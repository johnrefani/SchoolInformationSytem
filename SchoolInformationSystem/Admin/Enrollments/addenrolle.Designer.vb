<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addenrolle
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
        savebutton = New Button()
        cancelbutton = New Button()
        Label6 = New Label()
        estudname = New TextBox()
        Label8 = New Label()
        Label1 = New Label()
        eschoolyear = New TextBox()
        Label2 = New Label()
        egradelevel = New TextBox()
        Label3 = New Label()
        eamount = New TextBox()
        Label4 = New Label()
        emode = New TextBox()
        Label5 = New Label()
        Label7 = New Label()
        esection = New TextBox()
        Label9 = New Label()
        estatus = New TextBox()
        epaymentstatus = New TextBox()
        ediscount = New TextBox()
        Label10 = New Label()
        epaymentdate = New TextBox()
        Label11 = New Label()
        Label12 = New Label()
        ebalance = New TextBox()
        Label13 = New Label()
        eremarks = New TextBox()
        Label14 = New Label()
        cashier = New TextBox()
        Label15 = New Label()
        esubjectname = New TextBox()
        SuspendLayout()
        ' 
        ' savebutton
        ' 
        savebutton.BackColor = Color.FromArgb(CByte(127), CByte(189), CByte(228))
        savebutton.Cursor = Cursors.Hand
        savebutton.FlatAppearance.BorderSize = 0
        savebutton.FlatStyle = FlatStyle.Flat
        savebutton.ForeColor = Color.White
        savebutton.Location = New Point(762, 11)
        savebutton.Name = "savebutton"
        savebutton.Size = New Size(98, 37)
        savebutton.TabIndex = 64
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
        cancelbutton.Location = New Point(875, 11)
        cancelbutton.Name = "cancelbutton"
        cancelbutton.Size = New Size(111, 37)
        cancelbutton.TabIndex = 63
        cancelbutton.Text = "CANCEL"
        cancelbutton.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(12, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(201, 39)
        Label6.TabIndex = 62
        Label6.Text = "Add Enrolle"
        ' 
        ' estudname
        ' 
        estudname.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        estudname.BorderStyle = BorderStyle.FixedSingle
        estudname.Location = New Point(17, 111)
        estudname.Name = "estudname"
        estudname.Size = New Size(250, 33)
        estudname.TabIndex = 1
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(17, 73)
        Label8.Name = "Label8"
        Label8.Size = New Size(164, 25)
        Label8.TabIndex = 65
        Label8.Text = "STUDENT NAME"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(297, 73)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 25)
        Label1.TabIndex = 68
        Label1.Text = "SUBJECT NAME"
        ' 
        ' eschoolyear
        ' 
        eschoolyear.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        eschoolyear.BorderStyle = BorderStyle.FixedSingle
        eschoolyear.Location = New Point(547, 111)
        eschoolyear.Name = "eschoolyear"
        eschoolyear.Size = New Size(213, 33)
        eschoolyear.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(547, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(148, 25)
        Label2.TabIndex = 69
        Label2.Text = "SCHOOL YEAR"
        ' 
        ' egradelevel
        ' 
        egradelevel.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        egradelevel.BorderStyle = BorderStyle.FixedSingle
        egradelevel.Location = New Point(785, 111)
        egradelevel.Name = "egradelevel"
        egradelevel.Size = New Size(207, 33)
        egradelevel.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(787, 73)
        Label3.Name = "Label3"
        Label3.Size = New Size(142, 25)
        Label3.TabIndex = 71
        Label3.Text = "GRADE LEVEL"
        ' 
        ' eamount
        ' 
        eamount.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        eamount.BorderStyle = BorderStyle.FixedSingle
        eamount.Location = New Point(785, 209)
        eamount.Name = "eamount"
        eamount.Size = New Size(207, 33)
        eamount.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(787, 171)
        Label4.Name = "Label4"
        Label4.Size = New Size(150, 25)
        Label4.TabIndex = 79
        Label4.Text = "AMOUNT PAID"
        ' 
        ' emode
        ' 
        emode.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        emode.BorderStyle = BorderStyle.FixedSingle
        emode.Location = New Point(547, 209)
        emode.Name = "emode"
        emode.Size = New Size(213, 33)
        emode.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(547, 171)
        Label5.Name = "Label5"
        Label5.Size = New Size(167, 25)
        Label5.TabIndex = 77
        Label5.Text = "PAYMENT MODE"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(292, 171)
        Label7.Name = "Label7"
        Label7.Size = New Size(87, 25)
        Label7.TabIndex = 76
        Label7.Text = "STATUS"
        ' 
        ' esection
        ' 
        esection.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        esection.BorderStyle = BorderStyle.FixedSingle
        esection.Location = New Point(17, 209)
        esection.Name = "esection"
        esection.Size = New Size(250, 33)
        esection.TabIndex = 5
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(17, 171)
        Label9.Name = "Label9"
        Label9.Size = New Size(98, 25)
        Label9.TabIndex = 73
        Label9.Text = "SECTION"
        ' 
        ' estatus
        ' 
        estatus.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        estatus.BorderStyle = BorderStyle.FixedSingle
        estatus.Location = New Point(292, 209)
        estatus.Name = "estatus"
        estatus.Size = New Size(230, 33)
        estatus.TabIndex = 6
        ' 
        ' epaymentstatus
        ' 
        epaymentstatus.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        epaymentstatus.BorderStyle = BorderStyle.FixedSingle
        epaymentstatus.Location = New Point(292, 305)
        epaymentstatus.Name = "epaymentstatus"
        epaymentstatus.Size = New Size(230, 33)
        epaymentstatus.TabIndex = 10
        ' 
        ' ediscount
        ' 
        ediscount.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        ediscount.BorderStyle = BorderStyle.FixedSingle
        ediscount.Location = New Point(785, 305)
        ediscount.Name = "ediscount"
        ediscount.Size = New Size(207, 33)
        ediscount.TabIndex = 12
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(787, 267)
        Label10.Name = "Label10"
        Label10.Size = New Size(202, 25)
        Label10.TabIndex = 87
        Label10.Text = "DISCOUNT APPLIED"
        ' 
        ' epaymentdate
        ' 
        epaymentdate.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        epaymentdate.BorderStyle = BorderStyle.FixedSingle
        epaymentdate.Location = New Point(547, 305)
        epaymentdate.Name = "epaymentdate"
        epaymentdate.Size = New Size(213, 33)
        epaymentdate.TabIndex = 11
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(547, 267)
        Label11.Name = "Label11"
        Label11.Size = New Size(161, 25)
        Label11.TabIndex = 85
        Label11.Text = "PAYMENT DATE"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(292, 267)
        Label12.Name = "Label12"
        Label12.Size = New Size(185, 25)
        Label12.TabIndex = 84
        Label12.Text = "PAYMENT STATUS"
        ' 
        ' ebalance
        ' 
        ebalance.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        ebalance.BorderStyle = BorderStyle.FixedSingle
        ebalance.Location = New Point(17, 305)
        ebalance.Name = "ebalance"
        ebalance.Size = New Size(250, 33)
        ebalance.TabIndex = 9
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(17, 267)
        Label13.Name = "Label13"
        Label13.Size = New Size(100, 25)
        Label13.TabIndex = 82
        Label13.Text = "BALANCE"
        ' 
        ' eremarks
        ' 
        eremarks.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        eremarks.BorderStyle = BorderStyle.FixedSingle
        eremarks.Location = New Point(292, 396)
        eremarks.Name = "eremarks"
        eremarks.Size = New Size(230, 33)
        eremarks.TabIndex = 14
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(292, 358)
        Label14.Name = "Label14"
        Label14.Size = New Size(103, 25)
        Label14.TabIndex = 92
        Label14.Text = "REMARKS"
        ' 
        ' cashier
        ' 
        cashier.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        cashier.BorderStyle = BorderStyle.FixedSingle
        cashier.Location = New Point(17, 396)
        cashier.Name = "cashier"
        cashier.Size = New Size(250, 33)
        cashier.TabIndex = 13
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(17, 358)
        Label15.Name = "Label15"
        Label15.Size = New Size(159, 25)
        Label15.TabIndex = 90
        Label15.Text = "CASHIER NAME"
        ' 
        ' esubjectname
        ' 
        esubjectname.BackColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        esubjectname.BorderStyle = BorderStyle.FixedSingle
        esubjectname.Location = New Point(297, 111)
        esubjectname.Name = "esubjectname"
        esubjectname.Size = New Size(230, 33)
        esubjectname.TabIndex = 93
        ' 
        ' addenrolle
        ' 
        AutoScaleDimensions = New SizeF(12F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1008, 473)
        Controls.Add(esubjectname)
        Controls.Add(eremarks)
        Controls.Add(Label14)
        Controls.Add(cashier)
        Controls.Add(Label15)
        Controls.Add(epaymentstatus)
        Controls.Add(ediscount)
        Controls.Add(Label10)
        Controls.Add(epaymentdate)
        Controls.Add(Label11)
        Controls.Add(Label12)
        Controls.Add(ebalance)
        Controls.Add(Label13)
        Controls.Add(estatus)
        Controls.Add(eamount)
        Controls.Add(Label4)
        Controls.Add(emode)
        Controls.Add(Label5)
        Controls.Add(Label7)
        Controls.Add(esection)
        Controls.Add(Label9)
        Controls.Add(egradelevel)
        Controls.Add(Label3)
        Controls.Add(eschoolyear)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(estudname)
        Controls.Add(Label8)
        Controls.Add(savebutton)
        Controls.Add(cancelbutton)
        Controls.Add(Label6)
        Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Margin = New Padding(5)
        Name = "addenrolle"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin || Add Enrolle"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents savebutton As Button
    Friend WithEvents cancelbutton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents estudname As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents eschoolyear As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents egradelevel As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents eamount As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents emode As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents esection As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents estatus As TextBox
    Friend WithEvents epaymentstatus As TextBox
    Friend WithEvents ediscount As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents epaymentdate As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ebalance As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents eremarks As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cashier As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents esubjectname As TextBox
End Class
