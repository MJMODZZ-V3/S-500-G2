Imports System
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace S500RAT.My
	' Token: 0x02000008 RID: 8
	<HideModuleName()>
	<DebuggerNonUserCode()>
	<CompilerGenerated()>
	Friend NotInheritable Module MySettingsProperty
		' Token: 0x17000042 RID: 66
		' (get) Token: 0x06000053 RID: 83 RVA: 0x00002D4C File Offset: 0x00000F4C
		<HelpKeyword("My.Settings")>
		Friend ReadOnly Property Settings As MySettings
			Get
				Return MySettings.[Default]
			End Get
		End Property
	End Module
End Namespace
