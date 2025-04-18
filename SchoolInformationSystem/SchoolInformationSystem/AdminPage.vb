Imports MySql.Data.MySqlClient
Public Class AdminPage

    Private firstYearCount As Integer
    Private secondYearCount As Integer
    Private thirdYearCount As Integer
    Private fourthYearCount As Integer

    Private maleCount As Integer = 0
    Private femaleCount As Integer = 0

    Private maleFirstYearCount As Integer = 0
    Private femaleFirstYearCount As Integer = 0

    Private maleSecondYearCount As Integer = 0
    Private femaleSecondYearCount As Integer = 0

    Private maleThirdYearCount As Integer = 0
    Private femaleThirdYearCount As Integer = 0

    Private maleFourthYearCount As Integer = 0
    Private femaleFourthYearCount As Integer = 0

    Private Sub AdminPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            openConn(db_name)

            If Not CheckIfAdminExists() Then
                createadmin_Button.Visible = True
                Counts_Panel.Visible = False
                logout_Button.Visible = False
                UserManage_Button.Visible = False
            Else
                createadmin_Button.Visible = False
                Counts_Panel.Visible = True
                logout_Button.Visible = True
                UserManage_Button.Visible = True

                LoadStudentCountChart()
                LoadGenderCountChart()
            End If

            If IsNumeric(CurrentLoggedUser.id) Then
                SetDashboardState(Convert.ToInt32(CurrentLoggedUser.id) > 0)
            Else
                SetDashboardState(False)
            End If

            Dim studentCount As Integer = GetStudentCount()
            Dim allMaleCount As Integer = maleFirstYearCount + maleSecondYearCount + maleThirdYearCount + maleFourthYearCount
            Dim allFemaleCount As Integer = femaleFirstYearCount + femaleSecondYearCount + femaleThirdYearCount + femaleFourthYearCount


            StudentCount_Label.Text = $"Number of Students: {studentCount}"
            MaleCount_Label.Text = $"Male: {allMaleCount}"
            FemaleCount_Label.Text = $"Female: {allFemaleCount}"
        Catch ex As Exception
            MsgBox("Error loading dashboard: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub



    Private Sub SetDashboardState(isLoggedIn As Boolean)
        If Not isLoggedIn Then
            dashboard_Label.Text = "Please log in first"
            LoginPage.CenterElement(dashboard_Label)
            dashboard_Label.Visible = True
        Else
            dashboard_Label.Visible = False
        End If

        studentPage_Button.Enabled = isLoggedIn
        instructorPage_Button.Enabled = isLoggedIn
        coursePage_Button.Enabled = isLoggedIn
        programPage_Button.Enabled = isLoggedIn
        departmentPage_Button.Enabled = isLoggedIn
        departmentstaffPage_Button.Enabled = isLoggedIn
        courseregistrationPage_Button.Enabled = isLoggedIn
        transcriptPage_Button.Enabled = isLoggedIn
    End Sub

    Private Function CheckIfAdminExists() As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM user_accounts WHERE student_id IS NULL AND instructor_id IS NULL"

        Try
            ' Ensure the connection is open
            openConn(db_name)
            If conn.State <> ConnectionState.Open Then
                Throw New InvalidOperationException("Database connection could not be established.")
            End If

            ' Initialize the command with the query and connection
            Using cmd As New MySqlCommand(sql, conn)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        Catch ex As Exception
            MsgBox("An error occurred when checking admin: " & ex.Message, MsgBoxStyle.Critical)
            Return False
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Function


    Private Sub studentPage_Button_Click(sender As Object, e As EventArgs) Handles studentPage_Button.Click
        Dim form2 As New StudentList
        form2.Show()
        Hide()
    End Sub
    Private Sub instructorPage_Button_Click(sender As Object, e As EventArgs) Handles instructorPage_Button.Click
        Dim form2 As New InstructorList()
        form2.Show()
        Me.Hide()
    End Sub
    Private Sub blockPage_Button_Click(sender As Object, e As EventArgs) Handles blockPage_Button.Click
        Dim form2 As New BlockList()
        form2.Show()
        Me.Hide()
    End Sub
    Private Sub coursePage_Button_Click(sender As Object, e As EventArgs) Handles coursePage_Button.Click
        Dim form2 As New CourseList()
        form2.Show()
        Me.Hide()
    End Sub
    Private Sub programPage_Button_Click(sender As Object, e As EventArgs) Handles programPage_Button.Click
        Dim form2 As New ProgramList()
        form2.Show()
        Me.Hide()
    End Sub
    Private Sub departmentPage_Button_Click(sender As Object, e As EventArgs) Handles departmentPage_Button.Click
        Dim form2 As New DepartmentList()
        form2.Show()
        Me.Hide()
    End Sub
    Private Sub departmentstaffPage_Button_Click(sender As Object, e As EventArgs) Handles departmentstaffPage_Button.Click
        Dim form2 As New DepartmentStaffList()
        form2.Show()
        Me.Hide()
    End Sub
    Private Sub courseregistrationPage_Button_Click(sender As Object, e As EventArgs) Handles courseregistrationPage_Button.Click
        Dim form2 As New CourseRegistrationList()
        form2.Show()
        Me.Hide()
    End Sub
    Private Sub transcriptPage_Button_Click(sender As Object, e As EventArgs) Handles transcriptPage_Button.Click
        Dim form2 As New TranscriptList()
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub createadmin_Button_Click(sender As Object, e As EventArgs) Handles createadmin_Button.Click
        Dim AdminCreate As New AdminAccountCreation
        AdminCreate.Show()
        Me.Close()
    End Sub

    Public Function GetStudentCount() As Integer
        Dim count As Integer = 0
        Try
            openConn("schooldb")
            Dim query As String = "SELECT COUNT(*) FROM student_info"
            Using command As New MySqlCommand(query, modDb.conn)
                count = Convert.ToInt32(command.ExecuteScalar())
            End Using
        Catch ex As Exception
            MsgBox("Error retrieving student count: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
        Return count
    End Function


    Private Sub LoadStudentCountChart()
        Dim sql As String = "SELECT current_year, COUNT(*) AS studentCount FROM student_info GROUP BY current_year"

        Try
            openConn("schooldb")
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.CommandText = sql
            cmd.Parameters.Clear()

            cmdRead = cmd.ExecuteReader()

            Dim counts(4) As Integer

            While cmdRead.Read()
                Dim year As Integer = cmdRead("current_year")
                Dim count As Integer = cmdRead("studentCount")

                If year >= 1 And year <= 4 Then
                    counts(year) = count
                End If
            End While

            cmdRead.Close()

            firstYearCount = counts(1)
            secondYearCount = counts(2)
            thirdYearCount = counts(3)
            fourthYearCount = counts(4)

            UpdateChart()

        Catch ex As Exception
            MsgBox("An error occurred when loading the student chart: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub


    Private Sub UpdateChart()
        If Not IsNothing(StudentCount_Chart) Then
            StudentCount_Chart.Titles.Clear()
            StudentCount_Chart.Titles.Add("Student Count")

            StudentCount_Chart.ChartAreas(0).AxisX.Title = "Year"
            StudentCount_Chart.ChartAreas(0).AxisY.Title = "Student Count"

            If StudentCount_Chart.Series.IndexOf("Count") <> -1 Then
                StudentCount_Chart.Series("Count").Points.Clear()

                StudentCount_Chart.Series("Count").Points.AddXY("1st Year", firstYearCount)
                StudentCount_Chart.Series("Count").Points.AddXY("2nd Year", secondYearCount)
                StudentCount_Chart.Series("Count").Points.AddXY("3rd Year", thirdYearCount)
                StudentCount_Chart.Series("Count").Points.AddXY("4th Year", fourthYearCount)
            Else
                MsgBox("Series 'Count' does not exist.")
            End If
        Else
            MsgBox("Chart control is not initialized.")
        End If
    End Sub

    Private Sub LoadGenderCountChart()
        Dim sql As String = "
        SELECT current_year, gender, COUNT(*) AS studentCount 
        FROM student_info 
        GROUP BY current_year, gender"

        Try
            openConn("schooldb")
            cmd.CommandText = sql
            cmd.Parameters.Clear()
            cmdRead = cmd.ExecuteReader()

            While cmdRead.Read()
                Dim year As Integer = cmdRead("current_year")
                Dim gender As String = cmdRead("gender").ToString().ToLower()
                Dim count As Integer = cmdRead("studentCount")

                If gender = "male" And year = 1 Then
                    maleFirstYearCount = count
                ElseIf gender = "female" And year = 1 Then
                    femaleFirstYearCount = count
                End If

                If gender = "male" And year = 2 Then
                    maleSecondYearCount = count
                ElseIf gender = "female" And year = 2 Then
                    femaleSecondYearCount = count
                End If

                If gender = "male" And year = 3 Then
                    maleThirdYearCount = count
                ElseIf gender = "female" And year = 3 Then
                    femaleThirdYearCount = count
                End If

                If gender = "male" And year = 4 Then
                    maleFourthYearCount = count
                ElseIf gender = "female" And year = 4 Then
                    femaleFourthYearCount = count
                End If
            End While

            cmdRead.Close()

            UpdateGenderChart()

        Catch ex As Exception
            MsgBox("An error occurred when loading gender chart: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub UpdateGenderChart()
        If IsNothing(GenderCount_Chart) Then
            MsgBox("GenderCount_Chart control is not initialized.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        GenderCount_Chart.Titles.Clear()
        GenderCount_Chart.Titles.Add("Gender Count")

        If GenderCount_Chart.Series.IndexOf("Male") = -1 OrElse GenderCount_Chart.Series.IndexOf("Female") = -1 Then
            MsgBox("Chart series 'Male' or 'Female' does not exist.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        GenderCount_Chart.Series("Male").Points.Clear()
        GenderCount_Chart.Series("Female").Points.Clear()

        GenderCount_Chart.Series("Male").Points.AddXY("1st Year", maleFirstYearCount)
        GenderCount_Chart.Series("Female").Points.AddXY("1st Year", femaleFirstYearCount)

        GenderCount_Chart.Series("Male").Points.AddXY("2nd Year", maleSecondYearCount)
        GenderCount_Chart.Series("Female").Points.AddXY("2nd Year", femaleSecondYearCount)

        GenderCount_Chart.Series("Male").Points.AddXY("3rd Year", maleThirdYearCount)
        GenderCount_Chart.Series("Female").Points.AddXY("3rd Year", femaleThirdYearCount)

        GenderCount_Chart.Series("Male").Points.AddXY("4th Year", maleFourthYearCount)
        GenderCount_Chart.Series("Female").Points.AddXY("4th Year", femaleFourthYearCount)
    End Sub



    Private Sub UserManage_Button_Click(sender As Object, e As EventArgs) Handles UserManage_Button.Click
        Dim createUAForm As New UserManagementPage()
        Me.Close()
        createUAForm.Show()
    End Sub

    Private Sub LoadInstructorChart()
        modDb.openConn("schooldb")
        Dim query As String = "SELECT department, COUNT(*) AS instructor_count 
                           FROM instructor 
                           GROUP BY department"
        Try
            Using command As New MySqlCommand(query, modDb.conn)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    InstructorCount_Chart.Series.Clear()

                    Dim series As New DataVisualization.Charting.Series("Instructor Count")
                    series.ChartType = DataVisualization.Charting.SeriesChartType.Pie

                    While reader.Read()
                        Dim department As String = reader("department").ToString()
                        Dim instructorCount As Integer = Convert.ToInt32(reader("instructor_count"))

                        series.Points.AddXY(department, instructorCount)
                    End While

                    InstructorCount_Chart.Series.Add(series)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading instructor chart data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            modDb.conn.Close()
        End Try
    End Sub

    Private Sub logout_Button_Click_1(sender As Object, e As EventArgs) Handles logout_Button.Click
        Dim login As New LoginPage()
        login.Show()
        Me.Close()
    End Sub
End Class