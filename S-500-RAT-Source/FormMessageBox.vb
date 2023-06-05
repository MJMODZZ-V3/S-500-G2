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
	' Token: 0x02000024 RID: 36
	<DesignerGenerated()>
	Public Partial Class FormMessageBox
		Inherits Form

		' Token: 0x06000622 RID: 1570 RVA: 0x00034712 File Offset: 0x00032912
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormMessageBox_Load
			AddHandler MyBase.Resize, AddressOf Me.FormMessageBox_Resize
			Me.FormSize = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000279 RID: 633
		' (get) Token: 0x06000625 RID: 1573 RVA: 0x00036537 File Offset: 0x00034737
		' (set) Token: 0x06000626 RID: 1574 RVA: 0x00036544 File Offset: 0x00034744
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

		' Token: 0x1700027A RID: 634
		' (get) Token: 0x06000627 RID: 1575 RVA: 0x00036587 File Offset: 0x00034787
		' (set) Token: 0x06000628 RID: 1576 RVA: 0x00036591 File Offset: 0x00034791
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x1700027B RID: 635
		' (get) Token: 0x06000629 RID: 1577 RVA: 0x0003659A File Offset: 0x0003479A
		' (set) Token: 0x0600062A RID: 1578 RVA: 0x000365A4 File Offset: 0x000347A4
		Private Overridable Property ClientInfo As Label

		' Token: 0x1700027C RID: 636
		' (get) Token: 0x0600062B RID: 1579 RVA: 0x000365AD File Offset: 0x000347AD
		' (set) Token: 0x0600062C RID: 1580 RVA: 0x000365B7 File Offset: 0x000347B7
		Friend Overridable Property Guna2ResizeBox1 As Guna2ResizeBox

		' Token: 0x1700027D RID: 637
		' (get) Token: 0x0600062D RID: 1581 RVA: 0x000365C0 File Offset: 0x000347C0
		' (set) Token: 0x0600062E RID: 1582 RVA: 0x000365CA File Offset: 0x000347CA
		Friend Overridable Property Panel3 As Panel

		' Token: 0x1700027E RID: 638
		' (get) Token: 0x0600062F RID: 1583 RVA: 0x000365D3 File Offset: 0x000347D3
		' (set) Token: 0x06000630 RID: 1584 RVA: 0x000365DD File Offset: 0x000347DD
		Friend Overridable Property PictureBox6 As PictureBox

		' Token: 0x1700027F RID: 639
		' (get) Token: 0x06000631 RID: 1585 RVA: 0x000365E6 File Offset: 0x000347E6
		' (set) Token: 0x06000632 RID: 1586 RVA: 0x000365F0 File Offset: 0x000347F0
		Friend Overridable Property PictureBox5 As PictureBox

		' Token: 0x17000280 RID: 640
		' (get) Token: 0x06000633 RID: 1587 RVA: 0x000365F9 File Offset: 0x000347F9
		' (set) Token: 0x06000634 RID: 1588 RVA: 0x00036603 File Offset: 0x00034803
		Friend Overridable Property PictureBox2 As PictureBox

		' Token: 0x17000281 RID: 641
		' (get) Token: 0x06000635 RID: 1589 RVA: 0x0003660C File Offset: 0x0003480C
		' (set) Token: 0x06000636 RID: 1590 RVA: 0x00036616 File Offset: 0x00034816
		Friend Overridable Property PictureBox4 As PictureBox

		' Token: 0x17000282 RID: 642
		' (get) Token: 0x06000637 RID: 1591 RVA: 0x0003661F File Offset: 0x0003481F
		' (set) Token: 0x06000638 RID: 1592 RVA: 0x00036629 File Offset: 0x00034829
		Public Overridable Property title As Guna2TextBox

		' Token: 0x17000283 RID: 643
		' (get) Token: 0x06000639 RID: 1593 RVA: 0x00036632 File Offset: 0x00034832
		' (set) Token: 0x0600063A RID: 1594 RVA: 0x0003663C File Offset: 0x0003483C
		Friend Overridable Property AbortRetryIgnore As UIRadioButton

		' Token: 0x17000284 RID: 644
		' (get) Token: 0x0600063B RID: 1595 RVA: 0x00036645 File Offset: 0x00034845
		' (set) Token: 0x0600063C RID: 1596 RVA: 0x0003664F File Offset: 0x0003484F
		Friend Overridable Property RetryCancel As UIRadioButton

		' Token: 0x17000285 RID: 645
		' (get) Token: 0x0600063D RID: 1597 RVA: 0x00036658 File Offset: 0x00034858
		' (set) Token: 0x0600063E RID: 1598 RVA: 0x00036662 File Offset: 0x00034862
		Friend Overridable Property OkCancel As UIRadioButton

		' Token: 0x17000286 RID: 646
		' (get) Token: 0x0600063F RID: 1599 RVA: 0x0003666B File Offset: 0x0003486B
		' (set) Token: 0x06000640 RID: 1600 RVA: 0x00036675 File Offset: 0x00034875
		Friend Overridable Property OK As UIRadioButton

		' Token: 0x17000287 RID: 647
		' (get) Token: 0x06000641 RID: 1601 RVA: 0x0003667E File Offset: 0x0003487E
		' (set) Token: 0x06000642 RID: 1602 RVA: 0x00036688 File Offset: 0x00034888
		Friend Overridable Property YesNoCancel As UIRadioButton

		' Token: 0x17000288 RID: 648
		' (get) Token: 0x06000643 RID: 1603 RVA: 0x00036691 File Offset: 0x00034891
		' (set) Token: 0x06000644 RID: 1604 RVA: 0x0003669B File Offset: 0x0003489B
		Friend Overridable Property YesNo As UIRadioButton

		' Token: 0x17000289 RID: 649
		' (get) Token: 0x06000645 RID: 1605 RVA: 0x000366A4 File Offset: 0x000348A4
		' (set) Token: 0x06000646 RID: 1606 RVA: 0x000366AE File Offset: 0x000348AE
		Friend Overridable Property MsgInformation As UIRadioButton

		' Token: 0x1700028A RID: 650
		' (get) Token: 0x06000647 RID: 1607 RVA: 0x000366B7 File Offset: 0x000348B7
		' (set) Token: 0x06000648 RID: 1608 RVA: 0x000366C1 File Offset: 0x000348C1
		Friend Overridable Property MsgError As UIRadioButton

		' Token: 0x1700028B RID: 651
		' (get) Token: 0x06000649 RID: 1609 RVA: 0x000366CA File Offset: 0x000348CA
		' (set) Token: 0x0600064A RID: 1610 RVA: 0x000366D4 File Offset: 0x000348D4
		Friend Overridable Property MsgWarning As UIRadioButton

		' Token: 0x1700028C RID: 652
		' (get) Token: 0x0600064B RID: 1611 RVA: 0x000366DD File Offset: 0x000348DD
		' (set) Token: 0x0600064C RID: 1612 RVA: 0x000366E7 File Offset: 0x000348E7
		Friend Overridable Property MsgQuestion As UIRadioButton

		' Token: 0x1700028D RID: 653
		' (get) Token: 0x0600064D RID: 1613 RVA: 0x000366F0 File Offset: 0x000348F0
		' (set) Token: 0x0600064E RID: 1614 RVA: 0x000366FC File Offset: 0x000348FC
		Friend Overridable Property SendMessage As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._SendMessage
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.SendMessage_Click
				Dim sendMessage As Guna2GradientButton = Me._SendMessage
				If sendMessage IsNot Nothing Then
					RemoveHandler sendMessage.Click, value2
				End If
				Me._SendMessage = value
				sendMessage = Me._SendMessage
				If sendMessage IsNot Nothing Then
					AddHandler sendMessage.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700028E RID: 654
		' (get) Token: 0x0600064F RID: 1615 RVA: 0x0003673F File Offset: 0x0003493F
		' (set) Token: 0x06000650 RID: 1616 RVA: 0x0003674C File Offset: 0x0003494C
		Friend Overridable Property Test As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._Test
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.Test_Click
				Dim test As Guna2GradientButton = Me._Test
				If test IsNot Nothing Then
					RemoveHandler test.Click, value2
				End If
				Me._Test = value
				test = Me._Test
				If test IsNot Nothing Then
					AddHandler test.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700028F RID: 655
		' (get) Token: 0x06000651 RID: 1617 RVA: 0x0003678F File Offset: 0x0003498F
		' (set) Token: 0x06000652 RID: 1618 RVA: 0x00036799 File Offset: 0x00034999
		Public Overridable Property Message As UIRichTextBox

		' Token: 0x17000290 RID: 656
		' (get) Token: 0x06000653 RID: 1619 RVA: 0x000367A2 File Offset: 0x000349A2
		' (set) Token: 0x06000654 RID: 1620 RVA: 0x000367AC File Offset: 0x000349AC
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x17000291 RID: 657
		' (get) Token: 0x06000655 RID: 1621 RVA: 0x000367B5 File Offset: 0x000349B5
		' (set) Token: 0x06000656 RID: 1622 RVA: 0x000367BF File Offset: 0x000349BF
		Friend Overridable Property MAX As ValleyMax

		' Token: 0x17000292 RID: 658
		' (get) Token: 0x06000657 RID: 1623 RVA: 0x000367C8 File Offset: 0x000349C8
		' (set) Token: 0x06000658 RID: 1624 RVA: 0x000367D4 File Offset: 0x000349D4
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

		' Token: 0x17000293 RID: 659
		' (get) Token: 0x06000659 RID: 1625 RVA: 0x00036817 File Offset: 0x00034A17
		' (set) Token: 0x0600065A RID: 1626 RVA: 0x00036821 File Offset: 0x00034A21
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x17000294 RID: 660
		' (get) Token: 0x0600065B RID: 1627 RVA: 0x0003682A File Offset: 0x00034A2A
		' (set) Token: 0x0600065C RID: 1628 RVA: 0x00036834 File Offset: 0x00034A34
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x17000295 RID: 661
		' (get) Token: 0x0600065D RID: 1629 RVA: 0x0003683D File Offset: 0x00034A3D
		' (set) Token: 0x0600065E RID: 1630 RVA: 0x00036847 File Offset: 0x00034A47
		Public Property Client As Clients

		' Token: 0x17000296 RID: 662
		' (get) Token: 0x0600065F RID: 1631 RVA: 0x00036850 File Offset: 0x00034A50
		' (set) Token: 0x06000660 RID: 1632 RVA: 0x0003685A File Offset: 0x00034A5A
		Public Property F As FormS500

		' Token: 0x17000297 RID: 663
		' (get) Token: 0x06000661 RID: 1633 RVA: 0x00036863 File Offset: 0x00034A63
		' (set) Token: 0x06000662 RID: 1634 RVA: 0x0003686D File Offset: 0x00034A6D
		Public Property FullPath As String

		' Token: 0x17000298 RID: 664
		' (get) Token: 0x06000663 RID: 1635 RVA: 0x00036876 File Offset: 0x00034A76
		' (set) Token: 0x06000664 RID: 1636 RVA: 0x00036880 File Offset: 0x00034A80
		Friend Property ParentClient As Clients

		' Token: 0x06000665 RID: 1637 RVA: 0x0003688C File Offset: 0x00034A8C
		Private Sub FormMessageBox_Load(sender As Object, e As EventArgs)
			Dim expression As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(DataB.InfoClient(Me.ParentClient.L)))
			Try
				Me.ClientInfo.Text = String.Concat(New String() { Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(1), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(3), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(4) })
			Catch ex As Exception
				Me.ClientInfo.Text = "Not found !"
			End Try
			Me.FormSize = True
			Me.MinimumSize = MyBase.Size
			Me.OK.Checked = True
			Me.MsgError.Checked = True
		End Sub

		' Token: 0x06000666 RID: 1638 RVA: 0x00036990 File Offset: 0x00034B90
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

		' Token: 0x06000667 RID: 1639 RVA: 0x000369FC File Offset: 0x00034BFC
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			ThreadPool.QueueUserWorkItem(Sub(o As Object)
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
				MyBase.Close()
			End Sub)
		End Sub

		' Token: 0x06000668 RID: 1640 RVA: 0x00036A14 File Offset: 0x00034C14
		Private Sub FormMessageBox_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x06000669 RID: 1641 RVA: 0x00036AA8 File Offset: 0x00034CA8
		Public Function Messageicon() As Object
			Dim result As String = ""
			Dim checked As Boolean = Me.MsgInformation.Checked
			If checked Then
				result = "1"
			Else
				Dim checked2 As Boolean = Me.MsgQuestion.Checked
				If checked2 Then
					result = "2"
				Else
					Dim checked3 As Boolean = Me.MsgWarning.Checked
					If checked3 Then
						result = "3"
					Else
						Dim checked4 As Boolean = Me.MsgError.Checked
						If checked4 Then
							result = "4"
						End If
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x0600066A RID: 1642 RVA: 0x00036B24 File Offset: 0x00034D24
		Public Function Messagebutton() As Object
			Dim result As String = ""
			Dim checked As Boolean = Me.YesNo.Checked
			If checked Then
				result = "1"
			Else
				Dim checked2 As Boolean = Me.YesNoCancel.Checked
				If checked2 Then
					result = "2"
				Else
					Dim checked3 As Boolean = Me.OK.Checked
					If checked3 Then
						result = "3"
					Else
						Dim checked4 As Boolean = Me.OkCancel.Checked
						If checked4 Then
							result = "4"
						Else
							Dim checked5 As Boolean = Me.RetryCancel.Checked
							If checked5 Then
								result = "5"
							Else
								Dim checked6 As Boolean = Me.AbortRetryIgnore.Checked
								If checked6 Then
									result = "6"
								End If
							End If
						End If
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x0600066B RID: 1643 RVA: 0x00036BD4 File Offset: 0x00034DD4
		Private Sub Test_Click(sender As Object, e As EventArgs)
			Dim checked As Boolean = Me.MsgInformation.Checked
			Dim icon As MessageBoxIcon
			If checked Then
				icon = MessageBoxIcon.Asterisk
			Else
				Dim checked2 As Boolean = Me.MsgQuestion.Checked
				If checked2 Then
					icon = MessageBoxIcon.Question
				Else
					Dim checked3 As Boolean = Me.MsgWarning.Checked
					If checked3 Then
						icon = MessageBoxIcon.Exclamation
					Else
						Dim checked4 As Boolean = Me.MsgError.Checked
						If checked4 Then
							icon = MessageBoxIcon.Hand
						Else
							icon = MessageBoxIcon.Asterisk
						End If
					End If
				End If
			End If
			Dim checked5 As Boolean = Me.YesNo.Checked
			Dim buttons As MessageBoxButtons
			If checked5 Then
				buttons = MessageBoxButtons.YesNo
			Else
				Dim checked6 As Boolean = Me.YesNoCancel.Checked
				If checked6 Then
					buttons = MessageBoxButtons.YesNoCancel
				Else
					Dim checked7 As Boolean = Me.OK.Checked
					If checked7 Then
						buttons = MessageBoxButtons.OK
					Else
						Dim checked8 As Boolean = Me.OkCancel.Checked
						If checked8 Then
							buttons = MessageBoxButtons.OKCancel
						Else
							Dim checked9 As Boolean = Me.RetryCancel.Checked
							If checked9 Then
								buttons = MessageBoxButtons.RetryCancel
							Else
								Dim checked10 As Boolean = Me.AbortRetryIgnore.Checked
								If checked10 Then
									buttons = MessageBoxButtons.AbortRetryIgnore
								Else
									buttons = MessageBoxButtons.OK
								End If
							End If
						End If
					End If
				End If
			End If
			MessageBox.Show(Me.title.Text, Me.Message.Text, buttons, icon)
		End Sub

		' Token: 0x0600066C RID: 1644 RVA: 0x00036CE8 File Offset: 0x00034EE8
		Private Sub SendMessage_Click(sender As Object, e As EventArgs)
			Try
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "Message"
				msgPack.ForcePathObject("messageicon").AsString = Conversions.ToString(Me.Messageicon())
				msgPack.ForcePathObject("messagebutton").AsString = Conversions.ToString(Me.Messagebutton())
				msgPack.ForcePathObject("title").AsString = Me.title.Text
				msgPack.ForcePathObject("MsgBox").AsString = Me.Message.Text
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x040002E9 RID: 745
		Private FormSize As Boolean
	End Class
End Namespace
