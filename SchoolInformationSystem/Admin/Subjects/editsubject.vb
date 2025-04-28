Imports MySql.Data.MySqlClient

Public Class editsubject
    ' Public property to receive the subject ID
    Public Property SubjectId As Integer

    ' Default constructor (required for Windows Forms)
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub

    Private Sub editsubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load combobox options
        LoadComboBoxOptions()

        ' Only load data if SubjectId has been set
        If SubjectId > 0 Then
            LoadSubjectData()
        Else
            MessageBox.Show("No subject ID provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
    End Sub

    Private Sub LoadComboBoxOptions()
        ' Load subject type options
        subtype.Items.AddRange({"Major", "Minor"})

        ' Load semester options
        subsemester.Items.AddRange({"1st Semester", "2nd Semester"})

        ' Load day options
        subday.Items.AddRange({"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
    End Sub

    Private Sub LoadSubjectData()
        Using conn As MySqlConnection = strconnection()
            Try
                conn.Open()

                ' Get subject data with instructor name
                Dim query As String = "SELECT s.*, CONCAT(i.first_name, ' ', i.middle_initial, ' ', i.last_name) AS instructor_name " &
                                     "FROM subject s LEFT JOIN instructor i ON s.teacher_id = i.instructor_id " &
                                     "WHERE s.subject_id = @id"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", SubjectId)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Auto-fill the form fields
                            subid.Text = SubjectId.ToString()
                            subname.Text = reader("subject_name").ToString()
                            subcode.Text = reader("subject_code").ToString()
                            subtype.Text = reader("subject_type").ToString()
                            subdepartment.Text = reader("department").ToString()
                            subgradelevel.Text = reader("grade_level").ToString()
                            subinstructor.Text = If(reader.IsDBNull(reader.GetOrdinal("instructor_name")), "", reader("instructor_name").ToString())
                            subdescription.Text = If(reader.IsDBNull(reader.GetOrdinal("description")), "", reader("description").ToString())
                            subunits.Text = reader("units").ToString()
                            subsection.Text = If(reader.IsDBNull(reader.GetOrdinal("section")), "", reader("section").ToString())
                            subsemester.Text = reader("semester").ToString()
                            subroomnum.Text = If(reader.IsDBNull(reader.GetOrdinal("room_number")), "", reader("room_number").ToString())
                            subsched.Text = If(reader.IsDBNull(reader.GetOrdinal("schedule_time")), "", reader("schedule_time").ToString())
                            subday.Text = If(reader.IsDBNull(reader.GetOrdinal("day")), "", reader("day").ToString())
                            submax.Text = reader("max_students").ToString()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading subject data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub subsave_Click(sender As Object, e As EventArgs) Handles subsave.Click
        ' Validate required fields
        If String.IsNullOrWhiteSpace(subname.Text) OrElse
           String.IsNullOrWhiteSpace(subcode.Text) OrElse
           String.IsNullOrWhiteSpace(subtype.Text) OrElse
           String.IsNullOrWhiteSpace(subdepartment.Text) OrElse
           String.IsNullOrWhiteSpace(subgradelevel.Text) OrElse
           String.IsNullOrWhiteSpace(subunits.Text) Then
            MessageBox.Show("Please fill in all required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validate units is numeric
        Dim unitsValue As Integer
        If Not Integer.TryParse(subunits.Text, unitsValue) Then
            MessageBox.Show("Units must be a numeric value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validate max students is numeric if not empty
        If Not String.IsNullOrWhiteSpace(submax.Text) AndAlso Not Integer.TryParse(submax.Text, unitsValue) Then
            MessageBox.Show("Max Students must be a numeric value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conn As MySqlConnection = strconnection()
                conn.Open()

                ' Update subject table
                Dim query As String = "UPDATE subject SET " &
                                     "subject_name = @name, " &
                                     "subject_code = @code, " &
                                     "subject_type = @type, " &
                                     "department = @department, " &
                                     "grade_level = @gradelevel, " &
                                     "description = @description, " &
                                     "units = @units, " &
                                     "section = @section, " &
                                     "semester = @semester, " &
                                     "room_number = @roomnum, " &
                                     "schedule_time = @sched, " &
                                     "day = @day, " &
                                     "max_students = @max " &
                                     "WHERE subject_id = @id"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", SubjectId)
                    cmd.Parameters.AddWithValue("@name", subname.Text)
                    cmd.Parameters.AddWithValue("@code", subcode.Text)
                    cmd.Parameters.AddWithValue("@type", subtype.Text)
                    cmd.Parameters.AddWithValue("@department", subdepartment.Text)
                    cmd.Parameters.AddWithValue("@gradelevel", subgradelevel.Text)
                    cmd.Parameters.AddWithValue("@description", If(String.IsNullOrEmpty(subdescription.Text), DBNull.Value, subdescription.Text))
                    cmd.Parameters.AddWithValue("@units", subunits.Text)
                    cmd.Parameters.AddWithValue("@section", If(String.IsNullOrEmpty(subsection.Text), DBNull.Value, subsection.Text))
                    cmd.Parameters.AddWithValue("@semester", subsemester.Text)
                    cmd.Parameters.AddWithValue("@roomnum", If(String.IsNullOrEmpty(subroomnum.Text), DBNull.Value, subroomnum.Text))
                    cmd.Parameters.AddWithValue("@sched", If(String.IsNullOrEmpty(subsched.Text), DBNull.Value, subsched.Text))
                    cmd.Parameters.AddWithValue("@day", If(String.IsNullOrEmpty(subday.Text), DBNull.Value, subday.Text))
                    cmd.Parameters.AddWithValue("@max", If(String.IsNullOrEmpty(submax.Text), DBNull.Value, submax.Text))

                    Dim rowsAffected = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Subject updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    Else
                        MessageBox.Show("No changes were made to the subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub subdelete_Click(sender As Object, e As EventArgs) Handles subdelete.Click
        ' Confirm with the user before deleting
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this subject?",
                                               "Confirm Delete",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Try
                Using conn As MySqlConnection = strconnection()
                    conn.Open()

                    ' Start a transaction
                    Dim transaction As MySqlTransaction = conn.BeginTransaction()

                    Try
                        ' First check if there are any enrollments for this subject
                        Dim checkEnrollmentQuery As String = "SELECT COUNT(*) FROM enrollment WHERE subject_id = @id"
                        Using checkCmd As New MySqlCommand(checkEnrollmentQuery, conn, transaction)
                            checkCmd.Parameters.AddWithValue("@id", SubjectId)
                            Dim enrollmentCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                            If enrollmentCount > 0 Then
                                transaction.Rollback()
                                MessageBox.Show("Cannot delete subject because there are enrollments associated with it.",
                                          "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Return
                            End If
                        End Using

                        ' Delete from subject table
                        Dim deleteQuery As String = "DELETE FROM subject WHERE subject_id = @id"
                        Using cmd As New MySqlCommand(deleteQuery, conn, transaction)
                            cmd.Parameters.AddWithValue("@id", SubjectId)
                            Dim rowsAffected = cmd.ExecuteNonQuery()

                            If rowsAffected > 0 Then
                                transaction.Commit()
                                MessageBox.Show("Subject deleted successfully!", "Success",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Me.Close()
                            Else
                                transaction.Rollback()
                                MessageBox.Show("No subject was deleted.", "Information",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End Using

                    Catch ex As Exception
                        transaction.Rollback()
                        MessageBox.Show("Error deleting subject: " & ex.Message, "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub cancelbutton_Click(sender As Object, e As EventArgs) Handles cancelbutton.Click
        Me.Close()
        adminframe.Show()
    End Sub
End Class