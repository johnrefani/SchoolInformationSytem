<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBlockPageforAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddBlockPageforAdmin))
        Panel1 = New Panel()
        addblock_back_Button = New Button()
        block_add_Button = New Button()
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
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.Controls.Add(addblock_back_Button)
        Panel1.Controls.Add(block_add_Button)
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
        Panel1.Location = New Point(313, 274)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(940, 450)
        Panel1.TabIndex = 0
        ' 
        ' addblock_back_Button
        ' 
        addblock_back_Button.BackColor = Color.Maroon
        addblock_back_Button.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addblock_back_Button.ForeColor = SystemColors.ControlLightLight
        addblock_back_Button.Location = New Point(781, 74)
        addblock_back_Button.Name = "addblock_back_Button"
        addblock_back_Button.Size = New Size(94, 31)
        addblock_back_Button.TabIndex = 73
        addblock_back_Button.Text = "Back"
        addblock_back_Button.UseVisualStyleBackColor = False
        ' 
        ' block_add_Button
        ' 
        block_add_Button.BackColor = Color.Maroon
        block_add_Button.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        block_add_Button.ForeColor = SystemColors.ControlLightLight
        block_add_Button.Location = New Point(407, 346)
        block_add_Button.Name = "block_add_Button"
        block_add_Button.Size = New Size(94, 31)
        block_add_Button.TabIndex = 72
        block_add_Button.Text = "Add"
        block_add_Button.UseVisualStyleBackColor = False
        ' 
        ' block_semester_TextBox
        ' 
        block_semester_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        block_semester_TextBox.Location = New Point(438, 237)
        block_semester_TextBox.Margin = New Padding(3, 4, 3, 4)
        block_semester_TextBox.Name = "block_semester_TextBox"
        block_semester_TextBox.Size = New Size(142, 29)
        block_semester_TextBox.TabIndex = 71
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label5.Location = New Point(354, 241)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 23)
        Label5.TabIndex = 70
        Label5.Text = "Semester"
        ' 
        ' block_studentid_TextBox
        ' 
        block_studentid_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        block_studentid_TextBox.Location = New Point(158, 237)
        block_studentid_TextBox.Margin = New Padding(3, 4, 3, 4)
        block_studentid_TextBox.Name = "block_studentid_TextBox"
        block_studentid_TextBox.Size = New Size(157, 29)
        block_studentid_TextBox.TabIndex = 69
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label4.Location = New Point(66, 241)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 23)
        Label4.TabIndex = 68
        Label4.Text = "Student ID"
        ' 
        ' block_programid_TextBox
        ' 
        block_programid_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        block_programid_TextBox.Location = New Point(699, 175)
        block_programid_TextBox.Margin = New Padding(3, 4, 3, 4)
        block_programid_TextBox.Name = "block_programid_TextBox"
        block_programid_TextBox.Size = New Size(137, 29)
        block_programid_TextBox.TabIndex = 67
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(601, 179)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 23)
        Label3.TabIndex = 66
        Label3.Text = "Program ID"
        ' 
        ' block_blockcode_TextBox
        ' 
        block_blockcode_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        block_blockcode_TextBox.Location = New Point(438, 175)
        block_blockcode_TextBox.Margin = New Padding(3, 4, 3, 4)
        block_blockcode_TextBox.Name = "block_blockcode_TextBox"
        block_blockcode_TextBox.Size = New Size(142, 29)
        block_blockcode_TextBox.TabIndex = 65
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label2.Location = New Point(340, 179)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 23)
        Label2.TabIndex = 64
        Label2.Text = "Block Code"
        ' 
        ' block_blockid_TextBox
        ' 
        block_blockid_TextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        block_blockid_TextBox.Location = New Point(158, 175)
        block_blockid_TextBox.Margin = New Padding(3, 4, 3, 4)
        block_blockid_TextBox.Name = "block_blockid_TextBox"
        block_blockid_TextBox.Size = New Size(157, 29)
        block_blockid_TextBox.TabIndex = 63
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label1.Location = New Point(84, 179)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 23)
        Label1.TabIndex = 62
        Label1.Text = "Block ID"
        ' 
        ' AddBlockPageforAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1566, 999)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Margin = New Padding(3, 4, 3, 4)
        Name = "AddBlockPageforAdmin"
        Text = "Add Block For Admin"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents addblock_back_Button As Button
    Friend WithEvents block_add_Button As Button
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
End Class
