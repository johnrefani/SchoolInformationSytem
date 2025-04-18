<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPage
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminPage))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New DataVisualization.Charting.Title()
        coursePage_Button = New Button()
        studentPage_Button = New Button()
        instructorPage_Button = New Button()
        programPage_Button = New Button()
        departmentPage_Button = New Button()
        departmentstaffPage_Button = New Button()
        transcriptPage_Button = New Button()
        courseregistrationPage_Button = New Button()
        ImageList1 = New ImageList(components)
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        PictureBox9 = New PictureBox()
        PictureBox10 = New PictureBox()
        logout_Button = New Button()
        PictureBox11 = New PictureBox()
        createadmin_Button = New Button()
        dashboard_Label = New Label()
        Counts_Panel = New Panel()
        Label2 = New Label()
        InstructorCount_Chart = New DataVisualization.Charting.Chart()
        GenderCount_Chart = New DataVisualization.Charting.Chart()
        StudentCount_Chart = New DataVisualization.Charting.Chart()
        FemaleCount_Label = New Label()
        MaleCount_Label = New Label()
        StudentCount_Label = New Label()
        UserManage_Button = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).BeginInit()
        Counts_Panel.SuspendLayout()
        CType(InstructorCount_Chart, ComponentModel.ISupportInitialize).BeginInit()
        CType(GenderCount_Chart, ComponentModel.ISupportInitialize).BeginInit()
        CType(StudentCount_Chart, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' coursePage_Button
        ' 
        coursePage_Button.BackColor = Color.Maroon
        coursePage_Button.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        coursePage_Button.ForeColor = SystemColors.ButtonFace
        coursePage_Button.Location = New Point(77, 342)
        coursePage_Button.Name = "coursePage_Button"
        coursePage_Button.Size = New Size(424, 50)
        coursePage_Button.TabIndex = 1
        coursePage_Button.Text = "COURSE"
        coursePage_Button.UseVisualStyleBackColor = False
        ' 
        ' studentPage_Button
        ' 
        studentPage_Button.BackColor = Color.Maroon
        studentPage_Button.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        studentPage_Button.ForeColor = SystemColors.ButtonFace
        studentPage_Button.Location = New Point(77, 237)
        studentPage_Button.Name = "studentPage_Button"
        studentPage_Button.Size = New Size(424, 47)
        studentPage_Button.TabIndex = 2
        studentPage_Button.Text = "STUDENT"
        studentPage_Button.UseVisualStyleBackColor = False
        ' 
        ' instructorPage_Button
        ' 
        instructorPage_Button.BackColor = Color.Maroon
        instructorPage_Button.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        instructorPage_Button.ForeColor = SystemColors.ButtonFace
        instructorPage_Button.Location = New Point(77, 291)
        instructorPage_Button.Name = "instructorPage_Button"
        instructorPage_Button.Size = New Size(424, 45)
        instructorPage_Button.TabIndex = 3
        instructorPage_Button.Text = "INSTRUCTOR"
        instructorPage_Button.UseVisualStyleBackColor = False
        ' 
        ' programPage_Button
        ' 
        programPage_Button.BackColor = Color.Maroon
        programPage_Button.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        programPage_Button.ForeColor = SystemColors.ButtonFace
        programPage_Button.Location = New Point(77, 397)
        programPage_Button.Name = "programPage_Button"
        programPage_Button.Size = New Size(424, 48)
        programPage_Button.TabIndex = 4
        programPage_Button.Text = "PROGRAM"
        programPage_Button.UseVisualStyleBackColor = False
        ' 
        ' departmentPage_Button
        ' 
        departmentPage_Button.BackColor = Color.Maroon
        departmentPage_Button.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        departmentPage_Button.ForeColor = SystemColors.ButtonFace
        departmentPage_Button.Location = New Point(77, 452)
        departmentPage_Button.Name = "departmentPage_Button"
        departmentPage_Button.Size = New Size(424, 45)
        departmentPage_Button.TabIndex = 5
        departmentPage_Button.Text = "DEPARTMENT"
        departmentPage_Button.UseVisualStyleBackColor = False
        ' 
        ' departmentstaffPage_Button
        ' 
        departmentstaffPage_Button.BackColor = Color.Maroon
        departmentstaffPage_Button.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        departmentstaffPage_Button.ForeColor = SystemColors.ButtonFace
        departmentstaffPage_Button.Location = New Point(77, 504)
        departmentstaffPage_Button.Name = "departmentstaffPage_Button"
        departmentstaffPage_Button.Size = New Size(424, 47)
        departmentstaffPage_Button.TabIndex = 6
        departmentstaffPage_Button.Text = "DEPARTMENT STAFF"
        departmentstaffPage_Button.UseVisualStyleBackColor = False
        ' 
        ' transcriptPage_Button
        ' 
        transcriptPage_Button.BackColor = Color.Maroon
        transcriptPage_Button.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        transcriptPage_Button.ForeColor = SystemColors.ButtonFace
        transcriptPage_Button.Location = New Point(77, 605)
        transcriptPage_Button.Name = "transcriptPage_Button"
        transcriptPage_Button.Size = New Size(424, 45)
        transcriptPage_Button.TabIndex = 7
        transcriptPage_Button.Text = "TRANSCRIPT"
        transcriptPage_Button.UseVisualStyleBackColor = False
        ' 
        ' courseregistrationPage_Button
        ' 
        courseregistrationPage_Button.BackColor = Color.Maroon
        courseregistrationPage_Button.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        courseregistrationPage_Button.ForeColor = SystemColors.ButtonFace
        courseregistrationPage_Button.Location = New Point(77, 554)
        courseregistrationPage_Button.Name = "courseregistrationPage_Button"
        courseregistrationPage_Button.Size = New Size(424, 48)
        courseregistrationPage_Button.TabIndex = 8
        courseregistrationPage_Button.Text = "COURSE REGISTRATION"
        courseregistrationPage_Button.UseVisualStyleBackColor = False
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageSize = New Size(16, 16)
        ImageList1.TransparentColor = Color.Transparent
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Maroon
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(385, 241)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(109, 38)
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Maroon
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(385, 348)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(109, 38)
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Maroon
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Location = New Point(385, 293)
        PictureBox4.Margin = New Padding(3, 2, 3, 2)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(109, 38)
        PictureBox4.TabIndex = 12
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Maroon
        PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), Image)
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox5.Location = New Point(385, 402)
        PictureBox5.Margin = New Padding(3, 2, 3, 2)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(109, 38)
        PictureBox5.TabIndex = 13
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.Maroon
        PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), Image)
        PictureBox6.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox6.Location = New Point(385, 456)
        PictureBox6.Margin = New Padding(3, 2, 3, 2)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(109, 38)
        PictureBox6.TabIndex = 14
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.Maroon
        PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), Image)
        PictureBox7.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox7.Location = New Point(385, 508)
        PictureBox7.Margin = New Padding(3, 2, 3, 2)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(109, 38)
        PictureBox7.TabIndex = 15
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = Color.Maroon
        PictureBox8.BackgroundImage = CType(resources.GetObject("PictureBox8.BackgroundImage"), Image)
        PictureBox8.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox8.Location = New Point(385, 559)
        PictureBox8.Margin = New Padding(3, 2, 3, 2)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(109, 38)
        PictureBox8.TabIndex = 16
        PictureBox8.TabStop = False
        ' 
        ' PictureBox9
        ' 
        PictureBox9.BackColor = Color.Maroon
        PictureBox9.BackgroundImage = CType(resources.GetObject("PictureBox9.BackgroundImage"), Image)
        PictureBox9.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox9.Location = New Point(385, 608)
        PictureBox9.Margin = New Padding(3, 2, 3, 2)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(109, 38)
        PictureBox9.TabIndex = 17
        PictureBox9.TabStop = False
        ' 
        ' PictureBox10
        ' 
        PictureBox10.BackColor = Color.Maroon
        PictureBox10.BackgroundImage = CType(resources.GetObject("PictureBox10.BackgroundImage"), Image)
        PictureBox10.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox10.Location = New Point(385, 896)
        PictureBox10.Margin = New Padding(3, 2, 3, 2)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(109, 38)
        PictureBox10.TabIndex = 19
        PictureBox10.TabStop = False
        ' 
        ' logout_Button
        ' 
        logout_Button.BackColor = Color.Maroon
        logout_Button.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        logout_Button.ForeColor = SystemColors.ButtonFace
        logout_Button.Location = New Point(77, 893)
        logout_Button.Name = "logout_Button"
        logout_Button.Size = New Size(424, 45)
        logout_Button.TabIndex = 18
        logout_Button.Text = "LOG OUT"
        logout_Button.UseVisualStyleBackColor = False
        ' 
        ' PictureBox11
        ' 
        PictureBox11.BackColor = Color.Maroon
        PictureBox11.BackgroundImage = CType(resources.GetObject("PictureBox11.BackgroundImage"), Image)
        PictureBox11.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox11.Location = New Point(385, 896)
        PictureBox11.Margin = New Padding(3, 2, 3, 2)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(109, 38)
        PictureBox11.TabIndex = 21
        PictureBox11.TabStop = False
        ' 
        ' createadmin_Button
        ' 
        createadmin_Button.BackColor = Color.Maroon
        createadmin_Button.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        createadmin_Button.ForeColor = SystemColors.ButtonFace
        createadmin_Button.Location = New Point(77, 893)
        createadmin_Button.Name = "createadmin_Button"
        createadmin_Button.Size = New Size(424, 45)
        createadmin_Button.TabIndex = 20
        createadmin_Button.Text = "CREATE ACCOUNT"
        createadmin_Button.UseVisualStyleBackColor = False
        ' 
        ' dashboard_Label
        ' 
        dashboard_Label.AutoSize = True
        dashboard_Label.BackColor = Color.Transparent
        dashboard_Label.Font = New Font("Segoe UI", 20F)
        dashboard_Label.ForeColor = SystemColors.HighlightText
        dashboard_Label.Location = New Point(540, 44)
        dashboard_Label.Margin = New Padding(2, 0, 2, 0)
        dashboard_Label.Name = "dashboard_Label"
        dashboard_Label.Size = New Size(96, 37)
        dashboard_Label.TabIndex = 22
        dashboard_Label.Text = "Label1"
        ' 
        ' Counts_Panel
        ' 
        Counts_Panel.BackColor = Color.Silver
        Counts_Panel.Controls.Add(Label2)
        Counts_Panel.Controls.Add(InstructorCount_Chart)
        Counts_Panel.Controls.Add(GenderCount_Chart)
        Counts_Panel.Controls.Add(StudentCount_Chart)
        Counts_Panel.Controls.Add(FemaleCount_Label)
        Counts_Panel.Controls.Add(MaleCount_Label)
        Counts_Panel.Controls.Add(StudentCount_Label)
        Counts_Panel.Location = New Point(653, 161)
        Counts_Panel.Margin = New Padding(2)
        Counts_Panel.Name = "Counts_Panel"
        Counts_Panel.Padding = New Padding(20)
        Counts_Panel.Size = New Size(930, 757)
        Counts_Panel.TabIndex = 23
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(527, 24)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(127, 15)
        Label2.TabIndex = 17
        Label2.Text = "Number of Instructors:"
        Label2.Visible = False
        ' 
        ' InstructorCount_Chart
        ' 
        ChartArea1.Name = "ChartArea1"
        InstructorCount_Chart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        InstructorCount_Chart.Legends.Add(Legend1)
        InstructorCount_Chart.Location = New Point(503, 57)
        InstructorCount_Chart.Margin = New Padding(2)
        InstructorCount_Chart.Name = "InstructorCount_Chart"
        InstructorCount_Chart.Palette = DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Count"
        InstructorCount_Chart.Series.Add(Series1)
        InstructorCount_Chart.Size = New Size(315, 208)
        InstructorCount_Chart.TabIndex = 16
        InstructorCount_Chart.Text = "Instructor Count"
        InstructorCount_Chart.Visible = False
        ' 
        ' GenderCount_Chart
        ' 
        ChartArea2.AxisX.Title = "Year"
        ChartArea2.AxisY.Title = "Count"
        ChartArea2.Name = "ChartArea1"
        GenderCount_Chart.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        GenderCount_Chart.Legends.Add(Legend2)
        GenderCount_Chart.Location = New Point(42, 429)
        GenderCount_Chart.Margin = New Padding(2)
        GenderCount_Chart.Name = "GenderCount_Chart"
        Series2.ChartArea = "ChartArea1"
        Series2.Color = Color.Cyan
        Series2.IsXValueIndexed = True
        Series2.Legend = "Legend1"
        Series2.Name = "Male"
        Series2.ShadowColor = Color.Transparent
        Series3.ChartArea = "ChartArea1"
        Series3.Color = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        Series3.IsXValueIndexed = True
        Series3.Legend = "Legend1"
        Series3.Name = "Female"
        Series3.ShadowColor = Color.White
        GenderCount_Chart.Series.Add(Series2)
        GenderCount_Chart.Series.Add(Series3)
        GenderCount_Chart.Size = New Size(421, 280)
        GenderCount_Chart.TabIndex = 15
        GenderCount_Chart.Text = "Gender Count"
        ' 
        ' StudentCount_Chart
        ' 
        ChartArea3.AxisX.Title = "Year"
        ChartArea3.AxisY.Title = "Count"
        ChartArea3.Name = "ChartArea1"
        StudentCount_Chart.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        StudentCount_Chart.Legends.Add(Legend3)
        StudentCount_Chart.Location = New Point(42, 57)
        StudentCount_Chart.Margin = New Padding(2)
        StudentCount_Chart.Name = "StudentCount_Chart"
        Series4.ChartArea = "ChartArea1"
        Series4.IsXValueIndexed = True
        Series4.Legend = "Legend1"
        Series4.Name = "Count"
        StudentCount_Chart.Series.Add(Series4)
        StudentCount_Chart.Size = New Size(421, 279)
        StudentCount_Chart.TabIndex = 14
        StudentCount_Chart.Text = "Student Count"
        Title1.Name = "Student Count"
        StudentCount_Chart.Titles.Add(Title1)
        ' 
        ' FemaleCount_Label
        ' 
        FemaleCount_Label.AutoSize = True
        FemaleCount_Label.Location = New Point(218, 401)
        FemaleCount_Label.Margin = New Padding(2, 0, 2, 0)
        FemaleCount_Label.Name = "FemaleCount_Label"
        FemaleCount_Label.Size = New Size(48, 15)
        FemaleCount_Label.TabIndex = 13
        FemaleCount_Label.Text = "Female:"
        ' 
        ' MaleCount_Label
        ' 
        MaleCount_Label.AutoSize = True
        MaleCount_Label.Location = New Point(55, 401)
        MaleCount_Label.Margin = New Padding(2, 0, 2, 0)
        MaleCount_Label.Name = "MaleCount_Label"
        MaleCount_Label.Size = New Size(36, 15)
        MaleCount_Label.TabIndex = 12
        MaleCount_Label.Text = "Male:"
        ' 
        ' StudentCount_Label
        ' 
        StudentCount_Label.AutoSize = True
        StudentCount_Label.Location = New Point(66, 29)
        StudentCount_Label.Margin = New Padding(2, 0, 2, 0)
        StudentCount_Label.Name = "StudentCount_Label"
        StudentCount_Label.Size = New Size(117, 15)
        StudentCount_Label.TabIndex = 11
        StudentCount_Label.Text = "Number of Students:"
        ' 
        ' UserManage_Button
        ' 
        UserManage_Button.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        UserManage_Button.BackColor = Color.Maroon
        UserManage_Button.Font = New Font("Segoe UI", 12F)
        UserManage_Button.ForeColor = Color.White
        UserManage_Button.Location = New Point(1586, 44)
        UserManage_Button.Name = "UserManage_Button"
        UserManage_Button.Size = New Size(260, 49)
        UserManage_Button.TabIndex = 24
        UserManage_Button.Text = "USER MANAGEMENT"
        UserManage_Button.UseVisualStyleBackColor = False
        ' 
        ' AdminPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1904, 1041)
        Controls.Add(UserManage_Button)
        Controls.Add(Counts_Panel)
        Controls.Add(dashboard_Label)
        Controls.Add(PictureBox11)
        Controls.Add(createadmin_Button)
        Controls.Add(PictureBox10)
        Controls.Add(logout_Button)
        Controls.Add(PictureBox9)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(courseregistrationPage_Button)
        Controls.Add(transcriptPage_Button)
        Controls.Add(departmentstaffPage_Button)
        Controls.Add(departmentPage_Button)
        Controls.Add(programPage_Button)
        Controls.Add(instructorPage_Button)
        Controls.Add(studentPage_Button)
        Controls.Add(coursePage_Button)
        DoubleBuffered = True
        Name = "AdminPage"
        Text = "AdminPage"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).EndInit()
        Counts_Panel.ResumeLayout(False)
        Counts_Panel.PerformLayout()
        CType(InstructorCount_Chart, ComponentModel.ISupportInitialize).EndInit()
        CType(GenderCount_Chart, ComponentModel.ISupportInitialize).EndInit()
        CType(StudentCount_Chart, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents blockPage_Button As Button
    Friend WithEvents coursePage_Button As Button
    Friend WithEvents studentPage_Button As Button
    Friend WithEvents instructorPage_Button As Button
    Friend WithEvents programPage_Button As Button
    Friend WithEvents departmentPage_Button As Button
    Friend WithEvents departmentstaffPage_Button As Button
    Friend WithEvents transcriptPage_Button As Button
    Friend WithEvents courseregistrationPage_Button As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents logout_Button As Button
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents createadmin_Button As Button
    Friend WithEvents dashboard_Label As Label
    Friend WithEvents Counts_Panel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents InstructorCount_Chart As DataVisualization.Charting.Chart
    Friend WithEvents GenderCount_Chart As DataVisualization.Charting.Chart
    Friend WithEvents StudentCount_Chart As DataVisualization.Charting.Chart
    Friend WithEvents FemaleCount_Label As Label
    Friend WithEvents MaleCount_Label As Label
    Friend WithEvents StudentCount_Label As Label
    Friend WithEvents UserManage_Button As Button
End Class
