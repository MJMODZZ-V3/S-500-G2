Namespace S500RAT
	' Token: 0x0200000F RID: 15
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormAdmin
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600006D RID: 109 RVA: 0x000042A8 File Offset: 0x000024A8
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

		' Token: 0x0600006E RID: 110 RVA: 0x000042F8 File Offset: 0x000024F8
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormAdmin))
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.UiLabel1 = New Global.Sunny.UI.UILabel()
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.BypassUAC = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.AddUAC = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.RunAsadminstartor = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.ExcuteUAC = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.AdminInfo = New Global.System.Windows.Forms.Label()
			Me.StateAdmin = New Global.System.Windows.Forms.Label()
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.UiLine1 = New Global.Sunny.UI.UILine()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.UiLine2 = New Global.Sunny.UI.UILine()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.UiLine3 = New Global.Sunny.UI.UILine()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.UiLine4 = New Global.Sunny.UI.UILine()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			MyBase.SuspendLayout()
			Me.Timer1.Interval = 2000
			Me.UiLabel1.AutoSize = True
			Me.UiLabel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel1.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel1.Location = New Global.System.Drawing.Point(23, 9)
			Me.UiLabel1.Name = "UiLabel1"
			Me.UiLabel1.Size = New Global.System.Drawing.Size(88, 19)
			Me.UiLabel1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLabel1.TabIndex = 354
			Me.UiLabel1.Text = "UAC Exploit"
			Me.UiLabel1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(24, 37)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(200, 16)
			Me.ClientInfo.TabIndex = 355
			Me.ClientInfo.Text = "FC / Desktop_3424 / Windows 10 pro"
			Me.BypassUAC.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.BypassUAC.BackColor = Global.System.Drawing.Color.Transparent
			Me.BypassUAC.BorderRadius = 8
			Me.BypassUAC.CheckedState.Parent = Me.BypassUAC
			Me.BypassUAC.CustomImages.Parent = Me.BypassUAC
			Me.BypassUAC.Enabled = False
			Me.BypassUAC.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.BypassUAC.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.BypassUAC.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.BypassUAC.ForeColor = Global.System.Drawing.Color.White
			Me.BypassUAC.HoverState.Parent = Me.BypassUAC
			Me.BypassUAC.Location = New Global.System.Drawing.Point(336, 103)
			Me.BypassUAC.Name = "BypassUAC"
			Me.BypassUAC.ShadowDecoration.Parent = Me.BypassUAC
			Me.BypassUAC.Size = New Global.System.Drawing.Size(152, 31)
			Me.BypassUAC.TabIndex = 487
			Me.BypassUAC.Text = "Bypass UAC"
			Me.AddUAC.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.AddUAC.BackColor = Global.System.Drawing.Color.Transparent
			Me.AddUAC.BorderRadius = 8
			Me.AddUAC.CheckedState.Parent = Me.AddUAC
			Me.AddUAC.CustomImages.Parent = Me.AddUAC
			Me.AddUAC.Enabled = False
			Me.AddUAC.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.AddUAC.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.AddUAC.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.AddUAC.ForeColor = Global.System.Drawing.Color.White
			Me.AddUAC.HoverState.Parent = Me.AddUAC
			Me.AddUAC.Location = New Global.System.Drawing.Point(336, 262)
			Me.AddUAC.Name = "AddUAC"
			Me.AddUAC.ShadowDecoration.Parent = Me.AddUAC
			Me.AddUAC.Size = New Global.System.Drawing.Size(152, 31)
			Me.AddUAC.TabIndex = 489
			Me.AddUAC.Text = "Add a UAC scheduled task"
			Me.RunAsadminstartor.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.RunAsadminstartor.BackColor = Global.System.Drawing.Color.Transparent
			Me.RunAsadminstartor.BorderRadius = 8
			Me.RunAsadminstartor.CheckedState.Parent = Me.RunAsadminstartor
			Me.RunAsadminstartor.CustomImages.Parent = Me.RunAsadminstartor
			Me.RunAsadminstartor.Enabled = False
			Me.RunAsadminstartor.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.RunAsadminstartor.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.RunAsadminstartor.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.RunAsadminstartor.ForeColor = Global.System.Drawing.Color.White
			Me.RunAsadminstartor.HoverState.Parent = Me.RunAsadminstartor
			Me.RunAsadminstartor.Location = New Global.System.Drawing.Point(336, 189)
			Me.RunAsadminstartor.Name = "RunAsadminstartor"
			Me.RunAsadminstartor.ShadowDecoration.Parent = Me.RunAsadminstartor
			Me.RunAsadminstartor.Size = New Global.System.Drawing.Size(152, 31)
			Me.RunAsadminstartor.TabIndex = 520
			Me.RunAsadminstartor.Text = "Run as adminstartor"
			Me.ExcuteUAC.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExcuteUAC.BackColor = Global.System.Drawing.Color.Transparent
			Me.ExcuteUAC.BorderRadius = 8
			Me.ExcuteUAC.CheckedState.Parent = Me.ExcuteUAC
			Me.ExcuteUAC.CustomImages.Parent = Me.ExcuteUAC
			Me.ExcuteUAC.Enabled = False
			Me.ExcuteUAC.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ExcuteUAC.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ExcuteUAC.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ExcuteUAC.ForeColor = Global.System.Drawing.Color.White
			Me.ExcuteUAC.HoverState.Parent = Me.ExcuteUAC
			Me.ExcuteUAC.Location = New Global.System.Drawing.Point(336, 336)
			Me.ExcuteUAC.Name = "ExcuteUAC"
			Me.ExcuteUAC.ShadowDecoration.Parent = Me.ExcuteUAC
			Me.ExcuteUAC.Size = New Global.System.Drawing.Size(152, 31)
			Me.ExcuteUAC.TabIndex = 521
			Me.ExcuteUAC.Text = " Excute scheduled task"
			Me.AdminInfo.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.AdminInfo.AutoSize = True
			Me.AdminInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.AdminInfo.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.AdminInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.AdminInfo.Location = New Global.System.Drawing.Point(428, 418)
			Me.AdminInfo.Name = "AdminInfo"
			Me.AdminInfo.Size = New Global.System.Drawing.Size(75, 14)
			Me.AdminInfo.TabIndex = 525
			Me.AdminInfo.Text = "Admin :  Yes"
			Me.StateAdmin.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.StateAdmin.AutoSize = True
			Me.StateAdmin.BackColor = Global.System.Drawing.Color.Transparent
			Me.StateAdmin.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.StateAdmin.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.StateAdmin.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.StateAdmin.Location = New Global.System.Drawing.Point(29, 418)
			Me.StateAdmin.Name = "StateAdmin"
			Me.StateAdmin.Size = New Global.System.Drawing.Size(15, 14)
			Me.StateAdmin.TabIndex = 552
			Me.StateAdmin.Text = "--"
			Me.Mini.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Mini.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Mini.Location = New Global.System.Drawing.Point(457, 8)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 551
			Me.Mini.Text = "ValleyMini1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(483, 8)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 549
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
			Me.UiLine1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.UiLine1.FillColor = Global.System.Drawing.Color.Transparent
			Me.UiLine1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 12F)
			Me.UiLine1.LineColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.UiLine1.LineDashStyle = Global.Sunny.UI.UILineDashStyle.None
			Me.UiLine1.Location = New Global.System.Drawing.Point(28, 140)
			Me.UiLine1.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.UiLine1.Name = "UiLine1"
			Me.UiLine1.Size = New Global.System.Drawing.Size(460, 29)
			Me.UiLine1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLine1.TabIndex = 553
			Me.Label1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Label1.AutoSize = True
			Me.Label1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F)
			Me.Label1.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.Label1.Location = New Global.System.Drawing.Point(25, 103)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(298, 16)
			Me.Label1.TabIndex = 554
			Me.Label1.Text = "User Account Bypass user account and silent execution"
			Me.UiLine2.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.UiLine2.FillColor = Global.System.Drawing.Color.Transparent
			Me.UiLine2.Font = New Global.System.Drawing.Font("Microsoft YaHei", 12F)
			Me.UiLine2.LineColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.UiLine2.LineDashStyle = Global.Sunny.UI.UILineDashStyle.None
			Me.UiLine2.Location = New Global.System.Drawing.Point(28, 226)
			Me.UiLine2.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.UiLine2.Name = "UiLine2"
			Me.UiLine2.Size = New Global.System.Drawing.Size(460, 29)
			Me.UiLine2.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLine2.TabIndex = 555
			Me.Label2.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Label2.AutoSize = True
			Me.Label2.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label2.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F)
			Me.Label2.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.Label2.Location = New Global.System.Drawing.Point(23, 189)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(278, 16)
			Me.Label2.TabIndex = 556
			Me.Label2.Text = "Execution of the client as responsible with approval"
			Me.UiLine3.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.UiLine3.FillColor = Global.System.Drawing.Color.Transparent
			Me.UiLine3.Font = New Global.System.Drawing.Font("Microsoft YaHei", 12F)
			Me.UiLine3.LineColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.UiLine3.LineDashStyle = Global.Sunny.UI.UILineDashStyle.None
			Me.UiLine3.Location = New Global.System.Drawing.Point(28, 299)
			Me.UiLine3.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.UiLine3.Name = "UiLine3"
			Me.UiLine3.Size = New Global.System.Drawing.Size(460, 29)
			Me.UiLine3.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLine3.TabIndex = 557
			Me.Label3.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Label3.AutoSize = True
			Me.Label3.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label3.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F)
			Me.Label3.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.Label3.Location = New Global.System.Drawing.Point(25, 262)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Global.System.Drawing.Size(231, 32)
			Me.Label3.TabIndex = 558
			Me.Label3.Text = "Add the Client in the scheduled tasks with " & vbCrLf & "execution with the highest privileges"
			Me.UiLine4.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.UiLine4.FillColor = Global.System.Drawing.Color.Transparent
			Me.UiLine4.Font = New Global.System.Drawing.Font("Microsoft YaHei", 12F)
			Me.UiLine4.LineColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.UiLine4.LineDashStyle = Global.Sunny.UI.UILineDashStyle.None
			Me.UiLine4.Location = New Global.System.Drawing.Point(28, 373)
			Me.UiLine4.MinimumSize = New Global.System.Drawing.Size(1, 1)
			Me.UiLine4.Name = "UiLine4"
			Me.UiLine4.Size = New Global.System.Drawing.Size(460, 29)
			Me.UiLine4.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLine4.TabIndex = 559
			Me.Label4.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Label4.AutoSize = True
			Me.Label4.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label4.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F)
			Me.Label4.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.Label4.Location = New Global.System.Drawing.Point(25, 336)
			Me.Label4.Name = "Label4"
			Me.Label4.Size = New Global.System.Drawing.Size(146, 16)
			Me.Label4.TabIndex = 560
			Me.Label4.Text = "Run with highest privilrgrs"
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(96F, 96F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Dpi
			Me.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			MyBase.ClientSize = New Global.System.Drawing.Size(515, 442)
			MyBase.Controls.Add(Me.Label4)
			MyBase.Controls.Add(Me.UiLine4)
			MyBase.Controls.Add(Me.Label3)
			MyBase.Controls.Add(Me.UiLine3)
			MyBase.Controls.Add(Me.Label2)
			MyBase.Controls.Add(Me.UiLine2)
			MyBase.Controls.Add(Me.Label1)
			MyBase.Controls.Add(Me.UiLine1)
			MyBase.Controls.Add(Me.StateAdmin)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.AdminInfo)
			MyBase.Controls.Add(Me.ExcuteUAC)
			MyBase.Controls.Add(Me.RunAsadminstartor)
			MyBase.Controls.Add(Me.AddUAC)
			MyBase.Controls.Add(Me.BypassUAC)
			MyBase.Controls.Add(Me.UiLabel1)
			MyBase.Controls.Add(Me.ClientInfo)
			Me.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "FormAdmin"
			Me.Text = "FormAdmin"
			MyBase.TopMost = True
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x04000034 RID: 52
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
