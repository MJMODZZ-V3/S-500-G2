Namespace S500RAT
	' Token: 0x02000030 RID: 48
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormPasswordView
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000E0A RID: 3594 RVA: 0x0007D3E4 File Offset: 0x0007B5E4
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

		' Token: 0x06000E0B RID: 3595 RVA: 0x0007D434 File Offset: 0x0007B634
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle3 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle4 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormPasswordView))
			Me.ListPassword = New Global.System.Windows.Forms.DataGridView()
			Me.DataGridViewImageColumn3 = New Global.System.Windows.Forms.DataGridViewImageColumn()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn6 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn7 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.ControllContextMenuStrip = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.CopyUser = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CopyPassword = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CopyURL = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.Guna2Elipse1 = New Global.Guna.UI2.WinForms.Guna2Elipse(Me.components)
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.Label13 = New Global.System.Windows.Forms.Label()
			Me.Guna2ResizeBox1 = New Global.Guna.UI2.WinForms.Guna2ResizeBox()
			Me.ImageList1 = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.MAX = New Global.S500RAT.ValleyMax()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			CType(Me.ListPassword, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.ControllContextMenuStrip.SuspendLayout()
			MyBase.SuspendLayout()
			Me.ListPassword.AllowUserToAddRows = False
			Me.ListPassword.AllowUserToDeleteRows = False
			Me.ListPassword.AllowUserToResizeColumns = False
			Me.ListPassword.AllowUserToResizeRows = False
			dataGridViewCellStyle.BackColor = Global.System.Drawing.Color.FromArgb(23, 27, 82)
			dataGridViewCellStyle.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ListPassword.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
			Me.ListPassword.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ListPassword.BackgroundColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ListPassword.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.ListPassword.ClipboardCopyMode = Global.System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
			Me.ListPassword.ColumnHeadersBorderStyle = Global.System.Windows.Forms.DataGridViewHeaderBorderStyle.None
			dataGridViewCellStyle2.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle2.BackColor = Global.System.Drawing.Color.FromArgb(79, 46, 208)
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle2.ForeColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle2.SelectionForeColor = Global.System.Drawing.Color.FromArgb(242, 243, 244)
			dataGridViewCellStyle2.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.ListPassword.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
			Me.ListPassword.ColumnHeadersHeight = 29
			Me.ListPassword.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.ListPassword.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.DataGridViewImageColumn3, Me.Column1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7 })
			Me.ListPassword.ContextMenuStrip = Me.ControllContextMenuStrip
			dataGridViewCellStyle3.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle3.BackColor = Global.System.Drawing.Color.FromArgb(19, 23, 61)
			dataGridViewCellStyle3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle3.ForeColor = Global.System.Drawing.Color.FromArgb(79, 46, 208)
			dataGridViewCellStyle3.SelectionBackColor = Global.System.Drawing.Color.FromArgb(47, 39, 134)
			dataGridViewCellStyle3.SelectionForeColor = Global.System.Drawing.Color.FromArgb(242, 243, 255)
			dataGridViewCellStyle3.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[False]
			Me.ListPassword.DefaultCellStyle = dataGridViewCellStyle3
			Me.ListPassword.EnableHeadersVisualStyles = False
			Me.ListPassword.GridColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ListPassword.Location = New Global.System.Drawing.Point(21, 69)
			Me.ListPassword.Name = "ListPassword"
			Me.ListPassword.[ReadOnly] = True
			Me.ListPassword.RowHeadersBorderStyle = Global.System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
			dataGridViewCellStyle4.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle4.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle4.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.ListPassword.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
			Me.ListPassword.RowHeadersVisible = False
			Me.ListPassword.RowHeadersWidth = 55
			Me.ListPassword.RowHeadersWidthSizeMode = Global.System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
			Me.ListPassword.RowTemplate.Resizable = Global.System.Windows.Forms.DataGridViewTriState.[False]
			Me.ListPassword.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
			Me.ListPassword.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			Me.ListPassword.ShowCellToolTips = False
			Me.ListPassword.ShowEditingIcon = False
			Me.ListPassword.Size = New Global.System.Drawing.Size(626, 343)
			Me.ListPassword.TabIndex = 254
			Me.DataGridViewImageColumn3.AutoSizeMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
			Me.DataGridViewImageColumn3.HeaderText = "           "
			Me.DataGridViewImageColumn3.ImageLayout = Global.System.Windows.Forms.DataGridViewImageCellLayout.Zoom
			Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
			Me.DataGridViewImageColumn3.[ReadOnly] = True
			Me.DataGridViewImageColumn3.Width = 26
			Me.Column1.AutoSizeMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
			Me.Column1.HeaderText = "App"
			Me.Column1.Name = "Column1"
			Me.Column1.[ReadOnly] = True
			Me.Column1.Width = 49
			Me.DataGridViewTextBoxColumn3.AutoSizeMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
			Me.DataGridViewTextBoxColumn3.HeaderText = "Username"
			Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
			Me.DataGridViewTextBoxColumn3.[ReadOnly] = True
			Me.DataGridViewTextBoxColumn3.Width = 78
			Me.DataGridViewTextBoxColumn6.AutoSizeMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
			Me.DataGridViewTextBoxColumn6.HeaderText = "Password"
			Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
			Me.DataGridViewTextBoxColumn6.[ReadOnly] = True
			Me.DataGridViewTextBoxColumn6.Width = 76
			Me.DataGridViewTextBoxColumn7.AutoSizeMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn7.HeaderText = "Url"
			Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
			Me.DataGridViewTextBoxColumn7.[ReadOnly] = True
			Me.ControllContextMenuStrip.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ControllContextMenuStrip.ImageScalingSize = New Global.System.Drawing.Size(24, 24)
			Me.ControllContextMenuStrip.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.CopyUser, Me.CopyPassword, Me.CopyURL })
			Me.ControllContextMenuStrip.Name = "ContextMenuStrip1"
			Me.ControllContextMenuStrip.Size = New Global.System.Drawing.Size(170, 94)
			Me.CopyUser.BackColor = Global.System.Drawing.Color.FromArgb(24, 30, 54)
			Me.CopyUser.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.CopyUser.Image = CType(componentResourceManager.GetObject("CopyUser.Image"), Global.System.Drawing.Image)
			Me.CopyUser.Name = "CopyUser"
			Me.CopyUser.Size = New Global.System.Drawing.Size(169, 30)
			Me.CopyUser.Text = "Copy User"
			Me.CopyPassword.BackColor = Global.System.Drawing.Color.FromArgb(24, 30, 54)
			Me.CopyPassword.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.CopyPassword.Image = CType(componentResourceManager.GetObject("CopyPassword.Image"), Global.System.Drawing.Image)
			Me.CopyPassword.Name = "CopyPassword"
			Me.CopyPassword.Size = New Global.System.Drawing.Size(169, 30)
			Me.CopyPassword.Text = "Copy Password"
			Me.CopyURL.BackColor = Global.System.Drawing.Color.FromArgb(24, 30, 54)
			Me.CopyURL.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.CopyURL.Image = CType(componentResourceManager.GetObject("CopyURL.Image"), Global.System.Drawing.Image)
			Me.CopyURL.Name = "CopyURL"
			Me.CopyURL.Size = New Global.System.Drawing.Size(169, 30)
			Me.CopyURL.Text = "Copy Url"
			Me.Guna2Elipse1.BorderRadius = 23
			Me.Guna2Elipse1.TargetControl = Me.ListPassword
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Nirmala UI", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(158, 161, 176)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(27, 32)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(17, 15)
			Me.ClientInfo.TabIndex = 288
			Me.ClientInfo.Text = "--"
			Me.Label13.AutoSize = True
			Me.Label13.Font = New Global.System.Drawing.Font("Nirmala UI", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label13.ForeColor = Global.System.Drawing.Color.White
			Me.Label13.Location = New Global.System.Drawing.Point(19, 11)
			Me.Label13.Name = "Label13"
			Me.Label13.Size = New Global.System.Drawing.Size(132, 17)
			Me.Label13.TabIndex = 287
			Me.Label13.Text = "Recovery Passwords"
			Me.Guna2ResizeBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Guna2ResizeBox1.FillColor = Global.System.Drawing.Color.White
			Me.Guna2ResizeBox1.ForeColor = Global.System.Drawing.Color.Empty
			Me.Guna2ResizeBox1.Location = New Global.System.Drawing.Point(647, 414)
			Me.Guna2ResizeBox1.Name = "Guna2ResizeBox1"
			Me.Guna2ResizeBox1.Size = New Global.System.Drawing.Size(17, 19)
			Me.Guna2ResizeBox1.TabIndex = 289
			Me.Guna2ResizeBox1.TargetControl = Me
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
			Me.Mini.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Mini.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Mini.Location = New Global.System.Drawing.Point(590, 12)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 563
			Me.Mini.Text = "ValleyMini1"
			Me.MAX.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.MAX.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.MAX.Location = New Global.System.Drawing.Point(616, 12)
			Me.MAX.Name = "MAX"
			Me.MAX.Size = New Global.System.Drawing.Size(20, 20)
			Me.MAX.TabIndex = 562
			Me.MAX.Text = "ValleyMax1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(642, 12)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 561
			Me.ExitForm.Text = "ValleyClose1"
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(96F, 96F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Dpi
			Me.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			MyBase.ClientSize = New Global.System.Drawing.Size(674, 444)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.MAX)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.Guna2ResizeBox1)
			MyBase.Controls.Add(Me.ClientInfo)
			MyBase.Controls.Add(Me.Label13)
			MyBase.Controls.Add(Me.ListPassword)
			Me.ForeColor = Global.System.Drawing.Color.FromArgb(79, 46, 208)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "FormPasswordView"
			MyBase.TopMost = True
			CType(Me.ListPassword, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ControllContextMenuStrip.ResumeLayout(False)
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0400064D RID: 1613
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
