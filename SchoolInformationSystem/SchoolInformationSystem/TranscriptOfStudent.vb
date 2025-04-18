Imports MySql.Data.MySqlClient

Public Class TranscriptOfStudent
    Private Sub TranscriptOfStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTranscript()
    End Sub

    Private Sub student_profile_Button_Click(sender As Object, e As EventArgs) Handles student_profile_Button.Click
        Dim newPfpStudent As New StudentProfileforStudent
        newPfpStudent.Show()
        Me.Close()
    End Sub

    Private Sub student_addCR_Button_Click(sender As Object, e As EventArgs) Handles student_addCR_Button.Click
        Dim enrolledSubs As New EnrolledSubjectOfStudent
        enrolledSubs.Show()
        Me.Close()
    End Sub

    Private Sub transcript_Button_Click(sender As Object, e As EventArgs) Handles transcript_Button.Click
        Dim transcript As New TranscriptOfStudent
        transcript.Show()
        Me.Close()
    End Sub

    Private Sub student_logout_Button_Click(sender As Object, e As EventArgs) Handles student_logout_Button.Click
        Dim loginAgain As New LoginPage
        loginAgain.Show()
        Me.Close()
    End Sub

    Private Sub LoadTranscript()
        Dim studentID As String = CurrentLoggedUser.studentOrInstructorID
        Dim query As String = "SELECT c.course_name AS `Course Title`, c.course_code AS `Course Code`, t.semester AS `Semester`, t.grade AS `Grade`, t.remarks AS `Remarks` FROM transcripts t LEFT JOIN course_info c ON t.course_id = c.course_id WHERE t.student_id = @student_id ORDER BY t.semester ASC, c.course_name ASC"

        Try
            modDb.openConn("schooldb")
            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@student_id", studentID)

                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                Transcript_DGV.DataSource = table
            End Using
        Catch ex As Exception
            MsgBox("Error loading transcript: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub
End Class