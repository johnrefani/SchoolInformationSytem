<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminframe
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminframe))
        dashboardpanel = New Panel()
        TotalEnroll = New Panel()
        EnrollmentCount = New TextBox()
        TotalEnrollments = New TextBox()
        TotalSub = New Panel()
        SubjectCount = New TextBox()
        TotalSubjects = New TextBox()
        TotalIns = New Panel()
        InstructorsCount = New TextBox()
        TotalInstructors = New TextBox()
        TotalStuds = New Panel()
        StudentsCount = New TextBox()
        TotalStudents = New TextBox()
        head_dashboard = New Panel()
        title_dashboard = New Label()
        username = New Label()
        sidenav = New Panel()
        header = New Panel()
        title = New Label()
        logo = New PictureBox()
        menupanel = New Panel()
        dashboard = New Panel()
        dashboardbutton = New Button()
        users = New Panel()
        usersbutton = New Button()
        enrollments = New Panel()
        enrollmentsbutton = New Button()
        subjects = New Panel()
        subjectsbutton = New Button()
        configuration = New Panel()
        configurationbutton = New Button()
        userspanel = New Panel()
        bodyclassespanel = New Panel()
        Button4 = New Button()
        Button1 = New Button()
        ComboBox3 = New ComboBox()
        TextBox2 = New TextBox()
        adduserbutton = New Button()
        DataGridView2 = New DataGridView()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        head_users = New Panel()
        title_users = New Label()
        head_enrollments = New Panel()
        title_enrollments = New Label()
        enrollmentspanel = New Panel()
        Panel1 = New Panel()
        ComboBox6 = New ComboBox()
        ComboBox5 = New ComboBox()
        Button5 = New Button()
        Button6 = New Button()
        ComboBox4 = New ComboBox()
        TextBox3 = New TextBox()
        Button7 = New Button()
        DataGridView1 = New DataGridView()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        sidepanel = New Panel()
        subjectspanel = New Panel()
        Panel2 = New Panel()
        ComboBox8 = New ComboBox()
        Button8 = New Button()
        Button9 = New Button()
        ComboBox9 = New ComboBox()
        TextBox4 = New TextBox()
        Button10 = New Button()
        DataGridView3 = New DataGridView()
        PictureBox3 = New PictureBox()
        Label2 = New Label()
        head_subjects = New Panel()
        title_subjects = New Label()
        configurationpanel = New Panel()
        Panel3 = New Panel()
        TextBox1 = New TextBox()
        Label3 = New Label()
        TextBox5 = New TextBox()
        Label5 = New Label()
        TextBox6 = New TextBox()
        Label6 = New Label()
        TextBox7 = New TextBox()
        Label7 = New Label()
        studentnametextbox = New TextBox()
        Label8 = New Label()
        Button2 = New Button()
        configurebutton = New Button()
        Label9 = New Label()
        head_configuration = New Panel()
        title_configuration = New Label()
        dashboardpanel.SuspendLayout()
        TotalEnroll.SuspendLayout()
        TotalSub.SuspendLayout()
        TotalIns.SuspendLayout()
        TotalStuds.SuspendLayout()
        head_dashboard.SuspendLayout()
        sidenav.SuspendLayout()
        header.SuspendLayout()
        CType(logo, ComponentModel.ISupportInitialize).BeginInit()
        menupanel.SuspendLayout()
        dashboard.SuspendLayout()
        users.SuspendLayout()
        enrollments.SuspendLayout()
        subjects.SuspendLayout()
        configuration.SuspendLayout()
        userspanel.SuspendLayout()
        bodyclassespanel.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        head_users.SuspendLayout()
        head_enrollments.SuspendLayout()
        enrollmentspanel.SuspendLayout()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        sidepanel.SuspendLayout()
        subjectspanel.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        head_subjects.SuspendLayout()
        configurationpanel.SuspendLayout()
        Panel3.SuspendLayout()
        head_configuration.SuspendLayout()
        SuspendLayout()
        ' 
        ' dashboardpanel
        ' 
        dashboardpanel.Controls.Add(TotalEnroll)
        dashboardpanel.Controls.Add(TotalSub)
        dashboardpanel.Controls.Add(TotalIns)
        dashboardpanel.Controls.Add(TotalStuds)
        dashboardpanel.Controls.Add(head_dashboard)
        dashboardpanel.Dock = DockStyle.Fill
        dashboardpanel.Location = New Point(350, 0)
        dashboardpanel.Name = "dashboardpanel"
        dashboardpanel.Size = New Size(1020, 749)
        dashboardpanel.TabIndex = 9
        ' 
        ' TotalEnroll
        ' 
        TotalEnroll.BackColor = Color.SlateGray
        TotalEnroll.Controls.Add(EnrollmentCount)
        TotalEnroll.Controls.Add(TotalEnrollments)
        TotalEnroll.ForeColor = SystemColors.ControlLightLight
        TotalEnroll.Location = New Point(767, 115)
        TotalEnroll.Name = "TotalEnroll"
        TotalEnroll.Size = New Size(230, 200)
        TotalEnroll.TabIndex = 4
        ' 
        ' EnrollmentCount
        ' 
        EnrollmentCount.BackColor = Color.SlateGray
        EnrollmentCount.BorderStyle = BorderStyle.None
        EnrollmentCount.Font = New Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EnrollmentCount.ForeColor = Color.Gold
        EnrollmentCount.Location = New Point(3, 89)
        EnrollmentCount.Name = "EnrollmentCount"
        EnrollmentCount.Size = New Size(224, 58)
        EnrollmentCount.TabIndex = 1
        EnrollmentCount.Text = "3,120"
        EnrollmentCount.TextAlign = HorizontalAlignment.Center
        ' 
        ' TotalEnrollments
        ' 
        TotalEnrollments.BackColor = Color.SlateGray
        TotalEnrollments.BorderStyle = BorderStyle.None
        TotalEnrollments.Font = New Font("Tahoma", 14F, FontStyle.Bold)
        TotalEnrollments.ForeColor = Color.Gold
        TotalEnrollments.Location = New Point(3, 41)
        TotalEnrollments.Name = "TotalEnrollments"
        TotalEnrollments.Size = New Size(224, 23)
        TotalEnrollments.TabIndex = 0
        TotalEnrollments.Text = "Total Enrollments"
        TotalEnrollments.TextAlign = HorizontalAlignment.Center
        ' 
        ' TotalSub
        ' 
        TotalSub.BackColor = Color.SteelBlue
        TotalSub.Controls.Add(SubjectCount)
        TotalSub.Controls.Add(TotalSubjects)
        TotalSub.ForeColor = SystemColors.ControlLightLight
        TotalSub.Location = New Point(515, 115)
        TotalSub.Name = "TotalSub"
        TotalSub.Size = New Size(230, 200)
        TotalSub.TabIndex = 3
        ' 
        ' SubjectCount
        ' 
        SubjectCount.BackColor = Color.SteelBlue
        SubjectCount.BorderStyle = BorderStyle.None
        SubjectCount.Font = New Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SubjectCount.ForeColor = Color.White
        SubjectCount.Location = New Point(3, 89)
        SubjectCount.Name = "SubjectCount"
        SubjectCount.Size = New Size(224, 58)
        SubjectCount.TabIndex = 1
        SubjectCount.Text = "105"
        SubjectCount.TextAlign = HorizontalAlignment.Center
        ' 
        ' TotalSubjects
        ' 
        TotalSubjects.BackColor = Color.SteelBlue
        TotalSubjects.BorderStyle = BorderStyle.None
        TotalSubjects.Font = New Font("Tahoma", 14F, FontStyle.Bold)
        TotalSubjects.ForeColor = Color.White
        TotalSubjects.Location = New Point(3, 41)
        TotalSubjects.Name = "TotalSubjects"
        TotalSubjects.Size = New Size(224, 23)
        TotalSubjects.TabIndex = 0
        TotalSubjects.Text = "Total Subjects"
        TotalSubjects.TextAlign = HorizontalAlignment.Center
        ' 
        ' TotalIns
        ' 
        TotalIns.BackColor = Color.Silver
        TotalIns.Controls.Add(InstructorsCount)
        TotalIns.Controls.Add(TotalInstructors)
        TotalIns.ForeColor = Color.WhiteSmoke
        TotalIns.Location = New Point(265, 115)
        TotalIns.Name = "TotalIns"
        TotalIns.Size = New Size(230, 200)
        TotalIns.TabIndex = 2
        ' 
        ' InstructorsCount
        ' 
        InstructorsCount.BackColor = Color.Silver
        InstructorsCount.BorderStyle = BorderStyle.None
        InstructorsCount.Font = New Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        InstructorsCount.ForeColor = Color.DarkRed
        InstructorsCount.Location = New Point(3, 89)
        InstructorsCount.Name = "InstructorsCount"
        InstructorsCount.Size = New Size(224, 58)
        InstructorsCount.TabIndex = 1
        InstructorsCount.Text = "38"
        InstructorsCount.TextAlign = HorizontalAlignment.Center
        ' 
        ' TotalInstructors
        ' 
        TotalInstructors.BackColor = Color.Silver
        TotalInstructors.BorderStyle = BorderStyle.None
        TotalInstructors.Font = New Font("Tahoma", 14F, FontStyle.Bold)
        TotalInstructors.ForeColor = Color.DarkRed
        TotalInstructors.Location = New Point(3, 41)
        TotalInstructors.Name = "TotalInstructors"
        TotalInstructors.Size = New Size(224, 23)
        TotalInstructors.TabIndex = 0
        TotalInstructors.Text = "Total Instructors"
        TotalInstructors.TextAlign = HorizontalAlignment.Center
        ' 
        ' TotalStuds
        ' 
        TotalStuds.BackColor = Color.Gold
        TotalStuds.Controls.Add(StudentsCount)
        TotalStuds.Controls.Add(TotalStudents)
        TotalStuds.ForeColor = SystemColors.ControlLightLight
        TotalStuds.Location = New Point(16, 115)
        TotalStuds.Name = "TotalStuds"
        TotalStuds.Size = New Size(230, 200)
        TotalStuds.TabIndex = 1
        ' 
        ' StudentsCount
        ' 
        StudentsCount.BackColor = Color.Gold
        StudentsCount.BorderStyle = BorderStyle.None
        StudentsCount.Font = New Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StudentsCount.ForeColor = Color.DarkRed
        StudentsCount.Location = New Point(3, 89)
        StudentsCount.Name = "StudentsCount"
        StudentsCount.Size = New Size(224, 58)
        StudentsCount.TabIndex = 1
        StudentsCount.Text = "3,120"
        StudentsCount.TextAlign = HorizontalAlignment.Center
        ' 
        ' TotalStudents
        ' 
        TotalStudents.BackColor = Color.Gold
        TotalStudents.BorderStyle = BorderStyle.None
        TotalStudents.Font = New Font("Tahoma", 14F, FontStyle.Bold)
        TotalStudents.ForeColor = Color.DarkRed
        TotalStudents.Location = New Point(3, 41)
        TotalStudents.Name = "TotalStudents"
        TotalStudents.Size = New Size(224, 23)
        TotalStudents.TabIndex = 0
        TotalStudents.Text = "Total Students"
        TotalStudents.TextAlign = HorizontalAlignment.Center
        ' 
        ' head_dashboard
        ' 
        head_dashboard.BackColor = Color.Maroon
        head_dashboard.Controls.Add(title_dashboard)
        head_dashboard.Controls.Add(username)
        head_dashboard.Dock = DockStyle.Top
        head_dashboard.Location = New Point(0, 0)
        head_dashboard.Name = "head_dashboard"
        head_dashboard.Size = New Size(1020, 94)
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
        username.Text = "Admin"
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
        menupanel.Controls.Add(dashboard)
        menupanel.Controls.Add(users)
        menupanel.Controls.Add(enrollments)
        menupanel.Controls.Add(subjects)
        menupanel.Controls.Add(configuration)
        menupanel.Dock = DockStyle.Fill
        menupanel.Location = New Point(0, 0)
        menupanel.Name = "menupanel"
        menupanel.Size = New Size(300, 580)
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
        userspanel.Controls.Add(bodyclassespanel)
        userspanel.Controls.Add(head_users)
        userspanel.Dock = DockStyle.Fill
        userspanel.Location = New Point(350, 0)
        userspanel.Name = "userspanel"
        userspanel.Size = New Size(1020, 749)
        userspanel.TabIndex = 10
        ' 
        ' bodyclassespanel
        ' 
        bodyclassespanel.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        bodyclassespanel.Controls.Add(Button4)
        bodyclassespanel.Controls.Add(Button1)
        bodyclassespanel.Controls.Add(ComboBox3)
        bodyclassespanel.Controls.Add(TextBox2)
        bodyclassespanel.Controls.Add(adduserbutton)
        bodyclassespanel.Controls.Add(DataGridView2)
        bodyclassespanel.Controls.Add(PictureBox1)
        bodyclassespanel.Controls.Add(Label4)
        bodyclassespanel.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bodyclassespanel.Location = New Point(25, 121)
        bodyclassespanel.Name = "bodyclassespanel"
        bodyclassespanel.Size = New Size(1024, 850)
        bodyclassespanel.TabIndex = 2
        ' 
        ' Button4
        ' 
        Button4.AutoSize = True
        Button4.Location = New Point(766, 26)
        Button4.Name = "Button4"
        Button4.Size = New Size(98, 35)
        Button4.TabIndex = 13
        Button4.Text = "EXPORT"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.AutoSize = True
        Button1.Location = New Point(654, 26)
        Button1.Name = "Button1"
        Button1.Size = New Size(95, 35)
        Button1.TabIndex = 12
        Button1.Text = "PRINT"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(882, 85)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(121, 33)
        ComboBox3.TabIndex = 11
        ComboBox3.Text = "Role"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(61, 79)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(358, 33)
        TextBox2.TabIndex = 10
        TextBox2.Text = "Search"
        ' 
        ' adduserbutton
        ' 
        adduserbutton.AutoSize = True
        adduserbutton.BackColor = Color.FromArgb(CByte(35), CByte(50), CByte(85))
        adduserbutton.Cursor = Cursors.Hand
        adduserbutton.FlatAppearance.BorderSize = 0
        adduserbutton.FlatStyle = FlatStyle.Flat
        adduserbutton.ForeColor = Color.White
        adduserbutton.Location = New Point(881, 26)
        adduserbutton.Name = "adduserbutton"
        adduserbutton.Size = New Size(121, 35)
        adduserbutton.TabIndex = 9
        adduserbutton.Text = "ADD USER"
        adduserbutton.UseVisualStyleBackColor = False
        ' 
        ' DataGridView2
        ' 
        DataGridView2.BackgroundColor = Color.White
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(23, 133)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(981, 698)
        DataGridView2.TabIndex = 8
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(23, 79)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(32, 33)
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(23, 19)
        Label4.Name = "Label4"
        Label4.Size = New Size(172, 39)
        Label4.TabIndex = 0
        Label4.Text = "Users List"
        ' 
        ' head_users
        ' 
        head_users.BackColor = Color.Maroon
        head_users.Controls.Add(title_users)
        head_users.Dock = DockStyle.Top
        head_users.Location = New Point(0, 0)
        head_users.Name = "head_users"
        head_users.Size = New Size(1020, 94)
        head_users.TabIndex = 0
        ' 
        ' title_users
        ' 
        title_users.Font = New Font("Tahoma", 24F)
        title_users.ForeColor = Color.White
        title_users.ImeMode = ImeMode.NoControl
        title_users.Location = New Point(16, 28)
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
        head_enrollments.Size = New Size(1020, 94)
        head_enrollments.TabIndex = 0
        ' 
        ' title_enrollments
        ' 
        title_enrollments.Font = New Font("Tahoma", 24F)
        title_enrollments.ForeColor = Color.White
        title_enrollments.ImeMode = ImeMode.NoControl
        title_enrollments.Location = New Point(16, 28)
        title_enrollments.Name = "title_enrollments"
        title_enrollments.Size = New Size(366, 38)
        title_enrollments.TabIndex = 0
        title_enrollments.Text = "Manage Enrollments"
        title_enrollments.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' enrollmentspanel
        ' 
        enrollmentspanel.Controls.Add(Panel1)
        enrollmentspanel.Controls.Add(head_enrollments)
        enrollmentspanel.Dock = DockStyle.Fill
        enrollmentspanel.Location = New Point(350, 0)
        enrollmentspanel.Name = "enrollmentspanel"
        enrollmentspanel.Size = New Size(1020, 749)
        enrollmentspanel.TabIndex = 11
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        Panel1.Controls.Add(ComboBox6)
        Panel1.Controls.Add(ComboBox5)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(ComboBox4)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(Button7)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Label1)
        Panel1.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel1.Location = New Point(25, 118)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1024, 850)
        Panel1.TabIndex = 3
        ' 
        ' ComboBox6
        ' 
        ComboBox6.FormattingEnabled = True
        ComboBox6.Location = New Point(577, 85)
        ComboBox6.Name = "ComboBox6"
        ComboBox6.Size = New Size(146, 33)
        ComboBox6.TabIndex = 15
        ComboBox6.Text = "School Year"
        ' 
        ' ComboBox5
        ' 
        ComboBox5.FormattingEnabled = True
        ComboBox5.Location = New Point(742, 85)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(121, 33)
        ComboBox5.TabIndex = 14
        ComboBox5.Text = "Status"
        ' 
        ' Button5
        ' 
        Button5.AutoSize = True
        Button5.Location = New Point(726, 29)
        Button5.Name = "Button5"
        Button5.Size = New Size(98, 35)
        Button5.TabIndex = 13
        Button5.Text = "EXPORT"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.AutoSize = True
        Button6.Location = New Point(608, 29)
        Button6.Name = "Button6"
        Button6.Size = New Size(95, 35)
        Button6.TabIndex = 12
        Button6.Text = "PRINT"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(882, 85)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(121, 33)
        ComboBox4.TabIndex = 11
        ComboBox4.Text = "Role"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(61, 79)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(358, 33)
        TextBox3.TabIndex = 10
        TextBox3.Text = "Search"
        ' 
        ' Button7
        ' 
        Button7.AutoSize = True
        Button7.BackColor = Color.FromArgb(CByte(35), CByte(50), CByte(85))
        Button7.Cursor = Cursors.Hand
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatStyle = FlatStyle.Flat
        Button7.ForeColor = Color.White
        Button7.Location = New Point(847, 29)
        Button7.Name = "Button7"
        Button7.Size = New Size(156, 35)
        Button7.TabIndex = 9
        Button7.Text = "ADD ENROLLE"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(23, 133)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(981, 698)
        DataGridView1.TabIndex = 8
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(23, 79)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(32, 33)
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(23, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(276, 39)
        Label1.TabIndex = 0
        Label1.Text = "Enrollments List"
        ' 
        ' sidepanel
        ' 
        sidepanel.BackColor = Color.Maroon
        sidepanel.Controls.Add(sidenav)
        sidepanel.Dock = DockStyle.Left
        sidepanel.Location = New Point(0, 0)
        sidepanel.Name = "sidepanel"
        sidepanel.Size = New Size(350, 749)
        sidepanel.TabIndex = 8
        ' 
        ' subjectspanel
        ' 
        subjectspanel.Controls.Add(Panel2)
        subjectspanel.Controls.Add(head_subjects)
        subjectspanel.Dock = DockStyle.Fill
        subjectspanel.Location = New Point(350, 0)
        subjectspanel.Name = "subjectspanel"
        subjectspanel.Size = New Size(1020, 749)
        subjectspanel.TabIndex = 12
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        Panel2.Controls.Add(ComboBox8)
        Panel2.Controls.Add(Button8)
        Panel2.Controls.Add(Button9)
        Panel2.Controls.Add(ComboBox9)
        Panel2.Controls.Add(TextBox4)
        Panel2.Controls.Add(Button10)
        Panel2.Controls.Add(DataGridView3)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Controls.Add(Label2)
        Panel2.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel2.Location = New Point(25, 115)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1024, 850)
        Panel2.TabIndex = 4
        ' 
        ' ComboBox8
        ' 
        ComboBox8.FormattingEnabled = True
        ComboBox8.Location = New Point(685, 85)
        ComboBox8.Name = "ComboBox8"
        ComboBox8.Size = New Size(139, 33)
        ComboBox8.TabIndex = 14
        ComboBox8.Text = "Department"
        ' 
        ' Button8
        ' 
        Button8.AutoSize = True
        Button8.Location = New Point(726, 29)
        Button8.Name = "Button8"
        Button8.Size = New Size(98, 35)
        Button8.TabIndex = 13
        Button8.Text = "EXPORT"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.AutoSize = True
        Button9.Location = New Point(608, 29)
        Button9.Name = "Button9"
        Button9.Size = New Size(95, 35)
        Button9.TabIndex = 12
        Button9.Text = "PRINT"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' ComboBox9
        ' 
        ComboBox9.FormattingEnabled = True
        ComboBox9.Location = New Point(847, 85)
        ComboBox9.Name = "ComboBox9"
        ComboBox9.Size = New Size(156, 33)
        ComboBox9.TabIndex = 11
        ComboBox9.Text = "Grade Level"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(61, 79)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(358, 33)
        TextBox4.TabIndex = 10
        TextBox4.Text = "Search"
        ' 
        ' Button10
        ' 
        Button10.AutoSize = True
        Button10.BackColor = Color.FromArgb(CByte(35), CByte(50), CByte(85))
        Button10.Cursor = Cursors.Hand
        Button10.FlatAppearance.BorderSize = 0
        Button10.FlatStyle = FlatStyle.Flat
        Button10.ForeColor = Color.White
        Button10.Location = New Point(847, 29)
        Button10.Name = "Button10"
        Button10.Size = New Size(156, 35)
        Button10.TabIndex = 9
        Button10.Text = "ADD SUBJECT"
        Button10.UseVisualStyleBackColor = False
        ' 
        ' DataGridView3
        ' 
        DataGridView3.BackgroundColor = Color.White
        DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView3.Location = New Point(23, 133)
        DataGridView3.Name = "DataGridView3"
        DataGridView3.Size = New Size(981, 698)
        DataGridView3.TabIndex = 8
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(23, 79)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(32, 33)
        PictureBox3.TabIndex = 5
        PictureBox3.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(23, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(220, 39)
        Label2.TabIndex = 0
        Label2.Text = "Subjects List"
        ' 
        ' head_subjects
        ' 
        head_subjects.BackColor = Color.Maroon
        head_subjects.Controls.Add(title_subjects)
        head_subjects.Dock = DockStyle.Top
        head_subjects.Location = New Point(0, 0)
        head_subjects.Name = "head_subjects"
        head_subjects.Size = New Size(1020, 94)
        head_subjects.TabIndex = 0
        ' 
        ' title_subjects
        ' 
        title_subjects.Font = New Font("Tahoma", 24F)
        title_subjects.ForeColor = Color.White
        title_subjects.ImeMode = ImeMode.NoControl
        title_subjects.Location = New Point(16, 28)
        title_subjects.Name = "title_subjects"
        title_subjects.Size = New Size(366, 38)
        title_subjects.TabIndex = 0
        title_subjects.Text = "Manage Subjects"
        title_subjects.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' configurationpanel
        ' 
        configurationpanel.Controls.Add(Panel3)
        configurationpanel.Controls.Add(head_configuration)
        configurationpanel.Dock = DockStyle.Fill
        configurationpanel.Location = New Point(350, 0)
        configurationpanel.Name = "configurationpanel"
        configurationpanel.Size = New Size(1020, 749)
        configurationpanel.TabIndex = 13
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(TextBox1)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(TextBox5)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(TextBox6)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(TextBox7)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(studentnametextbox)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(configurebutton)
        Panel3.Controls.Add(Label9)
        Panel3.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel3.Location = New Point(25, 124)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1024, 357)
        Panel3.TabIndex = 5
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(327, 230)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(250, 33)
        TextBox1.TabIndex = 153
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(327, 192)
        Label3.Name = "Label3"
        Label3.Size = New Size(122, 25)
        Label3.TabIndex = 152
        Label3.Text = "PASSWORD"
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        TextBox5.BorderStyle = BorderStyle.FixedSingle
        TextBox5.Location = New Point(34, 230)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(250, 33)
        TextBox5.TabIndex = 151
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(34, 192)
        Label5.Name = "Label5"
        Label5.Size = New Size(118, 25)
        Label5.TabIndex = 150
        Label5.Text = "USERNAME"
        ' 
        ' TextBox6
        ' 
        TextBox6.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        TextBox6.BorderStyle = BorderStyle.FixedSingle
        TextBox6.Location = New Point(612, 129)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(250, 33)
        TextBox6.TabIndex = 149
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(612, 91)
        Label6.Name = "Label6"
        Label6.Size = New Size(176, 25)
        Label6.TabIndex = 148
        Label6.Text = "DATABASE NAME"
        ' 
        ' TextBox7
        ' 
        TextBox7.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        TextBox7.BorderStyle = BorderStyle.FixedSingle
        TextBox7.Location = New Point(327, 129)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(250, 33)
        TextBox7.TabIndex = 147
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(327, 91)
        Label7.Name = "Label7"
        Label7.Size = New Size(64, 25)
        Label7.TabIndex = 146
        Label7.Text = "PORT"
        ' 
        ' studentnametextbox
        ' 
        studentnametextbox.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        studentnametextbox.BorderStyle = BorderStyle.FixedSingle
        studentnametextbox.Location = New Point(34, 129)
        studentnametextbox.Name = "studentnametextbox"
        studentnametextbox.Size = New Size(250, 33)
        studentnametextbox.TabIndex = 145
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(34, 91)
        Label8.Name = "Label8"
        Label8.Size = New Size(184, 25)
        Label8.TabIndex = 144
        Label8.Text = "SERVER ADDRESS"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(127), CByte(189), CByte(228))
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.White
        Button2.Location = New Point(742, 20)
        Button2.Name = "Button2"
        Button2.Size = New Size(98, 35)
        Button2.TabIndex = 143
        Button2.Text = "TEST"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' configurebutton
        ' 
        configurebutton.BackColor = Color.FromArgb(CByte(35), CByte(50), CByte(85))
        configurebutton.Cursor = Cursors.Hand
        configurebutton.FlatAppearance.BorderSize = 0
        configurebutton.FlatStyle = FlatStyle.Flat
        configurebutton.ForeColor = Color.White
        configurebutton.Location = New Point(859, 20)
        configurebutton.Name = "configurebutton"
        configurebutton.Size = New Size(141, 35)
        configurebutton.TabIndex = 141
        configurebutton.Text = "CONFIGURE"
        configurebutton.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(23, 20)
        Label9.Name = "Label9"
        Label9.Size = New Size(490, 39)
        Label9.TabIndex = 140
        Label9.Text = "Manage Database Connection"
        ' 
        ' head_configuration
        ' 
        head_configuration.BackColor = Color.Maroon
        head_configuration.Controls.Add(title_configuration)
        head_configuration.Dock = DockStyle.Top
        head_configuration.Location = New Point(0, 0)
        head_configuration.Name = "head_configuration"
        head_configuration.Size = New Size(1020, 94)
        head_configuration.TabIndex = 0
        ' 
        ' title_configuration
        ' 
        title_configuration.Font = New Font("Tahoma", 24F)
        title_configuration.ForeColor = Color.White
        title_configuration.ImeMode = ImeMode.NoControl
        title_configuration.Location = New Point(16, 28)
        title_configuration.Name = "title_configuration"
        title_configuration.Size = New Size(366, 38)
        title_configuration.TabIndex = 0
        title_configuration.Text = "Configure Database"
        title_configuration.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' adminframe
        ' 
        AutoScaleDimensions = New SizeF(12F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1370, 749)
        Controls.Add(dashboardpanel)
        Controls.Add(configurationpanel)
        Controls.Add(subjectspanel)
        Controls.Add(enrollmentspanel)
        Controls.Add(userspanel)
        Controls.Add(sidepanel)
        Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5)
        MaximizeBox = False
        Name = "adminframe"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin"
        dashboardpanel.ResumeLayout(False)
        TotalEnroll.ResumeLayout(False)
        TotalEnroll.PerformLayout()
        TotalSub.ResumeLayout(False)
        TotalSub.PerformLayout()
        TotalIns.ResumeLayout(False)
        TotalIns.PerformLayout()
        TotalStuds.ResumeLayout(False)
        TotalStuds.PerformLayout()
        head_dashboard.ResumeLayout(False)
        sidenav.ResumeLayout(False)
        header.ResumeLayout(False)
        CType(logo, ComponentModel.ISupportInitialize).EndInit()
        menupanel.ResumeLayout(False)
        dashboard.ResumeLayout(False)
        users.ResumeLayout(False)
        enrollments.ResumeLayout(False)
        subjects.ResumeLayout(False)
        configuration.ResumeLayout(False)
        userspanel.ResumeLayout(False)
        bodyclassespanel.ResumeLayout(False)
        bodyclassespanel.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        head_users.ResumeLayout(False)
        head_enrollments.ResumeLayout(False)
        enrollmentspanel.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        sidepanel.ResumeLayout(False)
        subjectspanel.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        head_subjects.ResumeLayout(False)
        configurationpanel.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
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
    Friend WithEvents bodyclassespanel As Panel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents adduserbutton As Button
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ComboBox8 As ComboBox
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents ComboBox9 As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button10 As Button
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents studentnametextbox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents configurebutton As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents TotalStuds As Panel
    Friend WithEvents TotalStudents As TextBox
    Friend WithEvents TotalIns As Panel
    Friend WithEvents InstructorsCount As TextBox
    Friend WithEvents TotalInstructors As TextBox
    Friend WithEvents StudentsCount As TextBox
    Friend WithEvents TotalEnroll As Panel
    Friend WithEvents EnrollmentCount As TextBox
    Friend WithEvents TotalEnrollments As TextBox
    Friend WithEvents TotalSub As Panel
    Friend WithEvents SubjectCount As TextBox
    Friend WithEvents TotalSubjects As TextBox
End Class
