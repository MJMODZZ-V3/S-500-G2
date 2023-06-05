Namespace S500RAT
	' Token: 0x02000013 RID: 19
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormClient
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000152 RID: 338 RVA: 0x0000B3A4 File Offset: 0x000095A4
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

		' Token: 0x06000153 RID: 339 RVA: 0x0000B3F4 File Offset: 0x000095F4
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormClient))
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.UiLabel1 = New Global.Sunny.UI.UILabel()
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.TextName = New Global.System.Windows.Forms.Label()
			Me.UiLabel2 = New Global.Sunny.UI.UILabel()
			Me.UiLabel3 = New Global.Sunny.UI.UILabel()
			Me.TextPath = New Global.System.Windows.Forms.Label()
			Me.UiLabel4 = New Global.Sunny.UI.UILabel()
			Me.TextDate = New Global.System.Windows.Forms.Label()
			Me.Guna2ResizeBox1 = New Global.Guna.UI2.WinForms.Guna2ResizeBox()
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.MAX = New Global.S500RAT.ValleyMax()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.Guna2BorderlessForm1.AnimateWindow = True
			Me.Guna2BorderlessForm1.BorderRadius = 40
			Me.Guna2BorderlessForm1.ContainerControl = Me
			Me.Guna2BorderlessForm1.DockIndicatorColor = Global.System.Drawing.Color.FromArgb(56, 37, 200)
			Me.Guna2BorderlessForm1.ResizeForm = False
			Me.Guna2BorderlessForm1.ShadowColor = Global.System.Drawing.Color.FromArgb(56, 37, 200)
			Me.Timer1.Interval = 2000
			Me.UiLabel1.AutoSize = True
			Me.UiLabel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel1.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel1.Location = New Global.System.Drawing.Point(26, 12)
			Me.UiLabel1.Name = "UiLabel1"
			Me.UiLabel1.Size = New Global.System.Drawing.Size(47, 19)
			Me.UiLabel1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLabel1.TabIndex = 358
			Me.UiLabel1.Text = "Client"
			Me.UiLabel1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(27, 40)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(203, 14)
			Me.ClientInfo.TabIndex = 359
			Me.ClientInfo.Text = "FC / Desktop_3424 / Windows 10 pro"
			Me.TextName.Anchor = Global.System.Windows.Forms.AnchorStyles.None
			Me.TextName.AutoSize = True
			Me.TextName.BackColor = Global.System.Drawing.Color.Transparent
			Me.TextName.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.TextName.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.TextName.Location = New Global.System.Drawing.Point(173, 115)
			Me.TextName.Name = "TextName"
			Me.TextName.Size = New Global.System.Drawing.Size(15, 14)
			Me.TextName.TabIndex = 362
			Me.TextName.Text = "--"
			Me.UiLabel2.Anchor = Global.System.Windows.Forms.AnchorStyles.None
			Me.UiLabel2.AutoSize = True
			Me.UiLabel2.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel2.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel2.ForeColor = Global.System.Drawing.Color.FromArgb(255, 128, 0)
			Me.UiLabel2.Location = New Global.System.Drawing.Point(173, 93)
			Me.UiLabel2.Name = "UiLabel2"
			Me.UiLabel2.Size = New Global.System.Drawing.Size(72, 16)
			Me.UiLabel2.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLabel2.TabIndex = 363
			Me.UiLabel2.Text = "Client name"
			Me.UiLabel2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.UiLabel3.Anchor = Global.System.Windows.Forms.AnchorStyles.None
			Me.UiLabel3.AutoSize = True
			Me.UiLabel3.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel3.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel3.ForeColor = Global.System.Drawing.Color.FromArgb(255, 128, 0)
			Me.UiLabel3.Location = New Global.System.Drawing.Point(173, 147)
			Me.UiLabel3.Name = "UiLabel3"
			Me.UiLabel3.Size = New Global.System.Drawing.Size(67, 16)
			Me.UiLabel3.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLabel3.TabIndex = 365
			Me.UiLabel3.Text = "Client path"
			Me.UiLabel3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.TextPath.Anchor = Global.System.Windows.Forms.AnchorStyles.None
			Me.TextPath.AutoSize = True
			Me.TextPath.BackColor = Global.System.Drawing.Color.Transparent
			Me.TextPath.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.TextPath.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.TextPath.Location = New Global.System.Drawing.Point(173, 169)
			Me.TextPath.Name = "TextPath"
			Me.TextPath.Size = New Global.System.Drawing.Size(15, 14)
			Me.TextPath.TabIndex = 364
			Me.TextPath.Text = "--"
			Me.UiLabel4.Anchor = Global.System.Windows.Forms.AnchorStyles.None
			Me.UiLabel4.AutoSize = True
			Me.UiLabel4.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel4.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel4.ForeColor = Global.System.Drawing.Color.FromArgb(255, 128, 0)
			Me.UiLabel4.Location = New Global.System.Drawing.Point(173, 197)
			Me.UiLabel4.Name = "UiLabel4"
			Me.UiLabel4.Size = New Global.System.Drawing.Size(69, 16)
			Me.UiLabel4.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLabel4.TabIndex = 367
			Me.UiLabel4.Text = "Data install"
			Me.UiLabel4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.TextDate.Anchor = Global.System.Windows.Forms.AnchorStyles.None
			Me.TextDate.AutoSize = True
			Me.TextDate.BackColor = Global.System.Drawing.Color.Transparent
			Me.TextDate.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.TextDate.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.TextDate.Location = New Global.System.Drawing.Point(173, 219)
			Me.TextDate.Name = "TextDate"
			Me.TextDate.Size = New Global.System.Drawing.Size(15, 14)
			Me.TextDate.TabIndex = 366
			Me.TextDate.Text = "--"
			Me.Guna2ResizeBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Guna2ResizeBox1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Guna2ResizeBox1.FillColor = Global.System.Drawing.Color.Silver
			Me.Guna2ResizeBox1.ForeColor = Global.System.Drawing.Color.Empty
			Me.Guna2ResizeBox1.Location = New Global.System.Drawing.Point(615, 230)
			Me.Guna2ResizeBox1.Name = "Guna2ResizeBox1"
			Me.Guna2ResizeBox1.Size = New Global.System.Drawing.Size(20, 20)
			Me.Guna2ResizeBox1.TabIndex = 526
			Me.Guna2ResizeBox1.TargetControl = Me
			Me.Guna2ResizeBox1.UseTransparentBackground = True
			Me.Mini.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Mini.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Mini.Location = New Global.System.Drawing.Point(563, 12)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 584
			Me.Mini.Text = "ValleyMini1"
			Me.MAX.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.MAX.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.MAX.Location = New Global.System.Drawing.Point(589, 12)
			Me.MAX.Name = "MAX"
			Me.MAX.Size = New Global.System.Drawing.Size(20, 20)
			Me.MAX.TabIndex = 583
			Me.MAX.Text = "ValleyMax1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(615, 12)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 582
			Me.ExitForm.Text = "ValleyClose1"
			Me.PictureBox1.Anchor = Global.System.Windows.Forms.AnchorStyles.None
			Me.PictureBox1.Image = CType(componentResourceManager.GetObject("PictureBox1.Image"), Global.System.Drawing.Image)
			Me.PictureBox1.Location = New Global.System.Drawing.Point(16, 84)
			Me.PictureBox1.Name = "PictureBox1"
			Me.PictureBox1.Size = New Global.System.Drawing.Size(141, 140)
			Me.PictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox1.TabIndex = 585
			Me.PictureBox1.TabStop = False
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(96F, 96F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Dpi
			Me.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			MyBase.ClientSize = New Global.System.Drawing.Size(647, 262)
			MyBase.Controls.Add(Me.PictureBox1)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.MAX)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.Guna2ResizeBox1)
			MyBase.Controls.Add(Me.UiLabel4)
			MyBase.Controls.Add(Me.TextDate)
			MyBase.Controls.Add(Me.UiLabel3)
			MyBase.Controls.Add(Me.TextPath)
			MyBase.Controls.Add(Me.UiLabel2)
			MyBase.Controls.Add(Me.TextName)
			MyBase.Controls.Add(Me.UiLabel1)
			MyBase.Controls.Add(Me.ClientInfo)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "FormClient"
			Me.Text = "FormClient"
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0400009A RID: 154
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
