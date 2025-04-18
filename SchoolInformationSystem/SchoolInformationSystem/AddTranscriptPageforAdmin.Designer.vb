<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddTranscriptPageforAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddTranscriptPageforAdmin))
        Panel1 = New Panel()
        addtranscript_back_Button = New Button()
        addtranscript_Button = New Button()
        Transcript_remarks_TextBox = New TextBox()
        Label7 = New Label()
        Transcript_grades_TextBox = New TextBox()
        Label6 = New Label()
        Transcript_semester_TextBox = New TextBox()
        Label5 = New Label()
        Transcript_programid_TextBox = New TextBox()
        Label4 = New Label()
        Transcript_instructorid_TextBox = New TextBox()
        Label3 = New Label()
        Transcript_courseid_TextBox = New TextBox()
        Label2 = New Label()
        Transcript_studentid_TextBox = New TextBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLight
        Panel1.Controls.Add(addtranscript_back_Button)
        Panel1.Controls.Add(addtranscript_Button)
        Panel1.Controls.Add(Transcript_remarks_TextBox)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Transcript_grades_TextBox)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Transcript_semester_TextBox)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Transcript_programid_TextBox)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Transcript_instructorid_TextBox)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Transcript_courseid_TextBox)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Transcript_studentid_TextBox)
        Panel1.Controls.Add(Label1)
        Panel1.Font = New Font("Segoe UI", 10F)
        Panel1.Location = New Point(269, 88)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(776, 413)
        Panel1.TabIndex = 16
        ' 
        ' addtranscript_back_Button
        ' 
        addtranscript_back_Button.BackColor = Color.Maroon
        addtranscript_back_Button.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addtranscript_back_Button.ForeColor = Color.White
        addtranscript_back_Button.Location = New Point(673, 22)
        addtranscript_back_Button.Margin = New Padding(2)
        addtranscript_back_Button.Name = "addtranscript_back_Button"
        addtranscript_back_Button.Size = New Size(78, 27)
        addtranscript_back_Button.TabIndex = 31
        addtranscript_back_Button.Text = "Back"
        addtranscript_back_Button.UseVisualStyleBackColor = False
        ' 
        ' addtranscript_Button
        ' 
        addtranscript_Button.BackColor = Color.Maroon
        addtranscript_Button.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addtranscript_Button.ForeColor = Color.White
        addtranscript_Button.Location = New Point(333, 282)
        addtranscript_Button.Margin = New Padding(2)
        addtranscript_Button.Name = "addtranscript_Button"
        addtranscript_Button.Size = New Size(78, 28)
        addtranscript_Button.TabIndex = 30
        addtranscript_Button.Text = "Add"
        addtranscript_Button.UseVisualStyleBackColor = False
        ' 
        ' Transcript_remarks_TextBox
        ' 
        Transcript_remarks_TextBox.Location = New Point(502, 191)
        Transcript_remarks_TextBox.Margin = New Padding(2)
        Transcript_remarks_TextBox.Name = "Transcript_remarks_TextBox"
        Transcript_remarks_TextBox.Size = New Size(92, 25)
        Transcript_remarks_TextBox.TabIndex = 29
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(426, 194)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(61, 19)
        Label7.TabIndex = 28
        Label7.Text = "Remarks"
        ' 
        ' Transcript_grades_TextBox
        ' 
        Transcript_grades_TextBox.Location = New Point(294, 191)
        Transcript_grades_TextBox.Margin = New Padding(2)
        Transcript_grades_TextBox.Name = "Transcript_grades_TextBox"
        Transcript_grades_TextBox.Size = New Size(90, 25)
        Transcript_grades_TextBox.TabIndex = 27
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(238, 194)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 19)
        Label6.TabIndex = 26
        Label6.Text = "Grades"
        ' 
        ' Transcript_semester_TextBox
        ' 
        Transcript_semester_TextBox.Location = New Point(108, 191)
        Transcript_semester_TextBox.Margin = New Padding(2)
        Transcript_semester_TextBox.Name = "Transcript_semester_TextBox"
        Transcript_semester_TextBox.Size = New Size(95, 25)
        Transcript_semester_TextBox.TabIndex = 25
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(39, 194)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 19)
        Label5.TabIndex = 24
        Label5.Text = "Semester"
        ' 
        ' Transcript_programid_TextBox
        ' 
        Transcript_programid_TextBox.Location = New Point(398, 137)
        Transcript_programid_TextBox.Margin = New Padding(2)
        Transcript_programid_TextBox.Name = "Transcript_programid_TextBox"
        Transcript_programid_TextBox.Size = New Size(127, 25)
        Transcript_programid_TextBox.TabIndex = 23
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(294, 140)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 19)
        Label4.TabIndex = 22
        Label4.Text = "Program ID"
        ' 
        ' Transcript_instructorid_TextBox
        ' 
        Transcript_instructorid_TextBox.Location = New Point(161, 137)
        Transcript_instructorid_TextBox.Margin = New Padding(2)
        Transcript_instructorid_TextBox.Name = "Transcript_instructorid_TextBox"
        Transcript_instructorid_TextBox.Size = New Size(106, 25)
        Transcript_instructorid_TextBox.TabIndex = 21
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(70, 140)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 19)
        Label3.TabIndex = 20
        Label3.Text = "Instructor ID"
        ' 
        ' Transcript_courseid_TextBox
        ' 
        Transcript_courseid_TextBox.Location = New Point(378, 83)
        Transcript_courseid_TextBox.Margin = New Padding(2)
        Transcript_courseid_TextBox.Name = "Transcript_courseid_TextBox"
        Transcript_courseid_TextBox.Size = New Size(126, 25)
        Transcript_courseid_TextBox.TabIndex = 19
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(304, 86)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 19)
        Label2.TabIndex = 18
        Label2.Text = "Course ID"
        ' 
        ' Transcript_studentid_TextBox
        ' 
        Transcript_studentid_TextBox.Location = New Point(118, 83)
        Transcript_studentid_TextBox.Margin = New Padding(2)
        Transcript_studentid_TextBox.Name = "Transcript_studentid_TextBox"
        Transcript_studentid_TextBox.Size = New Size(126, 25)
        Transcript_studentid_TextBox.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(39, 86)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 19)
        Label1.TabIndex = 16
        Label1.Text = "Student ID"
        ' 
        ' AddTranscriptPageforAdmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1167, 641)
        Controls.Add(Panel1)
        Margin = New Padding(2, 2, 2, 2)
        Name = "AddTranscriptPageforAdmin"
        Text = "Add Transcript"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Transcript_studentid_TextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Transcript_courseid_TextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Transcript_instructorid_TextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Transcript_programid_TextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Transcript_semester_TextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Transcript_grades_TextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Transcript_remarks_TextBox As TextBox
    Friend WithEvents addtranscript_Button As Button
    Friend WithEvents addtranscript_back_Button As Button
    Friend WithEvents Panel1 As Panel
End Class
