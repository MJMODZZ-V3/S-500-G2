Namespace S500RAT
	' Token: 0x02000014 RID: 20
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormClipboard
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000181 RID: 385 RVA: 0x0000C468 File Offset: 0x0000A668
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

		' Token: 0x06000182 RID: 386 RVA: 0x0000C4B8 File Offset: 0x0000A6B8
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormClipboard))
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.UiLabel1 = New Global.Sunny.UI.UILabel()
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.T1 = New Global.Sunny.UI.UIRichTextBox()
			Me.T1_ContextMenuStrip = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.RefreshToolStripMenuItem2 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.PasteToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CleanToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.Guna2ResizeBox1 = New Global.Guna.UI2.WinForms.Guna2ResizeBox()
			Me.Paste = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.Copy = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.Clean = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.MAX = New Global.S500RAT.ValleyMax()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			Me.T1_ContextMenuStrip.SuspendLayout()
			MyBase.SuspendLayout()
			Me.Timer1.Interval = 2000
			Me.UiLabel1.AutoSize = True
			Me.UiLabel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel1.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel1.Location = New Global.System.Drawing.Point(19, 11)
			Me.UiLabel1.Name = "UiLabel1"
			Me.UiLabel1.Size = New Global.System.Drawing.Size(76, 19)
			Me.UiLabel1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLabel1.TabIndex = 334
			Me.UiLabel1.Text = "Clipboard"
			Me.UiLabel1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(20, 35)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(200, 16)
			Me.ClientInfo.TabIndex = 335
			Me.ClientInfo.Text = "FC / Desktop_3424 / Windows 10 pro"
			Me.T1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.T1.AutoWordSelection = True
			Me.T1.BackColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.T1.ContextMenuStrip = Me.T1_ContextMenuStrip
			Me.T1.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.T1.FillColor2 = Global.System.Drawing.SystemColors.WindowFrame
			Me.T1.FillDisableColor = Global.System.Drawing.Color.Red
			Me.T1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.T1.ForeColor = Global.System.Drawing.Color.White
			Me.T1.ForeDisableColor = Global.System.Drawing.Color.Blue
			Me.T1.Location = New Global.System.Drawing.Point(12, 133)
			Me.T1.Margin = New Global.System.Windows.Forms.Padding(3, 5, 3, 5)
			Me.T1.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.T1.Name = "T1"
			Me.T1.Padding = New Global.System.Windows.Forms.Padding(2)
			Me.T1.Radius = 8
			Me.T1.RectColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.T1.Size = New Global.System.Drawing.Size(505, 188)
			Me.T1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.T1.TabIndex = 514
			Me.T1.TextAlignment = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.T1.WordWrap = False
			Me.T1_ContextMenuStrip.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.RefreshToolStripMenuItem2, Me.PasteToolStripMenuItem, Me.CleanToolStripMenuItem })
			Me.T1_ContextMenuStrip.Name = "lst_ContextMenuStrip"
			Me.T1_ContextMenuStrip.Size = New Global.System.Drawing.Size(105, 70)
			Me.RefreshToolStripMenuItem2.Name = "RefreshToolStripMenuItem2"
			Me.RefreshToolStripMenuItem2.Size = New Global.System.Drawing.Size(104, 22)
			Me.RefreshToolStripMenuItem2.Text = "Copy"
			Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
			Me.PasteToolStripMenuItem.Size = New Global.System.Drawing.Size(104, 22)
			Me.PasteToolStripMenuItem.Text = "Paste"
			Me.CleanToolStripMenuItem.Name = "CleanToolStripMenuItem"
			Me.CleanToolStripMenuItem.Size = New Global.System.Drawing.Size(104, 22)
			Me.CleanToolStripMenuItem.Text = "Clean"
			Me.Guna2ResizeBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Guna2ResizeBox1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Guna2ResizeBox1.FillColor = Global.System.Drawing.Color.Silver
			Me.Guna2ResizeBox1.ForeColor = Global.System.Drawing.Color.Empty
			Me.Guna2ResizeBox1.Location = New Global.System.Drawing.Point(501, 329)
			Me.Guna2ResizeBox1.Name = "Guna2ResizeBox1"
			Me.Guna2ResizeBox1.Size = New Global.System.Drawing.Size(17, 19)
			Me.Guna2ResizeBox1.TabIndex = 517
			Me.Guna2ResizeBox1.TargetControl = Me
			Me.Guna2ResizeBox1.UseTransparentBackground = True
			Me.Paste.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Paste.BackColor = Global.System.Drawing.Color.Transparent
			Me.Paste.BorderRadius = 8
			Me.Paste.CheckedState.Parent = Me.Paste
			Me.Paste.CustomImages.Parent = Me.Paste
			Me.Paste.Enabled = False
			Me.Paste.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.Paste.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.Paste.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Paste.ForeColor = Global.System.Drawing.Color.White
			Me.Paste.HoverState.Parent = Me.Paste
			Me.Paste.Location = New Global.System.Drawing.Point(450, 98)
			Me.Paste.Name = "Paste"
			Me.Paste.ShadowDecoration.Parent = Me.Paste
			Me.Paste.Size = New Global.System.Drawing.Size(68, 27)
			Me.Paste.TabIndex = 540
			Me.Paste.Text = "Paste"
			Me.Copy.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Copy.BackColor = Global.System.Drawing.Color.Transparent
			Me.Copy.BorderRadius = 8
			Me.Copy.CheckedState.Parent = Me.Copy
			Me.Copy.CustomImages.Parent = Me.Copy
			Me.Copy.Enabled = False
			Me.Copy.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.Copy.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.Copy.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Copy.ForeColor = Global.System.Drawing.Color.White
			Me.Copy.HoverState.Parent = Me.Copy
			Me.Copy.Location = New Global.System.Drawing.Point(377, 98)
			Me.Copy.Name = "Copy"
			Me.Copy.ShadowDecoration.Parent = Me.Copy
			Me.Copy.Size = New Global.System.Drawing.Size(68, 27)
			Me.Copy.TabIndex = 541
			Me.Copy.Text = "Copy"
			Me.Clean.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Clean.BackColor = Global.System.Drawing.Color.Transparent
			Me.Clean.BorderRadius = 8
			Me.Clean.CheckedState.Parent = Me.Clean
			Me.Clean.CustomImages.Parent = Me.Clean
			Me.Clean.Enabled = False
			Me.Clean.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.Clean.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.Clean.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Clean.ForeColor = Global.System.Drawing.Color.White
			Me.Clean.HoverState.Parent = Me.Clean
			Me.Clean.Location = New Global.System.Drawing.Point(304, 98)
			Me.Clean.Name = "Clean"
			Me.Clean.ShadowDecoration.Parent = Me.Clean
			Me.Clean.Size = New Global.System.Drawing.Size(68, 27)
			Me.Clean.TabIndex = 542
			Me.Clean.Text = "Clean"
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
			Me.Mini.Location = New Global.System.Drawing.Point(445, 10)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 583
			Me.Mini.Text = "ValleyMini1"
			Me.MAX.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.MAX.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.MAX.Location = New Global.System.Drawing.Point(471, 10)
			Me.MAX.Name = "MAX"
			Me.MAX.Size = New Global.System.Drawing.Size(20, 20)
			Me.MAX.TabIndex = 582
			Me.MAX.Text = "ValleyMax1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(497, 10)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 581
			Me.ExitForm.Text = "ValleyClose1"
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(96F, 96F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Dpi
			Me.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			MyBase.ClientSize = New Global.System.Drawing.Size(529, 359)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.MAX)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.Clean)
			MyBase.Controls.Add(Me.Copy)
			MyBase.Controls.Add(Me.Paste)
			MyBase.Controls.Add(Me.Guna2ResizeBox1)
			MyBase.Controls.Add(Me.T1)
			MyBase.Controls.Add(Me.UiLabel1)
			MyBase.Controls.Add(Me.ClientInfo)
			Me.DoubleBuffered = True
			Me.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "FormClipboard"
			Me.Text = "FormCliboard"
			MyBase.TopMost = True
			Me.T1_ContextMenuStrip.ResumeLayout(False)
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x040000AF RID: 175
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
