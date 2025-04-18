<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CourseRegistrationList
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
        crlist_search_Button = New Button()
        crlist_add_Button = New Button()
        CourseRegistrationDataGridView = New DataGridView()
        Panel2 = New Panel()
        Label1 = New Label()
        Panel1 = New Panel()
        cr_schedule_SearchField = New TextBox()
        cr_schedule_Label = New Label()
        cr_semester_SearchField = New TextBox()
        cr_emester_Label = New Label()
        cr_enrollmentdate_SearchField = New TextBox()
        cr_enrollmentdate_Label = New Label()
        cr_instructorid_SearchField = New TextBox()
        cr_instructorid_Label = New Label()
        cr_programid_SearchField = New TextBox()
        cr_programid_Label = New Label()
        cr_courseid_SearchField = New TextBox()
        cr_courseid_Label = New Label()
        cr_blockid_SearchField = New TextBox()
        cr_blockid_Label = New Label()
        cr_studentid_SearchField = New TextBox()
        cr_studentid_Label = New Label()
        cr_registrationid_SearchField = New TextBox()
        cr_registrationid_Label = New Label()
        cr_back_Button = New Button()
        CType(CourseRegistrationDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' crlist_search_Button
        ' 
        crlist_search_Button.BackColor = Color.Maroon
        crlist_search_Button.FlatStyle = FlatStyle.Popup
        crlist_search_Button.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        crlist_search_Button.ForeColor = SystemColors.ControlLightLight
        crlist_search_Button.Location = New Point(561, 241)
        crlist_search_Button.Name = "crlist_search_Button"
        crlist_search_Button.Size = New Size(75, 29)
        crlist_search_Button.TabIndex = 15
        crlist_search_Button.Text = "Search"
        crlist_search_Button.UseVisualStyleBackColor = False
        ' 
        ' crlist_add_Button
        ' 
        crlist_add_Button.BackColor = Color.Maroon
        crlist_add_Button.FlatStyle = FlatStyle.Popup
        crlist_add_Button.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        crlist_add_Button.ForeColor = SystemColors.ControlLightLight
        crlist_add_Button.Location = New Point(1285, 256)
        crlist_add_Button.Name = "crlist_add_Button"
        crlist_add_Button.Size = New Size(75, 29)
        crlist_add_Button.TabIndex = 13
        crlist_add_Button.Text = "Add"
        crlist_add_Button.UseVisualStyleBackColor = False
        ' 
        ' CourseRegistrationDataGridView
        ' 
        CourseRegistrationDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        CourseRegistrationDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        CourseRegistrationDataGridView.Dock = DockStyle.Bottom
        CourseRegistrationDataGridView.Location = New Point(10, 189)
        CourseRegistrationDataGridView.Name = "CourseRegistrationDataGridView"
        CourseRegistrationDataGridView.Size = New Size(1350, 550)
        CourseRegistrationDataGridView.TabIndex = 12
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Maroon
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(10, 73)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(626, 32)
        Panel2.TabIndex = 37
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Maroon
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(19, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(40, 17)
        Label1.TabIndex = 40
        Label1.Text = "Filter"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.Controls.Add(cr_schedule_SearchField)
        Panel1.Controls.Add(cr_schedule_Label)
        Panel1.Controls.Add(cr_semester_SearchField)
        Panel1.Controls.Add(cr_emester_Label)
        Panel1.Controls.Add(cr_enrollmentdate_SearchField)
        Panel1.Controls.Add(cr_enrollmentdate_Label)
        Panel1.Controls.Add(cr_instructorid_SearchField)
        Panel1.Controls.Add(cr_instructorid_Label)
        Panel1.Controls.Add(cr_programid_SearchField)
        Panel1.Controls.Add(cr_programid_Label)
        Panel1.Controls.Add(cr_courseid_SearchField)
        Panel1.Controls.Add(cr_courseid_Label)
        Panel1.Controls.Add(cr_blockid_SearchField)
        Panel1.Controls.Add(cr_blockid_Label)
        Panel1.Controls.Add(cr_studentid_SearchField)
        Panel1.Controls.Add(cr_studentid_Label)
        Panel1.Controls.Add(cr_registrationid_SearchField)
        Panel1.Controls.Add(cr_registrationid_Label)
        Panel1.Location = New Point(10, 101)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(626, 139)
        Panel1.TabIndex = 38
        ' 
        ' cr_schedule_SearchField
        ' 
        cr_schedule_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_schedule_SearchField.Location = New Point(494, 88)
        cr_schedule_SearchField.Name = "cr_schedule_SearchField"
        cr_schedule_SearchField.Size = New Size(100, 25)
        cr_schedule_SearchField.TabIndex = 54
        ' 
        ' cr_schedule_Label
        ' 
        cr_schedule_Label.AutoSize = True
        cr_schedule_Label.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_schedule_Label.Location = New Point(426, 91)
        cr_schedule_Label.Name = "cr_schedule_Label"
        cr_schedule_Label.Size = New Size(62, 17)
        cr_schedule_Label.TabIndex = 53
        cr_schedule_Label.Text = "Schedule"
        ' 
        ' cr_semester_SearchField
        ' 
        cr_semester_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_semester_SearchField.Location = New Point(320, 88)
        cr_semester_SearchField.Name = "cr_semester_SearchField"
        cr_semester_SearchField.Size = New Size(100, 25)
        cr_semester_SearchField.TabIndex = 52
        ' 
        ' cr_emester_Label
        ' 
        cr_emester_Label.AutoSize = True
        cr_emester_Label.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_emester_Label.Location = New Point(242, 91)
        cr_emester_Label.Name = "cr_emester_Label"
        cr_emester_Label.Size = New Size(64, 17)
        cr_emester_Label.TabIndex = 51
        cr_emester_Label.Text = "Semester"
        ' 
        ' cr_enrollmentdate_SearchField
        ' 
        cr_enrollmentdate_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_enrollmentdate_SearchField.Location = New Point(136, 88)
        cr_enrollmentdate_SearchField.Name = "cr_enrollmentdate_SearchField"
        cr_enrollmentdate_SearchField.Size = New Size(100, 25)
        cr_enrollmentdate_SearchField.TabIndex = 50
        ' 
        ' cr_enrollmentdate_Label
        ' 
        cr_enrollmentdate_Label.AutoSize = True
        cr_enrollmentdate_Label.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_enrollmentdate_Label.Location = New Point(32, 91)
        cr_enrollmentdate_Label.Name = "cr_enrollmentdate_Label"
        cr_enrollmentdate_Label.Size = New Size(102, 17)
        cr_enrollmentdate_Label.TabIndex = 49
        cr_enrollmentdate_Label.Text = "EnrollmentDate"
        ' 
        ' cr_instructorid_SearchField
        ' 
        cr_instructorid_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_instructorid_SearchField.Location = New Point(490, 57)
        cr_instructorid_SearchField.Name = "cr_instructorid_SearchField"
        cr_instructorid_SearchField.Size = New Size(104, 25)
        cr_instructorid_SearchField.TabIndex = 48
        ' 
        ' cr_instructorid_Label
        ' 
        cr_instructorid_Label.AutoSize = True
        cr_instructorid_Label.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_instructorid_Label.Location = New Point(401, 61)
        cr_instructorid_Label.Name = "cr_instructorid_Label"
        cr_instructorid_Label.Size = New Size(85, 17)
        cr_instructorid_Label.TabIndex = 47
        cr_instructorid_Label.Text = "Instructor ID"
        ' 
        ' cr_programid_SearchField
        ' 
        cr_programid_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_programid_SearchField.Location = New Point(295, 58)
        cr_programid_SearchField.Name = "cr_programid_SearchField"
        cr_programid_SearchField.Size = New Size(100, 25)
        cr_programid_SearchField.TabIndex = 46
        ' 
        ' cr_programid_Label
        ' 
        cr_programid_Label.AutoSize = True
        cr_programid_Label.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_programid_Label.Location = New Point(211, 61)
        cr_programid_Label.Name = "cr_programid_Label"
        cr_programid_Label.Size = New Size(78, 17)
        cr_programid_Label.TabIndex = 45
        cr_programid_Label.Text = "Program ID"
        ' 
        ' cr_courseid_SearchField
        ' 
        cr_courseid_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_courseid_SearchField.Location = New Point(105, 57)
        cr_courseid_SearchField.Name = "cr_courseid_SearchField"
        cr_courseid_SearchField.Size = New Size(100, 25)
        cr_courseid_SearchField.TabIndex = 44
        ' 
        ' cr_courseid_Label
        ' 
        cr_courseid_Label.AutoSize = True
        cr_courseid_Label.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_courseid_Label.Location = New Point(32, 61)
        cr_courseid_Label.Name = "cr_courseid_Label"
        cr_courseid_Label.Size = New Size(67, 17)
        cr_courseid_Label.TabIndex = 43
        cr_courseid_Label.Text = "Course ID"
        ' 
        ' cr_blockid_SearchField
        ' 
        cr_blockid_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_blockid_SearchField.Location = New Point(490, 26)
        cr_blockid_SearchField.Name = "cr_blockid_SearchField"
        cr_blockid_SearchField.Size = New Size(104, 25)
        cr_blockid_SearchField.TabIndex = 42
        ' 
        ' cr_blockid_Label
        ' 
        cr_blockid_Label.AutoSize = True
        cr_blockid_Label.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_blockid_Label.Location = New Point(427, 29)
        cr_blockid_Label.Name = "cr_blockid_Label"
        cr_blockid_Label.Size = New Size(57, 17)
        cr_blockid_Label.TabIndex = 41
        cr_blockid_Label.Text = "Block ID"
        ' 
        ' cr_studentid_SearchField
        ' 
        cr_studentid_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_studentid_SearchField.Location = New Point(321, 26)
        cr_studentid_SearchField.Name = "cr_studentid_SearchField"
        cr_studentid_SearchField.Size = New Size(100, 25)
        cr_studentid_SearchField.TabIndex = 40
        ' 
        ' cr_studentid_Label
        ' 
        cr_studentid_Label.AutoSize = True
        cr_studentid_Label.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_studentid_Label.Location = New Point(242, 29)
        cr_studentid_Label.Name = "cr_studentid_Label"
        cr_studentid_Label.Size = New Size(73, 17)
        cr_studentid_Label.TabIndex = 39
        cr_studentid_Label.Text = "Student ID"
        ' 
        ' cr_registrationid_SearchField
        ' 
        cr_registrationid_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_registrationid_SearchField.Location = New Point(136, 26)
        cr_registrationid_SearchField.Name = "cr_registrationid_SearchField"
        cr_registrationid_SearchField.Size = New Size(100, 25)
        cr_registrationid_SearchField.TabIndex = 38
        ' 
        ' cr_registrationid_Label
        ' 
        cr_registrationid_Label.AutoSize = True
        cr_registrationid_Label.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_registrationid_Label.Location = New Point(32, 29)
        cr_registrationid_Label.Name = "cr_registrationid_Label"
        cr_registrationid_Label.Size = New Size(98, 17)
        cr_registrationid_Label.TabIndex = 37
        cr_registrationid_Label.Text = "Registration ID"
        ' 
        ' cr_back_Button
        ' 
        cr_back_Button.BackColor = Color.Maroon
        cr_back_Button.FlatStyle = FlatStyle.Popup
        cr_back_Button.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        cr_back_Button.ForeColor = SystemColors.ControlLightLight
        cr_back_Button.Location = New Point(1285, 13)
        cr_back_Button.Name = "cr_back_Button"
        cr_back_Button.Size = New Size(75, 29)
        cr_back_Button.TabIndex = 39
        cr_back_Button.Text = "Back"
        cr_back_Button.UseVisualStyleBackColor = False
        ' 
        ' CourseRegistrationList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.adminbg
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1370, 749)
        Controls.Add(crlist_search_Button)
        Controls.Add(cr_back_Button)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(crlist_add_Button)
        Controls.Add(CourseRegistrationDataGridView)
        Name = "CourseRegistrationList"
        Padding = New Padding(10)
        Text = "CourseRegistrationList"
        WindowState = FormWindowState.Maximized
        CType(CourseRegistrationDataGridView, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents crlist_search_Button As Button
    Friend WithEvents crlist_add_Button As Button
    Friend WithEvents CourseRegistrationDataGridView As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cr_schedule_SearchField As TextBox
    Friend WithEvents cr_schedule_Label As Label
    Friend WithEvents cr_semester_SearchField As TextBox
    Friend WithEvents cr_emester_Label As Label
    Friend WithEvents cr_enrollmentdate_SearchField As TextBox
    Friend WithEvents cr_enrollmentdate_Label As Label
    Friend WithEvents cr_instructorid_SearchField As TextBox
    Friend WithEvents cr_instructorid_Label As Label
    Friend WithEvents cr_programid_SearchField As TextBox
    Friend WithEvents cr_programid_Label As Label
    Friend WithEvents cr_courseid_SearchField As TextBox
    Friend WithEvents cr_courseid_Label As Label
    Friend WithEvents cr_blockid_SearchField As TextBox
    Friend WithEvents cr_blockid_Label As Label
    Friend WithEvents cr_studentid_SearchField As TextBox
    Friend WithEvents cr_studentid_Label As Label
    Friend WithEvents cr_registrationid_SearchField As TextBox
    Friend WithEvents cr_registrationid_Label As Label
    Friend WithEvents cr_back_Button As Button
    Friend WithEvents Label1 As Label
End Class
