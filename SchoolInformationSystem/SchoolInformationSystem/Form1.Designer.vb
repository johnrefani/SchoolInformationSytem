<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        student_Button = New Button()
        instructor_Button = New Button()
        admin_Button = New Button()
        SuspendLayout()
        ' 
        ' student_Button
        ' 
        student_Button.Location = New Point(678, 343)
        student_Button.Name = "student_Button"
        student_Button.Size = New Size(75, 23)
        student_Button.TabIndex = 1
        student_Button.Text = "Student"
        student_Button.UseVisualStyleBackColor = True
        ' 
        ' instructor_Button
        ' 
        instructor_Button.Location = New Point(678, 372)
        instructor_Button.Name = "instructor_Button"
        instructor_Button.Size = New Size(75, 23)
        instructor_Button.TabIndex = 4
        instructor_Button.Text = "Instructor"
        instructor_Button.UseVisualStyleBackColor = True
        ' 
        ' admin_Button
        ' 
        admin_Button.Location = New Point(678, 401)
        admin_Button.Name = "admin_Button"
        admin_Button.Size = New Size(75, 23)
        admin_Button.TabIndex = 5
        admin_Button.Text = "Admin"
        admin_Button.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(admin_Button)
        Controls.Add(instructor_Button)
        Controls.Add(student_Button)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents student_Button As Button
    Friend WithEvents instructor_Button As Button
    Friend WithEvents admin_Button As Button
End Class
