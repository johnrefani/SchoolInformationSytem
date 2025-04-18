<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigSettings
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
        Server_TextBox = New TextBox()
        Save_Button = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Database_TextBox = New TextBox()
        Password_TextBox = New TextBox()
        UID_TextBox = New TextBox()
        Cancel_Button = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(194, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 25)
        Label1.TabIndex = 0
        Label1.Text = "Server"
        ' 
        ' Server_TextBox
        ' 
        Server_TextBox.Location = New Point(284, 85)
        Server_TextBox.Name = "Server_TextBox"
        Server_TextBox.Size = New Size(257, 31)
        Server_TextBox.TabIndex = 1
        ' 
        ' Save_Button
        ' 
        Save_Button.Location = New Point(194, 355)
        Save_Button.Name = "Save_Button"
        Save_Button.Size = New Size(149, 52)
        Save_Button.TabIndex = 2
        Save_Button.Text = "Save Changes"
        Save_Button.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(194, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 25)
        Label2.TabIndex = 3
        Label2.Text = "UID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(194, 200)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 25)
        Label3.TabIndex = 4
        Label3.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(194, 265)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 25)
        Label4.TabIndex = 5
        Label4.Text = "Database"
        ' 
        ' Database_TextBox
        ' 
        Database_TextBox.Location = New Point(284, 259)
        Database_TextBox.Name = "Database_TextBox"
        Database_TextBox.Size = New Size(257, 31)
        Database_TextBox.TabIndex = 6
        ' 
        ' Password_TextBox
        ' 
        Password_TextBox.Location = New Point(287, 194)
        Password_TextBox.Name = "Password_TextBox"
        Password_TextBox.Size = New Size(254, 31)
        Password_TextBox.TabIndex = 7
        ' 
        ' UID_TextBox
        ' 
        UID_TextBox.Location = New Point(284, 140)
        UID_TextBox.Name = "UID_TextBox"
        UID_TextBox.Size = New Size(257, 31)
        UID_TextBox.TabIndex = 8
        ' 
        ' Cancel_Button
        ' 
        Cancel_Button.Location = New Point(392, 355)
        Cancel_Button.Name = "Cancel_Button"
        Cancel_Button.Size = New Size(149, 52)
        Cancel_Button.TabIndex = 9
        Cancel_Button.Text = "Cancel"
        Cancel_Button.UseVisualStyleBackColor = True
        ' 
        ' ConfigSettings
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(736, 508)
        Controls.Add(Cancel_Button)
        Controls.Add(UID_TextBox)
        Controls.Add(Password_TextBox)
        Controls.Add(Database_TextBox)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Save_Button)
        Controls.Add(Server_TextBox)
        Controls.Add(Label1)
        Name = "ConfigSettings"
        Text = "ConfigSettings"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Server_TextBox As TextBox
    Friend WithEvents Save_Button As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Database_TextBox As TextBox
    Friend WithEvents Password_TextBox As TextBox
    Friend WithEvents UID_TextBox As TextBox
    Friend WithEvents Cancel_Button As Button
End Class
