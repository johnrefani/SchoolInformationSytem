Imports MySql.Data.MySqlClient

Public Class InstructorProfile

    Private Property FullName As String
    Private Property Gender As String
    Private Property Birthdate As String
    Private Property Email As String
    Private Property ContactNumber As String
    Private Property HireDate As String
    Private Property Department As String


    Private Sub profile_Button_Click(sender As Object, e As EventArgs) Handles profile_Button.Click
        Dim profile As New InstructorProfile
        profile.Show()
        Me.Close()
    End Sub

    Private Sub courseReg_Button_Click(sender As Object, e As EventArgs) Handles courseReg_Button.Click
        Dim courseReg As New CourseRegistrationForInstructor
        courseReg.Show()
        Me.Close()
    End Sub

    Private Sub setGrades_Button_Click(sender As Object, e As EventArgs) Handles setGrades_Button.Click
        Dim setGrade As New SetGrades
        setGrade.Show()
        Me.Close()
    End Sub

    Private Sub viewSubjects_Button_Click(sender As Object, e As EventArgs) Handles viewSubjects_Button.Click
        Dim viewSubs As New ViewAssignedSubjects
        viewSubs.Show()
        Me.Close()
    End Sub

    Private Sub logout_Button_Click(sender As Object, e As EventArgs) Handles logout_Button.Click
        Dim loginAgain As New LoginPage
        loginAgain.Show()
        Me.Close()
    End Sub

    Private Sub InstructorProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInstructorProfile()
    End Sub

    Private Sub LoadInstructorProfile()
        Dim instructorID = CurrentLoggedUser.studentOrInstructorID

        If String.IsNullOrEmpty(instructorID) Then
            MsgBox("No instructor is currently logged in.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim query As String = "SELECT i.first_name, i.middlename, i.last_name, i.suffix, i.gender, i.birthdate, i.email, i.contact_number, i.hire_date, " &
                              "i.department_id, d.department_name " &
                              "FROM instructor_info i " &
                              "LEFT JOIN department_info d ON i.department_id = d.department_id " &
                              "WHERE i.instructor_id = @instructorID"

        Try
            modDb.openConn("schooldb")

            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@instructorID", instructorID)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read()

                        FullName = $"{If(IsDBNull(reader("first_name")), "", reader("first_name").ToString())} " &
                                   $"{If(IsDBNull(reader("middlename")), "", reader("middlename").ToString())} " &
                                   $"{If(IsDBNull(reader("last_name")), "", reader("last_name").ToString())}".Trim()
                        If Not IsDBNull(reader("suffix")) Then FullName &= $" {reader("suffix").ToString()}"

                        Gender = If(IsDBNull(reader("gender")), "N/A", reader("gender").ToString())
                        Birthdate = If(IsDBNull(reader("birthdate")), "N/A", Convert.ToDateTime(reader("birthdate")).ToString("MMMM dd, yyyy"))
                        Email = If(IsDBNull(reader("email")), "N/A", reader("email").ToString())
                        ContactNumber = If(IsDBNull(reader("contact_number")), "N/A", reader("contact_number").ToString())
                        HireDate = If(IsDBNull(reader("hire_date")), "N/A", Convert.ToDateTime(reader("hire_date")).ToString("MMMM dd, yyyy"))
                        Department = If(IsDBNull(reader("department_name")), "N/A", reader("department_name").ToString())

                        id_TextBox.Text = instructorID
                        firstname_TextBox.Text = If(IsDBNull(reader("first_name")), "", reader("first_name").ToString()).Trim()
                        middlename_TextBox.Text = If(IsDBNull(reader("middlename")), "", reader("middlename").ToString())
                        lastname_TextBox.Text = If(IsDBNull(reader("last_name")), "", reader("last_name").ToString())
                        suffix_TextBox.Text = If(IsDBNull(reader("suffix")), "", reader("suffix").ToString())
                        gender_TextBox.Text = Gender
                        birthdate_TextBox.Text = Birthdate
                        email_TextBox.Text = Email
                        contact_TextBox.Text = ContactNumber
                        hiredate_TextBox.Text = HireDate
                        department_TextBox.Text = Department

                        reader.Close()
                    Else
                        MsgBox("No profile found for this instructor.", MsgBoxStyle.Exclamation)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("An error occurred while loading the instructor profile: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If modDb.conn IsNot Nothing AndAlso modDb.conn.State = ConnectionState.Open Then
                modDb.conn.Close()
            End If
        End Try
    End Sub

    Private Sub editProfile_Button_Click(sender As Object, e As EventArgs) Handles editProfile_Button.Click
        firstname_TextBox.Enabled = True
        middlename_TextBox.Enabled = True
        lastname_TextBox.Enabled = True
        suffix_TextBox.Enabled = True
        birthdate_TextBox.Enabled = True
        gender_TextBox.Enabled = True
        contact_TextBox.Enabled = True
        email_TextBox.Enabled = True

        saveChanges_Button.Visible = True
        cancelEdit_Button.Visible = True
    End Sub

    Private Sub saveChanges_Button_Click(sender As Object, e As EventArgs) Handles saveChanges_Button.Click
        Dim sql As String = "UPDATE instructor_info SET "

        Dim values As New List(Of String)

        If firstname_TextBox.Enabled Then
            values.Add("first_name = @firstname")
        End If

        If middlename_TextBox.Enabled Then
            values.Add("middlename = @middlename")
        End If

        If lastname_TextBox.Enabled Then
            values.Add("last_name = @lastname")
        End If

        If suffix_TextBox.Enabled Then
            values.Add("suffix = @suffix")
        End If

        If birthdate_TextBox.Enabled Then
            values.Add("birthdate = @birthdate")
        End If

        If gender_TextBox.Enabled Then
            values.Add("gender = @gender")
        End If

        If contact_TextBox.Enabled Then
            values.Add("contact_number = @contact")
        End If

        If email_TextBox.Enabled Then
            values.Add("email = @email")
        End If

        If values.Count > 0 Then
            sql &= String.Join(", ", values) & " WHERE instructor_id = @instructorID"

            Try
                modDb.openConn(db_name)

                Using cmd As New MySqlCommand(sql, conn)
                    If firstname_TextBox.Enabled Then cmd.Parameters.AddWithValue("@firstname", firstname_TextBox.Text)
                    If middlename_TextBox.Enabled Then cmd.Parameters.AddWithValue("@middlename", middlename_TextBox.Text)
                    If lastname_TextBox.Enabled Then cmd.Parameters.AddWithValue("@lastname", lastname_TextBox.Text)
                    If suffix_TextBox.Enabled Then cmd.Parameters.AddWithValue("@suffix", suffix_TextBox.Text)
                    If birthdate_TextBox.Enabled Then cmd.Parameters.AddWithValue("@birthdate", DateTime.Parse(birthdate_TextBox.Text))
                    If gender_TextBox.Enabled Then cmd.Parameters.AddWithValue("@gender", gender_TextBox.Text)
                    If contact_TextBox.Enabled Then cmd.Parameters.AddWithValue("@contact", contact_TextBox.Text)
                    If email_TextBox.Enabled Then cmd.Parameters.AddWithValue("@email", email_TextBox.Text)
                    cmd.Parameters.AddWithValue("@instructorID", CurrentLoggedUser.studentOrInstructorID)

                    If cmd.ExecuteNonQuery() > 0 Then
                        MessageBox.Show("Changes saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Failed to save changes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    Dim refresh As New InstructorProfile
                    refresh.Show()
                    Me.Close()
                End Using

            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        Else
            MessageBox.Show("No changes to save.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cancelEdit_Button_Click(sender As Object, e As EventArgs) Handles cancelEdit_Button.Click
        Dim refresh As New InstructorProfile
        refresh.Show()
        Me.Close()
    End Sub
End Class