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

    Private Sub chartpanel_Paint(sender As Object, e As PaintEventArgs) Handles chartpanel.Paint
        If LineChart.ChartAreas.Count = 0 Then
            LineChart.ChartAreas.Add("ChartArea1")
        End If

        Dim mathSeries As New Series("Math")
        mathSeries.ChartType = SeriesChartType.Line
        mathSeries.Points.AddXY(2021, 500)
        mathSeries.Points.AddXY(2022, 550)
        mathSeries.Points.AddXY(2023, 600)
        mathSeries.Points.AddXY(2024, 620)
        mathSeries.Points.AddXY(2025, 650)
        mathSeries.Color = Color.FromArgb(52, 152, 219)
        mathSeries.BorderWidth = 2

        Dim scienceSeries As New Series("Science")
        scienceSeries.ChartType = SeriesChartType.Line
        scienceSeries.Points.AddXY(2021, 450)
        scienceSeries.Points.AddXY(2022, 480)
        scienceSeries.Points.AddXY(2023, 510)
        scienceSeries.Points.AddXY(2024, 530)
        scienceSeries.Points.AddXY(2025, 560)
        scienceSeries.Color = Color.FromArgb(46, 204, 113)
        scienceSeries.BorderWidth = 2

        Dim englishSeries As New Series("English")
        englishSeries.ChartType = SeriesChartType.Line
        englishSeries.Points.AddXY(2021, 400)
        englishSeries.Points.AddXY(2022, 420)
        englishSeries.Points.AddXY(2023, 440)
        englishSeries.Points.AddXY(2024, 460)
        englishSeries.Points.AddXY(2025, 480)
        englishSeries.Color = Color.FromArgb(231, 76, 60)
        englishSeries.BorderWidth = 2

        If LineChart.Legends.Count = 0 Then
            LineChart.Legends.Add("Legend1")
        End If
        LineChart.Legends("Legend1").Docking = Docking.Top
        LineChart.Legends("Legend1").Title = "Subjects"
        LineChart.Legends("Legend1").Font = New Font("Tahoma", 10, FontStyle.Regular)
        LineChart.Legends("Legend1").BackColor = Color.FromArgb(245, 245, 245)

        LineChart.Series.Clear()
        LineChart.Series.Add(mathSeries)
        LineChart.Series.Add(scienceSeries)
        LineChart.Series.Add(englishSeries)

        LineChart.Titles.Add("Student Enrollment per Subject Over School Years")
        LineChart.Titles(0).Font = New Font("Tahoma", 18, FontStyle.Bold)
        LineChart.Titles(0).ForeColor = Color.FromArgb(44, 62, 80)

        LineChart.ChartAreas(0).AxisX.Title = "School Year"
        LineChart.ChartAreas(0).AxisX.TitleFont = New Font("Tahoma", 12, FontStyle.Regular)
        LineChart.ChartAreas(0).AxisY.Title = "Enrollment"
        LineChart.ChartAreas(0).AxisY.TitleFont = New Font("Tahoma", 12, FontStyle.Regular)
    End Sub

    Private Sub logoutbutton_Click(sender As Object, e As EventArgs) Handles logoutbutton.Click
        Me.Close()
        login.Show()
        connection.Close()
    End Sub

    Private Sub instructor_username_Click(sender As Object, e As EventArgs) Handles instructor_username.Click

    End Sub
End Class
