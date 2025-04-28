Imports MySql.Data.MySqlClient

Public Class editprofile
    Private Sub editprofile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim instructorId As String = GlobalInstructorId
        FetchInstructorData(instructorId)
    End Sub

    Private Sub FetchInstructorData(instructorId As String)
        Try
            Using connection As MySqlConnection = strconnection()
                connection.Open()

                ' SQL query to fetch the instructor data
                Dim query As String = "SELECT * FROM instructor WHERE instructor_id = @InstructorId"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@InstructorId", instructorId)

                    ' Execute the query
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Populate the textboxes with instructor data

                            yearsofexperiencetextbox.Text = reader("years_of_experience").ToString()
                            nationalitytextbox.Text = reader("nationality").ToString()
                            civilstatustextbox.Text = reader("civil_status").ToString()
                            subjecthandledtextbox.Text = reader("subject_handled").ToString()
                            addresstextbox.Text = reader("address").ToString()
                            advisorytextbox.Text = reader("advisory_class").ToString()
                            departmenttextbox.Text = reader("department").ToString()
                            emailaddtextbox.Text = reader("email").ToString()
                            contactnumtextbox.Text = reader("contact_number").ToString()
                            gendertextbox.Text = reader("gender").ToString()
                            lastnametextbox.Text = reader("last_name").ToString()
                            middleinitialtextbox.Text = reader("middle_initial").ToString() ' Assuming middle_name is used for initials
                            firsnametextbox.Text = reader("first_name").ToString()
                        Else
                            MessageBox.Show("Instructor not found.")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub SaveInstructorData()
        Dim instructorId As String = GlobalInstructorId

        ' Combine the full name from the first name, middle initial, and last name
        Dim fullName As String = firsnametextbox.Text & " " & middleinitialtextbox.Text & ". " & lastnametextbox.Text

        Try
            Using connection As MySqlConnection = strconnection()
                connection.Open()

                ' SQL Update query for the instructor
                Dim query As String = "UPDATE instructor SET 
                                first_name = @FirstName,
                                last_name = @LastName,
                                middle_initial = @MiddleName,
                                gender = @Gender,
                                address = @Address,
                                contact_number = @ContactNumber,
                                email = @Email,
                                subject_handled = @SubjectHandled,
                                advisory_class = @AdvisoryClass,
                                department = @Department,
                                civil_status = @CivilStatus,
                                nationality = @Nationality,
                                years_of_experience = @YearsOfExperience
                               WHERE instructor_id = @InstructorId"

                Using cmd As New MySqlCommand(query, connection)
                    ' Add parameters for instructor update
                    cmd.Parameters.AddWithValue("@FirstName", firsnametextbox.Text)
                    cmd.Parameters.AddWithValue("@LastName", lastnametextbox.Text)
                    cmd.Parameters.AddWithValue("@MiddleName", middleinitialtextbox.Text)
                    cmd.Parameters.AddWithValue("@Gender", gendertextbox.Text)
                    cmd.Parameters.AddWithValue("@Address", addresstextbox.Text)
                    cmd.Parameters.AddWithValue("@ContactNumber", contactnumtextbox.Text)
                    cmd.Parameters.AddWithValue("@Email", emailaddtextbox.Text)
                    cmd.Parameters.AddWithValue("@SubjectHandled", subjecthandledtextbox.Text)
                    cmd.Parameters.AddWithValue("@AdvisoryClass", advisorytextbox.Text)
                    cmd.Parameters.AddWithValue("@Department", departmenttextbox.Text)
                    cmd.Parameters.AddWithValue("@CivilStatus", civilstatustextbox.Text)
                    cmd.Parameters.AddWithValue("@Nationality", nationalitytextbox.Text)
                    cmd.Parameters.AddWithValue("@YearsOfExperience", yearsofexperiencetextbox.Text)
                    cmd.Parameters.AddWithValue("@InstructorId", instructorId)

                    ' Execute update for instructor
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        ' Now update the full name in the user table
                        Dim updateUserQuery As String = "UPDATE user SET 
                                                     full_name = @FullName
                                                     WHERE user_id = @InstructorId"

                        Using userCmd As New MySqlCommand(updateUserQuery, connection)
                            userCmd.Parameters.AddWithValue("@FullName", fullName)
                            userCmd.Parameters.AddWithValue("@InstructorId", instructorId)

                            Dim userRowsAffected As Integer = userCmd.ExecuteNonQuery()

                            If userRowsAffected > 0 Then
                                MessageBox.Show("Instructor profile and user full name updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MessageBox.Show("Instructor profile updated, but no matching user found to update.", "Partial Update", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If
                        End Using
                    Else
                        MessageBox.Show("No changes were made to the instructor profile.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating profile: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub savebutton_Click(sender As Object, e As EventArgs) Handles savebutton.Click
        SaveInstructorData()
        Me.Close()
        instructorframe.Show()

    End Sub

    Private Sub cancelbutton_Click(sender As Object, e As EventArgs) Handles cancelbutton.Click
        Me.Close()
        instructorframe.Show()

    End Sub
End Class