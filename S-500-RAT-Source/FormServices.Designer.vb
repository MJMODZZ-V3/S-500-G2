Namespace S500RAT
	' Token: 0x02000033 RID: 51
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormServices
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000E97 RID: 3735 RVA: 0x00081698 File Offset: 0x0007F898
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

		' Token: 0x06000E98 RID: 3736 RVA: 0x000816E8 File Offset: 0x0007F8E8
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormServices))
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle3 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.ControllContextMenuStrip = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.RefreshList = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.StopServices = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.UnstallSoftware = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ImageList1 = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.UiLabel1 = New Global.Sunny.UI.UILabel()
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.ServicesNum = New Global.System.Windows.Forms.Label()
			Me.Guna2ResizeBox1 = New Global.Guna.UI2.WinForms.Guna2ResizeBox()
			Me.ListServices = New Global.Guna.UI2.WinForms.Guna2DataGridView()
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.MAX = New Global.S500RAT.ValleyMax()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewImageColumn()
			Me.Column4 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column5 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column6 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.ControllContextMenuStrip.SuspendLayout()
			CType(Me.ListServices, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.Timer1.Interval = 2000
			Me.ControllContextMenuStrip.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ControllContextMenuStrip.ImageScalingSize = New Global.System.Drawing.Size(20, 20)
			Me.ControllContextMenuStrip.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.RefreshList, Me.StopServices, Me.UnstallSoftware })
			Me.ControllContextMenuStrip.Name = "ContextMenuStrip1"
			Me.ControllContextMenuStrip.Size = New Global.System.Drawing.Size(123, 82)
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
			Me.StopServices.Text = "Stop"
			Me.UnstallSoftware.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.UnstallSoftware.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.UnstallSoftware.Image = CType(componentResourceManager.GetObject("UnstallSoftware.Image"), Global.System.Drawing.Image)
			Me.UnstallSoftware.Name = "UnstallSoftware"
			Me.UnstallSoftware.Size = New Global.System.Drawing.Size(122, 26)
			Me.UnstallSoftware.Text = "Start"
			Me.ImageList1.ImageStream = CType(componentResourceManager.GetObject("ImageList1.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.ImageList1.TransparentColor = Global.System.Drawing.Color.Transparent
			Me.ImageList1.Images.SetKeyName(0, "False.png")
			Me.ImageList1.Images.SetKeyName(1, "True.png")
			Me.UiLabel1.AutoSize = True
			Me.UiLabel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel1.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel1.Location = New Global.System.Drawing.Point(18, 8)
			Me.UiLabel1.Name = "UiLabel1"
			Me.UiLabel1.Size = New Global.System.Drawing.Size(64, 19)
			Me.UiLabel1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLabel1.TabIndex = 319
			Me.UiLabel1.Text = "Services"
			Me.UiLabel1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(19, 32)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(200, 16)
			Me.ClientInfo.TabIndex = 320
			Me.ClientInfo.Text = "FC / Desktop_3424 / Windows 10 pro"
			Me.ServicesNum.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.ServicesNum.AutoSize = True
			Me.ServicesNum.BackColor = Global.System.Drawing.Color.Transparent
			Me.ServicesNum.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ServicesNum.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ServicesNum.Location = New Global.System.Drawing.Point(9, 507)
			Me.ServicesNum.Name = "ServicesNum"
			Me.ServicesNum.Size = New Global.System.Drawing.Size(78, 14)
			Me.ServicesNum.TabIndex = 505
			Me.ServicesNum.Text = "Services [ 0 ]"
			Me.Guna2ResizeBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Guna2ResizeBox1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Guna2ResizeBox1.FillColor = Global.System.Drawing.Color.Silver
			Me.Guna2ResizeBox1.ForeColor = Global.System.Drawing.Color.Empty
			Me.Guna2ResizeBox1.Location = New Global.System.Drawing.Point(616, 502)
			Me.Guna2ResizeBox1.Name = "Guna2ResizeBox1"
			Me.Guna2ResizeBox1.Size = New Global.System.Drawing.Size(17, 19)
			Me.Guna2ResizeBox1.TabIndex = 504
			Me.Guna2ResizeBox1.TargetControl = Me
			Me.Guna2ResizeBox1.UseTransparentBackground = True
			Me.ListServices.AllowUserToAddRows = False
			Me.ListServices.AllowUserToDeleteRows = False
			Me.ListServices.AllowUserToResizeColumns = False
			Me.ListServices.AllowUserToResizeRows = False
			dataGridViewCellStyle.BackColor = Global.System.Drawing.Color.FromArgb(209, 196, 233)
			Me.ListServices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
			Me.ListServices.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ListServices.AutoSizeColumnsMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
			Me.ListServices.BackgroundColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ListServices.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.ListServices.CellBorderStyle = Global.System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
			Me.ListServices.ColumnHeadersBorderStyle = Global.System.Windows.Forms.DataGridViewHeaderBorderStyle.None
			dataGridViewCellStyle2.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle2.BackColor = Global.System.Drawing.Color.FromArgb(103, 58, 183)
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle2.ForeColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle2.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle2.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle2.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.ListServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
			Me.ListServices.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.ListServices.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column1 })
			Me.ListServices.ContextMenuStrip = Me.ControllContextMenuStrip
			dataGridViewCellStyle3.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle3.BackColor = Global.System.Drawing.Color.FromArgb(224, 215, 240)
			dataGridViewCellStyle3.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle3.ForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle3.SelectionBackColor = Global.System.Drawing.Color.FromArgb(153, 123, 207)
			dataGridViewCellStyle3.SelectionForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle3.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[False]
			Me.ListServices.DefaultCellStyle = dataGridViewCellStyle3
			Me.ListServices.EnableHeadersVisualStyles = False
			Me.ListServices.GridColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ListServices.Location = New Global.System.Drawing.Point(12, 81)
			Me.ListServices.MultiSelect = False
			Me.ListServices.Name = "ListServices"
			Me.ListServices.[ReadOnly] = True
			Me.ListServices.RowHeadersVisible = False
			Me.ListServices.RowHeadersWidth = 20
			Me.ListServices.RowHeadersWidthSizeMode = Global.System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
			Me.ListServices.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			Me.ListServices.ShowCellErrors = False
			Me.ListServices.ShowEditingIcon = False
			Me.ListServices.ShowRowErrors = False
			Me.ListServices.Size = New Global.System.Drawing.Size(620, 415)
			Me.ListServices.TabIndex = 506
			Me.ListServices.Theme = Global.Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.DeepPurple
			Me.ListServices.ThemeStyle.AlternatingRowsStyle.BackColor = Global.System.Drawing.Color.FromArgb(209, 196, 233)
			Me.ListServices.ThemeStyle.AlternatingRowsStyle.Font = Nothing
			Me.ListServices.ThemeStyle.AlternatingRowsStyle.ForeColor = Global.System.Drawing.Color.Empty
			Me.ListServices.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Global.System.Drawing.Color.Empty
			Me.ListServices.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Global.System.Drawing.Color.Empty
			Me.ListServices.ThemeStyle.BackColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ListServices.ThemeStyle.GridColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ListServices.ThemeStyle.HeaderStyle.BackColor = Global.System.Drawing.Color.FromArgb(103, 58, 183)
			Me.ListServices.ThemeStyle.HeaderStyle.BorderStyle = Global.System.Windows.Forms.DataGridViewHeaderBorderStyle.None
			Me.ListServices.ThemeStyle.HeaderStyle.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ListServices.ThemeStyle.HeaderStyle.ForeColor = Global.System.Drawing.Color.White
			Me.ListServices.ThemeStyle.HeaderStyle.HeaightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.ListServices.ThemeStyle.HeaderStyle.Height = 23
			Me.ListServices.ThemeStyle.[ReadOnly] = True
			Me.ListServices.ThemeStyle.RowsStyle.BackColor = Global.System.Drawing.Color.FromArgb(224, 215, 240)
			Me.ListServices.ThemeStyle.RowsStyle.BorderStyle = Global.System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
			Me.ListServices.ThemeStyle.RowsStyle.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ListServices.ThemeStyle.RowsStyle.ForeColor = Global.System.Drawing.Color.Black
			Me.ListServices.ThemeStyle.RowsStyle.Height = 22
			Me.ListServices.ThemeStyle.RowsStyle.SelectionBackColor = Global.System.Drawing.Color.FromArgb(153, 123, 207)
			Me.ListServices.ThemeStyle.RowsStyle.SelectionForeColor = Global.System.Drawing.Color.Black
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
			Me.Mini.Location = New Global.System.Drawing.Point(560, 12)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 572
			Me.Mini.Text = "ValleyMini1"
			Me.MAX.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.MAX.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.MAX.Location = New Global.System.Drawing.Point(586, 12)
			Me.MAX.Name = "MAX"
			Me.MAX.Size = New Global.System.Drawing.Size(20, 20)
			Me.MAX.TabIndex = 571
			Me.MAX.Text = "ValleyMax1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(612, 12)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 570
			Me.ExitForm.Text = "ValleyClose1"
			Me.Column3.HeaderText = "         "
			Me.Column3.ImageLayout = Global.System.Windows.Forms.DataGridViewImageCellLayout.Zoom
			Me.Column3.Name = "Column3"
			Me.Column3.[ReadOnly] = True
			Me.Column3.Width = 38
			Me.Column4.HeaderText = "Services"
			Me.Column4.Name = "Column4"
			Me.Column4.[ReadOnly] = True
			Me.Column4.Width = 78
			Me.Column5.HeaderText = "Name"
			Me.Column5.Name = "Column5"
			Me.Column5.[ReadOnly] = True
			Me.Column5.Width = 61
			Me.Column6.AutoSizeMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
			Me.Column6.HeaderText = "Type"
			Me.Column6.Name = "Column6"
			Me.Column6.[ReadOnly] = True
			Me.Column6.Width = 56
			Me.Column1.AutoSizeMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
			Me.Column1.HeaderText = "Status"
			Me.Column1.Name = "Column1"
			Me.Column1.[ReadOnly] = True
			Me.Column1.Width = 65
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(96F, 96F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Dpi
			Me.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			MyBase.ClientSize = New Global.System.Drawing.Size(644, 532)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.MAX)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.ListServices)
			MyBase.Controls.Add(Me.ServicesNum)
			MyBase.Controls.Add(Me.Guna2ResizeBox1)
			MyBase.Controls.Add(Me.UiLabel1)
			MyBase.Controls.Add(Me.ClientInfo)
			Me.DoubleBuffered = True
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "FormServices"
			Me.Text = "FormServices"
			MyBase.TopMost = True
			Me.ControllContextMenuStrip.ResumeLayout(False)
			CType(Me.ListServices, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0400068B RID: 1675
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
