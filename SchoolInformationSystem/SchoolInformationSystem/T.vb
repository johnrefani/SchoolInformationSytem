Public Class T
    Private Sub student_logout_Button_Click(sender As Object, e As EventArgs)
        Dim loginForm As New LoginPage
        loginForm.Show()
        Hide()
    End Sub

    Private Sub student_profile_Button_Click(sender As Object, e As EventArgs)
        Dim stPfpForm As New StudentPage
        stPfpForm.Show()
        Hide()
    End Sub

    Private Sub student_addCR_Button_Click(sender As Object, e As EventArgs)
        Dim corseRegForm As New CourseRegistrationList
        corseRegForm.Show()
        Hide()
    End Sub

    Private Sub student_enrolled_sub__Button_Click(sender As Object, e As EventArgs)
        Dim transcriptsForm As New TranscriptList
        transcriptsForm.Show()
        Hide()
    End Sub
End Class