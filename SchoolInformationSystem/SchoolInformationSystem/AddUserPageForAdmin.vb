Imports MySql.Data.MySqlClient

Public Class AddUserPageForAdmin

    Private isPasswordVisible As Boolean = False

    Private Sub AddUserPageForAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
        SetDefaultId()
        Password_TextBox.PasswordChar = "•"c
        UserType_ComboBox.SelectedIndex = 0
        PictureBox1.Image = My.Resources.eye_closed
    End Sub

    ' Set the user id based on the user type
    Private Sub SetDefaultId()
        Dim query As String = ""
        If UserType_ComboBox.Text = "Student" Then
            query = "SELECT MAX(student_id) FROM student"
        ElseIf UserType_ComboBox.Text = "Instructor" Then
            query = "SELECT MAX(instructor_id) FROM instructor"
        Else
            UserID_TextBox.Text = ""
            Return
        End If

        Try
            modDb.openConn("schooldb")
            If modDb.conn.State <> ConnectionState.Open Then
                Throw New InvalidOperationException("Database connection failed to open.")
            End If

            Using command As New MySqlCommand(query, modDb.conn)
                Dim result = command.ExecuteScalar()
                Dim newId As Integer = If(IsDBNull(result), 1, Convert.ToInt32(result) + 1)
                UserID_TextBox.Text = newId.ToString() 'palitan nalang
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As InvalidOperationException
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Unexpected Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDb.conn IsNot Nothing AndAlso modDb.conn.State = ConnectionState.Open Then
                modDb.conn.Close()
            End If
        End Try
    End Sub


    ' Add user account
    Private Sub SaveUser_Button_Click(sender As Object, e As EventArgs) Handles SaveUser_Button.Click
        If String.IsNullOrWhiteSpace(Password_TextBox.Text) Then
            MessageBox.Show("Please enter your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim userType As Integer = If(UserType_ComboBox.Text = "Student", 1, 2)
        Dim query As String
        If userType = 1 Then
            query = "INSERT INTO user_accounts (student_id, password, user_type) VALUES (@UserId, @Password, @UserType)"
        Else
            query = "INSERT INTO user_accounts (instructor_id, password, user_type) VALUES (@UserId, @Password, @UserType)"
        End If




        modDb.openConn("schooldb")
        Try
            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.AddWithValue("@UserId", UserID_TextBox.Text)
                command.Parameters.AddWithValue("@Password", Encrypt(Password_TextBox.Text))
                command.Parameters.AddWithValue("@UserType", userType)
                command.ExecuteNonQuery()

                MessageBox.Show("User account added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearForm()
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            modDb.conn.Close()
        End Try
    End Sub

    Private Sub ClearForm()
        UserID_TextBox.Clear()
        Password_TextBox.Clear()
        UserType_ComboBox.SelectedIndex = -1
        SetDefaultId()
    End Sub

    ' visibility nung mata
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Password_TextBox.PasswordChar = "•"c Then
            Password_TextBox.PasswordChar = ControlChars.NullChar
            PictureBox1.Image = My.Resources.open_eye
        Else
            Password_TextBox.PasswordChar = "•"c
            PictureBox1.Image = My.Resources.eye_closed
        End If
    End Sub

    ' Para mabago ung id based dun sa combobox
    Private Sub UserType_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UserType_ComboBox.SelectedIndexChanged
        SetDefaultId()
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Dim adminPage As New AdminPage()
        adminPage.Show()
        Me.Close()
    End Sub
End Class
