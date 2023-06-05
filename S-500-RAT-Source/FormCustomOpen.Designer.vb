Namespace S500RAT
	' Token: 0x02000016 RID: 22
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormCustomOpen
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060001E0 RID: 480 RVA: 0x0000EB2C File Offset: 0x0000CD2C
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

		' Token: 0x060001E1 RID: 481 RVA: 0x0000EB7C File Offset: 0x0000CD7C
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormCustomOpen))
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.UiLabel1 = New Global.Sunny.UI.UILabel()
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Open = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.FileName = New Global.Guna.UI2.WinForms.Guna2TextBox()
			Me.Args = New Global.Guna.UI2.WinForms.Guna2TextBox()
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.MAX = New Global.S500RAT.ValleyMax()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			MyBase.SuspendLayout()
			Me.Timer1.Enabled = True
			Me.Timer1.Interval = 2000
			Me.UiLabel1.AutoSize = True
			Me.UiLabel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel1.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel1.Location = New Global.System.Drawing.Point(10, 8)
			Me.UiLabel1.Name = "UiLabel1"
			Me.UiLabel1.Size = New Global.System.Drawing.Size(99, 19)
			Me.UiLabel1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLabel1.TabIndex = 535
			Me.UiLabel1.Text = "Custom Open"
			Me.UiLabel1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(11, 32)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(203, 14)
			Me.ClientInfo.TabIndex = 536
			Me.ClientInfo.Text = "FC / Desktop_3424 / Windows 10 pro"
			Me.Label1.AutoSize = True
			Me.Label1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label1.Font = New Global.System.Drawing.Font("Arial Unicode MS", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.ForeColor = Global.System.Drawing.Color.FromArgb(255, 128, 0)
			Me.Label1.Location = New Global.System.Drawing.Point(27, 71)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(444, 15)
			Me.Label1.TabIndex = 537
			Me.Label1.Text = "Enter the path of the file you want to execute. According to its path on the client's computer"
			Me.Open.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Open.BackColor = Global.System.Drawing.Color.Transparent
			Me.Open.BorderRadius = 8
			Me.Open.CheckedState.Parent = Me.Open
			Me.Open.CustomImages.Parent = Me.Open
			Me.Open.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.Open.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.Open.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Open.ForeColor = Global.System.Drawing.Color.White
			Me.Open.HoverState.Parent = Me.Open
			Me.Open.Location = New Global.System.Drawing.Point(498, 148)
			Me.Open.Name = "Open"
			Me.Open.ShadowDecoration.Parent = Me.Open
			Me.Open.Size = New Global.System.Drawing.Size(140, 27)
			Me.Open.TabIndex = 538
			Me.Open.Text = "Run"
			Me.FileName.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.FileName.Animated = True
			Me.FileName.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.FileName.BorderColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.FileName.BorderRadius = 7
			Me.FileName.BorderStyle = Global.System.Drawing.Drawing2D.DashStyle.Custom
			Me.FileName.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.FileName.DefaultText = ""
			Me.FileName.DisabledState.BorderColor = Global.System.Drawing.Color.FromArgb(208, 208, 208)
			Me.FileName.DisabledState.FillColor = Global.System.Drawing.Color.FromArgb(226, 226, 226)
			Me.FileName.DisabledState.ForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.FileName.DisabledState.Parent = Me.FileName
			Me.FileName.DisabledState.PlaceholderForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.FileName.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.FileName.FocusedState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.FileName.FocusedState.Parent = Me.FileName
			Me.FileName.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.FileName.ForeColor = Global.System.Drawing.Color.White
			Me.FileName.HoverState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.FileName.HoverState.Parent = Me.FileName
			Me.FileName.Location = New Global.System.Drawing.Point(12, 106)
			Me.FileName.Margin = New Global.System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.FileName.Name = "FileName"
			Me.FileName.PasswordChar = vbNullChar
			Me.FileName.PlaceholderForeColor = Global.System.Drawing.Color.Gray
			Me.FileName.PlaceholderText = "Path"
			Me.FileName.SelectedText = ""
			Me.FileName.ShadowDecoration.Parent = Me.FileName
			Me.FileName.Size = New Global.System.Drawing.Size(626, 27)
			Me.FileName.TabIndex = 539
			Me.FileName.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Args.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Args.Animated = True
			Me.Args.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.Args.BorderColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.Args.BorderRadius = 7
			Me.Args.BorderStyle = Global.System.Drawing.Drawing2D.DashStyle.Custom
			Me.Args.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.Args.DefaultText = ""
			Me.Args.DisabledState.BorderColor = Global.System.Drawing.Color.FromArgb(208, 208, 208)
			Me.Args.DisabledState.FillColor = Global.System.Drawing.Color.FromArgb(226, 226, 226)
			Me.Args.DisabledState.ForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.Args.DisabledState.Parent = Me.Args
			Me.Args.DisabledState.PlaceholderForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.Args.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.Args.FocusedState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.Args.FocusedState.Parent = Me.Args
			Me.Args.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Args.ForeColor = Global.System.Drawing.Color.White
			Me.Args.HoverState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.Args.HoverState.Parent = Me.Args
			Me.Args.Location = New Global.System.Drawing.Point(12, 148)
			Me.Args.Margin = New Global.System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.Args.Name = "Args"
			Me.Args.PasswordChar = vbNullChar
			Me.Args.PlaceholderForeColor = Global.System.Drawing.Color.Gray
			Me.Args.PlaceholderText = "Arguments"
			Me.Args.SelectedText = ""
			Me.Args.ShadowDecoration.Parent = Me.Args
			Me.Args.Size = New Global.System.Drawing.Size(459, 27)
			Me.Args.TabIndex = 540
			Me.Args.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
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
			Me.Mini.Location = New Global.System.Drawing.Point(566, 7)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 586
			Me.Mini.Text = "ValleyMini1"
			Me.MAX.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.MAX.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.MAX.Enabled = False
			Me.MAX.Location = New Global.System.Drawing.Point(592, 7)
			Me.MAX.Name = "MAX"
			Me.MAX.Size = New Global.System.Drawing.Size(20, 20)
			Me.MAX.TabIndex = 585
			Me.MAX.Text = "ValleyMax1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(618, 7)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 584
			Me.ExitForm.Text = "ValleyClose1"
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(96F, 96F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Dpi
			Me.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			MyBase.ClientSize = New Global.System.Drawing.Size(650, 210)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.MAX)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.Args)
			MyBase.Controls.Add(Me.FileName)
			MyBase.Controls.Add(Me.Open)
			MyBase.Controls.Add(Me.Label1)
			MyBase.Controls.Add(Me.UiLabel1)
			MyBase.Controls.Add(Me.ClientInfo)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "FormCustomOpen"
			Me.Text = "FormCustomOpen"
			MyBase.TopMost = True
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x040000DC RID: 220
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
