Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class LoginPage

    Private Property usertype As Integer = Nothing

    Private isPasswordVisible As Boolean = False
    Private Sub LoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateConnectionString()
        serverConfig_Label.Visible = False
        password_TextBox.PasswordChar = "●"c
        usertype_ComboBox.SelectedIndex = 0
    End Sub

    Public Sub CenterElement(ctrl As Control)
        ' Igigitna ung element sa form
        ctrl.Left = (Me.ClientSize.Width - ctrl.Width) \ 2
        ctrl.Top = (Me.ClientSize.Height - ctrl.Height) \ 2
    End Sub

    Private Sub login_Button_Click(sender As Object, e As EventArgs) Handles login_Button.Click
        If IsAdminAccountMissing() Then
            Dim dashboard As New AdminPage
            Hide()
            dashboard.Show()
        Else
            If CheckLogin() Then
                Select Case CurrentLoggedUser.type
                    Case 1
                        Dim studentDashboard As New StudentProfileforStudent
                        Hide()
                        studentDashboard.Show()
                    Case 2
                        Dim instructorDashboard As New InstructorProfile
                        Hide()
                        instructorDashboard.Show()
                    Case 3
                        Dim adminDashboard As New AdminPage
                        Hide()
                        adminDashboard.Show()
                End Select
            End If
        End If
    End Sub


    Public Function IsAdminAccountMissing() As Boolean
        Dim query As String = "SELECT COUNT(*) FROM user_accounts WHERE student_id IS NULL AND instructor_id IS NULL"

        Try
            modDb.openConn("schooldb")
            Using command As New MySqlCommand(query, modDb.conn)
                Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return result = 0
            End Using
        Catch ex As Exception
            MsgBox("Error checking admin account: " & ex.Message, MsgBoxStyle.Critical)
            Return False
        Finally
            If modDb.conn IsNot Nothing AndAlso modDb.conn.State = ConnectionState.Open Then
                modDb.conn.Close()
            End If
        End Try
    End Function



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If isPasswordVisible Then
            password_TextBox.PasswordChar = "●"c
            PictureBox1.Image = My.Resources.eye_closed
        Else
            password_TextBox.PasswordChar = ControlChars.NullChar
            PictureBox1.Image = My.Resources.open_eye
        End If

        isPasswordVisible = Not isPasswordVisible
    End Sub

    Private Sub usertype_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles usertype_ComboBox.SelectedIndexChanged
        modDb.UpdateUserType(usertype_ComboBox.SelectedItem.ToString())
        Select Case usertype_ComboBox.SelectedItem.ToString()
            Case "Student"
                usertype = 1
                serverConfig_Label.Visible = False
            Case "Instructor"
                usertype = 2
                serverConfig_Label.Visible = False
            Case "Administrator"
                usertype = 3
                serverConfig_Label.Visible = True
        End Select
    End Sub

    Private Function CheckLogin() As Boolean
        Dim enteredID As String = idnumber_TextBox.Text
        Dim enteredPassword As String = Encrypt(password_TextBox.Text)
        Dim selectedUserType As Integer = usertype

        ' SQL query to check if the user exists based on their user id and password
        Dim sql As String = "SELECT user_id, username, user_type, student_id, instructor_id FROM user_accounts 
                         WHERE 
                         (student_id = @id OR instructor_id = @id OR (student_id IS NULL AND instructor_id IS NULL AND username = @id)) 
                         AND password = @password
                         AND user_type = @usertype"

        Try
            modDb.openConn("schooldb")

            Using command As New MySqlCommand(sql, modDb.conn)
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@id", enteredID)
                command.Parameters.AddWithValue("@password", enteredPassword)
                command.Parameters.AddWithValue("@usertype", selectedUserType)

                cmdRead = command.ExecuteReader()

                If cmdRead.HasRows Then
                    cmdRead.Read()
                    CurrentLoggedUser.id = If(IsDBNull(cmdRead("user_id")), String.Empty, cmdRead("user_id").ToString())
                    CurrentLoggedUser.username = If(IsDBNull(cmdRead("username")), String.Empty, cmdRead("username").ToString())
                    CurrentLoggedUser.type = If(IsDBNull(cmdRead("user_type")), String.Empty, cmdRead("user_type").ToString())

                    If Not IsDBNull(cmdRead("student_id")) AndAlso cmdRead("student_id").ToString() = enteredID Then
                        CurrentLoggedUser.id = cmdRead("user_id").ToString()
                        CurrentLoggedUser.studentOrInstructorID = cmdRead("student_id").ToString()
                        cmdRead.Close()
                        GetFullName("student_info", "student_id", enteredID)
                    ElseIf Not IsDBNull(cmdRead("instructor_id")) AndAlso cmdRead("instructor_id").ToString() = enteredID Then
                        CurrentLoggedUser.id = cmdRead("user_id").ToString()
                        CurrentLoggedUser.studentOrInstructorID = cmdRead("instructor_id").ToString()

                        cmdRead.Close()
                        GetFullName("instructor_info", "instructor_id", enteredID)
                    Else
                        CurrentLoggedUser.id = If(IsDBNull(cmdRead("user_id")), Nothing, cmdRead("user_id").ToString())
                        CurrentLoggedUser.name = CurrentLoggedUser.username
                    End If

                    Logs("User logged in successfully.")
                    MsgBox("Login successful!", MsgBoxStyle.Information)
                    cmdRead.Close()
                    Return True
                Else
                    cmdRead.Close()
                    MsgBox("No user found with this ID and password. Please enter valid credentials.", MsgBoxStyle.Critical)
                    Return False
                End If
            End Using
        Catch ex As Exception
            MsgBox("An error occurred when trying to login: " & ex.Message, MsgBoxStyle.Critical)
            Return False
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function


    Private Sub GetFullName(tableName As String, idColumn As String, enteredID As String)
        Try
            Dim fullNameSql As String = $"SELECT first_name, middlename, last_name, suffix FROM {tableName} WHERE {idColumn} = @id"
            Dim cmd As New MySqlCommand(fullNameSql, conn)
            cmd.Parameters.AddWithValue("@id", enteredID)
            cmdRead = cmd.ExecuteReader()

            If cmdRead.HasRows Then
                cmdRead.Read()
                Dim firstName As String = cmdRead("first_name").ToString()
                Dim middleName As String = cmdRead("middlename").ToString()
                Dim lastName As String = cmdRead("last_name").ToString()
                Dim suffix As String = cmdRead("suffix").ToString()

                CurrentLoggedUser.name = $"{firstName} {middleName} {lastName}".Trim()
                If Not String.IsNullOrEmpty(suffix) Then
                    CurrentLoggedUser.name &= $" {suffix}"
                End If
            Else
                MsgBox("Could not retrieve user details. Please try again.", MsgBoxStyle.Critical)
            End If
            cmdRead.Close()
        Catch ex As Exception
            MsgBox("An error occurred while getting the full name: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub serverConfig_Label_Click(sender As Object, e As EventArgs) Handles serverConfig_Label.Click
        Dim newConfig As New ConfigSettings()
        newConfig.Show()
    End Sub
End Class