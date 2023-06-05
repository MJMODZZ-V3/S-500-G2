Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Guna.UI2.WinForms
Imports Guna.UI2.WinForms.Enums
Imports initialization
Imports Microsoft.VisualBasic.CompilerServices
Imports Sunny.UI

Namespace S500RAT
	' Token: 0x02000023 RID: 35
	<DesignerGenerated()>
	Public Partial Class FormLogin
		Inherits Form

		' Token: 0x06000605 RID: 1541 RVA: 0x00033348 File Offset: 0x00031548
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormLogin_Load
			AddHandler MyBase.Resize, AddressOf Me.FormLogin_Resize
			Me.FormSize = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700026E RID: 622
		' (get) Token: 0x06000608 RID: 1544 RVA: 0x00034332 File Offset: 0x00032532
		' (set) Token: 0x06000609 RID: 1545 RVA: 0x0003433C File Offset: 0x0003253C
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x1700026F RID: 623
		' (get) Token: 0x0600060A RID: 1546 RVA: 0x00034345 File Offset: 0x00032545
		' (set) Token: 0x0600060B RID: 1547 RVA: 0x0003434F File Offset: 0x0003254F
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x17000270 RID: 624
		' (get) Token: 0x0600060C RID: 1548 RVA: 0x00034358 File Offset: 0x00032558
		' (set) Token: 0x0600060D RID: 1549 RVA: 0x00034362 File Offset: 0x00032562
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x17000271 RID: 625
		' (get) Token: 0x0600060E RID: 1550 RVA: 0x0003436B File Offset: 0x0003256B
		' (set) Token: 0x0600060F RID: 1551 RVA: 0x00034378 File Offset: 0x00032578
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

		' Token: 0x17000272 RID: 626
		' (get) Token: 0x06000610 RID: 1552 RVA: 0x000343BB File Offset: 0x000325BB
		' (set) Token: 0x06000611 RID: 1553 RVA: 0x000343C5 File Offset: 0x000325C5
		Friend Overridable Property UserNameTXT As Guna2TextBox

		' Token: 0x17000273 RID: 627
		' (get) Token: 0x06000612 RID: 1554 RVA: 0x000343CE File Offset: 0x000325CE
		' (set) Token: 0x06000613 RID: 1555 RVA: 0x000343D8 File Offset: 0x000325D8
		Friend Overridable Property PasswordTXT As Guna2TextBox

		' Token: 0x17000274 RID: 628
		' (get) Token: 0x06000614 RID: 1556 RVA: 0x000343E1 File Offset: 0x000325E1
		' (set) Token: 0x06000615 RID: 1557 RVA: 0x000343EB File Offset: 0x000325EB
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x17000275 RID: 629
		' (get) Token: 0x06000616 RID: 1558 RVA: 0x000343F4 File Offset: 0x000325F4
		' (set) Token: 0x06000617 RID: 1559 RVA: 0x00034400 File Offset: 0x00032600
		Friend Overridable Property Login As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._Login
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.Login_Click
				Dim login As Guna2GradientButton = Me._Login
				If login IsNot Nothing Then
					RemoveHandler login.Click, value2
				End If
				Me._Login = value
				login = Me._Login
				If login IsNot Nothing Then
					AddHandler login.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000276 RID: 630
		' (get) Token: 0x06000618 RID: 1560 RVA: 0x00034443 File Offset: 0x00032643
		' (set) Token: 0x06000619 RID: 1561 RVA: 0x0003444D File Offset: 0x0003264D
		Public Overridable Property RememberMe As Guna2ToggleSwitch

		' Token: 0x17000277 RID: 631
		' (get) Token: 0x0600061A RID: 1562 RVA: 0x00034456 File Offset: 0x00032656
		' (set) Token: 0x0600061B RID: 1563 RVA: 0x00034460 File Offset: 0x00032660
		Friend Overridable Property Label2 As Label

		' Token: 0x17000278 RID: 632
		' (get) Token: 0x0600061C RID: 1564 RVA: 0x00034469 File Offset: 0x00032669
		' (set) Token: 0x0600061D RID: 1565 RVA: 0x00034473 File Offset: 0x00032673
		Friend Overridable Property PLW As Guna2CircleProgressBar

		' Token: 0x0600061E RID: 1566 RVA: 0x0003447C File Offset: 0x0003267C
		Private Sub FormLogin_Load(sender As Object, e As EventArgs)
			FormLogin.auth_sample.init()
			Me.FormSize = True
			Me.MinimumSize = MyBase.Size
			Me.MaximumSize = MyBase.Size
			Try
				Me.UserNameTXT.Text = Conversions.ToString(Functions.RegistryGetValue("#LoginUser", Me.UserNameTXT.Text))
				Me.PasswordTXT.Text = Conversions.ToString(Functions.RegistryGetValue("#LoginPass", Me.PasswordTXT.Text))
			Catch ex As Exception
				Console.WriteLine(ex.Message)
			End Try
		End Sub

		' Token: 0x0600061F RID: 1567 RVA: 0x00034534 File Offset: 0x00032734
		Private Sub FormLogin_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x06000620 RID: 1568 RVA: 0x000345C8 File Offset: 0x000327C8
		Private Sub Login_Click(sender As Object, e As EventArgs)
			Try
				Me.Login.Enabled = False
				Me.Login.Text = "Login..."
				Dim flag As Boolean = FormLogin.auth_sample.login(Me.UserNameTXT.Text, Me.PasswordTXT.Text, Nothing)
				If flag Then
					Dim checked As Boolean = Me.RememberMe.Checked
					If checked Then
						Try
							Functions.RegistrySetValue("#LoginUser", Conversions.ToString(Me.UserNameTXT.Text))
							Functions.RegistrySetValue("#LoginPass", Conversions.ToString(Me.PasswordTXT.Text))
						Catch ex As Exception
							Console.WriteLine(ex.Message)
						End Try
					End If
					Dim formS As FormS500 = New FormS500()
					formS.Show()
					MyBase.Hide()
					MyBase.ShowInTaskbar = False
				Else
					Me.Login.Text = "Login"
					Me.Login.Enabled = True
				End If
			Catch ex2 As Exception
				Console.WriteLine(ex2.Message)
				MyBase.Close()
			End Try
		End Sub

		' Token: 0x06000621 RID: 1569 RVA: 0x00034708 File Offset: 0x00032908
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x040002C6 RID: 710
		Public Shared auth_sample As API = New API("1.0", "rG6ZR3Oqhr4IQ3DQCKPUpvFVhgmbDf38duy", "3cf63e5b3693e721f2fef0d0fd960a85", True)

		' Token: 0x040002C7 RID: 711
		Private FormSize As Boolean
	End Class
End Namespace
