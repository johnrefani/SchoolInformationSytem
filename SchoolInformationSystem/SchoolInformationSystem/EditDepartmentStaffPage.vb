Imports MySql.Data.MySqlClient
Public Class EditDepartmentStaffPage
    Public StaffID As String ' The staff ID to edit
    Private gender_ComboBox As ComboBox ' Adjusted to ComboBox type
    Private Sub EditDepartmentStaffPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not String.IsNullOrWhiteSpace(StaffID) Then
            LoadStaffDetails(StaffID)
        Else
            MessageBox.Show(“Staff ID not provided.”, “Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End If
    End Sub
    ' Load the staff details into the form fields
    Private Sub LoadStaffDetails(staffId As String)
        modDb.openConn(“schooldb”)
        Dim query As String = “SELECT * FROM department_staff_info WHERE staff_id = @StaffID”
        Try
            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.AddWithValue(“@StaffID”, staffId)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        departmentstaff_staffid_TextBox.Text = reader(“staff_id”).ToString()
                        departmentstaff_firstname_TextBox.Text = reader(“first_name”).ToString()
                        departmentstaff_lastname_TextBox.Text = reader(“last_name”).ToString()
                        departmentstaff_middlename_TextBox.Text = reader(“middlename”).ToString()
                        departmentstaff_position_TextBox.Text = reader(“position”).ToString()
                        departmentstaff_departmentid_TextBox.Text = reader(“department_id”).ToString()
                        departmentstaff_hiredate_TextBox.Text = DateTime.Parse(reader(“hire_date”).ToString()).ToString(“yyyy-MM-dd”)
                        departmentstaff_email_TextBox.Text = reader(“email”).ToString()
                        'gender_ComboBox.SelectedItem = reader(“gender”).ToString() ' Assumes ComboBox contains “Male” and “Female”
                    Else
                        MessageBox.Show(“Staff not found.”, “Error”, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Close()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(“Error: “ & ex.Message, “Database Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
        End Try
    End Sub
    ' Save the updated details
    Private Sub editinstructor_save_Button(sender As Object, e As EventArgs)
        If ValidateFields() Then
            UpdateStaffDetails()
        End If
    End Sub
    ' Update staff details in the database
    Private Sub UpdateStaffDetails()
        modDb.openConn(“schooldb”)
        Dim query As String = “UPDATE department_staff_info
SET first_name = @FirstName,
Last_name = @LastName,
Middlename = @MiddleName,
Position = @Position,
Department_id = @DepartmentID,
Hire_date = @HireDate,
Email = @Email,
Gender = @Gender
WHERE staff_id = @StaffID”
        Try
            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.AddWithValue(“@StaffID”, departmentstaff_staffid_TextBox.Text)
                command.Parameters.AddWithValue(“@FirstName”, departmentstaff_firstname_TextBox.Text)
                command.Parameters.AddWithValue(“@LastName”, departmentstaff_lastname_TextBox.Text)
                command.Parameters.AddWithValue(“@MiddleName”, departmentstaff_middlename_TextBox.Text)
                command.Parameters.AddWithValue(“@Position”, departmentstaff_position_TextBox.Text)
                command.Parameters.AddWithValue(“@DepartmentID”, departmentstaff_departmentid_TextBox.Text)
                ' Validate the hire date input
                Dim hireDate As DateTime
                If DateTime.TryParse(departmentstaff_hiredate_TextBox.Text, hireDate) Then
                    command.Parameters.AddWithValue(“@HireDate”, hireDate)
                Else
                    MessageBox.Show(“Please enter a valid hire date.”, “Validation Error”, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
                command.Parameters.AddWithValue(“@Email”, departmentstaff_email_TextBox.Text)
                ' Ensure a gender selection is made
                If gender_ComboBox.SelectedIndex = -1 Then
                    MessageBox.Show(“Please select a gender.”, “Validation Error”, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
                command.Parameters.AddWithValue(“@Gender”, gender_ComboBox.SelectedItem.ToString())
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show(“Staff details updated successfully.”, “Success”, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Close()
                Else
                    MessageBox.Show(“No changes were made.”, “Information”, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(“Error: “ & ex.Message, “Database Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
        End Try
    End Sub
    ' Validate form fields
    Private Function ValidateFields() As Boolean
        If String.IsNullOrWhiteSpace(departmentstaff_firstname_TextBox.Text) OrElse
        String.IsNullOrWhiteSpace(departmentstaff_lastname_TextBox.Text) OrElse
        String.IsNullOrWhiteSpace(departmentstaff_position_TextBox.Text) OrElse
        String.IsNullOrWhiteSpace(departmentstaff_departmentid_TextBox.Text) OrElse
        String.IsNullOrWhiteSpace(departmentstaff_email_TextBox.Text) OrElse
        gender_ComboBox.SelectedIndex = -1 Then
            MessageBox.Show(“Please fill out all required fields.”, “Validation Error”, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function
    ' Cancel the editing process
    Private Sub editdepartmentstaff_cancel_Button_Click(sender As Object, e As EventArgs) Handles editdepartmentstaff_cancel_Button.Click
        Close()
    End Sub

    Private Sub editdepartmentstaff_save_button_Click(sender As Object, e As EventArgs) Handles editdepartmentstaff_save_button.Click
        If ValidateFields() Then
            UpdateStaffDetails()
        End If
    End Sub

    Private Sub departmentstaff_middlename_TextBox_TextChanged(sender As Object, e As EventArgs) Handles departmentstaff_middlename_TextBox.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class