<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddInstructorPageforAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddInstructorPageforAdmin))
        Label1 = New Label()
        insttructor_name_Label = New Label()
        instructor_lastname_TextBox = New TextBox()
        instructor_firstname_TextBox = New TextBox()
        instrutor_middlename_TextBox = New TextBox()
        instructor_birthdate_Label = New Label()
        instructor_birthdate_TextBox = New TextBox()
        instructor_idno_Label = New Label()
        instructor_idno_TextBox = New TextBox()
        instructor_gender_Label = New Label()
        instructor_email_Label = New Label()
        instructor_email_TextBox = New TextBox()
        Label2 = New Label()
        instructor_contactnumber_TextBox = New TextBox()
        instructor_hiredate_Label = New Label()
        instructor_hiredate_TextBox = New TextBox()
        Label3 = New Label()
        instructor_departmentid_TextBox = New TextBox()
        instructor_add_Button = New Button()
        addinstructor_back_Button = New Button()
        Panel1 = New Panel()
        instructor_gender_TextBox = New ComboBox()
        Label4 = New Label()
        instructor_suffix_TextBox = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(31, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(174, 28)
        Label1.TabIndex = 0
        Label1.Text = "Instructor Profile"
        ' 
        ' insttructor_name_Label
        ' 
        insttructor_name_Label.AutoSize = True
        insttructor_name_Label.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        insttructor_name_Label.Location = New Point(105, 125)
        insttructor_name_Label.Name = "insttructor_name_Label"
        insttructor_name_Label.Size = New Size(56, 23)
        insttructor_name_Label.TabIndex = 1
        insttructor_name_Label.Text = "Name"
        ' 
        ' instructor_lastname_TextBox
        ' 
        instructor_lastname_TextBox.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        instructor_lastname_TextBox.Location = New Point(167, 122)
        instructor_lastname_TextBox.Margin = New Padding(3, 4, 3, 4)
        instructor_lastname_TextBox.Name = "instructor_lastname_TextBox"
        instructor_lastname_TextBox.PlaceholderText = "Last Name"
        instructor_lastname_TextBox.Size = New Size(164, 30)
        instructor_lastname_TextBox.TabIndex = 2
        ' 
        ' instructor_firstname_TextBox
        ' 
        instructor_firstname_TextBox.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        instructor_firstname_TextBox.Location = New Point(337, 122)
        instructor_firstname_TextBox.Margin = New Padding(3, 4, 3, 4)
        instructor_firstname_TextBox.Name = "instructor_firstname_TextBox"
        instructor_firstname_TextBox.PlaceholderText = "First Name"
        instructor_firstname_TextBox.Size = New Size(165, 30)
        instructor_firstname_TextBox.TabIndex = 3
        ' 
        ' instrutor_middlename_TextBox
        ' 
        instrutor_middlename_TextBox.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        instrutor_middlename_TextBox.Location = New Point(508, 122)
        instrutor_middlename_TextBox.Margin = New Padding(3, 4, 3, 4)
        instrutor_middlename_TextBox.Name = "instrutor_middlename_TextBox"
        instrutor_middlename_TextBox.PlaceholderText = "Middle Name"
        instrutor_middlename_TextBox.Size = New Size(165, 30)
        instrutor_middlename_TextBox.TabIndex = 4
        ' 
        ' instructor_birthdate_Label
        ' 
        instructor_birthdate_Label.AutoSize = True
        instructor_birthdate_Label.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        instructor_birthdate_Label.Location = New Point(106, 167)
        instructor_birthdate_Label.Name = "instructor_birthdate_Label"
        instructor_birthdate_Label.Size = New Size(87, 23)
        instructor_birthdate_Label.TabIndex = 7
        instructor_birthdate_Label.Text = "Birth Date"
        ' 
        ' instructor_birthdate_TextBox
        ' 
        instructor_birthdate_TextBox.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        instructor_birthdate_TextBox.Location = New Point(197, 164)
        instructor_birthdate_TextBox.Margin = New Padding(3, 4, 3, 4)
        instructor_birthdate_TextBox.Name = "instructor_birthdate_TextBox"
        instructor_birthdate_TextBox.PlaceholderText = "YYYY-MM-DD"
        instructor_birthdate_TextBox.Size = New Size(138, 30)
        instructor_birthdate_TextBox.TabIndex = 8
        ' 
        ' instructor_idno_Label
        ' 
        instructor_idno_Label.AutoSize = True
        instructor_idno_Label.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        instructor_idno_Label.Location = New Point(348, 168)
        instructor_idno_Label.Name = "instructor_idno_Label"
        instructor_idno_Label.Size = New Size(95, 23)
        instructor_idno_Label.TabIndex = 9
        instructor_idno_Label.Text = "ID Number"
        ' 
        ' instructor_idno_TextBox
        ' 
        instructor_idno_TextBox.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        instructor_idno_TextBox.Location = New Point(443, 164)
        instructor_idno_TextBox.Margin = New Padding(3, 4, 3, 4)
        instructor_idno_TextBox.Name = "instructor_idno_TextBox"
        instructor_idno_TextBox.Size = New Size(135, 30)
        instructor_idno_TextBox.TabIndex = 10
        ' 
        ' instructor_gender_Label
        ' 
        instructor_gender_Label.AutoSize = True
        instructor_gender_Label.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        instructor_gender_Label.Location = New Point(590, 167)
        instructor_gender_Label.Name = "instructor_gender_Label"
        instructor_gender_Label.Size = New Size(66, 23)
        instructor_gender_Label.TabIndex = 11
        instructor_gender_Label.Text = "Gender"
        ' 
        ' instructor_email_Label
        ' 
        instructor_email_Label.AutoSize = True
        instructor_email_Label.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        instructor_email_Label.Location = New Point(107, 207)
        instructor_email_Label.Name = "instructor_email_Label"
        instructor_email_Label.Size = New Size(116, 23)
        instructor_email_Label.TabIndex = 13
        instructor_email_Label.Text = "Email Address"
        ' 
        ' instructor_email_TextBox
        ' 
        instructor_email_TextBox.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        instructor_email_TextBox.Location = New Point(222, 202)
        instructor_email_TextBox.Margin = New Padding(3, 4, 3, 4)
        instructor_email_TextBox.Name = "instructor_email_TextBox"
        instructor_email_TextBox.PlaceholderText = "ex. @gmail.com"
        instructor_email_TextBox.Size = New Size(242, 30)
        instructor_email_TextBox.TabIndex = 14
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        Label2.Location = New Point(486, 207)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 23)
        Label2.TabIndex = 15
        Label2.Text = "Contact Number"
        ' 
        ' instructor_contactnumber_TextBox
        ' 
        instructor_contactnumber_TextBox.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        instructor_contactnumber_TextBox.Location = New Point(630, 204)
        instructor_contactnumber_TextBox.Margin = New Padding(3, 4, 3, 4)
        instructor_contactnumber_TextBox.Name = "instructor_contactnumber_TextBox"
        instructor_contactnumber_TextBox.Size = New Size(193, 30)
        instructor_contactnumber_TextBox.TabIndex = 16
        instructor_contactnumber_TextBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' instructor_hiredate_Label
        ' 
        instructor_hiredate_Label.AutoSize = True
        instructor_hiredate_Label.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        instructor_hiredate_Label.Location = New Point(107, 247)
        instructor_hiredate_Label.Name = "instructor_hiredate_Label"
        instructor_hiredate_Label.Size = New Size(83, 23)
        instructor_hiredate_Label.TabIndex = 17
        instructor_hiredate_Label.Text = "Hire Date"
        ' 
        ' instructor_hiredate_TextBox
        ' 
        instructor_hiredate_TextBox.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        instructor_hiredate_TextBox.Location = New Point(196, 244)
        instructor_hiredate_TextBox.Margin = New Padding(3, 4, 3, 4)
        instructor_hiredate_TextBox.Name = "instructor_hiredate_TextBox"
        instructor_hiredate_TextBox.PlaceholderText = "YYYY-MM-DD"
        instructor_hiredate_TextBox.Size = New Size(180, 30)
        instructor_hiredate_TextBox.TabIndex = 18
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        Label3.Location = New Point(414, 247)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 23)
        Label3.TabIndex = 19
        Label3.Text = "Department ID"
        ' 
        ' instructor_departmentid_TextBox
        ' 
        instructor_departmentid_TextBox.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        instructor_departmentid_TextBox.Location = New Point(547, 244)
        instructor_departmentid_TextBox.Margin = New Padding(3, 4, 3, 4)
        instructor_departmentid_TextBox.Name = "instructor_departmentid_TextBox"
        instructor_departmentid_TextBox.Size = New Size(173, 30)
        instructor_departmentid_TextBox.TabIndex = 20
        instructor_departmentid_TextBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' instructor_add_Button
        ' 
        instructor_add_Button.BackColor = Color.Maroon
        instructor_add_Button.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        instructor_add_Button.ForeColor = Color.White
        instructor_add_Button.Location = New Point(424, 340)
        instructor_add_Button.Margin = New Padding(3, 4, 3, 4)
        instructor_add_Button.Name = "instructor_add_Button"
        instructor_add_Button.Size = New Size(114, 39)
        instructor_add_Button.TabIndex = 22
        instructor_add_Button.Text = "Add"
        instructor_add_Button.UseVisualStyleBackColor = False
        ' 
        ' addinstructor_back_Button
        ' 
        addinstructor_back_Button.BackColor = Color.Maroon
        addinstructor_back_Button.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addinstructor_back_Button.ForeColor = Color.White
        addinstructor_back_Button.Location = New Point(818, 26)
        addinstructor_back_Button.Margin = New Padding(3, 4, 3, 4)
        addinstructor_back_Button.Name = "addinstructor_back_Button"
        addinstructor_back_Button.Size = New Size(86, 31)
        addinstructor_back_Button.TabIndex = 25
        addinstructor_back_Button.Text = "Back"
        addinstructor_back_Button.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.Controls.Add(instructor_gender_TextBox)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(instructor_suffix_TextBox)
        Panel1.Controls.Add(instructor_add_Button)
        Panel1.Controls.Add(addinstructor_back_Button)
        Panel1.Controls.Add(instructor_departmentid_TextBox)
        Panel1.Controls.Add(instructor_hiredate_TextBox)
        Panel1.Controls.Add(instructor_hiredate_Label)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(instructor_email_Label)
        Panel1.Controls.Add(instructor_contactnumber_TextBox)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(instructor_gender_Label)
        Panel1.Controls.Add(instructor_email_TextBox)
        Panel1.Controls.Add(instructor_birthdate_TextBox)
        Panel1.Controls.Add(instructor_idno_TextBox)
        Panel1.Controls.Add(instructor_birthdate_Label)
        Panel1.Controls.Add(instructor_idno_Label)
        Panel1.Controls.Add(instrutor_middlename_TextBox)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(insttructor_name_Label)
        Panel1.Controls.Add(instructor_firstname_TextBox)
        Panel1.Controls.Add(instructor_lastname_TextBox)
        Panel1.Location = New Point(492, 302)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(940, 450)
        Panel1.TabIndex = 26
        ' 
        ' instructor_gender_TextBox
        ' 
        instructor_gender_TextBox.FormattingEnabled = True
        instructor_gender_TextBox.Items.AddRange(New Object() {"Female", "Male", "Other"})
        instructor_gender_TextBox.Location = New Point(662, 163)
        instructor_gender_TextBox.Name = "instructor_gender_TextBox"
        instructor_gender_TextBox.Size = New Size(124, 28)
        instructor_gender_TextBox.TabIndex = 28
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        Label4.Location = New Point(682, 129)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 23)
        Label4.TabIndex = 26
        Label4.Text = "Suffix"
        ' 
        ' instructor_suffix_TextBox
        ' 
        instructor_suffix_TextBox.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        instructor_suffix_TextBox.Location = New Point(737, 122)
        instructor_suffix_TextBox.Margin = New Padding(3, 4, 3, 4)
        instructor_suffix_TextBox.Name = "instructor_suffix_TextBox"
        instructor_suffix_TextBox.PlaceholderText = "ex. Jr., I, II,III"
        instructor_suffix_TextBox.Size = New Size(85, 30)
        instructor_suffix_TextBox.TabIndex = 27
        ' 
        ' AddInstructorPageforAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1924, 1055)
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "AddInstructorPageforAdmin"
        Text = "Add Instructor For Admin"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents insttructor_name_Label As Label
    Friend WithEvents instructor_lastname_TextBox As TextBox
    Friend WithEvents instructor_firstname_TextBox As TextBox
    Friend WithEvents instrutor_middlename_TextBox As TextBox
    Friend WithEvents instructor_birthdate_Label As Label
    Friend WithEvents instructor_birthdate_TextBox As TextBox
    Friend WithEvents instructor_idno_Label As Label
    Friend WithEvents instructor_idno_TextBox As TextBox
    Friend WithEvents instructor_gender_Label As Label
    Friend WithEvents instructor_email_Label As Label
    Friend WithEvents instructor_email_TextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents instructor_contactnumber_TextBox As TextBox
    Friend WithEvents instructor_hiredate_Label As Label
    Friend WithEvents instructor_hiredate_TextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents instructor_departmentid_TextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents instructor_delete_Button As Button
    Friend WithEvents instructor_edit_Button As Button
    Friend WithEvents instructor_add_Button As Button
    Friend WithEvents addinstructor_back_Button As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents instructor_suffix_TextBox As TextBox
    Friend WithEvents instructor_gender_TextBox As ComboBox
End Class
