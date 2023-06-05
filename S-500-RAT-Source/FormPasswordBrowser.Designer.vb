Namespace S500RAT
	' Token: 0x0200003A RID: 58
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormPasswordBrowser
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06001024 RID: 4132 RVA: 0x0008B84C File Offset: 0x00089A4C
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

		' Token: 0x06001025 RID: 4133 RVA: 0x0008B89C File Offset: 0x00089A9C
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle3 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormPasswordBrowser))
			Me.Guna2Elipse1 = New Global.Guna.UI2.WinForms.Guna2Elipse(Me.components)
			Me.ListPass = New Global.Guna.UI2.WinForms.Guna2DataGridView()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewImageColumn()
			Me.Column4 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column5 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column6 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.ControllContextMenuStrip = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.CopyUser = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CopyPassword = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CopyURL = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ImageList1 = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.Label13 = New Global.System.Windows.Forms.Label()
			Me.Guna2ResizeBox1 = New Global.Guna.UI2.WinForms.Guna2ResizeBox()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.MAX = New Global.S500RAT.ValleyMax()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			CType(Me.ListPass, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.ControllContextMenuStrip.SuspendLayout()
			MyBase.SuspendLayout()
			Me.Guna2Elipse1.BorderRadius = 23
			Me.Guna2Elipse1.TargetControl = Me.ListPass
			Me.ListPass.AllowUserToAddRows = False
			Me.ListPass.AllowUserToDeleteRows = False
			Me.ListPass.AllowUserToResizeColumns = False
			Me.ListPass.AllowUserToResizeRows = False
			dataGridViewCellStyle.BackColor = Global.System.Drawing.Color.FromArgb(209, 196, 233)
			Me.ListPass.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
			Me.ListPass.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ListPass.AutoSizeColumnsMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
			Me.ListPass.BackgroundColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ListPass.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.ListPass.CellBorderStyle = Global.System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
			Me.ListPass.ColumnHeadersBorderStyle = Global.System.Windows.Forms.DataGridViewHeaderBorderStyle.None
			dataGridViewCellStyle2.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle2.BackColor = Global.System.Drawing.Color.FromArgb(103, 58, 183)
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle2.ForeColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle2.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle2.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle2.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.ListPass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
			Me.ListPass.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.ListPass.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column3, Me.Column4, Me.Column2, Me.Column5, Me.Column6 })
			Me.ListPass.ContextMenuStrip = Me.ControllContextMenuStrip
			dataGridViewCellStyle3.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle3.BackColor = Global.System.Drawing.Color.FromArgb(224, 215, 240)
			dataGridViewCellStyle3.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle3.ForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle3.SelectionBackColor = Global.System.Drawing.Color.FromArgb(153, 123, 207)
			dataGridViewCellStyle3.SelectionForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle3.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[False]
			Me.ListPass.DefaultCellStyle = dataGridViewCellStyle3
			Me.ListPass.EnableHeadersVisualStyles = False
			Me.ListPass.GridColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ListPass.Location = New Global.System.Drawing.Point(18, 69)
			Me.ListPass.Name = "ListPass"
			Me.ListPass.[ReadOnly] = True
			Me.ListPass.RowHeadersVisible = False
			Me.ListPass.RowHeadersWidth = 20
			Me.ListPass.RowHeadersWidthSizeMode = Global.System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
			Me.ListPass.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			Me.ListPass.ShowCellErrors = False
			Me.ListPass.ShowEditingIcon = False
			Me.ListPass.ShowRowErrors = False
			Me.ListPass.Size = New Global.System.Drawing.Size(554, 329)
			Me.ListPass.TabIndex = 513
			Me.ListPass.Theme = Global.Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.DeepPurple
			Me.ListPass.ThemeStyle.AlternatingRowsStyle.BackColor = Global.System.Drawing.Color.FromArgb(209, 196, 233)
			Me.ListPass.ThemeStyle.AlternatingRowsStyle.Font = Nothing
			Me.ListPass.ThemeStyle.AlternatingRowsStyle.ForeColor = Global.System.Drawing.Color.Empty
			Me.ListPass.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Global.System.Drawing.Color.Empty
			Me.ListPass.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Global.System.Drawing.Color.Empty
			Me.ListPass.ThemeStyle.BackColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ListPass.ThemeStyle.GridColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ListPass.ThemeStyle.HeaderStyle.BackColor = Global.System.Drawing.Color.FromArgb(103, 58, 183)
			Me.ListPass.ThemeStyle.HeaderStyle.BorderStyle = Global.System.Windows.Forms.DataGridViewHeaderBorderStyle.None
			Me.ListPass.ThemeStyle.HeaderStyle.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ListPass.ThemeStyle.HeaderStyle.ForeColor = Global.System.Drawing.Color.White
			Me.ListPass.ThemeStyle.HeaderStyle.HeaightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.ListPass.ThemeStyle.HeaderStyle.Height = 23
			Me.ListPass.ThemeStyle.[ReadOnly] = True
			Me.ListPass.ThemeStyle.RowsStyle.BackColor = Global.System.Drawing.Color.FromArgb(224, 215, 240)
			Me.ListPass.ThemeStyle.RowsStyle.BorderStyle = Global.System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
			Me.ListPass.ThemeStyle.RowsStyle.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ListPass.ThemeStyle.RowsStyle.ForeColor = Global.System.Drawing.Color.Black
			Me.ListPass.ThemeStyle.RowsStyle.Height = 22
			Me.ListPass.ThemeStyle.RowsStyle.SelectionBackColor = Global.System.Drawing.Color.FromArgb(153, 123, 207)
			Me.ListPass.ThemeStyle.RowsStyle.SelectionForeColor = Global.System.Drawing.Color.Black
			Me.Column3.HeaderText = "         "
			Me.Column3.ImageLayout = Global.System.Windows.Forms.DataGridViewImageCellLayout.Zoom
			Me.Column3.Name = "Column3"
			Me.Column3.[ReadOnly] = True
			Me.Column3.Width = 38
			Me.Column4.AutoSizeMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
			Me.Column4.HeaderText = "App"
			Me.Column4.Name = "Column4"
			Me.Column4.[ReadOnly] = True
			Me.Column4.Width = 52
			Me.Column2.AutoSizeMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
			Me.Column2.HeaderText = "User name"
			Me.Column2.Name = "Column2"
			Me.Column2.[ReadOnly] = True
			Me.Column2.Width = 90
			Me.Column5.AutoSizeMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
			Me.Column5.HeaderText = "Password"
			Me.Column5.Name = "Column5"
			Me.Column5.[ReadOnly] = True
			Me.Column5.Width = 86
			Me.Column6.AutoSizeMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
			Me.Column6.HeaderText = "Url"
			Me.Column6.Name = "Column6"
			Me.Column6.[ReadOnly] = True
			Me.ControllContextMenuStrip.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ControllContextMenuStrip.ImageScalingSize = New Global.System.Drawing.Size(20, 20)
			Me.ControllContextMenuStrip.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.CopyUser, Me.CopyPassword, Me.CopyURL, Me.ToolStripMenuItem1 })
			Me.ControllContextMenuStrip.Name = "ContextMenuStrip1"
			Me.ControllContextMenuStrip.ShowImageMargin = False
			Me.ControllContextMenuStrip.Size = New Global.System.Drawing.Size(141, 92)
			Me.CopyUser.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.CopyUser.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.CopyUser.Name = "CopyUser"
			Me.CopyUser.Size = New Global.System.Drawing.Size(140, 22)
			Me.CopyUser.Text = "Copy User name"
			Me.CopyPassword.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.CopyPassword.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.CopyPassword.Name = "CopyPassword"
			Me.CopyPassword.Size = New Global.System.Drawing.Size(140, 22)
			Me.CopyPassword.Text = "Copy Password"
			Me.CopyURL.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.CopyURL.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.CopyURL.Name = "CopyURL"
			Me.CopyURL.Size = New Global.System.Drawing.Size(140, 22)
			Me.CopyURL.Text = "Copy Url"
			Me.ToolStripMenuItem1.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.ToolStripMenuItem1.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
			Me.ToolStripMenuItem1.Size = New Global.System.Drawing.Size(140, 22)
			Me.ToolStripMenuItem1.Text = "Copy All"
			Me.ImageList1.ImageStream = CType(componentResourceManager.GetObject("ImageList1.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.ImageList1.TransparentColor = Global.System.Drawing.Color.Transparent
			Me.ImageList1.Images.SetKeyName(0, "7Star.png")
			Me.ImageList1.Images.SetKeyName(1, "360 Browser.png")
			Me.ImageList1.Images.SetKeyName(2, "Amigo.png")
			Me.ImageList1.Images.SetKeyName(3, "Brave Browser.png")
			Me.ImageList1.Images.SetKeyName(4, "CentBrowser.png")
			Me.ImageList1.Images.SetKeyName(5, "Chedot.png")
			Me.ImageList1.Images.SetKeyName(6, "Chrome.png")
			Me.ImageList1.Images.SetKeyName(7, "Citrio.png")
			Me.ImageList1.Images.SetKeyName(8, "CocCoc.png")
			Me.ImageList1.Images.SetKeyName(9, "Comodo Dragon.png")
			Me.ImageList1.Images.SetKeyName(10, "CoolNovo.png")
			Me.ImageList1.Images.SetKeyName(11, "Coowon.png")
			Me.ImageList1.Images.SetKeyName(12, "Edge Chromium.png")
			Me.ImageList1.Images.SetKeyName(13, "Elements Browser.png")
			Me.ImageList1.Images.SetKeyName(14, "Epic Privacy Browser.png")
			Me.ImageList1.Images.SetKeyName(15, "Iridium Browser.png")
			Me.ImageList1.Images.SetKeyName(16, "Kometa.png")
			Me.ImageList1.Images.SetKeyName(17, "Liebao Browser.png")
			Me.ImageList1.Images.SetKeyName(18, "Opera.png")
			Me.ImageList1.Images.SetKeyName(19, "Orbitum.png")
			Me.ImageList1.Images.SetKeyName(20, "QIP Surf.png")
			Me.ImageList1.Images.SetKeyName(21, "Sleipnir 6.png")
			Me.ImageList1.Images.SetKeyName(22, "Sputnik.png")
			Me.ImageList1.Images.SetKeyName(23, "SRWare Iron.png")
			Me.ImageList1.Images.SetKeyName(24, "Torch Browser.png")
			Me.ImageList1.Images.SetKeyName(25, "uCozMedia.png")
			Me.ImageList1.Images.SetKeyName(26, "Vivaldi.png")
			Me.ImageList1.Images.SetKeyName(27, "Yandex.png")
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Nirmala UI", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(158, 161, 176)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(23, 31)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(17, 15)
			Me.ClientInfo.TabIndex = 293
			Me.ClientInfo.Text = "--"
			Me.Label13.AutoSize = True
			Me.Label13.Font = New Global.System.Drawing.Font("Nirmala UI", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label13.ForeColor = Global.System.Drawing.Color.White
			Me.Label13.Location = New Global.System.Drawing.Point(19, 11)
			Me.Label13.Name = "Label13"
			Me.Label13.Size = New Global.System.Drawing.Size(72, 17)
			Me.Label13.TabIndex = 292
			Me.Label13.Text = "Passwords"
			Me.Guna2ResizeBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Guna2ResizeBox1.FillColor = Global.System.Drawing.Color.White
			Me.Guna2ResizeBox1.ForeColor = Global.System.Drawing.Color.Empty
			Me.Guna2ResizeBox1.Location = New Global.System.Drawing.Point(563, 397)
			Me.Guna2ResizeBox1.Name = "Guna2ResizeBox1"
			Me.Guna2ResizeBox1.Size = New Global.System.Drawing.Size(17, 19)
			Me.Guna2ResizeBox1.TabIndex = 512
			Me.Guna2ResizeBox1.TargetControl = Me
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
			Me.Mini.Location = New Global.System.Drawing.Point(507, 12)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 560
			Me.Mini.Text = "ValleyMini1"
			Me.MAX.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.MAX.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.MAX.Location = New Global.System.Drawing.Point(533, 12)
			Me.MAX.Name = "MAX"
			Me.MAX.Size = New Global.System.Drawing.Size(20, 20)
			Me.MAX.TabIndex = 559
			Me.MAX.Text = "ValleyMax1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(559, 12)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 558
			Me.ExitForm.Text = "ValleyClose1"
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(96F, 96F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Dpi
			Me.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			MyBase.ClientSize = New Global.System.Drawing.Size(591, 427)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.MAX)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.ListPass)
			MyBase.Controls.Add(Me.Guna2ResizeBox1)
			MyBase.Controls.Add(Me.ClientInfo)
			MyBase.Controls.Add(Me.Label13)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "FormPasswordBrowser"
			Me.Text = "PasswordBrowser"
			MyBase.TopMost = True
			CType(Me.ListPass, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ControllContextMenuStrip.ResumeLayout(False)
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0400073C RID: 1852
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
