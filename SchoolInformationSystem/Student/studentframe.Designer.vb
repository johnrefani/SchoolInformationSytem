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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        title_myprofile = New Label()
        myprofilepanel = New Panel()
        Panel3 = New Panel()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        TextBox7 = New TextBox()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        email = New TextBox()
        contactnumber = New TextBox()
        age = New TextBox()
        gender = New TextBox()
        Label4 = New Label()
        fullname = New TextBox()
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
        schoolyear = New ComboBox()
        status = New ComboBox()
        PictureBox1 = New PictureBox()
        TextBox1 = New TextBox()
        print_button = New Button()
        export_button = New Button()
        title_dashboard = New Label()
        username = New Label()
        head_dashboard = New Panel()
        sidenav = New Panel()
        sidepanel = New Panel()
        dashboardpanel = New Panel()
        Panel1 = New Panel()
        Label3 = New Label()
        schedule_panel = New Panel()
        Label2 = New Label()
        subject_panel = New Panel()
        StudBarChart = New DataVisualization.Charting.Chart()
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
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        head_dashboard.SuspendLayout()
        sidenav.SuspendLayout()
        sidepanel.SuspendLayout()
        dashboardpanel.SuspendLayout()
        Panel1.SuspendLayout()
        schedule_panel.SuspendLayout()
        subject_panel.SuspendLayout()
        CType(StudBarChart, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel3.Controls.Add(Label14)
        Panel3.Controls.Add(Label13)
        Panel3.Controls.Add(Label12)
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(TextBox7)
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(TextBox6)
        Panel3.Controls.Add(TextBox5)
        Panel3.Controls.Add(TextBox4)
        Panel3.Controls.Add(TextBox3)
        Panel3.Controls.Add(TextBox2)
        Panel3.Controls.Add(email)
        Panel3.Controls.Add(contactnumber)
        Panel3.Controls.Add(age)
        Panel3.Controls.Add(gender)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(fullname)
        Panel3.Controls.Add(editprofile)
        Panel3.Location = New Point(16, 103)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1040, 523)
        Panel3.TabIndex = 1
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(384, 359)
        Label14.Name = "Label14"
        Label14.Size = New Size(79, 21)
        Label14.TabIndex = 22
        Label14.Text = "RELIGION"
        Label14.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(55, 378)
        Label13.Name = "Label13"
        Label13.Size = New Size(137, 21)
        Label13.TabIndex = 21
        Label13.Text = "GUARDIAN NAME"
        Label13.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(674, 267)
        Label12.Name = "Label12"
        Label12.Size = New Size(106, 21)
        Label12.TabIndex = 20
        Label12.Text = "NATIONALITY"
        Label12.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(237, 267)
        Label11.Name = "Label11"
        Label11.Size = New Size(96, 21)
        Label11.TabIndex = 19
        Label11.Text = "BIRTHPLACE"
        Label11.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox7.Location = New Point(674, 307)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(222, 35)
        TextBox7.TabIndex = 18
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(43, 267)
        Label10.Name = "Label10"
        Label10.Size = New Size(106, 21)
        Label10.TabIndex = 17
        Label10.Text = "GRADE LEVEL"
        Label10.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(370, 160)
        Label9.Name = "Label9"
        Label9.Size = New Size(78, 21)
        Label9.TabIndex = 16
        Label9.Text = "ADDRESS"
        Label9.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(40, 160)
        Label8.Name = "Label8"
        Label8.Size = New Size(126, 21)
        Label8.TabIndex = 15
        Label8.Text = "EMAIL ADDRESS"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(720, 58)
        Label7.Name = "Label7"
        Label7.Size = New Size(147, 21)
        Label7.TabIndex = 14
        Label7.Text = "CONTACT NUMBER"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(558, 58)
        Label6.Name = "Label6"
        Label6.Size = New Size(39, 21)
        Label6.TabIndex = 13
        Label6.Text = "AGE"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(370, 57)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 21)
        Label5.TabIndex = 12
        Label5.Text = "GENDER"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox6.Location = New Point(384, 402)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(394, 35)
        TextBox6.TabIndex = 11
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox5.Location = New Point(40, 402)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(302, 35)
        TextBox5.TabIndex = 10
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(237, 307)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(410, 35)
        TextBox4.TabIndex = 9
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(40, 307)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(169, 35)
        TextBox3.TabIndex = 8
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(370, 193)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(657, 35)
        TextBox2.TabIndex = 7
        ' 
        ' email
        ' 
        email.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        email.Location = New Point(40, 193)
        email.Name = "email"
        email.Size = New Size(302, 35)
        email.TabIndex = 6
        ' 
        ' contactnumber
        ' 
        contactnumber.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        contactnumber.Location = New Point(720, 86)
        contactnumber.Name = "contactnumber"
        contactnumber.Size = New Size(307, 35)
        contactnumber.TabIndex = 5
        ' 
        ' age
        ' 
        age.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        age.Location = New Point(558, 86)
        age.Name = "age"
        age.Size = New Size(127, 35)
        age.TabIndex = 4
        ' 
        ' gender
        ' 
        gender.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        gender.Location = New Point(370, 86)
        gender.Name = "gender"
        gender.Size = New Size(169, 35)
        gender.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(43, 58)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 21)
        Label4.TabIndex = 2
        Label4.Text = "FULL NAME"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' fullname
        ' 
        fullname.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        fullname.Location = New Point(40, 86)
        fullname.Name = "fullname"
        fullname.Size = New Size(302, 35)
        fullname.TabIndex = 1
        ' 
        ' editprofile
        ' 
        editprofile.Location = New Point(931, 18)
        editprofile.Name = "editprofile"
        editprofile.Size = New Size(96, 23)
        editprofile.TabIndex = 0
        editprofile.Text = "EDIT PROFILE"
        editprofile.UseVisualStyleBackColor = True
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
        Panel2.Controls.Add(schoolyear)
        Panel2.Controls.Add(status)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(print_button)
        Panel2.Controls.Add(export_button)
        Panel2.Location = New Point(16, 100)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1043, 831)
        Panel2.TabIndex = 1
        ' 
        ' schoolyear
        ' 
        schoolyear.FormattingEnabled = True
        schoolyear.Items.AddRange(New Object() {"School Year"})
        schoolyear.Location = New Point(931, 63)
        schoolyear.Name = "schoolyear"
        schoolyear.Size = New Size(96, 23)
        schoolyear.TabIndex = 5
        ' 
        ' status
        ' 
        status.FormattingEnabled = True
        status.Items.AddRange(New Object() {"Status"})
        status.Location = New Point(800, 63)
        status.Name = "status"
        status.Size = New Size(96, 23)
        status.TabIndex = 4
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(17, 54)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(32, 32)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 12F)
        TextBox1.Location = New Point(55, 57)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Search"
        TextBox1.Size = New Size(418, 29)
        TextBox1.TabIndex = 2
        ' 
        ' print_button
        ' 
        print_button.Location = New Point(860, 21)
        print_button.Name = "print_button"
        print_button.Size = New Size(75, 23)
        print_button.TabIndex = 1
        print_button.Text = "PRINT"
        print_button.UseVisualStyleBackColor = True
        ' 
        ' export_button
        ' 
        export_button.Location = New Point(952, 21)
        export_button.Name = "export_button"
        export_button.Size = New Size(75, 23)
        export_button.TabIndex = 0
        export_button.Text = "EXPORT"
        export_button.UseVisualStyleBackColor = True
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
        sidepanel.Controls.Add(sidenav)
        sidepanel.Dock = DockStyle.Left
        sidepanel.Location = New Point(0, 0)
        sidepanel.Name = "sidepanel"
        sidepanel.Size = New Size(350, 749)
        sidepanel.TabIndex = 4
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
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(16, 526)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1046, 420)
        Panel1.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(16, 17)
        Label3.Name = "Label3"
        Label3.Size = New Size(188, 25)
        Label3.TabIndex = 2
        Label3.Text = "Enrollment Summary"
        ' 
        ' schedule_panel
        ' 
        schedule_panel.BackColor = Color.WhiteSmoke
        schedule_panel.Controls.Add(Label2)
        schedule_panel.Location = New Point(591, 121)
        schedule_panel.Name = "schedule_panel"
        schedule_panel.Size = New Size(435, 362)
        schedule_panel.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(16, 17)
        Label2.Name = "Label2"
        Label2.Size = New Size(172, 25)
        Label2.TabIndex = 1
        Label2.Text = "Schedule Overview"
        ' 
        ' subject_panel
        ' 
        subject_panel.BackColor = Color.WhiteSmoke
        subject_panel.Controls.Add(StudBarChart)
        subject_panel.Location = New Point(16, 121)
        subject_panel.Name = "subject_panel"
        subject_panel.Size = New Size(550, 362)
        subject_panel.TabIndex = 1
        ' 
        ' StudBarChart
        ' 
        ChartArea2.Name = "ChartArea1"
        StudBarChart.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        StudBarChart.Legends.Add(Legend2)
        StudBarChart.Location = New Point(0, 0)
        StudBarChart.Name = "StudBarChart"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        StudBarChart.Series.Add(Series2)
        StudBarChart.Size = New Size(550, 362)
        StudBarChart.TabIndex = 0
        StudBarChart.Text = "Chart1"
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
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        head_dashboard.ResumeLayout(False)
        sidenav.ResumeLayout(False)
        sidepanel.ResumeLayout(False)
        dashboardpanel.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        schedule_panel.ResumeLayout(False)
        schedule_panel.PerformLayout()
        subject_panel.ResumeLayout(False)
        CType(StudBarChart, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents username As Label
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
    Friend WithEvents export_button As Button
    Friend WithEvents status As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents schoolyear As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents fullname As TextBox
    Friend WithEvents editprofile As Button
    Friend WithEvents age As TextBox
    Friend WithEvents contactnumber As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents gender As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents StudBarChart As DataVisualization.Charting.Chart
End Class

