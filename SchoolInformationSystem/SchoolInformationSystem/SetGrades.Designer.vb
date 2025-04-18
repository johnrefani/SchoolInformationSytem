<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetGrades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SetGrades))
        Panel4 = New Panel()
        viewSubjects_Button = New Button()
        profile_Button = New Button()
        courseReg_Button = New Button()
        setGrades_Button = New Button()
        logout_Button = New Button()
        PictureBox1 = New PictureBox()
        StudentGrades_DGV = New DataGridView()
        Panel2 = New Panel()
        Label2 = New Label()
        Panel1 = New Panel()
        suffix_TextBox = New TextBox()
        search_Button = New Button()
        idNumber_TextBox = New TextBox()
        student_idno_Label = New Label()
        student_name_Label = New Label()
        middlename_TextBox = New TextBox()
        firstname_TextBox = New TextBox()
        lastname_TextBox = New TextBox()
        Panel4.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(StudentGrades_DGV, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.IndianRed
        Panel4.Controls.Add(viewSubjects_Button)
        Panel4.Controls.Add(profile_Button)
        Panel4.Controls.Add(courseReg_Button)
        Panel4.Controls.Add(setGrades_Button)
        Panel4.Controls.Add(logout_Button)
        Panel4.Controls.Add(PictureBox1)
        Panel4.Location = New Point(-1, -1)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(246, 1048)
        Panel4.TabIndex = 152
        ' 
        ' viewSubjects_Button
        ' 
        viewSubjects_Button.BackColor = Color.Maroon
        viewSubjects_Button.FlatStyle = FlatStyle.Popup
        viewSubjects_Button.ForeColor = SystemColors.ControlLightLight
        viewSubjects_Button.Location = New Point(66, 565)
        viewSubjects_Button.Name = "viewSubjects_Button"
        viewSubjects_Button.Size = New Size(117, 42)
        viewSubjects_Button.TabIndex = 8
        viewSubjects_Button.Text = "View Assigned Subjects"
        viewSubjects_Button.UseVisualStyleBackColor = False
        ' 
        ' profile_Button
        ' 
        profile_Button.BackColor = Color.Maroon
        profile_Button.FlatStyle = FlatStyle.Popup
        profile_Button.ForeColor = SystemColors.ControlLightLight
        profile_Button.Location = New Point(66, 374)
        profile_Button.Name = "profile_Button"
        profile_Button.Size = New Size(117, 42)
        profile_Button.TabIndex = 7
        profile_Button.Text = "Profile"
        profile_Button.UseVisualStyleBackColor = False
        ' 
        ' courseReg_Button
        ' 
        courseReg_Button.BackColor = Color.Maroon
        courseReg_Button.FlatStyle = FlatStyle.Popup
        courseReg_Button.ForeColor = SystemColors.ControlLightLight
        courseReg_Button.Location = New Point(66, 438)
        courseReg_Button.Name = "courseReg_Button"
        courseReg_Button.Size = New Size(117, 42)
        courseReg_Button.TabIndex = 6
        courseReg_Button.Text = "Course Registrations"
        courseReg_Button.UseVisualStyleBackColor = False
        ' 
        ' setGrades_Button
        ' 
        setGrades_Button.BackColor = Color.Maroon
        setGrades_Button.FlatStyle = FlatStyle.Popup
        setGrades_Button.ForeColor = SystemColors.ControlLightLight
        setGrades_Button.Location = New Point(66, 502)
        setGrades_Button.Name = "setGrades_Button"
        setGrades_Button.Size = New Size(117, 42)
        setGrades_Button.TabIndex = 5
        setGrades_Button.Text = "Set Student Grades"
        setGrades_Button.UseVisualStyleBackColor = False
        ' 
        ' logout_Button
        ' 
        logout_Button.BackColor = Color.Maroon
        logout_Button.FlatStyle = FlatStyle.Popup
        logout_Button.ForeColor = SystemColors.ControlLightLight
        logout_Button.Location = New Point(66, 778)
        logout_Button.Name = "logout_Button"
        logout_Button.Size = New Size(117, 42)
        logout_Button.TabIndex = 4
        logout_Button.Text = "Log Out"
        logout_Button.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(71, 70)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 96)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' StudentGrades_DGV
        ' 
        StudentGrades_DGV.AllowUserToOrderColumns = True
        StudentGrades_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        StudentGrades_DGV.Location = New Point(265, 393)
        StudentGrades_DGV.Name = "StudentGrades_DGV"
        StudentGrades_DGV.Size = New Size(1150, 636)
        StudentGrades_DGV.TabIndex = 153
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Maroon
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(276, 74)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1110, 44)
        Panel2.TabIndex = 177
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(509, 8)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 32)
        Label2.TabIndex = 0
        Label2.Text = "F I L T E R"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.Controls.Add(suffix_TextBox)
        Panel1.Controls.Add(search_Button)
        Panel1.Controls.Add(idNumber_TextBox)
        Panel1.Controls.Add(student_idno_Label)
        Panel1.Controls.Add(student_name_Label)
        Panel1.Controls.Add(middlename_TextBox)
        Panel1.Controls.Add(firstname_TextBox)
        Panel1.Controls.Add(lastname_TextBox)
        Panel1.Location = New Point(276, 111)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(9, 8, 9, 8)
        Panel1.Size = New Size(1107, 267)
        Panel1.TabIndex = 176
        ' 
        ' suffix_TextBox
        ' 
        suffix_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        suffix_TextBox.Location = New Point(543, 126)
        suffix_TextBox.Margin = New Padding(3, 2, 3, 2)
        suffix_TextBox.Name = "suffix_TextBox"
        suffix_TextBox.PlaceholderText = "Suffix"
        suffix_TextBox.Size = New Size(90, 26)
        suffix_TextBox.TabIndex = 172
        ' 
        ' search_Button
        ' 
        search_Button.BackColor = Color.Maroon
        search_Button.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        search_Button.ForeColor = Color.White
        search_Button.Location = New Point(938, 202)
        search_Button.Name = "search_Button"
        search_Button.Size = New Size(124, 45)
        search_Button.TabIndex = 175
        search_Button.Text = "Search"
        search_Button.UseVisualStyleBackColor = False
        ' 
        ' idNumber_TextBox
        ' 
        idNumber_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        idNumber_TextBox.Location = New Point(824, 123)
        idNumber_TextBox.Name = "idNumber_TextBox"
        idNumber_TextBox.Size = New Size(151, 26)
        idNumber_TextBox.TabIndex = 168
        ' 
        ' student_idno_Label
        ' 
        student_idno_Label.AutoSize = True
        student_idno_Label.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        student_idno_Label.Location = New Point(736, 126)
        student_idno_Label.Name = "student_idno_Label"
        student_idno_Label.Size = New Size(82, 19)
        student_idno_Label.TabIndex = 167
        student_idno_Label.Text = "ID Number"
        ' 
        ' student_name_Label
        ' 
        student_name_Label.AutoSize = True
        student_name_Label.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        student_name_Label.Location = New Point(38, 130)
        student_name_Label.Name = "student_name_Label"
        student_name_Label.Size = New Size(49, 19)
        student_name_Label.TabIndex = 151
        student_name_Label.Text = "Name"
        ' 
        ' middlename_TextBox
        ' 
        middlename_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        middlename_TextBox.Location = New Point(393, 127)
        middlename_TextBox.Name = "middlename_TextBox"
        middlename_TextBox.PlaceholderText = "Middle Name"
        middlename_TextBox.Size = New Size(142, 26)
        middlename_TextBox.TabIndex = 149
        ' 
        ' firstname_TextBox
        ' 
        firstname_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        firstname_TextBox.Location = New Point(239, 127)
        firstname_TextBox.Name = "firstname_TextBox"
        firstname_TextBox.PlaceholderText = "First Name"
        firstname_TextBox.Size = New Size(139, 26)
        firstname_TextBox.TabIndex = 148
        ' 
        ' lastname_TextBox
        ' 
        lastname_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        lastname_TextBox.Location = New Point(93, 127)
        lastname_TextBox.Name = "lastname_TextBox"
        lastname_TextBox.PlaceholderText = "Last Name"
        lastname_TextBox.Size = New Size(140, 26)
        lastname_TextBox.TabIndex = 147
        ' 
        ' SetGrades
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.adminbg
        ClientSize = New Size(1904, 1041)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(StudentGrades_DGV)
        Controls.Add(Panel4)
        Name = "SetGrades"
        WindowState = FormWindowState.Maximized
        Panel4.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(StudentGrades_DGV, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents viewSubjects_Button As Button
    Friend WithEvents profile_Button As Button
    Friend WithEvents courseReg_Button As Button
    Friend WithEvents setGrades_Button As Button
    Friend WithEvents logout_Button As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents StudentGrades_DGV As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents suffix_TextBox As TextBox
    Friend WithEvents idNumber_TextBox As TextBox
    Friend WithEvents student_idno_Label As Label
    Friend WithEvents student_name_Label As Label
    Friend WithEvents middlename_TextBox As TextBox
    Friend WithEvents firstname_TextBox As TextBox
    Friend WithEvents lastname_TextBox As TextBox
    Friend WithEvents search_Button As Button
End Class
