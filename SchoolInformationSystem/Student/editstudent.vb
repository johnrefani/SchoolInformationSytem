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

        ' Split the full name into first name, middle initial, and last name
        Dim fullNameParts As String() = studentedit_fullname.Text.Trim().Split(" "c)

        Dim firstName As String = ""
        Dim middleInitial As String = ""
        Dim lastName As String = ""

        If fullNameParts.Length >= 3 Then
            firstName = fullNameParts(0)
            middleInitial = fullNameParts(1).Replace(".", "") ' Remove the dot if user typed it
            lastName = fullNameParts(2)
        Else
            MessageBox.Show("Please enter full name in 'Firstname M. Lastname' format.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim conn As MySqlConnection = strconnection()

        Try
            conn.Open()
            Dim query As String = "UPDATE student SET 
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

            Dim cmd As New MySqlCommand(query, conn)

            ' Parameters
            cmd.Parameters.AddWithValue("@firstName", firstName)
            cmd.Parameters.AddWithValue("@middleInitial", middleInitial)
            cmd.Parameters.AddWithValue("@lastName", lastName)
            cmd.Parameters.AddWithValue("@gender", studentedit_gender.Text)
            cmd.Parameters.AddWithValue("@address", studentedit_address.Text)
            cmd.Parameters.AddWithValue("@contact", studentedit_contact.Text)
            cmd.Parameters.AddWithValue("@email", studentedit_email.Text)
            cmd.Parameters.AddWithValue("@age", studentedit_age.Text)
            cmd.Parameters.AddWithValue("@birthPlace", studentedit_birthplace.Text)
            cmd.Parameters.AddWithValue("@nationality", studentedit_nationality.Text)
            cmd.Parameters.AddWithValue("@religion", studentedit_religion.Text)
            cmd.Parameters.AddWithValue("@gradeLevel", studentedit_grade.Text)
            cmd.Parameters.AddWithValue("@guardianName", studentedit_guardian.Text)
            cmd.Parameters.AddWithValue("@studentId", studentId)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Student profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No changes were made.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

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