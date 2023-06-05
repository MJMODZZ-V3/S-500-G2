Namespace S500RAT
	' Token: 0x02000017 RID: 23
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormDDos
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000200 RID: 512 RVA: 0x0000FCD4 File Offset: 0x0000DED4
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

		' Token: 0x06000201 RID: 513 RVA: 0x0000FD24 File Offset: 0x0000DF24
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormDDos))
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle3 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.UiLabel1 = New Global.Sunny.UI.UILabel()
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.DDosPort = New Global.Guna.UI2.WinForms.Guna2TextBox()
			Me.DDosHost = New Global.Guna.UI2.WinForms.Guna2TextBox()
			Me.DDosStart = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.TimeOut = New Global.Guna.UI2.WinForms.Guna2TextBox()
			Me.ListDDos = New Global.Guna.UI2.WinForms.Guna2DataGridView()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewImageColumn()
			Me.Column2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Add_Info = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.Guna2ResizeBox1 = New Global.Guna.UI2.WinForms.Guna2ResizeBox()
			Me.Guna2Elipse1 = New Global.Guna.UI2.WinForms.Guna2Elipse(Me.components)
			Me.ImageList1 = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.DDosRemove = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.MAX = New Global.S500RAT.ValleyMax()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			CType(Me.ListDDos, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.Timer1.Interval = 2000
			Me.UiLabel1.AutoSize = True
			Me.UiLabel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel1.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel1.Location = New Global.System.Drawing.Point(21, 12)
			Me.UiLabel1.Name = "UiLabel1"
			Me.UiLabel1.Size = New Global.System.Drawing.Size(93, 19)
			Me.UiLabel1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLabel1.TabIndex = 339
			Me.UiLabel1.Text = "DDoS Attack"
			Me.UiLabel1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(21, 36)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(200, 16)
			Me.ClientInfo.TabIndex = 340
			Me.ClientInfo.Text = "FC / Desktop_3424 / Windows 10 pro"
			Me.DDosPort.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.DDosPort.Animated = True
			Me.DDosPort.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.DDosPort.BorderColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.DDosPort.BorderRadius = 6
			Me.DDosPort.BorderStyle = Global.System.Drawing.Drawing2D.DashStyle.Custom
			Me.DDosPort.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.DDosPort.DefaultText = ""
			Me.DDosPort.DisabledState.BorderColor = Global.System.Drawing.Color.FromArgb(208, 208, 208)
			Me.DDosPort.DisabledState.FillColor = Global.System.Drawing.Color.FromArgb(208, 208, 208)
			Me.DDosPort.DisabledState.ForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.DDosPort.DisabledState.Parent = Me.DDosPort
			Me.DDosPort.DisabledState.PlaceholderForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.DDosPort.Enabled = False
			Me.DDosPort.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.DDosPort.FocusedState.BorderColor = Global.System.Drawing.Color.FromArgb(82, 43, 255)
			Me.DDosPort.FocusedState.Parent = Me.DDosPort
			Me.DDosPort.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 9F, Global.System.Drawing.FontStyle.Bold)
			Me.DDosPort.ForeColor = Global.System.Drawing.Color.White
			Me.DDosPort.HoverState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.DDosPort.HoverState.Parent = Me.DDosPort
			Me.DDosPort.IconLeft = CType(componentResourceManager.GetObject("DDosPort.IconLeft"), Global.System.Drawing.Image)
			Me.DDosPort.Location = New Global.System.Drawing.Point(12, 135)
			Me.DDosPort.Margin = New Global.System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.DDosPort.Name = "DDosPort"
			Me.DDosPort.PasswordChar = vbNullChar
			Me.DDosPort.PlaceholderForeColor = Global.System.Drawing.Color.Gray
			Me.DDosPort.PlaceholderText = "Port"
			Me.DDosPort.SelectedText = ""
			Me.DDosPort.ShadowDecoration.Parent = Me.DDosPort
			Me.DDosPort.Size = New Global.System.Drawing.Size(305, 27)
			Me.DDosPort.TabIndex = 516
			Me.DDosPort.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.DDosHost.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.DDosHost.Animated = True
			Me.DDosHost.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.DDosHost.BorderColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.DDosHost.BorderRadius = 6
			Me.DDosHost.BorderStyle = Global.System.Drawing.Drawing2D.DashStyle.Custom
			Me.DDosHost.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.DDosHost.DefaultText = ""
			Me.DDosHost.DisabledState.BorderColor = Global.System.Drawing.Color.FromArgb(208, 208, 208)
			Me.DDosHost.DisabledState.FillColor = Global.System.Drawing.Color.FromArgb(208, 208, 208)
			Me.DDosHost.DisabledState.ForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.DDosHost.DisabledState.Parent = Me.DDosHost
			Me.DDosHost.DisabledState.PlaceholderForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.DDosHost.Enabled = False
			Me.DDosHost.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.DDosHost.FocusedState.BorderColor = Global.System.Drawing.Color.FromArgb(82, 43, 255)
			Me.DDosHost.FocusedState.Parent = Me.DDosHost
			Me.DDosHost.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 9F, Global.System.Drawing.FontStyle.Bold)
			Me.DDosHost.ForeColor = Global.System.Drawing.Color.White
			Me.DDosHost.HoverState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.DDosHost.HoverState.Parent = Me.DDosHost
			Me.DDosHost.IconLeft = CType(componentResourceManager.GetObject("DDosHost.IconLeft"), Global.System.Drawing.Image)
			Me.DDosHost.Location = New Global.System.Drawing.Point(12, 99)
			Me.DDosHost.Margin = New Global.System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.DDosHost.Name = "DDosHost"
			Me.DDosHost.PasswordChar = vbNullChar
			Me.DDosHost.PlaceholderForeColor = Global.System.Drawing.Color.Gray
			Me.DDosHost.PlaceholderText = "Host"
			Me.DDosHost.SelectedText = ""
			Me.DDosHost.ShadowDecoration.Parent = Me.DDosHost
			Me.DDosHost.Size = New Global.System.Drawing.Size(451, 27)
			Me.DDosHost.TabIndex = 515
			Me.DDosHost.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.DDosStart.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.DDosStart.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.DDosStart.BorderRadius = 8
			Me.DDosStart.CheckedState.Parent = Me.DDosStart
			Me.DDosStart.CustomImages.Parent = Me.DDosStart
			Me.DDosStart.Enabled = False
			Me.DDosStart.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.DDosStart.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.DDosStart.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.DDosStart.ForeColor = Global.System.Drawing.Color.White
			Me.DDosStart.HoverState.Parent = Me.DDosStart
			Me.DDosStart.Location = New Global.System.Drawing.Point(323, 168)
			Me.DDosStart.Name = "DDosStart"
			Me.DDosStart.ShadowDecoration.Parent = Me.DDosStart
			Me.DDosStart.Size = New Global.System.Drawing.Size(140, 35)
			Me.DDosStart.TabIndex = 519
			Me.DDosStart.Text = "Start"
			Me.TimeOut.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.TimeOut.Animated = True
			Me.TimeOut.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.TimeOut.BorderColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.TimeOut.BorderRadius = 6
			Me.TimeOut.BorderStyle = Global.System.Drawing.Drawing2D.DashStyle.Custom
			Me.TimeOut.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.TimeOut.DefaultText = "3"
			Me.TimeOut.DisabledState.BorderColor = Global.System.Drawing.Color.FromArgb(208, 208, 208)
			Me.TimeOut.DisabledState.FillColor = Global.System.Drawing.Color.FromArgb(226, 226, 226)
			Me.TimeOut.DisabledState.ForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.TimeOut.DisabledState.Parent = Me.TimeOut
			Me.TimeOut.DisabledState.PlaceholderForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.TimeOut.Enabled = False
			Me.TimeOut.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.TimeOut.FocusedState.BorderColor = Global.System.Drawing.Color.FromArgb(82, 43, 255)
			Me.TimeOut.FocusedState.Parent = Me.TimeOut
			Me.TimeOut.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 9F, Global.System.Drawing.FontStyle.Bold)
			Me.TimeOut.ForeColor = Global.System.Drawing.Color.White
			Me.TimeOut.HoverState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.TimeOut.HoverState.Parent = Me.TimeOut
			Me.TimeOut.IconLeft = CType(componentResourceManager.GetObject("TimeOut.IconLeft"), Global.System.Drawing.Image)
			Me.TimeOut.Location = New Global.System.Drawing.Point(12, 176)
			Me.TimeOut.Margin = New Global.System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.TimeOut.Name = "TimeOut"
			Me.TimeOut.PasswordChar = vbNullChar
			Me.TimeOut.PlaceholderForeColor = Global.System.Drawing.Color.Gray
			Me.TimeOut.PlaceholderText = "Secound !!!"
			Me.TimeOut.SelectedText = ""
			Me.TimeOut.SelectionStart = 1
			Me.TimeOut.ShadowDecoration.Parent = Me.TimeOut
			Me.TimeOut.Size = New Global.System.Drawing.Size(305, 27)
			Me.TimeOut.TabIndex = 520
			Me.TimeOut.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.ListDDos.AllowUserToAddRows = False
			Me.ListDDos.AllowUserToDeleteRows = False
			Me.ListDDos.AllowUserToResizeColumns = False
			Me.ListDDos.AllowUserToResizeRows = False
			dataGridViewCellStyle.BackColor = Global.System.Drawing.Color.FromArgb(209, 196, 233)
			Me.ListDDos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
			Me.ListDDos.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ListDDos.AutoSizeColumnsMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
			Me.ListDDos.BackgroundColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ListDDos.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.ListDDos.CellBorderStyle = Global.System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
			Me.ListDDos.ColumnHeadersBorderStyle = Global.System.Windows.Forms.DataGridViewHeaderBorderStyle.None
			dataGridViewCellStyle2.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle2.BackColor = Global.System.Drawing.Color.FromArgb(103, 58, 183)
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle2.ForeColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle2.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle2.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle2.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.ListDDos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
			Me.ListDDos.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.ListDDos.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column1, Me.Column2, Me.Column3 })
			dataGridViewCellStyle3.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle3.BackColor = Global.System.Drawing.Color.FromArgb(224, 215, 240)
			dataGridViewCellStyle3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle3.ForeColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle3.SelectionBackColor = Global.System.Drawing.Color.FromArgb(153, 123, 207)
			dataGridViewCellStyle3.SelectionForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle3.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[False]
			Me.ListDDos.DefaultCellStyle = dataGridViewCellStyle3
			Me.ListDDos.Enabled = False
			Me.ListDDos.EnableHeadersVisualStyles = False
			Me.ListDDos.GridColor = Global.System.Drawing.Color.FromArgb(79, 46, 208)
			Me.ListDDos.Location = New Global.System.Drawing.Point(14, 219)
			Me.ListDDos.MultiSelect = False
			Me.ListDDos.Name = "ListDDos"
			Me.ListDDos.[ReadOnly] = True
			Me.ListDDos.RowHeadersVisible = False
			Me.ListDDos.RowHeadersWidth = 20
			Me.ListDDos.RowHeadersWidthSizeMode = Global.System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
			Me.ListDDos.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			Me.ListDDos.ShowCellErrors = False
			Me.ListDDos.ShowEditingIcon = False
			Me.ListDDos.ShowRowErrors = False
			Me.ListDDos.Size = New Global.System.Drawing.Size(450, 255)
			Me.ListDDos.TabIndex = 521
			Me.ListDDos.Theme = Global.Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.DeepPurple
			Me.ListDDos.ThemeStyle.AlternatingRowsStyle.BackColor = Global.System.Drawing.Color.FromArgb(209, 196, 233)
			Me.ListDDos.ThemeStyle.AlternatingRowsStyle.Font = Nothing
			Me.ListDDos.ThemeStyle.AlternatingRowsStyle.ForeColor = Global.System.Drawing.Color.Empty
			Me.ListDDos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Global.System.Drawing.Color.Empty
			Me.ListDDos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Global.System.Drawing.Color.Empty
			Me.ListDDos.ThemeStyle.BackColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ListDDos.ThemeStyle.GridColor = Global.System.Drawing.Color.FromArgb(79, 46, 208)
			Me.ListDDos.ThemeStyle.HeaderStyle.BackColor = Global.System.Drawing.Color.FromArgb(103, 58, 183)
			Me.ListDDos.ThemeStyle.HeaderStyle.BorderStyle = Global.System.Windows.Forms.DataGridViewHeaderBorderStyle.None
			Me.ListDDos.ThemeStyle.HeaderStyle.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ListDDos.ThemeStyle.HeaderStyle.ForeColor = Global.System.Drawing.Color.White
			Me.ListDDos.ThemeStyle.HeaderStyle.HeaightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.ListDDos.ThemeStyle.HeaderStyle.Height = 23
			Me.ListDDos.ThemeStyle.[ReadOnly] = True
			Me.ListDDos.ThemeStyle.RowsStyle.BackColor = Global.System.Drawing.Color.FromArgb(224, 215, 240)
			Me.ListDDos.ThemeStyle.RowsStyle.BorderStyle = Global.System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
			Me.ListDDos.ThemeStyle.RowsStyle.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ListDDos.ThemeStyle.RowsStyle.ForeColor = Global.System.Drawing.Color.White
			Me.ListDDos.ThemeStyle.RowsStyle.Height = 22
			Me.ListDDos.ThemeStyle.RowsStyle.SelectionBackColor = Global.System.Drawing.Color.FromArgb(153, 123, 207)
			Me.ListDDos.ThemeStyle.RowsStyle.SelectionForeColor = Global.System.Drawing.Color.Black
			Me.Column1.HeaderText = "       "
			Me.Column1.Name = "Column1"
			Me.Column1.[ReadOnly] = True
			Me.Column1.Width = 29
			Me.Column2.HeaderText = "Host"
			Me.Column2.Name = "Column2"
			Me.Column2.[ReadOnly] = True
			Me.Column2.Width = 52
			Me.Column3.AutoSizeMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
			Me.Column3.HeaderText = "Port"
			Me.Column3.Name = "Column3"
			Me.Column3.[ReadOnly] = True
			Me.Add_Info.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Add_Info.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.Add_Info.BorderRadius = 8
			Me.Add_Info.CheckedState.Parent = Me.Add_Info
			Me.Add_Info.CustomImages.Parent = Me.Add_Info
			Me.Add_Info.Enabled = False
			Me.Add_Info.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.Add_Info.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.Add_Info.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Add_Info.ForeColor = Global.System.Drawing.Color.White
			Me.Add_Info.HoverState.Parent = Me.Add_Info
			Me.Add_Info.Location = New Global.System.Drawing.Point(389, 135)
			Me.Add_Info.Name = "Add_Info"
			Me.Add_Info.ShadowDecoration.Parent = Me.Add_Info
			Me.Add_Info.Size = New Global.System.Drawing.Size(75, 27)
			Me.Add_Info.TabIndex = 522
			Me.Add_Info.Text = "Add "
			Me.Guna2ResizeBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Guna2ResizeBox1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Guna2ResizeBox1.FillColor = Global.System.Drawing.Color.Silver
			Me.Guna2ResizeBox1.ForeColor = Global.System.Drawing.Color.Empty
			Me.Guna2ResizeBox1.Location = New Global.System.Drawing.Point(450, 480)
			Me.Guna2ResizeBox1.Name = "Guna2ResizeBox1"
			Me.Guna2ResizeBox1.Size = New Global.System.Drawing.Size(17, 19)
			Me.Guna2ResizeBox1.TabIndex = 523
			Me.Guna2ResizeBox1.TargetControl = Me
			Me.Guna2ResizeBox1.UseTransparentBackground = True
			Me.Guna2Elipse1.BorderRadius = 20
			Me.Guna2Elipse1.TargetControl = Me.ListDDos
			Me.ImageList1.ImageStream = CType(componentResourceManager.GetObject("ImageList1.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.ImageList1.TransparentColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.ImageList1.Images.SetKeyName(0, "DDOS.png")
			Me.DDosRemove.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.DDosRemove.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.DDosRemove.BorderRadius = 8
			Me.DDosRemove.CheckedState.Parent = Me.DDosRemove
			Me.DDosRemove.CustomImages.Parent = Me.DDosRemove
			Me.DDosRemove.Enabled = False
			Me.DDosRemove.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.DDosRemove.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.DDosRemove.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.DDosRemove.ForeColor = Global.System.Drawing.Color.White
			Me.DDosRemove.HoverState.Parent = Me.DDosRemove
			Me.DDosRemove.Location = New Global.System.Drawing.Point(323, 135)
			Me.DDosRemove.Name = "DDosRemove"
			Me.DDosRemove.ShadowDecoration.Parent = Me.DDosRemove
			Me.DDosRemove.Size = New Global.System.Drawing.Size(60, 27)
			Me.DDosRemove.TabIndex = 525
			Me.DDosRemove.Text = "Remove"
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
			Me.Mini.Location = New Global.System.Drawing.Point(399, 11)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 586
			Me.Mini.Text = "ValleyMini1"
			Me.MAX.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.MAX.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.MAX.Location = New Global.System.Drawing.Point(421, 11)
			Me.MAX.Name = "MAX"
			Me.MAX.Size = New Global.System.Drawing.Size(20, 20)
			Me.MAX.TabIndex = 585
			Me.MAX.Text = "ValleyMax1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(443, 11)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 584
			Me.ExitForm.Text = "ValleyClose1"
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(96F, 96F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Dpi
			Me.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			MyBase.ClientSize = New Global.System.Drawing.Size(477, 510)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.MAX)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.DDosRemove)
			MyBase.Controls.Add(Me.Guna2ResizeBox1)
			MyBase.Controls.Add(Me.Add_Info)
			MyBase.Controls.Add(Me.ListDDos)
			MyBase.Controls.Add(Me.TimeOut)
			MyBase.Controls.Add(Me.DDosStart)
			MyBase.Controls.Add(Me.DDosPort)
			MyBase.Controls.Add(Me.DDosHost)
			MyBase.Controls.Add(Me.UiLabel1)
			MyBase.Controls.Add(Me.ClientInfo)
			Me.DoubleBuffered = True
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "FormDDos"
			Me.Text = "FormDDos"
			MyBase.TopMost = True
			CType(Me.ListDDos, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x040000ED RID: 237
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
