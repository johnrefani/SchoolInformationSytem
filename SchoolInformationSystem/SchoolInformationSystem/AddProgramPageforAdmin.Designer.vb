<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProgramPageforAdmin
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
        program_add_Button = New Button()
        addprogram_back_Button = New Button()
        Panel1 = New Panel()
        program_durationyears_TextBox = New TextBox()
        program_programhead_TextBox = New TextBox()
        program_departmentid_TextBox = New TextBox()
        program_programname_TextBox = New TextBox()
        program_programcode_TextBox = New TextBox()
        program_programid_TextBox = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' program_add_Button
        ' 
        program_add_Button.BackColor = Color.Maroon
        program_add_Button.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        program_add_Button.ForeColor = Color.White
        program_add_Button.Location = New Point(867, 632)
        program_add_Button.Margin = New Padding(3, 4, 3, 4)
        program_add_Button.Name = "program_add_Button"
        program_add_Button.Size = New Size(86, 37)
        program_add_Button.TabIndex = 25
        program_add_Button.Text = "Add"
        program_add_Button.UseVisualStyleBackColor = False
        ' 
        ' addprogram_back_Button
        ' 
        addprogram_back_Button.BackColor = Color.Maroon
        addprogram_back_Button.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addprogram_back_Button.ForeColor = Color.White
        addprogram_back_Button.Location = New Point(1256, 119)
        addprogram_back_Button.Margin = New Padding(3, 4, 3, 4)
        addprogram_back_Button.Name = "addprogram_back_Button"
        addprogram_back_Button.Size = New Size(86, 39)
        addprogram_back_Button.TabIndex = 28
        addprogram_back_Button.Text = "Back"
        addprogram_back_Button.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLight
        Panel1.Controls.Add(program_durationyears_TextBox)
        Panel1.Controls.Add(program_programhead_TextBox)
        Panel1.Controls.Add(program_departmentid_TextBox)
        Panel1.Controls.Add(program_programname_TextBox)
        Panel1.Controls.Add(program_programcode_TextBox)
        Panel1.Controls.Add(program_programid_TextBox)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(437, 165)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(940, 450)
        Panel1.TabIndex = 29
        ' 
        ' program_durationyears_TextBox
        ' 
        program_durationyears_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        program_durationyears_TextBox.Location = New Point(657, 164)
        program_durationyears_TextBox.Margin = New Padding(3, 4, 3, 4)
        program_durationyears_TextBox.Name = "program_durationyears_TextBox"
        program_durationyears_TextBox.Size = New Size(178, 30)
        program_durationyears_TextBox.TabIndex = 28
        ' 
        ' program_programhead_TextBox
        ' 
        program_programhead_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        program_programhead_TextBox.Location = New Point(304, 168)
        program_programhead_TextBox.Margin = New Padding(3, 4, 3, 4)
        program_programhead_TextBox.Name = "program_programhead_TextBox"
        program_programhead_TextBox.Size = New Size(192, 30)
        program_programhead_TextBox.TabIndex = 27
        ' 
        ' program_departmentid_TextBox
        ' 
        program_departmentid_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        program_departmentid_TextBox.Location = New Point(596, 230)
        program_departmentid_TextBox.Margin = New Padding(3, 4, 3, 4)
        program_departmentid_TextBox.Name = "program_departmentid_TextBox"
        program_departmentid_TextBox.Size = New Size(189, 30)
        program_departmentid_TextBox.TabIndex = 26
        ' 
        ' program_programname_TextBox
        ' 
        program_programname_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        program_programname_TextBox.Location = New Point(630, 97)
        program_programname_TextBox.Margin = New Padding(3, 4, 3, 4)
        program_programname_TextBox.Name = "program_programname_TextBox"
        program_programname_TextBox.Size = New Size(225, 30)
        program_programname_TextBox.TabIndex = 25
        ' 
        ' program_programcode_TextBox
        ' 
        program_programcode_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        program_programcode_TextBox.Location = New Point(228, 230)
        program_programcode_TextBox.Margin = New Padding(3, 4, 3, 4)
        program_programcode_TextBox.Name = "program_programcode_TextBox"
        program_programcode_TextBox.Size = New Size(200, 30)
        program_programcode_TextBox.TabIndex = 24
        ' 
        ' program_programid_TextBox
        ' 
        program_programid_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        program_programid_TextBox.Location = New Point(216, 97)
        program_programid_TextBox.Margin = New Padding(3, 4, 3, 4)
        program_programid_TextBox.Name = "program_programid_TextBox"
        program_programid_TextBox.Size = New Size(212, 30)
        program_programid_TextBox.TabIndex = 23
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label6.Location = New Point(525, 171)
        Label6.Name = "Label6"
        Label6.Size = New Size(126, 23)
        Label6.TabIndex = 22
        Label6.Text = "Duration Years"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label5.Location = New Point(444, 233)
        Label5.Name = "Label5"
        Label5.Size = New Size(131, 23)
        Label5.TabIndex = 21
        Label5.Text = "Department ID"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label4.Location = New Point(85, 233)
        Label4.Name = "Label4"
        Label4.Size = New Size(126, 23)
        Label4.TabIndex = 20
        Label4.Text = "Program Code"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label3.Location = New Point(152, 171)
        Label3.Name = "Label3"
        Label3.Size = New Size(127, 23)
        Label3.TabIndex = 19
        Label3.Text = "Program Head"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label2.Location = New Point(479, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 23)
        Label2.TabIndex = 18
        Label2.Text = "Program Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label1.Location = New Point(96, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 23)
        Label1.TabIndex = 17
        Label1.Text = "Program ID"
        ' 
        ' AddProgramPageforAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.adminbg
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1841, 781)
        Controls.Add(Panel1)
        Controls.Add(addprogram_back_Button)
        Controls.Add(program_add_Button)
        Margin = New Padding(3, 4, 3, 4)
        Name = "AddProgramPageforAdmin"
        Text = "ProgramPage"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents program_add_Button As Button
    Friend WithEvents addprogram_back_Button As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents program_durationyears_TextBox As TextBox
    Friend WithEvents program_programhead_TextBox As TextBox
    Friend WithEvents program_departmentid_TextBox As TextBox
    Friend WithEvents program_programname_TextBox As TextBox
    Friend WithEvents program_programcode_TextBox As TextBox
    Friend WithEvents program_programid_TextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
