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
        gender = New TextBox()
        Label11 = New Label()
        fullname = New TextBox()
        Label10 = New Label()
        password = New TextBox()
        Label9 = New Label()
        username = New TextBox()
        Label8 = New Label()
        Label1 = New Label()
        idnum = New TextBox()
        Label2 = New Label()
        contact = New TextBox()
        Label3 = New Label()
        email = New TextBox()
        Label4 = New Label()
        role = New ComboBox()
        position = New TextBox()
        Label20 = New Label()
        address = New TextBox()
        Label15 = New Label()
        active = New TextBox()
        Label19 = New Label()
        accesslevel = New TextBox()
        Label18 = New Label()
        office = New TextBox()
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
        Label6.Size = New Size(161, 39)
        Label6.TabIndex = 59
        Label6.Text = "Add User"
        ' 
        ' gender
        ' 
        gender.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        gender.BorderStyle = BorderStyle.FixedSingle
        gender.Location = New Point(869, 117)
        gender.Name = "gender"
        gender.Size = New Size(111, 33)
        gender.TabIndex = 4
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
        ' fullname
        ' 
        fullname.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        fullname.BorderStyle = BorderStyle.FixedSingle
        fullname.Location = New Point(564, 117)
        fullname.Name = "fullname"
        fullname.Size = New Size(286, 33)
        fullname.TabIndex = 3
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
        ' password
        ' 
        password.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        password.BorderStyle = BorderStyle.FixedSingle
        password.Location = New Point(295, 117)
        password.Name = "password"
        password.Size = New Size(250, 33)
        password.TabIndex = 2
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
        ' username
        ' 
        username.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        username.BorderStyle = BorderStyle.FixedSingle
        username.Location = New Point(26, 117)
        username.Name = "username"
        username.Size = New Size(250, 33)
        username.TabIndex = 1
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
        Label1.Size = New Size(52, 25)
        Label1.TabIndex = 76
        Label1.Text = "Role"
        ' 
        ' idnum
        ' 
        idnum.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        idnum.BorderStyle = BorderStyle.FixedSingle
        idnum.Location = New Point(564, 217)
        idnum.Name = "idnum"
        idnum.Size = New Size(286, 33)
        idnum.TabIndex = 7
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
        ' contact
        ' 
        contact.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        contact.BorderStyle = BorderStyle.FixedSingle
        contact.Location = New Point(295, 217)
        contact.Name = "contact"
        contact.Size = New Size(250, 33)
        contact.TabIndex = 6
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
        ' email
        ' 
        email.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        email.BorderStyle = BorderStyle.FixedSingle
        email.Location = New Point(26, 217)
        email.Name = "email"
        email.Size = New Size(250, 33)
        email.TabIndex = 5
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
        ' role
        ' 
        role.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        role.FormattingEnabled = True
        role.Items.AddRange(New Object() {"Admin", "Instructor", "Student"})
        role.Location = New Point(871, 217)
        role.Name = "role"
        role.Size = New Size(109, 33)
        role.TabIndex = 8
        role.Text = "Select"
        ' 
        ' position
        ' 
        position.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        position.BorderStyle = BorderStyle.FixedSingle
        position.Location = New Point(564, 318)
        position.Name = "position"
        position.Size = New Size(416, 33)
        position.TabIndex = 10
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
        ' address
        ' 
        address.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        address.BorderStyle = BorderStyle.FixedSingle
        address.Location = New Point(26, 318)
        address.Name = "address"
        address.Size = New Size(519, 33)
        address.TabIndex = 9
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
        ' active
        ' 
        active.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        active.BorderStyle = BorderStyle.FixedSingle
        active.Location = New Point(632, 420)
        active.Name = "active"
        active.Size = New Size(196, 33)
        active.TabIndex = 13
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
        ' accesslevel
        ' 
        accesslevel.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        accesslevel.BorderStyle = BorderStyle.FixedSingle
        accesslevel.Location = New Point(361, 420)
        accesslevel.Name = "accesslevel"
        accesslevel.Size = New Size(245, 33)
        accesslevel.TabIndex = 12
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
        ' office
        ' 
        office.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        office.BorderStyle = BorderStyle.FixedSingle
        office.Location = New Point(26, 420)
        office.Name = "office"
        office.Size = New Size(309, 33)
        office.TabIndex = 11
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
        Controls.Add(active)
        Controls.Add(Label19)
        Controls.Add(accesslevel)
        Controls.Add(Label18)
        Controls.Add(office)
        Controls.Add(Label14)
        Controls.Add(position)
        Controls.Add(Label20)
        Controls.Add(address)
        Controls.Add(Label15)
        Controls.Add(role)
        Controls.Add(Label1)
        Controls.Add(idnum)
        Controls.Add(Label2)
        Controls.Add(contact)
        Controls.Add(Label3)
        Controls.Add(email)
        Controls.Add(Label4)
        Controls.Add(gender)
        Controls.Add(Label11)
        Controls.Add(fullname)
        Controls.Add(Label10)
        Controls.Add(password)
        Controls.Add(Label9)
        Controls.Add(username)
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
    Friend WithEvents gender As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents fullname As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents password As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents username As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents idnum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents contact As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents role As ComboBox
    Friend WithEvents position As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents address As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents active As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents accesslevel As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents office As TextBox
    Friend WithEvents Label14 As Label
End Class
