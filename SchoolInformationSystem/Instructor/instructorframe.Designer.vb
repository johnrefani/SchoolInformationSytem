<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class instructor_frame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(instructor_frame))
        title_myprofile = New Label()
        myprofilepanel = New Panel()
        head_myprofile = New Panel()
        title_classes = New Label()
        menupanel = New Panel()
        dashboard = New Panel()
        dashboardbutton = New Button()
        classes = New Panel()
        classesbutton = New Button()
        myprofile = New Panel()
        myprofilebutton = New Button()
        header = New Panel()
        title = New Label()
        logo = New PictureBox()
        head_classes = New Panel()
        classespanel = New Panel()
        title_dashboard = New Label()
        username = New Label()
        head_dashboard = New Panel()
        sidenav = New Panel()
        sidepanel = New Panel()
        dashboardpanel = New Panel()
        myprofilepanel.SuspendLayout()
        head_myprofile.SuspendLayout()
        menupanel.SuspendLayout()
        dashboard.SuspendLayout()
        classes.SuspendLayout()
        myprofile.SuspendLayout()
        header.SuspendLayout()
        CType(logo, ComponentModel.ISupportInitialize).BeginInit()
        head_classes.SuspendLayout()
        classespanel.SuspendLayout()
        head_dashboard.SuspendLayout()
        sidenav.SuspendLayout()
        sidepanel.SuspendLayout()
        dashboardpanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' title_myprofile
        ' 
        title_myprofile.Font = New Font("Tahoma", 24F)
        title_myprofile.ForeColor = Color.White
        title_myprofile.ImeMode = ImeMode.NoControl
        title_myprofile.Location = New Point(16, 28)
        title_myprofile.Name = "title_myprofile"
        title_myprofile.Size = New Size(366, 38)
        title_myprofile.TabIndex = 0
        title_myprofile.Text = "My Profile"
        title_myprofile.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' myprofilepanel
        ' 
        myprofilepanel.Controls.Add(head_myprofile)
        myprofilepanel.Dock = DockStyle.Fill
        myprofilepanel.Location = New Point(350, 0)
        myprofilepanel.Name = "myprofilepanel"
        myprofilepanel.Size = New Size(1074, 985)
        myprofilepanel.TabIndex = 7
        ' 
        ' head_myprofile
        ' 
        head_myprofile.BackColor = Color.Maroon
        head_myprofile.Controls.Add(title_myprofile)
        head_myprofile.Dock = DockStyle.Top
        head_myprofile.Location = New Point(0, 0)
        head_myprofile.Name = "head_myprofile"
        head_myprofile.Size = New Size(1074, 94)
        head_myprofile.TabIndex = 0
        ' 
        ' title_classes
        ' 
        title_classes.Font = New Font("Tahoma", 24F)
        title_classes.ForeColor = Color.White
        title_classes.ImeMode = ImeMode.NoControl
        title_classes.Location = New Point(16, 28)
        title_classes.Name = "title_classes"
        title_classes.Size = New Size(366, 38)
        title_classes.TabIndex = 0
        title_classes.Text = "My Classes"
        title_classes.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' menupanel
        ' 
        menupanel.Controls.Add(dashboard)
        menupanel.Controls.Add(classes)
        menupanel.Controls.Add(myprofile)
        menupanel.Dock = DockStyle.Fill
        menupanel.Location = New Point(0, 0)
        menupanel.Name = "menupanel"
        menupanel.Size = New Size(300, 500)
        menupanel.TabIndex = 2
        ' 
        ' dashboard
        ' 
        dashboard.Controls.Add(dashboardbutton)
        dashboard.Cursor = Cursors.Hand
        dashboard.Location = New Point(3, 100)
        dashboard.Name = "dashboard"
        dashboard.Size = New Size(294, 56)
        dashboard.TabIndex = 0
        ' 
        ' dashboardbutton
        ' 
        dashboardbutton.BackColor = Color.Maroon
        dashboardbutton.Dock = DockStyle.Fill
        dashboardbutton.FlatAppearance.BorderColor = Color.Maroon
        dashboardbutton.FlatAppearance.BorderSize = 0
        dashboardbutton.FlatStyle = FlatStyle.Flat
        dashboardbutton.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dashboardbutton.ForeColor = Color.White
        dashboardbutton.ImeMode = ImeMode.NoControl
        dashboardbutton.Location = New Point(0, 0)
        dashboardbutton.Name = "dashboardbutton"
        dashboardbutton.Size = New Size(294, 56)
        dashboardbutton.TabIndex = 0
        dashboardbutton.Text = "Dashboard"
        dashboardbutton.UseVisualStyleBackColor = False
        ' 
        ' classes
        ' 
        classes.BackgroundImageLayout = ImageLayout.None
        classes.Controls.Add(classesbutton)
        classes.Cursor = Cursors.Hand
        classes.ForeColor = SystemColors.ControlText
        classes.Location = New Point(3, 185)
        classes.Name = "classes"
        classes.Size = New Size(294, 56)
        classes.TabIndex = 1
        ' 
        ' classesbutton
        ' 
        classesbutton.BackColor = Color.Maroon
        classesbutton.Cursor = Cursors.Hand
        classesbutton.Dock = DockStyle.Fill
        classesbutton.FlatAppearance.BorderSize = 0
        classesbutton.FlatStyle = FlatStyle.Flat
        classesbutton.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        classesbutton.ForeColor = Color.WhiteSmoke
        classesbutton.ImeMode = ImeMode.NoControl
        classesbutton.Location = New Point(0, 0)
        classesbutton.Name = "classesbutton"
        classesbutton.Size = New Size(294, 56)
        classesbutton.TabIndex = 0
        classesbutton.Text = "Classes"
        classesbutton.UseVisualStyleBackColor = False
        ' 
        ' myprofile
        ' 
        myprofile.Controls.Add(myprofilebutton)
        myprofile.Cursor = Cursors.Hand
        myprofile.Location = New Point(3, 265)
        myprofile.Name = "myprofile"
        myprofile.Size = New Size(294, 56)
        myprofile.TabIndex = 2
        ' 
        ' myprofilebutton
        ' 
        myprofilebutton.BackColor = Color.Maroon
        myprofilebutton.Dock = DockStyle.Fill
        myprofilebutton.FlatAppearance.BorderSize = 0
        myprofilebutton.FlatStyle = FlatStyle.Flat
        myprofilebutton.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        myprofilebutton.ForeColor = Color.White
        myprofilebutton.ImeMode = ImeMode.NoControl
        myprofilebutton.Location = New Point(0, 0)
        myprofilebutton.Name = "myprofilebutton"
        myprofilebutton.Size = New Size(294, 56)
        myprofilebutton.TabIndex = 0
        myprofilebutton.Text = "My Profile"
        myprofilebutton.UseVisualStyleBackColor = False
        ' 
        ' header
        ' 
        header.Controls.Add(title)
        header.Controls.Add(logo)
        header.Dock = DockStyle.Top
        header.Location = New Point(0, 0)
        header.Name = "header"
        header.Size = New Size(300, 73)
        header.TabIndex = 1
        ' 
        ' title
        ' 
        title.Dock = DockStyle.Fill
        title.Font = New Font("Tahoma", 14.25F)
        title.ForeColor = Color.White
        title.ImeMode = ImeMode.NoControl
        title.Location = New Point(63, 0)
        title.Name = "title"
        title.Size = New Size(237, 73)
        title.TabIndex = 1
        title.Text = "CNSC Information System"
        title.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' logo
        ' 
        logo.BackColor = Color.White
        logo.Dock = DockStyle.Left
        logo.Image = CType(resources.GetObject("logo.Image"), Image)
        logo.ImeMode = ImeMode.NoControl
        logo.Location = New Point(0, 0)
        logo.Name = "logo"
        logo.Size = New Size(63, 73)
        logo.SizeMode = PictureBoxSizeMode.Zoom
        logo.TabIndex = 0
        logo.TabStop = False
        ' 
        ' head_classes
        ' 
        head_classes.BackColor = Color.Maroon
        head_classes.Controls.Add(title_classes)
        head_classes.Dock = DockStyle.Top
        head_classes.Location = New Point(0, 0)
        head_classes.Name = "head_classes"
        head_classes.Size = New Size(1074, 94)
        head_classes.TabIndex = 0
        ' 
        ' classespanel
        ' 
        classespanel.Controls.Add(head_classes)
        classespanel.Dock = DockStyle.Fill
        classespanel.Location = New Point(350, 0)
        classespanel.Name = "classespanel"
        classespanel.Size = New Size(1074, 985)
        classespanel.TabIndex = 6
        ' 
        ' title_dashboard
        ' 
        title_dashboard.Font = New Font("Tahoma", 24F)
        title_dashboard.ForeColor = Color.White
        title_dashboard.ImeMode = ImeMode.NoControl
        title_dashboard.Location = New Point(16, 28)
        title_dashboard.Name = "title_dashboard"
        title_dashboard.Size = New Size(157, 38)
        title_dashboard.TabIndex = 0
        title_dashboard.Text = "Welcome,"
        title_dashboard.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' username
        ' 
        username.Font = New Font("Tahoma", 24F)
        username.ForeColor = Color.White
        username.ImeMode = ImeMode.NoControl
        username.Location = New Point(179, 28)
        username.Name = "username"
        username.Size = New Size(157, 38)
        username.TabIndex = 1
        username.Text = "John Doe"
        username.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' head_dashboard
        ' 
        head_dashboard.BackColor = Color.Maroon
        head_dashboard.Controls.Add(title_dashboard)
        head_dashboard.Controls.Add(username)
        head_dashboard.Dock = DockStyle.Top
        head_dashboard.Location = New Point(0, 0)
        head_dashboard.Name = "head_dashboard"
        head_dashboard.Size = New Size(1074, 94)
        head_dashboard.TabIndex = 0
        ' 
        ' sidenav
        ' 
        sidenav.Controls.Add(header)
        sidenav.Controls.Add(menupanel)
        sidenav.Location = New Point(25, 21)
        sidenav.Name = "sidenav"
        sidenav.Size = New Size(300, 500)
        sidenav.TabIndex = 0
        ' 
        ' sidepanel
        ' 
        sidepanel.BackColor = Color.Maroon
        sidepanel.Controls.Add(sidenav)
        sidepanel.Dock = DockStyle.Left
        sidepanel.Location = New Point(0, 0)
        sidepanel.Name = "sidepanel"
        sidepanel.Size = New Size(350, 985)
        sidepanel.TabIndex = 4
        ' 
        ' dashboardpanel
        ' 
        dashboardpanel.Controls.Add(head_dashboard)
        dashboardpanel.Dock = DockStyle.Fill
        dashboardpanel.Location = New Point(350, 0)
        dashboardpanel.Name = "dashboardpanel"
        dashboardpanel.Size = New Size(1074, 985)
        dashboardpanel.TabIndex = 5
        ' 
        ' instructor_frame
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1424, 985)
        Controls.Add(myprofilepanel)
        Controls.Add(classespanel)
        Controls.Add(dashboardpanel)
        Controls.Add(sidepanel)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "instructor_frame"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Instructor"
        myprofilepanel.ResumeLayout(False)
        head_myprofile.ResumeLayout(False)
        menupanel.ResumeLayout(False)
        dashboard.ResumeLayout(False)
        classes.ResumeLayout(False)
        myprofile.ResumeLayout(False)
        header.ResumeLayout(False)
        CType(logo, ComponentModel.ISupportInitialize).EndInit()
        head_classes.ResumeLayout(False)
        classespanel.ResumeLayout(False)
        head_dashboard.ResumeLayout(False)
        sidenav.ResumeLayout(False)
        sidepanel.ResumeLayout(False)
        dashboardpanel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents title_myprofile As Label
    Friend WithEvents myprofilepanel As Panel
    Friend WithEvents head_myprofile As Panel
    Friend WithEvents title_classes As Label
    Friend WithEvents menupanel As Panel
    Friend WithEvents dashboard As Panel
    Friend WithEvents dashboardbutton As Button
    Friend WithEvents classes As Panel
    Friend WithEvents classesbutton As Button
    Friend WithEvents myprofile As Panel
    Friend WithEvents myprofilebutton As Button
    Friend WithEvents head_classes As Panel
    Friend WithEvents classespanel As Panel
    Friend WithEvents title_dashboard As Label
    Friend WithEvents username As Label
    Friend WithEvents head_dashboard As Panel
    Friend WithEvents title As Label
    Friend WithEvents logo As PictureBox
    Friend WithEvents header As Panel
    Friend WithEvents sidenav As Panel
    Friend WithEvents sidepanel As Panel
    Friend WithEvents dashboardpanel As Panel
End Class
