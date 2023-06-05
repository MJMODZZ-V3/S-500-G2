Namespace S500RAT
	' Token: 0x0200001C RID: 28
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormHBrowser
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060003D7 RID: 983 RVA: 0x00021564 File Offset: 0x0001F764
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

		' Token: 0x060003D8 RID: 984 RVA: 0x000215B4 File Offset: 0x0001F7B4
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormHBrowser))
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.FPS = New Global.System.Windows.Forms.Label()
			Me.UiLabel1 = New Global.Sunny.UI.UILabel()
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.StateHApp = New Global.System.Windows.Forms.Label()
			Me.Guna2ResizeBox2 = New Global.Guna.UI2.WinForms.Guna2ResizeBox()
			Me.PLW = New Global.Guna.UI2.WinForms.Guna2CircleProgressBar()
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.StartAndStop = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.ComboBox1 = New Global.Sunny.UI.UIComboBox()
			Me.Quality = New Global.Guna.UI2.WinForms.Guna2HtmlLabel()
			Me.QualityUsing = New Global.Guna.UI2.WinForms.Guna2TrackBar()
			Me.SizeImage = New Global.System.Windows.Forms.Label()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.MAX = New Global.S500RAT.ValleyMax()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.Timer1.Interval = 2000
			Me.Label2.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.Label2.AutoSize = True
			Me.Label2.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label2.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Label2.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 155)
			Me.Label2.Location = New Global.System.Drawing.Point(167, 482)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(33, 14)
			Me.Label2.TabIndex = 562
			Me.Label2.Text = "FPS :"
			Me.FPS.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.FPS.AutoSize = True
			Me.FPS.BackColor = Global.System.Drawing.Color.Transparent
			Me.FPS.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.FPS.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.FPS.ForeColor = Global.System.Drawing.SystemColors.Window
			Me.FPS.Location = New Global.System.Drawing.Point(206, 482)
			Me.FPS.Name = "FPS"
			Me.FPS.Size = New Global.System.Drawing.Size(13, 14)
			Me.FPS.TabIndex = 563
			Me.FPS.Text = "0"
			Me.UiLabel1.AutoSize = True
			Me.UiLabel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel1.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel1.Location = New Global.System.Drawing.Point(18, 11)
			Me.UiLabel1.Name = "UiLabel1"
			Me.UiLabel1.Size = New Global.System.Drawing.Size(117, 19)
			Me.UiLabel1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLabel1.TabIndex = 560
			Me.UiLabel1.Text = "Hidden Browser"
			Me.UiLabel1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(19, 35)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(15, 14)
			Me.ClientInfo.TabIndex = 561
			Me.ClientInfo.Text = "--"
			Me.Label1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.Label1.AutoSize = True
			Me.Label1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Label1.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 155)
			Me.Label1.Location = New Global.System.Drawing.Point(12, 529)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(41, 14)
			Me.Label1.TabIndex = 565
			Me.Label1.Text = "State :"
			Me.StateHApp.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.StateHApp.AutoSize = True
			Me.StateHApp.BackColor = Global.System.Drawing.Color.Transparent
			Me.StateHApp.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.StateHApp.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.StateHApp.ForeColor = Global.System.Drawing.SystemColors.Window
			Me.StateHApp.Location = New Global.System.Drawing.Point(59, 529)
			Me.StateHApp.Name = "StateHApp"
			Me.StateHApp.Size = New Global.System.Drawing.Size(16, 14)
			Me.StateHApp.TabIndex = 566
			Me.StateHApp.Text = "..."
			Me.Guna2ResizeBox2.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Guna2ResizeBox2.BackColor = Global.System.Drawing.Color.Transparent
			Me.Guna2ResizeBox2.FillColor = Global.System.Drawing.Color.Silver
			Me.Guna2ResizeBox2.ForeColor = Global.System.Drawing.Color.Empty
			Me.Guna2ResizeBox2.Location = New Global.System.Drawing.Point(590, 524)
			Me.Guna2ResizeBox2.Name = "Guna2ResizeBox2"
			Me.Guna2ResizeBox2.Size = New Global.System.Drawing.Size(17, 19)
			Me.Guna2ResizeBox2.TabIndex = 564
			Me.Guna2ResizeBox2.TargetControl = Me
			Me.Guna2ResizeBox2.UseTransparentBackground = True
			Me.PLW.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.PLW.AnimationSpeed = 2F
			Me.PLW.BackColor = Global.System.Drawing.Color.Transparent
			Me.PLW.FillColor = Global.System.Drawing.Color.Transparent
			Me.PLW.FillThickness = 10
			Me.PLW.ImageSize = New Global.System.Drawing.Size(38, 38)
			Me.PLW.Location = New Global.System.Drawing.Point(13, 462)
			Me.PLW.Name = "PLW"
			Me.PLW.ProgressBrushMode = Global.Guna.UI2.WinForms.Enums.BrushMode.Solid
			Me.PLW.ProgressColor = Global.System.Drawing.Color.FromArgb(192, 64, 0)
			Me.PLW.ProgressColor2 = Global.System.Drawing.Color.FromArgb(255, 128, 0)
			Me.PLW.ProgressEndCap = Global.System.Drawing.Drawing2D.LineCap.Custom
			Me.PLW.ProgressStartCap = Global.System.Drawing.Drawing2D.LineCap.AnchorMask
			Me.PLW.ProgressThickness = 5
			Me.PLW.ShadowDecoration.Mode = Global.Guna.UI2.WinForms.Enums.ShadowMode.Circle
			Me.PLW.ShadowDecoration.Parent = Me.PLW
			Me.PLW.Size = New Global.System.Drawing.Size(50, 50)
			Me.PLW.TabIndex = 571
			Me.PictureBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.PictureBox1.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.PictureBox1.Location = New Global.System.Drawing.Point(15, 72)
			Me.PictureBox1.Name = "PictureBox1"
			Me.PictureBox1.Size = New Global.System.Drawing.Size(592, 304)
			Me.PictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox1.TabIndex = 545
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
			Me.StartAndStop.Location = New Global.System.Drawing.Point(491, 483)
			Me.StartAndStop.Name = "StartAndStop"
			Me.StartAndStop.ShadowDecoration.Color = Global.System.Drawing.Color.White
			Me.StartAndStop.ShadowDecoration.Parent = Me.StartAndStop
			Me.StartAndStop.Size = New Global.System.Drawing.Size(116, 29)
			Me.StartAndStop.TabIndex = 543
			Me.StartAndStop.Tag = "Start"
			Me.StartAndStop.Text = "Start"
			Me.ComboBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.ComboBox1.DataSource = Nothing
			Me.ComboBox1.DropDownStyle = Global.Sunny.UI.UIDropDownStyle.DropDownList
			Me.ComboBox1.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ComboBox1.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ComboBox1.FillDisableColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ComboBox1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ComboBox1.ForeColor = Global.System.Drawing.Color.White
			Me.ComboBox1.ForeDisableColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ComboBox1.Items.AddRange(New Object() { "Browser Chrome", "Browser Firefox", "Browser Edge", "Browser Brave" })
			Me.ComboBox1.Location = New Global.System.Drawing.Point(13, 421)
			Me.ComboBox1.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.ComboBox1.MinimumSize = New Global.System.Drawing.Size(63, 0)
			Me.ComboBox1.Name = "ComboBox1"
			Me.ComboBox1.Padding = New Global.System.Windows.Forms.Padding(0, 0, 30, 2)
			Me.ComboBox1.Radius = 15
			Me.ComboBox1.RectColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ComboBox1.RectDisableColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ComboBox1.Size = New Global.System.Drawing.Size(223, 31)
			Me.ComboBox1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.ComboBox1.TabIndex = 579
			Me.ComboBox1.TextAlignment = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Quality.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Quality.BackColor = Global.System.Drawing.Color.Transparent
			Me.Quality.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Quality.ForeColor = Global.System.Drawing.Color.White
			Me.Quality.Location = New Global.System.Drawing.Point(542, 388)
			Me.Quality.Name = "Quality"
			Me.Quality.Size = New Global.System.Drawing.Size(64, 16)
			Me.Quality.TabIndex = 581
			Me.Quality.Text = "80% Quality"
			Me.QualityUsing.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.QualityUsing.Enabled = False
			Me.QualityUsing.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.QualityUsing.HoverState.Parent = Me.QualityUsing
			Me.QualityUsing.IndicateFocus = False
			Me.QualityUsing.Location = New Global.System.Drawing.Point(13, 382)
			Me.QualityUsing.Name = "QualityUsing"
			Me.QualityUsing.Size = New Global.System.Drawing.Size(523, 31)
			Me.QualityUsing.TabIndex = 582
			Me.QualityUsing.ThumbColor = Global.System.Drawing.Color.FromArgb(173, 178, 181)
			Me.QualityUsing.Value = 80
			Me.SizeImage.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.SizeImage.AutoSize = True
			Me.SizeImage.BackColor = Global.System.Drawing.Color.Transparent
			Me.SizeImage.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.SizeImage.ForeColor = Global.System.Drawing.Color.White
			Me.SizeImage.Location = New Global.System.Drawing.Point(121, 482)
			Me.SizeImage.Name = "SizeImage"
			Me.SizeImage.Size = New Global.System.Drawing.Size(13, 14)
			Me.SizeImage.TabIndex = 588
			Me.SizeImage.Text = "0"
			Me.Label6.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.Label6.AutoSize = True
			Me.Label6.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label6.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Label6.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.Label6.Location = New Global.System.Drawing.Point(76, 482)
			Me.Label6.Name = "Label6"
			Me.Label6.Size = New Global.System.Drawing.Size(39, 14)
			Me.Label6.TabIndex = 587
			Me.Label6.Text = "Size : "
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
			Me.Mini.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Mini.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Mini.Location = New Global.System.Drawing.Point(534, 10)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 591
			Me.Mini.Text = "ValleyMini1"
			Me.MAX.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.MAX.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.MAX.Location = New Global.System.Drawing.Point(560, 10)
			Me.MAX.Name = "MAX"
			Me.MAX.Size = New Global.System.Drawing.Size(20, 20)
			Me.MAX.TabIndex = 590
			Me.MAX.Text = "ValleyMax1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(586, 10)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 589
			Me.ExitForm.Text = "ValleyClose1"
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(96F, 96F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Dpi
			Me.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			MyBase.ClientSize = New Global.System.Drawing.Size(618, 554)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.MAX)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.SizeImage)
			MyBase.Controls.Add(Me.Label6)
			MyBase.Controls.Add(Me.Quality)
			MyBase.Controls.Add(Me.QualityUsing)
			MyBase.Controls.Add(Me.PictureBox1)
			MyBase.Controls.Add(Me.PLW)
			MyBase.Controls.Add(Me.ComboBox1)
			MyBase.Controls.Add(Me.StartAndStop)
			MyBase.Controls.Add(Me.Label1)
			MyBase.Controls.Add(Me.StateHApp)
			MyBase.Controls.Add(Me.Guna2ResizeBox2)
			MyBase.Controls.Add(Me.Label2)
			MyBase.Controls.Add(Me.FPS)
			MyBase.Controls.Add(Me.UiLabel1)
			MyBase.Controls.Add(Me.ClientInfo)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "FormHBrowser"
			Me.Text = "FormHBrowser"
			MyBase.TopMost = True
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x040001B8 RID: 440
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
