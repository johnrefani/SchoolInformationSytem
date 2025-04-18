<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserManagementPage
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
        Back_Button = New Button()
        Label1 = New Label()
        UserID_TextBox = New TextBox()
        Panel1 = New Panel()
        UserType_ComboBox = New ComboBox()
        AddUser_Button = New Button()
        Label3 = New Label()
        SearchUser_Button = New Button()
        UserDGV = New DataGridView()
        Panel1.SuspendLayout()
        CType(UserDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Back_Button
        ' 
        Back_Button.Location = New Point(1715, 11)
        Back_Button.Margin = New Padding(2)
        Back_Button.Name = "Back_Button"
        Back_Button.Size = New Size(165, 39)
        Back_Button.TabIndex = 0
        Back_Button.Text = "Back"
        Back_Button.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(85, 201)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 15)
        Label1.TabIndex = 1
        Label1.Text = "ID Number"
        ' 
        ' UserID_TextBox
        ' 
        UserID_TextBox.Location = New Point(154, 198)
        UserID_TextBox.Margin = New Padding(2)
        UserID_TextBox.Name = "UserID_TextBox"
        UserID_TextBox.Size = New Size(145, 23)
        UserID_TextBox.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(UserType_ComboBox)
        Panel1.Controls.Add(AddUser_Button)
        Panel1.Controls.Add(Back_Button)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(SearchUser_Button)
        Panel1.Controls.Add(UserID_TextBox)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1904, 256)
        Panel1.TabIndex = 3
        ' 
        ' UserType_ComboBox
        ' 
        UserType_ComboBox.FormattingEnabled = True
        UserType_ComboBox.Items.AddRange(New Object() {"Student", "Instructor"})
        UserType_ComboBox.Location = New Point(404, 198)
        UserType_ComboBox.Margin = New Padding(2)
        UserType_ComboBox.Name = "UserType_ComboBox"
        UserType_ComboBox.Size = New Size(134, 23)
        UserType_ComboBox.TabIndex = 8
        ' 
        ' AddUser_Button
        ' 
        AddUser_Button.Location = New Point(1747, 198)
        AddUser_Button.Margin = New Padding(2)
        AddUser_Button.Name = "AddUser_Button"
        AddUser_Button.Size = New Size(133, 44)
        AddUser_Button.TabIndex = 4
        AddUser_Button.Text = "Add User"
        AddUser_Button.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(343, 201)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 15)
        Label3.TabIndex = 7
        Label3.Text = "User Type"
        ' 
        ' SearchUser_Button
        ' 
        SearchUser_Button.Location = New Point(558, 189)
        SearchUser_Button.Margin = New Padding(2)
        SearchUser_Button.Name = "SearchUser_Button"
        SearchUser_Button.Size = New Size(117, 38)
        SearchUser_Button.TabIndex = 3
        SearchUser_Button.Text = "Search"
        SearchUser_Button.UseVisualStyleBackColor = True
        ' 
        ' UserDGV
        ' 
        UserDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        UserDGV.Dock = DockStyle.Bottom
        UserDGV.Location = New Point(0, 260)
        UserDGV.Margin = New Padding(2)
        UserDGV.Name = "UserDGV"
        UserDGV.RowHeadersWidth = 62
        UserDGV.Size = New Size(1904, 781)
        UserDGV.TabIndex = 4
        ' 
        ' UserManagementPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1904, 1041)
        Controls.Add(UserDGV)
        Controls.Add(Panel1)
        Margin = New Padding(2)
        Name = "UserManagementPage"
        Text = "UserManagementPage"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(UserDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Back_Button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents UserID_TextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AddUser_Button As Button
    Friend WithEvents SearchUser_Button As Button
    Friend WithEvents UserDGV As DataGridView
    Friend WithEvents UserType_ComboBox As ComboBox
    Friend WithEvents Label3 As Label
End Class
