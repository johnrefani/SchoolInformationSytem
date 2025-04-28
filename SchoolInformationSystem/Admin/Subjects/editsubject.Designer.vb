<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editsubject
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
        subunits = New TextBox()
        submax = New TextBox()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        subroomnum = New TextBox()
        subsched = New TextBox()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        subsection = New TextBox()
        Label12 = New Label()
        subdescription = New TextBox()
        Label4 = New Label()
        subinstructor = New TextBox()
        Label5 = New Label()
        subdepartment = New TextBox()
        Label7 = New Label()
        subgradelevel = New TextBox()
        Label3 = New Label()
        subcode = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        subtype = New ComboBox()
        subname = New TextBox()
        Label8 = New Label()
        subsave = New Button()
        cancelbutton = New Button()
        Label6 = New Label()
        subdelete = New Button()
        subsemester = New ComboBox()
        subday = New ComboBox()
        subid = New TextBox()
        SuspendLayout()
        ' 
        ' subunits
        ' 
        subunits.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        subunits.BorderStyle = BorderStyle.FixedSingle
        subunits.Location = New Point(531, 416)
        subunits.Name = "subunits"
        subunits.Size = New Size(230, 33)
        subunits.TabIndex = 132
        ' 
        ' submax
        ' 
        submax.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        submax.BorderStyle = BorderStyle.FixedSingle
        submax.Location = New Point(293, 416)
        submax.Name = "submax"
        submax.Size = New Size(213, 33)
        submax.TabIndex = 131
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(531, 378)
        Label13.Name = "Label13"
        Label13.Size = New Size(72, 25)
        Label13.TabIndex = 130
        Label13.Text = "UNITS"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(293, 378)
        Label14.Name = "Label14"
        Label14.Size = New Size(162, 25)
        Label14.TabIndex = 129
        Label14.Text = "MAX STUDENTS"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(18, 378)
        Label15.Name = "Label15"
        Label15.Size = New Size(51, 25)
        Label15.TabIndex = 127
        Label15.Text = "DAY"
        ' 
        ' subroomnum
        ' 
        subroomnum.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        subroomnum.BorderStyle = BorderStyle.FixedSingle
        subroomnum.Location = New Point(531, 324)
        subroomnum.Name = "subroomnum"
        subroomnum.Size = New Size(230, 33)
        subroomnum.TabIndex = 126
        ' 
        ' subsched
        ' 
        subsched.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        subsched.BorderStyle = BorderStyle.FixedSingle
        subsched.Location = New Point(786, 324)
        subsched.Name = "subsched"
        subsched.Size = New Size(207, 33)
        subsched.TabIndex = 125
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(788, 286)
        Label9.Name = "Label9"
        Label9.Size = New Size(168, 25)
        Label9.TabIndex = 124
        Label9.Text = "SCHEDULE TIME"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(531, 286)
        Label10.Name = "Label10"
        Label10.Size = New Size(160, 25)
        Label10.TabIndex = 122
        Label10.Text = "ROOM NUMBER"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(293, 286)
        Label11.Name = "Label11"
        Label11.Size = New Size(113, 25)
        Label11.TabIndex = 121
        Label11.Text = "SEMESTER"
        ' 
        ' subsection
        ' 
        subsection.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        subsection.BorderStyle = BorderStyle.FixedSingle
        subsection.Location = New Point(18, 324)
        subsection.Name = "subsection"
        subsection.Size = New Size(250, 33)
        subsection.TabIndex = 120
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(18, 286)
        Label12.Name = "Label12"
        Label12.Size = New Size(98, 25)
        Label12.TabIndex = 119
        Label12.Text = "SECTION"
        ' 
        ' subdescription
        ' 
        subdescription.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        subdescription.BorderStyle = BorderStyle.FixedSingle
        subdescription.Location = New Point(618, 227)
        subdescription.Name = "subdescription"
        subdescription.Size = New Size(375, 33)
        subdescription.TabIndex = 118
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(620, 189)
        Label4.Name = "Label4"
        Label4.Size = New Size(145, 25)
        Label4.TabIndex = 117
        Label4.Text = "DESCRIPTION"
        ' 
        ' subinstructor
        ' 
        subinstructor.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        subinstructor.BorderStyle = BorderStyle.FixedSingle
        subinstructor.Location = New Point(293, 227)
        subinstructor.Name = "subinstructor"
        subinstructor.Size = New Size(301, 33)
        subinstructor.TabIndex = 116
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(293, 189)
        Label5.Name = "Label5"
        Label5.Size = New Size(200, 25)
        Label5.TabIndex = 115
        Label5.Text = "INSTRUCTOR NAME"
        ' 
        ' subdepartment
        ' 
        subdepartment.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        subdepartment.BorderStyle = BorderStyle.FixedSingle
        subdepartment.Location = New Point(19, 227)
        subdepartment.Name = "subdepartment"
        subdepartment.Size = New Size(250, 33)
        subdepartment.TabIndex = 114
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(19, 189)
        Label7.Name = "Label7"
        Label7.Size = New Size(142, 25)
        Label7.TabIndex = 113
        Label7.Text = "DEPARTMENT"
        ' 
        ' subgradelevel
        ' 
        subgradelevel.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        subgradelevel.BorderStyle = BorderStyle.FixedSingle
        subgradelevel.Location = New Point(787, 133)
        subgradelevel.Name = "subgradelevel"
        subgradelevel.Size = New Size(207, 33)
        subgradelevel.TabIndex = 112
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(789, 95)
        Label3.Name = "Label3"
        Label3.Size = New Size(142, 25)
        Label3.TabIndex = 111
        Label3.Text = "GRADE LEVEL"
        ' 
        ' subcode
        ' 
        subcode.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        subcode.BorderStyle = BorderStyle.FixedSingle
        subcode.Location = New Point(294, 133)
        subcode.Name = "subcode"
        subcode.Size = New Size(213, 33)
        subcode.TabIndex = 110
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(531, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(152, 25)
        Label2.TabIndex = 109
        Label2.Text = "SUBJECT TYPE"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(294, 95)
        Label1.Name = "Label1"
        Label1.Size = New Size(158, 25)
        Label1.TabIndex = 108
        Label1.Text = "SUBJECT CODE"
        ' 
        ' subtype
        ' 
        subtype.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        subtype.ForeColor = Color.Black
        subtype.FormattingEnabled = True
        subtype.Location = New Point(532, 133)
        subtype.Name = "subtype"
        subtype.Size = New Size(230, 33)
        subtype.TabIndex = 107
        ' 
        ' subname
        ' 
        subname.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        subname.BorderStyle = BorderStyle.FixedSingle
        subname.Location = New Point(19, 133)
        subname.Name = "subname"
        subname.Size = New Size(250, 33)
        subname.TabIndex = 106
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(19, 95)
        Label8.Name = "Label8"
        Label8.Size = New Size(159, 25)
        Label8.TabIndex = 105
        Label8.Text = "SUBJECT NAME"
        ' 
        ' subsave
        ' 
        subsave.BackColor = Color.FromArgb(CByte(127), CByte(189), CByte(228))
        subsave.Cursor = Cursors.Hand
        subsave.FlatAppearance.BorderSize = 0
        subsave.FlatStyle = FlatStyle.Flat
        subsave.ForeColor = Color.White
        subsave.Location = New Point(633, 33)
        subsave.Name = "subsave"
        subsave.Size = New Size(98, 37)
        subsave.TabIndex = 104
        subsave.Text = "SAVE"
        subsave.UseVisualStyleBackColor = False
        ' 
        ' cancelbutton
        ' 
        cancelbutton.BackColor = Color.FromArgb(CByte(255), CByte(73), CByte(73))
        cancelbutton.Cursor = Cursors.Hand
        cancelbutton.FlatAppearance.BorderSize = 0
        cancelbutton.FlatStyle = FlatStyle.Flat
        cancelbutton.ForeColor = Color.White
        cancelbutton.Location = New Point(877, 33)
        cancelbutton.Name = "cancelbutton"
        cancelbutton.Size = New Size(111, 37)
        cancelbutton.TabIndex = 103
        cancelbutton.Text = "CANCEL"
        cancelbutton.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(14, 31)
        Label6.Name = "Label6"
        Label6.Size = New Size(273, 39)
        Label6.TabIndex = 102
        Label6.Text = "Manage Subject"
        ' 
        ' subdelete
        ' 
        subdelete.BackColor = Color.FromArgb(CByte(190), CByte(0), CByte(0))
        subdelete.Cursor = Cursors.Hand
        subdelete.FlatAppearance.BorderSize = 0
        subdelete.FlatStyle = FlatStyle.Flat
        subdelete.ForeColor = Color.White
        subdelete.Location = New Point(755, 33)
        subdelete.Name = "subdelete"
        subdelete.Size = New Size(98, 37)
        subdelete.TabIndex = 133
        subdelete.Text = "DELETE"
        subdelete.UseVisualStyleBackColor = False
        ' 
        ' subsemester
        ' 
        subsemester.FormattingEnabled = True
        subsemester.Location = New Point(293, 323)
        subsemester.Name = "subsemester"
        subsemester.Size = New Size(214, 33)
        subsemester.TabIndex = 134
        ' 
        ' subday
        ' 
        subday.FormattingEnabled = True
        subday.Location = New Point(19, 415)
        subday.Name = "subday"
        subday.Size = New Size(249, 33)
        subday.TabIndex = 135
        ' 
        ' subid
        ' 
        subid.Location = New Point(374, 31)
        subid.Name = "subid"
        subid.Size = New Size(100, 33)
        subid.TabIndex = 136
        subid.Visible = False
        ' 
        ' editsubject
        ' 
        AutoScaleDimensions = New SizeF(12F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1008, 481)
        Controls.Add(subid)
        Controls.Add(subday)
        Controls.Add(subsemester)
        Controls.Add(subdelete)
        Controls.Add(subunits)
        Controls.Add(submax)
        Controls.Add(Label13)
        Controls.Add(Label14)
        Controls.Add(Label15)
        Controls.Add(subroomnum)
        Controls.Add(subsched)
        Controls.Add(Label9)
        Controls.Add(Label10)
        Controls.Add(Label11)
        Controls.Add(subsection)
        Controls.Add(Label12)
        Controls.Add(subdescription)
        Controls.Add(Label4)
        Controls.Add(subinstructor)
        Controls.Add(Label5)
        Controls.Add(subdepartment)
        Controls.Add(Label7)
        Controls.Add(subgradelevel)
        Controls.Add(Label3)
        Controls.Add(subcode)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(subtype)
        Controls.Add(subname)
        Controls.Add(Label8)
        Controls.Add(subsave)
        Controls.Add(cancelbutton)
        Controls.Add(Label6)
        Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Margin = New Padding(5)
        Name = "editsubject"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin || Edit Subject"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents subunits As TextBox
    Friend WithEvents submax As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents subroomnum As TextBox
    Friend WithEvents subsched As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents subsection As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents subdescription As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents subinstructor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents subdepartment As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents subgradelevel As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents subcode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents subtype As ComboBox
    Friend WithEvents subname As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents subsave As Button
    Friend WithEvents cancelbutton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents subdelete As Button
    Friend WithEvents subsemester As ComboBox
    Friend WithEvents subday As ComboBox
    Friend WithEvents subid As TextBox
End Class
