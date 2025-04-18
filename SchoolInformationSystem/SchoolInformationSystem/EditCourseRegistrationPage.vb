Imports MySql.Data.MySqlClient
Public Class EditCourseRegistrationPage
    Public Property RegistrationID As String
    Private Sub EditCourseRegistrationPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not String.IsNullOrEmpty(RegistrationID) Then
            LoadCourseRegistrationDetails(RegistrationID)
        End If
    End Sub
    ' Load course registration details into the form fields
    Private Sub LoadCourseRegistrationDetails(registrationId As String)
        modDb.openConn(“schooldb”)
        Dim query As String = “SELECT * FROM course_registrations WHERE registration_id = @RegistrationID”
        Try
            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.AddWithValue(“@RegistrationID”, registrationId)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Populate form fields with data from the database
                        cr_registrationid_TextBox.Text = reader(“registration_id”).ToString()
                        cr_studentid_TextBox.Text = reader(“student_id”).ToString()
                        cr_blockid_TextBox.Text = reader(“block_id”).ToString()
                        cr_courseid_TextBox.Text = reader(“course_id”).ToString()
                        cr_programid_TextBox.Text = reader(“program_id”).ToString()
                        cr_instructorid_TextBox.Text = reader(“instructor_id”).ToString()
                        cr_enrollmentdate_TextBox.Text = Convert.ToDateTime(reader(“enrolment_date”)).ToString(“yyyy-MM-dd”)
                        cr_semester_TextBox.Text = reader(“semester”).ToString()
                        cr_schedule_TextBox.Text = reader(“schedule”).ToString()
                    Else
                        MessageBox.Show(“Registration details not found.”, “Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Close()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(“Error: “ & ex.Message, “Database Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
        End Try
    End Sub
    ' Update the course registration details
    Private Sub editcr_save_Button_Click(sender As Object, e As EventArgs) Handles editcr_save_Button.Click
        modDb.openConn(“schooldb”)
        Dim query As String = “UPDATE course_registrations
SET student_id = @StudentID,
Block_id = @BlockID,
Course_id = @CourseID,
Program_id = @ProgramID,
Instructor_id = @InstructorID,
Enrolment_date = @EnrollmentDate,
Semester = @Semester,
Schedule = @Schedule
WHERE registration_id = @RegistrationID”
        Try
            Using command As New MySqlCommand(query, modDb.conn)
                ' Assign values to parameters
                command.Parameters.AddWithValue(“@RegistrationID”, cr_registrationid_TextBox.Text)
                command.Parameters.AddWithValue(“@StudentID”, cr_studentid_TextBox.Text)
                command.Parameters.AddWithValue(“@BlockID”, cr_blockid_TextBox.Text)
                command.Parameters.AddWithValue(“@CourseID”, cr_courseid_TextBox.Text)
                command.Parameters.AddWithValue(“@ProgramID”, cr_programid_TextBox.Text)
                command.Parameters.AddWithValue(“@InstructorID”, cr_instructorid_TextBox.Text)
                command.Parameters.AddWithValue(“@EnrollmentDate”, cr_enrollmentdate_TextBox.Text)
                command.Parameters.AddWithValue(“@Semester”, cr_semester_TextBox.Text)
                command.Parameters.AddWithValue(“@Schedule”, cr_schedule_TextBox.Text)
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show(“Registration details updated successfully.”, “Success”, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim registrationList As New CourseRegistrationList()
                    registrationList.Show()
                    Me.Close()
                Else
                    MessageBox.Show(“No changes were made.”, “Warning”, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(“Error: “ & ex.Message, “Database Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
        End Try
    End Sub
    ' Handle the Cancel button click
    Private Sub editcr_cancel_Button_Click(sender As Object, e As EventArgs) Handles editcr_cancel_Button.Click
        Dim registrationList As New CourseRegistrationList()
        registrationList.Show()
        Me.Close()
    End Sub
End Class