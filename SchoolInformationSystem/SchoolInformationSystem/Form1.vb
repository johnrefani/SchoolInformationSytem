Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modDb.UpdateConnectionString()
        MsgBox(modDb.db_name & "haha")
        modDb.openConn(modDb.db_name)
        MsgBox(modDb.strConnection)
        Dim connstate As Boolean
        connstate = modDb.isConnectedToLocalServer

        MsgBox(connstate)
    End Sub
    Private Sub student_Button_Click(sender As Object, e As EventArgs) Handles student_Button.Click
        Dim form2 As New LoginPage()
        form2.Show()
        Me.Hide()
    End Sub
    Private Sub instructor_Button_Click(sender As Object, e As EventArgs) Handles instructor_Button.Click
        Dim form2 As New LoginPage()
        form2.Show()
        Me.Hide()
    End Sub
    Private Sub admin_Button_Click(sender As Object, e As EventArgs) Handles admin_Button.Click
        Dim form2 As New LoginPage()
        form2.Show()
        Me.Hide()
    End Sub
End Class