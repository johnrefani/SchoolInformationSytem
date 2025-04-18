<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDepartmentPageforAdmin
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
        department_add_Button = New Button()
        department_list_Button = New Button()
        department_back_Button = New Button()
        Panel1 = New Panel()
        department_location_TextBox = New TextBox()
        department_departmentid_TextBox = New TextBox()
        department_departmenthead_TextBox = New TextBox()
        department_departmentname_TextBox = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' department_add_Button
        ' 
        department_add_Button.BackColor = Color.Maroon
        department_add_Button.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        department_add_Button.ForeColor = Color.White
        department_add_Button.Location = New Point(1228, 731)
        department_add_Button.Margin = New Padding(3, 4, 3, 4)
        department_add_Button.Name = "department_add_Button"
        department_add_Button.Size = New Size(86, 40)
        department_add_Button.TabIndex = 18
        department_add_Button.Text = "Add"
        department_add_Button.UseVisualStyleBackColor = False
        ' 
        ' department_list_Button
        ' 
        department_list_Button.BackColor = Color.Maroon
        department_list_Button.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        department_list_Button.ForeColor = Color.White
        department_list_Button.Location = New Point(978, 731)
        department_list_Button.Margin = New Padding(3, 4, 3, 4)
        department_list_Button.Name = "department_list_Button"
        department_list_Button.Size = New Size(162, 40)
        department_list_Button.TabIndex = 21
        department_list_Button.Text = "Department List"
        department_list_Button.UseVisualStyleBackColor = False
        ' 
        ' department_back_Button
        ' 
        department_back_Button.BackColor = Color.Maroon
        department_back_Button.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        department_back_Button.ForeColor = Color.White
        department_back_Button.Location = New Point(1266, 291)
        department_back_Button.Margin = New Padding(3, 4, 3, 4)
        department_back_Button.Name = "department_back_Button"
        department_back_Button.Size = New Size(86, 42)
        department_back_Button.TabIndex = 22
        department_back_Button.Text = "Back"
        department_back_Button.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.Controls.Add(department_location_TextBox)
        Panel1.Controls.Add(department_departmentid_TextBox)
        Panel1.Controls.Add(department_departmenthead_TextBox)
        Panel1.Controls.Add(department_departmentname_TextBox)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(559, 340)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(806, 375)
        Panel1.TabIndex = 23
        ' 
        ' department_location_TextBox
        ' 
        department_location_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        department_location_TextBox.Location = New Point(577, 203)
        department_location_TextBox.Margin = New Padding(3, 4, 3, 4)
        department_location_TextBox.Name = "department_location_TextBox"
        department_location_TextBox.Size = New Size(145, 30)
        department_location_TextBox.TabIndex = 19
        ' 
        ' department_departmentid_TextBox
        ' 
        department_departmentid_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        department_departmentid_TextBox.Location = New Point(577, 141)
        department_departmentid_TextBox.Margin = New Padding(3, 4, 3, 4)
        department_departmentid_TextBox.Name = "department_departmentid_TextBox"
        department_departmentid_TextBox.Size = New Size(145, 30)
        department_departmentid_TextBox.TabIndex = 18
        ' 
        ' department_departmenthead_TextBox
        ' 
        department_departmenthead_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        department_departmenthead_TextBox.Location = New Point(250, 206)
        department_departmenthead_TextBox.Margin = New Padding(3, 4, 3, 4)
        department_departmenthead_TextBox.Name = "department_departmenthead_TextBox"
        department_departmenthead_TextBox.Size = New Size(138, 30)
        department_departmenthead_TextBox.TabIndex = 17
        ' 
        ' department_departmentname_TextBox
        ' 
        department_departmentname_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        department_departmentname_TextBox.Location = New Point(250, 138)
        department_departmentname_TextBox.Margin = New Padding(3, 4, 3, 4)
        department_departmentname_TextBox.Name = "department_departmentname_TextBox"
        department_departmentname_TextBox.Size = New Size(138, 30)
        department_departmentname_TextBox.TabIndex = 16
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label4.Location = New Point(470, 209)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 23)
        Label4.TabIndex = 15
        Label4.Text = "Location"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label3.Location = New Point(84, 209)
        Label3.Name = "Label3"
        Label3.Size = New Size(155, 23)
        Label3.TabIndex = 14
        Label3.Text = "Department Head"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label2.Location = New Point(417, 145)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 23)
        Label2.TabIndex = 13
        Label2.Text = "Department ID"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label1.Location = New Point(84, 141)
        Label1.Name = "Label1"
        Label1.Size = New Size(160, 23)
        Label1.TabIndex = 12
        Label1.Text = "Department Name"
        ' 
        ' AddDepartmentPageforAdmin
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.adminbg
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1924, 1055)
        Controls.Add(Panel1)
        Controls.Add(department_back_Button)
        Controls.Add(department_list_Button)
        Controls.Add(department_add_Button)
        Margin = New Padding(3, 4, 3, 4)
        Name = "AddDepartmentPageforAdmin"
        Text = "DepartmentPage"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents department_add_Button As Button
    Friend WithEvents department_list_Button As Button
    Friend WithEvents department_back_Button As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents department_location_TextBox As TextBox
    Friend WithEvents department_departmentid_TextBox As TextBox
    Friend WithEvents department_departmenthead_TextBox As TextBox
    Friend WithEvents department_departmentname_TextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
