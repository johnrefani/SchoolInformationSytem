Imports MySql.Data.MySqlClient
Public Class StudentList
    Private Sub StudentProfilePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudentData()
        AddDeleteButtonColumn()
    End Sub
    ' Method to load student data into the DataGridView
    Private Sub LoadStudentData()
        modDb.openConn(“schooldb”)
        Dim query As String = “SELECT * FROM student_info”
        Dim table As New DataTable()
        Try
            Using adapter As New MySqlDataAdapter(query, modDb.conn)
                adapter.Fill(table)
                StudentsDataGridView.DataSource = table ' Bind the DataTable to the DataGridView
            End Using
        Catch ex As Exception
            MessageBox.Show(“Error in loading student data: “ & ex.Message)
        Finally
            If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
        End Try
    End Sub
    ' Handle the CellContentClick event to display student details when a cell is clicked
    Private Sub StudentsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentsDataGridView.CellContentClick
        ' Ensure the click is within bounds
        If e.RowIndex >= 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = StudentsDataGridView.Rows(e.RowIndex)
            ' Handle Delete button click
            If e.ColumnIndex = StudentsDataGridView.Columns(“Delete”).Index Then
                Dim studentId As String = Convert.ToString(selectedRow.Cells(“student_id”).Value)
                ' Confirm deletion
                Dim result = MessageBox.Show($”Are you sure you want to delete the student with ID {studentId}?”,
                “Confirm Delete”, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    DeleteStudent(studentId)
                    LoadStudentData() ' Refresh data after deletion
                End If
                ' Handle Edit button click
            ElseIf e.ColumnIndex = StudentsDataGridView.Columns(“Edit”).Index Then
                Dim studentId As String = Convert.ToString(selectedRow.Cells(“student_id”).Value)
                ' Open the Edit Form and pass the Student ID
                Dim editForm As New EditStudentPage()
                editForm.StudentID = studentId ' Pass the ID to the form
                editForm.Show()
                Me.Hide() ' Hide the current form
            End If
        End If
    End Sub
    Private Sub student_add_Button_Click(sender As Object, e As EventArgs) Handles studentlist_add_Button.Click
        Dim form2 As New AddStudentPage
        form2.Show()
        Hide()
    End Sub
    Private Sub AddDeleteButtonColumn()
        Dim deleteButton As New DataGridViewButtonColumn()
        deleteButton.Name = “Delete”
        deleteButton.HeaderText = “Action”
        deleteButton.Text = “Delete”
        deleteButton.UseColumnTextForButtonValue = True
        StudentsDataGridView.Columns.Add(deleteButton)
        Dim editButton As New DataGridViewButtonColumn()
        editButton.Name = “Edit”
        editButton.HeaderText = “Action”
        editButton.Text = “Edit”
        editButton.UseColumnTextForButtonValue = True
        StudentsDataGridView.Columns.Add(editButton)
    End Sub
    Private Sub DeleteStudent(studentId As String)
        modDb.openConn(“schooldb”)
        Try
            Dim query As String = “DELETE FROM student_info WHERE student_id = @StudentID”
            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.AddWithValue(“@StudentID”, studentId)
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show(“Student deleted successfully.”, “Success”, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show(“Student not found.”, “Error”, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        Catch ex As MySqlException
            MessageBox.Show(“An error occurred: “ & ex.Message, “Database Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            modDb.conn.Close()
        End Try
    End Sub
    Private Sub studentlist_search_Button_Click(sender As Object, e As EventArgs) Handles studentlist_search_Button.Click
        modDb.openConn(“schooldb”)
        ' Build the base query
        Dim query As String = “SELECT * FROM student_info WHERE 1=1”
        ' Add conditions based on filled search fields
        If Not String.IsNullOrWhiteSpace(student_idnumber_SearchField.Text) Then
            query &= “ AND student_id LIKE @StudentID”
        End If
        If Not String.IsNullOrWhiteSpace(student_lastname_SearchField.Text) Then
            query &= “ AND last_name LIKE @LastName”
        End If
        If Not String.IsNullOrWhiteSpace(student_firstname_SearchField.Text) Then
            query &= “ AND first_name LIKE @FirstName”
        End If
        If Not String.IsNullOrWhiteSpace(student_middlename_SearchField.Text) Then
            query &= “ AND middlename LIKE @MiddleName”
        End If
        If Not String.IsNullOrWhiteSpace(student_yl_SearchField.Text) Then
            query &= “ AND current_year LIKE @CurrentYear”
        End If
        If Not String.IsNullOrWhiteSpace(student_gender_SearchField.Text) Then
            query &= “ AND gender LIKE @Gender”
        End If
        ' Add other search field conditions as needed…
        Dim table As New DataTable()
        Try
            Using command As New MySqlCommand(query, modDb.conn)
                ' Add parameter values
                If Not String.IsNullOrWhiteSpace(student_idnumber_SearchField.Text) Then
                    command.Parameters.AddWithValue(“@StudentID”, “%” & student_idnumber_SearchField.Text & “%”)
                End If
                If Not String.IsNullOrWhiteSpace(student_lastname_SearchField.Text) Then
                    command.Parameters.AddWithValue(“@LastName”, “%” & student_lastname_SearchField.Text & “%”)
                End If
                If Not String.IsNullOrWhiteSpace(student_firstname_SearchField.Text) Then
                    command.Parameters.AddWithValue(“@FirstName”, “%” & student_firstname_SearchField.Text & “%”)
                End If
                If Not String.IsNullOrWhiteSpace(student_middlename_SearchField.Text) Then
                    command.Parameters.AddWithValue(“@MiddleName”, “%” & student_middlename_SearchField.Text & “%”)
                End If
                If Not String.IsNullOrWhiteSpace(student_yl_SearchField.Text) Then
                    command.Parameters.AddWithValue(“@CurrentYear”, “%” & student_yl_SearchField.Text & “%”)
                End If
                If Not String.IsNullOrWhiteSpace(student_gender_SearchField.Text) Then
                    command.Parameters.AddWithValue(“@Gender”, “%” & student_gender_SearchField.Text & “%”)
                End If
                ' Add other parameters as needed…
                Using adapter As New MySqlDataAdapter(command)
                    adapter.Fill(table)
                    StudentsDataGridView.DataSource = table ' Display results in the DataGridView
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(“Error in searching: “ & ex.Message, “Database Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
        End Try
    End Sub

    Private Sub studentlist_back_button_Click(sender As Object, e As EventArgs) Handles studentlist_back_button.Click
        Dim form2 As New AdminPage()
        form2.Show()
        Me.Hide()

    End Sub
End Class