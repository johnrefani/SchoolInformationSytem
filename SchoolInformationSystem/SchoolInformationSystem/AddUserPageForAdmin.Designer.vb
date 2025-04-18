<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUserPageForAdmin
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
        Label1 = New Label()
        UserID_TextBox = New TextBox()
        Label2 = New Label()
        UserType_ComboBox = New ComboBox()
        Label3 = New Label()
        Password_TextBox = New TextBox()
        Creation_Panel = New Panel()
        PictureBox1 = New PictureBox()
        Cancel_Button = New Button()
        SaveUser_Button = New Button()
        Creation_Panel.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(177, 185)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 25)
        Label1.TabIndex = 0
        Label1.Text = "ID Number"
        ' 
        ' UserID_TextBox
        ' 
        UserID_TextBox.Enabled = False
        UserID_TextBox.Location = New Point(283, 185)
        UserID_TextBox.Name = "UserID_TextBox"
        UserID_TextBox.Size = New Size(274, 31)
        UserID_TextBox.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(176, 145)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 25)
        Label2.TabIndex = 2
        Label2.Text = "User Type"
        ' 
        ' UserType_ComboBox
        ' 
        UserType_ComboBox.FormattingEnabled = True
        UserType_ComboBox.Items.AddRange(New Object() {"Student", "Instructor"})
        UserType_ComboBox.Location = New Point(282, 137)
        UserType_ComboBox.Name = "UserType_ComboBox"
        UserType_ComboBox.Size = New Size(274, 33)
        UserType_ComboBox.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(177, 236)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 25)
        Label3.TabIndex = 4
        Label3.Text = "Password"
        ' 
        ' Password_TextBox
        ' 
        Password_TextBox.Location = New Point(283, 236)
        Password_TextBox.Name = "Password_TextBox"
        Password_TextBox.Size = New Size(274, 31)
        Password_TextBox.TabIndex = 5
        ' 
        ' Creation_Panel
        ' 
        Creation_Panel.BackColor = SystemColors.GradientActiveCaption
        Creation_Panel.Controls.Add(PictureBox1)
        Creation_Panel.Controls.Add(Cancel_Button)
        Creation_Panel.Controls.Add(SaveUser_Button)
        Creation_Panel.Controls.Add(Password_TextBox)
        Creation_Panel.Controls.Add(Label3)
        Creation_Panel.Controls.Add(UserType_ComboBox)
        Creation_Panel.Controls.Add(Label2)
        Creation_Panel.Controls.Add(UserID_TextBox)
        Creation_Panel.Controls.Add(Label1)
        Creation_Panel.Location = New Point(-2, -1)
        Creation_Panel.Name = "Creation_Panel"
        Creation_Panel.Size = New Size(736, 466)
        Creation_Panel.TabIndex = 6
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.Control
        PictureBox1.Image = My.Resources.Resources.eye_closed
        PictureBox1.InitialImage = Nothing
        PictureBox1.Location = New Point(522, 241)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(31, 21)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Cancel_Button
        ' 
        Cancel_Button.Location = New Point(390, 302)
        Cancel_Button.Name = "Cancel_Button"
        Cancel_Button.Size = New Size(180, 48)
        Cancel_Button.TabIndex = 7
        Cancel_Button.Text = "Cancel"
        Cancel_Button.UseVisualStyleBackColor = True
        ' 
        ' SaveUser_Button
        ' 
        SaveUser_Button.Location = New Point(176, 302)
        SaveUser_Button.Name = "SaveUser_Button"
        SaveUser_Button.Size = New Size(180, 48)
        SaveUser_Button.TabIndex = 6
        SaveUser_Button.Text = "Save"
        SaveUser_Button.UseVisualStyleBackColor = True
        ' 
        ' AddUserPageForAdmin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(731, 466)
        Controls.Add(Creation_Panel)
        Name = "AddUserPageForAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add User"
        Creation_Panel.ResumeLayout(False)
        Creation_Panel.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents UserID_TextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents UserType_ComboBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Password_TextBox As TextBox
    Friend WithEvents Creation_Panel As Panel
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents SaveUser_Button As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
