Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Configuration
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace S500RAT.My
	' Token: 0x02000007 RID: 7
	<CompilerGenerated()>
	<GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")>
	<EditorBrowsable(EditorBrowsableState.Advanced)>
	Friend NotInheritable Partial Class MySettings
		Inherits ApplicationSettingsBase

		' Token: 0x06000049 RID: 73 RVA: 0x00002BC4 File Offset: 0x00000DC4
		<DebuggerNonUserCode()>
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Private Shared Sub AutoSaveSettings(sender As Object, e As EventArgs)
			Dim saveMySettingsOnExit As Boolean = MyProject.Application.SaveMySettingsOnExit
			If saveMySettingsOnExit Then
				MySettingsProperty.Settings.Save()
			End If
		End Sub

		' Token: 0x1700003D RID: 61
		' (get) Token: 0x0600004A RID: 74 RVA: 0x00002BF0 File Offset: 0x00000DF0
		Public Shared ReadOnly Property [Default] As MySettings
			Get
				Dim flag As Boolean = Not MySettings.addedHandler
				If flag Then
					Dim obj As Object = MySettings.addedHandlerLockObject
					ObjectFlowControl.CheckForSyncLockOnValueType(obj)
					SyncLock obj
						Dim flag3 As Boolean = Not MySettings.addedHandler
						If flag3 Then
							AddHandler MyProject.Application.Shutdown, AddressOf MySettings.AutoSaveSettings
							MySettings.addedHandler = True
						End If
					End SyncLock
				End If
				Return MySettings.defaultInstance
			End Get
		End Property

		' Token: 0x1700003E RID: 62
		' (get) Token: 0x0600004B RID: 75 RVA: 0x00002C7C File Offset: 0x00000E7C
		' (set) Token: 0x0600004C RID: 76 RVA: 0x00002C9E File Offset: 0x00000E9E
		<UserScopedSetting()>
		<DebuggerNonUserCode()>
		<DefaultSettingValue("")>
		Public Property Ports As String
			Get
				Return Conversions.ToString(Me("Ports"))
			End Get
			Set(value As String)
				Me("Ports") = value
			End Set
		End Property

		' Token: 0x1700003F RID: 63
		' (get) Token: 0x0600004D RID: 77 RVA: 0x00002CB0 File Offset: 0x00000EB0
		' (set) Token: 0x0600004E RID: 78 RVA: 0x00002CD2 File Offset: 0x00000ED2
		<UserScopedSetting()>
		<DebuggerNonUserCode()>
		<DefaultSettingValue("")>
		Public Property txtBlocked As String
			Get
				Return Conversions.ToString(Me("txtBlocked"))
			End Get
			Set(value As String)
				Me("txtBlocked") = value
			End Set
		End Property

		' Token: 0x17000040 RID: 64
		' (get) Token: 0x0600004F RID: 79 RVA: 0x00002CE4 File Offset: 0x00000EE4
		' (set) Token: 0x06000050 RID: 80 RVA: 0x00002D06 File Offset: 0x00000F06
		<UserScopedSetting()>
		<DebuggerNonUserCode()>
		<DefaultSettingValue("")>
		Public Property UsernameLogin As String
			Get
				Return Conversions.ToString(Me("UsernameLogin"))
			End Get
			Set(value As String)
				Me("UsernameLogin") = value
			End Set
		End Property

		' Token: 0x17000041 RID: 65
		' (get) Token: 0x06000051 RID: 81 RVA: 0x00002D18 File Offset: 0x00000F18
		' (set) Token: 0x06000052 RID: 82 RVA: 0x00002D3A File Offset: 0x00000F3A
		<UserScopedSetting()>
		<DebuggerNonUserCode()>
		<DefaultSettingValue("")>
		Public Property PasswordLogin As String
			Get
				Return Conversions.ToString(Me("PasswordLogin"))
			End Get
			Set(value As String)
				Me("PasswordLogin") = value
			End Set
		End Property

		' Token: 0x04000008 RID: 8
		Private Shared defaultInstance As MySettings = CType(SettingsBase.Synchronized(New MySettings()), MySettings)

		' Token: 0x04000009 RID: 9
		Private Shared addedHandler As Boolean

		' Token: 0x0400000A RID: 10
		Private Shared addedHandlerLockObject As Object = RuntimeHelpers.GetObjectValue(New Object())
	End Class
End Namespace
