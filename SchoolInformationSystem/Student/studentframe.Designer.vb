<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class studentframe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(studentframe))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        title_myprofile = New Label()
        myprofilepanel = New Panel()
        Panel3 = New Panel()
        student_birthplace = New Label()
        Label17 = New Label()
        student_religion = New Label()
        student_guardian = New Label()
        student_nationality = New Label()
        student_grade = New Label()
        student_address = New Label()
        student_email = New Label()
        student_contact = New Label()
        student_age = New Label()
        student_gender = New Label()
        student_fullname = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        editprofile = New Button()
        head_myprofile = New Panel()
        title_classes = New Label()
        menupanel = New Panel()
        dashboard = New Panel()
        dashboardbutton = New Button()
        classes = New Panel()
        classesbutton = New Button()
        myprofile = New Panel()
        myprofilebutton = New Button()
        header = New Panel()
        title = New Label()
        logo = New PictureBox()
        head_classes = New Panel()
        classespanel = New Panel()
        Panel2 = New Panel()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        schoolyear = New ComboBox()
        status = New ComboBox()
        PictureBox1 = New PictureBox()
        TextBox1 = New TextBox()
        print_button = New Button()
        title_dashboard = New Label()
        student_name = New Label()
        head_dashboard = New Panel()
        sidenav = New Panel()
        sidepanel = New Panel()
        logoutpanel = New Panel()
        logoutbutton = New Button()
        dashboardpanel = New Panel()
        Panel1 = New Panel()
        Label3 = New Label()
        schedule_panel = New Panel()
        ScheduleDataGrid = New DataGridView()
        Label2 = New Label()
        subject_panel = New Panel()
        StudBarChart = New DataVisualization.Charting.Chart()
        enrolldatagrid = New DataGridView()
        myprofilepanel.SuspendLayout()
        Panel3.SuspendLayout()
        head_myprofile.SuspendLayout()
        menupanel.SuspendLayout()
        dashboard.SuspendLayout()
        classes.SuspendLayout()
        myprofile.SuspendLayout()
        header.SuspendLayout()
        CType(logo, ComponentModel.ISupportInitialize).BeginInit()
        head_classes.SuspendLayout()
        classespanel.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        head_dashboard.SuspendLayout()
        sidenav.SuspendLayout()
        sidepanel.SuspendLayout()
        logoutpanel.SuspendLayout()
        dashboardpanel.SuspendLayout()
        Panel1.SuspendLayout()
        schedule_panel.SuspendLayout()
        CType(ScheduleDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        subject_panel.SuspendLayout()
        CType(StudBarChart, ComponentModel.ISupportInitialize).BeginInit()
        CType(enrolldatagrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' title_myprofile
        ' 
        title_myprofile.Font = New Font("Tahoma", 24F)
        title_myprofile.ForeColor = Color.White
        title_myprofile.ImeMode = ImeMode.NoControl
        title_myprofile.Location = New Point(16, 21)
        title_myprofile.Name = "title_myprofile"
        title_myprofile.Size = New Size(366, 38)
        title_myprofile.TabIndex = 0
        title_myprofile.Text = "My Profile"
        title_myprofile.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' myprofilepanel
        ' 
        myprofilepanel.BackColor = Color.Gainsboro
        myprofilepanel.Controls.Add(Panel3)
        myprofilepanel.Controls.Add(head_myprofile)
        myprofilepanel.Dock = DockStyle.Fill
        myprofilepanel.Location = New Point(350, 0)
        myprofilepanel.Name = "myprofilepanel"
        myprofilepanel.Size = New Size(1020, 749)
        myprofilepanel.TabIndex = 7
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(student_birthplace)
        Panel3.Controls.Add(Label17)
        Panel3.Controls.Add(student_religion)
        Panel3.Controls.Add(student_guardian)
        Panel3.Controls.Add(student_nationality)
        Panel3.Controls.Add(student_grade)
        Panel3.Controls.Add(student_address)
        Panel3.Controls.Add(student_email)
        Panel3.Controls.Add(student_contact)
        Panel3.Controls.Add(student_age)
        Panel3.Controls.Add(student_gender)
        Panel3.Controls.Add(student_fullname)
        Panel3.Controls.Add(Label14)
        Panel3.Controls.Add(Label13)
        Panel3.Controls.Add(Label12)
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(editprofile)
        Panel3.Location = New Point(41, 103)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(992, 523)
        Panel3.TabIndex = 1
        ' 
        ' student_birthplace
        ' 
        student_birthplace.AutoSize = True
        student_birthplace.Font = New Font("Tahoma", 15.75F)
        student_birthplace.Location = New Point(370, 299)
        student_birthplace.Name = "student_birthplace"
        student_birthplace.Size = New Size(140, 25)
        student_birthplace.TabIndex = 35
        student_birthplace.Text = "Barangay 456"
        student_birthplace.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Tahoma", 14.25F)
        Label17.Location = New Point(370, 271)
        Label17.Name = "Label17"
        Label17.Size = New Size(116, 23)
        Label17.TabIndex = 34
        Label17.Text = "BIRTHPLACE"
        Label17.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' student_religion
        ' 
        student_religion.AutoSize = True
        student_religion.Font = New Font("Tahoma", 15.75F)
        student_religion.Location = New Point(370, 405)
        student_religion.Name = "student_religion"
        student_religion.Size = New Size(158, 25)
        student_religion.TabIndex = 33
        student_religion.Text = "Roman Catholic"
        student_religion.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' student_guardian
        ' 
        student_guardian.AutoSize = True
        student_guardian.Font = New Font("Tahoma", 15.75F)
        student_guardian.Location = New Point(43, 405)
        student_guardian.Name = "student_guardian"
        student_guardian.Size = New Size(197, 25)
        student_guardian.TabIndex = 32
        student_guardian.Text = "Dela Cruz, Dante D."
        student_guardian.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' student_nationality
        ' 
        student_nationality.AutoSize = True
        student_nationality.Font = New Font("Tahoma", 15.75F)
        student_nationality.Location = New Point(720, 299)
        student_nationality.Name = "student_nationality"
        student_nationality.Size = New Size(100, 25)
        student_nationality.TabIndex = 31
        student_nationality.Text = "American"
        student_nationality.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' student_grade
        ' 
        student_grade.AutoSize = True
        student_grade.Font = New Font("Tahoma", 15.75F)
        student_grade.Location = New Point(43, 299)
        student_grade.Name = "student_grade"
        student_grade.Size = New Size(86, 25)
        student_grade.TabIndex = 29
        student_grade.Text = "1st year"
        student_grade.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' student_address
        ' 
        student_address.AutoSize = True
        student_address.Font = New Font("Tahoma", 15.75F)
        student_address.Location = New Point(370, 196)
        student_address.Name = "student_address"
        student_address.Size = New Size(140, 25)
        student_address.TabIndex = 28
        student_address.Text = "Barangay 143"
        student_address.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' student_email
        ' 
        student_email.AutoSize = True
        student_email.Font = New Font("Tahoma", 15.75F)
        student_email.Location = New Point(43, 196)
        student_email.Name = "student_email"
        student_email.Size = New Size(205, 25)
        student_email.TabIndex = 27
        student_email.Text = "delacruz@gmail.com"
        student_email.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' student_contact
        ' 
        student_contact.AutoSize = True
        student_contact.Font = New Font("Tahoma", 15.75F)
        student_contact.Location = New Point(720, 97)
        student_contact.Name = "student_contact"
        student_contact.Size = New Size(133, 25)
        student_contact.TabIndex = 26
        student_contact.Text = "09123456789"
        student_contact.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' student_age
        ' 
        student_age.AutoSize = True
        student_age.Font = New Font("Tahoma", 15.75F)
        student_age.Location = New Point(558, 97)
        student_age.Name = "student_age"
        student_age.Size = New Size(34, 25)
        student_age.TabIndex = 25
        student_age.Text = "22"
        student_age.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' student_gender
        ' 
        student_gender.AutoSize = True
        student_gender.Font = New Font("Tahoma", 15.75F)
        student_gender.Location = New Point(370, 97)
        student_gender.Name = "student_gender"
        student_gender.Size = New Size(55, 25)
        student_gender.TabIndex = 24
        student_gender.Text = "Male"
        student_gender.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' student_fullname
        ' 
        student_fullname.AutoSize = True
        student_fullname.Font = New Font("Tahoma", 15.75F)
        student_fullname.Location = New Point(43, 97)
        student_fullname.Name = "student_fullname"
        student_fullname.Size = New Size(184, 25)
        student_fullname.TabIndex = 23
        student_fullname.Text = "Dela Cruz, Juan P."
        student_fullname.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Tahoma", 14.25F)
        Label14.Location = New Point(370, 376)
        Label14.Name = "Label14"
        Label14.Size = New Size(95, 23)
        Label14.TabIndex = 22
        Label14.Text = "RELIGION"
        Label14.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Tahoma", 14.25F)
        Label13.Location = New Point(43, 376)
        Label13.Name = "Label13"
        Label13.Size = New Size(158, 23)
        Label13.TabIndex = 21
        Label13.Text = "GUARDIAN NAME"
        Label13.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Tahoma", 14.25F)
        Label12.Location = New Point(720, 271)
        Label12.Name = "Label12"
        Label12.Size = New Size(127, 23)
        Label12.TabIndex = 20
        Label12.Text = "NATIONALITY"
        Label12.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Tahoma", 14.25F)
        Label10.Location = New Point(43, 271)
        Label10.Name = "Label10"
        Label10.Size = New Size(127, 23)
        Label10.TabIndex = 17
        Label10.Text = "GRADE LEVEL"
        Label10.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Tahoma", 14.25F)
        Label9.Location = New Point(370, 168)
        Label9.Name = "Label9"
        Label9.Size = New Size(92, 23)
        Label9.TabIndex = 16
        Label9.Text = "ADDRESS"
        Label9.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Tahoma", 14.25F)
        Label8.Location = New Point(43, 168)
        Label8.Name = "Label8"
        Label8.Size = New Size(151, 23)
        Label8.TabIndex = 15
        Label8.Text = "EMAIL ADDRESS"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 14.25F)
        Label7.Location = New Point(720, 66)
        Label7.Name = "Label7"
        Label7.Size = New Size(171, 23)
        Label7.TabIndex = 14
        Label7.Text = "CONTACT NUMBER"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 14.25F)
        Label6.Location = New Point(558, 66)
        Label6.Name = "Label6"
        Label6.Size = New Size(45, 23)
        Label6.TabIndex = 13
        Label6.Text = "AGE"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 14.25F)
        Label5.Location = New Point(370, 66)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 23)
        Label5.TabIndex = 12
        Label5.Text = "GENDER"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 14.25F)
        Label4.Location = New Point(43, 66)
        Label4.Name = "Label4"
        Label4.Size = New Size(106, 23)
        Label4.TabIndex = 2
        Label4.Text = "FULL NAME"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' editprofile
        ' 
        editprofile.BackColor = Color.FromArgb(CByte(35), CByte(50), CByte(85))
        editprofile.Font = New Font("Tahoma", 15.75F)
        editprofile.ForeColor = SystemColors.ControlLightLight
        editprofile.Location = New Point(800, 16)
        editprofile.Name = "editprofile"
        editprofile.Size = New Size(169, 36)
        editprofile.TabIndex = 0
        editprofile.Text = "EDIT PROFILE"
        editprofile.UseVisualStyleBackColor = False
        ' 
        ' head_myprofile
        ' 
        head_myprofile.BackColor = Color.Maroon
        head_myprofile.Controls.Add(title_myprofile)
        head_myprofile.Dock = DockStyle.Top
        head_myprofile.Location = New Point(0, 0)
        head_myprofile.Name = "head_myprofile"
        head_myprofile.Size = New Size(1020, 81)
        head_myprofile.TabIndex = 0
        ' 
        ' title_classes
        ' 
        title_classes.Font = New Font("Tahoma", 24F)
        title_classes.ForeColor = Color.White
        title_classes.ImeMode = ImeMode.NoControl
        title_classes.Location = New Point(16, 21)
        title_classes.Name = "title_classes"
        title_classes.Size = New Size(366, 38)
        title_classes.TabIndex = 0
        title_classes.Text = "My Classes"
        title_classes.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' menupanel
        ' 
        menupanel.Controls.Add(dashboard)
        menupanel.Controls.Add(classes)
        menupanel.Controls.Add(myprofile)
        menupanel.Dock = DockStyle.Fill
        menupanel.Location = New Point(0, 0)
        menupanel.Name = "menupanel"
        menupanel.Size = New Size(300, 500)
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
        ' classes
        ' 
        classes.BackgroundImageLayout = ImageLayout.None
        classes.Controls.Add(classesbutton)
        classes.Cursor = Cursors.Hand
        classes.ForeColor = SystemColors.ControlText
        classes.Location = New Point(3, 185)
        classes.Name = "classes"
        classes.Size = New Size(294, 56)
        classes.TabIndex = 1
        ' 
        ' classesbutton
        ' 
        classesbutton.BackColor = Color.Maroon
        classesbutton.Cursor = Cursors.Hand
        classesbutton.Dock = DockStyle.Fill
        classesbutton.FlatAppearance.BorderSize = 0
        classesbutton.FlatStyle = FlatStyle.Flat
        classesbutton.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        classesbutton.ForeColor = Color.WhiteSmoke
        classesbutton.Image = CType(resources.GetObject("classesbutton.Image"), Image)
        classesbutton.ImageAlign = ContentAlignment.MiddleLeft
        classesbutton.ImeMode = ImeMode.NoControl
        classesbutton.Location = New Point(0, 0)
        classesbutton.Name = "classesbutton"
        classesbutton.Size = New Size(294, 56)
        classesbutton.TabIndex = 0
        classesbutton.Text = "       Enrollment"
        classesbutton.TextAlign = ContentAlignment.MiddleLeft
        classesbutton.UseVisualStyleBackColor = False
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
        myprofilebutton.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        myprofilebutton.ForeColor = Color.White
        myprofilebutton.Image = CType(resources.GetObject("myprofilebutton.Image"), Image)
        myprofilebutton.ImageAlign = ContentAlignment.MiddleLeft
        myprofilebutton.ImeMode = ImeMode.NoControl
        myprofilebutton.Location = New Point(0, 0)
        myprofilebutton.Name = "myprofilebutton"
        myprofilebutton.Size = New Size(294, 56)
        myprofilebutton.TabIndex = 0
        myprofilebutton.Text = "       My Profile"
        myprofilebutton.TextAlign = ContentAlignment.MiddleLeft
        myprofilebutton.UseVisualStyleBackColor = False
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
        logo.BackColor = Color.Transparent
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
        ' head_classes
        ' 
        head_classes.BackColor = Color.Maroon
        head_classes.Controls.Add(title_classes)
        head_classes.Dock = DockStyle.Top
        head_classes.Location = New Point(0, 0)
        head_classes.Name = "head_classes"
        head_classes.Size = New Size(1020, 81)
        head_classes.TabIndex = 0
        ' 
        ' classespanel
        ' 
        classespanel.BackColor = Color.Gainsboro
        classespanel.Controls.Add(Panel2)
        classespanel.Controls.Add(head_classes)
        classespanel.Dock = DockStyle.Fill
        classespanel.Location = New Point(350, 0)
        classespanel.Name = "classespanel"
        classespanel.Size = New Size(1020, 749)
        classespanel.TabIndex = 6
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.WhiteSmoke
        Panel2.Controls.Add(DataGridView1)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(schoolyear)
        Panel2.Controls.Add(status)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(print_button)
        Panel2.Location = New Point(43, 100)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(989, 831)
        Panel2.TabIndex = 1
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(21, 149)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(946, 651)
        DataGridView1.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Tahoma", 14.25F)
        Button1.ForeColor = SystemColors.Desktop
        Button1.Location = New Point(867, 19)
        Button1.Name = "Button1"
        Button1.Size = New Size(96, 36)
        Button1.TabIndex = 6
        Button1.Text = "EXPORT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' schoolyear
        ' 
        schoolyear.Font = New Font("Tahoma", 15.75F)
        schoolyear.FormattingEnabled = True
        schoolyear.Location = New Point(816, 74)
        schoolyear.Name = "schoolyear"
        schoolyear.Size = New Size(147, 33)
        schoolyear.TabIndex = 5
        schoolyear.Text = "School Year"
        ' 
        ' status
        ' 
        status.Font = New Font("Tahoma", 15.75F)
        status.FormattingEnabled = True
        status.Location = New Point(698, 74)
        status.Name = "status"
        status.Size = New Size(96, 33)
        status.TabIndex = 4
        status.Text = "Status"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(17, 74)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(32, 32)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(55, 72)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Search"
        TextBox1.Size = New Size(418, 36)
        TextBox1.TabIndex = 2
        ' 
        ' print_button
        ' 
        print_button.BackColor = Color.White
        print_button.FlatAppearance.BorderSize = 0
        print_button.FlatStyle = FlatStyle.Flat
        print_button.Font = New Font("Tahoma", 14.25F)
        print_button.ForeColor = SystemColors.Desktop
        print_button.Location = New Point(758, 19)
        print_button.Name = "print_button"
        print_button.Size = New Size(100, 36)
        print_button.TabIndex = 1
        print_button.Text = "PRINT"
        print_button.UseVisualStyleBackColor = False
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
        ' student_name
        ' 
        student_name.Font = New Font("Tahoma", 24F)
        student_name.ForeColor = Color.White
        student_name.ImeMode = ImeMode.NoControl
        student_name.Location = New Point(179, 28)
        student_name.Name = "student_name"
        student_name.Size = New Size(827, 38)
        student_name.TabIndex = 1
        student_name.Text = "John Doe"
        student_name.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' head_dashboard
        ' 
        head_dashboard.BackColor = Color.Maroon
        head_dashboard.Controls.Add(title_dashboard)
        head_dashboard.Controls.Add(student_name)
        head_dashboard.Dock = DockStyle.Top
        head_dashboard.Location = New Point(0, 0)
        head_dashboard.Name = "head_dashboard"
        head_dashboard.Size = New Size(1020, 94)
        head_dashboard.TabIndex = 0
        ' 
        ' sidenav
        ' 
        sidenav.Controls.Add(header)
        sidenav.Controls.Add(menupanel)
        sidenav.Location = New Point(25, 21)
        sidenav.Name = "sidenav"
        sidenav.Size = New Size(300, 500)
        sidenav.TabIndex = 0
        ' 
        ' sidepanel
        ' 
        sidepanel.BackColor = Color.Maroon
        sidepanel.Controls.Add(logoutpanel)
        sidepanel.Controls.Add(sidenav)
        sidepanel.Dock = DockStyle.Left
        sidepanel.Location = New Point(0, 0)
        sidepanel.Name = "sidepanel"
        sidepanel.Size = New Size(350, 749)
        sidepanel.TabIndex = 4
        ' 
        ' logoutpanel
        ' 
        logoutpanel.Controls.Add(logoutbutton)
        logoutpanel.Cursor = Cursors.Hand
        logoutpanel.Location = New Point(25, 890)
        logoutpanel.Name = "logoutpanel"
        logoutpanel.Size = New Size(294, 56)
        logoutpanel.TabIndex = 3
        ' 
        ' logoutbutton
        ' 
        logoutbutton.BackColor = Color.Maroon
        logoutbutton.Dock = DockStyle.Fill
        logoutbutton.FlatAppearance.BorderSize = 0
        logoutbutton.FlatStyle = FlatStyle.Flat
        logoutbutton.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        logoutbutton.ForeColor = Color.White
        logoutbutton.Image = CType(resources.GetObject("logoutbutton.Image"), Image)
        logoutbutton.ImageAlign = ContentAlignment.MiddleLeft
        logoutbutton.ImeMode = ImeMode.NoControl
        logoutbutton.Location = New Point(0, 0)
        logoutbutton.Name = "logoutbutton"
        logoutbutton.Size = New Size(294, 56)
        logoutbutton.TabIndex = 0
        logoutbutton.Text = "       Log Out"
        logoutbutton.TextAlign = ContentAlignment.MiddleLeft
        logoutbutton.UseVisualStyleBackColor = False
        ' 
        ' dashboardpanel
        ' 
        dashboardpanel.BackColor = Color.Gainsboro
        dashboardpanel.Controls.Add(Panel1)
        dashboardpanel.Controls.Add(schedule_panel)
        dashboardpanel.Controls.Add(subject_panel)
        dashboardpanel.Controls.Add(head_dashboard)
        dashboardpanel.Dock = DockStyle.Fill
        dashboardpanel.Location = New Point(350, 0)
        dashboardpanel.Name = "dashboardpanel"
        dashboardpanel.Size = New Size(1020, 749)
        dashboardpanel.TabIndex = 5
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(enrolldatagrid)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(41, 505)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(953, 420)
        Panel1.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(16, 17)
        Label3.Name = "Label3"
        Label3.Size = New Size(232, 25)
        Label3.TabIndex = 2
        Label3.Text = "Enrollment Summary"
        ' 
        ' schedule_panel
        ' 
        schedule_panel.BackColor = Color.White
        schedule_panel.Controls.Add(ScheduleDataGrid)
        schedule_panel.Controls.Add(Label2)
        schedule_panel.Location = New Point(586, 121)
        schedule_panel.Name = "schedule_panel"
        schedule_panel.Size = New Size(431, 362)
        schedule_panel.TabIndex = 2
        ' 
        ' ScheduleDataGrid
        ' 
        ScheduleDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ScheduleDataGrid.Location = New Point(3, 48)
        ScheduleDataGrid.Name = "ScheduleDataGrid"
        ScheduleDataGrid.Size = New Size(431, 309)
        ScheduleDataGrid.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(16, 17)
        Label2.Name = "Label2"
        Label2.Size = New Size(209, 25)
        Label2.TabIndex = 1
        Label2.Text = "Schedule Overview"
        ' 
        ' subject_panel
        ' 
        subject_panel.BackColor = Color.White
        subject_panel.Controls.Add(StudBarChart)
        subject_panel.Location = New Point(41, 121)
        subject_panel.Name = "subject_panel"
        subject_panel.Size = New Size(524, 362)
        subject_panel.TabIndex = 1
        ' 
        ' StudBarChart
        ' 
        ChartArea1.Name = "ChartArea1"
        StudBarChart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        StudBarChart.Legends.Add(Legend1)
        StudBarChart.Location = New Point(15, 28)
        StudBarChart.Name = "StudBarChart"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        StudBarChart.Series.Add(Series1)
        StudBarChart.Size = New Size(494, 307)
        StudBarChart.TabIndex = 0
        StudBarChart.Text = "Chart1"
        ' 
        ' enrolldatagrid
        ' 
        enrolldatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        enrolldatagrid.Location = New Point(23, 62)
        enrolldatagrid.Name = "enrolldatagrid"
        enrolldatagrid.Size = New Size(899, 150)
        enrolldatagrid.TabIndex = 3
        ' 
        ' studentframe
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1370, 749)
        Controls.Add(dashboardpanel)
        Controls.Add(myprofilepanel)
        Controls.Add(classespanel)
        Controls.Add(sidepanel)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "studentframe"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student"
        myprofilepanel.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        head_myprofile.ResumeLayout(False)
        menupanel.ResumeLayout(False)
        dashboard.ResumeLayout(False)
        classes.ResumeLayout(False)
        myprofile.ResumeLayout(False)
        header.ResumeLayout(False)
        CType(logo, ComponentModel.ISupportInitialize).EndInit()
        head_classes.ResumeLayout(False)
        classespanel.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        head_dashboard.ResumeLayout(False)
        sidenav.ResumeLayout(False)
        sidepanel.ResumeLayout(False)
        logoutpanel.ResumeLayout(False)
        dashboardpanel.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        schedule_panel.ResumeLayout(False)
        schedule_panel.PerformLayout()
        CType(ScheduleDataGrid, ComponentModel.ISupportInitialize).EndInit()
        subject_panel.ResumeLayout(False)
        CType(StudBarChart, ComponentModel.ISupportInitialize).EndInit()
        CType(enrolldatagrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents title_myprofile As Label
    Friend WithEvents myprofilepanel As Panel
    Friend WithEvents head_myprofile As Panel
    Friend WithEvents title_classes As Label
    Friend WithEvents menupanel As Panel
    Friend WithEvents dashboard As Panel
    Friend WithEvents dashboardbutton As Button
    Friend WithEvents classes As Panel
    Friend WithEvents classesbutton As Button
    Friend WithEvents myprofile As Panel
    Friend WithEvents myprofilebutton As Button
    Friend WithEvents head_classes As Panel
    Friend WithEvents classespanel As Panel
    Friend WithEvents title_dashboard As Label
    Friend WithEvents student_name As Label
    Friend WithEvents head_dashboard As Panel
    Friend WithEvents title As Label
    Friend WithEvents logo As PictureBox
    Friend WithEvents header As Panel
    Friend WithEvents sidenav As Panel
    Friend WithEvents sidepanel As Panel
    Friend WithEvents dashboardpanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents schedule_panel As Panel
    Friend WithEvents subject_panel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents print_button As Button
    Friend WithEvents status As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents schoolyear As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents editprofile As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents StudBarChart As DataVisualization.Charting.Chart
    Friend WithEvents student_fullname As Label
    Friend WithEvents student_religion As Label
    Friend WithEvents student_guardian As Label
    Friend WithEvents student_nationality As Label
    Friend WithEvents student_grade As Label
    Friend WithEvents student_address As Label
    Friend WithEvents student_email As Label
    Friend WithEvents student_contact As Label
    Friend WithEvents student_age As Label
    Friend WithEvents student_gender As Label
    Friend WithEvents student_birthplace As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents logoutpanel As Panel
    Friend WithEvents logoutbutton As Button
    Friend WithEvents ScheduleDataGrid As DataGridView
    Friend WithEvents enrolldatagrid As DataGridView
End Class

