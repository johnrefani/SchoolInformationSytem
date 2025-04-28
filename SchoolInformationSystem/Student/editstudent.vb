Imports MySql.Data.MySqlClient

Public Class editstudent

    Private Sub LoadStudentProfile()
        Dim studentId As String = GlobalStudentId ' Retrieve the stored studentId from the global variable

        ' Use studentId to query the student data from your database
        Dim conn As MySqlConnection = strconnection()

        Try
            conn.Open()
            Dim query As String = "SELECT * FROM student WHERE student_id = @studentId"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@studentId", studentId)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                ' Display student information on the profile panel
                studentedit_fullname.Text = reader("first_name").ToString() & " " & reader("middle_initial").ToString() & ". " & reader("last_name").ToString()
                studentedit_email.Text = reader("email").ToString()
                studentedit_contact.Text = reader("contact_number").ToString()
                studentedit_address.Text = reader("address").ToString()
                studentedit_gender.Text = reader("gender").ToString()
                studentedit_age.Text = reader("age").ToString()
                studentedit_grade.Text = reader("grade_level").ToString()
                studentedit_birthplace.Text = reader("birth_place").ToString()
                studentedit_nationality.Text = reader("nationality").ToString()
                studentedit_guardian.Text = reader("guardian_name").ToString()
                studentedit_religion.Text = reader("religion").ToString()



                ' Other profile fields can be added here
            Else
                MessageBox.Show("Student profile not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading profile data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub SaveStudentProfile()
        Dim studentId As String = GlobalStudentId ' Use the global variable for the ID

        ' Split the full name into parts
        Dim fullNameParts As String() = studentedit_fullname.Text.Trim().Split(" "c)

        Dim firstName As String = ""
        Dim middleInitial As String = ""
        Dim lastName As String = ""

        If fullNameParts.Length >= 3 Then
            firstName = fullNameParts(0)
            middleInitial = fullNameParts(1).Replace(".", "") ' Remove dot if any
            lastName = fullNameParts(2)
        Else
            MessageBox.Show("Please enter full name in 'Firstname M. Lastname' format.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Prepare full name
        Dim fullName As String = $"{firstName} {middleInitial}. {lastName}"

        Dim conn As MySqlConnection = strconnection()

        Try
            conn.Open()

            ' Update Student table
            Dim updateStudentQuery As String = "UPDATE student SET 
                                first_name = @firstName,
                                middle_initial = @middleInitial,
                                last_name = @lastName,
                                gender = @gender,
                                address = @address,
                                contact_number = @contact,
                                email = @email,
                                age = @age,
                                birth_place = @birthPlace,
                                nationality = @nationality,
                                religion = @religion,
                                grade_level = @gradeLevel,
                                guardian_name = @guardianName
                            WHERE student_id = @studentId"

            Using studentCmd As New MySqlCommand(updateStudentQuery, conn)
                studentCmd.Parameters.AddWithValue("@firstName", firstName)
                studentCmd.Parameters.AddWithValue("@middleInitial", middleInitial)
                studentCmd.Parameters.AddWithValue("@lastName", lastName)
                studentCmd.Parameters.AddWithValue("@gender", studentedit_gender.Text)
                studentCmd.Parameters.AddWithValue("@address", studentedit_address.Text)
                studentCmd.Parameters.AddWithValue("@contact", studentedit_contact.Text)
                studentCmd.Parameters.AddWithValue("@email", studentedit_email.Text)
                studentCmd.Parameters.AddWithValue("@age", studentedit_age.Text)
                studentCmd.Parameters.AddWithValue("@birthPlace", studentedit_birthplace.Text)
                studentCmd.Parameters.AddWithValue("@nationality", studentedit_nationality.Text)
                studentCmd.Parameters.AddWithValue("@religion", studentedit_religion.Text)
                studentCmd.Parameters.AddWithValue("@gradeLevel", studentedit_grade.Text)
                studentCmd.Parameters.AddWithValue("@guardianName", studentedit_guardian.Text)
                studentCmd.Parameters.AddWithValue("@studentId", studentId)

                studentCmd.ExecuteNonQuery()
            End Using

            ' Update User table (using id_number which is the same as student_id)
            Dim updateUserQuery As String = "UPDATE user SET 
                                         full_name = @fullName
                                         WHERE user_id = @studentId"

            Using userCmd As New MySqlCommand(updateUserQuery, conn)
                userCmd.Parameters.AddWithValue("@fullName", fullName)
                userCmd.Parameters.AddWithValue("@studentId", studentId)

                Dim affectedRows As Integer = userCmd.ExecuteNonQuery()

                If affectedRows > 0 Then
                    MessageBox.Show("Student profile and user full name updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Student profile updated, but no matching user found to update.", "Partial Update", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error saving profile: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub



    Private Sub editstudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudentProfile()

    End Sub

    Private Sub savebutton_Click(sender As Object, e As EventArgs) Handles savebutton.Click
        SaveStudentProfile()
        Me.Close()
        studentframe.Show()
    End Sub

    Private Sub cancelbutton_Click(sender As Object, e As EventArgs) Handles cancelbutton.Click
        Me.Close()
        studentframe.Show()

    End Sub
End Class