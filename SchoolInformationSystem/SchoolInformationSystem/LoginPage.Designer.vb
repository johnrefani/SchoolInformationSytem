<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginPage))
        idnumber_TextBox = New TextBox()
        password_TextBox = New TextBox()
        login_Button = New Button()
        Panel1 = New Panel()
        serverConfig_Label = New Label()
        PictureBox1 = New PictureBox()
        usertype_ComboBox = New ComboBox()
        cnsc_logo_PictureBox = New PictureBox()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(cnsc_logo_PictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' idnumber_TextBox
        ' 
        idnumber_TextBox.Anchor = AnchorStyles.None
        idnumber_TextBox.Location = New Point(149, 211)
        idnumber_TextBox.Name = "idnumber_TextBox"
        idnumber_TextBox.PlaceholderText = "ID Number"
        idnumber_TextBox.Size = New Size(115, 23)
        idnumber_TextBox.TabIndex = 0
        ' 
        ' password_TextBox
        ' 
        password_TextBox.Anchor = AnchorStyles.None
        password_TextBox.Location = New Point(46, 244)
        password_TextBox.Name = "password_TextBox"
        password_TextBox.PlaceholderText = "Password"
        password_TextBox.Size = New Size(218, 23)
        password_TextBox.TabIndex = 1
        ' 
        ' login_Button
        ' 
        login_Button.Anchor = AnchorStyles.None
        login_Button.BackColor = Color.Maroon
        login_Button.FlatStyle = FlatStyle.Popup
        login_Button.ForeColor = SystemColors.ControlLightLight
        login_Button.Location = New Point(120, 296)
        login_Button.Name = "login_Button"
        login_Button.Size = New Size(76, 23)
        login_Button.TabIndex = 2
        login_Button.Text = "Log in"
        login_Button.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.BackColor = SystemColors.ControlLight
        Panel1.Controls.Add(serverConfig_Label)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(usertype_ComboBox)
        Panel1.Controls.Add(cnsc_logo_PictureBox)
        Panel1.Controls.Add(idnumber_TextBox)
        Panel1.Controls.Add(password_TextBox)
        Panel1.Controls.Add(login_Button)
        Panel1.Location = New Point(807, 396)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(316, 366)
        Panel1.TabIndex = 3
        ' 
        ' serverConfig_Label
        ' 
        serverConfig_Label.AutoSize = True
        serverConfig_Label.ForeColor = Color.Blue
        serverConfig_Label.Location = New Point(18, 341)
        serverConfig_Label.Name = "serverConfig_Label"
        serverConfig_Label.Size = New Size(116, 15)
        serverConfig_Label.TabIndex = 6
        serverConfig_Label.Text = "Server Configuration"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.Image = My.Resources.Resources.eye_closed
        PictureBox1.Location = New Point(239, 250)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(21, 11)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' usertype_ComboBox
        ' 
        usertype_ComboBox.FormattingEnabled = True
        usertype_ComboBox.Items.AddRange(New Object() {"Student", "Instructor", "Administrator"})
        usertype_ComboBox.Location = New Point(46, 211)
        usertype_ComboBox.Margin = New Padding(2)
        usertype_ComboBox.Name = "usertype_ComboBox"
        usertype_ComboBox.Size = New Size(93, 23)
        usertype_ComboBox.TabIndex = 4
        ' 
        ' cnsc_logo_PictureBox
        ' 
        cnsc_logo_PictureBox.Anchor = AnchorStyles.None
        cnsc_logo_PictureBox.BackgroundImage = CType(resources.GetObject("cnsc_logo_PictureBox.BackgroundImage"), Image)
        cnsc_logo_PictureBox.BackgroundImageLayout = ImageLayout.Stretch
        cnsc_logo_PictureBox.Location = New Point(92, 81)
        cnsc_logo_PictureBox.Name = "cnsc_logo_PictureBox"
        cnsc_logo_PictureBox.Size = New Size(130, 100)
        cnsc_logo_PictureBox.TabIndex = 3
        cnsc_logo_PictureBox.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.None
        Panel2.BackColor = Color.Maroon
        Panel2.Location = New Point(807, 396)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(316, 62)
        Panel2.TabIndex = 5
        ' 
        ' LoginPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1904, 1041)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Name = "LoginPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login Page"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(cnsc_logo_PictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents idnumber_TextBox As TextBox
    Friend WithEvents password_TextBox As TextBox
    Friend WithEvents login_Button As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cnsc_logo_PictureBox As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents usertype_ComboBox As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents serverConfig_Label As Label
End Class
