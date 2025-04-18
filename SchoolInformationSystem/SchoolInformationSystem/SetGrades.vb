Imports MySql.Data.MySqlClient

Public Class SetGrades
    Private Sub SetGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudentsGrades()
        AddEditButtonColumn()
    End Sub

    Private Sub LoadStudentsGrades()
        Dim sql As String = "SELECT 
                            s.student_id AS `Student ID`, 
                            CONCAT(s.first_name, ' ', COALESCE(s.middlename, ''), ' ', s.last_name,' ', COALESCE(s.suffix, '')) AS `Full Name`,
                            c.course_name AS `Course Name`,
                            cr.semester AS Semester,
                            t.grade AS Grade,
                            t.remarks AS Remarks
                         FROM 
                            student_info s
                         JOIN 
                            course_registrations cr ON s.student_id = cr.student_id
                         JOIN 
                            course_info c ON cr.course_id = c.course_id
                         LEFT JOIN 
                            transcripts t ON s.student_id = t.student_id AND cr.course_id = t.course_id
                         WHERE 
                            cr.instructor_id = @instructorID"

        Try
            modDb.openConn("schooldb")

            Using command As New MySqlCommand(sql, modDb.conn)
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@instructorID", CurrentLoggedUser.studentOrInstructorID)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        Dim dt As New DataTable()
                        dt.Load(reader)
                        StudentGrades_DGV.DataSource = dt
                    Else
                        MsgBox("No grades found for this instructor's students.", MsgBoxStyle.Information)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("An error occurred while loading grades: " & ex.Message, MsgBoxStyle.Critical)
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

    Private Sub AddEditButtonColumn()
        Dim editButton As New DataGridViewButtonColumn()
        editButton.Name = “Edit”
        editButton.HeaderText = “Action”
        editButton.Text = “Edit”
        editButton.UseColumnTextForButtonValue = True
        StudentGrades_DGV.Columns.Add(editButton)
    End Sub

    Private Sub StudentGrades_DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentGrades_DGV.CellClick
        If e.RowIndex >= 0 AndAlso StudentGrades_DGV.Columns(e.ColumnIndex).Name = "Edit" Then
            Dim selectedRow As DataGridViewRow = StudentGrades_DGV.Rows(e.RowIndex)
            Dim studentID As Integer = Convert.ToInt32(selectedRow.Cells("Student ID").Value)
            Dim courseName As String = selectedRow.Cells("Course Name").Value.ToString()
            Dim studentName As String = selectedRow.Cells("Full Name").Value.ToString()

            Dim editGradeForm As New EditGradeForm(studentID, courseName, studentName)
            If editGradeForm.ShowDialog() = DialogResult.OK Then
                LoadStudentsGrades()
            End If
        End If
    End Sub


    Private Sub search_Button_Click(sender As Object, e As EventArgs) Handles search_Button.Click
        Dim studentID As Integer
        Dim firstName As String = firstname_TextBox.Text.Trim()
        Dim middleName As String = If(String.IsNullOrEmpty(middlename_TextBox.Text.Trim()), "", middlename_TextBox.Text.Trim())
        Dim lastName As String = lastname_TextBox.Text.Trim()
        Dim suffix As String = If(String.IsNullOrEmpty(suffix_TextBox.Text.Trim()), "", suffix_TextBox.Text.Trim())

        Try
            If Integer.TryParse(idNumber_TextBox.Text, studentID) OrElse Not String.IsNullOrEmpty(firstName) OrElse
               Not String.IsNullOrEmpty(middleName) OrElse Not String.IsNullOrEmpty(lastName) OrElse
               Not String.IsNullOrEmpty(suffix) Then

                Dim sql As String = "SELECT 
                                        s.student_id AS `Student ID`, 
                                        CONCAT(s.first_name, ' ', COALESCE(s.middlename, ''), ' ', s.last_name, ' ', COALESCE(s.suffix, '')) AS `Full Name`,
                                        c.course_name AS `Course Name`,
                                        cr.semester AS Semester,
                                        t.grade AS Grade,
                                        t.remarks AS Remarks
                                     FROM 
                                        student_info s
                                     JOIN 
                                        course_registrations cr ON s.student_id = cr.student_id
                                     JOIN 
                                        course_info c ON cr.course_id = c.course_id
                                     LEFT JOIN 
                                        transcripts t ON s.student_id = t.student_id AND cr.course_id = t.course_id
                                     WHERE 
                                        1=1"

                If studentID > 0 Then
                    sql &= " AND s.student_id = @studentID"
                End If

                If Not String.IsNullOrEmpty(firstName) Then
                    sql &= " AND s.first_name LIKE @firstName"
                End If

                If Not String.IsNullOrEmpty(middleName) Then
                    sql &= " AND s.middlename LIKE @middleName"
                End If

                If Not String.IsNullOrEmpty(lastName) Then
                    sql &= " AND s.last_name LIKE @lastName"
                End If

                If Not String.IsNullOrEmpty(suffix) Then
                    sql &= " AND s.suffix LIKE @suffix"
                End If

                modDb.openConn(db_name)

                Using cmd As New MySqlCommand(sql, conn)
                    If studentID > 0 Then
                        cmd.Parameters.AddWithValue("@studentID", studentID)
                    End If

                    If Not String.IsNullOrEmpty(firstName) Then
                        cmd.Parameters.AddWithValue("@firstName", "%" & firstName & "%")
                    End If

                    If Not String.IsNullOrEmpty(middleName) Then
                        cmd.Parameters.AddWithValue("@middleName", "%" & middleName & "%")
                    End If

                    If Not String.IsNullOrEmpty(lastName) Then
                        cmd.Parameters.AddWithValue("@lastName", "%" & lastName & "%")
                    End If

                    If Not String.IsNullOrEmpty(suffix) Then
                        cmd.Parameters.AddWithValue("@suffix", "%" & suffix & "%")
                    End If

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            Dim dt As New DataTable()
                            dt.Load(reader)
                            StudentGrades_DGV.DataSource = dt
                        Else
                            MessageBox.Show("No matching student found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using

            Else
                MessageBox.Show("Please enter at least one search criteria (ID, First Name, Middle Name, Last Name, or Suffix).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred when searching: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub



End Class