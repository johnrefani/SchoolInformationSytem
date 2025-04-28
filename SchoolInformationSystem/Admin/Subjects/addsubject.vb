Imports MySql.Data.MySqlClient

Public Class addsubject
    Private Sub addsubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate ComboBox options
        subtype.Items.AddRange({"Major", "Minor"})
        subsemester.Items.AddRange({"1st Semester", "2nd Semester"})
        subday.Items.AddRange({"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})

        ' Set default values or clear fields
        ClearForm()
    End Sub

    Private Sub subsavebutton_Click(sender As Object, e As EventArgs) Handles subsavebutton.Click
        ' Validate required fields
        If String.IsNullOrWhiteSpace(subname.Text) OrElse
           String.IsNullOrWhiteSpace(subcode.Text) OrElse
           String.IsNullOrWhiteSpace(subtype.Text) OrElse
           String.IsNullOrWhiteSpace(subgradelevel.Text) OrElse
           String.IsNullOrWhiteSpace(subdepartment.Text) OrElse
           String.IsNullOrWhiteSpace(subinstructor.Tag?.ToString()) OrElse
           String.IsNullOrWhiteSpace(subsection.Text) OrElse
           String.IsNullOrWhiteSpace(subsemester.Text) OrElse
           String.IsNullOrWhiteSpace(subroomnum.Text) OrElse
           String.IsNullOrWhiteSpace(subsched.Text) OrElse
           String.IsNullOrWhiteSpace(subday.Text) OrElse
           String.IsNullOrWhiteSpace(submax.Text) OrElse
           String.IsNullOrWhiteSpace(subunits.Text) Then
            MessageBox.Show("Please fill in all required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conn As MySqlConnection = strconnection()
                conn.Open()

                Dim subjectQuery As String = "INSERT INTO Subject (subject_name, subject_code, subject_type, department, grade_level, teacher_id, description, units, section, semester, room_number, schedule_time, day, max_students) " &
                                            "VALUES (@subname, @subcode, @subtype, @subdepartment, @subgradelevel, @teacherid, @subdescription, @subunits, @subsection, @subsemester, @subroomnum, @subsched, @subday, @submax)"

                Using cmd As New MySqlCommand(subjectQuery, conn)
                    cmd.Parameters.AddWithValue("@subname", subname.Text)
                    cmd.Parameters.AddWithValue("@subcode", subcode.Text)
                    cmd.Parameters.AddWithValue("@subtype", subtype.Text)
                    cmd.Parameters.AddWithValue("@subdepartment", subdepartment.Text)
                    cmd.Parameters.AddWithValue("@subgradelevel", subgradelevel.Text)
                    cmd.Parameters.AddWithValue("@teacherid", Convert.ToInt32(subinstructor.Tag))
                    cmd.Parameters.AddWithValue("@subdescription", If(String.IsNullOrEmpty(subdescription.Text), DBNull.Value, subdescription.Text))
                    cmd.Parameters.AddWithValue("@subunits", Convert.ToInt32(subunits.Text))
                    cmd.Parameters.AddWithValue("@subsection", subsection.Text)
                    cmd.Parameters.AddWithValue("@subsemester", subsemester.Text)
                    cmd.Parameters.AddWithValue("@subroomnum", subroomnum.Text)
                    cmd.Parameters.AddWithValue("@subsched", subsched.Text)
                    cmd.Parameters.AddWithValue("@subday", subday.Text)
                    cmd.Parameters.AddWithValue("@submax", Convert.ToInt32(submax.Text))

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Subject added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearForm()
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message & vbCrLf & "Error Code: " & ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub subinstructor_TextChanged(sender As Object, e As EventArgs) Handles subinstructor.TextChanged
        ' Implement search functionality for instructor
        If String.IsNullOrWhiteSpace(subinstructor.Text) Then
            subinstructor.Tag = Nothing
            Return
        End If

        Try
            Using conn As MySqlConnection = strconnection()
                conn.Open()

                Dim searchQuery As String = "SELECT instructor_id, CONCAT(first_name, ' ', middle_initial, ' ', last_name) AS full_name " &
                                           "FROM Instructor WHERE CONCAT(first_name, ' ', middle_initial, ' ', last_name) LIKE @search"

                Using cmd As New MySqlCommand(searchQuery, conn)
                    cmd.Parameters.AddWithValue("@search", "%" & subinstructor.Text & "%")
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            subinstructor.Text = reader("full_name").ToString()
                            subinstructor.Tag = reader("instructor_id")
                        Else
                            subinstructor.Tag = Nothing
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error searching instructor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cancelbutton_Click(sender As Object, e As EventArgs) Handles cancelbutton.Click
        ClearForm()
        Me.Close()
    End Sub

    Private Sub ClearForm()
        subname.Text = ""
        subcode.Text = ""
        subtype.SelectedIndex = -1
        subgradelevel.Text = ""
        subdepartment.Text = ""
        subinstructor.Text = ""
        subinstructor.Tag = Nothing
        subdescription.Text = ""
        subunits.Text = ""
        subsection.Text = ""
        subsemester.SelectedIndex = -1
        subroomnum.Text = ""
        subsched.Text = ""
        subday.SelectedIndex = -1
        submax.Text = ""
    End Sub
End Class