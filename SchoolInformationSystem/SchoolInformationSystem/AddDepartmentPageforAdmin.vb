Imports MySql.Data.MySqlClient
Public Class AddDepartmentPageforAdmin
    Private Sub department_add_Button_Click(sender As Object, e As EventArgs) Handles department_add_Button.Click
        AddDepartmentData()
    End Sub
    Private Sub AddDepartmentData()
        If String.IsNullOrWhiteSpace(department_departmentid_TextBox.Text) OrElse
        String.IsNullOrWhiteSpace(department_departmentname_TextBox.Text) OrElse
        String.IsNullOrWhiteSpace(department_departmenthead_TextBox.Text) OrElse
        String.IsNullOrWhiteSpace(department_location_TextBox.Text) Then
            MessageBox.Show(“Please fill in all fields.”)
            Exit Sub
        End If
        modDb.openConn(“schooldb”)
        Dim query As String = “INSERT INTO department_info (department_id, department_name, department_head, location) “ &
        “VALUES (@DepartmentID, @DepartmentName, @DepartmentHead, @Location)”
        Using command As New MySqlCommand(query, modDb.conn)
            command.Parameters.AddWithValue(“@DepartmentID”, department_departmentid_TextBox.Text)
            command.Parameters.AddWithValue(“@DepartmentName”, department_departmentname_TextBox.Text)
            command.Parameters.AddWithValue(“@DepartmentHead”, department_departmenthead_TextBox.Text)
            command.Parameters.AddWithValue(“@Location”, department_location_TextBox.Text)
            Try
                command.ExecuteNonQuery()
                MessageBox.Show(“Department added successfully.”)
                ClearTextBoxes()
            Catch ex As Exception
                MessageBox.Show(“An error occurred: “ & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub ClearTextBoxes()
        department_departmentid_TextBox.Clear()
        department_departmentname_TextBox.Clear()
        department_departmenthead_TextBox.Clear()
        department_location_TextBox.Clear()
    End Sub
    Private Sub department_back_Button_Click(sender As Object, e As EventArgs) Handles department_back_Button.Click
        Dim form2 As New AdminPage()
        form2.Show()
        Me.Hide()
    End Sub
End Class