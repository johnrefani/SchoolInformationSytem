Imports MySql.Data.MySqlClient
Public Class CourseList
    Private Sub CourseList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCourseData()
        AddActionButtonColumns()
    End Sub
    ' Method to load course data into the DataGridView
    Private Sub LoadCourseData()
        modDb.openConn(“schooldb”)
        Dim query As String = “SELECT * FROM course_info”
        Dim table As New DataTable()
        Try
            Using adapter As New MySqlDataAdapter(query, modDb.conn)
                adapter.Fill(table)
                CourseDataGridView.DataSource = table ' Bind the DataTable to the DataGridView
            End Using
        Catch ex As Exception
            MessageBox.Show(“Error: “ & ex.Message, “Database Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
        End Try
    End Sub
    ' Handle the CellContentClick event to process Delete and Edit actions
    Private Sub CourseDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CourseDataGridView.CellContentClick
        ' Ensure the click is within bounds
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = CourseDataGridView.Rows(e.RowIndex)
            ' Handle Delete button click
            If e.ColumnIndex = CourseDataGridView.Columns(“Delete”).Index Then
                Dim courseId As String = Convert.ToString(selectedRow.Cells(“course_id”).Value)
                Dim result = MessageBox.Show($”Are you sure you want to delete the course with ID {courseId}?”,
                “Confirm Delete”, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    DeleteCourse(courseId)
                    LoadCourseData() ' Refresh data
                End If
                ' Handle Edit button click
            ElseIf e.ColumnIndex = CourseDataGridView.Columns(“Edit”).Index Then
                Dim courseId As String = Convert.ToString(selectedRow.Cells(“course_id”).Value)
                Dim editForm As New EditCoursePage()
                editForm.CourseID = courseId ' Pass the ID to the form
                editForm.Show()
                Me.Hide() ' Hide current form
            End If
        End If
    End Sub
    ' Add dynamic button columns for Edit and Delete actions
    Private Sub AddActionButtonColumns()
        Dim deleteButton As New DataGridViewButtonColumn()
        deleteButton.Name = “Delete”
        deleteButton.HeaderText = “Action”
        deleteButton.Text = “Delete”
        deleteButton.UseColumnTextForButtonValue = True
        CourseDataGridView.Columns.Add(deleteButton)
        Dim editButton As New DataGridViewButtonColumn()
        editButton.Name = “Edit”
        editButton.HeaderText = “Action”
        editButton.Text = “Edit”
        editButton.UseColumnTextForButtonValue = True
        CourseDataGridView.Columns.Add(editButton)
    End Sub
    ' Method to delete a course from the database
    Private Sub DeleteCourse(courseId As String)
        modDb.openConn(“schooldb”)
        Try
            Dim query As String = “DELETE FROM course_info WHERE course_id = @CourseID”
            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.AddWithValue(“@CourseID”, courseId)
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show(“Course deleted successfully.”, “Success”, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show(“Course not found.”, “Error”, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        Catch ex As MySqlException
            MessageBox.Show(“An error occurred: “ & ex.Message, “Database Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            modDb.conn.Close()
        End Try
    End Sub
    ' Handle the Add button click to open the AddCoursePage
    Private Sub courselist_add_Button_Click(sender As Object, e As EventArgs) Handles courselist_add_Button.Click
        Dim form2 As New AddCoursePageforAdmin
        form2.Show()
        Me.Hide()
    End Sub
    ' Handle the Search button click to filter courses based on search fields
    Private Sub courselist_search_Button_Click(sender As Object, e As EventArgs) Handles courselist_search_Button.Click
        modDb.openConn(“schooldb”)
        Dim query As String = “SELECT * FROM course_info WHERE 1=1”
        ' Add conditions based on filled search fields
        If Not String.IsNullOrWhiteSpace(course_courseid_SearchField.Text) Then
            query &= “ AND course_id LIKE @CourseID”
        End If
        If Not String.IsNullOrWhiteSpace(course_coursename_SearchField.Text) Then
            query &= “ AND course_name LIKE @CourseName”
        End If
        If Not String.IsNullOrWhiteSpace(course_coursecode_SearchField.Text) Then
            query &= “ AND course_code LIKE @CourseCode”
        End If
        If Not String.IsNullOrWhiteSpace(course_units_SearchField.Text) Then
            query &= “ AND units LIKE @Units”
        End If
        If Not String.IsNullOrWhiteSpace(course_departmentid_SearchField.Text) Then
            query &= “ AND department_id LIKE @DepartmentID”
        End If
        If Not String.IsNullOrWhiteSpace(course_programid_SearchField.Text) Then
            query &= “ AND program_id LIKE @ProgramID”
        End If
        If Not String.IsNullOrWhiteSpace(course_coursedescription_SearchField.Text) Then
            query &= “ AND course_description LIKE @CourseDescription”
        End If
        Dim table As New DataTable()
        Try
            Using command As New MySqlCommand(query, modDb.conn)
                ' Add parameter values
                If Not String.IsNullOrWhiteSpace(course_courseid_SearchField.Text) Then
                    command.Parameters.AddWithValue(“@CourseID”, “%” & course_courseid_SearchField.Text & “%”)
                End If
                If Not String.IsNullOrWhiteSpace(course_coursename_SearchField.Text) Then
                    command.Parameters.AddWithValue(“@CourseName”, “%” & course_coursename_SearchField.Text & “%”)
                End If
                If Not String.IsNullOrWhiteSpace(course_coursecode_SearchField.Text) Then
                    command.Parameters.AddWithValue(“@CourseCode”, “%” & course_coursecode_SearchField.Text & “%”)
                End If
                If Not String.IsNullOrWhiteSpace(course_units_SearchField.Text) Then
                    command.Parameters.AddWithValue(“@Units”, “%” & course_units_SearchField.Text & “%”)
                End If
                If Not String.IsNullOrWhiteSpace(course_departmentid_SearchField.Text) Then
                    command.Parameters.AddWithValue(“@DepartmentID”, “%” & course_departmentid_SearchField.Text & “%”)
                End If
                If Not String.IsNullOrWhiteSpace(course_programid_SearchField.Text) Then
                    command.Parameters.AddWithValue(“@ProgramID”, “%” & course_programid_SearchField.Text & “%”)
                End If
                If Not String.IsNullOrWhiteSpace(course_coursedescription_SearchField.Text) Then
                    command.Parameters.AddWithValue(“@CourseDescription”, “%” & course_coursedescription_SearchField.Text & “%”)
                End If
                ' Execute query and fill table
                Using adapter As New MySqlDataAdapter(command)
                    adapter.Fill(table)
                    CourseDataGridView.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(“Error: “ & ex.Message, “Database Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
        End Try
    End Sub

    Private Sub courselist_back_Button_Click(sender As Object, e As EventArgs) Handles courselist_back_Button.Click
        Dim form2 As New AdminPage()
        form2.Show()
        Me.Hide()
    End Sub
End Class