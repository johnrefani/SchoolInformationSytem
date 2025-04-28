<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addsubject
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
        subsavebutton = New Button()
        cancelbutton = New Button()
        Label6 = New Label()
        subday = New ComboBox()
        subsemester = New ComboBox()
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
        SuspendLayout()
        ' 
        ' subsavebutton
        ' 
        subsavebutton.BackColor = Color.FromArgb(CByte(127), CByte(189), CByte(228))
        subsavebutton.Cursor = Cursors.Hand
        subsavebutton.FlatAppearance.BorderSize = 0
        subsavebutton.FlatStyle = FlatStyle.Flat
        subsavebutton.ForeColor = Color.White
        subsavebutton.Location = New Point(762, 11)
        subsavebutton.Name = "subsavebutton"
        subsavebutton.Size = New Size(98, 37)
        subsavebutton.TabIndex = 67
        subsavebutton.Text = "SAVE"
        subsavebutton.UseVisualStyleBackColor = False
        ' 
        ' cancelbutton
        ' 
        cancelbutton.BackColor = Color.FromArgb(CByte(255), CByte(73), CByte(73))
        cancelbutton.Cursor = Cursors.Hand
        cancelbutton.FlatAppearance.BorderSize = 0
        cancelbutton.FlatStyle = FlatStyle.Flat
        cancelbutton.ForeColor = Color.White
        cancelbutton.Location = New Point(875, 11)
        cancelbutton.Name = "cancelbutton"
        cancelbutton.Size = New Size(111, 37)
        cancelbutton.TabIndex = 66
        cancelbutton.Text = "CANCEL"
        cancelbutton.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(12, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(209, 39)
        Label6.TabIndex = 65
        Label6.Text = "Add Subject"
        ' 
        ' subday
        ' 
        subday.FormattingEnabled = True
        subday.Location = New Point(17, 383)
        subday.Name = "subday"
        subday.Size = New Size(249, 33)
        subday.TabIndex = 163
        ' 
        ' subsemester
        ' 
        subsemester.FormattingEnabled = True
        subsemester.Location = New Point(291, 291)
        subsemester.Name = "subsemester"
        subsemester.Size = New Size(214, 33)
        subsemester.TabIndex = 162
        ' 
        ' subunits
        ' 
        subunits.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        subunits.BorderStyle = BorderStyle.FixedSingle
        subunits.Location = New Point(529, 384)
        subunits.Name = "subunits"
        subunits.Size = New Size(230, 33)
        subunits.TabIndex = 161
        ' 
        ' submax
        ' 
        submax.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        submax.BorderStyle = BorderStyle.FixedSingle
        submax.Location = New Point(291, 384)
        submax.Name = "submax"
        submax.Size = New Size(213, 33)
        submax.TabIndex = 160
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(529, 346)
        Label13.Name = "Label13"
        Label13.Size = New Size(72, 25)
        Label13.TabIndex = 159
        Label13.Text = "UNITS"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(291, 346)
        Label14.Name = "Label14"
        Label14.Size = New Size(162, 25)
        Label14.TabIndex = 158
        Label14.Text = "MAX STUDENTS"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(16, 346)
        Label15.Name = "Label15"
        Label15.Size = New Size(51, 25)
        Label15.TabIndex = 157
        Label15.Text = "DAY"
        ' 
        ' subroomnum
        ' 
        subroomnum.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        subroomnum.BorderStyle = BorderStyle.FixedSingle
        subroomnum.Location = New Point(529, 292)
        subroomnum.Name = "subroomnum"
        subroomnum.Size = New Size(230, 33)
        subroomnum.TabIndex = 156
        ' 
        ' subsched
        ' 
        subsched.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        subsched.BorderStyle = BorderStyle.FixedSingle
        subsched.Location = New Point(784, 292)
        subsched.Name = "subsched"
        subsched.Size = New Size(207, 33)
        subsched.TabIndex = 155
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(786, 254)
        Label9.Name = "Label9"
        Label9.Size = New Size(168, 25)
        Label9.TabIndex = 154
        Label9.Text = "SCHEDULE TIME"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(529, 254)
        Label10.Name = "Label10"
        Label10.Size = New Size(160, 25)
        Label10.TabIndex = 153
        Label10.Text = "ROOM NUMBER"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(291, 254)
        Label11.Name = "Label11"
        Label11.Size = New Size(113, 25)
        Label11.TabIndex = 152
        Label11.Text = "SEMESTER"
        ' 
        ' subsection
        ' 
        subsection.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        subsection.BorderStyle = BorderStyle.FixedSingle
        subsection.Location = New Point(16, 292)
        subsection.Name = "subsection"
        subsection.Size = New Size(250, 33)
        subsection.TabIndex = 151
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(16, 254)
        Label12.Name = "Label12"
        Label12.Size = New Size(98, 25)
        Label12.TabIndex = 150
        Label12.Text = "SECTION"
        ' 
        ' subdescription
        ' 
        subdescription.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        subdescription.BorderStyle = BorderStyle.FixedSingle
        subdescription.Location = New Point(616, 195)
        subdescription.Name = "subdescription"
        subdescription.Size = New Size(375, 33)
        subdescription.TabIndex = 149
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(618, 157)
        Label4.Name = "Label4"
        Label4.Size = New Size(145, 25)
        Label4.TabIndex = 148
        Label4.Text = "DESCRIPTION"
        ' 
        ' subinstructor
        ' 
        subinstructor.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        subinstructor.BorderStyle = BorderStyle.FixedSingle
        subinstructor.Location = New Point(291, 195)
        subinstructor.Name = "subinstructor"
        subinstructor.Size = New Size(301, 33)
        subinstructor.TabIndex = 147
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(291, 157)
        Label5.Name = "Label5"
        Label5.Size = New Size(200, 25)
        Label5.TabIndex = 146
        Label5.Text = "INSTRUCTOR NAME"
        ' 
        ' subdepartment
        ' 
        subdepartment.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        subdepartment.BorderStyle = BorderStyle.FixedSingle
        subdepartment.Location = New Point(17, 195)
        subdepartment.Name = "subdepartment"
        subdepartment.Size = New Size(250, 33)
        subdepartment.TabIndex = 145
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(17, 157)
        Label7.Name = "Label7"
        Label7.Size = New Size(142, 25)
        Label7.TabIndex = 144
        Label7.Text = "DEPARTMENT"
        ' 
        ' subgradelevel
        ' 
        subgradelevel.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        subgradelevel.BorderStyle = BorderStyle.FixedSingle
        subgradelevel.Location = New Point(785, 101)
        subgradelevel.Name = "subgradelevel"
        subgradelevel.Size = New Size(207, 33)
        subgradelevel.TabIndex = 143
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(787, 63)
        Label3.Name = "Label3"
        Label3.Size = New Size(142, 25)
        Label3.TabIndex = 142
        Label3.Text = "GRADE LEVEL"
        ' 
        ' subcode
        ' 
        subcode.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        subcode.BorderStyle = BorderStyle.FixedSingle
        subcode.Location = New Point(292, 101)
        subcode.Name = "subcode"
        subcode.Size = New Size(213, 33)
        subcode.TabIndex = 141
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(529, 63)
        Label2.Name = "Label2"
        Label2.Size = New Size(152, 25)
        Label2.TabIndex = 140
        Label2.Text = "SUBJECT TYPE"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(292, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(158, 25)
        Label1.TabIndex = 139
        Label1.Text = "SUBJECT CODE"
        ' 
        ' subtype
        ' 
        subtype.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        subtype.ForeColor = Color.Black
        subtype.FormattingEnabled = True
        subtype.Location = New Point(530, 101)
        subtype.Name = "subtype"
        subtype.Size = New Size(230, 33)
        subtype.TabIndex = 138
        ' 
        ' subname
        ' 
        subname.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        subname.BorderStyle = BorderStyle.FixedSingle
        subname.Location = New Point(17, 101)
        subname.Name = "subname"
        subname.Size = New Size(250, 33)
        subname.TabIndex = 137
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(17, 63)
        Label8.Name = "Label8"
        Label8.Size = New Size(159, 25)
        Label8.TabIndex = 136
        Label8.Text = "SUBJECT NAME"
        ' 
        ' addsubject
        ' 
        AutoScaleDimensions = New SizeF(12F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1008, 481)
        Controls.Add(subday)
        Controls.Add(subsemester)
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
        Controls.Add(subsavebutton)
        Controls.Add(cancelbutton)
        Controls.Add(Label6)
        Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Margin = New Padding(5)
        Name = "addsubject"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin || Add Subject"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents subsavebutton As Button
    Friend WithEvents cancelbutton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents subday As ComboBox
    Friend WithEvents subsemester As ComboBox
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
End Class
