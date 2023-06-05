Namespace S500RAT
	' Token: 0x0200003B RID: 59
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormXMR
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06001065 RID: 4197 RVA: 0x0008D6C0 File Offset: 0x0008B8C0
		<Global.System.Diagnostics.DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				Dim flag As Boolean = disposing AndAlso Me.components IsNot Nothing
				If flag Then
					Me.components.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x06001066 RID: 4198 RVA: 0x0008D710 File Offset: 0x0008B910
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormXMR))
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.UiLabel1 = New Global.Sunny.UI.UILabel()
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.GroupConfig = New Global.Guna.UI2.WinForms.Guna2GroupBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.InjectNotepad = New Global.Sunny.UI.UIRadioButton()
			Me.PictureBox36 = New Global.System.Windows.Forms.PictureBox()
			Me.InjectConhost = New Global.Sunny.UI.UIRadioButton()
			Me.InjectCmd = New Global.Sunny.UI.UIRadioButton()
			Me.PictureBox39 = New Global.System.Windows.Forms.PictureBox()
			Me.MiningWorkName = New Global.Guna.UI2.WinForms.Guna2TextBox()
			Me.MiningPool = New Global.Guna.UI2.WinForms.Guna2TextBox()
			Me.MiningWalletAddress = New Global.Guna.UI2.WinForms.Guna2TextBox()
			Me.GroupCoin = New Global.Guna.UI2.WinForms.Guna2GroupBox()
			Me.PictureBox41 = New Global.System.Windows.Forms.PictureBox()
			Me.ConDOGE = New Global.Sunny.UI.UIRadioButton()
			Me.PictureBox35 = New Global.System.Windows.Forms.PictureBox()
			Me.ConLSK = New Global.Sunny.UI.UIRadioButton()
			Me.PictureBox40 = New Global.System.Windows.Forms.PictureBox()
			Me.ConETH = New Global.Sunny.UI.UIRadioButton()
			Me.PictureBox34 = New Global.System.Windows.Forms.PictureBox()
			Me.PictureBox11 = New Global.System.Windows.Forms.PictureBox()
			Me.ConXMR = New Global.Sunny.UI.UIRadioButton()
			Me.ConBTC = New Global.Sunny.UI.UIRadioButton()
			Me.Label8 = New Global.System.Windows.Forms.Label()
			Me.PictureBox37 = New Global.System.Windows.Forms.PictureBox()
			Me.PanelCPUmax = New Global.Guna.UI2.WinForms.Guna2GroupBox()
			Me.Label13 = New Global.System.Windows.Forms.Label()
			Me.PictureBox38 = New Global.System.Windows.Forms.PictureBox()
			Me.MiningNumMax = New Global.Guna.UI2.WinForms.Guna2HtmlLabel()
			Me.MiningMAX = New Global.Guna.UI2.WinForms.Guna2TrackBar()
			Me.Power = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			Me.GroupConfig.SuspendLayout()
			CType(Me.PictureBox36, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.PictureBox39, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.GroupCoin.SuspendLayout()
			CType(Me.PictureBox41, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.PictureBox35, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.PictureBox40, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.PictureBox34, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.PictureBox11, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.PictureBox37, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.PanelCPUmax.SuspendLayout()
			CType(Me.PictureBox38, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.Guna2BorderlessForm1.AnimateWindow = True
			Me.Guna2BorderlessForm1.BorderRadius = 40
			Me.Guna2BorderlessForm1.ContainerControl = Me
			Me.Guna2BorderlessForm1.DockIndicatorColor = Global.System.Drawing.Color.FromArgb(56, 37, 200)
			Me.Guna2BorderlessForm1.ResizeForm = False
			Me.Guna2BorderlessForm1.ShadowColor = Global.System.Drawing.Color.FromArgb(56, 37, 200)
			Me.Timer1.Interval = 2000
			Me.UiLabel1.AutoSize = True
			Me.UiLabel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel1.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel1.Location = New Global.System.Drawing.Point(10, 8)
			Me.UiLabel1.Name = "UiLabel1"
			Me.UiLabel1.Size = New Global.System.Drawing.Size(55, 19)
			Me.UiLabel1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLabel1.TabIndex = 319
			Me.UiLabel1.Text = "Mining"
			Me.UiLabel1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(11, 32)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(200, 16)
			Me.ClientInfo.TabIndex = 320
			Me.ClientInfo.Text = "FC / Desktop_3424 / Windows 10 pro"
			Me.GroupConfig.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.GroupConfig.BorderColor = Global.System.Drawing.Color.FromArgb(33, 11, 77)
			Me.GroupConfig.Controls.Add(Me.Label1)
			Me.GroupConfig.Controls.Add(Me.InjectNotepad)
			Me.GroupConfig.Controls.Add(Me.PictureBox36)
			Me.GroupConfig.Controls.Add(Me.InjectConhost)
			Me.GroupConfig.Controls.Add(Me.InjectCmd)
			Me.GroupConfig.Controls.Add(Me.PictureBox39)
			Me.GroupConfig.Controls.Add(Me.MiningWorkName)
			Me.GroupConfig.Controls.Add(Me.MiningPool)
			Me.GroupConfig.Controls.Add(Me.MiningWalletAddress)
			Me.GroupConfig.CustomBorderColor = Global.System.Drawing.Color.Empty
			Me.GroupConfig.Enabled = False
			Me.GroupConfig.FillColor = Global.System.Drawing.Color.Empty
			Me.GroupConfig.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.GroupConfig.ForeColor = Global.System.Drawing.Color.White
			Me.GroupConfig.Location = New Global.System.Drawing.Point(15, 222)
			Me.GroupConfig.Name = "GroupConfig"
			Me.GroupConfig.ShadowDecoration.Parent = Me.GroupConfig
			Me.GroupConfig.Size = New Global.System.Drawing.Size(435, 266)
			Me.GroupConfig.TabIndex = 442
			Me.GroupConfig.Text = "Configuration"
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Label1.ForeColor = Global.System.Drawing.Color.White
			Me.Label1.Location = New Global.System.Drawing.Point(11, 199)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(103, 14)
			Me.Label1.TabIndex = 429
			Me.Label1.Text = "Injection Process"
			Me.InjectNotepad.BackColor = Global.System.Drawing.Color.Transparent
			Me.InjectNotepad.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.InjectNotepad.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.InjectNotepad.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.InjectNotepad.Location = New Global.System.Drawing.Point(12, 227)
			Me.InjectNotepad.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.InjectNotepad.Name = "InjectNotepad"
			Me.InjectNotepad.Padding = New Global.System.Windows.Forms.Padding(22, 0, 0, 0)
			Me.InjectNotepad.RadioButtonColor = Global.System.Drawing.Color.FromArgb(84, 43, 244)
			Me.InjectNotepad.Size = New Global.System.Drawing.Size(90, 17)
			Me.InjectNotepad.Style = Global.Sunny.UI.UIStyle.Custom
			Me.InjectNotepad.TabIndex = 428
			Me.InjectNotepad.Text = "notepad.exe"
			Me.PictureBox36.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.PictureBox36.Image = CType(componentResourceManager.GetObject("PictureBox36.Image"), Global.System.Drawing.Image)
			Me.PictureBox36.Location = New Global.System.Drawing.Point(396, 207)
			Me.PictureBox36.Name = "PictureBox36"
			Me.PictureBox36.Size = New Global.System.Drawing.Size(24, 24)
			Me.PictureBox36.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.AutoSize
			Me.PictureBox36.TabIndex = 423
			Me.PictureBox36.TabStop = False
			Me.InjectConhost.BackColor = Global.System.Drawing.Color.Transparent
			Me.InjectConhost.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.InjectConhost.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.InjectConhost.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.InjectConhost.Location = New Global.System.Drawing.Point(197, 227)
			Me.InjectConhost.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.InjectConhost.Name = "InjectConhost"
			Me.InjectConhost.Padding = New Global.System.Windows.Forms.Padding(22, 0, 0, 0)
			Me.InjectConhost.RadioButtonColor = Global.System.Drawing.Color.FromArgb(84, 43, 244)
			Me.InjectConhost.Size = New Global.System.Drawing.Size(90, 17)
			Me.InjectConhost.Style = Global.Sunny.UI.UIStyle.Custom
			Me.InjectConhost.TabIndex = 427
			Me.InjectConhost.Text = "conhost.exe"
			Me.InjectCmd.BackColor = Global.System.Drawing.Color.Transparent
			Me.InjectCmd.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.InjectCmd.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.InjectCmd.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.InjectCmd.Location = New Global.System.Drawing.Point(115, 227)
			Me.InjectCmd.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.InjectCmd.Name = "InjectCmd"
			Me.InjectCmd.Padding = New Global.System.Windows.Forms.Padding(22, 0, 0, 0)
			Me.InjectCmd.RadioButtonColor = Global.System.Drawing.Color.FromArgb(84, 43, 244)
			Me.InjectCmd.Size = New Global.System.Drawing.Size(69, 17)
			Me.InjectCmd.Style = Global.Sunny.UI.UIStyle.Custom
			Me.InjectCmd.TabIndex = 426
			Me.InjectCmd.Text = "cmd.exe"
			Me.PictureBox39.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.PictureBox39.Image = CType(componentResourceManager.GetObject("PictureBox39.Image"), Global.System.Drawing.Image)
			Me.PictureBox39.Location = New Global.System.Drawing.Point(405, 9)
			Me.PictureBox39.Name = "PictureBox39"
			Me.PictureBox39.Size = New Global.System.Drawing.Size(24, 24)
			Me.PictureBox39.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.AutoSize
			Me.PictureBox39.TabIndex = 423
			Me.PictureBox39.TabStop = False
			Me.MiningWorkName.Animated = True
			Me.MiningWorkName.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.MiningWorkName.BorderColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.MiningWorkName.BorderRadius = 5
			Me.MiningWorkName.BorderStyle = Global.System.Drawing.Drawing2D.DashStyle.Custom
			Me.MiningWorkName.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.MiningWorkName.DefaultText = ""
			Me.MiningWorkName.DisabledState.BorderColor = Global.System.Drawing.Color.FromArgb(208, 208, 208)
			Me.MiningWorkName.DisabledState.FillColor = Global.System.Drawing.Color.FromArgb(226, 226, 226)
			Me.MiningWorkName.DisabledState.ForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.MiningWorkName.DisabledState.Parent = Me.MiningWorkName
			Me.MiningWorkName.DisabledState.PlaceholderForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.MiningWorkName.Enabled = False
			Me.MiningWorkName.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.MiningWorkName.FocusedState.BorderColor = Global.System.Drawing.Color.FromArgb(84, 43, 244)
			Me.MiningWorkName.FocusedState.Parent = Me.MiningWorkName
			Me.MiningWorkName.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 9F, Global.System.Drawing.FontStyle.Bold)
			Me.MiningWorkName.ForeColor = Global.System.Drawing.Color.WhiteSmoke
			Me.MiningWorkName.HoverState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.MiningWorkName.HoverState.Parent = Me.MiningWorkName
			Me.MiningWorkName.IconLeft = CType(componentResourceManager.GetObject("MiningWorkName.IconLeft"), Global.System.Drawing.Image)
			Me.MiningWorkName.Location = New Global.System.Drawing.Point(14, 64)
			Me.MiningWorkName.Margin = New Global.System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.MiningWorkName.Name = "MiningWorkName"
			Me.MiningWorkName.PasswordChar = vbNullChar
			Me.MiningWorkName.PlaceholderForeColor = Global.System.Drawing.Color.Gray
			Me.MiningWorkName.PlaceholderText = "Worker Name"
			Me.MiningWorkName.SelectedText = ""
			Me.MiningWorkName.ShadowDecoration.Parent = Me.MiningWorkName
			Me.MiningWorkName.Size = New Global.System.Drawing.Size(409, 27)
			Me.MiningWorkName.TabIndex = 394
			Me.MiningWorkName.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.MiningPool.Animated = True
			Me.MiningPool.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.MiningPool.BorderColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.MiningPool.BorderRadius = 5
			Me.MiningPool.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.MiningPool.DefaultText = ""
			Me.MiningPool.DisabledState.BorderColor = Global.System.Drawing.Color.FromArgb(208, 208, 208)
			Me.MiningPool.DisabledState.FillColor = Global.System.Drawing.Color.FromArgb(226, 226, 226)
			Me.MiningPool.DisabledState.ForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.MiningPool.DisabledState.Parent = Me.MiningPool
			Me.MiningPool.DisabledState.PlaceholderForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.MiningPool.Enabled = False
			Me.MiningPool.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.MiningPool.FocusedState.BorderColor = Global.System.Drawing.Color.FromArgb(84, 43, 244)
			Me.MiningPool.FocusedState.Parent = Me.MiningPool
			Me.MiningPool.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 9F, Global.System.Drawing.FontStyle.Bold)
			Me.MiningPool.ForeColor = Global.System.Drawing.Color.White
			Me.MiningPool.HoverState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.MiningPool.HoverState.Parent = Me.MiningPool
			Me.MiningPool.IconLeft = CType(componentResourceManager.GetObject("MiningPool.IconLeft"), Global.System.Drawing.Image)
			Me.MiningPool.Location = New Global.System.Drawing.Point(14, 153)
			Me.MiningPool.Margin = New Global.System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.MiningPool.Name = "MiningPool"
			Me.MiningPool.PasswordChar = vbNullChar
			Me.MiningPool.PlaceholderForeColor = Global.System.Drawing.Color.Gray
			Me.MiningPool.PlaceholderText = "Mining Pool Address (Pool:Port)"
			Me.MiningPool.SelectedText = ""
			Me.MiningPool.ShadowDecoration.Parent = Me.MiningPool
			Me.MiningPool.Size = New Global.System.Drawing.Size(409, 27)
			Me.MiningPool.TabIndex = 396
			Me.MiningPool.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.MiningWalletAddress.Animated = True
			Me.MiningWalletAddress.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.MiningWalletAddress.BorderColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.MiningWalletAddress.BorderRadius = 5
			Me.MiningWalletAddress.BorderStyle = Global.System.Drawing.Drawing2D.DashStyle.Custom
			Me.MiningWalletAddress.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.MiningWalletAddress.DefaultText = ""
			Me.MiningWalletAddress.DisabledState.BorderColor = Global.System.Drawing.Color.FromArgb(208, 208, 208)
			Me.MiningWalletAddress.DisabledState.FillColor = Global.System.Drawing.Color.FromArgb(226, 226, 226)
			Me.MiningWalletAddress.DisabledState.ForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.MiningWalletAddress.DisabledState.Parent = Me.MiningWalletAddress
			Me.MiningWalletAddress.DisabledState.PlaceholderForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.MiningWalletAddress.Enabled = False
			Me.MiningWalletAddress.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.MiningWalletAddress.FocusedState.BorderColor = Global.System.Drawing.Color.FromArgb(84, 43, 244)
			Me.MiningWalletAddress.FocusedState.Parent = Me.MiningWalletAddress
			Me.MiningWalletAddress.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 9F, Global.System.Drawing.FontStyle.Bold)
			Me.MiningWalletAddress.ForeColor = Global.System.Drawing.Color.White
			Me.MiningWalletAddress.HoverState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.MiningWalletAddress.HoverState.Parent = Me.MiningWalletAddress
			Me.MiningWalletAddress.IconLeft = CType(componentResourceManager.GetObject("MiningWalletAddress.IconLeft"), Global.System.Drawing.Image)
			Me.MiningWalletAddress.Location = New Global.System.Drawing.Point(14, 108)
			Me.MiningWalletAddress.Margin = New Global.System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.MiningWalletAddress.Name = "MiningWalletAddress"
			Me.MiningWalletAddress.PasswordChar = vbNullChar
			Me.MiningWalletAddress.PlaceholderForeColor = Global.System.Drawing.Color.Gray
			Me.MiningWalletAddress.PlaceholderText = "Wallet Address"
			Me.MiningWalletAddress.SelectedText = ""
			Me.MiningWalletAddress.ShadowDecoration.Parent = Me.MiningWalletAddress
			Me.MiningWalletAddress.Size = New Global.System.Drawing.Size(409, 27)
			Me.MiningWalletAddress.TabIndex = 395
			Me.MiningWalletAddress.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.GroupCoin.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.GroupCoin.BorderColor = Global.System.Drawing.Color.FromArgb(33, 11, 77)
			Me.GroupCoin.Controls.Add(Me.PictureBox41)
			Me.GroupCoin.Controls.Add(Me.ConDOGE)
			Me.GroupCoin.Controls.Add(Me.PictureBox35)
			Me.GroupCoin.Controls.Add(Me.ConLSK)
			Me.GroupCoin.Controls.Add(Me.PictureBox40)
			Me.GroupCoin.Controls.Add(Me.ConETH)
			Me.GroupCoin.Controls.Add(Me.PictureBox34)
			Me.GroupCoin.Controls.Add(Me.PictureBox11)
			Me.GroupCoin.Controls.Add(Me.ConXMR)
			Me.GroupCoin.Controls.Add(Me.ConBTC)
			Me.GroupCoin.Controls.Add(Me.Label8)
			Me.GroupCoin.Controls.Add(Me.PictureBox37)
			Me.GroupCoin.CustomBorderColor = Global.System.Drawing.Color.Empty
			Me.GroupCoin.Enabled = False
			Me.GroupCoin.FillColor = Global.System.Drawing.Color.Empty
			Me.GroupCoin.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.GroupCoin.ForeColor = Global.System.Drawing.Color.White
			Me.GroupCoin.Location = New Global.System.Drawing.Point(15, 77)
			Me.GroupCoin.Name = "GroupCoin"
			Me.GroupCoin.ShadowDecoration.Parent = Me.GroupCoin
			Me.GroupCoin.Size = New Global.System.Drawing.Size(435, 139)
			Me.GroupCoin.TabIndex = 441
			Me.GroupCoin.Text = "Cryptocurrency"
			Me.PictureBox41.Image = CType(componentResourceManager.GetObject("PictureBox41.Image"), Global.System.Drawing.Image)
			Me.PictureBox41.Location = New Global.System.Drawing.Point(288, 61)
			Me.PictureBox41.Name = "PictureBox41"
			Me.PictureBox41.Size = New Global.System.Drawing.Size(23, 28)
			Me.PictureBox41.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox41.TabIndex = 423
			Me.PictureBox41.TabStop = False
			Me.ConDOGE.BackColor = Global.System.Drawing.Color.Transparent
			Me.ConDOGE.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ConDOGE.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ConDOGE.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.ConDOGE.Location = New Global.System.Drawing.Point(315, 68)
			Me.ConDOGE.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.ConDOGE.Name = "ConDOGE"
			Me.ConDOGE.Padding = New Global.System.Windows.Forms.Padding(22, 0, 0, 0)
			Me.ConDOGE.RadioButtonColor = Global.System.Drawing.Color.FromArgb(84, 43, 244)
			Me.ConDOGE.Size = New Global.System.Drawing.Size(107, 17)
			Me.ConDOGE.Style = Global.Sunny.UI.UIStyle.Custom
			Me.ConDOGE.TabIndex = 389
			Me.ConDOGE.Text = "Dogecoin [ DOGE ]"
			Me.PictureBox35.Image = CType(componentResourceManager.GetObject("PictureBox35.Image"), Global.System.Drawing.Image)
			Me.PictureBox35.Location = New Global.System.Drawing.Point(150, 98)
			Me.PictureBox35.Name = "PictureBox35"
			Me.PictureBox35.Size = New Global.System.Drawing.Size(23, 28)
			Me.PictureBox35.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox35.TabIndex = 423
			Me.PictureBox35.TabStop = False
			Me.ConLSK.BackColor = Global.System.Drawing.Color.Transparent
			Me.ConLSK.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ConLSK.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ConLSK.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.ConLSK.Location = New Global.System.Drawing.Point(178, 105)
			Me.ConLSK.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.ConLSK.Name = "ConLSK"
			Me.ConLSK.Padding = New Global.System.Windows.Forms.Padding(22, 0, 0, 0)
			Me.ConLSK.RadioButtonColor = Global.System.Drawing.Color.FromArgb(84, 43, 244)
			Me.ConLSK.Size = New Global.System.Drawing.Size(96, 17)
			Me.ConLSK.Style = Global.Sunny.UI.UIStyle.Custom
			Me.ConLSK.TabIndex = 389
			Me.ConLSK.Text = "Lisk [ LSK ]"
			Me.PictureBox40.Image = CType(componentResourceManager.GetObject("PictureBox40.Image"), Global.System.Drawing.Image)
			Me.PictureBox40.Location = New Global.System.Drawing.Point(150, 61)
			Me.PictureBox40.Name = "PictureBox40"
			Me.PictureBox40.Size = New Global.System.Drawing.Size(23, 28)
			Me.PictureBox40.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox40.TabIndex = 423
			Me.PictureBox40.TabStop = False
			Me.ConETH.BackColor = Global.System.Drawing.Color.Transparent
			Me.ConETH.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ConETH.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ConETH.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.ConETH.Location = New Global.System.Drawing.Point(178, 68)
			Me.ConETH.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.ConETH.Name = "ConETH"
			Me.ConETH.Padding = New Global.System.Windows.Forms.Padding(22, 0, 0, 0)
			Me.ConETH.RadioButtonColor = Global.System.Drawing.Color.FromArgb(84, 43, 244)
			Me.ConETH.Size = New Global.System.Drawing.Size(96, 17)
			Me.ConETH.Style = Global.Sunny.UI.UIStyle.Custom
			Me.ConETH.TabIndex = 389
			Me.ConETH.Text = "Ethereum [ ETH ]"
			Me.PictureBox34.Image = CType(componentResourceManager.GetObject("PictureBox34.Image"), Global.System.Drawing.Image)
			Me.PictureBox34.Location = New Global.System.Drawing.Point(15, 98)
			Me.PictureBox34.Name = "PictureBox34"
			Me.PictureBox34.Size = New Global.System.Drawing.Size(23, 28)
			Me.PictureBox34.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.Zoom
			Me.PictureBox34.TabIndex = 423
			Me.PictureBox34.TabStop = False
			Me.PictureBox11.Image = CType(componentResourceManager.GetObject("PictureBox11.Image"), Global.System.Drawing.Image)
			Me.PictureBox11.Location = New Global.System.Drawing.Point(15, 61)
			Me.PictureBox11.Name = "PictureBox11"
			Me.PictureBox11.Size = New Global.System.Drawing.Size(23, 28)
			Me.PictureBox11.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.Zoom
			Me.PictureBox11.TabIndex = 423
			Me.PictureBox11.TabStop = False
			Me.ConXMR.BackColor = Global.System.Drawing.Color.Transparent
			Me.ConXMR.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ConXMR.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ConXMR.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.ConXMR.Location = New Global.System.Drawing.Point(44, 105)
			Me.ConXMR.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.ConXMR.Name = "ConXMR"
			Me.ConXMR.Padding = New Global.System.Windows.Forms.Padding(22, 0, 0, 0)
			Me.ConXMR.RadioButtonColor = Global.System.Drawing.Color.FromArgb(84, 43, 244)
			Me.ConXMR.Size = New Global.System.Drawing.Size(99, 17)
			Me.ConXMR.Style = Global.Sunny.UI.UIStyle.Custom
			Me.ConXMR.TabIndex = 389
			Me.ConXMR.Text = "Monero [ XMR ]"
			Me.ConBTC.BackColor = Global.System.Drawing.Color.Transparent
			Me.ConBTC.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ConBTC.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ConBTC.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.ConBTC.Location = New Global.System.Drawing.Point(44, 68)
			Me.ConBTC.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.ConBTC.Name = "ConBTC"
			Me.ConBTC.Padding = New Global.System.Windows.Forms.Padding(22, 0, 0, 0)
			Me.ConBTC.RadioButtonColor = Global.System.Drawing.Color.FromArgb(84, 43, 244)
			Me.ConBTC.Size = New Global.System.Drawing.Size(99, 17)
			Me.ConBTC.Style = Global.Sunny.UI.UIStyle.Custom
			Me.ConBTC.TabIndex = 389
			Me.ConBTC.Text = "Bitcoin [ BTC ]"
			Me.Label8.AutoSize = True
			Me.Label8.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label8.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.Label8.Location = New Global.System.Drawing.Point(9, 30)
			Me.Label8.Name = "Label8"
			Me.Label8.Size = New Global.System.Drawing.Size(156, 13)
			Me.Label8.TabIndex = 405
			Me.Label8.Text = "Choose Crypto Currency Type"
			Me.PictureBox37.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.PictureBox37.Image = CType(componentResourceManager.GetObject("PictureBox37.Image"), Global.System.Drawing.Image)
			Me.PictureBox37.Location = New Global.System.Drawing.Point(405, 9)
			Me.PictureBox37.Name = "PictureBox37"
			Me.PictureBox37.Size = New Global.System.Drawing.Size(20, 20)
			Me.PictureBox37.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.AutoSize
			Me.PictureBox37.TabIndex = 423
			Me.PictureBox37.TabStop = False
			Me.PanelCPUmax.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.PanelCPUmax.BorderColor = Global.System.Drawing.Color.FromArgb(33, 11, 77)
			Me.PanelCPUmax.Controls.Add(Me.Label13)
			Me.PanelCPUmax.Controls.Add(Me.PictureBox38)
			Me.PanelCPUmax.Controls.Add(Me.MiningNumMax)
			Me.PanelCPUmax.Controls.Add(Me.MiningMAX)
			Me.PanelCPUmax.CustomBorderColor = Global.System.Drawing.Color.Empty
			Me.PanelCPUmax.Enabled = False
			Me.PanelCPUmax.FillColor = Global.System.Drawing.Color.Empty
			Me.PanelCPUmax.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.PanelCPUmax.ForeColor = Global.System.Drawing.Color.White
			Me.PanelCPUmax.Location = New Global.System.Drawing.Point(15, 493)
			Me.PanelCPUmax.Name = "PanelCPUmax"
			Me.PanelCPUmax.ShadowDecoration.Parent = Me.PanelCPUmax
			Me.PanelCPUmax.Size = New Global.System.Drawing.Size(435, 92)
			Me.PanelCPUmax.TabIndex = 443
			Me.PanelCPUmax.Text = "CPU Usage"
			Me.Label13.AutoSize = True
			Me.Label13.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label13.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.Label13.Location = New Global.System.Drawing.Point(9, 30)
			Me.Label13.Name = "Label13"
			Me.Label13.Size = New Global.System.Drawing.Size(334, 13)
			Me.Label13.TabIndex = 405
			Me.Label13.Text = "Determine the percentage of mining consumption from the cpu"
			Me.PictureBox38.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.PictureBox38.Image = CType(componentResourceManager.GetObject("PictureBox38.Image"), Global.System.Drawing.Image)
			Me.PictureBox38.Location = New Global.System.Drawing.Point(405, 9)
			Me.PictureBox38.Name = "PictureBox38"
			Me.PictureBox38.Size = New Global.System.Drawing.Size(24, 24)
			Me.PictureBox38.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.AutoSize
			Me.PictureBox38.TabIndex = 423
			Me.PictureBox38.TabStop = False
			Me.MiningNumMax.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.MiningNumMax.BackColor = Global.System.Drawing.Color.Transparent
			Me.MiningNumMax.Font = New Global.System.Drawing.Font("Nirmala UI", 15.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.MiningNumMax.ForeColor = Global.System.Drawing.Color.White
			Me.MiningNumMax.Location = New Global.System.Drawing.Point(376, 52)
			Me.MiningNumMax.Name = "MiningNumMax"
			Me.MiningNumMax.Size = New Global.System.Drawing.Size(45, 32)
			Me.MiningNumMax.TabIndex = 397
			Me.MiningNumMax.Text = "40%"
			Me.MiningMAX.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.MiningMAX.HoverState.Parent = Me.MiningMAX
			Me.MiningMAX.IndicateFocus = False
			Me.MiningMAX.Location = New Global.System.Drawing.Point(19, 58)
			Me.MiningMAX.Name = "MiningMAX"
			Me.MiningMAX.Size = New Global.System.Drawing.Size(352, 28)
			Me.MiningMAX.TabIndex = 398
			Me.MiningMAX.ThumbColor = Global.System.Drawing.Color.Silver
			Me.Power.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Power.BackColor = Global.System.Drawing.Color.Transparent
			Me.Power.BorderRadius = 8
			Me.Power.CheckedState.Parent = Me.Power
			Me.Power.CustomImages.Parent = Me.Power
			Me.Power.Enabled = False
			Me.Power.FillColor = Global.System.Drawing.Color.Teal
			Me.Power.FillColor2 = Global.System.Drawing.Color.Teal
			Me.Power.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Power.ForeColor = Global.System.Drawing.Color.White
			Me.Power.HoverState.Parent = Me.Power
			Me.Power.Location = New Global.System.Drawing.Point(331, 591)
			Me.Power.Name = "Power"
			Me.Power.ShadowDecoration.Parent = Me.Power
			Me.Power.Size = New Global.System.Drawing.Size(117, 28)
			Me.Power.TabIndex = 488
			Me.Power.Text = "Start"
			Me.Mini.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Mini.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Mini.Location = New Global.System.Drawing.Point(406, 12)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 562
			Me.Mini.Text = "ValleyMini1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(432, 12)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 560
			Me.ExitForm.Text = "ValleyClose1"
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(96F, 96F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Dpi
			Me.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			MyBase.ClientSize = New Global.System.Drawing.Size(464, 632)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.Power)
			MyBase.Controls.Add(Me.GroupConfig)
			MyBase.Controls.Add(Me.GroupCoin)
			MyBase.Controls.Add(Me.PanelCPUmax)
			MyBase.Controls.Add(Me.UiLabel1)
			MyBase.Controls.Add(Me.ClientInfo)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Name = "FormXMR"
			Me.Text = "FormXMR"
			MyBase.TopMost = True
			Me.GroupConfig.ResumeLayout(False)
			Me.GroupConfig.PerformLayout()
			CType(Me.PictureBox36, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.PictureBox39, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.GroupCoin.ResumeLayout(False)
			Me.GroupCoin.PerformLayout()
			CType(Me.PictureBox41, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.PictureBox35, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.PictureBox40, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.PictureBox34, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.PictureBox11, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.PictureBox37, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.PanelCPUmax.ResumeLayout(False)
			Me.PanelCPUmax.PerformLayout()
			CType(Me.PictureBox38, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x04000758 RID: 1880
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
