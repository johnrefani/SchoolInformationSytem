Imports MySql.Data.MySqlClient

Public Class editenrolle
    ' Public property to receive the enrollment ID
    Public Property EnrollmentId As Integer

    ' Default constructor (required for Windows Forms)
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub

    Private Sub editenrolle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Only load data if EnrollmentId has been set
        If EnrollmentId > 0 Then
            LoadEnrollmentData()
        Else
            MessageBox.Show("No enrollment ID provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
    End Sub

    Private Sub LoadEnrollmentData()
        Using conn As MySqlConnection = strconnection()
            Try
                conn.Open()

                ' Get enrollment data with student and subject names
                Dim query As String = "SELECT e.*, CONCAT(s.last_name, ' ', s.first_name, ' ', s.middle_name) AS student_name, sub.subject_name " &
                                     "FROM enrollment e " &
                                     "JOIN student s ON e.student_id = s.student_id " &
                                     "JOIN subject sub ON e.subject_id = sub.subject_id " &
                                     "WHERE e.enrollment_id = @id"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", EnrollmentId)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Display the data in the form fields
                            eid.Text = EnrollmentId.ToString()
                            estudentname.Text = reader("student_name").ToString()
                            esubjectname.Text = reader("subject_name").ToString()
                            eschoolyear.Text = reader("school_year").ToString()
                            egradelevel.Text = reader("grade_level").ToString()
                            esection.Text = reader("section").ToString()
                            estatus.Text = reader("status").ToString()
                            eremarks.Text = If(reader.IsDBNull(reader.GetOrdinal("remarks")), "", reader("remarks").ToString())
                            epaymentstatus.Text = reader("payment_status").ToString()
                            eamount.Text = If(reader.IsDBNull(reader.GetOrdinal("amount_paid")), "", reader("amount_paid").ToString())
                            ebalance.Text = If(reader.IsDBNull(reader.GetOrdinal("balance")), "", reader("balance").ToString())
                            epaymentdate.Text = If(reader.IsDBNull(reader.GetOrdinal("payment_date")), "", reader("payment_date").ToString())
                            cashier.Text = If(reader.IsDBNull(reader.GetOrdinal("cashier_name")), "", reader("cashier_name").ToString())
                            ediscount.Text = If(reader.IsDBNull(reader.GetOrdinal("discount_applied")), "", reader("discount_applied").ToString())
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading enrollment data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub eupdatebutton_Click(sender As Object, e As EventArgs) Handles eupdatebutton.Click
        ' Validate required fields
        If String.IsNullOrWhiteSpace(estatus.Text) OrElse
           String.IsNullOrWhiteSpace(epaymentstatus.Text) Then
            MessageBox.Show("Please fill in all required fields (Status and Payment Status)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validate amount and balance if payment status is "Paid"
        If epaymentstatus.Text = "Paid" Then
            Dim amountPaid As Decimal
            Dim balance As Decimal

            If Not Decimal.TryParse(eamount.Text, amountPaid) Then
                MessageBox.Show("Please enter a valid amount paid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Not Decimal.TryParse(ebalance.Text, balance) Then
                MessageBox.Show("Please enter a valid balance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If balance <> 0 Then
                MessageBox.Show("Balance should be 0 when payment status is 'Paid'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If String.IsNullOrWhiteSpace(epaymentdate.Text) Then
                MessageBox.Show("Payment date is required when payment status is 'Paid'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If

        Try
            Using conn As MySqlConnection = strconnection()
                conn.Open()

                ' Update enrollment table
                Dim query As String = "UPDATE enrollment SET " &
                                     "status = @status, " &
                                     "remarks = @remarks, " &
                                     "payment_status = @payment_status, " &
                                     "amount_paid = @amount_paid, " &
                                     "balance = @balance, " &
                                     "mode_of_payment = @mode_of_payment, " &
                                     "payment_date = @payment_date, " &
                                     "cashier_name = @cashier_name, " &
                                     "discount_applied = @discount_applied " &
                                     "WHERE enrollment_id = @id"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", EnrollmentId)
                    cmd.Parameters.AddWithValue("@status", estatus.Text)
                    cmd.Parameters.AddWithValue("@remarks", If(String.IsNullOrEmpty(eremarks.Text), DBNull.Value, eremarks.Text))
                    cmd.Parameters.AddWithValue("@payment_status", epaymentstatus.Text)

                    ' Handle numeric values
                    Dim amountPaid As Decimal = 0
                    Decimal.TryParse(eamount.Text, amountPaid)
                    cmd.Parameters.AddWithValue("@amount_paid", amountPaid)

                    Dim balance As Decimal = 0
                    Decimal.TryParse(ebalance.Text, balance)
                    cmd.Parameters.AddWithValue("@balance", balance)

                    cmd.Parameters.AddWithValue("@mode_of_payment", If(String.IsNullOrEmpty(epaymentstatus.Text), DBNull.Value, epaymentstatus.Text))

                    ' Handle payment date (convert from string to DateTime if needed)
                    Dim paymentDate As Object = DBNull.Value
                    If Not String.IsNullOrEmpty(epaymentdate.Text) Then
                        Dim parsedDate As DateTime
                        If DateTime.TryParse(epaymentdate.Text, parsedDate) Then
                            paymentDate = parsedDate
                        End If
                    End If
                    cmd.Parameters.AddWithValue("@payment_date", paymentDate)

                    cmd.Parameters.AddWithValue("@cashier_name", If(String.IsNullOrEmpty(cashier.Text), DBNull.Value, cashier.Text))

                    ' Handle discount (could be percentage or amount)
                    Dim discount As Decimal = 0
                    Decimal.TryParse(ediscount.Text, discount)
                    cmd.Parameters.AddWithValue("@discount_applied", discount)

                    Dim rowsAffected = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Enrollment updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    Else
                        MessageBox.Show("No changes were made to the enrollment.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub edeletebutton_Click(sender As Object, e As EventArgs) Handles edeletebutton.Click
        ' Confirm with the user before deleting
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this enrollment record?",
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
                        ' Delete the enrollment record
                        Dim query As String = "DELETE FROM enrollment WHERE enrollment_id = @id"
                        Using cmd As New MySqlCommand(query, conn, transaction)
                            cmd.Parameters.AddWithValue("@id", EnrollmentId)
                            Dim rowsAffected = cmd.ExecuteNonQuery()

                            If rowsAffected > 0 Then
                                transaction.Commit()
                                MessageBox.Show("Enrollment deleted successfully!", "Success",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Me.Close()
                            Else
                                transaction.Rollback()
                                MessageBox.Show("No enrollment was deleted.", "Information",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End Using

                    Catch ex As Exception
                        transaction.Rollback()
                        MessageBox.Show("Error deleting enrollment: " & ex.Message, "Error",
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
    End Sub
End Class