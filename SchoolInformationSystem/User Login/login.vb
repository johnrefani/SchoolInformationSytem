Imports MySql.Data.MySqlClient

Public Class login
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        password.Multiline = False
        password.AutoSize = False
        password.Height = 40
        password.UseSystemPasswordChar = True
        hide.Visible = False
        show.Visible = True

    End Sub

    ' Event handler for login button click
    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        errorLabel.Text = ""

        ' Validation
        If String.IsNullOrWhiteSpace(username.Text) OrElse String.IsNullOrWhiteSpace(password.Text) Then
            errorLabel.Text = "Please enter both username and password."
            Return
        End If

        If role.SelectedIndex = -1 Then
            errorLabel.Text = "Please select a user type (Student/Instructor/Admin)."
            Return
        End If

        ' Get user inputs and ensure they're lowercase for case-insensitive matching
        Dim inputUsername As String = username.Text.Trim().ToLower()
        Dim inputPassword As String = password.Text.Trim().ToLower()
        Dim inputRole As String = role.SelectedItem.ToString().Trim().ToLower()

        ' Database connection
        Dim conn As MySqlConnection = strconnection()

        Try
            conn.Open()

            ' SQL query for case-insensitive username and role matching
            Dim query As String = "SELECT * FROM user WHERE LOWER(username) = @username AND LOWER(role) = @role"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", inputUsername)
            cmd.Parameters.AddWithValue("@role", inputRole)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Check if the user exists
            If reader.HasRows Then
                reader.Read()

                ' Check if the account is active
                If CInt(reader("is_active")) = 0 Then
                    errorLabel.Text = "This account is inactive."
                    Return
                End If


                If inputPassword = reader("password").ToString().ToLower() Then
                    ' Successful login
                    Me.Close()
                    Select Case inputRole
                        Case "admin"
                            adminframe.Show()
                        Case "student"
                            studentframe.Show()
                        Case "instructor"
                            instructorframe.Show()
                    End Select
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

    ' Event handler for Enter key press in the username field
    Private Sub username_KeyDown(sender As Object, e As KeyEventArgs) Handles username.KeyDown
        If e.KeyCode = Keys.Enter Then
            loginbtn.PerformClick()
        End If
    End Sub

    ' Event handler for Enter key press in the password field
    Private Sub password_KeyDown(sender As Object, e As KeyEventArgs) Handles password.KeyDown
        If e.KeyCode = Keys.Enter Then
            loginbtn.PerformClick()
        End If
    End Sub

    Private Sub login_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            loginbtn.PerformClick()
        End If
    End Sub
    ' Show password button
    Private Sub show_Click(sender As Object, e As EventArgs) Handles show.Click
        password.UseSystemPasswordChar = False
        show.Visible = False
        hide.Visible = True
    End Sub

    ' Hide password button
    Private Sub hide_Click(sender As Object, e As EventArgs) Handles hide.Click
        password.UseSystemPasswordChar = True
        hide.Visible = False
        show.Visible = True
    End Sub



End Class
