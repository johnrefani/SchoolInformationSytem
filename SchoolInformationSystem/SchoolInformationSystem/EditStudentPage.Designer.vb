<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditStudentPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditStudentPage))
        Panel1 = New Panel()
        ComboBox1 = New ComboBox()
        editstudent_cancel_Button = New Button()
        editstudent_save_Button = New Button()
        Label1 = New Label()
        student_yl_TextBox = New TextBox()
        student_yl_Label = New Label()
        student_studentid_TextBox = New TextBox()
        student_idno_Label = New Label()
        student_email_TextBox = New TextBox()
        student_email_Label = New Label()
        student_contact_TextBox = New TextBox()
        Label3 = New Label()
        student_postalcode_TextBox = New TextBox()
        student_province_TextBox = New TextBox()
        student_municipality_TextBox = New TextBox()
        student_barangay_TextBox = New TextBox()
        student_street_TextBox = New TextBox()
        student_address_Label = New Label()
        student_sex_Label = New Label()
        student_birthdate_TextBox = New TextBox()
        student_birthdate_Label = New Label()
        student_age_Label = New Label()
        student_name_Label = New Label()
        student_enrolmentdate_TextBox = New TextBox()
        student_middlename_TextBox = New TextBox()
        student_firstname_TextBox = New TextBox()
        student_lastname_TextBox = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLight
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(editstudent_cancel_Button)
        Panel1.Controls.Add(editstudent_save_Button)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(student_yl_TextBox)
        Panel1.Controls.Add(student_yl_Label)
        Panel1.Controls.Add(student_studentid_TextBox)
        Panel1.Controls.Add(student_idno_Label)
        Panel1.Controls.Add(student_email_TextBox)
        Panel1.Controls.Add(student_email_Label)
        Panel1.Controls.Add(student_contact_TextBox)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(student_postalcode_TextBox)
        Panel1.Controls.Add(student_province_TextBox)
        Panel1.Controls.Add(student_municipality_TextBox)
        Panel1.Controls.Add(student_barangay_TextBox)
        Panel1.Controls.Add(student_street_TextBox)
        Panel1.Controls.Add(student_address_Label)
        Panel1.Controls.Add(student_sex_Label)
        Panel1.Controls.Add(student_birthdate_TextBox)
        Panel1.Controls.Add(student_birthdate_Label)
        Panel1.Controls.Add(student_age_Label)
        Panel1.Controls.Add(student_name_Label)
        Panel1.Controls.Add(student_enrolmentdate_TextBox)
        Panel1.Controls.Add(student_middlename_TextBox)
        Panel1.Controls.Add(student_firstname_TextBox)
        Panel1.Controls.Add(student_lastname_TextBox)
        Panel1.Location = New Point(353, 115)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(822, 338)
        Panel1.TabIndex = 149
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Male", "Female", "Other"})
        ComboBox1.Location = New Point(712, 81)
        ComboBox1.Margin = New Padding(3, 2, 3, 2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(78, 23)
        ComboBox1.TabIndex = 176
        ComboBox1.Text = "Male"
        ' 
        ' editstudent_cancel_Button
        ' 
        editstudent_cancel_Button.BackColor = Color.Maroon
        editstudent_cancel_Button.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        editstudent_cancel_Button.ForeColor = Color.White
        editstudent_cancel_Button.Location = New Point(431, 233)
        editstudent_cancel_Button.Name = "editstudent_cancel_Button"
        editstudent_cancel_Button.Size = New Size(75, 27)
        editstudent_cancel_Button.TabIndex = 175
        editstudent_cancel_Button.Text = "Cancel"
        editstudent_cancel_Button.UseVisualStyleBackColor = False
        ' 
        ' editstudent_save_Button
        ' 
        editstudent_save_Button.BackColor = Color.Maroon
        editstudent_save_Button.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        editstudent_save_Button.ForeColor = Color.White
        editstudent_save_Button.Location = New Point(295, 233)
        editstudent_save_Button.Name = "editstudent_save_Button"
        editstudent_save_Button.Size = New Size(75, 27)
        editstudent_save_Button.TabIndex = 174
        editstudent_save_Button.Text = "Save"
        editstudent_save_Button.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F)
        Label1.Location = New Point(535, 148)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 19)
        Label1.TabIndex = 173
        Label1.Text = "Postal Code"
        ' 
        ' student_yl_TextBox
        ' 
        student_yl_TextBox.Font = New Font("Segoe UI", 10F)
        student_yl_TextBox.Location = New Point(633, 48)
        student_yl_TextBox.Name = "student_yl_TextBox"
        student_yl_TextBox.Size = New Size(130, 25)
        student_yl_TextBox.TabIndex = 172
        ' 
        ' student_yl_Label
        ' 
        student_yl_Label.AutoSize = True
        student_yl_Label.Font = New Font("Segoe UI", 10F)
        student_yl_Label.Location = New Point(548, 50)
        student_yl_Label.Name = "student_yl_Label"
        student_yl_Label.Size = New Size(70, 19)
        student_yl_Label.TabIndex = 171
        student_yl_Label.Text = "Year Level"
        ' 
        ' student_studentid_TextBox
        ' 
        student_studentid_TextBox.Font = New Font("Segoe UI", 10F)
        student_studentid_TextBox.Location = New Point(571, 80)
        student_studentid_TextBox.Name = "student_studentid_TextBox"
        student_studentid_TextBox.Size = New Size(98, 25)
        student_studentid_TextBox.TabIndex = 170
        ' 
        ' student_idno_Label
        ' 
        student_idno_Label.AutoSize = True
        student_idno_Label.Font = New Font("Segoe UI", 10F)
        student_idno_Label.Location = New Point(483, 82)
        student_idno_Label.Name = "student_idno_Label"
        student_idno_Label.Size = New Size(77, 19)
        student_idno_Label.TabIndex = 169
        student_idno_Label.Text = "ID Number"
        ' 
        ' student_email_TextBox
        ' 
        student_email_TextBox.Font = New Font("Segoe UI", 10F)
        student_email_TextBox.Location = New Point(378, 146)
        student_email_TextBox.Name = "student_email_TextBox"
        student_email_TextBox.Size = New Size(133, 25)
        student_email_TextBox.TabIndex = 168
        ' 
        ' student_email_Label
        ' 
        student_email_Label.AutoSize = True
        student_email_Label.Font = New Font("Segoe UI", 10F)
        student_email_Label.Location = New Point(271, 148)
        student_email_Label.Name = "student_email_Label"
        student_email_Label.Size = New Size(94, 19)
        student_email_Label.TabIndex = 167
        student_email_Label.Text = "Email Address"
        ' 
        ' student_contact_TextBox
        ' 
        student_contact_TextBox.Font = New Font("Segoe UI", 10F)
        student_contact_TextBox.Location = New Point(159, 146)
        student_contact_TextBox.Name = "student_contact_TextBox"
        student_contact_TextBox.Size = New Size(107, 25)
        student_contact_TextBox.TabIndex = 166
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.Location = New Point(65, 148)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 19)
        Label3.TabIndex = 165
        Label3.Text = "Contact No."
        ' 
        ' student_postalcode_TextBox
        ' 
        student_postalcode_TextBox.Font = New Font("Segoe UI", 10F)
        student_postalcode_TextBox.Location = New Point(633, 142)
        student_postalcode_TextBox.Name = "student_postalcode_TextBox"
        student_postalcode_TextBox.Size = New Size(86, 25)
        student_postalcode_TextBox.TabIndex = 164
        ' 
        ' student_province_TextBox
        ' 
        student_province_TextBox.Font = New Font("Segoe UI", 10F)
        student_province_TextBox.Location = New Point(605, 111)
        student_province_TextBox.Name = "student_province_TextBox"
        student_province_TextBox.PlaceholderText = "Province"
        student_province_TextBox.Size = New Size(158, 25)
        student_province_TextBox.TabIndex = 163
        ' 
        ' student_municipality_TextBox
        ' 
        student_municipality_TextBox.Font = New Font("Segoe UI", 10F)
        student_municipality_TextBox.Location = New Point(438, 111)
        student_municipality_TextBox.Name = "student_municipality_TextBox"
        student_municipality_TextBox.PlaceholderText = "Municipality"
        student_municipality_TextBox.Size = New Size(154, 25)
        student_municipality_TextBox.TabIndex = 162
        ' 
        ' student_barangay_TextBox
        ' 
        student_barangay_TextBox.Font = New Font("Segoe UI", 10F)
        student_barangay_TextBox.Location = New Point(288, 111)
        student_barangay_TextBox.Name = "student_barangay_TextBox"
        student_barangay_TextBox.PlaceholderText = "Brangay"
        student_barangay_TextBox.Size = New Size(141, 25)
        student_barangay_TextBox.TabIndex = 161
        ' 
        ' student_street_TextBox
        ' 
        student_street_TextBox.Font = New Font("Segoe UI", 10F)
        student_street_TextBox.Location = New Point(146, 111)
        student_street_TextBox.Name = "student_street_TextBox"
        student_street_TextBox.PlaceholderText = "Street"
        student_street_TextBox.Size = New Size(130, 25)
        student_street_TextBox.TabIndex = 160
        ' 
        ' student_address_Label
        ' 
        student_address_Label.AutoSize = True
        student_address_Label.Font = New Font("Segoe UI", 10F)
        student_address_Label.Location = New Point(80, 111)
        student_address_Label.Name = "student_address_Label"
        student_address_Label.Size = New Size(58, 19)
        student_address_Label.TabIndex = 159
        student_address_Label.Text = "Address"
        ' 
        ' student_sex_Label
        ' 
        student_sex_Label.AutoSize = True
        student_sex_Label.Font = New Font("Segoe UI", 10F)
        student_sex_Label.Location = New Point(676, 82)
        student_sex_Label.Name = "student_sex_Label"
        student_sex_Label.Size = New Size(29, 19)
        student_sex_Label.TabIndex = 157
        student_sex_Label.Text = "Sex"
        ' 
        ' student_birthdate_TextBox
        ' 
        student_birthdate_TextBox.Font = New Font("Segoe UI", 10F)
        student_birthdate_TextBox.Location = New Point(377, 80)
        student_birthdate_TextBox.Name = "student_birthdate_TextBox"
        student_birthdate_TextBox.PlaceholderText = "YYYY-MM-DD"
        student_birthdate_TextBox.Size = New Size(101, 25)
        student_birthdate_TextBox.TabIndex = 156
        ' 
        ' student_birthdate_Label
        ' 
        student_birthdate_Label.AutoSize = True
        student_birthdate_Label.Font = New Font("Segoe UI", 10F)
        student_birthdate_Label.Location = New Point(297, 82)
        student_birthdate_Label.Name = "student_birthdate_Label"
        student_birthdate_Label.Size = New Size(71, 19)
        student_birthdate_Label.TabIndex = 155
        student_birthdate_Label.Text = "Birth Date"
        ' 
        ' student_age_Label
        ' 
        student_age_Label.AutoSize = True
        student_age_Label.Font = New Font("Segoe UI", 10F)
        student_age_Label.Location = New Point(55, 82)
        student_age_Label.Name = "student_age_Label"
        student_age_Label.Size = New Size(105, 19)
        student_age_Label.TabIndex = 154
        student_age_Label.Text = "Enrolment Date"
        ' 
        ' student_name_Label
        ' 
        student_name_Label.AutoSize = True
        student_name_Label.Font = New Font("Segoe UI", 10F)
        student_name_Label.Location = New Point(71, 50)
        student_name_Label.Name = "student_name_Label"
        student_name_Label.Size = New Size(45, 19)
        student_name_Label.TabIndex = 153
        student_name_Label.Text = "Name"
        ' 
        ' student_enrolmentdate_TextBox
        ' 
        student_enrolmentdate_TextBox.Font = New Font("Segoe UI", 10F)
        student_enrolmentdate_TextBox.Location = New Point(173, 80)
        student_enrolmentdate_TextBox.Name = "student_enrolmentdate_TextBox"
        student_enrolmentdate_TextBox.PlaceholderText = "YYYY-MM-DD"
        student_enrolmentdate_TextBox.Size = New Size(110, 25)
        student_enrolmentdate_TextBox.TabIndex = 152
        ' 
        ' student_middlename_TextBox
        ' 
        student_middlename_TextBox.Font = New Font("Segoe UI", 10F)
        student_middlename_TextBox.Location = New Point(397, 48)
        student_middlename_TextBox.Name = "student_middlename_TextBox"
        student_middlename_TextBox.PlaceholderText = "Middle Name"
        student_middlename_TextBox.Size = New Size(145, 25)
        student_middlename_TextBox.TabIndex = 151
        ' 
        ' student_firstname_TextBox
        ' 
        student_firstname_TextBox.Font = New Font("Segoe UI", 10F)
        student_firstname_TextBox.Location = New Point(244, 48)
        student_firstname_TextBox.Name = "student_firstname_TextBox"
        student_firstname_TextBox.PlaceholderText = "First Name"
        student_firstname_TextBox.Size = New Size(139, 25)
        student_firstname_TextBox.TabIndex = 150
        ' 
        ' student_lastname_TextBox
        ' 
        student_lastname_TextBox.Font = New Font("Segoe UI", 10F)
        student_lastname_TextBox.Location = New Point(125, 48)
        student_lastname_TextBox.Name = "student_lastname_TextBox"
        student_lastname_TextBox.PlaceholderText = "Last Name"
        student_lastname_TextBox.Size = New Size(114, 25)
        student_lastname_TextBox.TabIndex = 149
        ' 
        ' EditStudentPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1431, 587)
        Controls.Add(Panel1)
        Name = "EditStudentPage"
        Text = "EditStudentPage"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents editstudent_cancel_Button As Button
    Friend WithEvents editstudent_save_Button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents student_yl_TextBox As TextBox
    Friend WithEvents student_yl_Label As Label
    Friend WithEvents student_studentid_TextBox As TextBox
    Friend WithEvents student_idno_Label As Label
    Friend WithEvents student_email_TextBox As TextBox
    Friend WithEvents student_email_Label As Label
    Friend WithEvents student_contact_TextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents student_postalcode_TextBox As TextBox
    Friend WithEvents student_province_TextBox As TextBox
    Friend WithEvents student_municipality_TextBox As TextBox
    Friend WithEvents student_barangay_TextBox As TextBox
    Friend WithEvents student_street_TextBox As TextBox
    Friend WithEvents student_address_Label As Label
    Friend WithEvents student_sex_Label As Label
    Friend WithEvents student_birthdate_TextBox As TextBox
    Friend WithEvents student_birthdate_Label As Label
    Friend WithEvents student_age_Label As Label
    Friend WithEvents student_name_Label As Label
    Friend WithEvents student_enrolmentdate_TextBox As TextBox
    Friend WithEvents student_middlename_TextBox As TextBox
    Friend WithEvents student_firstname_TextBox As TextBox
    Friend WithEvents student_lastname_TextBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
