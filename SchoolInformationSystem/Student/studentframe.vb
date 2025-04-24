Imports System.Windows.Forms.DataVisualization.Charting

Public Class studentframe
    Private Sub studentframe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HideAllPanels()
        dashboardpanel.Visible = True
        HighlightActiveButton(dashboardbutton)
    End Sub

    ' Hide all panels
    Private Sub HideAllPanels()
        dashboardpanel.Visible = False
        classespanel.Visible = False
        myprofilepanel.Visible = False
    End Sub

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

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub myprofilepanel_Paint(sender As Object, e As PaintEventArgs) Handles myprofilepanel.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint, Panel3.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub schedule_panel_Paint(sender As Object, e As PaintEventArgs) Handles schedule_panel.Paint

    End Sub

    Private Sub subject_panel_Paint(sender As Object, e As PaintEventArgs) Handles subject_panel.Paint
        If StudBarChart.ChartAreas.Count = 0 Then
            StudBarChart.ChartAreas.Add("ChartArea1")
        End If

        Dim studentSeries As New Series("Enrolled Subjects")
        studentSeries.ChartType = SeriesChartType.Column
        studentSeries.Points.AddXY("Fall 2023", 4)
        studentSeries.Points.AddXY("Spring 2024", 5)
        studentSeries.Points.AddXY("Fall 2024", 3)
        studentSeries.Points.AddXY("Spring 2025", 4)
        studentSeries.Color = Color.FromArgb(52, 152, 219)
        studentSeries.CustomProperties = "PointWidth=0.4"

        If StudBarChart.Legends.Count = 0 Then
            StudBarChart.Legends.Add("Legend1")
        End If
        StudBarChart.Legends("Legend1").Docking = Docking.Top
        StudBarChart.Legends("Legend1").Title = "Student Enrollment"
        StudBarChart.Legends("Legend1").Font = New Font("Tahoma", 10, FontStyle.Regular)
        StudBarChart.Legends("Legend1").BackColor = Color.FromArgb(245, 245, 245)

        StudBarChart.Series.Clear()
        StudBarChart.Series.Add(studentSeries)

        StudBarChart.Titles.Add("Enrolled Subjects per Semester")
        StudBarChart.Titles(0).Font = New Font("Tahoma", 18, FontStyle.Bold)
        StudBarChart.Titles(0).ForeColor = Color.FromArgb(44, 62, 80)

        StudBarChart.ChartAreas(0).AxisX.Title = "Semester"
        StudBarChart.ChartAreas(0).AxisX.TitleFont = New Font("Tahoma", 12, FontStyle.Regular)
        StudBarChart.ChartAreas(0).AxisX.Interval = 1
        StudBarChart.ChartAreas(0).AxisX.MajorGrid.Enabled = False
        StudBarChart.ChartAreas(0).AxisX.LabelStyle.Font = New Font("Tahoma", 8, FontStyle.Regular)
        StudBarChart.ChartAreas(0).AxisX.LabelStyle.Angle = 45
        StudBarChart.ChartAreas(0).AxisY.Title = "Number of Subjects"
        StudBarChart.ChartAreas(0).AxisY.TitleFont = New Font("Tahoma", 12, FontStyle.Regular)


        StudBarChart.ChartAreas(0).AxisX.ScrollBar.Enabled = True
        StudBarChart.ChartAreas(0).AxisX.ScrollBar.Size = 15
        StudBarChart.ChartAreas(0).AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.All
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles student_fullname.Click

    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel3_Paint(sender, e)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub print_button_Click(sender As Object, e As EventArgs) Handles print_button.Click

    End Sub

    Private Sub status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles status.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub schoolyear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles schoolyear.SelectedIndexChanged

    End Sub

End Class