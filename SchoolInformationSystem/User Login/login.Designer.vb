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
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        logo = New PictureBox()
        selectuser = New ComboBox()
        username = New TextBox()
        password = New TextBox()
        loginbtn = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(logo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Maroon
        PictureBox1.Dock = DockStyle.Top
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1440, 512)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.White
        PictureBox2.Location = New Point(470, 212)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(500, 600)
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' logo
        ' 
        logo.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        logo.BackColor = Color.White
        logo.Image = CType(resources.GetObject("logo.Image"), Image)
        logo.Location = New Point(640, 254)
        logo.Name = "logo"
        logo.Size = New Size(160, 160)
        logo.SizeMode = PictureBoxSizeMode.StretchImage
        logo.TabIndex = 2
        logo.TabStop = False
        ' 
        ' selectuser
        ' 
        selectuser.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        selectuser.FormattingEnabled = True
        selectuser.Items.AddRange(New Object() {"Student", "Teacher", "Admin"})
        selectuser.Location = New Point(570, 462)
        selectuser.Name = "selectuser"
        selectuser.Size = New Size(300, 33)
        selectuser.TabIndex = 3
        ' 
        ' username
        ' 
        username.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        username.Location = New Point(570, 530)
        username.Multiline = True
        username.Name = "username"
        username.PlaceholderText = "Username"
        username.Size = New Size(300, 40)
        username.TabIndex = 4
        ' 
        ' password
        ' 
        password.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        password.Location = New Point(570, 587)
        password.Multiline = True
        password.Name = "password"
        password.PlaceholderText = "Password"
        password.Size = New Size(300, 40)
        password.TabIndex = 5
        ' 
        ' loginbtn
        ' 
        loginbtn.BackColor = Color.Maroon
        loginbtn.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        loginbtn.ForeColor = Color.White
        loginbtn.Location = New Point(570, 665)
        loginbtn.Name = "loginbtn"
        loginbtn.Size = New Size(300, 48)
        loginbtn.TabIndex = 6
        loginbtn.Text = "Log In"
        loginbtn.UseVisualStyleBackColor = False
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1440, 1024)
        Controls.Add(logo)
        Controls.Add(loginbtn)
        Controls.Add(password)
        Controls.Add(username)
        Controls.Add(selectuser)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "User LogIn"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(logo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents logo As PictureBox
    Friend WithEvents selectuser As ComboBox
    Friend WithEvents username As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents loginbtn As Button
End Class
