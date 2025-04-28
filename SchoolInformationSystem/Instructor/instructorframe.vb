Imports MySql.Data.MySqlClient
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
End Class
