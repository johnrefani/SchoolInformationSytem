<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepartmentStaffList
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
        departmentstafflist_search_Button = New Button()
        departmentstafflist_add_Button = New Button()
        DepartmentStaffDataGridView = New DataGridView()
        Panel1 = New Panel()
        departmentstaff_gender_SearchField = New TextBox()
        Label7 = New Label()
        departmentstaff_email_SearchField = New TextBox()
        Label6 = New Label()
        departmentstaff_hiredate_SearchField = New TextBox()
        Label5 = New Label()
        departmentstaff_position_SearchField = New TextBox()
        Label4 = New Label()
        departmentstaff_departmentid_SearchField = New TextBox()
        departmentstaff_staffid_SearchField = New TextBox()
        departmentstaff_middlename_SearchField = New TextBox()
        departmentstaff_firstname_SearchField = New TextBox()
        departmentstaff_lastname_SearchField = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Label8 = New Label()
        departmentstaff_back_Button = New Button()
        CType(DepartmentStaffDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' departmentstafflist_search_Button
        ' 
        departmentstafflist_search_Button.BackColor = Color.Maroon
        departmentstafflist_search_Button.FlatStyle = FlatStyle.Popup
        departmentstafflist_search_Button.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        departmentstafflist_search_Button.ForeColor = SystemColors.ControlLightLight
        departmentstafflist_search_Button.Location = New Point(513, 251)
        departmentstafflist_search_Button.Name = "departmentstafflist_search_Button"
        departmentstafflist_search_Button.Size = New Size(75, 29)
        departmentstafflist_search_Button.TabIndex = 19
        departmentstafflist_search_Button.Text = "Search"
        departmentstafflist_search_Button.UseVisualStyleBackColor = False
        ' 
        ' departmentstafflist_add_Button
        ' 
        departmentstafflist_add_Button.BackColor = Color.Maroon
        departmentstafflist_add_Button.FlatStyle = FlatStyle.Popup
        departmentstafflist_add_Button.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        departmentstafflist_add_Button.ForeColor = SystemColors.ControlLightLight
        departmentstafflist_add_Button.Location = New Point(1285, 256)
        departmentstafflist_add_Button.Name = "departmentstafflist_add_Button"
        departmentstafflist_add_Button.Size = New Size(75, 29)
        departmentstafflist_add_Button.TabIndex = 17
        departmentstafflist_add_Button.Text = "Add"
        departmentstafflist_add_Button.UseVisualStyleBackColor = False
        ' 
        ' DepartmentStaffDataGridView
        ' 
        DepartmentStaffDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DepartmentStaffDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DepartmentStaffDataGridView.Dock = DockStyle.Bottom
        DepartmentStaffDataGridView.Location = New Point(10, 189)
        DepartmentStaffDataGridView.Name = "DepartmentStaffDataGridView"
        DepartmentStaffDataGridView.Size = New Size(1350, 550)
        DepartmentStaffDataGridView.TabIndex = 16
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.Controls.Add(departmentstaff_gender_SearchField)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(departmentstaff_email_SearchField)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(departmentstaff_hiredate_SearchField)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(departmentstaff_position_SearchField)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(departmentstaff_departmentid_SearchField)
        Panel1.Controls.Add(departmentstaff_staffid_SearchField)
        Panel1.Controls.Add(departmentstaff_middlename_SearchField)
        Panel1.Controls.Add(departmentstaff_firstname_SearchField)
        Panel1.Controls.Add(departmentstaff_lastname_SearchField)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(11, 114)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(578, 135)
        Panel1.TabIndex = 46
        ' 
        ' departmentstaff_gender_SearchField
        ' 
        departmentstaff_gender_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        departmentstaff_gender_SearchField.Location = New Point(443, 24)
        departmentstaff_gender_SearchField.Name = "departmentstaff_gender_SearchField"
        departmentstaff_gender_SearchField.Size = New Size(118, 25)
        departmentstaff_gender_SearchField.TabIndex = 49
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label7.Location = New Point(385, 27)
        Label7.Name = "Label7"
        Label7.Size = New Size(52, 17)
        Label7.TabIndex = 60
        Label7.Text = "Gender"
        ' 
        ' departmentstaff_email_SearchField
        ' 
        departmentstaff_email_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        departmentstaff_email_SearchField.Location = New Point(67, 85)
        departmentstaff_email_SearchField.Name = "departmentstaff_email_SearchField"
        departmentstaff_email_SearchField.Size = New Size(100, 25)
        departmentstaff_email_SearchField.TabIndex = 59
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label6.Location = New Point(21, 88)
        Label6.Name = "Label6"
        Label6.Size = New Size(40, 17)
        Label6.TabIndex = 58
        Label6.Text = "Email"
        ' 
        ' departmentstaff_hiredate_SearchField
        ' 
        departmentstaff_hiredate_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        departmentstaff_hiredate_SearchField.Location = New Point(248, 85)
        departmentstaff_hiredate_SearchField.Name = "departmentstaff_hiredate_SearchField"
        departmentstaff_hiredate_SearchField.PlaceholderText = "YYYY-MM-DD"
        departmentstaff_hiredate_SearchField.Size = New Size(100, 25)
        departmentstaff_hiredate_SearchField.TabIndex = 57
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label5.Location = New Point(177, 88)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 17)
        Label5.TabIndex = 56
        Label5.Text = "Hire Date"
        ' 
        ' departmentstaff_position_SearchField
        ' 
        departmentstaff_position_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        departmentstaff_position_SearchField.Location = New Point(461, 54)
        departmentstaff_position_SearchField.Name = "departmentstaff_position_SearchField"
        departmentstaff_position_SearchField.Size = New Size(100, 25)
        departmentstaff_position_SearchField.TabIndex = 55
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label4.Location = New Point(398, 57)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 17)
        Label4.TabIndex = 54
        Label4.Text = "Position"
        ' 
        ' departmentstaff_departmentid_SearchField
        ' 
        departmentstaff_departmentid_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        departmentstaff_departmentid_SearchField.Location = New Point(288, 54)
        departmentstaff_departmentid_SearchField.Name = "departmentstaff_departmentid_SearchField"
        departmentstaff_departmentid_SearchField.Size = New Size(100, 25)
        departmentstaff_departmentid_SearchField.TabIndex = 53
        ' 
        ' departmentstaff_staffid_SearchField
        ' 
        departmentstaff_staffid_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        departmentstaff_staffid_SearchField.Location = New Point(78, 54)
        departmentstaff_staffid_SearchField.Name = "departmentstaff_staffid_SearchField"
        departmentstaff_staffid_SearchField.Size = New Size(100, 25)
        departmentstaff_staffid_SearchField.TabIndex = 52
        ' 
        ' departmentstaff_middlename_SearchField
        ' 
        departmentstaff_middlename_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        departmentstaff_middlename_SearchField.Location = New Point(279, 24)
        departmentstaff_middlename_SearchField.Name = "departmentstaff_middlename_SearchField"
        departmentstaff_middlename_SearchField.PlaceholderText = "Middle Initial"
        departmentstaff_middlename_SearchField.Size = New Size(100, 25)
        departmentstaff_middlename_SearchField.TabIndex = 51
        ' 
        ' departmentstaff_firstname_SearchField
        ' 
        departmentstaff_firstname_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        departmentstaff_firstname_SearchField.Location = New Point(173, 24)
        departmentstaff_firstname_SearchField.Name = "departmentstaff_firstname_SearchField"
        departmentstaff_firstname_SearchField.PlaceholderText = "First Name"
        departmentstaff_firstname_SearchField.Size = New Size(100, 25)
        departmentstaff_firstname_SearchField.TabIndex = 50
        ' 
        ' departmentstaff_lastname_SearchField
        ' 
        departmentstaff_lastname_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        departmentstaff_lastname_SearchField.Location = New Point(67, 24)
        departmentstaff_lastname_SearchField.Name = "departmentstaff_lastname_SearchField"
        departmentstaff_lastname_SearchField.PlaceholderText = "Last Name"
        departmentstaff_lastname_SearchField.Size = New Size(100, 25)
        departmentstaff_lastname_SearchField.TabIndex = 49
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(184, 57)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 17)
        Label3.TabIndex = 48
        Label3.Text = "Department ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label2.Location = New Point(20, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 17)
        Label2.TabIndex = 47
        Label2.Text = "Staff ID"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label1.Location = New Point(17, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 17)
        Label1.TabIndex = 46
        Label1.Text = "Name"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Maroon
        Panel2.Controls.Add(Label8)
        Panel2.Location = New Point(11, 83)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(578, 36)
        Panel2.TabIndex = 47
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Maroon
        Label8.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ControlLightLight
        Label8.Location = New Point(22, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(40, 17)
        Label8.TabIndex = 40
        Label8.Text = "Filter"
        ' 
        ' departmentstaff_back_Button
        ' 
        departmentstaff_back_Button.BackColor = Color.Maroon
        departmentstaff_back_Button.FlatStyle = FlatStyle.Popup
        departmentstaff_back_Button.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        departmentstaff_back_Button.ForeColor = SystemColors.ControlLightLight
        departmentstaff_back_Button.Location = New Point(1285, 13)
        departmentstaff_back_Button.Name = "departmentstaff_back_Button"
        departmentstaff_back_Button.Size = New Size(75, 29)
        departmentstaff_back_Button.TabIndex = 48
        departmentstaff_back_Button.Text = "Back"
        departmentstaff_back_Button.UseVisualStyleBackColor = False
        ' 
        ' DepartmentStaffList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.adminbg
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1370, 749)
        Controls.Add(departmentstaff_back_Button)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(departmentstafflist_search_Button)
        Controls.Add(departmentstafflist_add_Button)
        Controls.Add(DepartmentStaffDataGridView)
        Name = "DepartmentStaffList"
        Padding = New Padding(10)
        Text = "DepartmentStaffList"
        WindowState = FormWindowState.Maximized
        CType(DepartmentStaffDataGridView, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents departmentstafflist_search_Button As Button
    Friend WithEvents departmentstafflist_add_Button As Button
    Friend WithEvents DepartmentStaffDataGridView As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents departmentstaff_email_SearchField As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents departmentstaff_hiredate_SearchField As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents departmentstaff_position_SearchField As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents departmentstaff_departmentid_SearchField As TextBox
    Friend WithEvents departmentstaff_staffid_SearchField As TextBox
    Friend WithEvents departmentstaff_middlename_SearchField As TextBox
    Friend WithEvents departmentstaff_firstname_SearchField As TextBox
    Friend WithEvents departmentstaff_lastname_SearchField As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents departmentstaff_back_Button As Button
    Friend WithEvents departmentstaff_gender_SearchField As TextBox
End Class
