Imports MySql.Data.MySqlClient
Public Class EditDepartmentPage
    ' Property to store the Department ID passed from another form
    Public Property DepartmentID As String
    ' Load the department details when the form loads
    Private Sub EditDepartmentPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not String.IsNullOrEmpty(DepartmentID) Then
            LoadDepartmentDetails(DepartmentID)
        Else
            MessageBox.Show(“No Department ID provided.”, “Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
    End Sub
    ' Load department details from the database
    Private Sub LoadDepartmentDetails(departmentId As String)
        modDb.openConn(“schooldb”)
        Dim query As String = “SELECT * FROM department_info WHERE department_id = @DepartmentID”
        Try
            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.AddWithValue(“@DepartmentID”, departmentId)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Map database fields to form controls
                        department_departmentid_TextBox.Text = reader(“department_id”).ToString()
                        department_departmentname_TextBox.Text = reader(“department_name”).ToString()
                        department_departmenthead_TextBox.Text = reader(“department_head”).ToString()
                        department_location_TextBox.Text = reader(“location”).ToString()
                    Else
                        MessageBox.Show(“Department not found.”, “Error”, MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
    Private Sub editdepartment_save_Button_Click(sender As Object, e As EventArgs) Handles editdepartment_save_Button.Click
        If ValidateInputs() Then
            UpdateDepartmentDetails()
        End If
    End Sub
    ' Validate form inputs
    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(department_departmentname_TextBox.Text) Then
            MessageBox.Show(“Department name cannot be empty.”, “Validation Error”, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(department_departmenthead_TextBox.Text) Then
            MessageBox.Show(“Department head cannot be empty.”, “Validation Error”, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function
    ' Update department details in the database
    Private Sub UpdateDepartmentDetails()
        modDb.openConn(“schooldb”)
        Dim query As String = “UPDATE department_info SET department_name = @DepartmentName, “ &
        “department_head = @DepartmentHead, location = @Location “ &
        “WHERE department_id = @DepartmentID”
        Try
            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.AddWithValue(“@DepartmentName”, department_departmentname_TextBox.Text)
                command.Parameters.AddWithValue(“@DepartmentHead”, department_departmenthead_TextBox.Text)
                command.Parameters.AddWithValue(“@Location”, department_location_TextBox.Text)
                command.Parameters.AddWithValue(“@DepartmentID”, department_departmentid_TextBox.Text)
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show(“Department updated successfully.”, “Success”, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim addForm As New DepartmentList()
                    addForm.Show()
                    Me.Hide()
                Else
                    MessageBox.Show(“No changes were made.”, “Warning”, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(“Error: “ & ex.Message, “Database Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
        End Try
    End Sub
    ' Handle Cancel button click
    Private Sub editdepartment_cancel_Button_Click(sender As Object, e As EventArgs) Handles editdepartment_cancel_Button.Click
        Dim addForm As New DepartmentList()
        addForm.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


End Class