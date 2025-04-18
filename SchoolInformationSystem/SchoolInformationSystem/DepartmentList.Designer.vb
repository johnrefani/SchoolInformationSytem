<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepartmentList
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
        departmentlist_search_Button = New Button()
        departmentlist_add_Button = New Button()
        DepartmentDataGridView = New DataGridView()
        Panel1 = New Panel()
        department_location_SearchField = New TextBox()
        department_departmentid_SearchField = New TextBox()
        department_departmenthead_SearchField = New TextBox()
        department_departmentname_SearchField = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Label5 = New Label()
        department_back_Button = New Button()
        CType(DepartmentDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' departmentlist_search_Button
        ' 
        departmentlist_search_Button.BackColor = Color.Maroon
        departmentlist_search_Button.FlatStyle = FlatStyle.Popup
        departmentlist_search_Button.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        departmentlist_search_Button.ForeColor = SystemColors.ControlLightLight
        departmentlist_search_Button.Location = New Point(505, 233)
        departmentlist_search_Button.Name = "departmentlist_search_Button"
        departmentlist_search_Button.Size = New Size(75, 29)
        departmentlist_search_Button.TabIndex = 11
        departmentlist_search_Button.Text = "Search"
        departmentlist_search_Button.UseVisualStyleBackColor = False
        ' 
        ' departmentlist_add_Button
        ' 
        departmentlist_add_Button.BackColor = Color.Maroon
        departmentlist_add_Button.FlatStyle = FlatStyle.Popup
        departmentlist_add_Button.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        departmentlist_add_Button.ForeColor = SystemColors.ControlLightLight
        departmentlist_add_Button.Location = New Point(1285, 256)
        departmentlist_add_Button.Name = "departmentlist_add_Button"
        departmentlist_add_Button.Size = New Size(75, 29)
        departmentlist_add_Button.TabIndex = 9
        departmentlist_add_Button.Text = "Add"
        departmentlist_add_Button.UseVisualStyleBackColor = False
        ' 
        ' DepartmentDataGridView
        ' 
        DepartmentDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DepartmentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DepartmentDataGridView.Dock = DockStyle.Bottom
        DepartmentDataGridView.Location = New Point(11, 188)
        DepartmentDataGridView.Name = "DepartmentDataGridView"
        DepartmentDataGridView.Size = New Size(1348, 550)
        DepartmentDataGridView.TabIndex = 8
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.Controls.Add(department_location_SearchField)
        Panel1.Controls.Add(department_departmentid_SearchField)
        Panel1.Controls.Add(department_departmenthead_SearchField)
        Panel1.Controls.Add(department_departmentname_SearchField)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(11, 114)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(569, 113)
        Panel1.TabIndex = 20
        ' 
        ' department_location_SearchField
        ' 
        department_location_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        department_location_SearchField.Location = New Point(376, 60)
        department_location_SearchField.Multiline = True
        department_location_SearchField.Name = "department_location_SearchField"
        department_location_SearchField.Size = New Size(158, 26)
        department_location_SearchField.TabIndex = 27
        ' 
        ' department_departmentid_SearchField
        ' 
        department_departmentid_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        department_departmentid_SearchField.Location = New Point(421, 25)
        department_departmentid_SearchField.Name = "department_departmentid_SearchField"
        department_departmentid_SearchField.Size = New Size(114, 25)
        department_departmentid_SearchField.TabIndex = 26
        ' 
        ' department_departmenthead_SearchField
        ' 
        department_departmenthead_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        department_departmenthead_SearchField.Location = New Point(181, 60)
        department_departmenthead_SearchField.Name = "department_departmenthead_SearchField"
        department_departmenthead_SearchField.Size = New Size(114, 25)
        department_departmenthead_SearchField.TabIndex = 25
        ' 
        ' department_departmentname_SearchField
        ' 
        department_departmentname_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        department_departmentname_SearchField.Location = New Point(181, 25)
        department_departmentname_SearchField.Name = "department_departmentname_SearchField"
        department_departmentname_SearchField.Size = New Size(114, 25)
        department_departmentname_SearchField.TabIndex = 24
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label4.Location = New Point(302, 63)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 17)
        Label4.TabIndex = 23
        Label4.Text = "Location"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(40, 63)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 17)
        Label3.TabIndex = 22
        Label3.Text = "Department Head"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label2.Location = New Point(302, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 17)
        Label2.TabIndex = 21
        Label2.Text = "Department ID"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label1.Location = New Point(35, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 17)
        Label1.TabIndex = 20
        Label1.Text = "Department Name"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Maroon
        Panel2.Controls.Add(Label5)
        Panel2.Location = New Point(11, 83)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(569, 36)
        Panel2.TabIndex = 38
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Maroon
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(22, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(40, 17)
        Label5.TabIndex = 40
        Label5.Text = "Filter"
        ' 
        ' department_back_Button
        ' 
        department_back_Button.BackColor = Color.Maroon
        department_back_Button.FlatStyle = FlatStyle.Popup
        department_back_Button.ForeColor = SystemColors.ControlLightLight
        department_back_Button.Location = New Point(1285, 13)
        department_back_Button.Name = "department_back_Button"
        department_back_Button.Size = New Size(75, 29)
        department_back_Button.TabIndex = 39
        department_back_Button.Text = "Back"
        department_back_Button.UseVisualStyleBackColor = False
        ' 
        ' DepartmentList
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.adminbg
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1370, 749)
        Controls.Add(department_back_Button)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(departmentlist_search_Button)
        Controls.Add(departmentlist_add_Button)
        Controls.Add(DepartmentDataGridView)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Name = "DepartmentList"
        Padding = New Padding(11)
        Text = "DepartmentListPage"
        WindowState = FormWindowState.Maximized
        CType(DepartmentDataGridView, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents departmentlist_search_Button As Button
    Friend WithEvents departmentlist_add_Button As Button
    Friend WithEvents DepartmentDataGridView As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents department_location_SearchField As TextBox
    Friend WithEvents department_departmentid_SearchField As TextBox
    Friend WithEvents department_departmenthead_SearchField As TextBox
    Friend WithEvents department_departmentname_SearchField As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents department_back_Button As Button
End Class
