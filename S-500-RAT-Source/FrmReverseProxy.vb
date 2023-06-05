Imports System
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x0200005C RID: 92
	Public Class FrmReverseProxy
		' Token: 0x060011B6 RID: 4534 RVA: 0x0009D76C File Offset: 0x0009B96C
		Public Sub AddArrary(client As Clients, unpack_msgpack As MsgPack)
			Try
				Dim formReverseProxy As FormReverseProxy = CType(Application.OpenForms("FormReverseProxy" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormReverseProxy)
				Dim asString As String = unpack_msgpack.ForcePathObject("Command").AsString
				If Operators.CompareString(asString, "setClient", False) = 0 Then
					Dim flag As Boolean = formReverseProxy IsNot Nothing
					If flag Then
						Dim flag2 As Boolean = formReverseProxy.Client Is Nothing
						If flag2 Then
							formReverseProxy.Client = client
							formReverseProxy.Timer1.Enabled = True
							formReverseProxy.ID.Text = unpack_msgpack.ForcePathObject("RemoteEndPoint").AsString
							formReverseProxy.Start.Enabled = True
						End If
					End If
				End If
			Catch ex As Exception
				ListLogs.AddArray("Reverse Proxy " + client.IP + " Error : " + ex.Message, 0)
			End Try
		End Sub
	End Class
End Namespace
