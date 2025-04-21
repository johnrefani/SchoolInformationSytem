Public Class student_frame

    Private Sub student_frame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HideAllPanels()
        dashboardpanel.Visible = True
        HighlightActiveButton(dashboardbutton)
    End Sub

    ' Hide all panels
    Private Sub HideAllPanels()
        dashboardpanel.Visible = False
        enrollmentpanel.Visible = False
        myprofilepanel.Visible = False
    End Sub

    ' Reset and highlight active button
    Private Sub HighlightActiveButton(activeBtn As Button)
        Dim buttons As Button() = {dashboardbutton, enrollmentbutton, myprofilebutton}

        For Each btn As Button In buttons
            btn.BackColor = Color.Transparent
        Next

        activeBtn.BackColor = ColorTranslator.FromHtml("#ADADAD")
    End Sub

    ' Dashboard button click
    Private Sub dashboardbutton_Click(sender As Object, e As EventArgs) Handles dashboardbutton.Click
        HideAllPanels()
        dashboardpanel.Visible = True
        HighlightActiveButton(dashboardbutton)
    End Sub

    ' Enrollment button click
    Private Sub enrollmentbutton_Click(sender As Object, e As EventArgs) Handles enrollmentbutton.Click
        HideAllPanels()
        enrollmentpanel.Visible = True
        HighlightActiveButton(enrollmentbutton)
    End Sub

    ' My Profile button click
    Private Sub myprofilebutton_Click(sender As Object, e As EventArgs) Handles myprofilebutton.Click
        HideAllPanels()
        myprofilepanel.Visible = True
        HighlightActiveButton(myprofilebutton)
    End Sub


End Class
