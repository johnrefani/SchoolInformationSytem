Imports MySql.Data.MySqlClient

Public Class login
    ' Declare connection string and connection object
    Dim connString As String = "Server=your_server;Database=school_information_db;Uid=your_user;Pwd=your_password;"
    Dim conn As New MySqlConnection(connString)

    ' Event handler for login button click
    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        errorLabel.Text = "" ' Clear error label

        ' Validation
        If String.IsNullOrWhiteSpace(username.Text) OrElse String.IsNullOrWhiteSpace(password.Text) Then
            errorLabel.Text = "Please enter both username and password."
            Return
        End If

        If Me.role.SelectedIndex = -1 Then
            errorLabel.Text = "Please select a user type (Student/Teacher)."
            Return
        End If

        Dim inputUsername As String = username.Text
        Dim inputPassword As String = password.Text
        Dim role As String = Me.role.SelectedItem.ToString()

        Dim conn As MySqlConnection = strconnection()

        Try
            conn.Open()

            Dim query As String = "SELECT * FROM user WHERE username = @username AND role = @role"
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

                        studentframe.Show()

                    ElseIf role.ToLower() = "instructor" Then
                        instructorframe.Show()

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

End Class
