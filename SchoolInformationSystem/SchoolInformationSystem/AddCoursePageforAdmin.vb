Imports MySql.Data.MySqlClient
Public Class AddCoursePageforAdmin
    ' Function to check if the program ID exists in the database
    Private Function ProgramIdExists(programId As String) As Boolean
        Dim query As String = “SELECT COUNT(*) FROM program_info WHERE program_id = @ProgramID”
        Try
            If modDb.conn.State <> ConnectionState.Open Then
                modDb.conn.Open()
            End If
            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.AddWithValue(“@ProgramID”, programId)
                Return Convert.ToInt32(command.ExecuteScalar()) > 0
            End Using
        Catch ex As Exception
            MessageBox.Show(“An error occurred while checking Program ID: “ & ex.Message)
            Return False
        Finally
            If modDb.conn.State = ConnectionState.Open Then
                modDb.conn.Close()
            End If
        End Try
    End Function
    ' Function to add a course
    Private Sub AddCourse()
        Dim course_id As String = course_courseid_TextBox.Text
        Dim course_name As String = course_coursename_TextBox.Text
        Dim units As String = course_units_TextBox.Text
        Dim course_code As String = course_coursecode_TextBox.Text
        Dim department_id As String = course_departmentid_TextBox.Text
        Dim program_id As String = course_programid_TextBox.Text
        Dim course_description As String = course_coursdescription_TextBox.Text
        ' Validate inputs
        If String.IsNullOrWhiteSpace(course_id) OrElse String.IsNullOrWhiteSpace(course_name) OrElse
        String.IsNullOrWhiteSpace(units) OrElse String.IsNullOrWhiteSpace(course_code) OrElse
        String.IsNullOrWhiteSpace(department_id) OrElse String.IsNullOrWhiteSpace(program_id) OrElse
        String.IsNullOrWhiteSpace(course_description) Then
            MessageBox.Show(“Please fill in all fields.”)
            Return
        End If
        If Not IsNumeric(units) Then
            MessageBox.Show(“Units must be a valid number.”)
            Return
        End If
        ' Check if the program ID exists
        If Not ProgramIdExists(program_id) Then
            MessageBox.Show(“Invalid Program ID. Please ensure it exists in the Program Information.”)
            Return
        End If
        ' Insert course into the database
        Dim query As String = “INSERT INTO course_info (course_id, course_name, units, course_code, department_id, program_id, course_description) “ &
        “VALUES (@CourseID, @CourseName, @Units, @CourseCode, @DepartmentID, @ProgramID, @CourseDescription)”
        Try
            If modDb.conn.State <> ConnectionState.Open Then
                modDb.conn.Open()
            End If
            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.AddWithValue(“@CourseID”, course_id)
                command.Parameters.AddWithValue(“@CourseName”, course_name)
                command.Parameters.AddWithValue(“@Units”, units)
                command.Parameters.AddWithValue(“@CourseCode”, course_code)
                command.Parameters.AddWithValue(“@DepartmentID”, department_id)
                command.Parameters.AddWithValue(“@ProgramID”, program_id)
                command.Parameters.AddWithValue(“@CourseDescription”, course_description)
                command.ExecuteNonQuery()
                MessageBox.Show(“Course added successfully.”)
                ClearTextBoxes()
            End Using
        Catch ex As MySqlException
            MessageBox.Show(“Database error: “ & ex.Message)
        Catch ex As Exception
            MessageBox.Show(“An unexpected error occurred: “ & ex.Message)
        Finally
            If modDb.conn.State = ConnectionState.Open Then
                modDb.conn.Close()
            End If
        End Try
    End Sub
    ' Function to clear all textboxes
    Private Sub ClearTextBoxes()
        course_courseid_TextBox.Clear()
        course_coursename_TextBox.Clear()
        course_units_TextBox.Clear()
        course_coursecode_TextBox.Clear()
        course_departmentid_TextBox.Clear()
        course_programid_TextBox.Clear()
        course_coursdescription_TextBox.Clear()
    End Sub
    ' Event handler for the Add button
    Private Sub course_add_Button_Click(sender As Object, e As EventArgs) Handles course_add_Button.Click
        AddCourse()
    End Sub
    ' Event handler for the Back button
    Private Sub addcourse_back_Button_Click(sender As Object, e As EventArgs) Handles addcourse_back_Button.Click
        Dim form2 As New CourseList()
        form2.Show()
        Hide()
    End Sub

End Class