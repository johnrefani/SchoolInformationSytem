Imports MySql.Data.MySqlClient
Public Class EditBlockPage
    Public Property BlockID As String ' Property to hold the Block ID being edited
    Private Sub EditBlockPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBlockDetails() ' Load existing details of the selected block
    End Sub
    ' Load block details based on BlockID
    Private Sub LoadBlockDetails()
        modDb.openConn(“schooldb”)
        Dim query As String = “SELECT * FROM block_info WHERE block_id = @BlockID”
        Try
            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.AddWithValue(“@BlockID”, BlockID)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Assuming these TextBoxes exist in your form
                        block_blockid_TextBox.Text = reader(“block_id”).ToString()
                        block_blockcode_TextBox.Text = reader(“block_code”).ToString()
                        block_programid_TextBox.Text = reader(“program_id”).ToString()
                        block_studentid_TextBox.Text = reader(“student_id”).ToString()
                        block_semester_TextBox.Text = reader(“semester”).ToString()
                    Else
                        MessageBox.Show(“Block not found.”, “Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.Close()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(“Error: “ & ex.Message, “Database Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
        End Try
    End Sub
    ' Save button click event to update the block details
    ' Save button click event to update the block details
    Private Sub editblock_save_Button_Click(sender As Object, e As EventArgs) Handles editblock_save_Button.Click
        If ValidateInput() Then
            If String.IsNullOrEmpty(BlockID) Then
                MessageBox.Show(“Block ID is not set. Unable to update.”, “Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            modDb.openConn(“schooldb”)
            Dim query As String = “UPDATE block_info SET block_code = @BlockCode, program_id = @ProgramID, student_id = @StudentID, semester = @Semester WHERE block_id = @BlockID”
            Try
                Using command As New MySqlCommand(query, modDb.conn)
                    ' Add parameters for the query
                    command.Parameters.AddWithValue(“@BlockCode”, block_blockcode_TextBox.Text.Trim())
                    command.Parameters.AddWithValue(“@ProgramID”, block_programid_TextBox.Text.Trim())
                    command.Parameters.AddWithValue(“@StudentID”, block_studentid_TextBox.Text.Trim())
                    command.Parameters.AddWithValue(“@Semester”, block_semester_TextBox.Text.Trim())
                    command.Parameters.AddWithValue(“@BlockID”, BlockID.Trim())
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show(“Block details updated successfully.”, “Success”, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim addForm As New BlockList()
                        addForm.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show(“No changes made or block not found. Please check the Block ID.”, “Information”, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            Catch ex As MySqlException
                MessageBox.Show(“An error occurred: “ & ex.Message, “Database Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
            End Try
        End If
    End Sub
    ' Validate input fields before saving
    Private Function ValidateInput() As Boolean
        If String.IsNullOrEmpty(block_blockcode_TextBox.Text.Trim()) OrElse
        String.IsNullOrEmpty(block_programid_TextBox.Text.Trim()) OrElse
        String.IsNullOrEmpty(block_blockid_TextBox.Text.Trim()) OrElse
        String.IsNullOrEmpty(block_studentid_TextBox.Text.Trim()) OrElse
        String.IsNullOrEmpty(block_semester_TextBox.Text.Trim()) Then
            MessageBox.Show(“Please fill out all fields.”, “Validation Error”, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function
    ' Cancel button to close the form
    Private Sub editblock_cancel_Button_Click(sender As Object, e As EventArgs) Handles editblock_cancel_Button.Click
        Dim addForm As New BlockList()
        addForm.Show()
        Me.Hide()
    End Sub
End Class