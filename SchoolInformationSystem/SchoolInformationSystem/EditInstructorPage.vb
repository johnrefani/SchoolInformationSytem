Imports MySql.Data.MySqlClient

Public Class EditInstructorPage
    ' Property to store the Instructor ID passed from another form
    Public Property InstructorID As String

    ' Load the instructor details when the form loads
    Private Sub EditInstructorPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not String.IsNullOrEmpty(InstructorID) Then
            LoadInstructorDetails(InstructorID)
        Else
            MessageBox.Show("No Instructor ID provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
    End Sub

    ' Load instructor details from the database
    Private Sub LoadInstructorDetails(instructorId As String)
        modDb.openConn("schooldb")
        Dim query As String = "SELECT * FROM instructor_info WHERE instructor_id = @InstructorID"
        Try
            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.AddWithValue("@InstructorID", instructorId)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Map database fields to form controls
                        instructor_id_TextBox.Text = reader("instructor_id").ToString()
                        instructor_firstname_TextBox.Text = reader("first_name").ToString()
                        instructor_middlename_TextBox.Text = reader("middlename").ToString()
                        instructor_lastname_TextBox.Text = reader("last_name").ToString()
                        instructor_email_TextBox.Text = reader("email").ToString()
                        instructor_contactnumber_TextBox.Text = reader("contact_number").ToString()
                        instructor_birthdate_TextBox.Text = reader("birthdate").ToString()
                        instructor_gender_ComboBox.Text = reader("gender").ToString()
                        instructor_hiredate_DTP.Value = Convert.ToDateTime(reader("hire_date"))
                        instructor_departmentid_TextBox.Text = reader("department_id").ToString()
                    Else
                        MessageBox.Show("Instructor not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.Close()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
        End Try
    End Sub

    ' Handle the Save button click
    Private Sub editinstructor_save_Button_Click(sender As Object, e As EventArgs) Handles editinstructor_save_Button.Click
        If ValidateInputs() Then
            UpdateInstructorDetails()
        End If
    End Sub

    ' Validate form inputs
    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(instructor_firstname_TextBox.Text) Then
            MessageBox.Show("First name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(instructor_lastname_TextBox.Text) Then
            MessageBox.Show("Last name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(instructor_email_TextBox.Text) Then
            MessageBox.Show("Email cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    ' Update instructor details in the database
    Private Sub UpdateInstructorDetails()
        modDb.openConn("schooldb")
        Dim query As String = "UPDATE instructor_info SET first_name = @FirstName, middlename = @MiddleName, last_name = @LastName, " &
                              "email = @Email, contact_number = @ContactNumber, birthdate = @BirthDate, gender = @Gender, hire_date = @HireDate, " &
                              "department_id = @DepartmentID WHERE instructor_id = @InstructorID"
        Try
            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.AddWithValue("@FirstName", instructor_firstname_TextBox.Text)
                command.Parameters.AddWithValue("@MiddleName", instructor_middlename_TextBox.Text)
                command.Parameters.AddWithValue("@LastName", instructor_lastname_TextBox.Text)
                command.Parameters.AddWithValue("@Email", instructor_email_TextBox.Text)
                command.Parameters.AddWithValue("@ContactNumber", instructor_contactnumber_TextBox.Text)
                command.Parameters.AddWithValue("@BirthDate", instructor_birthdate_TextBox.Text)
                command.Parameters.AddWithValue("@Gender", instructor_gender_ComboBox.Text)
                command.Parameters.AddWithValue("@HireDate", instructor_hiredate_DTP.Value)
                command.Parameters.AddWithValue("@DepartmentID", instructor_departmentid_TextBox.Text)
                command.Parameters.AddWithValue("@InstructorID", instructor_id_TextBox.Text)

                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Instructor updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim listForm As New InstructorList()
                    listForm.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("No changes were made.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
        End Try
    End Sub

    ' Handle Cancel button click
    Private Sub editinstructor_cancel_Button_Click(sender As Object, e As EventArgs) Handles editinstructor_cancel_Button.Click
        Dim listForm As New InstructorList()
        listForm.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class
