<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMLOGIN
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMLOGIN))
        Me.tmlogin = New System.Windows.Forms.Timer(Me.components)
        Me.tmlogin2 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.pnlloginmain = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnllogin = New Bunifu.UI.WinForms.BunifuGradientPanel()
        Me.gbsocial = New System.Windows.Forms.GroupBox()
        Me.BTNFACEBOOK = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNINSTA = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNTWITT = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNSIGNUP = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNSIGNIN = New Guna.UI2.WinForms.Guna2Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.pnlloginmain.SuspendLayout()
        Me.pnllogin.SuspendLayout()
        Me.gbsocial.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmlogin
        '
        Me.tmlogin.Interval = 30
        '
        'tmlogin2
        '
        Me.tmlogin2.Interval = 30
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.pnlloginmain)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel1
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(626, 512)
        Me.Guna2CustomGradientPanel1.TabIndex = 1
        '
        'pnlloginmain
        '
        Me.pnlloginmain.BackColor = System.Drawing.Color.Transparent
        Me.pnlloginmain.Controls.Add(Me.Label1)
        Me.pnlloginmain.Location = New System.Drawing.Point(9, 7)
        Me.pnlloginmain.Name = "pnlloginmain"
        Me.pnlloginmain.Size = New System.Drawing.Size(361, 494)
        Me.pnlloginmain.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(281, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'pnllogin
        '
        Me.pnllogin.BackColor = System.Drawing.Color.Transparent
        Me.pnllogin.BackgroundImage = CType(resources.GetObject("pnllogin.BackgroundImage"), System.Drawing.Image)
        Me.pnllogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnllogin.BorderRadius = 10
        Me.pnllogin.Controls.Add(Me.gbsocial)
        Me.pnllogin.Controls.Add(Me.BTNSIGNUP)
        Me.pnllogin.Controls.Add(Me.BTNSIGNIN)
        Me.pnllogin.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.pnllogin.GradientBottomRight = System.Drawing.Color.DeepPink
        Me.pnllogin.GradientTopLeft = System.Drawing.Color.DodgerBlue
        Me.pnllogin.GradientTopRight = System.Drawing.Color.DodgerBlue
        Me.pnllogin.Location = New System.Drawing.Point(376, 7)
        Me.pnllogin.Name = "pnllogin"
        Me.pnllogin.Quality = 10
        Me.pnllogin.Size = New System.Drawing.Size(243, 499)
        Me.pnllogin.TabIndex = 0
        '
        'gbsocial
        '
        Me.gbsocial.BackColor = System.Drawing.Color.Transparent
        Me.gbsocial.Controls.Add(Me.BTNFACEBOOK)
        Me.gbsocial.Controls.Add(Me.BTNINSTA)
        Me.gbsocial.Controls.Add(Me.BTNTWITT)
        Me.gbsocial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbsocial.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbsocial.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.gbsocial.Location = New System.Drawing.Point(21, 306)
        Me.gbsocial.Name = "gbsocial"
        Me.gbsocial.Size = New System.Drawing.Size(208, 179)
        Me.gbsocial.TabIndex = 6
        Me.gbsocial.TabStop = False
        Me.gbsocial.Text = "Follow us on "
        Me.gbsocial.UseCompatibleTextRendering = True
        '
        'BTNFACEBOOK
        '
        Me.BTNFACEBOOK.AutoRoundedCorners = True
        Me.BTNFACEBOOK.BackColor = System.Drawing.Color.Transparent
        Me.BTNFACEBOOK.BorderRadius = 21
        Me.BTNFACEBOOK.CheckedState.Parent = Me.BTNFACEBOOK
        Me.BTNFACEBOOK.CustomImages.Parent = Me.BTNFACEBOOK
        Me.BTNFACEBOOK.FillColor = System.Drawing.Color.White
        Me.BTNFACEBOOK.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNFACEBOOK.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.BTNFACEBOOK.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNFACEBOOK.HoverState.ForeColor = System.Drawing.Color.White
        Me.BTNFACEBOOK.HoverState.Parent = Me.BTNFACEBOOK
        Me.BTNFACEBOOK.Image = Global.WindowsApp1.My.Resources.Resources.facebook__1_
        Me.BTNFACEBOOK.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTNFACEBOOK.Location = New System.Drawing.Point(13, 19)
        Me.BTNFACEBOOK.Name = "BTNFACEBOOK"
        Me.BTNFACEBOOK.ShadowDecoration.Parent = Me.BTNFACEBOOK
        Me.BTNFACEBOOK.Size = New System.Drawing.Size(180, 45)
        Me.BTNFACEBOOK.TabIndex = 2
        Me.BTNFACEBOOK.Text = "Facebook"
        Me.BTNFACEBOOK.UseTransparentBackground = True
        '
        'BTNINSTA
        '
        Me.BTNINSTA.AutoRoundedCorners = True
        Me.BTNINSTA.BackColor = System.Drawing.Color.Transparent
        Me.BTNINSTA.BorderRadius = 21
        Me.BTNINSTA.CheckedState.Parent = Me.BTNINSTA
        Me.BTNINSTA.CustomImages.Parent = Me.BTNINSTA
        Me.BTNINSTA.FillColor = System.Drawing.Color.White
        Me.BTNINSTA.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNINSTA.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.BTNINSTA.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNINSTA.HoverState.ForeColor = System.Drawing.Color.White
        Me.BTNINSTA.HoverState.Parent = Me.BTNINSTA
        Me.BTNINSTA.Image = Global.WindowsApp1.My.Resources.Resources.instagram
        Me.BTNINSTA.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTNINSTA.Location = New System.Drawing.Point(13, 121)
        Me.BTNINSTA.Name = "BTNINSTA"
        Me.BTNINSTA.ShadowDecoration.Parent = Me.BTNINSTA
        Me.BTNINSTA.Size = New System.Drawing.Size(180, 45)
        Me.BTNINSTA.TabIndex = 5
        Me.BTNINSTA.Text = "Instagram"
        Me.BTNINSTA.UseTransparentBackground = True
        '
        'BTNTWITT
        '
        Me.BTNTWITT.AutoRoundedCorners = True
        Me.BTNTWITT.BackColor = System.Drawing.Color.Transparent
        Me.BTNTWITT.BorderRadius = 21
        Me.BTNTWITT.CheckedState.Parent = Me.BTNTWITT
        Me.BTNTWITT.CustomImages.Parent = Me.BTNTWITT
        Me.BTNTWITT.FillColor = System.Drawing.Color.White
        Me.BTNTWITT.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNTWITT.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.BTNTWITT.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNTWITT.HoverState.ForeColor = System.Drawing.Color.White
        Me.BTNTWITT.HoverState.Parent = Me.BTNTWITT
        Me.BTNTWITT.Image = Global.WindowsApp1.My.Resources.Resources.twitter
        Me.BTNTWITT.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTNTWITT.Location = New System.Drawing.Point(13, 70)
        Me.BTNTWITT.Name = "BTNTWITT"
        Me.BTNTWITT.ShadowDecoration.Parent = Me.BTNTWITT
        Me.BTNTWITT.Size = New System.Drawing.Size(180, 45)
        Me.BTNTWITT.TabIndex = 4
        Me.BTNTWITT.Text = "Twitter"
        Me.BTNTWITT.UseTransparentBackground = True
        '
        'BTNSIGNUP
        '
        Me.BTNSIGNUP.AutoRoundedCorners = True
        Me.BTNSIGNUP.BorderRadius = 21
        Me.BTNSIGNUP.CheckedState.Parent = Me.BTNSIGNUP
        Me.BTNSIGNUP.CustomImages.Parent = Me.BTNSIGNUP
        Me.BTNSIGNUP.FillColor = System.Drawing.Color.White
        Me.BTNSIGNUP.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSIGNUP.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.BTNSIGNUP.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNSIGNUP.HoverState.ForeColor = System.Drawing.Color.White
        Me.BTNSIGNUP.HoverState.Parent = Me.BTNSIGNUP
        Me.BTNSIGNUP.Location = New System.Drawing.Point(32, 227)
        Me.BTNSIGNUP.Name = "BTNSIGNUP"
        Me.BTNSIGNUP.ShadowDecoration.Parent = Me.BTNSIGNUP
        Me.BTNSIGNUP.Size = New System.Drawing.Size(180, 45)
        Me.BTNSIGNUP.TabIndex = 1
        Me.BTNSIGNUP.Text = "SIGN UP"
        Me.BTNSIGNUP.UseTransparentBackground = True
        '
        'BTNSIGNIN
        '
        Me.BTNSIGNIN.AutoRoundedCorners = True
        Me.BTNSIGNIN.BorderRadius = 21
        Me.BTNSIGNIN.CheckedState.Parent = Me.BTNSIGNIN
        Me.BTNSIGNIN.CustomImages.Parent = Me.BTNSIGNIN
        Me.BTNSIGNIN.FillColor = System.Drawing.Color.White
        Me.BTNSIGNIN.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSIGNIN.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.BTNSIGNIN.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNSIGNIN.HoverState.ForeColor = System.Drawing.Color.White
        Me.BTNSIGNIN.HoverState.Parent = Me.BTNSIGNIN
        Me.BTNSIGNIN.Location = New System.Drawing.Point(32, 176)
        Me.BTNSIGNIN.Name = "BTNSIGNIN"
        Me.BTNSIGNIN.ShadowDecoration.Parent = Me.BTNSIGNIN
        Me.BTNSIGNIN.Size = New System.Drawing.Size(180, 45)
        Me.BTNSIGNIN.TabIndex = 0
        Me.BTNSIGNIN.Text = "SIGN IN"
        Me.BTNSIGNIN.UseTransparentBackground = True
        '
        'FRMLOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(626, 512)
        Me.Controls.Add(Me.pnllogin)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRMLOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.pnlloginmain.ResumeLayout(False)
        Me.pnlloginmain.PerformLayout()
        Me.pnllogin.ResumeLayout(False)
        Me.gbsocial.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnllogin As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents BTNFACEBOOK As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNSIGNUP As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNSIGNIN As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNINSTA As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNTWITT As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gbsocial As GroupBox
    Friend WithEvents tmlogin As Timer
    Friend WithEvents tmlogin2 As Timer
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents pnlloginmain As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
