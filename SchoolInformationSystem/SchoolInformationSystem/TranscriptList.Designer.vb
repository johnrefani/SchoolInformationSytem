<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TranscriptList
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
        transcriptlist_search_Button = New Button()
        transcriptlist_add_Button = New Button()
        TranscriptDataGridView = New DataGridView()
        Panel1 = New Panel()
        transcript_remarks_TextBox = New TextBox()
        Label8 = New Label()
        transcript_grades_TextBox = New TextBox()
        Label7 = New Label()
        transcript_semester_TextBox = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        transcript_programid_TextBox = New TextBox()
        transcript_instructorid_TextBox = New TextBox()
        Label4 = New Label()
        transcript_courseid_TextBox = New TextBox()
        Label3 = New Label()
        transcript_studentid_TextBox = New TextBox()
        Label2 = New Label()
        transcript_id_TextBox = New TextBox()
        Label1 = New Label()
        transcript_back_Button = New Button()
        Panel2 = New Panel()
        Label9 = New Label()
        CType(TranscriptDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' transcriptlist_search_Button
        ' 
        transcriptlist_search_Button.BackColor = Color.Maroon
        transcriptlist_search_Button.FlatStyle = FlatStyle.Popup
        transcriptlist_search_Button.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        transcriptlist_search_Button.ForeColor = SystemColors.ControlLightLight
        transcriptlist_search_Button.Location = New Point(549, 217)
        transcriptlist_search_Button.Margin = New Padding(2)
        transcriptlist_search_Button.Name = "transcriptlist_search_Button"
        transcriptlist_search_Button.Size = New Size(75, 29)
        transcriptlist_search_Button.TabIndex = 2
        transcriptlist_search_Button.Text = "Search"
        transcriptlist_search_Button.UseVisualStyleBackColor = False
        ' 
        ' transcriptlist_add_Button
        ' 
        transcriptlist_add_Button.BackColor = Color.Maroon
        transcriptlist_add_Button.FlatStyle = FlatStyle.Popup
        transcriptlist_add_Button.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        transcriptlist_add_Button.ForeColor = SystemColors.ControlLightLight
        transcriptlist_add_Button.Location = New Point(1285, 256)
        transcriptlist_add_Button.Margin = New Padding(2)
        transcriptlist_add_Button.Name = "transcriptlist_add_Button"
        transcriptlist_add_Button.Size = New Size(75, 29)
        transcriptlist_add_Button.TabIndex = 17
        transcriptlist_add_Button.Text = "Add"
        transcriptlist_add_Button.UseVisualStyleBackColor = False
        ' 
        ' TranscriptDataGridView
        ' 
        TranscriptDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        TranscriptDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        TranscriptDataGridView.Dock = DockStyle.Bottom
        TranscriptDataGridView.Location = New Point(10, 289)
        TranscriptDataGridView.Margin = New Padding(14, 12, 14, 12)
        TranscriptDataGridView.Name = "TranscriptDataGridView"
        TranscriptDataGridView.RowHeadersWidth = 62
        TranscriptDataGridView.Size = New Size(1350, 450)
        TranscriptDataGridView.TabIndex = 19
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.Controls.Add(transcript_remarks_TextBox)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(transcript_grades_TextBox)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(transcript_semester_TextBox)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(transcript_programid_TextBox)
        Panel1.Controls.Add(transcript_instructorid_TextBox)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(transcript_courseid_TextBox)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(transcript_studentid_TextBox)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(transcript_id_TextBox)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(10, 101)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(614, 114)
        Panel1.TabIndex = 20
        ' 
        ' transcript_remarks_TextBox
        ' 
        transcript_remarks_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        transcript_remarks_TextBox.Location = New Point(271, 74)
        transcript_remarks_TextBox.Margin = New Padding(2)
        transcript_remarks_TextBox.Name = "transcript_remarks_TextBox"
        transcript_remarks_TextBox.Size = New Size(106, 25)
        transcript_remarks_TextBox.TabIndex = 32
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label8.Location = New Point(207, 77)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(60, 17)
        Label8.TabIndex = 31
        Label8.Text = "Remarks"
        ' 
        ' transcript_grades_TextBox
        ' 
        transcript_grades_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        transcript_grades_TextBox.Location = New Point(97, 74)
        transcript_grades_TextBox.Margin = New Padding(2)
        transcript_grades_TextBox.Name = "transcript_grades_TextBox"
        transcript_grades_TextBox.Size = New Size(106, 25)
        transcript_grades_TextBox.TabIndex = 30
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label7.Location = New Point(43, 77)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(50, 17)
        Label7.TabIndex = 29
        Label7.Text = "Grades"
        ' 
        ' transcript_semester_TextBox
        ' 
        transcript_semester_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        transcript_semester_TextBox.Location = New Point(475, 45)
        transcript_semester_TextBox.Margin = New Padding(2)
        transcript_semester_TextBox.Name = "transcript_semester_TextBox"
        transcript_semester_TextBox.Size = New Size(98, 25)
        transcript_semester_TextBox.TabIndex = 28
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label6.Location = New Point(407, 48)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 17)
        Label6.TabIndex = 27
        Label6.Text = "Semester"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label5.Location = New Point(223, 48)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 17)
        Label5.TabIndex = 26
        Label5.Text = "Program ID"
        ' 
        ' transcript_programid_TextBox
        ' 
        transcript_programid_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        transcript_programid_TextBox.Location = New Point(305, 45)
        transcript_programid_TextBox.Margin = New Padding(2)
        transcript_programid_TextBox.Name = "transcript_programid_TextBox"
        transcript_programid_TextBox.Size = New Size(95, 25)
        transcript_programid_TextBox.TabIndex = 25
        ' 
        ' transcript_instructorid_TextBox
        ' 
        transcript_instructorid_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        transcript_instructorid_TextBox.Location = New Point(132, 45)
        transcript_instructorid_TextBox.Margin = New Padding(2)
        transcript_instructorid_TextBox.Name = "transcript_instructorid_TextBox"
        transcript_instructorid_TextBox.Size = New Size(87, 25)
        transcript_instructorid_TextBox.TabIndex = 24
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label4.Location = New Point(43, 48)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 17)
        Label4.TabIndex = 23
        Label4.Text = "Instructor ID"
        ' 
        ' transcript_courseid_TextBox
        ' 
        transcript_courseid_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        transcript_courseid_TextBox.Location = New Point(475, 16)
        transcript_courseid_TextBox.Margin = New Padding(2)
        transcript_courseid_TextBox.Name = "transcript_courseid_TextBox"
        transcript_courseid_TextBox.Size = New Size(98, 25)
        transcript_courseid_TextBox.TabIndex = 22
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(404, 19)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 17)
        Label3.TabIndex = 21
        Label3.Text = "Course ID"
        ' 
        ' transcript_studentid_TextBox
        ' 
        transcript_studentid_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        transcript_studentid_TextBox.Location = New Point(299, 16)
        transcript_studentid_TextBox.Margin = New Padding(2)
        transcript_studentid_TextBox.Name = "transcript_studentid_TextBox"
        transcript_studentid_TextBox.Size = New Size(101, 25)
        transcript_studentid_TextBox.TabIndex = 20
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label2.Location = New Point(222, 19)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 17)
        Label2.TabIndex = 19
        Label2.Text = "Student ID"
        ' 
        ' transcript_id_TextBox
        ' 
        transcript_id_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        transcript_id_TextBox.Location = New Point(130, 16)
        transcript_id_TextBox.Margin = New Padding(2)
        transcript_id_TextBox.Name = "transcript_id_TextBox"
        transcript_id_TextBox.Size = New Size(88, 25)
        transcript_id_TextBox.TabIndex = 18
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label1.Location = New Point(42, 19)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 17)
        Label1.TabIndex = 17
        Label1.Text = "Transcript ID"
        ' 
        ' transcript_back_Button
        ' 
        transcript_back_Button.BackColor = Color.Maroon
        transcript_back_Button.FlatStyle = FlatStyle.Popup
        transcript_back_Button.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        transcript_back_Button.ForeColor = SystemColors.ControlLightLight
        transcript_back_Button.Location = New Point(1285, 13)
        transcript_back_Button.Name = "transcript_back_Button"
        transcript_back_Button.Size = New Size(75, 29)
        transcript_back_Button.TabIndex = 21
        transcript_back_Button.Text = "Back"
        transcript_back_Button.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Maroon
        Panel2.Controls.Add(Label9)
        Panel2.Location = New Point(10, 73)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(614, 32)
        Panel2.TabIndex = 38
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Maroon
        Label9.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ControlLightLight
        Label9.Location = New Point(19, 8)
        Label9.Name = "Label9"
        Label9.Size = New Size(40, 17)
        Label9.TabIndex = 40
        Label9.Text = "Filter"
        ' 
        ' TranscriptList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.adminbg
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1370, 749)
        Controls.Add(Panel2)
        Controls.Add(transcript_back_Button)
        Controls.Add(Panel1)
        Controls.Add(TranscriptDataGridView)
        Controls.Add(transcriptlist_add_Button)
        Controls.Add(transcriptlist_search_Button)
        Margin = New Padding(2)
        Name = "TranscriptList"
        Padding = New Padding(10)
        Text = "TranscriptList"
        WindowState = FormWindowState.Maximized
        CType(TranscriptDataGridView, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents transcriptlist_search_Button As Button
    Friend WithEvents transcriptlist_add_Button As Button
    Friend WithEvents TranscriptDataGridView As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents transcript_remarks_TextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents transcript_grades_TextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents transcript_semester_TextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents transcript_programid_TextBox As TextBox
    Friend WithEvents transcript_instructorid_TextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents transcript_courseid_TextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents transcript_studentid_TextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents transcript_id_TextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents transcript_back_Button As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
End Class
