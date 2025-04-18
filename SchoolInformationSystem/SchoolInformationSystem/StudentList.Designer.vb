<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentList
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
        StudentsDataGridView = New DataGridView()
        studentlist_add_Button = New Button()
        studentlist_search_Button = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel1 = New Panel()
        student_suffix_SearchField = New TextBox()
        Label1 = New Label()
        student_yl_SearchField = New TextBox()
        student_yl_Label = New Label()
        student_idnumber_SearchField = New TextBox()
        student_idno_Label = New Label()
        student_email_SearchField = New TextBox()
        student_email_Label = New Label()
        student_contact_SearchField = New TextBox()
        Label3 = New Label()
        student_postalcode_SearchField = New TextBox()
        student_province_SearchField = New TextBox()
        student_municipality_SearchField = New TextBox()
        student_barangay_SearchField = New TextBox()
        student_street_SearchField = New TextBox()
        student_address_Label = New Label()
        student_gender_SearchField = New TextBox()
        student_sex_Label = New Label()
        student_birthdate_SearchField = New TextBox()
        student_birthdate_Label = New Label()
        student_age_Label = New Label()
        student_name_Label = New Label()
        student_enrolmentdate_SearchField = New TextBox()
        student_middlename_SearchField = New TextBox()
        student_firstname_SearchField = New TextBox()
        student_lastname_SearchField = New TextBox()
        Panel2 = New Panel()
        Label2 = New Label()
        studentlist_back_button = New Button()
        CType(StudentsDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' StudentsDataGridView
        ' 
        StudentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        StudentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        StudentsDataGridView.Dock = DockStyle.Bottom
        StudentsDataGridView.Location = New Point(9, 283)
        StudentsDataGridView.Name = "StudentsDataGridView"
        StudentsDataGridView.RowHeadersWidth = 51
        StudentsDataGridView.Size = New Size(1666, 500)
        StudentsDataGridView.TabIndex = 0
        ' 
        ' studentlist_add_Button
        ' 
        studentlist_add_Button.BackColor = Color.Maroon
        studentlist_add_Button.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        studentlist_add_Button.ForeColor = Color.White
        studentlist_add_Button.Location = New Point(1012, 358)
        studentlist_add_Button.Name = "studentlist_add_Button"
        studentlist_add_Button.Size = New Size(78, 32)
        studentlist_add_Button.TabIndex = 1
        studentlist_add_Button.Text = "Add"
        studentlist_add_Button.UseVisualStyleBackColor = False
        ' 
        ' studentlist_search_Button
        ' 
        studentlist_search_Button.BackColor = Color.Maroon
        studentlist_search_Button.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        studentlist_search_Button.ForeColor = Color.White
        studentlist_search_Button.Location = New Point(904, 358)
        studentlist_search_Button.Name = "studentlist_search_Button"
        studentlist_search_Button.Size = New Size(75, 32)
        studentlist_search_Button.TabIndex = 3
        studentlist_search_Button.Text = "Search"
        studentlist_search_Button.UseVisualStyleBackColor = False
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Location = New Point(6, 304)
        FlowLayoutPanel1.Margin = New Padding(3, 2, 3, 2)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(0, 0)
        FlowLayoutPanel1.TabIndex = 147
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.Controls.Add(student_suffix_SearchField)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(student_yl_SearchField)
        Panel1.Controls.Add(student_yl_Label)
        Panel1.Controls.Add(student_idnumber_SearchField)
        Panel1.Controls.Add(student_idno_Label)
        Panel1.Controls.Add(student_email_SearchField)
        Panel1.Controls.Add(student_email_Label)
        Panel1.Controls.Add(student_contact_SearchField)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(student_postalcode_SearchField)
        Panel1.Controls.Add(student_province_SearchField)
        Panel1.Controls.Add(student_municipality_SearchField)
        Panel1.Controls.Add(student_barangay_SearchField)
        Panel1.Controls.Add(student_street_SearchField)
        Panel1.Controls.Add(student_address_Label)
        Panel1.Controls.Add(student_gender_SearchField)
        Panel1.Controls.Add(student_sex_Label)
        Panel1.Controls.Add(student_birthdate_SearchField)
        Panel1.Controls.Add(student_birthdate_Label)
        Panel1.Controls.Add(student_age_Label)
        Panel1.Controls.Add(student_name_Label)
        Panel1.Controls.Add(student_enrolmentdate_SearchField)
        Panel1.Controls.Add(student_middlename_SearchField)
        Panel1.Controls.Add(student_firstname_SearchField)
        Panel1.Controls.Add(student_lastname_SearchField)
        Panel1.Location = New Point(10, 86)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(9, 8, 9, 8)
        Panel1.Size = New Size(1107, 267)
        Panel1.TabIndex = 148
        ' 
        ' student_suffix_SearchField
        ' 
        student_suffix_SearchField.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        student_suffix_SearchField.Location = New Point(665, 64)
        student_suffix_SearchField.Margin = New Padding(3, 2, 3, 2)
        student_suffix_SearchField.Name = "student_suffix_SearchField"
        student_suffix_SearchField.PlaceholderText = "suffix"
        student_suffix_SearchField.Size = New Size(90, 26)
        student_suffix_SearchField.TabIndex = 172
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label1.Location = New Point(742, 178)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 19)
        Label1.TabIndex = 171
        Label1.Text = "Postal Code"
        ' 
        ' student_yl_SearchField
        ' 
        student_yl_SearchField.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        student_yl_SearchField.Location = New Point(860, 63)
        student_yl_SearchField.Name = "student_yl_SearchField"
        student_yl_SearchField.Size = New Size(101, 26)
        student_yl_SearchField.TabIndex = 170
        ' 
        ' student_yl_Label
        ' 
        student_yl_Label.AutoSize = True
        student_yl_Label.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        student_yl_Label.Location = New Point(786, 73)
        student_yl_Label.Name = "student_yl_Label"
        student_yl_Label.Size = New Size(78, 19)
        student_yl_Label.TabIndex = 169
        student_yl_Label.Text = "Year Level"
        ' 
        ' student_idnumber_SearchField
        ' 
        student_idnumber_SearchField.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        student_idnumber_SearchField.Location = New Point(711, 101)
        student_idnumber_SearchField.Name = "student_idnumber_SearchField"
        student_idnumber_SearchField.Size = New Size(151, 26)
        student_idnumber_SearchField.TabIndex = 168
        ' 
        ' student_idno_Label
        ' 
        student_idno_Label.AutoSize = True
        student_idno_Label.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        student_idno_Label.Location = New Point(626, 111)
        student_idno_Label.Name = "student_idno_Label"
        student_idno_Label.Size = New Size(82, 19)
        student_idno_Label.TabIndex = 167
        student_idno_Label.Text = "ID Number"
        ' 
        ' student_email_SearchField
        ' 
        student_email_SearchField.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        student_email_SearchField.Location = New Point(563, 178)
        student_email_SearchField.Name = "student_email_SearchField"
        student_email_SearchField.Size = New Size(151, 26)
        student_email_SearchField.TabIndex = 166
        ' 
        ' student_email_Label
        ' 
        student_email_Label.AutoSize = True
        student_email_Label.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        student_email_Label.Location = New Point(450, 181)
        student_email_Label.Name = "student_email_Label"
        student_email_Label.Size = New Size(103, 19)
        student_email_Label.TabIndex = 165
        student_email_Label.Text = "Email Address"
        ' 
        ' student_contact_SearchField
        ' 
        student_contact_SearchField.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        student_contact_SearchField.Location = New Point(261, 176)
        student_contact_SearchField.Name = "student_contact_SearchField"
        student_contact_SearchField.Size = New Size(140, 26)
        student_contact_SearchField.TabIndex = 164
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label3.Location = New Point(164, 178)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 19)
        Label3.TabIndex = 163
        Label3.Text = "Contact No."
        ' 
        ' student_postalcode_SearchField
        ' 
        student_postalcode_SearchField.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        student_postalcode_SearchField.Location = New Point(837, 176)
        student_postalcode_SearchField.Name = "student_postalcode_SearchField"
        student_postalcode_SearchField.Size = New Size(143, 26)
        student_postalcode_SearchField.TabIndex = 162
        ' 
        ' student_province_SearchField
        ' 
        student_province_SearchField.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        student_province_SearchField.Location = New Point(829, 138)
        student_province_SearchField.Name = "student_province_SearchField"
        student_province_SearchField.PlaceholderText = "Province"
        student_province_SearchField.Size = New Size(171, 26)
        student_province_SearchField.TabIndex = 161
        ' 
        ' student_municipality_SearchField
        ' 
        student_municipality_SearchField.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        student_municipality_SearchField.Location = New Point(634, 138)
        student_municipality_SearchField.Name = "student_municipality_SearchField"
        student_municipality_SearchField.PlaceholderText = "Municipality"
        student_municipality_SearchField.Size = New Size(168, 26)
        student_municipality_SearchField.TabIndex = 160
        ' 
        ' student_barangay_SearchField
        ' 
        student_barangay_SearchField.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        student_barangay_SearchField.Location = New Point(433, 138)
        student_barangay_SearchField.Name = "student_barangay_SearchField"
        student_barangay_SearchField.PlaceholderText = "Barangay"
        student_barangay_SearchField.Size = New Size(178, 26)
        student_barangay_SearchField.TabIndex = 159
        ' 
        ' student_street_SearchField
        ' 
        student_street_SearchField.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        student_street_SearchField.Location = New Point(227, 138)
        student_street_SearchField.Name = "student_street_SearchField"
        student_street_SearchField.PlaceholderText = "Street"
        student_street_SearchField.Size = New Size(185, 26)
        student_street_SearchField.TabIndex = 158
        ' 
        ' student_address_Label
        ' 
        student_address_Label.AutoSize = True
        student_address_Label.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        student_address_Label.Location = New Point(154, 146)
        student_address_Label.Name = "student_address_Label"
        student_address_Label.Size = New Size(63, 19)
        student_address_Label.TabIndex = 157
        student_address_Label.Text = "Address"
        ' 
        ' student_gender_SearchField
        ' 
        student_gender_SearchField.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        student_gender_SearchField.Location = New Point(951, 101)
        student_gender_SearchField.Name = "student_gender_SearchField"
        student_gender_SearchField.Size = New Size(78, 26)
        student_gender_SearchField.TabIndex = 156
        student_gender_SearchField.TextAlign = HorizontalAlignment.Center
        ' 
        ' student_sex_Label
        ' 
        student_sex_Label.AutoSize = True
        student_sex_Label.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        student_sex_Label.Location = New Point(894, 111)
        student_sex_Label.Name = "student_sex_Label"
        student_sex_Label.Size = New Size(58, 19)
        student_sex_Label.TabIndex = 155
        student_sex_Label.Text = "Gender"
        ' 
        ' student_birthdate_SearchField
        ' 
        student_birthdate_SearchField.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        student_birthdate_SearchField.Location = New Point(469, 101)
        student_birthdate_SearchField.Name = "student_birthdate_SearchField"
        student_birthdate_SearchField.PlaceholderText = "YYYY-MM-DAY"
        student_birthdate_SearchField.Size = New Size(142, 26)
        student_birthdate_SearchField.TabIndex = 154
        ' 
        ' student_birthdate_Label
        ' 
        student_birthdate_Label.AutoSize = True
        student_birthdate_Label.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        student_birthdate_Label.Location = New Point(391, 111)
        student_birthdate_Label.Name = "student_birthdate_Label"
        student_birthdate_Label.Size = New Size(76, 19)
        student_birthdate_Label.TabIndex = 153
        student_birthdate_Label.Text = "Birth Date"
        ' 
        ' student_age_Label
        ' 
        student_age_Label.AutoSize = True
        student_age_Label.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        student_age_Label.Location = New Point(111, 111)
        student_age_Label.Name = "student_age_Label"
        student_age_Label.Size = New Size(112, 19)
        student_age_Label.TabIndex = 152
        student_age_Label.Text = "Enrolment Date"
        ' 
        ' student_name_Label
        ' 
        student_name_Label.AutoSize = True
        student_name_Label.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        student_name_Label.Location = New Point(111, 70)
        student_name_Label.Name = "student_name_Label"
        student_name_Label.Size = New Size(49, 19)
        student_name_Label.TabIndex = 151
        student_name_Label.Text = "Name"
        ' 
        ' student_enrolmentdate_SearchField
        ' 
        student_enrolmentdate_SearchField.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        student_enrolmentdate_SearchField.Location = New Point(227, 98)
        student_enrolmentdate_SearchField.Name = "student_enrolmentdate_SearchField"
        student_enrolmentdate_SearchField.PlaceholderText = "YYYY-MM-DD"
        student_enrolmentdate_SearchField.Size = New Size(151, 26)
        student_enrolmentdate_SearchField.TabIndex = 150
        ' 
        ' student_middlename_SearchField
        ' 
        student_middlename_SearchField.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        student_middlename_SearchField.Location = New Point(488, 63)
        student_middlename_SearchField.Name = "student_middlename_SearchField"
        student_middlename_SearchField.PlaceholderText = "Last Name"
        student_middlename_SearchField.Size = New Size(142, 26)
        student_middlename_SearchField.TabIndex = 149
        ' 
        ' student_firstname_SearchField
        ' 
        student_firstname_SearchField.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        student_firstname_SearchField.Location = New Point(326, 62)
        student_firstname_SearchField.Name = "student_firstname_SearchField"
        student_firstname_SearchField.PlaceholderText = "Middle Name"
        student_firstname_SearchField.Size = New Size(139, 26)
        student_firstname_SearchField.TabIndex = 148
        ' 
        ' student_lastname_SearchField
        ' 
        student_lastname_SearchField.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        student_lastname_SearchField.Location = New Point(159, 62)
        student_lastname_SearchField.Name = "student_lastname_SearchField"
        student_lastname_SearchField.PlaceholderText = "First Name"
        student_lastname_SearchField.Size = New Size(140, 26)
        student_lastname_SearchField.TabIndex = 147
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Maroon
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(10, 49)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1110, 44)
        Panel2.TabIndex = 173
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(509, 8)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 32)
        Label2.TabIndex = 0
        Label2.Text = "F I L T E R"
        ' 
        ' studentlist_back_button
        ' 
        studentlist_back_button.BackColor = Color.Maroon
        studentlist_back_button.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        studentlist_back_button.ForeColor = Color.White
        studentlist_back_button.Location = New Point(1037, 10)
        studentlist_back_button.Margin = New Padding(3, 2, 3, 2)
        studentlist_back_button.Name = "studentlist_back_button"
        studentlist_back_button.Size = New Size(82, 29)
        studentlist_back_button.TabIndex = 174
        studentlist_back_button.Text = "Back"
        studentlist_back_button.UseVisualStyleBackColor = False
        ' 
        ' StudentList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.adminbg
        ClientSize = New Size(1684, 791)
        Controls.Add(studentlist_back_button)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(studentlist_search_Button)
        Controls.Add(studentlist_add_Button)
        Controls.Add(StudentsDataGridView)
        Name = "StudentList"
        Padding = New Padding(9, 8, 9, 8)
        Text = "Student List Page"
        WindowState = FormWindowState.Maximized
        CType(StudentsDataGridView, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents student_age_TextBox As TextBox
    Friend WithEvents student_nationality_Label As Label
    Friend WithEvents student_nationality_TextBox As TextBox
    Friend WithEvents student_height_TextBox As TextBox
    Friend WithEvents student_weight_Label As Label
    Friend WithEvents student_weight_TextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents student_bloodtype_TextBox As TextBox
    Friend WithEvents student_sex_TextBox As TextBox
    Friend WithEvents student_houseno_TextBox As TextBox
    Friend WithEvents student_zipcode_TextBox As TextBox
    Friend WithEvents father_name_Label As Label
    Friend WithEvents father_lastname_TextBox As TextBox
    Friend WithEvents father_firstname_TextBox As TextBox
    Friend WithEvents father_middlename_TextBox As TextBox
    Friend WithEvents father_occupation_TextBox As TextBox
    Friend WithEvents father_occupation_Label As Label
    Friend WithEvents father_contact_TextBox As TextBox
    Friend WithEvents father_contact_Label As Label
    Friend WithEvents mother_occupation_TextBox As TextBox
    Friend WithEvents mother_occupation_Label As Label
    Friend WithEvents mother_contact_TextBox As TextBox
    Friend WithEvents mother_contact_Label As Label
    Friend WithEvents mother_middlename_TextBox As TextBox
    Friend WithEvents mother_firstname_TextBox As TextBox
    Friend WithEvents mother_lastname_TextBox As TextBox
    Friend WithEvents mother_name_Label As Label
    Friend WithEvents student_idno_TextBox As TextBox
    Friend WithEvents student_status_TextBox As TextBox
    Friend WithEvents student_status_Label As Label
    Friend WithEvents student_block_TextBox As TextBox
    Friend WithEvents student_block_Label As Label
    Friend WithEvents student_department_Label As Label
    Friend WithEvents student_department_TextBox As TextBox
    Friend WithEvents student_course_TextBox As TextBox
    Friend WithEvents student_course_Label As Label
    Friend WithEvents student_COE_Button As Button
    Friend WithEvents student_COR_Button As Button
    Friend WithEvents student_COG_Button As Button
    Friend WithEvents student_TOR_Button As Button
    Friend WithEvents StudentsDataGridView As DataGridView
    Friend WithEvents studentlist_add_Button As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents studentlist_search_Button As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents student_yl_SearchField As TextBox
    Friend WithEvents student_yl_Label As Label
    Friend WithEvents student_idnumber_SearchField As TextBox
    Friend WithEvents student_idno_Label As Label
    Friend WithEvents student_email_SearchField As TextBox
    Friend WithEvents student_email_Label As Label
    Friend WithEvents student_contact_SearchField As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents student_postalcode_SearchField As TextBox
    Friend WithEvents student_province_SearchField As TextBox
    Friend WithEvents student_municipality_SearchField As TextBox
    Friend WithEvents student_barangay_SearchField As TextBox
    Friend WithEvents student_street_SearchField As TextBox
    Friend WithEvents student_address_Label As Label
    Friend WithEvents student_gender_SearchField As TextBox
    Friend WithEvents student_sex_Label As Label
    Friend WithEvents student_birthdate_SearchField As TextBox
    Friend WithEvents student_birthdate_Label As Label
    Friend WithEvents student_age_Label As Label
    Friend WithEvents student_name_Label As Label
    Friend WithEvents student_enrolmentdate_SearchField As TextBox
    Friend WithEvents student_middlename_SearchField As TextBox
    Friend WithEvents student_firstname_SearchField As TextBox
    Friend WithEvents student_lastname_SearchField As TextBox
    Friend WithEvents student_suffix_SearchField As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents studentlist_back_button As Button
End Class
