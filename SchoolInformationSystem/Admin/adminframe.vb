Imports System.Windows.Forms.DataVisualization.Charting
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

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        editsubject.Show()
    End Sub

    Private Sub configurebutton_Click(sender As Object, e As EventArgs) Handles configurebutton.Click
        editconfiguration.Show()

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles TotalIns.Paint

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles SubjectCount.TextChanged

    End Sub

    Private Sub UserPieChart_Paint(sender As Object, e As PaintEventArgs) Handles UserPieChart.Paint
        If PieChart.ChartAreas.Count = 0 Then
            PieChart.ChartAreas.Add("ChartArea1")
        End If

        Dim series1 As New Series("UserTypes")
        series1.ChartType = SeriesChartType.Pie

        series1.Points.AddXY("Students", 3120)
        series1.Points.AddXY("Instructors", 38)
        series1.Points.AddXY("Aadmins", 15)

        series1.IsValueShownAsLabel = False

        If PieChart.Legends.Count = 0 Then
            PieChart.Legends.Add("Legend1")
        End If

        PieChart.Legends("Legend1").BackColor = Color.FromArgb(245, 245, 245)

        series1.Points(0).LegendText = "Students, 3120"
        series1.Points(1).LegendText = "Instructors, 38"
        series1.Points(2).LegendText = "Admins, 15"

        series1.Points(0).Color = Color.FromArgb(255, 255, 215, 0)
        series1.Points(1).Color = Color.FromArgb(255, 245, 225, 160)
        series1.Points(2).Color = Color.FromArgb(255, 0, 128, 128)

        PieChart.Series.Clear()
        PieChart.Series.Add(series1)

        PieChart.Titles.Add("Total Number of Users")
        PieChart.Titles(0).Font = New Font("Tahoma", 18, FontStyle.Bold)
        PieChart.Titles(0).ForeColor = Color.FromArgb(42, 62, 80)
    End Sub

    Private Sub Panel4_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel4.Paint
        If EnrollmentBarGraph.ChartAreas.Count = 0 Then
            EnrollmentBarGraph.ChartAreas.Add("ChartArea1")
        End If

        Dim series1 As New Series("Enrollments")
        series1.ChartType = SeriesChartType.Column

        series1.Points.AddXY(2021, 2500)
        series1.Points.AddXY(2022, 2800)
        series1.Points.AddXY(2023, 3000)
        series1.Points.AddXY(2024, 3200)
        series1.Points.AddXY(2025, 3400)

        If EnrollmentBarGraph.Legends.Count = 0 Then
            EnrollmentBarGraph.Legends.Add("Legend1")
        End If
        EnrollmentBarGraph.Legends("Legend1").Docking = Docking.Top
        EnrollmentBarGraph.Legends("Legend1").Title = "Enrollments"
        EnrollmentBarGraph.Legends("Legend1").Font = New Font("Tahoma", 10, FontStyle.Regular)
        EnrollmentBarGraph.Legends("Legend1").BackColor = Color.FromArgb(245, 245, 245)

        series1.Color = Color.FromArgb(52, 152, 219)

        EnrollmentBarGraph.Series.Clear()
        EnrollmentBarGraph.Series.Add(series1)

        EnrollmentBarGraph.Titles.Add("Total Enrollments per Year")
        EnrollmentBarGraph.Titles(0).Font = New Font("Tahoma", 18, FontStyle.Bold)
        EnrollmentBarGraph.Titles(0).ForeColor = Color.FromArgb(44, 62, 80)

        EnrollmentBarGraph.ChartAreas(0).AxisX.Title = "Year"
        EnrollmentBarGraph.ChartAreas(0).AxisX.TitleFont = New Font("Tahoma", 12, FontStyle.Regular)
        EnrollmentBarGraph.ChartAreas(0).AxisY.Title = "Enrollments"
        EnrollmentBarGraph.ChartAreas(0).AxisY.TitleFont = New Font("Tahoma", 12, FontStyle.Regular)
    End Sub
End Class
