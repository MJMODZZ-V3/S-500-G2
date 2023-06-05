Namespace S500RAT
	' Token: 0x02000037 RID: 55
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormWiFi
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000F84 RID: 3972 RVA: 0x00087A04 File Offset: 0x00085C04
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

		' Token: 0x06000F85 RID: 3973 RVA: 0x00087A54 File Offset: 0x00085C54
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormWiFi))
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle3 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.ControllContextMenuStrip = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.RefreshList = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ImageList1 = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.UiLabel1 = New Global.Sunny.UI.UILabel()
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.ListWifi = New Global.Guna.UI2.WinForms.Guna2DataGridView()
			Me.WifiNum = New Global.System.Windows.Forms.Label()
			Me.Guna2ResizeBox1 = New Global.Guna.UI2.WinForms.Guna2ResizeBox()
			Me.Guna2Elipse2 = New Global.Guna.UI2.WinForms.Guna2Elipse(Me.components)
			Me.Guna2Elipse1 = New Global.Guna.UI2.WinForms.Guna2Elipse(Me.components)
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.MAX = New Global.S500RAT.ValleyMax()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			Me.ToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewImageColumn()
			Me.Column4 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column5 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.ControllContextMenuStrip.SuspendLayout()
			CType(Me.ListWifi, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.Timer1.Interval = 2000
			Me.ControllContextMenuStrip.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ControllContextMenuStrip.ImageScalingSize = New Global.System.Drawing.Size(20, 20)
			Me.ControllContextMenuStrip.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.RefreshList, Me.ToolStripMenuItem1 })
			Me.ControllContextMenuStrip.Name = "ContextMenuStrip1"
			Me.ControllContextMenuStrip.Size = New Global.System.Drawing.Size(162, 48)
			Me.RefreshList.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.RefreshList.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.RefreshList.Name = "RefreshList"
			Me.RefreshList.Size = New Global.System.Drawing.Size(161, 22)
			Me.RefreshList.Text = "Refresh"
			Me.ImageList1.ImageStream = CType(componentResourceManager.GetObject("ImageList1.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.ImageList1.TransparentColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.ImageList1.Images.SetKeyName(0, "False.png")
			Me.ImageList1.Images.SetKeyName(1, "True.png")
			Me.UiLabel1.AutoSize = True
			Me.UiLabel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel1.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel1.Location = New Global.System.Drawing.Point(20, 15)
			Me.UiLabel1.Name = "UiLabel1"
			Me.UiLabel1.Size = New Global.System.Drawing.Size(38, 19)
			Me.UiLabel1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLabel1.TabIndex = 324
			Me.UiLabel1.Text = "WiFi"
			Me.UiLabel1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(21, 39)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(200, 16)
			Me.ClientInfo.TabIndex = 325
			Me.ClientInfo.Text = "FC / Desktop_3424 / Windows 10 pro"
			Me.ListWifi.AllowUserToAddRows = False
			Me.ListWifi.AllowUserToDeleteRows = False
			Me.ListWifi.AllowUserToResizeColumns = False
			Me.ListWifi.AllowUserToResizeRows = False
			dataGridViewCellStyle.BackColor = Global.System.Drawing.Color.FromArgb(209, 196, 233)
			Me.ListWifi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
			Me.ListWifi.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ListWifi.AutoSizeColumnsMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
			Me.ListWifi.BackgroundColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ListWifi.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.ListWifi.CellBorderStyle = Global.System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
			Me.ListWifi.ColumnHeadersBorderStyle = Global.System.Windows.Forms.DataGridViewHeaderBorderStyle.None
			dataGridViewCellStyle2.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle2.BackColor = Global.System.Drawing.Color.FromArgb(103, 58, 183)
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle2.ForeColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle2.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle2.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle2.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.ListWifi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
			Me.ListWifi.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.ListWifi.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column3, Me.Column4, Me.Column5 })
			Me.ListWifi.ContextMenuStrip = Me.ControllContextMenuStrip
			dataGridViewCellStyle3.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle3.BackColor = Global.System.Drawing.Color.FromArgb(224, 215, 240)
			dataGridViewCellStyle3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle3.ForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle3.SelectionBackColor = Global.System.Drawing.Color.FromArgb(153, 123, 207)
			dataGridViewCellStyle3.SelectionForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle3.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[False]
			Me.ListWifi.DefaultCellStyle = dataGridViewCellStyle3
			Me.ListWifi.EnableHeadersVisualStyles = False
			Me.ListWifi.GridColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ListWifi.Location = New Global.System.Drawing.Point(12, 80)
			Me.ListWifi.MultiSelect = False
			Me.ListWifi.Name = "ListWifi"
			Me.ListWifi.[ReadOnly] = True
			Me.ListWifi.RowHeadersVisible = False
			Me.ListWifi.RowHeadersWidth = 20
			Me.ListWifi.RowHeadersWidthSizeMode = Global.System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
			Me.ListWifi.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			Me.ListWifi.ShowCellErrors = False
			Me.ListWifi.ShowEditingIcon = False
			Me.ListWifi.ShowRowErrors = False
			Me.ListWifi.Size = New Global.System.Drawing.Size(488, 278)
			Me.ListWifi.TabIndex = 509
			Me.ListWifi.Theme = Global.Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.DeepPurple
			Me.ListWifi.ThemeStyle.AlternatingRowsStyle.BackColor = Global.System.Drawing.Color.FromArgb(209, 196, 233)
			Me.ListWifi.ThemeStyle.AlternatingRowsStyle.Font = Nothing
			Me.ListWifi.ThemeStyle.AlternatingRowsStyle.ForeColor = Global.System.Drawing.Color.Empty
			Me.ListWifi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Global.System.Drawing.Color.Empty
			Me.ListWifi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Global.System.Drawing.Color.Empty
			Me.ListWifi.ThemeStyle.BackColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ListWifi.ThemeStyle.GridColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ListWifi.ThemeStyle.HeaderStyle.BackColor = Global.System.Drawing.Color.FromArgb(103, 58, 183)
			Me.ListWifi.ThemeStyle.HeaderStyle.BorderStyle = Global.System.Windows.Forms.DataGridViewHeaderBorderStyle.None
			Me.ListWifi.ThemeStyle.HeaderStyle.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ListWifi.ThemeStyle.HeaderStyle.ForeColor = Global.System.Drawing.Color.White
			Me.ListWifi.ThemeStyle.HeaderStyle.HeaightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.ListWifi.ThemeStyle.HeaderStyle.Height = 23
			Me.ListWifi.ThemeStyle.[ReadOnly] = True
			Me.ListWifi.ThemeStyle.RowsStyle.BackColor = Global.System.Drawing.Color.FromArgb(224, 215, 240)
			Me.ListWifi.ThemeStyle.RowsStyle.BorderStyle = Global.System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
			Me.ListWifi.ThemeStyle.RowsStyle.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ListWifi.ThemeStyle.RowsStyle.ForeColor = Global.System.Drawing.Color.Black
			Me.ListWifi.ThemeStyle.RowsStyle.Height = 22
			Me.ListWifi.ThemeStyle.RowsStyle.SelectionBackColor = Global.System.Drawing.Color.FromArgb(153, 123, 207)
			Me.ListWifi.ThemeStyle.RowsStyle.SelectionForeColor = Global.System.Drawing.Color.Black
			Me.WifiNum.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.WifiNum.AutoSize = True
			Me.WifiNum.BackColor = Global.System.Drawing.Color.Transparent
			Me.WifiNum.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.WifiNum.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.WifiNum.Location = New Global.System.Drawing.Point(9, 364)
			Me.WifiNum.Name = "WifiNum"
			Me.WifiNum.Size = New Global.System.Drawing.Size(50, 14)
			Me.WifiNum.TabIndex = 508
			Me.WifiNum.Text = "Wifi [ 0 ]"
			Me.Guna2ResizeBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Guna2ResizeBox1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Guna2ResizeBox1.FillColor = Global.System.Drawing.Color.Silver
			Me.Guna2ResizeBox1.ForeColor = Global.System.Drawing.Color.Empty
			Me.Guna2ResizeBox1.Location = New Global.System.Drawing.Point(485, 364)
			Me.Guna2ResizeBox1.Name = "Guna2ResizeBox1"
			Me.Guna2ResizeBox1.Size = New Global.System.Drawing.Size(17, 19)
			Me.Guna2ResizeBox1.TabIndex = 507
			Me.Guna2ResizeBox1.TargetControl = Me
			Me.Guna2ResizeBox1.UseTransparentBackground = True
			Me.Guna2Elipse2.BorderRadius = 20
			Me.Guna2Elipse1.BorderRadius = 20
			Me.Guna2Elipse1.TargetControl = Me.ListWifi
			Me.Mini.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Mini.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Mini.Location = New Global.System.Drawing.Point(428, 12)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 578
			Me.Mini.Text = "ValleyMini1"
			Me.MAX.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.MAX.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.MAX.Location = New Global.System.Drawing.Point(454, 12)
			Me.MAX.Name = "MAX"
			Me.MAX.Size = New Global.System.Drawing.Size(20, 20)
			Me.MAX.TabIndex = 577
			Me.MAX.Text = "ValleyMax1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(480, 12)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 576
			Me.ExitForm.Text = "ValleyClose1"
			Me.ToolStripMenuItem1.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.ToolStripMenuItem1.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
			Me.ToolStripMenuItem1.Size = New Global.System.Drawing.Size(161, 22)
			Me.ToolStripMenuItem1.Text = "Copy Password"
			Me.Column3.AutoSizeMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
			Me.Column3.HeaderText = "         "
			Me.Column3.ImageLayout = Global.System.Windows.Forms.DataGridViewImageCellLayout.Zoom
			Me.Column3.Name = "Column3"
			Me.Column3.[ReadOnly] = True
			Me.Column3.Width = 38
			Me.Column4.AutoSizeMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
			Me.Column4.HeaderText = "Name"
			Me.Column4.Name = "Column4"
			Me.Column4.[ReadOnly] = True
			Me.Column4.Width = 58
			Me.Column5.AutoSizeMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
			Me.Column5.HeaderText = "Password"
			Me.Column5.Name = "Column5"
			Me.Column5.[ReadOnly] = True
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
			MyBase.ClientSize = New Global.System.Drawing.Size(512, 394)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.MAX)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.WifiNum)
			MyBase.Controls.Add(Me.ListWifi)
			MyBase.Controls.Add(Me.Guna2ResizeBox1)
			MyBase.Controls.Add(Me.UiLabel1)
			MyBase.Controls.Add(Me.ClientInfo)
			Me.DoubleBuffered = True
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "FormWiFi"
			Me.Text = "FormWiFi"
			MyBase.TopMost = True
			Me.ControllContextMenuStrip.ResumeLayout(False)
			CType(Me.ListWifi, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x040006F5 RID: 1781
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
