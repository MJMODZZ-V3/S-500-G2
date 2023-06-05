Namespace S500RAT
	' Token: 0x0200003C RID: 60
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Microphone
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060010C5 RID: 4293 RVA: 0x000908F0 File Offset: 0x0008EAF0
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

		' Token: 0x060010C6 RID: 4294 RVA: 0x00090940 File Offset: 0x0008EB40
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.Microphone))
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.UiLabel1 = New Global.Sunny.UI.UILabel()
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.StartAndStop = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.combxListenClient = New Global.Sunny.UI.UIComboBox()
			Me.CombxSpeakClient = New Global.Sunny.UI.UIComboBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.UiLine1 = New Global.Sunny.UI.UILine()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.CombxSpeakServer = New Global.Sunny.UI.UIComboBox()
			Me.CombxListenServer = New Global.Sunny.UI.UIComboBox()
			Me.Jitter = New Global.Guna.UI2.WinForms.Guna2TextBox()
			Me.BufferCount = New Global.Sunny.UI.UIComboBox()
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.MAX = New Global.S500RAT.ValleyMax()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			Me.SpeakClient = New Global.System.Windows.Forms.Button()
			Me.ListenClient = New Global.System.Windows.Forms.Button()
			Me.ListenServer = New Global.System.Windows.Forms.Button()
			Me.SpeakServer = New Global.System.Windows.Forms.Button()
			Me.UiLine2 = New Global.Sunny.UI.UILine()
			Me.UiLine3 = New Global.Sunny.UI.UILine()
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.PictureBox2 = New Global.System.Windows.Forms.PictureBox()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.Label8 = New Global.System.Windows.Forms.Label()
			Me.ProgressBar1 = New Global.Guna.UI2.WinForms.Guna2ProgressBar()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.PictureBox2, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.Timer1.Interval = 2000
			Me.Guna2DragControl1.ContainerControl = Me
			Me.Guna2DragControl1.DockForm = True
			Me.Guna2DragControl1.DockIndicatorColor = Global.System.Drawing.Color.FromArgb(56, 37, 200)
			Me.Guna2DragControl1.DragMode = Global.Guna.UI2.WinForms.Enums.DragMode.Control
			Me.Guna2DragControl1.DragStartTransparencyValue = 0.6
			Me.Guna2DragControl1.TransparentWhileDrag = True
			Me.Guna2DragControl1.UseTransparentDrag = True
			Me.Guna2BorderlessForm1.AnimateWindow = True
			Me.Guna2BorderlessForm1.BorderRadius = 40
			Me.Guna2BorderlessForm1.ContainerControl = Me
			Me.Guna2BorderlessForm1.DockIndicatorColor = Global.System.Drawing.Color.FromArgb(56, 37, 200)
			Me.Guna2BorderlessForm1.DragStartTransparencyValue = 0.6
			Me.Guna2BorderlessForm1.ShadowColor = Global.System.Drawing.Color.FromArgb(56, 37, 200)
			Me.Guna2BorderlessForm1.TransparentWhileDrag = True
			Me.UiLabel1.AutoSize = True
			Me.UiLabel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel1.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel1.Location = New Global.System.Drawing.Point(12, 9)
			Me.UiLabel1.Name = "UiLabel1"
			Me.UiLabel1.Size = New Global.System.Drawing.Size(90, 19)
			Me.UiLabel1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLabel1.TabIndex = 552
			Me.UiLabel1.Text = "Microphone"
			Me.UiLabel1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(13, 37)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(200, 16)
			Me.ClientInfo.TabIndex = 553
			Me.ClientInfo.Text = "FC / Desktop_3424 / Windows 10 pro"
			Me.StartAndStop.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.StartAndStop.BackColor = Global.System.Drawing.Color.Transparent
			Me.StartAndStop.BorderRadius = 8
			Me.StartAndStop.CheckedState.Parent = Me.StartAndStop
			Me.StartAndStop.CustomImages.Parent = Me.StartAndStop
			Me.StartAndStop.Enabled = False
			Me.StartAndStop.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.StartAndStop.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.StartAndStop.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.StartAndStop.ForeColor = Global.System.Drawing.Color.White
			Me.StartAndStop.HoverState.Parent = Me.StartAndStop
			Me.StartAndStop.Location = New Global.System.Drawing.Point(648, 454)
			Me.StartAndStop.Name = "StartAndStop"
			Me.StartAndStop.ShadowDecoration.Parent = Me.StartAndStop
			Me.StartAndStop.Size = New Global.System.Drawing.Size(157, 31)
			Me.StartAndStop.TabIndex = 558
			Me.StartAndStop.Text = "Start"
			Me.combxListenClient.DataSource = Nothing
			Me.combxListenClient.DropDownWidth = 500
			Me.combxListenClient.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.combxListenClient.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.combxListenClient.FillDisableColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.combxListenClient.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.combxListenClient.ForeColor = Global.System.Drawing.Color.White
			Me.combxListenClient.Location = New Global.System.Drawing.Point(16, 318)
			Me.combxListenClient.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.combxListenClient.MinimumSize = New Global.System.Drawing.Size(63, 0)
			Me.combxListenClient.Name = "combxListenClient"
			Me.combxListenClient.Padding = New Global.System.Windows.Forms.Padding(0, 0, 30, 2)
			Me.combxListenClient.Radius = 15
			Me.combxListenClient.RectColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.combxListenClient.Size = New Global.System.Drawing.Size(353, 31)
			Me.combxListenClient.Style = Global.Sunny.UI.UIStyle.Custom
			Me.combxListenClient.TabIndex = 579
			Me.combxListenClient.TextAlignment = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.CombxSpeakClient.DataSource = Nothing
			Me.CombxSpeakClient.DropDownWidth = 500
			Me.CombxSpeakClient.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.CombxSpeakClient.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.CombxSpeakClient.FillDisableColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.CombxSpeakClient.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.CombxSpeakClient.ForeColor = Global.System.Drawing.Color.White
			Me.CombxSpeakClient.Location = New Global.System.Drawing.Point(16, 190)
			Me.CombxSpeakClient.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.CombxSpeakClient.MinimumSize = New Global.System.Drawing.Size(63, 0)
			Me.CombxSpeakClient.Name = "CombxSpeakClient"
			Me.CombxSpeakClient.Padding = New Global.System.Windows.Forms.Padding(0, 0, 30, 2)
			Me.CombxSpeakClient.Radius = 15
			Me.CombxSpeakClient.RectColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.CombxSpeakClient.Size = New Global.System.Drawing.Size(353, 31)
			Me.CombxSpeakClient.Style = Global.Sunny.UI.UIStyle.Custom
			Me.CombxSpeakClient.TabIndex = 580
			Me.CombxSpeakClient.TextAlignment = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label1.AutoSize = True
			Me.Label1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.Label1.Location = New Global.System.Drawing.Point(15, 169)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(47, 14)
			Me.Label1.TabIndex = 581
			Me.Label1.Text = "Speak :"
			Me.Label2.AutoSize = True
			Me.Label2.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label2.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Label2.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.Label2.Location = New Global.System.Drawing.Point(15, 299)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(49, 14)
			Me.Label2.TabIndex = 582
			Me.Label2.Text = "Lisren :"
			Me.UiLine1.Direction = Global.Sunny.UI.UILine.LineDirection.Vertical
			Me.UiLine1.FillColor = Global.System.Drawing.Color.Transparent
			Me.UiLine1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 12F)
			Me.UiLine1.LineColor = Global.System.Drawing.Color.FromArgb(64, 64, 64)
			Me.UiLine1.LineDashStyle = Global.Sunny.UI.UILineDashStyle.None
			Me.UiLine1.Location = New Global.System.Drawing.Point(396, 84)
			Me.UiLine1.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.UiLine1.Name = "UiLine1"
			Me.UiLine1.Size = New Global.System.Drawing.Size(16, 352)
			Me.UiLine1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLine1.TabIndex = 591
			Me.Label3.AutoSize = True
			Me.Label3.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label3.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Label3.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.Label3.Location = New Global.System.Drawing.Point(426, 299)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Global.System.Drawing.Size(49, 14)
			Me.Label3.TabIndex = 595
			Me.Label3.Text = "Lisren :"
			Me.Label4.AutoSize = True
			Me.Label4.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label4.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Label4.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.Label4.Location = New Global.System.Drawing.Point(426, 169)
			Me.Label4.Name = "Label4"
			Me.Label4.Size = New Global.System.Drawing.Size(47, 14)
			Me.Label4.TabIndex = 594
			Me.Label4.Text = "Speak :"
			Me.CombxSpeakServer.DataSource = Nothing
			Me.CombxSpeakServer.DropDownWidth = 500
			Me.CombxSpeakServer.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.CombxSpeakServer.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.CombxSpeakServer.FillDisableColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.CombxSpeakServer.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.CombxSpeakServer.ForeColor = Global.System.Drawing.Color.White
			Me.CombxSpeakServer.Location = New Global.System.Drawing.Point(429, 190)
			Me.CombxSpeakServer.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.CombxSpeakServer.MinimumSize = New Global.System.Drawing.Size(63, 0)
			Me.CombxSpeakServer.Name = "CombxSpeakServer"
			Me.CombxSpeakServer.Padding = New Global.System.Windows.Forms.Padding(0, 0, 30, 2)
			Me.CombxSpeakServer.Radius = 15
			Me.CombxSpeakServer.RectColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.CombxSpeakServer.Size = New Global.System.Drawing.Size(353, 31)
			Me.CombxSpeakServer.Style = Global.Sunny.UI.UIStyle.Custom
			Me.CombxSpeakServer.TabIndex = 593
			Me.CombxSpeakServer.TextAlignment = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.CombxListenServer.DataSource = Nothing
			Me.CombxListenServer.DropDownWidth = 500
			Me.CombxListenServer.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.CombxListenServer.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.CombxListenServer.FillDisableColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.CombxListenServer.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.CombxListenServer.ForeColor = Global.System.Drawing.Color.White
			Me.CombxListenServer.Location = New Global.System.Drawing.Point(429, 318)
			Me.CombxListenServer.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.CombxListenServer.MinimumSize = New Global.System.Drawing.Size(63, 0)
			Me.CombxListenServer.Name = "CombxListenServer"
			Me.CombxListenServer.Padding = New Global.System.Windows.Forms.Padding(0, 0, 30, 2)
			Me.CombxListenServer.Radius = 15
			Me.CombxListenServer.RectColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.CombxListenServer.Size = New Global.System.Drawing.Size(353, 31)
			Me.CombxListenServer.Style = Global.Sunny.UI.UIStyle.Custom
			Me.CombxListenServer.TabIndex = 592
			Me.CombxListenServer.TextAlignment = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Jitter.Animated = True
			Me.Jitter.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.Jitter.BorderColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.Jitter.BorderRadius = 7
			Me.Jitter.BorderStyle = Global.System.Drawing.Drawing2D.DashStyle.Custom
			Me.Jitter.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.Jitter.DefaultText = "20"
			Me.Jitter.DisabledState.BorderColor = Global.System.Drawing.Color.FromArgb(208, 208, 208)
			Me.Jitter.DisabledState.FillColor = Global.System.Drawing.Color.FromArgb(226, 226, 226)
			Me.Jitter.DisabledState.ForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.Jitter.DisabledState.Parent = Me.Jitter
			Me.Jitter.DisabledState.PlaceholderForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.Jitter.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.Jitter.FocusedState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.Jitter.FocusedState.Parent = Me.Jitter
			Me.Jitter.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Jitter.ForeColor = Global.System.Drawing.Color.White
			Me.Jitter.HoverState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.Jitter.HoverState.Parent = Me.Jitter
			Me.Jitter.Location = New Global.System.Drawing.Point(429, 256)
			Me.Jitter.Margin = New Global.System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.Jitter.Name = "Jitter"
			Me.Jitter.PasswordChar = vbNullChar
			Me.Jitter.PlaceholderForeColor = Global.System.Drawing.Color.Gray
			Me.Jitter.PlaceholderText = "Jitter"
			Me.Jitter.SelectedText = ""
			Me.Jitter.SelectionStart = 2
			Me.Jitter.ShadowDecoration.Parent = Me.Jitter
			Me.Jitter.Size = New Global.System.Drawing.Size(108, 31)
			Me.Jitter.TabIndex = 598
			Me.Jitter.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.BufferCount.DataSource = Nothing
			Me.BufferCount.DropDownWidth = 500
			Me.BufferCount.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.BufferCount.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.BufferCount.FillDisableColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.BufferCount.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.BufferCount.ForeColor = Global.System.Drawing.Color.White
			Me.BufferCount.Items.AddRange(New Object() { "5000", "8000", "22050", "44100" })
			Me.BufferCount.Location = New Global.System.Drawing.Point(429, 388)
			Me.BufferCount.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.BufferCount.MinimumSize = New Global.System.Drawing.Size(63, 0)
			Me.BufferCount.Name = "BufferCount"
			Me.BufferCount.Padding = New Global.System.Windows.Forms.Padding(0, 0, 30, 2)
			Me.BufferCount.Radius = 15
			Me.BufferCount.RectColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.BufferCount.Size = New Global.System.Drawing.Size(108, 31)
			Me.BufferCount.Style = Global.Sunny.UI.UIStyle.Custom
			Me.BufferCount.TabIndex = 599
			Me.BufferCount.TextAlignment = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Mini.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Mini.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Mini.Location = New Global.System.Drawing.Point(728, 12)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 556
			Me.Mini.Text = "ValleyMini1"
			Me.MAX.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.MAX.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.MAX.Enabled = False
			Me.MAX.Location = New Global.System.Drawing.Point(754, 12)
			Me.MAX.Name = "MAX"
			Me.MAX.Size = New Global.System.Drawing.Size(20, 20)
			Me.MAX.TabIndex = 555
			Me.MAX.Text = "ValleyMax1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(780, 12)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 554
			Me.ExitForm.Text = "ValleyClose1"
			Me.SpeakClient.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Zoom
			Me.SpeakClient.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.SpeakClient.Enabled = False
			Me.SpeakClient.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.SpeakClient.Image = CType(componentResourceManager.GetObject("SpeakClient.Image"), Global.System.Drawing.Image)
			Me.SpeakClient.Location = New Global.System.Drawing.Point(323, 229)
			Me.SpeakClient.Name = "SpeakClient"
			Me.SpeakClient.Size = New Global.System.Drawing.Size(67, 62)
			Me.SpeakClient.TabIndex = 601
			Me.SpeakClient.UseVisualStyleBackColor = True
			Me.ListenClient.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Zoom
			Me.ListenClient.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ListenClient.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.ListenClient.Image = Global.S500RAT.My.Resources.Resources.ListenOFF
			Me.ListenClient.Location = New Global.System.Drawing.Point(323, 357)
			Me.ListenClient.Name = "ListenClient"
			Me.ListenClient.Size = New Global.System.Drawing.Size(67, 62)
			Me.ListenClient.TabIndex = 604
			Me.ListenClient.UseVisualStyleBackColor = True
			Me.ListenServer.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Zoom
			Me.ListenServer.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ListenServer.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.ListenServer.Image = Global.S500RAT.My.Resources.Resources.ListenOFF
			Me.ListenServer.Location = New Global.System.Drawing.Point(738, 357)
			Me.ListenServer.Name = "ListenServer"
			Me.ListenServer.Size = New Global.System.Drawing.Size(67, 62)
			Me.ListenServer.TabIndex = 606
			Me.ListenServer.UseVisualStyleBackColor = True
			Me.SpeakServer.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Zoom
			Me.SpeakServer.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.SpeakServer.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.SpeakServer.Image = CType(componentResourceManager.GetObject("SpeakServer.Image"), Global.System.Drawing.Image)
			Me.SpeakServer.Location = New Global.System.Drawing.Point(738, 229)
			Me.SpeakServer.Name = "SpeakServer"
			Me.SpeakServer.Size = New Global.System.Drawing.Size(67, 62)
			Me.SpeakServer.TabIndex = 605
			Me.SpeakServer.UseVisualStyleBackColor = True
			Me.UiLine2.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.UiLine2.FillColor = Global.System.Drawing.Color.Transparent
			Me.UiLine2.Font = New Global.System.Drawing.Font("Microsoft YaHei", 12F)
			Me.UiLine2.LineColor = Global.System.Drawing.Color.FromArgb(64, 64, 64)
			Me.UiLine2.LineDashStyle = Global.Sunny.UI.UILineDashStyle.None
			Me.UiLine2.Location = New Global.System.Drawing.Point(-9, 430)
			Me.UiLine2.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.UiLine2.Name = "UiLine2"
			Me.UiLine2.Size = New Global.System.Drawing.Size(874, 15)
			Me.UiLine2.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLine2.TabIndex = 607
			Me.UiLine3.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.UiLine3.FillColor = Global.System.Drawing.Color.Transparent
			Me.UiLine3.Font = New Global.System.Drawing.Font("Microsoft YaHei", 12F)
			Me.UiLine3.LineColor = Global.System.Drawing.Color.FromArgb(64, 64, 64)
			Me.UiLine3.LineDashStyle = Global.Sunny.UI.UILineDashStyle.None
			Me.UiLine3.Location = New Global.System.Drawing.Point(-9, 84)
			Me.UiLine3.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.UiLine3.Name = "UiLine3"
			Me.UiLine3.Size = New Global.System.Drawing.Size(833, 15)
			Me.UiLine3.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLine3.TabIndex = 608
			Me.PictureBox1.Image = CType(componentResourceManager.GetObject("PictureBox1.Image"), Global.System.Drawing.Image)
			Me.PictureBox1.Location = New Global.System.Drawing.Point(750, 105)
			Me.PictureBox1.Name = "PictureBox1"
			Me.PictureBox1.Size = New Global.System.Drawing.Size(55, 48)
			Me.PictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox1.TabIndex = 609
			Me.PictureBox1.TabStop = False
			Me.PictureBox2.Image = CType(componentResourceManager.GetObject("PictureBox2.Image"), Global.System.Drawing.Image)
			Me.PictureBox2.Location = New Global.System.Drawing.Point(335, 105)
			Me.PictureBox2.Name = "PictureBox2"
			Me.PictureBox2.Size = New Global.System.Drawing.Size(55, 48)
			Me.PictureBox2.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox2.TabIndex = 610
			Me.PictureBox2.TabStop = False
			Me.Label5.AutoSize = True
			Me.Label5.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label5.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label5.ForeColor = Global.System.Drawing.Color.White
			Me.Label5.Location = New Global.System.Drawing.Point(418, 105)
			Me.Label5.Name = "Label5"
			Me.Label5.Size = New Global.System.Drawing.Size(27, 17)
			Me.Label5.TabIndex = 611
			Me.Label5.Text = "Me"
			Me.Label6.AutoSize = True
			Me.Label6.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label6.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label6.ForeColor = Global.System.Drawing.Color.White
			Me.Label6.Location = New Global.System.Drawing.Point(12, 105)
			Me.Label6.Name = "Label6"
			Me.Label6.Size = New Global.System.Drawing.Size(44, 17)
			Me.Label6.TabIndex = 612
			Me.Label6.Text = "Client"
			Me.Label7.AutoSize = True
			Me.Label7.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label7.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F)
			Me.Label7.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.Label7.Location = New Global.System.Drawing.Point(418, 122)
			Me.Label7.Name = "Label7"
			Me.Label7.Size = New Global.System.Drawing.Size(141, 16)
			Me.Label7.TabIndex = 613
			Me.Label7.Text = "Control your microphone"
			Me.Label8.AutoSize = True
			Me.Label8.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label8.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F)
			Me.Label8.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.Label8.Location = New Global.System.Drawing.Point(12, 125)
			Me.Label8.Name = "Label8"
			Me.Label8.Size = New Global.System.Drawing.Size(180, 16)
			Me.Label8.TabIndex = 614
			Me.Label8.Text = "Microphone control of the client"
			Me.ProgressBar1.AutoRoundedCorners = True
			Me.ProgressBar1.BackColor = Global.System.Drawing.Color.Transparent
			Me.ProgressBar1.BorderRadius = 14
			Me.ProgressBar1.GradientMode = Global.System.Drawing.Drawing2D.LinearGradientMode.Horizontal
			Me.ProgressBar1.Location = New Global.System.Drawing.Point(12, 454)
			Me.ProgressBar1.Name = "ProgressBar1"
			Me.ProgressBar1.ShadowDecoration.Parent = Me.ProgressBar1
			Me.ProgressBar1.Size = New Global.System.Drawing.Size(300, 31)
			Me.ProgressBar1.TabIndex = 619
			Me.ProgressBar1.TextRenderingHint = Global.System.Drawing.Text.TextRenderingHint.SystemDefault
			Me.ProgressBar1.UseTransparentBackground = True
			Me.ProgressBar1.Value = 50
			Me.ProgressBar1.Visible = False
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			MyBase.ClientSize = New Global.System.Drawing.Size(816, 499)
			MyBase.Controls.Add(Me.ProgressBar1)
			MyBase.Controls.Add(Me.Label8)
			MyBase.Controls.Add(Me.Label7)
			MyBase.Controls.Add(Me.Label6)
			MyBase.Controls.Add(Me.Label5)
			MyBase.Controls.Add(Me.PictureBox2)
			MyBase.Controls.Add(Me.PictureBox1)
			MyBase.Controls.Add(Me.UiLine3)
			MyBase.Controls.Add(Me.UiLine2)
			MyBase.Controls.Add(Me.ListenServer)
			MyBase.Controls.Add(Me.SpeakServer)
			MyBase.Controls.Add(Me.ListenClient)
			MyBase.Controls.Add(Me.SpeakClient)
			MyBase.Controls.Add(Me.BufferCount)
			MyBase.Controls.Add(Me.Jitter)
			MyBase.Controls.Add(Me.Label3)
			MyBase.Controls.Add(Me.Label4)
			MyBase.Controls.Add(Me.CombxSpeakServer)
			MyBase.Controls.Add(Me.CombxListenServer)
			MyBase.Controls.Add(Me.UiLine1)
			MyBase.Controls.Add(Me.Label2)
			MyBase.Controls.Add(Me.Label1)
			MyBase.Controls.Add(Me.CombxSpeakClient)
			MyBase.Controls.Add(Me.combxListenClient)
			MyBase.Controls.Add(Me.StartAndStop)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.MAX)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.UiLabel1)
			MyBase.Controls.Add(Me.ClientInfo)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "Microphone"
			Me.Text = "Microphone"
			MyBase.TopMost = True
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.PictureBox2, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x04000781 RID: 1921
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
