Namespace S500RAT
	' Token: 0x0200001A RID: 26
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormFileManager
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060002AD RID: 685 RVA: 0x00015EBC File Offset: 0x000140BC
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

		' Token: 0x060002AE RID: 686 RVA: 0x00015F0C File Offset: 0x0001410C
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormFileManager))
			Dim listViewGroup As Global.System.Windows.Forms.ListViewGroup = New Global.System.Windows.Forms.ListViewGroup("Folder", Global.System.Windows.Forms.HorizontalAlignment.Left)
			Dim listViewGroup2 As Global.System.Windows.Forms.ListViewGroup = New Global.System.Windows.Forms.ListViewGroup("Files", Global.System.Windows.Forms.HorizontalAlignment.Left)
			Dim listViewGroup3 As Global.System.Windows.Forms.ListViewGroup = New Global.System.Windows.Forms.ListViewGroup("Folder", Global.System.Windows.Forms.HorizontalAlignment.Left)
			Dim listViewGroup4 As Global.System.Windows.Forms.ListViewGroup = New Global.System.Windows.Forms.ListViewGroup("Devices and Drives", Global.System.Windows.Forms.HorizontalAlignment.Left)
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.UiLabel1 = New Global.Sunny.UI.UILabel()
			Me.pr = New Global.Guna.UI2.WinForms.Guna2ProgressBar()
			Me.ButtionPC = New Global.Guna.UI2.WinForms.Guna2ImageButton()
			Me.MeduamIcons = New Global.Guna.UI2.WinForms.Guna2ImageButton()
			Me.ListIcons = New Global.Guna.UI2.WinForms.Guna2ImageButton()
			Me.TextBox1 = New Global.Guna.UI2.WinForms.Guna2TextBox()
			Me.Search = New Global.Guna.UI2.WinForms.Guna2TextBox()
			Me.L2 = New Global.System.Windows.Forms.ListView()
			Me.ColumnHeader1 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader2 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader3 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader6 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ContextMenuControl = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.COpen = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CNormal = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CHiden = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CRunAdmin = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CRefresh = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CAddArchive = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CExtractHere = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CFilesexcrypt = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CEncrypt = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CDecrypt = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CFolderLock = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CLock = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.cUnlock = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CDownload = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CUploadFromLink = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CUpload = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CRename = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CEditor = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CCopy = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CCut = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CPast = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CNew = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CNewFolder = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CNewEmptyFile = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CShortCut = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CHide = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CShow = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CDelete = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.COpenDownloadFolder = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.imageList1 = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.MG = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.Guna2ResizeBox1 = New Global.Guna.UI2.WinForms.Guna2ResizeBox()
			Me.ManagrLogs = New Global.System.Windows.Forms.LinkLabel()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.FolderLen = New Global.System.Windows.Forms.Label()
			Me.L1 = New Global.System.Windows.Forms.ListView()
			Me.ColumnHeader4 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader5 = New Global.System.Windows.Forms.ColumnHeader()
			Me.SelectedItiemsL2 = New Global.System.Windows.Forms.Label()
			Me.Timer2 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.TimerClose = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.MAX = New Global.S500RAT.ValleyMax()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			Me.ContextMenuControl.SuspendLayout()
			MyBase.SuspendLayout()
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(19, 32)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(200, 16)
			Me.ClientInfo.TabIndex = 303
			Me.ClientInfo.Text = "FC / Desktop_3424 / Windows 10 pro"
			Me.UiLabel1.AutoSize = True
			Me.UiLabel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel1.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel1.Location = New Global.System.Drawing.Point(18, 8)
			Me.UiLabel1.Name = "UiLabel1"
			Me.UiLabel1.Size = New Global.System.Drawing.Size(96, 19)
			Me.UiLabel1.TabIndex = 302
			Me.UiLabel1.Text = "File Manager"
			Me.UiLabel1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.pr.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.pr.FillColor = Global.System.Drawing.Color.FromArgb(23, 27, 82)
			Me.pr.GradientMode = Global.System.Drawing.Drawing2D.LinearGradientMode.Horizontal
			Me.pr.Location = New Global.System.Drawing.Point(15, 125)
			Me.pr.Name = "pr"
			Me.pr.ProgressColor = Global.System.Drawing.Color.FromArgb(79, 46, 208)
			Me.pr.ProgressColor2 = Global.System.Drawing.Color.FromArgb(79, 46, 208)
			Me.pr.ShadowDecoration.Parent = Me.pr
			Me.pr.Size = New Global.System.Drawing.Size(486, 11)
			Me.pr.TabIndex = 59
			Me.pr.TextRenderingHint = Global.System.Drawing.Text.TextRenderingHint.SystemDefault
			Me.ButtionPC.CheckedState.ImageSize = New Global.System.Drawing.Size(64, 64)
			Me.ButtionPC.CheckedState.Parent = Me.ButtionPC
			Me.ButtionPC.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ButtionPC.HoverState.Image = CType(componentResourceManager.GetObject("ButtionPC.HoverState.Image"), Global.System.Drawing.Image)
			Me.ButtionPC.HoverState.ImageSize = New Global.System.Drawing.Size(36, 36)
			Me.ButtionPC.HoverState.Parent = Me.ButtionPC
			Me.ButtionPC.Image = CType(componentResourceManager.GetObject("ButtionPC.Image"), Global.System.Drawing.Image)
			Me.ButtionPC.ImageRotate = 0F
			Me.ButtionPC.ImageSize = New Global.System.Drawing.Size(32, 32)
			Me.ButtionPC.Location = New Global.System.Drawing.Point(15, 94)
			Me.ButtionPC.Name = "ButtionPC"
			Me.ButtionPC.PressedState.Image = CType(componentResourceManager.GetObject("ButtionPC.PressedState.Image"), Global.System.Drawing.Image)
			Me.ButtionPC.PressedState.ImageSize = New Global.System.Drawing.Size(40, 40)
			Me.ButtionPC.PressedState.Parent = Me.ButtionPC
			Me.ButtionPC.Size = New Global.System.Drawing.Size(27, 30)
			Me.ButtionPC.TabIndex = 56
			Me.MeduamIcons.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.MeduamIcons.CheckedState.ImageSize = New Global.System.Drawing.Size(64, 64)
			Me.MeduamIcons.CheckedState.Parent = Me.MeduamIcons
			Me.MeduamIcons.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.MeduamIcons.HoverState.Image = CType(componentResourceManager.GetObject("MeduamIcons.HoverState.Image"), Global.System.Drawing.Image)
			Me.MeduamIcons.HoverState.ImageSize = New Global.System.Drawing.Size(38, 38)
			Me.MeduamIcons.HoverState.Parent = Me.MeduamIcons
			Me.MeduamIcons.Image = CType(componentResourceManager.GetObject("MeduamIcons.Image"), Global.System.Drawing.Image)
			Me.MeduamIcons.ImageRotate = 0F
			Me.MeduamIcons.ImageSize = New Global.System.Drawing.Size(32, 32)
			Me.MeduamIcons.Location = New Global.System.Drawing.Point(751, 94)
			Me.MeduamIcons.Name = "MeduamIcons"
			Me.MeduamIcons.PressedState.Image = CType(componentResourceManager.GetObject("MeduamIcons.PressedState.Image"), Global.System.Drawing.Image)
			Me.MeduamIcons.PressedState.ImageSize = New Global.System.Drawing.Size(38, 38)
			Me.MeduamIcons.PressedState.Parent = Me.MeduamIcons
			Me.MeduamIcons.Size = New Global.System.Drawing.Size(29, 27)
			Me.MeduamIcons.TabIndex = 54
			Me.ListIcons.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ListIcons.BackColor = Global.System.Drawing.Color.Transparent
			Me.ListIcons.CheckedState.ImageSize = New Global.System.Drawing.Size(64, 64)
			Me.ListIcons.CheckedState.Parent = Me.ListIcons
			Me.ListIcons.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ListIcons.HoverState.Image = CType(componentResourceManager.GetObject("ListIcons.HoverState.Image"), Global.System.Drawing.Image)
			Me.ListIcons.HoverState.ImageSize = New Global.System.Drawing.Size(38, 38)
			Me.ListIcons.HoverState.Parent = Me.ListIcons
			Me.ListIcons.Image = CType(componentResourceManager.GetObject("ListIcons.Image"), Global.System.Drawing.Image)
			Me.ListIcons.ImageRotate = 0F
			Me.ListIcons.ImageSize = New Global.System.Drawing.Size(32, 32)
			Me.ListIcons.IndicateFocus = True
			Me.ListIcons.Location = New Global.System.Drawing.Point(717, 94)
			Me.ListIcons.Name = "ListIcons"
			Me.ListIcons.PressedState.Image = CType(componentResourceManager.GetObject("ListIcons.PressedState.Image"), Global.System.Drawing.Image)
			Me.ListIcons.PressedState.ImageSize = New Global.System.Drawing.Size(38, 38)
			Me.ListIcons.PressedState.Parent = Me.ListIcons
			Me.ListIcons.Size = New Global.System.Drawing.Size(29, 27)
			Me.ListIcons.TabIndex = 55
			Me.ListIcons.UseTransparentBackground = True
			Me.TextBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.TextBox1.Animated = True
			Me.TextBox1.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.TextBox1.BorderColor = Global.System.Drawing.Color.FromArgb(82, 43, 235)
			Me.TextBox1.BorderRadius = 7
			Me.TextBox1.BorderStyle = Global.System.Drawing.Drawing2D.DashStyle.Custom
			Me.TextBox1.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.TextBox1.DefaultText = ""
			Me.TextBox1.DisabledState.BorderColor = Global.System.Drawing.Color.FromArgb(208, 208, 208)
			Me.TextBox1.DisabledState.FillColor = Global.System.Drawing.Color.FromArgb(226, 226, 226)
			Me.TextBox1.DisabledState.ForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.TextBox1.DisabledState.Parent = Me.TextBox1
			Me.TextBox1.DisabledState.PlaceholderForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.TextBox1.FillColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.TextBox1.FocusedState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.TextBox1.FocusedState.Parent = Me.TextBox1
			Me.TextBox1.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 9F, Global.System.Drawing.FontStyle.Bold)
			Me.TextBox1.ForeColor = Global.System.Drawing.Color.White
			Me.TextBox1.HoverState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.TextBox1.HoverState.Parent = Me.TextBox1
			Me.TextBox1.IconLeft = CType(componentResourceManager.GetObject("TextBox1.IconLeft"), Global.System.Drawing.Image)
			Me.TextBox1.IconLeftCursor = Global.System.Windows.Forms.Cursors.Hand
			Me.TextBox1.IconRight = CType(componentResourceManager.GetObject("TextBox1.IconRight"), Global.System.Drawing.Image)
			Me.TextBox1.IconRightCursor = Global.System.Windows.Forms.Cursors.Hand
			Me.TextBox1.Location = New Global.System.Drawing.Point(48, 94)
			Me.TextBox1.Margin = New Global.System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.TextBox1.Name = "TextBox1"
			Me.TextBox1.PasswordChar = vbNullChar
			Me.TextBox1.PlaceholderForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.TextBox1.PlaceholderText = "This PC"
			Me.TextBox1.SelectedText = ""
			Me.TextBox1.ShadowDecoration.Parent = Me.TextBox1
			Me.TextBox1.Size = New Global.System.Drawing.Size(453, 27)
			Me.TextBox1.Style = Global.Guna.UI2.WinForms.Enums.TextBoxStyle.Material
			Me.TextBox1.TabIndex = 456
			Me.Search.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Search.Animated = True
			Me.Search.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.Search.BorderColor = Global.System.Drawing.Color.FromArgb(82, 43, 235)
			Me.Search.BorderRadius = 7
			Me.Search.BorderStyle = Global.System.Drawing.Drawing2D.DashStyle.Custom
			Me.Search.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.Search.DefaultText = ""
			Me.Search.DisabledState.Parent = Me.Search
			Me.Search.FillColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.Search.FocusedState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.Search.FocusedState.Parent = Me.Search
			Me.Search.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 9F, Global.System.Drawing.FontStyle.Bold)
			Me.Search.ForeColor = Global.System.Drawing.Color.White
			Me.Search.HoverState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.Search.HoverState.Parent = Me.Search
			Me.Search.IconLeftCursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Search.IconRight = CType(componentResourceManager.GetObject("Search.IconRight"), Global.System.Drawing.Image)
			Me.Search.IconRightCursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Search.Location = New Global.System.Drawing.Point(507, 94)
			Me.Search.Margin = New Global.System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.Search.Name = "Search"
			Me.Search.PasswordChar = vbNullChar
			Me.Search.PlaceholderForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.Search.PlaceholderText = "Search"
			Me.Search.SelectedText = ""
			Me.Search.ShadowDecoration.Parent = Me.Search
			Me.Search.Size = New Global.System.Drawing.Size(205, 27)
			Me.Search.Style = Global.Guna.UI2.WinForms.Enums.TextBoxStyle.Material
			Me.Search.TabIndex = 457
			Me.L2.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.L2.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 48)
			Me.L2.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.L2.Columns.AddRange(New Global.System.Windows.Forms.ColumnHeader() { Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader6 })
			Me.L2.ContextMenuStrip = Me.ContextMenuControl
			Me.L2.ForeColor = Global.System.Drawing.Color.White
			Me.L2.FullRowSelect = True
			listViewGroup.Header = "Folder"
			listViewGroup.Name = "Folder"
			listViewGroup2.Header = "Files"
			listViewGroup2.Name = "Files"
			Me.L2.Groups.AddRange(New Global.System.Windows.Forms.ListViewGroup() { listViewGroup, listViewGroup2 })
			Me.L2.HideSelection = False
			Me.L2.LargeImageList = Me.imageList1
			Me.L2.Location = New Global.System.Drawing.Point(15, 165)
			Me.L2.Name = "L2"
			Me.L2.Size = New Global.System.Drawing.Size(768, 365)
			Me.L2.SmallImageList = Me.imageList1
			Me.L2.StateImageList = Me.imageList1
			Me.L2.TabIndex = 463
			Me.L2.UseCompatibleStateImageBehavior = False
			Me.L2.View = Global.System.Windows.Forms.View.Details
			Me.ColumnHeader1.Text = "Name"
			Me.ColumnHeader1.Width = 190
			Me.ColumnHeader2.Text = "Date modified"
			Me.ColumnHeader2.Width = 285
			Me.ColumnHeader3.Text = "Type"
			Me.ColumnHeader3.Width = 189
			Me.ColumnHeader6.Text = "Size"
			Me.ColumnHeader6.Width = 228
			Me.ContextMenuControl.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ContextMenuControl.ImageScalingSize = New Global.System.Drawing.Size(20, 20)
			Me.ContextMenuControl.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.COpen, Me.CRefresh, Me.CAddArchive, Me.CExtractHere, Me.CFilesexcrypt, Me.CFolderLock, Me.CDownload, Me.CUploadFromLink, Me.CUpload, Me.CRename, Me.CEditor, Me.CCopy, Me.CCut, Me.CPast, Me.CNew, Me.CHide, Me.CShow, Me.CDelete, Me.COpenDownloadFolder })
			Me.ContextMenuControl.Name = "ContextMenuStrip1"
			Me.ContextMenuControl.Size = New Global.System.Drawing.Size(203, 498)
			Me.COpen.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.COpen.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.CNormal, Me.CHiden, Me.CRunAdmin })
			Me.COpen.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.COpen.Image = CType(componentResourceManager.GetObject("COpen.Image"), Global.System.Drawing.Image)
			Me.COpen.Name = "COpen"
			Me.COpen.Size = New Global.System.Drawing.Size(202, 26)
			Me.COpen.Text = "Open"
			Me.CNormal.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.CNormal.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.CNormal.Image = CType(componentResourceManager.GetObject("CNormal.Image"), Global.System.Drawing.Image)
			Me.CNormal.Name = "CNormal"
			Me.CNormal.Size = New Global.System.Drawing.Size(193, 26)
			Me.CNormal.Text = "Normal"
			Me.CHiden.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.CHiden.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.CHiden.Image = CType(componentResourceManager.GetObject("CHiden.Image"), Global.System.Drawing.Image)
			Me.CHiden.Name = "CHiden"
			Me.CHiden.Size = New Global.System.Drawing.Size(193, 26)
			Me.CHiden.Text = "Hiden"
			Me.CRunAdmin.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.CRunAdmin.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.CRunAdmin.Image = CType(componentResourceManager.GetObject("CRunAdmin.Image"), Global.System.Drawing.Image)
			Me.CRunAdmin.Name = "CRunAdmin"
			Me.CRunAdmin.Size = New Global.System.Drawing.Size(193, 26)
			Me.CRunAdmin.Text = "Run as administrator"
			Me.CRefresh.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.CRefresh.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.CRefresh.Image = CType(componentResourceManager.GetObject("CRefresh.Image"), Global.System.Drawing.Image)
			Me.CRefresh.Name = "CRefresh"
			Me.CRefresh.Size = New Global.System.Drawing.Size(202, 26)
			Me.CRefresh.Text = "Refresh"
			Me.CAddArchive.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.CAddArchive.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.CAddArchive.Image = CType(componentResourceManager.GetObject("CAddArchive.Image"), Global.System.Drawing.Image)
			Me.CAddArchive.Name = "CAddArchive"
			Me.CAddArchive.Size = New Global.System.Drawing.Size(202, 26)
			Me.CAddArchive.Text = "Add Archive"
			Me.CExtractHere.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.CExtractHere.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.CExtractHere.Image = CType(componentResourceManager.GetObject("CExtractHere.Image"), Global.System.Drawing.Image)
			Me.CExtractHere.Name = "CExtractHere"
			Me.CExtractHere.Size = New Global.System.Drawing.Size(202, 26)
			Me.CExtractHere.Text = "Extract Here"
			Me.CFilesexcrypt.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.CFilesexcrypt.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.CEncrypt, Me.CDecrypt })
			Me.CFilesexcrypt.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.CFilesexcrypt.Image = CType(componentResourceManager.GetObject("CFilesexcrypt.Image"), Global.System.Drawing.Image)
			Me.CFilesexcrypt.Name = "CFilesexcrypt"
			Me.CFilesexcrypt.Size = New Global.System.Drawing.Size(202, 26)
			Me.CFilesexcrypt.Text = "Files Encryp"
			Me.CEncrypt.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.CEncrypt.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.CEncrypt.Image = CType(componentResourceManager.GetObject("CEncrypt.Image"), Global.System.Drawing.Image)
			Me.CEncrypt.Name = "CEncrypt"
			Me.CEncrypt.Size = New Global.System.Drawing.Size(120, 26)
			Me.CEncrypt.Text = "Encrypt"
			Me.CDecrypt.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.CDecrypt.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.CDecrypt.Image = CType(componentResourceManager.GetObject("CDecrypt.Image"), Global.System.Drawing.Image)
			Me.CDecrypt.Name = "CDecrypt"
			Me.CDecrypt.Size = New Global.System.Drawing.Size(120, 26)
			Me.CDecrypt.Text = "Decrypt"
			Me.CFolderLock.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.CFolderLock.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.CLock, Me.cUnlock })
			Me.CFolderLock.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.CFolderLock.Image = CType(componentResourceManager.GetObject("CFolderLock.Image"), Global.System.Drawing.Image)
			Me.CFolderLock.Name = "CFolderLock"
			Me.CFolderLock.Size = New Global.System.Drawing.Size(202, 26)
			Me.CFolderLock.Text = "Folder Lock"
			Me.CLock.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.CLock.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.CLock.Image = CType(componentResourceManager.GetObject("CLock.Image"), Global.System.Drawing.Image)
			Me.CLock.Name = "CLock"
			Me.CLock.Size = New Global.System.Drawing.Size(115, 26)
			Me.CLock.Text = "Lock"
			Me.cUnlock.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.cUnlock.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.cUnlock.Image = CType(componentResourceManager.GetObject("cUnlock.Image"), Global.System.Drawing.Image)
			Me.cUnlock.Name = "cUnlock"
			Me.cUnlock.Size = New Global.System.Drawing.Size(115, 26)
			Me.cUnlock.Text = "Unlock"
			Me.CDownload.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.CDownload.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.CDownload.Image = CType(componentResourceManager.GetObject("CDownload.Image"), Global.System.Drawing.Image)
			Me.CDownload.Name = "CDownload"
			Me.CDownload.Size = New Global.System.Drawing.Size(202, 26)
			Me.CDownload.Text = "Download"
			Me.CUploadFromLink.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.CUploadFromLink.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.CUploadFromLink.Image = CType(componentResourceManager.GetObject("CUploadFromLink.Image"), Global.System.Drawing.Image)
			Me.CUploadFromLink.Name = "CUploadFromLink"
			Me.CUploadFromLink.Size = New Global.System.Drawing.Size(202, 26)
			Me.CUploadFromLink.Text = "Upload From Link "
			Me.CUpload.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.CUpload.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.CUpload.Image = CType(componentResourceManager.GetObject("CUpload.Image"), Global.System.Drawing.Image)
			Me.CUpload.Name = "CUpload"
			Me.CUpload.Size = New Global.System.Drawing.Size(202, 26)
			Me.CUpload.Text = "Upload"
			Me.CRename.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.CRename.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.CRename.Image = CType(componentResourceManager.GetObject("CRename.Image"), Global.System.Drawing.Image)
			Me.CRename.Name = "CRename"
			Me.CRename.Size = New Global.System.Drawing.Size(202, 26)
			Me.CRename.Text = "Rename"
			Me.CEditor.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.CEditor.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.CEditor.Image = CType(componentResourceManager.GetObject("CEditor.Image"), Global.System.Drawing.Image)
			Me.CEditor.Name = "CEditor"
			Me.CEditor.Size = New Global.System.Drawing.Size(202, 26)
			Me.CEditor.Text = "Editor"
			Me.CCopy.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.CCopy.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.CCopy.Image = CType(componentResourceManager.GetObject("CCopy.Image"), Global.System.Drawing.Image)
			Me.CCopy.Name = "CCopy"
			Me.CCopy.Size = New Global.System.Drawing.Size(202, 26)
			Me.CCopy.Text = "Copy"
			Me.CCut.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.CCut.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.CCut.Image = CType(componentResourceManager.GetObject("CCut.Image"), Global.System.Drawing.Image)
			Me.CCut.Name = "CCut"
			Me.CCut.Size = New Global.System.Drawing.Size(202, 26)
			Me.CCut.Text = "Cut"
			Me.CPast.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.CPast.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.CPast.Image = CType(componentResourceManager.GetObject("CPast.Image"), Global.System.Drawing.Image)
			Me.CPast.Name = "CPast"
			Me.CPast.Size = New Global.System.Drawing.Size(202, 26)
			Me.CPast.Text = "Paste"
			Me.CNew.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.CNew.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.CNewFolder, Me.CNewEmptyFile, Me.CShortCut })
			Me.CNew.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.CNew.Image = CType(componentResourceManager.GetObject("CNew.Image"), Global.System.Drawing.Image)
			Me.CNew.Name = "CNew"
			Me.CNew.Size = New Global.System.Drawing.Size(202, 26)
			Me.CNew.Text = "New"
			Me.CNewFolder.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.CNewFolder.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.CNewFolder.Image = CType(componentResourceManager.GetObject("CNewFolder.Image"), Global.System.Drawing.Image)
			Me.CNewFolder.Name = "CNewFolder"
			Me.CNewFolder.Size = New Global.System.Drawing.Size(134, 26)
			Me.CNewFolder.Text = "Folder"
			Me.CNewEmptyFile.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.CNewEmptyFile.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.CNewEmptyFile.Image = CType(componentResourceManager.GetObject("CNewEmptyFile.Image"), Global.System.Drawing.Image)
			Me.CNewEmptyFile.Name = "CNewEmptyFile"
			Me.CNewEmptyFile.Size = New Global.System.Drawing.Size(134, 26)
			Me.CNewEmptyFile.Text = "Empty File"
			Me.CShortCut.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.CShortCut.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.CShortCut.Image = CType(componentResourceManager.GetObject("CShortCut.Image"), Global.System.Drawing.Image)
			Me.CShortCut.Name = "CShortCut"
			Me.CShortCut.Size = New Global.System.Drawing.Size(134, 26)
			Me.CShortCut.Text = "ShortCut"
			Me.CHide.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.CHide.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.CHide.Image = CType(componentResourceManager.GetObject("CHide.Image"), Global.System.Drawing.Image)
			Me.CHide.Name = "CHide"
			Me.CHide.Size = New Global.System.Drawing.Size(202, 26)
			Me.CHide.Text = "Hide"
			Me.CShow.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.CShow.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.CShow.Image = CType(componentResourceManager.GetObject("CShow.Image"), Global.System.Drawing.Image)
			Me.CShow.Name = "CShow"
			Me.CShow.Size = New Global.System.Drawing.Size(202, 26)
			Me.CShow.Text = "Show"
			Me.CDelete.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.CDelete.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.CDelete.Image = CType(componentResourceManager.GetObject("CDelete.Image"), Global.System.Drawing.Image)
			Me.CDelete.Name = "CDelete"
			Me.CDelete.Size = New Global.System.Drawing.Size(202, 26)
			Me.CDelete.Text = "Delete"
			Me.COpenDownloadFolder.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.COpenDownloadFolder.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.COpenDownloadFolder.Image = CType(componentResourceManager.GetObject("COpenDownloadFolder.Image"), Global.System.Drawing.Image)
			Me.COpenDownloadFolder.Name = "COpenDownloadFolder"
			Me.COpenDownloadFolder.Size = New Global.System.Drawing.Size(202, 26)
			Me.COpenDownloadFolder.Text = "Open Download Folder"
			Me.imageList1.ImageStream = CType(componentResourceManager.GetObject("imageList1.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.imageList1.TransparentColor = Global.System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "Folder.png")
			Me.MG.ImageStream = CType(componentResourceManager.GetObject("MG.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.MG.TransparentColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.MG.Images.SetKeyName(0, "Folder.png")
			Me.MG.Images.SetKeyName(1, "Disk.png")
			Me.MG.Images.SetKeyName(2, "DVD.png")
			Me.MG.Images.SetKeyName(3, "USB.png")
			Me.MG.Images.SetKeyName(4, "DiskNewtwork.png")
			Me.MG.Images.SetKeyName(5, "DesktopFolder.png")
			Me.MG.Images.SetKeyName(6, "Picture.png")
			Me.MG.Images.SetKeyName(7, "Movie.png")
			Me.MG.Images.SetKeyName(8, "Documents.png")
			Me.MG.Images.SetKeyName(9, "Download.png")
			Me.MG.Images.SetKeyName(10, "DiskC.png")
			Me.MG.Images.SetKeyName(11, "Backs.png")
			Me.MG.Images.SetKeyName(12, "FileEmty.png")
			Me.MG.Images.SetKeyName(13, "Music.png")
			Me.Guna2ResizeBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Guna2ResizeBox1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Guna2ResizeBox1.FillColor = Global.System.Drawing.Color.Silver
			Me.Guna2ResizeBox1.ForeColor = Global.System.Drawing.Color.Empty
			Me.Guna2ResizeBox1.Location = New Global.System.Drawing.Point(766, 536)
			Me.Guna2ResizeBox1.Name = "Guna2ResizeBox1"
			Me.Guna2ResizeBox1.Size = New Global.System.Drawing.Size(17, 19)
			Me.Guna2ResizeBox1.TabIndex = 287
			Me.Guna2ResizeBox1.TargetControl = Me
			Me.Guna2ResizeBox1.UseTransparentBackground = True
			Me.ManagrLogs.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.ManagrLogs.AutoSize = True
			Me.ManagrLogs.LinkColor = Global.System.Drawing.Color.White
			Me.ManagrLogs.Location = New Global.System.Drawing.Point(19, 544)
			Me.ManagrLogs.Name = "ManagrLogs"
			Me.ManagrLogs.Size = New Global.System.Drawing.Size(16, 13)
			Me.ManagrLogs.TabIndex = 467
			Me.ManagrLogs.TabStop = True
			Me.ManagrLogs.Text = "..."
			Me.Timer1.Interval = 1000
			Me.FolderLen.AutoSize = True
			Me.FolderLen.BackColor = Global.System.Drawing.Color.Transparent
			Me.FolderLen.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.FolderLen.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.FolderLen.Location = New Global.System.Drawing.Point(18, 142)
			Me.FolderLen.Name = "FolderLen"
			Me.FolderLen.Size = New Global.System.Drawing.Size(13, 14)
			Me.FolderLen.TabIndex = 469
			Me.FolderLen.Text = ".."
			Me.L1.AllowColumnReorder = True
			Me.L1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.L1.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 48)
			Me.L1.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.L1.Columns.AddRange(New Global.System.Windows.Forms.ColumnHeader() { Me.ColumnHeader4, Me.ColumnHeader5 })
			Me.L1.ForeColor = Global.System.Drawing.Color.White
			listViewGroup3.Header = "Folder"
			listViewGroup3.Name = "Folder"
			listViewGroup4.Header = "Devices and Drives"
			listViewGroup4.Name = "Devices and Drives"
			Me.L1.Groups.AddRange(New Global.System.Windows.Forms.ListViewGroup() { listViewGroup3, listViewGroup4 })
			Me.L1.HeaderStyle = Global.System.Windows.Forms.ColumnHeaderStyle.None
			Me.L1.HideSelection = False
			Me.L1.LargeImageList = Me.MG
			Me.L1.Location = New Global.System.Drawing.Point(15, 165)
			Me.L1.Margin = New Global.System.Windows.Forms.Padding(2)
			Me.L1.Name = "L1"
			Me.L1.ShowItemToolTips = True
			Me.L1.Size = New Global.System.Drawing.Size(769, 378)
			Me.L1.SmallImageList = Me.MG
			Me.L1.StateImageList = Me.MG
			Me.L1.TabIndex = 470
			Me.L1.UseCompatibleStateImageBehavior = False
			Me.L1.View = Global.System.Windows.Forms.View.Tile
			Me.SelectedItiemsL2.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.SelectedItiemsL2.AutoSize = True
			Me.SelectedItiemsL2.BackColor = Global.System.Drawing.Color.Transparent
			Me.SelectedItiemsL2.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.SelectedItiemsL2.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.SelectedItiemsL2.Location = New Global.System.Drawing.Point(507, 125)
			Me.SelectedItiemsL2.Name = "SelectedItiemsL2"
			Me.SelectedItiemsL2.Size = New Global.System.Drawing.Size(13, 14)
			Me.SelectedItiemsL2.TabIndex = 471
			Me.SelectedItiemsL2.Text = ".."
			Me.Timer2.Enabled = True
			Me.TimerClose.Enabled = True
			Me.TimerClose.Interval = 1000
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
			Me.Mini.Location = New Global.System.Drawing.Point(706, 12)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 583
			Me.Mini.Text = "ValleyMini1"
			Me.MAX.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.MAX.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.MAX.Location = New Global.System.Drawing.Point(732, 12)
			Me.MAX.Name = "MAX"
			Me.MAX.Size = New Global.System.Drawing.Size(20, 20)
			Me.MAX.TabIndex = 582
			Me.MAX.Text = "ValleyMax1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(758, 12)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 581
			Me.ExitForm.Text = "ValleyClose1"
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(96F, 96F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Dpi
			Me.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			MyBase.ClientSize = New Global.System.Drawing.Size(794, 565)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.MAX)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.SelectedItiemsL2)
			MyBase.Controls.Add(Me.L1)
			MyBase.Controls.Add(Me.FolderLen)
			MyBase.Controls.Add(Me.ManagrLogs)
			MyBase.Controls.Add(Me.L2)
			MyBase.Controls.Add(Me.Search)
			MyBase.Controls.Add(Me.TextBox1)
			MyBase.Controls.Add(Me.Guna2ResizeBox1)
			MyBase.Controls.Add(Me.UiLabel1)
			MyBase.Controls.Add(Me.MeduamIcons)
			MyBase.Controls.Add(Me.ListIcons)
			MyBase.Controls.Add(Me.pr)
			MyBase.Controls.Add(Me.ButtionPC)
			MyBase.Controls.Add(Me.ClientInfo)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "FormFileManager"
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.Manual
			Me.Text = "FileManager"
			MyBase.TopMost = True
			Me.ContextMenuControl.ResumeLayout(False)
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0400013F RID: 319
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
