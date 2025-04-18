Imports MySql.Data.MySqlClient

Public Class EditGradeForm
    Private studentID As Integer
    Private courseName As String
    Private studentName As String

    Public Sub New(studentID As Integer, courseName As String, studentName As String)
        InitializeComponent()
        Me.studentID = studentID
        Me.courseName = courseName
        Me.studentName = studentName
    End Sub

    Private Sub EditGradeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idNumber_Label.Text = "ID Number: " + studentID.ToString()
        courseName_Label.Text = "Name: " + courseName
        studentName_Label.Text = "Name: " + studentName
        LoadStudentGrade()
    End Sub

    Private Sub LoadStudentGrade()
        Dim sql As String = "SELECT t.grade, t.remarks 
                         FROM transcripts t
                         JOIN course_info c ON t.course_id = c.course_id
                         WHERE t.student_id = @studentID AND TRIM(LOWER(c.course_name)) = TRIM(LOWER(@courseName))"

        Try
            modDb.openConn(db_name)
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@studentID", studentID)
                cmd.Parameters.AddWithValue("@courseName", courseName)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        grade_TextBox.Text = reader("grade").ToString()
                        remarks_TextBox.Text = reader("remarks").ToString()
                    Else
                        MessageBox.Show("No matching data found. You can add a new entry.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        grade_TextBox.Text = ""
                        remarks_TextBox.Text = ""
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub


    Private Sub save_Button_Click(sender As Object, e As EventArgs) Handles save_Button.Click
        Dim sql As String = "INSERT INTO transcripts (student_id, course_id, grade, remarks) 
                     VALUES (@studentID, (SELECT course_id FROM course_info WHERE course_name = @courseName LIMIT 1), @grade, @remarks)
                     ON DUPLICATE KEY UPDATE grade = @grade, remarks = @remarks"

        Try
            modDb.openConn(db_name)
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@studentID", studentID)
                cmd.Parameters.AddWithValue("@courseName", courseName)
                cmd.Parameters.AddWithValue("@grade", grade_TextBox.Text)
                cmd.Parameters.AddWithValue("@remarks", remarks_TextBox.Text)

                Dim result As Integer = cmd.ExecuteNonQuery()
                If result > 0 Then
                    MessageBox.Show("Grade updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = DialogResult.OK
                Else
                    MessageBox.Show("No changes were made.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

    End Sub

    Private Sub cancel_Button_Click(sender As Object, e As EventArgs) Handles cancel_Button.Click
        SetGrades.Refresh()
        Me.Close()
    End Sub
End Class
