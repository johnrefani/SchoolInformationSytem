<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class T
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(T))
        Panel1 = New Panel()
        Panel2 = New Panel()
        TranscriptDataGridView = New DataGridView()
        transcriptlist_back_button = New Button()
        transcriptlist_add_Button = New Button()
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
        transcriptlist_search_Button = New Button()
        transcript_id_TextBox = New TextBox()
        Label1 = New Label()
        Panel3 = New Panel()
        Label12 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(TranscriptDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Panel3)
        Panel1.Location = New Point(111, 72)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1134, 615)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveBorder
        Panel2.Controls.Add(TranscriptDataGridView)
        Panel2.Controls.Add(transcriptlist_back_button)
        Panel2.Controls.Add(transcriptlist_add_Button)
        Panel2.Controls.Add(transcript_remarks_TextBox)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(transcript_grades_TextBox)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(transcript_semester_TextBox)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(transcript_programid_TextBox)
        Panel2.Controls.Add(transcript_instructorid_TextBox)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(transcript_courseid_TextBox)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(transcript_studentid_TextBox)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(transcriptlist_search_Button)
        Panel2.Controls.Add(transcript_id_TextBox)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(39, 122)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1056, 469)
        Panel2.TabIndex = 22
        ' 
        ' TranscriptDataGridView
        ' 
        TranscriptDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        TranscriptDataGridView.Location = New Point(14, 210)
        TranscriptDataGridView.Margin = New Padding(14, 12, 14, 12)
        TranscriptDataGridView.Name = "TranscriptDataGridView"
        TranscriptDataGridView.RowHeadersWidth = 62
        TranscriptDataGridView.Size = New Size(1028, 247)
        TranscriptDataGridView.TabIndex = 39
        ' 
        ' transcriptlist_back_button
        ' 
        transcriptlist_back_button.BackColor = Color.Maroon
        transcriptlist_back_button.FlatStyle = FlatStyle.Popup
        transcriptlist_back_button.ForeColor = SystemColors.ControlLightLight
        transcriptlist_back_button.Location = New Point(19, 18)
        transcriptlist_back_button.Margin = New Padding(2)
        transcriptlist_back_button.Name = "transcriptlist_back_button"
        transcriptlist_back_button.Size = New Size(85, 25)
        transcriptlist_back_button.TabIndex = 38
        transcriptlist_back_button.Text = "Transcripts"
        transcriptlist_back_button.UseVisualStyleBackColor = False
        ' 
        ' transcriptlist_add_Button
        ' 
        transcriptlist_add_Button.BackColor = Color.Maroon
        transcriptlist_add_Button.FlatStyle = FlatStyle.Popup
        transcriptlist_add_Button.ForeColor = SystemColors.ControlLightLight
        transcriptlist_add_Button.Location = New Point(948, 171)
        transcriptlist_add_Button.Margin = New Padding(2)
        transcriptlist_add_Button.Name = "transcriptlist_add_Button"
        transcriptlist_add_Button.Size = New Size(78, 25)
        transcriptlist_add_Button.TabIndex = 37
        transcriptlist_add_Button.Text = "Add"
        transcriptlist_add_Button.UseVisualStyleBackColor = False
        ' 
        ' transcript_remarks_TextBox
        ' 
        transcript_remarks_TextBox.Location = New Point(715, 130)
        transcript_remarks_TextBox.Margin = New Padding(2)
        transcript_remarks_TextBox.Name = "transcript_remarks_TextBox"
        transcript_remarks_TextBox.Size = New Size(137, 23)
        transcript_remarks_TextBox.TabIndex = 36
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(659, 133)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(52, 15)
        Label8.TabIndex = 35
        Label8.Text = "Remarks"
        ' 
        ' transcript_grades_TextBox
        ' 
        transcript_grades_TextBox.Location = New Point(438, 130)
        transcript_grades_TextBox.Margin = New Padding(2)
        transcript_grades_TextBox.Name = "transcript_grades_TextBox"
        transcript_grades_TextBox.Size = New Size(140, 23)
        transcript_grades_TextBox.TabIndex = 34
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(391, 133)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(43, 15)
        Label7.TabIndex = 33
        Label7.Text = "Grades"
        ' 
        ' transcript_semester_TextBox
        ' 
        transcript_semester_TextBox.Location = New Point(156, 130)
        transcript_semester_TextBox.Margin = New Padding(2)
        transcript_semester_TextBox.Name = "transcript_semester_TextBox"
        transcript_semester_TextBox.Size = New Size(127, 23)
        transcript_semester_TextBox.TabIndex = 32
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(97, 133)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 15)
        Label6.TabIndex = 31
        Label6.Text = "Semester"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(367, 97)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 15)
        Label5.TabIndex = 30
        Label5.Text = "Program ID"
        ' 
        ' transcript_programid_TextBox
        ' 
        transcript_programid_TextBox.Location = New Point(438, 94)
        transcript_programid_TextBox.Margin = New Padding(2)
        transcript_programid_TextBox.Name = "transcript_programid_TextBox"
        transcript_programid_TextBox.Size = New Size(140, 23)
        transcript_programid_TextBox.TabIndex = 29
        ' 
        ' transcript_instructorid_TextBox
        ' 
        transcript_instructorid_TextBox.Location = New Point(156, 94)
        transcript_instructorid_TextBox.Margin = New Padding(2)
        transcript_instructorid_TextBox.Name = "transcript_instructorid_TextBox"
        transcript_instructorid_TextBox.Size = New Size(127, 23)
        transcript_instructorid_TextBox.TabIndex = 28
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(80, 97)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 15)
        Label4.TabIndex = 27
        Label4.Text = "Instructor ID"
        ' 
        ' transcript_courseid_TextBox
        ' 
        transcript_courseid_TextBox.Location = New Point(715, 58)
        transcript_courseid_TextBox.Margin = New Padding(2)
        transcript_courseid_TextBox.Name = "transcript_courseid_TextBox"
        transcript_courseid_TextBox.Size = New Size(137, 23)
        transcript_courseid_TextBox.TabIndex = 26
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(653, 61)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 15)
        Label3.TabIndex = 25
        Label3.Text = "Course ID"
        ' 
        ' transcript_studentid_TextBox
        ' 
        transcript_studentid_TextBox.Location = New Point(438, 58)
        transcript_studentid_TextBox.Margin = New Padding(2)
        transcript_studentid_TextBox.Name = "transcript_studentid_TextBox"
        transcript_studentid_TextBox.Size = New Size(140, 23)
        transcript_studentid_TextBox.TabIndex = 24
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(372, 61)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 15)
        Label2.TabIndex = 23
        Label2.Text = "Student ID"
        ' 
        ' transcriptlist_search_Button
        ' 
        transcriptlist_search_Button.BackColor = Color.Maroon
        transcriptlist_search_Button.FlatStyle = FlatStyle.Popup
        transcriptlist_search_Button.ForeColor = SystemColors.ControlLightLight
        transcriptlist_search_Button.Location = New Point(852, 171)
        transcriptlist_search_Button.Margin = New Padding(2)
        transcriptlist_search_Button.Name = "transcriptlist_search_Button"
        transcriptlist_search_Button.Size = New Size(78, 25)
        transcriptlist_search_Button.TabIndex = 22
        transcriptlist_search_Button.Text = "Search"
        transcriptlist_search_Button.UseVisualStyleBackColor = False
        ' 
        ' transcript_id_TextBox
        ' 
        transcript_id_TextBox.Location = New Point(156, 58)
        transcript_id_TextBox.Margin = New Padding(2)
        transcript_id_TextBox.Name = "transcript_id_TextBox"
        transcript_id_TextBox.Size = New Size(127, 23)
        transcript_id_TextBox.TabIndex = 21
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(80, 61)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 15)
        Label1.TabIndex = 20
        Label1.Text = "Transcript ID"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Maroon
        Panel3.Controls.Add(Label12)
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1134, 96)
        Panel3.TabIndex = 23
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = SystemColors.ControlLightLight
        Label12.Location = New Point(411, 25)
        Label12.Name = "Label12"
        Label12.Size = New Size(336, 47)
        Label12.TabIndex = 0
        Label12.Text = "TRANSCRIPTS LIST"
        ' 
        ' T
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1370, 749)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Name = "T"
        Text = "T"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(TranscriptDataGridView, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TranscriptDataGridView As DataGridView
    Friend WithEvents transcriptlist_back_button As Button
    Friend WithEvents transcriptlist_add_Button As Button
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
    Friend WithEvents transcriptlist_search_Button As Button
    Friend WithEvents transcript_id_TextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label12 As Label
End Class
