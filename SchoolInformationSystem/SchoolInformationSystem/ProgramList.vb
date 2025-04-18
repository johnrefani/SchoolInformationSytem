Imports MySql.Data.MySqlClient
Public Class ProgramList
    Private Sub ProgramList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProgramData()
        AddDeleteAndEditButtonColumns()
    End Sub
    ' Load program data into the DataGridView
    Private Sub LoadProgramData()
        modDb.openConn(“schooldb”)
        Dim query As String = “SELECT * FROM program_info”
        Dim table As New DataTable()
        Try
            Using adapter As New MySqlDataAdapter(query, modDb.conn)
                adapter.Fill(table)
                ProgramDataGridView.DataSource = table ' Bind the data to the DataGridView
            End Using
        Catch ex As Exception
            MessageBox.Show(“Error: “ & ex.Message, “Database Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
        End Try
    End Sub
    ' Handle the Add button click
    Private Sub programlist_add_Button_Click(sender As Object, e As EventArgs) Handles programlist_add_Button.Click
        Dim form2 As New AddProgramPageforAdmin
        form2.Show()
        Hide()
    End Sub
    ' Handle search functionality
    Private Sub programlist_search_Button_Click(sender As Object, e As EventArgs) Handles programlist_search_Button.Click
        modDb.openConn(“schooldb”)
        Dim query As String = “SELECT * FROM program_info WHERE 1=1”
        ' Add search conditions based on input fields
        If Not String.IsNullOrWhiteSpace(program_programid_SearchField.Text) Then
            query &= “ AND program_id LIKE @ProgramID”
        End If
        If Not String.IsNullOrWhiteSpace(program_programname_SearchField.Text) Then
            query &= “ AND program_name LIKE @ProgramName”
        End If
        If Not String.IsNullOrWhiteSpace(program_programhead_SearchField.Text) Then
            query &= “ AND program_head LIKE @ProgramHead”
        End If
        If Not String.IsNullOrWhiteSpace(program_programcode_SearchField.Text) Then
            query &= “ AND program_code LIKE @ProgramCode”
        End If
        If Not String.IsNullOrWhiteSpace(program_departmentid_SearchField.Text) Then
            query &= “ AND department_id LIKE @DepartmentID”
        End If
        If Not String.IsNullOrWhiteSpace(program_durationyears_SearchField.Text) Then
            query &= “ AND duration_years LIKE @DurationYears”
        End If
        Dim table As New DataTable()
        Try
            Using command As New MySqlCommand(query, modDb.conn)
                If Not String.IsNullOrWhiteSpace(program_programid_SearchField.Text) Then
                    command.Parameters.AddWithValue(“@ProgramID”, “%” & program_programid_SearchField.Text & “%”)
                End If
                If Not String.IsNullOrWhiteSpace(program_programname_SearchField.Text) Then
                    command.Parameters.AddWithValue(“@ProgramName”, “%” & program_programname_SearchField.Text & “%”)
                End If
                If Not String.IsNullOrWhiteSpace(program_programhead_SearchField.Text) Then
                    command.Parameters.AddWithValue(“@ProgramHead”, “%” & program_programhead_SearchField.Text & “%”)
                End If
                If Not String.IsNullOrWhiteSpace(program_programcode_SearchField.Text) Then
                    command.Parameters.AddWithValue(“@ProgramCode”, “%” & program_programcode_SearchField.Text & “%”)
                End If
                If Not String.IsNullOrWhiteSpace(program_departmentid_SearchField.Text) Then
                    command.Parameters.AddWithValue(“@DepartmentID”, “%” & program_departmentid_SearchField.Text & “%”)
                End If
                If Not String.IsNullOrWhiteSpace(program_durationyears_SearchField.Text) Then
                    command.Parameters.AddWithValue(“@DurationYears”, “%” & program_durationyears_SearchField.Text & “%”)
                End If
                Using adapter As New MySqlDataAdapter(command)
                    adapter.Fill(table)
                    ProgramDataGridView.DataSource = table
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
        If ProgramDataGridView.Columns(“Delete”) Is Nothing Then
            Dim deleteButton As New DataGridViewButtonColumn()
            deleteButton.Name = “Delete”
            deleteButton.HeaderText = “Action”
            deleteButton.Text = “Delete”
            deleteButton.UseColumnTextForButtonValue = True
            ProgramDataGridView.Columns.Add(deleteButton)
        End If
        If ProgramDataGridView.Columns(“Edit”) Is Nothing Then
            Dim editButton As New DataGridViewButtonColumn()
            editButton.Name = “Edit”
            editButton.HeaderText = “Action”
            editButton.Text = “Edit”
            editButton.UseColumnTextForButtonValue = True
            ProgramDataGridView.Columns.Add(editButton)
        End If
    End Sub
    ' Handle cell content click for Delete and Edit actions
    Private Sub ProgramDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProgramDataGridView.CellContentClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = ProgramDataGridView.Rows(e.RowIndex)
            If e.ColumnIndex = ProgramDataGridView.Columns(“Delete”).Index Then
                Dim programId As String = selectedRow.Cells(“program_id”).Value.ToString()
                Dim result = MessageBox.Show($”Are you sure you want to delete the program with ID {programId}?”,
                “Confirm Delete”, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    DeleteProgram(programId)
                    LoadProgramData() ' Refresh data
                End If
            ElseIf e.ColumnIndex = ProgramDataGridView.Columns(“Edit”).Index Then
                Dim programId As String = selectedRow.Cells(“program_id”).Value.ToString()
                Dim editForm As New EditProgramPage()
                editForm.ProgramID = programId
                editForm.Show()
                Hide()
            End If
        End If
    End Sub
    ' Delete program record
    Private Sub DeleteProgram(programId As String)
        modDb.openConn(“schooldb”)
        Dim query As String = “DELETE FROM program_info WHERE program_id = @ProgramID”
        Try
            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.AddWithValue(“@ProgramID”, programId)
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show(“Program deleted successfully.”, “Success”, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show(“Program not found.”, “Error”, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(“Error: “ & ex.Message, “Database Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
        End Try
    End Sub

    Private Sub program_back_Button_Click(sender As Object, e As EventArgs) Handles program_back_Button.Click
        Dim form2 As New AdminPage()
        form2.Show()
        Me.Hide()
    End Sub
End Class