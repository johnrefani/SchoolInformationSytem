<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BlockList
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
        blocklist_add_Button = New Button()
        BlockDataGridView = New DataGridView()
        blocklist_search_Button = New Button()
        Panel1 = New Panel()
        block_semester_SearchField = New TextBox()
        Label5 = New Label()
        block_studentid_SearchField = New TextBox()
        Label4 = New Label()
        block_programid_SearchField = New TextBox()
        Label3 = New Label()
        block_bloblock_blockcode_SearchFieldckcode_TextBox = New TextBox()
        Label2 = New Label()
        block_blockid_SearchField = New TextBox()
        Label1 = New Label()
        blocklist_back_Button = New Button()
        Panel2 = New Panel()
        Label6 = New Label()
        CType(BlockDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' blocklist_add_Button
        ' 
        blocklist_add_Button.BackColor = Color.Maroon
        blocklist_add_Button.FlatStyle = FlatStyle.Popup
        blocklist_add_Button.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        blocklist_add_Button.ForeColor = SystemColors.ControlLightLight
        blocklist_add_Button.Location = New Point(1284, 256)
        blocklist_add_Button.Name = "blocklist_add_Button"
        blocklist_add_Button.Size = New Size(75, 29)
        blocklist_add_Button.TabIndex = 5
        blocklist_add_Button.Text = "Add"
        blocklist_add_Button.UseVisualStyleBackColor = False
        ' 
        ' BlockDataGridView
        ' 
        BlockDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        BlockDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        BlockDataGridView.Dock = DockStyle.Bottom
        BlockDataGridView.Location = New Point(11, 188)
        BlockDataGridView.Name = "BlockDataGridView"
        BlockDataGridView.Size = New Size(1348, 550)
        BlockDataGridView.TabIndex = 4
        ' 
        ' blocklist_search_Button
        ' 
        blocklist_search_Button.BackColor = Color.Maroon
        blocklist_search_Button.FlatStyle = FlatStyle.Popup
        blocklist_search_Button.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        blocklist_search_Button.ForeColor = SystemColors.ControlLightLight
        blocklist_search_Button.Location = New Point(577, 211)
        blocklist_search_Button.Name = "blocklist_search_Button"
        blocklist_search_Button.Size = New Size(75, 29)
        blocklist_search_Button.TabIndex = 7
        blocklist_search_Button.Text = "Search"
        blocklist_search_Button.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.Controls.Add(block_semester_SearchField)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(block_studentid_SearchField)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(block_programid_SearchField)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(block_bloblock_blockcode_SearchFieldckcode_TextBox)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(block_blockid_SearchField)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(10, 101)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(642, 108)
        Panel1.TabIndex = 20
        ' 
        ' block_semester_SearchField
        ' 
        block_semester_SearchField.Location = New Point(300, 57)
        block_semester_SearchField.Name = "block_semester_SearchField"
        block_semester_SearchField.Size = New Size(114, 25)
        block_semester_SearchField.TabIndex = 29
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(230, 60)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 17)
        Label5.TabIndex = 28
        Label5.Text = "Semester"
        ' 
        ' block_studentid_SearchField
        ' 
        block_studentid_SearchField.Location = New Point(110, 57)
        block_studentid_SearchField.Name = "block_studentid_SearchField"
        block_studentid_SearchField.Size = New Size(114, 25)
        block_studentid_SearchField.TabIndex = 27
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(31, 60)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 17)
        Label4.TabIndex = 26
        Label4.Text = "Student ID"
        ' 
        ' block_programid_SearchField
        ' 
        block_programid_SearchField.Location = New Point(498, 26)
        block_programid_SearchField.Name = "block_programid_SearchField"
        block_programid_SearchField.Size = New Size(114, 25)
        block_programid_SearchField.TabIndex = 25
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(414, 29)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 17)
        Label3.TabIndex = 24
        Label3.Text = "Program ID"
        ' 
        ' block_bloblock_blockcode_SearchFieldckcode_TextBox
        ' 
        block_bloblock_blockcode_SearchFieldckcode_TextBox.Location = New Point(294, 26)
        block_bloblock_blockcode_SearchFieldckcode_TextBox.Name = "block_bloblock_blockcode_SearchFieldckcode_TextBox"
        block_bloblock_blockcode_SearchFieldckcode_TextBox.Size = New Size(114, 25)
        block_bloblock_blockcode_SearchFieldckcode_TextBox.TabIndex = 23
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(213, 29)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 17)
        Label2.TabIndex = 22
        Label2.Text = "Block Code"
        ' 
        ' block_blockid_SearchField
        ' 
        block_blockid_SearchField.Location = New Point(94, 26)
        block_blockid_SearchField.Name = "block_blockid_SearchField"
        block_blockid_SearchField.Size = New Size(114, 25)
        block_blockid_SearchField.TabIndex = 21
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(31, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 17)
        Label1.TabIndex = 20
        Label1.Text = "Block ID"
        ' 
        ' blocklist_back_Button
        ' 
        blocklist_back_Button.BackColor = Color.Maroon
        blocklist_back_Button.FlatStyle = FlatStyle.Popup
        blocklist_back_Button.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        blocklist_back_Button.ForeColor = SystemColors.ControlLightLight
        blocklist_back_Button.Location = New Point(1285, 13)
        blocklist_back_Button.Name = "blocklist_back_Button"
        blocklist_back_Button.Size = New Size(75, 29)
        blocklist_back_Button.TabIndex = 21
        blocklist_back_Button.Text = "Back"
        blocklist_back_Button.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Maroon
        Panel2.Controls.Add(Label6)
        Panel2.Location = New Point(10, 73)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(642, 32)
        Panel2.TabIndex = 38
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Maroon
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ControlLightLight
        Label6.Location = New Point(19, 8)
        Label6.Name = "Label6"
        Label6.Size = New Size(40, 17)
        Label6.TabIndex = 40
        Label6.Text = "Filter"
        ' 
        ' BlockList
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.adminbg
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1370, 749)
        Controls.Add(Panel2)
        Controls.Add(blocklist_back_Button)
        Controls.Add(Panel1)
        Controls.Add(blocklist_search_Button)
        Controls.Add(blocklist_add_Button)
        Controls.Add(BlockDataGridView)
        Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Name = "BlockList"
        Padding = New Padding(11)
        Text = "Block List Page"
        WindowState = FormWindowState.Maximized
        CType(BlockDataGridView, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents blocklist_add_Button As Button
    Friend WithEvents BlockDataGridView As DataGridView
    Friend WithEvents blocklist_search_Button As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents block_semester_SearchField As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents block_studentid_SearchField As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents block_programid_SearchField As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents block_bloblock_blockcode_SearchFieldckcode_TextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents block_blockid_SearchField As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents blocklist_back_Button As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
End Class
