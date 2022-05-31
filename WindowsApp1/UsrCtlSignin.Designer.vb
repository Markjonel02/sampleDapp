<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsrCtlSignin
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsrCtlSignin))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties5 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties6 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties7 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties8 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Me.BunifuShadowPanel2 = New Bunifu.UI.WinForms.BunifuShadowPanel()
        Me.lblforgot = New System.Windows.Forms.LinkLabel()
        Me.lbluserstat = New System.Windows.Forms.Label()
        Me.BunifuPictureBox1 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuSeparator2 = New Bunifu.UI.WinForms.BunifuSeparator()
        Me.chkeyes = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.TXTPASS = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.BTNLOGIN = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.TXTUSN = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.BunifuShadowPanel2.SuspendLayout()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuShadowPanel2
        '
        Me.BunifuShadowPanel2.BackColor = System.Drawing.Color.White
        Me.BunifuShadowPanel2.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuShadowPanel2.BorderRadius = 1
        Me.BunifuShadowPanel2.BorderThickness = 1
        Me.BunifuShadowPanel2.Controls.Add(Me.lblforgot)
        Me.BunifuShadowPanel2.Controls.Add(Me.lbluserstat)
        Me.BunifuShadowPanel2.Controls.Add(Me.BunifuPictureBox1)
        Me.BunifuShadowPanel2.Controls.Add(Me.Label1)
        Me.BunifuShadowPanel2.Controls.Add(Me.BunifuSeparator2)
        Me.BunifuShadowPanel2.Controls.Add(Me.chkeyes)
        Me.BunifuShadowPanel2.Controls.Add(Me.TXTPASS)
        Me.BunifuShadowPanel2.Controls.Add(Me.BTNLOGIN)
        Me.BunifuShadowPanel2.Controls.Add(Me.TXTUSN)
        Me.BunifuShadowPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuShadowPanel2.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid
        Me.BunifuShadowPanel2.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical
        Me.BunifuShadowPanel2.Location = New System.Drawing.Point(0, 0)
        Me.BunifuShadowPanel2.Name = "BunifuShadowPanel2"
        Me.BunifuShadowPanel2.PanelColor = System.Drawing.Color.White
        Me.BunifuShadowPanel2.PanelColor2 = System.Drawing.Color.White
        Me.BunifuShadowPanel2.ShadowColor = System.Drawing.Color.White
        Me.BunifuShadowPanel2.ShadowDept = 2
        Me.BunifuShadowPanel2.ShadowDepth = 5
        Me.BunifuShadowPanel2.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded
        Me.BunifuShadowPanel2.ShadowTopLeftVisible = False
        Me.BunifuShadowPanel2.Size = New System.Drawing.Size(361, 494)
        Me.BunifuShadowPanel2.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat
        Me.BunifuShadowPanel2.TabIndex = 1
        '
        'lblforgot
        '
        Me.lblforgot.AutoSize = True
        Me.lblforgot.Location = New System.Drawing.Point(131, 398)
        Me.lblforgot.Name = "lblforgot"
        Me.lblforgot.Size = New System.Drawing.Size(91, 13)
        Me.lblforgot.TabIndex = 23
        Me.lblforgot.TabStop = True
        Me.lblforgot.Text = "Forgot password?"
        '
        'lbluserstat
        '
        Me.lbluserstat.Location = New System.Drawing.Point(106, 182)
        Me.lbluserstat.Name = "lbluserstat"
        Me.lbluserstat.Size = New System.Drawing.Size(145, 25)
        Me.lbluserstat.TabIndex = 22
        Me.lbluserstat.Visible = False
        '
        'BunifuPictureBox1
        '
        Me.BunifuPictureBox1.AllowFocused = False
        Me.BunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox1.AutoSizeHeight = True
        Me.BunifuPictureBox1.BorderRadius = 50
        Me.BunifuPictureBox1.Image = CType(resources.GetObject("BunifuPictureBox1.Image"), System.Drawing.Image)
        Me.BunifuPictureBox1.IsCircle = True
        Me.BunifuPictureBox1.Location = New System.Drawing.Point(127, 27)
        Me.BunifuPictureBox1.Name = "BunifuPictureBox1"
        Me.BunifuPictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.BunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuPictureBox1.TabIndex = 20
        Me.BunifuPictureBox1.TabStop = False
        Me.BunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(121, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 37)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "SIGN IN"
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.BackgroundImage = CType(resources.GetObject("BunifuSeparator2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuSeparator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.RoyalBlue
        Me.BunifuSeparator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(28, 148)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal
        Me.BunifuSeparator2.Size = New System.Drawing.Size(308, 10)
        Me.BunifuSeparator2.TabIndex = 18
        '
        'chkeyes
        '
        Me.chkeyes.BackColor = System.Drawing.Color.Transparent
        Me.chkeyes.CheckedState.Image = Global.WindowsApp1.My.Resources.Resources.visible_opened_eye_interface_option
        Me.chkeyes.CheckedState.Parent = Me.chkeyes
        Me.chkeyes.HoverState.Parent = Me.chkeyes
        Me.chkeyes.Image = Global.WindowsApp1.My.Resources.Resources.invisible
        Me.chkeyes.Location = New System.Drawing.Point(269, 272)
        Me.chkeyes.Name = "chkeyes"
        Me.chkeyes.PressedState.Parent = Me.chkeyes
        Me.chkeyes.Size = New System.Drawing.Size(34, 23)
        Me.chkeyes.TabIndex = 7
        Me.chkeyes.UseTransparentBackground = True
        '
        'TXTPASS
        '
        Me.TXTPASS.AcceptsReturn = False
        Me.TXTPASS.AcceptsTab = False
        Me.TXTPASS.AnimationSpeed = 200
        Me.TXTPASS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TXTPASS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TXTPASS.BackColor = System.Drawing.Color.White
        Me.TXTPASS.BackgroundImage = CType(resources.GetObject("TXTPASS.BackgroundImage"), System.Drawing.Image)
        Me.TXTPASS.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.TXTPASS.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TXTPASS.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTPASS.BorderColorIdle = System.Drawing.Color.Silver
        Me.TXTPASS.BorderRadius = 31
        Me.TXTPASS.BorderThickness = 1
        Me.TXTPASS.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXTPASS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTPASS.DefaultFont = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.TXTPASS.DefaultText = ""
        Me.TXTPASS.FillColor = System.Drawing.Color.White
        Me.TXTPASS.HideSelection = True
        Me.TXTPASS.IconLeft = Global.WindowsApp1.My.Resources.Resources.password
        Me.TXTPASS.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTPASS.IconPadding = 10
        Me.TXTPASS.IconRight = Nothing
        Me.TXTPASS.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTPASS.Lines = New String(-1) {}
        Me.TXTPASS.Location = New System.Drawing.Point(46, 267)
        Me.TXTPASS.MaxLength = 32767
        Me.TXTPASS.MinimumSize = New System.Drawing.Size(1, 1)
        Me.TXTPASS.Modified = False
        Me.TXTPASS.Multiline = False
        Me.TXTPASS.Name = "TXTPASS"
        StateProperties1.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.TXTPASS.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TXTPASS.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.TXTPASS.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.Silver
        StateProperties4.FillColor = System.Drawing.Color.White
        StateProperties4.ForeColor = System.Drawing.Color.Empty
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.TXTPASS.OnIdleState = StateProperties4
        Me.TXTPASS.Padding = New System.Windows.Forms.Padding(3)
        Me.TXTPASS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTPASS.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.TXTPASS.PlaceholderText = "Password"
        Me.TXTPASS.ReadOnly = False
        Me.TXTPASS.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TXTPASS.SelectedText = ""
        Me.TXTPASS.SelectionLength = 0
        Me.TXTPASS.SelectionStart = 0
        Me.TXTPASS.ShortcutsEnabled = True
        Me.TXTPASS.Size = New System.Drawing.Size(260, 37)
        Me.TXTPASS.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material
        Me.TXTPASS.TabIndex = 6
        Me.TXTPASS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXTPASS.TextMarginBottom = 0
        Me.TXTPASS.TextMarginLeft = 3
        Me.TXTPASS.TextMarginTop = 0
        Me.TXTPASS.TextPlaceholder = "Password"
        Me.TXTPASS.UseSystemPasswordChar = False
        Me.TXTPASS.WordWrap = True
        '
        'BTNLOGIN
        '
        Me.BTNLOGIN.AllowAnimations = True
        Me.BTNLOGIN.AllowMouseEffects = True
        Me.BTNLOGIN.AllowToggling = False
        Me.BTNLOGIN.AnimationSpeed = 200
        Me.BTNLOGIN.AutoGenerateColors = False
        Me.BTNLOGIN.AutoRoundBorders = False
        Me.BTNLOGIN.AutoSizeLeftIcon = True
        Me.BTNLOGIN.AutoSizeRightIcon = True
        Me.BTNLOGIN.BackColor = System.Drawing.Color.Transparent
        Me.BTNLOGIN.BackColor1 = System.Drawing.Color.DodgerBlue
        Me.BTNLOGIN.BackgroundImage = CType(resources.GetObject("BTNLOGIN.BackgroundImage"), System.Drawing.Image)
        Me.BTNLOGIN.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNLOGIN.ButtonText = "SIGN IN"
        Me.BTNLOGIN.ButtonTextMarginLeft = 0
        Me.BTNLOGIN.ColorContrastOnClick = 45
        Me.BTNLOGIN.ColorContrastOnHover = 45
        Me.BTNLOGIN.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.BTNLOGIN.CustomizableEdges = BorderEdges1
        Me.BTNLOGIN.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTNLOGIN.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BTNLOGIN.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BTNLOGIN.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BTNLOGIN.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BTNLOGIN.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLOGIN.ForeColor = System.Drawing.Color.White
        Me.BTNLOGIN.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNLOGIN.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BTNLOGIN.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BTNLOGIN.IconMarginLeft = 11
        Me.BTNLOGIN.IconPadding = 10
        Me.BTNLOGIN.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNLOGIN.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BTNLOGIN.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BTNLOGIN.IconSize = 25
        Me.BTNLOGIN.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.BTNLOGIN.IdleBorderRadius = 1
        Me.BTNLOGIN.IdleBorderThickness = 1
        Me.BTNLOGIN.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.BTNLOGIN.IdleIconLeftImage = Nothing
        Me.BTNLOGIN.IdleIconRightImage = Nothing
        Me.BTNLOGIN.IndicateFocus = False
        Me.BTNLOGIN.Location = New System.Drawing.Point(101, 345)
        Me.BTNLOGIN.Name = "BTNLOGIN"
        Me.BTNLOGIN.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BTNLOGIN.OnDisabledState.BorderRadius = 1
        Me.BTNLOGIN.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNLOGIN.OnDisabledState.BorderThickness = 1
        Me.BTNLOGIN.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BTNLOGIN.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BTNLOGIN.OnDisabledState.IconLeftImage = Nothing
        Me.BTNLOGIN.OnDisabledState.IconRightImage = Nothing
        Me.BTNLOGIN.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNLOGIN.onHoverState.BorderRadius = 1
        Me.BTNLOGIN.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNLOGIN.onHoverState.BorderThickness = 1
        Me.BTNLOGIN.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNLOGIN.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BTNLOGIN.onHoverState.IconLeftImage = Nothing
        Me.BTNLOGIN.onHoverState.IconRightImage = Nothing
        Me.BTNLOGIN.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.BTNLOGIN.OnIdleState.BorderRadius = 1
        Me.BTNLOGIN.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNLOGIN.OnIdleState.BorderThickness = 1
        Me.BTNLOGIN.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue
        Me.BTNLOGIN.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.BTNLOGIN.OnIdleState.IconLeftImage = Nothing
        Me.BTNLOGIN.OnIdleState.IconRightImage = Nothing
        Me.BTNLOGIN.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BTNLOGIN.OnPressedState.BorderRadius = 1
        Me.BTNLOGIN.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNLOGIN.OnPressedState.BorderThickness = 1
        Me.BTNLOGIN.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BTNLOGIN.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BTNLOGIN.OnPressedState.IconLeftImage = Nothing
        Me.BTNLOGIN.OnPressedState.IconRightImage = Nothing
        Me.BTNLOGIN.Size = New System.Drawing.Size(150, 39)
        Me.BTNLOGIN.TabIndex = 5
        Me.BTNLOGIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BTNLOGIN.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BTNLOGIN.TextMarginLeft = 0
        Me.BTNLOGIN.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BTNLOGIN.UseDefaultRadiusAndThickness = True
        '
        'TXTUSN
        '
        Me.TXTUSN.AcceptsReturn = False
        Me.TXTUSN.AcceptsTab = False
        Me.TXTUSN.AnimationSpeed = 200
        Me.TXTUSN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TXTUSN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TXTUSN.BackColor = System.Drawing.Color.White
        Me.TXTUSN.BackgroundImage = CType(resources.GetObject("TXTUSN.BackgroundImage"), System.Drawing.Image)
        Me.TXTUSN.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.TXTUSN.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TXTUSN.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTUSN.BorderColorIdle = System.Drawing.Color.Silver
        Me.TXTUSN.BorderRadius = 31
        Me.TXTUSN.BorderThickness = 1
        Me.TXTUSN.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXTUSN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTUSN.DefaultFont = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.TXTUSN.DefaultText = ""
        Me.TXTUSN.FillColor = System.Drawing.Color.White
        Me.TXTUSN.HideSelection = True
        Me.TXTUSN.IconLeft = Global.WindowsApp1.My.Resources.Resources.user__4_
        Me.TXTUSN.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTUSN.IconPadding = 10
        Me.TXTUSN.IconRight = Nothing
        Me.TXTUSN.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTUSN.Lines = New String(-1) {}
        Me.TXTUSN.Location = New System.Drawing.Point(46, 210)
        Me.TXTUSN.MaxLength = 32767
        Me.TXTUSN.MinimumSize = New System.Drawing.Size(1, 1)
        Me.TXTUSN.Modified = False
        Me.TXTUSN.Multiline = False
        Me.TXTUSN.Name = "TXTUSN"
        StateProperties5.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties5.FillColor = System.Drawing.Color.Empty
        StateProperties5.ForeColor = System.Drawing.Color.Empty
        StateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.TXTUSN.OnActiveState = StateProperties5
        StateProperties6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties6.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TXTUSN.OnDisabledState = StateProperties6
        StateProperties7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties7.FillColor = System.Drawing.Color.Empty
        StateProperties7.ForeColor = System.Drawing.Color.Empty
        StateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.TXTUSN.OnHoverState = StateProperties7
        StateProperties8.BorderColor = System.Drawing.Color.Silver
        StateProperties8.FillColor = System.Drawing.Color.White
        StateProperties8.ForeColor = System.Drawing.Color.Empty
        StateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.TXTUSN.OnIdleState = StateProperties8
        Me.TXTUSN.Padding = New System.Windows.Forms.Padding(3)
        Me.TXTUSN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTUSN.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.TXTUSN.PlaceholderText = "Username"
        Me.TXTUSN.ReadOnly = False
        Me.TXTUSN.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TXTUSN.SelectedText = ""
        Me.TXTUSN.SelectionLength = 0
        Me.TXTUSN.SelectionStart = 0
        Me.TXTUSN.ShortcutsEnabled = True
        Me.TXTUSN.Size = New System.Drawing.Size(260, 37)
        Me.TXTUSN.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material
        Me.TXTUSN.TabIndex = 4
        Me.TXTUSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXTUSN.TextMarginBottom = 0
        Me.TXTUSN.TextMarginLeft = 3
        Me.TXTUSN.TextMarginTop = 0
        Me.TXTUSN.TextPlaceholder = "Username"
        Me.TXTUSN.UseSystemPasswordChar = False
        Me.TXTUSN.WordWrap = True
        '
        'UsrCtlSignin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BunifuShadowPanel2)
        Me.Name = "UsrCtlSignin"
        Me.Size = New System.Drawing.Size(361, 494)
        Me.BunifuShadowPanel2.ResumeLayout(False)
        Me.BunifuShadowPanel2.PerformLayout()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuShadowPanel2 As Bunifu.UI.WinForms.BunifuShadowPanel
    Friend WithEvents TXTPASS As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents BTNLOGIN As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents TXTUSN As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents chkeyes As Guna.UI2.WinForms.Guna2ImageCheckBox
    Friend WithEvents BunifuPictureBox1 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuSeparator2 As Bunifu.UI.WinForms.BunifuSeparator
    Friend WithEvents lbluserstat As Label
    Friend WithEvents lblforgot As LinkLabel
End Class
