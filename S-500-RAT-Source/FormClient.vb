Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Guna.UI2.WinForms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection
Imports Sunny.UI

Namespace S500RAT
	' Token: 0x02000013 RID: 19
	<DesignerGenerated()>
	Public Partial Class FormClient
		Inherits Form

		' Token: 0x06000151 RID: 337 RVA: 0x0000B365 File Offset: 0x00009565
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormClient_Load
			AddHandler MyBase.Resize, AddressOf Me.FormClient_Resize
			Me.FormSize = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700009E RID: 158
		' (get) Token: 0x06000154 RID: 340 RVA: 0x0000C02A File Offset: 0x0000A22A
		' (set) Token: 0x06000155 RID: 341 RVA: 0x0000C034 File Offset: 0x0000A234
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x1700009F RID: 159
		' (get) Token: 0x06000156 RID: 342 RVA: 0x0000C03D File Offset: 0x0000A23D
		' (set) Token: 0x06000157 RID: 343 RVA: 0x0000C048 File Offset: 0x0000A248
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

		' Token: 0x170000A0 RID: 160
		' (get) Token: 0x06000158 RID: 344 RVA: 0x0000C08B File Offset: 0x0000A28B
		' (set) Token: 0x06000159 RID: 345 RVA: 0x0000C095 File Offset: 0x0000A295
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x170000A1 RID: 161
		' (get) Token: 0x0600015A RID: 346 RVA: 0x0000C09E File Offset: 0x0000A29E
		' (set) Token: 0x0600015B RID: 347 RVA: 0x0000C0A8 File Offset: 0x0000A2A8
		Private Overridable Property ClientInfo As Label

		' Token: 0x170000A2 RID: 162
		' (get) Token: 0x0600015C RID: 348 RVA: 0x0000C0B1 File Offset: 0x0000A2B1
		' (set) Token: 0x0600015D RID: 349 RVA: 0x0000C0BB File Offset: 0x0000A2BB
		Friend Overridable Property UiLabel4 As UILabel

		' Token: 0x170000A3 RID: 163
		' (get) Token: 0x0600015E RID: 350 RVA: 0x0000C0C4 File Offset: 0x0000A2C4
		' (set) Token: 0x0600015F RID: 351 RVA: 0x0000C0CE File Offset: 0x0000A2CE
		Friend Overridable Property UiLabel3 As UILabel

		' Token: 0x170000A4 RID: 164
		' (get) Token: 0x06000160 RID: 352 RVA: 0x0000C0D7 File Offset: 0x0000A2D7
		' (set) Token: 0x06000161 RID: 353 RVA: 0x0000C0E1 File Offset: 0x0000A2E1
		Friend Overridable Property UiLabel2 As UILabel

		' Token: 0x170000A5 RID: 165
		' (get) Token: 0x06000162 RID: 354 RVA: 0x0000C0EA File Offset: 0x0000A2EA
		' (set) Token: 0x06000163 RID: 355 RVA: 0x0000C0F4 File Offset: 0x0000A2F4
		Friend Overridable Property Guna2ResizeBox1 As Guna2ResizeBox

		' Token: 0x170000A6 RID: 166
		' (get) Token: 0x06000164 RID: 356 RVA: 0x0000C0FD File Offset: 0x0000A2FD
		' (set) Token: 0x06000165 RID: 357 RVA: 0x0000C107 File Offset: 0x0000A307
		Public Overridable Property TextDate As Label

		' Token: 0x170000A7 RID: 167
		' (get) Token: 0x06000166 RID: 358 RVA: 0x0000C110 File Offset: 0x0000A310
		' (set) Token: 0x06000167 RID: 359 RVA: 0x0000C11A File Offset: 0x0000A31A
		Public Overridable Property TextPath As Label

		' Token: 0x170000A8 RID: 168
		' (get) Token: 0x06000168 RID: 360 RVA: 0x0000C123 File Offset: 0x0000A323
		' (set) Token: 0x06000169 RID: 361 RVA: 0x0000C12D File Offset: 0x0000A32D
		Public Overridable Property TextName As Label

		' Token: 0x170000A9 RID: 169
		' (get) Token: 0x0600016A RID: 362 RVA: 0x0000C136 File Offset: 0x0000A336
		' (set) Token: 0x0600016B RID: 363 RVA: 0x0000C140 File Offset: 0x0000A340
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x170000AA RID: 170
		' (get) Token: 0x0600016C RID: 364 RVA: 0x0000C149 File Offset: 0x0000A349
		' (set) Token: 0x0600016D RID: 365 RVA: 0x0000C153 File Offset: 0x0000A353
		Friend Overridable Property MAX As ValleyMax

		' Token: 0x170000AB RID: 171
		' (get) Token: 0x0600016E RID: 366 RVA: 0x0000C15C File Offset: 0x0000A35C
		' (set) Token: 0x0600016F RID: 367 RVA: 0x0000C168 File Offset: 0x0000A368
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

		' Token: 0x170000AC RID: 172
		' (get) Token: 0x06000170 RID: 368 RVA: 0x0000C1AB File Offset: 0x0000A3AB
		' (set) Token: 0x06000171 RID: 369 RVA: 0x0000C1B5 File Offset: 0x0000A3B5
		Friend Overridable Property PictureBox1 As PictureBox

		' Token: 0x170000AD RID: 173
		' (get) Token: 0x06000172 RID: 370 RVA: 0x0000C1BE File Offset: 0x0000A3BE
		' (set) Token: 0x06000173 RID: 371 RVA: 0x0000C1C8 File Offset: 0x0000A3C8
		Public Property Client As Clients

		' Token: 0x170000AE RID: 174
		' (get) Token: 0x06000174 RID: 372 RVA: 0x0000C1D1 File Offset: 0x0000A3D1
		' (set) Token: 0x06000175 RID: 373 RVA: 0x0000C1DB File Offset: 0x0000A3DB
		Public Property F As FormS500

		' Token: 0x170000AF RID: 175
		' (get) Token: 0x06000176 RID: 374 RVA: 0x0000C1E4 File Offset: 0x0000A3E4
		' (set) Token: 0x06000177 RID: 375 RVA: 0x0000C1EE File Offset: 0x0000A3EE
		Public Property FullPath As String

		' Token: 0x170000B0 RID: 176
		' (get) Token: 0x06000178 RID: 376 RVA: 0x0000C1F7 File Offset: 0x0000A3F7
		' (set) Token: 0x06000179 RID: 377 RVA: 0x0000C201 File Offset: 0x0000A401
		Friend Property ParentClient As Clients

		' Token: 0x0600017A RID: 378 RVA: 0x0000C20C File Offset: 0x0000A40C
		Private Sub FormClient_Load(sender As Object, e As EventArgs)
			Dim expression As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(DataB.InfoClient(Me.ParentClient.L)))
			Try
				Me.ClientInfo.Text = String.Concat(New String() { Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(1), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(3), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(4) })
			Catch ex As Exception
				Me.ClientInfo.Text = "Not found !"
			End Try
			Me.FormSize = True
			Me.MinimumSize = MyBase.Size
		End Sub

		' Token: 0x0600017B RID: 379 RVA: 0x0000C2F4 File Offset: 0x0000A4F4
		Private Sub FormClient_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x0600017C RID: 380 RVA: 0x0000C388 File Offset: 0x0000A588
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

		' Token: 0x0600017D RID: 381 RVA: 0x0000C3F4 File Offset: 0x0000A5F4
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			ThreadPool.QueueUserWorkItem(Sub(o As Object)
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
				MyBase.Close()
			End Sub)
		End Sub

		' Token: 0x0600017E RID: 382 RVA: 0x0000C409 File Offset: 0x0000A609
		Private Sub StateClient_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
		End Sub

		' Token: 0x040000AE RID: 174
		Private FormSize As Boolean
	End Class
End Namespace
