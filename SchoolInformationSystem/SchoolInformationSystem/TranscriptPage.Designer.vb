<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TranscriptPage
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        transcript_transcriptid_TextBox = New TextBox()
        transcrip_instructorid_TextBox = New TextBox()
        transcript_grade_TextBox = New TextBox()
        transcript_studentid_TextBox = New TextBox()
        transcript_programid_TextBox = New TextBox()
        transcript_remark_TextBox = New TextBox()
        transcript_courseid_TextBox = New TextBox()
        transcript_semester_TextBox = New TextBox()
        transcript_delete_Button = New Button()
        transcript_edit_Button = New Button()
        transcript_add_Button = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(108, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 15)
        Label1.TabIndex = 0
        Label1.Text = "Transcript ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(292, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 15)
        Label2.TabIndex = 2
        Label2.Text = "Student ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(325, 146)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 15)
        Label3.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(466, 83)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 15)
        Label4.TabIndex = 11
        Label4.Text = "Course ID"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(108, 113)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 15)
        Label5.TabIndex = 12
        Label5.Text = "Instructor ID"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(292, 113)
        Label6.Name = "Label6"
        Label6.Size = New Size(67, 15)
        Label6.TabIndex = 13
        Label6.Text = "Program ID"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(471, 112)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 15)
        Label7.TabIndex = 14
        Label7.Text = "Semester"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(142, 141)
        Label8.Name = "Label8"
        Label8.Size = New Size(38, 15)
        Label8.TabIndex = 15
        Label8.Text = "Grade"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(292, 141)
        Label9.Name = "Label9"
        Label9.Size = New Size(47, 15)
        Label9.TabIndex = 16
        Label9.Text = "Remark"
        ' 
        ' transcript_transcriptid_TextBox
        ' 
        transcript_transcriptid_TextBox.Location = New Point(186, 80)
        transcript_transcriptid_TextBox.Name = "transcript_transcriptid_TextBox"
        transcript_transcriptid_TextBox.Size = New Size(100, 23)
        transcript_transcriptid_TextBox.TabIndex = 17
        ' 
        ' transcrip_instructorid_TextBox
        ' 
        transcrip_instructorid_TextBox.Location = New Point(186, 109)
        transcrip_instructorid_TextBox.Name = "transcrip_instructorid_TextBox"
        transcrip_instructorid_TextBox.Size = New Size(100, 23)
        transcrip_instructorid_TextBox.TabIndex = 18
        ' 
        ' transcript_grade_TextBox
        ' 
        transcript_grade_TextBox.Location = New Point(186, 138)
        transcript_grade_TextBox.Name = "transcript_grade_TextBox"
        transcript_grade_TextBox.Size = New Size(100, 23)
        transcript_grade_TextBox.TabIndex = 19
        ' 
        ' transcript_studentid_TextBox
        ' 
        transcript_studentid_TextBox.Location = New Point(360, 80)
        transcript_studentid_TextBox.Name = "transcript_studentid_TextBox"
        transcript_studentid_TextBox.Size = New Size(100, 23)
        transcript_studentid_TextBox.TabIndex = 20
        ' 
        ' transcript_programid_TextBox
        ' 
        transcript_programid_TextBox.Location = New Point(365, 110)
        transcript_programid_TextBox.Name = "transcript_programid_TextBox"
        transcript_programid_TextBox.Size = New Size(100, 23)
        transcript_programid_TextBox.TabIndex = 21
        ' 
        ' transcript_remark_TextBox
        ' 
        transcript_remark_TextBox.Location = New Point(345, 138)
        transcript_remark_TextBox.Name = "transcript_remark_TextBox"
        transcript_remark_TextBox.Size = New Size(100, 23)
        transcript_remark_TextBox.TabIndex = 22
        ' 
        ' transcript_courseid_TextBox
        ' 
        transcript_courseid_TextBox.Location = New Point(530, 80)
        transcript_courseid_TextBox.Name = "transcript_courseid_TextBox"
        transcript_courseid_TextBox.Size = New Size(100, 23)
        transcript_courseid_TextBox.TabIndex = 23
        ' 
        ' transcript_semester_TextBox
        ' 
        transcript_semester_TextBox.Location = New Point(530, 109)
        transcript_semester_TextBox.Name = "transcript_semester_TextBox"
        transcript_semester_TextBox.Size = New Size(100, 23)
        transcript_semester_TextBox.TabIndex = 24
        ' 
        ' transcript_delete_Button
        ' 
        transcript_delete_Button.Location = New Point(461, 290)
        transcript_delete_Button.Name = "transcript_delete_Button"
        transcript_delete_Button.Size = New Size(75, 23)
        transcript_delete_Button.TabIndex = 27
        transcript_delete_Button.Text = "Delete"
        transcript_delete_Button.UseVisualStyleBackColor = True
        ' 
        ' transcript_edit_Button
        ' 
        transcript_edit_Button.Location = New Point(345, 291)
        transcript_edit_Button.Name = "transcript_edit_Button"
        transcript_edit_Button.Size = New Size(75, 23)
        transcript_edit_Button.TabIndex = 26
        transcript_edit_Button.Text = "Edit"
        transcript_edit_Button.UseVisualStyleBackColor = True
        ' 
        ' transcript_add_Button
        ' 
        transcript_add_Button.Location = New Point(227, 291)
        transcript_add_Button.Name = "transcript_add_Button"
        transcript_add_Button.Size = New Size(75, 23)
        transcript_add_Button.TabIndex = 25
        transcript_add_Button.Text = "Add"
        transcript_add_Button.UseVisualStyleBackColor = True
        ' 
        ' TranscriptPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(transcript_delete_Button)
        Controls.Add(transcript_edit_Button)
        Controls.Add(transcript_add_Button)
        Controls.Add(transcript_semester_TextBox)
        Controls.Add(transcript_courseid_TextBox)
        Controls.Add(transcript_remark_TextBox)
        Controls.Add(transcript_programid_TextBox)
        Controls.Add(transcript_studentid_TextBox)
        Controls.Add(transcript_grade_TextBox)
        Controls.Add(transcrip_instructorid_TextBox)
        Controls.Add(transcript_transcriptid_TextBox)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "TranscriptPage"
        Text = "TranscriptPage"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents transcript_transcriptid_TextBox As TextBox
    Friend WithEvents transcrip_instructorid_TextBox As TextBox
    Friend WithEvents transcript_grade_TextBox As TextBox
    Friend WithEvents transcript_studentid_TextBox As TextBox
    Friend WithEvents transcript_programid_TextBox As TextBox
    Friend WithEvents transcript_remark_TextBox As TextBox
    Friend WithEvents transcript_courseid_TextBox As TextBox
    Friend WithEvents transcript_semester_TextBox As TextBox
    Friend WithEvents transcript_delete_Button As Button
    Friend WithEvents transcript_edit_Button As Button
    Friend WithEvents transcript_add_Button As Button
End Class
