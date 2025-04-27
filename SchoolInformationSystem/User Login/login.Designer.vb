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
        hideicon = New PictureBox()
        showicon = New PictureBox()
        errorLabel = New Label()
        role = New ComboBox()
        loginbtn = New Button()
        password = New TextBox()
        username = New TextBox()
        Logo = New PictureBox()
        LoginPanel.SuspendLayout()
        CType(hideicon, ComponentModel.ISupportInitialize).BeginInit()
        CType(showicon, ComponentModel.ISupportInitialize).BeginInit()
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
        LoginPanel.Controls.Add(hideicon)
        LoginPanel.Controls.Add(showicon)
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
        ' hideicon
        ' 
        hideicon.Cursor = Cursors.Hand
        hideicon.Image = CType(resources.GetObject("hideicon.Image"), Image)
        hideicon.Location = New Point(363, 402)
        hideicon.Name = "hideicon"
        hideicon.Size = New Size(35, 35)
        hideicon.SizeMode = PictureBoxSizeMode.StretchImage
        hideicon.TabIndex = 7
        hideicon.TabStop = False
        ' 
        ' showicon
        ' 
        showicon.Cursor = Cursors.Hand
        showicon.Image = CType(resources.GetObject("showicon.Image"), Image)
        showicon.Location = New Point(363, 402)
        showicon.Name = "showicon"
        showicon.Size = New Size(35, 35)
        showicon.SizeMode = PictureBoxSizeMode.StretchImage
        showicon.TabIndex = 6
        showicon.TabStop = False
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
        loginbtn.TabIndex = 5
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
        password.TabIndex = 4
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
        username.TabIndex = 3
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
        CType(hideicon, ComponentModel.ISupportInitialize).EndInit()
        CType(showicon, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents hideicon As PictureBox
    Friend WithEvents showicon As PictureBox
End Class
