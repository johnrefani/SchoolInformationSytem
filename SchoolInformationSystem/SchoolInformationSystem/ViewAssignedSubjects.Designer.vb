<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewAssignedSubjects
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewAssignedSubjects))
        Panel4 = New Panel()
        viewSubjects_Button = New Button()
        profile_Button = New Button()
        courseReg_Button = New Button()
        setGrades_Button = New Button()
        logout_Button = New Button()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        assignedSubjects_DGV = New DataGridView()
        Panel3 = New Panel()
        Panel4.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(assignedSubjects_DGV, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel4.Location = New Point(-2, -1)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(246, 1048)
        Panel4.TabIndex = 151
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
        ' Panel1
        ' 
        Panel1.Controls.Add(assignedSubjects_DGV)
        Panel1.Controls.Add(Panel3)
        Panel1.Location = New Point(442, 214)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1020, 612)
        Panel1.TabIndex = 152
        ' 
        ' assignedSubjects_DGV
        ' 
        assignedSubjects_DGV.AllowUserToOrderColumns = True
        assignedSubjects_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        assignedSubjects_DGV.Location = New Point(16, 115)
        assignedSubjects_DGV.Name = "assignedSubjects_DGV"
        assignedSubjects_DGV.Size = New Size(987, 476)
        assignedSubjects_DGV.TabIndex = 24
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Maroon
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1033, 96)
        Panel3.TabIndex = 23
        ' 
        ' ViewAssignedSubjects
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.adminbg
        ClientSize = New Size(1904, 1041)
        Controls.Add(Panel1)
        Controls.Add(Panel4)
        Name = "ViewAssignedSubjects"
        Text = "Assigned Subjects"
        WindowState = FormWindowState.Maximized
        Panel4.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(assignedSubjects_DGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents viewSubjects_Button As Button
    Friend WithEvents profile_Button As Button
    Friend WithEvents courseReg_Button As Button
    Friend WithEvents setGrades_Button As Button
    Friend WithEvents logout_Button As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents assignedSubjects_DGV As DataGridView
    Friend WithEvents Panel3 As Panel
End Class
