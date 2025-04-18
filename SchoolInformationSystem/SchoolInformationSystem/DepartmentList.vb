Imports MySql.Data.MySqlClient
Public Class DepartmentList
    Private Sub DepartmentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDepartmentData()
        AddDeleteAndEditButtonColumns()
    End Sub
    ' Load department data into the DataGridView
    Private Sub LoadDepartmentData()
        modDb.openConn(“schooldb”)
        Dim query As String = “SELECT * FROM department_info”
        Dim table As New DataTable()
        Try
            Using adapter As New MySqlDataAdapter(query, modDb.conn)
                adapter.Fill(table)
                DepartmentDataGridView.DataSource = table ' Bind the data to the DataGridView
            End Using
        Catch ex As Exception
            MessageBox.Show(“Error: “ & ex.Message, “Database Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
        End Try
    End Sub
    ' Handle the Add button click
    Private Sub departmentlist_add_Button_Click(sender As Object, e As EventArgs) Handles departmentlist_add_Button.Click
        Dim form2 As New AddDepartmentPageforAdmin()
        form2.Show()
        Me.Hide()
    End Sub
    ' Handle search functionality
    Private Sub departmentlist_search_Button_Click(sender As Object, e As EventArgs) Handles departmentlist_search_Button.Click
        modDb.openConn(“schooldb”)
        ' Build the search query
        Dim query As String = “SELECT * FROM department_info WHERE 1=1”
        ' Add search conditions based on input fields
        If Not String.IsNullOrWhiteSpace(department_departmentid_SearchField.Text) Then
            query &= “ AND department_id LIKE @DepartmentID”
        End If
        If Not String.IsNullOrWhiteSpace(department_departmentname_SearchField.Text) Then
            query &= “ AND department_name LIKE @DepartmentName”
        End If
        If Not String.IsNullOrWhiteSpace(department_departmenthead_SearchField.Text) Then
            query &= “ AND department_head LIKE @DepartmentHead”
        End If
        If Not String.IsNullOrWhiteSpace(department_location_SearchField.Text) Then
            query &= “ AND location LIKE @Location”
        End If
        Dim table As New DataTable()
        Try
            Using command As New MySqlCommand(query, modDb.conn)
                ' Add parameters for search fields
                If Not String.IsNullOrWhiteSpace(department_departmentid_SearchField.Text) Then
                    command.Parameters.AddWithValue(“@DepartmentID”, “%” & department_departmentid_SearchField.Text & “%”)
                End If
                If Not String.IsNullOrWhiteSpace(department_departmentname_SearchField.Text) Then
                    command.Parameters.AddWithValue(“@DepartmentName”, “%” & department_departmentname_SearchField.Text & “%”)
                End If
                If Not String.IsNullOrWhiteSpace(department_departmenthead_SearchField.Text) Then
                    command.Parameters.AddWithValue(“@DepartmentHead”, “%” & department_departmenthead_SearchField.Text & “%”)
                End If
                If Not String.IsNullOrWhiteSpace(department_location_SearchField.Text) Then
                    command.Parameters.AddWithValue(“@Location”, “%” & department_location_SearchField.Text & “%”)
                End If
                Using adapter As New MySqlDataAdapter(command)
                    adapter.Fill(table)
                    DepartmentDataGridView.DataSource = table
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
        DepartmentDataGridView.Columns.Add(deleteButton)
        Dim editButton As New DataGridViewButtonColumn()
        editButton.Name = “Edit”
        editButton.HeaderText = “Action”
        editButton.Text = “Edit”
        editButton.UseColumnTextForButtonValue = True
        DepartmentDataGridView.Columns.Add(editButton)
    End Sub
    ' Handle cell content click for Delete and Edit actions
    Private Sub DepartmentDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DepartmentDataGridView.CellContentClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DepartmentDataGridView.Rows(e.RowIndex)
            If e.ColumnIndex = DepartmentDataGridView.Columns(“Delete”).Index Then
                Dim departmentId As String = selectedRow.Cells(“department_id”).Value.ToString()
                Dim result = MessageBox.Show($”Are you sure you want to delete the department with ID {departmentId}?”,
                “Confirm Delete”, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    DeleteDepartment(departmentId)
                    LoadDepartmentData() ' Refresh data
                End If
            ElseIf e.ColumnIndex = DepartmentDataGridView.Columns(“Edit”).Index Then
                Dim departmentId As String = selectedRow.Cells(“department_id”).Value.ToString()
                Dim editForm As New EditDepartmentPage()
                editForm.DepartmentID = departmentId
                editForm.Show()
                Me.Hide()
            End If
        End If
    End Sub
    ' Delete department record
    Private Sub DeleteDepartment(departmentId As String)
        modDb.openConn(“schooldb”)
        Dim query As String = “DELETE FROM department_info WHERE department_id = @DepartmentID”
        Try
            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.AddWithValue(“@DepartmentID”, departmentId)
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show(“Department deleted successfully.”, “Success”, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show(“Department not found.”, “Error”, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(“Error: “ & ex.Message, “Database Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
        End Try
    End Sub

    Private Sub department_back_Button_Click(sender As Object, e As EventArgs) Handles department_back_Button.Click
        Dim form2 As New AdminPage()
        form2.Show()
        Me.Hide()
    End Sub
End Class