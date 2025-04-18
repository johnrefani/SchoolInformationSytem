Public Class StudentPage
    Private Sub student_logout_Button_Click(sender As Object, e As EventArgs) Handles student_logout_Button.Click
        Dim loginForm As New LoginPage()
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub student_profile_Button_Click(sender As Object, e As EventArgs) Handles student_profile_Button.Click
        Dim stPfpForm As New StudentProfileforStudent()
        stPfpForm.Show()
        Me.Hide()
    End Sub

    Private Sub student_addCR_Button_Click(sender As Object, e As EventArgs) Handles student_addCR_Button.Click

    End Sub

    Private Sub student_enrolled_sub__Button_Click(sender As Object, e As EventArgs) Handles student_enrolled_sub__Button.Click

    End Sub

    Private Sub StudentPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class