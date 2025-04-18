Imports MySql.Data.MySqlClient

Public Class AdminAccountCreation

    Private Property IsPasswordVisible As Boolean = False

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Dim username As String = UsernameTextBox.Text.Trim()
        Dim password As String = PasswordTextBox.Text

        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MsgBox("All fields are required.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            Dim encryptedPassword As String = Encrypt(password)
            openConn(db_name)
            Dim sql As String = "INSERT INTO user_accounts (username, password, user_type) VALUES (@username, @password, @userType)"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.CommandText = sql
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", encryptedPassword)
            cmd.Parameters.AddWithValue("@userType", 3)

            cmd.ExecuteNonQuery()

            MsgBox("Admin account created successfully!", MsgBoxStyle.Information)
            Logs("Admin account created successfully!")
            Dim loginAgain As New LoginPage()
            Me.Close()
            loginAgain.Show()
        Catch ex As Exception
            MsgBox("An error occurred when creating the account: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub


    Private Sub AdminAccountCreation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PasswordTextBox.PasswordChar = "●"c
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If IsPasswordVisible Then
            PasswordTextBox.PasswordChar = "●"c
            PictureBox1.Image = My.Resources.eye_closed
        Else
            PasswordTextBox.PasswordChar = ControlChars.NullChar
            PictureBox1.Image = My.Resources.open_eye
        End If

        IsPasswordVisible = Not IsPasswordVisible
    End Sub
End Class
