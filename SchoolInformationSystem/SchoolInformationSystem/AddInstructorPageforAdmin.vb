Imports MySql.Data.MySqlClient
Public Class AddInstructorPageforAdmin
    Private Sub instructor_add_Button_Click(sender As Object, e As EventArgs) Handles instructor_add_Button.Click
        AddInstructor()
    End Sub
    Private Sub AddInstructor()
        If String.IsNullOrWhiteSpace(instructor_idno_TextBox.Text) Or
        String.IsNullOrWhiteSpace(instructor_lastname_TextBox.Text) Or
        String.IsNullOrWhiteSpace(instructor_firstname_TextBox.Text) Or
        String.IsNullOrWhiteSpace(instrutor_middlename_TextBox.Text) Or
        String.IsNullOrWhiteSpace(instructor_birthdate_TextBox.Text) Or
        String.IsNullOrWhiteSpace(instructor_gender_TextBox.Text) Or
        String.IsNullOrWhiteSpace(instructor_email_TextBox.Text) Or
        String.IsNullOrWhiteSpace(instructor_contactnumber_TextBox.Text) Or
        String.IsNullOrWhiteSpace(instructor_hiredate_TextBox.Text) Then
            MessageBox.Show(“Please fill in all fields before adding the instructor.”)
            Exit Sub
        End If
        modDb.openConn(“schooldb”)
        Try
            If Not DepartmentIdExists(instructor_departmentid_TextBox.Text) Then
                MessageBox.Show(“Invalid Department ID. Please enter a valid department ID.”)
                Exit Sub
            End If
            Dim query As String = “INSERT INTO instructor_info (instructor_id, last_name, first_name, middlename, birthdate, gender, email, department_id, contact_number, hire_date) “ &
            “VALUES (@InstructorID, @LastName, @FirstName, @MiddleName, @BirthDate, @Gender, @Email, @DepartmentID, @ContactNumber, @HireDate)”
            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.AddWithValue(“@InstructorID”, instructor_idno_TextBox.Text)
                command.Parameters.AddWithValue(“@LastName”, instructor_lastname_TextBox.Text)
                command.Parameters.AddWithValue(“@FirstName”, instructor_firstname_TextBox.Text)
                command.Parameters.AddWithValue(“@MiddleName”, instrutor_middlename_TextBox.Text)
                command.Parameters.AddWithValue(“@BirthDate”, instructor_birthdate_TextBox.Text)
                command.Parameters.AddWithValue(“@Gender”, instructor_gender_TextBox.Text)
                command.Parameters.AddWithValue(“@Email”, instructor_email_TextBox.Text)
                command.Parameters.AddWithValue(“@DepartmentID”, instructor_departmentid_TextBox.Text)
                command.Parameters.AddWithValue(“@ContactNumber”, instructor_contactnumber_TextBox.Text)
                command.Parameters.AddWithValue(“@HireDate”, instructor_hiredate_TextBox.Text)
                command.ExecuteNonQuery()
                MessageBox.Show(“Instructor added successfully!”)
                ClearTextBoxes()
            End Using
        Catch ex As MySqlException
            MessageBox.Show(“An error occurred: “ & ex.Message)
        End Try
    End Sub
    Private Function DepartmentIdExists(departmentId As String) As Boolean
        Dim query As String = “SELECT COUNT(*) FROM department_info WHERE department_id = @DepartmentID”
        Using cmd As New MySqlCommand(query, modDb.conn)
            cmd.Parameters.AddWithValue(“@DepartmentID”, departmentId)
            Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
        End Using
    End Function
    Private Sub ClearTextBoxes()
        instructor_idno_TextBox.Clear()
        instructor_lastname_TextBox.Clear()
        instructor_firstname_TextBox.Clear()
        instrutor_middlename_TextBox.Clear()
        instructor_birthdate_TextBox.Clear()
        instructor_email_TextBox.Clear()
        instructor_contactnumber_TextBox.Clear()
        instructor_hiredate_TextBox.Clear()
    End Sub
    Private Sub addinstructor_back_Button_Click(sender As Object, e As EventArgs) Handles addinstructor_back_Button.Click
        Dim form2 As New InstructorList()
        form2.Show()
        Me.Hide()
    End Sub

End Class