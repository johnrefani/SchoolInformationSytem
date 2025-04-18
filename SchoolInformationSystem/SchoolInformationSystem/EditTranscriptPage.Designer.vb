<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditTranscriptPage
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
        edittranscript_save_Button = New Button()
        edittranscript_cancel_Button = New Button()
        Panel1 = New Panel()
        edittranscript_remarks_TextBox = New TextBox()
        Label7 = New Label()
        edittranscript_grades_TextBox = New TextBox()
        Label6 = New Label()
        edittranscript_semester_TextBox = New TextBox()
        Label5 = New Label()
        edittranscript_programid_TextBox = New TextBox()
        Label4 = New Label()
        edittranscript_instructorid_TextBox = New TextBox()
        Label3 = New Label()
        edittranscript_courseid_TextBox = New TextBox()
        Label2 = New Label()
        edittranscript_studentid_TextBox = New TextBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' edittranscript_save_Button
        ' 
        edittranscript_save_Button.BackColor = Color.Maroon
        edittranscript_save_Button.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        edittranscript_save_Button.ForeColor = Color.White
        edittranscript_save_Button.Location = New Point(787, 637)
        edittranscript_save_Button.Margin = New Padding(2)
        edittranscript_save_Button.Name = "edittranscript_save_Button"
        edittranscript_save_Button.Size = New Size(90, 40)
        edittranscript_save_Button.TabIndex = 2
        edittranscript_save_Button.Text = "Save"
        edittranscript_save_Button.UseVisualStyleBackColor = False
        ' 
        ' edittranscript_cancel_Button
        ' 
        edittranscript_cancel_Button.BackColor = Color.Maroon
        edittranscript_cancel_Button.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        edittranscript_cancel_Button.ForeColor = Color.White
        edittranscript_cancel_Button.Location = New Point(955, 637)
        edittranscript_cancel_Button.Margin = New Padding(2)
        edittranscript_cancel_Button.Name = "edittranscript_cancel_Button"
        edittranscript_cancel_Button.Size = New Size(90, 40)
        edittranscript_cancel_Button.TabIndex = 15
        edittranscript_cancel_Button.Text = "Cancel"
        edittranscript_cancel_Button.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLight
        Panel1.Controls.Add(edittranscript_remarks_TextBox)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(edittranscript_grades_TextBox)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(edittranscript_semester_TextBox)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(edittranscript_programid_TextBox)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(edittranscript_instructorid_TextBox)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(edittranscript_courseid_TextBox)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(edittranscript_studentid_TextBox)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(450, 182)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(940, 450)
        Panel1.TabIndex = 16
        ' 
        ' edittranscript_remarks_TextBox
        ' 
        edittranscript_remarks_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        edittranscript_remarks_TextBox.Location = New Point(666, 269)
        edittranscript_remarks_TextBox.Margin = New Padding(2)
        edittranscript_remarks_TextBox.Name = "edittranscript_remarks_TextBox"
        edittranscript_remarks_TextBox.Size = New Size(126, 30)
        edittranscript_remarks_TextBox.TabIndex = 28
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label7.Location = New Point(583, 272)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.RightToLeft = RightToLeft.No
        Label7.Size = New Size(79, 23)
        Label7.TabIndex = 27
        Label7.Text = "Remarks"
        ' 
        ' edittranscript_grades_TextBox
        ' 
        edittranscript_grades_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        edittranscript_grades_TextBox.Location = New Point(463, 269)
        edittranscript_grades_TextBox.Margin = New Padding(2)
        edittranscript_grades_TextBox.Name = "edittranscript_grades_TextBox"
        edittranscript_grades_TextBox.Size = New Size(116, 30)
        edittranscript_grades_TextBox.TabIndex = 26
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label6.Location = New Point(386, 272)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(65, 23)
        Label6.TabIndex = 25
        Label6.Text = "Grades"
        ' 
        ' edittranscript_semester_TextBox
        ' 
        edittranscript_semester_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        edittranscript_semester_TextBox.Location = New Point(266, 269)
        edittranscript_semester_TextBox.Margin = New Padding(2)
        edittranscript_semester_TextBox.Name = "edittranscript_semester_TextBox"
        edittranscript_semester_TextBox.Size = New Size(116, 30)
        edittranscript_semester_TextBox.TabIndex = 24
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label5.Location = New Point(175, 269)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 23)
        Label5.TabIndex = 23
        Label5.Text = "Semester"
        ' 
        ' edittranscript_programid_TextBox
        ' 
        edittranscript_programid_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        edittranscript_programid_TextBox.Location = New Point(607, 215)
        edittranscript_programid_TextBox.Margin = New Padding(2)
        edittranscript_programid_TextBox.Name = "edittranscript_programid_TextBox"
        edittranscript_programid_TextBox.Size = New Size(185, 30)
        edittranscript_programid_TextBox.TabIndex = 22
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label4.Location = New Point(483, 212)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(103, 23)
        Label4.TabIndex = 21
        Label4.Text = "Program ID"
        ' 
        ' edittranscript_instructorid_TextBox
        ' 
        edittranscript_instructorid_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        edittranscript_instructorid_TextBox.Location = New Point(266, 212)
        edittranscript_instructorid_TextBox.Margin = New Padding(2)
        edittranscript_instructorid_TextBox.Name = "edittranscript_instructorid_TextBox"
        edittranscript_instructorid_TextBox.Size = New Size(185, 30)
        edittranscript_instructorid_TextBox.TabIndex = 20
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label3.Location = New Point(148, 212)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(111, 23)
        Label3.TabIndex = 19
        Label3.Text = "Instructor ID"
        ' 
        ' edittranscript_courseid_TextBox
        ' 
        edittranscript_courseid_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        edittranscript_courseid_TextBox.Location = New Point(607, 152)
        edittranscript_courseid_TextBox.Margin = New Padding(2)
        edittranscript_courseid_TextBox.Name = "edittranscript_courseid_TextBox"
        edittranscript_courseid_TextBox.Size = New Size(185, 30)
        edittranscript_courseid_TextBox.TabIndex = 18
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label2.Location = New Point(499, 152)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 23)
        Label2.TabIndex = 17
        Label2.Text = "Course ID"
        ' 
        ' edittranscript_studentid_TextBox
        ' 
        edittranscript_studentid_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        edittranscript_studentid_TextBox.Location = New Point(266, 152)
        edittranscript_studentid_TextBox.Margin = New Padding(2)
        edittranscript_studentid_TextBox.Name = "edittranscript_studentid_TextBox"
        edittranscript_studentid_TextBox.Size = New Size(185, 30)
        edittranscript_studentid_TextBox.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label1.Location = New Point(162, 152)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 23)
        Label1.TabIndex = 15
        Label1.Text = "Student ID"
        ' 
        ' EditTranscriptPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.adminbg
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1841, 814)
        Controls.Add(Panel1)
        Controls.Add(edittranscript_cancel_Button)
        Controls.Add(edittranscript_save_Button)
        Margin = New Padding(2)
        Name = "EditTranscriptPage"
        Text = "Edit Transcript"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents edittranscript_save_Button As Button
    Friend WithEvents edittranscript_cancel_Button As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents edittranscript_remarks_TextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents edittranscript_grades_TextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents edittranscript_semester_TextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents edittranscript_programid_TextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents edittranscript_instructorid_TextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents edittranscript_courseid_TextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents edittranscript_studentid_TextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
