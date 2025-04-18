Imports MySql.Data.MySqlClient

Public Class AddSubjectForm
    Private Sub AddSubjectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCourses()
        AddEnrollButtonColumn()
    End Sub

    Private Sub LoadCourses()
        Dim sql As String = "SELECT cr.course_id AS `Course ID`, c.course_name AS `Course Name`, i.instructor_id AS `Instructor ID`,
                             GROUP_CONCAT(CONCAT(i.first_name, ' ', COALESCE(i.middlename, ''), ' ', i.last_name, ' ', COALESCE(i.suffix, ''))) AS Instructor
                      FROM course_registrations cr
                      LEFT JOIN course_info c ON cr.course_id = c.course_id
                      LEFT JOIN instructor_info i ON cr.instructor_id = i.instructor_id
                      GROUP BY cr.course_id, c.course_name"

        Try
            modDb.openConn(db_name)

            Using cmd As New MySqlCommand(sql, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        Dim dt As New DataTable()
                        dt.Load(reader)
                        courses_DGV.DataSource = dt
                    Else
                        MessageBox.Show("No courses found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub



    Private Sub AddEnrollButtonColumn()
        Dim enroll_Button As New DataGridViewButtonColumn()
        enroll_Button.Name = "Enroll"
        enroll_Button.HeaderText = "Action"
        enroll_Button.Text = "Enroll"
        enroll_Button.UseColumnTextForButtonValue = True
        courses_DGV.Columns.Add(enroll_Button)
    End Sub

    Private Sub courses_DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles courses_DGV.CellContentClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = courses_DGV.Rows(e.RowIndex)
            Dim courseID As Integer = Convert.ToInt32(selectedRow.Cells("Course ID").Value)

            If courses_DGV.Columns(e.ColumnIndex).Name = "Enroll" Then
                Dim insertSql As String = "INSERT INTO course_registrations (student_id, course_id) VALUES (@studentID, @courseID)"

                Try
                    modDb.openConn(db_name)
                    Using cmd As New MySqlCommand(insertSql, conn)
                        cmd.Parameters.AddWithValue("@studentID", CurrentLoggedUser.studentOrInstructorID)
                        cmd.Parameters.AddWithValue("@courseID", courseID)

                        If cmd.ExecuteNonQuery() > 0 Then
                            MessageBox.Show("You have enrolled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Failed to enroll.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                        conn.Close()
                    End If
                End Try
            End If
        End If
    End Sub

End Class
