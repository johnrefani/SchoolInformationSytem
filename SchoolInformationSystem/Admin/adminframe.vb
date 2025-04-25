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

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        editsubject.Show()
    End Sub

    Private Sub configurebutton_Click(sender As Object, e As EventArgs) Handles configurebutton.Click
        editconfiguration.Show()

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
End Class
