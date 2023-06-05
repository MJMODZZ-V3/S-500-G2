Namespace S500RAT
	' Token: 0x02000021 RID: 33
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormInstalledSoftware
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060005A4 RID: 1444 RVA: 0x000308F4 File Offset: 0x0002EAF4
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

		' Token: 0x060005A5 RID: 1445 RVA: 0x00030944 File Offset: 0x0002EB44
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormInstalledSoftware))
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle3 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.ImageList1 = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Guna2Elipse1 = New Global.Guna.UI2.WinForms.Guna2Elipse(Me.components)
			Me.ListInstalledSoftware = New Global.Guna.UI2.WinForms.Guna2DataGridView()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewImageColumn()
			Me.Column4 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.ControllContextMenuStrip = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.RefreshList = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.StopServices = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.UiLabel1 = New Global.Sunny.UI.UILabel()
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.Guna2ResizeBox1 = New Global.Guna.UI2.WinForms.Guna2ResizeBox()
			Me.SoftwareNum = New Global.System.Windows.Forms.Label()
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.MAX = New Global.S500RAT.ValleyMax()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			CType(Me.ListInstalledSoftware, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.ControllContextMenuStrip.SuspendLayout()
			MyBase.SuspendLayout()
			Me.ImageList1.ImageStream = CType(componentResourceManager.GetObject("ImageList1.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.ImageList1.TransparentColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.ImageList1.Images.SetKeyName(0, "B.png")
			Me.Timer1.Interval = 2000
			Me.Guna2Elipse1.BorderRadius = 20
			Me.Guna2Elipse1.TargetControl = Me.ListInstalledSoftware
			Me.ListInstalledSoftware.AllowUserToAddRows = False
			Me.ListInstalledSoftware.AllowUserToDeleteRows = False
			Me.ListInstalledSoftware.AllowUserToResizeColumns = False
			Me.ListInstalledSoftware.AllowUserToResizeRows = False
			dataGridViewCellStyle.BackColor = Global.System.Drawing.Color.FromArgb(209, 196, 233)
			Me.ListInstalledSoftware.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
			Me.ListInstalledSoftware.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ListInstalledSoftware.AutoSizeColumnsMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
			Me.ListInstalledSoftware.BackgroundColor = Global.System.Drawing.Color.FromArgb(7, 11, 48)
			Me.ListInstalledSoftware.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.ListInstalledSoftware.CellBorderStyle = Global.System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
			Me.ListInstalledSoftware.ColumnHeadersBorderStyle = Global.System.Windows.Forms.DataGridViewHeaderBorderStyle.None
			dataGridViewCellStyle2.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle2.BackColor = Global.System.Drawing.Color.FromArgb(103, 58, 183)
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle2.ForeColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle2.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle2.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle2.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.ListInstalledSoftware.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
			Me.ListInstalledSoftware.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.ListInstalledSoftware.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column3, Me.Column4 })
			Me.ListInstalledSoftware.ContextMenuStrip = Me.ControllContextMenuStrip
			dataGridViewCellStyle3.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle3.BackColor = Global.System.Drawing.Color.FromArgb(224, 215, 240)
			dataGridViewCellStyle3.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle3.ForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle3.SelectionBackColor = Global.System.Drawing.Color.FromArgb(153, 123, 207)
			dataGridViewCellStyle3.SelectionForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle3.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[False]
			Me.ListInstalledSoftware.DefaultCellStyle = dataGridViewCellStyle3
			Me.ListInstalledSoftware.EnableHeadersVisualStyles = False
			Me.ListInstalledSoftware.GridColor = Global.System.Drawing.Color.FromArgb(79, 46, 208)
			Me.ListInstalledSoftware.Location = New Global.System.Drawing.Point(20, 81)
			Me.ListInstalledSoftware.MultiSelect = False
			Me.ListInstalledSoftware.Name = "ListInstalledSoftware"
			Me.ListInstalledSoftware.[ReadOnly] = True
			Me.ListInstalledSoftware.RowHeadersVisible = False
			Me.ListInstalledSoftware.RowHeadersWidth = 20
			Me.ListInstalledSoftware.RowHeadersWidthSizeMode = Global.System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
			Me.ListInstalledSoftware.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			Me.ListInstalledSoftware.ShowCellErrors = False
			Me.ListInstalledSoftware.ShowEditingIcon = False
			Me.ListInstalledSoftware.ShowRowErrors = False
			Me.ListInstalledSoftware.Size = New Global.System.Drawing.Size(534, 352)
			Me.ListInstalledSoftware.TabIndex = 510
			Me.ListInstalledSoftware.Theme = Global.Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.DeepPurple
			Me.ListInstalledSoftware.ThemeStyle.AlternatingRowsStyle.BackColor = Global.System.Drawing.Color.FromArgb(209, 196, 233)
			Me.ListInstalledSoftware.ThemeStyle.AlternatingRowsStyle.Font = Nothing
			Me.ListInstalledSoftware.ThemeStyle.AlternatingRowsStyle.ForeColor = Global.System.Drawing.Color.Empty
			Me.ListInstalledSoftware.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Global.System.Drawing.Color.Empty
			Me.ListInstalledSoftware.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Global.System.Drawing.Color.Empty
			Me.ListInstalledSoftware.ThemeStyle.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 48)
			Me.ListInstalledSoftware.ThemeStyle.GridColor = Global.System.Drawing.Color.FromArgb(79, 46, 208)
			Me.ListInstalledSoftware.ThemeStyle.HeaderStyle.BackColor = Global.System.Drawing.Color.FromArgb(103, 58, 183)
			Me.ListInstalledSoftware.ThemeStyle.HeaderStyle.BorderStyle = Global.System.Windows.Forms.DataGridViewHeaderBorderStyle.None
			Me.ListInstalledSoftware.ThemeStyle.HeaderStyle.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ListInstalledSoftware.ThemeStyle.HeaderStyle.ForeColor = Global.System.Drawing.Color.White
			Me.ListInstalledSoftware.ThemeStyle.HeaderStyle.HeaightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.ListInstalledSoftware.ThemeStyle.HeaderStyle.Height = 23
			Me.ListInstalledSoftware.ThemeStyle.[ReadOnly] = True
			Me.ListInstalledSoftware.ThemeStyle.RowsStyle.BackColor = Global.System.Drawing.Color.FromArgb(224, 215, 240)
			Me.ListInstalledSoftware.ThemeStyle.RowsStyle.BorderStyle = Global.System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
			Me.ListInstalledSoftware.ThemeStyle.RowsStyle.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ListInstalledSoftware.ThemeStyle.RowsStyle.ForeColor = Global.System.Drawing.Color.Black
			Me.ListInstalledSoftware.ThemeStyle.RowsStyle.Height = 22
			Me.ListInstalledSoftware.ThemeStyle.RowsStyle.SelectionBackColor = Global.System.Drawing.Color.FromArgb(153, 123, 207)
			Me.ListInstalledSoftware.ThemeStyle.RowsStyle.SelectionForeColor = Global.System.Drawing.Color.Black
			Me.Column3.HeaderText = "         "
			Me.Column3.ImageLayout = Global.System.Windows.Forms.DataGridViewImageCellLayout.Zoom
			Me.Column3.Name = "Column3"
			Me.Column3.[ReadOnly] = True
			Me.Column3.Width = 38
			Me.Column4.AutoSizeMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
			Me.Column4.HeaderText = "Name"
			Me.Column4.Name = "Column4"
			Me.Column4.[ReadOnly] = True
			Me.ControllContextMenuStrip.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ControllContextMenuStrip.ImageScalingSize = New Global.System.Drawing.Size(20, 20)
			Me.ControllContextMenuStrip.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.RefreshList, Me.StopServices })
			Me.ControllContextMenuStrip.Name = "ContextMenuStrip1"
			Me.ControllContextMenuStrip.Size = New Global.System.Drawing.Size(123, 56)
			Me.RefreshList.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.RefreshList.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.RefreshList.Image = CType(componentResourceManager.GetObject("RefreshList.Image"), Global.System.Drawing.Image)
			Me.RefreshList.Name = "RefreshList"
			Me.RefreshList.Size = New Global.System.Drawing.Size(122, 26)
			Me.RefreshList.Text = "Refresh"
			Me.StopServices.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.StopServices.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.StopServices.Image = CType(componentResourceManager.GetObject("StopServices.Image"), Global.System.Drawing.Image)
			Me.StopServices.Name = "StopServices"
			Me.StopServices.Size = New Global.System.Drawing.Size(122, 26)
			Me.StopServices.Text = "Unstall"
			Me.UiLabel1.AutoSize = True
			Me.UiLabel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel1.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel1.Location = New Global.System.Drawing.Point(18, 15)
			Me.UiLabel1.Name = "UiLabel1"
			Me.UiLabel1.Size = New Global.System.Drawing.Size(129, 19)
			Me.UiLabel1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLabel1.TabIndex = 329
			Me.UiLabel1.Text = "Installed Software"
			Me.UiLabel1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(19, 39)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(200, 16)
			Me.ClientInfo.TabIndex = 330
			Me.ClientInfo.Text = "FC / Desktop_3424 / Windows 10 pro"
			Me.Guna2ResizeBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Guna2ResizeBox1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Guna2ResizeBox1.FillColor = Global.System.Drawing.Color.Silver
			Me.Guna2ResizeBox1.ForeColor = Global.System.Drawing.Color.Empty
			Me.Guna2ResizeBox1.Location = New Global.System.Drawing.Point(549, 438)
			Me.Guna2ResizeBox1.Name = "Guna2ResizeBox1"
			Me.Guna2ResizeBox1.Size = New Global.System.Drawing.Size(17, 19)
			Me.Guna2ResizeBox1.TabIndex = 508
			Me.Guna2ResizeBox1.TargetControl = Me
			Me.Guna2ResizeBox1.UseTransparentBackground = True
			Me.SoftwareNum.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.SoftwareNum.AutoSize = True
			Me.SoftwareNum.BackColor = Global.System.Drawing.Color.Transparent
			Me.SoftwareNum.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.SoftwareNum.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.SoftwareNum.Location = New Global.System.Drawing.Point(19, 441)
			Me.SoftwareNum.Name = "SoftwareNum"
			Me.SoftwareNum.Size = New Global.System.Drawing.Size(137, 14)
			Me.SoftwareNum.TabIndex = 511
			Me.SoftwareNum.Text = "Installed Softwares [ 0 ]"
			Me.Mini.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Mini.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Mini.Location = New Global.System.Drawing.Point(500, 12)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 592
			Me.Mini.Text = "ValleyMini1"
			Me.MAX.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.MAX.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.MAX.Location = New Global.System.Drawing.Point(522, 12)
			Me.MAX.Name = "MAX"
			Me.MAX.Size = New Global.System.Drawing.Size(20, 20)
			Me.MAX.TabIndex = 591
			Me.MAX.Text = "ValleyMax1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(544, 12)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 590
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
			MyBase.ClientSize = New Global.System.Drawing.Size(576, 468)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.MAX)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.SoftwareNum)
			MyBase.Controls.Add(Me.ListInstalledSoftware)
			MyBase.Controls.Add(Me.Guna2ResizeBox1)
			MyBase.Controls.Add(Me.UiLabel1)
			MyBase.Controls.Add(Me.ClientInfo)
			Me.DoubleBuffered = True
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "FormInstalledSoftware"
			Me.Text = "FormInstalledSoftware"
			MyBase.TopMost = True
			CType(Me.ListInstalledSoftware, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ControllContextMenuStrip.ResumeLayout(False)
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0400028F RID: 655
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
