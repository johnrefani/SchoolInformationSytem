

Imports MySql.Data.MySqlClient
Imports System.Collections.Specialized.BitVector32

Public Class addenrolle

    Private selectedStudentId As Integer = 0
    Private selectedSubjectId As Integer = 0
    Private Sub addenrolle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set default school year format (current year - next year)
        Dim currentYear As Integer = DateTime.Now.Year
        eschoolyear.Text = $"{currentYear}-{currentYear + 1}"

        ' Set default payment date to current date
        epaymentdate.Text = DateTime.Now.ToString("yyyy-MM-dd")

        ' Initialize other defaults if needed
        estatus.Text = "Enrolled"
        epaymentstatus.Text = "Pending"
        eamount.Text = "0"
        ebalance.Text = "0"
        ediscount.Text = "0"
    End Sub

    Private Sub estudname_TextChanged(sender As Object, e As EventArgs) Handles estudname.TextChanged
        ' Search for students when text changes
        If estudname.Text.Length > 2 Then ' Only search after 3 characters
            SearchStudents()
        End If
    End Sub

    Private Sub SearchStudents()
        Using conn As MySqlConnection = strconnection()
            Try
                conn.Open()
                Dim query As String = "SELECT student_id, CONCAT(first_name, ' ', IFNULL(middle_initial, ''), ' ', last_name) AS full_name " &
                                     "FROM student WHERE first_name LIKE @search OR middle_initial LIKE @search OR last_name LIKE @search " &
                                     "LIMIT 10"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@search", "%" & estudname.Text & "%")

                    Dim dt As New DataTable()
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)

                    ' Display results in a dropdown or list
                    If dt.Rows.Count > 0 Then
                        Dim studentList As New ListBox()
                        studentList.Width = estudname.Width
                        studentList.Height = 150
                        studentList.Top = estudname.Bottom
                        studentList.Left = estudname.Left
                        studentList.DataSource = dt
                        studentList.DisplayMember = "full_name"
                        studentList.ValueMember = "student_id"

                        AddHandler studentList.Click, Sub(s, ev)
                                                          selectedStudentId = CInt(studentList.SelectedValue)
                                                          estudname.Text = studentList.Text
                                                          studentList.Dispose()
                                                      End Sub

                        Me.Controls.Add(studentList)
                        studentList.BringToFront()
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error searching students: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub esubjectname_TextChanged(sender As Object, e As EventArgs) Handles esubjectname.TextChanged
        ' Search for subjects when text changes
        If esubjectname.Text.Length > 2 Then ' Only search after 3 characters
            SearchSubjects()
        End If
    End Sub

    Private Sub SearchSubjects()
        Using conn As MySqlConnection = strconnection()
            Try
                conn.Open()
                Dim query As String = "SELECT subject_id, subject_name FROM subject " &
                                     "WHERE subject_name LIKE @search LIMIT 10"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@search", "%" & esubjectname.Text & "%")

                    Dim dt As New DataTable()
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)

                    ' Display results in a dropdown or list
                    If dt.Rows.Count > 0 Then
                        Dim subjectList As New ListBox()
                        subjectList.Width = esubjectname.Width
                        subjectList.Height = 150
                        subjectList.Top = esubjectname.Bottom
                        subjectList.Left = esubjectname.Left
                        subjectList.DataSource = dt
                        subjectList.DisplayMember = "subject_name"
                        subjectList.ValueMember = "subject_id"

                        AddHandler subjectList.Click, Sub(s, ev)
                                                          selectedSubjectId = CInt(subjectList.SelectedValue)
                                                          esubjectname.Text = subjectList.Text
                                                          subjectList.Dispose()
                                                      End Sub

                        Me.Controls.Add(subjectList)
                        subjectList.BringToFront()
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error searching subjects: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub savebutton_Click(sender As Object, e As EventArgs) Handles savebutton.Click
        ' Validate required fields
        If selectedStudentId = 0 Then
            MessageBox.Show("Please select a valid student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If selectedSubjectId = 0 Then
            MessageBox.Show("Please select a valid subject", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrWhiteSpace(eschoolyear.Text) OrElse
           String.IsNullOrWhiteSpace(egradelevel.Text) OrElse
           String.IsNullOrWhiteSpace(estatus.Text) OrElse
           String.IsNullOrWhiteSpace(epaymentstatus.Text) Then
            MessageBox.Show("Please fill in all required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validate numeric fields
        Dim amountPaid As Decimal
        Dim balance As Decimal
        Dim discount As Decimal

        If Not Decimal.TryParse(eamount.Text, amountPaid) Then
            MessageBox.Show("Please enter a valid amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not Decimal.TryParse(ebalance.Text, balance) Then
            MessageBox.Show("Please enter a valid balance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not Decimal.TryParse(ediscount.Text, discount) Then
            MessageBox.Show("Please enter a valid discount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conn As MySqlConnection = strconnection()
                conn.Open()

                ' Insert into enrollment table
                Dim query As String = "INSERT INTO enrollment " &
                                     "(student_id, subject_id, school_year, grade_level, section, " &
                                     "status, amount_paid, balance, payment_status, payment_date, " &
                                     "discount_applied, cashier_name, mode_of_payment, remarks) " &
                                     "VALUES " &
                                     "(@student_id, @subject_id, @school_year, @grade_level, @section, " &
                                     "@status, @amount_paid, @balance, @payment_status, @payment_date, " &
                                     "@discount_applied, @cashier_name, @mode_of_payment, @remarks)"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@student_id", selectedStudentId)
                    cmd.Parameters.AddWithValue("@subject_id", selectedSubjectId)
                    cmd.Parameters.AddWithValue("@school_year", eschoolyear.Text)
                    cmd.Parameters.AddWithValue("@grade_level", egradelevel.Text)
                    cmd.Parameters.AddWithValue("@section", esection.Text)
                    cmd.Parameters.AddWithValue("@status", estatus.Text)
                    cmd.Parameters.AddWithValue("@amount_paid", amountPaid)
                    cmd.Parameters.AddWithValue("@balance", balance)
                    cmd.Parameters.AddWithValue("@payment_status", epaymentstatus.Text)

                    ' Handle payment date
                    Dim paymentDate As Object = DBNull.Value
                    If Not String.IsNullOrEmpty(epaymentdate.Text) Then
                        Dim parsedDate As DateTime
                        If DateTime.TryParse(epaymentdate.Text, parsedDate) Then
                            paymentDate = parsedDate
                        End If
                    End If
                    cmd.Parameters.AddWithValue("@payment_date", paymentDate)

                    cmd.Parameters.AddWithValue("@discount_applied", discount)
                    cmd.Parameters.AddWithValue("@cashier_name", If(String.IsNullOrEmpty(cashier.Text), DBNull.Value, cashier.Text))
                    cmd.Parameters.AddWithValue("@mode_of_payment", If(String.IsNullOrEmpty(emode.Text), DBNull.Value, emode.Text))
                    cmd.Parameters.AddWithValue("@remarks", If(String.IsNullOrEmpty(eremarks.Text), DBNull.Value, eremarks.Text))

                    Dim rowsAffected = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Enrollment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ClearForm()
                    Else
                        MessageBox.Show("No enrollment was added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearForm()
        estudname.Text = ""
        esubjectname.Text = ""
        egradelevel.Text = ""
        esection.Text = ""
        estatus.Text = "Enrolled"
        eamount.Text = "0"
        ebalance.Text = "0"
        epaymentstatus.Text = "Pending"
        epaymentdate.Text = DateTime.Now.ToString("yyyy-MM-dd")
        ediscount.Text = "0"
        cashier.Text = ""
        emode.Text = ""
        eremarks.Text = ""

        selectedStudentId = 0
        selectedSubjectId = 0

        ' Reset school year to current year - next year
        Dim currentYear As Integer = DateTime.Now.Year
        eschoolyear.Text = $"{currentYear}-{currentYear + 1}"
    End Sub

    Private Sub cancelbutton_Click(sender As Object, e As EventArgs) Handles cancelbutton.Click
        Me.Close()
        adminframe.Show()

    End Sub
End Class