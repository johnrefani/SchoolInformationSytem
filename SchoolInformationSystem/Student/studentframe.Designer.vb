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
        dashboard = New Panel()
        dashboardbutton = New Button()
        enrollment = New Panel()
        enrollmentbutton = New Button()
        myprofile = New Panel()
        myprofilebutton = New Button()
        header = New Panel()
        title = New Label()
        logo = New PictureBox()
        dashboardpanel = New Panel()
        head_dashboard = New Panel()
        title_dashboard = New Label()
        username = New Label()
        enrollmentpanel = New Panel()
        head_enrollment = New Panel()
        title_enrollment = New Label()
        myprofilepanel = New Panel()
        head_myprofile = New Panel()
        title_myprofile = New Label()
        sidepanel.SuspendLayout()
        sidenav.SuspendLayout()
        menupanel.SuspendLayout()
        dashboard.SuspendLayout()
        enrollment.SuspendLayout()
        myprofile.SuspendLayout()
        header.SuspendLayout()
        CType(logo, ComponentModel.ISupportInitialize).BeginInit()
        dashboardpanel.SuspendLayout()
        head_dashboard.SuspendLayout()
        enrollmentpanel.SuspendLayout()
        head_enrollment.SuspendLayout()
        myprofilepanel.SuspendLayout()
        head_myprofile.SuspendLayout()
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
        menupanel.Controls.Add(dashboard)
        menupanel.Controls.Add(enrollment)
        menupanel.Controls.Add(myprofile)
        menupanel.Dock = DockStyle.Fill
        menupanel.Location = New Point(0, 60)
        menupanel.Name = "menupanel"
        menupanel.Size = New Size(300, 440)
        menupanel.TabIndex = 2
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
        dashboardbutton.FlatStyle = FlatStyle.Flat
        dashboardbutton.ForeColor = Color.White
        dashboardbutton.Location = New Point(0, 0)
        dashboardbutton.Name = "dashboardbutton"
        dashboardbutton.Size = New Size(294, 56)
        dashboardbutton.TabIndex = 0
        dashboardbutton.Text = "Dashboard"
        dashboardbutton.UseVisualStyleBackColor = False
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
        enrollmentbutton.FlatAppearance.BorderSize = 0
        enrollmentbutton.FlatStyle = FlatStyle.Flat
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
        myprofilebutton.FlatAppearance.BorderSize = 0
        myprofilebutton.FlatStyle = FlatStyle.Flat
        myprofilebutton.ForeColor = Color.White
        myprofilebutton.Location = New Point(0, 0)
        myprofilebutton.Name = "myprofilebutton"
        myprofilebutton.Size = New Size(294, 56)
        myprofilebutton.TabIndex = 0
        myprofilebutton.Text = "My Profile"
        myprofilebutton.UseVisualStyleBackColor = False
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
        dashboardpanel.Controls.Add(head_dashboard)
        dashboardpanel.Dock = DockStyle.Fill
        dashboardpanel.Location = New Point(350, 0)
        dashboardpanel.Name = "dashboardpanel"
        dashboardpanel.Size = New Size(1074, 985)
        dashboardpanel.TabIndex = 1
        ' 
        ' head_dashboard
        ' 
        head_dashboard.BackColor = Color.Maroon
        head_dashboard.Controls.Add(title_dashboard)
        head_dashboard.Controls.Add(username)
        head_dashboard.Dock = DockStyle.Top
        head_dashboard.Location = New Point(0, 0)
        head_dashboard.Name = "head_dashboard"
        head_dashboard.Size = New Size(1074, 81)
        head_dashboard.TabIndex = 0
        ' 
        ' title_dashboard
        ' 
        title_dashboard.Font = New Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        title_dashboard.ForeColor = Color.White
        title_dashboard.Location = New Point(16, 21)
        title_dashboard.Name = "title_dashboard"
        title_dashboard.Size = New Size(157, 38)
        title_dashboard.TabIndex = 0
        title_dashboard.Text = "Welcome,"
        title_dashboard.TextAlign = ContentAlignment.MiddleLeft
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
        ' enrollmentpanel
        ' 
        enrollmentpanel.Controls.Add(head_enrollment)
        enrollmentpanel.Dock = DockStyle.Fill
        enrollmentpanel.Location = New Point(350, 0)
        enrollmentpanel.Name = "enrollmentpanel"
        enrollmentpanel.Size = New Size(1074, 985)
        enrollmentpanel.TabIndex = 2
        ' 
        ' head_enrollment
        ' 
        head_enrollment.BackColor = Color.Maroon
        head_enrollment.Controls.Add(title_enrollment)
        head_enrollment.Dock = DockStyle.Top
        head_enrollment.Location = New Point(0, 0)
        head_enrollment.Name = "head_enrollment"
        head_enrollment.Size = New Size(1074, 81)
        head_enrollment.TabIndex = 0
        ' 
        ' title_enrollment
        ' 
        title_enrollment.Font = New Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        title_enrollment.ForeColor = Color.White
        title_enrollment.Location = New Point(16, 21)
        title_enrollment.Name = "title_enrollment"
        title_enrollment.Size = New Size(366, 38)
        title_enrollment.TabIndex = 0
        title_enrollment.Text = "My Enrollment History"
        title_enrollment.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' myprofilepanel
        ' 
        myprofilepanel.Controls.Add(head_myprofile)
        myprofilepanel.Dock = DockStyle.Fill
        myprofilepanel.Location = New Point(350, 0)
        myprofilepanel.Name = "myprofilepanel"
        myprofilepanel.Size = New Size(1074, 985)
        myprofilepanel.TabIndex = 3
        ' 
        ' head_myprofile
        ' 
        head_myprofile.BackColor = Color.Maroon
        head_myprofile.Controls.Add(title_myprofile)
        head_myprofile.Dock = DockStyle.Top
        head_myprofile.Location = New Point(0, 0)
        head_myprofile.Name = "head_myprofile"
        head_myprofile.Size = New Size(1074, 81)
        head_myprofile.TabIndex = 0
        ' 
        ' title_myprofile
        ' 
        title_myprofile.Font = New Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        title_myprofile.ForeColor = Color.White
        title_myprofile.Location = New Point(16, 21)
        title_myprofile.Name = "title_myprofile"
        title_myprofile.Size = New Size(366, 38)
        title_myprofile.TabIndex = 0
        title_myprofile.Text = "My Profile"
        title_myprofile.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' student_frame
        ' 
        AutoScaleDimensions = New SizeF(12F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1424, 985)
        Controls.Add(dashboardpanel)
        Controls.Add(enrollmentpanel)
        Controls.Add(myprofilepanel)
        Controls.Add(sidepanel)
        Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5)
        Name = "student_frame"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Frame"
        sidepanel.ResumeLayout(False)
        sidenav.ResumeLayout(False)
        menupanel.ResumeLayout(False)
        dashboard.ResumeLayout(False)
        enrollment.ResumeLayout(False)
        myprofile.ResumeLayout(False)
        header.ResumeLayout(False)
        CType(logo, ComponentModel.ISupportInitialize).EndInit()
        dashboardpanel.ResumeLayout(False)
        head_dashboard.ResumeLayout(False)
        enrollmentpanel.ResumeLayout(False)
        head_enrollment.ResumeLayout(False)
        myprofilepanel.ResumeLayout(False)
        head_myprofile.ResumeLayout(False)
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
    Friend WithEvents head_dashboard As Panel
    Friend WithEvents title_dashboard As Label
    Friend WithEvents username As Label
    Friend WithEvents enrollmentpanel As Panel
    Friend WithEvents head_enrollment As Panel
    Friend WithEvents title_enrollment As Label
    Friend WithEvents myprofilepanel As Panel
    Friend WithEvents head_myprofile As Panel
    Friend WithEvents title_myprofile As Label
End Class
