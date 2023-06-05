Namespace S500RAT
	' Token: 0x02000036 RID: 54
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormTCPConnection
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000F46 RID: 3910 RVA: 0x00086028 File Offset: 0x00084228
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

		' Token: 0x06000F47 RID: 3911 RVA: 0x00086078 File Offset: 0x00084278
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormTCPConnection))
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle3 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.ControllContextMenuStrip = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.RefreshList = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.KillProcess = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.UiLabel1 = New Global.Sunny.UI.UILabel()
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.Guna2ResizeBox1 = New Global.Guna.UI2.WinForms.Guna2ResizeBox()
			Me.ConnectionNum = New Global.System.Windows.Forms.Label()
			Me.ListConnection = New Global.Guna.UI2.WinForms.Guna2DataGridView()
			Me.ImageList1 = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.Timer2 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.MAX = New Global.S500RAT.ValleyMax()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewImageColumn()
			Me.Column4 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column5 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column6 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.ControllContextMenuStrip.SuspendLayout()
			CType(Me.ListConnection, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.Timer1.Interval = 2000
			Me.ControllContextMenuStrip.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ControllContextMenuStrip.ImageScalingSize = New Global.System.Drawing.Size(20, 20)
			Me.ControllContextMenuStrip.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.RefreshList, Me.KillProcess })
			Me.ControllContextMenuStrip.Name = "ContextMenuStrip1"
			Me.ControllContextMenuStrip.Size = New Global.System.Drawing.Size(123, 56)
			Me.RefreshList.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.RefreshList.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.RefreshList.Image = CType(componentResourceManager.GetObject("RefreshList.Image"), Global.System.Drawing.Image)
			Me.RefreshList.Name = "RefreshList"
			Me.RefreshList.Size = New Global.System.Drawing.Size(122, 26)
			Me.RefreshList.Text = "Refresh"
			Me.KillProcess.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.KillProcess.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.KillProcess.Image = CType(componentResourceManager.GetObject("KillProcess.Image"), Global.System.Drawing.Image)
			Me.KillProcess.Name = "KillProcess"
			Me.KillProcess.Size = New Global.System.Drawing.Size(122, 26)
			Me.KillProcess.Text = "Kill"
			Me.UiLabel1.AutoSize = True
			Me.UiLabel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel1.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel1.Location = New Global.System.Drawing.Point(18, 8)
			Me.UiLabel1.Name = "UiLabel1"
			Me.UiLabel1.Size = New Global.System.Drawing.Size(67, 19)
			Me.UiLabel1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLabel1.TabIndex = 314
			Me.UiLabel1.Text = "Network"
			Me.UiLabel1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(19, 32)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(200, 16)
			Me.ClientInfo.TabIndex = 315
			Me.ClientInfo.Text = "FC / Desktop_3424 / Windows 10 pro"
			Me.Guna2ResizeBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Guna2ResizeBox1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Guna2ResizeBox1.FillColor = Global.System.Drawing.Color.Silver
			Me.Guna2ResizeBox1.ForeColor = Global.System.Drawing.Color.Empty
			Me.Guna2ResizeBox1.Location = New Global.System.Drawing.Point(579, 490)
			Me.Guna2ResizeBox1.Name = "Guna2ResizeBox1"
			Me.Guna2ResizeBox1.Size = New Global.System.Drawing.Size(17, 19)
			Me.Guna2ResizeBox1.TabIndex = 501
			Me.Guna2ResizeBox1.TargetControl = Me
			Me.Guna2ResizeBox1.UseTransparentBackground = True
			Me.ConnectionNum.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.ConnectionNum.AutoSize = True
			Me.ConnectionNum.BackColor = Global.System.Drawing.Color.Transparent
			Me.ConnectionNum.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ConnectionNum.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ConnectionNum.Location = New Global.System.Drawing.Point(9, 490)
			Me.ConnectionNum.Name = "ConnectionNum"
			Me.ConnectionNum.Size = New Global.System.Drawing.Size(93, 14)
			Me.ConnectionNum.TabIndex = 503
			Me.ConnectionNum.Text = "Connection [ 0 ]"
			Me.ListConnection.AllowUserToAddRows = False
			Me.ListConnection.AllowUserToDeleteRows = False
			Me.ListConnection.AllowUserToResizeColumns = False
			Me.ListConnection.AllowUserToResizeRows = False
			dataGridViewCellStyle.BackColor = Global.System.Drawing.Color.FromArgb(209, 196, 233)
			Me.ListConnection.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
			Me.ListConnection.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ListConnection.AutoSizeColumnsMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
			Me.ListConnection.BackgroundColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ListConnection.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.ListConnection.CellBorderStyle = Global.System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
			Me.ListConnection.ColumnHeadersBorderStyle = Global.System.Windows.Forms.DataGridViewHeaderBorderStyle.None
			dataGridViewCellStyle2.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle2.BackColor = Global.System.Drawing.Color.FromArgb(103, 58, 183)
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle2.ForeColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle2.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle2.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle2.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.ListConnection.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
			Me.ListConnection.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.ListConnection.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column3, Me.Column4, Me.Column2, Me.Column5, Me.Column6, Me.Column1 })
			Me.ListConnection.ContextMenuStrip = Me.ControllContextMenuStrip
			dataGridViewCellStyle3.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle3.BackColor = Global.System.Drawing.Color.FromArgb(224, 215, 240)
			dataGridViewCellStyle3.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle3.ForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle3.SelectionBackColor = Global.System.Drawing.Color.FromArgb(153, 123, 207)
			dataGridViewCellStyle3.SelectionForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle3.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[False]
			Me.ListConnection.DefaultCellStyle = dataGridViewCellStyle3
			Me.ListConnection.EnableHeadersVisualStyles = False
			Me.ListConnection.GridColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ListConnection.Location = New Global.System.Drawing.Point(12, 75)
			Me.ListConnection.Name = "ListConnection"
			Me.ListConnection.[ReadOnly] = True
			Me.ListConnection.RowHeadersVisible = False
			Me.ListConnection.RowHeadersWidth = 20
			Me.ListConnection.RowHeadersWidthSizeMode = Global.System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
			Me.ListConnection.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			Me.ListConnection.ShowCellErrors = False
			Me.ListConnection.ShowEditingIcon = False
			Me.ListConnection.ShowRowErrors = False
			Me.ListConnection.Size = New Global.System.Drawing.Size(582, 403)
			Me.ListConnection.TabIndex = 505
			Me.ListConnection.Theme = Global.Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.DeepPurple
			Me.ListConnection.ThemeStyle.AlternatingRowsStyle.BackColor = Global.System.Drawing.Color.FromArgb(209, 196, 233)
			Me.ListConnection.ThemeStyle.AlternatingRowsStyle.Font = Nothing
			Me.ListConnection.ThemeStyle.AlternatingRowsStyle.ForeColor = Global.System.Drawing.Color.Empty
			Me.ListConnection.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Global.System.Drawing.Color.Empty
			Me.ListConnection.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Global.System.Drawing.Color.Empty
			Me.ListConnection.ThemeStyle.BackColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ListConnection.ThemeStyle.GridColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ListConnection.ThemeStyle.HeaderStyle.BackColor = Global.System.Drawing.Color.FromArgb(103, 58, 183)
			Me.ListConnection.ThemeStyle.HeaderStyle.BorderStyle = Global.System.Windows.Forms.DataGridViewHeaderBorderStyle.None
			Me.ListConnection.ThemeStyle.HeaderStyle.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ListConnection.ThemeStyle.HeaderStyle.ForeColor = Global.System.Drawing.Color.White
			Me.ListConnection.ThemeStyle.HeaderStyle.HeaightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.ListConnection.ThemeStyle.HeaderStyle.Height = 23
			Me.ListConnection.ThemeStyle.[ReadOnly] = True
			Me.ListConnection.ThemeStyle.RowsStyle.BackColor = Global.System.Drawing.Color.FromArgb(224, 215, 240)
			Me.ListConnection.ThemeStyle.RowsStyle.BorderStyle = Global.System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
			Me.ListConnection.ThemeStyle.RowsStyle.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ListConnection.ThemeStyle.RowsStyle.ForeColor = Global.System.Drawing.Color.Black
			Me.ListConnection.ThemeStyle.RowsStyle.Height = 22
			Me.ListConnection.ThemeStyle.RowsStyle.SelectionBackColor = Global.System.Drawing.Color.FromArgb(153, 123, 207)
			Me.ListConnection.ThemeStyle.RowsStyle.SelectionForeColor = Global.System.Drawing.Color.Black
			Me.ImageList1.ImageStream = CType(componentResourceManager.GetObject("ImageList1.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.ImageList1.TransparentColor = Global.System.Drawing.Color.Transparent
			Me.ImageList1.Images.SetKeyName(0, "Closed.png")
			Me.ImageList1.Images.SetKeyName(1, "Closeing.png")
			Me.ImageList1.Images.SetKeyName(2, "Established.png")
			Me.ImageList1.Images.SetKeyName(3, "Listen.png")
			Me.ImageList1.Images.SetKeyName(4, "Other.png")
			Me.ImageList1.Images.SetKeyName(5, "Received.png")
			Me.ImageList1.Images.SetKeyName(6, "Sent.png")
			Me.Timer2.Enabled = True
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
			Me.Mini.Location = New Global.System.Drawing.Point(522, 12)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 581
			Me.Mini.Text = "ValleyMini1"
			Me.MAX.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.MAX.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.MAX.Location = New Global.System.Drawing.Point(548, 12)
			Me.MAX.Name = "MAX"
			Me.MAX.Size = New Global.System.Drawing.Size(20, 20)
			Me.MAX.TabIndex = 580
			Me.MAX.Text = "ValleyMax1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(574, 12)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 579
			Me.ExitForm.Text = "ValleyClose1"
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
			Me.Column4.Width = 61
			Me.Column2.AutoSizeMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
			Me.Column2.HeaderText = "PID"
			Me.Column2.Name = "Column2"
			Me.Column2.[ReadOnly] = True
			Me.Column2.Width = 47
			Me.Column5.AutoSizeMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
			Me.Column5.HeaderText = "IP Address"
			Me.Column5.Name = "Column5"
			Me.Column5.[ReadOnly] = True
			Me.Column5.Width = 91
			Me.Column6.AutoSizeMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
			Me.Column6.HeaderText = "Remote Address"
			Me.Column6.Name = "Column6"
			Me.Column6.[ReadOnly] = True
			Me.Column6.Width = 124
			Me.Column1.AutoSizeMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
			Me.Column1.HeaderText = "State"
			Me.Column1.Name = "Column1"
			Me.Column1.[ReadOnly] = True
			Me.Column1.Width = 58
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(96F, 96F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Dpi
			Me.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			MyBase.ClientSize = New Global.System.Drawing.Size(606, 519)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.MAX)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.ListConnection)
			MyBase.Controls.Add(Me.ConnectionNum)
			MyBase.Controls.Add(Me.Guna2ResizeBox1)
			MyBase.Controls.Add(Me.UiLabel1)
			MyBase.Controls.Add(Me.ClientInfo)
			Me.DoubleBuffered = True
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "FormTCPConnection"
			Me.Text = "FormTCPConnection"
			MyBase.TopMost = True
			Me.ControllContextMenuStrip.ResumeLayout(False)
			CType(Me.ListConnection, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x040006D9 RID: 1753
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
