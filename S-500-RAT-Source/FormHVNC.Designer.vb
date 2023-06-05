Namespace S500RAT
	' Token: 0x0200001F RID: 31
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormHVNC
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000517 RID: 1303 RVA: 0x0002C558 File Offset: 0x0002A758
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

		' Token: 0x06000518 RID: 1304 RVA: 0x0002C5A8 File Offset: 0x0002A7A8
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormHVNC))
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.UiLabel1 = New Global.Sunny.UI.UILabel()
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.Guna2ResizeBox1 = New Global.Guna.UI2.WinForms.Guna2ResizeBox()
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.StartAndStop = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.MenuStrip1 = New Global.System.Windows.Forms.MenuStrip()
			Me.SetingToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.Conx = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.ToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ToolStripMenuItem3 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ToolStripMenuItem5 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ToolStripMenuItem6 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ToolStripMenuItem7 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ToolStripMenuItem8 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ToolStripMenuItem9 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ToolStripMenuItem10 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ToolStripMenuItem13 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CopyText = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.PasteText = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.StateHvnc = New Global.System.Windows.Forms.Label()
			Me.Timer2 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.ImageList1 = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.Quality = New Global.Guna.UI2.WinForms.Guna2HtmlLabel()
			Me.QualityUsing = New Global.Guna.UI2.WinForms.Guna2TrackBar()
			Me.SizeImage = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.FPS = New Global.System.Windows.Forms.Label()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.MAX = New Global.S500RAT.ValleyMax()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.MenuStrip1.SuspendLayout()
			Me.Conx.SuspendLayout()
			MyBase.SuspendLayout()
			Me.Timer1.Interval = 2000
			Me.UiLabel1.AutoSize = True
			Me.UiLabel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel1.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel1.Location = New Global.System.Drawing.Point(10, 10)
			Me.UiLabel1.Name = "UiLabel1"
			Me.UiLabel1.Size = New Global.System.Drawing.Size(105, 19)
			Me.UiLabel1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLabel1.TabIndex = 529
			Me.UiLabel1.Text = "Remote HVNC"
			Me.UiLabel1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(11, 34)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(18, 16)
			Me.ClientInfo.TabIndex = 530
			Me.ClientInfo.Text = "--"
			Me.Guna2ResizeBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Guna2ResizeBox1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Guna2ResizeBox1.FillColor = Global.System.Drawing.Color.Silver
			Me.Guna2ResizeBox1.ForeColor = Global.System.Drawing.Color.Empty
			Me.Guna2ResizeBox1.Location = New Global.System.Drawing.Point(558, 454)
			Me.Guna2ResizeBox1.Name = "Guna2ResizeBox1"
			Me.Guna2ResizeBox1.Size = New Global.System.Drawing.Size(17, 19)
			Me.Guna2ResizeBox1.TabIndex = 531
			Me.Guna2ResizeBox1.TargetControl = Me
			Me.Guna2ResizeBox1.UseTransparentBackground = True
			Me.PictureBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.PictureBox1.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.PictureBox1.ErrorImage = Global.S500RAT.My.Resources.Resources.XXXX
			Me.PictureBox1.Location = New Global.System.Drawing.Point(14, 72)
			Me.PictureBox1.Name = "PictureBox1"
			Me.PictureBox1.Size = New Global.System.Drawing.Size(555, 300)
			Me.PictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox1.TabIndex = 544
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
			Me.StartAndStop.Location = New Global.System.Drawing.Point(458, 422)
			Me.StartAndStop.Name = "StartAndStop"
			Me.StartAndStop.ShadowDecoration.Color = Global.System.Drawing.Color.White
			Me.StartAndStop.ShadowDecoration.Parent = Me.StartAndStop
			Me.StartAndStop.Size = New Global.System.Drawing.Size(111, 29)
			Me.StartAndStop.TabIndex = 543
			Me.StartAndStop.Tag = "Start"
			Me.StartAndStop.Text = "Start"
			Me.MenuStrip1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.MenuStrip1.BackColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.MenuStrip1.Dock = Global.System.Windows.Forms.DockStyle.None
			Me.MenuStrip1.Font = New Global.System.Drawing.Font("Segoe UI", 14.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.MenuStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.SetingToolStripMenuItem })
			Me.MenuStrip1.Location = New Global.System.Drawing.Point(14, 417)
			Me.MenuStrip1.Name = "MenuStrip1"
			Me.MenuStrip1.Padding = New Global.System.Windows.Forms.Padding(5, 2, 0, 2)
			Me.MenuStrip1.RenderMode = Global.System.Windows.Forms.ToolStripRenderMode.Professional
			Me.MenuStrip1.Size = New Global.System.Drawing.Size(55, 24)
			Me.MenuStrip1.TabIndex = 540
			Me.MenuStrip1.Text = "MenuStrip1"
			Me.SetingToolStripMenuItem.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.SetingToolStripMenuItem.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.SetingToolStripMenuItem.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
			Me.SetingToolStripMenuItem.Name = "SetingToolStripMenuItem"
			Me.SetingToolStripMenuItem.Size = New Global.System.Drawing.Size(48, 20)
			Me.SetingToolStripMenuItem.Text = "Open"
			Me.Conx.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Conx.ImageScalingSize = New Global.System.Drawing.Size(20, 20)
			Me.Conx.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.ToolStripMenuItem1, Me.ToolStripMenuItem13 })
			Me.Conx.Name = "ContextMenuStrip1"
			Me.Conx.Size = New Global.System.Drawing.Size(132, 56)
			Me.ToolStripMenuItem1.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.ToolStripMenuItem1.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.ToolStripMenuItem3, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.ToolStripMenuItem7, Me.ToolStripMenuItem8, Me.ToolStripMenuItem9, Me.ToolStripMenuItem10 })
			Me.ToolStripMenuItem1.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.ToolStripMenuItem1.Image = CType(componentResourceManager.GetObject("ToolStripMenuItem1.Image"), Global.System.Drawing.Image)
			Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
			Me.ToolStripMenuItem1.Size = New Global.System.Drawing.Size(131, 26)
			Me.ToolStripMenuItem1.Text = "Open"
			Me.ToolStripMenuItem3.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.ToolStripMenuItem3.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.ToolStripMenuItem3.Image = CType(componentResourceManager.GetObject("ToolStripMenuItem3.Image"), Global.System.Drawing.Image)
			Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
			Me.ToolStripMenuItem3.Size = New Global.System.Drawing.Size(212, 26)
			Me.ToolStripMenuItem3.Text = "Microsoft Edge Browser"
			Me.ToolStripMenuItem5.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.ToolStripMenuItem5.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.ToolStripMenuItem5.Image = CType(componentResourceManager.GetObject("ToolStripMenuItem5.Image"), Global.System.Drawing.Image)
			Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
			Me.ToolStripMenuItem5.Size = New Global.System.Drawing.Size(212, 26)
			Me.ToolStripMenuItem5.Text = "Chrome Browser"
			Me.ToolStripMenuItem6.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.ToolStripMenuItem6.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.ToolStripMenuItem6.Image = CType(componentResourceManager.GetObject("ToolStripMenuItem6.Image"), Global.System.Drawing.Image)
			Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
			Me.ToolStripMenuItem6.Size = New Global.System.Drawing.Size(212, 26)
			Me.ToolStripMenuItem6.Text = "FireFox Browser"
			Me.ToolStripMenuItem7.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.ToolStripMenuItem7.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.ToolStripMenuItem7.Image = CType(componentResourceManager.GetObject("ToolStripMenuItem7.Image"), Global.System.Drawing.Image)
			Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
			Me.ToolStripMenuItem7.Size = New Global.System.Drawing.Size(212, 26)
			Me.ToolStripMenuItem7.Text = "Brave Browser"
			Me.ToolStripMenuItem8.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.ToolStripMenuItem8.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.ToolStripMenuItem8.Image = CType(componentResourceManager.GetObject("ToolStripMenuItem8.Image"), Global.System.Drawing.Image)
			Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
			Me.ToolStripMenuItem8.Size = New Global.System.Drawing.Size(212, 26)
			Me.ToolStripMenuItem8.Text = "Command Prompt"
			Me.ToolStripMenuItem9.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.ToolStripMenuItem9.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.ToolStripMenuItem9.Image = CType(componentResourceManager.GetObject("ToolStripMenuItem9.Image"), Global.System.Drawing.Image)
			Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
			Me.ToolStripMenuItem9.Size = New Global.System.Drawing.Size(212, 26)
			Me.ToolStripMenuItem9.Text = "PowerShell"
			Me.ToolStripMenuItem10.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.ToolStripMenuItem10.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.ToolStripMenuItem10.Image = CType(componentResourceManager.GetObject("ToolStripMenuItem10.Image"), Global.System.Drawing.Image)
			Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
			Me.ToolStripMenuItem10.Size = New Global.System.Drawing.Size(212, 26)
			Me.ToolStripMenuItem10.Text = "Custom Open"
			Me.ToolStripMenuItem13.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.ToolStripMenuItem13.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.CopyText, Me.PasteText })
			Me.ToolStripMenuItem13.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.ToolStripMenuItem13.Image = CType(componentResourceManager.GetObject("ToolStripMenuItem13.Image"), Global.System.Drawing.Image)
			Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
			Me.ToolStripMenuItem13.Size = New Global.System.Drawing.Size(131, 26)
			Me.ToolStripMenuItem13.Text = "Clipboard"
			Me.CopyText.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.CopyText.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.CopyText.Image = CType(componentResourceManager.GetObject("CopyText.Image"), Global.System.Drawing.Image)
			Me.CopyText.Name = "CopyText"
			Me.CopyText.Size = New Global.System.Drawing.Size(109, 26)
			Me.CopyText.Text = "Copy"
			Me.PasteText.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.PasteText.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.PasteText.Image = CType(componentResourceManager.GetObject("PasteText.Image"), Global.System.Drawing.Image)
			Me.PasteText.Name = "PasteText"
			Me.PasteText.Size = New Global.System.Drawing.Size(109, 26)
			Me.PasteText.Text = "Paste"
			Me.StateHvnc.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.StateHvnc.AutoSize = True
			Me.StateHvnc.BackColor = Global.System.Drawing.Color.Transparent
			Me.StateHvnc.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.StateHvnc.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.StateHvnc.ForeColor = Global.System.Drawing.Color.Silver
			Me.StateHvnc.Location = New Global.System.Drawing.Point(29, 454)
			Me.StateHvnc.Name = "StateHvnc"
			Me.StateHvnc.Size = New Global.System.Drawing.Size(0, 14)
			Me.StateHvnc.TabIndex = 543
			Me.Timer2.Enabled = True
			Me.ImageList1.ImageStream = CType(componentResourceManager.GetObject("ImageList1.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.ImageList1.TransparentColor = Global.System.Drawing.Color.Transparent
			Me.ImageList1.Images.SetKeyName(0, "GoogleChrome.png")
			Me.Quality.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Quality.BackColor = Global.System.Drawing.Color.Transparent
			Me.Quality.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Quality.ForeColor = Global.System.Drawing.Color.White
			Me.Quality.Location = New Global.System.Drawing.Point(499, 385)
			Me.Quality.Name = "Quality"
			Me.Quality.Size = New Global.System.Drawing.Size(64, 16)
			Me.Quality.TabIndex = 581
			Me.Quality.Text = "80% Quality"
			Me.QualityUsing.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.QualityUsing.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.QualityUsing.HoverState.Parent = Me.QualityUsing
			Me.QualityUsing.IndicateFocus = False
			Me.QualityUsing.Location = New Global.System.Drawing.Point(14, 378)
			Me.QualityUsing.Name = "QualityUsing"
			Me.QualityUsing.Size = New Global.System.Drawing.Size(475, 31)
			Me.QualityUsing.TabIndex = 582
			Me.QualityUsing.ThumbColor = Global.System.Drawing.Color.FromArgb(173, 178, 181)
			Me.QualityUsing.Value = 80
			Me.SizeImage.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.SizeImage.AutoSize = True
			Me.SizeImage.BackColor = Global.System.Drawing.Color.Transparent
			Me.SizeImage.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.SizeImage.ForeColor = Global.System.Drawing.Color.White
			Me.SizeImage.Location = New Global.System.Drawing.Point(119, 422)
			Me.SizeImage.Name = "SizeImage"
			Me.SizeImage.Size = New Global.System.Drawing.Size(13, 14)
			Me.SizeImage.TabIndex = 590
			Me.SizeImage.Text = "0"
			Me.Label2.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.Label2.AutoSize = True
			Me.Label2.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label2.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Label2.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.Label2.Location = New Global.System.Drawing.Point(82, 422)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(39, 14)
			Me.Label2.TabIndex = 589
			Me.Label2.Text = "Size : "
			Me.FPS.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.FPS.AutoSize = True
			Me.FPS.BackColor = Global.System.Drawing.Color.Transparent
			Me.FPS.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.FPS.ForeColor = Global.System.Drawing.Color.White
			Me.FPS.Location = New Global.System.Drawing.Point(217, 422)
			Me.FPS.Name = "FPS"
			Me.FPS.Size = New Global.System.Drawing.Size(13, 14)
			Me.FPS.TabIndex = 588
			Me.FPS.Text = "0"
			Me.Label4.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.Label4.AutoSize = True
			Me.Label4.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label4.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Label4.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.Label4.Location = New Global.System.Drawing.Point(180, 422)
			Me.Label4.Name = "Label4"
			Me.Label4.Size = New Global.System.Drawing.Size(36, 14)
			Me.Label4.TabIndex = 587
			Me.Label4.Text = "FPS : "
			Me.Mini.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Mini.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Mini.Location = New Global.System.Drawing.Point(497, 9)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 593
			Me.Mini.Text = "ValleyMini1"
			Me.MAX.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.MAX.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.MAX.Location = New Global.System.Drawing.Point(523, 9)
			Me.MAX.Name = "MAX"
			Me.MAX.Size = New Global.System.Drawing.Size(20, 20)
			Me.MAX.TabIndex = 592
			Me.MAX.Text = "ValleyMax1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(549, 9)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 591
			Me.ExitForm.Text = "ValleyClose1"
			Me.Guna2DragControl1.ContainerControl = Me
			Me.Guna2DragControl1.DockForm = True
			Me.Guna2DragControl1.DockIndicatorColor = Global.System.Drawing.Color.FromArgb(56, 37, 200)
			Me.Guna2DragControl1.DragMode = Global.Guna.UI2.WinForms.Enums.DragMode.Control
			Me.Guna2DragControl1.DragStartTransparencyValue = 0.6
			Me.Guna2DragControl1.TransparentWhileDrag = True
			Me.Guna2DragControl1.UseTransparentDrag = True
			Me.Guna2BorderlessForm1.AnimateWindow = True
			Me.Guna2BorderlessForm1.BorderRadius = 30
			Me.Guna2BorderlessForm1.ContainerControl = Me
			Me.Guna2BorderlessForm1.DockIndicatorColor = Global.System.Drawing.Color.FromArgb(56, 37, 200)
			Me.Guna2BorderlessForm1.DragStartTransparencyValue = 0.6
			Me.Guna2BorderlessForm1.ShadowColor = Global.System.Drawing.Color.FromArgb(56, 37, 200)
			Me.Guna2BorderlessForm1.TransparentWhileDrag = True
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			MyBase.ClientSize = New Global.System.Drawing.Size(585, 482)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.MAX)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.SizeImage)
			MyBase.Controls.Add(Me.Label2)
			MyBase.Controls.Add(Me.FPS)
			MyBase.Controls.Add(Me.Label4)
			MyBase.Controls.Add(Me.Quality)
			MyBase.Controls.Add(Me.QualityUsing)
			MyBase.Controls.Add(Me.StartAndStop)
			MyBase.Controls.Add(Me.PictureBox1)
			MyBase.Controls.Add(Me.MenuStrip1)
			MyBase.Controls.Add(Me.StateHvnc)
			MyBase.Controls.Add(Me.Guna2ResizeBox1)
			MyBase.Controls.Add(Me.UiLabel1)
			MyBase.Controls.Add(Me.ClientInfo)
			Me.DoubleBuffered = True
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.MainMenuStrip = Me.MenuStrip1
			MyBase.Name = "FormHVNC"
			Me.Text = "FormHVNC"
			MyBase.TopMost = True
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.MenuStrip1.ResumeLayout(False)
			Me.MenuStrip1.PerformLayout()
			Me.Conx.ResumeLayout(False)
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0400024B RID: 587
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
