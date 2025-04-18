Imports MySql.Data.MySqlClient

Public Class UserManagementPage
    Private Sub UserManagementPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserData()
        AddActionButtonColumns()
    End Sub

    ' Method to load user data into the DataGridView
    Private Sub LoadUserData()
        modDb.openConn("schooldb")
        Dim query As String = "
        SELECT 
            ua.user_id,
            ua.student_id,
            ua.instructor_id,
            ua.user_type,
            COALESCE(CONCAT(s.first_name, ' ', 
                            COALESCE(s.middlename, ''), ' ', 
                            s.last_name, ' ', 
                            COALESCE(s.suffix, '')), '') AS student_full_name,
            COALESCE(CONCAT(i.first_name, ' ', 
                            COALESCE(i.middlename, ''), ' ', 
                            i.last_name, ' ', 
                            COALESCE(i.suffix, '')), '') AS instructor_full_name
        FROM user_accounts ua
        LEFT JOIN student_info s ON ua.student_id = s.student_id
        LEFT JOIN instructor_info i ON ua.instructor_id = i.instructor_id
        WHERE ua.user_type != 3"

        Dim table As New DataTable()
        Try
            Using adapter As New MySqlDataAdapter(query, modDb.conn)
                adapter.Fill(table)
                UserDGV.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
        End Try
    End Sub

    ' Handle the edit and delete
    Private Sub UsersDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UserDGV.CellContentClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = UserDGV.Rows(e.RowIndex)

            If e.ColumnIndex = UserDGV.Columns("Delete").Index Then
                Dim userId As String = Convert.ToString(selectedRow.Cells("user_id").Value)
                Dim result = MessageBox.Show($"Are you sure you want to delete the user with ID {userId}?",
                                              "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    DeleteUser(userId)
                    LoadUserData()
                End If
            End If

            If e.ColumnIndex = UserDGV.Columns("Edit").Index Then
                Dim userId As String = Convert.ToString(selectedRow.Cells("user_id").Value)
                Dim editForm As New EditUserPage()
                editForm.UserID = userId
                editForm.Show()
                Me.Hide()
            End If
        End If
    End Sub

    ' Add Edit/Delete action buttons to the DataGridView
    Private Sub AddActionButtonColumns()
        Dim deleteButton As New DataGridViewButtonColumn()
        deleteButton.Name = "Delete"
        deleteButton.HeaderText = "Action"
        deleteButton.Text = "Delete"
        deleteButton.UseColumnTextForButtonValue = True
        UserDGV.Columns.Add(deleteButton)

        Dim editButton As New DataGridViewButtonColumn()
        editButton.Name = "Edit"
        editButton.HeaderText = "Action"
        editButton.Text = "Edit"
        editButton.UseColumnTextForButtonValue = True
        UserDGV.Columns.Add(editButton)
    End Sub

    ' Delete user from the database
    Private Sub DeleteUser(userId As String)
        modDb.openConn("schooldb")
        Try
            Dim query As String = "DELETE FROM user_accounts WHERE user_id = @UserID"
            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.AddWithValue("@UserID", userId)
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            modDb.conn.Close()
        End Try
    End Sub

    ' Search function
    Private Sub SearchUser_Button_Click(sender As Object, e As EventArgs) Handles SearchUser_Button.Click
        modDb.openConn("schooldb")
        Dim query As String = "SELECT * FROM user_accounts WHERE 1=1"

        If Not String.IsNullOrWhiteSpace(UserID_TextBox.Text) Then
            query &= " AND (ua.student_id LIKE @UserID OR ua.instructor_id LIKE @UserID)"
        End If
        If Not String.IsNullOrWhiteSpace(UserType_ComboBox.Text) Then
            query &= " AND ua.user_type = @UserType"
        End If
        query &= " ORDER BY ua.student_id ASC, ua.instructor_id ASC"

        Dim table As New DataTable()
        Try
            Using command As New MySqlCommand(query, modDb.conn)
                If Not String.IsNullOrWhiteSpace(UserID_TextBox.Text) Then
                    command.Parameters.AddWithValue("@UserID", "%" & UserID_TextBox.Text & "%")
                End If
                If Not String.IsNullOrWhiteSpace(UserType_ComboBox.Text) Then
                    command.Parameters.AddWithValue("@UserType", UserType_ComboBox.SelectedIndex + 1)
                End If
                Using adapter As New MySqlDataAdapter(command)
                    adapter.Fill(table)
                    UserDGV.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
        End Try
    End Sub

    ' Add user function
    Private Sub AddUser_Button_Click(sender As Object, e As EventArgs) Handles AddUser_Button.Click
        Dim addForm As New AddUserPageForAdmin()
        addForm.Show()
    End Sub

    ' Back button function
    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Dim dashboardForm As New AdminPage()
        dashboardForm.Show()
        Me.Close()
    End Sub

End Class
