<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentProfileforStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentProfileforStudent))
        Panel4 = New Panel()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        student_logout_Button = New Button()
        transcript_Button = New PictureBox()
        student_addCR_Button = New PictureBox()
        student_profile_Button = New PictureBox()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        editProfile_Button = New Button()
        Panel2 = New Panel()
        cancelEdit_Button = New Button()
        saveChanges_Button = New Button()
        block_ComboBox = New ComboBox()
        yearLevel_ComboBox = New ComboBox()
        program_TextBox = New TextBox()
        Label4 = New Label()
        Label2 = New Label()
        suffix_TextBox = New TextBox()
        student_gender_TextBox = New ComboBox()
        Label1 = New Label()
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
        Panel3 = New Panel()
        Panel4.SuspendLayout()
        CType(transcript_Button, ComponentModel.ISupportInitialize).BeginInit()
        CType(student_addCR_Button, ComponentModel.ISupportInitialize).BeginInit()
        CType(student_profile_Button, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
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
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(204, 1048)
        Panel4.TabIndex = 147
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
        ' Panel1
        ' 
        Panel1.Controls.Add(editProfile_Button)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Panel3)
        Panel1.Location = New Point(464, 275)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1020, 612)
        Panel1.TabIndex = 148
        ' 
        ' editProfile_Button
        ' 
        editProfile_Button.BackColor = Color.Maroon
        editProfile_Button.FlatStyle = FlatStyle.Popup
        editProfile_Button.ForeColor = SystemColors.ControlLightLight
        editProfile_Button.Location = New Point(856, 126)
        editProfile_Button.Name = "editProfile_Button"
        editProfile_Button.Size = New Size(90, 42)
        editProfile_Button.TabIndex = 7
        editProfile_Button.Text = "Edit"
        editProfile_Button.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveBorder
        Panel2.Controls.Add(cancelEdit_Button)
        Panel2.Controls.Add(saveChanges_Button)
        Panel2.Controls.Add(block_ComboBox)
        Panel2.Controls.Add(yearLevel_ComboBox)
        Panel2.Controls.Add(program_TextBox)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(suffix_TextBox)
        Panel2.Controls.Add(student_gender_TextBox)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(student_yl_Label)
        Panel2.Controls.Add(student_studentid_TextBox)
        Panel2.Controls.Add(student_idno_Label)
        Panel2.Controls.Add(student_email_TextBox)
        Panel2.Controls.Add(student_email_Label)
        Panel2.Controls.Add(student_contact_TextBox)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(student_postalcode_TextBox)
        Panel2.Controls.Add(student_province_TextBox)
        Panel2.Controls.Add(student_municipality_TextBox)
        Panel2.Controls.Add(student_barangay_TextBox)
        Panel2.Controls.Add(student_street_TextBox)
        Panel2.Controls.Add(student_address_Label)
        Panel2.Controls.Add(student_sex_Label)
        Panel2.Controls.Add(student_birthdate_TextBox)
        Panel2.Controls.Add(student_birthdate_Label)
        Panel2.Controls.Add(student_age_Label)
        Panel2.Controls.Add(student_name_Label)
        Panel2.Controls.Add(student_enrolmentdate_TextBox)
        Panel2.Controls.Add(student_middlename_TextBox)
        Panel2.Controls.Add(student_firstname_TextBox)
        Panel2.Controls.Add(student_lastname_TextBox)
        Panel2.Location = New Point(73, 168)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(874, 375)
        Panel2.TabIndex = 22
        ' 
        ' cancelEdit_Button
        ' 
        cancelEdit_Button.BackColor = Color.LightGray
        cancelEdit_Button.FlatStyle = FlatStyle.Popup
        cancelEdit_Button.ForeColor = Color.Black
        cancelEdit_Button.Location = New Point(445, 311)
        cancelEdit_Button.Name = "cancelEdit_Button"
        cancelEdit_Button.Size = New Size(132, 42)
        cancelEdit_Button.TabIndex = 180
        cancelEdit_Button.Text = "Cancel"
        cancelEdit_Button.UseVisualStyleBackColor = False
        cancelEdit_Button.Visible = False
        ' 
        ' saveChanges_Button
        ' 
        saveChanges_Button.BackColor = Color.Maroon
        saveChanges_Button.FlatStyle = FlatStyle.Popup
        saveChanges_Button.ForeColor = Color.White
        saveChanges_Button.Location = New Point(271, 311)
        saveChanges_Button.Name = "saveChanges_Button"
        saveChanges_Button.Size = New Size(137, 42)
        saveChanges_Button.TabIndex = 24
        saveChanges_Button.Text = "Save Changes"
        saveChanges_Button.UseVisualStyleBackColor = False
        saveChanges_Button.Visible = False
        ' 
        ' block_ComboBox
        ' 
        block_ComboBox.Enabled = False
        block_ComboBox.FormattingEnabled = True
        block_ComboBox.Items.AddRange(New Object() {"A", "B", "C", "D"})
        block_ComboBox.Location = New Point(667, 67)
        block_ComboBox.Name = "block_ComboBox"
        block_ComboBox.Size = New Size(95, 23)
        block_ComboBox.TabIndex = 179
        ' 
        ' yearLevel_ComboBox
        ' 
        yearLevel_ComboBox.Enabled = False
        yearLevel_ComboBox.FormattingEnabled = True
        yearLevel_ComboBox.Items.AddRange(New Object() {"1", "2", "3", "4"})
        yearLevel_ComboBox.Location = New Point(505, 67)
        yearLevel_ComboBox.Name = "yearLevel_ComboBox"
        yearLevel_ComboBox.Size = New Size(95, 23)
        yearLevel_ComboBox.TabIndex = 178
        ' 
        ' program_TextBox
        ' 
        program_TextBox.Enabled = False
        program_TextBox.Location = New Point(346, 67)
        program_TextBox.Name = "program_TextBox"
        program_TextBox.Size = New Size(90, 23)
        program_TextBox.TabIndex = 177
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(288, 70)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 15)
        Label4.TabIndex = 176
        Label4.Text = "Program"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(625, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 15)
        Label2.TabIndex = 174
        Label2.Text = "Block"
        ' 
        ' suffix_TextBox
        ' 
        suffix_TextBox.Enabled = False
        suffix_TextBox.Location = New Point(613, 107)
        suffix_TextBox.Name = "suffix_TextBox"
        suffix_TextBox.PlaceholderText = "Suffix"
        suffix_TextBox.Size = New Size(148, 23)
        suffix_TextBox.TabIndex = 173
        ' 
        ' student_gender_TextBox
        ' 
        student_gender_TextBox.Enabled = False
        student_gender_TextBox.FormattingEnabled = True
        student_gender_TextBox.Items.AddRange(New Object() {"Female", "Male", "Other"})
        student_gender_TextBox.Location = New Point(658, 143)
        student_gender_TextBox.Name = "student_gender_TextBox"
        student_gender_TextBox.Size = New Size(104, 23)
        student_gender_TextBox.TabIndex = 172
        student_gender_TextBox.Text = "Female"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(595, 221)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 15)
        Label1.TabIndex = 171
        Label1.Text = "Postal Code"
        ' 
        ' student_yl_Label
        ' 
        student_yl_Label.AutoSize = True
        student_yl_Label.Location = New Point(445, 70)
        student_yl_Label.Name = "student_yl_Label"
        student_yl_Label.Size = New Size(59, 15)
        student_yl_Label.TabIndex = 169
        student_yl_Label.Text = "Year Level"
        ' 
        ' student_studentid_TextBox
        ' 
        student_studentid_TextBox.Enabled = False
        student_studentid_TextBox.Location = New Point(150, 64)
        student_studentid_TextBox.Name = "student_studentid_TextBox"
        student_studentid_TextBox.Size = New Size(111, 23)
        student_studentid_TextBox.TabIndex = 168
        ' 
        ' student_idno_Label
        ' 
        student_idno_Label.AutoSize = True
        student_idno_Label.Location = New Point(82, 70)
        student_idno_Label.Name = "student_idno_Label"
        student_idno_Label.Size = New Size(65, 15)
        student_idno_Label.TabIndex = 167
        student_idno_Label.Text = "ID Number"
        ' 
        ' student_email_TextBox
        ' 
        student_email_TextBox.Enabled = False
        student_email_TextBox.Location = New Point(396, 218)
        student_email_TextBox.Name = "student_email_TextBox"
        student_email_TextBox.PlaceholderText = "ex. @gmail.com"
        student_email_TextBox.Size = New Size(181, 23)
        student_email_TextBox.TabIndex = 166
        ' 
        ' student_email_Label
        ' 
        student_email_Label.AutoSize = True
        student_email_Label.Location = New Point(309, 221)
        student_email_Label.Name = "student_email_Label"
        student_email_Label.Size = New Size(81, 15)
        student_email_Label.TabIndex = 165
        student_email_Label.Text = "Email Address"
        ' 
        ' student_contact_TextBox
        ' 
        student_contact_TextBox.Enabled = False
        student_contact_TextBox.Location = New Point(150, 218)
        student_contact_TextBox.Name = "student_contact_TextBox"
        student_contact_TextBox.Size = New Size(132, 23)
        student_contact_TextBox.TabIndex = 164
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(77, 221)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 15)
        Label3.TabIndex = 163
        Label3.Text = "Contact No."
        ' 
        ' student_postalcode_TextBox
        ' 
        student_postalcode_TextBox.Enabled = False
        student_postalcode_TextBox.Location = New Point(675, 218)
        student_postalcode_TextBox.Name = "student_postalcode_TextBox"
        student_postalcode_TextBox.PlaceholderText = "0000"
        student_postalcode_TextBox.Size = New Size(86, 23)
        student_postalcode_TextBox.TabIndex = 162
        ' 
        ' student_province_TextBox
        ' 
        student_province_TextBox.Enabled = False
        student_province_TextBox.Location = New Point(613, 180)
        student_province_TextBox.Name = "student_province_TextBox"
        student_province_TextBox.PlaceholderText = "Province"
        student_province_TextBox.Size = New Size(149, 23)
        student_province_TextBox.TabIndex = 161
        ' 
        ' student_municipality_TextBox
        ' 
        student_municipality_TextBox.Enabled = False
        student_municipality_TextBox.Location = New Point(458, 180)
        student_municipality_TextBox.Name = "student_municipality_TextBox"
        student_municipality_TextBox.PlaceholderText = "Municipality"
        student_municipality_TextBox.Size = New Size(149, 23)
        student_municipality_TextBox.TabIndex = 160
        ' 
        ' student_barangay_TextBox
        ' 
        student_barangay_TextBox.Enabled = False
        student_barangay_TextBox.Location = New Point(304, 180)
        student_barangay_TextBox.Name = "student_barangay_TextBox"
        student_barangay_TextBox.PlaceholderText = "Barangay"
        student_barangay_TextBox.Size = New Size(148, 23)
        student_barangay_TextBox.TabIndex = 159
        ' 
        ' student_street_TextBox
        ' 
        student_street_TextBox.Enabled = False
        student_street_TextBox.Location = New Point(150, 180)
        student_street_TextBox.Name = "student_street_TextBox"
        student_street_TextBox.PlaceholderText = "Street"
        student_street_TextBox.Size = New Size(148, 23)
        student_street_TextBox.TabIndex = 158
        ' 
        ' student_address_Label
        ' 
        student_address_Label.AutoSize = True
        student_address_Label.Location = New Point(95, 183)
        student_address_Label.Name = "student_address_Label"
        student_address_Label.Size = New Size(49, 15)
        student_address_Label.TabIndex = 157
        student_address_Label.Text = "Address"
        ' 
        ' student_sex_Label
        ' 
        student_sex_Label.AutoSize = True
        student_sex_Label.Location = New Point(607, 149)
        student_sex_Label.Name = "student_sex_Label"
        student_sex_Label.Size = New Size(45, 15)
        student_sex_Label.TabIndex = 155
        student_sex_Label.Text = "Gender"
        ' 
        ' student_birthdate_TextBox
        ' 
        student_birthdate_TextBox.Enabled = False
        student_birthdate_TextBox.Location = New Point(427, 143)
        student_birthdate_TextBox.Name = "student_birthdate_TextBox"
        student_birthdate_TextBox.PlaceholderText = "YYYY-MM-DD"
        student_birthdate_TextBox.Size = New Size(162, 23)
        student_birthdate_TextBox.TabIndex = 154
        ' 
        ' student_birthdate_Label
        ' 
        student_birthdate_Label.AutoSize = True
        student_birthdate_Label.Location = New Point(365, 149)
        student_birthdate_Label.Name = "student_birthdate_Label"
        student_birthdate_Label.Size = New Size(59, 15)
        student_birthdate_Label.TabIndex = 153
        student_birthdate_Label.Text = "Birth Date"
        ' 
        ' student_age_Label
        ' 
        student_age_Label.AutoSize = True
        student_age_Label.Location = New Point(55, 149)
        student_age_Label.Name = "student_age_Label"
        student_age_Label.Size = New Size(89, 15)
        student_age_Label.TabIndex = 152
        student_age_Label.Text = "Enrolment Date"
        ' 
        ' student_name_Label
        ' 
        student_name_Label.AutoSize = True
        student_name_Label.Location = New Point(105, 110)
        student_name_Label.Name = "student_name_Label"
        student_name_Label.Size = New Size(39, 15)
        student_name_Label.TabIndex = 151
        student_name_Label.Text = "Name"
        ' 
        ' student_enrolmentdate_TextBox
        ' 
        student_enrolmentdate_TextBox.Enabled = False
        student_enrolmentdate_TextBox.Location = New Point(150, 143)
        student_enrolmentdate_TextBox.Name = "student_enrolmentdate_TextBox"
        student_enrolmentdate_TextBox.PlaceholderText = "YYYY-MM-DD"
        student_enrolmentdate_TextBox.Size = New Size(196, 23)
        student_enrolmentdate_TextBox.TabIndex = 150
        ' 
        ' student_middlename_TextBox
        ' 
        student_middlename_TextBox.Enabled = False
        student_middlename_TextBox.Location = New Point(452, 107)
        student_middlename_TextBox.Name = "student_middlename_TextBox"
        student_middlename_TextBox.PlaceholderText = "Middle Name"
        student_middlename_TextBox.Size = New Size(148, 23)
        student_middlename_TextBox.TabIndex = 149
        ' 
        ' student_firstname_TextBox
        ' 
        student_firstname_TextBox.Enabled = False
        student_firstname_TextBox.Location = New Point(288, 107)
        student_firstname_TextBox.Name = "student_firstname_TextBox"
        student_firstname_TextBox.PlaceholderText = "First Name"
        student_firstname_TextBox.Size = New Size(148, 23)
        student_firstname_TextBox.TabIndex = 148
        ' 
        ' student_lastname_TextBox
        ' 
        student_lastname_TextBox.Enabled = False
        student_lastname_TextBox.Location = New Point(150, 107)
        student_lastname_TextBox.Name = "student_lastname_TextBox"
        student_lastname_TextBox.PlaceholderText = "Last Name"
        student_lastname_TextBox.Size = New Size(118, 23)
        student_lastname_TextBox.TabIndex = 147
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Maroon
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1033, 96)
        Panel3.TabIndex = 23
        ' 
        ' StudentProfileforStudent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1904, 1041)
        Controls.Add(Panel1)
        Controls.Add(Panel4)
        DoubleBuffered = True
        Name = "StudentProfileforStudent"
        Text = "Student Profile"
        WindowState = FormWindowState.Maximized
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(transcript_Button, ComponentModel.ISupportInitialize).EndInit()
        CType(student_addCR_Button, ComponentModel.ISupportInitialize).EndInit()
        CType(student_profile_Button, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
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
    Friend WithEvents student_gender_TextBox As ComboBox
    Friend WithEvents suffix_TextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents block_ComboBox As ComboBox
    Friend WithEvents yearLevel_ComboBox As ComboBox
    Friend WithEvents program_TextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents editProfile_Button As Button
    Friend WithEvents cancelEdit_Button As Button
    Friend WithEvents saveChanges_Button As Button
End Class
