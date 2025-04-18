Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Module modDb
    ' Original connection variables
    Public conn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public db_server As String = "localhost"
    Public db_uid As String = "root"
    Public db_pwd As String = ""
    Public db_name As String = "schooldb"
    Public strConnection As String = $"server={db_server};uid={db_uid};password={db_pwd};database={db_name};allowuservariables=True;"

    ' Add cmdRead for reading queries
    Public cmdRead As MySqlDataReader

    ' Structure for Logged User
    Public Structure LoggedUser
        Dim id As Integer
        Dim name As String
        Dim position As String
        Dim username As String
        Dim password As String
        Dim type As Integer
        Public studentOrInstructorID As String
    End Structure

    Public CurrentLoggedUser As LoggedUser = Nothing

    Public Sub UpdateUserType(role As String)
        Select Case role
            Case "Student"
                CurrentLoggedUser.type = 1
            Case "Instructor"
                CurrentLoggedUser.type = 2
            Case "Administrator"
                CurrentLoggedUser.type = 3
            Case Else
                MsgBox("Invalid role selected.", MsgBoxStyle.Critical)
        End Select
    End Sub

    ' Update connection string method
    Public Sub UpdateConnectionString()
        Try
            Dim config As String = Path.Combine(Directory.GetCurrentDirectory(), "config.txt")
            If File.Exists(config) Then
                Dim lines As String() = File.ReadAllLines(config)
                strConnection = $"server={lines(0).Split("=")(1)};uid={lines(1).Split("=")(1)};password={lines(2).Split("=")(1)};database={lines(3).Split("=")(1)};allowuservariables=True;"
            Else
                MsgBox("Config file does not exist.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' Open connection method
    Public Sub openConn(ByVal dbName As String)
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.ConnectionString = strConnection
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' Read query method
    Public Sub readQuery(ByVal sql As String)
        Try
            openConn(db_name)
            With cmd
                .Connection = conn
                .CommandText = sql
                cmdRead = .ExecuteReader
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' SQL script import functionality
    Public Sub ImportSQLFile(filePath As String)
        Try
            Dim script As String = File.ReadAllText(filePath)
            openConn(db_name)

            Dim commands As String() = script.Split(";"c)
            For Each command As String In commands
                If Not String.IsNullOrWhiteSpace(command) Then
                    Using sqlCommand As New MySqlCommand(command, conn)
                        sqlCommand.ExecuteNonQuery()
                    End Using
                End If
            Next

            MsgBox("SQL script imported successfully.")
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' Check if connected to local server
    Public Function isConnectedToLocalServer() As Boolean
        Dim result As Boolean = False
        Try
            conn.ConnectionString = strConnection
            conn.Open()
            If conn.State = ConnectionState.Open Then
                result = True
                conn.Close()
            End If
        Catch ex As Exception
            result = False
        End Try
        Return result
    End Function

    ' Load data to DataGridView
    Public Function LoadToDGV(ByVal query As String, ByVal dgv As DataGridView) As Integer
        Try
            readQuery(query)
            Dim dt As DataTable = New DataTable()
            Using adapter As New MySqlDataAdapter(query, conn)
                adapter.Fill(dt)
            End Using
            dgv.DataSource = dt
            dgv.Refresh()
            Return dgv.Rows.Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return 0
        End Try
    End Function

    ' Load data to DataGridView with column hiding
    Public Function LoadToDGVForDisplay(ByVal query As String, ByVal dgv As DataGridView) As Integer
        Try
            readQuery(query)
            Dim dt As DataTable = New DataTable()
            dt.Load(cmdRead)
            dgv.DataSource = dt
            dgv.Refresh()
            If dgv.ColumnCount > 1 Then
                dgv.Columns(0).Visible = False
            End If
            Return dgv.Rows.Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return 0
        End Try
    End Function

    ' Encrypt data
    Public Function Encrypt(ByVal clearText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, &H65, &H64, &H76, &H65, &H64, &H65, &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(clearBytes, 0, clearBytes.Length)
                    cs.Close()
                End Using
                clearText = Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
        Return clearText
    End Function

    ' Decrypt data
    Public Function Decrypt(ByVal cipherText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, &H65, &H64, &H76, &H65, &H64, &H65, &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                    cs.Write(cipherBytes, 0, cipherBytes.Length)
                    cs.Close()
                End Using
                cipherText = Encoding.Unicode.GetString(ms.ToArray())
            End Using
        End Using
        Return cipherText
    End Function

    ' Logging user actions
    Public Sub Logs(ByVal transaction As String, Optional ByVal events As String = "*_Click")
        Try
            readQuery($"INSERT INTO `logs`(`dt`, `user_id`, `event`, `transactions`) VALUES (now(), {CurrentLoggedUser.id}, '{events}', '{transaction}')")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' One time lang to gagamitin, para lang maencrypt, di kasi mawork sa login ung decrypt if di man nakaencrypt
    Public Sub EncryptAllPasswords()
        Dim selectQuery As String = "SELECT user_id, password FROM user_accounts"
        Dim updateQuery As String = "UPDATE user_accounts SET password = @EncryptedPassword WHERE user_id = @UserID"

        Try
            openConn("schooldb")

            ' Una, kukunin muna ung mga data
            Dim userList As New List(Of KeyValuePair(Of Integer, String))()
            Using selectCommand As New MySqlCommand(selectQuery, conn)
                Using reader As MySqlDataReader = selectCommand.ExecuteReader()
                    While reader.Read()
                        Dim userId As Integer = Convert.ToInt32(reader("user_id"))
                        Dim password As String = reader("password").ToString()
                        userList.Add(New KeyValuePair(Of Integer, String)(userId, password))
                    End While
                End Using
            End Using

            ' Then, ieencrypt isa isa
            For Each user In userList
                Dim encryptedPassword As String = Encrypt(user.Value)

                Using updateCommand As New MySqlCommand(updateQuery, conn)
                    updateCommand.Parameters.AddWithValue("@EncryptedPassword", encryptedPassword)
                    updateCommand.Parameters.AddWithValue("@UserID", user.Key)
                    updateCommand.ExecuteNonQuery()
                End Using
            Next

            MessageBox.Show("All passwords have been encrypted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As MySqlException
            MessageBox.Show("Error encrypting passwords: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            modDb.conn.Close()
        End Try
    End Sub

    ' Change checker
    Private Sub ListenForDatabaseChanges()
        Dim lastChecked As DateTime = DateTime.Now

        While True
            Dim sql As String = "SELECT * FROM your_table WHERE updated_at > @lastChecked"
            Try
                openConn("your_database")
                cmd.CommandText = sql
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@lastChecked", lastChecked)

                cmdRead = cmd.ExecuteReader()
                While cmdRead.Read()
                    MsgBox("Change detected: " & cmdRead("column_name").ToString())
                End While
                cmdRead.Close()

                lastChecked = DateTime.Now
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try

            Threading.Thread.Sleep(5000)
        End While
    End Sub


End Module
