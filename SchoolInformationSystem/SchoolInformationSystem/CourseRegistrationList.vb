Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class CourseRegistrationList
    Private WithEvents dbWatcher As New BackgroundWorker

    Private Sub CourseRegistrationList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'dbWatcher.RunWorkerAsync()
        LoadCourseRegistrationData()
        AddDeleteAndEditButtonColumns()
    End Sub
    ' Load course registration data into the DataGridView
    Private Sub LoadCourseRegistrationData()
        modDb.openConn(“schooldb”)
        Dim query As String = “SELECT * FROM course_registrations”
        Dim table As New DataTable()
        Try
            Using adapter As New MySqlDataAdapter(query, modDb.conn)
                adapter.Fill(table)
                CourseRegistrationDataGridView.DataSource = table ' Bind the data to the DataGridView
            End Using
        Catch ex As Exception
            MessageBox.Show(“Error: “ & ex.Message, “Database Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
        End Try
    End Sub
    ' Handle the Add button click
    Private Sub crlist_add_Button_Click(sender As Object, e As EventArgs) Handles crlist_add_Button.Click
        Dim form2 As New AddCourseRegistrationPageforAdmin()
        form2.Show()
        Me.Hide()
    End Sub
    ' Handle search functionality
    Private Sub crlist_search_Button_Click(sender As Object, e As EventArgs) Handles crlist_search_Button.Click
        modDb.openConn(“schooldb”)
        ' Build the search query
        Dim query As String = “SELECT * FROM course_registrations WHERE 1=1”
        ' Add search conditions based on input fields
        If Not String.IsNullOrWhiteSpace(cr_registrationid_SearchField.Text) Then
            query &= “ AND registration_id LIKE @RegistrationID”
        End If
        If Not String.IsNullOrWhiteSpace(cr_studentid_SearchField.Text) Then
            query &= “ AND student_id LIKE @StudentID”
        End If
        If Not String.IsNullOrWhiteSpace(cr_blockid_SearchField.Text) Then
            query &= “ AND block_id LIKE @BlockID”
        End If
        If Not String.IsNullOrWhiteSpace(cr_courseid_SearchField.Text) Then
            query &= “ AND course_id LIKE @CourseID”
        End If
        If Not String.IsNullOrWhiteSpace(cr_programid_SearchField.Text) Then
            query &= “ AND program_id LIKE @ProgramID”
        End If
        If Not String.IsNullOrWhiteSpace(cr_instructorid_SearchField.Text) Then
            query &= “ AND instructor_id LIKE @InstructorID”
        End If
        If Not String.IsNullOrWhiteSpace(cr_enrollmentdate_SearchField.Text) Then
            query &= “ AND enrollment_date LIKE @EnrollmentDate”
        End If
        If Not String.IsNullOrWhiteSpace(cr_semester_SearchField.Text) Then
            query &= “ AND semester LIKE @Semester”
        End If
        If Not String.IsNullOrWhiteSpace(cr_schedule_SearchField.Text) Then
            query &= “ AND schedule LIKE @Schedule”
        End If
        Dim table As New DataTable()
        Try
            Using command As New MySqlCommand(query, modDb.conn)
                ' Add parameters for search fields
                If Not String.IsNullOrWhiteSpace(cr_registrationid_SearchField.Text) Then
                    command.Parameters.AddWithValue(“@RegistrationID”, “%” & cr_registrationid_SearchField.Text & “%”)
                End If
                If Not String.IsNullOrWhiteSpace(cr_studentid_SearchField.Text) Then
                    command.Parameters.AddWithValue(“@StudentID”, “%” & cr_studentid_SearchField.Text & “%”)
                End If
                If Not String.IsNullOrWhiteSpace(cr_blockid_SearchField.Text) Then
                    command.Parameters.AddWithValue(“@BlockID”, “%” & cr_blockid_SearchField.Text & “%”)
                End If
                If Not String.IsNullOrWhiteSpace(cr_courseid_SearchField.Text) Then
                    command.Parameters.AddWithValue(“@CourseID”, “%” & cr_courseid_SearchField.Text & “%”)
                End If
                If Not String.IsNullOrWhiteSpace(cr_programid_SearchField.Text) Then
                    command.Parameters.AddWithValue(“@ProgramID”, “%” & cr_programid_SearchField.Text & “%”)
                End If
                If Not String.IsNullOrWhiteSpace(cr_instructorid_SearchField.Text) Then
                    command.Parameters.AddWithValue(“@InstructorID”, “%” & cr_instructorid_SearchField.Text & “%”)
                End If
                If Not String.IsNullOrWhiteSpace(cr_enrollmentdate_SearchField.Text) Then
                    command.Parameters.AddWithValue(“@EnrollmentDate”, “%” & cr_enrollmentdate_SearchField.Text & “%”)
                End If
                If Not String.IsNullOrWhiteSpace(cr_semester_SearchField.Text) Then
                    command.Parameters.AddWithValue(“@Semester”, “%” & cr_semester_SearchField.Text & “%”)
                End If
                If Not String.IsNullOrWhiteSpace(cr_schedule_SearchField.Text) Then
                    command.Parameters.AddWithValue(“@Schedule”, “%” & cr_schedule_SearchField.Text & “%”)
                End If
                Using adapter As New MySqlDataAdapter(command)
                    adapter.Fill(table)
                    CourseRegistrationDataGridView.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(“Error: “ & ex.Message, “Database Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
        End Try
    End Sub
    ' Add Delete and Edit button columns to the DataGridView
    Private Sub AddDeleteAndEditButtonColumns()
        Dim deleteButton As New DataGridViewButtonColumn()
        deleteButton.Name = “Delete”
        deleteButton.HeaderText = “Action”
        deleteButton.Text = “Delete”
        deleteButton.UseColumnTextForButtonValue = True
        CourseRegistrationDataGridView.Columns.Add(deleteButton)
        Dim editButton As New DataGridViewButtonColumn()
        editButton.Name = “Edit”
        editButton.HeaderText = “Action”
        editButton.Text = “Edit”
        editButton.UseColumnTextForButtonValue = True
        CourseRegistrationDataGridView.Columns.Add(editButton)
    End Sub
    ' Handle cell content click for Delete and Edit actions
    Private Sub CourseRegistrationDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CourseRegistrationDataGridView.CellContentClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = CourseRegistrationDataGridView.Rows(e.RowIndex)
            If e.ColumnIndex = CourseRegistrationDataGridView.Columns(“Delete”).Index Then
                Dim registrationId As String = selectedRow.Cells(“registration_id”).Value.ToString()
                Dim result = MessageBox.Show($”Are you sure you want to delete the registration with ID {registrationId}?”,
                “Confirm Delete”, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    DeleteCourseRegistration(registrationId)
                    LoadCourseRegistrationData() ' Refresh data
                End If
            ElseIf e.ColumnIndex = CourseRegistrationDataGridView.Columns(“Edit”).Index Then
                Dim registrationId As String = selectedRow.Cells(“registration_id”).Value.ToString()
                Dim editForm As New EditCourseRegistrationPage()
                editForm.RegistrationID = registrationId
                editForm.Show()
                Me.Hide()
            End If
        End If
    End Sub
    ' Delete course registration record
    Private Sub DeleteCourseRegistration(registrationId As String)
        modDb.openConn(“schooldb”)
        Dim query As String = “DELETE FROM course_registrations WHERE registration_id = @RegistrationID”
        Try
            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.AddWithValue(“@RegistrationID”, registrationId)
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show(“Registration deleted successfully.”, “Success”, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show(“Registration not found.”, “Error”, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(“Error: “ & ex.Message, “Database Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
        End Try
    End Sub

    Private Sub cr_back_Button_Click(sender As Object, e As EventArgs) Handles cr_back_Button.Click
        Dim form2 As New AdminPage()
        form2.Show()
        Me.Hide()
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
                            LoadCourseRegistrationData()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Error:" + ex.Message, MsgBoxStyle.Critical)
            Finally
                If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try

            Threading.Thread.Sleep(3000)
        End While
    End Sub

End Class