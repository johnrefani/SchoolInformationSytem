<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class instructorframe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(instructorframe))
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        title_myprofile = New Label()
        myprofilepanel = New Panel()
        myprofilebodypanel = New Panel()
        yearofexperiencetextbox = New TextBox()
        Label20 = New Label()
        nationalitytextbox = New TextBox()
        Label19 = New Label()
        civilstatustextbox = New TextBox()
        Label18 = New Label()
        subjecthandledtextbox = New TextBox()
        Label17 = New Label()
        addresstextbox = New TextBox()
        Label16 = New Label()
        advisorytextbox = New TextBox()
        Label15 = New Label()
        departmenttextbox = New TextBox()
        Label14 = New Label()
        emailaddtextbox = New TextBox()
        Label13 = New Label()
        contactnumtextbox = New TextBox()
        Label12 = New Label()
        gendertextbox = New TextBox()
        Label11 = New Label()
        lastnametextbox = New TextBox()
        Label10 = New Label()
        middleinitialtextbox = New TextBox()
        Label9 = New Label()
        firsnametextbox = New TextBox()
        Label8 = New Label()
        editprofilebutton = New Button()
        Label6 = New Label()
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
        bodyclassespanel = New Panel()
        DataGridView2 = New DataGridView()
        ComboBox2 = New ComboBox()
        ComboBox1 = New ComboBox()
        PictureBox1 = New PictureBox()
        TextBox1 = New TextBox()
        Button3 = New Button()
        Button2 = New Button()
        Label4 = New Label()
        title_dashboard = New Label()
        instructor_username = New Label()
        head_dashboard = New Panel()
        sidenav = New Panel()
        sidepanel = New Panel()
        logoutpanel = New Panel()
        logoutbutton = New Button()
        dashboardpanel = New Panel()
        Panel3 = New Panel()
        Button1 = New Button()
        ClassGridView = New DataGridView()
        Label7 = New Label()
        droppedstuds = New Panel()
        droppedstudentslabel = New Label()
        Label5 = New Label()
        enrolledstuds = New Panel()
        enrolledstudentslabel = New Label()
        Label3 = New Label()
        chartpanel = New Panel()
        LineChart = New DataVisualization.Charting.Chart()
        myprofilepanel.SuspendLayout()
        myprofilebodypanel.SuspendLayout()
        head_myprofile.SuspendLayout()
        menupanel.SuspendLayout()
        dashboard.SuspendLayout()
        classes.SuspendLayout()
        myprofile.SuspendLayout()
        header.SuspendLayout()
        CType(logo, ComponentModel.ISupportInitialize).BeginInit()
        head_classes.SuspendLayout()
        classespanel.SuspendLayout()
        bodyclassespanel.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        head_dashboard.SuspendLayout()
        sidenav.SuspendLayout()
        sidepanel.SuspendLayout()
        logoutpanel.SuspendLayout()
        dashboardpanel.SuspendLayout()
        Panel3.SuspendLayout()
        CType(ClassGridView, ComponentModel.ISupportInitialize).BeginInit()
        droppedstuds.SuspendLayout()
        enrolledstuds.SuspendLayout()
        chartpanel.SuspendLayout()
        CType(LineChart, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' title_myprofile
        ' 
        title_myprofile.Font = New Font("Tahoma", 24F)
        title_myprofile.ForeColor = Color.White
        title_myprofile.ImeMode = ImeMode.NoControl
        title_myprofile.Location = New Point(16, 28)
        title_myprofile.Name = "title_myprofile"
        title_myprofile.Size = New Size(366, 38)
        title_myprofile.TabIndex = 0
        title_myprofile.Text = "My Profile"
        title_myprofile.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' myprofilepanel
        ' 
        myprofilepanel.Controls.Add(myprofilebodypanel)
        myprofilepanel.Controls.Add(head_myprofile)
        myprofilepanel.Dock = DockStyle.Fill
        myprofilepanel.Location = New Point(350, 0)
        myprofilepanel.Name = "myprofilepanel"
        myprofilepanel.Size = New Size(1020, 749)
        myprofilepanel.TabIndex = 7
        ' 
        ' myprofilebodypanel
        ' 
        myprofilebodypanel.BackColor = Color.White
        myprofilebodypanel.Controls.Add(yearofexperiencetextbox)
        myprofilebodypanel.Controls.Add(Label20)
        myprofilebodypanel.Controls.Add(nationalitytextbox)
        myprofilebodypanel.Controls.Add(Label19)
        myprofilebodypanel.Controls.Add(civilstatustextbox)
        myprofilebodypanel.Controls.Add(Label18)
        myprofilebodypanel.Controls.Add(subjecthandledtextbox)
        myprofilebodypanel.Controls.Add(Label17)
        myprofilebodypanel.Controls.Add(addresstextbox)
        myprofilebodypanel.Controls.Add(Label16)
        myprofilebodypanel.Controls.Add(advisorytextbox)
        myprofilebodypanel.Controls.Add(Label15)
        myprofilebodypanel.Controls.Add(departmenttextbox)
        myprofilebodypanel.Controls.Add(Label14)
        myprofilebodypanel.Controls.Add(emailaddtextbox)
        myprofilebodypanel.Controls.Add(Label13)
        myprofilebodypanel.Controls.Add(contactnumtextbox)
        myprofilebodypanel.Controls.Add(Label12)
        myprofilebodypanel.Controls.Add(gendertextbox)
        myprofilebodypanel.Controls.Add(Label11)
        myprofilebodypanel.Controls.Add(lastnametextbox)
        myprofilebodypanel.Controls.Add(Label10)
        myprofilebodypanel.Controls.Add(middleinitialtextbox)
        myprofilebodypanel.Controls.Add(Label9)
        myprofilebodypanel.Controls.Add(firsnametextbox)
        myprofilebodypanel.Controls.Add(Label8)
        myprofilebodypanel.Controls.Add(editprofilebutton)
        myprofilebodypanel.Controls.Add(Label6)
        myprofilebodypanel.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        myprofilebodypanel.Location = New Point(25, 121)
        myprofilebodypanel.Name = "myprofilebodypanel"
        myprofilebodypanel.Size = New Size(1024, 589)
        myprofilebodypanel.TabIndex = 1
        ' 
        ' yearofexperiencetextbox
        ' 
        yearofexperiencetextbox.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        yearofexperiencetextbox.BorderStyle = BorderStyle.FixedSingle
        yearofexperiencetextbox.Location = New Point(360, 525)
        yearofexperiencetextbox.Name = "yearofexperiencetextbox"
        yearofexperiencetextbox.ReadOnly = True
        yearofexperiencetextbox.Size = New Size(234, 33)
        yearofexperiencetextbox.TabIndex = 29
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(360, 487)
        Label20.Name = "Label20"
        Label20.Size = New Size(234, 25)
        Label20.TabIndex = 28
        Label20.Text = "YEARS OF EXPERIENCE"
        ' 
        ' nationalitytextbox
        ' 
        nationalitytextbox.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        nationalitytextbox.BorderStyle = BorderStyle.FixedSingle
        nationalitytextbox.Location = New Point(696, 428)
        nationalitytextbox.Name = "nationalitytextbox"
        nationalitytextbox.ReadOnly = True
        nationalitytextbox.Size = New Size(282, 33)
        nationalitytextbox.TabIndex = 27
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(696, 390)
        Label19.Name = "Label19"
        Label19.Size = New Size(143, 25)
        Label19.TabIndex = 26
        Label19.Text = "NATIONALITY"
        ' 
        ' civilstatustextbox
        ' 
        civilstatustextbox.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        civilstatustextbox.BorderStyle = BorderStyle.FixedSingle
        civilstatustextbox.Location = New Point(360, 428)
        civilstatustextbox.Name = "civilstatustextbox"
        civilstatustextbox.ReadOnly = True
        civilstatustextbox.Size = New Size(302, 33)
        civilstatustextbox.TabIndex = 25
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(360, 390)
        Label18.Name = "Label18"
        Label18.Size = New Size(146, 25)
        Label18.TabIndex = 24
        Label18.Text = "CIVIL STATUS"
        ' 
        ' subjecthandledtextbox
        ' 
        subjecthandledtextbox.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        subjecthandledtextbox.BorderStyle = BorderStyle.FixedSingle
        subjecthandledtextbox.Location = New Point(360, 332)
        subjecthandledtextbox.Name = "subjecthandledtextbox"
        subjecthandledtextbox.ReadOnly = True
        subjecthandledtextbox.Size = New Size(619, 33)
        subjecthandledtextbox.TabIndex = 23
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(360, 294)
        Label17.Name = "Label17"
        Label17.Size = New Size(195, 25)
        Label17.TabIndex = 22
        Label17.Text = "SUBJECT HANDLED"
        ' 
        ' addresstextbox
        ' 
        addresstextbox.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        addresstextbox.BorderStyle = BorderStyle.FixedSingle
        addresstextbox.Location = New Point(360, 234)
        addresstextbox.Name = "addresstextbox"
        addresstextbox.ReadOnly = True
        addresstextbox.Size = New Size(619, 33)
        addresstextbox.TabIndex = 21
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(360, 196)
        Label16.Name = "Label16"
        Label16.Size = New Size(102, 25)
        Label16.TabIndex = 20
        Label16.Text = "ADDRESS"
        ' 
        ' advisorytextbox
        ' 
        advisorytextbox.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        advisorytextbox.BorderStyle = BorderStyle.FixedSingle
        advisorytextbox.Location = New Point(23, 525)
        advisorytextbox.Name = "advisorytextbox"
        advisorytextbox.ReadOnly = True
        advisorytextbox.Size = New Size(309, 33)
        advisorytextbox.TabIndex = 19
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(23, 487)
        Label15.Name = "Label15"
        Label15.Size = New Size(179, 25)
        Label15.TabIndex = 18
        Label15.Text = "ADVISORY CLASS"
        ' 
        ' departmenttextbox
        ' 
        departmenttextbox.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        departmenttextbox.BorderStyle = BorderStyle.FixedSingle
        departmenttextbox.Location = New Point(23, 428)
        departmenttextbox.Name = "departmenttextbox"
        departmenttextbox.ReadOnly = True
        departmenttextbox.Size = New Size(309, 33)
        departmenttextbox.TabIndex = 17
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(23, 390)
        Label14.Name = "Label14"
        Label14.Size = New Size(142, 25)
        Label14.TabIndex = 16
        Label14.Text = "DEPARTMENT"
        ' 
        ' emailaddtextbox
        ' 
        emailaddtextbox.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        emailaddtextbox.BorderStyle = BorderStyle.FixedSingle
        emailaddtextbox.Location = New Point(23, 332)
        emailaddtextbox.Name = "emailaddtextbox"
        emailaddtextbox.ReadOnly = True
        emailaddtextbox.Size = New Size(309, 33)
        emailaddtextbox.TabIndex = 15
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(23, 294)
        Label13.Name = "Label13"
        Label13.Size = New Size(168, 25)
        Label13.TabIndex = 14
        Label13.Text = "EMAIL ADDRESS"
        ' 
        ' contactnumtextbox
        ' 
        contactnumtextbox.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        contactnumtextbox.BorderStyle = BorderStyle.FixedSingle
        contactnumtextbox.Location = New Point(23, 234)
        contactnumtextbox.Name = "contactnumtextbox"
        contactnumtextbox.ReadOnly = True
        contactnumtextbox.Size = New Size(309, 33)
        contactnumtextbox.TabIndex = 13
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(23, 196)
        Label12.Name = "Label12"
        Label12.Size = New Size(193, 25)
        Label12.TabIndex = 12
        Label12.Text = "CONTACT NUMBER"
        ' 
        ' gendertextbox
        ' 
        gendertextbox.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        gendertextbox.BorderStyle = BorderStyle.FixedSingle
        gendertextbox.Location = New Point(830, 133)
        gendertextbox.Name = "gendertextbox"
        gendertextbox.ReadOnly = True
        gendertextbox.Size = New Size(149, 33)
        gendertextbox.TabIndex = 11
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(830, 95)
        Label11.Name = "Label11"
        Label11.Size = New Size(91, 25)
        Label11.TabIndex = 10
        Label11.Text = "GENDER"
        ' 
        ' lastnametextbox
        ' 
        lastnametextbox.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        lastnametextbox.BorderStyle = BorderStyle.FixedSingle
        lastnametextbox.Location = New Point(561, 133)
        lastnametextbox.Name = "lastnametextbox"
        lastnametextbox.ReadOnly = True
        lastnametextbox.Size = New Size(250, 33)
        lastnametextbox.TabIndex = 9
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(561, 95)
        Label10.Name = "Label10"
        Label10.Size = New Size(121, 25)
        Label10.TabIndex = 8
        Label10.Text = "LAST NAME"
        ' 
        ' middleinitialtextbox
        ' 
        middleinitialtextbox.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        middleinitialtextbox.BorderStyle = BorderStyle.FixedSingle
        middleinitialtextbox.Location = New Point(292, 133)
        middleinitialtextbox.Name = "middleinitialtextbox"
        middleinitialtextbox.ReadOnly = True
        middleinitialtextbox.Size = New Size(250, 33)
        middleinitialtextbox.TabIndex = 7
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(292, 95)
        Label9.Name = "Label9"
        Label9.Size = New Size(148, 25)
        Label9.TabIndex = 6
        Label9.Text = "MIDDLE NAME"
        ' 
        ' firsnametextbox
        ' 
        firsnametextbox.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        firsnametextbox.BorderStyle = BorderStyle.FixedSingle
        firsnametextbox.Location = New Point(23, 133)
        firsnametextbox.Name = "firsnametextbox"
        firsnametextbox.ReadOnly = True
        firsnametextbox.Size = New Size(250, 33)
        firsnametextbox.TabIndex = 5
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(23, 95)
        Label8.Name = "Label8"
        Label8.Size = New Size(130, 25)
        Label8.TabIndex = 4
        Label8.Text = "FIRST NAME"
        ' 
        ' editprofilebutton
        ' 
        editprofilebutton.AutoSize = True
        editprofilebutton.BackColor = Color.FromArgb(CByte(35), CByte(50), CByte(85))
        editprofilebutton.Cursor = Cursors.Hand
        editprofilebutton.FlatAppearance.BorderSize = 0
        editprofilebutton.FlatStyle = FlatStyle.Flat
        editprofilebutton.ForeColor = Color.White
        editprofilebutton.Location = New Point(848, 25)
        editprofilebutton.Name = "editprofilebutton"
        editprofilebutton.Size = New Size(156, 37)
        editprofilebutton.TabIndex = 3
        editprofilebutton.Text = "EDIT PROFILE"
        editprofilebutton.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(16, 20)
        Label6.Name = "Label6"
        Label6.Size = New Size(258, 39)
        Label6.TabIndex = 2
        Label6.Text = "Manage Profile"
        ' 
        ' head_myprofile
        ' 
        head_myprofile.BackColor = Color.Maroon
        head_myprofile.Controls.Add(title_myprofile)
        head_myprofile.Dock = DockStyle.Top
        head_myprofile.Location = New Point(0, 0)
        head_myprofile.Name = "head_myprofile"
        head_myprofile.Size = New Size(1020, 94)
        head_myprofile.TabIndex = 0
        ' 
        ' title_classes
        ' 
        title_classes.Font = New Font("Tahoma", 24F)
        title_classes.ForeColor = Color.White
        title_classes.ImeMode = ImeMode.NoControl
        title_classes.Location = New Point(16, 28)
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
        dashboardbutton.BackgroundImageLayout = ImageLayout.Center
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
        classesbutton.BackgroundImageLayout = ImageLayout.Center
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
        classesbutton.Text = "       Classes"
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
        myprofilebutton.BackgroundImageLayout = ImageLayout.Center
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
        ' head_classes
        ' 
        head_classes.BackColor = Color.Maroon
        head_classes.Controls.Add(title_classes)
        head_classes.Dock = DockStyle.Top
        head_classes.Location = New Point(0, 0)
        head_classes.Name = "head_classes"
        head_classes.Size = New Size(1020, 94)
        head_classes.TabIndex = 0
        ' 
        ' classespanel
        ' 
        classespanel.Controls.Add(bodyclassespanel)
        classespanel.Controls.Add(head_classes)
        classespanel.Dock = DockStyle.Fill
        classespanel.Location = New Point(350, 0)
        classespanel.Name = "classespanel"
        classespanel.Size = New Size(1020, 749)
        classespanel.TabIndex = 6
        ' 
        ' bodyclassespanel
        ' 
        bodyclassespanel.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        bodyclassespanel.Controls.Add(DataGridView2)
        bodyclassespanel.Controls.Add(ComboBox2)
        bodyclassespanel.Controls.Add(ComboBox1)
        bodyclassespanel.Controls.Add(PictureBox1)
        bodyclassespanel.Controls.Add(TextBox1)
        bodyclassespanel.Controls.Add(Button3)
        bodyclassespanel.Controls.Add(Button2)
        bodyclassespanel.Controls.Add(Label4)
        bodyclassespanel.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bodyclassespanel.Location = New Point(25, 121)
        bodyclassespanel.Name = "bodyclassespanel"
        bodyclassespanel.Size = New Size(1024, 850)
        bodyclassespanel.TabIndex = 1
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
        ' ComboBox2
        ' 
        ComboBox2.ForeColor = Color.FromArgb(CByte(35), CByte(50), CByte(85))
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(883, 79)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(121, 33)
        ComboBox2.TabIndex = 7
        ComboBox2.Text = "Semester"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.ForeColor = Color.FromArgb(CByte(35), CByte(50), CByte(85))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(756, 79)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 33)
        ComboBox1.TabIndex = 6
        ComboBox1.Text = "Subject"
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
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(61, 79)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Search"
        TextBox1.Size = New Size(418, 33)
        TextBox1.TabIndex = 4
        ' 
        ' Button3
        ' 
        Button3.AutoSize = True
        Button3.BackColor = Color.White
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.FromArgb(CByte(35), CByte(50), CByte(85))
        Button3.Location = New Point(906, 22)
        Button3.Name = "Button3"
        Button3.Size = New Size(98, 37)
        Button3.TabIndex = 2
        Button3.Text = "EXPORT"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.AutoSize = True
        Button2.BackColor = Color.White
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.FromArgb(CByte(35), CByte(50), CByte(85))
        Button2.Location = New Point(805, 21)
        Button2.Name = "Button2"
        Button2.Size = New Size(95, 37)
        Button2.TabIndex = 1
        Button2.Text = "PRINT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(15, 17)
        Label4.Name = "Label4"
        Label4.Size = New Size(295, 39)
        Label4.TabIndex = 0
        Label4.Text = "Handled Subjects"
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
        ' instructor_username
        ' 
        instructor_username.Font = New Font("Tahoma", 24F)
        instructor_username.ForeColor = Color.White
        instructor_username.ImeMode = ImeMode.NoControl
        instructor_username.Location = New Point(179, 28)
        instructor_username.Name = "instructor_username"
        instructor_username.Size = New Size(850, 39)
        instructor_username.TabIndex = 1
        instructor_username.Text = "John Doe"
        instructor_username.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' head_dashboard
        ' 
        head_dashboard.BackColor = Color.Maroon
        head_dashboard.Controls.Add(title_dashboard)
        head_dashboard.Controls.Add(instructor_username)
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
        logoutpanel.Location = New Point(28, 890)
        logoutpanel.Name = "logoutpanel"
        logoutpanel.Size = New Size(294, 56)
        logoutpanel.TabIndex = 3
        ' 
        ' logoutbutton
        ' 
        logoutbutton.BackColor = Color.Maroon
        logoutbutton.BackgroundImageLayout = ImageLayout.Center
        logoutbutton.Dock = DockStyle.Fill
        logoutbutton.FlatAppearance.BorderColor = Color.Maroon
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
        dashboardpanel.Controls.Add(Panel3)
        dashboardpanel.Controls.Add(droppedstuds)
        dashboardpanel.Controls.Add(enrolledstuds)
        dashboardpanel.Controls.Add(chartpanel)
        dashboardpanel.Controls.Add(head_dashboard)
        dashboardpanel.Dock = DockStyle.Fill
        dashboardpanel.Location = New Point(350, 0)
        dashboardpanel.Name = "dashboardpanel"
        dashboardpanel.Size = New Size(1020, 749)
        dashboardpanel.TabIndex = 5
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(Button1)
        Panel3.Controls.Add(ClassGridView)
        Panel3.Controls.Add(Label7)
        Panel3.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel3.Location = New Point(28, 506)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1016, 467)
        Panel3.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(35), CByte(50), CByte(85))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.White
        Button1.Location = New Point(520, 25)
        Button1.Name = "Button1"
        Button1.Size = New Size(240, 40)
        Button1.TabIndex = 3
        Button1.Text = "VIEW ALL CLASSES"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ClassGridView
        ' 
        ClassGridView.BackgroundColor = Color.White
        ClassGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ClassGridView.Location = New Point(14, 82)
        ClassGridView.Name = "ClassGridView"
        ClassGridView.Size = New Size(989, 380)
        ClassGridView.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(14, 25)
        Label7.Name = "Label7"
        Label7.Size = New Size(261, 39)
        Label7.TabIndex = 1
        Label7.Text = "Class Summary"
        ' 
        ' droppedstuds
        ' 
        droppedstuds.BackColor = Color.FromArgb(CByte(255), CByte(139), CByte(139))
        droppedstuds.Controls.Add(droppedstudentslabel)
        droppedstuds.Controls.Add(Label5)
        droppedstuds.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        droppedstuds.Location = New Point(816, 319)
        droppedstuds.Name = "droppedstuds"
        droppedstuds.Size = New Size(230, 167)
        droppedstuds.TabIndex = 3
        ' 
        ' droppedstudentslabel
        ' 
        droppedstudentslabel.AutoSize = True
        droppedstudentslabel.Font = New Font("Tahoma", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        droppedstudentslabel.ForeColor = Color.FromArgb(CByte(86), CByte(0), CByte(0))
        droppedstudentslabel.Location = New Point(79, 70)
        droppedstudentslabel.Name = "droppedstudentslabel"
        droppedstudentslabel.Size = New Size(74, 77)
        droppedstudentslabel.TabIndex = 2
        droppedstudentslabel.Text = "2"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(86), CByte(0), CByte(0))
        Label5.Location = New Point(16, 32)
        Label5.Name = "Label5"
        Label5.Size = New Size(200, 25)
        Label5.TabIndex = 1
        Label5.Text = "Dropped Students"
        ' 
        ' enrolledstuds
        ' 
        enrolledstuds.BackColor = Color.FromArgb(CByte(255), CByte(17), CByte(17))
        enrolledstuds.Controls.Add(enrolledstudentslabel)
        enrolledstuds.Controls.Add(Label3)
        enrolledstuds.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        enrolledstuds.Location = New Point(815, 120)
        enrolledstuds.Name = "enrolledstuds"
        enrolledstuds.Size = New Size(230, 167)
        enrolledstuds.TabIndex = 2
        ' 
        ' enrolledstudentslabel
        ' 
        enrolledstudentslabel.AutoSize = True
        enrolledstudentslabel.Font = New Font("Tahoma", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        enrolledstudentslabel.ForeColor = Color.FromArgb(CByte(86), CByte(0), CByte(0))
        enrolledstudentslabel.Location = New Point(56, 69)
        enrolledstudentslabel.Name = "enrolledstudentslabel"
        enrolledstudentslabel.Size = New Size(115, 77)
        enrolledstudentslabel.TabIndex = 1
        enrolledstudentslabel.Text = "96"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(86), CByte(0), CByte(0))
        Label3.Location = New Point(18, 29)
        Label3.Name = "Label3"
        Label3.Size = New Size(196, 25)
        Label3.TabIndex = 0
        Label3.Text = "Enrolled Students"
        ' 
        ' chartpanel
        ' 
        chartpanel.BackColor = Color.White
        chartpanel.Controls.Add(LineChart)
        chartpanel.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chartpanel.Location = New Point(28, 121)
        chartpanel.Name = "chartpanel"
        chartpanel.Size = New Size(760, 365)
        chartpanel.TabIndex = 1
        ' 
        ' LineChart
        ' 
        ChartArea2.Name = "ChartArea1"
        LineChart.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        LineChart.Legends.Add(Legend2)
        LineChart.Location = New Point(3, -1)
        LineChart.Name = "LineChart"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = DataVisualization.Charting.SeriesChartType.Line
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        LineChart.Series.Add(Series2)
        LineChart.Size = New Size(754, 363)
        LineChart.TabIndex = 0
        LineChart.Text = "Chart1"
        ' 
        ' instructorframe
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1370, 749)
        Controls.Add(dashboardpanel)
        Controls.Add(myprofilepanel)
        Controls.Add(classespanel)
        Controls.Add(sidepanel)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "instructorframe"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Instructor"
        myprofilepanel.ResumeLayout(False)
        myprofilebodypanel.ResumeLayout(False)
        myprofilebodypanel.PerformLayout()
        head_myprofile.ResumeLayout(False)
        menupanel.ResumeLayout(False)
        dashboard.ResumeLayout(False)
        classes.ResumeLayout(False)
        myprofile.ResumeLayout(False)
        header.ResumeLayout(False)
        CType(logo, ComponentModel.ISupportInitialize).EndInit()
        head_classes.ResumeLayout(False)
        classespanel.ResumeLayout(False)
        bodyclassespanel.ResumeLayout(False)
        bodyclassespanel.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        head_dashboard.ResumeLayout(False)
        sidenav.ResumeLayout(False)
        sidepanel.ResumeLayout(False)
        logoutpanel.ResumeLayout(False)
        dashboardpanel.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(ClassGridView, ComponentModel.ISupportInitialize).EndInit()
        droppedstuds.ResumeLayout(False)
        droppedstuds.PerformLayout()
        enrolledstuds.ResumeLayout(False)
        enrolledstuds.PerformLayout()
        chartpanel.ResumeLayout(False)
        CType(LineChart, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents instructor_username As Label
    Friend WithEvents head_dashboard As Panel
    Friend WithEvents title As Label
    Friend WithEvents logo As PictureBox
    Friend WithEvents header As Panel
    Friend WithEvents sidenav As Panel
    Friend WithEvents sidepanel As Panel
    Friend WithEvents dashboardpanel As Panel
    Friend WithEvents chartpanel As Panel
    Friend WithEvents droppedstuds As Panel
    Friend WithEvents enrolledstuds As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents enrolledstudentslabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents droppedstudentslabel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ClassGridView As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents bodyclassespanel As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents myprofilebodypanel As Panel
    Friend WithEvents editprofilebutton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents gendertextbox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lastnametextbox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents middleinitialtextbox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents firsnametextbox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents contactnumtextbox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents emailaddtextbox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents advisorytextbox As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents departmenttextbox As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents addresstextbox As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents subjecthandledtextbox As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents nationalitytextbox As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents civilstatustextbox As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents yearofexperiencetextbox As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents LineChart As DataVisualization.Charting.Chart
    Friend WithEvents logoutpanel As Panel
    Friend WithEvents logoutbutton As Button
End Class
