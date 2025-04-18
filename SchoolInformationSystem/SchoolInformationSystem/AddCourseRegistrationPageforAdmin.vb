Imports MySql.Data.MySqlClient
Public Class AddCourseRegistrationPageforAdmin
    Private Sub courseregistration_add_Button_Click(sender As Object, e As EventArgs) Handles courseregistration_add_Button.Click
        AddCourseRegistration()
    End Sub
    Private Sub AddCourseRegistration()
        If String.IsNullOrWhiteSpace(cr_registrationid_TextBox.Text) Or
        String.IsNullOrWhiteSpace(cr_studentid_TextBox.Text) Or
        String.IsNullOrWhiteSpace(cr_blockid_TextBox.Text) Or
        String.IsNullOrWhiteSpace(cr_courseid_TextBox.Text) Or
        String.IsNullOrWhiteSpace(cr_programid_TextBox.Text) Or
        String.IsNullOrWhiteSpace(cr_instructorid_TextBox.Text) Or
        String.IsNullOrWhiteSpace(cr_enrollmentdate_TextBox.Text) Or
        String.IsNullOrWhiteSpace(cr_semester_TextBox.Text) Or
        String.IsNullOrWhiteSpace(cr_schedule_TextBox.Text) Then
            MessageBox.Show(“Please fill in all fields before adding the course registration.”)
            Exit Sub
        End If
        modDb.openConn(“schooldb”)
        Try
            Dim studentExists As Boolean = CheckIfExists(“student_info”, “student_id”, cr_studentid_TextBox.Text)
            Dim blockExists As Boolean = CheckIfExists(“block_info”, “block_id”, cr_blockid_TextBox.Text)
            Dim courseExists As Boolean = CheckIfExists(“course_info”, “course_id”, cr_courseid_TextBox.Text)
            Dim programExists As Boolean = CheckIfExists(“program_info”, “program_id”, cr_programid_TextBox.Text)
            Dim instructorExists As Boolean = CheckIfExists(“instructor_info”, “instructor_id”, cr_instructorid_TextBox.Text)
            If Not (studentExists And blockExists And courseExists And programExists And instructorExists) Then
                MessageBox.Show(“One or more IDs do not exist. Please enter valid IDs.”)
                Exit Sub
            End If
            Dim query As String = “INSERT INTO course_registrations (registration_id, student_id, block_id, course_id, program_id, instructor_id, enrolment_date, semester, schedule) “ &
            “VALUES (@RegistrationID, @StudentID, @BlockID, @CourseID, @ProgramID, @InstructorID, @EnrollmentDate, @Semester, @Schedule)”
            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.AddWithValue(“@RegistrationID”, cr_registrationid_TextBox.Text)
                command.Parameters.AddWithValue(“@StudentID”, cr_studentid_TextBox.Text)
                command.Parameters.AddWithValue(“@BlockID”, cr_blockid_TextBox.Text)
                command.Parameters.AddWithValue(“@CourseID”, cr_courseid_TextBox.Text)
                command.Parameters.AddWithValue(“@ProgramID”, cr_programid_TextBox.Text)
                command.Parameters.AddWithValue(“@InstructorID”, cr_instructorid_TextBox.Text)
                command.Parameters.AddWithValue(“@EnrollmentDate”, cr_enrollmentdate_TextBox.Text)
                command.Parameters.AddWithValue(“@Semester”, cr_semester_TextBox.Text)
                command.Parameters.AddWithValue(“@Schedule”, cr_schedule_TextBox.Text)
                command.ExecuteNonQuery()
                MessageBox.Show(“Course registration added successfully!”)
                ClearTextBoxes()
            End Using
        Catch ex As MySqlException
            MessageBox.Show(“An error occurred: “ & ex.Message)
        End Try
    End Sub
    Private Function CheckIfExists(tableName As String, columnName As String, value As String) As Boolean
        Dim query As String = $”SELECT COUNT(*) FROM {tableName} WHERE {columnName} = @Value”
        Using command As New MySqlCommand(query, modDb.conn)
            command.Parameters.AddWithValue(“@Value”, value)
            Return Convert.ToInt32(command.ExecuteScalar()) > 0
        End Using
    End Function
    Private Sub ClearTextBoxes()
        cr_registrationid_TextBox.Clear()
        cr_studentid_TextBox.Clear()
        cr_blockid_TextBox.Clear()
        cr_courseid_TextBox.Clear()
        cr_programid_TextBox.Clear()
        cr_instructorid_TextBox.Clear()
        cr_enrollmentdate_TextBox.Clear()
        cr_semester_TextBox.Clear()
        cr_schedule_TextBox.Clear()
    End Sub
    Private Sub addcoursereg_back_Button_Click(sender As Object, e As EventArgs) Handles addcoursereg_back_Button.Click
        Dim form2 As New CourseRegistrationList()
        form2.Show()
        Close()
    End Sub
End Class