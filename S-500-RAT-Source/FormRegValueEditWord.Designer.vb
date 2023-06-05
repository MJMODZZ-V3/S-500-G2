Namespace S500RAT
	' Token: 0x0200002C RID: 44
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormRegValueEditWord
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000859 RID: 2137 RVA: 0x00044858 File Offset: 0x00042A58
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

		' Token: 0x0600085A RID: 2138 RVA: 0x000448A8 File Offset: 0x00042AA8
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.baseBox = New Global.System.Windows.Forms.GroupBox()
			Me.radioDecimal = New Global.System.Windows.Forms.RadioButton()
			Me.radioHexa = New Global.System.Windows.Forms.RadioButton()
			Me.okButton = New Global.System.Windows.Forms.Button()
			Me.label2 = New Global.System.Windows.Forms.Label()
			Me.valueNameTxtBox = New Global.System.Windows.Forms.TextBox()
			Me.label1 = New Global.System.Windows.Forms.Label()
			Me.valueDataTxtBox = New Global.Gry.Helper.WordTextBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.baseBox.SuspendLayout()
			MyBase.SuspendLayout()
			Me.baseBox.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.baseBox.Controls.Add(Me.radioDecimal)
			Me.baseBox.Controls.Add(Me.radioHexa)
			Me.baseBox.Location = New Global.System.Drawing.Point(193, 54)
			Me.baseBox.Name = "baseBox"
			Me.baseBox.Size = New Global.System.Drawing.Size(156, 68)
			Me.baseBox.TabIndex = 20
			Me.baseBox.TabStop = False
			Me.baseBox.Text = "Base"
			Me.radioDecimal.AutoSize = True
			Me.radioDecimal.Location = New Global.System.Drawing.Point(14, 43)
			Me.radioDecimal.Name = "radioDecimal"
			Me.radioDecimal.Size = New Global.System.Drawing.Size(68, 18)
			Me.radioDecimal.TabIndex = 4
			Me.radioDecimal.Text = "Decimal"
			Me.radioDecimal.UseVisualStyleBackColor = True
			Me.radioHexa.AutoSize = True
			Me.radioHexa.Checked = True
			Me.radioHexa.Location = New Global.System.Drawing.Point(14, 18)
			Me.radioHexa.Name = "radioHexa"
			Me.radioHexa.Size = New Global.System.Drawing.Size(94, 18)
			Me.radioHexa.TabIndex = 3
			Me.radioHexa.TabStop = True
			Me.radioHexa.Text = "Hexadecimal"
			Me.radioHexa.UseVisualStyleBackColor = True
			Me.okButton.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.okButton.DialogResult = Global.System.Windows.Forms.DialogResult.OK
			Me.okButton.Location = New Global.System.Drawing.Point(193, 135)
			Me.okButton.Name = "okButton"
			Me.okButton.Size = New Global.System.Drawing.Size(75, 25)
			Me.okButton.TabIndex = 17
			Me.okButton.Text = "OK"
			Me.okButton.UseVisualStyleBackColor = True
			Me.label2.AutoSize = True
			Me.label2.Location = New Global.System.Drawing.Point(12, 54)
			Me.label2.Name = "label2"
			Me.label2.Size = New Global.System.Drawing.Size(66, 14)
			Me.label2.TabIndex = 22
			Me.label2.Text = "Value data:"
			Me.label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.valueNameTxtBox.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.valueNameTxtBox.Location = New Global.System.Drawing.Point(15, 26)
			Me.valueNameTxtBox.Name = "valueNameTxtBox"
			Me.valueNameTxtBox.[ReadOnly] = True
			Me.valueNameTxtBox.Size = New Global.System.Drawing.Size(334, 20)
			Me.valueNameTxtBox.TabIndex = 21
			Me.label1.AutoSize = True
			Me.label1.Location = New Global.System.Drawing.Point(12, 9)
			Me.label1.Name = "label1"
			Me.label1.Size = New Global.System.Drawing.Size(74, 14)
			Me.label1.TabIndex = 23
			Me.label1.Text = "Value name:"
			Me.label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.valueDataTxtBox.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.valueDataTxtBox.IsHexNumber = False
			Me.valueDataTxtBox.Location = New Global.System.Drawing.Point(15, 83)
			Me.valueDataTxtBox.MaxLength = 8
			Me.valueDataTxtBox.Name = "valueDataTxtBox"
			Me.valueDataTxtBox.Size = New Global.System.Drawing.Size(161, 20)
			Me.valueDataTxtBox.TabIndex = 5
			Me.valueDataTxtBox.Type = Global.Gry.Helper.WordTextBox.WordType.DWORD
			Me.Button1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Button1.DialogResult = Global.System.Windows.Forms.DialogResult.OK
			Me.Button1.Location = New Global.System.Drawing.Point(274, 135)
			Me.Button1.Name = "Button1"
			Me.Button1.Size = New Global.System.Drawing.Size(75, 25)
			Me.Button1.TabIndex = 24
			Me.Button1.Text = "Cancel"
			Me.Button1.UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(7F, 14F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			MyBase.ClientSize = New Global.System.Drawing.Size(368, 181)
			MyBase.Controls.Add(Me.Button1)
			MyBase.Controls.Add(Me.valueDataTxtBox)
			MyBase.Controls.Add(Me.label2)
			MyBase.Controls.Add(Me.valueNameTxtBox)
			MyBase.Controls.Add(Me.label1)
			MyBase.Controls.Add(Me.baseBox)
			MyBase.Controls.Add(Me.okButton)
			Me.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "FormRegValueEditWord"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "FormRegValueEditWord"
			MyBase.TopMost = True
			Me.baseBox.ResumeLayout(False)
			Me.baseBox.PerformLayout()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x040003B4 RID: 948
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
