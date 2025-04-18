<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDepartmentStaffPageforAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddDepartmentStaffPageforAdmin))
        Panel1 = New Panel()
        adddepartment_back_Button = New Button()
        departmentstaff_add_Button = New Button()
        departmentstaff_gender_TextBox = New ComboBox()
        departmentstaff_position_TextBox = New TextBox()
        TextBox9 = New TextBox()
        departmentstaff_email_TextBox = New TextBox()
        departmentstaff_hiredate_TextBox = New TextBox()
        departmentstaff_departmentid_TextBox = New TextBox()
        departmentstaff_staffid_TextBox = New TextBox()
        departmentstaff_middlename_TextBox = New TextBox()
        departmentstaff_firstname_TextBox = New TextBox()
        departmentstaff_lastname_TextBox = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.BackColor = Color.LightGray
        Panel1.Controls.Add(adddepartment_back_Button)
        Panel1.Controls.Add(departmentstaff_add_Button)
        Panel1.Controls.Add(departmentstaff_gender_TextBox)
        Panel1.Controls.Add(departmentstaff_position_TextBox)
        Panel1.Controls.Add(TextBox9)
        Panel1.Controls.Add(departmentstaff_email_TextBox)
        Panel1.Controls.Add(departmentstaff_hiredate_TextBox)
        Panel1.Controls.Add(departmentstaff_departmentid_TextBox)
        Panel1.Controls.Add(departmentstaff_staffid_TextBox)
        Panel1.Controls.Add(departmentstaff_middlename_TextBox)
        Panel1.Controls.Add(departmentstaff_firstname_TextBox)
        Panel1.Controls.Add(departmentstaff_lastname_TextBox)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(313, 274)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(940, 450)
        Panel1.TabIndex = 0
        ' 
        ' adddepartment_back_Button
        ' 
        adddepartment_back_Button.BackColor = Color.Maroon
        adddepartment_back_Button.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        adddepartment_back_Button.ForeColor = SystemColors.ControlLightLight
        adddepartment_back_Button.Location = New Point(826, 28)
        adddepartment_back_Button.Margin = New Padding(3, 4, 3, 4)
        adddepartment_back_Button.Name = "adddepartment_back_Button"
        adddepartment_back_Button.Size = New Size(86, 35)
        adddepartment_back_Button.TabIndex = 20
        adddepartment_back_Button.Text = "Back"
        adddepartment_back_Button.UseVisualStyleBackColor = False
        ' 
        ' departmentstaff_add_Button
        ' 
        departmentstaff_add_Button.BackColor = Color.Maroon
        departmentstaff_add_Button.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        departmentstaff_add_Button.ForeColor = SystemColors.ControlLightLight
        departmentstaff_add_Button.Location = New Point(429, 337)
        departmentstaff_add_Button.Margin = New Padding(3, 4, 3, 4)
        departmentstaff_add_Button.Name = "departmentstaff_add_Button"
        departmentstaff_add_Button.Size = New Size(86, 35)
        departmentstaff_add_Button.TabIndex = 19
        departmentstaff_add_Button.Text = "Add"
        departmentstaff_add_Button.UseVisualStyleBackColor = False
        ' 
        ' departmentstaff_gender_TextBox
        ' 
        departmentstaff_gender_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        departmentstaff_gender_TextBox.FormattingEnabled = True
        departmentstaff_gender_TextBox.Items.AddRange(New Object() {"Female", "Male", "Other"})
        departmentstaff_gender_TextBox.Location = New Point(708, 182)
        departmentstaff_gender_TextBox.Margin = New Padding(3, 4, 3, 4)
        departmentstaff_gender_TextBox.Name = "departmentstaff_gender_TextBox"
        departmentstaff_gender_TextBox.Size = New Size(119, 29)
        departmentstaff_gender_TextBox.TabIndex = 18
        ' 
        ' departmentstaff_position_TextBox
        ' 
        departmentstaff_position_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        departmentstaff_position_TextBox.Location = New Point(447, 235)
        departmentstaff_position_TextBox.Margin = New Padding(3, 4, 3, 4)
        departmentstaff_position_TextBox.Name = "departmentstaff_position_TextBox"
        departmentstaff_position_TextBox.Size = New Size(151, 29)
        departmentstaff_position_TextBox.TabIndex = 17
        ' 
        ' TextBox9
        ' 
        TextBox9.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        TextBox9.Location = New Point(752, 131)
        TextBox9.Margin = New Padding(3, 4, 3, 4)
        TextBox9.Name = "TextBox9"
        TextBox9.PlaceholderText = "ex. Jr., I, II, III"
        TextBox9.Size = New Size(75, 29)
        TextBox9.TabIndex = 16
        ' 
        ' departmentstaff_email_TextBox
        ' 
        departmentstaff_email_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        departmentstaff_email_TextBox.Location = New Point(183, 235)
        departmentstaff_email_TextBox.Margin = New Padding(3, 4, 3, 4)
        departmentstaff_email_TextBox.Name = "departmentstaff_email_TextBox"
        departmentstaff_email_TextBox.PlaceholderText = "ex. @gmail.com"
        departmentstaff_email_TextBox.Size = New Size(174, 29)
        departmentstaff_email_TextBox.TabIndex = 14
        ' 
        ' departmentstaff_hiredate_TextBox
        ' 
        departmentstaff_hiredate_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        departmentstaff_hiredate_TextBox.Location = New Point(695, 235)
        departmentstaff_hiredate_TextBox.Margin = New Padding(3, 4, 3, 4)
        departmentstaff_hiredate_TextBox.Name = "departmentstaff_hiredate_TextBox"
        departmentstaff_hiredate_TextBox.PlaceholderText = "YYYY-MM-DD"
        departmentstaff_hiredate_TextBox.Size = New Size(132, 29)
        departmentstaff_hiredate_TextBox.TabIndex = 13
        ' 
        ' departmentstaff_departmentid_TextBox
        ' 
        departmentstaff_departmentid_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        departmentstaff_departmentid_TextBox.Location = New Point(476, 182)
        departmentstaff_departmentid_TextBox.Margin = New Padding(3, 4, 3, 4)
        departmentstaff_departmentid_TextBox.Name = "departmentstaff_departmentid_TextBox"
        departmentstaff_departmentid_TextBox.Size = New Size(153, 29)
        departmentstaff_departmentid_TextBox.TabIndex = 12
        ' 
        ' departmentstaff_staffid_TextBox
        ' 
        departmentstaff_staffid_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        departmentstaff_staffid_TextBox.Location = New Point(183, 182)
        departmentstaff_staffid_TextBox.Margin = New Padding(3, 4, 3, 4)
        departmentstaff_staffid_TextBox.Name = "departmentstaff_staffid_TextBox"
        departmentstaff_staffid_TextBox.Size = New Size(158, 29)
        departmentstaff_staffid_TextBox.TabIndex = 11
        ' 
        ' departmentstaff_middlename_TextBox
        ' 
        departmentstaff_middlename_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        departmentstaff_middlename_TextBox.Location = New Point(515, 131)
        departmentstaff_middlename_TextBox.Margin = New Padding(3, 4, 3, 4)
        departmentstaff_middlename_TextBox.Name = "departmentstaff_middlename_TextBox"
        departmentstaff_middlename_TextBox.PlaceholderText = "Middle Name"
        departmentstaff_middlename_TextBox.Size = New Size(158, 29)
        departmentstaff_middlename_TextBox.TabIndex = 10
        ' 
        ' departmentstaff_firstname_TextBox
        ' 
        departmentstaff_firstname_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        departmentstaff_firstname_TextBox.Location = New Point(349, 131)
        departmentstaff_firstname_TextBox.Margin = New Padding(3, 4, 3, 4)
        departmentstaff_firstname_TextBox.Name = "departmentstaff_firstname_TextBox"
        departmentstaff_firstname_TextBox.PlaceholderText = "First Name"
        departmentstaff_firstname_TextBox.Size = New Size(158, 29)
        departmentstaff_firstname_TextBox.TabIndex = 9
        ' 
        ' departmentstaff_lastname_TextBox
        ' 
        departmentstaff_lastname_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        departmentstaff_lastname_TextBox.Location = New Point(183, 131)
        departmentstaff_lastname_TextBox.Margin = New Padding(3, 4, 3, 4)
        departmentstaff_lastname_TextBox.Name = "departmentstaff_lastname_TextBox"
        departmentstaff_lastname_TextBox.PlaceholderText = "Last Name"
        departmentstaff_lastname_TextBox.Size = New Size(158, 29)
        departmentstaff_lastname_TextBox.TabIndex = 8
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label8.Location = New Point(641, 186)
        Label8.Name = "Label8"
        Label8.Size = New Size(66, 23)
        Label8.TabIndex = 7
        Label8.Text = "Gender"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label7.Location = New Point(120, 239)
        Label7.Name = "Label7"
        Label7.Size = New Size(51, 23)
        Label7.TabIndex = 6
        Label7.Text = "Email"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label6.Location = New Point(614, 239)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 23)
        Label6.TabIndex = 5
        Label6.Text = "Hire Date"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label5.Location = New Point(357, 186)
        Label5.Name = "Label5"
        Label5.Size = New Size(124, 23)
        Label5.TabIndex = 4
        Label5.Text = "Department ID"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label4.Location = New Point(110, 186)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 23)
        Label4.TabIndex = 3
        Label4.Text = "Staff ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(375, 239)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 23)
        Label3.TabIndex = 2
        Label3.Text = "Position"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label2.Location = New Point(697, 135)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 23)
        Label2.TabIndex = 1
        Label2.Text = "Suffix"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label1.Location = New Point(120, 135)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 23)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' AddDepartmentStaffPageforAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1566, 999)
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "AddDepartmentStaffPageforAdmin"
        Text = "Add Department Staff Page for Admin"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents departmentstaff_position_TextBox As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents departmentstaff_email_TextBox As TextBox
    Friend WithEvents departmentstaff_hiredate_TextBox As TextBox
    Friend WithEvents departmentstaff_departmentid_TextBox As TextBox
    Friend WithEvents departmentstaff_staffid_TextBox As TextBox
    Friend WithEvents departmentstaff_middlename_TextBox As TextBox
    Friend WithEvents departmentstaff_firstname_TextBox As TextBox
    Friend WithEvents departmentstaff_lastname_TextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents adddepartment_back_Button As Button
    Friend WithEvents departmentstaff_add_Button As Button
    Friend WithEvents departmentstaff_gender_TextBox As ComboBox
End Class
