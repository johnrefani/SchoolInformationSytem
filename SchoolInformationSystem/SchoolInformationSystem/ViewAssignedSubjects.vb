Imports MySql.Data.MySqlClient

Public Class ViewAssignedSubjects
    Private Sub ViewAssignedSubjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAssignedSubjects()
    End Sub

    Private Sub LoadAssignedSubjects()
        Dim instructorID As Integer = CurrentLoggedUser.studentOrInstructorID
        Dim sql As String = "SELECT 
                            CONCAT(i.first_name, ' ', COALESCE(i.middlename, ''), ' ', i.last_name, ' ', COALESCE(i.suffix, '')) AS `Full Name`,
                            COUNT(cr.student_id) AS `Student Count`,
                            c.course_name AS `Course Name`,
                            c.course_code AS `Course Code`,
                            cr.semester AS Semester,
                            cr.schedule AS Schedule
                        FROM 
                            instructor_info i
                        JOIN 
                            course_registrations cr ON i.instructor_id = cr.instructor_id
                        JOIN 
                            course_info c ON cr.course_id = c.course_id
                        WHERE 
                            i.instructor_id = @instructorID
                        GROUP BY 
                            c.course_id"

        Try
            modDb.openConn("schooldb")

            Using command As New MySqlCommand(sql, modDb.conn)
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@instructorID", instructorID)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        Dim dt As New DataTable()
                        dt.Load(reader)
                        assignedSubjects_DGV.DataSource = dt
                    Else
                        MsgBox("No assigned subjects found for this instructor.", MsgBoxStyle.Exclamation)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("An error occurred while loading assigned subjects: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If modDb.conn IsNot Nothing AndAlso modDb.conn.State = ConnectionState.Open Then
                modDb.conn.Close()
            End If
        End Try
    End Sub



    Private Sub profile_Button_Click(sender As Object, e As EventArgs) Handles profile_Button.Click
        Dim profile As New InstructorProfile
        profile.Show()
        Me.Close()
    End Sub

    Private Sub courseReg_Button_Click(sender As Object, e As EventArgs) Handles courseReg_Button.Click
        Dim courseReg As New CourseRegistrationForInstructor
        courseReg.Show()
        Me.Close()
    End Sub

    Private Sub setGrades_Button_Click(sender As Object, e As EventArgs) Handles setGrades_Button.Click
        Dim setGrade As New SetGrades
        setGrade.Show()
        Me.Close()
    End Sub

    Private Sub viewSubjects_Button_Click(sender As Object, e As EventArgs) Handles viewSubjects_Button.Click
        Dim viewSubs As New ViewAssignedSubjects
        viewSubs.Show()
        Me.Close()
    End Sub

    Private Sub logout_Button_Click(sender As Object, e As EventArgs) Handles logout_Button.Click
        Dim loginAgain As New LoginPage
        loginAgain.Show()
        Me.Close()
    End Sub
End Class