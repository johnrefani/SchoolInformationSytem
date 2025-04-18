<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditDepartmentPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditDepartmentPage))
        department_location_TextBox = New TextBox()
        department_departmentid_TextBox = New TextBox()
        department_departmenthead_TextBox = New TextBox()
        department_departmentname_TextBox = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        editdepartment_cancel_Button = New Button()
        editdepartment_save_Button = New Button()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' department_location_TextBox
        ' 
        department_location_TextBox.Font = New Font("Segoe UI", 10F)
        department_location_TextBox.Location = New Point(564, 149)
        department_location_TextBox.Margin = New Padding(3, 4, 3, 4)
        department_location_TextBox.Name = "department_location_TextBox"
        department_location_TextBox.Size = New Size(165, 30)
        department_location_TextBox.TabIndex = 19
        ' 
        ' department_departmentid_TextBox
        ' 
        department_departmentid_TextBox.Font = New Font("Segoe UI", 10F)
        department_departmentid_TextBox.Location = New Point(564, 67)
        department_departmentid_TextBox.Margin = New Padding(3, 4, 3, 4)
        department_departmentid_TextBox.Name = "department_departmentid_TextBox"
        department_departmentid_TextBox.Size = New Size(165, 30)
        department_departmentid_TextBox.TabIndex = 18
        ' 
        ' department_departmenthead_TextBox
        ' 
        department_departmenthead_TextBox.Font = New Font("Segoe UI", 10F)
        department_departmenthead_TextBox.Location = New Point(279, 149)
        department_departmenthead_TextBox.Margin = New Padding(3, 4, 3, 4)
        department_departmenthead_TextBox.Name = "department_departmenthead_TextBox"
        department_departmenthead_TextBox.Size = New Size(146, 30)
        department_departmenthead_TextBox.TabIndex = 17
        ' 
        ' department_departmentname_TextBox
        ' 
        department_departmentname_TextBox.Font = New Font("Segoe UI", 10F)
        department_departmentname_TextBox.Location = New Point(210, 67)
        department_departmentname_TextBox.Margin = New Padding(3, 4, 3, 4)
        department_departmentname_TextBox.Name = "department_departmentname_TextBox"
        department_departmentname_TextBox.Size = New Size(172, 30)
        department_departmentname_TextBox.TabIndex = 16
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F)
        Label4.Location = New Point(471, 152)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 23)
        Label4.TabIndex = 15
        Label4.Text = "Location"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.Location = New Point(126, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(147, 23)
        Label3.TabIndex = 14
        Label3.Text = "Department Head"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F)
        Label2.Location = New Point(422, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 23)
        Label2.TabIndex = 13
        Label2.Text = "Department ID"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F)
        Label1.Location = New Point(51, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 23)
        Label1.TabIndex = 12
        Label1.Text = "Department Name"
        ' 
        ' editdepartment_cancel_Button
        ' 
        editdepartment_cancel_Button.BackColor = Color.Maroon
        editdepartment_cancel_Button.Font = New Font("Segoe UI", 10F)
        editdepartment_cancel_Button.ForeColor = Color.White
        editdepartment_cancel_Button.Location = New Point(490, 246)
        editdepartment_cancel_Button.Margin = New Padding(3, 4, 3, 4)
        editdepartment_cancel_Button.Name = "editdepartment_cancel_Button"
        editdepartment_cancel_Button.Size = New Size(98, 31)
        editdepartment_cancel_Button.TabIndex = 156
        editdepartment_cancel_Button.Text = "Cancel"
        editdepartment_cancel_Button.UseVisualStyleBackColor = False
        ' 
        ' editdepartment_save_Button
        ' 
        editdepartment_save_Button.BackColor = Color.Maroon
        editdepartment_save_Button.Font = New Font("Segoe UI", 10F)
        editdepartment_save_Button.ForeColor = Color.White
        editdepartment_save_Button.Location = New Point(308, 246)
        editdepartment_save_Button.Margin = New Padding(3, 4, 3, 4)
        editdepartment_save_Button.Name = "editdepartment_save_Button"
        editdepartment_save_Button.Size = New Size(95, 31)
        editdepartment_save_Button.TabIndex = 155
        editdepartment_save_Button.Text = "Save"
        editdepartment_save_Button.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLight
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(editdepartment_cancel_Button)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(editdepartment_save_Button)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(department_location_TextBox)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(department_departmentid_TextBox)
        Panel1.Controls.Add(department_departmentname_TextBox)
        Panel1.Controls.Add(department_departmenthead_TextBox)
        Panel1.Location = New Point(420, 124)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(940, 450)
        Panel1.TabIndex = 157
        ' 
        ' EditDepartmentPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1613, 602)
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "EditDepartmentPage"
        Text = "EditDepartmentPage"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents department_location_TextBox As TextBox
    Friend WithEvents department_departmentid_TextBox As TextBox
    Friend WithEvents department_departmenthead_TextBox As TextBox
    Friend WithEvents department_departmentname_TextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents editdepartment_cancel_Button As Button
    Friend WithEvents editdepartment_save_Button As Button
    Friend WithEvents Panel1 As Panel
End Class
