<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Panel1 = New Panel()
        TextBox2 = New TextBox()
        ComboBox1 = New ComboBox()
        PictureBox1 = New PictureBox()
        TextBox1 = New TextBox()
        TextBox3 = New TextBox()
        Button1 = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(131, 142)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(690, 600)
        Panel1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 15F)
        TextBox2.Location = New Point(198, 323)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(319, 41)
        TextBox2.TabIndex = 2
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Select User", "Student", "Instructor", "Admin"})
        ComboBox1.Location = New Point(198, 237)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(319, 29)
        ComboBox1.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), Image)
        PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), Image)
        PictureBox1.Location = New Point(271, 53)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(160, 160)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(0, 0)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 29)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 15F)
        TextBox3.Location = New Point(198, 399)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(319, 41)
        TextBox3.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(198, 504)
        Button1.Name = "Button1"
        Button1.Size = New Size(319, 50)
        Button1.TabIndex = 4
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1902, 1033)
        Controls.Add(TextBox1)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "login"
        RightToLeft = RightToLeft.No
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "School Information System"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
End Class
