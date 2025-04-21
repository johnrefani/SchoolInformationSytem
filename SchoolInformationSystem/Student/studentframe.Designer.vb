<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class student_frame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(student_frame))
        sidepanel = New Panel()
        sidenav = New Panel()
        menupanel = New Panel()
        dashboard = New Panel()
        dashboardbutton = New Button()
        enrollment = New Panel()
        enrollmentbutton = New Button()
        myprofile = New Panel()
        myprofilebutton = New Button()
        header = New Panel()
        title = New Label()
        logo = New PictureBox()
        dashboardpanel = New Panel()
        head_dashboard = New Panel()
        title_dashboard = New Label()
        username = New Label()
        enrollmentpanel = New Panel()
        head_enrollment = New Panel()
        title_enrollment = New Label()
        myprofilepanel = New Panel()
        head_myprofile = New Panel()
        title_myprofile = New Label()
        sidepanel.SuspendLayout()
        sidenav.SuspendLayout()
        menupanel.SuspendLayout()
        dashboard.SuspendLayout()
        enrollment.SuspendLayout()
        myprofile.SuspendLayout()
        header.SuspendLayout()
        CType(logo, ComponentModel.ISupportInitialize).BeginInit()
        dashboardpanel.SuspendLayout()
        head_dashboard.SuspendLayout()
        enrollmentpanel.SuspendLayout()
        head_enrollment.SuspendLayout()
        myprofilepanel.SuspendLayout()
        head_myprofile.SuspendLayout()
        SuspendLayout()
        ' 
        ' sidepanel
        ' 
        resources.ApplyResources(sidepanel, "sidepanel")
        sidepanel.BackColor = Color.Maroon
        sidepanel.Controls.Add(sidenav)
        sidepanel.Name = "sidepanel"
        ' 
        ' sidenav
        ' 
        resources.ApplyResources(sidenav, "sidenav")
        sidenav.Controls.Add(menupanel)
        sidenav.Controls.Add(header)
        sidenav.Name = "sidenav"
        ' 
        ' menupanel
        ' 
        resources.ApplyResources(menupanel, "menupanel")
        menupanel.Controls.Add(dashboard)
        menupanel.Controls.Add(enrollment)
        menupanel.Controls.Add(myprofile)
        menupanel.Name = "menupanel"
        ' 
        ' dashboard
        ' 
        resources.ApplyResources(dashboard, "dashboard")
        dashboard.Controls.Add(dashboardbutton)
        dashboard.Cursor = Cursors.Hand
        dashboard.Name = "dashboard"
        ' 
        ' dashboardbutton
        ' 
        resources.ApplyResources(dashboardbutton, "dashboardbutton")
        dashboardbutton.BackColor = Color.Maroon
        dashboardbutton.FlatAppearance.BorderColor = Color.Maroon
        dashboardbutton.FlatAppearance.BorderSize = 0
        dashboardbutton.ForeColor = Color.White
        dashboardbutton.Name = "dashboardbutton"
        dashboardbutton.UseVisualStyleBackColor = False
        ' 
        ' enrollment
        ' 
        resources.ApplyResources(enrollment, "enrollment")
        enrollment.Controls.Add(enrollmentbutton)
        enrollment.Cursor = Cursors.Hand
        enrollment.ForeColor = SystemColors.ControlText
        enrollment.Name = "enrollment"
        ' 
        ' enrollmentbutton
        ' 
        resources.ApplyResources(enrollmentbutton, "enrollmentbutton")
        enrollmentbutton.BackColor = Color.Maroon
        enrollmentbutton.Cursor = Cursors.Hand
        enrollmentbutton.FlatAppearance.BorderSize = 0
        enrollmentbutton.ForeColor = Color.White
        enrollmentbutton.Name = "enrollmentbutton"
        enrollmentbutton.UseVisualStyleBackColor = False
        ' 
        ' myprofile
        ' 
        resources.ApplyResources(myprofile, "myprofile")
        myprofile.Controls.Add(myprofilebutton)
        myprofile.Cursor = Cursors.Hand
        myprofile.Name = "myprofile"
        ' 
        ' myprofilebutton
        ' 
        resources.ApplyResources(myprofilebutton, "myprofilebutton")
        myprofilebutton.BackColor = Color.Maroon
        myprofilebutton.FlatAppearance.BorderSize = 0
        myprofilebutton.ForeColor = Color.White
        myprofilebutton.Name = "myprofilebutton"
        myprofilebutton.UseVisualStyleBackColor = False
        ' 
        ' header
        ' 
        resources.ApplyResources(header, "header")
        header.Controls.Add(title)
        header.Controls.Add(logo)
        header.Name = "header"
        ' 
        ' title
        ' 
        resources.ApplyResources(title, "title")
        title.ForeColor = Color.White
        title.Name = "title"
        ' 
        ' logo
        ' 
        resources.ApplyResources(logo, "logo")
        logo.BackColor = Color.White
        logo.Name = "logo"
        logo.TabStop = False
        ' 
        ' dashboardpanel
        ' 
        resources.ApplyResources(dashboardpanel, "dashboardpanel")
        dashboardpanel.Controls.Add(head_dashboard)
        dashboardpanel.Name = "dashboardpanel"
        ' 
        ' head_dashboard
        ' 
        resources.ApplyResources(head_dashboard, "head_dashboard")
        head_dashboard.BackColor = Color.Maroon
        head_dashboard.Controls.Add(title_dashboard)
        head_dashboard.Controls.Add(username)
        head_dashboard.Name = "head_dashboard"
        ' 
        ' title_dashboard
        ' 
        resources.ApplyResources(title_dashboard, "title_dashboard")
        title_dashboard.ForeColor = Color.White
        title_dashboard.Name = "title_dashboard"
        ' 
        ' username
        ' 
        resources.ApplyResources(username, "username")
        username.ForeColor = Color.White
        username.Name = "username"
        ' 
        ' enrollmentpanel
        ' 
        resources.ApplyResources(enrollmentpanel, "enrollmentpanel")
        enrollmentpanel.Controls.Add(head_enrollment)
        enrollmentpanel.Name = "enrollmentpanel"
        ' 
        ' head_enrollment
        ' 
        resources.ApplyResources(head_enrollment, "head_enrollment")
        head_enrollment.BackColor = Color.Maroon
        head_enrollment.Controls.Add(title_enrollment)
        head_enrollment.Name = "head_enrollment"
        ' 
        ' title_enrollment
        ' 
        resources.ApplyResources(title_enrollment, "title_enrollment")
        title_enrollment.ForeColor = Color.White
        title_enrollment.Name = "title_enrollment"
        ' 
        ' myprofilepanel
        ' 
        resources.ApplyResources(myprofilepanel, "myprofilepanel")
        myprofilepanel.Controls.Add(head_myprofile)
        myprofilepanel.Name = "myprofilepanel"
        ' 
        ' head_myprofile
        ' 
        resources.ApplyResources(head_myprofile, "head_myprofile")
        head_myprofile.BackColor = Color.Maroon
        head_myprofile.Controls.Add(title_myprofile)
        head_myprofile.Name = "head_myprofile"
        ' 
        ' title_myprofile
        ' 
        resources.ApplyResources(title_myprofile, "title_myprofile")
        title_myprofile.ForeColor = Color.White
        title_myprofile.Name = "title_myprofile"
        ' 
        ' student_frame
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        Controls.Add(dashboardpanel)
        Controls.Add(enrollmentpanel)
        Controls.Add(myprofilepanel)
        Controls.Add(sidepanel)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "student_frame"
        sidepanel.ResumeLayout(False)
        sidenav.ResumeLayout(False)
        menupanel.ResumeLayout(False)
        dashboard.ResumeLayout(False)
        enrollment.ResumeLayout(False)
        myprofile.ResumeLayout(False)
        header.ResumeLayout(False)
        CType(logo, ComponentModel.ISupportInitialize).EndInit()
        dashboardpanel.ResumeLayout(False)
        head_dashboard.ResumeLayout(False)
        enrollmentpanel.ResumeLayout(False)
        head_enrollment.ResumeLayout(False)
        myprofilepanel.ResumeLayout(False)
        head_myprofile.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents sidepanel As Panel
    Friend WithEvents sidenav As Panel
    Friend WithEvents header As Panel
    Friend WithEvents logo As PictureBox
    Friend WithEvents menupanel As Panel
    Friend WithEvents dashboard As Panel
    Friend WithEvents dashboardbutton As Button
    Friend WithEvents title As Label
    Friend WithEvents myprofile As Panel
    Friend WithEvents myprofilebutton As Button
    Friend WithEvents enrollment As Panel
    Friend WithEvents enrollmentbutton As Button
    Friend WithEvents dashboardpanel As Panel
    Friend WithEvents head_dashboard As Panel
    Friend WithEvents title_dashboard As Label
    Friend WithEvents username As Label
    Friend WithEvents enrollmentpanel As Panel
    Friend WithEvents head_enrollment As Panel
    Friend WithEvents title_enrollment As Label
    Friend WithEvents myprofilepanel As Panel
    Friend WithEvents head_myprofile As Panel
    Friend WithEvents title_myprofile As Label
End Class
