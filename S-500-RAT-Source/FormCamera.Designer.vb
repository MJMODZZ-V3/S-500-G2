Namespace S500RAT
	' Token: 0x02000011 RID: 17
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormCamera
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060000E5 RID: 229 RVA: 0x00007EE8 File Offset: 0x000060E8
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

		' Token: 0x060000E6 RID: 230 RVA: 0x00007F38 File Offset: 0x00006138
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormCamera))
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.UiLabel1 = New Global.Sunny.UI.UILabel()
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.pictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.TextFPS = New Global.System.Windows.Forms.Label()
			Me.Label10 = New Global.System.Windows.Forms.Label()
			Me.Guna2ResizeBox1 = New Global.Guna.UI2.WinForms.Guna2ResizeBox()
			Me.StartAndStop = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.SaveScreen = New Global.Guna.UI2.WinForms.Guna2ToggleSwitch()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.comboBox1 = New Global.Sunny.UI.UIComboBox()
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.Quality = New Global.Guna.UI2.WinForms.Guna2HtmlLabel()
			Me.QualityUsing = New Global.Guna.UI2.WinForms.Guna2TrackBar()
			Me.ImageSaved = New Global.System.Windows.Forms.Label()
			Me.SizeImage = New Global.System.Windows.Forms.Label()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.MAX = New Global.S500RAT.ValleyMax()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			CType(Me.pictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.Timer1.Interval = 2000
			Me.UiLabel1.AutoSize = True
			Me.UiLabel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel1.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel1.Location = New Global.System.Drawing.Point(27, 12)
			Me.UiLabel1.Name = "UiLabel1"
			Me.UiLabel1.Size = New Global.System.Drawing.Size(68, 19)
			Me.UiLabel1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLabel1.TabIndex = 529
			Me.UiLabel1.Text = "Webcam"
			Me.UiLabel1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(28, 38)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(200, 16)
			Me.ClientInfo.TabIndex = 530
			Me.ClientInfo.Text = "FC / Desktop_3424 / Windows 10 pro"
			Me.pictureBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.pictureBox1.Location = New Global.System.Drawing.Point(13, 74)
			Me.pictureBox1.Margin = New Global.System.Windows.Forms.Padding(2)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New Global.System.Drawing.Size(481, 228)
			Me.pictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.pictureBox1.TabIndex = 532
			Me.pictureBox1.TabStop = False
			Me.TextFPS.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.TextFPS.AutoSize = True
			Me.TextFPS.BackColor = Global.System.Drawing.Color.Transparent
			Me.TextFPS.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.TextFPS.ForeColor = Global.System.Drawing.Color.White
			Me.TextFPS.Location = New Global.System.Drawing.Point(282, 393)
			Me.TextFPS.Name = "TextFPS"
			Me.TextFPS.Size = New Global.System.Drawing.Size(13, 14)
			Me.TextFPS.TabIndex = 541
			Me.TextFPS.Text = "0"
			Me.Label10.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.Label10.AutoSize = True
			Me.Label10.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label10.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Label10.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.Label10.Location = New Global.System.Drawing.Point(245, 393)
			Me.Label10.Name = "Label10"
			Me.Label10.Size = New Global.System.Drawing.Size(36, 14)
			Me.Label10.TabIndex = 540
			Me.Label10.Text = "FPS : "
			Me.Guna2ResizeBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Guna2ResizeBox1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Guna2ResizeBox1.FillColor = Global.System.Drawing.Color.Silver
			Me.Guna2ResizeBox1.ForeColor = Global.System.Drawing.Color.Empty
			Me.Guna2ResizeBox1.Location = New Global.System.Drawing.Point(478, 424)
			Me.Guna2ResizeBox1.Name = "Guna2ResizeBox1"
			Me.Guna2ResizeBox1.Size = New Global.System.Drawing.Size(20, 20)
			Me.Guna2ResizeBox1.TabIndex = 533
			Me.Guna2ResizeBox1.TargetControl = Me
			Me.Guna2ResizeBox1.UseTransparentBackground = True
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
			Me.StartAndStop.Location = New Global.System.Drawing.Point(378, 389)
			Me.StartAndStop.Name = "StartAndStop"
			Me.StartAndStop.ShadowDecoration.Color = Global.System.Drawing.Color.White
			Me.StartAndStop.ShadowDecoration.Parent = Me.StartAndStop
			Me.StartAndStop.Size = New Global.System.Drawing.Size(115, 31)
			Me.StartAndStop.TabIndex = 573
			Me.StartAndStop.Text = "Start"
			Me.SaveScreen.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.SaveScreen.Animated = True
			Me.SaveScreen.AutoRoundedCorners = True
			Me.SaveScreen.BackColor = Global.System.Drawing.Color.Transparent
			Me.SaveScreen.CheckedState.BorderColor = Global.System.Drawing.Color.FromArgb(82, 43, 235)
			Me.SaveScreen.CheckedState.FillColor = Global.System.Drawing.Color.FromArgb(82, 43, 235)
			Me.SaveScreen.CheckedState.InnerBorderColor = Global.System.Drawing.Color.White
			Me.SaveScreen.CheckedState.InnerColor = Global.System.Drawing.Color.White
			Me.SaveScreen.CheckedState.Parent = Me.SaveScreen
			Me.SaveScreen.Enabled = False
			Me.SaveScreen.Location = New Global.System.Drawing.Point(12, 389)
			Me.SaveScreen.Name = "SaveScreen"
			Me.SaveScreen.ShadowDecoration.Parent = Me.SaveScreen
			Me.SaveScreen.Size = New Global.System.Drawing.Size(41, 20)
			Me.SaveScreen.TabIndex = 572
			Me.SaveScreen.UncheckedState.BorderColor = Global.System.Drawing.Color.Red
			Me.SaveScreen.UncheckedState.FillColor = Global.System.Drawing.Color.FromArgb(66, 69, 91)
			Me.SaveScreen.UncheckedState.InnerBorderColor = Global.System.Drawing.Color.White
			Me.SaveScreen.UncheckedState.InnerColor = Global.System.Drawing.Color.White
			Me.SaveScreen.UncheckedState.Parent = Me.SaveScreen
			Me.Label2.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.Label2.AutoSize = True
			Me.Label2.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label2.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Label2.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.Label2.Location = New Global.System.Drawing.Point(59, 392)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(33, 14)
			Me.Label2.TabIndex = 573
			Me.Label2.Text = "Save"
			Me.comboBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.comboBox1.DataSource = Nothing
			Me.comboBox1.DropDownWidth = 500
			Me.comboBox1.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.comboBox1.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.comboBox1.FillDisableColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.comboBox1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.comboBox1.ForeColor = Global.System.Drawing.Color.White
			Me.comboBox1.Location = New Global.System.Drawing.Point(12, 343)
			Me.comboBox1.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.comboBox1.MinimumSize = New Global.System.Drawing.Size(63, 0)
			Me.comboBox1.Name = "comboBox1"
			Me.comboBox1.Padding = New Global.System.Windows.Forms.Padding(0, 0, 30, 2)
			Me.comboBox1.Radius = 15
			Me.comboBox1.RectColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.comboBox1.Size = New Global.System.Drawing.Size(481, 31)
			Me.comboBox1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.comboBox1.TabIndex = 578
			Me.comboBox1.TextAlignment = Global.System.Drawing.ContentAlignment.MiddleLeft
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
			Me.Quality.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Quality.BackColor = Global.System.Drawing.Color.Transparent
			Me.Quality.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Quality.ForeColor = Global.System.Drawing.Color.White
			Me.Quality.Location = New Global.System.Drawing.Point(427, 314)
			Me.Quality.Name = "Quality"
			Me.Quality.Size = New Global.System.Drawing.Size(64, 16)
			Me.Quality.TabIndex = 579
			Me.Quality.Text = "40% Quality"
			Me.QualityUsing.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.QualityUsing.Enabled = False
			Me.QualityUsing.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.QualityUsing.HoverState.Parent = Me.QualityUsing
			Me.QualityUsing.IndicateFocus = False
			Me.QualityUsing.Location = New Global.System.Drawing.Point(12, 307)
			Me.QualityUsing.Name = "QualityUsing"
			Me.QualityUsing.Size = New Global.System.Drawing.Size(406, 31)
			Me.QualityUsing.TabIndex = 580
			Me.QualityUsing.ThumbColor = Global.System.Drawing.Color.FromArgb(173, 178, 181)
			Me.ImageSaved.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.ImageSaved.AutoSize = True
			Me.ImageSaved.BackColor = Global.System.Drawing.Color.Transparent
			Me.ImageSaved.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ImageSaved.ForeColor = Global.System.Drawing.Color.Red
			Me.ImageSaved.Location = New Global.System.Drawing.Point(98, 393)
			Me.ImageSaved.Name = "ImageSaved"
			Me.ImageSaved.Size = New Global.System.Drawing.Size(13, 14)
			Me.ImageSaved.TabIndex = 582
			Me.ImageSaved.Text = "0"
			Me.SizeImage.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.SizeImage.AutoSize = True
			Me.SizeImage.BackColor = Global.System.Drawing.Color.Transparent
			Me.SizeImage.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.SizeImage.ForeColor = Global.System.Drawing.Color.White
			Me.SizeImage.Location = New Global.System.Drawing.Point(184, 393)
			Me.SizeImage.Name = "SizeImage"
			Me.SizeImage.Size = New Global.System.Drawing.Size(13, 14)
			Me.SizeImage.TabIndex = 586
			Me.SizeImage.Text = "0"
			Me.Label6.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.Label6.AutoSize = True
			Me.Label6.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label6.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Label6.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.Label6.Location = New Global.System.Drawing.Point(147, 393)
			Me.Label6.Name = "Label6"
			Me.Label6.Size = New Global.System.Drawing.Size(39, 14)
			Me.Label6.TabIndex = 585
			Me.Label6.Text = "Size : "
			Me.Mini.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Mini.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Mini.Location = New Global.System.Drawing.Point(425, 11)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 577
			Me.Mini.Text = "ValleyMini1"
			Me.MAX.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.MAX.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.MAX.Enabled = False
			Me.MAX.Location = New Global.System.Drawing.Point(451, 11)
			Me.MAX.Name = "MAX"
			Me.MAX.Size = New Global.System.Drawing.Size(20, 20)
			Me.MAX.TabIndex = 576
			Me.MAX.Text = "ValleyMax1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(477, 11)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 575
			Me.ExitForm.Text = "ValleyClose1"
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(96F, 96F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Dpi
			Me.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			MyBase.ClientSize = New Global.System.Drawing.Size(510, 456)
			MyBase.Controls.Add(Me.SizeImage)
			MyBase.Controls.Add(Me.Label6)
			MyBase.Controls.Add(Me.ImageSaved)
			MyBase.Controls.Add(Me.Quality)
			MyBase.Controls.Add(Me.QualityUsing)
			MyBase.Controls.Add(Me.SaveScreen)
			MyBase.Controls.Add(Me.Label2)
			MyBase.Controls.Add(Me.comboBox1)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.MAX)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.StartAndStop)
			MyBase.Controls.Add(Me.TextFPS)
			MyBase.Controls.Add(Me.Label10)
			MyBase.Controls.Add(Me.Guna2ResizeBox1)
			MyBase.Controls.Add(Me.pictureBox1)
			MyBase.Controls.Add(Me.UiLabel1)
			MyBase.Controls.Add(Me.ClientInfo)
			Me.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "FormCamera"
			Me.Text = "FormCamera"
			MyBase.TopMost = True
			CType(Me.pictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x04000066 RID: 102
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
