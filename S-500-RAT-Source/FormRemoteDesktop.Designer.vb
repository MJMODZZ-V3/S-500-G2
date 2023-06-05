Namespace S500RAT
	' Token: 0x0200002D RID: 45
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormRemoteDesktop
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000874 RID: 2164 RVA: 0x000452A0 File Offset: 0x000434A0
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

		' Token: 0x06000875 RID: 2165 RVA: 0x000452F0 File Offset: 0x000434F0
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormRemoteDesktop))
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.UiLabel1 = New Global.Sunny.UI.UILabel()
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.Guna2ResizeBox1 = New Global.Guna.UI2.WinForms.Guna2ResizeBox()
			Me.UiMillisecondTimer1 = New Global.Sunny.UI.UIMillisecondTimer(Me.components)
			Me.UiToolTip1 = New Global.Sunny.UI.UIToolTip(Me.components)
			Me.TimerSave = New Global.System.Windows.Forms.Timer(Me.components)
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.StartAndStop = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.Mouse = New Global.Guna.UI2.WinForms.Guna2ToggleSwitch()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Video = New Global.Guna.UI2.WinForms.Guna2ToggleSwitch()
			Me.Keyboard = New Global.Guna.UI2.WinForms.Guna2ToggleSwitch()
			Me.Label22 = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.MAX = New Global.S500RAT.ValleyMax()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			Me.Quality = New Global.Guna.UI2.WinForms.Guna2HtmlLabel()
			Me.QualityUsing = New Global.Guna.UI2.WinForms.Guna2TrackBar()
			Me.SizeImage = New Global.System.Windows.Forms.Label()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.ImageSaved = New Global.System.Windows.Forms.Label()
			Me.FPS = New Global.System.Windows.Forms.Label()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.DisplayScreen = New Global.System.Windows.Forms.Label()
			Me.Label9 = New Global.System.Windows.Forms.Label()
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.Timer1.Interval = 2000
			Me.UiLabel1.AutoSize = True
			Me.UiLabel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel1.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel1.Location = New Global.System.Drawing.Point(18, 13)
			Me.UiLabel1.Name = "UiLabel1"
			Me.UiLabel1.Size = New Global.System.Drawing.Size(120, 19)
			Me.UiLabel1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLabel1.TabIndex = 334
			Me.UiLabel1.Text = "Remote Desktop"
			Me.UiLabel1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(19, 37)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(200, 16)
			Me.ClientInfo.TabIndex = 335
			Me.ClientInfo.Text = "FC / Desktop_3424 / Windows 10 pro"
			Me.Guna2ResizeBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Guna2ResizeBox1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Guna2ResizeBox1.FillColor = Global.System.Drawing.Color.Silver
			Me.Guna2ResizeBox1.ForeColor = Global.System.Drawing.Color.Empty
			Me.Guna2ResizeBox1.Location = New Global.System.Drawing.Point(535, 462)
			Me.Guna2ResizeBox1.Name = "Guna2ResizeBox1"
			Me.Guna2ResizeBox1.Size = New Global.System.Drawing.Size(17, 19)
			Me.Guna2ResizeBox1.TabIndex = 512
			Me.Guna2ResizeBox1.TargetControl = Me
			Me.Guna2ResizeBox1.UseTransparentBackground = True
			Me.UiMillisecondTimer1.TagString = Nothing
			Me.UiToolTip1.BackColor = Global.System.Drawing.Color.FromArgb(54, 54, 54)
			Me.UiToolTip1.ForeColor = Global.System.Drawing.Color.FromArgb(239, 239, 239)
			Me.UiToolTip1.OwnerDraw = True
			Me.PictureBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.PictureBox1.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.PictureBox1.ErrorImage = Global.S500RAT.My.Resources.Resources.XXXX
			Me.PictureBox1.Location = New Global.System.Drawing.Point(12, 80)
			Me.PictureBox1.Name = "PictureBox1"
			Me.PictureBox1.Size = New Global.System.Drawing.Size(538, 267)
			Me.PictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox1.TabIndex = 523
			Me.PictureBox1.TabStop = False
			Me.StartAndStop.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.StartAndStop.BackColor = Global.System.Drawing.Color.Transparent
			Me.StartAndStop.BorderRadius = 8
			Me.StartAndStop.CheckedState.Parent = Me.StartAndStop
			Me.StartAndStop.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.StartAndStop.CustomImages.Parent = Me.StartAndStop
			Me.StartAndStop.Enabled = False
			Me.StartAndStop.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.StartAndStop.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.StartAndStop.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.StartAndStop.ForeColor = Global.System.Drawing.Color.White
			Me.StartAndStop.HoverState.Parent = Me.StartAndStop
			Me.StartAndStop.Location = New Global.System.Drawing.Point(443, 435)
			Me.StartAndStop.Name = "StartAndStop"
			Me.StartAndStop.ShadowDecoration.Color = Global.System.Drawing.Color.White
			Me.StartAndStop.ShadowDecoration.Parent = Me.StartAndStop
			Me.StartAndStop.Size = New Global.System.Drawing.Size(92, 29)
			Me.StartAndStop.TabIndex = 492
			Me.StartAndStop.Tag = "Start"
			Me.StartAndStop.Text = "Start"
			Me.Mouse.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.Mouse.Animated = True
			Me.Mouse.AutoRoundedCorners = True
			Me.Mouse.BackColor = Global.System.Drawing.Color.Transparent
			Me.Mouse.CheckedState.BorderColor = Global.System.Drawing.Color.FromArgb(82, 43, 235)
			Me.Mouse.CheckedState.BorderRadius = 8
			Me.Mouse.CheckedState.FillColor = Global.System.Drawing.Color.FromArgb(82, 43, 235)
			Me.Mouse.CheckedState.InnerBorderColor = Global.System.Drawing.Color.White
			Me.Mouse.CheckedState.InnerBorderRadius = 4
			Me.Mouse.CheckedState.InnerColor = Global.System.Drawing.Color.White
			Me.Mouse.CheckedState.Parent = Me.Mouse
			Me.Mouse.Enabled = False
			Me.Mouse.Location = New Global.System.Drawing.Point(12, 396)
			Me.Mouse.Name = "Mouse"
			Me.Mouse.ShadowDecoration.Parent = Me.Mouse
			Me.Mouse.Size = New Global.System.Drawing.Size(35, 19)
			Me.Mouse.TabIndex = 487
			Me.Mouse.UncheckedState.BorderColor = Global.System.Drawing.Color.Red
			Me.Mouse.UncheckedState.BorderRadius = 8
			Me.Mouse.UncheckedState.FillColor = Global.System.Drawing.Color.FromArgb(66, 69, 91)
			Me.Mouse.UncheckedState.InnerBorderColor = Global.System.Drawing.Color.White
			Me.Mouse.UncheckedState.InnerBorderRadius = 4
			Me.Mouse.UncheckedState.InnerColor = Global.System.Drawing.Color.White
			Me.Mouse.UncheckedState.Parent = Me.Mouse
			Me.Label1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.Label1.AutoSize = True
			Me.Label1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label1.Enabled = False
			Me.Label1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Label1.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.Label1.Location = New Global.System.Drawing.Point(146, 399)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(59, 14)
			Me.Label1.TabIndex = 490
			Me.Label1.Text = "Keyboard"
			Me.Video.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.Video.Animated = True
			Me.Video.AutoRoundedCorners = True
			Me.Video.BackColor = Global.System.Drawing.Color.Transparent
			Me.Video.CheckedState.BorderColor = Global.System.Drawing.Color.FromArgb(82, 43, 235)
			Me.Video.CheckedState.BorderRadius = 8
			Me.Video.CheckedState.FillColor = Global.System.Drawing.Color.FromArgb(82, 43, 235)
			Me.Video.CheckedState.InnerBorderColor = Global.System.Drawing.Color.White
			Me.Video.CheckedState.InnerBorderRadius = 4
			Me.Video.CheckedState.InnerColor = Global.System.Drawing.Color.White
			Me.Video.CheckedState.Parent = Me.Video
			Me.Video.Enabled = False
			Me.Video.Location = New Global.System.Drawing.Point(212, 396)
			Me.Video.Name = "Video"
			Me.Video.ShadowDecoration.Parent = Me.Video
			Me.Video.Size = New Global.System.Drawing.Size(35, 19)
			Me.Video.TabIndex = 496
			Me.Video.UncheckedState.BorderColor = Global.System.Drawing.Color.Red
			Me.Video.UncheckedState.BorderRadius = 8
			Me.Video.UncheckedState.FillColor = Global.System.Drawing.Color.FromArgb(66, 69, 91)
			Me.Video.UncheckedState.InnerBorderColor = Global.System.Drawing.Color.White
			Me.Video.UncheckedState.InnerBorderRadius = 4
			Me.Video.UncheckedState.InnerColor = Global.System.Drawing.Color.White
			Me.Video.UncheckedState.Parent = Me.Video
			Me.Keyboard.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.Keyboard.Animated = True
			Me.Keyboard.AutoRoundedCorners = True
			Me.Keyboard.BackColor = Global.System.Drawing.Color.Transparent
			Me.Keyboard.CheckedState.BorderColor = Global.System.Drawing.Color.FromArgb(82, 43, 235)
			Me.Keyboard.CheckedState.BorderRadius = 8
			Me.Keyboard.CheckedState.FillColor = Global.System.Drawing.Color.FromArgb(82, 43, 235)
			Me.Keyboard.CheckedState.InnerBorderColor = Global.System.Drawing.Color.White
			Me.Keyboard.CheckedState.InnerBorderRadius = 4
			Me.Keyboard.CheckedState.InnerColor = Global.System.Drawing.Color.White
			Me.Keyboard.CheckedState.Parent = Me.Keyboard
			Me.Keyboard.Enabled = False
			Me.Keyboard.Location = New Global.System.Drawing.Point(105, 396)
			Me.Keyboard.Name = "Keyboard"
			Me.Keyboard.ShadowDecoration.Parent = Me.Keyboard
			Me.Keyboard.Size = New Global.System.Drawing.Size(35, 19)
			Me.Keyboard.TabIndex = 489
			Me.Keyboard.UncheckedState.BorderColor = Global.System.Drawing.Color.Red
			Me.Keyboard.UncheckedState.BorderRadius = 8
			Me.Keyboard.UncheckedState.FillColor = Global.System.Drawing.Color.FromArgb(66, 69, 91)
			Me.Keyboard.UncheckedState.InnerBorderColor = Global.System.Drawing.Color.White
			Me.Keyboard.UncheckedState.InnerBorderRadius = 4
			Me.Keyboard.UncheckedState.InnerColor = Global.System.Drawing.Color.White
			Me.Keyboard.UncheckedState.Parent = Me.Keyboard
			Me.Label22.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.Label22.AutoSize = True
			Me.Label22.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label22.Enabled = False
			Me.Label22.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Label22.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.Label22.Location = New Global.System.Drawing.Point(52, 399)
			Me.Label22.Name = "Label22"
			Me.Label22.Size = New Global.System.Drawing.Size(45, 14)
			Me.Label22.TabIndex = 488
			Me.Label22.Text = "Mouse"
			Me.Label2.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.Label2.AutoSize = True
			Me.Label2.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label2.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Label2.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.Label2.Location = New Global.System.Drawing.Point(252, 399)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(33, 14)
			Me.Label2.TabIndex = 497
			Me.Label2.Text = "Save"
			Me.Mini.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Mini.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Mini.Location = New Global.System.Drawing.Point(479, 12)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 569
			Me.Mini.Text = "ValleyMini1"
			Me.MAX.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.MAX.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.MAX.Location = New Global.System.Drawing.Point(505, 12)
			Me.MAX.Name = "MAX"
			Me.MAX.Size = New Global.System.Drawing.Size(20, 20)
			Me.MAX.TabIndex = 568
			Me.MAX.Text = "ValleyMax1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(531, 12)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 567
			Me.ExitForm.Text = "ValleyClose1"
			Me.Quality.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Quality.BackColor = Global.System.Drawing.Color.Transparent
			Me.Quality.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Quality.ForeColor = Global.System.Drawing.Color.White
			Me.Quality.Location = New Global.System.Drawing.Point(482, 360)
			Me.Quality.Name = "Quality"
			Me.Quality.Size = New Global.System.Drawing.Size(64, 16)
			Me.Quality.TabIndex = 582
			Me.Quality.Text = "80% Quality"
			Me.QualityUsing.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.QualityUsing.Enabled = False
			Me.QualityUsing.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.QualityUsing.HoverState.Parent = Me.QualityUsing
			Me.QualityUsing.IndicateFocus = False
			Me.QualityUsing.Location = New Global.System.Drawing.Point(12, 353)
			Me.QualityUsing.Name = "QualityUsing"
			Me.QualityUsing.Size = New Global.System.Drawing.Size(464, 31)
			Me.QualityUsing.TabIndex = 583
			Me.QualityUsing.ThumbColor = Global.System.Drawing.Color.FromArgb(173, 178, 181)
			Me.QualityUsing.Value = 80
			Me.SizeImage.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.SizeImage.AutoSize = True
			Me.SizeImage.BackColor = Global.System.Drawing.Color.Transparent
			Me.SizeImage.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.SizeImage.ForeColor = Global.System.Drawing.Color.White
			Me.SizeImage.Location = New Global.System.Drawing.Point(359, 399)
			Me.SizeImage.Name = "SizeImage"
			Me.SizeImage.Size = New Global.System.Drawing.Size(13, 14)
			Me.SizeImage.TabIndex = 591
			Me.SizeImage.Text = "0"
			Me.Label4.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.Label4.AutoSize = True
			Me.Label4.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label4.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Label4.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.Label4.Location = New Global.System.Drawing.Point(322, 399)
			Me.Label4.Name = "Label4"
			Me.Label4.Size = New Global.System.Drawing.Size(39, 14)
			Me.Label4.TabIndex = 590
			Me.Label4.Text = "Size : "
			Me.ImageSaved.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.ImageSaved.AutoSize = True
			Me.ImageSaved.BackColor = Global.System.Drawing.Color.Transparent
			Me.ImageSaved.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ImageSaved.ForeColor = Global.System.Drawing.Color.Red
			Me.ImageSaved.Location = New Global.System.Drawing.Point(291, 399)
			Me.ImageSaved.Name = "ImageSaved"
			Me.ImageSaved.Size = New Global.System.Drawing.Size(13, 14)
			Me.ImageSaved.TabIndex = 589
			Me.ImageSaved.Text = "0"
			Me.FPS.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.FPS.AutoSize = True
			Me.FPS.BackColor = Global.System.Drawing.Color.Transparent
			Me.FPS.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.FPS.ForeColor = Global.System.Drawing.Color.White
			Me.FPS.Location = New Global.System.Drawing.Point(433, 399)
			Me.FPS.Name = "FPS"
			Me.FPS.Size = New Global.System.Drawing.Size(13, 14)
			Me.FPS.TabIndex = 588
			Me.FPS.Text = "0"
			Me.Label5.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.Label5.AutoSize = True
			Me.Label5.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label5.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Label5.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.Label5.Location = New Global.System.Drawing.Point(396, 399)
			Me.Label5.Name = "Label5"
			Me.Label5.Size = New Global.System.Drawing.Size(36, 14)
			Me.Label5.TabIndex = 587
			Me.Label5.Text = "FPS : "
			Me.DisplayScreen.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.DisplayScreen.AutoSize = True
			Me.DisplayScreen.BackColor = Global.System.Drawing.Color.Transparent
			Me.DisplayScreen.Font = New Global.System.Drawing.Font("Arial", 18F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.DisplayScreen.ForeColor = Global.System.Drawing.Color.White
			Me.DisplayScreen.Location = New Global.System.Drawing.Point(50, 435)
			Me.DisplayScreen.Name = "DisplayScreen"
			Me.DisplayScreen.Size = New Global.System.Drawing.Size(118, 29)
			Me.DisplayScreen.TabIndex = 593
			Me.DisplayScreen.Text = "800 x 600"
			Me.Label9.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.Label9.AutoSize = True
			Me.Label9.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label9.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Label9.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.Label9.Location = New Global.System.Drawing.Point(9, 435)
			Me.Label9.Name = "Label9"
			Me.Label9.Size = New Global.System.Drawing.Size(39, 14)
			Me.Label9.TabIndex = 592
			Me.Label9.Text = "Size : "
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
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(96F, 96F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Dpi
			Me.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			MyBase.ClientSize = New Global.System.Drawing.Size(563, 491)
			MyBase.Controls.Add(Me.DisplayScreen)
			MyBase.Controls.Add(Me.Label9)
			MyBase.Controls.Add(Me.SizeImage)
			MyBase.Controls.Add(Me.Label4)
			MyBase.Controls.Add(Me.ImageSaved)
			MyBase.Controls.Add(Me.FPS)
			MyBase.Controls.Add(Me.Label5)
			MyBase.Controls.Add(Me.Quality)
			MyBase.Controls.Add(Me.QualityUsing)
			MyBase.Controls.Add(Me.PictureBox1)
			MyBase.Controls.Add(Me.StartAndStop)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.Mouse)
			MyBase.Controls.Add(Me.Label1)
			MyBase.Controls.Add(Me.Video)
			MyBase.Controls.Add(Me.MAX)
			MyBase.Controls.Add(Me.Keyboard)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.Label22)
			MyBase.Controls.Add(Me.Label2)
			MyBase.Controls.Add(Me.Guna2ResizeBox1)
			MyBase.Controls.Add(Me.UiLabel1)
			MyBase.Controls.Add(Me.ClientInfo)
			Me.DoubleBuffered = True
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "FormRemoteDesktop"
			Me.Text = "FormRemoteDesktop"
			MyBase.TopMost = True
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x040003C1 RID: 961
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
