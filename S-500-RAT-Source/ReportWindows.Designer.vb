Namespace S500RAT
	' Token: 0x0200003D RID: 61
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class ReportWindows
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06001123 RID: 4387 RVA: 0x00093A20 File Offset: 0x00091C20
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

		' Token: 0x06001124 RID: 4388 RVA: 0x00093A70 File Offset: 0x00091C70
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle3 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.ReportWindows))
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			Me.ImageList1 = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.ElipseList = New Global.Guna.UI2.WinForms.Guna2Elipse(Me.components)
			Me.ListAc = New Global.Guna.UI2.WinForms.Guna2DataGridView()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewImageColumn()
			Me.Column4 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.UiLabel1 = New Global.Sunny.UI.UILabel()
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.Save = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.TextBox1 = New Global.Guna.UI2.WinForms.Guna2TextBox()
			Me.Guna2ResizeBox1 = New Global.Guna.UI2.WinForms.Guna2ResizeBox()
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.MAX = New Global.S500RAT.ValleyMax()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			CType(Me.ListAc, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.Guna2DragControl1.ContainerControl = Me
			Me.Guna2DragControl1.DockForm = True
			Me.Guna2DragControl1.DockIndicatorColor = Global.System.Drawing.Color.FromArgb(56, 37, 200)
			Me.Guna2DragControl1.DragMode = Global.Guna.UI2.WinForms.Enums.DragMode.Control
			Me.Guna2DragControl1.DragStartTransparencyValue = 0.6
			Me.Guna2DragControl1.TargetControl = Me
			Me.Guna2DragControl1.TransparentWhileDrag = True
			Me.Guna2DragControl1.UseTransparentDrag = True
			Me.ImageList1.ImageStream = CType(componentResourceManager.GetObject("ImageList1.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.ImageList1.TransparentColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.ImageList1.Images.SetKeyName(0, "B.png")
			Me.Guna2BorderlessForm1.AnimateWindow = True
			Me.Guna2BorderlessForm1.BorderRadius = 40
			Me.Guna2BorderlessForm1.ContainerControl = Me
			Me.Guna2BorderlessForm1.DockIndicatorColor = Global.System.Drawing.Color.FromArgb(56, 37, 200)
			Me.Guna2BorderlessForm1.DragStartTransparencyValue = 0.6
			Me.Guna2BorderlessForm1.ShadowColor = Global.System.Drawing.Color.FromArgb(56, 37, 200)
			Me.Guna2BorderlessForm1.TransparentWhileDrag = True
			Me.ElipseList.BorderRadius = 8
			Me.ElipseList.TargetControl = Me.ListAc
			Me.ListAc.AllowUserToAddRows = False
			Me.ListAc.AllowUserToDeleteRows = False
			Me.ListAc.AllowUserToResizeColumns = False
			Me.ListAc.AllowUserToResizeRows = False
			dataGridViewCellStyle.BackColor = Global.System.Drawing.Color.FromArgb(209, 196, 233)
			Me.ListAc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
			Me.ListAc.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ListAc.AutoSizeColumnsMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
			Me.ListAc.BackgroundColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ListAc.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.ListAc.CellBorderStyle = Global.System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
			Me.ListAc.ColumnHeadersBorderStyle = Global.System.Windows.Forms.DataGridViewHeaderBorderStyle.None
			dataGridViewCellStyle2.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle2.BackColor = Global.System.Drawing.Color.FromArgb(103, 58, 183)
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			dataGridViewCellStyle2.ForeColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle2.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle2.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle2.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.ListAc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
			Me.ListAc.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.ListAc.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column3, Me.Column4 })
			dataGridViewCellStyle3.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle3.BackColor = Global.System.Drawing.Color.FromArgb(224, 215, 240)
			dataGridViewCellStyle3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			dataGridViewCellStyle3.ForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle3.SelectionBackColor = Global.System.Drawing.Color.FromArgb(153, 123, 207)
			dataGridViewCellStyle3.SelectionForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle3.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[False]
			Me.ListAc.DefaultCellStyle = dataGridViewCellStyle3
			Me.ListAc.EnableHeadersVisualStyles = False
			Me.ListAc.GridColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ListAc.Location = New Global.System.Drawing.Point(16, 81)
			Me.ListAc.Name = "ListAc"
			Me.ListAc.[ReadOnly] = True
			Me.ListAc.RowHeadersVisible = False
			Me.ListAc.RowHeadersWidth = 20
			Me.ListAc.RowHeadersWidthSizeMode = Global.System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
			Me.ListAc.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			Me.ListAc.ShowCellErrors = False
			Me.ListAc.ShowEditingIcon = False
			Me.ListAc.ShowRowErrors = False
			Me.ListAc.Size = New Global.System.Drawing.Size(383, 249)
			Me.ListAc.TabIndex = 563
			Me.ListAc.Theme = Global.Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.DeepPurple
			Me.ListAc.ThemeStyle.AlternatingRowsStyle.BackColor = Global.System.Drawing.Color.FromArgb(209, 196, 233)
			Me.ListAc.ThemeStyle.AlternatingRowsStyle.Font = Nothing
			Me.ListAc.ThemeStyle.AlternatingRowsStyle.ForeColor = Global.System.Drawing.Color.Empty
			Me.ListAc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Global.System.Drawing.Color.Empty
			Me.ListAc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Global.System.Drawing.Color.Empty
			Me.ListAc.ThemeStyle.BackColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ListAc.ThemeStyle.GridColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ListAc.ThemeStyle.HeaderStyle.BackColor = Global.System.Drawing.Color.FromArgb(103, 58, 183)
			Me.ListAc.ThemeStyle.HeaderStyle.BorderStyle = Global.System.Windows.Forms.DataGridViewHeaderBorderStyle.None
			Me.ListAc.ThemeStyle.HeaderStyle.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.ListAc.ThemeStyle.HeaderStyle.ForeColor = Global.System.Drawing.Color.White
			Me.ListAc.ThemeStyle.HeaderStyle.HeaightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.ListAc.ThemeStyle.HeaderStyle.Height = 23
			Me.ListAc.ThemeStyle.[ReadOnly] = True
			Me.ListAc.ThemeStyle.RowsStyle.BackColor = Global.System.Drawing.Color.FromArgb(224, 215, 240)
			Me.ListAc.ThemeStyle.RowsStyle.BorderStyle = Global.System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
			Me.ListAc.ThemeStyle.RowsStyle.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.ListAc.ThemeStyle.RowsStyle.ForeColor = Global.System.Drawing.Color.Black
			Me.ListAc.ThemeStyle.RowsStyle.Height = 22
			Me.ListAc.ThemeStyle.RowsStyle.SelectionBackColor = Global.System.Drawing.Color.FromArgb(153, 123, 207)
			Me.ListAc.ThemeStyle.RowsStyle.SelectionForeColor = Global.System.Drawing.Color.Black
			Me.Column3.AutoSizeMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
			Me.Column3.HeaderText = "         "
			Me.Column3.ImageLayout = Global.System.Windows.Forms.DataGridViewImageCellLayout.Zoom
			Me.Column3.Name = "Column3"
			Me.Column3.[ReadOnly] = True
			Me.Column3.Width = 38
			Me.Column4.AutoSizeMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
			Me.Column4.HeaderText = " Window Title"
			Me.Column4.Name = "Column4"
			Me.Column4.[ReadOnly] = True
			Me.UiLabel1.AutoSize = True
			Me.UiLabel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel1.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel1.Location = New Global.System.Drawing.Point(12, 12)
			Me.UiLabel1.Name = "UiLabel1"
			Me.UiLabel1.Size = New Global.System.Drawing.Size(123, 19)
			Me.UiLabel1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLabel1.TabIndex = 555
			Me.UiLabel1.Text = "Motionr Watcher"
			Me.UiLabel1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(12, 36)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(308, 16)
			Me.ClientInfo.TabIndex = 556
			Me.ClientInfo.Text = "Send a NotifIcation When Client Open a Specific Window"
			Me.Save.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Save.BackColor = Global.System.Drawing.Color.Transparent
			Me.Save.BorderRadius = 8
			Me.Save.CheckedState.Parent = Me.Save
			Me.Save.CustomImages.Parent = Me.Save
			Me.Save.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.Save.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.Save.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Save.ForeColor = Global.System.Drawing.Color.White
			Me.Save.HoverState.Parent = Me.Save
			Me.Save.Location = New Global.System.Drawing.Point(256, 369)
			Me.Save.Name = "Save"
			Me.Save.ShadowDecoration.Parent = Me.Save
			Me.Save.Size = New Global.System.Drawing.Size(143, 29)
			Me.Save.TabIndex = 562
			Me.Save.Text = "Ok"
			Me.TextBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.TextBox1.Animated = True
			Me.TextBox1.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.TextBox1.BorderColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.TextBox1.BorderRadius = 7
			Me.TextBox1.BorderStyle = Global.System.Drawing.Drawing2D.DashStyle.Custom
			Me.TextBox1.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.TextBox1.DefaultText = ""
			Me.TextBox1.DisabledState.BorderColor = Global.System.Drawing.Color.FromArgb(208, 208, 208)
			Me.TextBox1.DisabledState.FillColor = Global.System.Drawing.Color.FromArgb(226, 226, 226)
			Me.TextBox1.DisabledState.ForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.TextBox1.DisabledState.Parent = Me.TextBox1
			Me.TextBox1.DisabledState.PlaceholderForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.TextBox1.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.TextBox1.FocusedState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.TextBox1.FocusedState.Parent = Me.TextBox1
			Me.TextBox1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.TextBox1.ForeColor = Global.System.Drawing.Color.White
			Me.TextBox1.HoverState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.TextBox1.HoverState.Parent = Me.TextBox1
			Me.TextBox1.IconLeft = CType(componentResourceManager.GetObject("TextBox1.IconLeft"), Global.System.Drawing.Image)
			Me.TextBox1.IconLeftCursor = Global.System.Windows.Forms.Cursors.Hand
			Me.TextBox1.IconRight = CType(componentResourceManager.GetObject("TextBox1.IconRight"), Global.System.Drawing.Image)
			Me.TextBox1.IconRightCursor = Global.System.Windows.Forms.Cursors.Hand
			Me.TextBox1.Location = New Global.System.Drawing.Point(16, 335)
			Me.TextBox1.Margin = New Global.System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.TextBox1.Name = "TextBox1"
			Me.TextBox1.PasswordChar = vbNullChar
			Me.TextBox1.PlaceholderForeColor = Global.System.Drawing.Color.Gray
			Me.TextBox1.PlaceholderText = "Add window name"
			Me.TextBox1.SelectedText = ""
			Me.TextBox1.ShadowDecoration.Parent = Me.TextBox1
			Me.TextBox1.Size = New Global.System.Drawing.Size(383, 27)
			Me.TextBox1.TabIndex = 561
			Me.TextBox1.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Guna2ResizeBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Guna2ResizeBox1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Guna2ResizeBox1.FillColor = Global.System.Drawing.Color.Silver
			Me.Guna2ResizeBox1.ForeColor = Global.System.Drawing.Color.Empty
			Me.Guna2ResizeBox1.Location = New Global.System.Drawing.Point(389, 404)
			Me.Guna2ResizeBox1.Name = "Guna2ResizeBox1"
			Me.Guna2ResizeBox1.Size = New Global.System.Drawing.Size(17, 19)
			Me.Guna2ResizeBox1.TabIndex = 560
			Me.Guna2ResizeBox1.TargetControl = Me
			Me.Guna2ResizeBox1.UseTransparentBackground = True
			Me.Mini.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Mini.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Mini.Location = New Global.System.Drawing.Point(335, 12)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 559
			Me.Mini.Text = "ValleyMini1"
			Me.MAX.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.MAX.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.MAX.Location = New Global.System.Drawing.Point(361, 12)
			Me.MAX.Name = "MAX"
			Me.MAX.Size = New Global.System.Drawing.Size(20, 20)
			Me.MAX.TabIndex = 558
			Me.MAX.Text = "ValleyMax1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(387, 12)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 557
			Me.ExitForm.Text = "ValleyClose1"
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			MyBase.ClientSize = New Global.System.Drawing.Size(419, 435)
			MyBase.Controls.Add(Me.ListAc)
			MyBase.Controls.Add(Me.Save)
			MyBase.Controls.Add(Me.TextBox1)
			MyBase.Controls.Add(Me.Guna2ResizeBox1)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.MAX)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.UiLabel1)
			MyBase.Controls.Add(Me.ClientInfo)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "ReportWindows"
			Me.Text = "Motionr Watcher"
			CType(Me.ListAc, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x040007AB RID: 1963
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
