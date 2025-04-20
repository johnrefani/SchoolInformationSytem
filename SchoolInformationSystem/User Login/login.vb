Public Class login
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Center the second PictureBox on the form when the form loads
        CenterPictureBox()


    End Sub

    Private Sub login_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' Adjust position of PictureBox2 when the form is resized
        CenterPictureBox()
    End Sub

    ' Function to center the PictureBox
    Private Sub CenterPictureBox()
        ' Center PictureBox2 in the form
        PictureBox2.Left = (Me.ClientSize.Width - PictureBox2.Width) \ 2
        PictureBox2.Top = (Me.ClientSize.Height - PictureBox2.Height) \ 2
    End Sub

End Class
