Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Guna.UI2.WinForms
Imports Guna.UI2.WinForms.Enums
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection
Imports Sunny.UI

Namespace S500RAT
	' Token: 0x02000020 RID: 32
	<DesignerGenerated()>
	Public Partial Class FormInformation
		Inherits Form

		' Token: 0x0600057C RID: 1404 RVA: 0x0002F440 File Offset: 0x0002D640
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormInformation_Load
			AddHandler MyBase.Resize, AddressOf Me.FormInformation_Resize
			Me.FormSize = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000238 RID: 568
		' (get) Token: 0x0600057F RID: 1407 RVA: 0x00030530 File Offset: 0x0002E730
		' (set) Token: 0x06000580 RID: 1408 RVA: 0x0003053A File Offset: 0x0002E73A
		Friend Overridable Property ImageList1 As ImageList

		' Token: 0x17000239 RID: 569
		' (get) Token: 0x06000581 RID: 1409 RVA: 0x00030543 File Offset: 0x0002E743
		' (set) Token: 0x06000582 RID: 1410 RVA: 0x00030550 File Offset: 0x0002E750
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

		' Token: 0x1700023A RID: 570
		' (get) Token: 0x06000583 RID: 1411 RVA: 0x00030593 File Offset: 0x0002E793
		' (set) Token: 0x06000584 RID: 1412 RVA: 0x0003059D File Offset: 0x0002E79D
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x1700023B RID: 571
		' (get) Token: 0x06000585 RID: 1413 RVA: 0x000305A6 File Offset: 0x0002E7A6
		' (set) Token: 0x06000586 RID: 1414 RVA: 0x000305B0 File Offset: 0x0002E7B0
		Private Overridable Property ClientInfo As Label

		' Token: 0x1700023C RID: 572
		' (get) Token: 0x06000587 RID: 1415 RVA: 0x000305B9 File Offset: 0x0002E7B9
		' (set) Token: 0x06000588 RID: 1416 RVA: 0x000305C3 File Offset: 0x0002E7C3
		Friend Overridable Property ListNode As TreeView

		' Token: 0x1700023D RID: 573
		' (get) Token: 0x06000589 RID: 1417 RVA: 0x000305CC File Offset: 0x0002E7CC
		' (set) Token: 0x0600058A RID: 1418 RVA: 0x000305D6 File Offset: 0x0002E7D6
		Friend Overridable Property Guna2ResizeBox1 As Guna2ResizeBox

		' Token: 0x1700023E RID: 574
		' (get) Token: 0x0600058B RID: 1419 RVA: 0x000305DF File Offset: 0x0002E7DF
		' (set) Token: 0x0600058C RID: 1420 RVA: 0x000305E9 File Offset: 0x0002E7E9
		Friend Overridable Property Guna2Elipse1 As Guna2Elipse

		' Token: 0x1700023F RID: 575
		' (get) Token: 0x0600058D RID: 1421 RVA: 0x000305F2 File Offset: 0x0002E7F2
		' (set) Token: 0x0600058E RID: 1422 RVA: 0x000305FC File Offset: 0x0002E7FC
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x17000240 RID: 576
		' (get) Token: 0x0600058F RID: 1423 RVA: 0x00030605 File Offset: 0x0002E805
		' (set) Token: 0x06000590 RID: 1424 RVA: 0x0003060F File Offset: 0x0002E80F
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x17000241 RID: 577
		' (get) Token: 0x06000591 RID: 1425 RVA: 0x00030618 File Offset: 0x0002E818
		' (set) Token: 0x06000592 RID: 1426 RVA: 0x00030622 File Offset: 0x0002E822
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x17000242 RID: 578
		' (get) Token: 0x06000593 RID: 1427 RVA: 0x0003062B File Offset: 0x0002E82B
		' (set) Token: 0x06000594 RID: 1428 RVA: 0x00030635 File Offset: 0x0002E835
		Friend Overridable Property MAX As ValleyMax

		' Token: 0x17000243 RID: 579
		' (get) Token: 0x06000595 RID: 1429 RVA: 0x0003063E File Offset: 0x0002E83E
		' (set) Token: 0x06000596 RID: 1430 RVA: 0x00030648 File Offset: 0x0002E848
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

		' Token: 0x17000244 RID: 580
		' (get) Token: 0x06000597 RID: 1431 RVA: 0x0003068B File Offset: 0x0002E88B
		' (set) Token: 0x06000598 RID: 1432 RVA: 0x00030695 File Offset: 0x0002E895
		Public Property Client As Clients

		' Token: 0x17000245 RID: 581
		' (get) Token: 0x06000599 RID: 1433 RVA: 0x0003069E File Offset: 0x0002E89E
		' (set) Token: 0x0600059A RID: 1434 RVA: 0x000306A8 File Offset: 0x0002E8A8
		Public Property F As FormS500

		' Token: 0x17000246 RID: 582
		' (get) Token: 0x0600059B RID: 1435 RVA: 0x000306B1 File Offset: 0x0002E8B1
		' (set) Token: 0x0600059C RID: 1436 RVA: 0x000306BB File Offset: 0x0002E8BB
		Public Property FullPath As String

		' Token: 0x17000247 RID: 583
		' (get) Token: 0x0600059D RID: 1437 RVA: 0x000306C4 File Offset: 0x0002E8C4
		' (set) Token: 0x0600059E RID: 1438 RVA: 0x000306CE File Offset: 0x0002E8CE
		Friend Property ParentClient As Clients

		' Token: 0x0600059F RID: 1439 RVA: 0x000306D8 File Offset: 0x0002E8D8
		Private Sub FormInformation_Load(sender As Object, e As EventArgs)
			Dim expression As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(DataB.InfoClient(Me.ParentClient.L)))
			Try
				Me.ClientInfo.Text = String.Concat(New String() { Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(1), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(3), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(4) })
			Catch ex As Exception
				Me.ClientInfo.Text = "Not found !"
			End Try
			Me.FormSize = True
			Me.MinimumSize = MyBase.Size
		End Sub

		' Token: 0x060005A0 RID: 1440 RVA: 0x000307C0 File Offset: 0x0002E9C0
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

		' Token: 0x060005A1 RID: 1441 RVA: 0x0003082C File Offset: 0x0002EA2C
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			ThreadPool.QueueUserWorkItem(Sub(o As Object)
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
				MyBase.Close()
			End Sub)
		End Sub

		' Token: 0x060005A2 RID: 1442 RVA: 0x00030844 File Offset: 0x0002EA44
		Private Sub FormInformation_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x0400028E RID: 654
		Private FormSize As Boolean
	End Class
End Namespace
