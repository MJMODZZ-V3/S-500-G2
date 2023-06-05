Namespace S500RAT
	' Token: 0x02000022 RID: 34
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormKeylogger
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060005DB RID: 1499 RVA: 0x000320B4 File Offset: 0x000302B4
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

		' Token: 0x060005DC RID: 1500 RVA: 0x00032104 File Offset: 0x00030304
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormKeylogger))
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.UiLabel1 = New Global.Sunny.UI.UILabel()
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.Guna2ResizeBox1 = New Global.Guna.UI2.WinForms.Guna2ResizeBox()
			Me.Search = New Global.Guna.UI2.WinForms.Guna2TextBox()
			Me.KeyloggerSave = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.T1 = New Global.Sunny.UI.UIRichTextBox()
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.MAX = New Global.S500RAT.ValleyMax()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			MyBase.SuspendLayout()
			Me.Timer1.Interval = 2000
			Me.UiLabel1.AutoSize = True
			Me.UiLabel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel1.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel1.Location = New Global.System.Drawing.Point(10, 8)
			Me.UiLabel1.Name = "UiLabel1"
			Me.UiLabel1.Size = New Global.System.Drawing.Size(78, 19)
			Me.UiLabel1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLabel1.TabIndex = 534
			Me.UiLabel1.Text = "Keylogger"
			Me.UiLabel1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(11, 32)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(203, 14)
			Me.ClientInfo.TabIndex = 535
			Me.ClientInfo.Text = "FC / Desktop_3424 / Windows 10 pro"
			Me.Guna2ResizeBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Guna2ResizeBox1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Guna2ResizeBox1.FillColor = Global.System.Drawing.Color.Silver
			Me.Guna2ResizeBox1.ForeColor = Global.System.Drawing.Color.Empty
			Me.Guna2ResizeBox1.Location = New Global.System.Drawing.Point(556, 389)
			Me.Guna2ResizeBox1.Name = "Guna2ResizeBox1"
			Me.Guna2ResizeBox1.Size = New Global.System.Drawing.Size(17, 19)
			Me.Guna2ResizeBox1.TabIndex = 537
			Me.Guna2ResizeBox1.TargetControl = Me
			Me.Guna2ResizeBox1.UseTransparentBackground = True
			Me.Search.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Search.Animated = True
			Me.Search.BackColor = Global.System.Drawing.Color.Transparent
			Me.Search.BorderColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.Search.BorderRadius = 18
			Me.Search.BorderStyle = Global.System.Drawing.Drawing2D.DashStyle.Custom
			Me.Search.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.Search.DefaultText = ""
			Me.Search.DisabledState.Parent = Me.Search
			Me.Search.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.Search.FocusedState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.Search.FocusedState.Parent = Me.Search
			Me.Search.ForeColor = Global.System.Drawing.Color.White
			Me.Search.HoverState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.Search.HoverState.Parent = Me.Search
			Me.Search.IconLeftCursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Search.IconRight = CType(componentResourceManager.GetObject("Search.IconRight"), Global.System.Drawing.Image)
			Me.Search.IconRightCursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Search.Location = New Global.System.Drawing.Point(14, 62)
			Me.Search.Margin = New Global.System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.Search.Name = "Search"
			Me.Search.PasswordChar = vbNullChar
			Me.Search.PlaceholderForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.Search.PlaceholderText = "Search"
			Me.Search.SelectedText = ""
			Me.Search.ShadowDecoration.Parent = Me.Search
			Me.Search.Size = New Global.System.Drawing.Size(549, 27)
			Me.Search.Style = Global.Guna.UI2.WinForms.Enums.TextBoxStyle.Material
			Me.Search.TabIndex = 538
			Me.KeyloggerSave.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.KeyloggerSave.BackColor = Global.System.Drawing.Color.Transparent
			Me.KeyloggerSave.BorderRadius = 8
			Me.KeyloggerSave.CheckedState.Parent = Me.KeyloggerSave
			Me.KeyloggerSave.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.KeyloggerSave.CustomImages.Parent = Me.KeyloggerSave
			Me.KeyloggerSave.Enabled = False
			Me.KeyloggerSave.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.KeyloggerSave.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.KeyloggerSave.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.KeyloggerSave.ForeColor = Global.System.Drawing.Color.White
			Me.KeyloggerSave.HoverState.Parent = Me.KeyloggerSave
			Me.KeyloggerSave.Location = New Global.System.Drawing.Point(14, 387)
			Me.KeyloggerSave.Name = "KeyloggerSave"
			Me.KeyloggerSave.ShadowDecoration.Color = Global.System.Drawing.Color.White
			Me.KeyloggerSave.ShadowDecoration.Parent = Me.KeyloggerSave
			Me.KeyloggerSave.Size = New Global.System.Drawing.Size(90, 27)
			Me.KeyloggerSave.TabIndex = 544
			Me.KeyloggerSave.Tag = ""
			Me.KeyloggerSave.Text = "Save"
			Me.T1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.T1.AutoWordSelection = True
			Me.T1.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 48)
			Me.T1.FillColor = Global.System.Drawing.Color.FromArgb(7, 11, 48)
			Me.T1.FillColor2 = Global.System.Drawing.SystemColors.WindowFrame
			Me.T1.FillDisableColor = Global.System.Drawing.Color.Red
			Me.T1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.T1.ForeColor = Global.System.Drawing.Color.White
			Me.T1.ForeDisableColor = Global.System.Drawing.Color.FromArgb(82, 43, 235)
			Me.T1.Location = New Global.System.Drawing.Point(17, 96)
			Me.T1.Margin = New Global.System.Windows.Forms.Padding(3, 5, 3, 5)
			Me.T1.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.T1.Name = "T1"
			Me.T1.Padding = New Global.System.Windows.Forms.Padding(2)
			Me.T1.Radius = 8
			Me.T1.[ReadOnly] = True
			Me.T1.RectColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.T1.Size = New Global.System.Drawing.Size(546, 286)
			Me.T1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.T1.TabIndex = 545
			Me.T1.TextAlignment = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.T1.WordWrap = True
			Me.Mini.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Mini.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Mini.Location = New Global.System.Drawing.Point(499, 12)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 557
			Me.Mini.Text = "ValleyMini1"
			Me.MAX.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.MAX.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.MAX.Location = New Global.System.Drawing.Point(525, 12)
			Me.MAX.Name = "MAX"
			Me.MAX.Size = New Global.System.Drawing.Size(20, 20)
			Me.MAX.TabIndex = 556
			Me.MAX.Text = "ValleyMax1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(551, 12)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 555
			Me.ExitForm.Text = "ValleyClose1"
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
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(96F, 96F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Dpi
			Me.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			MyBase.ClientSize = New Global.System.Drawing.Size(583, 419)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.MAX)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.T1)
			MyBase.Controls.Add(Me.KeyloggerSave)
			MyBase.Controls.Add(Me.Search)
			MyBase.Controls.Add(Me.Guna2ResizeBox1)
			MyBase.Controls.Add(Me.UiLabel1)
			MyBase.Controls.Add(Me.ClientInfo)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "FormKeylogger"
			Me.Text = "FormKeylogger"
			MyBase.TopMost = True
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x040002A7 RID: 679
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
