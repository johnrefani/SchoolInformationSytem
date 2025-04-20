<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        TopColor = New Panel()
        LoginPanel = New Panel()
        UserSelect = New ComboBox()
        LoginButton = New Button()
        Password = New TextBox()
        Username = New TextBox()
        Logo = New PictureBox()
        LoginPanel.SuspendLayout()
        CType(Logo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TopColor
        ' 
        TopColor.BackColor = Color.Maroon
        TopColor.Dock = DockStyle.Top
        TopColor.Location = New Point(0, 0)
        TopColor.Margin = New Padding(2)
        TopColor.Name = "TopColor"
        TopColor.Size = New Size(1479, 324)
        TopColor.TabIndex = 0
        ' 
        ' LoginPanel
        ' 
        LoginPanel.BackColor = Color.White
        LoginPanel.Controls.Add(UserSelect)
        LoginPanel.Controls.Add(LoginButton)
        LoginPanel.Controls.Add(Password)
        LoginPanel.Controls.Add(Username)
        LoginPanel.Controls.Add(Logo)
        LoginPanel.Location = New Point(552, 194)
        LoginPanel.Margin = New Padding(2)
        LoginPanel.Name = "LoginPanel"
        LoginPanel.Size = New Size(389, 486)
        LoginPanel.TabIndex = 1
        ' 
        ' UserSelect
        ' 
        UserSelect.FormattingEnabled = True
        UserSelect.Items.AddRange(New Object() {"Select User", "Student", "Instructor", "Admin"})
        UserSelect.SelectedIndex = 0
        UserSelect.Location = New Point(86, 202)
        UserSelect.Name = "UserSelect"
        UserSelect.Size = New Size(217, 25)
        UserSelect.TabIndex = 4
        ' 
        ' LoginButton
        ' 
        LoginButton.BackColor = Color.Maroon
        LoginButton.ForeColor = Color.White
        LoginButton.Location = New Point(86, 372)
        LoginButton.Name = "LoginButton"
        LoginButton.Size = New Size(217, 35)
        LoginButton.TabIndex = 3
        LoginButton.Text = "Login"
        LoginButton.UseVisualStyleBackColor = False
        ' 
        ' Password
        ' 
        Password.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Password.Location = New Point(86, 311)
        Password.Name = "Password"
        Password.PlaceholderText = "Password"
        Password.Size = New Size(217, 29)
        Password.TabIndex = 2
        ' 
        ' Username
        ' 
        Username.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Username.Location = New Point(86, 261)
        Username.Name = "Username"
        Username.PlaceholderText = "Username"
        Username.Size = New Size(217, 29)
        Username.TabIndex = 1
        ' 
        ' Logo
        ' 
        Logo.Image = CType(resources.GetObject("Logo.Image"), Image)
        Logo.Location = New Point(144, 62)
        Logo.Name = "Logo"
        Logo.Size = New Size(100, 100)
        Logo.SizeMode = PictureBoxSizeMode.StretchImage
        Logo.TabIndex = 0
        Logo.TabStop = False
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 17.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1479, 836)
        Controls.Add(LoginPanel)
        Controls.Add(TopColor)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(2)
        MaximizeBox = False
        Name = "login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "School Information System"
        LoginPanel.ResumeLayout(False)
        LoginPanel.PerformLayout()
        CType(Logo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TopColor As Panel
    Friend WithEvents LoginPanel As Panel
    Friend WithEvents Logo As PictureBox
    Friend WithEvents Username As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents LoginButton As Button
    Friend WithEvents UserSelect As ComboBox
End Class
