Imports System.Drawing.Printing
Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient

Public Class studentframe


    Private Sub studentframe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HideAllPanels()
        dashboardpanel.Visible = True
        HighlightActiveButton(dashboardbutton)

        ' Call method to load the student profile using the global studentId
        LoadStudentProfile()
    End Sub

    ' Hide all panels
    Private Sub HideAllPanels()
        dashboardpanel.Visible = False
        classespanel.Visible = False
        myprofilepanel.Visible = False
    End Sub

    ' Highlight active button in navigation
    Sub HighlightActiveButton(activeBtn As Button)
        Dim buttons As Button() = {dashboardbutton, classesbutton, myprofilebutton}

        For Each btn As Button In buttons
            btn.BackColor = Color.Transparent
        Next

        activeBtn.BackColor = ColorTranslator.FromHtml("#ADADAD")
    End Sub

    Private Sub dashboardbutton_Click(sender As Object, e As EventArgs) Handles dashboardbutton.Click
        HideAllPanels()
        dashboardpanel.Visible = True
        HighlightActiveButton(dashboardbutton)
    End Sub

    Private Sub classesbutton_Click(sender As Object, e As EventArgs) Handles classesbutton.Click
        HideAllPanels()
        classespanel.Visible = True
        HighlightActiveButton(classesbutton)
    End Sub

    Private Sub myprofilebutton_Click(sender As Object, e As EventArgs) Handles myprofilebutton.Click
        HideAllPanels()
        myprofilepanel.Visible = True
        HighlightActiveButton(myprofilebutton)
    End Sub

    ' Method to load student profile using the global studentId
    Private Sub LoadStudentProfile()
        Dim studentId As String = GlobalStudentId ' Retrieve the stored studentId from the global variable

        ' Use studentId to query the student data from your database
        Dim conn As MySqlConnection = strconnection()

        Try
            conn.Open()
            Dim query As String = "SELECT * FROM student WHERE student_id = @studentId"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@studentId", studentId)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                ' Display student information on the profile panel
                student_name.Text = reader("first_name").ToString() & " " & reader("middle_initial").ToString() & ". " & reader("last_name").ToString()
                student_fullname.Text = reader("first_name").ToString() & " " & reader("middle_initial").ToString() & ". " & reader("last_name").ToString()
                student_email.Text = reader("email").ToString()
                student_contact.Text = reader("contact_number").ToString()
                student_address.Text = reader("address").ToString()
                student_gender.Text = reader("gender").ToString()
                student_age.Text = reader("age").ToString()
                student_grade.Text = reader("grade_level").ToString()
                student_birthplace.Text = reader("birth_place").ToString()
                student_nationality.Text = reader("nationality").ToString()
                student_guardian.Text = reader("guardian_name").ToString()
                student_religion.Text = reader("religion").ToString()

                ' Other profile fields can be added here
            Else
                MessageBox.Show("Student profile not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading profile data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub logoutbutton_Click(sender As Object, e As EventArgs) Handles logoutbutton.Click
        Me.Close()
        login.Show()
        connection.Close()
    End Sub

    Private Sub editprofile_Click(sender As Object, e As EventArgs) Handles editprofile.Click
        editstudent.Show()
        Me.Close()
    End Sub


    Private Sub subject_panel_Paint(sender As Object, e As PaintEventArgs) Handles subject_panel.Paint
        Dim studentId As String = GlobalStudentId
        Try
            Using conn As MySqlConnection = strconnection()
                conn.Open()

                ' SQL query to count enrolled subjects per semester for a specific student
                Dim query As String = "
                SELECT s.semester, COUNT(e.subject_id) as subject_count
                FROM enrollment e
                INNER JOIN subject s ON e.subject_id = s.subject_id
                WHERE e.student_id = @studentId
                GROUP BY s.semester
                ORDER BY s.semester"

                Using cmd As New MySqlCommand(query, conn)
                    ' Replace @studentId with actual student ID parameter
                    cmd.Parameters.AddWithValue("@studentId", studentId) ' Ensure studentId is defined

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        ' Clear existing series
                        StudBarChart.Series.Clear()

                        ' Create new series for the bar chart
                        Dim series As New DataVisualization.Charting.Series("Enrolled Subjects")
                        series.ChartType = DataVisualization.Charting.SeriesChartType.Bar

                        ' Add data points from query results
                        While reader.Read()
                            Dim semester As String = reader("semester").ToString()
                            Dim count As Integer = Convert.ToInt32(reader("subject_count"))
                            series.Points.AddXY(semester, count)
                        End While

                        ' Add series to chart
                        StudBarChart.Series.Add(series)

                        ' Customize chart appearance
                        StudBarChart.Titles.Clear()
                        StudBarChart.Titles.Add("Enrolled Subjects per Semester")
                        StudBarChart.ChartAreas(0).AxisX.Title = "Semester"
                        StudBarChart.ChartAreas(0).AxisY.Title = "Number of Subjects"
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading chart data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub schedule_panel_Paint(sender As Object, e As PaintEventArgs) Handles schedule_panel.Paint
        Dim studentId As String = GlobalStudentId
        Dim conn As MySqlConnection = strconnection()
        Try
            conn.Open()
            Dim query As String = "SELECT s.subject_name, s.day, s.schedule_time, s.room_number " &
                             "FROM enrollment e " &
                             "JOIN subject s ON e.subject_id = s.subject_id " &
                             "WHERE e.student_id = @studentId"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@studentId", studentId) ' Ensure studentId is defined or passed

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            ScheduleDataGrid.DataSource = dt

            ' Optional: Set column headers for better display
            With ScheduleDataGrid
                .Columns("subject_name").HeaderText = "Subject Name"
                .Columns("day").HeaderText = "Day"
                .Columns("schedule_time").HeaderText = "Schedule Time"
                .Columns("room_number").HeaderText = "Room Number"
            End With
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim studentId As String = GlobalStudentId
        Dim conn As MySqlConnection = strconnection()
        Try
            conn.Open()
            Dim query As String = "SELECT e.enrollment_id, s.subject_name, s.subject_code, s.section, " &
                             "e.status, e.balance, e.amount_paid, e.payment_status, e.remarks " &
                             "FROM enrollment e " &
                             "JOIN subject s ON e.subject_id = s.subject_id " &
                             "WHERE e.student_id = @studentId"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@studentId", studentId) ' Ensure studentId is defined or passed

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            enrolldatagrid.DataSource = dt

            ' Optional: Set column headers for better display
            With enrolldatagrid
                .Columns("enrollment_id").HeaderText = "Enrollment ID"
                .Columns("subject_name").HeaderText = "Subject Name"
                .Columns("subject_code").HeaderText = "Subject Code"
                .Columns("section").HeaderText = "Section"
                .Columns("status").HeaderText = "Status"
                .Columns("balance").HeaderText = "Balance"
                .Columns("amount_paid").HeaderText = "Amount Paid"
                .Columns("payment_status").HeaderText = "Payment Status"
                .Columns("remarks").HeaderText = "Remarks"
            End With
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub





















    ' For setting the variables
    Private currentEnrollmentPage As Integer = 1
    Private enrollmentPageSize As Integer = 15
    Private totalEnrollmentRecords As Integer = 0
    Private totalEnrollmentPages As Integer = 0
    Private isEnrollmentSearching As Boolean = False

    ' For loading the form
    Private Sub EnrollmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupFilterComboBoxes()
        AddHandler classsearch.TextChanged, AddressOf ClassSearch_TextChanged
        LoadEnrollmentData()
    End Sub

    Private Sub LoadEnrollmentData()
        Dim offset As Integer = (currentEnrollmentPage - 1) * enrollmentPageSize
        Dim selectedSchoolYear As String = filterschoolyear.SelectedItem?.ToString()
        Dim selectedStatus As String = filterstatus.SelectedItem?.ToString()

        Using conn As MySqlConnection = strconnection()
            Try
                conn.Open()

                ' Count query
                Dim countQuery As String = "SELECT COUNT(*) FROM enrollment WHERE student_id = @studentId"

                If selectedSchoolYear <> "All School Years" AndAlso Not String.IsNullOrEmpty(selectedSchoolYear) Then
                    countQuery &= " AND school_year = @schoolYear"
                End If

                If selectedStatus <> "All Status" AndAlso Not String.IsNullOrEmpty(selectedStatus) Then
                    countQuery &= " AND status = @status"
                End If

                Using countCmd As New MySqlCommand(countQuery, conn)
                    countCmd.Parameters.AddWithValue("@studentId", GlobalStudentId)

                    If selectedSchoolYear <> "All School Years" AndAlso Not String.IsNullOrEmpty(selectedSchoolYear) Then
                        countCmd.Parameters.AddWithValue("@schoolYear", selectedSchoolYear)
                    End If

                    If selectedStatus <> "All Status" AndAlso Not String.IsNullOrEmpty(selectedStatus) Then
                        countCmd.Parameters.AddWithValue("@status", selectedStatus)
                    End If

                    totalEnrollmentRecords = Convert.ToInt32(countCmd.ExecuteScalar())
                    totalEnrollmentPages = Math.Ceiling(totalEnrollmentRecords / enrollmentPageSize)
                End Using

                ' Main query with joins to get student name and subject name
                Dim query As String = "SELECT e.enrollment_id, CONCAT(s.first_name,' ',s.middle_initial,' ',s.last_name) AS student_name, sub.subject_name, 
                                 e.school_year, e.grade_level, e.section, e.status, e.remarks, 
                                 e.payment_status, e.amount_paid, e.balance, e.mode_of_payment, 
                                 e.payment_date, e.cashier_name, e.discount_applied
                                 FROM enrollment e
                                 JOIN student s ON e.student_id = s.student_id
                                 JOIN subject sub ON e.subject_id = sub.subject_id
                                 WHERE e.student_id = @studentId"

                If selectedSchoolYear <> "All School Years" AndAlso Not String.IsNullOrEmpty(selectedSchoolYear) Then
                    query &= " AND e.school_year = @schoolYear"
                End If

                If selectedStatus <> "All Status" AndAlso Not String.IsNullOrEmpty(selectedStatus) Then
                    query &= " AND e.status = @status"
                End If

                query &= " LIMIT @limit OFFSET @offset"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@studentId", GlobalStudentId)

                    If selectedSchoolYear <> "All School Years" AndAlso Not String.IsNullOrEmpty(selectedSchoolYear) Then
                        cmd.Parameters.AddWithValue("@schoolYear", selectedSchoolYear)
                    End If

                    If selectedStatus <> "All Status" AndAlso Not String.IsNullOrEmpty(selectedStatus) Then
                        cmd.Parameters.AddWithValue("@status", selectedStatus)
                    End If

                    cmd.Parameters.AddWithValue("@limit", enrollmentPageSize)
                    cmd.Parameters.AddWithValue("@offset", offset)

                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)
                        classdatagrid.DataSource = dt
                    End Using
                End Using

                UpdateEnrollmentPaginationUI()
                SetupEnrollmentDataGridView()

            Catch ex As Exception
                MessageBox.Show("Error loading enrollment data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub FilterEnrollmentData()
        isEnrollmentSearching = True
        Dim offset As Integer = (currentEnrollmentPage - 1) * enrollmentPageSize
        Dim selectedSchoolYear As String = filterschoolyear.SelectedItem?.ToString()
        Dim selectedStatus As String = filterstatus.SelectedItem?.ToString()
        Dim searchText As String = classsearch.Text

        Using conn As MySqlConnection = strconnection()
            Try
                conn.Open()

                ' Counting filtered
                Dim countQuery As String = "SELECT COUNT(*) FROM enrollment e
                                      JOIN student s ON e.student_id = s.student_id
                                      JOIN subject sub ON e.subject_id = sub.subject_id
                                      WHERE e.student_id = @studentId
                                      AND (s.last_name LIKE @search OR sub.subject_name LIKE @search)"

                If selectedSchoolYear <> "All School Years" AndAlso Not String.IsNullOrEmpty(selectedSchoolYear) Then
                    countQuery &= " AND e.school_year = @schoolYear"
                End If

                If selectedStatus <> "All Status" AndAlso Not String.IsNullOrEmpty(selectedStatus) Then
                    countQuery &= " AND e.status = @status"
                End If

                Using countCmd As New MySqlCommand(countQuery, conn)
                    countCmd.Parameters.AddWithValue("@studentId", GlobalStudentId)
                    countCmd.Parameters.AddWithValue("@search", "%" & searchText & "%")

                    If selectedSchoolYear <> "All School Years" AndAlso Not String.IsNullOrEmpty(selectedSchoolYear) Then
                        countCmd.Parameters.AddWithValue("@schoolYear", selectedSchoolYear)
                    End If

                    If selectedStatus <> "All Status" AndAlso Not String.IsNullOrEmpty(selectedStatus) Then
                        countCmd.Parameters.AddWithValue("@status", selectedStatus)
                    End If

                    totalEnrollmentRecords = Convert.ToInt32(countCmd.ExecuteScalar())
                    totalEnrollmentPages = Math.Ceiling(totalEnrollmentRecords / enrollmentPageSize)
                End Using

                ' Query for searching
                Dim query As String = "SELECT e.enrollment_id, CONCAT(s.first_name,' ',s.middle_initial,' ',s.last_name) AS student_name, sub.subject_name, 
                                 e.school_year, e.grade_level, e.section, e.status, e.remarks, 
                                 e.payment_status, e.amount_paid, e.balance, e.mode_of_payment, 
                                 e.payment_date, e.cashier_name, e.discount_applied
                                 FROM enrollment e
                                 JOIN student s ON e.student_id = s.student_id
                                 JOIN subject sub ON e.subject_id = sub.subject_id
                                 WHERE e.student_id = @studentId
                                 AND (s.last_name LIKE @search OR sub.subject_name LIKE @search)"

                If selectedSchoolYear <> "All School Years" AndAlso Not String.IsNullOrEmpty(selectedSchoolYear) Then
                    query &= " AND e.school_year = @schoolYear"
                End If

                If selectedStatus <> "All Status" AndAlso Not String.IsNullOrEmpty(selectedStatus) Then
                    query &= " AND e.status = @status"
                End If

                query &= " LIMIT @limit OFFSET @offset"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@studentId", GlobalStudentId)
                    cmd.Parameters.AddWithValue("@search", "%" & searchText & "%")

                    If selectedSchoolYear <> "All School Years" AndAlso Not String.IsNullOrEmpty(selectedSchoolYear) Then
                        cmd.Parameters.AddWithValue("@schoolYear", selectedSchoolYear)
                    End If

                    If selectedStatus <> "All Status" AndAlso Not String.IsNullOrEmpty(selectedStatus) Then
                        cmd.Parameters.AddWithValue("@status", selectedStatus)
                    End If

                    cmd.Parameters.AddWithValue("@limit", enrollmentPageSize)
                    cmd.Parameters.AddWithValue("@offset", offset)

                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)
                        classdatagrid.DataSource = dt
                    End Using
                End Using

                UpdateEnrollmentPaginationUI()
                SetupEnrollmentDataGridView()

            Catch ex As Exception
                MessageBox.Show("Error filtering enrollment data: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Set column headers and the design of the table
    Private Sub SetupEnrollmentDataGridView()
        Dim headers As String() = {"Enrollment ID", "Student Name", "Subject Name", "School Year",
                             "Grade Level", "Section", "Status", "Remarks", "Payment Status",
                             "Amount Paid", "Balance", "Mode of Payment", "Payment Date",
                             "Cashier Name", "Discount Applied"}

        With classdatagrid
            If .Columns.Count = headers.Length Then
                For i As Integer = 0 To headers.Length - 1
                    .Columns(i).HeaderText = headers(i)
                Next
            End If
            .DefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)
            .DefaultCellStyle.Font = New Font("Tahoma", 10)
        End With
    End Sub

    ' Updating the label and button states (this for pagination)
    Private Sub UpdateEnrollmentPaginationUI()
        studlabel.Text = $"Page {currentEnrollmentPage} of {If(totalEnrollmentPages = 0, 1, totalEnrollmentPages)}"
        studprev.Enabled = currentEnrollmentPage > 1
        studnext.Enabled = currentEnrollmentPage < totalEnrollmentPages
    End Sub

    Private Sub SetupFilterComboBoxes()
        ' Setup school year filter
        filterschoolyear.Items.Clear()
        filterschoolyear.Items.Add("All School Years")

        Using conn As MySqlConnection = strconnection()
            Try
                conn.Open()
                Dim query As String = "SELECT DISTINCT school_year FROM enrollment WHERE student_id = @studentId ORDER BY school_year DESC"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@studentId", GlobalStudentId)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            filterschoolyear.Items.Add(reader("school_year").ToString())
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading school years: " & ex.Message)
            End Try
        End Using

        filterschoolyear.SelectedIndex = 0

        ' Setup status filter
        filterstatus.Items.Clear()
        filterstatus.Items.Add("All Status")
        filterstatus.Items.Add("Active")
        filterstatus.Items.Add("Inactive")
        filterstatus.Items.Add("Completed")
        filterstatus.Items.Add("Dropped")
        filterstatus.SelectedIndex = 0
    End Sub

    ' Updating the search results
    Private Sub ClassSearch_TextChanged(sender As Object, e As EventArgs)
        currentEnrollmentPage = 1
        If String.IsNullOrWhiteSpace(classsearch.Text) Then
            isEnrollmentSearching = False
            LoadEnrollmentData()
        Else
            FilterEnrollmentData()
        End If
    End Sub

    'For filtering by school year
    Private Sub FilterSchoolYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filterschoolyear.SelectedIndexChanged
        currentEnrollmentPage = 1
        If String.IsNullOrWhiteSpace(classsearch.Text) Then
            LoadEnrollmentData()
        Else
            FilterEnrollmentData()
        End If
    End Sub

    'For filtering by status
    Private Sub FilterStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filterstatus.SelectedIndexChanged
        currentEnrollmentPage = 1
        If String.IsNullOrWhiteSpace(classsearch.Text) Then
            LoadEnrollmentData()
        Else
            FilterEnrollmentData()
        End If
    End Sub

    ' Next Page Button
    Private Sub StudNext_Click(sender As Object, e As EventArgs) Handles studnext.Click
        If currentEnrollmentPage < totalEnrollmentPages Then
            currentEnrollmentPage += 1
            If isEnrollmentSearching Then
                FilterEnrollmentData()
            Else
                LoadEnrollmentData()
            End If
        End If
    End Sub

    ' Prev Page Button
    Private Sub StudPrev_Click(sender As Object, e As EventArgs) Handles studprev.Click
        If currentEnrollmentPage > 1 Then
            currentEnrollmentPage -= 1
            If isEnrollmentSearching Then
                FilterEnrollmentData()
            Else
                LoadEnrollmentData()
            End If
        End If
    End Sub

    Private Sub StudPrint_Click(sender As Object, e As EventArgs) Handles studprint.Click
        ' Create a PrintDocument
        Dim printDoc As New PrintDocument()
        AddHandler printDoc.PrintPage, AddressOf PrintEnrollmentPageHandler

        ' Show print dialog
        Dim printDialog As New PrintDialog()
        printDialog.Document = printDoc

        If printDialog.ShowDialog() = DialogResult.OK Then
            printDoc.Print()
        End If
    End Sub

    Private Sub PrintEnrollmentPageHandler(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Dim selectedSchoolYear As String = filterschoolyear.SelectedItem?.ToString()
        Dim selectedStatus As String = filterstatus.SelectedItem?.ToString()
        Dim searchText As String = classsearch.Text

        ' Get the data to print
        Dim dt As New DataTable()

        Using conn As MySqlConnection = strconnection()
            Try
                conn.Open()

                Dim query As String = "SELECT CONCAT(s.first_name,' ',s.middle_initial,' ',s.last_name) AS student_name, sub.subject_name, 
                                  e.grade_level, e.remarks, e.payment_status
                                  FROM enrollment e
                                  JOIN student s ON e.student_id = s.student_id
                                  JOIN subject sub ON e.subject_id = sub.subject_id
                                  WHERE e.student_id = @studentId"

                Dim whereClauses As New List(Of String)

                If Not String.IsNullOrWhiteSpace(searchText) Then
                    whereClauses.Add("(s.last_name LIKE @search OR sub.subject_name LIKE @search)")
                End If

                If selectedSchoolYear <> "All School Years" AndAlso Not String.IsNullOrEmpty(selectedSchoolYear) Then
                    whereClauses.Add("e.school_year = @schoolYear")
                End If

                If selectedStatus <> "All Status" AndAlso Not String.IsNullOrEmpty(selectedStatus) Then
                    whereClauses.Add("e.status = @status")
                End If

                If whereClauses.Count > 0 Then
                    query &= " AND " & String.Join(" AND ", whereClauses)
                End If

                ' For printing, we want all matching records (no pagination)
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@studentId", GlobalStudentId)

                    If Not String.IsNullOrWhiteSpace(searchText) Then
                        cmd.Parameters.AddWithValue("@search", "%" & searchText & "%")
                    End If

                    If selectedSchoolYear <> "All School Years" AndAlso Not String.IsNullOrEmpty(selectedSchoolYear) Then
                        cmd.Parameters.AddWithValue("@schoolYear", selectedSchoolYear)
                    End If

                    If selectedStatus <> "All Status" AndAlso Not String.IsNullOrEmpty(selectedStatus) Then
                        cmd.Parameters.AddWithValue("@status", selectedStatus)
                    End If

                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error preparing enrollment data for printing: " & ex.Message)
                Return
            End Try
        End Using

        ' Set up printing parameters
        Dim fontHeader As New Font("Arial", 12, FontStyle.Bold)
        Dim fontBody As New Font("Arial", 10)
        Dim brush As New SolidBrush(Color.Black)

        ' Margins and spacing
        Dim leftMargin As Integer = e.MarginBounds.Left
        Dim topMargin As Integer = e.MarginBounds.Top
        Dim yPos As Integer = topMargin
        Dim xPos As Integer = leftMargin

        ' Column widths
        Dim colWidths As Integer() = {150, 200, 100, 150, 120}

        ' Print title
        e.Graphics.DrawString("ENROLLMENT REPORT", fontHeader, brush, xPos, yPos)
        yPos += 30

        ' Print date
        e.Graphics.DrawString("Printed on: " & DateTime.Now.ToString("MMM dd, yyyy hh:mm tt"), fontBody, brush, xPos, yPos)
        yPos += 30

        ' Print filter info if any
        If Not String.IsNullOrWhiteSpace(searchText) OrElse selectedSchoolYear <> "All School Years" OrElse selectedStatus <> "All Status" Then
            Dim filterText As String = "Filtered by: "
            If Not String.IsNullOrWhiteSpace(searchText) Then
                filterText += "Search='" & searchText & "' "
            End If
            If selectedSchoolYear <> "All School Years" Then
                filterText += "School Year='" & selectedSchoolYear & "' "
            End If
            If selectedStatus <> "All Status" Then
                filterText += "Status='" & selectedStatus & "'"
            End If
            e.Graphics.DrawString(filterText, fontBody, brush, xPos, yPos)
            yPos += 20
        End If

        ' Print column headers
        Dim headers As String() = {"Student Name", "Subject Name", "Grade Level", "Remarks", "Payment Status"}
        xPos = leftMargin

        For i As Integer = 0 To headers.Length - 1
            e.Graphics.DrawString(headers(i), fontBody, brush, xPos, yPos)
            xPos += colWidths(i)
        Next

        yPos += 25

        ' Print a line under headers
        e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, leftMargin + colWidths.Sum(), yPos)
        yPos += 10

        ' Print each row of data
        For Each row As DataRow In dt.Rows
            xPos = leftMargin

            ' Check if we need a new page
            If yPos > e.MarginBounds.Bottom - 50 Then
                e.HasMorePages = True
                Return
            End If

            ' Print each column
            For i As Integer = 0 To headers.Length - 1
                Dim cellValue As String = If(row.IsNull(i), "", row(i).ToString())
                e.Graphics.DrawString(cellValue, fontBody, brush, xPos, yPos)
                xPos += colWidths(i)
            Next

            yPos += 20
        Next

        ' Print record count at the bottom
        yPos += 20
        e.Graphics.DrawString($"Total Records: {dt.Rows.Count}", fontBody, brush, leftMargin, yPos)

        ' No more pages
        e.HasMorePages = False
    End Sub
End Class
