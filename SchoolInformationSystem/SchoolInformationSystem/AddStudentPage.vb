Imports MySql.Data.MySqlClient
Public Class AddStudentPage
    Private Sub block_add_Button_Click(sender As Object, e As EventArgs) Handles block_add_Button.Click
        AddStudent()
    End Sub
    Private Sub AddStudent()
        If String.IsNullOrWhiteSpace(student_lastname_TextBox.Text) OrElse
        String.IsNullOrWhiteSpace(student_firstname_TextBox.Text) OrElse
        String.IsNullOrWhiteSpace(student_middlename_TextBox.Text) OrElse
        String.IsNullOrWhiteSpace(student_enrolmentdate_TextBox.Text) OrElse
        String.IsNullOrWhiteSpace(student_birthdate_TextBox.Text) OrElse
        String.IsNullOrWhiteSpace(student_gender_TextBox.Text) OrElse
        String.IsNullOrWhiteSpace(student_street_TextBox.Text) OrElse
        String.IsNullOrWhiteSpace(student_barangay_TextBox.Text) OrElse
        String.IsNullOrWhiteSpace(student_municipality_TextBox.Text) OrElse
        String.IsNullOrWhiteSpace(student_province_TextBox.Text) OrElse
        String.IsNullOrWhiteSpace(student_postalcode_TextBox.Text) OrElse
        String.IsNullOrWhiteSpace(student_contact_TextBox.Text) OrElse
        String.IsNullOrWhiteSpace(student_email_TextBox.Text) OrElse
        String.IsNullOrWhiteSpace(student_studentid_TextBox.Text) OrElse
        String.IsNullOrWhiteSpace(student_yl_TextBox.Text) Then
            MessageBox.Show(“Please fill in all required fields.”)
            Return
        End If
        modDb.openConn(“schooldb”)
        Dim query As String = “INSERT INTO student_info (student_id, last_name, first_name, middlename, birthdate, gender, street, barangay, municipality, province, postal_code, contact_number, email, enrolment_date, current_year) “ &
        “VALUES (@StudentID, @LastName, @FirstName, @MiddleName, @BirthDate, @Gender, @Street, @Barangay, @Municipality, @Province, @PostalCode, @ContactNumber, @Email, @EnrolmentDate, @CurrentYear)”
        Using command As New MySqlCommand(query, modDb.conn)
            command.Parameters.AddWithValue(“@StudentID”, student_studentid_TextBox.Text)
            command.Parameters.AddWithValue(“@LastName”, student_lastname_TextBox.Text)
            command.Parameters.AddWithValue(“@FirstName”, student_firstname_TextBox.Text)
            command.Parameters.AddWithValue(“@MiddleName”, student_middlename_TextBox.Text)
            command.Parameters.AddWithValue(“@BirthDate”, student_birthdate_TextBox.Text)
            command.Parameters.AddWithValue(“@Gender”, student_gender_TextBox.Text)
            command.Parameters.AddWithValue(“@Street”, student_street_TextBox.Text)
            command.Parameters.AddWithValue(“@Barangay”, student_barangay_TextBox.Text)
            command.Parameters.AddWithValue(“@Municipality”, student_municipality_TextBox.Text)
            command.Parameters.AddWithValue(“@Province”, student_province_TextBox.Text)
            command.Parameters.AddWithValue(“@PostalCode”, student_postalcode_TextBox.Text)
            command.Parameters.AddWithValue(“@ContactNumber”, student_contact_TextBox.Text)
            command.Parameters.AddWithValue(“@Email”, student_email_TextBox.Text)
            command.Parameters.AddWithValue(“@EnrolmentDate”, student_enrolmentdate_TextBox.Text)
            command.Parameters.AddWithValue(“@CurrentYear”, student_yl_TextBox.Text)
            Try
                command.ExecuteNonQuery()
                MessageBox.Show(“Student added successfully!”)
                ClearTextBoxes()
            Catch ex As MySqlException
                MessageBox.Show(“Error: “ & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub ClearTextBoxes()
        student_lastname_TextBox.Clear()
        student_firstname_TextBox.Clear()
        student_middlename_TextBox.Clear()
        student_enrolmentdate_TextBox.Clear()
        student_birthdate_TextBox.Clear()
        student_gender_TextBox.Clear()
        student_street_TextBox.Clear()
        student_barangay_TextBox.Clear()
        student_municipality_TextBox.Clear()
        student_province_TextBox.Clear()
        student_postalcode_TextBox.Clear()
        student_contact_TextBox.Clear()
        student_email_TextBox.Clear()
        student_studentid_TextBox.Clear()
        student_yl_TextBox.Clear()
    End Sub
    Private Sub addstudent_back_Button_Click(sender As Object, e As EventArgs) Handles addstudent_back_Button.Click
        Dim form2 As New StudentList()
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub student_yl_TextBox_TextChanged(sender As Object, e As EventArgs) Handles student_yl_TextBox.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub student_idno_Label_Click(sender As Object, e As EventArgs) Handles student_idno_Label.Click

    End Sub

    Private Sub AddStudentPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class