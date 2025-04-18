Imports ContentAlignment = System.Drawing.ContentAlignment

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class AdminAccountCreation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        UsernameLabel = New Label()
        PasswordLabel = New Label()
        UsernameTextBox = New TextBox()
        PasswordTextBox = New TextBox()
        OK = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.Location = New Point(80, 21)
        UsernameLabel.Margin = New Padding(2, 0, 2, 0)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(154, 14)
        UsernameLabel.TabIndex = 0
        UsernameLabel.Text = "User name"
        UsernameLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.Location = New Point(80, 58)
        PasswordLabel.Margin = New Padding(2, 0, 2, 0)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(154, 14)
        PasswordLabel.TabIndex = 2
        PasswordLabel.Text = "Password"
        PasswordLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.Location = New Point(81, 36)
        UsernameTextBox.Margin = New Padding(2, 2, 2, 2)
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(155, 23)
        UsernameTextBox.TabIndex = 1
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Location = New Point(81, 74)
        PasswordTextBox.Margin = New Padding(2, 2, 2, 2)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.PasswordChar = "*"c
        PasswordTextBox.Size = New Size(155, 23)
        PasswordTextBox.TabIndex = 3
        ' 
        ' OK
        ' 
        OK.Location = New Point(168, 105)
        OK.Margin = New Padding(2, 2, 2, 2)
        OK.Name = "OK"
        OK.Size = New Size(66, 25)
        OK.TabIndex = 4
        OK.Text = "Create"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.eye_closed
        PictureBox1.InitialImage = Nothing
        PictureBox1.Location = New Point(211, 78)
        PictureBox1.Margin = New Padding(2, 2, 2, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(21, 11)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' AdminAccountCreation
        ' 
        AcceptButton = OK
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(323, 161)
        Controls.Add(PictureBox1)
        Controls.Add(OK)
        Controls.Add(PasswordTextBox)
        Controls.Add(UsernameTextBox)
        Controls.Add(PasswordLabel)
        Controls.Add(UsernameLabel)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(2, 2, 2, 2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "AdminAccountCreation"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "Account Creation"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox

End Class
