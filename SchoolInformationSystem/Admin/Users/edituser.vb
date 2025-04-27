Imports MySql.Data.MySqlClient

Public Class edituser
    ' Public property to receive the user ID
    Public Property UserId As Integer

    ' Default constructor (required for Windows Forms)
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub

    Private Sub edituser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Only load data if UserId has been set
        If UserId > 0 Then
            LoadUserData()
        Else
            MessageBox.Show("No user ID provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
    End Sub


    Private Sub LoadUserData()
        Using conn As MySqlConnection = strconnection()
            Try
                conn.Open()

                ' Get user data
                Dim query As String = "SELECT * FROM User WHERE user_id = @id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", UserId)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Auto-fill the form fields
                            id.Text = UserId.ToString()
                            username.Text = reader("username").ToString()
                            password.Text = reader("password").ToString()
                            fullname.Text = reader("full_name").ToString()
                            gender.Text = If(reader.IsDBNull(reader.GetOrdinal("gender")), "", reader("gender").ToString())
                            email.Text = If(reader.IsDBNull(reader.GetOrdinal("email")), "", reader("email").ToString())
                            contact.Text = If(reader.IsDBNull(reader.GetOrdinal("contact_number")), "", reader("contact_number").ToString())
                            idnum.Text = If(reader.IsDBNull(reader.GetOrdinal("id_number")), "", reader("id_number").ToString())
                            role.Text = reader("role").ToString()
                            address.Text = If(reader.IsDBNull(reader.GetOrdinal("address")), "", reader("address").ToString())
                            position.Text = If(reader.IsDBNull(reader.GetOrdinal("position")), "", reader("position").ToString())
                            office.Text = If(reader.IsDBNull(reader.GetOrdinal("assigned_office")), "", reader("assigned_office").ToString())
                            accesslevel.Text = If(reader.IsDBNull(reader.GetOrdinal("access_level")), "", reader("access_level").ToString())
                            active.Text = If(reader.IsDBNull(reader.GetOrdinal("is_active")), "", reader("is_active").ToString())
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading user data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub updatebutton_Click(sender As Object, e As EventArgs) Handles updatebutton.Click
        ' Validate required fields
        If String.IsNullOrWhiteSpace(username.Text) OrElse
           String.IsNullOrWhiteSpace(password.Text) OrElse
           String.IsNullOrWhiteSpace(fullname.Text) OrElse
           String.IsNullOrWhiteSpace(role.Text) Then
            MessageBox.Show("Please fill in all required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conn As MySqlConnection = strconnection()
                conn.Open()

                ' Update user table
                Dim userQuery As String = "UPDATE User SET " &
                                         "username = @username, " &
                                         "password = @password, " &
                                         "full_name = @fullname, " &
                                         "gender = @gender, " &
                                         "email = @email, " &
                                         "contact_number = @contact, " &
                                         "id_number = @idnum, " &
                                         "role = @role, " &
                                         "address = @address, " &
                                         "position = @position, " &
                                         "assigned_office = @office, " &
                                         "access_level = @accesslevel, " &
                                         "is_active = @active " &
                                         "WHERE user_id = @id"

                Using cmd As New MySqlCommand(userQuery, conn)
                    cmd.Parameters.AddWithValue("@id", UserId)
                    cmd.Parameters.AddWithValue("@username", username.Text)
                    cmd.Parameters.AddWithValue("@password", password.Text) ' Consider hashing the password
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

                    Dim rowsAffected = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        ' Now update role-specific table
                        If role.Text = "Student" Then
                            UpdateStudent(conn)
                        ElseIf role.Text = "Instructor" Then
                            UpdateInstructor(conn)
                        End If

                        MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    Else
                        MessageBox.Show("No changes were made to the user.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateStudent(conn As MySqlConnection)
        ' Check if student record exists
        Dim checkQuery As String = "SELECT COUNT(*) FROM student WHERE student_id = @userId"
        Using checkCmd As New MySqlCommand(checkQuery, conn)
            checkCmd.Parameters.AddWithValue("@userId", UserId)
            Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If exists > 0 Then
                ' Update existing student record
                Dim updateQuery As String = "UPDATE student SET " &
                                           "first_name = @firstName, " &
                                           "gender = @gender, " &
                                           "address = @address, " &
                                           "contact_number = @contact, " &
                                           "email = @email " &
                                           "WHERE student_id = @userId"

                Using cmd As New MySqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@userId", UserId)
                    cmd.Parameters.AddWithValue("@firstName", fullname.Text)
                    cmd.Parameters.AddWithValue("@gender", If(String.IsNullOrEmpty(gender.Text), DBNull.Value, gender.Text))
                    cmd.Parameters.AddWithValue("@address", If(String.IsNullOrEmpty(address.Text), DBNull.Value, address.Text))
                    cmd.Parameters.AddWithValue("@contact", If(String.IsNullOrEmpty(contact.Text), DBNull.Value, contact.Text))
                    cmd.Parameters.AddWithValue("@email", If(String.IsNullOrEmpty(email.Text), DBNull.Value, email.Text))

                    cmd.ExecuteNonQuery()
                End Using
            Else
                ' Insert new student record
                Dim insertQuery As String = "INSERT INTO student (student_id, first_name, gender, address, contact_number, email) " &
                                           "VALUES (@userId, @firstName, @gender, @address, @contact, @email)"

                Using cmd As New MySqlCommand(insertQuery, conn)
                    cmd.Parameters.AddWithValue("@userId", UserId)
                    cmd.Parameters.AddWithValue("@firstName", fullname.Text)
                    cmd.Parameters.AddWithValue("@gender", If(String.IsNullOrEmpty(gender.Text), DBNull.Value, gender.Text))
                    cmd.Parameters.AddWithValue("@address", If(String.IsNullOrEmpty(address.Text), DBNull.Value, address.Text))
                    cmd.Parameters.AddWithValue("@contact", If(String.IsNullOrEmpty(contact.Text), DBNull.Value, contact.Text))
                    cmd.Parameters.AddWithValue("@email", If(String.IsNullOrEmpty(email.Text), DBNull.Value, email.Text))

                    cmd.ExecuteNonQuery()
                End Using
            End If
        End Using
    End Sub

    Private Sub UpdateInstructor(conn As MySqlConnection)
        ' Check if instructor record exists
        Dim checkQuery As String = "SELECT COUNT(*) FROM instructor WHERE instructor_id = @userId"
        Using checkCmd As New MySqlCommand(checkQuery, conn)
            checkCmd.Parameters.AddWithValue("@userId", UserId)
            Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If exists > 0 Then
                ' Update existing instructor record
                Dim updateQuery As String = "UPDATE instructor SET " &
                                           "first_name = @firstName, " &
                                           "gender = @gender, " &
                                           "address = @address, " &
                                           "contact_number = @contact, " &
                                           "email = @email " &
                                           "WHERE instructor_id = @userId"

                Using cmd As New MySqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@userId", UserId)
                    cmd.Parameters.AddWithValue("@firstName", fullname.Text)
                    cmd.Parameters.AddWithValue("@gender", If(String.IsNullOrEmpty(gender.Text), DBNull.Value, gender.Text))
                    cmd.Parameters.AddWithValue("@address", If(String.IsNullOrEmpty(address.Text), DBNull.Value, address.Text))
                    cmd.Parameters.AddWithValue("@contact", If(String.IsNullOrEmpty(contact.Text), DBNull.Value, contact.Text))
                    cmd.Parameters.AddWithValue("@email", If(String.IsNullOrEmpty(email.Text), DBNull.Value, email.Text))

                    cmd.ExecuteNonQuery()
                End Using
            Else
                ' Insert new instructor record
                Dim insertQuery As String = "INSERT INTO instructor (instructor_id, first_name, gender, address, contact_number, email) " &
                                           "VALUES (@userId, @firstName, @gender, @address, @contact, @email)"

                Using cmd As New MySqlCommand(insertQuery, conn)
                    cmd.Parameters.AddWithValue("@userId", UserId)
                    cmd.Parameters.AddWithValue("@firstName", fullname.Text)
                    cmd.Parameters.AddWithValue("@gender", If(String.IsNullOrEmpty(gender.Text), DBNull.Value, gender.Text))
                    cmd.Parameters.AddWithValue("@address", If(String.IsNullOrEmpty(address.Text), DBNull.Value, address.Text))
                    cmd.Parameters.AddWithValue("@contact", If(String.IsNullOrEmpty(contact.Text), DBNull.Value, contact.Text))
                    cmd.Parameters.AddWithValue("@email", If(String.IsNullOrEmpty(email.Text), DBNull.Value, email.Text))

                    cmd.ExecuteNonQuery()
                End Using
            End If
        End Using
    End Sub

    Private Sub cancelbutton_Click(sender As Object, e As EventArgs) Handles cancelbutton.Click
        Me.Close()
    End Sub
End Class