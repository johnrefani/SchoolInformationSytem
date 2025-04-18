<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditBlockPage
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
        editblock_cancel_Button = New Button()
        editblock_save_Button = New Button()
        Panel1 = New Panel()
        block_semester_TextBox = New TextBox()
        Label5 = New Label()
        block_studentid_TextBox = New TextBox()
        Label4 = New Label()
        block_programid_TextBox = New TextBox()
        Label3 = New Label()
        block_blockcode_TextBox = New TextBox()
        Label2 = New Label()
        block_blockid_TextBox = New TextBox()
        Label1 = New Label()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' editblock_cancel_Button
        ' 
        editblock_cancel_Button.BackColor = Color.Maroon
        editblock_cancel_Button.FlatStyle = FlatStyle.Popup
        editblock_cancel_Button.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        editblock_cancel_Button.ForeColor = Color.White
        editblock_cancel_Button.Location = New Point(965, 505)
        editblock_cancel_Button.Name = "editblock_cancel_Button"
        editblock_cancel_Button.Size = New Size(75, 29)
        editblock_cancel_Button.TabIndex = 150
        editblock_cancel_Button.Text = "Cancel"
        editblock_cancel_Button.UseVisualStyleBackColor = False
        ' 
        ' editblock_save_Button
        ' 
        editblock_save_Button.BackColor = Color.Maroon
        editblock_save_Button.FlatStyle = FlatStyle.Popup
        editblock_save_Button.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        editblock_save_Button.ForeColor = Color.White
        editblock_save_Button.Location = New Point(704, 505)
        editblock_save_Button.Name = "editblock_save_Button"
        editblock_save_Button.Size = New Size(75, 29)
        editblock_save_Button.TabIndex = 149
        editblock_save_Button.Text = "Save"
        editblock_save_Button.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLight
        Panel1.Controls.Add(block_semester_TextBox)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(block_studentid_TextBox)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(block_programid_TextBox)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(block_blockcode_TextBox)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(block_blockid_TextBox)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(274, 150)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(822, 200)
        Panel1.TabIndex = 151
        ' 
        ' block_semester_TextBox
        ' 
        block_semester_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        block_semester_TextBox.Location = New Point(485, 133)
        block_semester_TextBox.Name = "block_semester_TextBox"
        block_semester_TextBox.Size = New Size(163, 25)
        block_semester_TextBox.TabIndex = 29
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label5.Location = New Point(418, 135)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 17)
        Label5.TabIndex = 28
        Label5.Text = "Semester"
        ' 
        ' block_studentid_TextBox
        ' 
        block_studentid_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        block_studentid_TextBox.Location = New Point(234, 133)
        block_studentid_TextBox.Name = "block_studentid_TextBox"
        block_studentid_TextBox.Size = New Size(162, 25)
        block_studentid_TextBox.TabIndex = 27
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label4.Location = New Point(160, 135)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 17)
        Label4.TabIndex = 26
        Label4.Text = "Student ID"
        ' 
        ' block_programid_TextBox
        ' 
        block_programid_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        block_programid_TextBox.Location = New Point(605, 87)
        block_programid_TextBox.Name = "block_programid_TextBox"
        block_programid_TextBox.Size = New Size(154, 25)
        block_programid_TextBox.TabIndex = 25
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(525, 89)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 17)
        Label3.TabIndex = 24
        Label3.Text = "Program ID"
        ' 
        ' block_blockcode_TextBox
        ' 
        block_blockcode_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        block_blockcode_TextBox.Location = New Point(363, 87)
        block_blockcode_TextBox.Name = "block_blockcode_TextBox"
        block_blockcode_TextBox.Size = New Size(157, 25)
        block_blockcode_TextBox.TabIndex = 23
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label2.Location = New Point(284, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 17)
        Label2.TabIndex = 22
        Label2.Text = "Block Code"
        ' 
        ' block_blockid_TextBox
        ' 
        block_blockid_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        block_blockid_TextBox.Location = New Point(129, 87)
        block_blockid_TextBox.Name = "block_blockid_TextBox"
        block_blockid_TextBox.Size = New Size(150, 25)
        block_blockid_TextBox.TabIndex = 21
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label1.Location = New Point(62, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 17)
        Label1.TabIndex = 20
        Label1.Text = "Block ID"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Maroon
        Panel2.Location = New Point(274, 139)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(822, 50)
        Panel2.TabIndex = 152
        ' 
        ' EditBlockPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.adminbg
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1370, 749)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(editblock_cancel_Button)
        Controls.Add(editblock_save_Button)
        Name = "EditBlockPage"
        Text = "EditBlockPage"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents editblock_cancel_Button As Button
    Friend WithEvents editblock_save_Button As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents block_semester_TextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents block_studentid_TextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents block_programid_TextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents block_blockcode_TextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents block_blockid_TextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
End Class
