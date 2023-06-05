Imports System
Imports System.Drawing
Imports Microsoft.VisualBasic
Imports S500RAT.My.Resources
Imports Tulpep.NotificationWindow

Namespace S500RAT
	' Token: 0x0200006E RID: 110
	Public Class HelpNotif
		' Token: 0x060011FD RID: 4605 RVA: 0x000A2F18 File Offset: 0x000A1118
		Public Sub NotifClient(IP As String, UserName As String, System As String, Country As String, StateClient As Boolean)
			Dim popupNotifier As PopupNotifier = New PopupNotifier()
			popupNotifier.Size = New Size(350, 120)
			popupNotifier.ImageSize = New Size(90, 90)
			popupNotifier.Image = Resources.S42
			popupNotifier.HeaderHeight = 1
			popupNotifier.ShowCloseButton = False
			popupNotifier.ShowGrip = False
			popupNotifier.TitleFont = New Font("Microsoft YaHei", 8F, FontStyle.Bold)
			popupNotifier.ContentFont = New Font("Arial", 8F, FontStyle.Bold)
			popupNotifier.ContentText = String.Concat(New String() { vbCrLf & "IP Address : ", IP, vbCrLf & vbCrLf & "UserName  : ", UserName, vbCrLf & vbCrLf & "System       : ", System, vbCrLf & vbCrLf & "Country      : ", Country })
			popupNotifier.ContentColor = Color.White
			popupNotifier.TitleColor = Color.White
			If StateClient Then
				popupNotifier.TitleText = Strings.Space(33) + "S500 RAT G2( Connected )"
				popupNotifier.BodyColor = Color.FromArgb(7, 11, 41)
				popupNotifier.BorderColor = Color.FromArgb(7, 11, 41)
			Else
				popupNotifier.TitleText = Strings.Space(30) + "S500 RAT G2( Disconnected )"
				popupNotifier.BodyColor = Color.Maroon
				popupNotifier.BorderColor = Color.Maroon
			End If
			popupNotifier.Popup()
		End Sub
	End Class
End Namespace
