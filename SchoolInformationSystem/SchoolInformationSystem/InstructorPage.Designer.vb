<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstructorPage
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
        instructor_instructorprofile_Button = New Button()
        instructor_updategrades_Button = New Button()
        instructor_block_Button = New Button()
        instructor_course_Button = New Button()
        SuspendLayout()
        ' 
        ' instructor_instructorprofile_Button
        ' 
        instructor_instructorprofile_Button.Location = New Point(28, 129)
        instructor_instructorprofile_Button.Name = "instructor_instructorprofile_Button"
        instructor_instructorprofile_Button.Size = New Size(184, 23)
        instructor_instructorprofile_Button.TabIndex = 0
        instructor_instructorprofile_Button.Text = "Instructor Profile"
        instructor_instructorprofile_Button.UseVisualStyleBackColor = True
        ' 
        ' instructor_updategrades_Button
        ' 
        instructor_updategrades_Button.Location = New Point(28, 158)
        instructor_updategrades_Button.Name = "instructor_updategrades_Button"
        instructor_updategrades_Button.Size = New Size(184, 23)
        instructor_updategrades_Button.TabIndex = 1
        instructor_updategrades_Button.Text = "Insert Course Registation"
        instructor_updategrades_Button.UseVisualStyleBackColor = True
        ' 
        ' instructor_block_Button
        ' 
        instructor_block_Button.Location = New Point(28, 187)
        instructor_block_Button.Name = "instructor_block_Button"
        instructor_block_Button.Size = New Size(184, 23)
        instructor_block_Button.TabIndex = 2
        instructor_block_Button.Text = "Edit Student Transcript"
        instructor_block_Button.UseVisualStyleBackColor = True
        ' 
        ' instructor_course_Button
        ' 
        instructor_course_Button.Location = New Point(28, 216)
        instructor_course_Button.Name = "instructor_course_Button"
        instructor_course_Button.Size = New Size(184, 23)
        instructor_course_Button.TabIndex = 3
        instructor_course_Button.Text = "View Program"
        instructor_course_Button.UseVisualStyleBackColor = True
        ' 
        ' InstructorPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(instructor_course_Button)
        Controls.Add(instructor_block_Button)
        Controls.Add(instructor_updategrades_Button)
        Controls.Add(instructor_instructorprofile_Button)
        Name = "InstructorPage"
        Text = "Instructor Portal For Instructor"
        ResumeLayout(False)
    End Sub

    Friend WithEvents instructor_instructorprofile_Button As Button
    Friend WithEvents instructor_updategrades_Button As Button
    Friend WithEvents instructor_block_Button As Button
    Friend WithEvents instructor_course_Button As Button
End Class
