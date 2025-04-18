Imports MySql.Data.MySqlClient
Public Class AddProgramPageforAdmin
    Private Sub ProgramPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Any initialization code can go here if needed
    End Sub
    Private Sub program_add_Button_Click(sender As Object, e As EventArgs) Handles program_add_Button.Click
        AddProgram()
    End Sub
    Private Sub AddProgram()
        If String.IsNullOrWhiteSpace(program_programcode_TextBox.Text) Or
        String.IsNullOrWhiteSpace(program_programname_TextBox.Text) Or
        String.IsNullOrWhiteSpace(program_departmentid_TextBox.Text) Or
        String.IsNullOrWhiteSpace(program_programhead_TextBox.Text) Or
        String.IsNullOrWhiteSpace(program_durationyears_TextBox.Text) Then
            MessageBox.Show(“Please fill in all fields before adding the program.”)
            Exit Sub
        End If
        modDb.openConn(“schooldb”)
        Try
            Dim checkQuery As String = “SELECT COUNT(*) FROM department_info WHERE department_id = @DepartmentID”
            Using checkCommand As New MySqlCommand(checkQuery, modDb.conn)
                checkCommand.Parameters.AddWithValue(“@DepartmentID”, program_departmentid_TextBox.Text)
                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
                If count = 0 Then
                    MessageBox.Show(“The specified Department ID does not exist. Please enter a valid Department ID.”)
                    Exit Sub
                End If
            End Using
            Dim query As String = “INSERT INTO program_info (program_code, program_name, department_id, program_head, duration_years) “ &
            “VALUES (@ProgramCode, @ProgramName, @DepartmentID, @ProgramHead, @DurationYears)”
            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.AddWithValue(“@ProgramCode”, program_programcode_TextBox.Text)
                command.Parameters.AddWithValue(“@ProgramName”, program_programname_TextBox.Text)
                command.Parameters.AddWithValue(“@DepartmentID”, program_departmentid_TextBox.Text)
                command.Parameters.AddWithValue(“@ProgramHead”, program_programhead_TextBox.Text)
                command.Parameters.AddWithValue(“@DurationYears”, program_durationyears_TextBox.Text)
                command.ExecuteNonQuery()
                MessageBox.Show(“Program added successfully!”)
                ClearTextBoxes()
            End Using
        Catch ex As MySqlException
            MessageBox.Show(“An error occurred: “ & ex.Message)
        End Try
    End Sub
    Private Sub ClearTextBoxes()
        program_programcode_TextBox.Clear()
        program_programname_TextBox.Clear()
        program_departmentid_TextBox.Clear()
        program_programhead_TextBox.Clear()
        program_durationyears_TextBox.Clear()
    End Sub
    Private Sub addprogram_back_Button_Click(sender As Object, e As EventArgs) Handles addprogram_back_Button.Click
        Dim form2 As New ProgramList()
        form2.Show()
        Me.Hide()
    End Sub
End Class