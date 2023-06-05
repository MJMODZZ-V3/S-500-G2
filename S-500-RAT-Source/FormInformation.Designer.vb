Namespace S500RAT
	' Token: 0x02000020 RID: 32
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormInformation
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600057D RID: 1405 RVA: 0x0002F480 File Offset: 0x0002D680
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

		' Token: 0x0600057E RID: 1406 RVA: 0x0002F4D0 File Offset: 0x0002D6D0
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormInformation))
			Dim treeNode As Global.System.Windows.Forms.TreeNode = New Global.System.Windows.Forms.TreeNode("Name : ", 2, 2)
			Dim treeNode2 As Global.System.Windows.Forms.TreeNode = New Global.System.Windows.Forms.TreeNode("Installation Path :", 2, 2)
			Dim treeNode3 As Global.System.Windows.Forms.TreeNode = New Global.System.Windows.Forms.TreeNode("Admin : ", 2, 2)
			Dim treeNode4 As Global.System.Windows.Forms.TreeNode = New Global.System.Windows.Forms.TreeNode("Hidden : ", 2, 2)
			Dim treeNode5 As Global.System.Windows.Forms.TreeNode = New Global.System.Windows.Forms.TreeNode("Date Installed : ", 2, 2)
			Dim treeNode6 As Global.System.Windows.Forms.TreeNode = New Global.System.Windows.Forms.TreeNode("Client info", 0, 0, New Global.System.Windows.Forms.TreeNode() { treeNode, treeNode2, treeNode3, treeNode4, treeNode5 })
			Dim treeNode7 As Global.System.Windows.Forms.TreeNode = New Global.System.Windows.Forms.TreeNode("IP :", 2, 2)
			Dim treeNode8 As Global.System.Windows.Forms.TreeNode = New Global.System.Windows.Forms.TreeNode("Port : ", 2, 2)
			Dim treeNode9 As Global.System.Windows.Forms.TreeNode = New Global.System.Windows.Forms.TreeNode("IPV4 : ", 2, 2)
			Dim treeNode10 As Global.System.Windows.Forms.TreeNode = New Global.System.Windows.Forms.TreeNode("MAC : ", 2, 2)
			Dim treeNode11 As Global.System.Windows.Forms.TreeNode = New Global.System.Windows.Forms.TreeNode("Connection info", 1, 1, New Global.System.Windows.Forms.TreeNode() { treeNode7, treeNode8, treeNode9, treeNode10 })
			Dim treeNode12 As Global.System.Windows.Forms.TreeNode = New Global.System.Windows.Forms.TreeNode("Computer Name : ", 2, 2)
			Dim treeNode13 As Global.System.Windows.Forms.TreeNode = New Global.System.Windows.Forms.TreeNode("UserDomainName : ", 2, 2)
			Dim treeNode14 As Global.System.Windows.Forms.TreeNode = New Global.System.Windows.Forms.TreeNode("UserName : ", 2, 2)
			Dim treeNode15 As Global.System.Windows.Forms.TreeNode = New Global.System.Windows.Forms.TreeNode("Monitor : ", 2, 2)
			Dim treeNode16 As Global.System.Windows.Forms.TreeNode = New Global.System.Windows.Forms.TreeNode("Screen Sizes : ", 2, 2)
			Dim treeNode17 As Global.System.Windows.Forms.TreeNode = New Global.System.Windows.Forms.TreeNode("Windows : ", 2, 2)
			Dim treeNode18 As Global.System.Windows.Forms.TreeNode = New Global.System.Windows.Forms.TreeNode("OS : ", 2, 2)
			Dim treeNode19 As Global.System.Windows.Forms.TreeNode = New Global.System.Windows.Forms.TreeNode("OSVersion : ", 2, 2)
			Dim treeNode20 As Global.System.Windows.Forms.TreeNode = New Global.System.Windows.Forms.TreeNode("RAM : ", 2, 2)
			Dim treeNode21 As Global.System.Windows.Forms.TreeNode = New Global.System.Windows.Forms.TreeNode("CPU : ", 2, 2)
			Dim treeNode22 As Global.System.Windows.Forms.TreeNode = New Global.System.Windows.Forms.TreeNode("GPU : ", 2, 2)
			Dim treeNode23 As Global.System.Windows.Forms.TreeNode = New Global.System.Windows.Forms.TreeNode("Battery : ", 2, 2)
			Dim treeNode24 As Global.System.Windows.Forms.TreeNode = New Global.System.Windows.Forms.TreeNode("Computer Started time : ", 2, 2)
			Dim treeNode25 As Global.System.Windows.Forms.TreeNode = New Global.System.Windows.Forms.TreeNode("Date :", 2, 2)
			Dim treeNode26 As Global.System.Windows.Forms.TreeNode = New Global.System.Windows.Forms.TreeNode("CAM :  ", 2, 2)
			Dim treeNode27 As Global.System.Windows.Forms.TreeNode = New Global.System.Windows.Forms.TreeNode("System Directory :", 2, 2)
			Dim treeNode28 As Global.System.Windows.Forms.TreeNode = New Global.System.Windows.Forms.TreeNode("AV : ", 2, 2)
			Dim treeNode29 As Global.System.Windows.Forms.TreeNode = New Global.System.Windows.Forms.TreeNode("System Model : ", 2, 2)
			Dim treeNode30 As Global.System.Windows.Forms.TreeNode = New Global.System.Windows.Forms.TreeNode("BIOS", 2, 2)
			Dim treeNode31 As Global.System.Windows.Forms.TreeNode = New Global.System.Windows.Forms.TreeNode("PC info", 3, 3, New Global.System.Windows.Forms.TreeNode() { treeNode12, treeNode13, treeNode14, treeNode15, treeNode16, treeNode17, treeNode18, treeNode19, treeNode20, treeNode21, treeNode22, treeNode23, treeNode24, treeNode25, treeNode26, treeNode27, treeNode28, treeNode29, treeNode30 })
			Me.ImageList1 = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.UiLabel1 = New Global.Sunny.UI.UILabel()
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.ListNode = New Global.System.Windows.Forms.TreeView()
			Me.Guna2Elipse1 = New Global.Guna.UI2.WinForms.Guna2Elipse(Me.components)
			Me.Guna2ResizeBox1 = New Global.Guna.UI2.WinForms.Guna2ResizeBox()
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.MAX = New Global.S500RAT.ValleyMax()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			MyBase.SuspendLayout()
			Me.ImageList1.ImageStream = CType(componentResourceManager.GetObject("ImageList1.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.ImageList1.TransparentColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.ImageList1.Images.SetKeyName(0, "ClientInfo.png")
			Me.ImageList1.Images.SetKeyName(1, "ConnectionInfo.png")
			Me.ImageList1.Images.SetKeyName(2, "Info.png")
			Me.ImageList1.Images.SetKeyName(3, "PCinfo.png")
			Me.Timer1.Interval = 2000
			Me.UiLabel1.AutoSize = True
			Me.UiLabel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel1.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel1.Location = New Global.System.Drawing.Point(18, 15)
			Me.UiLabel1.Name = "UiLabel1"
			Me.UiLabel1.Size = New Global.System.Drawing.Size(88, 19)
			Me.UiLabel1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLabel1.TabIndex = 339
			Me.UiLabel1.Text = "Information"
			Me.UiLabel1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(19, 39)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(200, 16)
			Me.ClientInfo.TabIndex = 340
			Me.ClientInfo.Text = "FC / Desktop_3424 / Windows 10 pro"
			Me.ListNode.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ListNode.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 48)
			Me.ListNode.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.ListNode.Font = New Global.System.Drawing.Font("Arial", 9F, Global.System.Drawing.FontStyle.Bold)
			Me.ListNode.ForeColor = Global.System.Drawing.Color.White
			Me.ListNode.ImageKey = "application-blue.png"
			Me.ListNode.ImageList = Me.ImageList1
			Me.ListNode.LineColor = Global.System.Drawing.Color.FromArgb(7, 11, 48)
			Me.ListNode.Location = New Global.System.Drawing.Point(21, 81)
			Me.ListNode.Name = "ListNode"
			treeNode.ImageIndex = 2
			treeNode.Name = "Node0"
			treeNode.SelectedImageIndex = 2
			treeNode.StateImageKey = "Info.png"
			treeNode.Text = "Name : "
			treeNode2.ImageIndex = 2
			treeNode2.Name = "Node1"
			treeNode2.SelectedImageIndex = 2
			treeNode2.StateImageKey = "Info.png"
			treeNode2.Text = "Installation Path :"
			treeNode3.ImageIndex = 2
			treeNode3.Name = "Node2"
			treeNode3.SelectedImageIndex = 2
			treeNode3.StateImageKey = "Info.png"
			treeNode3.Text = "Admin : "
			treeNode4.ImageIndex = 2
			treeNode4.Name = "Node3"
			treeNode4.SelectedImageIndex = 2
			treeNode4.StateImageKey = "Info.png"
			treeNode4.Text = "Hidden : "
			treeNode5.ImageIndex = 2
			treeNode5.Name = "Node4"
			treeNode5.SelectedImageIndex = 2
			treeNode5.StateImageKey = "Info.png"
			treeNode5.Text = "Date Installed : "
			treeNode6.ImageIndex = 0
			treeNode6.Name = "ClientInfo"
			treeNode6.SelectedImageIndex = 0
			treeNode6.StateImageKey = "(none)"
			treeNode6.Text = "Client info"
			treeNode7.ImageIndex = 2
			treeNode7.Name = "Knoten4"
			treeNode7.SelectedImageIndex = 2
			treeNode7.Text = "IP :"
			treeNode8.ImageIndex = 2
			treeNode8.Name = "Knoten5"
			treeNode8.SelectedImageIndex = 2
			treeNode8.Text = "Port : "
			treeNode9.ImageIndex = 2
			treeNode9.Name = "Knoten6"
			treeNode9.SelectedImageIndex = 2
			treeNode9.Text = "IPV4 : "
			treeNode10.ImageIndex = 2
			treeNode10.Name = "Node1"
			treeNode10.SelectedImageIndex = 2
			treeNode10.Text = "MAC : "
			treeNode11.ImageIndex = 1
			treeNode11.Name = "ConnectionInfo"
			treeNode11.SelectedImageIndex = 1
			treeNode11.Text = "Connection info"
			treeNode12.ImageIndex = 2
			treeNode12.Name = "Node6"
			treeNode12.SelectedImageIndex = 2
			treeNode12.Text = "Computer Name : "
			treeNode13.ImageIndex = 2
			treeNode13.Name = "Node8"
			treeNode13.SelectedImageIndex = 2
			treeNode13.Text = "UserDomainName : "
			treeNode14.ImageIndex = 2
			treeNode14.Name = "Node9"
			treeNode14.SelectedImageIndex = 2
			treeNode14.Text = "UserName : "
			treeNode15.ImageIndex = 2
			treeNode15.Name = "Node10"
			treeNode15.SelectedImageIndex = 2
			treeNode15.Text = "Monitor : "
			treeNode16.ImageIndex = 2
			treeNode16.Name = "Node11"
			treeNode16.SelectedImageIndex = 2
			treeNode16.Text = "Screen Sizes : "
			treeNode17.ImageIndex = 2
			treeNode17.Name = "Node12"
			treeNode17.SelectedImageIndex = 2
			treeNode17.Text = "Windows : "
			treeNode18.ImageIndex = 2
			treeNode18.Name = "Node13"
			treeNode18.SelectedImageIndex = 2
			treeNode18.Text = "OS : "
			treeNode19.ImageIndex = 2
			treeNode19.Name = "Node14"
			treeNode19.SelectedImageIndex = 2
			treeNode19.Text = "OSVersion : "
			treeNode20.ImageIndex = 2
			treeNode20.Name = "Node15"
			treeNode20.SelectedImageIndex = 2
			treeNode20.Text = "RAM : "
			treeNode21.ImageIndex = 2
			treeNode21.Name = "Node16"
			treeNode21.SelectedImageIndex = 2
			treeNode21.Text = "CPU : "
			treeNode22.ImageIndex = 2
			treeNode22.Name = "Node21"
			treeNode22.SelectedImageIndex = 2
			treeNode22.Text = "GPU : "
			treeNode23.ImageIndex = 2
			treeNode23.Name = "Node22"
			treeNode23.SelectedImageIndex = 2
			treeNode23.Text = "Battery : "
			treeNode24.ImageIndex = 2
			treeNode24.Name = "Node23"
			treeNode24.SelectedImageIndex = 2
			treeNode24.Text = "Computer Started time : "
			treeNode25.ImageIndex = 2
			treeNode25.Name = "Node24"
			treeNode25.SelectedImageIndex = 2
			treeNode25.Text = "Date :"
			treeNode26.ImageIndex = 2
			treeNode26.Name = "Node25"
			treeNode26.SelectedImageIndex = 2
			treeNode26.Text = "CAM :  "
			treeNode27.ImageIndex = 2
			treeNode27.Name = "Node27"
			treeNode27.SelectedImageIndex = 2
			treeNode27.Text = "System Directory :"
			treeNode28.ImageIndex = 2
			treeNode28.Name = "Node28"
			treeNode28.SelectedImageIndex = 2
			treeNode28.Text = "AV : "
			treeNode29.ImageIndex = 2
			treeNode29.Name = "Node29"
			treeNode29.SelectedImageIndex = 2
			treeNode29.Text = "System Model : "
			treeNode30.ImageIndex = 2
			treeNode30.Name = "Node30"
			treeNode30.SelectedImageIndex = 2
			treeNode30.Text = "BIOS"
			treeNode31.ImageIndex = 3
			treeNode31.Name = "Node12"
			treeNode31.SelectedImageIndex = 3
			treeNode31.Text = "PC info"
			Me.ListNode.Nodes.AddRange(New Global.System.Windows.Forms.TreeNode() { treeNode6, treeNode11, treeNode31 })
			Me.ListNode.SelectedImageIndex = 0
			Me.ListNode.Size = New Global.System.Drawing.Size(553, 439)
			Me.ListNode.TabIndex = 344
			Me.Guna2Elipse1.BorderRadius = 20
			Me.Guna2Elipse1.TargetControl = Me.ListNode
			Me.Guna2ResizeBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Guna2ResizeBox1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Guna2ResizeBox1.FillColor = Global.System.Drawing.Color.Silver
			Me.Guna2ResizeBox1.ForeColor = Global.System.Drawing.Color.Empty
			Me.Guna2ResizeBox1.Location = New Global.System.Drawing.Point(576, 516)
			Me.Guna2ResizeBox1.Name = "Guna2ResizeBox1"
			Me.Guna2ResizeBox1.Size = New Global.System.Drawing.Size(17, 19)
			Me.Guna2ResizeBox1.TabIndex = 513
			Me.Guna2ResizeBox1.TargetControl = Me
			Me.Guna2ResizeBox1.UseTransparentBackground = True
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
			Me.Mini.Location = New Global.System.Drawing.Point(527, 12)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 589
			Me.Mini.Text = "ValleyMini1"
			Me.MAX.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.MAX.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.MAX.Location = New Global.System.Drawing.Point(549, 12)
			Me.MAX.Name = "MAX"
			Me.MAX.Size = New Global.System.Drawing.Size(20, 20)
			Me.MAX.TabIndex = 588
			Me.MAX.Text = "ValleyMax1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(571, 12)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 587
			Me.ExitForm.Text = "ValleyClose1"
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(96F, 96F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Dpi
			Me.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			MyBase.ClientSize = New Global.System.Drawing.Size(603, 546)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.MAX)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.Guna2ResizeBox1)
			MyBase.Controls.Add(Me.ListNode)
			MyBase.Controls.Add(Me.UiLabel1)
			MyBase.Controls.Add(Me.ClientInfo)
			Me.DoubleBuffered = True
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "FormInformation"
			Me.Text = "FormInformation"
			MyBase.TopMost = True
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0400027D RID: 637
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
