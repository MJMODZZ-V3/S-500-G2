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
Imports S500RAT.Server.Connection
Imports Sunny.UI

Namespace S500RAT
	' Token: 0x02000021 RID: 33
	<DesignerGenerated()>
	Public Partial Class FormInstalledSoftware
		Inherits Form

		' Token: 0x17000248 RID: 584
		' (get) Token: 0x060005A6 RID: 1446 RVA: 0x00031930 File Offset: 0x0002FB30
		' (set) Token: 0x060005A7 RID: 1447 RVA: 0x0003193A File Offset: 0x0002FB3A
		Friend Overridable Property ImageList1 As ImageList

		' Token: 0x17000249 RID: 585
		' (get) Token: 0x060005A8 RID: 1448 RVA: 0x00031943 File Offset: 0x0002FB43
		' (set) Token: 0x060005A9 RID: 1449 RVA: 0x00031950 File Offset: 0x0002FB50
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

		' Token: 0x1700024A RID: 586
		' (get) Token: 0x060005AA RID: 1450 RVA: 0x00031993 File Offset: 0x0002FB93
		' (set) Token: 0x060005AB RID: 1451 RVA: 0x0003199D File Offset: 0x0002FB9D
		Friend Overridable Property Guna2Elipse1 As Guna2Elipse

		' Token: 0x1700024B RID: 587
		' (get) Token: 0x060005AC RID: 1452 RVA: 0x000319A6 File Offset: 0x0002FBA6
		' (set) Token: 0x060005AD RID: 1453 RVA: 0x000319B0 File Offset: 0x0002FBB0
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x1700024C RID: 588
		' (get) Token: 0x060005AE RID: 1454 RVA: 0x000319B9 File Offset: 0x0002FBB9
		' (set) Token: 0x060005AF RID: 1455 RVA: 0x000319C3 File Offset: 0x0002FBC3
		Private Overridable Property ClientInfo As Label

		' Token: 0x1700024D RID: 589
		' (get) Token: 0x060005B0 RID: 1456 RVA: 0x000319CC File Offset: 0x0002FBCC
		' (set) Token: 0x060005B1 RID: 1457 RVA: 0x000319D6 File Offset: 0x0002FBD6
		Friend Overridable Property Guna2ResizeBox1 As Guna2ResizeBox

		' Token: 0x1700024E RID: 590
		' (get) Token: 0x060005B2 RID: 1458 RVA: 0x000319DF File Offset: 0x0002FBDF
		' (set) Token: 0x060005B3 RID: 1459 RVA: 0x000319E9 File Offset: 0x0002FBE9
		Friend Overridable Property ListInstalledSoftware As Guna2DataGridView

		' Token: 0x1700024F RID: 591
		' (get) Token: 0x060005B4 RID: 1460 RVA: 0x000319F2 File Offset: 0x0002FBF2
		' (set) Token: 0x060005B5 RID: 1461 RVA: 0x000319FC File Offset: 0x0002FBFC
		Friend Overridable Property Column3 As DataGridViewImageColumn

		' Token: 0x17000250 RID: 592
		' (get) Token: 0x060005B6 RID: 1462 RVA: 0x00031A05 File Offset: 0x0002FC05
		' (set) Token: 0x060005B7 RID: 1463 RVA: 0x00031A0F File Offset: 0x0002FC0F
		Friend Overridable Property Column4 As DataGridViewTextBoxColumn

		' Token: 0x17000251 RID: 593
		' (get) Token: 0x060005B8 RID: 1464 RVA: 0x00031A18 File Offset: 0x0002FC18
		' (set) Token: 0x060005B9 RID: 1465 RVA: 0x00031A22 File Offset: 0x0002FC22
		Friend Overridable Property ControllContextMenuStrip As ContextMenuStrip

		' Token: 0x17000252 RID: 594
		' (get) Token: 0x060005BA RID: 1466 RVA: 0x00031A2B File Offset: 0x0002FC2B
		' (set) Token: 0x060005BB RID: 1467 RVA: 0x00031A38 File Offset: 0x0002FC38
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

		' Token: 0x17000253 RID: 595
		' (get) Token: 0x060005BC RID: 1468 RVA: 0x00031A7B File Offset: 0x0002FC7B
		' (set) Token: 0x060005BD RID: 1469 RVA: 0x00031A88 File Offset: 0x0002FC88
		Friend Overridable Property StopServices As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._StopServices
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.StopServices_Click
				Dim stopServices As ToolStripMenuItem = Me._StopServices
				If stopServices IsNot Nothing Then
					RemoveHandler stopServices.Click, value2
				End If
				Me._StopServices = value
				stopServices = Me._StopServices
				If stopServices IsNot Nothing Then
					AddHandler stopServices.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000254 RID: 596
		' (get) Token: 0x060005BE RID: 1470 RVA: 0x00031ACB File Offset: 0x0002FCCB
		' (set) Token: 0x060005BF RID: 1471 RVA: 0x00031AD5 File Offset: 0x0002FCD5
		Public Overridable Property SoftwareNum As Label

		' Token: 0x17000255 RID: 597
		' (get) Token: 0x060005C0 RID: 1472 RVA: 0x00031ADE File Offset: 0x0002FCDE
		' (set) Token: 0x060005C1 RID: 1473 RVA: 0x00031AE8 File Offset: 0x0002FCE8
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x17000256 RID: 598
		' (get) Token: 0x060005C2 RID: 1474 RVA: 0x00031AF1 File Offset: 0x0002FCF1
		' (set) Token: 0x060005C3 RID: 1475 RVA: 0x00031AFB File Offset: 0x0002FCFB
		Friend Overridable Property MAX As ValleyMax

		' Token: 0x17000257 RID: 599
		' (get) Token: 0x060005C4 RID: 1476 RVA: 0x00031B04 File Offset: 0x0002FD04
		' (set) Token: 0x060005C5 RID: 1477 RVA: 0x00031B10 File Offset: 0x0002FD10
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

		' Token: 0x17000258 RID: 600
		' (get) Token: 0x060005C6 RID: 1478 RVA: 0x00031B53 File Offset: 0x0002FD53
		' (set) Token: 0x060005C7 RID: 1479 RVA: 0x00031B5D File Offset: 0x0002FD5D
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x17000259 RID: 601
		' (get) Token: 0x060005C8 RID: 1480 RVA: 0x00031B66 File Offset: 0x0002FD66
		' (set) Token: 0x060005C9 RID: 1481 RVA: 0x00031B70 File Offset: 0x0002FD70
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x1700025A RID: 602
		' (get) Token: 0x060005CA RID: 1482 RVA: 0x00031B79 File Offset: 0x0002FD79
		' (set) Token: 0x060005CB RID: 1483 RVA: 0x00031B83 File Offset: 0x0002FD83
		Public Property Client As Clients

		' Token: 0x1700025B RID: 603
		' (get) Token: 0x060005CC RID: 1484 RVA: 0x00031B8C File Offset: 0x0002FD8C
		' (set) Token: 0x060005CD RID: 1485 RVA: 0x00031B96 File Offset: 0x0002FD96
		Public Property F As FormS500

		' Token: 0x1700025C RID: 604
		' (get) Token: 0x060005CE RID: 1486 RVA: 0x00031B9F File Offset: 0x0002FD9F
		' (set) Token: 0x060005CF RID: 1487 RVA: 0x00031BA9 File Offset: 0x0002FDA9
		Public Property FullPath As String

		' Token: 0x1700025D RID: 605
		' (get) Token: 0x060005D0 RID: 1488 RVA: 0x00031BB2 File Offset: 0x0002FDB2
		' (set) Token: 0x060005D1 RID: 1489 RVA: 0x00031BBC File Offset: 0x0002FDBC
		Friend Property ParentClient As Clients

		' Token: 0x060005D2 RID: 1490 RVA: 0x00031BC5 File Offset: 0x0002FDC5
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormInstalledSoftware_Load
			AddHandler MyBase.Resize, AddressOf Me.FormInstalledSoftware_Resize
			Me.FormSize = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x060005D3 RID: 1491 RVA: 0x00031C04 File Offset: 0x0002FE04
		Private Sub FormInstalledSoftware_Load(sender As Object, e As EventArgs)
			Me.ListInstalledSoftware.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 31, 55)
			Me.ListInstalledSoftware.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(26, 31, 55)
			Me.ListInstalledSoftware.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(26, 31, 55)
			Me.ListInstalledSoftware.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255)
			Me.ListInstalledSoftware.DefaultCellStyle.BackColor = Color.FromArgb(7, 11, 48)
			Me.ListInstalledSoftware.DefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255)
			Me.ListInstalledSoftware.DefaultCellStyle.SelectionBackColor = Color.FromArgb(47, 39, 134)
			Me.ListInstalledSoftware.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255)
			Me.ListInstalledSoftware.CellBorderStyle = DataGridViewCellBorderStyle.None
			Dim expression As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(DataB.InfoClient(Me.ParentClient.L)))
			Try
				Me.ClientInfo.Text = String.Concat(New String() { Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(1), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(3), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(4) })
			Catch ex As Exception
				Me.ClientInfo.Text = "Not found !"
			End Try
			Me.FormSize = True
			Me.MinimumSize = MyBase.Size
		End Sub

		' Token: 0x060005D4 RID: 1492 RVA: 0x00031DF8 File Offset: 0x0002FFF8
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

		' Token: 0x060005D5 RID: 1493 RVA: 0x00031E64 File Offset: 0x00030064
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			ThreadPool.QueueUserWorkItem(Sub(o As Object)
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
				MyBase.Close()
			End Sub)
		End Sub

		' Token: 0x060005D6 RID: 1494 RVA: 0x00031E7C File Offset: 0x0003007C
		Private Sub FormInstalledSoftware_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x060005D7 RID: 1495 RVA: 0x00031F10 File Offset: 0x00030110
		Private Sub RefreshList_Click(sender As Object, e As EventArgs)
			Dim msgPack As MsgPack = New MsgPack()
			msgPack.ForcePathObject("Packet").AsString = "List"
			ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
		End Sub

		' Token: 0x060005D8 RID: 1496 RVA: 0x00031F58 File Offset: 0x00030158
		Private Sub StopServices_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.ListInstalledSoftware.Rows.Count > 0
			If flag Then
				Try
					For Each obj As Object In Me.ListInstalledSoftware.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Dim msgPack As MsgPack = New MsgPack()
						msgPack.ForcePathObject("Packet").AsString = "Unstall"
						msgPack.ForcePathObject("NameSoftware").AsString = dataGridViewRow.Cells(1).Value.ToString()
						ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
					Next
				Catch ex As Exception
					Console.WriteLine(ex.Message)
				End Try
			End If
		End Sub

		' Token: 0x040002A6 RID: 678
		Private FormSize As Boolean
	End Class
End Namespace
