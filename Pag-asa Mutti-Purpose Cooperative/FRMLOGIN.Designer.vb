<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMLOGIN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMLOGIN))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties5 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties6 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties7 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties8 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel3 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Guna2CheckBox1 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.LBLFORGOT = New System.Windows.Forms.LinkLabel()
        Me.CHKEYE = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.BTNLOGIN = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuPictureBox1 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.TXTPASS = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.TXTUSN = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuLabel1.Location = New System.Drawing.Point(444, 229)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(53, 15)
        Me.BunifuLabel1.TabIndex = 3
        Me.BunifuLabel1.Text = "Username"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AllowParentOverrides = False
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.CursorType = Nothing
        Me.BunifuLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuLabel2.Location = New System.Drawing.Point(441, 291)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(50, 15)
        Me.BunifuLabel2.TabIndex = 4
        Me.BunifuLabel2.Text = "Password"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel3
        '
        Me.BunifuLabel3.AllowParentOverrides = False
        Me.BunifuLabel3.AutoEllipsis = False
        Me.BunifuLabel3.AutoSize = False
        Me.BunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel3.Location = New System.Drawing.Point(370, 137)
        Me.BunifuLabel3.Name = "BunifuLabel3"
        Me.BunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel3.Size = New System.Drawing.Size(413, 95)
        Me.BunifuLabel3.TabIndex = 5
        Me.BunifuLabel3.Text = "Welcome, to Pag-asa Multi-Purpose Cooperative"
        Me.BunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'Guna2CheckBox1
        '
        Me.Guna2CheckBox1.AutoSize = True
        Me.Guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CheckBox1.CheckedState.BorderRadius = 2
        Me.Guna2CheckBox1.CheckedState.BorderThickness = 0
        Me.Guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CheckBox1.ForeColor = System.Drawing.Color.Blue
        Me.Guna2CheckBox1.Location = New System.Drawing.Point(429, 354)
        Me.Guna2CheckBox1.Name = "Guna2CheckBox1"
        Me.Guna2CheckBox1.Size = New System.Drawing.Size(94, 17)
        Me.Guna2CheckBox1.TabIndex = 7
        Me.Guna2CheckBox1.Text = "Remember me"
        Me.Guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2CheckBox1.UncheckedState.BorderRadius = 2
        Me.Guna2CheckBox1.UncheckedState.BorderThickness = 0
        Me.Guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2CheckBox1.UseVisualStyleBackColor = True
        '
        'LBLFORGOT
        '
        Me.LBLFORGOT.AutoSize = True
        Me.LBLFORGOT.Location = New System.Drawing.Point(639, 355)
        Me.LBLFORGOT.Name = "LBLFORGOT"
        Me.LBLFORGOT.Size = New System.Drawing.Size(92, 13)
        Me.LBLFORGOT.TabIndex = 8
        Me.LBLFORGOT.TabStop = True
        Me.LBLFORGOT.Text = "Forgot Password?"
        '
        'CHKEYE
        '
        Me.CHKEYE.BackColor = System.Drawing.Color.Transparent
        Me.CHKEYE.CheckedState.Image = Global.Pag_asa_Mutti_Purpose_Cooperative.My.Resources.Resources.eye__1___1_
        Me.CHKEYE.CheckedState.Parent = Me.CHKEYE
        Me.CHKEYE.HoverState.Parent = Me.CHKEYE
        Me.CHKEYE.Image = Global.Pag_asa_Mutti_Purpose_Cooperative.My.Resources.Resources.eye__3_
        Me.CHKEYE.Location = New System.Drawing.Point(696, 305)
        Me.CHKEYE.Name = "CHKEYE"
        Me.CHKEYE.PressedState.Parent = Me.CHKEYE
        Me.CHKEYE.Size = New System.Drawing.Size(28, 22)
        Me.CHKEYE.TabIndex = 10
        Me.CHKEYE.UseTransparentBackground = True
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
        Me.BTNLOGIN.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNLOGIN.BackgroundImage = CType(resources.GetObject("BTNLOGIN.BackgroundImage"), System.Drawing.Image)
        Me.BTNLOGIN.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNLOGIN.ButtonText = "LOGIN"
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
        Me.BTNLOGIN.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.BTNLOGIN.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNLOGIN.IdleBorderRadius = 37
        Me.BTNLOGIN.IdleBorderThickness = 1
        Me.BTNLOGIN.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNLOGIN.IdleIconLeftImage = Nothing
        Me.BTNLOGIN.IdleIconRightImage = Nothing
        Me.BTNLOGIN.IndicateFocus = False
        Me.BTNLOGIN.Location = New System.Drawing.Point(471, 397)
        Me.BTNLOGIN.Name = "BTNLOGIN"
        Me.BTNLOGIN.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BTNLOGIN.OnDisabledState.BorderRadius = 37
        Me.BTNLOGIN.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNLOGIN.OnDisabledState.BorderThickness = 1
        Me.BTNLOGIN.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BTNLOGIN.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BTNLOGIN.OnDisabledState.IconLeftImage = Nothing
        Me.BTNLOGIN.OnDisabledState.IconRightImage = Nothing
        Me.BTNLOGIN.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNLOGIN.onHoverState.BorderRadius = 37
        Me.BTNLOGIN.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNLOGIN.onHoverState.BorderThickness = 1
        Me.BTNLOGIN.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNLOGIN.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BTNLOGIN.onHoverState.IconLeftImage = Nothing
        Me.BTNLOGIN.onHoverState.IconRightImage = Nothing
        Me.BTNLOGIN.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNLOGIN.OnIdleState.BorderRadius = 37
        Me.BTNLOGIN.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNLOGIN.OnIdleState.BorderThickness = 1
        Me.BTNLOGIN.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNLOGIN.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.BTNLOGIN.OnIdleState.IconLeftImage = Nothing
        Me.BTNLOGIN.OnIdleState.IconRightImage = Nothing
        Me.BTNLOGIN.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNLOGIN.OnPressedState.BorderRadius = 37
        Me.BTNLOGIN.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNLOGIN.OnPressedState.BorderThickness = 1
        Me.BTNLOGIN.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNLOGIN.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BTNLOGIN.OnPressedState.IconLeftImage = Nothing
        Me.BTNLOGIN.OnPressedState.IconRightImage = Nothing
        Me.BTNLOGIN.Size = New System.Drawing.Size(226, 39)
        Me.BTNLOGIN.TabIndex = 9
        Me.BTNLOGIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BTNLOGIN.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BTNLOGIN.TextMarginLeft = 0
        Me.BTNLOGIN.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BTNLOGIN.UseDefaultRadiusAndThickness = True
        '
        'BunifuPictureBox1
        '
        Me.BunifuPictureBox1.AllowFocused = False
        Me.BunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox1.AutoSizeHeight = True
        Me.BunifuPictureBox1.BorderRadius = 77
        Me.BunifuPictureBox1.Image = Global.Pag_asa_Mutti_Purpose_Cooperative.My.Resources.Resources.FB_IMG_1673280633955_removebg_preview
        Me.BunifuPictureBox1.IsCircle = True
        Me.BunifuPictureBox1.Location = New System.Drawing.Point(506, 1)
        Me.BunifuPictureBox1.Name = "BunifuPictureBox1"
        Me.BunifuPictureBox1.Size = New System.Drawing.Size(154, 154)
        Me.BunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuPictureBox1.TabIndex = 6
        Me.BunifuPictureBox1.TabStop = False
        Me.BunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle
        '
        'TXTPASS
        '
        Me.TXTPASS.AcceptsReturn = False
        Me.TXTPASS.AcceptsTab = False
        Me.TXTPASS.AnimationSpeed = 200
        Me.TXTPASS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TXTPASS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TXTPASS.BackColor = System.Drawing.Color.Transparent
        Me.TXTPASS.BackgroundImage = CType(resources.GetObject("TXTPASS.BackgroundImage"), System.Drawing.Image)
        Me.TXTPASS.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTPASS.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TXTPASS.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTPASS.BorderColorIdle = System.Drawing.Color.Silver
        Me.TXTPASS.BorderRadius = 1
        Me.TXTPASS.BorderThickness = 1
        Me.TXTPASS.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXTPASS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTPASS.DefaultFont = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.TXTPASS.DefaultText = ""
        Me.TXTPASS.FillColor = System.Drawing.Color.White
        Me.TXTPASS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTPASS.HideSelection = True
        Me.TXTPASS.IconLeft = Nothing
        Me.TXTPASS.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTPASS.IconPadding = 10
        Me.TXTPASS.IconRight = Nothing
        Me.TXTPASS.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTPASS.Lines = New String(-1) {}
        Me.TXTPASS.Location = New System.Drawing.Point(429, 298)
        Me.TXTPASS.MaxLength = 32767
        Me.TXTPASS.MinimumSize = New System.Drawing.Size(1, 1)
        Me.TXTPASS.Modified = False
        Me.TXTPASS.Multiline = False
        Me.TXTPASS.Name = "TXTPASS"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(255, Byte), Integer))
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
        StateProperties4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.TXTPASS.OnIdleState = StateProperties4
        Me.TXTPASS.Padding = New System.Windows.Forms.Padding(3)
        Me.TXTPASS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTPASS.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.TXTPASS.PlaceholderText = "Your password"
        Me.TXTPASS.ReadOnly = False
        Me.TXTPASS.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TXTPASS.SelectedText = ""
        Me.TXTPASS.SelectionLength = 0
        Me.TXTPASS.SelectionStart = 0
        Me.TXTPASS.ShortcutsEnabled = True
        Me.TXTPASS.Size = New System.Drawing.Size(302, 37)
        Me.TXTPASS.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.TXTPASS.TabIndex = 2
        Me.TXTPASS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXTPASS.TextMarginBottom = 0
        Me.TXTPASS.TextMarginLeft = 3
        Me.TXTPASS.TextMarginTop = 0
        Me.TXTPASS.TextPlaceholder = "Your password"
        Me.TXTPASS.UseSystemPasswordChar = False
        Me.TXTPASS.WordWrap = True
        '
        'TXTUSN
        '
        Me.TXTUSN.AcceptsReturn = False
        Me.TXTUSN.AcceptsTab = False
        Me.TXTUSN.AnimationSpeed = 200
        Me.TXTUSN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TXTUSN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TXTUSN.BackColor = System.Drawing.Color.Transparent
        Me.TXTUSN.BackgroundImage = CType(resources.GetObject("TXTUSN.BackgroundImage"), System.Drawing.Image)
        Me.TXTUSN.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTUSN.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TXTUSN.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTUSN.BorderColorIdle = System.Drawing.Color.Silver
        Me.TXTUSN.BorderRadius = 1
        Me.TXTUSN.BorderThickness = 1
        Me.TXTUSN.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXTUSN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTUSN.DefaultFont = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.TXTUSN.DefaultText = ""
        Me.TXTUSN.FillColor = System.Drawing.Color.White
        Me.TXTUSN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTUSN.HideSelection = True
        Me.TXTUSN.IconLeft = Nothing
        Me.TXTUSN.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTUSN.IconPadding = 10
        Me.TXTUSN.IconRight = Nothing
        Me.TXTUSN.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTUSN.Lines = New String(-1) {}
        Me.TXTUSN.Location = New System.Drawing.Point(429, 236)
        Me.TXTUSN.MaxLength = 32767
        Me.TXTUSN.MinimumSize = New System.Drawing.Size(1, 1)
        Me.TXTUSN.Modified = False
        Me.TXTUSN.Multiline = False
        Me.TXTUSN.Name = "TXTUSN"
        StateProperties5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(255, Byte), Integer))
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
        StateProperties8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.TXTUSN.OnIdleState = StateProperties8
        Me.TXTUSN.Padding = New System.Windows.Forms.Padding(3)
        Me.TXTUSN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTUSN.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.TXTUSN.PlaceholderText = "Your username"
        Me.TXTUSN.ReadOnly = False
        Me.TXTUSN.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TXTUSN.SelectedText = ""
        Me.TXTUSN.SelectionLength = 0
        Me.TXTUSN.SelectionStart = 0
        Me.TXTUSN.ShortcutsEnabled = True
        Me.TXTUSN.Size = New System.Drawing.Size(302, 37)
        Me.TXTUSN.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.TXTUSN.TabIndex = 1
        Me.TXTUSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXTUSN.TextMarginBottom = 0
        Me.TXTUSN.TextMarginLeft = 3
        Me.TXTUSN.TextMarginTop = 0
        Me.TXTUSN.TextPlaceholder = "Your username"
        Me.TXTUSN.UseSystemPasswordChar = False
        Me.TXTUSN.WordWrap = True
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.Pag_asa_Mutti_Purpose_Cooperative.My.Resources.Resources._38435_register__1_
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(365, 493)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'FRMLOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(788, 493)
        Me.Controls.Add(Me.CHKEYE)
        Me.Controls.Add(Me.BTNLOGIN)
        Me.Controls.Add(Me.LBLFORGOT)
        Me.Controls.Add(Me.Guna2CheckBox1)
        Me.Controls.Add(Me.BunifuPictureBox1)
        Me.Controls.Add(Me.BunifuLabel3)
        Me.Controls.Add(Me.BunifuLabel2)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Controls.Add(Me.TXTPASS)
        Me.Controls.Add(Me.TXTUSN)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRMLOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRMLOGIN"
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents TXTUSN As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents TXTPASS As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel3 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuPictureBox1 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents Guna2CheckBox1 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents LBLFORGOT As LinkLabel
    Friend WithEvents BTNLOGIN As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents CHKEYE As Guna.UI2.WinForms.Guna2ImageCheckBox
End Class
