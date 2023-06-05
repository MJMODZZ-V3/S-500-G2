Namespace S500RAT
	' Token: 0x02000025 RID: 37
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormOptions
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600066F RID: 1647 RVA: 0x00036E1C File Offset: 0x0003501C
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

		' Token: 0x06000670 RID: 1648 RVA: 0x00036E6C File Offset: 0x0003506C
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormOptions))
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.UiLabel1 = New Global.Sunny.UI.UILabel()
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.DisabledWD = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.StateWD = New Global.Sunny.UI.UILabel()
			Me.UiLabel18 = New Global.Sunny.UI.UILabel()
			Me.DisabledControl = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.PictureBox3 = New Global.System.Windows.Forms.PictureBox()
			Me.StateControlPanel = New Global.Sunny.UI.UILabel()
			Me.UiLabel7 = New Global.Sunny.UI.UILabel()
			Me.DisabledUAC = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.PictureBox4 = New Global.System.Windows.Forms.PictureBox()
			Me.StateUAC = New Global.Sunny.UI.UILabel()
			Me.UiLabel10 = New Global.Sunny.UI.UILabel()
			Me.DisabledRegistry = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.PictureBox5 = New Global.System.Windows.Forms.PictureBox()
			Me.StateRegistry = New Global.Sunny.UI.UILabel()
			Me.UiLabel13 = New Global.Sunny.UI.UILabel()
			Me.DisabledFirewall = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.PictureBox6 = New Global.System.Windows.Forms.PictureBox()
			Me.StateFirewall = New Global.Sunny.UI.UILabel()
			Me.UiLabel16 = New Global.Sunny.UI.UILabel()
			Me.EnabledAntiProcess = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.PictureBox7 = New Global.System.Windows.Forms.PictureBox()
			Me.StateAntiprocess = New Global.Sunny.UI.UILabel()
			Me.UiLabel3 = New Global.Sunny.UI.UILabel()
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.PictureBox3, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.PictureBox4, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.PictureBox5, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.PictureBox6, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.PictureBox7, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.Timer1.Interval = 2000
			Me.UiLabel1.AutoSize = True
			Me.UiLabel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel1.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel1.Location = New Global.System.Drawing.Point(20, 15)
			Me.UiLabel1.Name = "UiLabel1"
			Me.UiLabel1.Size = New Global.System.Drawing.Size(61, 19)
			Me.UiLabel1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLabel1.TabIndex = 339
			Me.UiLabel1.Text = "Options"
			Me.UiLabel1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(21, 39)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(200, 16)
			Me.ClientInfo.TabIndex = 340
			Me.ClientInfo.Text = "FC / Desktop_3424 / Windows 10 pro"
			Me.DisabledWD.BackColor = Global.System.Drawing.Color.Transparent
			Me.DisabledWD.BorderRadius = 8
			Me.DisabledWD.CheckedState.Parent = Me.DisabledWD
			Me.DisabledWD.CustomImages.Parent = Me.DisabledWD
			Me.DisabledWD.FillColor = Global.System.Drawing.Color.FromArgb(3, 112, 200)
			Me.DisabledWD.FillColor2 = Global.System.Drawing.Color.FromArgb(51, 191, 240)
			Me.DisabledWD.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.DisabledWD.ForeColor = Global.System.Drawing.Color.White
			Me.DisabledWD.HoverState.Parent = Me.DisabledWD
			Me.DisabledWD.Location = New Global.System.Drawing.Point(209, 171)
			Me.DisabledWD.Name = "DisabledWD"
			Me.DisabledWD.ShadowDecoration.Parent = Me.DisabledWD
			Me.DisabledWD.Size = New Global.System.Drawing.Size(126, 30)
			Me.DisabledWD.TabIndex = 484
			Me.DisabledWD.Text = "Disabled"
			Me.PictureBox1.Image = CType(componentResourceManager.GetObject("PictureBox1.Image"), Global.System.Drawing.Image)
			Me.PictureBox1.Location = New Global.System.Drawing.Point(28, 169)
			Me.PictureBox1.Name = "PictureBox1"
			Me.PictureBox1.Size = New Global.System.Drawing.Size(27, 26)
			Me.PictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.Zoom
			Me.PictureBox1.TabIndex = 448
			Me.PictureBox1.TabStop = False
			Me.StateWD.BackColor = Global.System.Drawing.Color.Transparent
			Me.StateWD.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.StateWD.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F)
			Me.StateWD.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 155)
			Me.StateWD.Location = New Global.System.Drawing.Point(21, 134)
			Me.StateWD.Name = "StateWD"
			Me.StateWD.Size = New Global.System.Drawing.Size(314, 21)
			Me.StateWD.TabIndex = 447
			Me.StateWD.Text = "..."
			Me.StateWD.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.UiLabel18.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel18.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold)
			Me.UiLabel18.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel18.Location = New Global.System.Drawing.Point(17, 108)
			Me.UiLabel18.Name = "UiLabel18"
			Me.UiLabel18.Size = New Global.System.Drawing.Size(198, 21)
			Me.UiLabel18.TabIndex = 445
			Me.UiLabel18.Text = "Windows Defender"
			Me.UiLabel18.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.DisabledControl.BackColor = Global.System.Drawing.Color.Transparent
			Me.DisabledControl.BorderRadius = 8
			Me.DisabledControl.CheckedState.Parent = Me.DisabledControl
			Me.DisabledControl.CustomImages.Parent = Me.DisabledControl
			Me.DisabledControl.FillColor = Global.System.Drawing.Color.FromArgb(24, 99, 250)
			Me.DisabledControl.FillColor2 = Global.System.Drawing.Color.FromArgb(24, 99, 250)
			Me.DisabledControl.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.DisabledControl.ForeColor = Global.System.Drawing.Color.White
			Me.DisabledControl.HoverState.Parent = Me.DisabledControl
			Me.DisabledControl.Location = New Global.System.Drawing.Point(209, 285)
			Me.DisabledControl.Name = "DisabledControl"
			Me.DisabledControl.ShadowDecoration.Parent = Me.DisabledControl
			Me.DisabledControl.Size = New Global.System.Drawing.Size(126, 30)
			Me.DisabledControl.TabIndex = 484
			Me.DisabledControl.Text = "Disabled"
			Me.PictureBox3.Image = CType(componentResourceManager.GetObject("PictureBox3.Image"), Global.System.Drawing.Image)
			Me.PictureBox3.Location = New Global.System.Drawing.Point(28, 285)
			Me.PictureBox3.Name = "PictureBox3"
			Me.PictureBox3.Size = New Global.System.Drawing.Size(27, 26)
			Me.PictureBox3.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.Zoom
			Me.PictureBox3.TabIndex = 448
			Me.PictureBox3.TabStop = False
			Me.StateControlPanel.BackColor = Global.System.Drawing.Color.Transparent
			Me.StateControlPanel.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.StateControlPanel.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F)
			Me.StateControlPanel.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 155)
			Me.StateControlPanel.Location = New Global.System.Drawing.Point(21, 250)
			Me.StateControlPanel.Name = "StateControlPanel"
			Me.StateControlPanel.Size = New Global.System.Drawing.Size(314, 21)
			Me.StateControlPanel.TabIndex = 447
			Me.StateControlPanel.Text = ".."
			Me.StateControlPanel.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.UiLabel7.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel7.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold)
			Me.UiLabel7.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel7.Location = New Global.System.Drawing.Point(17, 222)
			Me.UiLabel7.Name = "UiLabel7"
			Me.UiLabel7.Size = New Global.System.Drawing.Size(198, 21)
			Me.UiLabel7.TabIndex = 445
			Me.UiLabel7.Text = "Control Panel "
			Me.UiLabel7.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.DisabledUAC.BackColor = Global.System.Drawing.Color.Transparent
			Me.DisabledUAC.BorderRadius = 8
			Me.DisabledUAC.CheckedState.Parent = Me.DisabledUAC
			Me.DisabledUAC.CustomImages.Parent = Me.DisabledUAC
			Me.DisabledUAC.FillColor = Global.System.Drawing.Color.FromArgb(5, 105, 188)
			Me.DisabledUAC.FillColor2 = Global.System.Drawing.Color.FromArgb(5, 105, 188)
			Me.DisabledUAC.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.DisabledUAC.ForeColor = Global.System.Drawing.Color.White
			Me.DisabledUAC.HoverState.Parent = Me.DisabledUAC
			Me.DisabledUAC.Location = New Global.System.Drawing.Point(572, 395)
			Me.DisabledUAC.Name = "DisabledUAC"
			Me.DisabledUAC.ShadowDecoration.Parent = Me.DisabledUAC
			Me.DisabledUAC.Size = New Global.System.Drawing.Size(126, 30)
			Me.DisabledUAC.TabIndex = 484
			Me.DisabledUAC.Text = "Disabled"
			Me.PictureBox4.Image = CType(componentResourceManager.GetObject("PictureBox4.Image"), Global.System.Drawing.Image)
			Me.PictureBox4.Location = New Global.System.Drawing.Point(384, 395)
			Me.PictureBox4.Name = "PictureBox4"
			Me.PictureBox4.Size = New Global.System.Drawing.Size(27, 26)
			Me.PictureBox4.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.Zoom
			Me.PictureBox4.TabIndex = 448
			Me.PictureBox4.TabStop = False
			Me.StateUAC.BackColor = Global.System.Drawing.Color.Transparent
			Me.StateUAC.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.StateUAC.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F)
			Me.StateUAC.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 155)
			Me.StateUAC.Location = New Global.System.Drawing.Point(388, 360)
			Me.StateUAC.Name = "StateUAC"
			Me.StateUAC.Size = New Global.System.Drawing.Size(310, 21)
			Me.StateUAC.TabIndex = 447
			Me.StateUAC.Text = ".."
			Me.StateUAC.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.UiLabel10.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel10.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold)
			Me.UiLabel10.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel10.Location = New Global.System.Drawing.Point(380, 332)
			Me.UiLabel10.Name = "UiLabel10"
			Me.UiLabel10.Size = New Global.System.Drawing.Size(198, 21)
			Me.UiLabel10.TabIndex = 445
			Me.UiLabel10.Text = "UAC"
			Me.UiLabel10.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.DisabledRegistry.BackColor = Global.System.Drawing.Color.Transparent
			Me.DisabledRegistry.BorderRadius = 8
			Me.DisabledRegistry.CheckedState.Parent = Me.DisabledRegistry
			Me.DisabledRegistry.CustomImages.Parent = Me.DisabledRegistry
			Me.DisabledRegistry.FillColor = Global.System.Drawing.Color.FromArgb(26, 155, 161)
			Me.DisabledRegistry.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 155, 161)
			Me.DisabledRegistry.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.DisabledRegistry.ForeColor = Global.System.Drawing.Color.White
			Me.DisabledRegistry.HoverState.Parent = Me.DisabledRegistry
			Me.DisabledRegistry.Location = New Global.System.Drawing.Point(572, 285)
			Me.DisabledRegistry.Name = "DisabledRegistry"
			Me.DisabledRegistry.ShadowDecoration.Parent = Me.DisabledRegistry
			Me.DisabledRegistry.Size = New Global.System.Drawing.Size(126, 30)
			Me.DisabledRegistry.TabIndex = 484
			Me.DisabledRegistry.Text = "Disabled"
			Me.PictureBox5.Image = CType(componentResourceManager.GetObject("PictureBox5.Image"), Global.System.Drawing.Image)
			Me.PictureBox5.Location = New Global.System.Drawing.Point(391, 285)
			Me.PictureBox5.Name = "PictureBox5"
			Me.PictureBox5.Size = New Global.System.Drawing.Size(27, 26)
			Me.PictureBox5.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.Zoom
			Me.PictureBox5.TabIndex = 448
			Me.PictureBox5.TabStop = False
			Me.StateRegistry.BackColor = Global.System.Drawing.Color.Transparent
			Me.StateRegistry.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.StateRegistry.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F)
			Me.StateRegistry.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 155)
			Me.StateRegistry.Location = New Global.System.Drawing.Point(388, 250)
			Me.StateRegistry.Name = "StateRegistry"
			Me.StateRegistry.Size = New Global.System.Drawing.Size(310, 21)
			Me.StateRegistry.TabIndex = 447
			Me.StateRegistry.Text = ".."
			Me.StateRegistry.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.UiLabel13.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel13.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold)
			Me.UiLabel13.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel13.Location = New Global.System.Drawing.Point(380, 222)
			Me.UiLabel13.Name = "UiLabel13"
			Me.UiLabel13.Size = New Global.System.Drawing.Size(198, 21)
			Me.UiLabel13.TabIndex = 445
			Me.UiLabel13.Text = "Registry Editor"
			Me.UiLabel13.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.DisabledFirewall.BackColor = Global.System.Drawing.Color.Transparent
			Me.DisabledFirewall.BorderRadius = 8
			Me.DisabledFirewall.CheckedState.Parent = Me.DisabledFirewall
			Me.DisabledFirewall.CustomImages.Parent = Me.DisabledFirewall
			Me.DisabledFirewall.FillColor = Global.System.Drawing.Color.FromArgb(211, 57, 87)
			Me.DisabledFirewall.FillColor2 = Global.System.Drawing.Color.FromArgb(211, 57, 87)
			Me.DisabledFirewall.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.DisabledFirewall.ForeColor = Global.System.Drawing.Color.White
			Me.DisabledFirewall.HoverState.Parent = Me.DisabledFirewall
			Me.DisabledFirewall.Location = New Global.System.Drawing.Point(572, 171)
			Me.DisabledFirewall.Name = "DisabledFirewall"
			Me.DisabledFirewall.ShadowDecoration.Parent = Me.DisabledFirewall
			Me.DisabledFirewall.Size = New Global.System.Drawing.Size(126, 30)
			Me.DisabledFirewall.TabIndex = 484
			Me.DisabledFirewall.Text = "Disabled"
			Me.PictureBox6.Image = CType(componentResourceManager.GetObject("PictureBox6.Image"), Global.System.Drawing.Image)
			Me.PictureBox6.Location = New Global.System.Drawing.Point(391, 173)
			Me.PictureBox6.Name = "PictureBox6"
			Me.PictureBox6.Size = New Global.System.Drawing.Size(27, 26)
			Me.PictureBox6.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.Zoom
			Me.PictureBox6.TabIndex = 448
			Me.PictureBox6.TabStop = False
			Me.StateFirewall.BackColor = Global.System.Drawing.Color.Transparent
			Me.StateFirewall.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.StateFirewall.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F)
			Me.StateFirewall.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 155)
			Me.StateFirewall.Location = New Global.System.Drawing.Point(388, 134)
			Me.StateFirewall.Name = "StateFirewall"
			Me.StateFirewall.Size = New Global.System.Drawing.Size(310, 21)
			Me.StateFirewall.TabIndex = 447
			Me.StateFirewall.Text = "..."
			Me.StateFirewall.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.UiLabel16.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel16.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold)
			Me.UiLabel16.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel16.Location = New Global.System.Drawing.Point(380, 108)
			Me.UiLabel16.Name = "UiLabel16"
			Me.UiLabel16.Size = New Global.System.Drawing.Size(243, 21)
			Me.UiLabel16.TabIndex = 445
			Me.UiLabel16.Text = "Windows Defender Firewall"
			Me.UiLabel16.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.EnabledAntiProcess.BackColor = Global.System.Drawing.Color.Transparent
			Me.EnabledAntiProcess.BorderRadius = 8
			Me.EnabledAntiProcess.CheckedState.Parent = Me.EnabledAntiProcess
			Me.EnabledAntiProcess.CustomImages.Parent = Me.EnabledAntiProcess
			Me.EnabledAntiProcess.FillColor = Global.System.Drawing.Color.FromArgb(247, 119, 84)
			Me.EnabledAntiProcess.FillColor2 = Global.System.Drawing.Color.FromArgb(247, 119, 84)
			Me.EnabledAntiProcess.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.EnabledAntiProcess.ForeColor = Global.System.Drawing.Color.White
			Me.EnabledAntiProcess.HoverState.Parent = Me.EnabledAntiProcess
			Me.EnabledAntiProcess.Location = New Global.System.Drawing.Point(209, 395)
			Me.EnabledAntiProcess.Name = "EnabledAntiProcess"
			Me.EnabledAntiProcess.ShadowDecoration.Parent = Me.EnabledAntiProcess
			Me.EnabledAntiProcess.Size = New Global.System.Drawing.Size(126, 30)
			Me.EnabledAntiProcess.TabIndex = 484
			Me.EnabledAntiProcess.Text = "Enabled"
			Me.PictureBox7.Image = CType(componentResourceManager.GetObject("PictureBox7.Image"), Global.System.Drawing.Image)
			Me.PictureBox7.Location = New Global.System.Drawing.Point(28, 395)
			Me.PictureBox7.Name = "PictureBox7"
			Me.PictureBox7.Size = New Global.System.Drawing.Size(27, 26)
			Me.PictureBox7.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.Zoom
			Me.PictureBox7.TabIndex = 448
			Me.PictureBox7.TabStop = False
			Me.StateAntiprocess.BackColor = Global.System.Drawing.Color.Transparent
			Me.StateAntiprocess.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.StateAntiprocess.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F)
			Me.StateAntiprocess.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 155)
			Me.StateAntiprocess.Location = New Global.System.Drawing.Point(25, 360)
			Me.StateAntiprocess.Name = "StateAntiprocess"
			Me.StateAntiprocess.Size = New Global.System.Drawing.Size(310, 21)
			Me.StateAntiprocess.TabIndex = 447
			Me.StateAntiprocess.Text = "..."
			Me.StateAntiprocess.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.UiLabel3.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel3.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold)
			Me.UiLabel3.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel3.Location = New Global.System.Drawing.Point(17, 334)
			Me.UiLabel3.Name = "UiLabel3"
			Me.UiLabel3.Size = New Global.System.Drawing.Size(243, 21)
			Me.UiLabel3.TabIndex = 445
			Me.UiLabel3.Text = "Anti Process"
			Me.UiLabel3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Guna2BorderlessForm1.AnimateWindow = True
			Me.Guna2BorderlessForm1.BorderRadius = 40
			Me.Guna2BorderlessForm1.ContainerControl = Me
			Me.Guna2BorderlessForm1.DockIndicatorColor = Global.System.Drawing.Color.FromArgb(56, 37, 200)
			Me.Guna2BorderlessForm1.DragStartTransparencyValue = 0.6
			Me.Guna2BorderlessForm1.ShadowColor = Global.System.Drawing.Color.FromArgb(56, 37, 200)
			Me.Guna2BorderlessForm1.TransparentWhileDrag = True
			Me.Guna2DragControl1.ContainerControl = Me
			Me.Guna2DragControl1.DockForm = True
			Me.Guna2DragControl1.DockIndicatorColor = Global.System.Drawing.Color.FromArgb(56, 37, 200)
			Me.Guna2DragControl1.DragMode = Global.Guna.UI2.WinForms.Enums.DragMode.Control
			Me.Guna2DragControl1.DragStartTransparencyValue = 0.6
			Me.Guna2DragControl1.TargetControl = Me
			Me.Guna2DragControl1.TransparentWhileDrag = True
			Me.Guna2DragControl1.UseTransparentDrag = True
			Me.Mini.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Mini.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Mini.Location = New Global.System.Drawing.Point(661, 12)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 560
			Me.Mini.Text = "ValleyMini1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(687, 12)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 558
			Me.ExitForm.Text = "ValleyClose1"
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(96F, 96F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Dpi
			Me.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			MyBase.ClientSize = New Global.System.Drawing.Size(719, 452)
			MyBase.Controls.Add(Me.DisabledControl)
			MyBase.Controls.Add(Me.EnabledAntiProcess)
			MyBase.Controls.Add(Me.PictureBox3)
			MyBase.Controls.Add(Me.DisabledWD)
			MyBase.Controls.Add(Me.StateControlPanel)
			MyBase.Controls.Add(Me.PictureBox7)
			MyBase.Controls.Add(Me.UiLabel7)
			MyBase.Controls.Add(Me.StateAntiprocess)
			MyBase.Controls.Add(Me.DisabledUAC)
			MyBase.Controls.Add(Me.UiLabel3)
			MyBase.Controls.Add(Me.PictureBox1)
			MyBase.Controls.Add(Me.StateWD)
			MyBase.Controls.Add(Me.DisabledRegistry)
			MyBase.Controls.Add(Me.UiLabel18)
			MyBase.Controls.Add(Me.PictureBox4)
			MyBase.Controls.Add(Me.DisabledFirewall)
			MyBase.Controls.Add(Me.StateUAC)
			MyBase.Controls.Add(Me.PictureBox5)
			MyBase.Controls.Add(Me.UiLabel10)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.StateRegistry)
			MyBase.Controls.Add(Me.PictureBox6)
			MyBase.Controls.Add(Me.UiLabel13)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.StateFirewall)
			MyBase.Controls.Add(Me.UiLabel16)
			MyBase.Controls.Add(Me.UiLabel1)
			MyBase.Controls.Add(Me.ClientInfo)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "FormOptions"
			Me.Text = "FormOptions"
			MyBase.TopMost = True
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.PictureBox3, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.PictureBox4, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.PictureBox5, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.PictureBox6, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.PictureBox7, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x040002EA RID: 746
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
