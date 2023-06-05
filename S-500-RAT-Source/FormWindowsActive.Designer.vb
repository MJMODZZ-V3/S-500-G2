Namespace S500RAT
	' Token: 0x02000039 RID: 57
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormWindowsActive
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000FEF RID: 4079 RVA: 0x0008A26C File Offset: 0x0008846C
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

		' Token: 0x06000FF0 RID: 4080 RVA: 0x0008A2BC File Offset: 0x000884BC
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormWindowsActive))
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle3 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.ImageList1 = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Guna2Elipse1 = New Global.Guna.UI2.WinForms.Guna2Elipse(Me.components)
			Me.ListWindowsActive = New Global.Guna.UI2.WinForms.Guna2DataGridView()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewImageColumn()
			Me.Column4 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.ControllContextMenuStrip = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.RefreshList = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.UiLabel1 = New Global.Sunny.UI.UILabel()
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.ActiveNum = New Global.System.Windows.Forms.Label()
			Me.Guna2ResizeBox1 = New Global.Guna.UI2.WinForms.Guna2ResizeBox()
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.MAX = New Global.S500RAT.ValleyMax()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			CType(Me.ListWindowsActive, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.ControllContextMenuStrip.SuspendLayout()
			MyBase.SuspendLayout()
			Me.ImageList1.ImageStream = CType(componentResourceManager.GetObject("ImageList1.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.ImageList1.TransparentColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.ImageList1.Images.SetKeyName(0, "A.png")
			Me.Timer1.Interval = 2000
			Me.Guna2Elipse1.BorderRadius = 20
			Me.Guna2Elipse1.TargetControl = Me.ListWindowsActive
			Me.ListWindowsActive.AllowUserToAddRows = False
			Me.ListWindowsActive.AllowUserToDeleteRows = False
			Me.ListWindowsActive.AllowUserToResizeColumns = False
			Me.ListWindowsActive.AllowUserToResizeRows = False
			dataGridViewCellStyle.BackColor = Global.System.Drawing.Color.FromArgb(209, 196, 233)
			Me.ListWindowsActive.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
			Me.ListWindowsActive.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ListWindowsActive.AutoSizeColumnsMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
			Me.ListWindowsActive.BackgroundColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ListWindowsActive.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.ListWindowsActive.CellBorderStyle = Global.System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
			Me.ListWindowsActive.ColumnHeadersBorderStyle = Global.System.Windows.Forms.DataGridViewHeaderBorderStyle.None
			dataGridViewCellStyle2.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle2.BackColor = Global.System.Drawing.Color.FromArgb(103, 58, 183)
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle2.ForeColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle2.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle2.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle2.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.ListWindowsActive.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
			Me.ListWindowsActive.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.ListWindowsActive.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column3, Me.Column4, Me.Column1 })
			Me.ListWindowsActive.ContextMenuStrip = Me.ControllContextMenuStrip
			dataGridViewCellStyle3.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle3.BackColor = Global.System.Drawing.Color.FromArgb(224, 215, 240)
			dataGridViewCellStyle3.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle3.ForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle3.SelectionBackColor = Global.System.Drawing.Color.FromArgb(153, 123, 207)
			dataGridViewCellStyle3.SelectionForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle3.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[False]
			Me.ListWindowsActive.DefaultCellStyle = dataGridViewCellStyle3
			Me.ListWindowsActive.EnableHeadersVisualStyles = False
			Me.ListWindowsActive.GridColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ListWindowsActive.Location = New Global.System.Drawing.Point(21, 81)
			Me.ListWindowsActive.MultiSelect = False
			Me.ListWindowsActive.Name = "ListWindowsActive"
			Me.ListWindowsActive.[ReadOnly] = True
			Me.ListWindowsActive.RowHeadersVisible = False
			Me.ListWindowsActive.RowHeadersWidth = 20
			Me.ListWindowsActive.RowHeadersWidthSizeMode = Global.System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
			Me.ListWindowsActive.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			Me.ListWindowsActive.ShowCellErrors = False
			Me.ListWindowsActive.ShowEditingIcon = False
			Me.ListWindowsActive.ShowRowErrors = False
			Me.ListWindowsActive.Size = New Global.System.Drawing.Size(511, 295)
			Me.ListWindowsActive.TabIndex = 513
			Me.ListWindowsActive.Theme = Global.Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.DeepPurple
			Me.ListWindowsActive.ThemeStyle.AlternatingRowsStyle.BackColor = Global.System.Drawing.Color.FromArgb(209, 196, 233)
			Me.ListWindowsActive.ThemeStyle.AlternatingRowsStyle.Font = Nothing
			Me.ListWindowsActive.ThemeStyle.AlternatingRowsStyle.ForeColor = Global.System.Drawing.Color.Empty
			Me.ListWindowsActive.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Global.System.Drawing.Color.Empty
			Me.ListWindowsActive.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Global.System.Drawing.Color.Empty
			Me.ListWindowsActive.ThemeStyle.BackColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ListWindowsActive.ThemeStyle.GridColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ListWindowsActive.ThemeStyle.HeaderStyle.BackColor = Global.System.Drawing.Color.FromArgb(103, 58, 183)
			Me.ListWindowsActive.ThemeStyle.HeaderStyle.BorderStyle = Global.System.Windows.Forms.DataGridViewHeaderBorderStyle.None
			Me.ListWindowsActive.ThemeStyle.HeaderStyle.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ListWindowsActive.ThemeStyle.HeaderStyle.ForeColor = Global.System.Drawing.Color.White
			Me.ListWindowsActive.ThemeStyle.HeaderStyle.HeaightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.ListWindowsActive.ThemeStyle.HeaderStyle.Height = 23
			Me.ListWindowsActive.ThemeStyle.[ReadOnly] = True
			Me.ListWindowsActive.ThemeStyle.RowsStyle.BackColor = Global.System.Drawing.Color.FromArgb(224, 215, 240)
			Me.ListWindowsActive.ThemeStyle.RowsStyle.BorderStyle = Global.System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
			Me.ListWindowsActive.ThemeStyle.RowsStyle.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ListWindowsActive.ThemeStyle.RowsStyle.ForeColor = Global.System.Drawing.Color.Black
			Me.ListWindowsActive.ThemeStyle.RowsStyle.Height = 22
			Me.ListWindowsActive.ThemeStyle.RowsStyle.SelectionBackColor = Global.System.Drawing.Color.FromArgb(153, 123, 207)
			Me.ListWindowsActive.ThemeStyle.RowsStyle.SelectionForeColor = Global.System.Drawing.Color.Black
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
			Me.Column1.AutoSizeMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
			Me.Column1.HeaderText = "PID"
			Me.Column1.Name = "Column1"
			Me.Column1.[ReadOnly] = True
			Me.ControllContextMenuStrip.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ControllContextMenuStrip.ImageScalingSize = New Global.System.Drawing.Size(20, 20)
			Me.ControllContextMenuStrip.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.RefreshList })
			Me.ControllContextMenuStrip.Name = "ContextMenuStrip1"
			Me.ControllContextMenuStrip.Size = New Global.System.Drawing.Size(123, 30)
			Me.RefreshList.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.RefreshList.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.RefreshList.Image = CType(componentResourceManager.GetObject("RefreshList.Image"), Global.System.Drawing.Image)
			Me.RefreshList.Name = "RefreshList"
			Me.RefreshList.Size = New Global.System.Drawing.Size(184, 26)
			Me.RefreshList.Text = "Refresh"
			Me.UiLabel1.AutoSize = True
			Me.UiLabel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel1.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel1.Location = New Global.System.Drawing.Point(20, 8)
			Me.UiLabel1.Name = "UiLabel1"
			Me.UiLabel1.Size = New Global.System.Drawing.Size(116, 19)
			Me.UiLabel1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLabel1.TabIndex = 334
			Me.UiLabel1.Text = "Active Windows"
			Me.UiLabel1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(21, 32)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(200, 16)
			Me.ClientInfo.TabIndex = 335
			Me.ClientInfo.Text = "FC / Desktop_3424 / Windows 10 pro"
			Me.ActiveNum.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.ActiveNum.AutoSize = True
			Me.ActiveNum.BackColor = Global.System.Drawing.Color.Transparent
			Me.ActiveNum.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ActiveNum.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ActiveNum.Location = New Global.System.Drawing.Point(21, 387)
			Me.ActiveNum.Name = "ActiveNum"
			Me.ActiveNum.Size = New Global.System.Drawing.Size(64, 14)
			Me.ActiveNum.TabIndex = 514
			Me.ActiveNum.Text = "Active [ 0 ]"
			Me.Guna2ResizeBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Guna2ResizeBox1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Guna2ResizeBox1.FillColor = Global.System.Drawing.Color.Silver
			Me.Guna2ResizeBox1.ForeColor = Global.System.Drawing.Color.Empty
			Me.Guna2ResizeBox1.Location = New Global.System.Drawing.Point(529, 382)
			Me.Guna2ResizeBox1.Name = "Guna2ResizeBox1"
			Me.Guna2ResizeBox1.Size = New Global.System.Drawing.Size(17, 19)
			Me.Guna2ResizeBox1.TabIndex = 512
			Me.Guna2ResizeBox1.TargetControl = Me
			Me.Guna2ResizeBox1.UseTransparentBackground = True
			Me.Mini.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Mini.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Mini.Location = New Global.System.Drawing.Point(472, 12)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 581
			Me.Mini.Text = "ValleyMini1"
			Me.MAX.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.MAX.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.MAX.Location = New Global.System.Drawing.Point(498, 12)
			Me.MAX.Name = "MAX"
			Me.MAX.Size = New Global.System.Drawing.Size(20, 20)
			Me.MAX.TabIndex = 580
			Me.MAX.Text = "ValleyMax1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(524, 12)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 579
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
			MyBase.ClientSize = New Global.System.Drawing.Size(556, 411)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.MAX)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.ActiveNum)
			MyBase.Controls.Add(Me.ListWindowsActive)
			MyBase.Controls.Add(Me.Guna2ResizeBox1)
			MyBase.Controls.Add(Me.UiLabel1)
			MyBase.Controls.Add(Me.ClientInfo)
			Me.DoubleBuffered = True
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Name = "FormWindowsActive"
			Me.Text = "FormWindowsActive"
			MyBase.TopMost = True
			CType(Me.ListWindowsActive, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ControllContextMenuStrip.ResumeLayout(False)
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x04000724 RID: 1828
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
