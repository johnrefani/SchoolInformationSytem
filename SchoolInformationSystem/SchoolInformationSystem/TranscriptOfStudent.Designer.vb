<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TranscriptOfStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TranscriptOfStudent))
        Panel4 = New Panel()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        student_logout_Button = New Button()
        transcript_Button = New PictureBox()
        student_addCR_Button = New PictureBox()
        student_profile_Button = New PictureBox()
        PictureBox1 = New PictureBox()
        Transcript_DGV = New DataGridView()
        Panel4.SuspendLayout()
        CType(transcript_Button, ComponentModel.ISupportInitialize).BeginInit()
        CType(student_addCR_Button, ComponentModel.ISupportInitialize).BeginInit()
        CType(student_profile_Button, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Transcript_DGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.IndianRed
        Panel4.Controls.Add(Label9)
        Panel4.Controls.Add(Label10)
        Panel4.Controls.Add(Label11)
        Panel4.Controls.Add(student_logout_Button)
        Panel4.Controls.Add(transcript_Button)
        Panel4.Controls.Add(student_addCR_Button)
        Panel4.Controls.Add(student_profile_Button)
        Panel4.Controls.Add(PictureBox1)
        Panel4.Location = New Point(-3, -2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(204, 1048)
        Panel4.TabIndex = 148
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(57, 543)
        Label9.Name = "Label9"
        Label9.Size = New Size(59, 15)
        Label9.TabIndex = 6
        Label9.Text = "Transcript"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(35, 468)
        Label10.Name = "Label10"
        Label10.Size = New Size(97, 15)
        Label10.TabIndex = 5
        Label10.Text = "Enrolled Subjects"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(46, 391)
        Label11.Name = "Label11"
        Label11.Size = New Size(85, 15)
        Label11.TabIndex = 1
        Label11.Text = "Student Profile"
        ' 
        ' student_logout_Button
        ' 
        student_logout_Button.BackColor = Color.Maroon
        student_logout_Button.FlatStyle = FlatStyle.Popup
        student_logout_Button.ForeColor = SystemColors.ControlLightLight
        student_logout_Button.Location = New Point(53, 776)
        student_logout_Button.Name = "student_logout_Button"
        student_logout_Button.Size = New Size(90, 42)
        student_logout_Button.TabIndex = 4
        student_logout_Button.Text = "Log Out"
        student_logout_Button.UseVisualStyleBackColor = False
        ' 
        ' transcript_Button
        ' 
        transcript_Button.BackgroundImage = CType(resources.GetObject("transcript_Button.BackgroundImage"), Image)
        transcript_Button.BackgroundImageLayout = ImageLayout.Stretch
        transcript_Button.Cursor = Cursors.Hand
        transcript_Button.Location = New Point(66, 495)
        transcript_Button.Name = "transcript_Button"
        transcript_Button.Size = New Size(45, 45)
        transcript_Button.TabIndex = 3
        transcript_Button.TabStop = False
        ' 
        ' student_addCR_Button
        ' 
        student_addCR_Button.BackgroundImage = CType(resources.GetObject("student_addCR_Button.BackgroundImage"), Image)
        student_addCR_Button.BackgroundImageLayout = ImageLayout.Stretch
        student_addCR_Button.Cursor = Cursors.Hand
        student_addCR_Button.Location = New Point(66, 420)
        student_addCR_Button.Name = "student_addCR_Button"
        student_addCR_Button.Size = New Size(45, 45)
        student_addCR_Button.TabIndex = 2
        student_addCR_Button.TabStop = False
        ' 
        ' student_profile_Button
        ' 
        student_profile_Button.BackgroundImage = CType(resources.GetObject("student_profile_Button.BackgroundImage"), Image)
        student_profile_Button.BackgroundImageLayout = ImageLayout.Stretch
        student_profile_Button.Cursor = Cursors.Hand
        student_profile_Button.Location = New Point(66, 343)
        student_profile_Button.Name = "student_profile_Button"
        student_profile_Button.Size = New Size(45, 45)
        student_profile_Button.TabIndex = 1
        student_profile_Button.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(38, 74)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 96)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Transcript_DGV
        ' 
        Transcript_DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
        Transcript_DGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders
        Transcript_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Transcript_DGV.Location = New Point(289, 169)
        Transcript_DGV.Name = "Transcript_DGV"
        Transcript_DGV.Size = New Size(755, 577)
        Transcript_DGV.TabIndex = 149
        ' 
        ' TranscriptOfStudent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.adminbg
        ClientSize = New Size(1904, 1041)
        Controls.Add(Transcript_DGV)
        Controls.Add(Panel4)
        Name = "TranscriptOfStudent"
        Text = "Transcript"
        WindowState = FormWindowState.Maximized
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(transcript_Button, ComponentModel.ISupportInitialize).EndInit()
        CType(student_addCR_Button, ComponentModel.ISupportInitialize).EndInit()
        CType(student_profile_Button, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(Transcript_DGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents student_logout_Button As Button
    Friend WithEvents transcript_Button As PictureBox
    Friend WithEvents student_addCR_Button As PictureBox
    Friend WithEvents student_profile_Button As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Transcript_DGV As DataGridView
End Class
