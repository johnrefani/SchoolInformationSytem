Imports MySql.Data.MySqlClient
Public Class AddTranscriptPageforAdmin
    Private Sub AddTranscriptPageforAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub addtranscript_Button_Click(sender As Object, e As EventArgs)
        AddTranscript
    End Sub

    Private Sub AddTranscript()
        If String.IsNullOrWhiteSpace(Transcript_studentid_TextBox.Text) Or
           String.IsNullOrWhiteSpace(Transcript_courseid_TextBox.Text) Or
           String.IsNullOrWhiteSpace(Transcript_instructorid_TextBox.Text) Or
           String.IsNullOrWhiteSpace(Transcript_programid_TextBox.Text) Or
           String.IsNullOrWhiteSpace(Transcript_semester_TextBox.Text) Or
           String.IsNullOrWhiteSpace(Transcript_grades_TextBox.Text) Or
           String.IsNullOrWhiteSpace(Transcript_remarks_TextBox.Text) Then
            MessageBox.Show("Please fill in all fields before adding the transcript.")
            Exit Sub
        End If
        modDb.openConn("schooldb")
        Try
            Dim checkQuery As String = "SELECT COUNT(*) FROM student_info WHERE student_id = @StudentID"
            Using checkCommand As New MySqlCommand(checkQuery, modDb.conn)
                checkCommand.Parameters.AddWithValue("@StudentID", Transcript_studentid_TextBox.Text)
                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
                If count = 0 Then
                    MessageBox.Show("The specified Student ID does not exist. Please enter a valid Student ID.")
                    Exit Sub
                End If
            End Using
            Dim query As String = “INSERT INTO transcript_info (student_id, course_id, instructor_id, program_id, semester, grades, remarks) “ &
            “VALUES (@StudentID, @CourseID, @InstructorID, @ProgramID, @Semester, @Grades, @Remarks)”
            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.AddWithValue(“@StudentID”, Transcript_studentid_TextBox.Text)
                command.Parameters.AddWithValue(“@CourseID”, Transcript_courseid_TextBox.Text)
                command.Parameters.AddWithValue(“@InstructorID”, Transcript_instructorid_TextBox.Text)
                command.Parameters.AddWithValue(“@ProgramID”, Transcript_programid_TextBox.Text)
                command.Parameters.AddWithValue(“@Semester”, Transcript_semester_TextBox.Text)
                command.Parameters.AddWithValue(“@Grades”, Transcript_grades_TextBox.Text)
                command.Parameters.AddWithValue(“@Remarks”, Transcript_remarks_TextBox.Text)
                command.ExecuteNonQuery()
                MessageBox.Show(“Transcript added successfully!”)
                ClearTextBoxes()
            End Using
        Catch ex As Exception
            MessageBox.Show(“An error occurred: “ & ex.Message)
        End Try
    End Sub

    Private Sub ClearTextBoxes()
        Transcript_studentid_TextBox.Clear()
        Transcript_courseid_TextBox.Clear()
        Transcript_instructorid_TextBox.Clear()
        Transcript_programid_TextBox.Clear()
        Transcript_semester_TextBox.Clear()
        Transcript_grades_TextBox.Clear()
        Transcript_remarks_TextBox.Clear()
    End Sub

    Private Sub addtranscript_back_Button_Click(sender As Object, e As EventArgs)
        Dim form2 As New TranscriptList()
        form2.Show
        Hide
    End Sub
End Class