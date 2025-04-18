Imports MySql.Data.MySqlClient
Public Class BlockList
    Private Sub BlockList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBlockData()
        AddDeleteButtonColumn()
    End Sub
    ' Load block data into the DataGridView
    Private Sub LoadBlockData()
        modDb.openConn(“schooldb”)
        Dim query As String = “SELECT * FROM block_info”
        Dim table As New DataTable()
        Try
            Using adapter As New MySqlDataAdapter(query, modDb.conn)
                adapter.Fill(table)
                BlockDataGridView.DataSource = table ' Bind the DataTable to the DataGridView
            End Using
        Catch ex As Exception
            MessageBox.Show(“Error: “ & ex.Message)
        Finally
            If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
        End Try
    End Sub
    ' Add Delete and Edit buttons to the DataGridView
    Private Sub AddDeleteButtonColumn()
        Dim deleteButton As New DataGridViewButtonColumn()
        deleteButton.Name = “Delete”
        deleteButton.HeaderText = “Action”
        deleteButton.Text = “Delete”
        deleteButton.UseColumnTextForButtonValue = True
        BlockDataGridView.Columns.Add(deleteButton)
        Dim editButton As New DataGridViewButtonColumn()
        editButton.Name = “Edit”
        editButton.HeaderText = “Action”
        editButton.Text = “Edit”
        editButton.UseColumnTextForButtonValue = True
        BlockDataGridView.Columns.Add(editButton)
    End Sub
    ' Handle DataGridView cell clicks for Edit/Delete actions
    Private Sub BlockDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BlockDataGridView.CellContentClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = BlockDataGridView.Rows(e.RowIndex)
            If e.ColumnIndex = BlockDataGridView.Columns(“Delete”).Index Then
                Dim blockId As String = Convert.ToString(selectedRow.Cells(“block_id”).Value)
                Dim result = MessageBox.Show($”Are you sure you want to delete the block with ID {blockId}?”,
                “Confirm Delete”, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    DeleteBlock(blockId)
                    LoadBlockData() ' Refresh data
                End If
            ElseIf e.ColumnIndex = BlockDataGridView.Columns(“Edit”).Index Then
                Dim blockId As String = Convert.ToString(selectedRow.Cells(“block_id”).Value)
                Dim editForm As New EditBlockPage()
                editForm.BlockID = blockId ' Pass Block ID
                editForm.Show()
                Me.Hide()
            End If
        End If
    End Sub
    ' Delete block from database
    Private Sub DeleteBlock(blockId As String)
        modDb.openConn(“schooldb”)
        Try
            Dim query As String = “DELETE FROM block_info WHERE block_id = @BlockID”
            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.AddWithValue(“@BlockID”, blockId)
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show(“Block deleted successfully.”, “Success”, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show(“Block not found.”, “Error”, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        Catch ex As MySqlException
            MessageBox.Show(“An error occurred: “ & ex.Message, “Database Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            modDb.conn.Close()
        End Try
    End Sub
    ' Add new block
    Private Sub blocklist_add_Button_Click(sender As Object, e As EventArgs) Handles blocklist_add_Button.Click
        Dim addForm As New AddBlockPageforAdmin()
        addForm.Show()
        Me.Hide()
    End Sub
    ' Search functionality for blocks
    Private Sub blocklist_search_Button_Click(sender As Object, e As EventArgs) Handles blocklist_search_Button.Click
        modDb.openConn(“schooldb”)
        Dim query As String = “SELECT * FROM block_info WHERE 1=1”
        Dim parameters As New Dictionary(Of String, String)
        ' Map search fields to database columns
        Dim searchFields As New Dictionary(Of String, TextBox) From {
        {“block_id”, block_blockid_SearchField},
        {“block_code”, block_bloblock_blockcode_SearchFieldckcode_TextBox},
        {“program_id”, block_programid_SearchField},
        {“student_id”, block_studentid_SearchField},
        {“semester”, block_semester_SearchField}
        }
        For Each field In searchFields
            Dim value As String = field.Value.Text.Trim()
            If Not String.IsNullOrEmpty(value) Then
                query &= $” AND {field.Key} LIKE @{field.Key}”
                parameters.Add(field.Key, “%” & value & “%”)
            End If
        Next
        Dim table As New DataTable()
        Try
            Using command As New MySqlCommand(query, modDb.conn)
                For Each param In parameters
                    command.Parameters.AddWithValue(“@” & param.Key, param.Value)
                Next
                Using adapter As New MySqlDataAdapter(command)
                    adapter.Fill(table)
                    BlockDataGridView.DataSource = table
                End Using
            End Using
            If table.Rows.Count = 0 Then
                MessageBox.Show(“No matching blocks found.”, “Search Results”, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(“Error: “ & ex.Message, “Database Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
        End Try
    End Sub

    Private Sub blocklist_back_Button_Click(sender As Object, e As EventArgs) Handles blocklist_back_Button.Click
        Dim form2 As New AdminPage()
        form2.Show()
        Me.Hide()
    End Sub
End Class