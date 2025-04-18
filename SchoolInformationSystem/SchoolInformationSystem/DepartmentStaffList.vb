Imports MySql.Data.MySqlClient
Public Class DepartmentStaffList
    Private Sub DepartmentStaffList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDepartmentStaffData()
        AddDeleteAndEditButtonColumns()
    End Sub
    ' Load department staff data into the DataGridView
    Private Sub LoadDepartmentStaffData()
        modDb.openConn(“schooldb”)
        Dim query As String = “SELECT * FROM department_staff_info”
        Dim table As New DataTable()
        Try
            Using adapter As New MySqlDataAdapter(query, modDb.conn)
                adapter.Fill(table)
                ' Loop through rows and handle DATETIME conversion
                For Each row As DataRow In table.Rows
                    ' Assuming the hire_date column is of DATETIME type
                    If Not IsDBNull(row(“hire_date”)) Then
                        ' Safely convert the MySQL DATETIME to .NET DateTime
                        Dim hireDate As DateTime = Convert.ToDateTime(row(“hire_date”))
                        ' You can now use hireDate as a .NET DateTime object
                        ' For example, you could display or bind it to a control
                        row(“hire_date”) = hireDate
                    End If
                Next
                DepartmentStaffDataGridView.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show(“Error: “ & ex.Message, “Database Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ' Handle the Add button click
    Private Sub departmentstafflist_add_Button_Click(sender As Object, e As EventArgs) Handles departmentstafflist_add_Button.Click
        Dim form2 As New AddDepartmentStaffPageforAdmin()
        form2.Show()
        Me.Hide()
    End Sub
    ' Handle search functionality
    Private Sub departmentstafflist_search_Button_Click(sender As Object, e As EventArgs) Handles departmentstafflist_search_Button.Click
        modDb.openConn(“schooldb”)
        ' Build the search query
        Dim query As String = BuildSearchQuery()
        Dim table As New DataTable()
        Try
            Using command As New MySqlCommand(query, modDb.conn)
                ' Add parameters for search fields
                AddSearchParameters(command)
                Using adapter As New MySqlDataAdapter(command)
                    adapter.Fill(table)
                    DepartmentStaffDataGridView.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(“Error: “ & ex.Message, “Database Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ' Build search query based on input fields
    Private Function BuildSearchQuery() As String
        Dim query As String = “SELECT * FROM department_staff_info WHERE 1=1”
        If Not String.IsNullOrWhiteSpace(departmentstaff_staffid_SearchField.Text) Then
            query &= “ AND staff_id LIKE @StaffID”
        End If
        If Not String.IsNullOrWhiteSpace(departmentstaff_lastname_SearchField.Text) Then
            query &= “ AND last_name LIKE @LastName”
        End If
        If Not String.IsNullOrWhiteSpace(departmentstaff_firstname_SearchField.Text) Then
            query &= “ AND first_name LIKE @FirstName”
        End If
        If Not String.IsNullOrWhiteSpace(departmentstaff_middlename_SearchField.Text) Then
            query &= “ AND middle_name LIKE @MiddleName”
        End If
        If Not String.IsNullOrWhiteSpace(departmentstaff_position_SearchField.Text) Then
            query &= “ AND position LIKE @Position”
        End If
        If Not String.IsNullOrWhiteSpace(departmentstaff_departmentid_SearchField.Text) Then
            query &= “ AND department_id LIKE @DepartmentID”
        End If
        If Not String.IsNullOrWhiteSpace(departmentstaff_hiredate_SearchField.Text) Then
            query &= “ AND hire_date LIKE @HireDate”
        End If
        If Not String.IsNullOrWhiteSpace(departmentstaff_email_SearchField.Text) Then
            query &= “ AND email LIKE @Email”
        End If
        If Not String.IsNullOrWhiteSpace(departmentstaff_gender_SearchField.Text) Then
            query &= “ AND gender LIKE @Gender”
        End If
        Return query
    End Function
    ' Add search parameters to the command
    Private Sub AddSearchParameters(command As MySqlCommand)
        If Not String.IsNullOrWhiteSpace(departmentstaff_staffid_SearchField.Text) Then
            command.Parameters.AddWithValue(“@StaffID”, “%” & departmentstaff_staffid_SearchField.Text & “%”)
        End If
        If Not String.IsNullOrWhiteSpace(departmentstaff_lastname_SearchField.Text) Then
            command.Parameters.AddWithValue(“@LastName”, “%” & departmentstaff_lastname_SearchField.Text & “%”)
        End If
        If Not String.IsNullOrWhiteSpace(departmentstaff_firstname_SearchField.Text) Then
            command.Parameters.AddWithValue(“@FirstName”, “%” & departmentstaff_firstname_SearchField.Text & “%”)
        End If
        If Not String.IsNullOrWhiteSpace(departmentstaff_middlename_SearchField.Text) Then
            command.Parameters.AddWithValue(“@MiddleName”, “%” & departmentstaff_middlename_SearchField.Text & “%”)
        End If
        If Not String.IsNullOrWhiteSpace(departmentstaff_position_SearchField.Text) Then
            command.Parameters.AddWithValue(“@Position”, “%” & departmentstaff_position_SearchField.Text & “%”)
        End If
        If Not String.IsNullOrWhiteSpace(departmentstaff_departmentid_SearchField.Text) Then
            command.Parameters.AddWithValue(“@DepartmentID”, “%” & departmentstaff_departmentid_SearchField.Text & “%”)
        End If
        If Not String.IsNullOrWhiteSpace(departmentstaff_hiredate_SearchField.Text) Then
            command.Parameters.AddWithValue(“@HireDate”, “%” & departmentstaff_hiredate_SearchField.Text & “%”)
        End If
        If Not String.IsNullOrWhiteSpace(departmentstaff_email_SearchField.Text) Then
            command.Parameters.AddWithValue(“@Email”, “%” & departmentstaff_email_SearchField.Text & “%”)
        End If
        If Not String.IsNullOrWhiteSpace(departmentstaff_gender_SearchField.Text) Then
            command.Parameters.AddWithValue(“@Gender”, “%” & departmentstaff_gender_SearchField.Text & “%”)
        End If
    End Sub
    ' Add Delete and Edit button columns to the DataGridView
    Private Sub AddDeleteAndEditButtonColumns()
        AddButtonColumn(“Delete”, “Action”, “Delete”)
        AddButtonColumn(“Edit”, “Action”, “Edit”)
    End Sub
    ' Helper method to add button columns
    Private Sub AddButtonColumn(name As String, header As String, text As String)
        Dim buttonColumn As New DataGridViewButtonColumn()
        buttonColumn.Name = name
        buttonColumn.HeaderText = header
        buttonColumn.Text = text
        buttonColumn.UseColumnTextForButtonValue = True
        DepartmentStaffDataGridView.Columns.Add(buttonColumn)
    End Sub
    ' Handle cell content click for Delete and Edit actions
    Private Sub DepartmentStaffDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DepartmentStaffDataGridView.CellContentClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DepartmentStaffDataGridView.Rows(e.RowIndex)
            If e.ColumnIndex = DepartmentStaffDataGridView.Columns(“Delete”).Index Then
                Dim staffId As String = selectedRow.Cells(“staff_id”).Value.ToString()
                Dim staffName As String = selectedRow.Cells(“first_name”).Value.ToString() & “ “ & selectedRow.Cells(“last_name”).Value.ToString()
                Dim result = MessageBox.Show($”Are you sure you want to delete {staffName} (ID: {staffId})?”,
                “Confirm Delete”, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    DeleteDepartmentStaff(staffId)
                    LoadDepartmentStaffData() ' Refresh data
                End If
            ElseIf e.ColumnIndex = DepartmentStaffDataGridView.Columns(“Edit”).Index Then
                Dim staffId As String = selectedRow.Cells(“staff_id”).Value.ToString()
                Dim editForm As New EditDepartmentStaffPage()
                editForm.StaffID = staffId
                editForm.Show()
                Me.Hide()
            End If
        End If
    End Sub
    ' Delete department staff record
    Private Sub DeleteDepartmentStaff(staffId As String)
        modDb.openConn(“schooldb”)
        Dim query As String = “DELETE FROM department_staff_info WHERE staff_id = @StaffID”
        Try
            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.AddWithValue(“@StaffID”, staffId)
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show(“Staff deleted successfully.”, “Success”, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show(“Staff not found.”, “Error”, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(“Error: “ & ex.Message, “Database Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub departmentstaff_back_Button_Click(sender As Object, e As EventArgs) Handles departmentstaff_back_Button.Click
        Dim form2 As New AdminPage()
        form2.Show()
        Me.Hide()
    End Sub
End Class