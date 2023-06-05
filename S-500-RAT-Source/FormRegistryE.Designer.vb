Namespace S500RAT
	' Token: 0x02000028 RID: 40
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormRegistryE
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000766 RID: 1894 RVA: 0x0003F6E4 File Offset: 0x0003D8E4
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

		' Token: 0x06000767 RID: 1895 RVA: 0x0003F734 File Offset: 0x0003D934
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormRegistryE))
			Me.hName = New Global.System.Windows.Forms.ColumnHeader()
			Me.hType = New Global.System.Windows.Forms.ColumnHeader()
			Me.hValue = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader1 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader2 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader3 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader4 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader5 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader6 = New Global.System.Windows.Forms.ColumnHeader()
			Me.lstRegistryValues = New Global.Gry.Helper.AeroListView()
			Me.ColumnHeader7 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader8 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader9 = New Global.System.Windows.Forms.ColumnHeader()
			Me.imageRegistryKeyTypeList = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.tv_ContextMenuStrip = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.newToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.keyToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator2 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.stringValueToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.binaryValueToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.dWORD32bitValueToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.qWORD64bitValueToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.multiStringValueToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.expandableStringValueToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator1 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.RefreshToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.deleteToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.renameToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.imageRegistryDirectoryList = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.tvRegistryDirectory = New Global.Gry.Helper.RegistryTreeView()
			Me.lst_ContextMenuStrip = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.newToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.keyToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator4 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.stringValueToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.binaryValueToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.dWORD32bitValueToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.qWORD64bitValueToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.multiStringValueToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.expandableStringValueToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.RefreshToolStripMenuItem2 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.selectedItem_ContextMenuStrip = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.modifyToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.modifyBinaryDataToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.modifyToolStripSeparator1 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.RefreshToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.deleteToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.renameToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.NameForm = New Global.Sunny.UI.UILabel()
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.Guna2Elipse1 = New Global.Guna.UI2.WinForms.Guna2Elipse(Me.components)
			Me.Guna2ResizeBox1 = New Global.Guna.UI2.WinForms.Guna2ResizeBox()
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.MAX = New Global.S500RAT.ValleyMax()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			Me.tv_ContextMenuStrip.SuspendLayout()
			Me.lst_ContextMenuStrip.SuspendLayout()
			Me.selectedItem_ContextMenuStrip.SuspendLayout()
			Me.Panel1.SuspendLayout()
			MyBase.SuspendLayout()
			Me.hName.Text = "Name"
			Me.hName.Width = 173
			Me.hType.Text = "Type"
			Me.hType.Width = 104
			Me.hValue.Text = "Value"
			Me.hValue.Width = 214
			Me.ColumnHeader1.Text = "Name"
			Me.ColumnHeader1.Width = 173
			Me.ColumnHeader2.Text = "Type"
			Me.ColumnHeader2.Width = 104
			Me.ColumnHeader3.Text = "Value"
			Me.ColumnHeader3.Width = 214
			Me.ColumnHeader4.Text = "Name"
			Me.ColumnHeader4.Width = 173
			Me.ColumnHeader5.Text = "Type"
			Me.ColumnHeader5.Width = 104
			Me.ColumnHeader6.Text = "Value"
			Me.ColumnHeader6.Width = 214
			Me.lstRegistryValues.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.lstRegistryValues.BackColor = Global.System.Drawing.SystemColors.Control
			Me.lstRegistryValues.Columns.AddRange(New Global.System.Windows.Forms.ColumnHeader() { Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9 })
			Me.lstRegistryValues.FullRowSelect = True
			Me.lstRegistryValues.HeaderStyle = Global.System.Windows.Forms.ColumnHeaderStyle.Nonclickable
			Me.lstRegistryValues.HideSelection = False
			Me.lstRegistryValues.Location = New Global.System.Drawing.Point(214, 23)
			Me.lstRegistryValues.Name = "lstRegistryValues"
			Me.lstRegistryValues.Size = New Global.System.Drawing.Size(434, 405)
			Me.lstRegistryValues.SmallImageList = Me.imageRegistryKeyTypeList
			Me.lstRegistryValues.TabIndex = 0
			Me.lstRegistryValues.UseCompatibleStateImageBehavior = False
			Me.lstRegistryValues.View = Global.System.Windows.Forms.View.Details
			Me.ColumnHeader7.Text = "Name"
			Me.ColumnHeader7.Width = 173
			Me.ColumnHeader8.Text = "Type"
			Me.ColumnHeader8.Width = 104
			Me.ColumnHeader9.Text = "Value"
			Me.ColumnHeader9.Width = 214
			Me.imageRegistryKeyTypeList.ImageStream = CType(componentResourceManager.GetObject("imageRegistryKeyTypeList.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.imageRegistryKeyTypeList.TransparentColor = Global.System.Drawing.Color.Transparent
			Me.imageRegistryKeyTypeList.Images.SetKeyName(0, "reg_string.png")
			Me.imageRegistryKeyTypeList.Images.SetKeyName(1, "reg_binary.png")
			Me.tv_ContextMenuStrip.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.newToolStripMenuItem, Me.toolStripSeparator1, Me.RefreshToolStripMenuItem, Me.deleteToolStripMenuItem, Me.renameToolStripMenuItem })
			Me.tv_ContextMenuStrip.Name = "contextMenuStrip"
			Me.tv_ContextMenuStrip.Size = New Global.System.Drawing.Size(118, 98)
			Me.newToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.keyToolStripMenuItem, Me.toolStripSeparator2, Me.stringValueToolStripMenuItem, Me.binaryValueToolStripMenuItem, Me.dWORD32bitValueToolStripMenuItem, Me.qWORD64bitValueToolStripMenuItem, Me.multiStringValueToolStripMenuItem, Me.expandableStringValueToolStripMenuItem })
			Me.newToolStripMenuItem.Name = "newToolStripMenuItem"
			Me.newToolStripMenuItem.Size = New Global.System.Drawing.Size(117, 22)
			Me.newToolStripMenuItem.Text = "New"
			Me.keyToolStripMenuItem.Name = "keyToolStripMenuItem"
			Me.keyToolStripMenuItem.Size = New Global.System.Drawing.Size(200, 22)
			Me.keyToolStripMenuItem.Text = "Key"
			Me.toolStripSeparator2.Name = "toolStripSeparator2"
			Me.toolStripSeparator2.Size = New Global.System.Drawing.Size(197, 6)
			Me.stringValueToolStripMenuItem.Name = "stringValueToolStripMenuItem"
			Me.stringValueToolStripMenuItem.Size = New Global.System.Drawing.Size(200, 22)
			Me.stringValueToolStripMenuItem.Text = "String Value"
			Me.binaryValueToolStripMenuItem.Name = "binaryValueToolStripMenuItem"
			Me.binaryValueToolStripMenuItem.Size = New Global.System.Drawing.Size(200, 22)
			Me.binaryValueToolStripMenuItem.Text = "Binary Value"
			Me.dWORD32bitValueToolStripMenuItem.Name = "dWORD32bitValueToolStripMenuItem"
			Me.dWORD32bitValueToolStripMenuItem.Size = New Global.System.Drawing.Size(200, 22)
			Me.dWORD32bitValueToolStripMenuItem.Text = "DWORD (32-bit) Value"
			Me.qWORD64bitValueToolStripMenuItem.Name = "qWORD64bitValueToolStripMenuItem"
			Me.qWORD64bitValueToolStripMenuItem.Size = New Global.System.Drawing.Size(200, 22)
			Me.qWORD64bitValueToolStripMenuItem.Text = "QWORD (64-bit) Value"
			Me.multiStringValueToolStripMenuItem.Name = "multiStringValueToolStripMenuItem"
			Me.multiStringValueToolStripMenuItem.Size = New Global.System.Drawing.Size(200, 22)
			Me.multiStringValueToolStripMenuItem.Text = "Multi-String Value"
			Me.expandableStringValueToolStripMenuItem.Name = "expandableStringValueToolStripMenuItem"
			Me.expandableStringValueToolStripMenuItem.Size = New Global.System.Drawing.Size(200, 22)
			Me.expandableStringValueToolStripMenuItem.Text = "Expandable String Value"
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			Me.toolStripSeparator1.Size = New Global.System.Drawing.Size(114, 6)
			Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
			Me.RefreshToolStripMenuItem.Size = New Global.System.Drawing.Size(117, 22)
			Me.RefreshToolStripMenuItem.Text = "Refresh"
			Me.deleteToolStripMenuItem.Enabled = False
			Me.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem"
			Me.deleteToolStripMenuItem.Size = New Global.System.Drawing.Size(117, 22)
			Me.deleteToolStripMenuItem.Text = "Delete"
			Me.renameToolStripMenuItem.Enabled = False
			Me.renameToolStripMenuItem.Name = "renameToolStripMenuItem"
			Me.renameToolStripMenuItem.Size = New Global.System.Drawing.Size(117, 22)
			Me.renameToolStripMenuItem.Text = "Rename"
			Me.timer1.Interval = 2000
			Me.imageRegistryDirectoryList.ImageStream = CType(componentResourceManager.GetObject("imageRegistryDirectoryList.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.imageRegistryDirectoryList.TransparentColor = Global.System.Drawing.Color.Transparent
			Me.imageRegistryDirectoryList.Images.SetKeyName(0, "folder.png")
			Me.tvRegistryDirectory.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.tvRegistryDirectory.BackColor = Global.System.Drawing.SystemColors.Control
			Me.tvRegistryDirectory.HideSelection = False
			Me.tvRegistryDirectory.ImageIndex = 0
			Me.tvRegistryDirectory.ImageList = Me.imageRegistryDirectoryList
			Me.tvRegistryDirectory.Location = New Global.System.Drawing.Point(1, 23)
			Me.tvRegistryDirectory.Name = "tvRegistryDirectory"
			Me.tvRegistryDirectory.SelectedImageIndex = 0
			Me.tvRegistryDirectory.Size = New Global.System.Drawing.Size(213, 402)
			Me.tvRegistryDirectory.TabIndex = 0
			Me.lst_ContextMenuStrip.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.newToolStripMenuItem1, Me.RefreshToolStripMenuItem2 })
			Me.lst_ContextMenuStrip.Name = "lst_ContextMenuStrip"
			Me.lst_ContextMenuStrip.Size = New Global.System.Drawing.Size(114, 48)
			Me.newToolStripMenuItem1.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.keyToolStripMenuItem1, Me.toolStripSeparator4, Me.stringValueToolStripMenuItem1, Me.binaryValueToolStripMenuItem1, Me.dWORD32bitValueToolStripMenuItem1, Me.qWORD64bitValueToolStripMenuItem1, Me.multiStringValueToolStripMenuItem1, Me.expandableStringValueToolStripMenuItem1 })
			Me.newToolStripMenuItem1.Name = "newToolStripMenuItem1"
			Me.newToolStripMenuItem1.Size = New Global.System.Drawing.Size(113, 22)
			Me.newToolStripMenuItem1.Text = "New"
			Me.keyToolStripMenuItem1.Name = "keyToolStripMenuItem1"
			Me.keyToolStripMenuItem1.Size = New Global.System.Drawing.Size(200, 22)
			Me.keyToolStripMenuItem1.Text = "Key"
			Me.toolStripSeparator4.Name = "toolStripSeparator4"
			Me.toolStripSeparator4.Size = New Global.System.Drawing.Size(197, 6)
			Me.stringValueToolStripMenuItem1.Name = "stringValueToolStripMenuItem1"
			Me.stringValueToolStripMenuItem1.Size = New Global.System.Drawing.Size(200, 22)
			Me.stringValueToolStripMenuItem1.Text = "String Value"
			Me.binaryValueToolStripMenuItem1.Name = "binaryValueToolStripMenuItem1"
			Me.binaryValueToolStripMenuItem1.Size = New Global.System.Drawing.Size(200, 22)
			Me.binaryValueToolStripMenuItem1.Text = "Binary Value"
			Me.dWORD32bitValueToolStripMenuItem1.Name = "dWORD32bitValueToolStripMenuItem1"
			Me.dWORD32bitValueToolStripMenuItem1.Size = New Global.System.Drawing.Size(200, 22)
			Me.dWORD32bitValueToolStripMenuItem1.Text = "DWORD (32-bit) Value"
			Me.qWORD64bitValueToolStripMenuItem1.Name = "qWORD64bitValueToolStripMenuItem1"
			Me.qWORD64bitValueToolStripMenuItem1.Size = New Global.System.Drawing.Size(200, 22)
			Me.qWORD64bitValueToolStripMenuItem1.Text = "QWORD (64-bit) Value"
			Me.multiStringValueToolStripMenuItem1.Name = "multiStringValueToolStripMenuItem1"
			Me.multiStringValueToolStripMenuItem1.Size = New Global.System.Drawing.Size(200, 22)
			Me.multiStringValueToolStripMenuItem1.Text = "Multi-String Value"
			Me.expandableStringValueToolStripMenuItem1.Name = "expandableStringValueToolStripMenuItem1"
			Me.expandableStringValueToolStripMenuItem1.Size = New Global.System.Drawing.Size(200, 22)
			Me.expandableStringValueToolStripMenuItem1.Text = "Expandable String Value"
			Me.RefreshToolStripMenuItem2.Name = "RefreshToolStripMenuItem2"
			Me.RefreshToolStripMenuItem2.Size = New Global.System.Drawing.Size(113, 22)
			Me.RefreshToolStripMenuItem2.Text = "Refresh"
			Me.selectedItem_ContextMenuStrip.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.modifyToolStripMenuItem, Me.modifyBinaryDataToolStripMenuItem, Me.modifyToolStripSeparator1, Me.RefreshToolStripMenuItem1, Me.deleteToolStripMenuItem1, Me.renameToolStripMenuItem1 })
			Me.selectedItem_ContextMenuStrip.Name = "selectedItem_ContextMenuStrip"
			Me.selectedItem_ContextMenuStrip.Size = New Global.System.Drawing.Size(185, 120)
			Me.modifyToolStripMenuItem.Enabled = False
			Me.modifyToolStripMenuItem.Font = New Global.System.Drawing.Font("Segoe UI", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem"
			Me.modifyToolStripMenuItem.Size = New Global.System.Drawing.Size(184, 22)
			Me.modifyToolStripMenuItem.Text = "Modify..."
			Me.modifyBinaryDataToolStripMenuItem.Enabled = False
			Me.modifyBinaryDataToolStripMenuItem.Name = "modifyBinaryDataToolStripMenuItem"
			Me.modifyBinaryDataToolStripMenuItem.Size = New Global.System.Drawing.Size(184, 22)
			Me.modifyBinaryDataToolStripMenuItem.Text = "Modify Binary Data..."
			Me.modifyToolStripSeparator1.Name = "modifyToolStripSeparator1"
			Me.modifyToolStripSeparator1.Size = New Global.System.Drawing.Size(181, 6)
			Me.RefreshToolStripMenuItem1.Name = "RefreshToolStripMenuItem1"
			Me.RefreshToolStripMenuItem1.Size = New Global.System.Drawing.Size(184, 22)
			Me.RefreshToolStripMenuItem1.Text = "Refresh"
			Me.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1"
			Me.deleteToolStripMenuItem1.Size = New Global.System.Drawing.Size(184, 22)
			Me.deleteToolStripMenuItem1.Text = "Delete"
			Me.renameToolStripMenuItem1.Name = "renameToolStripMenuItem1"
			Me.renameToolStripMenuItem1.Size = New Global.System.Drawing.Size(184, 22)
			Me.renameToolStripMenuItem1.Text = "Rename"
			Me.Panel1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Panel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Panel1.Controls.Add(Me.TextBox1)
			Me.Panel1.Controls.Add(Me.tvRegistryDirectory)
			Me.Panel1.Controls.Add(Me.lstRegistryValues)
			Me.Panel1.Location = New Global.System.Drawing.Point(21, 72)
			Me.Panel1.Name = "Panel1"
			Me.Panel1.Size = New Global.System.Drawing.Size(648, 425)
			Me.Panel1.TabIndex = 6
			Me.TextBox1.BackColor = Global.System.Drawing.SystemColors.Control
			Me.TextBox1.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.TextBox1.Location = New Global.System.Drawing.Point(0, 0)
			Me.TextBox1.Multiline = True
			Me.TextBox1.Name = "TextBox1"
			Me.TextBox1.[ReadOnly] = True
			Me.TextBox1.Size = New Global.System.Drawing.Size(648, 23)
			Me.TextBox1.TabIndex = 5
			Me.NameForm.AutoSize = True
			Me.NameForm.BackColor = Global.System.Drawing.Color.Transparent
			Me.NameForm.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.NameForm.ForeColor = Global.System.Drawing.Color.White
			Me.NameForm.Location = New Global.System.Drawing.Point(19, 8)
			Me.NameForm.Name = "NameForm"
			Me.NameForm.Size = New Global.System.Drawing.Size(107, 19)
			Me.NameForm.Style = Global.Sunny.UI.UIStyle.Custom
			Me.NameForm.TabIndex = 311
			Me.NameForm.Text = "Registry Editor"
			Me.NameForm.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(19, 32)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(15, 14)
			Me.ClientInfo.TabIndex = 312
			Me.ClientInfo.Text = "--"
			Me.Guna2Elipse1.BorderRadius = 10
			Me.Guna2Elipse1.TargetControl = Me.Panel1
			Me.Guna2ResizeBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Guna2ResizeBox1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Guna2ResizeBox1.FillColor = Global.System.Drawing.Color.Silver
			Me.Guna2ResizeBox1.ForeColor = Global.System.Drawing.Color.Empty
			Me.Guna2ResizeBox1.Location = New Global.System.Drawing.Point(668, 506)
			Me.Guna2ResizeBox1.Name = "Guna2ResizeBox1"
			Me.Guna2ResizeBox1.Size = New Global.System.Drawing.Size(17, 19)
			Me.Guna2ResizeBox1.TabIndex = 498
			Me.Guna2ResizeBox1.TargetControl = Me
			Me.Guna2ResizeBox1.UseTransparentBackground = True
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
			Me.Mini.Location = New Global.System.Drawing.Point(611, 12)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 566
			Me.Mini.Text = "ValleyMini1"
			Me.MAX.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.MAX.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.MAX.Location = New Global.System.Drawing.Point(637, 12)
			Me.MAX.Name = "MAX"
			Me.MAX.Size = New Global.System.Drawing.Size(20, 20)
			Me.MAX.TabIndex = 565
			Me.MAX.Text = "ValleyMax1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(663, 12)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 564
			Me.ExitForm.Text = "ValleyClose1"
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(96F, 96F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Dpi
			Me.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			MyBase.ClientSize = New Global.System.Drawing.Size(695, 536)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.MAX)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.Guna2ResizeBox1)
			MyBase.Controls.Add(Me.NameForm)
			MyBase.Controls.Add(Me.ClientInfo)
			MyBase.Controls.Add(Me.Panel1)
			Me.DoubleBuffered = True
			Me.ForeColor = Global.System.Drawing.Color.White
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "FormRegistryE"
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.Manual
			Me.Text = "FormRegistryE"
			MyBase.TopMost = True
			Me.tv_ContextMenuStrip.ResumeLayout(False)
			Me.lst_ContextMenuStrip.ResumeLayout(False)
			Me.selectedItem_ContextMenuStrip.ResumeLayout(False)
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0400035A RID: 858
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
