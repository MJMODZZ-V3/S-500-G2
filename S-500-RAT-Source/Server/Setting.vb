Imports System
Imports System.Collections.Generic
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection

Namespace S500RAT.Server
	' Token: 0x0200000C RID: 12
	Public NotInheritable Module Setting
		' Token: 0x0400001C RID: 28
		Public LogsList As ListLogs = New ListLogs()

		' Token: 0x0400001D RID: 29
		Public Running As Boolean = False

		' Token: 0x0400001E RID: 30
		Public Clienttext As String = Nothing

		' Token: 0x0400001F RID: 31
		Public ByteHVNC As Byte() = Nothing

		' Token: 0x04000020 RID: 32
		Public Certificate_Path As String = Application.StartupPath + "\Certificate\ServerCertificate.p12"

		' Token: 0x04000021 RID: 33
		Public ServerCertificate As X509Certificate2

		' Token: 0x04000022 RID: 34
		Public SentValue As Long

		' Token: 0x04000023 RID: 35
		Public ReceivedValue As Long

		' Token: 0x04000024 RID: 36
		Public LockReceivedSendValue As Object = RuntimeHelpers.GetObjectValue(New Object())

		' Token: 0x04000025 RID: 37
		Public Version As String = "S500RAT G2"

		' Token: 0x04000026 RID: 38
		Public Blocked As List(Of String) = New List(Of String)()

		' Token: 0x04000027 RID: 39
		Public LockBlocked As Object = RuntimeHelpers.GetObjectValue(New Object())

		' Token: 0x04000028 RID: 40
		Public LockDataGridViewClients As Object = RuntimeHelpers.GetObjectValue(New Object())

		' Token: 0x04000029 RID: 41
		Public LockDataGridViewHome As Object = RuntimeHelpers.GetObjectValue(New Object())

		' Token: 0x0400002A RID: 42
		Public LockDataGridVieLogs As Object = RuntimeHelpers.GetObjectValue(New Object())

		' Token: 0x0400002B RID: 43
		Public LockListMining As Object = RuntimeHelpers.GetObjectValue(New Object())

		' Token: 0x0400002C RID: 44
		Public LockListviewLogs As Object = RuntimeHelpers.GetObjectValue(New Object())

		' Token: 0x0400002D RID: 45
		Public LockListviewThumb As Object = RuntimeHelpers.GetObjectValue(New Object())

		' Token: 0x0400002E RID: 46
		Public map As Object = RuntimeHelpers.GetObjectValue(New Object())

		' Token: 0x0400002F RID: 47
		Public ReportWindow As Boolean = False

		' Token: 0x04000030 RID: 48
		Public ReportWindowClients As List(Of Clients) = New List(Of Clients)()

		' Token: 0x04000031 RID: 49
		Public LockReportWindowClients As Object = RuntimeHelpers.GetObjectValue(New Object())
	End Module
End Namespace
