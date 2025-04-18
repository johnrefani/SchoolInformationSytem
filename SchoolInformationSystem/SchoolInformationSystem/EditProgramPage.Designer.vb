<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditProgramPage
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
        editprogram_save_Button = New Button()
        editprogram_cancel_Button = New Button()
        Panel1 = New Panel()
        Program_durationyears_TextBox = New TextBox()
        Label6 = New Label()
        Program_departmentid_TextBox = New TextBox()
        Label5 = New Label()
        Program_programcode_TextBox = New TextBox()
        Label4 = New Label()
        Program_programhead_TextBox = New TextBox()
        Label3 = New Label()
        Program_programname_TextBox = New TextBox()
        Label2 = New Label()
        Program_programid_TextBox = New TextBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' editprogram_save_Button
        ' 
        editprogram_save_Button.BackColor = Color.Maroon
        editprogram_save_Button.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        editprogram_save_Button.ForeColor = Color.White
        editprogram_save_Button.Location = New Point(747, 698)
        editprogram_save_Button.Margin = New Padding(2)
        editprogram_save_Button.Name = "editprogram_save_Button"
        editprogram_save_Button.Size = New Size(90, 34)
        editprogram_save_Button.TabIndex = 12
        editprogram_save_Button.Text = "Save"
        editprogram_save_Button.UseVisualStyleBackColor = False
        ' 
        ' editprogram_cancel_Button
        ' 
        editprogram_cancel_Button.BackColor = Color.Maroon
        editprogram_cancel_Button.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        editprogram_cancel_Button.ForeColor = Color.White
        editprogram_cancel_Button.Location = New Point(985, 698)
        editprogram_cancel_Button.Margin = New Padding(2)
        editprogram_cancel_Button.Name = "editprogram_cancel_Button"
        editprogram_cancel_Button.Size = New Size(90, 33)
        editprogram_cancel_Button.TabIndex = 13
        editprogram_cancel_Button.Text = "Cancel"
        editprogram_cancel_Button.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLight
        Panel1.Controls.Add(Program_durationyears_TextBox)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Program_departmentid_TextBox)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Program_programcode_TextBox)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Program_programhead_TextBox)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Program_programname_TextBox)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Program_programid_TextBox)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(423, 224)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(940, 450)
        Panel1.TabIndex = 14
        ' 
        ' Program_durationyears_TextBox
        ' 
        Program_durationyears_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Program_durationyears_TextBox.Location = New Point(657, 264)
        Program_durationyears_TextBox.Margin = New Padding(2)
        Program_durationyears_TextBox.Name = "Program_durationyears_TextBox"
        Program_durationyears_TextBox.Size = New Size(209, 30)
        Program_durationyears_TextBox.TabIndex = 23
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label6.Location = New Point(516, 267)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(126, 23)
        Label6.TabIndex = 22
        Label6.Text = "Duration Years"
        ' 
        ' Program_departmentid_TextBox
        ' 
        Program_departmentid_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Program_departmentid_TextBox.Location = New Point(270, 264)
        Program_departmentid_TextBox.Margin = New Padding(2)
        Program_departmentid_TextBox.Name = "Program_departmentid_TextBox"
        Program_departmentid_TextBox.Size = New Size(217, 30)
        Program_departmentid_TextBox.TabIndex = 21
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label5.Location = New Point(135, 267)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(131, 23)
        Label5.TabIndex = 20
        Label5.Text = "Department ID"
        ' 
        ' Program_programcode_TextBox
        ' 
        Program_programcode_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Program_programcode_TextBox.Location = New Point(599, 206)
        Program_programcode_TextBox.Margin = New Padding(2)
        Program_programcode_TextBox.Name = "Program_programcode_TextBox"
        Program_programcode_TextBox.Size = New Size(205, 30)
        Program_programcode_TextBox.TabIndex = 19
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label4.Location = New Point(469, 209)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(126, 23)
        Label4.TabIndex = 18
        Label4.Text = "Program Code"
        ' 
        ' Program_programhead_TextBox
        ' 
        Program_programhead_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Program_programhead_TextBox.Location = New Point(253, 206)
        Program_programhead_TextBox.Margin = New Padding(2)
        Program_programhead_TextBox.Name = "Program_programhead_TextBox"
        Program_programhead_TextBox.Size = New Size(212, 30)
        Program_programhead_TextBox.TabIndex = 17
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label3.Location = New Point(111, 209)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(127, 23)
        Label3.TabIndex = 16
        Label3.Text = "Program Head"
        ' 
        ' Program_programname_TextBox
        ' 
        Program_programname_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Program_programname_TextBox.Location = New Point(657, 157)
        Program_programname_TextBox.Margin = New Padding(2)
        Program_programname_TextBox.Name = "Program_programname_TextBox"
        Program_programname_TextBox.Size = New Size(210, 30)
        Program_programname_TextBox.TabIndex = 15
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label2.Location = New Point(510, 160)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 23)
        Label2.TabIndex = 14
        Label2.Text = "Program Name"
        ' 
        ' Program_programid_TextBox
        ' 
        Program_programid_TextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Program_programid_TextBox.Location = New Point(257, 157)
        Program_programid_TextBox.Margin = New Padding(2)
        Program_programid_TextBox.Name = "Program_programid_TextBox"
        Program_programid_TextBox.Size = New Size(210, 30)
        Program_programid_TextBox.TabIndex = 13
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label1.Location = New Point(135, 164)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 23)
        Label1.TabIndex = 12
        Label1.Text = "Program ID"
        ' 
        ' EditProgramPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.adminbg
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1804, 871)
        Controls.Add(Panel1)
        Controls.Add(editprogram_cancel_Button)
        Controls.Add(editprogram_save_Button)
        Margin = New Padding(2)
        Name = "EditProgramPage"
        Text = "EditProgramPage"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents editprogram_save_Button As Button
    Friend WithEvents editprogram_cancel_Button As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Program_durationyears_TextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Program_departmentid_TextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Program_programcode_TextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Program_programhead_TextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Program_programname_TextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Program_programid_TextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
