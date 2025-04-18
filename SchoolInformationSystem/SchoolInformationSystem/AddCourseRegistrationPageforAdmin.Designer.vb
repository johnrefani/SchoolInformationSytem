<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCourseRegistrationPageforAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddCourseRegistrationPageforAdmin))
        Panel1 = New Panel()
        addcoursereg_back_Button = New Button()
        courseregistration_add_Button = New Button()
        cr_schedule_TextBox = New TextBox()
        cr_schedule_Label = New Label()
        cr_semester_TextBox = New TextBox()
        cr_emester_Label = New Label()
        cr_enrollmentdate_TextBox = New TextBox()
        cr_enrollmentdate_Label = New Label()
        cr_instructorid_TextBox = New TextBox()
        cr_instructorid_Label = New Label()
        cr_programid_TextBox = New TextBox()
        cr_programid_Label = New Label()
        cr_courseid_TextBox = New TextBox()
        cr_courseid_Label = New Label()
        cr_blockid_TextBox = New TextBox()
        cr_blockid_Label = New Label()
        cr_studentid_TextBox = New TextBox()
        cr_studentid_Label = New Label()
        cr_registrationid_TextBox = New TextBox()
        cr_registrationid_Label = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.Controls.Add(addcoursereg_back_Button)
        Panel1.Controls.Add(courseregistration_add_Button)
        Panel1.Controls.Add(cr_schedule_TextBox)
        Panel1.Controls.Add(cr_schedule_Label)
        Panel1.Controls.Add(cr_semester_TextBox)
        Panel1.Controls.Add(cr_emester_Label)
        Panel1.Controls.Add(cr_enrollmentdate_TextBox)
        Panel1.Controls.Add(cr_enrollmentdate_Label)
        Panel1.Controls.Add(cr_instructorid_TextBox)
        Panel1.Controls.Add(cr_instructorid_Label)
        Panel1.Controls.Add(cr_programid_TextBox)
        Panel1.Controls.Add(cr_programid_Label)
        Panel1.Controls.Add(cr_courseid_TextBox)
        Panel1.Controls.Add(cr_courseid_Label)
        Panel1.Controls.Add(cr_blockid_TextBox)
        Panel1.Controls.Add(cr_blockid_Label)
        Panel1.Controls.Add(cr_studentid_TextBox)
        Panel1.Controls.Add(cr_studentid_Label)
        Panel1.Controls.Add(cr_registrationid_TextBox)
        Panel1.Controls.Add(cr_registrationid_Label)
        Panel1.Location = New Point(313, 274)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(940, 450)
        Panel1.TabIndex = 23
        ' 
        ' addcoursereg_back_Button
        ' 
        addcoursereg_back_Button.BackColor = Color.Maroon
        addcoursereg_back_Button.Cursor = Cursors.Hand
        addcoursereg_back_Button.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        addcoursereg_back_Button.ForeColor = SystemColors.ControlLightLight
        addcoursereg_back_Button.Location = New Point(811, 28)
        addcoursereg_back_Button.Margin = New Padding(3, 4, 3, 4)
        addcoursereg_back_Button.Name = "addcoursereg_back_Button"
        addcoursereg_back_Button.Size = New Size(86, 36)
        addcoursereg_back_Button.TabIndex = 42
        addcoursereg_back_Button.Text = "Back"
        addcoursereg_back_Button.UseVisualStyleBackColor = False
        ' 
        ' courseregistration_add_Button
        ' 
        courseregistration_add_Button.BackColor = Color.Maroon
        courseregistration_add_Button.Cursor = Cursors.Hand
        courseregistration_add_Button.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        courseregistration_add_Button.ForeColor = SystemColors.ControlLightLight
        courseregistration_add_Button.Location = New Point(430, 324)
        courseregistration_add_Button.Margin = New Padding(3, 4, 3, 4)
        courseregistration_add_Button.Name = "courseregistration_add_Button"
        courseregistration_add_Button.Size = New Size(86, 36)
        courseregistration_add_Button.TabIndex = 41
        courseregistration_add_Button.Text = "Add"
        courseregistration_add_Button.UseVisualStyleBackColor = False
        ' 
        ' cr_schedule_TextBox
        ' 
        cr_schedule_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_schedule_TextBox.Location = New Point(683, 229)
        cr_schedule_TextBox.Margin = New Padding(3, 4, 3, 4)
        cr_schedule_TextBox.Name = "cr_schedule_TextBox"
        cr_schedule_TextBox.Size = New Size(187, 29)
        cr_schedule_TextBox.TabIndex = 40
        ' 
        ' cr_schedule_Label
        ' 
        cr_schedule_Label.AutoSize = True
        cr_schedule_Label.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_schedule_Label.Location = New Point(604, 233)
        cr_schedule_Label.Name = "cr_schedule_Label"
        cr_schedule_Label.Size = New Size(79, 23)
        cr_schedule_Label.TabIndex = 39
        cr_schedule_Label.Text = "Schedule"
        ' 
        ' cr_semester_TextBox
        ' 
        cr_semester_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_semester_TextBox.Location = New Point(430, 229)
        cr_semester_TextBox.Margin = New Padding(3, 4, 3, 4)
        cr_semester_TextBox.Name = "cr_semester_TextBox"
        cr_semester_TextBox.Size = New Size(154, 29)
        cr_semester_TextBox.TabIndex = 38
        ' 
        ' cr_emester_Label
        ' 
        cr_emester_Label.AutoSize = True
        cr_emester_Label.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_emester_Label.Location = New Point(349, 233)
        cr_emester_Label.Name = "cr_emester_Label"
        cr_emester_Label.Size = New Size(80, 23)
        cr_emester_Label.TabIndex = 37
        cr_emester_Label.Text = "Semester"
        ' 
        ' cr_enrollmentdate_TextBox
        ' 
        cr_enrollmentdate_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_enrollmentdate_TextBox.Location = New Point(203, 229)
        cr_enrollmentdate_TextBox.Margin = New Padding(3, 4, 3, 4)
        cr_enrollmentdate_TextBox.Name = "cr_enrollmentdate_TextBox"
        cr_enrollmentdate_TextBox.PlaceholderText = "YYYY-MM-DD"
        cr_enrollmentdate_TextBox.Size = New Size(135, 29)
        cr_enrollmentdate_TextBox.TabIndex = 36
        ' 
        ' cr_enrollmentdate_Label
        ' 
        cr_enrollmentdate_Label.AutoSize = True
        cr_enrollmentdate_Label.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_enrollmentdate_Label.Location = New Point(82, 233)
        cr_enrollmentdate_Label.Name = "cr_enrollmentdate_Label"
        cr_enrollmentdate_Label.Size = New Size(129, 23)
        cr_enrollmentdate_Label.TabIndex = 35
        cr_enrollmentdate_Label.Text = "EnrollmentDate"
        ' 
        ' cr_instructorid_TextBox
        ' 
        cr_instructorid_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_instructorid_TextBox.Location = New Point(724, 181)
        cr_instructorid_TextBox.Margin = New Padding(3, 4, 3, 4)
        cr_instructorid_TextBox.Name = "cr_instructorid_TextBox"
        cr_instructorid_TextBox.Size = New Size(146, 29)
        cr_instructorid_TextBox.TabIndex = 34
        ' 
        ' cr_instructorid_Label
        ' 
        cr_instructorid_Label.AutoSize = True
        cr_instructorid_Label.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_instructorid_Label.Location = New Point(618, 185)
        cr_instructorid_Label.Name = "cr_instructorid_Label"
        cr_instructorid_Label.Size = New Size(106, 23)
        cr_instructorid_Label.TabIndex = 33
        cr_instructorid_Label.Text = "Instructor ID"
        ' 
        ' cr_programid_TextBox
        ' 
        cr_programid_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_programid_TextBox.Location = New Point(445, 181)
        cr_programid_TextBox.Margin = New Padding(3, 4, 3, 4)
        cr_programid_TextBox.Name = "cr_programid_TextBox"
        cr_programid_TextBox.Size = New Size(154, 29)
        cr_programid_TextBox.TabIndex = 32
        ' 
        ' cr_programid_Label
        ' 
        cr_programid_Label.AutoSize = True
        cr_programid_Label.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_programid_Label.Location = New Point(347, 185)
        cr_programid_Label.Name = "cr_programid_Label"
        cr_programid_Label.Size = New Size(98, 23)
        cr_programid_Label.TabIndex = 31
        cr_programid_Label.Text = "Program ID"
        ' 
        ' cr_courseid_TextBox
        ' 
        cr_courseid_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_courseid_TextBox.Location = New Point(168, 181)
        cr_courseid_TextBox.Margin = New Padding(3, 4, 3, 4)
        cr_courseid_TextBox.Name = "cr_courseid_TextBox"
        cr_courseid_TextBox.Size = New Size(161, 29)
        cr_courseid_TextBox.TabIndex = 30
        ' 
        ' cr_courseid_Label
        ' 
        cr_courseid_Label.AutoSize = True
        cr_courseid_Label.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_courseid_Label.Location = New Point(82, 185)
        cr_courseid_Label.Name = "cr_courseid_Label"
        cr_courseid_Label.Size = New Size(85, 23)
        cr_courseid_Label.TabIndex = 29
        cr_courseid_Label.Text = "Course ID"
        ' 
        ' cr_blockid_TextBox
        ' 
        cr_blockid_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_blockid_TextBox.Location = New Point(716, 133)
        cr_blockid_TextBox.Margin = New Padding(3, 4, 3, 4)
        cr_blockid_TextBox.Name = "cr_blockid_TextBox"
        cr_blockid_TextBox.Size = New Size(154, 29)
        cr_blockid_TextBox.TabIndex = 28
        ' 
        ' cr_blockid_Label
        ' 
        cr_blockid_Label.AutoSize = True
        cr_blockid_Label.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_blockid_Label.Location = New Point(642, 137)
        cr_blockid_Label.Name = "cr_blockid_Label"
        cr_blockid_Label.Size = New Size(73, 23)
        cr_blockid_Label.TabIndex = 27
        cr_blockid_Label.Text = "Block ID"
        ' 
        ' cr_studentid_TextBox
        ' 
        cr_studentid_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_studentid_TextBox.Location = New Point(474, 133)
        cr_studentid_TextBox.Margin = New Padding(3, 4, 3, 4)
        cr_studentid_TextBox.Name = "cr_studentid_TextBox"
        cr_studentid_TextBox.Size = New Size(154, 29)
        cr_studentid_TextBox.TabIndex = 26
        ' 
        ' cr_studentid_Label
        ' 
        cr_studentid_Label.AutoSize = True
        cr_studentid_Label.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_studentid_Label.Location = New Point(381, 137)
        cr_studentid_Label.Name = "cr_studentid_Label"
        cr_studentid_Label.Size = New Size(92, 23)
        cr_studentid_Label.TabIndex = 25
        cr_studentid_Label.Text = "Student ID"
        ' 
        ' cr_registrationid_TextBox
        ' 
        cr_registrationid_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_registrationid_TextBox.Location = New Point(203, 133)
        cr_registrationid_TextBox.Margin = New Padding(3, 4, 3, 4)
        cr_registrationid_TextBox.Name = "cr_registrationid_TextBox"
        cr_registrationid_TextBox.PlaceholderText = "Reg ID"
        cr_registrationid_TextBox.Size = New Size(161, 29)
        cr_registrationid_TextBox.TabIndex = 24
        ' 
        ' cr_registrationid_Label
        ' 
        cr_registrationid_Label.AutoSize = True
        cr_registrationid_Label.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cr_registrationid_Label.Location = New Point(82, 137)
        cr_registrationid_Label.Name = "cr_registrationid_Label"
        cr_registrationid_Label.Size = New Size(124, 23)
        cr_registrationid_Label.TabIndex = 23
        cr_registrationid_Label.Text = "Registration ID"
        ' 
        ' AddCourseRegistrationPageforAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1566, 999)
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "AddCourseRegistrationPageforAdmin"
        Text = "Add Course Registration For Admin"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents addcoursereg_back_Button As Button
    Friend WithEvents courseregistration_add_Button As Button
    Friend WithEvents cr_schedule_TextBox As TextBox
    Friend WithEvents cr_schedule_Label As Label
    Friend WithEvents cr_semester_TextBox As TextBox
    Friend WithEvents cr_emester_Label As Label
    Friend WithEvents cr_enrollmentdate_TextBox As TextBox
    Friend WithEvents cr_enrollmentdate_Label As Label
    Friend WithEvents cr_instructorid_TextBox As TextBox
    Friend WithEvents cr_instructorid_Label As Label
    Friend WithEvents cr_programid_TextBox As TextBox
    Friend WithEvents cr_programid_Label As Label
    Friend WithEvents cr_courseid_TextBox As TextBox
    Friend WithEvents cr_courseid_Label As Label
    Friend WithEvents cr_blockid_TextBox As TextBox
    Friend WithEvents cr_blockid_Label As Label
    Friend WithEvents cr_studentid_TextBox As TextBox
    Friend WithEvents cr_studentid_Label As Label
    Friend WithEvents cr_registrationid_TextBox As TextBox
    Friend WithEvents cr_registrationid_Label As Label
End Class
