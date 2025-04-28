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

End Class
