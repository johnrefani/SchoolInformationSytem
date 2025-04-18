Imports MySql.Data.MySqlClient

Public Class StudentProfileforStudent

    Private Property FullName As String
    Private Property Gender As String
    Private Property Birthdate As String
    Private Property Email As String
    Private Property ContactNumber As String
    Private Property Address As String
    Private Property EnrolmentDate As String
    Private Property CurrentYear As String
    Private Property Block As String
    Private Property Program As String

    Private Sub StudentProfileforStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadStudentProfile()
    End Sub

    Private Sub LoadStudentProfile()
        Dim studentID = CurrentLoggedUser.studentOrInstructorID

        If String.IsNullOrEmpty(studentID) Then
            MsgBox("No student is currently logged in.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            Dim sql As String = "SELECT s.first_name, s.middlename, s.last_name, s.suffix, s.gender, s.birthdate, 
                     s.email, s.contact_number, s.street, s.barangay, s.municipality, s.province, 
                     s.postal_code, s.enrolment_date, s.current_year, s.block, p.program_code 
                     FROM student_info s 
                     LEFT JOIN program_info p ON s.program_id = p.program_id 
                     WHERE s.student_id = @studentID"

            modDb.openConn("schooldb")

            Using command As New MySqlCommand(sql, modDb.conn)
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@studentID", studentID)

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
                        Address = $"{If(IsDBNull(reader("street")), "", reader("street").ToString())}, " &
                                  $"{If(IsDBNull(reader("barangay")), "", reader("barangay").ToString())}, " &
                                  $"{If(IsDBNull(reader("municipality")), "", reader("municipality").ToString())}, " &
                                  $"{If(IsDBNull(reader("province")), "", reader("province").ToString())}, " &
                                  $"{If(IsDBNull(reader("postal_code")), "N/A", reader("postal_code").ToString())}".Trim(", ")

                        EnrolmentDate = If(IsDBNull(reader("enrolment_date")), "N/A", Convert.ToDateTime(reader("enrolment_date")).ToString("MMMM dd, yyyy"))
                        CurrentYear = If(IsDBNull(reader("current_year")), "N/A", reader("current_year").ToString())
                        Block = If(IsDBNull(reader("block")), "", reader("block").ToString())
                        Program = If(IsDBNull(reader("program_code")), "", reader("program_code").ToString())

                        student_studentid_TextBox.Text = studentID
                        student_firstname_TextBox.Text = If(IsDBNull(reader("first_name")), "", reader("first_name").ToString()).Trim()
                        student_middlename_TextBox.Text = If(IsDBNull(reader("middlename")), "", reader("middlename").ToString())
                        student_lastname_TextBox.Text = If(IsDBNull(reader("last_name")), "", reader("last_name").ToString())
                        suffix_TextBox.Text = If(IsDBNull(reader("suffix")), "", reader("suffix").ToString())
                        student_gender_TextBox.Text = Gender
                        student_birthdate_TextBox.Text = Birthdate
                        student_email_TextBox.Text = Email
                        student_contact_TextBox.Text = ContactNumber
                        student_street_TextBox.Text = If(IsDBNull(reader("street")), "", reader("street").ToString())
                        student_barangay_TextBox.Text = If(IsDBNull(reader("barangay")), "", reader("barangay").ToString())
                        student_municipality_TextBox.Text = If(IsDBNull(reader("municipality")), "", reader("municipality").ToString())
                        student_province_TextBox.Text = If(IsDBNull(reader("province")), "", reader("province").ToString())
                        student_postalcode_TextBox.Text = If(IsDBNull(reader("postal_code")), "N/A", reader("postal_code").ToString())
                        student_enrolmentdate_TextBox.Text = EnrolmentDate
                        yearLevel_ComboBox.Text = CurrentYear
                        block_ComboBox.Text = Block
                        program_TextBox.Text = Program

                        reader.Close()
                    Else
                        MsgBox("No profile found for this student.", MsgBoxStyle.Exclamation)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("An error occurred while loading the student profile: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If modDb.conn IsNot Nothing AndAlso modDb.conn.State = ConnectionState.Open Then
                modDb.conn.Close()
            End If
        End Try
    End Sub

    Private Sub student_profile_Button_Click(sender As Object, e As EventArgs) Handles student_profile_Button.Click
        Dim newPfpStudent As New StudentProfileforStudent
        newPfpStudent.Show()
        Me.Close()
    End Sub

    Private Sub student_addCR_Button_Click(sender As Object, e As EventArgs) Handles student_addCR_Button.Click
        Dim enrolledSubs As New EnrolledSubjectOfStudent
        enrolledSubs.Show()
        Me.Close()
    End Sub

    Private Sub transcript_Button_Click(sender As Object, e As EventArgs) Handles transcript_Button.Click
        Dim transcript As New TranscriptOfStudent
        transcript.Show()
        Me.Close()
    End Sub

    Private Sub student_logout_Button_Click(sender As Object, e As EventArgs) Handles student_logout_Button.Click
        Dim loginAgain As New LoginPage
        loginAgain.Show()
        Close()
    End Sub

    Private Sub editProfile_Button_Click(sender As Object, e As EventArgs) Handles editProfile_Button.Click
        yearLevel_ComboBox.Enabled = True
        block_ComboBox.Enabled = True
        student_firstname_TextBox.Enabled = True
        student_middlename_TextBox.Enabled = True
        student_lastname_TextBox.Enabled = True
        suffix_TextBox.Enabled = True
        student_birthdate_TextBox.Enabled = True
        student_gender_TextBox.Enabled = True
        student_street_TextBox.Enabled = True
        student_barangay_TextBox.Enabled = True
        student_municipality_TextBox.Enabled = True
        student_province_TextBox.Enabled = True
        student_email_TextBox.Enabled = True
        student_contact_TextBox.Enabled = True
        student_postalcode_TextBox.Enabled = True

        saveChanges_Button.Visible = True
        cancelEdit_Button.Visible = True
    End Sub

    Private Sub saveChanges_Button_Click(sender As Object, e As EventArgs) Handles saveChanges_Button.Click
        Dim sql As String = "UPDATE student_info SET "

        Dim values As New List(Of String)

        If yearLevel_ComboBox.Enabled Then
            values.Add("current_year = @yearLevel")
        End If

        If block_ComboBox.Enabled Then
            values.Add("block = @block")
        End If

        If student_firstname_TextBox.Enabled Then
            values.Add("first_name = @firstname")
        End If

        If student_middlename_TextBox.Enabled Then
            values.Add("middlename = @middlename")
        End If

        If student_lastname_TextBox.Enabled Then
            values.Add("last_name = @lastname")
        End If

        If suffix_TextBox.Enabled Then
            values.Add("suffix = @suffix")
        End If

        If student_birthdate_TextBox.Enabled Then
            values.Add("birthdate = @birthdate")
        End If

        If student_gender_TextBox.Enabled Then
            values.Add("gender = @gender")
        End If

        If student_street_TextBox.Enabled Then
            values.Add("street = @street")
        End If

        If student_barangay_TextBox.Enabled Then
            values.Add("barangay = @barangay")
        End If

        If student_municipality_TextBox.Enabled Then
            values.Add("municipality = @municipality")
        End If

        If student_province_TextBox.Enabled Then
            values.Add("province = @province")
        End If

        If student_email_TextBox.Enabled Then
            values.Add("email = @email")
        End If

        If student_contact_TextBox.Enabled Then
            values.Add("contact_number = @contact")
        End If

        If student_postalcode_TextBox.Enabled Then
            values.Add("postal_code = @postalcode")
        End If

        If values.Count > 0 Then
            sql &= String.Join(", ", values) & " WHERE student_id = @studentID"

            Try
                modDb.openConn(db_name)

                Using cmd As New MySqlCommand(sql, conn)
                    If yearLevel_ComboBox.Enabled Then cmd.Parameters.AddWithValue("@yearLevel", yearLevel_ComboBox.SelectedValue)
                    If block_ComboBox.Enabled Then cmd.Parameters.AddWithValue("@block", block_ComboBox.Text)
                    If student_firstname_TextBox.Enabled Then cmd.Parameters.AddWithValue("@firstname", student_firstname_TextBox.Text)
                    If student_middlename_TextBox.Enabled Then cmd.Parameters.AddWithValue("@middlename", student_middlename_TextBox.Text)
                    If student_lastname_TextBox.Enabled Then cmd.Parameters.AddWithValue("@lastname", student_lastname_TextBox.Text)
                    If suffix_TextBox.Enabled Then cmd.Parameters.AddWithValue("@suffix", suffix_TextBox.Text)
                    If student_birthdate_TextBox.Enabled Then cmd.Parameters.AddWithValue("@birthdate", DateTime.Parse(student_birthdate_TextBox.Text))
                    If student_gender_TextBox.Enabled Then cmd.Parameters.AddWithValue("@gender", student_gender_TextBox.Text)
                    If student_street_TextBox.Enabled Then cmd.Parameters.AddWithValue("@street", student_street_TextBox.Text)
                    If student_barangay_TextBox.Enabled Then cmd.Parameters.AddWithValue("@barangay", student_barangay_TextBox.Text)
                    If student_municipality_TextBox.Enabled Then cmd.Parameters.AddWithValue("@municipality", student_municipality_TextBox.Text)
                    If student_province_TextBox.Enabled Then cmd.Parameters.AddWithValue("@province", student_province_TextBox.Text)
                    If student_email_TextBox.Enabled Then cmd.Parameters.AddWithValue("@email", student_email_TextBox.Text)
                    If student_contact_TextBox.Enabled Then cmd.Parameters.AddWithValue("@contact", student_contact_TextBox.Text)
                    If student_postalcode_TextBox.Enabled Then cmd.Parameters.AddWithValue("@postalcode", student_postalcode_TextBox.Text)
                    cmd.Parameters.AddWithValue("@studentID", CurrentLoggedUser.studentOrInstructorID)

                    If cmd.ExecuteNonQuery() > 0 Then
                        MessageBox.Show("Changes saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Failed to save changes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    Dim refresh As New StudentProfileforStudent
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
        Dim refresh As New StudentProfileforStudent
        refresh.Show()
        Me.Close()
    End Sub
End Class