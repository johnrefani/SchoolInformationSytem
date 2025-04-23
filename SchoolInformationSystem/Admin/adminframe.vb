Imports System.Windows.Forms.DataVisualization.Charting

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

    Private Sub TotalStudents_TextChanged(sender As Object, e As EventArgs) Handles TotalStudents.TextChanged

    End Sub

    Private Sub CountTotalStud_TextChanged(sender As Object, e As EventArgs) Handles CountTotalStud.TextChanged


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If UserPieChart.ChartAreas.Count = 0 Then
            UserPieChart.ChartAreas.Add("ChartArea1")
        End If

        Dim series1 As New Series("UserTypes")
        series1.ChartType = SeriesChartType.Pie

        series1.Points.AddXY("Students", 3120)
        series1.Points.AddXY("Admins", 15)
        series1.Points.AddXY("Instructors", 48)


        If UserPieChart.Legends.Count = 0 Then
            UserPieChart.Legends.Add("Legend2")
        End If
        UserPieChart.Legends("Legend2").Docking = Docking.Right
        UserPieChart.Legends("Legend2").Title = "User Categories"
        UserPieChart.Legends("Legend2").Font = New Font("Tahoma", 10, FontStyle.Regular)
        UserPieChart.Legends("Legend2").BackColor = Color.FromArgb(245, 245, 245)

        series1.Points(0).LegendText = "Students: 3120"
        series1.Points(1).LegendText = "Admins: 15"
        series1.Points(2).LegendText = "Instructors: 48"

        series1.Points(0).Color = Color.FromArgb(52, 152, 219)
        series1.Points(1).Color = Color.FromArgb(231, 76, 60)
        series1.Points(2).Color = Color.FromArgb(46, 204, 113)

        UserPieChart.Series.Clear()
        UserPieChart.Series.Add(series1)

        UserPieChart.Titles.Add("Total Number of Users")
        UserPieChart.Titles(0).Font = New Font("Tahoma", 18, FontStyle.Bold)
        UserPieChart.Titles(0).ForeColor = Color.FromArgb(44, 62, 80)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        If EnrollmentsBarChart.ChartAreas.Count = 0 Then
            EnrollmentsBarChart.ChartAreas.Add("ChartArea1")
        End If

        Dim series1 As New Series("Enrollments")
        series1.ChartType = SeriesChartType.Column

        series1.Points.AddXY(2021, 2500)
        series1.Points.AddXY(2022, 2800)
        series1.Points.AddXY(2023, 3000)
        series1.Points.AddXY(2024, 3200)
        series1.Points.AddXY(2025, 3400)

        If EnrollmentsBarChart.Legends.Count = 0 Then
            EnrollmentsBarChart.Legends.Add("Legend1")
        End If
        EnrollmentsBarChart.Legends("Legend1").Docking = Docking.Top
        EnrollmentsBarChart.Legends("Legend1").Title = "Enrollments"
        EnrollmentsBarChart.Legends("Legend1").Font = New Font("Tahoma", 10, FontStyle.Regular)
        EnrollmentsBarChart.Legends("Legend1").BackColor = Color.FromArgb(245, 245, 245)

        series1.Color = Color.FromArgb(52, 152, 219)

        EnrollmentsBarChart.Series.Clear()
        EnrollmentsBarChart.Series.Add(series1)

        EnrollmentsBarChart.Titles.Add("Total Enrollments per Year")
        EnrollmentsBarChart.Titles(0).Font = New Font("Tahoma", 18, FontStyle.Bold)
        EnrollmentsBarChart.Titles(0).ForeColor = Color.FromArgb(44, 62, 80)

        EnrollmentsBarChart.ChartAreas(0).AxisX.Title = "Year"
        EnrollmentsBarChart.ChartAreas(0).AxisX.TitleFont = New Font("Tahoma", 12, FontStyle.Regular)
        EnrollmentsBarChart.ChartAreas(0).AxisY.Title = "Enrollments"
        EnrollmentsBarChart.ChartAreas(0).AxisY.TitleFont = New Font("Tahoma", 12, FontStyle.Regular)
    End Sub
End Class
