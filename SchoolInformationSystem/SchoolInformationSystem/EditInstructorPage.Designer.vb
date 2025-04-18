<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditInstructorPage
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
        editinstructor_save_Button = New Button()
        editinstructor_cancel_Button = New Button()
        Panel1 = New Panel()
        instructor_hiredate_DTP = New DateTimePicker()
        instructor_gender_ComboBox = New ComboBox()
        Label8 = New Label()
        instructor_departmentid_TextBox = New TextBox()
        Label7 = New Label()
        instructor_contactnumber_TextBox = New TextBox()
        Label6 = New Label()
        instructor_email_TextBox = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        instructor_birthdate_TextBox = New TextBox()
        Label3 = New Label()
        instructor_id_TextBox = New TextBox()
        Label2 = New Label()
        instructor_suffix_TextBox = New TextBox()
        instructor_middlename_TextBox = New TextBox()
        instructor_firstname_TextBox = New TextBox()
        instructor_lastname_TextBox = New TextBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' editinstructor_save_Button
        ' 
        editinstructor_save_Button.BackColor = Color.Maroon
        editinstructor_save_Button.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        editinstructor_save_Button.ForeColor = Color.White
        editinstructor_save_Button.Location = New Point(745, 587)
        editinstructor_save_Button.Margin = New Padding(2)
        editinstructor_save_Button.Name = "editinstructor_save_Button"
        editinstructor_save_Button.Size = New Size(90, 38)
        editinstructor_save_Button.TabIndex = 2
        editinstructor_save_Button.Text = "Save"
        editinstructor_save_Button.UseVisualStyleBackColor = False
        ' 
        ' editinstructor_cancel_Button
        ' 
        editinstructor_cancel_Button.BackColor = Color.Maroon
        editinstructor_cancel_Button.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        editinstructor_cancel_Button.ForeColor = Color.White
        editinstructor_cancel_Button.Location = New Point(998, 587)
        editinstructor_cancel_Button.Margin = New Padding(2)
        editinstructor_cancel_Button.Name = "editinstructor_cancel_Button"
        editinstructor_cancel_Button.Size = New Size(90, 38)
        editinstructor_cancel_Button.TabIndex = 20
        editinstructor_cancel_Button.Text = "Cancel"
        editinstructor_cancel_Button.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLight
        Panel1.Controls.Add(instructor_hiredate_DTP)
        Panel1.Controls.Add(instructor_gender_ComboBox)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(instructor_departmentid_TextBox)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(instructor_contactnumber_TextBox)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(instructor_email_TextBox)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(instructor_birthdate_TextBox)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(instructor_id_TextBox)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(instructor_suffix_TextBox)
        Panel1.Controls.Add(instructor_middlename_TextBox)
        Panel1.Controls.Add(instructor_firstname_TextBox)
        Panel1.Controls.Add(instructor_lastname_TextBox)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(488, 123)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(940, 450)
        Panel1.TabIndex = 23
        ' 
        ' instructor_hiredate_DTP
        ' 
        instructor_hiredate_DTP.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        instructor_hiredate_DTP.Location = New Point(239, 261)
        instructor_hiredate_DTP.Margin = New Padding(2)
        instructor_hiredate_DTP.Name = "instructor_hiredate_DTP"
        instructor_hiredate_DTP.Size = New Size(285, 30)
        instructor_hiredate_DTP.TabIndex = 41
        ' 
        ' instructor_gender_ComboBox
        ' 
        instructor_gender_ComboBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        instructor_gender_ComboBox.FormattingEnabled = True
        instructor_gender_ComboBox.Items.AddRange(New Object() {"Male", "Female", "Other"})
        instructor_gender_ComboBox.Location = New Point(740, 142)
        instructor_gender_ComboBox.Margin = New Padding(2)
        instructor_gender_ComboBox.Name = "instructor_gender_ComboBox"
        instructor_gender_ComboBox.Size = New Size(112, 31)
        instructor_gender_ComboBox.TabIndex = 40
        instructor_gender_ComboBox.Tag = ""
        instructor_gender_ComboBox.Text = "Male"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label8.Location = New Point(547, 267)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(131, 23)
        Label8.TabIndex = 39
        Label8.Text = "Department ID"
        ' 
        ' instructor_departmentid_TextBox
        ' 
        instructor_departmentid_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        instructor_departmentid_TextBox.Location = New Point(682, 264)
        instructor_departmentid_TextBox.Margin = New Padding(2)
        instructor_departmentid_TextBox.Name = "instructor_departmentid_TextBox"
        instructor_departmentid_TextBox.Size = New Size(125, 30)
        instructor_departmentid_TextBox.TabIndex = 38
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label7.Location = New Point(148, 267)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(87, 23)
        Label7.TabIndex = 37
        Label7.Text = "Hire Date"
        ' 
        ' instructor_contactnumber_TextBox
        ' 
        instructor_contactnumber_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        instructor_contactnumber_TextBox.Location = New Point(645, 199)
        instructor_contactnumber_TextBox.Margin = New Padding(2)
        instructor_contactnumber_TextBox.Name = "instructor_contactnumber_TextBox"
        instructor_contactnumber_TextBox.Size = New Size(184, 30)
        instructor_contactnumber_TextBox.TabIndex = 36
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label6.Location = New Point(498, 202)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(143, 23)
        Label6.TabIndex = 35
        Label6.Text = "Contact Number"
        ' 
        ' instructor_email_TextBox
        ' 
        instructor_email_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        instructor_email_TextBox.Location = New Point(267, 199)
        instructor_email_TextBox.Margin = New Padding(2)
        instructor_email_TextBox.Name = "instructor_email_TextBox"
        instructor_email_TextBox.Size = New Size(203, 30)
        instructor_email_TextBox.TabIndex = 34
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label5.Location = New Point(207, 202)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(54, 23)
        Label5.TabIndex = 33
        Label5.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label4.Location = New Point(668, 145)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 23)
        Label4.TabIndex = 32
        Label4.Text = "Gender"
        ' 
        ' instructor_birthdate_TextBox
        ' 
        instructor_birthdate_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        instructor_birthdate_TextBox.Location = New Point(496, 142)
        instructor_birthdate_TextBox.Margin = New Padding(2)
        instructor_birthdate_TextBox.Name = "instructor_birthdate_TextBox"
        instructor_birthdate_TextBox.PlaceholderText = "MM-DD-YYYY"
        instructor_birthdate_TextBox.Size = New Size(145, 30)
        instructor_birthdate_TextBox.TabIndex = 31
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label3.Location = New Point(406, 145)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 23)
        Label3.TabIndex = 30
        Label3.Text = "Birthdate"
        ' 
        ' instructor_id_TextBox
        ' 
        instructor_id_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        instructor_id_TextBox.Location = New Point(267, 142)
        instructor_id_TextBox.Margin = New Padding(2)
        instructor_id_TextBox.Name = "instructor_id_TextBox"
        instructor_id_TextBox.Size = New Size(125, 30)
        instructor_id_TextBox.TabIndex = 29
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label2.Location = New Point(148, 145)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 23)
        Label2.TabIndex = 28
        Label2.Text = "ID Number"
        ' 
        ' instructor_suffix_TextBox
        ' 
        instructor_suffix_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        instructor_suffix_TextBox.Location = New Point(699, 87)
        instructor_suffix_TextBox.Margin = New Padding(2)
        instructor_suffix_TextBox.Name = "instructor_suffix_TextBox"
        instructor_suffix_TextBox.PlaceholderText = "Suffix (e.g. Jr, Sr)"
        instructor_suffix_TextBox.Size = New Size(129, 30)
        instructor_suffix_TextBox.TabIndex = 27
        ' 
        ' instructor_middlename_TextBox
        ' 
        instructor_middlename_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        instructor_middlename_TextBox.Location = New Point(540, 87)
        instructor_middlename_TextBox.Margin = New Padding(2)
        instructor_middlename_TextBox.Name = "instructor_middlename_TextBox"
        instructor_middlename_TextBox.PlaceholderText = "Middle Name"
        instructor_middlename_TextBox.Size = New Size(138, 30)
        instructor_middlename_TextBox.TabIndex = 26
        ' 
        ' instructor_firstname_TextBox
        ' 
        instructor_firstname_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        instructor_firstname_TextBox.Location = New Point(373, 87)
        instructor_firstname_TextBox.Margin = New Padding(2)
        instructor_firstname_TextBox.Name = "instructor_firstname_TextBox"
        instructor_firstname_TextBox.PlaceholderText = "First Name"
        instructor_firstname_TextBox.Size = New Size(151, 30)
        instructor_firstname_TextBox.TabIndex = 25
        ' 
        ' instructor_lastname_TextBox
        ' 
        instructor_lastname_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        instructor_lastname_TextBox.Location = New Point(207, 87)
        instructor_lastname_TextBox.Margin = New Padding(2)
        instructor_lastname_TextBox.Name = "instructor_lastname_TextBox"
        instructor_lastname_TextBox.PlaceholderText = "Last Name"
        instructor_lastname_TextBox.Size = New Size(153, 30)
        instructor_lastname_TextBox.TabIndex = 24
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label1.Location = New Point(135, 90)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 23)
        Label1.TabIndex = 23
        Label1.Text = "Name"
        ' 
        ' EditInstructorPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        BackgroundImage = My.Resources.Resources.adminbg
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1797, 790)
        Controls.Add(Panel1)
        Controls.Add(editinstructor_cancel_Button)
        Controls.Add(editinstructor_save_Button)
        Margin = New Padding(2)
        Name = "EditInstructorPage"
        Text = "EditInstructorPage"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents editinstructor_save_Button As Button
    Friend WithEvents editinstructor_cancel_Button As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents instructor_hiredate_DTP As DateTimePicker
    Friend WithEvents instructor_gender_ComboBox As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents instructor_departmentid_TextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents instructor_contactnumber_TextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents instructor_email_TextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents instructor_birthdate_TextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents instructor_id_TextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents instructor_suffix_TextBox As TextBox
    Friend WithEvents instructor_middlename_TextBox As TextBox
    Friend WithEvents instructor_firstname_TextBox As TextBox
    Friend WithEvents instructor_lastname_TextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
