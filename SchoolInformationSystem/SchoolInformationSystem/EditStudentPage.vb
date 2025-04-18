Imports MySql.Data.MySqlClient
Public Class EditStudentPage
    Private student_gender_TextBox As Object
    ' Property to hold the Student ID passed from the Student List form
    Public Property StudentID As String
    ' Form Load event to populate fields with the selected student’s data
    Private Sub EditStudentPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modDb.openConn(“schooldb”)
        Dim query As String = “SELECT * FROM student_info WHERE student_id = @StudentID”
        Try
            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.AddWithValue(“@StudentID”, StudentID)
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    ' Populate text fields with data
                    student_studentid_TextBox.Text = reader(“student_id”).ToString()
                    student_lastname_TextBox.Text = reader(“last_name”).ToString()
                    student_firstname_TextBox.Text = reader(“first_name”).ToString()
                    student_middlename_TextBox.Text = reader(“middlename”).ToString()
                    student_birthdate_TextBox.Text = reader(“birthdate”).ToString()
                    'student_gender_TextBox.Text = reader(“gender”).ToString()
                    student_street_TextBox.Text = reader(“street”).ToString()
                    student_barangay_TextBox.Text = reader(“barangay”).ToString()
                    student_municipality_TextBox.Text = reader(“municipality”).ToString()
                    student_province_TextBox.Text = reader(“province”).ToString()
                    student_postalcode_TextBox.Text = reader(“postal_code”).ToString()
                    student_contact_TextBox.Text = reader(“contact_number”).ToString()
                    student_email_TextBox.Text = reader(“email”).ToString()
                    student_enrolmentdate_TextBox.Text = reader(“enrolment_date”).ToString()
                    student_yl_TextBox.Text = reader(“current_year”).ToString()
                End If
            End Using
        Catch ex As MySqlException
            MessageBox.Show(“An error occurred: “ & ex.Message, “Database Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            modDb.conn.Close()
        End Try
    End Sub
    ' Save Button event to update the student’s information
    Private Sub editstudent_save_Button_Click(sender As Object, e As EventArgs) Handles editstudent_save_Button.Click
        openConn(“schooldb”)
        Dim query = “UPDATE student_info SET first_name = @FirstName, last_name = @LastName, gender = @Gender, middlename = @MiddleName, birthdate = @BirthDate, street = @Street, barangay = @Barangay, municipality = @Municipality, province = @Province, postal_code = @PostalCode, contact_number = @ContactNumber, email = @Email, enrolment_date = @EnrolmentDate, current_year = @CurrentYear WHERE student_id = @StudentID”
        Try
            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue(“@StudentID”, student_studentid_TextBox.Text)
                command.Parameters.AddWithValue(“@LastName”, student_lastname_TextBox.Text)
                command.Parameters.AddWithValue(“@FirstName”, student_firstname_TextBox.Text)
                command.Parameters.AddWithValue(“@MiddleName”, student_middlename_TextBox.Text)
                command.Parameters.AddWithValue(“@BirthDate”, Date.Parse(student_birthdate_TextBox.Text))
                'command.Parameters.AddWithValue(“@Gender”, student_gender_TextBox.Text)
                command.Parameters.AddWithValue(“@Street”, student_street_TextBox.Text)
                command.Parameters.AddWithValue(“@Barangay”, student_barangay_TextBox.Text)
                command.Parameters.AddWithValue(“@Municipality”, student_municipality_TextBox.Text)
                command.Parameters.AddWithValue(“@Province”, student_province_TextBox.Text)
                command.Parameters.AddWithValue(“@PostalCode”, student_postalcode_TextBox.Text)
                command.Parameters.AddWithValue(“@ContactNumber”, student_contact_TextBox.Text)
                command.Parameters.AddWithValue(“@Email”, student_email_TextBox.Text)
                command.Parameters.AddWithValue(“@EnrolmentDate”, Date.Parse(student_enrolmentdate_TextBox.Text))
                command.Parameters.AddWithValue(“@CurrentYear”, student_yl_TextBox.Text)
                command.ExecuteNonQuery()
                MessageBox.Show(“Student details updated successfully!”, “Success”, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As MySqlException
            MessageBox.Show(“An error occurred: “ & ex.Message, “Database Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
        ' Navigate back to the Student List form
        Dim mainForm As New StudentList
        mainForm.Show()
        Close()
    End Sub
    ' Cancel Button event to return to the Student List without saving
    Private Sub editstudent_cancel_Button_Click(sender As Object, e As EventArgs) Handles editstudent_cancel_Button.Click
        Dim mainForm As New StudentList
        mainForm.Show()
        Close()
    End Sub

    Private Sub student_yl_Label_Click(sender As Object, e As EventArgs) Handles student_yl_Label.Click

    End Sub

    Private Sub student_sex_Label_Click(sender As Object, e As EventArgs) Handles student_sex_Label.Click

    End Sub

    Private Sub student_middlename_TextBox_TextChanged(sender As Object, e As EventArgs) Handles student_middlename_TextBox.TextChanged

    End Sub

    Private Sub student_firstname_TextBox_TextChanged(sender As Object, e As EventArgs) Handles student_firstname_TextBox.TextChanged

    End Sub

    Private Sub student_address_Label_Click(sender As Object, e As EventArgs) Handles student_address_Label.Click

    End Sub

    Private Sub student_contact_TextBox_TextChanged(sender As Object, e As EventArgs) Handles student_contact_TextBox.TextChanged

    End Sub

    Private Sub student_province_TextBox_TextChanged(sender As Object, e As EventArgs) Handles student_province_TextBox.TextChanged

    End Sub
End Class