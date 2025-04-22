<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_frame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin_frame))
        dashboardpanel = New Panel()
        head_dashboard = New Panel()
        title_dashboard = New Label()
        username = New Label()
        sidenav = New Panel()
        header = New Panel()
        title = New Label()
        logo = New PictureBox()
        menupanel = New Panel()
        subjects = New Panel()
        subjectsbutton = New Button()
        dashboard = New Panel()
        dashboardbutton = New Button()
        users = New Panel()
        usersbutton = New Button()
        enrollments = New Panel()
        enrollmentsbutton = New Button()
        configuration = New Panel()
        configurationbutton = New Button()
        userspanel = New Panel()
        head_users = New Panel()
        title_users = New Label()
        head_enrollments = New Panel()
        title_enrollments = New Label()
        enrollmentspanel = New Panel()
        sidepanel = New Panel()
        subjectspanel = New Panel()
        head_subjects = New Panel()
        title_subjects = New Label()
        configurationpanel = New Panel()
        head_configuration = New Panel()
        title_configuration = New Label()
        dashboardpanel.SuspendLayout()
        head_dashboard.SuspendLayout()
        sidenav.SuspendLayout()
        header.SuspendLayout()
        CType(logo, ComponentModel.ISupportInitialize).BeginInit()
        menupanel.SuspendLayout()
        subjects.SuspendLayout()
        dashboard.SuspendLayout()
        users.SuspendLayout()
        enrollments.SuspendLayout()
        configuration.SuspendLayout()
        userspanel.SuspendLayout()
        head_users.SuspendLayout()
        head_enrollments.SuspendLayout()
        enrollmentspanel.SuspendLayout()
        sidepanel.SuspendLayout()
        subjectspanel.SuspendLayout()
        head_subjects.SuspendLayout()
        configurationpanel.SuspendLayout()
        head_configuration.SuspendLayout()
        SuspendLayout()
        ' 
        ' dashboardpanel
        ' 
        dashboardpanel.Controls.Add(head_dashboard)
        dashboardpanel.Dock = DockStyle.Fill
        dashboardpanel.Location = New Point(350, 0)
        dashboardpanel.Name = "dashboardpanel"
        dashboardpanel.Size = New Size(1074, 985)
        dashboardpanel.TabIndex = 9
        ' 
        ' head_dashboard
        ' 
        head_dashboard.BackColor = Color.Maroon
        head_dashboard.Controls.Add(title_dashboard)
        head_dashboard.Controls.Add(username)
        head_dashboard.Dock = DockStyle.Top
        head_dashboard.Location = New Point(0, 0)
        head_dashboard.Name = "head_dashboard"
        head_dashboard.Size = New Size(1074, 94)
        head_dashboard.TabIndex = 0
        ' 
        ' title_dashboard
        ' 
        title_dashboard.Font = New Font("Tahoma", 24F)
        title_dashboard.ForeColor = Color.White
        title_dashboard.ImeMode = ImeMode.NoControl
        title_dashboard.Location = New Point(16, 28)
        title_dashboard.Name = "title_dashboard"
        title_dashboard.Size = New Size(157, 38)
        title_dashboard.TabIndex = 0
        title_dashboard.Text = "Welcome,"
        title_dashboard.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' username
        ' 
        username.Font = New Font("Tahoma", 24F)
        username.ForeColor = Color.White
        username.ImeMode = ImeMode.NoControl
        username.Location = New Point(179, 28)
        username.Name = "username"
        username.Size = New Size(157, 38)
        username.TabIndex = 1
        username.Text = "John Doe"
        username.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' sidenav
        ' 
        sidenav.Controls.Add(header)
        sidenav.Controls.Add(menupanel)
        sidenav.Location = New Point(25, 21)
        sidenav.Name = "sidenav"
        sidenav.Size = New Size(300, 580)
        sidenav.TabIndex = 0
        ' 
        ' header
        ' 
        header.Controls.Add(title)
        header.Controls.Add(logo)
        header.Dock = DockStyle.Top
        header.Location = New Point(0, 0)
        header.Name = "header"
        header.Size = New Size(300, 73)
        header.TabIndex = 1
        ' 
        ' title
        ' 
        title.Dock = DockStyle.Fill
        title.Font = New Font("Tahoma", 14.25F)
        title.ForeColor = Color.White
        title.ImeMode = ImeMode.NoControl
        title.Location = New Point(63, 0)
        title.Name = "title"
        title.Size = New Size(237, 73)
        title.TabIndex = 1
        title.Text = "CNSC Information System"
        title.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' logo
        ' 
        logo.BackColor = Color.White
        logo.Dock = DockStyle.Left
        logo.Image = CType(resources.GetObject("logo.Image"), Image)
        logo.ImeMode = ImeMode.NoControl
        logo.Location = New Point(0, 0)
        logo.Name = "logo"
        logo.Size = New Size(63, 73)
        logo.SizeMode = PictureBoxSizeMode.Zoom
        logo.TabIndex = 0
        logo.TabStop = False
        ' 
        ' menupanel
        ' 
        menupanel.Controls.Add(subjects)
        menupanel.Controls.Add(dashboard)
        menupanel.Controls.Add(users)
        menupanel.Controls.Add(enrollments)
        menupanel.Controls.Add(configuration)
        menupanel.Dock = DockStyle.Fill
        menupanel.Location = New Point(0, 0)
        menupanel.Name = "menupanel"
        menupanel.Size = New Size(300, 580)
        menupanel.TabIndex = 2
        ' 
        ' subjects
        ' 
        subjects.Controls.Add(subjectsbutton)
        subjects.Cursor = Cursors.Hand
        subjects.Location = New Point(3, 286)
        subjects.Name = "subjects"
        subjects.Size = New Size(294, 56)
        subjects.TabIndex = 3
        ' 
        ' subjectsbutton
        ' 
        subjectsbutton.BackColor = Color.Maroon
        subjectsbutton.Dock = DockStyle.Fill
        subjectsbutton.FlatAppearance.BorderColor = Color.Maroon
        subjectsbutton.FlatAppearance.BorderSize = 0
        subjectsbutton.FlatStyle = FlatStyle.Flat
        subjectsbutton.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        subjectsbutton.ForeColor = Color.White
        subjectsbutton.Image = CType(resources.GetObject("subjectsbutton.Image"), Image)
        subjectsbutton.ImageAlign = ContentAlignment.MiddleLeft
        subjectsbutton.ImeMode = ImeMode.NoControl
        subjectsbutton.Location = New Point(0, 0)
        subjectsbutton.Name = "subjectsbutton"
        subjectsbutton.Size = New Size(294, 56)
        subjectsbutton.TabIndex = 0
        subjectsbutton.Text = "       Subjects"
        subjectsbutton.TextAlign = ContentAlignment.MiddleLeft
        subjectsbutton.UseVisualStyleBackColor = False
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
        dashboardbutton.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dashboardbutton.ForeColor = Color.White
        dashboardbutton.Image = CType(resources.GetObject("dashboardbutton.Image"), Image)
        dashboardbutton.ImageAlign = ContentAlignment.MiddleLeft
        dashboardbutton.ImeMode = ImeMode.NoControl
        dashboardbutton.Location = New Point(0, 0)
        dashboardbutton.Name = "dashboardbutton"
        dashboardbutton.Size = New Size(294, 56)
        dashboardbutton.TabIndex = 0
        dashboardbutton.Text = "       Dashboard"
        dashboardbutton.TextAlign = ContentAlignment.MiddleLeft
        dashboardbutton.UseVisualStyleBackColor = False
        ' 
        ' users
        ' 
        users.BackgroundImageLayout = ImageLayout.None
        users.Controls.Add(usersbutton)
        users.Cursor = Cursors.Hand
        users.ForeColor = SystemColors.ControlText
        users.Location = New Point(3, 162)
        users.Name = "users"
        users.Size = New Size(294, 56)
        users.TabIndex = 1
        ' 
        ' usersbutton
        ' 
        usersbutton.BackColor = Color.Maroon
        usersbutton.Cursor = Cursors.Hand
        usersbutton.Dock = DockStyle.Fill
        usersbutton.FlatAppearance.BorderSize = 0
        usersbutton.FlatStyle = FlatStyle.Flat
        usersbutton.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        usersbutton.ForeColor = Color.WhiteSmoke
        usersbutton.Image = CType(resources.GetObject("usersbutton.Image"), Image)
        usersbutton.ImageAlign = ContentAlignment.MiddleLeft
        usersbutton.ImeMode = ImeMode.NoControl
        usersbutton.Location = New Point(0, 0)
        usersbutton.Name = "usersbutton"
        usersbutton.Size = New Size(294, 56)
        usersbutton.TabIndex = 0
        usersbutton.Text = "       Users"
        usersbutton.TextAlign = ContentAlignment.MiddleLeft
        usersbutton.UseVisualStyleBackColor = False
        ' 
        ' enrollments
        ' 
        enrollments.Controls.Add(enrollmentsbutton)
        enrollments.Cursor = Cursors.Hand
        enrollments.Location = New Point(3, 224)
        enrollments.Name = "enrollments"
        enrollments.Size = New Size(294, 56)
        enrollments.TabIndex = 2
        ' 
        ' enrollmentsbutton
        ' 
        enrollmentsbutton.BackColor = Color.Maroon
        enrollmentsbutton.Dock = DockStyle.Fill
        enrollmentsbutton.FlatAppearance.BorderSize = 0
        enrollmentsbutton.FlatStyle = FlatStyle.Flat
        enrollmentsbutton.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        enrollmentsbutton.ForeColor = Color.White
        enrollmentsbutton.Image = CType(resources.GetObject("enrollmentsbutton.Image"), Image)
        enrollmentsbutton.ImageAlign = ContentAlignment.MiddleLeft
        enrollmentsbutton.ImeMode = ImeMode.NoControl
        enrollmentsbutton.Location = New Point(0, 0)
        enrollmentsbutton.Name = "enrollmentsbutton"
        enrollmentsbutton.Size = New Size(294, 56)
        enrollmentsbutton.TabIndex = 0
        enrollmentsbutton.Text = "       Enrollments"
        enrollmentsbutton.TextAlign = ContentAlignment.MiddleLeft
        enrollmentsbutton.UseVisualStyleBackColor = False
        ' 
        ' configuration
        ' 
        configuration.Controls.Add(configurationbutton)
        configuration.Cursor = Cursors.Hand
        configuration.Location = New Point(3, 348)
        configuration.Name = "configuration"
        configuration.Size = New Size(294, 56)
        configuration.TabIndex = 4
        ' 
        ' configurationbutton
        ' 
        configurationbutton.BackColor = Color.Maroon
        configurationbutton.Dock = DockStyle.Fill
        configurationbutton.FlatAppearance.BorderColor = Color.Maroon
        configurationbutton.FlatAppearance.BorderSize = 0
        configurationbutton.FlatStyle = FlatStyle.Flat
        configurationbutton.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        configurationbutton.ForeColor = Color.White
        configurationbutton.Image = CType(resources.GetObject("configurationbutton.Image"), Image)
        configurationbutton.ImageAlign = ContentAlignment.MiddleLeft
        configurationbutton.ImeMode = ImeMode.NoControl
        configurationbutton.Location = New Point(0, 0)
        configurationbutton.Name = "configurationbutton"
        configurationbutton.Size = New Size(294, 56)
        configurationbutton.TabIndex = 0
        configurationbutton.Text = "       Configuration"
        configurationbutton.TextAlign = ContentAlignment.MiddleLeft
        configurationbutton.UseVisualStyleBackColor = False
        ' 
        ' userspanel
        ' 
        userspanel.Controls.Add(head_users)
        userspanel.Dock = DockStyle.Fill
        userspanel.Location = New Point(350, 0)
        userspanel.Name = "userspanel"
        userspanel.Size = New Size(1074, 985)
        userspanel.TabIndex = 10
        ' 
        ' head_users
        ' 
        head_users.BackColor = Color.Maroon
        head_users.Controls.Add(title_users)
        head_users.Dock = DockStyle.Top
        head_users.Location = New Point(0, 0)
        head_users.Name = "head_users"
        head_users.Size = New Size(1074, 81)
        head_users.TabIndex = 0
        ' 
        ' title_users
        ' 
        title_users.Font = New Font("Tahoma", 24F)
        title_users.ForeColor = Color.White
        title_users.ImeMode = ImeMode.NoControl
        title_users.Location = New Point(16, 21)
        title_users.Name = "title_users"
        title_users.Size = New Size(366, 38)
        title_users.TabIndex = 0
        title_users.Text = "Manage Users"
        title_users.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' head_enrollments
        ' 
        head_enrollments.BackColor = Color.Maroon
        head_enrollments.Controls.Add(title_enrollments)
        head_enrollments.Dock = DockStyle.Top
        head_enrollments.Location = New Point(0, 0)
        head_enrollments.Name = "head_enrollments"
        head_enrollments.Size = New Size(1074, 81)
        head_enrollments.TabIndex = 0
        ' 
        ' title_enrollments
        ' 
        title_enrollments.Font = New Font("Tahoma", 24F)
        title_enrollments.ForeColor = Color.White
        title_enrollments.ImeMode = ImeMode.NoControl
        title_enrollments.Location = New Point(16, 21)
        title_enrollments.Name = "title_enrollments"
        title_enrollments.Size = New Size(366, 38)
        title_enrollments.TabIndex = 0
        title_enrollments.Text = "Manage Enrollments"
        title_enrollments.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' enrollmentspanel
        ' 
        enrollmentspanel.Controls.Add(head_enrollments)
        enrollmentspanel.Dock = DockStyle.Fill
        enrollmentspanel.Location = New Point(350, 0)
        enrollmentspanel.Name = "enrollmentspanel"
        enrollmentspanel.Size = New Size(1074, 985)
        enrollmentspanel.TabIndex = 11
        ' 
        ' sidepanel
        ' 
        sidepanel.BackColor = Color.Maroon
        sidepanel.Controls.Add(sidenav)
        sidepanel.Dock = DockStyle.Left
        sidepanel.Location = New Point(0, 0)
        sidepanel.Name = "sidepanel"
        sidepanel.Size = New Size(350, 985)
        sidepanel.TabIndex = 8
        ' 
        ' subjectspanel
        ' 
        subjectspanel.Controls.Add(head_subjects)
        subjectspanel.Dock = DockStyle.Fill
        subjectspanel.Location = New Point(350, 0)
        subjectspanel.Name = "subjectspanel"
        subjectspanel.Size = New Size(1074, 985)
        subjectspanel.TabIndex = 12
        ' 
        ' head_subjects
        ' 
        head_subjects.BackColor = Color.Maroon
        head_subjects.Controls.Add(title_subjects)
        head_subjects.Dock = DockStyle.Top
        head_subjects.Location = New Point(0, 0)
        head_subjects.Name = "head_subjects"
        head_subjects.Size = New Size(1074, 81)
        head_subjects.TabIndex = 0
        ' 
        ' title_subjects
        ' 
        title_subjects.Font = New Font("Tahoma", 24F)
        title_subjects.ForeColor = Color.White
        title_subjects.ImeMode = ImeMode.NoControl
        title_subjects.Location = New Point(16, 21)
        title_subjects.Name = "title_subjects"
        title_subjects.Size = New Size(366, 38)
        title_subjects.TabIndex = 0
        title_subjects.Text = "Manage Subjects"
        title_subjects.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' configurationpanel
        ' 
        configurationpanel.Controls.Add(head_configuration)
        configurationpanel.Dock = DockStyle.Fill
        configurationpanel.Location = New Point(350, 0)
        configurationpanel.Name = "configurationpanel"
        configurationpanel.Size = New Size(1074, 985)
        configurationpanel.TabIndex = 13
        ' 
        ' head_configuration
        ' 
        head_configuration.BackColor = Color.Maroon
        head_configuration.Controls.Add(title_configuration)
        head_configuration.Dock = DockStyle.Top
        head_configuration.Location = New Point(0, 0)
        head_configuration.Name = "head_configuration"
        head_configuration.Size = New Size(1074, 81)
        head_configuration.TabIndex = 0
        ' 
        ' title_configuration
        ' 
        title_configuration.Font = New Font("Tahoma", 24F)
        title_configuration.ForeColor = Color.White
        title_configuration.ImeMode = ImeMode.NoControl
        title_configuration.Location = New Point(16, 21)
        title_configuration.Name = "title_configuration"
        title_configuration.Size = New Size(366, 38)
        title_configuration.TabIndex = 0
        title_configuration.Text = "Configure Database"
        title_configuration.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' admin_frame
        ' 
        AutoScaleDimensions = New SizeF(12F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1424, 985)
        Controls.Add(dashboardpanel)
        Controls.Add(enrollmentspanel)
        Controls.Add(userspanel)
        Controls.Add(subjectspanel)
        Controls.Add(configurationpanel)
        Controls.Add(sidepanel)
        Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5)
        Name = "admin_frame"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin"
        dashboardpanel.ResumeLayout(False)
        head_dashboard.ResumeLayout(False)
        sidenav.ResumeLayout(False)
        header.ResumeLayout(False)
        CType(logo, ComponentModel.ISupportInitialize).EndInit()
        menupanel.ResumeLayout(False)
        subjects.ResumeLayout(False)
        dashboard.ResumeLayout(False)
        users.ResumeLayout(False)
        enrollments.ResumeLayout(False)
        configuration.ResumeLayout(False)
        userspanel.ResumeLayout(False)
        head_users.ResumeLayout(False)
        head_enrollments.ResumeLayout(False)
        enrollmentspanel.ResumeLayout(False)
        sidepanel.ResumeLayout(False)
        subjectspanel.ResumeLayout(False)
        head_subjects.ResumeLayout(False)
        configurationpanel.ResumeLayout(False)
        head_configuration.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents dashboardpanel As Panel
    Friend WithEvents head_dashboard As Panel
    Friend WithEvents title_dashboard As Label
    Friend WithEvents username As Label
    Friend WithEvents sidenav As Panel
    Friend WithEvents header As Panel
    Friend WithEvents title As Label
    Friend WithEvents logo As PictureBox
    Friend WithEvents menupanel As Panel
    Friend WithEvents dashboard As Panel
    Friend WithEvents dashboardbutton As Button
    Friend WithEvents users As Panel
    Friend WithEvents usersbutton As Button
    Friend WithEvents enrollments As Panel
    Friend WithEvents enrollmentsbutton As Button
    Friend WithEvents userspanel As Panel
    Friend WithEvents head_users As Panel
    Friend WithEvents title_users As Label
    Friend WithEvents head_enrollments As Panel
    Friend WithEvents title_enrollments As Label
    Friend WithEvents enrollmentspanel As Panel
    Friend WithEvents sidepanel As Panel
    Friend WithEvents configuration As Panel
    Friend WithEvents configurationbutton As Button
    Friend WithEvents subjects As Panel
    Friend WithEvents subjectsbutton As Button
    Friend WithEvents subjectspanel As Panel
    Friend WithEvents head_subjects As Panel
    Friend WithEvents title_subjects As Label
    Friend WithEvents configurationpanel As Panel
    Friend WithEvents head_configuration As Panel
    Friend WithEvents title_configuration As Label
End Class
