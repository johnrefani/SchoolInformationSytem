<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editconfiguration
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
        Button1 = New Button()
        savebutton = New Button()
        cancelbutton = New Button()
        Label6 = New Label()
        studentnametextbox = New TextBox()
        Label8 = New Label()
        TextBox1 = New TextBox()
        Label1 = New Label()
        TextBox2 = New TextBox()
        Label2 = New Label()
        TextBox3 = New TextBox()
        Label3 = New Label()
        TextBox4 = New TextBox()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(190), CByte(0), CByte(0))
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.White
        Button1.Location = New Point(769, 25)
        Button1.Name = "Button1"
        Button1.Size = New Size(98, 37)
        Button1.TabIndex = 129
        Button1.Text = "DELETE"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' savebutton
        ' 
        savebutton.BackColor = Color.FromArgb(CByte(127), CByte(189), CByte(228))
        savebutton.Cursor = Cursors.Hand
        savebutton.FlatAppearance.BorderSize = 0
        savebutton.FlatStyle = FlatStyle.Flat
        savebutton.ForeColor = Color.White
        savebutton.Location = New Point(647, 24)
        savebutton.Name = "savebutton"
        savebutton.Size = New Size(98, 37)
        savebutton.TabIndex = 128
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
        cancelbutton.Location = New Point(891, 25)
        cancelbutton.Name = "cancelbutton"
        cancelbutton.Size = New Size(98, 35)
        cancelbutton.TabIndex = 127
        cancelbutton.Text = "CANCEL"
        cancelbutton.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(12, 25)
        Label6.Name = "Label6"
        Label6.Size = New Size(427, 39)
        Label6.TabIndex = 126
        Label6.Text = "Edit Database Connection"
        ' 
        ' studentnametextbox
        ' 
        studentnametextbox.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        studentnametextbox.BorderStyle = BorderStyle.FixedSingle
        studentnametextbox.Location = New Point(23, 134)
        studentnametextbox.Name = "studentnametextbox"
        studentnametextbox.Size = New Size(250, 33)
        studentnametextbox.TabIndex = 131
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(23, 96)
        Label8.Name = "Label8"
        Label8.Size = New Size(184, 25)
        Label8.TabIndex = 130
        Label8.Text = "SERVER ADDRESS"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(316, 134)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(250, 33)
        TextBox1.TabIndex = 133
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(316, 96)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 25)
        Label1.TabIndex = 132
        Label1.Text = "PORT"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(601, 134)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(250, 33)
        TextBox2.TabIndex = 135
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(601, 96)
        Label2.Name = "Label2"
        Label2.Size = New Size(176, 25)
        Label2.TabIndex = 134
        Label2.Text = "DATABASE NAME"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Location = New Point(316, 235)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(250, 33)
        TextBox3.TabIndex = 139
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(316, 197)
        Label3.Name = "Label3"
        Label3.Size = New Size(122, 25)
        Label3.TabIndex = 138
        Label3.Text = "PASSWORD"
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Location = New Point(23, 235)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(250, 33)
        TextBox4.TabIndex = 137
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(23, 197)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 25)
        Label4.TabIndex = 136
        Label4.Text = "USERNAME"
        ' 
        ' editconfiguration
        ' 
        AutoScaleDimensions = New SizeF(12F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1008, 330)
        Controls.Add(TextBox3)
        Controls.Add(Label3)
        Controls.Add(TextBox4)
        Controls.Add(Label4)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(studentnametextbox)
        Controls.Add(Label8)
        Controls.Add(Button1)
        Controls.Add(savebutton)
        Controls.Add(cancelbutton)
        Controls.Add(Label6)
        Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Margin = New Padding(5)
        Name = "editconfiguration"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin || Edit Configuration"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents savebutton As Button
    Friend WithEvents cancelbutton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents studentnametextbox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
End Class
