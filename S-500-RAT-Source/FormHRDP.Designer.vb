Namespace S500RAT
	' Token: 0x0200001E RID: 30
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormHRDP
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060004BB RID: 1211 RVA: 0x00028F08 File Offset: 0x00027108
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

		' Token: 0x060004BC RID: 1212 RVA: 0x00028F58 File Offset: 0x00027158
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormHRDP))
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle3 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.RemoveRDP = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.CreateRDP = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.UiLabel1 = New Global.Sunny.UI.UILabel()
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.GroupBox2 = New Global.Guna.UI2.WinForms.Guna2GroupBox()
			Me.StateNagrok = New Global.System.Windows.Forms.Label()
			Me.YourAuthtoken = New Global.Guna.UI2.WinForms.Guna2TextBox()
			Me.ConnectNgrok = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.PictureBox17 = New Global.System.Windows.Forms.PictureBox()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.PasswordHRDP = New Global.Guna.UI2.WinForms.Guna2TextBox()
			Me.HostNgrok = New Global.Guna.UI2.WinForms.Guna2TextBox()
			Me.ListHRDP = New Global.System.Windows.Forms.DataGridView()
			Me.Column22 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column23 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.ControllContextMenuStrip = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.KillProcess = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.RefreshList = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.RestartProcess = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.UsernameRDP = New Global.Guna.UI2.WinForms.Guna2TextBox()
			Me.InstallAndUnstalRDP = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.GroupBox1 = New Global.Guna.UI2.WinForms.Guna2GroupBox()
			Me.StateInstalRDP = New Global.System.Windows.Forms.Label()
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.StateHRDP = New Global.System.Windows.Forms.Label()
			Me.Guna2ResizeBox2 = New Global.Guna.UI2.WinForms.Guna2ResizeBox()
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			Me.GroupBox2.SuspendLayout()
			CType(Me.PictureBox17, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ListHRDP, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.ControllContextMenuStrip.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.Timer1.Interval = 2000
			Me.RemoveRDP.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.RemoveRDP.BackColor = Global.System.Drawing.Color.Transparent
			Me.RemoveRDP.BorderRadius = 8
			Me.RemoveRDP.CheckedState.Parent = Me.RemoveRDP
			Me.RemoveRDP.CustomImages.Parent = Me.RemoveRDP
			Me.RemoveRDP.FillColor = Global.System.Drawing.Color.FromArgb(192, 64, 0)
			Me.RemoveRDP.FillColor2 = Global.System.Drawing.Color.FromArgb(255, 128, 0)
			Me.RemoveRDP.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.RemoveRDP.ForeColor = Global.System.Drawing.Color.White
			Me.RemoveRDP.HoverState.Parent = Me.RemoveRDP
			Me.RemoveRDP.Location = New Global.System.Drawing.Point(271, 270)
			Me.RemoveRDP.Name = "RemoveRDP"
			Me.RemoveRDP.ShadowDecoration.Parent = Me.RemoveRDP
			Me.RemoveRDP.Size = New Global.System.Drawing.Size(91, 32)
			Me.RemoveRDP.TabIndex = 532
			Me.RemoveRDP.Text = "Remove"
			Me.CreateRDP.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.CreateRDP.BackColor = Global.System.Drawing.Color.Transparent
			Me.CreateRDP.BorderRadius = 8
			Me.CreateRDP.CheckedState.Parent = Me.CreateRDP
			Me.CreateRDP.CustomImages.Parent = Me.CreateRDP
			Me.CreateRDP.FillColor = Global.System.Drawing.Color.FromArgb(26, 155, 161)
			Me.CreateRDP.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 155, 161)
			Me.CreateRDP.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.CreateRDP.ForeColor = Global.System.Drawing.Color.White
			Me.CreateRDP.HoverState.Parent = Me.CreateRDP
			Me.CreateRDP.Location = New Global.System.Drawing.Point(367, 270)
			Me.CreateRDP.Name = "CreateRDP"
			Me.CreateRDP.ShadowDecoration.Parent = Me.CreateRDP
			Me.CreateRDP.Size = New Global.System.Drawing.Size(121, 32)
			Me.CreateRDP.TabIndex = 530
			Me.CreateRDP.Text = "Create"
			Me.UiLabel1.AutoSize = True
			Me.UiLabel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel1.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel1.Location = New Global.System.Drawing.Point(13, 11)
			Me.UiLabel1.Name = "UiLabel1"
			Me.UiLabel1.Size = New Global.System.Drawing.Size(90, 19)
			Me.UiLabel1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLabel1.TabIndex = 526
			Me.UiLabel1.Text = "Hidden RDP"
			Me.UiLabel1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(14, 37)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(15, 14)
			Me.ClientInfo.TabIndex = 527
			Me.ClientInfo.Text = "--"
			Me.GroupBox2.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.GroupBox2.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 48)
			Me.GroupBox2.BorderColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.GroupBox2.BorderRadius = 15
			Me.GroupBox2.Controls.Add(Me.StateNagrok)
			Me.GroupBox2.Controls.Add(Me.YourAuthtoken)
			Me.GroupBox2.Controls.Add(Me.ConnectNgrok)
			Me.GroupBox2.Controls.Add(Me.PictureBox17)
			Me.GroupBox2.Controls.Add(Me.Label6)
			Me.GroupBox2.Controls.Add(Me.CreateRDP)
			Me.GroupBox2.Controls.Add(Me.RemoveRDP)
			Me.GroupBox2.Controls.Add(Me.PasswordHRDP)
			Me.GroupBox2.Controls.Add(Me.HostNgrok)
			Me.GroupBox2.Controls.Add(Me.ListHRDP)
			Me.GroupBox2.Controls.Add(Me.UsernameRDP)
			Me.GroupBox2.CustomBorderColor = Global.System.Drawing.Color.Empty
			Me.GroupBox2.Enabled = False
			Me.GroupBox2.FillColor = Global.System.Drawing.Color.Empty
			Me.GroupBox2.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.GroupBox2.ForeColor = Global.System.Drawing.Color.White
			Me.GroupBox2.Location = New Global.System.Drawing.Point(16, 205)
			Me.GroupBox2.Name = "GroupBox2"
			Me.GroupBox2.ShadowDecoration.Parent = Me.GroupBox2
			Me.GroupBox2.Size = New Global.System.Drawing.Size(503, 325)
			Me.GroupBox2.TabIndex = 535
			Me.GroupBox2.Text = "Connection Settings"
			Me.StateNagrok.AutoSize = True
			Me.StateNagrok.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.StateNagrok.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.StateNagrok.Location = New Global.System.Drawing.Point(9, 112)
			Me.StateNagrok.Name = "StateNagrok"
			Me.StateNagrok.Size = New Global.System.Drawing.Size(16, 13)
			Me.StateNagrok.TabIndex = 535
			Me.StateNagrok.Text = "..."
			Me.YourAuthtoken.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.YourAuthtoken.Animated = True
			Me.YourAuthtoken.BackColor = Global.System.Drawing.Color.Transparent
			Me.YourAuthtoken.BorderColor = Global.System.Drawing.Color.FromArgb(82, 43, 235)
			Me.YourAuthtoken.BorderRadius = 6
			Me.YourAuthtoken.BorderStyle = Global.System.Drawing.Drawing2D.DashStyle.Custom
			Me.YourAuthtoken.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.YourAuthtoken.DefaultText = ""
			Me.YourAuthtoken.DisabledState.BorderColor = Global.System.Drawing.Color.FromArgb(208, 208, 208)
			Me.YourAuthtoken.DisabledState.FillColor = Global.System.Drawing.Color.FromArgb(208, 208, 208)
			Me.YourAuthtoken.DisabledState.ForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.YourAuthtoken.DisabledState.Parent = Me.YourAuthtoken
			Me.YourAuthtoken.DisabledState.PlaceholderForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.YourAuthtoken.FillColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.YourAuthtoken.FocusedState.BorderColor = Global.System.Drawing.Color.FromArgb(82, 43, 255)
			Me.YourAuthtoken.FocusedState.Parent = Me.YourAuthtoken
			Me.YourAuthtoken.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 9F, Global.System.Drawing.FontStyle.Bold)
			Me.YourAuthtoken.ForeColor = Global.System.Drawing.Color.White
			Me.YourAuthtoken.HoverState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.YourAuthtoken.HoverState.Parent = Me.YourAuthtoken
			Me.YourAuthtoken.IconLeft = CType(componentResourceManager.GetObject("YourAuthtoken.IconLeft"), Global.System.Drawing.Image)
			Me.YourAuthtoken.Location = New Global.System.Drawing.Point(12, 72)
			Me.YourAuthtoken.Margin = New Global.System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.YourAuthtoken.Name = "YourAuthtoken"
			Me.YourAuthtoken.PasswordChar = vbNullChar
			Me.YourAuthtoken.PlaceholderForeColor = Global.System.Drawing.Color.Gray
			Me.YourAuthtoken.PlaceholderText = "Your Authtoken"
			Me.YourAuthtoken.SelectedText = ""
			Me.YourAuthtoken.ShadowDecoration.Parent = Me.YourAuthtoken
			Me.YourAuthtoken.Size = New Global.System.Drawing.Size(476, 27)
			Me.YourAuthtoken.TabIndex = 534
			Me.YourAuthtoken.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.ConnectNgrok.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.ConnectNgrok.BackColor = Global.System.Drawing.Color.Transparent
			Me.ConnectNgrok.BorderRadius = 8
			Me.ConnectNgrok.CheckedState.Parent = Me.ConnectNgrok
			Me.ConnectNgrok.CustomImages.Parent = Me.ConnectNgrok
			Me.ConnectNgrok.FillColor = Global.System.Drawing.Color.FromArgb(24, 83, 219)
			Me.ConnectNgrok.FillColor2 = Global.System.Drawing.Color.FromArgb(63, 119, 232)
			Me.ConnectNgrok.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ConnectNgrok.ForeColor = Global.System.Drawing.Color.White
			Me.ConnectNgrok.HoverState.Parent = Me.ConnectNgrok
			Me.ConnectNgrok.Location = New Global.System.Drawing.Point(367, 109)
			Me.ConnectNgrok.Name = "ConnectNgrok"
			Me.ConnectNgrok.ShadowDecoration.Parent = Me.ConnectNgrok
			Me.ConnectNgrok.Size = New Global.System.Drawing.Size(121, 32)
			Me.ConnectNgrok.TabIndex = 533
			Me.ConnectNgrok.Text = "Connect"
			Me.PictureBox17.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.PictureBox17.Image = CType(componentResourceManager.GetObject("PictureBox17.Image"), Global.System.Drawing.Image)
			Me.PictureBox17.Location = New Global.System.Drawing.Point(474, 9)
			Me.PictureBox17.Name = "PictureBox17"
			Me.PictureBox17.Size = New Global.System.Drawing.Size(24, 24)
			Me.PictureBox17.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.AutoSize
			Me.PictureBox17.TabIndex = 424
			Me.PictureBox17.TabStop = False
			Me.Label6.AutoSize = True
			Me.Label6.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label6.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.Label6.Location = New Global.System.Drawing.Point(9, 30)
			Me.Label6.Name = "Label6"
			Me.Label6.Size = New Global.System.Drawing.Size(145, 13)
			Me.Label6.TabIndex = 406
			Me.Label6.Text = "Adjust connection settings"
			Me.PasswordHRDP.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.PasswordHRDP.Animated = True
			Me.PasswordHRDP.BackColor = Global.System.Drawing.Color.FromArgb(32, 40, 86)
			Me.PasswordHRDP.BorderColor = Global.System.Drawing.Color.FromArgb(82, 43, 235)
			Me.PasswordHRDP.BorderRadius = 6
			Me.PasswordHRDP.BorderStyle = Global.System.Drawing.Drawing2D.DashStyle.Custom
			Me.PasswordHRDP.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.PasswordHRDP.DefaultText = ""
			Me.PasswordHRDP.DisabledState.BorderColor = Global.System.Drawing.Color.FromArgb(208, 208, 208)
			Me.PasswordHRDP.DisabledState.FillColor = Global.System.Drawing.Color.FromArgb(208, 208, 208)
			Me.PasswordHRDP.DisabledState.ForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.PasswordHRDP.DisabledState.Parent = Me.PasswordHRDP
			Me.PasswordHRDP.DisabledState.PlaceholderForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.PasswordHRDP.FillColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.PasswordHRDP.FocusedState.BorderColor = Global.System.Drawing.Color.FromArgb(82, 43, 255)
			Me.PasswordHRDP.FocusedState.Parent = Me.PasswordHRDP
			Me.PasswordHRDP.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 9F, Global.System.Drawing.FontStyle.Bold)
			Me.PasswordHRDP.ForeColor = Global.System.Drawing.Color.White
			Me.PasswordHRDP.HoverState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.PasswordHRDP.HoverState.Parent = Me.PasswordHRDP
			Me.PasswordHRDP.IconLeft = CType(componentResourceManager.GetObject("PasswordHRDP.IconLeft"), Global.System.Drawing.Image)
			Me.PasswordHRDP.Location = New Global.System.Drawing.Point(271, 235)
			Me.PasswordHRDP.Margin = New Global.System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.PasswordHRDP.Name = "PasswordHRDP"
			Me.PasswordHRDP.PasswordChar = vbNullChar
			Me.PasswordHRDP.PlaceholderForeColor = Global.System.Drawing.Color.Gray
			Me.PasswordHRDP.PlaceholderText = "Password"
			Me.PasswordHRDP.SelectedText = ""
			Me.PasswordHRDP.ShadowDecoration.Parent = Me.PasswordHRDP
			Me.PasswordHRDP.Size = New Global.System.Drawing.Size(217, 27)
			Me.PasswordHRDP.TabIndex = 367
			Me.PasswordHRDP.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.HostNgrok.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.HostNgrok.Animated = True
			Me.HostNgrok.BackColor = Global.System.Drawing.Color.Transparent
			Me.HostNgrok.BorderColor = Global.System.Drawing.Color.FromArgb(82, 43, 235)
			Me.HostNgrok.BorderRadius = 6
			Me.HostNgrok.BorderStyle = Global.System.Drawing.Drawing2D.DashStyle.Custom
			Me.HostNgrok.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.HostNgrok.DefaultText = ""
			Me.HostNgrok.DisabledState.BorderColor = Global.System.Drawing.Color.FromArgb(208, 208, 208)
			Me.HostNgrok.DisabledState.FillColor = Global.System.Drawing.Color.FromArgb(208, 208, 208)
			Me.HostNgrok.DisabledState.ForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.HostNgrok.DisabledState.Parent = Me.HostNgrok
			Me.HostNgrok.DisabledState.PlaceholderForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.HostNgrok.FillColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.HostNgrok.FocusedState.BorderColor = Global.System.Drawing.Color.FromArgb(82, 43, 255)
			Me.HostNgrok.FocusedState.Parent = Me.HostNgrok
			Me.HostNgrok.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 9F, Global.System.Drawing.FontStyle.Bold)
			Me.HostNgrok.ForeColor = Global.System.Drawing.Color.White
			Me.HostNgrok.HoverState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.HostNgrok.HoverState.Parent = Me.HostNgrok
			Me.HostNgrok.IconLeft = CType(componentResourceManager.GetObject("HostNgrok.IconLeft"), Global.System.Drawing.Image)
			Me.HostNgrok.Location = New Global.System.Drawing.Point(12, 152)
			Me.HostNgrok.Margin = New Global.System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.HostNgrok.Name = "HostNgrok"
			Me.HostNgrok.PasswordChar = vbNullChar
			Me.HostNgrok.PlaceholderForeColor = Global.System.Drawing.Color.Gray
			Me.HostNgrok.PlaceholderText = "Host"
			Me.HostNgrok.[ReadOnly] = True
			Me.HostNgrok.SelectedText = ""
			Me.HostNgrok.ShadowDecoration.Parent = Me.HostNgrok
			Me.HostNgrok.Size = New Global.System.Drawing.Size(476, 27)
			Me.HostNgrok.TabIndex = 368
			Me.HostNgrok.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.ListHRDP.AllowUserToAddRows = False
			Me.ListHRDP.AllowUserToDeleteRows = False
			dataGridViewCellStyle.BackColor = Global.System.Drawing.Color.FromArgb(23, 27, 82)
			dataGridViewCellStyle.ForeColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle.SelectionBackColor = Global.System.Drawing.Color.FromArgb(47, 39, 134)
			dataGridViewCellStyle.SelectionForeColor = Global.System.Drawing.Color.White
			Me.ListHRDP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
			Me.ListHRDP.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.ListHRDP.AutoSizeColumnsMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
			Me.ListHRDP.AutoSizeRowsMode = Global.System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
			Me.ListHRDP.BackgroundColor = Global.System.Drawing.Color.FromArgb(7, 11, 60)
			Me.ListHRDP.CellBorderStyle = Global.System.Windows.Forms.DataGridViewCellBorderStyle.None
			Me.ListHRDP.ColumnHeadersBorderStyle = Global.System.Windows.Forms.DataGridViewHeaderBorderStyle.None
			dataGridViewCellStyle2.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle2.BackColor = Global.System.Drawing.Color.FromArgb(11, 17, 51)
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle2.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			dataGridViewCellStyle2.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle2.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle2.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.ListHRDP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
			Me.ListHRDP.ColumnHeadersHeight = 27
			Me.ListHRDP.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column22, Me.Column23 })
			Me.ListHRDP.ContextMenuStrip = Me.ControllContextMenuStrip
			dataGridViewCellStyle3.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle3.BackColor = Global.System.Drawing.Color.FromArgb(19, 23, 61)
			dataGridViewCellStyle3.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle3.ForeColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle3.SelectionBackColor = Global.System.Drawing.Color.FromArgb(47, 39, 134)
			dataGridViewCellStyle3.SelectionForeColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle3.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[False]
			Me.ListHRDP.DefaultCellStyle = dataGridViewCellStyle3
			Me.ListHRDP.EnableHeadersVisualStyles = False
			Me.ListHRDP.Location = New Global.System.Drawing.Point(12, 195)
			Me.ListHRDP.MultiSelect = False
			Me.ListHRDP.Name = "ListHRDP"
			Me.ListHRDP.[ReadOnly] = True
			Me.ListHRDP.RowHeadersVisible = False
			Me.ListHRDP.RowHeadersWidthSizeMode = Global.System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
			Me.ListHRDP.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			Me.ListHRDP.Size = New Global.System.Drawing.Size(254, 107)
			Me.ListHRDP.TabIndex = 361
			Me.Column22.HeaderText = "User name"
			Me.Column22.Name = "Column22"
			Me.Column22.[ReadOnly] = True
			Me.Column23.HeaderText = "Password"
			Me.Column23.Name = "Column23"
			Me.Column23.[ReadOnly] = True
			Me.ControllContextMenuStrip.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ControllContextMenuStrip.ImageScalingSize = New Global.System.Drawing.Size(20, 20)
			Me.ControllContextMenuStrip.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.KillProcess, Me.RefreshList, Me.RestartProcess })
			Me.ControllContextMenuStrip.Name = "ContextMenuStrip1"
			Me.ControllContextMenuStrip.ShowImageMargin = False
			Me.ControllContextMenuStrip.Size = New Global.System.Drawing.Size(141, 70)
			Me.KillProcess.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.KillProcess.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.KillProcess.Name = "KillProcess"
			Me.KillProcess.Size = New Global.System.Drawing.Size(140, 22)
			Me.KillProcess.Text = "Refresh"
			Me.RefreshList.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.RefreshList.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.RefreshList.Name = "RefreshList"
			Me.RefreshList.Size = New Global.System.Drawing.Size(140, 22)
			Me.RefreshList.Text = "Copy User name"
			Me.RestartProcess.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.RestartProcess.ForeColor = Global.System.Drawing.Color.FromArgb(204, 204, 204)
			Me.RestartProcess.Name = "RestartProcess"
			Me.RestartProcess.Size = New Global.System.Drawing.Size(140, 22)
			Me.RestartProcess.Text = "Copy Password"
			Me.UsernameRDP.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.UsernameRDP.Animated = True
			Me.UsernameRDP.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.UsernameRDP.BorderColor = Global.System.Drawing.Color.FromArgb(82, 43, 235)
			Me.UsernameRDP.BorderRadius = 6
			Me.UsernameRDP.BorderStyle = Global.System.Drawing.Drawing2D.DashStyle.Custom
			Me.UsernameRDP.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.UsernameRDP.DefaultText = ""
			Me.UsernameRDP.DisabledState.BorderColor = Global.System.Drawing.Color.FromArgb(208, 208, 208)
			Me.UsernameRDP.DisabledState.FillColor = Global.System.Drawing.Color.FromArgb(208, 208, 208)
			Me.UsernameRDP.DisabledState.ForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.UsernameRDP.DisabledState.Parent = Me.UsernameRDP
			Me.UsernameRDP.DisabledState.PlaceholderForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.UsernameRDP.FillColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.UsernameRDP.FocusedState.BorderColor = Global.System.Drawing.Color.FromArgb(82, 43, 255)
			Me.UsernameRDP.FocusedState.Parent = Me.UsernameRDP
			Me.UsernameRDP.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 9F, Global.System.Drawing.FontStyle.Bold)
			Me.UsernameRDP.ForeColor = Global.System.Drawing.Color.White
			Me.UsernameRDP.HoverState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.UsernameRDP.HoverState.Parent = Me.UsernameRDP
			Me.UsernameRDP.IconLeft = CType(componentResourceManager.GetObject("UsernameRDP.IconLeft"), Global.System.Drawing.Image)
			Me.UsernameRDP.Location = New Global.System.Drawing.Point(271, 195)
			Me.UsernameRDP.Margin = New Global.System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.UsernameRDP.Name = "UsernameRDP"
			Me.UsernameRDP.PasswordChar = vbNullChar
			Me.UsernameRDP.PlaceholderForeColor = Global.System.Drawing.Color.Gray
			Me.UsernameRDP.PlaceholderText = "User name"
			Me.UsernameRDP.SelectedText = ""
			Me.UsernameRDP.ShadowDecoration.Parent = Me.UsernameRDP
			Me.UsernameRDP.Size = New Global.System.Drawing.Size(217, 27)
			Me.UsernameRDP.TabIndex = 366
			Me.UsernameRDP.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.InstallAndUnstalRDP.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.InstallAndUnstalRDP.BackColor = Global.System.Drawing.Color.Transparent
			Me.InstallAndUnstalRDP.BorderRadius = 8
			Me.InstallAndUnstalRDP.CheckedState.Parent = Me.InstallAndUnstalRDP
			Me.InstallAndUnstalRDP.CustomImages.Parent = Me.InstallAndUnstalRDP
			Me.InstallAndUnstalRDP.FillColor = Global.System.Drawing.Color.FromArgb(26, 155, 161)
			Me.InstallAndUnstalRDP.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 155, 110)
			Me.InstallAndUnstalRDP.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.InstallAndUnstalRDP.ForeColor = Global.System.Drawing.Color.White
			Me.InstallAndUnstalRDP.HoverState.Parent = Me.InstallAndUnstalRDP
			Me.InstallAndUnstalRDP.Location = New Global.System.Drawing.Point(367, 59)
			Me.InstallAndUnstalRDP.Name = "InstallAndUnstalRDP"
			Me.InstallAndUnstalRDP.ShadowDecoration.Parent = Me.InstallAndUnstalRDP
			Me.InstallAndUnstalRDP.Size = New Global.System.Drawing.Size(121, 32)
			Me.InstallAndUnstalRDP.TabIndex = 533
			Me.InstallAndUnstalRDP.Text = "Install"
			Me.GroupBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.GroupBox1.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 48)
			Me.GroupBox1.BorderColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.GroupBox1.BorderRadius = 15
			Me.GroupBox1.Controls.Add(Me.StateInstalRDP)
			Me.GroupBox1.Controls.Add(Me.InstallAndUnstalRDP)
			Me.GroupBox1.Controls.Add(Me.PictureBox1)
			Me.GroupBox1.Controls.Add(Me.Label3)
			Me.GroupBox1.CustomBorderColor = Global.System.Drawing.Color.Empty
			Me.GroupBox1.Enabled = False
			Me.GroupBox1.FillColor = Global.System.Drawing.Color.Empty
			Me.GroupBox1.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.GroupBox1.ForeColor = Global.System.Drawing.Color.White
			Me.GroupBox1.Location = New Global.System.Drawing.Point(16, 95)
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.ShadowDecoration.Parent = Me.GroupBox1
			Me.GroupBox1.Size = New Global.System.Drawing.Size(503, 105)
			Me.GroupBox1.TabIndex = 537
			Me.GroupBox1.Text = "RDP Installation "
			Me.StateInstalRDP.AutoSize = True
			Me.StateInstalRDP.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.StateInstalRDP.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.StateInstalRDP.Location = New Global.System.Drawing.Point(21, 59)
			Me.StateInstalRDP.Name = "StateInstalRDP"
			Me.StateInstalRDP.Size = New Global.System.Drawing.Size(16, 13)
			Me.StateInstalRDP.TabIndex = 535
			Me.StateInstalRDP.Text = "..."
			Me.PictureBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.PictureBox1.Image = CType(componentResourceManager.GetObject("PictureBox1.Image"), Global.System.Drawing.Image)
			Me.PictureBox1.Location = New Global.System.Drawing.Point(474, 9)
			Me.PictureBox1.Name = "PictureBox1"
			Me.PictureBox1.Size = New Global.System.Drawing.Size(24, 24)
			Me.PictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.AutoSize
			Me.PictureBox1.TabIndex = 424
			Me.PictureBox1.TabStop = False
			Me.Label3.AutoSize = True
			Me.Label3.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label3.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.Label3.Location = New Global.System.Drawing.Point(9, 30)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Global.System.Drawing.Size(235, 13)
			Me.Label3.TabIndex = 406
			Me.Label3.Text = "Configure hrdp settings to connect correctly"
			Me.Label4.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.Label4.AutoSize = True
			Me.Label4.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label4.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Label4.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 155)
			Me.Label4.Location = New Global.System.Drawing.Point(23, 537)
			Me.Label4.Name = "Label4"
			Me.Label4.Size = New Global.System.Drawing.Size(41, 14)
			Me.Label4.TabIndex = 551
			Me.Label4.Text = "State :"
			Me.StateHRDP.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.StateHRDP.AutoSize = True
			Me.StateHRDP.BackColor = Global.System.Drawing.Color.Transparent
			Me.StateHRDP.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.StateHRDP.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.StateHRDP.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.StateHRDP.ForeColor = Global.System.Drawing.SystemColors.Window
			Me.StateHRDP.Location = New Global.System.Drawing.Point(59, 537)
			Me.StateHRDP.Name = "StateHRDP"
			Me.StateHRDP.Size = New Global.System.Drawing.Size(16, 14)
			Me.StateHRDP.TabIndex = 552
			Me.StateHRDP.Text = "..."
			Me.Guna2ResizeBox2.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Guna2ResizeBox2.BackColor = Global.System.Drawing.Color.Transparent
			Me.Guna2ResizeBox2.FillColor = Global.System.Drawing.Color.Silver
			Me.Guna2ResizeBox2.ForeColor = Global.System.Drawing.Color.Empty
			Me.Guna2ResizeBox2.Location = New Global.System.Drawing.Point(515, 537)
			Me.Guna2ResizeBox2.Name = "Guna2ResizeBox2"
			Me.Guna2ResizeBox2.Size = New Global.System.Drawing.Size(17, 19)
			Me.Guna2ResizeBox2.TabIndex = 550
			Me.Guna2ResizeBox2.UseTransparentBackground = True
			Me.Mini.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Mini.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Mini.Location = New Global.System.Drawing.Point(493, 11)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 594
			Me.Mini.Text = "ValleyMini1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(515, 11)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 593
			Me.ExitForm.Text = "ValleyClose1"
			Me.Guna2BorderlessForm1.AnimateWindow = True
			Me.Guna2BorderlessForm1.BorderRadius = 30
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
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(96F, 96F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Dpi
			Me.AutoValidate = Global.System.Windows.Forms.AutoValidate.EnableAllowFocusChange
			Me.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			MyBase.ClientSize = New Global.System.Drawing.Size(543, 566)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.Label4)
			MyBase.Controls.Add(Me.StateHRDP)
			MyBase.Controls.Add(Me.Guna2ResizeBox2)
			MyBase.Controls.Add(Me.GroupBox1)
			MyBase.Controls.Add(Me.GroupBox2)
			MyBase.Controls.Add(Me.UiLabel1)
			MyBase.Controls.Add(Me.ClientInfo)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "FormHRDP"
			Me.Text = "FormHRDP"
			MyBase.TopMost = True
			Me.GroupBox2.ResumeLayout(False)
			Me.GroupBox2.PerformLayout()
			CType(Me.PictureBox17, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ListHRDP, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ControllContextMenuStrip.ResumeLayout(False)
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x04000221 RID: 545
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
