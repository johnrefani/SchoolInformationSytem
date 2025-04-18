Imports MySql.Data.MySqlClient

Public Class EnrolledSubjectOfStudent

    Private Sub EnrolledSubjectOfStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEnrolledSubjects()
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

    Private Sub LoadEnrolledSubjects()
        Dim studentID As String = CurrentLoggedUser.studentOrInstructorID
        Dim query As String = "SELECT 
                                    c.course_name AS `Course Title`, 
                                    c.course_code AS `Code`, 
                                    c.units AS `Units`, 
                                    cr.enrolment_date AS `Enrolment Date`, 
                                    cr.semester AS `Semester`, 
                                    cr.schedule AS `Schedule`, 
                                    CONCAT(i.first_name, ' ', i.last_name) AS `Instructor`
                                FROM 
                                    course_registrations cr
                                LEFT JOIN 
                                    course_info c ON cr.course_id = c.course_id
                                LEFT JOIN 
                                    instructor_info i ON cr.instructor_id = i.instructor_id
                                WHERE 
                                    cr.student_id = @student_id;"

        Try
            modDb.openConn("schooldb")
            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@student_id", studentID)
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                EnrolledSubjects_DataGridView.DataSource = table
            End Using
        Catch ex As Exception
            MsgBox("Error fetching enrolled courses: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub addSubject_Button_Click(sender As Object, e As EventArgs) Handles addSubject_Button.Click
        Dim addSubjectForm As New AddSubjectForm()
        If addSubjectForm.ShowDialog() = DialogResult.OK Then
            LoadEnrolledSubjects()
        End If
    End Sub
End Class