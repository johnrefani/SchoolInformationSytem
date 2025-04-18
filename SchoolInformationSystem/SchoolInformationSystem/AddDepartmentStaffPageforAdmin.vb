Imports MySql.Data.MySqlClient
Public Class AddDepartmentStaffPageforAdmin
    Private Sub departmentstaff_add_Button_Click(sender As Object, e As EventArgs) Handles departmentstaff_add_Button.Click
        AddDepartmentStaff()
    End Sub
    Private Sub AddDepartmentStaff()
        Dim staffId As String = departmentstaff_staffid_TextBox.Text.Trim()
        Dim departmentId As String = departmentstaff_departmentid_TextBox.Text.Trim()
        Dim lastName As String = departmentstaff_lastname_TextBox.Text.Trim()
        Dim firstName As String = departmentstaff_firstname_TextBox.Text.Trim()
        Dim middleName As String = departmentstaff_middlename_TextBox.Text.Trim()
        Dim gender As String = departmentstaff_gender_TextBox.Text.Trim()
        Dim email As String = departmentstaff_email_TextBox.Text.Trim()
        Dim position As String = departmentstaff_position_TextBox.Text.Trim()
        Dim hireDate As String = departmentstaff_hiredate_TextBox.Text.Trim()
        If String.IsNullOrEmpty(staffId) OrElse
        String.IsNullOrEmpty(departmentId) OrElse
        String.IsNullOrEmpty(lastName) OrElse
        String.IsNullOrEmpty(gender) OrElse
        String.IsNullOrEmpty(email) OrElse
        String.IsNullOrEmpty(position) OrElse
        String.IsNullOrEmpty(hireDate) OrElse
        String.IsNullOrEmpty(middleName) Then
            MessageBox.Show(“Please fill in all required fields (Staff ID, Department ID, Last Name, First Name).”, “Validation Error”, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        modDb.openConn(“schooldb”)
        Try
            If Not DepartmentIdExists(departmentId) Then
                MessageBox.Show(“The Department ID does not exist. Please enter a valid Department ID.”, “Invalid Department ID”, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If StaffIdExists(staffId) Then
                MessageBox.Show(“The Staff ID already exists. Please enter a unique Staff ID.”, “Duplicate Staff ID”, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Dim query As String = “INSERT INTO department_staff_info (staff_id, department_id, last_name, first_name, middlename, email, hire_date, position, gender) “ &
            “VALUES (@staff_id, @department_id, @last_name, @first_name, @middle_name, @email, @hireDate, @position, @gender)”
            Using cmd As New MySqlCommand(query, modDb.conn)
                cmd.Parameters.AddWithValue(“@staff_id”, staffId)
                cmd.Parameters.AddWithValue(“@department_id”, departmentId)
                cmd.Parameters.AddWithValue(“@last_name”, lastName)
                cmd.Parameters.AddWithValue(“@first_name”, firstName)
                cmd.Parameters.AddWithValue(“@middle_name”, middleName)
                cmd.Parameters.AddWithValue(“@hireDate”, hireDate)
                cmd.Parameters.AddWithValue(“@position”, position)
                cmd.Parameters.AddWithValue(“@gender”, gender)
                cmd.Parameters.AddWithValue(“@email”, email)
                If cmd.ExecuteNonQuery() > 0 Then
                    MessageBox.Show(“Department staff added successfully.”, “Success”, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearTextBoxes()
                Else
                    MessageBox.Show(“Failed to add department staff.”, “Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As MySqlException
            MessageBox.Show(“An error occurred while adding department staff: “ & ex.Message, “Database Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            modDb.conn.Close()
        End Try
    End Sub
    Private Function DepartmentIdExists(departmentId As String) As Boolean
        Dim query As String = “SELECT COUNT(*) FROM department_info WHERE department_id = @department_id”
        Using cmd As New MySqlCommand(query, modDb.conn)
            cmd.Parameters.AddWithValue(“@department_id”, departmentId)
            Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
        End Using
    End Function
    Private Function StaffIdExists(staffId As String) As Boolean
        Dim query As String = “SELECT COUNT(*) FROM department_staff_info WHERE staff_id = @staff_id”
        Using cmd As New MySqlCommand(query, modDb.conn)
            cmd.Parameters.AddWithValue(“@staff_id”, staffId)
            Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
        End Using
    End Function
    Private Sub ClearTextBoxes()
        departmentstaff_staffid_TextBox.Clear()
        departmentstaff_departmentid_TextBox.Clear()
        departmentstaff_lastname_TextBox.Clear()
        departmentstaff_firstname_TextBox.Clear()
        departmentstaff_middlename_TextBox.Clear()
        departmentstaff_gender_TextBox.Items.Clear()
        departmentstaff_hiredate_TextBox.Clear()
        departmentstaff_position_TextBox.Clear()
        departmentstaff_email_TextBox.Clear()
    End Sub
    Private Sub adddepartment_back_Button_Click(sender As Object, e As EventArgs) Handles adddepartment_back_Button.Click
        Dim form2 As New DepartmentStaffList()
        form2.Show()
        Hide()
    End Sub
End Class