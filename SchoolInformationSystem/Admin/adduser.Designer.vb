<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adduser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adduser))
        savebutton = New Button()
        cancelbutton = New Button()
        Label6 = New Label()
        gendertextbox = New TextBox()
        Label11 = New Label()
        lastnametextbox = New TextBox()
        Label10 = New Label()
        middlenametextbox = New TextBox()
        Label9 = New Label()
        firsnametextbox = New TextBox()
        Label8 = New Label()
        Label1 = New Label()
        TextBox2 = New TextBox()
        Label2 = New Label()
        TextBox3 = New TextBox()
        Label3 = New Label()
        TextBox4 = New TextBox()
        Label4 = New Label()
        adduser_rolecombobox = New ComboBox()
        TextBox1 = New TextBox()
        Label20 = New Label()
        advisorytextbox = New TextBox()
        Label15 = New Label()
        nationalitytextbox = New TextBox()
        Label19 = New Label()
        civilstatustextbox = New TextBox()
        Label18 = New Label()
        departmenttextbox = New TextBox()
        Label14 = New Label()
        SuspendLayout()
        ' 
        ' savebutton
        ' 
        savebutton.BackColor = Color.FromArgb(CByte(127), CByte(189), CByte(228))
        savebutton.Cursor = Cursors.Hand
        savebutton.FlatAppearance.BorderSize = 0
        savebutton.FlatStyle = FlatStyle.Flat
        savebutton.ForeColor = Color.White
        savebutton.Location = New Point(776, 14)
        savebutton.Name = "savebutton"
        savebutton.Size = New Size(98, 37)
        savebutton.TabIndex = 61
        savebutton.Text = "SAVE"
        savebutton.UseVisualStyleBackColor = False
        ' 
        ' cancelbutton
        ' 
        cancelbutton.BackColor = Color.FromArgb(CByte(255), CByte(73), CByte(73))
        cancelbutton.Cursor = Cursors.Hand
        cancelbutton.FlatAppearance.BorderSize = 0
        cancelbutton.FlatStyle = FlatStyle.Flat
        cancelbutton.ForeColor = Color.White
        cancelbutton.Location = New Point(889, 14)
        cancelbutton.Name = "cancelbutton"
        cancelbutton.Size = New Size(111, 37)
        cancelbutton.TabIndex = 60
        cancelbutton.Text = "CANCEL"
        cancelbutton.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(26, 12)
        Label6.Name = "Label6"
        Label6.Size = New Size(195, 39)
        Label6.TabIndex = 59
        Label6.Text = "Edit Profile"
        ' 
        ' gendertextbox
        ' 
        gendertextbox.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        gendertextbox.BorderStyle = BorderStyle.FixedSingle
        gendertextbox.Location = New Point(869, 117)
        gendertextbox.Name = "gendertextbox"
        gendertextbox.Size = New Size(111, 33)
        gendertextbox.TabIndex = 69
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(871, 79)
        Label11.Name = "Label11"
        Label11.Size = New Size(91, 25)
        Label11.TabIndex = 68
        Label11.Text = "GENDER"
        ' 
        ' lastnametextbox
        ' 
        lastnametextbox.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        lastnametextbox.BorderStyle = BorderStyle.FixedSingle
        lastnametextbox.Location = New Point(564, 117)
        lastnametextbox.Name = "lastnametextbox"
        lastnametextbox.Size = New Size(286, 33)
        lastnametextbox.TabIndex = 67
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(564, 79)
        Label10.Name = "Label10"
        Label10.Size = New Size(119, 25)
        Label10.TabIndex = 66
        Label10.Text = "FULL NAME"
        ' 
        ' middlenametextbox
        ' 
        middlenametextbox.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        middlenametextbox.BorderStyle = BorderStyle.FixedSingle
        middlenametextbox.Location = New Point(295, 117)
        middlenametextbox.Name = "middlenametextbox"
        middlenametextbox.Size = New Size(250, 33)
        middlenametextbox.TabIndex = 65
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(295, 79)
        Label9.Name = "Label9"
        Label9.Size = New Size(122, 25)
        Label9.TabIndex = 64
        Label9.Text = "PASSWORD"
        ' 
        ' firsnametextbox
        ' 
        firsnametextbox.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        firsnametextbox.BorderStyle = BorderStyle.FixedSingle
        firsnametextbox.Location = New Point(26, 117)
        firsnametextbox.Name = "firsnametextbox"
        firsnametextbox.Size = New Size(250, 33)
        firsnametextbox.TabIndex = 63
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(26, 79)
        Label8.Name = "Label8"
        Label8.Size = New Size(118, 25)
        Label8.TabIndex = 62
        Label8.Text = "USERNAME"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(871, 179)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 25)
        Label1.TabIndex = 76
        Label1.Text = "GENDER"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(564, 217)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(286, 33)
        TextBox2.TabIndex = 75
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(564, 179)
        Label2.Name = "Label2"
        Label2.Size = New Size(123, 25)
        Label2.TabIndex = 74
        Label2.Text = "ID NUMBER"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Location = New Point(295, 217)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(250, 33)
        TextBox3.TabIndex = 73
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(295, 179)
        Label3.Name = "Label3"
        Label3.Size = New Size(193, 25)
        Label3.TabIndex = 72
        Label3.Text = "CONTACT NUMBER"
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Location = New Point(26, 217)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(250, 33)
        TextBox4.TabIndex = 71
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(26, 179)
        Label4.Name = "Label4"
        Label4.Size = New Size(168, 25)
        Label4.TabIndex = 70
        Label4.Text = "EMAIL ADDRESS"
        ' 
        ' adduser_rolecombobox
        ' 
        adduser_rolecombobox.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        adduser_rolecombobox.FormattingEnabled = True
        adduser_rolecombobox.Location = New Point(871, 217)
        adduser_rolecombobox.Name = "adduser_rolecombobox"
        adduser_rolecombobox.Size = New Size(109, 33)
        adduser_rolecombobox.TabIndex = 77
        adduser_rolecombobox.Text = "Role"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(564, 318)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(416, 33)
        TextBox1.TabIndex = 81
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(564, 280)
        Label20.Name = "Label20"
        Label20.Size = New Size(108, 25)
        Label20.TabIndex = 80
        Label20.Text = "POSITION"
        ' 
        ' advisorytextbox
        ' 
        advisorytextbox.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        advisorytextbox.BorderStyle = BorderStyle.FixedSingle
        advisorytextbox.Location = New Point(26, 318)
        advisorytextbox.Name = "advisorytextbox"
        advisorytextbox.Size = New Size(519, 33)
        advisorytextbox.TabIndex = 79
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(26, 280)
        Label15.Name = "Label15"
        Label15.Size = New Size(102, 25)
        Label15.TabIndex = 78
        Label15.Text = "ADDRESS"
        ' 
        ' nationalitytextbox
        ' 
        nationalitytextbox.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        nationalitytextbox.BorderStyle = BorderStyle.FixedSingle
        nationalitytextbox.Location = New Point(632, 420)
        nationalitytextbox.Name = "nationalitytextbox"
        nationalitytextbox.Size = New Size(196, 33)
        nationalitytextbox.TabIndex = 87
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(633, 382)
        Label19.Name = "Label19"
        Label19.Size = New Size(110, 25)
        Label19.TabIndex = 86
        Label19.Text = "IS ACTIVE"
        ' 
        ' civilstatustextbox
        ' 
        civilstatustextbox.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        civilstatustextbox.BorderStyle = BorderStyle.FixedSingle
        civilstatustextbox.Location = New Point(361, 420)
        civilstatustextbox.Name = "civilstatustextbox"
        civilstatustextbox.Size = New Size(245, 33)
        civilstatustextbox.TabIndex = 85
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(363, 382)
        Label18.Name = "Label18"
        Label18.Size = New Size(151, 25)
        Label18.TabIndex = 84
        Label18.Text = "ACCESS LEVEL"
        ' 
        ' departmenttextbox
        ' 
        departmenttextbox.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        departmenttextbox.BorderStyle = BorderStyle.FixedSingle
        departmenttextbox.Location = New Point(26, 420)
        departmenttextbox.Name = "departmenttextbox"
        departmenttextbox.Size = New Size(309, 33)
        departmenttextbox.TabIndex = 83
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(26, 382)
        Label14.Name = "Label14"
        Label14.Size = New Size(188, 25)
        Label14.TabIndex = 82
        Label14.Text = "ASSIGNED OFFICE"
        ' 
        ' adduser
        ' 
        AutoScaleDimensions = New SizeF(12F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1008, 488)
        Controls.Add(nationalitytextbox)
        Controls.Add(Label19)
        Controls.Add(civilstatustextbox)
        Controls.Add(Label18)
        Controls.Add(departmenttextbox)
        Controls.Add(Label14)
        Controls.Add(TextBox1)
        Controls.Add(Label20)
        Controls.Add(advisorytextbox)
        Controls.Add(Label15)
        Controls.Add(adduser_rolecombobox)
        Controls.Add(Label1)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(TextBox3)
        Controls.Add(Label3)
        Controls.Add(TextBox4)
        Controls.Add(Label4)
        Controls.Add(gendertextbox)
        Controls.Add(Label11)
        Controls.Add(lastnametextbox)
        Controls.Add(Label10)
        Controls.Add(middlenametextbox)
        Controls.Add(Label9)
        Controls.Add(firsnametextbox)
        Controls.Add(Label8)
        Controls.Add(savebutton)
        Controls.Add(cancelbutton)
        Controls.Add(Label6)
        Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5)
        Name = "adduser"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin || Add User"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents savebutton As Button
    Friend WithEvents cancelbutton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents gendertextbox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lastnametextbox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents middlenametextbox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents firsnametextbox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents adduser_rolecombobox As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents advisorytextbox As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents nationalitytextbox As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents civilstatustextbox As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents departmenttextbox As TextBox
    Friend WithEvents Label14 As Label
End Class
