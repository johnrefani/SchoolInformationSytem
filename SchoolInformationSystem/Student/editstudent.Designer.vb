<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editstudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editstudent))
        savebutton = New Button()
        cancelbutton = New Button()
        Label6 = New Label()
        Label17 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label1 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        TextBox9 = New TextBox()
        TextBox10 = New TextBox()
        TextBox11 = New TextBox()
        TextBox12 = New TextBox()
        SuspendLayout()
        ' 
        ' savebutton
        ' 
        savebutton.BackColor = Color.FromArgb(CByte(127), CByte(189), CByte(228))
        savebutton.Cursor = Cursors.Hand
        savebutton.FlatAppearance.BorderSize = 0
        savebutton.FlatStyle = FlatStyle.Flat
        savebutton.Font = New Font("Tahoma", 15.75F)
        savebutton.ForeColor = Color.White
        savebutton.Location = New Point(690, 17)
        savebutton.Name = "savebutton"
        savebutton.Size = New Size(98, 37)
        savebutton.TabIndex = 60
        savebutton.Text = "SAVE"
        savebutton.UseVisualStyleBackColor = False
        ' 
        ' cancelbutton
        ' 
        cancelbutton.BackColor = Color.FromArgb(CByte(255), CByte(73), CByte(73))
        cancelbutton.Cursor = Cursors.Hand
        cancelbutton.FlatAppearance.BorderSize = 0
        cancelbutton.FlatStyle = FlatStyle.Flat
        cancelbutton.Font = New Font("Tahoma", 15.75F)
        cancelbutton.ForeColor = Color.White
        cancelbutton.Location = New Point(803, 17)
        cancelbutton.Name = "cancelbutton"
        cancelbutton.Size = New Size(111, 37)
        cancelbutton.TabIndex = 59
        cancelbutton.Text = "CANCEL"
        cancelbutton.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(12, 12)
        Label6.Name = "Label6"
        Label6.Size = New Size(329, 39)
        Label6.TabIndex = 61
        Label6.Text = "Edit Student Profile"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Tahoma", 14.25F)
        Label17.Location = New Point(366, 301)
        Label17.Name = "Label17"
        Label17.Size = New Size(116, 23)
        Label17.TabIndex = 73
        Label17.Text = "BIRTHPLACE"
        Label17.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Tahoma", 14.25F)
        Label14.Location = New Point(366, 406)
        Label14.Name = "Label14"
        Label14.Size = New Size(95, 23)
        Label14.TabIndex = 72
        Label14.Text = "RELIGION"
        Label14.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Tahoma", 14.25F)
        Label13.Location = New Point(25, 406)
        Label13.Name = "Label13"
        Label13.Size = New Size(158, 23)
        Label13.TabIndex = 71
        Label13.Text = "GUARDIAN NAME"
        Label13.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Tahoma", 14.25F)
        Label12.Location = New Point(661, 301)
        Label12.Name = "Label12"
        Label12.Size = New Size(127, 23)
        Label12.TabIndex = 70
        Label12.Text = "NATIONALITY"
        Label12.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Tahoma", 14.25F)
        Label11.Location = New Point(219, 301)
        Label11.Name = "Label11"
        Label11.Size = New Size(99, 23)
        Label11.TabIndex = 69
        Label11.Text = "BIRTHDAY"
        Label11.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Tahoma", 14.25F)
        Label10.Location = New Point(25, 301)
        Label10.Name = "Label10"
        Label10.Size = New Size(127, 23)
        Label10.TabIndex = 68
        Label10.Text = "GRADE LEVEL"
        Label10.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Tahoma", 14.25F)
        Label9.Location = New Point(352, 198)
        Label9.Name = "Label9"
        Label9.Size = New Size(92, 23)
        Label9.TabIndex = 67
        Label9.Text = "ADDRESS"
        Label9.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Tahoma", 14.25F)
        Label8.Location = New Point(25, 198)
        Label8.Name = "Label8"
        Label8.Size = New Size(151, 23)
        Label8.TabIndex = 66
        Label8.Text = "EMAIL ADDRESS"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 14.25F)
        Label7.Location = New Point(661, 96)
        Label7.Name = "Label7"
        Label7.Size = New Size(171, 23)
        Label7.TabIndex = 65
        Label7.Text = "CONTACT NUMBER"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 14.25F)
        Label1.Location = New Point(529, 96)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 23)
        Label1.TabIndex = 64
        Label1.Text = "AGE"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 14.25F)
        Label5.Location = New Point(352, 96)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 23)
        Label5.TabIndex = 63
        Label5.Text = "GENDER"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 14.25F)
        Label4.Location = New Point(25, 96)
        Label4.Name = "Label4"
        Label4.Size = New Size(106, 23)
        Label4.TabIndex = 62
        Label4.Text = "FULL NAME"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(25, 131)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(280, 33)
        TextBox1.TabIndex = 74
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(352, 131)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(114, 33)
        TextBox2.TabIndex = 75
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(529, 131)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(66, 33)
        TextBox3.TabIndex = 76
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(661, 131)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(239, 33)
        TextBox4.TabIndex = 77
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox5.Location = New Point(25, 237)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(280, 33)
        TextBox5.TabIndex = 78
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox6.Location = New Point(352, 237)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(548, 33)
        TextBox6.TabIndex = 79
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox7.Location = New Point(25, 341)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(166, 33)
        TextBox7.TabIndex = 80
        ' 
        ' TextBox8
        ' 
        TextBox8.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox8.Location = New Point(219, 341)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(122, 33)
        TextBox8.TabIndex = 81
        ' 
        ' TextBox9
        ' 
        TextBox9.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox9.Location = New Point(366, 341)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(272, 33)
        TextBox9.TabIndex = 82
        ' 
        ' TextBox10
        ' 
        TextBox10.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox10.Location = New Point(661, 341)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(239, 33)
        TextBox10.TabIndex = 83
        ' 
        ' TextBox11
        ' 
        TextBox11.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox11.Location = New Point(25, 444)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(280, 33)
        TextBox11.TabIndex = 84
        ' 
        ' TextBox12
        ' 
        TextBox12.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox12.Location = New Point(366, 444)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(240, 33)
        TextBox12.TabIndex = 85
        ' 
        ' editstudent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(936, 528)
        Controls.Add(TextBox12)
        Controls.Add(TextBox11)
        Controls.Add(TextBox10)
        Controls.Add(TextBox9)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label17)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label6)
        Controls.Add(savebutton)
        Controls.Add(cancelbutton)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "editstudent"
        Text = "Edit Student Profile"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents savebutton As Button
    Friend WithEvents cancelbutton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
End Class
