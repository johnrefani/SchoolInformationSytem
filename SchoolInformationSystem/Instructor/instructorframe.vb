Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.Windows.Forms.DataVisualization.Charting

Public Class instructorframe
    Private Sub instructor_frame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HideAllPanels()
        dashboardpanel.Visible = True
        HighlightActiveButton(dashboardbutton)

        ' Fetch Instructor Data on Load (Example)
        FetchInstructorData(GlobalInstructorId)
    End Sub

    ' Hide all panels
    Private Sub HideAllPanels()
        dashboardpanel.Visible = False
        classespanel.Visible = False
        myprofilepanel.Visible = False
    End Sub

    ' Reset and highlight active button
    Private Sub HighlightActiveButton(activeBtn As Button)
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

    Private Sub editprofilebutton_Click(sender As Object, e As EventArgs) Handles editprofilebutton.Click
        editprofile.Show()
        Me.Close()

    End Sub

    ' Fetch Instructor Data from the Database
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
                            instructor_username.Text = reader("first_name").ToString() & " " & reader("middle_initial").ToString() & ". " & reader("last_name").ToString()
                            yearofexperiencetextbox.Text = reader("years_of_experience").ToString()
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
                            middleinitialtextbox.Text = reader("middle_initial").ToString() ' Assuming middle_initial is used for initials
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



    Private Sub logoutbutton_Click(sender As Object, e As EventArgs) Handles logoutbutton.Click
        Me.Close()
        login.Show()
        connection.Close()
    End Sub


    Private Sub chartpanel_Paint(sender As Object, e As PaintEventArgs) Handles chartpanel.Paint
        Dim instructorId As String = GlobalInstructorId
        Dim conn As MySqlConnection = strconnection()
        Try
            conn.Open()
            Dim query As String = "SELECT s.subject_name, e.school_year, COUNT(e.enrollment_id) as enrollment_count " &
                             "FROM enrollment e " &
                             "JOIN subject s ON e.subject_id = s.subject_id " &
                             "WHERE s.teacher_id = @InstructorId " &
                             "GROUP BY s.subject_name, e.school_year " &
                             "ORDER BY e.school_year"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@InstructorId", instructorId) ' Ensure instructorId is defined or passed

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            ' Clear previous chart data
            LineChart.Series.Clear()
            LineChart.ChartAreas.Clear()

            ' Set up chart area
            Dim chartArea As New ChartArea()
            LineChart.ChartAreas.Add(chartArea)

            ' Group data by subject to create a series for each subject
            Dim subjects = dt.AsEnumerable().Select(Function(row) row.Field(Of String)("subject_name")).Distinct()
            For Each subject In subjects
                Dim series As New Series(subject)
                series.ChartType = SeriesChartType.Line
                series.BorderWidth = 2

                ' Filter data for the current subject
                Dim subjectData = dt.AsEnumerable().Where(Function(row) row.Field(Of String)("subject_name") = subject)
                For Each row In subjectData
                    Dim schoolYear = row.Field(Of String)("school_year")
                    Dim enrollmentCount = row.Field(Of Long)("enrollment_count")
                    series.Points.AddXY(schoolYear, enrollmentCount)
                Next

                LineChart.Series.Add(series)
            Next

            ' Customize chart appearance
            With LineChart
                .Titles.Clear()
                .Titles.Add("Student Enrollment per Subject Over School Years")
                .ChartAreas(0).AxisX.Title = "School Year"
                .ChartAreas(0).AxisY.Title = "Number of Enrollments"
                .ChartAreas(0).AxisX.Interval = 1
                .ChartAreas(0).AxisX.MajorGrid.LineColor = Color.LightGray
                .ChartAreas(0).AxisY.MajorGrid.LineColor = Color.LightGray
            End With

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub enrolledstuds_Paint(sender As Object, e As PaintEventArgs) Handles enrolledstuds.Paint
        Dim instructorId As String = GlobalInstructorId
        Dim conn As MySqlConnection = strconnection()
        Try
            conn.Open()
            Dim query As String = "SELECT COUNT(e.enrollment_id) as enrolled_count " &
                             "FROM enrollment e " &
                             "JOIN subject s ON e.subject_id = s.subject_id " &
                             "WHERE s.teacher_id = @InstructorId AND e.status = 'Enrolled'"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@InstructorId", instructorId) ' Ensure instructorId is defined or passed

            Dim enrolledCount As Object = cmd.ExecuteScalar()
            enrolledstudentslabel.Text = If(enrolledCount IsNot Nothing, enrolledCount.ToString(), "0")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub droppedstuds_Paint(sender As Object, e As PaintEventArgs) Handles droppedstuds.Paint
        Dim instructorId As String = GlobalInstructorId
        Dim conn As MySqlConnection = strconnection()
        Try
            conn.Open()
            Dim query As String = "SELECT COUNT(e.enrollment_id) as dropped_count " &
                             "FROM enrollment e " &
                             "JOIN subject s ON e.subject_id = s.subject_id " &
                             "WHERE s.teacher_id = @InstructorId AND e.status = 'Dropped'"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@InstructorId", instructorId) ' Ensure instructorId is defined or passed

            Dim droppedCount As Object = cmd.ExecuteScalar()
            droppedstudentslabel.Text = If(droppedCount IsNot Nothing, droppedCount.ToString(), "0")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
        Dim instructorId As String = GlobalInstructorId
        Dim conn As MySqlConnection = strconnection()
        Try
            conn.Open()
            Dim query As String = "SELECT subject_name, subject_code, grade_level, section, max_students " &
                             "FROM subject " &
                             "WHERE teacher_id = @InstructorId"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@InstructorId", instructorId) ' Ensure instructorId is defined or passed

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            ClassGridView.DataSource = dt

            ' Optional: Set column headers for better display
            With ClassGridView
                .Columns("subject_name").HeaderText = "Subject Name"
                .Columns("subject_code").HeaderText = "Subject Code"
                .Columns("grade_level").HeaderText = "Grade Level"
                .Columns("section").HeaderText = "Section"
                .Columns("max_students").HeaderText = "Max Students"

                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            End With
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' For setting the variables
    Private currentInstructorPage As Integer = 1
    Private instructorPageSize As Integer = 15
    Private totalInstructorRecords As Integer = 0
    Private totalInstructorPages As Integer = 0
    Private isInstructorSearching As Boolean = False

    ' For loading the form
    Private Sub InstructorSubjectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupInstructorFilterComboBox()
        AddHandler instSearch.TextChanged, AddressOf InstSearch_TextChanged
        LoadInstructorData()
    End Sub

    Private Sub LoadInstructorData()
        Dim offset As Integer = (currentInstructorPage - 1) * instructorPageSize
        Dim selectedSemester As String = instSemester.SelectedItem?.ToString()

        Using conn As MySqlConnection = strconnection()
            Try
                conn.Open()

                ' Count query
                Dim countQuery As String = "SELECT COUNT(*) FROM subject WHERE teacher_id = @instructorId"

                If selectedSemester <> "All Semesters" AndAlso Not String.IsNullOrEmpty(selectedSemester) Then
                    countQuery &= " AND semester = @semester"
                End If

                Using countCmd As New MySqlCommand(countQuery, conn)
                    countCmd.Parameters.AddWithValue("@instructorId", GlobalInstructorId)

                    If selectedSemester <> "All Semesters" AndAlso Not String.IsNullOrEmpty(selectedSemester) Then
                        countCmd.Parameters.AddWithValue("@semester", selectedSemester)
                    End If

                    totalInstructorRecords = Convert.ToInt32(countCmd.ExecuteScalar())
                    totalInstructorPages = Math.Ceiling(totalInstructorRecords / instructorPageSize)
                End Using

                ' Main query with join to get instructor name
                Dim query As String = "SELECT s.subject_id, s.subject_name, s.subject_code, s.subject_type, s.department, s.grade_level, 
                             CONCAT(i.first_name, ' ', i.middle_initial, ' ', i.last_name) AS instructor_name,
                             s.description, s.units, s.section, s.semester, s.room_number, s.schedule_time, s.day, s.max_students
                             FROM subject s
                             JOIN instructor i ON s.teacher_id = i.instructor_id
                             WHERE s.teacher_id = @instructorId"

                If selectedSemester <> "All Semesters" AndAlso Not String.IsNullOrEmpty(selectedSemester) Then
                    query &= " AND s.semester = @semester"
                End If

                query &= " LIMIT @limit OFFSET @offset"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@instructorId", GlobalInstructorId)

                    If selectedSemester <> "All Semesters" AndAlso Not String.IsNullOrEmpty(selectedSemester) Then
                        cmd.Parameters.AddWithValue("@semester", selectedSemester)
                    End If

                    cmd.Parameters.AddWithValue("@limit", instructorPageSize)
                    cmd.Parameters.AddWithValue("@offset", offset)

                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)
                        instData.DataSource = dt
                    End Using
                End Using

                UpdateInstructorPaginationUI()
                SetupInstructorDataGridView()

            Catch ex As Exception
                MessageBox.Show("Error loading instructor subject data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub FilterInstructorData()
        isInstructorSearching = True
        Dim offset As Integer = (currentInstructorPage - 1) * instructorPageSize
        Dim selectedSemester As String = instSemester.SelectedItem?.ToString()
        Dim searchText As String = instSearch.Text

        Using conn As MySqlConnection = strconnection()
            Try
                conn.Open()

                ' Counting filtered
                Dim countQuery As String = "SELECT COUNT(*) FROM subject s
                                  JOIN instructor i ON s.teacher_id = i.instructor_id
                                  WHERE s.teacher_id = @instructorId
                                  AND (s.subject_name LIKE @search OR s.subject_code LIKE @search)"

                If selectedSemester <> "All Semesters" AndAlso Not String.IsNullOrEmpty(selectedSemester) Then
                    countQuery &= " AND s.semester = @semester"
                End If

                Using countCmd As New MySqlCommand(countQuery, conn)
                    countCmd.Parameters.AddWithValue("@instructorId", GlobalInstructorId)
                    countCmd.Parameters.AddWithValue("@search", "%" & searchText & "%")

                    If selectedSemester <> "All Semesters" AndAlso Not String.IsNullOrEmpty(selectedSemester) Then
                        countCmd.Parameters.AddWithValue("@semester", selectedSemester)
                    End If

                    totalInstructorRecords = Convert.ToInt32(countCmd.ExecuteScalar())
                    totalInstructorPages = Math.Ceiling(totalInstructorRecords / instructorPageSize)
                End Using

                ' Query for searching
                Dim query As String = "SELECT s.subject_id, s.subject_name, s.subject_code, s.subject_type, s.department, s.grade_level, 
                             CONCAT(i.first_name, ' ', i.middle_initial, ' ', i.last_name) AS instructor_name,
                             s.description, s.units, s.section, s.semester, s.room_number, s.schedule_time, s.day, s.max_students
                             FROM subject s
                             JOIN instructor i ON s.teacher_id = i.instructor_id
                             WHERE s.teacher_id = @instructorId
                             AND (s.subject_name LIKE @search OR s.subject_code LIKE @search)"

                If selectedSemester <> "All Semesters" AndAlso Not String.IsNullOrEmpty(selectedSemester) Then
                    query &= " AND s.semester = @semester"
                End If

                query &= " LIMIT @limit OFFSET @offset"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@instructorId", GlobalInstructorId)
                    cmd.Parameters.AddWithValue("@search", "%" & searchText & "%")

                    If selectedSemester <> "All Semesters" AndAlso Not String.IsNullOrEmpty(selectedSemester) Then
                        cmd.Parameters.AddWithValue("@semester", selectedSemester)
                    End If

                    cmd.Parameters.AddWithValue("@limit", instructorPageSize)
                    cmd.Parameters.AddWithValue("@offset", offset)

                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)
                        instData.DataSource = dt
                    End Using
                End Using

                UpdateInstructorPaginationUI()
                SetupInstructorDataGridView()

            Catch ex As Exception
                MessageBox.Show("Error filtering instructor subject data: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Set column headers and the design of the table
    Private Sub SetupInstructorDataGridView()
        Dim headers As String() = {"Subject ID", "Subject Name", "Subject Code", "Subject Type", "Department",
                                  "Grade Level", "Instructor Name", "Description", "Units", "Section",
                                  "Semester", "Room Number", "Schedule Time", "Day", "Max Students"}

        With instData
            If .Columns.Count = headers.Length Then
                For i As Integer = 0 To headers.Length - 1
                    .Columns(i).HeaderText = headers(i)
                Next
            End If
            .DefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)
            .DefaultCellStyle.Font = New Font("Tahoma", 10)
        End With
    End Sub

    ' Updating the label and button states (for pagination)
    Private Sub UpdateInstructorPaginationUI()
        instLabel.Text = $"Page {currentInstructorPage} of {If(totalInstructorPages = 0, 1, totalInstructorPages)}"
        instPrev.Enabled = currentInstructorPage > 1
        instNext.Enabled = currentInstructorPage < totalInstructorPages
    End Sub

    Private Sub SetupInstructorFilterComboBox()
        ' Setup semester filter
        instSemester.Items.Clear()
        instSemester.Items.Add("All Semesters")

        Using conn As MySqlConnection = strconnection()
            Try
                conn.Open()
                Dim query As String = "SELECT DISTINCT semester FROM subject WHERE teacher_id = @instructorId ORDER BY semester"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@instructorId", GlobalInstructorId)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            instSemester.Items.Add(reader("semester").ToString())
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading semesters: " & ex.Message)
            End Try
        End Using

        instSemester.SelectedIndex = 0
    End Sub

    ' Updating the search results
    Private Sub InstSearch_TextChanged(sender As Object, e As EventArgs)
        currentInstructorPage = 1
        If String.IsNullOrWhiteSpace(instSearch.Text) Then
            isInstructorSearching = False
            LoadInstructorData()
        Else
            FilterInstructorData()
        End If
    End Sub

    ' For filtering by semester
    Private Sub InstSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles instSemester.SelectedIndexChanged
        currentInstructorPage = 1
        If String.IsNullOrWhiteSpace(instSearch.Text) Then
            LoadInstructorData()
        Else
            FilterInstructorData()
        End If
    End Sub

    ' Next Page Button
    Private Sub InstNext_Click(sender As Object, e As EventArgs) Handles instNext.Click
        If currentInstructorPage < totalInstructorPages Then
            currentInstructorPage += 1
            If isInstructorSearching Then
                FilterInstructorData()
            Else
                LoadInstructorData()
            End If
        End If
    End Sub

    ' Prev Page Button
    Private Sub InstPrev_Click(sender As Object, e As EventArgs) Handles instPrev.Click
        If currentInstructorPage > 1 Then
            currentInstructorPage -= 1
            If isInstructorSearching Then
                FilterInstructorData()
            Else
                LoadInstructorData()
            End If
        End If
    End Sub

    Private Sub InstPrint_Click(sender As Object, e As EventArgs) Handles instPrint.Click
        ' Create a PrintDocument
        Dim printDoc As New PrintDocument()
        AddHandler printDoc.PrintPage, AddressOf PrintInstructorPageHandler

        ' Show print dialog
        Dim printDialog As New PrintDialog()
        printDialog.Document = printDoc

        If printDialog.ShowDialog() = DialogResult.OK Then
            printDoc.Print()
        End If
    End Sub

    Private Sub PrintInstructorPageHandler(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Dim selectedSemester As String = instSemester.SelectedItem?.ToString()
        Dim searchText As String = instSearch.Text

        ' Get the data to print
        Dim dt As New DataTable()

        Using conn As MySqlConnection = strconnection()
            Try
                conn.Open()

                Dim query As String = "SELECT s.subject_name, s.subject_code, s.subject_type, s.units, s.schedule_time
                              FROM subject s
                              WHERE s.teacher_id = @instructorId"

                Dim whereClauses As New List(Of String)

                If Not String.IsNullOrWhiteSpace(searchText) Then
                    whereClauses.Add("(s.subject_name LIKE @search OR s.subject_code LIKE @search)")
                End If

                If selectedSemester <> "All Semesters" AndAlso Not String.IsNullOrEmpty(selectedSemester) Then
                    whereClauses.Add("s.semester = @semester")
                End If

                If whereClauses.Count > 0 Then
                    query &= " AND " & String.Join(" AND ", whereClauses)
                End If

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@instructorId", GlobalInstructorId)

                    If Not String.IsNullOrWhiteSpace(searchText) Then
                        cmd.Parameters.AddWithValue("@search", "%" & searchText & "%")
                    End If

                    If selectedSemester <> "All Semesters" AndAlso Not String.IsNullOrEmpty(selectedSemester) Then
                        cmd.Parameters.AddWithValue("@semester", selectedSemester)
                    End If

                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error preparing instructor subject data for printing: " & ex.Message)
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
        Dim colWidths As Integer() = {200, 100, 100, 80, 150}

        ' Print title
        e.Graphics.DrawString("INSTRUCTOR SUBJECT REPORT", fontHeader, brush, xPos, yPos)
        yPos += 30

        ' Print date
        e.Graphics.DrawString("Printed on: " & DateTime.Now.ToString("MMM dd, yyyy hh:mm tt"), fontBody, brush, xPos, yPos)
        yPos += 30

        ' Print filter info if any
        If Not String.IsNullOrWhiteSpace(searchText) OrElse selectedSemester <> "All Semesters" Then
            Dim filterText As String = "Filtered by: "
            If Not String.IsNullOrWhiteSpace(searchText) Then
                filterText += "Search='" & searchText & "' "
            End If
            If selectedSemester <> "All Semesters" Then
                filterText += "Semester='" & selectedSemester & "'"
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
        e.Graphics.DrawString($"Total Records: {dt.Rows.Count}", fontBody, brush, leftMargin, yPos)

        ' No more pages
        e.HasMorePages = False
    End Sub
End Class
