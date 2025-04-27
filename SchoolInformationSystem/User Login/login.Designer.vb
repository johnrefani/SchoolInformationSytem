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
        hide = New PictureBox()
        show = New PictureBox()
        errorLabel = New Label()
        role = New ComboBox()
        loginbtn = New Button()
        password = New TextBox()
        username = New TextBox()
        Logo = New PictureBox()
        LoginPanel.SuspendLayout()
        CType(hide, ComponentModel.ISupportInitialize).BeginInit()
        CType(show, ComponentModel.ISupportInitialize).BeginInit()
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
        TopColor.Size = New Size(1424, 512)
        TopColor.TabIndex = 0
        ' 
        ' LoginPanel
        ' 
        LoginPanel.BackColor = Color.White
        LoginPanel.Controls.Add(hide)
        LoginPanel.Controls.Add(show)
        LoginPanel.Controls.Add(errorLabel)
        LoginPanel.Controls.Add(role)
        LoginPanel.Controls.Add(loginbtn)
        LoginPanel.Controls.Add(password)
        LoginPanel.Controls.Add(username)
        LoginPanel.Controls.Add(Logo)
        LoginPanel.Location = New Point(462, 278)
        LoginPanel.Margin = New Padding(2)
        LoginPanel.Name = "LoginPanel"
        LoginPanel.Size = New Size(500, 600)
        LoginPanel.TabIndex = 1
        ' 
        ' hide
        ' 
        hide.Cursor = Cursors.Hand
        hide.Image = CType(resources.GetObject("hide.Image"), Image)
        hide.Location = New Point(363, 402)
        hide.Name = "hide"
        hide.Size = New Size(35, 35)
        hide.SizeMode = PictureBoxSizeMode.StretchImage
        hide.TabIndex = 7
        hide.TabStop = False
        ' 
        ' show
        ' 
        show.Cursor = Cursors.Hand
        show.Image = CType(resources.GetObject("show.Image"), Image)
        show.Location = New Point(363, 402)
        show.Name = "show"
        show.Size = New Size(35, 35)
        show.SizeMode = PictureBoxSizeMode.StretchImage
        show.TabIndex = 6
        show.TabStop = False
        ' 
        ' errorLabel
        ' 
        errorLabel.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        errorLabel.ForeColor = Color.Red
        errorLabel.Location = New Point(100, 513)
        errorLabel.Name = "errorLabel"
        errorLabel.Size = New Size(300, 72)
        errorLabel.TabIndex = 5
        errorLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' role
        ' 
        role.Cursor = Cursors.Hand
        role.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        role.FormattingEnabled = True
        role.Items.AddRange(New Object() {"Student", "Instructor", "Admin"})
        role.Location = New Point(100, 276)
        role.Name = "role"
        role.Size = New Size(300, 33)
        role.TabIndex = 1
        role.Text = "Select User"
        ' 
        ' loginbtn
        ' 
        loginbtn.BackColor = Color.Maroon
        loginbtn.Cursor = Cursors.Hand
        loginbtn.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        loginbtn.ForeColor = Color.White
        loginbtn.Location = New Point(100, 460)
        loginbtn.Name = "loginbtn"
        loginbtn.Size = New Size(300, 50)
        loginbtn.TabIndex = 3
        loginbtn.Text = "Login"
        loginbtn.UseVisualStyleBackColor = False
        ' 
        ' password
        ' 
        password.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        password.Location = New Point(100, 400)
        password.Name = "password"
        password.PlaceholderText = "Password"
        password.Size = New Size(300, 33)
        password.TabIndex = 3
        password.UseSystemPasswordChar = True
        ' 
        ' username
        ' 
        username.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        username.Location = New Point(100, 337)
        username.Multiline = True
        username.Name = "username"
        username.PlaceholderText = "Username"
        username.Size = New Size(300, 40)
        username.TabIndex = 2
        ' 
        ' Logo
        ' 
        Logo.Image = CType(resources.GetObject("Logo.Image"), Image)
        Logo.Location = New Point(170, 37)
        Logo.Name = "Logo"
        Logo.Size = New Size(160, 160)
        Logo.SizeMode = PictureBoxSizeMode.StretchImage
        Logo.TabIndex = 0
        Logo.TabStop = False
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1424, 985)
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
        CType(hide, ComponentModel.ISupportInitialize).EndInit()
        CType(show, ComponentModel.ISupportInitialize).EndInit()
        CType(Logo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TopColor As Panel
    Friend WithEvents LoginPanel As Panel
    Friend WithEvents Logo As PictureBox
    Friend WithEvents username As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents loginbtn As Button
    Friend WithEvents role As ComboBox
    Friend WithEvents errorLabel As Label
    Friend WithEvents hide As PictureBox
    Friend WithEvents show As PictureBox
End Class
