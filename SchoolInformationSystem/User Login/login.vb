Imports MySql.Data.MySqlClient

Public Class login
    ' Declare connection string and connection object
    Dim connString As String = "Server=your_server;Database=school_information_db;Uid=your_user;Pwd=your_password;"
    Dim conn As New MySqlConnection(connString)

    ' Event handler for user selection change
    Private Sub userselect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles userselect.SelectedIndexChanged
        ' You can add logic here to handle the user selection if needed
    End Sub

    ' Event handler for username text change
    Private Sub username_TextChanged(sender As Object, e As EventArgs) Handles username.TextChanged
        ' You can add logic here if needed for username text change
    End Sub

    ' Event handler for password text change
    Private Sub password_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged
        ' You can add logic here if needed for password text change
    End Sub

    ' Event handler for login button click
    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        errorLabel.Text = "" ' Clear error label

        ' Validation
        If String.IsNullOrWhiteSpace(username.Text) OrElse String.IsNullOrWhiteSpace(password.Text) Then
            errorLabel.Text = "Please enter both username and password."
            Return
        End If

        If userselect.SelectedIndex = -1 Then
            errorLabel.Text = "Please select a user type (Student/Teacher)."
            Return
        End If

        Dim inputUsername As String = username.Text
        Dim inputPassword As String = password.Text
        Dim role As String = userselect.SelectedItem.ToString()

        Dim conn As MySqlConnection = strconnection()

        Try
            conn.Open()

            Dim query As String = "SELECT * FROM users WHERE Username = @username AND Role = @role"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", inputUsername)
            cmd.Parameters.AddWithValue("@role", role)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                If inputPassword = reader("PasswordHash").ToString() Then
                    ' Login success
                    Me.Hide()
                    If role.ToLower() = "admin" Then
                        adminframe.Show()
                    ElseIf role.ToLower() = "student" Then

                        student_frame.Show()

                    ElseIf role.ToLower() = "teacher" Then
                        teacherframe.Show()

                    End If
                Else
                    errorLabel.Text = "Invalid password. Please try again."
                End If
            Else
                errorLabel.Text = "User not found or role mismatch."
            End If

        Catch ex As Exception
            errorLabel.Text = "Connection error: " & ex.Message
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
