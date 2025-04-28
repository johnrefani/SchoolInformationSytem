Imports System.Drawing.Printing
Imports System.IO
Imports System.Text
Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Misc

Public Class adminframe
    Private Sub admin_frame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HideAllPanels()
        dashboardpanel.Visible = True
        HighlightActiveButton(dashboardbutton)
    End Sub

    ' Hide all panels
    Private Sub HideAllPanels()
        dashboardpanel.Visible = False
        userspanel.Visible = False
        enrollmentspanel.Visible = False
        subjectspanel.Visible = False
        configurationpanel.Visible = False
    End Sub

    ' Highlight the active button
    Private Sub HighlightActiveButton(activeBtn As Button)
        Dim buttons As Button() = {
            dashboardbutton,
            usersbutton,
            enrollmentsbutton,
            subjectsbutton,
            configurationbutton
        }

        For Each btn As Button In buttons
            btn.BackColor = Color.Transparent
        Next

        activeBtn.BackColor = ColorTranslator.FromHtml("#ADADAD") ' light gray highlight
    End Sub

    Private Sub dashboardbutton_Click(sender As Object, e As EventArgs) Handles dashboardbutton.Click
        HideAllPanels()
        dashboardpanel.Visible = True
        HighlightActiveButton(dashboardbutton)
    End Sub

    Private Sub usersbutton_Click(sender As Object, e As EventArgs) Handles usersbutton.Click
        HideAllPanels()
        userspanel.Visible = True
        HighlightActiveButton(usersbutton)
    End Sub

    Private Sub enrollmentsbutton_Click(sender As Object, e As EventArgs) Handles enrollmentsbutton.Click
        HideAllPanels()
        enrollmentspanel.Visible = True
        HighlightActiveButton(enrollmentsbutton)
    End Sub

    Private Sub subjectsbutton_Click(sender As Object, e As EventArgs) Handles subjectsbutton.Click
        HideAllPanels()
        subjectspanel.Visible = True
        HighlightActiveButton(subjectsbutton)
    End Sub

    Private Sub configurationbutton_Click(sender As Object, e As EventArgs) Handles configurationbutton.Click
        HideAllPanels()
        configurationpanel.Visible = True
        HighlightActiveButton(configurationbutton)
    End Sub

    Private Sub adduserbutton_Click(sender As Object, e As EventArgs) Handles adduserbutton.Click
        adduser.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        addenrolle.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles addsub.Click
        editsubject.Show()
    End Sub

    Private Sub configurebutton_Click(sender As Object, e As EventArgs) Handles configurebutton.Click
        ' Update the variables from the textboxes
        ServerAddress = serveraddress_box.Text
        Port = port_box.Text
        DatabaseName = database_box.Text
        DBUsername = username_box.Text
        DBPassword = password_box.Text

        MessageBox.Show("Database configuration saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles TotalIns.Paint
        Try
            Dim conn As MySqlConnection = strconnection()
            conn.Open()

            Dim query As String = "SELECT COUNT(*) FROM Instructor"
            Dim cmd As New MySqlCommand(query, conn)
            Dim total As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            InstructorsCount.Text = total.ToString()

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error retrieving student count: " & ex.Message)
        End Try
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles SubjectCount.TextChanged

    End Sub

    Private Sub UserPieChart_Paint(sender As Object, e As PaintEventArgs) Handles UserPieChart.Paint
        Try
            Dim conn As MySqlConnection = strconnection()
            conn.Open()

            Dim query As String = "SELECT role, COUNT(*) AS count FROM User GROUP BY role"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            Dim studentCount As Integer = 0
            Dim instructorCount As Integer = 0
            Dim adminCount As Integer = 0

            While reader.Read()
                Dim role As String = reader("role").ToString().ToLower()
                Dim count As Integer = Convert.ToInt32(reader("count"))

                Select Case role
                    Case "student", "students"
                        studentCount = count
                    Case "instructor", "instructors"
                        instructorCount = count
                    Case "admin", "admins"
                        adminCount = count
                End Select
            End While

            reader.Close()
            conn.Close()

            PieChart.Series.Clear()
            If PieChart.ChartAreas.Count = 0 Then
                PieChart.ChartAreas.Add("ChartArea1")
            End If

            Dim series1 As New Series("UserTypes")
            series1.ChartType = SeriesChartType.Pie

            series1.Points.AddXY("Students", studentCount)
            series1.Points.AddXY("Instructors", instructorCount)
            series1.Points.AddXY("Admins", adminCount)

            series1.IsValueShownAsLabel = False

            If PieChart.Legends.Count = 0 Then
                PieChart.Legends.Add("Legend1")
            End If

            PieChart.Legends("Legend1").BackColor = Color.FromArgb(245, 245, 245)

            series1.Points(0).LegendText = "Students, " & studentCount
            series1.Points(1).LegendText = "Instructors, " & instructorCount
            series1.Points(2).LegendText = "Admins, " & adminCount

            series1.Points(0).Color = Color.FromArgb(255, 46, 46, 46)
            series1.Points(1).Color = Color.FromArgb(255, 0, 128, 128)
            series1.Points(2).Color = Color.FromArgb(255, 255, 165, 0)

            PieChart.Series.Add(series1)

            PieChart.Titles.Clear()
            PieChart.Titles.Add("Total Number of Users")
            PieChart.Titles(0).Font = New Font("Tahoma", 18, FontStyle.Bold)
            PieChart.Titles(0).ForeColor = Color.FromArgb(42, 62, 80)

        Catch ex As Exception
            MessageBox.Show("Error generating user pie chart: " & ex.Message)
        End Try
    End Sub


    Private Sub Panel4_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel4.Paint
        Try
            Dim conn As MySqlConnection = strconnection()
            conn.Open()

            Dim query As String = "SELECT school_year, COUNT(*) AS total FROM Enrollment GROUP BY school_year ORDER BY school_year ASC"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            EnrollmentBarGraph.Series.Clear()
            EnrollmentBarGraph.Titles.Clear()

            If EnrollmentBarGraph.ChartAreas.Count = 0 Then
                EnrollmentBarGraph.ChartAreas.Add("ChartArea1")
            End If

            Dim series1 As New Series("Enrollments")
            series1.ChartType = SeriesChartType.Column
            series1.Color = Color.FromArgb(52, 152, 219)

            While reader.Read()
                Dim yearStr As String = reader("school_year").ToString()
                Dim yearInt As Integer

                If yearStr.Contains("-") Then
                    Dim parts() As String = yearStr.Split("-"c)
                    If Integer.TryParse(parts(0), yearInt) Then
                        series1.Points.AddXY(yearInt, Convert.ToInt32(reader("total")))
                    End If
                ElseIf Integer.TryParse(yearStr, yearInt) Then
                    series1.Points.AddXY(yearInt, Convert.ToInt32(reader("total")))
                End If
            End While

            reader.Close()
            conn.Close()

            EnrollmentBarGraph.Series.Add(series1)

            If EnrollmentBarGraph.Legends.Count = 0 Then
                EnrollmentBarGraph.Legends.Add("Legend1")
            End If

            With EnrollmentBarGraph.Legends("Legend1")
                .Docking = Docking.Top
                .Title = "Enrollments"
                .Font = New Font("Tahoma", 10, FontStyle.Regular)
                .BackColor = Color.FromArgb(245, 245, 245)
            End With

            EnrollmentBarGraph.Titles.Add("Total Enrollments per Year")
            EnrollmentBarGraph.Titles(0).Font = New Font("Tahoma", 18, FontStyle.Bold)
            EnrollmentBarGraph.Titles(0).ForeColor = Color.FromArgb(44, 62, 80)

            With EnrollmentBarGraph.ChartAreas(0)
                .AxisX.Title = "Year"
                .AxisX.TitleFont = New Font("Tahoma", 12, FontStyle.Regular)
                .AxisY.Title = "Enrollments"
                .AxisY.TitleFont = New Font("Tahoma", 12, FontStyle.Regular)
            End With

        Catch ex As Exception
            MessageBox.Show("Error loading enrollment chart: " & ex.Message)
        End Try
    End Sub



    Private Sub TotalStuds_Paint(sender As Object, e As PaintEventArgs) Handles TotalStuds.Paint
        Try
            Dim conn As MySqlConnection = strconnection()
            conn.Open()

            Dim query As String = "SELECT COUNT(*) FROM Student"
            Dim cmd As New MySqlCommand(query, conn)
            Dim total As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            StudentsCount.Text = total.ToString()

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error retrieving student count: " & ex.Message)
        End Try
    End Sub

    Private Sub TotalSub_Paint(sender As Object, e As PaintEventArgs) Handles TotalSub.Paint
        Try
            Dim conn As MySqlConnection = strconnection()
            conn.Open()

            Dim query As String = "SELECT COUNT(*) FROM Subject"
            Dim cmd As New MySqlCommand(query, conn)
            Dim total As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            SubjectCount.Text = total.ToString()

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error retrieving student count: " & ex.Message)
        End Try
    End Sub

    Private Sub TotalEnroll_Paint(sender As Object, e As PaintEventArgs) Handles TotalEnroll.Paint
        Try
            Dim conn As MySqlConnection = strconnection()
            conn.Open()

            Dim query As String = "SELECT COUNT(*) FROM Enrollment"
            Dim cmd As New MySqlCommand(query, conn)
            Dim total As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            EnrollmentCount.Text = total.ToString()

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error retrieving student count: " & ex.Message)
        End Try
    End Sub

    ' For setting the variables
    Private currentPage As Integer = 1
    Private pageSize As Integer = 15
    Private totalRecords As Integer = 0
    Private totalPages As Integer = 0
    Private isSearching As Boolean = False


    'For loading the form
    Private Sub UsersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupRoleSortComboBox()
        AddHandler SearchUser.TextChanged, AddressOf SearchUser_TextChanged
        LoadUserData()
    End Sub

    Private Sub LoadUserData()
        Dim offset As Integer = (currentPage - 1) * pageSize
        Dim selectedRole As String = RoleSort.SelectedItem?.ToString()

        Using conn As MySqlConnection = strconnection()
            Try
                conn.Open()

                ' Count query
                Dim countQuery As String = "SELECT COUNT(*) FROM User"
                If selectedRole <> "Role" Then
                    countQuery &= " WHERE role = @role"
                End If

                Using countCmd As New MySqlCommand(countQuery, conn)
                    If selectedRole <> "Role" Then
                        countCmd.Parameters.AddWithValue("@role", selectedRole)
                    End If
                    totalRecords = Convert.ToInt32(countCmd.ExecuteScalar())
                    totalPages = Math.Ceiling(totalRecords / pageSize)
                End Using

                ' Main query
                Dim query As String = "SELECT * FROM User"
                If selectedRole <> "Role" Then
                    query &= " WHERE role = @role"
                End If
                query &= " LIMIT @limit OFFSET @offset"

                Using cmd As New MySqlCommand(query, conn)
                    If selectedRole <> "Role" Then
                        cmd.Parameters.AddWithValue("@role", selectedRole)
                    End If
                    cmd.Parameters.AddWithValue("@limit", pageSize)
                    cmd.Parameters.AddWithValue("@offset", offset)

                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)
                        UsersDataGrid.DataSource = dt
                    End Using
                End Using

                UpdatePaginationUI()
                SetupDataGridView()

            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub FilterData()
        isSearching = True
        Dim offset As Integer = (currentPage - 1) * pageSize
        Dim selectedRole As String = RoleSort.SelectedItem?.ToString()

        Using conn As MySqlConnection = strconnection()
            Try
                conn.Open()

                ' Counting filtered
                Dim countQuery As String = "SELECT COUNT(*) FROM User WHERE (username LIKE @search OR full_name LIKE @search)"
                If selectedRole <> "Role" Then
                    countQuery &= " AND role = @role"
                End If

                Using countCmd As New MySqlCommand(countQuery, conn)
                    countCmd.Parameters.AddWithValue("@search", "%" & SearchUser.Text & "%")
                    If selectedRole <> "Role" Then
                        countCmd.Parameters.AddWithValue("@role", selectedRole)
                    End If
                    totalRecords = Convert.ToInt32(countCmd.ExecuteScalar())
                    totalPages = Math.Ceiling(totalRecords / pageSize)
                End Using

                ' Query for searching
                Dim query As String = "SELECT * FROM User WHERE (username LIKE @search OR full_name LIKE @search)"
                If selectedRole <> "Role" Then
                    query &= " AND role = @role"
                End If
                query &= " LIMIT @limit OFFSET @offset"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@search", "%" & SearchUser.Text & "%")
                    If selectedRole <> "Role" Then
                        cmd.Parameters.AddWithValue("@role", selectedRole)
                    End If
                    cmd.Parameters.AddWithValue("@limit", pageSize)
                    cmd.Parameters.AddWithValue("@offset", offset)

                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)
                        UsersDataGrid.DataSource = dt
                    End Using
                End Using

                UpdatePaginationUI()
                SetupDataGridView()

            Catch ex As Exception
                MessageBox.Show("Error filtering data: " & ex.Message)
            End Try
        End Using
    End Sub


    ' Set column headers and the design of the table
    Private Sub SetupDataGridView()
        Dim headers As String() = {"User ID", "Username", "Password", "Full Name", "Role", "Email", "Contact Number", "Address", "Is Active", "Remarks", "Assigned Office", "Position", "ID Number", "Gender", "Access Level"}

        With UsersDataGrid
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
    Private Sub UpdatePaginationUI()
        PageLabel.Text = $"Page {currentPage} of {If(totalPages = 0, 1, totalPages)}"
        PrevPageButton.Enabled = currentPage > 1
        NextPageButton.Enabled = currentPage < totalPages
    End Sub

    Private Sub SetupRoleSortComboBox()
        RoleSort.Items.Clear()
        RoleSort.Items.Add("Role")
        RoleSort.Items.Add("Admin")
        RoleSort.Items.Add("Instructor")
        RoleSort.Items.Add("Student")
        RoleSort.SelectedIndex = 0
    End Sub


    ' Updating the search results
    Private Sub SearchUser_TextChanged(sender As Object, e As EventArgs)
        currentPage = 1
        If String.IsNullOrWhiteSpace(SearchUser.Text) Then
            isSearching = False
            LoadUserData()
        Else
            FilterData()
        End If
    End Sub

    'For filtering by role
    Private Sub RoleSort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RoleSort.SelectedIndexChanged
        currentPage = 1
        If String.IsNullOrWhiteSpace(SearchUser.Text) Then
            LoadUserData()
        Else
            FilterData()
        End If
    End Sub


    ' Next Page Button
    Private Sub NextPageButton_Click(sender As Object, e As EventArgs) Handles NextPageButton.Click
        If currentPage < totalPages Then
            currentPage += 1
            If isSearching Then
                FilterData()
            Else
                LoadUserData()
            End If
        End If
    End Sub

    ' Prev Page Button
    Private Sub PrevPageButton_Click(sender As Object, e As EventArgs) Handles PrevPageButton.Click
        If currentPage > 1 Then
            currentPage -= 1
            If isSearching Then
                FilterData()
            Else
                LoadUserData()
            End If
        End If
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        ' Create a PrintDocument
        Dim printDoc As New PrintDocument()
        AddHandler printDoc.PrintPage, AddressOf PrintPageHandler

        ' Show print dialog
        Dim printDialog As New PrintDialog()
        printDialog.Document = printDoc

        If printDialog.ShowDialog() = DialogResult.OK Then
            printDoc.Print()
        End If
    End Sub

    Private Sub PrintPageHandler(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Dim selectedRole As String = RoleSort.SelectedItem?.ToString()
        Dim searchText As String = SearchUser.Text

        ' Get the data to print (same filtering logic as in your form)
        Dim dt As New DataTable()

        Using conn As MySqlConnection = strconnection()
            Try
                conn.Open()

                Dim query As String = "SELECT username, full_name, email, contact_number, id_number FROM User"
                Dim whereClauses As New List(Of String)

                If Not String.IsNullOrWhiteSpace(searchText) Then
                    whereClauses.Add("(username LIKE @search OR full_name LIKE @search)")
                End If

                If selectedRole <> "Role" Then
                    whereClauses.Add("role = @role")
                End If

                If whereClauses.Count > 0 Then
                    query &= " WHERE " & String.Join(" AND ", whereClauses)
                End If

                ' For printing, we want all matching records (no pagination)
                Using cmd As New MySqlCommand(query, conn)
                    If Not String.IsNullOrWhiteSpace(searchText) Then
                        cmd.Parameters.AddWithValue("@search", "%" & searchText & "%")
                    End If

                    If selectedRole <> "Role" Then
                        cmd.Parameters.AddWithValue("@role", selectedRole)
                    End If

                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error preparing data for printing: " & ex.Message)
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
        Dim colWidths As Integer() = {130, 180, 200, 120, 100}

        ' Print title
        e.Graphics.DrawString("USER LIST REPORT", fontHeader, brush, xPos, yPos)
        yPos += 30

        ' Print date
        e.Graphics.DrawString("Printed on: " & DateTime.Now.ToString("MMM dd, yyyy hh:mm tt"), fontBody, brush, xPos, yPos)
        yPos += 30

        ' Print filter info if any
        If Not String.IsNullOrWhiteSpace(searchText) OrElse selectedRole <> "Role" Then
            Dim filterText As String = "Filtered by: "
            If Not String.IsNullOrWhiteSpace(searchText) Then
                filterText += "Search='" & searchText & "' "
            End If
            If selectedRole <> "Role" Then
                filterText += "Role='" & selectedRole & "'"
            End If
            e.Graphics.DrawString(filterText, fontBody, brush, xPos, yPos)
            yPos += 20
        End If

        ' Print column headers
        Dim headers As String() = {"Username", "Full Name", "Email", "Contact Number", "ID Number"}
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

    Private Sub UsersDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles UsersDataGrid.CellClick
        ' Ignore header clicks and invalid rows
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Return

        ' Get the selected row
        Dim selectedRow As DataGridViewRow = UsersDataGrid.Rows(e.RowIndex)

        ' Get the user ID from the first column (assuming it's the ID)
        Dim userId As Integer = Convert.ToInt32(selectedRow.Cells(0).Value)

        ' Open the edit form and pass the ID
        Dim editForm As New edituser()
        editForm.userId = userId ' Set the public property
        editForm.ShowDialog()

        ' Refresh the data after editing
        LoadUserData()
    End Sub





    'Enrollemnt Tab
    ' For setting the variables
    Private currentEnrollmentPage As Integer = 1
    Private enrollmentPageSize As Integer = 15
    Private totalEnrollmentRecords As Integer = 0
    Private totalEnrollmentPages As Integer = 0
    Private isSearchingEnrollment As Boolean = False

    ' For loading the form
    Private Sub EnrollmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupFilterComboBoxes()
        AddHandler searchenrollee.TextChanged, AddressOf SearchEnrollee_TextChanged
        LoadEnrollmentData()

        ' Fill the textboxes with the current connection values
        serveraddress_box.Text = ServerAddress
        port_box.Text = Port
        database_box.Text = DatabaseName
        username_box.Text = DBUsername
        password_box.Text = DBPassword

    End Sub

    Private Sub LoadEnrollmentData()
        Dim offset As Integer = (currentEnrollmentPage - 1) * enrollmentPageSize
        Dim selectedSchoolYear As String = filterschoolyear.SelectedItem?.ToString()
        Dim selectedStatus As String = filterstatus.SelectedItem?.ToString()

        Using conn As MySqlConnection = strconnection()
            Try
                conn.Open()

                ' Count query
                Dim countQuery As String = "SELECT COUNT(*) FROM enrollment e"
                Dim whereClauses As New List(Of String)

                If selectedSchoolYear <> "All School Years" AndAlso Not String.IsNullOrEmpty(selectedSchoolYear) Then
                    whereClauses.Add("e.school_year = @school_year")
                End If

                If selectedStatus <> "All Status" AndAlso Not String.IsNullOrEmpty(selectedStatus) Then
                    whereClauses.Add("e.status = @status")
                End If

                If whereClauses.Count > 0 Then
                    countQuery &= " WHERE " & String.Join(" AND ", whereClauses)
                End If

                Using countCmd As New MySqlCommand(countQuery, conn)
                    If selectedSchoolYear <> "All School Years" AndAlso Not String.IsNullOrEmpty(selectedSchoolYear) Then
                        countCmd.Parameters.AddWithValue("@school_year", selectedSchoolYear)
                    End If

                    If selectedStatus <> "All Status" AndAlso Not String.IsNullOrEmpty(selectedStatus) Then
                        countCmd.Parameters.AddWithValue("@status", selectedStatus)
                    End If

                    totalEnrollmentRecords = Convert.ToInt32(countCmd.ExecuteScalar())
                    totalEnrollmentPages = If(enrollmentPageSize > 0, Math.Ceiling(totalEnrollmentRecords / enrollmentPageSize), 1)
                End Using

                ' Main query with joins to get student and subject names
                Dim query As String = "SELECT e.enrollment_id, CONCAT(s.last_name, ' ', s.first_name, ' ', s.middle_initial) AS student_name, sub.subject_name, " &
                                     "e.school_year, e.grade_level, e.section, e.status, e.remarks, " &
                                     "e.payment_status, e.amount_paid, e.balance, e.mode_of_payment, " &
                                     "e.payment_date, e.cashier_name, e.discount_applied " &
                                     "FROM enrollment e " &
                                     "JOIN student s ON e.student_id = s.student_id " &
                                     "JOIN subject sub ON e.subject_id = sub.subject_id"

                If whereClauses.Count > 0 Then
                    query &= " WHERE " & String.Join(" AND ", whereClauses)
                End If

                query &= " LIMIT @limit OFFSET @offset"

                Using cmd As New MySqlCommand(query, conn)
                    If selectedSchoolYear <> "All School Years" AndAlso Not String.IsNullOrEmpty(selectedSchoolYear) Then
                        cmd.Parameters.AddWithValue("@school_year", selectedSchoolYear)
                    End If

                    If selectedStatus <> "All Status" AndAlso Not String.IsNullOrEmpty(selectedStatus) Then
                        cmd.Parameters.AddWithValue("@status", selectedStatus)
                    End If

                    cmd.Parameters.AddWithValue("@limit", enrollmentPageSize)
                    cmd.Parameters.AddWithValue("@offset", offset)

                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)
                        enrollmentdatagrid.DataSource = dt
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
        isSearchingEnrollment = True
        Dim offset As Integer = (currentEnrollmentPage - 1) * enrollmentPageSize
        Dim selectedSchoolYear As String = filterschoolyear.SelectedItem?.ToString()
        Dim selectedStatus As String = filterstatus.SelectedItem?.ToString()

        Using conn As MySqlConnection = strconnection()
            Try
                conn.Open()

                ' Counting filtered records
                Dim countQuery As String = "SELECT COUNT(*) FROM enrollment e " &
                                          "JOIN student s ON e.student_id = s.student_id " &
                                          "JOIN subject sub ON e.subject_id = sub.subject_id " &
                                          "WHERE (s.last_name LIKE @search OR sub.subject_name LIKE @search)"

                If selectedSchoolYear <> "All School Years" AndAlso Not String.IsNullOrEmpty(selectedSchoolYear) Then
                    countQuery &= " AND e.school_year = @school_year"
                End If

                If selectedStatus <> "All Status" AndAlso Not String.IsNullOrEmpty(selectedStatus) Then
                    countQuery &= " AND e.status = @status"
                End If

                Using countCmd As New MySqlCommand(countQuery, conn)
                    countCmd.Parameters.AddWithValue("@search", "%" & searchenrollee.Text & "%")

                    If selectedSchoolYear <> "All School Years" AndAlso Not String.IsNullOrEmpty(selectedSchoolYear) Then
                        countCmd.Parameters.AddWithValue("@school_year", selectedSchoolYear)
                    End If

                    If selectedStatus <> "All Status" AndAlso Not String.IsNullOrEmpty(selectedStatus) Then
                        countCmd.Parameters.AddWithValue("@status", selectedStatus)
                    End If

                    totalEnrollmentRecords = Convert.ToInt32(countCmd.ExecuteScalar())
                    totalEnrollmentPages = If(enrollmentPageSize > 0, Math.Ceiling(totalEnrollmentRecords / enrollmentPageSize), 1)
                End Using

                ' Query for searching
                Dim query As String = "SELECT e.enrollment_id, CONCAT(s.last_name, ' ', s.first_name, ' ', s.middle_initial) AS student_name, sub.subject_name, " &
                                     "e.school_year, e.grade_level, e.section, e.status, e.remarks, " &
                                     "e.payment_status, e.amount_paid, e.balance, e.mode_of_payment, " &
                                     "e.payment_date, e.cashier_name, e.discount_applied " &
                                     "FROM enrollment e " &
                                     "JOIN student s ON e.student_id = s.student_id " &
                                     "JOIN subject sub ON e.subject_id = sub.subject_id " &
                                     "WHERE (s.last_name LIKE @search OR sub.subject_name LIKE @search)"

                If selectedSchoolYear <> "All School Years" AndAlso Not String.IsNullOrEmpty(selectedSchoolYear) Then
                    query &= " AND e.school_year = @school_year"
                End If

                If selectedStatus <> "All Status" AndAlso Not String.IsNullOrEmpty(selectedStatus) Then
                    query &= " AND e.status = @status"
                End If

                query &= " LIMIT @limit OFFSET @offset"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@search", "%" & searchenrollee.Text & "%")

                    If selectedSchoolYear <> "All School Years" AndAlso Not String.IsNullOrEmpty(selectedSchoolYear) Then
                        cmd.Parameters.AddWithValue("@school_year", selectedSchoolYear)
                    End If

                    If selectedStatus <> "All Status" AndAlso Not String.IsNullOrEmpty(selectedStatus) Then
                        cmd.Parameters.AddWithValue("@status", selectedStatus)
                    End If

                    cmd.Parameters.AddWithValue("@limit", enrollmentPageSize)
                    cmd.Parameters.AddWithValue("@offset", offset)

                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)
                        enrollmentdatagrid.DataSource = dt
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

        With enrollmentdatagrid
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
        Epagelabel.Text = $"Page {currentEnrollmentPage} of {If(totalEnrollmentPages = 0, 1, totalEnrollmentPages)}"
        PrevButton.Enabled = currentEnrollmentPage > 1
        NextButton.Enabled = currentEnrollmentPage < totalEnrollmentPages
    End Sub

    Private Sub SetupFilterComboBoxes()
        ' Setup school year filter
        filterschoolyear.Items.Clear()
        filterschoolyear.Items.Add("All School Years")

        Using conn As MySqlConnection = strconnection()
            Try
                conn.Open()
                Dim query As String = "SELECT DISTINCT school_year FROM enrollment ORDER BY school_year DESC"
                Using cmd As New MySqlCommand(query, conn)
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

        Using conn As MySqlConnection = strconnection()
            Try
                conn.Open()
                Dim query As String = "SELECT DISTINCT status FROM enrollment"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            filterstatus.Items.Add(reader("status").ToString())
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading status options: " & ex.Message)
            End Try
        End Using
        filterstatus.SelectedIndex = 0
    End Sub

    ' Updating the search results
    Private Sub SearchEnrollee_TextChanged(sender As Object, e As EventArgs)
        currentEnrollmentPage = 1
        If String.IsNullOrWhiteSpace(searchenrollee.Text) Then
            isSearchingEnrollment = False
            LoadEnrollmentData()
        Else
            FilterEnrollmentData()
        End If
    End Sub

    ' For filtering by school year and status
    Private Sub Filter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filterschoolyear.SelectedIndexChanged, filterstatus.SelectedIndexChanged
        currentEnrollmentPage = 1
        If String.IsNullOrWhiteSpace(searchenrollee.Text) Then
            LoadEnrollmentData()
        Else
            FilterEnrollmentData()
        End If
    End Sub

    ' Next Page Button
    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If currentEnrollmentPage < totalEnrollmentPages Then
            currentEnrollmentPage += 1
            If isSearchingEnrollment Then
                FilterEnrollmentData()
            Else
                LoadEnrollmentData()
            End If
        End If
    End Sub

    ' Prev Page Button
    Private Sub PrevButton_Click(sender As Object, e As EventArgs) Handles PrevButton.Click
        If currentEnrollmentPage > 1 Then
            currentEnrollmentPage -= 1
            If isSearchingEnrollment Then
                FilterEnrollmentData()
            Else
                LoadEnrollmentData()
            End If
        End If
    End Sub

    Private Sub printenrollement_Click(sender As Object, e As EventArgs) Handles printenrollment.Click
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
        Dim searchText As String = searchenrollee.Text

        ' Get the data to print
        Dim dt As New DataTable()

        Using conn As MySqlConnection = strconnection()
            Try
                conn.Open()

                Dim query As String = "SELECT CONCAT(s.last_name, ' ', s.first_name, ' ', s.middle_initial) AS student_name, sub.subject_name, " &
                                     "e.grade_level, e.remarks, e.payment_status " &
                                     "FROM enrollment e " &
                                     "JOIN student s ON e.student_id = s.student_id " &
                                     "JOIN subject sub ON e.subject_id = sub.subject_id"

                Dim whereClauses As New List(Of String)

                If Not String.IsNullOrWhiteSpace(searchText) Then
                    whereClauses.Add("(s.last_name LIKE @search OR sub.subject_name LIKE @search)")
                End If

                If selectedSchoolYear <> "All School Years" AndAlso Not String.IsNullOrEmpty(selectedSchoolYear) Then
                    whereClauses.Add("e.school_year = @school_year")
                End If

                If selectedStatus <> "All Status" AndAlso Not String.IsNullOrEmpty(selectedStatus) Then
                    whereClauses.Add("e.status = @status")
                End If

                If whereClauses.Count > 0 Then
                    query &= " WHERE " & String.Join(" AND ", whereClauses)
                End If

                query &= " ORDER BY s.last_name"

                Using cmd As New MySqlCommand(query, conn)
                    If Not String.IsNullOrWhiteSpace(searchText) Then
                        cmd.Parameters.AddWithValue("@search", "%" & searchText & "%")
                    End If

                    If selectedSchoolYear <> "All School Years" AndAlso Not String.IsNullOrEmpty(selectedSchoolYear) Then
                        cmd.Parameters.AddWithValue("@school_year", selectedSchoolYear)
                    End If

                    If selectedStatus <> "All Status" AndAlso Not String.IsNullOrEmpty(selectedStatus) Then
                        cmd.Parameters.AddWithValue("@status", selectedStatus)
                    End If

                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error preparing data for printing: " & ex.Message)
                Return
            End Try
        End Using

        ' Set up printing parameters
        Dim fontHeader As New Font("Arial", 14, FontStyle.Bold)
        Dim fontSubHeader As New Font("Arial", 10, FontStyle.Italic)
        Dim fontBody As New Font("Arial", 10)
        Dim fontFooter As New Font("Arial", 9)
        Dim brush As New SolidBrush(Color.Black)

        ' Margins and spacing
        Dim leftMargin As Integer = e.MarginBounds.Left
        Dim topMargin As Integer = e.MarginBounds.Top
        Dim yPos As Integer = topMargin
        Dim xPos As Integer = leftMargin

        ' Column widths
        Dim colWidths As Integer() = {150, 180, 80, 120, 100}

        ' Print title
        e.Graphics.DrawString("ENROLLMENT REPORT", fontHeader, brush, xPos, yPos)
        yPos += 30

        ' Print date
        e.Graphics.DrawString("Printed on: " & DateTime.Now.ToString("MMM dd, yyyy hh:mm tt"), fontSubHeader, brush, xPos, yPos)
        yPos += 25

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
        e.Graphics.DrawString($"Total Records: {dt.Rows.Count}", fontFooter, brush, leftMargin, yPos)

        ' No more pages
        e.HasMorePages = False
    End Sub

    Private Sub enrollmentdatagrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles enrollmentdatagrid.CellClick
        ' Ignore header clicks and invalid rows
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Return

        ' Get the selected row
        Dim selectedRow As DataGridViewRow = enrollmentdatagrid.Rows(e.RowIndex)

        ' Get the enrollment ID from the first column
        Dim enrollmentId As Integer = Convert.ToInt32(selectedRow.Cells(0).Value)

        ' Open the edit form and pass the ID
        Dim editForm As New editenrolle()
        editForm.EnrollmentId = enrollmentId ' Set the public property
        editForm.ShowDialog()

        ' Refresh the data after editing
        LoadEnrollmentData()
    End Sub
    Private Sub studentnametextbox_TextChanged(sender As Object, e As EventArgs) Handles serveraddress_box.TextChanged

    End Sub

    Private Sub testdb_button_Click(sender As Object, e As EventArgs) Handles testdb_button.Click
        ' Update temporary values
        Dim testConnectionString As String = "server=" & serveraddress_box.Text & ";port=" & port_box.Text & ";username=" & username_box.Text & ";password=" & password_box.Text & ";database=" & database_box.Text

        Dim conn As New MySqlConnection(testConnectionString)
        Try
            conn.Open()
            MessageBox.Show("Connection successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Connection failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

    End Sub



    'Subject Tab
    ' For setting the variables
    Private currentSubPage As Integer = 1
    Private subPageSize As Integer = 15
    Private subTotalRecords As Integer = 0
    Private subTotalPages As Integer = 0
    Private isSubSearching As Boolean = False

    ' For loading the form
    Private Sub SubjectsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupDepartmentComboBox()
        SetupGradeLevelComboBox()
        AddHandler subsearch.TextChanged, AddressOf SubSearch_TextChanged
        LoadSubjectData()
    End Sub

    Private Sub LoadSubjectData()
        Dim offset As Integer = (currentSubPage - 1) * subPageSize
        Dim selectedDepartment As String = subdepartment.SelectedItem?.ToString()
        Dim selectedGradeLevel As String = subgradelevel.SelectedItem?.ToString()

        Using conn As MySqlConnection = strconnection()
            Try
                conn.Open()

                ' Count query
                Dim countQuery As String = "SELECT COUNT(*) FROM subject"
                Dim whereClauses As New List(Of String)

                If selectedDepartment <> "Department" Then
                    whereClauses.Add("department = @department")
                End If

                If selectedGradeLevel <> "Grade Level" Then
                    whereClauses.Add("grade_level = @gradelevel")
                End If

                If whereClauses.Count > 0 Then
                    countQuery &= " WHERE " & String.Join(" AND ", whereClauses)
                End If

                Using countCmd As New MySqlCommand(countQuery, conn)
                    If selectedDepartment <> "Department" Then
                        countCmd.Parameters.AddWithValue("@department", selectedDepartment)
                    End If
                    If selectedGradeLevel <> "Grade Level" Then
                        countCmd.Parameters.AddWithValue("@gradelevel", selectedGradeLevel)
                    End If
                    subTotalRecords = Convert.ToInt32(countCmd.ExecuteScalar())
                    subTotalPages = Math.Ceiling(subTotalRecords / subPageSize)
                End Using

                ' Main query with instructor name join
                Dim query As String = "SELECT s.subject_id, s.subject_name, s.subject_code, s.subject_type, " &
                                 "s.department, s.grade_level, CONCAT(i.first_name, ' ', i.middle_initial, ' ', i.last_name) AS instructor_name, " &
                                 "s.description, s.units, s.section, s.semester, s.room_number, " &
                                 "s.schedule_time, s.day, s.max_students " &
                                 "FROM subject s LEFT JOIN instructor i ON s.teacher_id = i.instructor_id"

                whereClauses.Clear()
                If selectedDepartment <> "Department" Then
                    whereClauses.Add("s.department = @department")
                End If
                If selectedGradeLevel <> "Grade Level" Then
                    whereClauses.Add("s.grade_level = @gradelevel")
                End If

                If whereClauses.Count > 0 Then
                    query &= " WHERE " & String.Join(" AND ", whereClauses)
                End If

                query &= " LIMIT @limit OFFSET @offset"

                Using cmd As New MySqlCommand(query, conn)
                    If selectedDepartment <> "Department" Then
                        cmd.Parameters.AddWithValue("@department", selectedDepartment)
                    End If
                    If selectedGradeLevel <> "Grade Level" Then
                        cmd.Parameters.AddWithValue("@gradelevel", selectedGradeLevel)
                    End If
                    cmd.Parameters.AddWithValue("@limit", subPageSize)
                    cmd.Parameters.AddWithValue("@offset", offset)

                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)
                        subdatagrid.DataSource = dt
                    End Using
                End Using

                UpdateSubjectPaginationUI()
                SetupSubjectDataGridView()

            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub FilterSubjectData()
        isSubSearching = True
        Dim offset As Integer = (currentSubPage - 1) * subPageSize
        Dim selectedDepartment As String = subdepartment.SelectedItem?.ToString()
        Dim selectedGradeLevel As String = subgradelevel.SelectedItem?.ToString()

        Using conn As MySqlConnection = strconnection()
            Try
                conn.Open()

                ' Counting filtered
                Dim countQuery As String = "SELECT COUNT(*) FROM subject s WHERE (s.subject_name LIKE @search OR s.subject_code LIKE @search)"
                If selectedDepartment <> "Department" Then
                    countQuery &= " AND s.department = @department"
                End If
                If selectedGradeLevel <> "Grade Level" Then
                    countQuery &= " AND s.grade_level = @gradelevel"
                End If

                Using countCmd As New MySqlCommand(countQuery, conn)
                    countCmd.Parameters.AddWithValue("@search", "%" & subsearch.Text & "%")
                    If selectedDepartment <> "Department" Then
                        countCmd.Parameters.AddWithValue("@department", selectedDepartment)
                    End If
                    If selectedGradeLevel <> "Grade Level" Then
                        countCmd.Parameters.AddWithValue("@gradelevel", selectedGradeLevel)
                    End If
                    subTotalRecords = Convert.ToInt32(countCmd.ExecuteScalar())
                    subTotalPages = Math.Ceiling(subTotalRecords / subPageSize)
                End Using

                ' Query for searching
                Dim query As String = "SELECT s.subject_id, s.subject_name, s.subject_code, s.subject_type, " &
                                 "s.department, s.grade_level, CONCAT(i.first_name, ' ', i.middle_initial, ' ', i.last_name) AS instructor_name, " &
                                 "s.description, s.units, s.section, s.semester, s.room_number, " &
                                 "s.schedule_time, s.day, s.max_students " &
                                 "FROM subject s LEFT JOIN instructor i ON s.teacher_id = i.instructor_id " &
                                 "WHERE (s.subject_name LIKE @search OR s.subject_code LIKE @search)"

                If selectedDepartment <> "Department" Then
                    query &= " AND s.department = @department"
                End If
                If selectedGradeLevel <> "Grade Level" Then
                    query &= " AND s.grade_level = @gradelevel"
                End If

                query &= " LIMIT @limit OFFSET @offset"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@search", "%" & subsearch.Text & "%")
                    If selectedDepartment <> "Department" Then
                        cmd.Parameters.AddWithValue("@department", selectedDepartment)
                    End If
                    If selectedGradeLevel <> "Grade Level" Then
                        cmd.Parameters.AddWithValue("@gradelevel", selectedGradeLevel)
                    End If
                    cmd.Parameters.AddWithValue("@limit", subPageSize)
                    cmd.Parameters.AddWithValue("@offset", offset)

                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)
                        subdatagrid.DataSource = dt
                    End Using
                End Using

                UpdateSubjectPaginationUI()
                SetupSubjectDataGridView()

            Catch ex As Exception
                MessageBox.Show("Error filtering data: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Set column headers and the design of the table
    Private Sub SetupSubjectDataGridView()
        Dim headers As String() = {"Subject ID", "Subject Name", "Subject Code", "Subject Type", "Department",
                              "Grade Level", "Instructor Name", "Description", "Units", "Section",
                              "Semester", "Room Number", "Schedule Time", "Day", "Max Students"}

        With subdatagrid
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
    Private Sub UpdateSubjectPaginationUI()
        subpagelabel.Text = $"Page {currentSubPage} of {If(subTotalPages = 0, 1, subTotalPages)}"
        subprev.Enabled = currentSubPage > 1
        subnext.Enabled = currentSubPage < subTotalPages
    End Sub

    Private Sub SetupDepartmentComboBox()
        subdepartment.Items.Clear()
        subdepartment.Items.Add("Department")

        Using conn As MySqlConnection = strconnection()
            Try
                conn.Open()
                Dim query As String = "SELECT DISTINCT department FROM subject ORDER BY department"

                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            subdepartment.Items.Add(reader("department").ToString())
                        End While
                    End Using
                End Using
                subdepartment.SelectedIndex = 0
            Catch ex As Exception
                MessageBox.Show("Error loading departments: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub SetupGradeLevelComboBox()
        subgradelevel.Items.Clear()
        subgradelevel.Items.Add("Grade Level")

        Using conn As MySqlConnection = strconnection()
            Try
                conn.Open()
                Dim query As String = "SELECT DISTINCT grade_level FROM subject ORDER BY grade_level"

                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            subgradelevel.Items.Add(reader("grade_level").ToString())
                        End While
                    End Using
                End Using
                subgradelevel.SelectedIndex = 0
            Catch ex As Exception
                MessageBox.Show("Error loading grade levels: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Updating the search results
    Private Sub SubSearch_TextChanged(sender As Object, e As EventArgs)
        currentSubPage = 1
        If String.IsNullOrWhiteSpace(subsearch.Text) Then
            isSubSearching = False
            LoadSubjectData()
        Else
            FilterSubjectData()
        End If
    End Sub

    'For filtering by department
    Private Sub SubDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles subdepartment.SelectedIndexChanged
        currentSubPage = 1
        If String.IsNullOrWhiteSpace(subsearch.Text) Then
            LoadSubjectData()
        Else
            FilterSubjectData()
        End If
    End Sub

    'For filtering by grade level
    Private Sub SubGradeLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles subgradelevel.SelectedIndexChanged
        currentSubPage = 1
        If String.IsNullOrWhiteSpace(subsearch.Text) Then
            LoadSubjectData()
        Else
            FilterSubjectData()
        End If
    End Sub

    ' Next Page Button
    Private Sub SubNext_Click(sender As Object, e As EventArgs) Handles subnext.Click
        If currentSubPage < subTotalPages Then
            currentSubPage += 1
            If isSubSearching Then
                FilterSubjectData()
            Else
                LoadSubjectData()
            End If
        End If
    End Sub

    ' Prev Page Button
    Private Sub SubPrev_Click(sender As Object, e As EventArgs) Handles subprev.Click
        If currentSubPage > 1 Then
            currentSubPage -= 1
            If isSubSearching Then
                FilterSubjectData()
            Else
                LoadSubjectData()
            End If
        End If
    End Sub

    Private Sub SubPrint_Click(sender As Object, e As EventArgs) Handles subprint.Click
        ' Create a PrintDocument
        Dim printDoc As New PrintDocument()
        AddHandler printDoc.PrintPage, AddressOf SubPrintPageHandler

        ' Show print dialog
        Dim printDialog As New PrintDialog()
        printDialog.Document = printDoc

        If printDialog.ShowDialog() = DialogResult.OK Then
            printDoc.Print()
        End If
    End Sub

    Private Sub SubPrintPageHandler(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Dim selectedDepartment As String = subdepartment.SelectedItem?.ToString()
        Dim selectedGradeLevel As String = subgradelevel.SelectedItem?.ToString()
        Dim searchText As String = subsearch.Text

        ' Get the data to print
        Dim dt As New DataTable()

        Using conn As MySqlConnection = strconnection()
            Try
                conn.Open()

                Dim query As String = "SELECT s.subject_name, s.subject_code, s.subject_type, s.units, s.schedule_time " &
                                  "FROM subject s"
                Dim whereClauses As New List(Of String)

                If Not String.IsNullOrWhiteSpace(searchText) Then
                    whereClauses.Add("(s.subject_name LIKE @search OR s.subject_code LIKE @search)")
                End If

                If selectedDepartment <> "Department" Then
                    whereClauses.Add("s.department = @department")
                End If

                If selectedGradeLevel <> "Grade Level" Then
                    whereClauses.Add("s.grade_level = @gradelevel")
                End If

                If whereClauses.Count > 0 Then
                    query &= " WHERE " & String.Join(" AND ", whereClauses)
                End If

                query &= " ORDER BY s.subject_name"

                Using cmd As New MySqlCommand(query, conn)
                    If Not String.IsNullOrWhiteSpace(searchText) Then
                        cmd.Parameters.AddWithValue("@search", "%" & searchText & "%")
                    End If

                    If selectedDepartment <> "Department" Then
                        cmd.Parameters.AddWithValue("@department", selectedDepartment)
                    End If

                    If selectedGradeLevel <> "Grade Level" Then
                        cmd.Parameters.AddWithValue("@gradelevel", selectedGradeLevel)
                    End If

                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error preparing data for printing: " & ex.Message)
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
        Dim colWidths As Integer() = {200, 120, 120, 50, 120}

        ' Print title
        e.Graphics.DrawString("SUBJECT LIST REPORT", fontHeader, brush, xPos, yPos)
        yPos += 30

        ' Print date
        e.Graphics.DrawString("Printed on: " & DateTime.Now.ToString("MMM dd, yyyy hh:mm tt"), fontBody, brush, xPos, yPos)
        yPos += 30

        ' Print filter info if any
        If Not String.IsNullOrWhiteSpace(searchText) OrElse selectedDepartment <> "Department" OrElse selectedGradeLevel <> "Grade Level" Then
            Dim filterText As String = "Filtered by: "
            If Not String.IsNullOrWhiteSpace(searchText) Then
                filterText += "Search='" & searchText & "' "
            End If
            If selectedDepartment <> "Department" Then
                filterText += "Department='" & selectedDepartment & "' "
            End If
            If selectedGradeLevel <> "Grade Level" Then
                filterText += "Grade Level='" & selectedGradeLevel & "'"
            End If
            e.Graphics.DrawString(filterText, fontBody, brush, xPos, yPos)
            yPos += 20
        End If

        ' Print column headers
        Dim headers As String() = {"Subject Name", "Subject Code", "Subject Type", "Units", "Schedule Time"}
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
        e.Graphics.DrawString($"Total Subjects: {dt.Rows.Count}", fontBody, brush, leftMargin, yPos)

        ' No more pages
        e.HasMorePages = False
    End Sub

    Private Sub SubDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles subdatagrid.CellClick
        ' Ignore header clicks and invalid rows
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Return

        ' Get the selected row
        Dim selectedRow As DataGridViewRow = subdatagrid.Rows(e.RowIndex)

        ' Get the subject ID from the first column
        Dim subjectId As Integer = Convert.ToInt32(selectedRow.Cells(0).Value)

        ' Open the edit form and pass the ID
        Dim editForm As New editsubject()
        editForm.SubjectId = subjectId ' Set the public property
        editForm.ShowDialog()

        ' Refresh the data after editing
        LoadSubjectData()
    End Sub

    Private Sub admin_logoutbutton_Click(sender As Object, e As EventArgs) Handles admin_logoutbutton.Click
        Me.Close()
        login.Show()
        connection.Close()
    End Sub

End Class
