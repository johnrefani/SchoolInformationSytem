<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditUserPage
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
        Label2 = New Label()
        Label3 = New Label()
        UserType_ComboBox = New ComboBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        SaveChanges_Button = New Button()
        Cancel_Button = New Button()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(237, 149)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 25)
        Label1.TabIndex = 0
        Label1.Text = "ID Number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(237, 190)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 25)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(237, 108)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 25)
        Label3.TabIndex = 2
        Label3.Text = "User Type" & vbCrLf
        ' 
        ' UserType_ComboBox
        ' 
        UserType_ComboBox.FormattingEnabled = True
        UserType_ComboBox.Items.AddRange(New Object() {"Student", "Instructor"})
        UserType_ComboBox.Location = New Point(343, 105)
        UserType_ComboBox.Name = "UserType_ComboBox"
        UserType_ComboBox.Size = New Size(182, 33)
        UserType_ComboBox.TabIndex = 3
        ' 
        ' TextBox1
        ' 
        TextBox1.Enabled = False
        TextBox1.Location = New Point(343, 149)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(182, 31)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(343, 192)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(182, 31)
        TextBox2.TabIndex = 5
        ' 
        ' SaveChanges_Button
        ' 
        SaveChanges_Button.Location = New Point(237, 270)
        SaveChanges_Button.Name = "SaveChanges_Button"
        SaveChanges_Button.Size = New Size(170, 46)
        SaveChanges_Button.TabIndex = 6
        SaveChanges_Button.Text = "Save Changes"
        SaveChanges_Button.UseVisualStyleBackColor = True
        ' 
        ' Cancel_Button
        ' 
        Cancel_Button.Location = New Point(413, 270)
        Cancel_Button.Name = "Cancel_Button"
        Cancel_Button.Size = New Size(112, 46)
        Cancel_Button.TabIndex = 7
        Cancel_Button.Text = "Cancel"
        Cancel_Button.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.GradientActiveCaption
        Panel1.Controls.Add(Cancel_Button)
        Panel1.Controls.Add(SaveChanges_Button)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(UserType_ComboBox)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(3, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(798, 457)
        Panel1.TabIndex = 8
        ' 
        ' EditUserPage
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Name = "EditUserPage"
        Text = "EditUserPage"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents UserType_ComboBox As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents SaveChanges_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents Panel1 As Panel
End Class
