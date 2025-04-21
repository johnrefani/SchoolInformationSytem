<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class student_frame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(student_frame))
        sidepanel = New Panel()
        sidenav = New Panel()
        menupanel = New Panel()
        enrollment = New Panel()
        enrollmentbutton = New Button()
        myprofile = New Panel()
        myprofilebutton = New Button()
        dashboard = New Panel()
        dashboardbutton = New Button()
        header = New Panel()
        title = New Label()
        logo = New PictureBox()
        dashboardpanel = New Panel()
        toppanel = New Panel()
        welcome = New Label()
        username = New Label()
        sidepanel.SuspendLayout()
        sidenav.SuspendLayout()
        menupanel.SuspendLayout()
        enrollment.SuspendLayout()
        myprofile.SuspendLayout()
        dashboard.SuspendLayout()
        header.SuspendLayout()
        CType(logo, ComponentModel.ISupportInitialize).BeginInit()
        dashboardpanel.SuspendLayout()
        toppanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' sidepanel
        ' 
        sidepanel.BackColor = Color.Maroon
        sidepanel.Controls.Add(sidenav)
        sidepanel.Dock = DockStyle.Left
        sidepanel.Location = New Point(0, 0)
        sidepanel.Name = "sidepanel"
        sidepanel.Size = New Size(350, 985)
        sidepanel.TabIndex = 0
        ' 
        ' sidenav
        ' 
        sidenav.Controls.Add(menupanel)
        sidenav.Controls.Add(header)
        sidenav.Location = New Point(25, 21)
        sidenav.Name = "sidenav"
        sidenav.Size = New Size(300, 500)
        sidenav.TabIndex = 0
        ' 
        ' menupanel
        ' 
        menupanel.Controls.Add(enrollment)
        menupanel.Controls.Add(myprofile)
        menupanel.Controls.Add(dashboard)
        menupanel.Dock = DockStyle.Fill
        menupanel.Location = New Point(0, 60)
        menupanel.Name = "menupanel"
        menupanel.Size = New Size(300, 440)
        menupanel.TabIndex = 2
        ' 
        ' enrollment
        ' 
        enrollment.BackgroundImageLayout = ImageLayout.None
        enrollment.Controls.Add(enrollmentbutton)
        enrollment.Cursor = Cursors.Hand
        enrollment.ForeColor = SystemColors.ControlText
        enrollment.Location = New Point(3, 185)
        enrollment.Name = "enrollment"
        enrollment.Size = New Size(294, 56)
        enrollment.TabIndex = 1
        ' 
        ' enrollmentbutton
        ' 
        enrollmentbutton.BackColor = Color.Maroon
        enrollmentbutton.Cursor = Cursors.Hand
        enrollmentbutton.Dock = DockStyle.Fill
        enrollmentbutton.ForeColor = Color.White
        enrollmentbutton.Location = New Point(0, 0)
        enrollmentbutton.Name = "enrollmentbutton"
        enrollmentbutton.Size = New Size(294, 56)
        enrollmentbutton.TabIndex = 0
        enrollmentbutton.Text = "Enrollment"
        enrollmentbutton.UseVisualStyleBackColor = False
        ' 
        ' myprofile
        ' 
        myprofile.Controls.Add(myprofilebutton)
        myprofile.Cursor = Cursors.Hand
        myprofile.Location = New Point(3, 265)
        myprofile.Name = "myprofile"
        myprofile.Size = New Size(294, 56)
        myprofile.TabIndex = 2
        ' 
        ' myprofilebutton
        ' 
        myprofilebutton.BackColor = Color.Maroon
        myprofilebutton.Dock = DockStyle.Fill
        myprofilebutton.ForeColor = Color.White
        myprofilebutton.Location = New Point(0, 0)
        myprofilebutton.Name = "myprofilebutton"
        myprofilebutton.Size = New Size(294, 56)
        myprofilebutton.TabIndex = 0
        myprofilebutton.Text = "My Profile"
        myprofilebutton.UseVisualStyleBackColor = False
        ' 
        ' dashboard
        ' 
        dashboard.Controls.Add(dashboardbutton)
        dashboard.Cursor = Cursors.Hand
        dashboard.Location = New Point(3, 100)
        dashboard.Name = "dashboard"
        dashboard.Size = New Size(294, 56)
        dashboard.TabIndex = 0
        ' 
        ' dashboardbutton
        ' 
        dashboardbutton.BackColor = Color.Maroon
        dashboardbutton.Dock = DockStyle.Fill
        dashboardbutton.FlatAppearance.BorderColor = Color.Maroon
        dashboardbutton.FlatAppearance.BorderSize = 0
        dashboardbutton.ForeColor = Color.White
        dashboardbutton.Location = New Point(0, 0)
        dashboardbutton.Name = "dashboardbutton"
        dashboardbutton.Size = New Size(294, 56)
        dashboardbutton.TabIndex = 0
        dashboardbutton.Text = "Dashboard"
        dashboardbutton.UseVisualStyleBackColor = False
        ' 
        ' header
        ' 
        header.Controls.Add(title)
        header.Controls.Add(logo)
        header.Dock = DockStyle.Top
        header.Location = New Point(0, 0)
        header.Name = "header"
        header.Size = New Size(300, 60)
        header.TabIndex = 1
        ' 
        ' title
        ' 
        title.Dock = DockStyle.Fill
        title.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        title.ForeColor = Color.White
        title.Location = New Point(57, 0)
        title.Name = "title"
        title.Size = New Size(243, 60)
        title.TabIndex = 1
        title.Text = "CNSC Information System"
        title.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' logo
        ' 
        logo.BackColor = Color.White
        logo.Dock = DockStyle.Left
        logo.Image = CType(resources.GetObject("logo.Image"), Image)
        logo.Location = New Point(0, 0)
        logo.Name = "logo"
        logo.Size = New Size(57, 60)
        logo.SizeMode = PictureBoxSizeMode.Zoom
        logo.TabIndex = 0
        logo.TabStop = False
        ' 
        ' dashboardpanel
        ' 
        dashboardpanel.Controls.Add(toppanel)
        dashboardpanel.Dock = DockStyle.Fill
        dashboardpanel.Location = New Point(350, 0)
        dashboardpanel.Name = "dashboardpanel"
        dashboardpanel.Size = New Size(1074, 985)
        dashboardpanel.TabIndex = 1
        ' 
        ' toppanel
        ' 
        toppanel.BackColor = Color.Maroon
        toppanel.Controls.Add(welcome)
        toppanel.Controls.Add(username)
        toppanel.Dock = DockStyle.Top
        toppanel.Location = New Point(0, 0)
        toppanel.Name = "toppanel"
        toppanel.Size = New Size(1074, 81)
        toppanel.TabIndex = 0
        ' 
        ' welcome
        ' 
        welcome.Font = New Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        welcome.ForeColor = Color.White
        welcome.Location = New Point(16, 21)
        welcome.Name = "welcome"
        welcome.Size = New Size(157, 38)
        welcome.TabIndex = 0
        welcome.Text = "Welcome,"
        welcome.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' username
        ' 
        username.Font = New Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        username.ForeColor = Color.White
        username.Location = New Point(179, 21)
        username.Name = "username"
        username.Size = New Size(157, 38)
        username.TabIndex = 1
        username.Text = "John Doe"
        username.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' student_frame
        ' 
        AutoScaleDimensions = New SizeF(12F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1424, 985)
        Controls.Add(dashboardpanel)
        Controls.Add(sidepanel)
        Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5)
        Name = "student_frame"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Frame"
        sidepanel.ResumeLayout(False)
        sidenav.ResumeLayout(False)
        menupanel.ResumeLayout(False)
        enrollment.ResumeLayout(False)
        myprofile.ResumeLayout(False)
        dashboard.ResumeLayout(False)
        header.ResumeLayout(False)
        CType(logo, ComponentModel.ISupportInitialize).EndInit()
        dashboardpanel.ResumeLayout(False)
        toppanel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents sidepanel As Panel
    Friend WithEvents sidenav As Panel
    Friend WithEvents header As Panel
    Friend WithEvents logo As PictureBox
    Friend WithEvents menupanel As Panel
    Friend WithEvents dashboard As Panel
    Friend WithEvents dashboardbutton As Button
    Friend WithEvents title As Label
    Friend WithEvents myprofile As Panel
    Friend WithEvents myprofilebutton As Button
    Friend WithEvents enrollment As Panel
    Friend WithEvents enrollmentbutton As Button
    Friend WithEvents dashboardpanel As Panel
    Friend WithEvents toppanel As Panel
    Friend WithEvents welcome As Label
    Friend WithEvents username As Label
End Class
