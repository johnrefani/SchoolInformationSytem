Imports MySql.Data.MySqlClient
Public Class AddBlockPageforAdmin
    Private Sub BlockPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub AddBlockInfo()
        If String.IsNullOrWhiteSpace(block_blockid_TextBox.Text) Or
        String.IsNullOrWhiteSpace(block_blockcode_TextBox.Text) Or
        String.IsNullOrWhiteSpace(block_programid_TextBox.Text) Or
        String.IsNullOrWhiteSpace(block_studentid_TextBox.Text) Or
        String.IsNullOrWhiteSpace(block_semester_TextBox.Text) Then
            MessageBox.Show(“Please fill in all fields before adding the block.”)
            Exit Sub
        End If
        modDb.openConn(“schooldb”)
        Try
            Dim programExists As Boolean = CheckIfExists(“program_info”, “program_id”, block_programid_TextBox.Text)
            If Not programExists Then
                MessageBox.Show(“The Program ID does not exist. Please enter a valid Program ID.”)
                Exit Sub
            End If
            Dim studentExists As Boolean = CheckIfExists(“student_info”, “student_id”, block_studentid_TextBox.Text)
            If Not studentExists Then
                MessageBox.Show(“The Student ID does not exist. Please enter a valid Student ID.”)
                Exit Sub
            End If
            Dim query As String = “INSERT INTO block_info (block_id, block_code, program_id, semester, student_id) “ &
            “VALUES (@BlockID, @BlockCode, @ProgramID, @Semester, @StudentID)”
            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.AddWithValue(“@BlockID”, block_blockid_TextBox.Text)
                command.Parameters.AddWithValue(“@BlockCode”, block_blockcode_TextBox.Text)
                command.Parameters.AddWithValue(“@ProgramID”, block_programid_TextBox.Text)
                command.Parameters.AddWithValue(“@Semester”, block_semester_TextBox.Text)
                command.Parameters.AddWithValue(“@StudentID”, block_studentid_TextBox.Text)
                command.ExecuteNonQuery()
                MessageBox.Show(“Block information added successfully!”)
                ClearTextBoxes()
            End Using
        Catch ex As MySqlException
            MessageBox.Show(“An error occurred: “ & ex.Message)
        End Try
    End Sub
    Private Function CheckIfExists(tableName As String, columnName As String, value As String) As Boolean
        Dim query As String = $”SELECT COUNT(*) FROM {tableName} WHERE {columnName} = @Value”
        Using command As New MySqlCommand(query, modDb.conn)
            command.Parameters.AddWithValue(“@Value”, value)
            Return Convert.ToInt32(command.ExecuteScalar()) > 0
        End Using
    End Function
    Private Sub ClearTextBoxes()
        block_blockid_TextBox.Clear()
        block_blockcode_TextBox.Clear()
        block_programid_TextBox.Clear()
        block_studentid_TextBox.Clear()
        block_semester_TextBox.Clear()
    End Sub
    Private Sub block_add_Button_Click(sender As Object, e As EventArgs) Handles block_add_Button.Click
        AddBlockInfo()
    End Sub
    Private Sub addblock_back_Button_Click(sender As Object, e As EventArgs) Handles addblock_back_Button.Click
        Dim form2 As New BlockList()
        form2.Show()
        Me.Close()
    End Sub

End Class