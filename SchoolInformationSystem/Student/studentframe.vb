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

    Private Sub student_name_Click(sender As Object, e As EventArgs) Handles student_name.Click

    End Sub
End Class
