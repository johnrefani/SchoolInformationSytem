Imports MySql.Data.MySqlClient

Public Class adduser
    Private Sub adduser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' You can initialize any form controls here if needed
    End Sub

    Private Sub savebutton_Click(sender As Object, e As EventArgs) Handles savebutton.Click
        ' Validate required fields
        If String.IsNullOrWhiteSpace(username.Text) OrElse
           String.IsNullOrWhiteSpace(password.Text) OrElse
           String.IsNullOrWhiteSpace(fullname.Text) OrElse
           String.IsNullOrWhiteSpace(role.Text) Then
            MessageBox.Show("Please fill in all required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            ' First, add to user table
            Using conn As MySqlConnection = strconnection()
                conn.Open()

                ' Insert into user table
                Dim userQuery As String = "INSERT INTO user (username, password, full_name, gender, email, contact_number, id_number, role, address, position, assigned_office, access_level, is_active) " &
                                         "VALUES (@username, @password, @fullname, @gender, @email, @contact, @idnum, @role, @address, @position, @office, @accesslevel, @active)"

                Using cmd As New MySqlCommand(userQuery, conn)
                    cmd.Parameters.AddWithValue("@username", username.Text)
                    cmd.Parameters.AddWithValue("@password", password.Text)
                    cmd.Parameters.AddWithValue("@fullname", fullname.Text)
                    cmd.Parameters.AddWithValue("@gender", If(String.IsNullOrEmpty(gender.Text), DBNull.Value, gender.Text))
                    cmd.Parameters.AddWithValue("@email", If(String.IsNullOrEmpty(email.Text), DBNull.Value, email.Text))
                    cmd.Parameters.AddWithValue("@contact", If(String.IsNullOrEmpty(contact.Text), DBNull.Value, contact.Text))
                    cmd.Parameters.AddWithValue("@idnum", If(String.IsNullOrEmpty(idnum.Text), DBNull.Value, idnum.Text))
                    cmd.Parameters.AddWithValue("@role", role.Text)
                    cmd.Parameters.AddWithValue("@address", If(String.IsNullOrEmpty(address.Text), DBNull.Value, address.Text))
                    cmd.Parameters.AddWithValue("@position", If(String.IsNullOrEmpty(position.Text), DBNull.Value, position.Text))
                    cmd.Parameters.AddWithValue("@office", If(String.IsNullOrEmpty(office.Text), DBNull.Value, office.Text))
                    cmd.Parameters.AddWithValue("@accesslevel", If(String.IsNullOrEmpty(accesslevel.Text), DBNull.Value, accesslevel.Text))
                    cmd.Parameters.AddWithValue("@active", If(String.IsNullOrEmpty(active.Text), DBNull.Value, active.Text))

                    cmd.ExecuteNonQuery()

                    ' Get the last inserted ID (assuming user table has auto-increment ID)
                    Dim lastInsertId As Integer = Convert.ToInt32(cmd.LastInsertedId)

                    ' Now insert into role-specific table
                    If role.Text = "Student" Then
                        InsertStudent(conn, lastInsertId)
                    ElseIf role.Text = "Instructor" Then
                        InsertInstructor(conn, lastInsertId)
                    End If
                End Using

                MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearForm()
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub InsertStudent(conn As MySqlConnection, userId As Integer)
        Dim studentQuery As String = "INSERT INTO student (first_name, gender, address, contact_number, email) " &
                                    "VALUES (@firstName, @gender, @address, @contact, @email)"

        Using cmd As New MySqlCommand(studentQuery, conn)
            cmd.Parameters.AddWithValue("@firstName", fullname.Text)
            cmd.Parameters.AddWithValue("@gender", If(String.IsNullOrEmpty(gender.Text), DBNull.Value, gender.Text))
            cmd.Parameters.AddWithValue("@address", If(String.IsNullOrEmpty(address.Text), DBNull.Value, address.Text))
            cmd.Parameters.AddWithValue("@contact", If(String.IsNullOrEmpty(contact.Text), DBNull.Value, contact.Text))
            cmd.Parameters.AddWithValue("@email", If(String.IsNullOrEmpty(email.Text), DBNull.Value, email.Text))

            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub InsertInstructor(conn As MySqlConnection, userId As Integer)
        Dim instructorQuery As String = "INSERT INTO instructor (first_name, gender, address, contact_number, email) " &
                                       "VALUES (@firstName, @gender, @address, @contact, @email)"

        Using cmd As New MySqlCommand(instructorQuery, conn)
            cmd.Parameters.AddWithValue("@firstName", fullname.Text)
            cmd.Parameters.AddWithValue("@gender", If(String.IsNullOrEmpty(gender.Text), DBNull.Value, gender.Text))
            cmd.Parameters.AddWithValue("@address", If(String.IsNullOrEmpty(address.Text), DBNull.Value, address.Text))
            cmd.Parameters.AddWithValue("@contact", If(String.IsNullOrEmpty(contact.Text), DBNull.Value, contact.Text))
            cmd.Parameters.AddWithValue("@email", If(String.IsNullOrEmpty(email.Text), DBNull.Value, email.Text))

            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub ClearForm()
        username.Text = ""
        password.Text = ""
        fullname.Text = ""
        gender.Text = ""
        email.Text = ""
        contact.Text = ""
        idnum.Text = ""
        role.Text = ""
        address.Text = ""
        position.Text = ""
        office.Text = ""
        accesslevel.Text = ""
        active.Text = ""
    End Sub
End Class
