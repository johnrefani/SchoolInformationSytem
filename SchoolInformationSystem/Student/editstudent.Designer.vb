<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editstudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editstudent))
        savebutton = New Button()
        cancelbutton = New Button()
        Label6 = New Label()
        Label17 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label1 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        studentedit_fullname = New TextBox()
        studentedit_gender = New TextBox()
        studentedit_age = New TextBox()
        studentedit_contact = New TextBox()
        studentedit_email = New TextBox()
        studentedit_address = New TextBox()
        studentedit_grade = New TextBox()
        studentedit_birthplace = New TextBox()
        studentedit_nationality = New TextBox()
        studentedit_guardian = New TextBox()
        studentedit_religion = New TextBox()
        SuspendLayout()
        ' 
        ' savebutton
        ' 
        savebutton.BackColor = Color.FromArgb(CByte(127), CByte(189), CByte(228))
        savebutton.Cursor = Cursors.Hand
        savebutton.FlatAppearance.BorderSize = 0
        savebutton.FlatStyle = FlatStyle.Flat
        savebutton.Font = New Font("Tahoma", 15.75F)
        savebutton.ForeColor = Color.White
        savebutton.Location = New Point(690, 17)
        savebutton.Name = "savebutton"
        savebutton.Size = New Size(98, 37)
        savebutton.TabIndex = 60
        savebutton.Text = "SAVE"
        savebutton.UseVisualStyleBackColor = False
        ' 
        ' cancelbutton
        ' 
        cancelbutton.BackColor = Color.FromArgb(CByte(255), CByte(73), CByte(73))
        cancelbutton.Cursor = Cursors.Hand
        cancelbutton.FlatAppearance.BorderSize = 0
        cancelbutton.FlatStyle = FlatStyle.Flat
        cancelbutton.Font = New Font("Tahoma", 15.75F)
        cancelbutton.ForeColor = Color.White
        cancelbutton.Location = New Point(803, 17)
        cancelbutton.Name = "cancelbutton"
        cancelbutton.Size = New Size(111, 37)
        cancelbutton.TabIndex = 59
        cancelbutton.Text = "CANCEL"
        cancelbutton.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(12, 12)
        Label6.Name = "Label6"
        Label6.Size = New Size(329, 39)
        Label6.TabIndex = 61
        Label6.Text = "Edit Student Profile"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Tahoma", 14.25F)
        Label17.Location = New Point(366, 301)
        Label17.Name = "Label17"
        Label17.Size = New Size(116, 23)
        Label17.TabIndex = 73
        Label17.Text = "BIRTHPLACE"
        Label17.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Tahoma", 14.25F)
        Label14.Location = New Point(366, 406)
        Label14.Name = "Label14"
        Label14.Size = New Size(95, 23)
        Label14.TabIndex = 72
        Label14.Text = "RELIGION"
        Label14.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Tahoma", 14.25F)
        Label13.Location = New Point(25, 406)
        Label13.Name = "Label13"
        Label13.Size = New Size(158, 23)
        Label13.TabIndex = 71
        Label13.Text = "GUARDIAN NAME"
        Label13.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Tahoma", 14.25F)
        Label12.Location = New Point(661, 301)
        Label12.Name = "Label12"
        Label12.Size = New Size(127, 23)
        Label12.TabIndex = 70
        Label12.Text = "NATIONALITY"
        Label12.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Tahoma", 14.25F)
        Label10.Location = New Point(25, 301)
        Label10.Name = "Label10"
        Label10.Size = New Size(127, 23)
        Label10.TabIndex = 68
        Label10.Text = "GRADE LEVEL"
        Label10.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Tahoma", 14.25F)
        Label9.Location = New Point(352, 198)
        Label9.Name = "Label9"
        Label9.Size = New Size(92, 23)
        Label9.TabIndex = 67
        Label9.Text = "ADDRESS"
        Label9.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Tahoma", 14.25F)
        Label8.Location = New Point(25, 198)
        Label8.Name = "Label8"
        Label8.Size = New Size(151, 23)
        Label8.TabIndex = 66
        Label8.Text = "EMAIL ADDRESS"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 14.25F)
        Label7.Location = New Point(661, 96)
        Label7.Name = "Label7"
        Label7.Size = New Size(171, 23)
        Label7.TabIndex = 65
        Label7.Text = "CONTACT NUMBER"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 14.25F)
        Label1.Location = New Point(529, 96)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 23)
        Label1.TabIndex = 64
        Label1.Text = "AGE"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 14.25F)
        Label5.Location = New Point(352, 96)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 23)
        Label5.TabIndex = 63
        Label5.Text = "GENDER"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 14.25F)
        Label4.Location = New Point(25, 96)
        Label4.Name = "Label4"
        Label4.Size = New Size(106, 23)
        Label4.TabIndex = 62
        Label4.Text = "FULL NAME"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' studentedit_fullname
        ' 
        studentedit_fullname.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        studentedit_fullname.Location = New Point(25, 131)
        studentedit_fullname.Name = "studentedit_fullname"
        studentedit_fullname.Size = New Size(280, 33)
        studentedit_fullname.TabIndex = 1
        ' 
        ' studentedit_gender
        ' 
        studentedit_gender.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        studentedit_gender.Location = New Point(352, 131)
        studentedit_gender.Name = "studentedit_gender"
        studentedit_gender.Size = New Size(114, 33)
        studentedit_gender.TabIndex = 2
        ' 
        ' studentedit_age
        ' 
        studentedit_age.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        studentedit_age.Location = New Point(529, 131)
        studentedit_age.Name = "studentedit_age"
        studentedit_age.Size = New Size(66, 33)
        studentedit_age.TabIndex = 3
        ' 
        ' studentedit_contact
        ' 
        studentedit_contact.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        studentedit_contact.Location = New Point(661, 131)
        studentedit_contact.Name = "studentedit_contact"
        studentedit_contact.Size = New Size(239, 33)
        studentedit_contact.TabIndex = 4
        ' 
        ' studentedit_email
        ' 
        studentedit_email.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        studentedit_email.Location = New Point(25, 237)
        studentedit_email.Name = "studentedit_email"
        studentedit_email.Size = New Size(280, 33)
        studentedit_email.TabIndex = 5
        ' 
        ' studentedit_address
        ' 
        studentedit_address.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        studentedit_address.Location = New Point(352, 237)
        studentedit_address.Name = "studentedit_address"
        studentedit_address.Size = New Size(548, 33)
        studentedit_address.TabIndex = 6
        ' 
        ' studentedit_grade
        ' 
        studentedit_grade.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        studentedit_grade.Location = New Point(25, 341)
        studentedit_grade.Name = "studentedit_grade"
        studentedit_grade.Size = New Size(280, 33)
        studentedit_grade.TabIndex = 7
        ' 
        ' studentedit_birthplace
        ' 
        studentedit_birthplace.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        studentedit_birthplace.Location = New Point(366, 341)
        studentedit_birthplace.Name = "studentedit_birthplace"
        studentedit_birthplace.Size = New Size(272, 33)
        studentedit_birthplace.TabIndex = 9
        ' 
        ' studentedit_nationality
        ' 
        studentedit_nationality.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        studentedit_nationality.Location = New Point(661, 341)
        studentedit_nationality.Name = "studentedit_nationality"
        studentedit_nationality.Size = New Size(239, 33)
        studentedit_nationality.TabIndex = 10
        ' 
        ' studentedit_guardian
        ' 
        studentedit_guardian.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        studentedit_guardian.Location = New Point(25, 444)
        studentedit_guardian.Name = "studentedit_guardian"
        studentedit_guardian.Size = New Size(280, 33)
        studentedit_guardian.TabIndex = 11
        ' 
        ' studentedit_religion
        ' 
        studentedit_religion.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        studentedit_religion.Location = New Point(366, 444)
        studentedit_religion.Name = "studentedit_religion"
        studentedit_religion.Size = New Size(312, 33)
        studentedit_religion.TabIndex = 12
        ' 
        ' editstudent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(936, 528)
        Controls.Add(studentedit_religion)
        Controls.Add(studentedit_guardian)
        Controls.Add(studentedit_nationality)
        Controls.Add(studentedit_birthplace)
        Controls.Add(studentedit_grade)
        Controls.Add(studentedit_address)
        Controls.Add(studentedit_email)
        Controls.Add(studentedit_contact)
        Controls.Add(studentedit_age)
        Controls.Add(studentedit_gender)
        Controls.Add(studentedit_fullname)
        Controls.Add(Label17)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label6)
        Controls.Add(savebutton)
        Controls.Add(cancelbutton)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "editstudent"
        Text = "Edit Student Profile"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents savebutton As Button
    Friend WithEvents cancelbutton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents studentedit_fullname As TextBox
    Friend WithEvents studentedit_gender As TextBox
    Friend WithEvents studentedit_age As TextBox
    Friend WithEvents studentedit_contact As TextBox
    Friend WithEvents studentedit_email As TextBox
    Friend WithEvents studentedit_address As TextBox
    Friend WithEvents studentedit_grade As TextBox
    Friend WithEvents studentedit_birthplace As TextBox
    Friend WithEvents studentedit_nationality As TextBox
    Friend WithEvents studentedit_guardian As TextBox
    Friend WithEvents studentedit_religion As TextBox
End Class
