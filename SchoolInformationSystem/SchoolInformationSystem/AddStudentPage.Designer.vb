<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStudentPage
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
        student_gender_TextBox = New TextBox()
        student_sex_Label = New Label()
        student_birthdate_TextBox = New TextBox()
        student_birthdate_Label = New Label()
        student_age_Label = New Label()
        student_name_Label = New Label()
        student_enrolmentdate_TextBox = New TextBox()
        student_middlename_TextBox = New TextBox()
        student_firstname_TextBox = New TextBox()
        student_lastname_TextBox = New TextBox()
        block_add_Button = New Button()
        Label1 = New Label()
        Label2 = New Label()
        addstudent_back_Button = New Button()
        Panel1 = New Panel()
        TextBox1 = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' student_yl_TextBox
        ' 
        student_yl_TextBox.Location = New Point(847, 173)
        student_yl_TextBox.Margin = New Padding(3, 4, 3, 4)
        student_yl_TextBox.Name = "student_yl_TextBox"
        student_yl_TextBox.Size = New Size(65, 27)
        student_yl_TextBox.TabIndex = 109
        ' 
        ' student_yl_Label
        ' 
        student_yl_Label.AutoSize = True
        student_yl_Label.Font = New Font("Segoe UI Variable Display", 9F, FontStyle.Bold)
        student_yl_Label.Location = New Point(762, 176)
        student_yl_Label.Name = "student_yl_Label"
        student_yl_Label.Size = New Size(79, 20)
        student_yl_Label.TabIndex = 108
        student_yl_Label.Text = "Year Level"
        ' 
        ' student_studentid_TextBox
        ' 
        student_studentid_TextBox.Location = New Point(829, 130)
        student_studentid_TextBox.Margin = New Padding(3, 4, 3, 4)
        student_studentid_TextBox.Name = "student_studentid_TextBox"
        student_studentid_TextBox.Size = New Size(83, 27)
        student_studentid_TextBox.TabIndex = 105
        ' 
        ' student_idno_Label
        ' 
        student_idno_Label.AutoSize = True
        student_idno_Label.Font = New Font("Segoe UI Variable Display", 9F, FontStyle.Bold)
        student_idno_Label.Location = New Point(738, 133)
        student_idno_Label.Name = "student_idno_Label"
        student_idno_Label.Size = New Size(87, 20)
        student_idno_Label.TabIndex = 104
        student_idno_Label.Text = "ID Number"
        ' 
        ' student_email_TextBox
        ' 
        student_email_TextBox.Location = New Point(412, 208)
        student_email_TextBox.Margin = New Padding(3, 4, 3, 4)
        student_email_TextBox.Name = "student_email_TextBox"
        student_email_TextBox.Size = New Size(179, 27)
        student_email_TextBox.TabIndex = 87
        ' 
        ' student_email_Label
        ' 
        student_email_Label.AutoSize = True
        student_email_Label.Font = New Font("Segoe UI Variable Display", 9F, FontStyle.Bold)
        student_email_Label.Location = New Point(305, 212)
        student_email_Label.Name = "student_email_Label"
        student_email_Label.Size = New Size(107, 20)
        student_email_Label.TabIndex = 86
        student_email_Label.Text = "Email Address"
        ' 
        ' student_contact_TextBox
        ' 
        student_contact_TextBox.Location = New Point(130, 209)
        student_contact_TextBox.Margin = New Padding(3, 4, 3, 4)
        student_contact_TextBox.Name = "student_contact_TextBox"
        student_contact_TextBox.Size = New Size(168, 27)
        student_contact_TextBox.TabIndex = 85
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Variable Display", 9F, FontStyle.Bold)
        Label3.Location = New Point(29, 212)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 20)
        Label3.TabIndex = 84
        Label3.Text = "Contact No."
        ' 
        ' student_postalcode_TextBox
        ' 
        student_postalcode_TextBox.Location = New Point(715, 209)
        student_postalcode_TextBox.Margin = New Padding(3, 4, 3, 4)
        student_postalcode_TextBox.Name = "student_postalcode_TextBox"
        student_postalcode_TextBox.Size = New Size(90, 27)
        student_postalcode_TextBox.TabIndex = 83
        ' 
        ' student_province_TextBox
        ' 
        student_province_TextBox.Location = New Point(582, 174)
        student_province_TextBox.Margin = New Padding(3, 4, 3, 4)
        student_province_TextBox.Name = "student_province_TextBox"
        student_province_TextBox.PlaceholderText = "Province"
        student_province_TextBox.Size = New Size(150, 27)
        student_province_TextBox.TabIndex = 82
        ' 
        ' student_municipality_TextBox
        ' 
        student_municipality_TextBox.Location = New Point(424, 174)
        student_municipality_TextBox.Margin = New Padding(3, 4, 3, 4)
        student_municipality_TextBox.Name = "student_municipality_TextBox"
        student_municipality_TextBox.PlaceholderText = "Minicipality"
        student_municipality_TextBox.Size = New Size(152, 27)
        student_municipality_TextBox.TabIndex = 81
        ' 
        ' student_barangay_TextBox
        ' 
        student_barangay_TextBox.Location = New Point(260, 174)
        student_barangay_TextBox.Margin = New Padding(3, 4, 3, 4)
        student_barangay_TextBox.Name = "student_barangay_TextBox"
        student_barangay_TextBox.PlaceholderText = "Barangay"
        student_barangay_TextBox.Size = New Size(158, 27)
        student_barangay_TextBox.TabIndex = 80
        ' 
        ' student_street_TextBox
        ' 
        student_street_TextBox.Location = New Point(101, 173)
        student_street_TextBox.Margin = New Padding(3, 4, 3, 4)
        student_street_TextBox.Name = "student_street_TextBox"
        student_street_TextBox.PlaceholderText = "Street"
        student_street_TextBox.Size = New Size(153, 27)
        student_street_TextBox.TabIndex = 79
        ' 
        ' student_address_Label
        ' 
        student_address_Label.AutoSize = True
        student_address_Label.Font = New Font("Segoe UI Variable Display", 9F, FontStyle.Bold)
        student_address_Label.Location = New Point(32, 174)
        student_address_Label.Name = "student_address_Label"
        student_address_Label.Size = New Size(65, 20)
        student_address_Label.TabIndex = 78
        student_address_Label.Text = "Address"
        ' 
        ' student_gender_TextBox
        ' 
        student_gender_TextBox.Location = New Point(648, 130)
        student_gender_TextBox.Margin = New Padding(3, 4, 3, 4)
        student_gender_TextBox.Name = "student_gender_TextBox"
        student_gender_TextBox.Size = New Size(84, 27)
        student_gender_TextBox.TabIndex = 77
        student_gender_TextBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' student_sex_Label
        ' 
        student_sex_Label.AutoSize = True
        student_sex_Label.Font = New Font("Segoe UI Variable Display", 9F, FontStyle.Bold)
        student_sex_Label.Location = New Point(608, 132)
        student_sex_Label.Name = "student_sex_Label"
        student_sex_Label.Size = New Size(60, 20)
        student_sex_Label.TabIndex = 76
        student_sex_Label.Text = "Gender"
        ' 
        ' student_birthdate_TextBox
        ' 
        student_birthdate_TextBox.Location = New Point(412, 129)
        student_birthdate_TextBox.Margin = New Padding(3, 4, 3, 4)
        student_birthdate_TextBox.Name = "student_birthdate_TextBox"
        student_birthdate_TextBox.PlaceholderText = "YYYY-MM-DD"
        student_birthdate_TextBox.Size = New Size(190, 27)
        student_birthdate_TextBox.TabIndex = 67
        ' 
        ' student_birthdate_Label
        ' 
        student_birthdate_Label.AutoSize = True
        student_birthdate_Label.Font = New Font("Segoe UI Variable Display", 9F, FontStyle.Bold)
        student_birthdate_Label.Location = New Point(329, 132)
        student_birthdate_Label.Name = "student_birthdate_Label"
        student_birthdate_Label.Size = New Size(80, 20)
        student_birthdate_Label.TabIndex = 66
        student_birthdate_Label.Text = "Birth Date"
        ' 
        ' student_age_Label
        ' 
        student_age_Label.AutoSize = True
        student_age_Label.Font = New Font("Segoe UI Variable Display", 9F, FontStyle.Bold)
        student_age_Label.Location = New Point(42, 129)
        student_age_Label.Name = "student_age_Label"
        student_age_Label.Size = New Size(119, 20)
        student_age_Label.TabIndex = 65
        student_age_Label.Text = "Enrolment Date"
        ' 
        ' student_name_Label
        ' 
        student_name_Label.AutoSize = True
        student_name_Label.Font = New Font("Segoe UI Variable Display", 9F, FontStyle.Bold)
        student_name_Label.Location = New Point(43, 88)
        student_name_Label.Name = "student_name_Label"
        student_name_Label.Size = New Size(51, 20)
        student_name_Label.TabIndex = 64
        student_name_Label.Text = "Name"
        ' 
        ' student_enrolmentdate_TextBox
        ' 
        student_enrolmentdate_TextBox.Location = New Point(169, 129)
        student_enrolmentdate_TextBox.Margin = New Padding(3, 4, 3, 4)
        student_enrolmentdate_TextBox.Name = "student_enrolmentdate_TextBox"
        student_enrolmentdate_TextBox.PlaceholderText = "YYYY-MM-DD"
        student_enrolmentdate_TextBox.Size = New Size(154, 27)
        student_enrolmentdate_TextBox.TabIndex = 63
        ' 
        ' student_middlename_TextBox
        ' 
        student_middlename_TextBox.Location = New Point(458, 85)
        student_middlename_TextBox.Margin = New Padding(3, 4, 3, 4)
        student_middlename_TextBox.Name = "student_middlename_TextBox"
        student_middlename_TextBox.PlaceholderText = "Middle Name"
        student_middlename_TextBox.Size = New Size(171, 27)
        student_middlename_TextBox.TabIndex = 62
        ' 
        ' student_firstname_TextBox
        ' 
        student_firstname_TextBox.Location = New Point(260, 85)
        student_firstname_TextBox.Margin = New Padding(3, 4, 3, 4)
        student_firstname_TextBox.Name = "student_firstname_TextBox"
        student_firstname_TextBox.PlaceholderText = "First Name"
        student_firstname_TextBox.Size = New Size(192, 27)
        student_firstname_TextBox.TabIndex = 61
        ' 
        ' student_lastname_TextBox
        ' 
        student_lastname_TextBox.Location = New Point(100, 85)
        student_lastname_TextBox.Margin = New Padding(3, 4, 3, 4)
        student_lastname_TextBox.Name = "student_lastname_TextBox"
        student_lastname_TextBox.PlaceholderText = "Last Name"
        student_lastname_TextBox.Size = New Size(154, 27)
        student_lastname_TextBox.TabIndex = 60
        ' 
        ' block_add_Button
        ' 
        block_add_Button.BackColor = Color.Maroon
        block_add_Button.Font = New Font("Segoe UI Variable Display", 9F, FontStyle.Bold)
        block_add_Button.ForeColor = SystemColors.ButtonFace
        block_add_Button.Location = New Point(397, 360)
        block_add_Button.Margin = New Padding(3, 4, 3, 4)
        block_add_Button.Name = "block_add_Button"
        block_add_Button.Size = New Size(102, 55)
        block_add_Button.TabIndex = 120
        block_add_Button.Text = "Add"
        block_add_Button.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Variable Display", 9F, FontStyle.Bold)
        Label1.Location = New Point(621, 215)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 20)
        Label1.TabIndex = 121
        Label1.Text = "Postal Code"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(18, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(143, 27)
        Label2.TabIndex = 122
        Label2.Text = "Required Field"
        ' 
        ' addstudent_back_Button
        ' 
        addstudent_back_Button.BackColor = Color.Maroon
        addstudent_back_Button.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addstudent_back_Button.ForeColor = SystemColors.ButtonHighlight
        addstudent_back_Button.Location = New Point(1121, 60)
        addstudent_back_Button.Margin = New Padding(3, 4, 3, 4)
        addstudent_back_Button.Name = "addstudent_back_Button"
        addstudent_back_Button.Size = New Size(71, 49)
        addstudent_back_Button.TabIndex = 123
        addstudent_back_Button.Text = "Back"
        addstudent_back_Button.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(student_province_TextBox)
        Panel1.Controls.Add(block_add_Button)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(student_name_Label)
        Panel1.Controls.Add(student_lastname_TextBox)
        Panel1.Controls.Add(student_postalcode_TextBox)
        Panel1.Controls.Add(student_studentid_TextBox)
        Panel1.Controls.Add(student_yl_TextBox)
        Panel1.Controls.Add(student_email_TextBox)
        Panel1.Controls.Add(student_idno_Label)
        Panel1.Controls.Add(student_email_Label)
        Panel1.Controls.Add(student_firstname_TextBox)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(student_contact_TextBox)
        Panel1.Controls.Add(student_yl_Label)
        Panel1.Controls.Add(student_middlename_TextBox)
        Panel1.Controls.Add(student_age_Label)
        Panel1.Controls.Add(student_enrolmentdate_TextBox)
        Panel1.Controls.Add(student_birthdate_Label)
        Panel1.Controls.Add(student_birthdate_TextBox)
        Panel1.Controls.Add(student_municipality_TextBox)
        Panel1.Controls.Add(student_sex_Label)
        Panel1.Controls.Add(student_barangay_TextBox)
        Panel1.Controls.Add(student_gender_TextBox)
        Panel1.Controls.Add(student_street_TextBox)
        Panel1.Controls.Add(student_address_Label)
        Panel1.Location = New Point(292, 116)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(940, 450)
        Panel1.TabIndex = 124
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(648, 85)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "suffix"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 123
        ' 
        ' AddStudentPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.adminbg
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1924, 1055)
        Controls.Add(addstudent_back_Button)
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "AddStudentPage"
        Text = "Add Student For Admin"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
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
    Friend WithEvents student_gender_TextBox As TextBox
    Friend WithEvents student_sex_Label As Label
    Friend WithEvents student_birthdate_TextBox As TextBox
    Friend WithEvents student_birthdate_Label As Label
    Friend WithEvents student_age_Label As Label
    Friend WithEvents student_name_Label As Label
    Friend WithEvents student_enrolmentdate_TextBox As TextBox
    Friend WithEvents student_middlename_TextBox As TextBox
    Friend WithEvents student_firstname_TextBox As TextBox
    Friend WithEvents student_lastname_TextBox As TextBox
    Friend WithEvents block_add_Button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents addstudent_back_Button As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
End Class
