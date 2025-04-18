<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditDepartmentStaffPage
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
        Panel1 = New Panel()
        ComboBox1 = New ComboBox()
        Label7 = New Label()
        departmentstaff_email_TextBox = New TextBox()
        Label6 = New Label()
        departmentstaff_hiredate_TextBox = New TextBox()
        Label5 = New Label()
        departmentstaff_position_TextBox = New TextBox()
        Label4 = New Label()
        departmentstaff_departmentid_TextBox = New TextBox()
        departmentstaff_staffid_TextBox = New TextBox()
        departmentstaff_middlename_TextBox = New TextBox()
        departmentstaff_firstname_TextBox = New TextBox()
        departmentstaff_lastname_TextBox = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        editdepartmentstaff_cancel_Button = New Button()
        editdepartmentstaff_save_button = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLight
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(departmentstaff_email_TextBox)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(departmentstaff_hiredate_TextBox)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(departmentstaff_position_TextBox)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(departmentstaff_departmentid_TextBox)
        Panel1.Controls.Add(departmentstaff_staffid_TextBox)
        Panel1.Controls.Add(departmentstaff_middlename_TextBox)
        Panel1.Controls.Add(departmentstaff_firstname_TextBox)
        Panel1.Controls.Add(departmentstaff_lastname_TextBox)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(408, 170)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1175, 518)
        Panel1.TabIndex = 159
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Male", "Female", "Other"})
        ComboBox1.Location = New Point(709, 303)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 27)
        ComboBox1.TabIndex = 193
        ComboBox1.Text = "Male"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10F)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(636, 311)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(54, 19)
        Label7.TabIndex = 192
        Label7.Text = "Gender"
        ' 
        ' departmentstaff_email_TextBox
        ' 
        departmentstaff_email_TextBox.Font = New Font("Segoe UI", 10F)
        departmentstaff_email_TextBox.ForeColor = Color.Black
        departmentstaff_email_TextBox.Location = New Point(367, 303)
        departmentstaff_email_TextBox.Margin = New Padding(4, 5, 4, 5)
        departmentstaff_email_TextBox.Name = "departmentstaff_email_TextBox"
        departmentstaff_email_TextBox.Size = New Size(160, 25)
        departmentstaff_email_TextBox.TabIndex = 191
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(299, 307)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(41, 19)
        Label6.TabIndex = 190
        Label6.Text = "Email"
        ' 
        ' departmentstaff_hiredate_TextBox
        ' 
        departmentstaff_hiredate_TextBox.Font = New Font("Segoe UI", 10F)
        departmentstaff_hiredate_TextBox.ForeColor = Color.Black
        departmentstaff_hiredate_TextBox.Location = New Point(900, 253)
        departmentstaff_hiredate_TextBox.Margin = New Padding(4, 5, 4, 5)
        departmentstaff_hiredate_TextBox.Name = "departmentstaff_hiredate_TextBox"
        departmentstaff_hiredate_TextBox.Size = New Size(142, 25)
        departmentstaff_hiredate_TextBox.TabIndex = 189
        departmentstaff_hiredate_TextBox.Text = "0000-00-00"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(790, 253)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 19)
        Label5.TabIndex = 188
        Label5.Text = "Hire Date"
        ' 
        ' departmentstaff_position_TextBox
        ' 
        departmentstaff_position_TextBox.Font = New Font("Segoe UI", 10F)
        departmentstaff_position_TextBox.ForeColor = Color.Black
        departmentstaff_position_TextBox.Location = New Point(900, 184)
        departmentstaff_position_TextBox.Margin = New Padding(4, 5, 4, 5)
        departmentstaff_position_TextBox.Name = "departmentstaff_position_TextBox"
        departmentstaff_position_TextBox.Size = New Size(176, 25)
        departmentstaff_position_TextBox.TabIndex = 187
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(805, 187)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 19)
        Label4.TabIndex = 186
        Label4.Text = "Position"
        ' 
        ' departmentstaff_departmentid_TextBox
        ' 
        departmentstaff_departmentid_TextBox.Font = New Font("Segoe UI", 10F)
        departmentstaff_departmentid_TextBox.ForeColor = Color.Black
        departmentstaff_departmentid_TextBox.Location = New Point(573, 249)
        departmentstaff_departmentid_TextBox.Margin = New Padding(4, 5, 4, 5)
        departmentstaff_departmentid_TextBox.Name = "departmentstaff_departmentid_TextBox"
        departmentstaff_departmentid_TextBox.Size = New Size(182, 25)
        departmentstaff_departmentid_TextBox.TabIndex = 185
        ' 
        ' departmentstaff_staffid_TextBox
        ' 
        departmentstaff_staffid_TextBox.Font = New Font("Segoe UI", 10F)
        departmentstaff_staffid_TextBox.ForeColor = Color.Black
        departmentstaff_staffid_TextBox.Location = New Point(226, 249)
        departmentstaff_staffid_TextBox.Margin = New Padding(4, 5, 4, 5)
        departmentstaff_staffid_TextBox.Name = "departmentstaff_staffid_TextBox"
        departmentstaff_staffid_TextBox.Size = New Size(162, 25)
        departmentstaff_staffid_TextBox.TabIndex = 184
        ' 
        ' departmentstaff_middlename_TextBox
        ' 
        departmentstaff_middlename_TextBox.Font = New Font("Segoe UI", 10F)
        departmentstaff_middlename_TextBox.ForeColor = Color.Black
        departmentstaff_middlename_TextBox.Location = New Point(591, 184)
        departmentstaff_middlename_TextBox.Margin = New Padding(4, 5, 4, 5)
        departmentstaff_middlename_TextBox.Name = "departmentstaff_middlename_TextBox"
        departmentstaff_middlename_TextBox.PlaceholderText = "Middle Name"
        departmentstaff_middlename_TextBox.Size = New Size(182, 25)
        departmentstaff_middlename_TextBox.TabIndex = 183
        ' 
        ' departmentstaff_firstname_TextBox
        ' 
        departmentstaff_firstname_TextBox.Font = New Font("Segoe UI", 10F)
        departmentstaff_firstname_TextBox.ForeColor = Color.Black
        departmentstaff_firstname_TextBox.Location = New Point(389, 184)
        departmentstaff_firstname_TextBox.Margin = New Padding(4, 5, 4, 5)
        departmentstaff_firstname_TextBox.Name = "departmentstaff_firstname_TextBox"
        departmentstaff_firstname_TextBox.PlaceholderText = "First Name"
        departmentstaff_firstname_TextBox.Size = New Size(176, 25)
        departmentstaff_firstname_TextBox.TabIndex = 182
        ' 
        ' departmentstaff_lastname_TextBox
        ' 
        departmentstaff_lastname_TextBox.Font = New Font("Segoe UI", 10F)
        departmentstaff_lastname_TextBox.ForeColor = Color.Black
        departmentstaff_lastname_TextBox.Location = New Point(176, 184)
        departmentstaff_lastname_TextBox.Margin = New Padding(4, 5, 4, 5)
        departmentstaff_lastname_TextBox.Name = "departmentstaff_lastname_TextBox"
        departmentstaff_lastname_TextBox.PlaceholderText = "Last Name"
        departmentstaff_lastname_TextBox.Size = New Size(185, 25)
        departmentstaff_lastname_TextBox.TabIndex = 181
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(411, 253)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 19)
        Label3.TabIndex = 180
        Label3.Text = "Department ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(137, 253)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 19)
        Label2.TabIndex = 179
        Label2.Text = "Staff ID"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(99, 187)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 19)
        Label1.TabIndex = 178
        Label1.Text = "Name"
        ' 
        ' editdepartmentstaff_cancel_Button
        ' 
        editdepartmentstaff_cancel_Button.BackColor = Color.Maroon
        editdepartmentstaff_cancel_Button.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        editdepartmentstaff_cancel_Button.ForeColor = Color.White
        editdepartmentstaff_cancel_Button.Location = New Point(1053, 696)
        editdepartmentstaff_cancel_Button.Margin = New Padding(4, 5, 4, 5)
        editdepartmentstaff_cancel_Button.Name = "editdepartmentstaff_cancel_Button"
        editdepartmentstaff_cancel_Button.Size = New Size(108, 36)
        editdepartmentstaff_cancel_Button.TabIndex = 176
        editdepartmentstaff_cancel_Button.Text = "Cancel"
        editdepartmentstaff_cancel_Button.UseVisualStyleBackColor = False
        ' 
        ' editdepartmentstaff_save_button
        ' 
        editdepartmentstaff_save_button.BackColor = Color.Maroon
        editdepartmentstaff_save_button.ForeColor = Color.White
        editdepartmentstaff_save_button.Location = New Point(879, 700)
        editdepartmentstaff_save_button.Name = "editdepartmentstaff_save_button"
        editdepartmentstaff_save_button.Size = New Size(94, 32)
        editdepartmentstaff_save_button.TabIndex = 177
        editdepartmentstaff_save_button.Text = "Save"
        editdepartmentstaff_save_button.UseVisualStyleBackColor = False
        ' 
        ' EditDepartmentStaffPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.adminbg
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1924, 846)
        Controls.Add(editdepartmentstaff_save_button)
        Controls.Add(Panel1)
        Controls.Add(editdepartmentstaff_cancel_Button)
        Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.White
        Margin = New Padding(4, 5, 4, 5)
        Name = "EditDepartmentStaffPage"
        Text = "EditDepartmentStaffPage"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents departmentstaff_gender_TextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents departmentstaff_email_TextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents departmentstaff_hiredate_TextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents departmentstaff_position_TextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents departmentstaff_departmentid_TextBox As TextBox
    Friend WithEvents departmentstaff_staffid_TextBox As TextBox
    Friend WithEvents departmentstaff_middlename_TextBox As TextBox
    Friend WithEvents departmentstaff_firstname_TextBox As TextBox
    Friend WithEvents departmentstaff_lastname_TextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents editdepartmentstaff_cancel_Button As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents edit As Button
    Friend WithEvents editdepartmentstaff_save_button As Button
End Class
