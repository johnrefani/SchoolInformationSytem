Imports MySql.Data.MySqlClient

Public Class EditTranscriptPage
    ' Property to store the Transcript ID passed from another form
    Public Property TranscriptID As String

    ' Load the transcript details when the form loads
    Private Sub EditTranscriptPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not String.IsNullOrEmpty(TranscriptID) Then
            LoadTranscriptDetails(TranscriptID)
        Else
            MessageBox.Show("No Transcript ID provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
    End Sub

    ' Load transcript details from the database
    Private Sub LoadTranscriptDetails(transcriptId As String)
        modDb.openConn("schooldb")
        Dim query As String = "SELECT * FROM transcript_info WHERE transcript_id = @TranscriptID"
        Try
            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.AddWithValue("@TranscriptID", transcriptId)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Map database fields to form controls
                        edittranscript_studentid_TextBox.Text = reader("student_id").ToString()
                        edittranscript_courseid_TextBox.Text = reader("course_id").ToString()
                        edittranscript_instructorid_TextBox.Text = reader("instructor_id").ToString()
                        edittranscript_programid_TextBox.Text = reader("program_id").ToString()
                        edittranscript_semester_TextBox.Text = reader("semester").ToString()
                        edittranscript_grades_TextBox.Text = reader("grades").ToString()
                        edittranscript_remarks_TextBox.Text = reader("remarks").ToString()
                    Else
                        MessageBox.Show("Transcript not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.Close()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
        End Try
    End Sub

    ' Handle the Save button click
    Private Sub edittranscript_save_Button_Click(sender As Object, e As EventArgs) Handles edittranscript_save_Button.Click
        If ValidateInputs() Then
            UpdateTranscriptDetails()
        End If
    End Sub

    ' Validate form inputs
    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(edittranscript_studentid_TextBox.Text) Then
            MessageBox.Show("Student ID cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(edittranscript_courseid_TextBox.Text) Then
            MessageBox.Show("Course ID cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(edittranscript_instructorid_TextBox.Text) Then
            MessageBox.Show("Instructor ID cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(edittranscript_programid_TextBox.Text) Then
            MessageBox.Show("Program ID cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(edittranscript_semester_TextBox.Text) Then
            MessageBox.Show("Semester cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(edittranscript_grades_TextBox.Text) Then
            MessageBox.Show("Grades cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(edittranscript_remarks_TextBox.Text) Then
            MessageBox.Show("Remarks cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    ' Update transcript details in the database
    Private Sub UpdateTranscriptDetails()
        modDb.openConn("schooldb")
        Dim query As String = "UPDATE transcript_info SET student_id = @StudentID, course_id = @CourseID, instructor_id = @InstructorID, " &
                              "program_id = @ProgramID, semester = @Semester, grades = @Grades, remarks = @Remarks WHERE transcript_id = @TranscriptID"
        Try
            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.AddWithValue("@StudentID", edittranscript_studentid_TextBox.Text)
                command.Parameters.AddWithValue("@CourseID", edittranscript_courseid_TextBox.Text)
                command.Parameters.AddWithValue("@InstructorID", edittranscript_instructorid_TextBox.Text)
                command.Parameters.AddWithValue("@ProgramID", edittranscript_programid_TextBox.Text)
                command.Parameters.AddWithValue("@Semester", edittranscript_semester_TextBox.Text)
                command.Parameters.AddWithValue("@Grades", edittranscript_grades_TextBox.Text)
                command.Parameters.AddWithValue("@Remarks", edittranscript_remarks_TextBox.Text)
                command.Parameters.AddWithValue("@TranscriptID", TranscriptID)

                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Transcript updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim mainForm As New TranscriptList()
                    mainForm.Show()
                    Me.Close()
                Else
                    MessageBox.Show("No changes were made.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
        End Try
    End Sub

    ' Handle Cancel button click
    Private Sub edittranscript_cancel_Button_Click(sender As Object, e As EventArgs) Handles edittranscript_cancel_Button.Click
        Dim mainForm As New TranscriptList()
        mainForm.Show()
        Me.Close()
    End Sub

    Private Sub edittranscript_courseid_TextBox_TextChanged(sender As Object, e As EventArgs) Handles edittranscript_courseid_TextBox.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
