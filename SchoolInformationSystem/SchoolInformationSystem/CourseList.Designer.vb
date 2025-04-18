<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CourseList
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
        courselist_search_Button = New Button()
        courselist_add_Button = New Button()
        CourseDataGridView = New DataGridView()
        Panel1 = New Panel()
        course_programid_SearchField = New TextBox()
        Label8 = New Label()
        course_departmentid_SearchField = New TextBox()
        Label7 = New Label()
        course_units_SearchField = New TextBox()
        Label6 = New Label()
        course_coursedescription_SearchField = New TextBox()
        Label5 = New Label()
        course_coursecode_SearchField = New TextBox()
        Label4 = New Label()
        course_coursename_SearchField = New TextBox()
        Label3 = New Label()
        course_courseid_SearchField = New TextBox()
        Label2 = New Label()
        Panel2 = New Panel()
        courselist_back_Button = New Button()
        CType(CourseDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' courselist_search_Button
        ' 
        courselist_search_Button.BackColor = Color.Maroon
        courselist_search_Button.FlatStyle = FlatStyle.Popup
        courselist_search_Button.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        courselist_search_Button.ForeColor = SystemColors.ControlLightLight
        courselist_search_Button.Location = New Point(565, 252)
        courselist_search_Button.Name = "courselist_search_Button"
        courselist_search_Button.Size = New Size(122, 38)
        courselist_search_Button.TabIndex = 11
        courselist_search_Button.Text = "Search"
        courselist_search_Button.UseVisualStyleBackColor = False
        ' 
        ' courselist_add_Button
        ' 
        courselist_add_Button.BackColor = Color.Maroon
        courselist_add_Button.FlatStyle = FlatStyle.Popup
        courselist_add_Button.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        courselist_add_Button.ForeColor = SystemColors.ControlLightLight
        courselist_add_Button.Location = New Point(1725, 281)
        courselist_add_Button.Name = "courselist_add_Button"
        courselist_add_Button.Size = New Size(166, 48)
        courselist_add_Button.TabIndex = 9
        courselist_add_Button.Text = "Add"
        courselist_add_Button.UseVisualStyleBackColor = False
        ' 
        ' CourseDataGridView
        ' 
        CourseDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        CourseDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        CourseDataGridView.Dock = DockStyle.Bottom
        CourseDataGridView.Location = New Point(10, 231)
        CourseDataGridView.Name = "CourseDataGridView"
        CourseDataGridView.RowHeadersWidth = 51
        CourseDataGridView.Size = New Size(1664, 550)
        CourseDataGridView.TabIndex = 8
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.Controls.Add(course_programid_SearchField)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(course_departmentid_SearchField)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(course_units_SearchField)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(course_coursedescription_SearchField)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(course_coursecode_SearchField)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(course_coursename_SearchField)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(course_courseid_SearchField)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(64, 128)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(623, 128)
        Panel1.TabIndex = 29
        ' 
        ' course_programid_SearchField
        ' 
        course_programid_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        course_programid_SearchField.Location = New Point(322, 52)
        course_programid_SearchField.Name = "course_programid_SearchField"
        course_programid_SearchField.Size = New Size(100, 25)
        course_programid_SearchField.TabIndex = 42
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label8.Location = New Point(238, 55)
        Label8.Name = "Label8"
        Label8.Size = New Size(78, 17)
        Label8.TabIndex = 41
        Label8.Text = "Program ID"
        ' 
        ' course_departmentid_SearchField
        ' 
        course_departmentid_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        course_departmentid_SearchField.Location = New Point(126, 52)
        course_departmentid_SearchField.Name = "course_departmentid_SearchField"
        course_departmentid_SearchField.Size = New Size(100, 25)
        course_departmentid_SearchField.TabIndex = 40
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label7.Location = New Point(22, 55)
        Label7.Name = "Label7"
        Label7.Size = New Size(98, 17)
        Label7.TabIndex = 39
        Label7.Text = "Department ID"
        ' 
        ' course_units_SearchField
        ' 
        course_units_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        course_units_SearchField.Location = New Point(499, 52)
        course_units_SearchField.Name = "course_units_SearchField"
        course_units_SearchField.Size = New Size(100, 25)
        course_units_SearchField.TabIndex = 38
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label6.Location = New Point(454, 55)
        Label6.Name = "Label6"
        Label6.Size = New Size(39, 17)
        Label6.TabIndex = 37
        Label6.Text = "Units"
        ' 
        ' course_coursedescription_SearchField
        ' 
        course_coursedescription_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        course_coursedescription_SearchField.Location = New Point(146, 83)
        course_coursedescription_SearchField.Multiline = True
        course_coursedescription_SearchField.Name = "course_coursedescription_SearchField"
        course_coursedescription_SearchField.Size = New Size(453, 23)
        course_coursedescription_SearchField.TabIndex = 36
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label5.Location = New Point(22, 86)
        Label5.Name = "Label5"
        Label5.Size = New Size(122, 17)
        Label5.TabIndex = 35
        Label5.Text = "Course Description"
        ' 
        ' course_coursecode_SearchField
        ' 
        course_coursecode_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        course_coursecode_SearchField.Location = New Point(501, 21)
        course_coursecode_SearchField.Name = "course_coursecode_SearchField"
        course_coursecode_SearchField.Size = New Size(100, 25)
        course_coursecode_SearchField.TabIndex = 34
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label4.Location = New Point(410, 24)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 17)
        Label4.TabIndex = 33
        Label4.Text = "Course Code"
        ' 
        ' course_coursename_SearchField
        ' 
        course_coursename_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        course_coursename_SearchField.Location = New Point(297, 21)
        course_coursename_SearchField.Name = "course_coursename_SearchField"
        course_coursename_SearchField.Size = New Size(100, 25)
        course_coursename_SearchField.TabIndex = 32
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(202, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 17)
        Label3.TabIndex = 31
        Label3.Text = "Course Name"
        ' 
        ' course_courseid_SearchField
        ' 
        course_courseid_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        course_courseid_SearchField.Location = New Point(94, 21)
        course_courseid_SearchField.Name = "course_courseid_SearchField"
        course_courseid_SearchField.Size = New Size(100, 25)
        course_courseid_SearchField.TabIndex = 30
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label2.Location = New Point(21, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 17)
        Label2.TabIndex = 29
        Label2.Text = "Course ID"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Maroon
        Panel2.Location = New Point(64, 100)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(623, 32)
        Panel2.TabIndex = 30
        ' 
        ' courselist_back_Button
        ' 
        courselist_back_Button.BackColor = Color.Maroon
        courselist_back_Button.FlatStyle = FlatStyle.Popup
        courselist_back_Button.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        courselist_back_Button.ForeColor = SystemColors.ControlLightLight
        courselist_back_Button.Location = New Point(1725, 13)
        courselist_back_Button.Name = "courselist_back_Button"
        courselist_back_Button.Size = New Size(169, 47)
        courselist_back_Button.TabIndex = 31
        courselist_back_Button.Text = "Back"
        courselist_back_Button.UseVisualStyleBackColor = False
        ' 
        ' CourseList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.adminbg
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1684, 791)
        Controls.Add(courselist_back_Button)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(courselist_search_Button)
        Controls.Add(courselist_add_Button)
        Controls.Add(CourseDataGridView)
        Name = "CourseList"
        Padding = New Padding(10)
        Text = "CourseList"
        WindowState = FormWindowState.Maximized
        CType(CourseDataGridView, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents courselist_search_Button As Button
    Friend WithEvents courselist_add_Button As Button
    Friend WithEvents CourseDataGridView As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents course_programid_SearchField As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents course_departmentid_SearchField As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents course_units_SearchField As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents course_coursedescription_SearchField As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents course_coursecode_SearchField As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents course_coursename_SearchField As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents course_courseid_SearchField As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents courselist_back_Button As Button
End Class
