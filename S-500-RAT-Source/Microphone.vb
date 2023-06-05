Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Guna.UI2.WinForms
Imports Guna.UI2.WinForms.Enums
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.My.Resources
Imports S500RAT.Server.Connection
Imports Sunny.UI
Imports WinMic
Imports WinSound

Namespace S500RAT
	' Token: 0x0200003C RID: 60
	<DesignerGenerated()>
	Public Partial Class Microphone
		Inherits Form

		' Token: 0x060010C4 RID: 4292 RVA: 0x0009089C File Offset: 0x0008EA9C
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Microphone_Load
			AddHandler MyBase.Resize, AddressOf Me.Microphone_Resize
			Me.random = New Random()
			Me.FormSize = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x170006D7 RID: 1751
		' (get) Token: 0x060010C7 RID: 4295 RVA: 0x000929CA File Offset: 0x00090BCA
		' (set) Token: 0x060010C8 RID: 4296 RVA: 0x000929D4 File Offset: 0x00090BD4
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

		' Token: 0x170006D8 RID: 1752
		' (get) Token: 0x060010C9 RID: 4297 RVA: 0x00092A17 File Offset: 0x00090C17
		' (set) Token: 0x060010CA RID: 4298 RVA: 0x00092A21 File Offset: 0x00090C21
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x170006D9 RID: 1753
		' (get) Token: 0x060010CB RID: 4299 RVA: 0x00092A2A File Offset: 0x00090C2A
		' (set) Token: 0x060010CC RID: 4300 RVA: 0x00092A34 File Offset: 0x00090C34
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x170006DA RID: 1754
		' (get) Token: 0x060010CD RID: 4301 RVA: 0x00092A3D File Offset: 0x00090C3D
		' (set) Token: 0x060010CE RID: 4302 RVA: 0x00092A47 File Offset: 0x00090C47
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x170006DB RID: 1755
		' (get) Token: 0x060010CF RID: 4303 RVA: 0x00092A50 File Offset: 0x00090C50
		' (set) Token: 0x060010D0 RID: 4304 RVA: 0x00092A5A File Offset: 0x00090C5A
		Friend Overridable Property MAX As ValleyMax

		' Token: 0x170006DC RID: 1756
		' (get) Token: 0x060010D1 RID: 4305 RVA: 0x00092A63 File Offset: 0x00090C63
		' (set) Token: 0x060010D2 RID: 4306 RVA: 0x00092A70 File Offset: 0x00090C70
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

		' Token: 0x170006DD RID: 1757
		' (get) Token: 0x060010D3 RID: 4307 RVA: 0x00092AB3 File Offset: 0x00090CB3
		' (set) Token: 0x060010D4 RID: 4308 RVA: 0x00092ABD File Offset: 0x00090CBD
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x170006DE RID: 1758
		' (get) Token: 0x060010D5 RID: 4309 RVA: 0x00092AC6 File Offset: 0x00090CC6
		' (set) Token: 0x060010D6 RID: 4310 RVA: 0x00092AD0 File Offset: 0x00090CD0
		Private Overridable Property ClientInfo As Label

		' Token: 0x170006DF RID: 1759
		' (get) Token: 0x060010D7 RID: 4311 RVA: 0x00092AD9 File Offset: 0x00090CD9
		' (set) Token: 0x060010D8 RID: 4312 RVA: 0x00092AE4 File Offset: 0x00090CE4
		Friend Overridable Property StartAndStop As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._StartAndStop
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.StartAndStop_Click
				Dim startAndStop As Guna2GradientButton = Me._StartAndStop
				If startAndStop IsNot Nothing Then
					RemoveHandler startAndStop.Click, value2
				End If
				Me._StartAndStop = value
				startAndStop = Me._StartAndStop
				If startAndStop IsNot Nothing Then
					AddHandler startAndStop.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170006E0 RID: 1760
		' (get) Token: 0x060010D9 RID: 4313 RVA: 0x00092B27 File Offset: 0x00090D27
		' (set) Token: 0x060010DA RID: 4314 RVA: 0x00092B31 File Offset: 0x00090D31
		Private Overridable Property Label2 As Label

		' Token: 0x170006E1 RID: 1761
		' (get) Token: 0x060010DB RID: 4315 RVA: 0x00092B3A File Offset: 0x00090D3A
		' (set) Token: 0x060010DC RID: 4316 RVA: 0x00092B44 File Offset: 0x00090D44
		Private Overridable Property Label1 As Label

		' Token: 0x170006E2 RID: 1762
		' (get) Token: 0x060010DD RID: 4317 RVA: 0x00092B4D File Offset: 0x00090D4D
		' (set) Token: 0x060010DE RID: 4318 RVA: 0x00092B57 File Offset: 0x00090D57
		Friend Overridable Property CombxSpeakClient As UIComboBox

		' Token: 0x170006E3 RID: 1763
		' (get) Token: 0x060010DF RID: 4319 RVA: 0x00092B60 File Offset: 0x00090D60
		' (set) Token: 0x060010E0 RID: 4320 RVA: 0x00092B6A File Offset: 0x00090D6A
		Friend Overridable Property combxListenClient As UIComboBox

		' Token: 0x170006E4 RID: 1764
		' (get) Token: 0x060010E1 RID: 4321 RVA: 0x00092B73 File Offset: 0x00090D73
		' (set) Token: 0x060010E2 RID: 4322 RVA: 0x00092B7D File Offset: 0x00090D7D
		Private Overridable Property Label3 As Label

		' Token: 0x170006E5 RID: 1765
		' (get) Token: 0x060010E3 RID: 4323 RVA: 0x00092B86 File Offset: 0x00090D86
		' (set) Token: 0x060010E4 RID: 4324 RVA: 0x00092B90 File Offset: 0x00090D90
		Private Overridable Property Label4 As Label

		' Token: 0x170006E6 RID: 1766
		' (get) Token: 0x060010E5 RID: 4325 RVA: 0x00092B99 File Offset: 0x00090D99
		' (set) Token: 0x060010E6 RID: 4326 RVA: 0x00092BA3 File Offset: 0x00090DA3
		Friend Overridable Property CombxSpeakServer As UIComboBox

		' Token: 0x170006E7 RID: 1767
		' (get) Token: 0x060010E7 RID: 4327 RVA: 0x00092BAC File Offset: 0x00090DAC
		' (set) Token: 0x060010E8 RID: 4328 RVA: 0x00092BB6 File Offset: 0x00090DB6
		Friend Overridable Property CombxListenServer As UIComboBox

		' Token: 0x170006E8 RID: 1768
		' (get) Token: 0x060010E9 RID: 4329 RVA: 0x00092BBF File Offset: 0x00090DBF
		' (set) Token: 0x060010EA RID: 4330 RVA: 0x00092BC9 File Offset: 0x00090DC9
		Friend Overridable Property UiLine1 As UILine

		' Token: 0x170006E9 RID: 1769
		' (get) Token: 0x060010EB RID: 4331 RVA: 0x00092BD2 File Offset: 0x00090DD2
		' (set) Token: 0x060010EC RID: 4332 RVA: 0x00092BDC File Offset: 0x00090DDC
		Friend Overridable Property BufferCount As UIComboBox

		' Token: 0x170006EA RID: 1770
		' (get) Token: 0x060010ED RID: 4333 RVA: 0x00092BE5 File Offset: 0x00090DE5
		' (set) Token: 0x060010EE RID: 4334 RVA: 0x00092BF0 File Offset: 0x00090DF0
		Friend Overridable Property Jitter As Guna2TextBox
			<CompilerGenerated()>
			Get
				Return Me._Jitter
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TextBox)
				Dim value2 As KeyPressEventHandler = AddressOf Me.Jitter_KeyPress
				Dim jitter As Guna2TextBox = Me._Jitter
				If jitter IsNot Nothing Then
					RemoveHandler jitter.KeyPress, value2
				End If
				Me._Jitter = value
				jitter = Me._Jitter
				If jitter IsNot Nothing Then
					AddHandler jitter.KeyPress, value2
				End If
			End Set
		End Property

		' Token: 0x170006EB RID: 1771
		' (get) Token: 0x060010EF RID: 4335 RVA: 0x00092C33 File Offset: 0x00090E33
		' (set) Token: 0x060010F0 RID: 4336 RVA: 0x00092C40 File Offset: 0x00090E40
		Friend Overridable Property SpeakClient As Button
			<CompilerGenerated()>
			Get
				Return Me._SpeakClient
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.SpeakClient_Click
				Dim speakClient As Button = Me._SpeakClient
				If speakClient IsNot Nothing Then
					RemoveHandler speakClient.Click, value2
				End If
				Me._SpeakClient = value
				speakClient = Me._SpeakClient
				If speakClient IsNot Nothing Then
					AddHandler speakClient.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170006EC RID: 1772
		' (get) Token: 0x060010F1 RID: 4337 RVA: 0x00092C83 File Offset: 0x00090E83
		' (set) Token: 0x060010F2 RID: 4338 RVA: 0x00092C90 File Offset: 0x00090E90
		Friend Overridable Property ListenClient As Button
			<CompilerGenerated()>
			Get
				Return Me._ListenClient
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.ListenClient_Click
				Dim listenClient As Button = Me._ListenClient
				If listenClient IsNot Nothing Then
					RemoveHandler listenClient.Click, value2
				End If
				Me._ListenClient = value
				listenClient = Me._ListenClient
				If listenClient IsNot Nothing Then
					AddHandler listenClient.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170006ED RID: 1773
		' (get) Token: 0x060010F3 RID: 4339 RVA: 0x00092CD3 File Offset: 0x00090ED3
		' (set) Token: 0x060010F4 RID: 4340 RVA: 0x00092CE0 File Offset: 0x00090EE0
		Friend Overridable Property ListenServer As Button
			<CompilerGenerated()>
			Get
				Return Me._ListenServer
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.ListenServer_Click_1
				Dim listenServer As Button = Me._ListenServer
				If listenServer IsNot Nothing Then
					RemoveHandler listenServer.Click, value2
				End If
				Me._ListenServer = value
				listenServer = Me._ListenServer
				If listenServer IsNot Nothing Then
					AddHandler listenServer.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170006EE RID: 1774
		' (get) Token: 0x060010F5 RID: 4341 RVA: 0x00092D23 File Offset: 0x00090F23
		' (set) Token: 0x060010F6 RID: 4342 RVA: 0x00092D30 File Offset: 0x00090F30
		Friend Overridable Property SpeakServer As Button
			<CompilerGenerated()>
			Get
				Return Me._SpeakServer
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.SpeakServer_Click_1
				Dim speakServer As Button = Me._SpeakServer
				If speakServer IsNot Nothing Then
					RemoveHandler speakServer.Click, value2
				End If
				Me._SpeakServer = value
				speakServer = Me._SpeakServer
				If speakServer IsNot Nothing Then
					AddHandler speakServer.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170006EF RID: 1775
		' (get) Token: 0x060010F7 RID: 4343 RVA: 0x00092D73 File Offset: 0x00090F73
		' (set) Token: 0x060010F8 RID: 4344 RVA: 0x00092D7D File Offset: 0x00090F7D
		Private Overridable Property Label8 As Label

		' Token: 0x170006F0 RID: 1776
		' (get) Token: 0x060010F9 RID: 4345 RVA: 0x00092D86 File Offset: 0x00090F86
		' (set) Token: 0x060010FA RID: 4346 RVA: 0x00092D90 File Offset: 0x00090F90
		Private Overridable Property Label7 As Label

		' Token: 0x170006F1 RID: 1777
		' (get) Token: 0x060010FB RID: 4347 RVA: 0x00092D99 File Offset: 0x00090F99
		' (set) Token: 0x060010FC RID: 4348 RVA: 0x00092DA3 File Offset: 0x00090FA3
		Private Overridable Property Label6 As Label

		' Token: 0x170006F2 RID: 1778
		' (get) Token: 0x060010FD RID: 4349 RVA: 0x00092DAC File Offset: 0x00090FAC
		' (set) Token: 0x060010FE RID: 4350 RVA: 0x00092DB6 File Offset: 0x00090FB6
		Private Overridable Property Label5 As Label

		' Token: 0x170006F3 RID: 1779
		' (get) Token: 0x060010FF RID: 4351 RVA: 0x00092DBF File Offset: 0x00090FBF
		' (set) Token: 0x06001100 RID: 4352 RVA: 0x00092DCC File Offset: 0x00090FCC
		Friend Overridable Property PictureBox2 As PictureBox
			<CompilerGenerated()>
			Get
				Return Me._PictureBox2
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim value2 As EventHandler = AddressOf Me.PictureBox2_Click
				Dim pictureBox As PictureBox = Me._PictureBox2
				If pictureBox IsNot Nothing Then
					RemoveHandler pictureBox.Click, value2
				End If
				Me._PictureBox2 = value
				pictureBox = Me._PictureBox2
				If pictureBox IsNot Nothing Then
					AddHandler pictureBox.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170006F4 RID: 1780
		' (get) Token: 0x06001101 RID: 4353 RVA: 0x00092E0F File Offset: 0x0009100F
		' (set) Token: 0x06001102 RID: 4354 RVA: 0x00092E19 File Offset: 0x00091019
		Friend Overridable Property PictureBox1 As PictureBox

		' Token: 0x170006F5 RID: 1781
		' (get) Token: 0x06001103 RID: 4355 RVA: 0x00092E22 File Offset: 0x00091022
		' (set) Token: 0x06001104 RID: 4356 RVA: 0x00092E2C File Offset: 0x0009102C
		Friend Overridable Property UiLine3 As UILine

		' Token: 0x170006F6 RID: 1782
		' (get) Token: 0x06001105 RID: 4357 RVA: 0x00092E35 File Offset: 0x00091035
		' (set) Token: 0x06001106 RID: 4358 RVA: 0x00092E3F File Offset: 0x0009103F
		Friend Overridable Property UiLine2 As UILine

		' Token: 0x170006F7 RID: 1783
		' (get) Token: 0x06001107 RID: 4359 RVA: 0x00092E48 File Offset: 0x00091048
		' (set) Token: 0x06001108 RID: 4360 RVA: 0x00092E52 File Offset: 0x00091052
		Friend Overridable Property ProgressBar1 As Guna2ProgressBar

		' Token: 0x170006F8 RID: 1784
		' (get) Token: 0x06001109 RID: 4361 RVA: 0x00092E5B File Offset: 0x0009105B
		' (set) Token: 0x0600110A RID: 4362 RVA: 0x00092E65 File Offset: 0x00091065
		Public Property Port As String

		' Token: 0x170006F9 RID: 1785
		' (get) Token: 0x0600110B RID: 4363 RVA: 0x00092E6E File Offset: 0x0009106E
		' (set) Token: 0x0600110C RID: 4364 RVA: 0x00092E78 File Offset: 0x00091078
		Public Property IP As String

		' Token: 0x170006FA RID: 1786
		' (get) Token: 0x0600110D RID: 4365 RVA: 0x00092E81 File Offset: 0x00091081
		' (set) Token: 0x0600110E RID: 4366 RVA: 0x00092E8B File Offset: 0x0009108B
		Public Property Client As Clients

		' Token: 0x170006FB RID: 1787
		' (get) Token: 0x0600110F RID: 4367 RVA: 0x00092E94 File Offset: 0x00091094
		' (set) Token: 0x06001110 RID: 4368 RVA: 0x00092E9E File Offset: 0x0009109E
		Public Property F As FormS500

		' Token: 0x170006FC RID: 1788
		' (get) Token: 0x06001111 RID: 4369 RVA: 0x00092EA7 File Offset: 0x000910A7
		' (set) Token: 0x06001112 RID: 4370 RVA: 0x00092EB1 File Offset: 0x000910B1
		Public Property FullPath As String

		' Token: 0x170006FD RID: 1789
		' (get) Token: 0x06001113 RID: 4371 RVA: 0x00092EBA File Offset: 0x000910BA
		' (set) Token: 0x06001114 RID: 4372 RVA: 0x00092EC4 File Offset: 0x000910C4
		Friend Property ParentClient As Clients

		' Token: 0x06001115 RID: 4373 RVA: 0x00092ED0 File Offset: 0x000910D0
		Private Sub Microphone_Load(sender As Object, e As EventArgs)
			Me.Port = Convert.ToString(Me.random.[Next](6066, 9090))
			Me.BufferCount.SelectedIndex = 1
			Dim expression As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(DataB.InfoClient(Me.ParentClient.L)))
			Try
				Me.ClientInfo.Text = String.Concat(New String() { Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(1), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(3), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(4) })
			Catch ex As Exception
				Me.ClientInfo.Text = "Not found !"
			End Try
			Me.FormSize = True
			Me.MinimumSize = MyBase.Size
		End Sub

		' Token: 0x06001116 RID: 4374 RVA: 0x00092FE8 File Offset: 0x000911E8
		Private Sub Microphone_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x06001117 RID: 4375 RVA: 0x0009307C File Offset: 0x0009127C
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

		' Token: 0x06001118 RID: 4376 RVA: 0x000930E8 File Offset: 0x000912E8
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			Try
				Me.Disconnect()
			Catch ex As Exception
			End Try
			Try
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
				MyBase.Close()
			Catch ex2 As Exception
			End Try
		End Sub

		' Token: 0x06001119 RID: 4377 RVA: 0x00093154 File Offset: 0x00091354
		Public Sub Disconnect()
			Try
				Dim flag As Boolean = Operators.CompareString(Me.StartAndStop.Text, "Stop", False) = 0 AndAlso Record.IsServerRunning
				If flag Then
					Record.StopServer()
					Record.StopRecordingFromSounddevice_Server()
					Record.StopTimerMixed()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").AsString = "Disconnect"
					msgPack.ForcePathObject("Port").AsString = Me.Port
					msgPack.ForcePathObject("Speak").AsString = Me.CombxSpeakClient.Text
					msgPack.ForcePathObject("Listen").AsString = Me.combxListenClient.Text
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600111A RID: 4378 RVA: 0x00093248 File Offset: 0x00091448
		Private Sub StartAndStop_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Jitter.Text, Nothing, False) = 0
			If flag Then
				Me.Jitter.Text = "20"
			End If
			Dim flag2 As Boolean = Operators.CompareString(Me.IP, Nothing, False) = 0
			If flag2 Then
				MessageBox.Show("An unexpected error occurred", "S500 | Microphone!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1)
			Else
				Try
					Record.FormToConfig(Me.IP, Me.Port, Me.CombxSpeakServer.Text, Me.CombxListenServer.Text, Conversions.ToUInteger(Me.Jitter.Text), Conversions.ToInteger(Me.BufferCount.Text))
					Dim flag3 As Boolean = Operators.CompareString(Me.StartAndStop.Text, "Start", False) = 0 AndAlso Not Record.IsServerRunning
					If flag3 Then
						Me.StartAndStop.Text = "Start.."
						Me.StartAndStop.Enabled = False
						Record.StartServer()
						Dim flag4 As Boolean = Not Record.m_Config.ServerNoSpeakAll
						If flag4 Then
							Record.StartRecordingFromSounddevice_Server()
						End If
						Record.StartTimerMixed()
						Dim msgPack As MsgPack = New MsgPack()
						msgPack.ForcePathObject("Packet").AsString = "Connect"
						msgPack.ForcePathObject("Port").AsString = Me.Port
						msgPack.ForcePathObject("Speak").AsString = Me.CombxSpeakClient.Text
						msgPack.ForcePathObject("Listen").AsString = Me.combxListenClient.Text
						ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
						Me.BufferCount.Enabled = False
						Me.Jitter.Enabled = False
					Else
						Dim flag5 As Boolean = Operators.CompareString(Me.StartAndStop.Text, "Stop", False) = 0 AndAlso Record.IsServerRunning
						If flag5 Then
							Me.StartAndStop.Text = "Stop.."
							Me.StartAndStop.Enabled = False
							Record.StopServer()
							Record.StopRecordingFromSounddevice_Server()
							Record.StopTimerMixed()
							Dim msgPack2 As MsgPack = New MsgPack()
							msgPack2.ForcePathObject("Packet").AsString = "Disconnect"
							msgPack2.ForcePathObject("Port").AsString = Me.Port
							msgPack2.ForcePathObject("Speak").AsString = Me.CombxSpeakClient.Text
							msgPack2.ForcePathObject("Listen").AsString = Me.combxListenClient.Text
							ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack2.Encode2Bytes())
							Me.BufferCount.Enabled = True
							Me.Jitter.Enabled = True
						Else
							Record.StopServer()
							Record.StopRecordingFromSounddevice_Server()
							Record.StopTimerMixed()
							Dim msgPack3 As MsgPack = New MsgPack()
							msgPack3.ForcePathObject("Packet").AsString = "Disconnect"
							msgPack3.ForcePathObject("Port").AsString = Me.Port
							msgPack3.ForcePathObject("Speak").AsString = Me.CombxSpeakClient.Text
							msgPack3.ForcePathObject("Listen").AsString = Me.combxListenClient.Text
							ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack3.Encode2Bytes())
							Me.BufferCount.Enabled = True
							Me.Jitter.Enabled = True
							Me.StartAndStop.Enabled = True
							Me.StartAndStop.Text = "Start"
						End If
					End If
				Catch ex As Exception
					Me.BufferCount.Enabled = True
					Me.Jitter.Enabled = True
					Me.StartAndStop.Enabled = True
					Me.StartAndStop.Text = "Start"
					MessageBox.Show(ex.Message, "S500 | Microphone!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1)
				End Try
			End If
		End Sub

		' Token: 0x0600111B RID: 4379 RVA: 0x0009366C File Offset: 0x0009186C
		Private Sub SpeakClient_Click(sender As Object, e As EventArgs)
			Try
				Me.SpeakClient.Enabled = False
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "ClientSpeak"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600111C RID: 4380 RVA: 0x000936E4 File Offset: 0x000918E4
		Private Sub ListenClient_Click(sender As Object, e As EventArgs)
			Try
				Me.ListenClient.Enabled = False
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "ClientListen"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600111D RID: 4381 RVA: 0x0009375C File Offset: 0x0009195C
		Public Sub InitComboboxesServer()
			Me.CombxListenServer.Items.Clear()
			Me.CombxSpeakServer.Items.Clear()
			Dim playbackNames As List(Of String) = WinSound.GetPlaybackNames()
			Dim recordingNames As List(Of String) = WinSound.GetRecordingNames()
			Try
				Dim source As IEnumerable(Of String) = playbackNames
				Dim predicate As Func(Of String, Boolean)
				If Microphone._Closure$__.$I170-0 IsNot Nothing Then
					predicate = Microphone._Closure$__.$I170-0
				Else
					Dim func As Func(Of String, Boolean) = Function(x As String) Not Object.Equals(x, Nothing)
					predicate = func
					Microphone._Closure$__.$I170-0 = func
				End If
				For Each item As String In source.Where(predicate)
					Me.CombxListenServer.Items.Add(item)
				Next
			Finally
				Dim enumerator As IEnumerator(Of String)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Try
				Dim source2 As IEnumerable(Of String) = recordingNames
				Dim predicate2 As Func(Of String, Boolean)
				If Microphone._Closure$__.$I170-1 IsNot Nothing Then
					predicate2 = Microphone._Closure$__.$I170-1
				Else
					Dim func2 As Func(Of String, Boolean) = Function(x As String) Not Object.Equals(x, Nothing)
					predicate2 = func2
					Microphone._Closure$__.$I170-1 = func2
				End If
				For Each item2 As String In source2.Where(predicate2)
					Me.CombxSpeakServer.Items.Add(item2)
				Next
			Finally
				Dim enumerator2 As IEnumerator(Of String)
				If enumerator2 IsNot Nothing Then
					enumerator2.Dispose()
				End If
			End Try
			Dim flag As Boolean = Me.CombxListenServer.Items.Count > 0
			If flag Then
				Me.CombxListenServer.SelectedIndex = 0
			End If
			Dim flag2 As Boolean = Me.CombxSpeakServer.Items.Count > 0
			If flag2 Then
				Me.CombxSpeakServer.SelectedIndex = 0
			End If
		End Sub

		' Token: 0x0600111E RID: 4382 RVA: 0x000938D8 File Offset: 0x00091AD8
		Private Sub SpeakServer_Click_1(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Record.ServerSpeak()
				If flag Then
					Me.SpeakServer.Image = Resources.MicOFF
				Else
					Me.SpeakServer.Image = Resources.MicON
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600111F RID: 4383 RVA: 0x00093938 File Offset: 0x00091B38
		Private Sub ListenServer_Click_1(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Record.ServerListen()
				If flag Then
					Me.ListenServer.Image = Resources.ListenOFF
				Else
					Me.ListenServer.Image = Resources.ListenONN
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06001120 RID: 4384 RVA: 0x00093998 File Offset: 0x00091B98
		Private Sub Jitter_KeyPress(sender As Object, e As KeyPressEventArgs)
			Dim flag As Boolean = Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar)
			If flag Then
				e.Handled = True
			End If
		End Sub

		' Token: 0x06001121 RID: 4385 RVA: 0x000939D1 File Offset: 0x00091BD1
		Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
			Interaction.MsgBox(Me.IP, MsgBoxStyle.OkOnly, Nothing)
		End Sub

		' Token: 0x040007A3 RID: 1955
		Private random As Random

		' Token: 0x040007AA RID: 1962
		Private FormSize As Boolean
	End Class
End Namespace
