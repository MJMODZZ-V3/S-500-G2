Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace S500RAT.My.Resources
	' Token: 0x02000006 RID: 6
	<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")>
	<DebuggerNonUserCode()>
	<CompilerGenerated()>
	<HideModuleName()>
	Friend NotInheritable Module Resources
		' Token: 0x17000006 RID: 6
		' (get) Token: 0x0600000F RID: 15 RVA: 0x00002198 File Offset: 0x00000398
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend ReadOnly Property ResourceManager As ResourceManager
			Get
				Dim flag As Boolean = Object.ReferenceEquals(Resources.resourceMan, Nothing)
				If flag Then
					Dim resourceManager As ResourceManager = New ResourceManager("S500RAT.Resources", GetType(Resources).Assembly)
					Resources.resourceMan = resourceManager
				End If
				Return Resources.resourceMan
			End Get
		End Property

		' Token: 0x17000007 RID: 7
		' (get) Token: 0x06000010 RID: 16 RVA: 0x000021E0 File Offset: 0x000003E0
		' (set) Token: 0x06000011 RID: 17 RVA: 0x000021F7 File Offset: 0x000003F7
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend Property Culture As CultureInfo
			Get
				Return Resources.resourceCulture
			End Get
			Set(value As CultureInfo)
				Resources.resourceCulture = value
			End Set
		End Property

		' Token: 0x17000008 RID: 8
		' (get) Token: 0x06000012 RID: 18 RVA: 0x00002200 File Offset: 0x00000400
		Friend ReadOnly Property _Error As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("_Error", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x17000009 RID: 9
		' (get) Token: 0x06000013 RID: 19 RVA: 0x00002234 File Offset: 0x00000434
		Friend ReadOnly Property _False As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("_False", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x1700000A RID: 10
		' (get) Token: 0x06000014 RID: 20 RVA: 0x00002268 File Offset: 0x00000468
		Friend ReadOnly Property Admin As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Admin", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x1700000B RID: 11
		' (get) Token: 0x06000015 RID: 21 RVA: 0x0000229C File Offset: 0x0000049C
		Friend ReadOnly Property AntiAnalysis As String
			Get
				Return Resources.ResourceManager.GetString("AntiAnalysis", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x1700000C RID: 12
		' (get) Token: 0x06000016 RID: 22 RVA: 0x000022C4 File Offset: 0x000004C4
		Friend ReadOnly Property AntiKillProcess As String
			Get
				Return Resources.ResourceManager.GetString("AntiKillProcess", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x1700000D RID: 13
		' (get) Token: 0x06000017 RID: 23 RVA: 0x000022EC File Offset: 0x000004EC
		Friend ReadOnly Property BlackL1 As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("BlackL1", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x1700000E RID: 14
		' (get) Token: 0x06000018 RID: 24 RVA: 0x00002320 File Offset: 0x00000520
		Friend ReadOnly Property Chatt As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Chatt", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x1700000F RID: 15
		' (get) Token: 0x06000019 RID: 25 RVA: 0x00002354 File Offset: 0x00000554
		Friend ReadOnly Property CodeHidden As String
			Get
				Return Resources.ResourceManager.GetString("CodeHidden", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x17000010 RID: 16
		' (get) Token: 0x0600001A RID: 26 RVA: 0x0000237C File Offset: 0x0000057C
		Friend ReadOnly Property CodeHostPort As String
			Get
				Return Resources.ResourceManager.GetString("CodeHostPort", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x17000011 RID: 17
		' (get) Token: 0x0600001B RID: 27 RVA: 0x000023A4 File Offset: 0x000005A4
		Friend ReadOnly Property CodeInstallation As String
			Get
				Return Resources.ResourceManager.GetString("CodeInstallation", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x17000012 RID: 18
		' (get) Token: 0x0600001C RID: 28 RVA: 0x000023CC File Offset: 0x000005CC
		Friend ReadOnly Property CodeSleep As String
			Get
				Return Resources.ResourceManager.GetString("CodeSleep", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x17000013 RID: 19
		' (get) Token: 0x0600001D RID: 29 RVA: 0x000023F4 File Offset: 0x000005F4
		Friend ReadOnly Property Connected As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Connected", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x17000014 RID: 20
		' (get) Token: 0x0600001E RID: 30 RVA: 0x00002428 File Offset: 0x00000628
		Friend ReadOnly Property DeleteSystemRestore As String
			Get
				Return Resources.ResourceManager.GetString("DeleteSystemRestore", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x17000015 RID: 21
		' (get) Token: 0x0600001F RID: 31 RVA: 0x00002450 File Offset: 0x00000650
		Friend ReadOnly Property Disconnect As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Disconnect", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x17000016 RID: 22
		' (get) Token: 0x06000020 RID: 32 RVA: 0x00002484 File Offset: 0x00000684
		Friend ReadOnly Property Discord As String
			Get
				Return Resources.ResourceManager.GetString("Discord", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x17000017 RID: 23
		' (get) Token: 0x06000021 RID: 33 RVA: 0x000024AC File Offset: 0x000006AC
		Friend ReadOnly Property DotNETc_ As String
			Get
				Return Resources.ResourceManager.GetString("DotNETc#", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x17000018 RID: 24
		' (get) Token: 0x06000022 RID: 34 RVA: 0x000024D4 File Offset: 0x000006D4
		Friend ReadOnly Property DotNETvb As String
			Get
				Return Resources.ResourceManager.GetString("DotNETvb", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x17000019 RID: 25
		' (get) Token: 0x06000023 RID: 35 RVA: 0x000024FC File Offset: 0x000006FC
		Friend ReadOnly Property EnableStartup As String
			Get
				Return Resources.ResourceManager.GetString("EnableStartup", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x1700001A RID: 26
		' (get) Token: 0x06000024 RID: 36 RVA: 0x00002524 File Offset: 0x00000724
		Friend ReadOnly Property ErrorBmp As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("ErrorBmp", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x1700001B RID: 27
		' (get) Token: 0x06000025 RID: 37 RVA: 0x00002558 File Offset: 0x00000758
		Friend ReadOnly Property ExploitUAC As String
			Get
				Return Resources.ResourceManager.GetString("ExploitUAC", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x1700001C RID: 28
		' (get) Token: 0x06000026 RID: 38 RVA: 0x00002580 File Offset: 0x00000780
		Friend ReadOnly Property FolderLock As String
			Get
				Return Resources.ResourceManager.GetString("FolderLock", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x1700001D RID: 29
		' (get) Token: 0x06000027 RID: 39 RVA: 0x000025A8 File Offset: 0x000007A8
		Friend ReadOnly Property GeoIP As Byte()
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("GeoIP", Resources.resourceCulture))
				Return CType(objectValue, Byte())
			End Get
		End Property

		' Token: 0x1700001E RID: 30
		' (get) Token: 0x06000028 RID: 40 RVA: 0x000025DC File Offset: 0x000007DC
		Friend ReadOnly Property GeoMap As String
			Get
				Return Resources.ResourceManager.GetString("GeoMap", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x1700001F RID: 31
		' (get) Token: 0x06000029 RID: 41 RVA: 0x00002604 File Offset: 0x00000804
		Friend ReadOnly Property GetHWID As String
			Get
				Return Resources.ResourceManager.GetString("GetHWID", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x17000020 RID: 32
		' (get) Token: 0x0600002A RID: 42 RVA: 0x0000262C File Offset: 0x0000082C
		Friend ReadOnly Property hacked_hack As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("hacked_hack", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x17000021 RID: 33
		' (get) Token: 0x0600002B RID: 43 RVA: 0x00002660 File Offset: 0x00000860
		Friend ReadOnly Property HiddenBrave As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("HiddenBrave", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x17000022 RID: 34
		' (get) Token: 0x0600002C RID: 44 RVA: 0x00002694 File Offset: 0x00000894
		Friend ReadOnly Property HiddenChrome As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("HiddenChrome", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x17000023 RID: 35
		' (get) Token: 0x0600002D RID: 45 RVA: 0x000026C8 File Offset: 0x000008C8
		Friend ReadOnly Property HiddenEdge As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("HiddenEdge", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x17000024 RID: 36
		' (get) Token: 0x0600002E RID: 46 RVA: 0x000026FC File Offset: 0x000008FC
		Friend ReadOnly Property HiddenFirefox As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("HiddenFirefox", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x17000025 RID: 37
		' (get) Token: 0x0600002F RID: 47 RVA: 0x00002730 File Offset: 0x00000930
		Friend ReadOnly Property Hide As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Hide", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x17000026 RID: 38
		' (get) Token: 0x06000030 RID: 48 RVA: 0x00002764 File Offset: 0x00000964
		Friend ReadOnly Property KeyHide As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("KeyHide", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x17000027 RID: 39
		' (get) Token: 0x06000031 RID: 49 RVA: 0x00002798 File Offset: 0x00000998
		Friend ReadOnly Property KeyShow As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("KeyShow", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x17000028 RID: 40
		' (get) Token: 0x06000032 RID: 50 RVA: 0x000027CC File Offset: 0x000009CC
		Friend ReadOnly Property ListenOFF As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("ListenOFF", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x17000029 RID: 41
		' (get) Token: 0x06000033 RID: 51 RVA: 0x00002800 File Offset: 0x00000A00
		Friend ReadOnly Property ListenONN As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("ListenONN", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x1700002A RID: 42
		' (get) Token: 0x06000034 RID: 52 RVA: 0x00002834 File Offset: 0x00000A34
		Friend ReadOnly Property MicOFF As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("MicOFF", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x1700002B RID: 43
		' (get) Token: 0x06000035 RID: 53 RVA: 0x00002868 File Offset: 0x00000A68
		Friend ReadOnly Property MicON As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("MicON", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x1700002C RID: 44
		' (get) Token: 0x06000036 RID: 54 RVA: 0x0000289C File Offset: 0x00000A9C
		Friend ReadOnly Property PastebinHostPort As String
			Get
				Return Resources.ResourceManager.GetString("PastebinHostPort", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x1700002D RID: 45
		' (get) Token: 0x06000037 RID: 55 RVA: 0x000028C4 File Offset: 0x00000AC4
		Friend ReadOnly Property ProxyCertificate As Byte()
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("ProxyCertificate", Resources.resourceCulture))
				Return CType(objectValue, Byte())
			End Get
		End Property

		' Token: 0x1700002E RID: 46
		' (get) Token: 0x06000038 RID: 56 RVA: 0x000028F8 File Offset: 0x00000AF8
		Friend ReadOnly Property RecoveryPasswords As String
			Get
				Return Resources.ResourceManager.GetString("RecoveryPasswords", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x1700002F RID: 47
		' (get) Token: 0x06000039 RID: 57 RVA: 0x00002920 File Offset: 0x00000B20
		Friend ReadOnly Property RNS_Crypt As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("RNS_Crypt", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x17000030 RID: 48
		' (get) Token: 0x0600003A RID: 58 RVA: 0x00002954 File Offset: 0x00000B54
		Friend ReadOnly Property RNS_Dcrypt As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("RNS_Dcrypt", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x17000031 RID: 49
		' (get) Token: 0x0600003B RID: 59 RVA: 0x00002988 File Offset: 0x00000B88
		Friend ReadOnly Property Running As String
			Get
				Return Resources.ResourceManager.GetString("Running", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x17000032 RID: 50
		' (get) Token: 0x0600003C RID: 60 RVA: 0x000029B0 File Offset: 0x00000BB0
		Friend ReadOnly Property RunningTask As String
			Get
				Return Resources.ResourceManager.GetString("RunningTask", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x17000033 RID: 51
		' (get) Token: 0x0600003D RID: 61 RVA: 0x000029D8 File Offset: 0x00000BD8
		Friend ReadOnly Property S42 As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("S42", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x17000034 RID: 52
		' (get) Token: 0x0600003E RID: 62 RVA: 0x00002A0C File Offset: 0x00000C0C
		Friend ReadOnly Property Sarmat As Byte()
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Sarmat", Resources.resourceCulture))
				Return CType(objectValue, Byte())
			End Get
		End Property

		' Token: 0x17000035 RID: 53
		' (get) Token: 0x0600003F RID: 63 RVA: 0x00002A40 File Offset: 0x00000C40
		Friend ReadOnly Property Security As String
			Get
				Return Resources.ResourceManager.GetString("Security", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x17000036 RID: 54
		' (get) Token: 0x06000040 RID: 64 RVA: 0x00002A68 File Offset: 0x00000C68
		Friend ReadOnly Property Setup As String
			Get
				Return Resources.ResourceManager.GetString("Setup", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x17000037 RID: 55
		' (get) Token: 0x06000041 RID: 65 RVA: 0x00002A90 File Offset: 0x00000C90
		Friend ReadOnly Property Show As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Show", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x17000038 RID: 56
		' (get) Token: 0x06000042 RID: 66 RVA: 0x00002AC4 File Offset: 0x00000CC4
		Friend ReadOnly Property TaskSchedukerNormal As String
			Get
				Return Resources.ResourceManager.GetString("TaskSchedukerNormal", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x17000039 RID: 57
		' (get) Token: 0x06000043 RID: 67 RVA: 0x00002AEC File Offset: 0x00000CEC
		Friend ReadOnly Property TaskSchedulerAdmin As String
			Get
				Return Resources.ResourceManager.GetString("TaskSchedulerAdmin", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x1700003A RID: 58
		' (get) Token: 0x06000044 RID: 68 RVA: 0x00002B14 File Offset: 0x00000D14
		Friend ReadOnly Property UACLoop As String
			Get
				Return Resources.ResourceManager.GetString("UACLoop", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x1700003B RID: 59
		' (get) Token: 0x06000045 RID: 69 RVA: 0x00002B3C File Offset: 0x00000D3C
		Friend ReadOnly Property WDExclusions As String
			Get
				Return Resources.ResourceManager.GetString("WDExclusions", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x1700003C RID: 60
		' (get) Token: 0x06000046 RID: 70 RVA: 0x00002B64 File Offset: 0x00000D64
		Friend ReadOnly Property XXXX As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("XXXX", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x04000006 RID: 6
		Private resourceMan As ResourceManager

		' Token: 0x04000007 RID: 7
		Private resourceCulture As CultureInfo
	End Module
End Namespace
