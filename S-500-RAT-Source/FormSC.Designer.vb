Namespace S500RAT
	' Token: 0x02000031 RID: 49
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormSC
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000E3B RID: 3643 RVA: 0x0007EBF8 File Offset: 0x0007CDF8
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

		' Token: 0x06000E3C RID: 3644 RVA: 0x0007EC48 File Offset: 0x0007CE48
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormSC))
			Me.PictureKey = New Global.System.Windows.Forms.PictureBox()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.PicturePass = New Global.System.Windows.Forms.PictureBox()
			Me.GroupBox3 = New Global.System.Windows.Forms.GroupBox()
			Me.PictureURL = New Global.System.Windows.Forms.PictureBox()
			Me.GroupBox4 = New Global.System.Windows.Forms.GroupBox()
			Me.PicturePassClient = New Global.System.Windows.Forms.PictureBox()
			CType(Me.PictureKey, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.GroupBox1.SuspendLayout()
			Me.GroupBox2.SuspendLayout()
			CType(Me.PicturePass, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.GroupBox3.SuspendLayout()
			CType(Me.PictureURL, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.GroupBox4.SuspendLayout()
			CType(Me.PicturePassClient, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.PictureKey.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.PictureKey.Image = CType(componentResourceManager.GetObject("PictureKey.Image"), Global.System.Drawing.Image)
			Me.PictureKey.Location = New Global.System.Drawing.Point(3, 16)
			Me.PictureKey.Name = "PictureKey"
			Me.PictureKey.Size = New Global.System.Drawing.Size(190, 137)
			Me.PictureKey.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureKey.TabIndex = 0
			Me.PictureKey.TabStop = False
			Me.GroupBox1.Controls.Add(Me.PictureKey)
			Me.GroupBox1.Location = New Global.System.Drawing.Point(12, 12)
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.Size = New Global.System.Drawing.Size(196, 156)
			Me.GroupBox1.TabIndex = 2
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "Key"
			Me.GroupBox2.Controls.Add(Me.PicturePass)
			Me.GroupBox2.Location = New Global.System.Drawing.Point(214, 12)
			Me.GroupBox2.Name = "GroupBox2"
			Me.GroupBox2.Size = New Global.System.Drawing.Size(196, 156)
			Me.GroupBox2.TabIndex = 3
			Me.GroupBox2.TabStop = False
			Me.GroupBox2.Text = "Password"
			Me.PicturePass.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.PicturePass.Image = CType(componentResourceManager.GetObject("PicturePass.Image"), Global.System.Drawing.Image)
			Me.PicturePass.Location = New Global.System.Drawing.Point(3, 16)
			Me.PicturePass.Name = "PicturePass"
			Me.PicturePass.Size = New Global.System.Drawing.Size(190, 137)
			Me.PicturePass.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PicturePass.TabIndex = 0
			Me.PicturePass.TabStop = False
			Me.GroupBox3.Controls.Add(Me.PictureURL)
			Me.GroupBox3.Location = New Global.System.Drawing.Point(217, 174)
			Me.GroupBox3.Name = "GroupBox3"
			Me.GroupBox3.Size = New Global.System.Drawing.Size(196, 156)
			Me.GroupBox3.TabIndex = 4
			Me.GroupBox3.TabStop = False
			Me.GroupBox3.Text = "url"
			Me.PictureURL.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.PictureURL.Image = CType(componentResourceManager.GetObject("PictureURL.Image"), Global.System.Drawing.Image)
			Me.PictureURL.Location = New Global.System.Drawing.Point(3, 16)
			Me.PictureURL.Name = "PictureURL"
			Me.PictureURL.Size = New Global.System.Drawing.Size(190, 137)
			Me.PictureURL.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureURL.TabIndex = 0
			Me.PictureURL.TabStop = False
			Me.GroupBox4.Controls.Add(Me.PicturePassClient)
			Me.GroupBox4.Location = New Global.System.Drawing.Point(15, 171)
			Me.GroupBox4.Name = "GroupBox4"
			Me.GroupBox4.Size = New Global.System.Drawing.Size(196, 156)
			Me.GroupBox4.TabIndex = 5
			Me.GroupBox4.TabStop = False
			Me.GroupBox4.Text = "Password Client"
			Me.PicturePassClient.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.PicturePassClient.Image = CType(componentResourceManager.GetObject("PicturePassClient.Image"), Global.System.Drawing.Image)
			Me.PicturePassClient.Location = New Global.System.Drawing.Point(3, 16)
			Me.PicturePassClient.Name = "PicturePassClient"
			Me.PicturePassClient.Size = New Global.System.Drawing.Size(190, 137)
			Me.PicturePassClient.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PicturePassClient.TabIndex = 0
			Me.PicturePassClient.TabStop = False
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			MyBase.ClientSize = New Global.System.Drawing.Size(674, 341)
			MyBase.Controls.Add(Me.GroupBox4)
			MyBase.Controls.Add(Me.GroupBox3)
			MyBase.Controls.Add(Me.GroupBox2)
			MyBase.Controls.Add(Me.GroupBox1)
			MyBase.Name = "FormSC"
			Me.Text = "FormSC"
			CType(Me.PictureKey, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox2.ResumeLayout(False)
			CType(Me.PicturePass, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.GroupBox3.ResumeLayout(False)
			CType(Me.PictureURL, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.GroupBox4.ResumeLayout(False)
			CType(Me.PicturePassClient, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x04000666 RID: 1638
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
