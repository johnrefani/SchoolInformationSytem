<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditGradeForm
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
        Panel1 = New Panel()
        idNumber_Label = New Label()
        Label2 = New Label()
        remarks_TextBox = New TextBox()
        Label1 = New Label()
        cancel_Button = New Button()
        save_Button = New Button()
        courseName_Label = New Label()
        studentName_Label = New Label()
        grade_TextBox = New TextBox()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Silver
        Panel1.Controls.Add(idNumber_Label)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(remarks_TextBox)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(cancel_Button)
        Panel1.Controls.Add(save_Button)
        Panel1.Controls.Add(courseName_Label)
        Panel1.Controls.Add(studentName_Label)
        Panel1.Controls.Add(grade_TextBox)
        Panel1.Location = New Point(196, 91)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(406, 288)
        Panel1.TabIndex = 0
        ' 
        ' idNumber_Label
        ' 
        idNumber_Label.AutoSize = True
        idNumber_Label.Location = New Point(87, 78)
        idNumber_Label.Name = "idNumber_Label"
        idNumber_Label.Size = New Size(68, 15)
        idNumber_Label.TabIndex = 8
        idNumber_Label.Text = "ID Number:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(100, 178)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 15)
        Label2.TabIndex = 7
        Label2.Text = "Remarks:"
        ' 
        ' remarks_TextBox
        ' 
        remarks_TextBox.Location = New Point(168, 178)
        remarks_TextBox.Name = "remarks_TextBox"
        remarks_TextBox.Size = New Size(100, 23)
        remarks_TextBox.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(113, 154)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 15)
        Label1.TabIndex = 5
        Label1.Text = "Grade: "
        ' 
        ' cancel_Button
        ' 
        cancel_Button.BackColor = Color.DarkGray
        cancel_Button.ForeColor = Color.Black
        cancel_Button.Location = New Point(194, 227)
        cancel_Button.Name = "cancel_Button"
        cancel_Button.Size = New Size(159, 40)
        cancel_Button.TabIndex = 4
        cancel_Button.Text = "Cancel"
        cancel_Button.UseVisualStyleBackColor = False
        ' 
        ' save_Button
        ' 
        save_Button.BackColor = Color.Maroon
        save_Button.ForeColor = Color.White
        save_Button.Location = New Point(38, 227)
        save_Button.Name = "save_Button"
        save_Button.Size = New Size(150, 40)
        save_Button.TabIndex = 3
        save_Button.Text = "Save"
        save_Button.UseVisualStyleBackColor = False
        ' 
        ' courseName_Label
        ' 
        courseName_Label.AutoSize = True
        courseName_Label.Location = New Point(108, 126)
        courseName_Label.Name = "courseName_Label"
        courseName_Label.Size = New Size(47, 15)
        courseName_Label.TabIndex = 2
        courseName_Label.Text = "Course:"
        ' 
        ' studentName_Label
        ' 
        studentName_Label.AutoSize = True
        studentName_Label.Location = New Point(113, 102)
        studentName_Label.Name = "studentName_Label"
        studentName_Label.Size = New Size(42, 15)
        studentName_Label.TabIndex = 1
        studentName_Label.Text = "Name:"
        ' 
        ' grade_TextBox
        ' 
        grade_TextBox.Location = New Point(168, 151)
        grade_TextBox.Name = "grade_TextBox"
        grade_TextBox.Size = New Size(100, 23)
        grade_TextBox.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Maroon
        Panel2.Location = New Point(196, 91)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(406, 66)
        Panel2.TabIndex = 1
        ' 
        ' EditGradeForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "EditGradeForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cancel_Button As Button
    Friend WithEvents save_Button As Button
    Friend WithEvents courseName_Label As Label
    Friend WithEvents studentName_Label As Label
    Friend WithEvents grade_TextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents remarks_TextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents idNumber_Label As Label
End Class
