Namespace S500RAT
	' Token: 0x02000032 RID: 50
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormSendFile
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000E53 RID: 3667 RVA: 0x0007F4E0 File Offset: 0x0007D6E0
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

		' Token: 0x06000E54 RID: 3668 RVA: 0x0007F530 File Offset: 0x0007D730
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormSendFile))
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.UiLabel1 = New Global.Sunny.UI.UILabel()
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.SendFile = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.CancelForm = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.FilenameEXE = New Global.Guna.UI2.WinForms.Guna2TextBox()
			Me.RunPE = New Global.Sunny.UI.UIRadioButton()
			Me.Memory = New Global.Sunny.UI.UIRadioButton()
			Me.ToDisk = New Global.Sunny.UI.UIRadioButton()
			Me.PanelInjection = New Global.System.Windows.Forms.Panel()
			Me.vbcexe = New Global.Sunny.UI.UIRadioButton()
			Me.RegSvcsexe = New Global.Sunny.UI.UIRadioButton()
			Me.MSBuildexe = New Global.Sunny.UI.UIRadioButton()
			Me.RegAsmexe = New Global.Sunny.UI.UIRadioButton()
			Me.GroupBoxFileLoad = New Global.Guna.UI2.WinForms.Guna2GroupBox()
			Me.State = New Global.System.Windows.Forms.Label()
			Me.PictureBox13 = New Global.System.Windows.Forms.PictureBox()
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			Me.PanelInjection.SuspendLayout()
			Me.GroupBoxFileLoad.SuspendLayout()
			CType(Me.PictureBox13, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.Timer1.Interval = 2000
			Me.UiLabel1.AutoSize = True
			Me.UiLabel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel1.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel1.Location = New Global.System.Drawing.Point(22, 11)
			Me.UiLabel1.Name = "UiLabel1"
			Me.UiLabel1.Size = New Global.System.Drawing.Size(73, 19)
			Me.UiLabel1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLabel1.TabIndex = 354
			Me.UiLabel1.Text = "Send File "
			Me.UiLabel1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(23, 37)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(200, 16)
			Me.ClientInfo.TabIndex = 355
			Me.ClientInfo.Text = "FC / Desktop_3424 / Windows 10 pro"
			Me.SendFile.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.SendFile.BackColor = Global.System.Drawing.Color.Transparent
			Me.SendFile.BorderRadius = 8
			Me.SendFile.CheckedState.Parent = Me.SendFile
			Me.SendFile.CustomImages.Parent = Me.SendFile
			Me.SendFile.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.SendFile.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 155, 161)
			Me.SendFile.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.SendFile.ForeColor = Global.System.Drawing.Color.White
			Me.SendFile.HoverState.Parent = Me.SendFile
			Me.SendFile.Location = New Global.System.Drawing.Point(389, 219)
			Me.SendFile.Name = "SendFile"
			Me.SendFile.ShadowDecoration.Parent = Me.SendFile
			Me.SendFile.Size = New Global.System.Drawing.Size(92, 33)
			Me.SendFile.TabIndex = 520
			Me.SendFile.Text = "Send"
			Me.CancelForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.CancelForm.BackColor = Global.System.Drawing.Color.Transparent
			Me.CancelForm.BorderRadius = 8
			Me.CancelForm.CheckedState.Parent = Me.CancelForm
			Me.CancelForm.CustomImages.Parent = Me.CancelForm
			Me.CancelForm.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.CancelForm.FillColor2 = Global.System.Drawing.Color.FromArgb(211, 57, 87)
			Me.CancelForm.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.CancelForm.ForeColor = Global.System.Drawing.Color.White
			Me.CancelForm.HoverState.Parent = Me.CancelForm
			Me.CancelForm.Location = New Global.System.Drawing.Point(486, 219)
			Me.CancelForm.Name = "CancelForm"
			Me.CancelForm.ShadowDecoration.Parent = Me.CancelForm
			Me.CancelForm.Size = New Global.System.Drawing.Size(92, 33)
			Me.CancelForm.TabIndex = 521
			Me.CancelForm.Text = "Cancel"
			Me.FilenameEXE.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.FilenameEXE.Animated = True
			Me.FilenameEXE.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.FilenameEXE.BorderColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.FilenameEXE.BorderRadius = 7
			Me.FilenameEXE.BorderStyle = Global.System.Drawing.Drawing2D.DashStyle.Custom
			Me.FilenameEXE.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.FilenameEXE.DefaultText = ""
			Me.FilenameEXE.DisabledState.BorderColor = Global.System.Drawing.Color.FromArgb(208, 208, 208)
			Me.FilenameEXE.DisabledState.FillColor = Global.System.Drawing.Color.FromArgb(226, 226, 226)
			Me.FilenameEXE.DisabledState.ForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.FilenameEXE.DisabledState.Parent = Me.FilenameEXE
			Me.FilenameEXE.DisabledState.PlaceholderForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.FilenameEXE.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.FilenameEXE.FocusedState.BorderColor = Global.System.Drawing.Color.FromArgb(94, 148, 255)
			Me.FilenameEXE.FocusedState.Parent = Me.FilenameEXE
			Me.FilenameEXE.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.FilenameEXE.ForeColor = Global.System.Drawing.Color.White
			Me.FilenameEXE.HoverState.BorderColor = Global.System.Drawing.Color.FromArgb(94, 148, 255)
			Me.FilenameEXE.HoverState.Parent = Me.FilenameEXE
			Me.FilenameEXE.IconLeftCursor = Global.System.Windows.Forms.Cursors.Hand
			Me.FilenameEXE.IconRight = CType(componentResourceManager.GetObject("FilenameEXE.IconRight"), Global.System.Drawing.Image)
			Me.FilenameEXE.IconRightCursor = Global.System.Windows.Forms.Cursors.Hand
			Me.FilenameEXE.Location = New Global.System.Drawing.Point(12, 46)
			Me.FilenameEXE.Margin = New Global.System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.FilenameEXE.Name = "FilenameEXE"
			Me.FilenameEXE.PasswordChar = vbNullChar
			Me.FilenameEXE.PlaceholderForeColor = Global.System.Drawing.Color.Gray
			Me.FilenameEXE.PlaceholderText = "Choose File (.exe)"
			Me.FilenameEXE.[ReadOnly] = True
			Me.FilenameEXE.SelectedText = ""
			Me.FilenameEXE.ShadowDecoration.Parent = Me.FilenameEXE
			Me.FilenameEXE.Size = New Global.System.Drawing.Size(566, 27)
			Me.FilenameEXE.TabIndex = 522
			Me.FilenameEXE.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.RunPE.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.RunPE.BackColor = Global.System.Drawing.Color.Transparent
			Me.RunPE.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.RunPE.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.RunPE.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.RunPE.Location = New Global.System.Drawing.Point(18, 84)
			Me.RunPE.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.RunPE.Name = "RunPE"
			Me.RunPE.Padding = New Global.System.Windows.Forms.Padding(22, 0, 0, 0)
			Me.RunPE.RadioButtonColor = Global.System.Drawing.Color.FromArgb(84, 43, 244)
			Me.RunPE.Size = New Global.System.Drawing.Size(75, 19)
			Me.RunPE.Style = Global.Sunny.UI.UIStyle.Custom
			Me.RunPE.TabIndex = 532
			Me.RunPE.Text = "RunPE"
			Me.Memory.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Memory.BackColor = Global.System.Drawing.Color.Transparent
			Me.Memory.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Memory.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Memory.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.Memory.Location = New Global.System.Drawing.Point(98, 84)
			Me.Memory.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.Memory.Name = "Memory"
			Me.Memory.Padding = New Global.System.Windows.Forms.Padding(22, 0, 0, 0)
			Me.Memory.RadioButtonColor = Global.System.Drawing.Color.FromArgb(84, 43, 244)
			Me.Memory.Size = New Global.System.Drawing.Size(79, 19)
			Me.Memory.Style = Global.Sunny.UI.UIStyle.Custom
			Me.Memory.TabIndex = 533
			Me.Memory.Text = "Memory"
			Me.ToDisk.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ToDisk.BackColor = Global.System.Drawing.Color.Transparent
			Me.ToDisk.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ToDisk.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ToDisk.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.ToDisk.Location = New Global.System.Drawing.Point(182, 84)
			Me.ToDisk.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.ToDisk.Name = "ToDisk"
			Me.ToDisk.Padding = New Global.System.Windows.Forms.Padding(22, 0, 0, 0)
			Me.ToDisk.RadioButtonColor = Global.System.Drawing.Color.FromArgb(84, 43, 244)
			Me.ToDisk.Size = New Global.System.Drawing.Size(59, 19)
			Me.ToDisk.Style = Global.Sunny.UI.UIStyle.Custom
			Me.ToDisk.TabIndex = 534
			Me.ToDisk.Text = "To Disk"
			Me.PanelInjection.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.PanelInjection.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 48)
			Me.PanelInjection.Controls.Add(Me.vbcexe)
			Me.PanelInjection.Controls.Add(Me.RegSvcsexe)
			Me.PanelInjection.Controls.Add(Me.MSBuildexe)
			Me.PanelInjection.Controls.Add(Me.RegAsmexe)
			Me.PanelInjection.Enabled = False
			Me.PanelInjection.Location = New Global.System.Drawing.Point(9, 110)
			Me.PanelInjection.Name = "PanelInjection"
			Me.PanelInjection.Size = New Global.System.Drawing.Size(197, 142)
			Me.PanelInjection.TabIndex = 535
			Me.vbcexe.BackColor = Global.System.Drawing.Color.Transparent
			Me.vbcexe.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.vbcexe.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.vbcexe.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.vbcexe.Location = New Global.System.Drawing.Point(9, 114)
			Me.vbcexe.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.vbcexe.Name = "vbcexe"
			Me.vbcexe.Padding = New Global.System.Windows.Forms.Padding(22, 0, 0, 0)
			Me.vbcexe.RadioButtonColor = Global.System.Drawing.Color.FromArgb(84, 43, 244)
			Me.vbcexe.Size = New Global.System.Drawing.Size(75, 18)
			Me.vbcexe.Style = Global.Sunny.UI.UIStyle.Custom
			Me.vbcexe.TabIndex = 535
			Me.vbcexe.Text = "vbc.exe"
			Me.RegSvcsexe.BackColor = Global.System.Drawing.Color.Transparent
			Me.RegSvcsexe.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.RegSvcsexe.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.RegSvcsexe.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.RegSvcsexe.Location = New Global.System.Drawing.Point(9, 80)
			Me.RegSvcsexe.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.RegSvcsexe.Name = "RegSvcsexe"
			Me.RegSvcsexe.Padding = New Global.System.Windows.Forms.Padding(22, 0, 0, 0)
			Me.RegSvcsexe.RadioButtonColor = Global.System.Drawing.Color.FromArgb(84, 43, 244)
			Me.RegSvcsexe.Size = New Global.System.Drawing.Size(92, 18)
			Me.RegSvcsexe.Style = Global.Sunny.UI.UIStyle.Custom
			Me.RegSvcsexe.TabIndex = 534
			Me.RegSvcsexe.Text = "RegSvcs.exe"
			Me.MSBuildexe.BackColor = Global.System.Drawing.Color.Transparent
			Me.MSBuildexe.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.MSBuildexe.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.MSBuildexe.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.MSBuildexe.Location = New Global.System.Drawing.Point(9, 46)
			Me.MSBuildexe.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.MSBuildexe.Name = "MSBuildexe"
			Me.MSBuildexe.Padding = New Global.System.Windows.Forms.Padding(22, 0, 0, 0)
			Me.MSBuildexe.RadioButtonColor = Global.System.Drawing.Color.FromArgb(84, 43, 244)
			Me.MSBuildexe.Size = New Global.System.Drawing.Size(92, 18)
			Me.MSBuildexe.Style = Global.Sunny.UI.UIStyle.Custom
			Me.MSBuildexe.TabIndex = 533
			Me.MSBuildexe.Text = "MSBuild.exe"
			Me.RegAsmexe.BackColor = Global.System.Drawing.Color.Transparent
			Me.RegAsmexe.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.RegAsmexe.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.RegAsmexe.ForeColor = Global.System.Drawing.Color.FromArgb(143, 156, 176)
			Me.RegAsmexe.Location = New Global.System.Drawing.Point(9, 15)
			Me.RegAsmexe.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.RegAsmexe.Name = "RegAsmexe"
			Me.RegAsmexe.Padding = New Global.System.Windows.Forms.Padding(22, 0, 0, 0)
			Me.RegAsmexe.RadioButtonColor = Global.System.Drawing.Color.FromArgb(84, 43, 244)
			Me.RegAsmexe.Size = New Global.System.Drawing.Size(92, 17)
			Me.RegAsmexe.Style = Global.Sunny.UI.UIStyle.Custom
			Me.RegAsmexe.TabIndex = 532
			Me.RegAsmexe.Text = "RegAsm.exe"
			Me.GroupBoxFileLoad.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.GroupBoxFileLoad.BackColor = Global.System.Drawing.Color.Transparent
			Me.GroupBoxFileLoad.BorderColor = Global.System.Drawing.Color.FromArgb(25, 29, 73)
			Me.GroupBoxFileLoad.BorderRadius = 15
			Me.GroupBoxFileLoad.Controls.Add(Me.State)
			Me.GroupBoxFileLoad.Controls.Add(Me.PictureBox13)
			Me.GroupBoxFileLoad.Controls.Add(Me.CancelForm)
			Me.GroupBoxFileLoad.Controls.Add(Me.SendFile)
			Me.GroupBoxFileLoad.Controls.Add(Me.PanelInjection)
			Me.GroupBoxFileLoad.Controls.Add(Me.FilenameEXE)
			Me.GroupBoxFileLoad.Controls.Add(Me.ToDisk)
			Me.GroupBoxFileLoad.Controls.Add(Me.RunPE)
			Me.GroupBoxFileLoad.Controls.Add(Me.Memory)
			Me.GroupBoxFileLoad.CustomBorderColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.GroupBoxFileLoad.FillColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.GroupBoxFileLoad.Font = New Global.System.Drawing.Font("Nirmala UI", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.GroupBoxFileLoad.ForeColor = Global.System.Drawing.SystemColors.Window
			Me.GroupBoxFileLoad.Location = New Global.System.Drawing.Point(9, 79)
			Me.GroupBoxFileLoad.Name = "GroupBoxFileLoad"
			Me.GroupBoxFileLoad.ShadowDecoration.Parent = Me.GroupBoxFileLoad
			Me.GroupBoxFileLoad.Size = New Global.System.Drawing.Size(590, 266)
			Me.GroupBoxFileLoad.TabIndex = 536
			Me.GroupBoxFileLoad.Text = "File Load"
			Me.State.AutoSize = True
			Me.State.BackColor = Global.System.Drawing.Color.Transparent
			Me.State.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.State.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.State.Location = New Global.System.Drawing.Point(369, 148)
			Me.State.Name = "State"
			Me.State.Size = New Global.System.Drawing.Size(0, 16)
			Me.State.TabIndex = 536
			Me.PictureBox13.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.PictureBox13.BackColor = Global.System.Drawing.Color.Transparent
			Me.PictureBox13.Image = CType(componentResourceManager.GetObject("PictureBox13.Image"), Global.System.Drawing.Image)
			Me.PictureBox13.Location = New Global.System.Drawing.Point(561, 9)
			Me.PictureBox13.Name = "PictureBox13"
			Me.PictureBox13.Size = New Global.System.Drawing.Size(18, 18)
			Me.PictureBox13.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.AutoSize
			Me.PictureBox13.TabIndex = 423
			Me.PictureBox13.TabStop = False
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
			Me.Mini.Location = New Global.System.Drawing.Point(557, 12)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 572
			Me.Mini.Text = "ValleyMini1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(583, 12)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 570
			Me.ExitForm.Text = "ValleyClose1"
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(96F, 96F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Dpi
			Me.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			MyBase.ClientSize = New Global.System.Drawing.Size(615, 356)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.GroupBoxFileLoad)
			MyBase.Controls.Add(Me.UiLabel1)
			MyBase.Controls.Add(Me.ClientInfo)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "FormSendFile"
			Me.Text = "FormSendFile"
			MyBase.TopMost = True
			Me.PanelInjection.ResumeLayout(False)
			Me.GroupBoxFileLoad.ResumeLayout(False)
			Me.GroupBoxFileLoad.PerformLayout()
			CType(Me.PictureBox13, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0400066F RID: 1647
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
