<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditCourseRegistrationPage
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
        editcr_cancel_Button = New Button()
        editcr_save_Button = New Button()
        Panel1 = New Panel()
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
        ' editcr_cancel_Button
        ' 
        editcr_cancel_Button.BackColor = Color.Maroon
        editcr_cancel_Button.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        editcr_cancel_Button.ForeColor = Color.White
        editcr_cancel_Button.Location = New Point(1152, 588)
        editcr_cancel_Button.Name = "editcr_cancel_Button"
        editcr_cancel_Button.Size = New Size(75, 28)
        editcr_cancel_Button.TabIndex = 154
        editcr_cancel_Button.Text = "Cancel"
        editcr_cancel_Button.UseVisualStyleBackColor = False
        ' 
        ' editcr_save_Button
        ' 
        editcr_save_Button.BackColor = Color.Maroon
        editcr_save_Button.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        editcr_save_Button.ForeColor = Color.White
        editcr_save_Button.Location = New Point(1043, 588)
        editcr_save_Button.Name = "editcr_save_Button"
        editcr_save_Button.Size = New Size(75, 28)
        editcr_save_Button.TabIndex = 153
        editcr_save_Button.Text = "Save"
        editcr_save_Button.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
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
        Panel1.Location = New Point(430, 226)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(822, 338)
        Panel1.TabIndex = 155
        ' 
        ' cr_schedule_TextBox
        ' 
        cr_schedule_TextBox.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        cr_schedule_TextBox.Location = New Point(641, 198)
        cr_schedule_TextBox.Name = "cr_schedule_TextBox"
        cr_schedule_TextBox.Size = New Size(126, 25)
        cr_schedule_TextBox.TabIndex = 54
        ' 
        ' cr_schedule_Label
        ' 
        cr_schedule_Label.AutoSize = True
        cr_schedule_Label.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        cr_schedule_Label.Location = New Point(564, 200)
        cr_schedule_Label.Name = "cr_schedule_Label"
        cr_schedule_Label.Size = New Size(69, 19)
        cr_schedule_Label.TabIndex = 53
        cr_schedule_Label.Text = "Schedule"
        ' 
        ' cr_semester_TextBox
        ' 
        cr_semester_TextBox.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        cr_semester_TextBox.Location = New Point(420, 201)
        cr_semester_TextBox.Name = "cr_semester_TextBox"
        cr_semester_TextBox.Size = New Size(122, 25)
        cr_semester_TextBox.TabIndex = 52
        ' 
        ' cr_emester_Label
        ' 
        cr_emester_Label.AutoSize = True
        cr_emester_Label.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        cr_emester_Label.Location = New Point(332, 203)
        cr_emester_Label.Name = "cr_emester_Label"
        cr_emester_Label.Size = New Size(79, 19)
        cr_emester_Label.TabIndex = 51
        cr_emester_Label.Text = "Semenster"
        ' 
        ' cr_enrollmentdate_TextBox
        ' 
        cr_enrollmentdate_TextBox.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        cr_enrollmentdate_TextBox.Location = New Point(192, 201)
        cr_enrollmentdate_TextBox.Name = "cr_enrollmentdate_TextBox"
        cr_enrollmentdate_TextBox.Size = New Size(132, 25)
        cr_enrollmentdate_TextBox.TabIndex = 50
        ' 
        ' cr_enrollmentdate_Label
        ' 
        cr_enrollmentdate_Label.AutoSize = True
        cr_enrollmentdate_Label.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        cr_enrollmentdate_Label.Location = New Point(68, 203)
        cr_enrollmentdate_Label.Name = "cr_enrollmentdate_Label"
        cr_enrollmentdate_Label.Size = New Size(112, 19)
        cr_enrollmentdate_Label.TabIndex = 49
        cr_enrollmentdate_Label.Text = "EnrollmentDate"
        ' 
        ' cr_instructorid_TextBox
        ' 
        cr_instructorid_TextBox.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        cr_instructorid_TextBox.Location = New Point(641, 164)
        cr_instructorid_TextBox.Name = "cr_instructorid_TextBox"
        cr_instructorid_TextBox.Size = New Size(126, 25)
        cr_instructorid_TextBox.TabIndex = 48
        ' 
        ' cr_instructorid_Label
        ' 
        cr_instructorid_Label.AutoSize = True
        cr_instructorid_Label.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        cr_instructorid_Label.Location = New Point(539, 169)
        cr_instructorid_Label.Name = "cr_instructorid_Label"
        cr_instructorid_Label.Size = New Size(91, 19)
        cr_instructorid_Label.TabIndex = 47
        cr_instructorid_Label.Text = "Instructor ID"
        ' 
        ' cr_programid_TextBox
        ' 
        cr_programid_TextBox.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        cr_programid_TextBox.Location = New Point(419, 164)
        cr_programid_TextBox.Name = "cr_programid_TextBox"
        cr_programid_TextBox.Size = New Size(123, 25)
        cr_programid_TextBox.TabIndex = 46
        ' 
        ' cr_programid_Label
        ' 
        cr_programid_Label.AutoSize = True
        cr_programid_Label.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        cr_programid_Label.Location = New Point(324, 166)
        cr_programid_Label.Name = "cr_programid_Label"
        cr_programid_Label.Size = New Size(87, 19)
        cr_programid_Label.TabIndex = 45
        cr_programid_Label.Text = "Program ID"
        ' 
        ' cr_courseid_TextBox
        ' 
        cr_courseid_TextBox.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        cr_courseid_TextBox.Location = New Point(192, 166)
        cr_courseid_TextBox.Name = "cr_courseid_TextBox"
        cr_courseid_TextBox.Size = New Size(132, 25)
        cr_courseid_TextBox.TabIndex = 44
        ' 
        ' cr_courseid_Label
        ' 
        cr_courseid_Label.AutoSize = True
        cr_courseid_Label.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        cr_courseid_Label.Location = New Point(91, 169)
        cr_courseid_Label.Name = "cr_courseid_Label"
        cr_courseid_Label.Size = New Size(73, 19)
        cr_courseid_Label.TabIndex = 43
        cr_courseid_Label.Text = "Course ID"
        ' 
        ' cr_blockid_TextBox
        ' 
        cr_blockid_TextBox.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        cr_blockid_TextBox.Location = New Point(641, 126)
        cr_blockid_TextBox.Name = "cr_blockid_TextBox"
        cr_blockid_TextBox.Size = New Size(126, 25)
        cr_blockid_TextBox.TabIndex = 42
        ' 
        ' cr_blockid_Label
        ' 
        cr_blockid_Label.AutoSize = True
        cr_blockid_Label.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        cr_blockid_Label.Location = New Point(569, 128)
        cr_blockid_Label.Name = "cr_blockid_Label"
        cr_blockid_Label.Size = New Size(64, 19)
        cr_blockid_Label.TabIndex = 41
        cr_blockid_Label.Text = "Block ID"
        ' 
        ' cr_studentid_TextBox
        ' 
        cr_studentid_TextBox.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        cr_studentid_TextBox.Location = New Point(419, 126)
        cr_studentid_TextBox.Name = "cr_studentid_TextBox"
        cr_studentid_TextBox.Size = New Size(123, 25)
        cr_studentid_TextBox.TabIndex = 40
        ' 
        ' cr_studentid_Label
        ' 
        cr_studentid_Label.AutoSize = True
        cr_studentid_Label.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        cr_studentid_Label.Location = New Point(329, 128)
        cr_studentid_Label.Name = "cr_studentid_Label"
        cr_studentid_Label.Size = New Size(78, 19)
        cr_studentid_Label.TabIndex = 39
        cr_studentid_Label.Text = "Student ID"
        ' 
        ' cr_registrationid_TextBox
        ' 
        cr_registrationid_TextBox.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        cr_registrationid_TextBox.Location = New Point(192, 126)
        cr_registrationid_TextBox.Name = "cr_registrationid_TextBox"
        cr_registrationid_TextBox.PlaceholderText = "regID"
        cr_registrationid_TextBox.Size = New Size(132, 25)
        cr_registrationid_TextBox.TabIndex = 38
        ' 
        ' cr_registrationid_Label
        ' 
        cr_registrationid_Label.AutoSize = True
        cr_registrationid_Label.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        cr_registrationid_Label.Location = New Point(73, 128)
        cr_registrationid_Label.Name = "cr_registrationid_Label"
        cr_registrationid_Label.Size = New Size(108, 19)
        cr_registrationid_Label.TabIndex = 37
        cr_registrationid_Label.Text = "Registration ID"
        ' 
        ' EditCourseRegistrationPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.adminbg
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1684, 791)
        Controls.Add(Panel1)
        Controls.Add(editcr_cancel_Button)
        Controls.Add(editcr_save_Button)
        Name = "EditCourseRegistrationPage"
        Text = "EditCourseRegistrationPage"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents editcr_cancel_Button As Button
    Friend WithEvents editcr_save_Button As Button
    Friend WithEvents Panel1 As Panel
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
