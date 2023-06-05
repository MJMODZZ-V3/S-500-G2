Namespace S500RAT
	' Token: 0x0200001B RID: 27
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormFun
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600035C RID: 860 RVA: 0x0001CC20 File Offset: 0x0001AE20
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

		' Token: 0x0600035D RID: 861 RVA: 0x0001CC70 File Offset: 0x0001AE70
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormFun))
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.UiLabel1 = New Global.Sunny.UI.UILabel()
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.GroupBoxDataEncrypt = New Global.Guna.UI2.WinForms.Guna2GroupBox()
			Me.DesktopBackground = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.TaskBarShow = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.TaskBaerHide = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.MouseRestor = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.Mousestop = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.ShowIconTaskBar = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.ClockShow = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.IconTaskbar = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.IconShow = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.ClockHide = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.IconHide = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.PictureBox13 = New Global.System.Windows.Forms.PictureBox()
			Me.SignOut = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.Restart = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.ShutDown = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.PictureBox_Background = New Global.System.Windows.Forms.PictureBox()
			Me.TextBox1Background = New Global.Guna.UI2.WinForms.Guna2TextBox()
			Me.UnlockScreen = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.LockScreen = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.Web = New Global.Guna.UI2.WinForms.Guna2TextBox()
			Me.ColorDialog1 = New Global.System.Windows.Forms.ColorDialog()
			Me.Guna2GroupBox3 = New Global.Guna.UI2.WinForms.Guna2GroupBox()
			Me.PictureBox4 = New Global.System.Windows.Forms.PictureBox()
			Me.Guna2GroupBox5 = New Global.Guna.UI2.WinForms.Guna2GroupBox()
			Me.Monitor = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.PictureBox5 = New Global.System.Windows.Forms.PictureBox()
			Me.Guna2GroupBox6 = New Global.Guna.UI2.WinForms.Guna2GroupBox()
			Me.Audio = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.PictureBox6 = New Global.System.Windows.Forms.PictureBox()
			Me.Guna2GroupBox8 = New Global.Guna.UI2.WinForms.Guna2GroupBox()
			Me.PictureBox7 = New Global.System.Windows.Forms.PictureBox()
			Me.Guna2GroupBox1 = New Global.Guna.UI2.WinForms.Guna2GroupBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.Guna2Elipse2 = New Global.Guna.UI2.WinForms.Guna2Elipse(Me.components)
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.GroupBoxDataEncrypt.SuspendLayout()
			CType(Me.PictureBox13, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.PictureBox_Background, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Guna2GroupBox3.SuspendLayout()
			CType(Me.PictureBox4, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Guna2GroupBox5.SuspendLayout()
			CType(Me.PictureBox5, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Guna2GroupBox6.SuspendLayout()
			CType(Me.PictureBox6, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Guna2GroupBox8.SuspendLayout()
			CType(Me.PictureBox7, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Guna2GroupBox1.SuspendLayout()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.Timer1.Interval = 2000
			Me.UiLabel1.AutoSize = True
			Me.UiLabel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel1.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel1.Location = New Global.System.Drawing.Point(22, 8)
			Me.UiLabel1.Name = "UiLabel1"
			Me.UiLabel1.Size = New Global.System.Drawing.Size(32, 19)
			Me.UiLabel1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLabel1.TabIndex = 349
			Me.UiLabel1.Text = "Fun"
			Me.UiLabel1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(23, 34)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(200, 16)
			Me.ClientInfo.TabIndex = 350
			Me.ClientInfo.Text = "FC / Desktop_3424 / Windows 10 pro"
			Me.GroupBoxDataEncrypt.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.GroupBoxDataEncrypt.BackColor = Global.System.Drawing.Color.Transparent
			Me.GroupBoxDataEncrypt.BorderColor = Global.System.Drawing.Color.FromArgb(25, 29, 73)
			Me.GroupBoxDataEncrypt.BorderRadius = 15
			Me.GroupBoxDataEncrypt.Controls.Add(Me.DesktopBackground)
			Me.GroupBoxDataEncrypt.Controls.Add(Me.TaskBarShow)
			Me.GroupBoxDataEncrypt.Controls.Add(Me.TaskBaerHide)
			Me.GroupBoxDataEncrypt.Controls.Add(Me.MouseRestor)
			Me.GroupBoxDataEncrypt.Controls.Add(Me.Mousestop)
			Me.GroupBoxDataEncrypt.Controls.Add(Me.ShowIconTaskBar)
			Me.GroupBoxDataEncrypt.Controls.Add(Me.ClockShow)
			Me.GroupBoxDataEncrypt.Controls.Add(Me.IconTaskbar)
			Me.GroupBoxDataEncrypt.Controls.Add(Me.IconShow)
			Me.GroupBoxDataEncrypt.Controls.Add(Me.ClockHide)
			Me.GroupBoxDataEncrypt.Controls.Add(Me.IconHide)
			Me.GroupBoxDataEncrypt.Controls.Add(Me.PictureBox13)
			Me.GroupBoxDataEncrypt.CustomBorderColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.GroupBoxDataEncrypt.FillColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.GroupBoxDataEncrypt.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.GroupBoxDataEncrypt.ForeColor = Global.System.Drawing.SystemColors.Window
			Me.GroupBoxDataEncrypt.Location = New Global.System.Drawing.Point(10, 85)
			Me.GroupBoxDataEncrypt.Name = "GroupBoxDataEncrypt"
			Me.GroupBoxDataEncrypt.ShadowDecoration.Parent = Me.GroupBoxDataEncrypt
			Me.GroupBoxDataEncrypt.Size = New Global.System.Drawing.Size(245, 295)
			Me.GroupBoxDataEncrypt.TabIndex = 486
			Me.GroupBoxDataEncrypt.Text = "Desktop Settings"
			Me.DesktopBackground.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.DesktopBackground.BackColor = Global.System.Drawing.Color.Transparent
			Me.DesktopBackground.BorderRadius = 8
			Me.DesktopBackground.CheckedState.Parent = Me.DesktopBackground
			Me.DesktopBackground.CustomImages.Parent = Me.DesktopBackground
			Me.DesktopBackground.FillColor = Global.System.Drawing.Color.FromArgb(24, 99, 250)
			Me.DesktopBackground.FillColor2 = Global.System.Drawing.Color.FromArgb(24, 99, 250)
			Me.DesktopBackground.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.DesktopBackground.ForeColor = Global.System.Drawing.Color.White
			Me.DesktopBackground.HoverState.Parent = Me.DesktopBackground
			Me.DesktopBackground.Location = New Global.System.Drawing.Point(13, 251)
			Me.DesktopBackground.Name = "DesktopBackground"
			Me.DesktopBackground.ShadowDecoration.Parent = Me.DesktopBackground
			Me.DesktopBackground.Size = New Global.System.Drawing.Size(222, 30)
			Me.DesktopBackground.TabIndex = 493
			Me.DesktopBackground.Text = "Desktop Background"
			Me.TaskBarShow.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.TaskBarShow.BackColor = Global.System.Drawing.Color.Transparent
			Me.TaskBarShow.BorderRadius = 8
			Me.TaskBarShow.CheckedState.Parent = Me.TaskBarShow
			Me.TaskBarShow.CustomImages.Parent = Me.TaskBarShow
			Me.TaskBarShow.FillColor = Global.System.Drawing.Color.FromArgb(26, 155, 161)
			Me.TaskBarShow.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 155, 161)
			Me.TaskBarShow.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.TaskBarShow.ForeColor = Global.System.Drawing.Color.White
			Me.TaskBarShow.HoverState.Parent = Me.TaskBarShow
			Me.TaskBarShow.Location = New Global.System.Drawing.Point(127, 129)
			Me.TaskBarShow.Name = "TaskBarShow"
			Me.TaskBarShow.ShadowDecoration.Parent = Me.TaskBarShow
			Me.TaskBarShow.Size = New Global.System.Drawing.Size(108, 26)
			Me.TaskBarShow.TabIndex = 498
			Me.TaskBarShow.Text = "Show"
			Me.TaskBaerHide.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.TaskBaerHide.BackColor = Global.System.Drawing.Color.Transparent
			Me.TaskBaerHide.BorderRadius = 8
			Me.TaskBaerHide.CheckedState.Parent = Me.TaskBaerHide
			Me.TaskBaerHide.CustomImages.Parent = Me.TaskBaerHide
			Me.TaskBaerHide.FillColor = Global.System.Drawing.Color.FromArgb(211, 57, 87)
			Me.TaskBaerHide.FillColor2 = Global.System.Drawing.Color.FromArgb(211, 57, 87)
			Me.TaskBaerHide.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.TaskBaerHide.ForeColor = Global.System.Drawing.Color.White
			Me.TaskBaerHide.HoverState.Parent = Me.TaskBaerHide
			Me.TaskBaerHide.Location = New Global.System.Drawing.Point(14, 129)
			Me.TaskBaerHide.Name = "TaskBaerHide"
			Me.TaskBaerHide.ShadowDecoration.Parent = Me.TaskBaerHide
			Me.TaskBaerHide.Size = New Global.System.Drawing.Size(108, 26)
			Me.TaskBaerHide.TabIndex = 497
			Me.TaskBaerHide.Text = "Taskbar Hide"
			Me.MouseRestor.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.MouseRestor.BackColor = Global.System.Drawing.Color.Transparent
			Me.MouseRestor.BorderRadius = 8
			Me.MouseRestor.CheckedState.Parent = Me.MouseRestor
			Me.MouseRestor.CustomImages.Parent = Me.MouseRestor
			Me.MouseRestor.FillColor = Global.System.Drawing.Color.FromArgb(26, 155, 161)
			Me.MouseRestor.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 155, 161)
			Me.MouseRestor.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.MouseRestor.ForeColor = Global.System.Drawing.Color.White
			Me.MouseRestor.HoverState.Parent = Me.MouseRestor
			Me.MouseRestor.Location = New Global.System.Drawing.Point(127, 211)
			Me.MouseRestor.Name = "MouseRestor"
			Me.MouseRestor.ShadowDecoration.Parent = Me.MouseRestor
			Me.MouseRestor.Size = New Global.System.Drawing.Size(108, 26)
			Me.MouseRestor.TabIndex = 496
			Me.MouseRestor.Text = "Restore"
			Me.Mousestop.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Mousestop.BackColor = Global.System.Drawing.Color.Transparent
			Me.Mousestop.BorderRadius = 8
			Me.Mousestop.CheckedState.Parent = Me.Mousestop
			Me.Mousestop.CustomImages.Parent = Me.Mousestop
			Me.Mousestop.FillColor = Global.System.Drawing.Color.FromArgb(211, 57, 87)
			Me.Mousestop.FillColor2 = Global.System.Drawing.Color.FromArgb(211, 57, 87)
			Me.Mousestop.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Mousestop.ForeColor = Global.System.Drawing.Color.White
			Me.Mousestop.HoverState.Parent = Me.Mousestop
			Me.Mousestop.Location = New Global.System.Drawing.Point(14, 211)
			Me.Mousestop.Name = "Mousestop"
			Me.Mousestop.ShadowDecoration.Parent = Me.Mousestop
			Me.Mousestop.Size = New Global.System.Drawing.Size(108, 26)
			Me.Mousestop.TabIndex = 495
			Me.Mousestop.Text = "Mouse stop"
			Me.ShowIconTaskBar.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ShowIconTaskBar.BackColor = Global.System.Drawing.Color.Transparent
			Me.ShowIconTaskBar.BorderRadius = 8
			Me.ShowIconTaskBar.CheckedState.Parent = Me.ShowIconTaskBar
			Me.ShowIconTaskBar.CustomImages.Parent = Me.ShowIconTaskBar
			Me.ShowIconTaskBar.FillColor = Global.System.Drawing.Color.FromArgb(26, 155, 161)
			Me.ShowIconTaskBar.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 155, 161)
			Me.ShowIconTaskBar.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ShowIconTaskBar.ForeColor = Global.System.Drawing.Color.White
			Me.ShowIconTaskBar.HoverState.Parent = Me.ShowIconTaskBar
			Me.ShowIconTaskBar.Location = New Global.System.Drawing.Point(127, 170)
			Me.ShowIconTaskBar.Name = "ShowIconTaskBar"
			Me.ShowIconTaskBar.ShadowDecoration.Parent = Me.ShowIconTaskBar
			Me.ShowIconTaskBar.Size = New Global.System.Drawing.Size(108, 26)
			Me.ShowIconTaskBar.TabIndex = 490
			Me.ShowIconTaskBar.Text = "Show"
			Me.ClockShow.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ClockShow.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClockShow.BorderRadius = 8
			Me.ClockShow.CheckedState.Parent = Me.ClockShow
			Me.ClockShow.CustomImages.Parent = Me.ClockShow
			Me.ClockShow.FillColor = Global.System.Drawing.Color.FromArgb(26, 155, 161)
			Me.ClockShow.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 155, 161)
			Me.ClockShow.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ClockShow.ForeColor = Global.System.Drawing.Color.White
			Me.ClockShow.HoverState.Parent = Me.ClockShow
			Me.ClockShow.Location = New Global.System.Drawing.Point(127, 92)
			Me.ClockShow.Name = "ClockShow"
			Me.ClockShow.ShadowDecoration.Parent = Me.ClockShow
			Me.ClockShow.Size = New Global.System.Drawing.Size(108, 26)
			Me.ClockShow.TabIndex = 489
			Me.ClockShow.Text = "Show"
			Me.IconTaskbar.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.IconTaskbar.BackColor = Global.System.Drawing.Color.Transparent
			Me.IconTaskbar.BorderRadius = 8
			Me.IconTaskbar.CheckedState.Parent = Me.IconTaskbar
			Me.IconTaskbar.CustomImages.Parent = Me.IconTaskbar
			Me.IconTaskbar.FillColor = Global.System.Drawing.Color.FromArgb(211, 57, 87)
			Me.IconTaskbar.FillColor2 = Global.System.Drawing.Color.FromArgb(211, 57, 87)
			Me.IconTaskbar.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.IconTaskbar.ForeColor = Global.System.Drawing.Color.White
			Me.IconTaskbar.HoverState.Parent = Me.IconTaskbar
			Me.IconTaskbar.Location = New Global.System.Drawing.Point(14, 171)
			Me.IconTaskbar.Name = "IconTaskbar"
			Me.IconTaskbar.ShadowDecoration.Parent = Me.IconTaskbar
			Me.IconTaskbar.Size = New Global.System.Drawing.Size(108, 26)
			Me.IconTaskbar.TabIndex = 488
			Me.IconTaskbar.Text = "Icon Taskbar Hide"
			Me.IconShow.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.IconShow.BackColor = Global.System.Drawing.Color.Transparent
			Me.IconShow.BorderRadius = 8
			Me.IconShow.CheckedState.Parent = Me.IconShow
			Me.IconShow.CustomImages.Parent = Me.IconShow
			Me.IconShow.FillColor = Global.System.Drawing.Color.FromArgb(26, 155, 161)
			Me.IconShow.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 155, 161)
			Me.IconShow.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.IconShow.ForeColor = Global.System.Drawing.Color.White
			Me.IconShow.HoverState.Parent = Me.IconShow
			Me.IconShow.Location = New Global.System.Drawing.Point(127, 52)
			Me.IconShow.Name = "IconShow"
			Me.IconShow.ShadowDecoration.Parent = Me.IconShow
			Me.IconShow.Size = New Global.System.Drawing.Size(108, 26)
			Me.IconShow.TabIndex = 485
			Me.IconShow.Text = "Show"
			Me.ClockHide.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ClockHide.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClockHide.BorderRadius = 8
			Me.ClockHide.CheckedState.Parent = Me.ClockHide
			Me.ClockHide.CustomImages.Parent = Me.ClockHide
			Me.ClockHide.FillColor = Global.System.Drawing.Color.FromArgb(211, 57, 87)
			Me.ClockHide.FillColor2 = Global.System.Drawing.Color.FromArgb(211, 57, 87)
			Me.ClockHide.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ClockHide.ForeColor = Global.System.Drawing.Color.White
			Me.ClockHide.HoverState.Parent = Me.ClockHide
			Me.ClockHide.Location = New Global.System.Drawing.Point(14, 92)
			Me.ClockHide.Name = "ClockHide"
			Me.ClockHide.ShadowDecoration.Parent = Me.ClockHide
			Me.ClockHide.Size = New Global.System.Drawing.Size(108, 26)
			Me.ClockHide.TabIndex = 487
			Me.ClockHide.Text = "Desktop Hide"
			Me.IconHide.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.IconHide.BackColor = Global.System.Drawing.Color.Transparent
			Me.IconHide.BorderRadius = 8
			Me.IconHide.CheckedState.Parent = Me.IconHide
			Me.IconHide.CustomImages.Parent = Me.IconHide
			Me.IconHide.FillColor = Global.System.Drawing.Color.FromArgb(211, 57, 87)
			Me.IconHide.FillColor2 = Global.System.Drawing.Color.FromArgb(211, 57, 87)
			Me.IconHide.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.IconHide.ForeColor = Global.System.Drawing.Color.White
			Me.IconHide.HoverState.Parent = Me.IconHide
			Me.IconHide.Location = New Global.System.Drawing.Point(14, 52)
			Me.IconHide.Name = "IconHide"
			Me.IconHide.ShadowDecoration.Parent = Me.IconHide
			Me.IconHide.Size = New Global.System.Drawing.Size(108, 26)
			Me.IconHide.TabIndex = 486
			Me.IconHide.Text = "Icon Hide"
			Me.PictureBox13.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.PictureBox13.BackColor = Global.System.Drawing.Color.Transparent
			Me.PictureBox13.Image = CType(componentResourceManager.GetObject("PictureBox13.Image"), Global.System.Drawing.Image)
			Me.PictureBox13.Location = New Global.System.Drawing.Point(216, 9)
			Me.PictureBox13.Name = "PictureBox13"
			Me.PictureBox13.Size = New Global.System.Drawing.Size(20, 20)
			Me.PictureBox13.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.AutoSize
			Me.PictureBox13.TabIndex = 423
			Me.PictureBox13.TabStop = False
			Me.SignOut.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.SignOut.BackColor = Global.System.Drawing.Color.Transparent
			Me.SignOut.BorderRadius = 8
			Me.SignOut.CheckedState.Parent = Me.SignOut
			Me.SignOut.CustomImages.Parent = Me.SignOut
			Me.SignOut.FillColor = Global.System.Drawing.Color.FromArgb(211, 57, 87)
			Me.SignOut.FillColor2 = Global.System.Drawing.Color.FromArgb(211, 57, 87)
			Me.SignOut.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.SignOut.ForeColor = Global.System.Drawing.Color.White
			Me.SignOut.HoverState.Parent = Me.SignOut
			Me.SignOut.Location = New Global.System.Drawing.Point(163, 42)
			Me.SignOut.Name = "SignOut"
			Me.SignOut.ShadowDecoration.Parent = Me.SignOut
			Me.SignOut.Size = New Global.System.Drawing.Size(74, 30)
			Me.SignOut.TabIndex = 496
			Me.SignOut.Text = "Sign out"
			Me.Restart.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Restart.BackColor = Global.System.Drawing.Color.Transparent
			Me.Restart.BorderRadius = 8
			Me.Restart.CheckedState.Parent = Me.Restart
			Me.Restart.CustomImages.Parent = Me.Restart
			Me.Restart.FillColor = Global.System.Drawing.Color.FromArgb(211, 57, 87)
			Me.Restart.FillColor2 = Global.System.Drawing.Color.FromArgb(247, 119, 84)
			Me.Restart.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Restart.ForeColor = Global.System.Drawing.Color.White
			Me.Restart.HoverState.Parent = Me.Restart
			Me.Restart.Location = New Global.System.Drawing.Point(84, 42)
			Me.Restart.Name = "Restart"
			Me.Restart.ShadowDecoration.Parent = Me.Restart
			Me.Restart.Size = New Global.System.Drawing.Size(74, 30)
			Me.Restart.TabIndex = 495
			Me.Restart.Text = "Restart"
			Me.ShutDown.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ShutDown.BackColor = Global.System.Drawing.Color.Transparent
			Me.ShutDown.BorderRadius = 8
			Me.ShutDown.CheckedState.Parent = Me.ShutDown
			Me.ShutDown.CustomImages.Parent = Me.ShutDown
			Me.ShutDown.FillColor = Global.System.Drawing.Color.FromArgb(211, 57, 87)
			Me.ShutDown.FillColor2 = Global.System.Drawing.Color.FromArgb(211, 57, 87)
			Me.ShutDown.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ShutDown.ForeColor = Global.System.Drawing.Color.White
			Me.ShutDown.HoverState.Parent = Me.ShutDown
			Me.ShutDown.Location = New Global.System.Drawing.Point(5, 42)
			Me.ShutDown.Name = "ShutDown"
			Me.ShutDown.ShadowDecoration.Parent = Me.ShutDown
			Me.ShutDown.Size = New Global.System.Drawing.Size(74, 30)
			Me.ShutDown.TabIndex = 494
			Me.ShutDown.Text = "Shut Down"
			Me.PictureBox_Background.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.PictureBox_Background.BackColor = Global.System.Drawing.Color.Transparent
			Me.PictureBox_Background.Enabled = False
			Me.PictureBox_Background.Image = CType(componentResourceManager.GetObject("PictureBox_Background.Image"), Global.System.Drawing.Image)
			Me.PictureBox_Background.Location = New Global.System.Drawing.Point(13, 44)
			Me.PictureBox_Background.Name = "PictureBox_Background"
			Me.PictureBox_Background.Size = New Global.System.Drawing.Size(149, 74)
			Me.PictureBox_Background.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.Zoom
			Me.PictureBox_Background.TabIndex = 517
			Me.PictureBox_Background.TabStop = False
			Me.TextBox1Background.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.TextBox1Background.Animated = True
			Me.TextBox1Background.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.TextBox1Background.BorderColor = Global.System.Drawing.Color.FromArgb(82, 43, 235)
			Me.TextBox1Background.BorderRadius = 7
			Me.TextBox1Background.BorderStyle = Global.System.Drawing.Drawing2D.DashStyle.Custom
			Me.TextBox1Background.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.TextBox1Background.DefaultText = ""
			Me.TextBox1Background.DisabledState.BorderColor = Global.System.Drawing.Color.FromArgb(208, 208, 208)
			Me.TextBox1Background.DisabledState.FillColor = Global.System.Drawing.Color.FromArgb(226, 226, 226)
			Me.TextBox1Background.DisabledState.ForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.TextBox1Background.DisabledState.Parent = Me.TextBox1Background
			Me.TextBox1Background.DisabledState.PlaceholderForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.TextBox1Background.FillColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.TextBox1Background.FocusedState.BorderColor = Global.System.Drawing.Color.FromArgb(94, 148, 255)
			Me.TextBox1Background.FocusedState.Parent = Me.TextBox1Background
			Me.TextBox1Background.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.TextBox1Background.ForeColor = Global.System.Drawing.Color.White
			Me.TextBox1Background.HoverState.BorderColor = Global.System.Drawing.Color.FromArgb(94, 148, 255)
			Me.TextBox1Background.HoverState.Parent = Me.TextBox1Background
			Me.TextBox1Background.IconLeftCursor = Global.System.Windows.Forms.Cursors.Hand
			Me.TextBox1Background.IconRight = CType(componentResourceManager.GetObject("TextBox1Background.IconRight"), Global.System.Drawing.Image)
			Me.TextBox1Background.IconRightCursor = Global.System.Windows.Forms.Cursors.Hand
			Me.TextBox1Background.Location = New Global.System.Drawing.Point(13, 132)
			Me.TextBox1Background.Margin = New Global.System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.TextBox1Background.Name = "TextBox1Background"
			Me.TextBox1Background.PasswordChar = vbNullChar
			Me.TextBox1Background.PlaceholderForeColor = Global.System.Drawing.Color.Gray
			Me.TextBox1Background.PlaceholderText = "Choose Background (.jpg)"
			Me.TextBox1Background.[ReadOnly] = True
			Me.TextBox1Background.SelectedText = ""
			Me.TextBox1Background.ShadowDecoration.Parent = Me.TextBox1Background
			Me.TextBox1Background.Size = New Global.System.Drawing.Size(467, 27)
			Me.TextBox1Background.TabIndex = 516
			Me.TextBox1Background.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.UnlockScreen.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.UnlockScreen.BackColor = Global.System.Drawing.Color.Transparent
			Me.UnlockScreen.BorderRadius = 8
			Me.UnlockScreen.CheckedState.Parent = Me.UnlockScreen
			Me.UnlockScreen.CustomImages.Parent = Me.UnlockScreen
			Me.UnlockScreen.FillColor = Global.System.Drawing.Color.FromArgb(26, 155, 161)
			Me.UnlockScreen.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 155, 161)
			Me.UnlockScreen.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.UnlockScreen.ForeColor = Global.System.Drawing.Color.White
			Me.UnlockScreen.HoverState.Parent = Me.UnlockScreen
			Me.UnlockScreen.Location = New Global.System.Drawing.Point(388, 169)
			Me.UnlockScreen.Name = "UnlockScreen"
			Me.UnlockScreen.ShadowDecoration.Parent = Me.UnlockScreen
			Me.UnlockScreen.Size = New Global.System.Drawing.Size(92, 26)
			Me.UnlockScreen.TabIndex = 518
			Me.UnlockScreen.Text = "Unlock"
			Me.LockScreen.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.LockScreen.BackColor = Global.System.Drawing.Color.Transparent
			Me.LockScreen.BorderRadius = 8
			Me.LockScreen.CheckedState.Parent = Me.LockScreen
			Me.LockScreen.CustomImages.Parent = Me.LockScreen
			Me.LockScreen.FillColor = Global.System.Drawing.Color.FromArgb(211, 57, 87)
			Me.LockScreen.FillColor2 = Global.System.Drawing.Color.FromArgb(211, 57, 87)
			Me.LockScreen.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.LockScreen.ForeColor = Global.System.Drawing.Color.White
			Me.LockScreen.HoverState.Parent = Me.LockScreen
			Me.LockScreen.Location = New Global.System.Drawing.Point(291, 169)
			Me.LockScreen.Name = "LockScreen"
			Me.LockScreen.ShadowDecoration.Parent = Me.LockScreen
			Me.LockScreen.Size = New Global.System.Drawing.Size(92, 26)
			Me.LockScreen.TabIndex = 519
			Me.LockScreen.Text = "Lock"
			Me.Web.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Web.Animated = True
			Me.Web.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.Web.BorderColor = Global.System.Drawing.Color.FromArgb(82, 43, 235)
			Me.Web.BorderRadius = 7
			Me.Web.BorderStyle = Global.System.Drawing.Drawing2D.DashStyle.Custom
			Me.Web.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.Web.DefaultText = "www.google.com"
			Me.Web.DisabledState.BorderColor = Global.System.Drawing.Color.FromArgb(208, 208, 208)
			Me.Web.DisabledState.FillColor = Global.System.Drawing.Color.FromArgb(226, 226, 226)
			Me.Web.DisabledState.ForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.Web.DisabledState.Parent = Me.Web
			Me.Web.DisabledState.PlaceholderForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.Web.FillColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.Web.FocusedState.BorderColor = Global.System.Drawing.Color.FromArgb(94, 148, 255)
			Me.Web.FocusedState.Parent = Me.Web
			Me.Web.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Web.ForeColor = Global.System.Drawing.Color.White
			Me.Web.HoverState.BorderColor = Global.System.Drawing.Color.FromArgb(94, 148, 255)
			Me.Web.HoverState.Parent = Me.Web
			Me.Web.IconLeftCursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Web.IconRight = CType(componentResourceManager.GetObject("Web.IconRight"), Global.System.Drawing.Image)
			Me.Web.IconRightCursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Web.Location = New Global.System.Drawing.Point(13, 45)
			Me.Web.Margin = New Global.System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.Web.Name = "Web"
			Me.Web.PasswordChar = vbNullChar
			Me.Web.PlaceholderForeColor = Global.System.Drawing.Color.Gray
			Me.Web.PlaceholderText = "Url"
			Me.Web.SelectedText = ""
			Me.Web.SelectionStart = 14
			Me.Web.ShadowDecoration.Parent = Me.Web
			Me.Web.Size = New Global.System.Drawing.Size(465, 27)
			Me.Web.TabIndex = 519
			Me.Web.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Guna2GroupBox3.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Guna2GroupBox3.BackColor = Global.System.Drawing.Color.Transparent
			Me.Guna2GroupBox3.BorderColor = Global.System.Drawing.Color.FromArgb(25, 29, 73)
			Me.Guna2GroupBox3.BorderRadius = 15
			Me.Guna2GroupBox3.Controls.Add(Me.SignOut)
			Me.Guna2GroupBox3.Controls.Add(Me.PictureBox4)
			Me.Guna2GroupBox3.Controls.Add(Me.ShutDown)
			Me.Guna2GroupBox3.Controls.Add(Me.Restart)
			Me.Guna2GroupBox3.CustomBorderColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.Guna2GroupBox3.FillColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.Guna2GroupBox3.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Guna2GroupBox3.ForeColor = Global.System.Drawing.SystemColors.Window
			Me.Guna2GroupBox3.Location = New Global.System.Drawing.Point(10, 386)
			Me.Guna2GroupBox3.Name = "Guna2GroupBox3"
			Me.Guna2GroupBox3.ShadowDecoration.Parent = Me.Guna2GroupBox3
			Me.Guna2GroupBox3.Size = New Global.System.Drawing.Size(245, 84)
			Me.Guna2GroupBox3.TabIndex = 495
			Me.Guna2GroupBox3.Text = "Power"
			Me.PictureBox4.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.PictureBox4.BackColor = Global.System.Drawing.Color.Transparent
			Me.PictureBox4.Image = CType(componentResourceManager.GetObject("PictureBox4.Image"), Global.System.Drawing.Image)
			Me.PictureBox4.Location = New Global.System.Drawing.Point(216, 9)
			Me.PictureBox4.Name = "PictureBox4"
			Me.PictureBox4.Size = New Global.System.Drawing.Size(24, 24)
			Me.PictureBox4.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.AutoSize
			Me.PictureBox4.TabIndex = 423
			Me.PictureBox4.TabStop = False
			Me.Guna2GroupBox5.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Guna2GroupBox5.BackColor = Global.System.Drawing.Color.Transparent
			Me.Guna2GroupBox5.BorderColor = Global.System.Drawing.Color.FromArgb(25, 29, 73)
			Me.Guna2GroupBox5.BorderRadius = 15
			Me.Guna2GroupBox5.Controls.Add(Me.Monitor)
			Me.Guna2GroupBox5.Controls.Add(Me.PictureBox5)
			Me.Guna2GroupBox5.CustomBorderColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.Guna2GroupBox5.FillColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.Guna2GroupBox5.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Guna2GroupBox5.ForeColor = Global.System.Drawing.SystemColors.Window
			Me.Guna2GroupBox5.Location = New Global.System.Drawing.Point(261, 386)
			Me.Guna2GroupBox5.Name = "Guna2GroupBox5"
			Me.Guna2GroupBox5.ShadowDecoration.Parent = Me.Guna2GroupBox5
			Me.Guna2GroupBox5.Size = New Global.System.Drawing.Size(245, 84)
			Me.Guna2GroupBox5.TabIndex = 497
			Me.Guna2GroupBox5.Text = "Monitor"
			Me.Monitor.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Monitor.BackColor = Global.System.Drawing.Color.Transparent
			Me.Monitor.BorderRadius = 8
			Me.Monitor.CheckedState.Parent = Me.Monitor
			Me.Monitor.CustomImages.Parent = Me.Monitor
			Me.Monitor.FillColor = Global.System.Drawing.Color.FromArgb(211, 57, 87)
			Me.Monitor.FillColor2 = Global.System.Drawing.Color.FromArgb(128, 64, 0)
			Me.Monitor.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Monitor.ForeColor = Global.System.Drawing.Color.White
			Me.Monitor.HoverState.Parent = Me.Monitor
			Me.Monitor.Location = New Global.System.Drawing.Point(13, 42)
			Me.Monitor.Name = "Monitor"
			Me.Monitor.ShadowDecoration.Parent = Me.Monitor
			Me.Monitor.Size = New Global.System.Drawing.Size(224, 30)
			Me.Monitor.TabIndex = 496
			Me.Monitor.Text = "Turn off"
			Me.PictureBox5.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.PictureBox5.BackColor = Global.System.Drawing.Color.Transparent
			Me.PictureBox5.Image = CType(componentResourceManager.GetObject("PictureBox5.Image"), Global.System.Drawing.Image)
			Me.PictureBox5.Location = New Global.System.Drawing.Point(216, 9)
			Me.PictureBox5.Name = "PictureBox5"
			Me.PictureBox5.Size = New Global.System.Drawing.Size(24, 24)
			Me.PictureBox5.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.AutoSize
			Me.PictureBox5.TabIndex = 423
			Me.PictureBox5.TabStop = False
			Me.Guna2GroupBox6.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Guna2GroupBox6.BackColor = Global.System.Drawing.Color.Transparent
			Me.Guna2GroupBox6.BorderColor = Global.System.Drawing.Color.FromArgb(25, 29, 73)
			Me.Guna2GroupBox6.BorderRadius = 15
			Me.Guna2GroupBox6.Controls.Add(Me.Audio)
			Me.Guna2GroupBox6.Controls.Add(Me.PictureBox6)
			Me.Guna2GroupBox6.CustomBorderColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.Guna2GroupBox6.FillColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.Guna2GroupBox6.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Guna2GroupBox6.ForeColor = Global.System.Drawing.SystemColors.Window
			Me.Guna2GroupBox6.Location = New Global.System.Drawing.Point(511, 386)
			Me.Guna2GroupBox6.Name = "Guna2GroupBox6"
			Me.Guna2GroupBox6.ShadowDecoration.Parent = Me.Guna2GroupBox6
			Me.Guna2GroupBox6.Size = New Global.System.Drawing.Size(245, 84)
			Me.Guna2GroupBox6.TabIndex = 498
			Me.Guna2GroupBox6.Text = "Play Audio"
			Me.Audio.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Audio.BackColor = Global.System.Drawing.Color.Transparent
			Me.Audio.BorderRadius = 8
			Me.Audio.CheckedState.Parent = Me.Audio
			Me.Audio.CustomImages.Parent = Me.Audio
			Me.Audio.FillColor = Global.System.Drawing.Color.FromArgb(26, 155, 161)
			Me.Audio.FillColor2 = Global.System.Drawing.Color.ForestGreen
			Me.Audio.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Audio.ForeColor = Global.System.Drawing.Color.White
			Me.Audio.HoverState.Parent = Me.Audio
			Me.Audio.Location = New Global.System.Drawing.Point(13, 42)
			Me.Audio.Name = "Audio"
			Me.Audio.ShadowDecoration.Parent = Me.Audio
			Me.Audio.Size = New Global.System.Drawing.Size(224, 30)
			Me.Audio.TabIndex = 496
			Me.Audio.Text = "Choose (*.wav)"
			Me.PictureBox6.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.PictureBox6.BackColor = Global.System.Drawing.Color.Transparent
			Me.PictureBox6.Image = CType(componentResourceManager.GetObject("PictureBox6.Image"), Global.System.Drawing.Image)
			Me.PictureBox6.Location = New Global.System.Drawing.Point(216, 9)
			Me.PictureBox6.Name = "PictureBox6"
			Me.PictureBox6.Size = New Global.System.Drawing.Size(24, 24)
			Me.PictureBox6.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.AutoSize
			Me.PictureBox6.TabIndex = 423
			Me.PictureBox6.TabStop = False
			Me.Guna2GroupBox8.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Guna2GroupBox8.BackColor = Global.System.Drawing.Color.Transparent
			Me.Guna2GroupBox8.BorderColor = Global.System.Drawing.Color.FromArgb(25, 29, 73)
			Me.Guna2GroupBox8.BorderRadius = 15
			Me.Guna2GroupBox8.Controls.Add(Me.Web)
			Me.Guna2GroupBox8.Controls.Add(Me.PictureBox7)
			Me.Guna2GroupBox8.CustomBorderColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.Guna2GroupBox8.FillColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.Guna2GroupBox8.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Guna2GroupBox8.ForeColor = Global.System.Drawing.SystemColors.Window
			Me.Guna2GroupBox8.Location = New Global.System.Drawing.Point(261, 296)
			Me.Guna2GroupBox8.Name = "Guna2GroupBox8"
			Me.Guna2GroupBox8.ShadowDecoration.Parent = Me.Guna2GroupBox8
			Me.Guna2GroupBox8.Size = New Global.System.Drawing.Size(495, 84)
			Me.Guna2GroupBox8.TabIndex = 499
			Me.Guna2GroupBox8.Text = "Website"
			Me.PictureBox7.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.PictureBox7.BackColor = Global.System.Drawing.Color.Transparent
			Me.PictureBox7.Image = CType(componentResourceManager.GetObject("PictureBox7.Image"), Global.System.Drawing.Image)
			Me.PictureBox7.Location = New Global.System.Drawing.Point(466, 9)
			Me.PictureBox7.Name = "PictureBox7"
			Me.PictureBox7.Size = New Global.System.Drawing.Size(24, 24)
			Me.PictureBox7.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.AutoSize
			Me.PictureBox7.TabIndex = 423
			Me.PictureBox7.TabStop = False
			Me.Guna2GroupBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Guna2GroupBox1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Guna2GroupBox1.BorderColor = Global.System.Drawing.Color.FromArgb(25, 29, 73)
			Me.Guna2GroupBox1.BorderRadius = 15
			Me.Guna2GroupBox1.Controls.Add(Me.Label1)
			Me.Guna2GroupBox1.Controls.Add(Me.UnlockScreen)
			Me.Guna2GroupBox1.Controls.Add(Me.PictureBox1)
			Me.Guna2GroupBox1.Controls.Add(Me.LockScreen)
			Me.Guna2GroupBox1.Controls.Add(Me.PictureBox_Background)
			Me.Guna2GroupBox1.Controls.Add(Me.TextBox1Background)
			Me.Guna2GroupBox1.CustomBorderColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.Guna2GroupBox1.FillColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.Guna2GroupBox1.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Guna2GroupBox1.ForeColor = Global.System.Drawing.SystemColors.Window
			Me.Guna2GroupBox1.Location = New Global.System.Drawing.Point(261, 85)
			Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
			Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
			Me.Guna2GroupBox1.Size = New Global.System.Drawing.Size(495, 205)
			Me.Guna2GroupBox1.TabIndex = 500
			Me.Guna2GroupBox1.Text = "Lock Screen"
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.Label1.Location = New Global.System.Drawing.Point(21, 171)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(15, 13)
			Me.Label1.TabIndex = 520
			Me.Label1.Text = "--"
			Me.PictureBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.PictureBox1.BackColor = Global.System.Drawing.Color.Transparent
			Me.PictureBox1.Image = CType(componentResourceManager.GetObject("PictureBox1.Image"), Global.System.Drawing.Image)
			Me.PictureBox1.Location = New Global.System.Drawing.Point(466, 9)
			Me.PictureBox1.Name = "PictureBox1"
			Me.PictureBox1.Size = New Global.System.Drawing.Size(24, 24)
			Me.PictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.AutoSize
			Me.PictureBox1.TabIndex = 423
			Me.PictureBox1.TabStop = False
			Me.Guna2Elipse2.BorderRadius = 200
			Me.Guna2Elipse2.TargetControl = Me.PictureBox_Background
			Me.Mini.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Mini.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Mini.Location = New Global.System.Drawing.Point(718, 7)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 586
			Me.Mini.Text = "ValleyMini1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(744, 7)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 584
			Me.ExitForm.Text = "ValleyClose1"
			Me.Guna2DragControl1.ContainerControl = Me
			Me.Guna2DragControl1.DockForm = True
			Me.Guna2DragControl1.DockIndicatorColor = Global.System.Drawing.Color.FromArgb(56, 37, 200)
			Me.Guna2DragControl1.DragMode = Global.Guna.UI2.WinForms.Enums.DragMode.Control
			Me.Guna2DragControl1.DragStartTransparencyValue = 0.6
			Me.Guna2DragControl1.TargetControl = Me
			Me.Guna2DragControl1.TransparentWhileDrag = True
			Me.Guna2DragControl1.UseTransparentDrag = True
			Me.Guna2BorderlessForm1.AnimateWindow = True
			Me.Guna2BorderlessForm1.BorderRadius = 40
			Me.Guna2BorderlessForm1.ContainerControl = Me
			Me.Guna2BorderlessForm1.DockIndicatorColor = Global.System.Drawing.Color.FromArgb(56, 37, 200)
			Me.Guna2BorderlessForm1.DragStartTransparencyValue = 0.6
			Me.Guna2BorderlessForm1.ShadowColor = Global.System.Drawing.Color.FromArgb(56, 37, 200)
			Me.Guna2BorderlessForm1.TransparentWhileDrag = True
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(96F, 96F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Dpi
			Me.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			MyBase.ClientSize = New Global.System.Drawing.Size(776, 488)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.Guna2GroupBox1)
			MyBase.Controls.Add(Me.Guna2GroupBox8)
			MyBase.Controls.Add(Me.Guna2GroupBox6)
			MyBase.Controls.Add(Me.Guna2GroupBox5)
			MyBase.Controls.Add(Me.Guna2GroupBox3)
			MyBase.Controls.Add(Me.GroupBoxDataEncrypt)
			MyBase.Controls.Add(Me.UiLabel1)
			MyBase.Controls.Add(Me.ClientInfo)
			Me.DoubleBuffered = True
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "FormFun"
			Me.Text = "FormFun"
			MyBase.TopMost = True
			Me.GroupBoxDataEncrypt.ResumeLayout(False)
			Me.GroupBoxDataEncrypt.PerformLayout()
			CType(Me.PictureBox13, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.PictureBox_Background, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Guna2GroupBox3.ResumeLayout(False)
			Me.Guna2GroupBox3.PerformLayout()
			CType(Me.PictureBox4, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Guna2GroupBox5.ResumeLayout(False)
			Me.Guna2GroupBox5.PerformLayout()
			CType(Me.PictureBox5, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Guna2GroupBox6.ResumeLayout(False)
			Me.Guna2GroupBox6.PerformLayout()
			CType(Me.PictureBox6, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Guna2GroupBox8.ResumeLayout(False)
			Me.Guna2GroupBox8.PerformLayout()
			CType(Me.PictureBox7, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Guna2GroupBox1.ResumeLayout(False)
			Me.Guna2GroupBox1.PerformLayout()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x04000186 RID: 390
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
