<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentPage))
        Panel1 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        student_logout_Button = New Button()
        student_enrolled_sub__Button = New PictureBox()
        student_addCR_Button = New PictureBox()
        student_profile_Button = New PictureBox()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(student_enrolled_sub__Button, ComponentModel.ISupportInitialize).BeginInit()
        CType(student_addCR_Button, ComponentModel.ISupportInitialize).BeginInit()
        CType(student_profile_Button, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.IndianRed
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(student_logout_Button)
        Panel1.Controls.Add(student_enrolled_sub__Button)
        Panel1.Controls.Add(student_addCR_Button)
        Panel1.Controls.Add(student_profile_Button)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(224, 1043)
        Panel1.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(72, 644)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 15)
        Label3.TabIndex = 6
        Label3.Text = "Transcripts"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(50, 569)
        Label2.Name = "Label2"
        Label2.Size = New Size(110, 15)
        Label2.TabIndex = 5
        Label2.Text = "Course Registration"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(61, 492)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 15)
        Label1.TabIndex = 1
        Label1.Text = "Student Profile"
        ' 
        ' student_logout_Button
        ' 
        student_logout_Button.BackColor = Color.Maroon
        student_logout_Button.FlatStyle = FlatStyle.Popup
        student_logout_Button.ForeColor = SystemColors.ControlLightLight
        student_logout_Button.Location = New Point(70, 826)
        student_logout_Button.Name = "student_logout_Button"
        student_logout_Button.Size = New Size(75, 23)
        student_logout_Button.TabIndex = 4
        student_logout_Button.Text = "Log Out"
        student_logout_Button.UseVisualStyleBackColor = False
        ' 
        ' student_enrolled_sub__Button
        ' 
        student_enrolled_sub__Button.BackgroundImage = CType(resources.GetObject("student_enrolled_sub__Button.BackgroundImage"), Image)
        student_enrolled_sub__Button.BackgroundImageLayout = ImageLayout.Stretch
        student_enrolled_sub__Button.Cursor = Cursors.Hand
        student_enrolled_sub__Button.Location = New Point(81, 596)
        student_enrolled_sub__Button.Name = "student_enrolled_sub__Button"
        student_enrolled_sub__Button.Size = New Size(45, 45)
        student_enrolled_sub__Button.TabIndex = 3
        student_enrolled_sub__Button.TabStop = False
        ' 
        ' student_addCR_Button
        ' 
        student_addCR_Button.BackgroundImage = CType(resources.GetObject("student_addCR_Button.BackgroundImage"), Image)
        student_addCR_Button.BackgroundImageLayout = ImageLayout.Stretch
        student_addCR_Button.Cursor = Cursors.Hand
        student_addCR_Button.Location = New Point(81, 521)
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
        student_profile_Button.Location = New Point(81, 444)
        student_profile_Button.Name = "student_profile_Button"
        student_profile_Button.Size = New Size(45, 45)
        student_profile_Button.TabIndex = 1
        student_profile_Button.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(58, 194)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 96)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' StudentPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1904, 1041)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Name = "StudentPage"
        Text = "Student Portal for Students"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(student_enrolled_sub__Button, ComponentModel.ISupportInitialize).EndInit()
        CType(student_addCR_Button, ComponentModel.ISupportInitialize).EndInit()
        CType(student_profile_Button, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents student_enrolled_sub__Button As PictureBox
    Friend WithEvents student_addCR_Button As PictureBox
    Friend WithEvents student_profile_Button As PictureBox
    Friend WithEvents student_logout_Button As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
