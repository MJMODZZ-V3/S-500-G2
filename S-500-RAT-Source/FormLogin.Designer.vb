Namespace S500RAT
	' Token: 0x02000023 RID: 35
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormLogin
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000606 RID: 1542 RVA: 0x00033388 File Offset: 0x00031588
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

		' Token: 0x06000607 RID: 1543 RVA: 0x000333D8 File Offset: 0x000315D8
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormLogin))
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			Me.PasswordTXT = New Global.Guna.UI2.WinForms.Guna2TextBox()
			Me.UserNameTXT = New Global.Guna.UI2.WinForms.Guna2TextBox()
			Me.UiLabel1 = New Global.Sunny.UI.UILabel()
			Me.Login = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.RememberMe = New Global.Guna.UI2.WinForms.Guna2ToggleSwitch()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.PLW = New Global.Guna.UI2.WinForms.Guna2CircleProgressBar()
			MyBase.SuspendLayout()
			Me.Guna2DragControl1.ContainerControl = Me
			Me.Guna2DragControl1.DockForm = True
			Me.Guna2DragControl1.DockIndicatorColor = Global.System.Drawing.Color.FromArgb(56, 37, 200)
			Me.Guna2DragControl1.DragEndTransparencyValue = 0.95
			Me.Guna2DragControl1.DragMode = Global.Guna.UI2.WinForms.Enums.DragMode.Control
			Me.Guna2DragControl1.DragStartTransparencyValue = 0.6
			Me.Guna2DragControl1.TargetControl = Me
			Me.Guna2DragControl1.TransparentWhileDrag = True
			Me.Guna2DragControl1.UseTransparentDrag = True
			Me.Guna2BorderlessForm1.AnimateWindow = True
			Me.Guna2BorderlessForm1.BorderRadius = 15
			Me.Guna2BorderlessForm1.ContainerControl = Me
			Me.Guna2BorderlessForm1.DockIndicatorColor = Global.System.Drawing.Color.FromArgb(56, 37, 200)
			Me.Guna2BorderlessForm1.DragStartTransparencyValue = 0.6
			Me.Guna2BorderlessForm1.ShadowColor = Global.System.Drawing.Color.FromArgb(56, 37, 200)
			Me.Guna2BorderlessForm1.TransparentWhileDrag = True
			Me.Mini.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Mini.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Mini.Location = New Global.System.Drawing.Point(332, 12)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 553
			Me.Mini.Text = "ValleyMini1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(358, 12)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 552
			Me.ExitForm.Text = "ValleyClose1"
			Me.PasswordTXT.Animated = True
			Me.PasswordTXT.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.PasswordTXT.BorderColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.PasswordTXT.BorderRadius = 7
			Me.PasswordTXT.BorderStyle = Global.System.Drawing.Drawing2D.DashStyle.Custom
			Me.PasswordTXT.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.PasswordTXT.DefaultText = ""
			Me.PasswordTXT.DisabledState.BorderColor = Global.System.Drawing.Color.FromArgb(208, 208, 208)
			Me.PasswordTXT.DisabledState.FillColor = Global.System.Drawing.Color.FromArgb(226, 226, 226)
			Me.PasswordTXT.DisabledState.ForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.PasswordTXT.DisabledState.Parent = Me.PasswordTXT
			Me.PasswordTXT.DisabledState.PlaceholderForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.PasswordTXT.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.PasswordTXT.FocusedState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.PasswordTXT.FocusedState.Parent = Me.PasswordTXT
			Me.PasswordTXT.Font = New Global.System.Drawing.Font("Microsoft YaHei UI", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.PasswordTXT.ForeColor = Global.System.Drawing.Color.White
			Me.PasswordTXT.HoverState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.PasswordTXT.HoverState.Parent = Me.PasswordTXT
			Me.PasswordTXT.IconLeft = CType(componentResourceManager.GetObject("PasswordTXT.IconLeft"), Global.System.Drawing.Image)
			Me.PasswordTXT.Location = New Global.System.Drawing.Point(45, 320)
			Me.PasswordTXT.Margin = New Global.System.Windows.Forms.Padding(2)
			Me.PasswordTXT.Name = "PasswordTXT"
			Me.PasswordTXT.PasswordChar = vbNullChar
			Me.PasswordTXT.PlaceholderForeColor = Global.System.Drawing.Color.Silver
			Me.PasswordTXT.PlaceholderText = "Password"
			Me.PasswordTXT.SelectedText = ""
			Me.PasswordTXT.ShadowDecoration.Parent = Me.PasswordTXT
			Me.PasswordTXT.Size = New Global.System.Drawing.Size(288, 28)
			Me.PasswordTXT.TabIndex = 555
			Me.PasswordTXT.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.PasswordTXT.UseSystemPasswordChar = True
			Me.UserNameTXT.Animated = True
			Me.UserNameTXT.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.UserNameTXT.BorderColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.UserNameTXT.BorderRadius = 7
			Me.UserNameTXT.BorderStyle = Global.System.Drawing.Drawing2D.DashStyle.Custom
			Me.UserNameTXT.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.UserNameTXT.DefaultText = ""
			Me.UserNameTXT.DisabledState.BorderColor = Global.System.Drawing.Color.FromArgb(208, 208, 208)
			Me.UserNameTXT.DisabledState.FillColor = Global.System.Drawing.Color.FromArgb(226, 226, 226)
			Me.UserNameTXT.DisabledState.ForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.UserNameTXT.DisabledState.Parent = Me.UserNameTXT
			Me.UserNameTXT.DisabledState.PlaceholderForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.UserNameTXT.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.UserNameTXT.FocusedState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.UserNameTXT.FocusedState.Parent = Me.UserNameTXT
			Me.UserNameTXT.Font = New Global.System.Drawing.Font("Microsoft YaHei UI", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UserNameTXT.ForeColor = Global.System.Drawing.Color.White
			Me.UserNameTXT.HoverState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.UserNameTXT.HoverState.Parent = Me.UserNameTXT
			Me.UserNameTXT.IconLeft = CType(componentResourceManager.GetObject("UserNameTXT.IconLeft"), Global.System.Drawing.Image)
			Me.UserNameTXT.Location = New Global.System.Drawing.Point(45, 279)
			Me.UserNameTXT.Margin = New Global.System.Windows.Forms.Padding(2)
			Me.UserNameTXT.Name = "UserNameTXT"
			Me.UserNameTXT.PasswordChar = vbNullChar
			Me.UserNameTXT.PlaceholderForeColor = Global.System.Drawing.Color.Silver
			Me.UserNameTXT.PlaceholderText = "Username"
			Me.UserNameTXT.SelectedText = ""
			Me.UserNameTXT.ShadowDecoration.Parent = Me.UserNameTXT
			Me.UserNameTXT.Size = New Global.System.Drawing.Size(288, 28)
			Me.UserNameTXT.TabIndex = 556
			Me.UserNameTXT.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.UiLabel1.AutoSize = True
			Me.UiLabel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel1.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel1.Location = New Global.System.Drawing.Point(12, 9)
			Me.UiLabel1.Name = "UiLabel1"
			Me.UiLabel1.Size = New Global.System.Drawing.Size(46, 19)
			Me.UiLabel1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLabel1.TabIndex = 561
			Me.UiLabel1.Text = "Login"
			Me.UiLabel1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Login.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Login.BackColor = Global.System.Drawing.Color.Transparent
			Me.Login.BorderRadius = 8
			Me.Login.CheckedState.Parent = Me.Login
			Me.Login.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Login.CustomImages.Parent = Me.Login
			Me.Login.FillColor = Global.System.Drawing.Color.FromArgb(192, 64, 0)
			Me.Login.FillColor2 = Global.System.Drawing.Color.DarkOrchid
			Me.Login.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Login.ForeColor = Global.System.Drawing.Color.White
			Me.Login.HoverState.Parent = Me.Login
			Me.Login.Location = New Global.System.Drawing.Point(266, 471)
			Me.Login.Name = "Login"
			Me.Login.ShadowDecoration.Parent = Me.Login
			Me.Login.Size = New Global.System.Drawing.Size(108, 31)
			Me.Login.TabIndex = 562
			Me.Login.Text = "Login"
			Me.RememberMe.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.RememberMe.Animated = True
			Me.RememberMe.AutoRoundedCorners = True
			Me.RememberMe.BackColor = Global.System.Drawing.Color.Transparent
			Me.RememberMe.CheckedState.BorderColor = Global.System.Drawing.Color.FromArgb(82, 43, 235)
			Me.RememberMe.CheckedState.FillColor = Global.System.Drawing.Color.FromArgb(82, 43, 235)
			Me.RememberMe.CheckedState.InnerBorderColor = Global.System.Drawing.Color.White
			Me.RememberMe.CheckedState.InnerColor = Global.System.Drawing.Color.White
			Me.RememberMe.CheckedState.Parent = Me.RememberMe
			Me.RememberMe.Location = New Global.System.Drawing.Point(45, 358)
			Me.RememberMe.Name = "RememberMe"
			Me.RememberMe.ShadowDecoration.Parent = Me.RememberMe
			Me.RememberMe.Size = New Global.System.Drawing.Size(41, 20)
			Me.RememberMe.TabIndex = 574
			Me.RememberMe.UncheckedState.BorderColor = Global.System.Drawing.Color.Red
			Me.RememberMe.UncheckedState.FillColor = Global.System.Drawing.Color.FromArgb(66, 69, 91)
			Me.RememberMe.UncheckedState.InnerBorderColor = Global.System.Drawing.Color.White
			Me.RememberMe.UncheckedState.InnerColor = Global.System.Drawing.Color.White
			Me.RememberMe.UncheckedState.Parent = Me.RememberMe
			Me.Label2.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.Label2.AutoSize = True
			Me.Label2.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label2.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Label2.ForeColor = Global.System.Drawing.Color.White
			Me.Label2.Location = New Global.System.Drawing.Point(92, 361)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(90, 14)
			Me.Label2.TabIndex = 575
			Me.Label2.Text = "Remember me"
			Me.PLW.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.PLW.AnimationSpeed = 1.6F
			Me.PLW.BackColor = Global.System.Drawing.Color.Transparent
			Me.PLW.FillColor = Global.System.Drawing.Color.Transparent
			Me.PLW.FillThickness = 10
			Me.PLW.GradientMode = Global.System.Drawing.Drawing2D.LinearGradientMode.Vertical
			Me.PLW.Image = CType(componentResourceManager.GetObject("PLW.Image"), Global.System.Drawing.Image)
			Me.PLW.ImageSize = New Global.System.Drawing.Size(130, 130)
			Me.PLW.Location = New Global.System.Drawing.Point(99, 63)
			Me.PLW.Name = "PLW"
			Me.PLW.ProgressBrushMode = Global.Guna.UI2.WinForms.Enums.BrushMode.SolidTransition
			Me.PLW.ProgressColor = Global.System.Drawing.Color.FromArgb(192, 64, 0)
			Me.PLW.ProgressColor2 = Global.System.Drawing.Color.DarkOrchid
			Me.PLW.ProgressEndCap = Global.System.Drawing.Drawing2D.LineCap.Round
			Me.PLW.ProgressStartCap = Global.System.Drawing.Drawing2D.LineCap.Round
			Me.PLW.ProgressThickness = 10
			Me.PLW.ShadowDecoration.Mode = Global.Guna.UI2.WinForms.Enums.ShadowMode.Circle
			Me.PLW.ShadowDecoration.Parent = Me.PLW
			Me.PLW.Size = New Global.System.Drawing.Size(173, 173)
			Me.PLW.TabIndex = 576
			Me.PLW.TextRenderingHint = Global.System.Drawing.Text.TextRenderingHint.SystemDefault
			Me.PLW.UseTransparentBackground = True
			Me.PLW.Value = 100
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(96F, 96F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Dpi
			Me.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			MyBase.ClientSize = New Global.System.Drawing.Size(390, 514)
			MyBase.Controls.Add(Me.PLW)
			MyBase.Controls.Add(Me.RememberMe)
			MyBase.Controls.Add(Me.Label2)
			MyBase.Controls.Add(Me.Login)
			MyBase.Controls.Add(Me.UiLabel1)
			MyBase.Controls.Add(Me.UserNameTXT)
			MyBase.Controls.Add(Me.PasswordTXT)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.ExitForm)
			Me.DoubleBuffered = True
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "FormLogin"
			Me.Text = "Login"
			MyBase.TopMost = True
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x040002BA RID: 698
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
