Imports MySql.Data.MySqlClient
Public Class EditProgramPage
    ' Property to store the Program ID passed from another form
    Public Property ProgramID As String
    ' Load the program details when the form loads
    Private Sub EditProgramPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not String.IsNullOrEmpty(ProgramID) Then
            LoadProgramDetails(ProgramID)
        Else
            MessageBox.Show(“No Program ID provided.”, “Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
    End Sub
    ' Load program details from the database
    Private Sub LoadProgramDetails(programId As String)
        modDb.openConn(“schooldb”)
        Dim query As String = “SELECT * FROM program_info WHERE program_id = @ProgramID”
        Try
            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.AddWithValue(“@ProgramID”, programId)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Map database fields to form controls
                        Program_programid_TextBox.Text = reader(“program_id”).ToString()
                        Program_programname_TextBox.Text = reader(“program_name”).ToString()
                        Program_programhead_TextBox.Text = If(IsDBNull(reader(“program_head”)), “”, reader(“program_head”).ToString())
                        Program_programcode_TextBox.Text = reader(“program_code”).ToString()
                        Program_departmentid_TextBox.Text = reader(“department_id”).ToString()
                        Program_durationyears_TextBox.Text = reader(“duration_years”).ToString()
                    Else
                        MessageBox.Show(“Program not found.”, “Error”, MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
    ' Handle the Save button click
    Private Sub editprogram_save_Button_Click(sender As Object, e As EventArgs) Handles editprogram_save_Button.Click
        If ValidateInputs() Then
            UpdateProgramDetails()
        End If
    End Sub
    ' Validate form inputs
    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(program_programname_TextBox.Text) Then
            MessageBox.Show(“Program name cannot be empty.”, “Validation Error”, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(program_programhead_TextBox.Text) Then
            MessageBox.Show(“Program head cannot be empty.”, “Validation Error”, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(program_programcode_TextBox.Text) Then
            MessageBox.Show(“Program code cannot be empty.”, “Validation Error”, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(program_departmentid_TextBox.Text) Then
            MessageBox.Show(“Department ID cannot be empty.”, “Validation Error”, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If Not Integer.TryParse(program_durationyears_TextBox.Text, Nothing) Then
            MessageBox.Show(“Duration years must be a valid number.”, “Validation Error”, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function
    ' Update program details in the database
    Private Sub UpdateProgramDetails()
        modDb.openConn(“schooldb”)
        Dim query As String = “UPDATE program_info SET program_name = @ProgramName, “ &
        “program_head = @ProgramHead, program_code = @ProgramCode, “ &
        “department_id = @DepartmentID, duration_years = @DurationYears “ &
        “WHERE program_id = @ProgramID”
        Try
            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.AddWithValue(“@ProgramName”, program_programname_TextBox.Text)
                command.Parameters.AddWithValue(“@ProgramHead”, program_programhead_TextBox.Text)
                command.Parameters.AddWithValue(“@ProgramCode”, program_programcode_TextBox.Text)
                command.Parameters.AddWithValue(“@DepartmentID”, program_departmentid_TextBox.Text)
                command.Parameters.AddWithValue(“@DurationYears”, Integer.Parse(program_durationyears_TextBox.Text))
                command.Parameters.AddWithValue(“@ProgramID”, program_programid_TextBox.Text)
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show(“Program updated successfully.”, “Success”, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim programListForm As New ProgramList()
                    programListForm.Show()
                    Me.Close()
                Else
                    MessageBox.Show(“No changes were made. Please review the input.”, “Warning”, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(“Error: “ & ex.Message, “Database Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
        End Try
    End Sub
    ' Handle Cancel button click
    Private Sub editprogram_cancel_Button_Click(sender As Object, e As EventArgs) Handles editprogram_cancel_Button.Click
        Dim programListForm As New ProgramList()
        programListForm.Show()
        Me.Close()
    End Sub

    Private Sub Program_programcode_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Program_programcode_TextBox.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class