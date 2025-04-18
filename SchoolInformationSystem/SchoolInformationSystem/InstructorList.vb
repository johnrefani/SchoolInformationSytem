Imports MySql.Data.MySqlClient

Public Class InstructorList
    Private Sub instructorlist_add_Button_Click(sender As Object, e As EventArgs) Handles instructorlist_add_Button.Click
        Dim form2 As New AddInstructorPageforAdmin
        form2.Show()
        Hide()
    End Sub

    Private Sub InstructorList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInstructorData()
        AddDeleteAndEditButtonColumns()
    End Sub

    Private Sub LoadInstructorData()
        modDb.openConn(“schooldb”)
        Dim query As String = “SELECT * FROM instructor_info”
        Dim table As New DataTable()
        Try
            Using adapter As New MySqlDataAdapter(query, modDb.conn)
                adapter.Fill(table)
                InstructorDataGridView.DataSource = table ' Bind the data to the DataGridView
            End Using
        Catch ex As Exception
            MessageBox.Show(“Error: “ & ex.Message, “Database Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
        End Try
    End Sub

    Private Sub AddDeleteAndEditButtonColumns()
        If InstructorDataGridView.Columns(“Delete”) Is Nothing Then
            Dim deleteButton As New DataGridViewButtonColumn()
            deleteButton.Name = “Delete”
            deleteButton.HeaderText = “Action”
            deleteButton.Text = “Delete”
            deleteButton.UseColumnTextForButtonValue = True
            InstructorDataGridView.Columns.Add(deleteButton)
        End If
        If InstructorDataGridView.Columns(“Edit”) Is Nothing Then
            Dim editButton As New DataGridViewButtonColumn()
            editButton.Name = “Edit”
            editButton.HeaderText = “Action”
            editButton.Text = “Edit”
            editButton.UseColumnTextForButtonValue = True
            InstructorDataGridView.Columns.Add(editButton)
        End If
    End Sub

    Private Sub instructorlist_search_Button_Click(sender As Object, e As EventArgs) Handles instructorlist_search_Button.Click
        modDb.openConn("schooldb")
        Dim query As String = "SELECT * FROM instructor_info WHERE 1=1"

        ' Add search conditions based on input fields
        If Not String.IsNullOrWhiteSpace(instructor_idno_TextBox.Text) Then
            query &= " AND instructor_id LIKE @InstructorID"
        End If
        If Not String.IsNullOrWhiteSpace(instructor_firstname_TextBox.Text) Then
            query &= " AND first_name LIKE @InstructorFirstName"
        End If
        If Not String.IsNullOrWhiteSpace(instrutor_middlename_TextBox.Text) Then
            query &= " AND middlename LIKE @InstructorMiddleName"
        End If
        If Not String.IsNullOrWhiteSpace(instructor_lastname_TextBox.Text) Then
            query &= " AND last_name LIKE @InstructorLastName"
        End If
        If Not String.IsNullOrWhiteSpace(instructor_birthdate_TextBox.Text) Then
            query &= " AND birthdate LIKE @InstructorBirthDate"
        End If
        If Not String.IsNullOrWhiteSpace(instructor_email_TextBox.Text) Then
            query &= " AND email LIKE @InstructorEmail"
        End If
        If Not String.IsNullOrWhiteSpace(instructor_gender_TextBox.Text) Then
            query &= " AND gender LIKE @InstructorGender"
        End If
        If Not String.IsNullOrWhiteSpace(instructor_contactnumber_TextBox.Text) Then
            query &= " AND contact_number LIKE @InstructorContactNumber"
        End If
        If Not String.IsNullOrWhiteSpace(instructor_hiredate_TextBox.Text) Then
            query &= " AND hire_date LIKE @InstructorHireDate"
        End If
        If Not String.IsNullOrWhiteSpace(instructor_departmentid_TextBox.Text) Then
            query &= " AND department_id LIKE @InstructorDeptID"
        End If

        Dim table As New DataTable()
        Try
            Using command As New MySqlCommand(query, modDb.conn)
                ' Add parameters
                If Not String.IsNullOrWhiteSpace(instructor_idno_TextBox.Text) Then
                    command.Parameters.AddWithValue("@InstructorID", "%" & instructor_idno_TextBox.Text & "%")
                End If
                If Not String.IsNullOrWhiteSpace(instructor_firstname_TextBox.Text) Then
                    command.Parameters.AddWithValue("@InstructorFirstName", "%" & instructor_firstname_TextBox.Text & "%")
                End If
                If Not String.IsNullOrWhiteSpace(instrutor_middlename_TextBox.Text) Then
                    command.Parameters.AddWithValue("@InstructorMiddleName", "%" & instrutor_middlename_TextBox.Text & "%")
                End If
                If Not String.IsNullOrWhiteSpace(instructor_lastname_TextBox.Text) Then
                    command.Parameters.AddWithValue("@InstructorLastName", "%" & instructor_lastname_TextBox.Text & "%")
                End If
                If Not String.IsNullOrWhiteSpace(instructor_birthdate_TextBox.Text) Then
                    command.Parameters.AddWithValue("@InstructorBirthDate", "%" & instructor_birthdate_TextBox.Text & "%")
                End If
                If Not String.IsNullOrWhiteSpace(instructor_email_TextBox.Text) Then
                    command.Parameters.AddWithValue("@InstructorEmail", "%" & instructor_email_TextBox.Text & "%")
                End If
                If Not String.IsNullOrWhiteSpace(instructor_gender_TextBox.Text) Then
                    command.Parameters.AddWithValue("@InstructorGender", "%" & instructor_gender_TextBox.Text & "%")
                End If
                If Not String.IsNullOrWhiteSpace(instructor_contactnumber_TextBox.Text) Then
                    command.Parameters.AddWithValue("@InstructorContactNumber", "%" & instructor_contactnumber_TextBox.Text & "%")
                End If
                If Not String.IsNullOrWhiteSpace(instructor_hiredate_TextBox.Text) Then
                    command.Parameters.AddWithValue("@InstructorHireDate", "%" & instructor_hiredate_TextBox.Text & "%")
                End If
                If Not String.IsNullOrWhiteSpace(instructor_departmentid_TextBox.Text) Then
                    command.Parameters.AddWithValue("@InstructorDeptID", "%" & instructor_departmentid_TextBox.Text & "%")
                End If

                ' Execute and bind results to the DataGridView
                Using adapter As New MySqlDataAdapter(command)
                    adapter.Fill(table)
                    InstructorDataGridView.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
        End Try
    End Sub

    Private Sub InstructorDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles InstructorDataGridView.CellContentClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = InstructorDataGridView.Rows(e.RowIndex)

            ' Handle Delete action
            If e.ColumnIndex = InstructorDataGridView.Columns("Delete").Index Then
                Dim instructorId As String = selectedRow.Cells("instructor_id").Value.ToString()
                Dim result = MessageBox.Show($"Are you sure you want to delete the instructor with ID {instructorId}?",
                                         "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    DeleteInstructor(instructorId)
                    LoadInstructorData() ' Refresh the instructor data
                End If

                ' Handle Edit action
            ElseIf e.ColumnIndex = InstructorDataGridView.Columns("Edit").Index Then
                Dim instructorId As String = selectedRow.Cells("instructor_id").Value.ToString()
                Dim editForm As New EditInstructorPage()
                editForm.InstructorID = instructorId
                editForm.Show()
                Hide()
            End If
        End If
    End Sub

    Private Sub DeleteInstructor(instructorId As String)
        Try
            modDb.openConn("schooldb")
            Dim query As String = "DELETE FROM instructor_info WHERE instructor_id = @InstructorID"
            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.AddWithValue("@InstructorID", instructorId)
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
        End Try
    End Sub

    Private Sub instructor_back_Button_Click(sender As Object, e As EventArgs) Handles instructor_back_Button.Click
        Dim form2 As New AdminPage()
        form2.Show()
        Me.Hide()
    End Sub
End Class