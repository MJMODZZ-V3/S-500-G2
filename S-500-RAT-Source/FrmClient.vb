Imports System
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x02000044 RID: 68
	Public Class FrmClient
		' Token: 0x0600117D RID: 4477 RVA: 0x000977E4 File Offset: 0x000959E4
		Public Sub AddArrary(client As Clients, unpack_msgpack As MsgPack)
			Try
				Dim formClient As FormClient = CType(Application.OpenForms("FormClient" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormClient)
				Dim asString As String = unpack_msgpack.ForcePathObject("Command").AsString
				If Operators.CompareString(asString, "setClient", False) <> 0 Then
					If Operators.CompareString(asString, "Error", False) = 0 Then
						Dim flag As Boolean = formClient IsNot Nothing
						If flag Then
						End If
					End If
				Else
					Dim flag2 As Boolean = formClient IsNot Nothing
					If flag2 Then
						Dim flag3 As Boolean = formClient.Client Is Nothing
						If flag3 Then
							formClient.Client = client
							formClient.Timer1.Enabled = True
							formClient.TextName.Text = unpack_msgpack.ForcePathObject("ClientName").AsString
							formClient.TextPath.Text = unpack_msgpack.ForcePathObject("ClientPath").AsString
							formClient.TextDate.Text = unpack_msgpack.ForcePathObject("ClientDate").AsString
						End If
					End If
				End If
			Catch ex As Exception
				ListLogs.AddArray("Client " + client.IP + " Error : " + ex.Message, 0)
			End Try
		End Sub
	End Class
End Namespace
