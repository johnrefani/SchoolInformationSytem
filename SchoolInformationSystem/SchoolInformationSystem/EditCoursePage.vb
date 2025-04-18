Imports MySql.Data.MySqlClient
Public Class EditCoursePage
    Public Property CourseID As String ' To receive the course ID from the previous form
    Private Sub EditCoursePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCourseDetails() ' Load course details when the form loads
    End Sub
    ' Method to load course details into input fields
    Private Sub LoadCourseDetails()
        modDb.openConn(“schooldb”)
        Dim query As String = “SELECT * FROM course_info WHERE course_id = @CourseID”
        Try
            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.AddWithValue(“@CourseID”, CourseID)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Populate fields with the current course details
                        course_courseid_TextBox.Text = reader(“course_id”).ToString()
                        course_coursename_TextBox.Text = reader(“course_name”).ToString()
                        course_coursecode_TextBox.Text = reader(“course_code”).ToString()
                        course_units_TextBox.Text = reader(“units”).ToString()
                        course_departmentid_TextBox.Text = reader(“department_id”).ToString()
                        course_programid_TextBox.Text = reader(“program_id”).ToString()
                        course_coursedescription_TextBox.Text = reader(“course_description”).ToString()
                    Else
                        MessageBox.Show(“Course not found.”, “Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.Close()
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show(“An error occurred: “ & ex.Message, “Database Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
        End Try
    End Sub
    ' Handle the Save button click to update the course details
    Private Sub editcourse_save_Button_Click(sender As Object, e As EventArgs) Handles editcourse_save_Button.Click
        modDb.openConn(“schooldb”)
        Dim query As String = “UPDATE course_info
SET course_name = @CourseName,
Course_code = @CourseCode,
Units = @Units,
Department_id = @DepartmentID,
Program_id = @ProgramID,
Course_description = @CourseDescription
WHERE course_id = @CourseID”
        Try
            Using command As New MySqlCommand(query, modDb.conn)
                ' Set parameters with values from input fields
                command.Parameters.AddWithValue(“@CourseID”, CourseID)
                command.Parameters.AddWithValue(“@CourseName”, course_coursename_TextBox.Text)
                command.Parameters.AddWithValue(“@CourseCode”, course_coursecode_TextBox.Text)
                command.Parameters.AddWithValue(“@Units”, course_units_TextBox.Text)
                command.Parameters.AddWithValue(“@DepartmentID”, course_departmentid_TextBox.Text)
                command.Parameters.AddWithValue(“@ProgramID”, course_programid_TextBox.Text)
                command.Parameters.AddWithValue(“@CourseDescription”, course_coursedescription_TextBox.Text)
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show(“Course updated successfully.”, “Success”, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim addForm As New CourseList()
                    addForm.Show()
                    Me.Hide()
                Else
                    MessageBox.Show(“No changes were made.”, “Info”, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As MySqlException
            MessageBox.Show(“An error occurred: “ & ex.Message, “Database Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
        End Try
    End Sub
    ' Handle the Cancel button click to close the form
    Private Sub editcourse_cancel_Button_Click(sender As Object, e As EventArgs) Handles editcourse_cancel_Button.Click
        Dim addForm As New CourseList()
        addForm.Show()
        Me.Hide()
    End Sub

    Private Sub course_courseid_TextBox_TextChanged(sender As Object, e As EventArgs) Handles course_courseid_TextBox.TextChanged

    End Sub
End Class