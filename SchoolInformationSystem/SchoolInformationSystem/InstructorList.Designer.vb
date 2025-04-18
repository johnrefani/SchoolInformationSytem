<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstructorList
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
        instructorlist_search_Button = New Button()
        instructorlist_add_Button = New Button()
        InstructorDataGridView = New DataGridView()
        Panel1 = New Panel()
        instructor_departmentid_TextBox = New TextBox()
        Label3 = New Label()
        instructor_hiredate_TextBox = New TextBox()
        instructor_hiredate_Label = New Label()
        instructor_contactnumber_TextBox = New TextBox()
        Label2 = New Label()
        instructor_email_TextBox = New TextBox()
        instructor_email_Label = New Label()
        instructor_gender_TextBox = New TextBox()
        instructor_gender_Label = New Label()
        instructor_idno_TextBox = New TextBox()
        instructor_idno_Label = New Label()
        instructor_birthdate_TextBox = New TextBox()
        instructor_birthdate_Label = New Label()
        instrutor_middlename_TextBox = New TextBox()
        instructor_firstname_TextBox = New TextBox()
        instructor_lastname_TextBox = New TextBox()
        insttructor_name_Label = New Label()
        Panel2 = New Panel()
        Label1 = New Label()
        instructor_back_Button = New Button()
        CType(InstructorDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' instructorlist_search_Button
        ' 
        instructorlist_search_Button.BackColor = Color.Maroon
        instructorlist_search_Button.FlatStyle = FlatStyle.Popup
        instructorlist_search_Button.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        instructorlist_search_Button.ForeColor = SystemColors.ControlLightLight
        instructorlist_search_Button.Location = New Point(577, 231)
        instructorlist_search_Button.Name = "instructorlist_search_Button"
        instructorlist_search_Button.Size = New Size(129, 35)
        instructorlist_search_Button.TabIndex = 11
        instructorlist_search_Button.Text = "Search"
        instructorlist_search_Button.UseVisualStyleBackColor = False
        ' 
        ' instructorlist_add_Button
        ' 
        instructorlist_add_Button.BackColor = Color.Maroon
        instructorlist_add_Button.FlatStyle = FlatStyle.Popup
        instructorlist_add_Button.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        instructorlist_add_Button.ForeColor = SystemColors.ControlLightLight
        instructorlist_add_Button.Location = New Point(1749, 246)
        instructorlist_add_Button.Name = "instructorlist_add_Button"
        instructorlist_add_Button.Size = New Size(145, 47)
        instructorlist_add_Button.TabIndex = 9
        instructorlist_add_Button.Text = "Add"
        instructorlist_add_Button.UseVisualStyleBackColor = False
        ' 
        ' InstructorDataGridView
        ' 
        InstructorDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        InstructorDataGridView.Dock = DockStyle.Bottom
        InstructorDataGridView.Location = New Point(10, 215)
        InstructorDataGridView.Name = "InstructorDataGridView"
        InstructorDataGridView.RowHeadersWidth = 62
        InstructorDataGridView.ScrollBars = ScrollBars.Vertical
        InstructorDataGridView.Size = New Size(1664, 550)
        InstructorDataGridView.TabIndex = 8
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.Controls.Add(instructor_departmentid_TextBox)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(instructor_hiredate_TextBox)
        Panel1.Controls.Add(instructor_hiredate_Label)
        Panel1.Controls.Add(instructor_contactnumber_TextBox)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(instructor_email_TextBox)
        Panel1.Controls.Add(instructor_email_Label)
        Panel1.Controls.Add(instructor_gender_TextBox)
        Panel1.Controls.Add(instructor_gender_Label)
        Panel1.Controls.Add(instructor_idno_TextBox)
        Panel1.Controls.Add(instructor_idno_Label)
        Panel1.Controls.Add(instructor_birthdate_TextBox)
        Panel1.Controls.Add(instructor_birthdate_Label)
        Panel1.Controls.Add(instrutor_middlename_TextBox)
        Panel1.Controls.Add(instructor_firstname_TextBox)
        Panel1.Controls.Add(instructor_lastname_TextBox)
        Panel1.Controls.Add(insttructor_name_Label)
        Panel1.Location = New Point(94, 86)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(612, 144)
        Panel1.TabIndex = 39
        ' 
        ' instructor_departmentid_TextBox
        ' 
        instructor_departmentid_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        instructor_departmentid_TextBox.Location = New Point(385, 75)
        instructor_departmentid_TextBox.Name = "instructor_departmentid_TextBox"
        instructor_departmentid_TextBox.Size = New Size(188, 25)
        instructor_departmentid_TextBox.TabIndex = 56
        instructor_departmentid_TextBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(281, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 17)
        Label3.TabIndex = 55
        Label3.Text = "Department ID"
        ' 
        ' instructor_hiredate_TextBox
        ' 
        instructor_hiredate_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        instructor_hiredate_TextBox.Location = New Point(112, 106)
        instructor_hiredate_TextBox.Name = "instructor_hiredate_TextBox"
        instructor_hiredate_TextBox.PlaceholderText = "YYYY-MM-DD"
        instructor_hiredate_TextBox.Size = New Size(107, 25)
        instructor_hiredate_TextBox.TabIndex = 54
        ' 
        ' instructor_hiredate_Label
        ' 
        instructor_hiredate_Label.AutoSize = True
        instructor_hiredate_Label.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        instructor_hiredate_Label.Location = New Point(41, 111)
        instructor_hiredate_Label.Name = "instructor_hiredate_Label"
        instructor_hiredate_Label.Size = New Size(65, 17)
        instructor_hiredate_Label.TabIndex = 53
        instructor_hiredate_Label.Text = "Hire Date"
        ' 
        ' instructor_contactnumber_TextBox
        ' 
        instructor_contactnumber_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        instructor_contactnumber_TextBox.Location = New Point(155, 75)
        instructor_contactnumber_TextBox.Name = "instructor_contactnumber_TextBox"
        instructor_contactnumber_TextBox.Size = New Size(120, 25)
        instructor_contactnumber_TextBox.TabIndex = 52
        instructor_contactnumber_TextBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label2.Location = New Point(40, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 17)
        Label2.TabIndex = 51
        Label2.Text = "Contact Number"
        ' 
        ' instructor_email_TextBox
        ' 
        instructor_email_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        instructor_email_TextBox.Location = New Point(419, 44)
        instructor_email_TextBox.Name = "instructor_email_TextBox"
        instructor_email_TextBox.Size = New Size(154, 25)
        instructor_email_TextBox.TabIndex = 50
        instructor_email_TextBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' instructor_email_Label
        ' 
        instructor_email_Label.AutoSize = True
        instructor_email_Label.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        instructor_email_Label.Location = New Point(320, 47)
        instructor_email_Label.Name = "instructor_email_Label"
        instructor_email_Label.Size = New Size(93, 17)
        instructor_email_Label.TabIndex = 49
        instructor_email_Label.Text = "Email Address"
        ' 
        ' instructor_gender_TextBox
        ' 
        instructor_gender_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        instructor_gender_TextBox.Location = New Point(269, 44)
        instructor_gender_TextBox.Name = "instructor_gender_TextBox"
        instructor_gender_TextBox.Size = New Size(45, 25)
        instructor_gender_TextBox.TabIndex = 48
        instructor_gender_TextBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' instructor_gender_Label
        ' 
        instructor_gender_Label.AutoSize = True
        instructor_gender_Label.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        instructor_gender_Label.Location = New Point(211, 47)
        instructor_gender_Label.Name = "instructor_gender_Label"
        instructor_gender_Label.Size = New Size(52, 17)
        instructor_gender_Label.TabIndex = 47
        instructor_gender_Label.Text = "Gender"
        ' 
        ' instructor_idno_TextBox
        ' 
        instructor_idno_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        instructor_idno_TextBox.Location = New Point(483, 13)
        instructor_idno_TextBox.Name = "instructor_idno_TextBox"
        instructor_idno_TextBox.Size = New Size(90, 25)
        instructor_idno_TextBox.TabIndex = 46
        ' 
        ' instructor_idno_Label
        ' 
        instructor_idno_Label.AutoSize = True
        instructor_idno_Label.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        instructor_idno_Label.Location = New Point(402, 16)
        instructor_idno_Label.Name = "instructor_idno_Label"
        instructor_idno_Label.Size = New Size(75, 17)
        instructor_idno_Label.TabIndex = 45
        instructor_idno_Label.Text = "ID Number"
        ' 
        ' instructor_birthdate_TextBox
        ' 
        instructor_birthdate_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        instructor_birthdate_TextBox.Location = New Point(115, 44)
        instructor_birthdate_TextBox.Name = "instructor_birthdate_TextBox"
        instructor_birthdate_TextBox.Size = New Size(90, 25)
        instructor_birthdate_TextBox.TabIndex = 44
        ' 
        ' instructor_birthdate_Label
        ' 
        instructor_birthdate_Label.AutoSize = True
        instructor_birthdate_Label.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        instructor_birthdate_Label.Location = New Point(40, 47)
        instructor_birthdate_Label.Name = "instructor_birthdate_Label"
        instructor_birthdate_Label.Size = New Size(69, 17)
        instructor_birthdate_Label.TabIndex = 43
        instructor_birthdate_Label.Text = "Birth Date"
        ' 
        ' instrutor_middlename_TextBox
        ' 
        instrutor_middlename_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        instrutor_middlename_TextBox.Location = New Point(296, 13)
        instrutor_middlename_TextBox.Name = "instrutor_middlename_TextBox"
        instrutor_middlename_TextBox.Size = New Size(100, 25)
        instrutor_middlename_TextBox.TabIndex = 42
        ' 
        ' instructor_firstname_TextBox
        ' 
        instructor_firstname_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        instructor_firstname_TextBox.Location = New Point(190, 13)
        instructor_firstname_TextBox.Name = "instructor_firstname_TextBox"
        instructor_firstname_TextBox.Size = New Size(100, 25)
        instructor_firstname_TextBox.TabIndex = 41
        ' 
        ' instructor_lastname_TextBox
        ' 
        instructor_lastname_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        instructor_lastname_TextBox.Location = New Point(84, 13)
        instructor_lastname_TextBox.Name = "instructor_lastname_TextBox"
        instructor_lastname_TextBox.Size = New Size(100, 25)
        instructor_lastname_TextBox.TabIndex = 40
        ' 
        ' insttructor_name_Label
        ' 
        insttructor_name_Label.AutoSize = True
        insttructor_name_Label.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        insttructor_name_Label.Location = New Point(40, 16)
        insttructor_name_Label.Name = "insttructor_name_Label"
        insttructor_name_Label.Size = New Size(44, 17)
        insttructor_name_Label.TabIndex = 39
        insttructor_name_Label.Text = "Name"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Maroon
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(94, 54)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(612, 32)
        Panel2.TabIndex = 40
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Maroon
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(19, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(40, 17)
        Label1.TabIndex = 40
        Label1.Text = "Filter"
        ' 
        ' instructor_back_Button
        ' 
        instructor_back_Button.BackColor = Color.Maroon
        instructor_back_Button.FlatStyle = FlatStyle.Popup
        instructor_back_Button.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        instructor_back_Button.ForeColor = SystemColors.ControlLightLight
        instructor_back_Button.Location = New Point(1751, 13)
        instructor_back_Button.Name = "instructor_back_Button"
        instructor_back_Button.Size = New Size(143, 47)
        instructor_back_Button.TabIndex = 41
        instructor_back_Button.Text = "Back"
        instructor_back_Button.UseVisualStyleBackColor = False
        ' 
        ' InstructorList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.adminbg
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1684, 775)
        Controls.Add(instructor_back_Button)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(instructorlist_search_Button)
        Controls.Add(instructorlist_add_Button)
        Controls.Add(InstructorDataGridView)
        Name = "InstructorList"
        Padding = New Padding(10, 10, 10, 10)
        Text = "InstructorList"
        WindowState = FormWindowState.Maximized
        CType(InstructorDataGridView, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents instructorlist_search_Button As Button
    Friend WithEvents instructorlist_add_Button As Button
    Friend WithEvents InstructorDataGridView As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents instructor_departmentid_TextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents instructor_hiredate_TextBox As TextBox
    Friend WithEvents instructor_hiredate_Label As Label
    Friend WithEvents instructor_contactnumber_TextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents instructor_email_TextBox As TextBox
    Friend WithEvents instructor_email_Label As Label
    Friend WithEvents instructor_gender_TextBox As TextBox
    Friend WithEvents instructor_gender_Label As Label
    Friend WithEvents instructor_idno_TextBox As TextBox
    Friend WithEvents instructor_idno_Label As Label
    Friend WithEvents instructor_birthdate_TextBox As TextBox
    Friend WithEvents instructor_birthdate_Label As Label
    Friend WithEvents instrutor_middlename_TextBox As TextBox
    Friend WithEvents instructor_firstname_TextBox As TextBox
    Friend WithEvents instructor_lastname_TextBox As TextBox
    Friend WithEvents insttructor_name_Label As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents instructor_back_Button As Button
End Class
