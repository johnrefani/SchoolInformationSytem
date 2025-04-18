Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class CourseRegistrationForInstructor
    Private WithEvents dbWatcher As New BackgroundWorker

    Private Sub CourseRegistrationForInstructor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'dbWatcher.RunWorkerAsync()
        LoadRegistrations()
    End Sub

    Private Sub LoadRegistrations(Optional courseNameFilter As String = "")
        Try
            Dim sql As String = "SELECT 
                                    c.course_name AS `Course Name`,
                                    s.first_name AS `First Name`, 
                                    s.middlename As `Middle Name`, 
                                    s.last_name AS `Last Name`, 
                                    s.suffix As `Suffix`,
                                    s.current_year AS `Current Year`,
                                    s.block AS `Block`
                                FROM 
                                    course_info c
                                JOIN 
                                    course_registrations cr ON c.course_id = cr.course_id
                                JOIN 
                                    student_info s ON cr.student_id = s.student_id
                                WHERE 
                                    c.course_name LIKE @courseNameFilter"

            modDb.openConn("schooldb")

            Using command As New MySqlCommand(sql, modDb.conn)
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@courseNameFilter", $"%{courseNameFilter}%")

                Using reader As MySqlDataReader = command.ExecuteReader()
                    Dim dataTable As New DataTable()
                    dataTable.Load(reader)

                    students_DGV.DataSource = dataTable
                End Using
            End Using
        Catch ex As Exception
            MsgBox("An error occurred while loading the registrations: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If modDb.conn IsNot Nothing AndAlso modDb.conn.State = ConnectionState.Open Then
                modDb.conn.Close()
            End If
        End Try
    End Sub

    Private Sub searchCourse_Button_Click(sender As Object, e As EventArgs) Handles searchCourse_Button.Click
        Dim courseName As String = courseSearch_TextBox.Text.Trim()
        LoadRegistrations(courseName)
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

    Private Sub dbWatcher_DoWork(sender As Object, e As DoWorkEventArgs) Handles dbWatcher.DoWork
        Dim sql As String = "SELECT * FROM course_registrations"
        Dim lastChecked As DateTime = DateTime.Now

        While True
            Try
                modDb.openConn(db_name)
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@lastChecked", lastChecked)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            lastChecked = DateTime.Now
                            LoadRegistrations()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            Finally
                If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try

            Threading.Thread.Sleep(3000)
        End While
    End Sub

End Class
