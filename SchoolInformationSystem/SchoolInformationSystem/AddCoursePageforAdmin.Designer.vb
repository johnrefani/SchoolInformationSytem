<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCoursePageforAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddCoursePageforAdmin))
        Label1 = New Label()
        Panel1 = New Panel()
        addcourse_back_Button = New Button()
        course_add_Button = New Button()
        course_programid_TextBox = New TextBox()
        Label8 = New Label()
        course_departmentid_TextBox = New TextBox()
        Label7 = New Label()
        course_units_TextBox = New TextBox()
        Label6 = New Label()
        course_coursdescription_TextBox = New TextBox()
        Label5 = New Label()
        course_coursecode_TextBox = New TextBox()
        Label4 = New Label()
        course_coursename_TextBox = New TextBox()
        Label3 = New Label()
        course_courseid_TextBox = New TextBox()
        Label2 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.Controls.Add(addcourse_back_Button)
        Panel1.Controls.Add(course_add_Button)
        Panel1.Controls.Add(course_programid_TextBox)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(course_departmentid_TextBox)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(course_units_TextBox)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(course_coursdescription_TextBox)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(course_coursecode_TextBox)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(course_coursename_TextBox)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(course_courseid_TextBox)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(313, 274)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(940, 450)
        Panel1.TabIndex = 23
        ' 
        ' addcourse_back_Button
        ' 
        addcourse_back_Button.BackColor = Color.Maroon
        addcourse_back_Button.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addcourse_back_Button.ForeColor = SystemColors.ControlLightLight
        addcourse_back_Button.Location = New Point(832, 31)
        addcourse_back_Button.Margin = New Padding(3, 4, 3, 4)
        addcourse_back_Button.Name = "addcourse_back_Button"
        addcourse_back_Button.Size = New Size(86, 39)
        addcourse_back_Button.TabIndex = 40
        addcourse_back_Button.Text = "Back"
        addcourse_back_Button.UseVisualStyleBackColor = False
        ' 
        ' course_add_Button
        ' 
        course_add_Button.BackColor = Color.Maroon
        course_add_Button.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        course_add_Button.ForeColor = SystemColors.ControlLightLight
        course_add_Button.Location = New Point(427, 359)
        course_add_Button.Margin = New Padding(3, 4, 3, 4)
        course_add_Button.Name = "course_add_Button"
        course_add_Button.Size = New Size(86, 37)
        course_add_Button.TabIndex = 37
        course_add_Button.Text = "Add"
        course_add_Button.UseVisualStyleBackColor = False
        ' 
        ' course_programid_TextBox
        ' 
        course_programid_TextBox.Font = New Font("Segoe UI", 10F)
        course_programid_TextBox.Location = New Point(737, 195)
        course_programid_TextBox.Margin = New Padding(3, 4, 3, 4)
        course_programid_TextBox.Name = "course_programid_TextBox"
        course_programid_TextBox.Size = New Size(141, 30)
        course_programid_TextBox.TabIndex = 36
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label8.Location = New Point(639, 196)
        Label8.Name = "Label8"
        Label8.Size = New Size(98, 23)
        Label8.TabIndex = 35
        Label8.Text = "Program ID"
        ' 
        ' course_departmentid_TextBox
        ' 
        course_departmentid_TextBox.Font = New Font("Segoe UI", 10F)
        course_departmentid_TextBox.Location = New Point(453, 192)
        course_departmentid_TextBox.Margin = New Padding(3, 4, 3, 4)
        course_departmentid_TextBox.Name = "course_departmentid_TextBox"
        course_departmentid_TextBox.Size = New Size(149, 30)
        course_departmentid_TextBox.TabIndex = 34
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label7.Location = New Point(327, 196)
        Label7.Name = "Label7"
        Label7.Size = New Size(124, 23)
        Label7.TabIndex = 33
        Label7.Text = "Department ID"
        ' 
        ' course_units_TextBox
        ' 
        course_units_TextBox.Font = New Font("Segoe UI", 10F)
        course_units_TextBox.Location = New Point(151, 192)
        course_units_TextBox.Margin = New Padding(3, 4, 3, 4)
        course_units_TextBox.Name = "course_units_TextBox"
        course_units_TextBox.Size = New Size(148, 30)
        course_units_TextBox.TabIndex = 32
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label6.Location = New Point(92, 196)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 23)
        Label6.TabIndex = 31
        Label6.Text = "Units"
        ' 
        ' course_coursdescription_TextBox
        ' 
        course_coursdescription_TextBox.Font = New Font("Segoe UI", 10F)
        course_coursdescription_TextBox.Location = New Point(204, 249)
        course_coursdescription_TextBox.Margin = New Padding(3, 4, 3, 4)
        course_coursdescription_TextBox.Multiline = True
        course_coursdescription_TextBox.Name = "course_coursdescription_TextBox"
        course_coursdescription_TextBox.Size = New Size(673, 64)
        course_coursdescription_TextBox.TabIndex = 30
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label5.Location = New Point(44, 265)
        Label5.Name = "Label5"
        Label5.Size = New Size(154, 23)
        Label5.TabIndex = 29
        Label5.Text = "Course Description"
        ' 
        ' course_coursecode_TextBox
        ' 
        course_coursecode_TextBox.Font = New Font("Segoe UI", 10F)
        course_coursecode_TextBox.Location = New Point(737, 140)
        course_coursecode_TextBox.Margin = New Padding(3, 4, 3, 4)
        course_coursecode_TextBox.Name = "course_coursecode_TextBox"
        course_coursecode_TextBox.Size = New Size(141, 30)
        course_coursecode_TextBox.TabIndex = 28
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label4.Location = New Point(630, 144)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 23)
        Label4.TabIndex = 27
        Label4.Text = "Course Code"
        ' 
        ' course_coursename_TextBox
        ' 
        course_coursename_TextBox.Font = New Font("Segoe UI", 10F)
        course_coursename_TextBox.Location = New Point(453, 140)
        course_coursename_TextBox.Margin = New Padding(3, 4, 3, 4)
        course_coursename_TextBox.Name = "course_coursename_TextBox"
        course_coursename_TextBox.Size = New Size(149, 30)
        course_coursename_TextBox.TabIndex = 26
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(337, 144)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 23)
        Label3.TabIndex = 25
        Label3.Text = "Course Name"
        ' 
        ' course_courseid_TextBox
        ' 
        course_courseid_TextBox.Font = New Font("Segoe UI", 10F)
        course_courseid_TextBox.Location = New Point(151, 140)
        course_courseid_TextBox.Margin = New Padding(3, 4, 3, 4)
        course_courseid_TextBox.Name = "course_courseid_TextBox"
        course_courseid_TextBox.Size = New Size(148, 30)
        course_courseid_TextBox.TabIndex = 24
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label2.Location = New Point(64, 144)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 23)
        Label2.TabIndex = 23
        Label2.Text = "Course ID"
        ' 
        ' AddCoursePageforAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1566, 999)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Cursor = Cursors.Hand
        Margin = New Padding(3, 4, 3, 4)
        Name = "AddCoursePageforAdmin"
        Text = "Add Course For Admin"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents addcourse_back_Button As Button
    Friend WithEvents course_add_Button As Button
    Friend WithEvents course_programid_TextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents course_departmentid_TextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents course_units_TextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents course_coursdescription_TextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents course_coursecode_TextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents course_coursename_TextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents course_courseid_TextBox As TextBox
    Friend WithEvents Label2 As Label
End Class
