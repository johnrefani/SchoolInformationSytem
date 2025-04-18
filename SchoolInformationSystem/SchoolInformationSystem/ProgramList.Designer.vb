<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProgramList
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
        programlist_search_Button = New Button()
        programlist_add_Button = New Button()
        ProgramDataGridView = New DataGridView()
        Panel1 = New Panel()
        program_durationyears_SearchField = New TextBox()
        program_programhead_SearchField = New TextBox()
        program_departmentid_SearchField = New TextBox()
        program_programname_SearchField = New TextBox()
        program_programcode_SearchField = New TextBox()
        program_programid_SearchField = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Label7 = New Label()
        program_back_Button = New Button()
        CType(ProgramDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' programlist_search_Button
        ' 
        programlist_search_Button.BackColor = Color.Maroon
        programlist_search_Button.FlatStyle = FlatStyle.Popup
        programlist_search_Button.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        programlist_search_Button.ForeColor = SystemColors.ControlLightLight
        programlist_search_Button.Location = New Point(617, 237)
        programlist_search_Button.Name = "programlist_search_Button"
        programlist_search_Button.Size = New Size(94, 34)
        programlist_search_Button.TabIndex = 15
        programlist_search_Button.Text = "Search"
        programlist_search_Button.UseVisualStyleBackColor = False
        ' 
        ' programlist_add_Button
        ' 
        programlist_add_Button.BackColor = Color.Maroon
        programlist_add_Button.FlatStyle = FlatStyle.Popup
        programlist_add_Button.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        programlist_add_Button.ForeColor = SystemColors.ControlLightLight
        programlist_add_Button.Location = New Point(1722, 306)
        programlist_add_Button.Name = "programlist_add_Button"
        programlist_add_Button.Size = New Size(172, 48)
        programlist_add_Button.TabIndex = 13
        programlist_add_Button.Text = "Add"
        programlist_add_Button.UseVisualStyleBackColor = False
        ' 
        ' ProgramDataGridView
        ' 
        ProgramDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ProgramDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ProgramDataGridView.Dock = DockStyle.Bottom
        ProgramDataGridView.Location = New Point(10, 231)
        ProgramDataGridView.Name = "ProgramDataGridView"
        ProgramDataGridView.RowHeadersWidth = 62
        ProgramDataGridView.Size = New Size(1664, 550)
        ProgramDataGridView.TabIndex = 12
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.Controls.Add(program_durationyears_SearchField)
        Panel1.Controls.Add(program_programhead_SearchField)
        Panel1.Controls.Add(program_departmentid_SearchField)
        Panel1.Controls.Add(program_programname_SearchField)
        Panel1.Controls.Add(program_programcode_SearchField)
        Panel1.Controls.Add(program_programid_SearchField)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(68, 114)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(644, 126)
        Panel1.TabIndex = 29
        ' 
        ' program_durationyears_SearchField
        ' 
        program_durationyears_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        program_durationyears_SearchField.Location = New Point(532, 66)
        program_durationyears_SearchField.Name = "program_durationyears_SearchField"
        program_durationyears_SearchField.Size = New Size(100, 25)
        program_durationyears_SearchField.TabIndex = 40
        ' 
        ' program_programhead_SearchField
        ' 
        program_programhead_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        program_programhead_SearchField.Location = New Point(522, 35)
        program_programhead_SearchField.Name = "program_programhead_SearchField"
        program_programhead_SearchField.Size = New Size(110, 25)
        program_programhead_SearchField.TabIndex = 39
        ' 
        ' program_departmentid_SearchField
        ' 
        program_departmentid_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        program_departmentid_SearchField.Location = New Point(323, 66)
        program_departmentid_SearchField.Name = "program_departmentid_SearchField"
        program_departmentid_SearchField.Size = New Size(100, 25)
        program_departmentid_SearchField.TabIndex = 38
        ' 
        ' program_programname_SearchField
        ' 
        program_programname_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        program_programname_SearchField.Location = New Point(117, 35)
        program_programname_SearchField.Name = "program_programname_SearchField"
        program_programname_SearchField.Size = New Size(100, 25)
        program_programname_SearchField.TabIndex = 37
        ' 
        ' program_programcode_SearchField
        ' 
        program_programcode_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        program_programcode_SearchField.Location = New Point(113, 66)
        program_programcode_SearchField.Name = "program_programcode_SearchField"
        program_programcode_SearchField.Size = New Size(100, 25)
        program_programcode_SearchField.TabIndex = 36
        ' 
        ' program_programid_SearchField
        ' 
        program_programid_SearchField.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        program_programid_SearchField.Location = New Point(313, 35)
        program_programid_SearchField.Name = "program_programid_SearchField"
        program_programid_SearchField.Size = New Size(100, 25)
        program_programid_SearchField.TabIndex = 35
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label6.Location = New Point(429, 69)
        Label6.Name = "Label6"
        Label6.Size = New Size(97, 17)
        Label6.TabIndex = 34
        Label6.Text = "Duration Years"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label5.Location = New Point(219, 69)
        Label5.Name = "Label5"
        Label5.Size = New Size(98, 17)
        Label5.TabIndex = 33
        Label5.Text = "Department ID"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label4.Location = New Point(14, 69)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 17)
        Label4.TabIndex = 32
        Label4.Text = "Program Code"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(419, 38)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 17)
        Label3.TabIndex = 31
        Label3.Text = "Program Head"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label2.Location = New Point(13, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 17)
        Label2.TabIndex = 30
        Label2.Text = "Program Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label1.Location = New Point(229, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 17)
        Label1.TabIndex = 29
        Label1.Text = "Program ID"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Maroon
        Panel2.Controls.Add(Label7)
        Panel2.Location = New Point(68, 86)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(644, 32)
        Panel2.TabIndex = 38
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Maroon
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ControlLightLight
        Label7.Location = New Point(19, 8)
        Label7.Name = "Label7"
        Label7.Size = New Size(40, 17)
        Label7.TabIndex = 40
        Label7.Text = "Filter"
        ' 
        ' program_back_Button
        ' 
        program_back_Button.BackColor = Color.Maroon
        program_back_Button.FlatStyle = FlatStyle.Popup
        program_back_Button.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        program_back_Button.ForeColor = SystemColors.ControlLightLight
        program_back_Button.Location = New Point(1722, 27)
        program_back_Button.Name = "program_back_Button"
        program_back_Button.Size = New Size(169, 47)
        program_back_Button.TabIndex = 39
        program_back_Button.Text = "Back"
        program_back_Button.UseVisualStyleBackColor = False
        ' 
        ' ProgramList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.adminbg
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1684, 791)
        Controls.Add(program_back_Button)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(programlist_search_Button)
        Controls.Add(programlist_add_Button)
        Controls.Add(ProgramDataGridView)
        Name = "ProgramList"
        Padding = New Padding(10, 10, 10, 10)
        Text = "ProgramList"
        WindowState = FormWindowState.Maximized
        CType(ProgramDataGridView, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents programlist_search_Button As Button
    Friend WithEvents programlist_add_Button As Button
    Friend WithEvents ProgramDataGridView As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents program_durationyears_SearchField As TextBox
    Friend WithEvents program_programhead_SearchField As TextBox
    Friend WithEvents program_departmentid_SearchField As TextBox
    Friend WithEvents program_programname_SearchField As TextBox
    Friend WithEvents program_programcode_SearchField As TextBox
    Friend WithEvents program_programid_SearchField As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents program_back_Button As Button
End Class
