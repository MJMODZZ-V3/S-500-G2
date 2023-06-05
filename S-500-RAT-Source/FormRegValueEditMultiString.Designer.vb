Namespace S500RAT
	' Token: 0x0200002A RID: 42
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormRegValueEditMultiString
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000835 RID: 2101 RVA: 0x00043BAC File Offset: 0x00041DAC
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

		' Token: 0x06000836 RID: 2102 RVA: 0x00043BFC File Offset: 0x00041DFC
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.valueDataTxtBox = New Global.System.Windows.Forms.TextBox()
			Me.okButton = New Global.System.Windows.Forms.Button()
			Me.label2 = New Global.System.Windows.Forms.Label()
			Me.valueNameTxtBox = New Global.System.Windows.Forms.TextBox()
			Me.label1 = New Global.System.Windows.Forms.Label()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			MyBase.SuspendLayout()
			Me.valueDataTxtBox.AcceptsReturn = True
			Me.valueDataTxtBox.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.valueDataTxtBox.Location = New Global.System.Drawing.Point(15, 77)
			Me.valueDataTxtBox.Multiline = True
			Me.valueDataTxtBox.Name = "valueDataTxtBox"
			Me.valueDataTxtBox.ScrollBars = Global.System.Windows.Forms.ScrollBars.Both
			Me.valueDataTxtBox.Size = New Global.System.Drawing.Size(336, 285)
			Me.valueDataTxtBox.TabIndex = 11
			Me.valueDataTxtBox.WordWrap = False
			Me.okButton.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.okButton.DialogResult = Global.System.Windows.Forms.DialogResult.OK
			Me.okButton.Location = New Global.System.Drawing.Point(195, 371)
			Me.okButton.Name = "okButton"
			Me.okButton.Size = New Global.System.Drawing.Size(75, 25)
			Me.okButton.TabIndex = 12
			Me.okButton.Text = "OK"
			Me.okButton.UseVisualStyleBackColor = True
			Me.label2.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.label2.AutoSize = True
			Me.label2.Location = New Global.System.Drawing.Point(12, 57)
			Me.label2.Name = "label2"
			Me.label2.Size = New Global.System.Drawing.Size(66, 14)
			Me.label2.TabIndex = 14
			Me.label2.Text = "Value data:"
			Me.label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.valueNameTxtBox.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.valueNameTxtBox.Location = New Global.System.Drawing.Point(15, 26)
			Me.valueNameTxtBox.Name = "valueNameTxtBox"
			Me.valueNameTxtBox.[ReadOnly] = True
			Me.valueNameTxtBox.Size = New Global.System.Drawing.Size(336, 20)
			Me.valueNameTxtBox.TabIndex = 15
			Me.label1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.label1.AutoSize = True
			Me.label1.Location = New Global.System.Drawing.Point(12, 9)
			Me.label1.Name = "label1"
			Me.label1.Size = New Global.System.Drawing.Size(74, 14)
			Me.label1.TabIndex = 16
			Me.label1.Text = "Value name:"
			Me.label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Button1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Button1.DialogResult = Global.System.Windows.Forms.DialogResult.OK
			Me.Button1.Location = New Global.System.Drawing.Point(276, 371)
			Me.Button1.Name = "Button1"
			Me.Button1.Size = New Global.System.Drawing.Size(75, 25)
			Me.Button1.TabIndex = 17
			Me.Button1.Text = "Cancel"
			Me.Button1.UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(7F, 14F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			MyBase.ClientSize = New Global.System.Drawing.Size(363, 406)
			MyBase.Controls.Add(Me.Button1)
			MyBase.Controls.Add(Me.valueDataTxtBox)
			MyBase.Controls.Add(Me.okButton)
			MyBase.Controls.Add(Me.label2)
			MyBase.Controls.Add(Me.valueNameTxtBox)
			MyBase.Controls.Add(Me.label1)
			Me.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "FormRegValueEditMultiString"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Edit Multi-String"
			MyBase.TopMost = True
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x040003A4 RID: 932
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
