Namespace S500RAT
	' Token: 0x0200003E RID: 62
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class UploadFromLink
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600114C RID: 4428 RVA: 0x000953C4 File Offset: 0x000935C4
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

		' Token: 0x0600114D RID: 4429 RVA: 0x00095414 File Offset: 0x00093614
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.UploadFromLink))
			Me.NameForm = New Global.Sunny.UI.UILabel()
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.TextBoxLink = New Global.Guna.UI2.WinForms.Guna2TextBox()
			Me.UploadFile = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.TextBox1Name = New Global.Guna.UI2.WinForms.Guna2TextBox()
			Me.FileSave = New Global.System.Windows.Forms.Label()
			Me.label3 = New Global.System.Windows.Forms.Label()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Timer2 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			Me.ProgressBar1 = New Global.Guna.UI2.WinForms.Guna2ProgressBar()
			MyBase.SuspendLayout()
			Me.NameForm.AutoSize = True
			Me.NameForm.BackColor = Global.System.Drawing.Color.Transparent
			Me.NameForm.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.NameForm.ForeColor = Global.System.Drawing.Color.White
			Me.NameForm.Location = New Global.System.Drawing.Point(18, 8)
			Me.NameForm.Name = "NameForm"
			Me.NameForm.Size = New Global.System.Drawing.Size(128, 19)
			Me.NameForm.Style = Global.Sunny.UI.UIStyle.Custom
			Me.NameForm.TabIndex = 309
			Me.NameForm.Text = "Upload From Link"
			Me.NameForm.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(19, 32)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(18, 16)
			Me.ClientInfo.TabIndex = 310
			Me.ClientInfo.Text = "--"
			Me.TextBoxLink.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.TextBoxLink.Animated = True
			Me.TextBoxLink.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.TextBoxLink.BorderColor = Global.System.Drawing.Color.FromArgb(82, 43, 235)
			Me.TextBoxLink.BorderRadius = 7
			Me.TextBoxLink.BorderStyle = Global.System.Drawing.Drawing2D.DashStyle.Custom
			Me.TextBoxLink.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.TextBoxLink.DefaultText = ""
			Me.TextBoxLink.DisabledState.BorderColor = Global.System.Drawing.Color.FromArgb(208, 208, 208)
			Me.TextBoxLink.DisabledState.FillColor = Global.System.Drawing.Color.FromArgb(226, 226, 226)
			Me.TextBoxLink.DisabledState.ForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.TextBoxLink.DisabledState.Parent = Me.TextBoxLink
			Me.TextBoxLink.DisabledState.PlaceholderForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.TextBoxLink.FillColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.TextBoxLink.FocusedState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.TextBoxLink.FocusedState.Parent = Me.TextBoxLink
			Me.TextBoxLink.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 9F, Global.System.Drawing.FontStyle.Bold)
			Me.TextBoxLink.ForeColor = Global.System.Drawing.Color.White
			Me.TextBoxLink.HoverState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.TextBoxLink.HoverState.Parent = Me.TextBoxLink
			Me.TextBoxLink.IconLeft = CType(componentResourceManager.GetObject("TextBoxLink.IconLeft"), Global.System.Drawing.Image)
			Me.TextBoxLink.IconLeftCursor = Global.System.Windows.Forms.Cursors.Hand
			Me.TextBoxLink.IconRightCursor = Global.System.Windows.Forms.Cursors.Hand
			Me.TextBoxLink.Location = New Global.System.Drawing.Point(12, 75)
			Me.TextBoxLink.Margin = New Global.System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.TextBoxLink.Name = "TextBoxLink"
			Me.TextBoxLink.PasswordChar = vbNullChar
			Me.TextBoxLink.PlaceholderForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.TextBoxLink.PlaceholderText = "Direct link"
			Me.TextBoxLink.SelectedText = ""
			Me.TextBoxLink.ShadowDecoration.Parent = Me.TextBoxLink
			Me.TextBoxLink.Size = New Global.System.Drawing.Size(514, 29)
			Me.TextBoxLink.Style = Global.Guna.UI2.WinForms.Enums.TextBoxStyle.Material
			Me.TextBoxLink.TabIndex = 458
			Me.UploadFile.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.UploadFile.BackColor = Global.System.Drawing.Color.Transparent
			Me.UploadFile.BorderRadius = 8
			Me.UploadFile.CheckedState.Parent = Me.UploadFile
			Me.UploadFile.CustomImages.Parent = Me.UploadFile
			Me.UploadFile.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.UploadFile.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.UploadFile.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.UploadFile.ForeColor = Global.System.Drawing.Color.White
			Me.UploadFile.HoverState.Parent = Me.UploadFile
			Me.UploadFile.Location = New Global.System.Drawing.Point(563, 145)
			Me.UploadFile.Name = "UploadFile"
			Me.UploadFile.ShadowDecoration.Parent = Me.UploadFile
			Me.UploadFile.Size = New Global.System.Drawing.Size(125, 29)
			Me.UploadFile.TabIndex = 459
			Me.UploadFile.Text = "Upload"
			Me.TextBox1Name.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.TextBox1Name.Animated = True
			Me.TextBox1Name.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.TextBox1Name.BorderColor = Global.System.Drawing.Color.FromArgb(82, 43, 235)
			Me.TextBox1Name.BorderRadius = 7
			Me.TextBox1Name.BorderStyle = Global.System.Drawing.Drawing2D.DashStyle.Custom
			Me.TextBox1Name.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.TextBox1Name.DefaultText = ""
			Me.TextBox1Name.DisabledState.BorderColor = Global.System.Drawing.Color.FromArgb(208, 208, 208)
			Me.TextBox1Name.DisabledState.FillColor = Global.System.Drawing.Color.FromArgb(226, 226, 226)
			Me.TextBox1Name.DisabledState.ForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.TextBox1Name.DisabledState.Parent = Me.TextBox1Name
			Me.TextBox1Name.DisabledState.PlaceholderForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.TextBox1Name.FillColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.TextBox1Name.FocusedState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.TextBox1Name.FocusedState.Parent = Me.TextBox1Name
			Me.TextBox1Name.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 9F, Global.System.Drawing.FontStyle.Bold)
			Me.TextBox1Name.ForeColor = Global.System.Drawing.Color.White
			Me.TextBox1Name.HoverState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.TextBox1Name.HoverState.Parent = Me.TextBox1Name
			Me.TextBox1Name.IconLeft = CType(componentResourceManager.GetObject("TextBox1Name.IconLeft"), Global.System.Drawing.Image)
			Me.TextBox1Name.IconLeftCursor = Global.System.Windows.Forms.Cursors.Hand
			Me.TextBox1Name.IconRightCursor = Global.System.Windows.Forms.Cursors.Hand
			Me.TextBox1Name.Location = New Global.System.Drawing.Point(532, 75)
			Me.TextBox1Name.Margin = New Global.System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.TextBox1Name.Name = "TextBox1Name"
			Me.TextBox1Name.PasswordChar = vbNullChar
			Me.TextBox1Name.PlaceholderForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.TextBox1Name.PlaceholderText = "File.exe"
			Me.TextBox1Name.SelectedText = ""
			Me.TextBox1Name.ShadowDecoration.Parent = Me.TextBox1Name
			Me.TextBox1Name.Size = New Global.System.Drawing.Size(156, 29)
			Me.TextBox1Name.Style = Global.Guna.UI2.WinForms.Enums.TextBoxStyle.Material
			Me.TextBox1Name.TabIndex = 463
			Me.FileSave.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.FileSave.AutoSize = True
			Me.FileSave.ForeColor = Global.System.Drawing.Color.White
			Me.FileSave.Location = New Global.System.Drawing.Point(121, 151)
			Me.FileSave.Margin = New Global.System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.FileSave.Name = "FileSave"
			Me.FileSave.Size = New Global.System.Drawing.Size(13, 13)
			Me.FileSave.TabIndex = 460
			Me.FileSave.Text = ".."
			Me.label3.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.label3.AutoSize = True
			Me.label3.ForeColor = Global.System.Drawing.Color.White
			Me.label3.Location = New Global.System.Drawing.Point(13, 151)
			Me.label3.Margin = New Global.System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.label3.Name = "label3"
			Me.label3.Size = New Global.System.Drawing.Size(104, 13)
			Me.label3.TabIndex = 462
			Me.label3.Text = "File Save  Location :"
			Me.Timer1.Enabled = True
			Me.Timer1.Interval = 1000
			Me.Timer2.Enabled = True
			Me.Mini.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Mini.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Mini.Location = New Global.System.Drawing.Point(647, 12)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 562
			Me.Mini.Text = "ValleyMini1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(673, 12)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 560
			Me.ExitForm.Text = "ValleyClose1"
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
			Me.Guna2DragControl1.TargetControl = Me.UploadFile
			Me.Guna2DragControl1.TransparentWhileDrag = True
			Me.Guna2DragControl1.UseTransparentDrag = True
			Me.ProgressBar1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ProgressBar1.BackColor = Global.System.Drawing.Color.Transparent
			Me.ProgressBar1.BorderColor = Global.System.Drawing.Color.White
			Me.ProgressBar1.BorderRadius = 5
			Me.ProgressBar1.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ProgressBar1.ForeColor = Global.System.Drawing.Color.White
			Me.ProgressBar1.GradientMode = Global.System.Drawing.Drawing2D.LinearGradientMode.Horizontal
			Me.ProgressBar1.Location = New Global.System.Drawing.Point(12, 113)
			Me.ProgressBar1.Name = "ProgressBar1"
			Me.ProgressBar1.ProgressColor = Global.System.Drawing.Color.FromArgb(255, 128, 0)
			Me.ProgressBar1.ProgressColor2 = Global.System.Drawing.Color.FromArgb(0, 192, 0)
			Me.ProgressBar1.ShadowDecoration.Parent = Me.ProgressBar1
			Me.ProgressBar1.ShowPercentage = True
			Me.ProgressBar1.Size = New Global.System.Drawing.Size(676, 26)
			Me.ProgressBar1.TabIndex = 563
			Me.ProgressBar1.TextRenderingHint = Global.System.Drawing.Text.TextRenderingHint.SystemDefault
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(96F, 96F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Dpi
			Me.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			MyBase.ClientSize = New Global.System.Drawing.Size(705, 186)
			MyBase.Controls.Add(Me.ProgressBar1)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.TextBox1Name)
			MyBase.Controls.Add(Me.FileSave)
			MyBase.Controls.Add(Me.label3)
			MyBase.Controls.Add(Me.UploadFile)
			MyBase.Controls.Add(Me.TextBoxLink)
			MyBase.Controls.Add(Me.NameForm)
			MyBase.Controls.Add(Me.ClientInfo)
			Me.ForeColor = Global.System.Drawing.Color.White
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "UploadFromLink"
			Me.Text = "UploadFromLink"
			MyBase.TopMost = True
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x040007BD RID: 1981
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
