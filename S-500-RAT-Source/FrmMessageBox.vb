Imports System
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x02000052 RID: 82
	Public Class FrmMessageBox
		' Token: 0x06001199 RID: 4505 RVA: 0x0009A978 File Offset: 0x00098B78
		Public Sub AddArrary(client As Clients, unpack_msgpack As MsgPack)
			Try
				Dim formMessageBox As FormMessageBox = CType(Application.OpenForms("FormMessageBox" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormMessageBox)
				Dim flag As Boolean = formMessageBox IsNot Nothing
				If flag Then
					Dim flag2 As Boolean = formMessageBox.Client Is Nothing
					If flag2 Then
						formMessageBox.Client = client
						formMessageBox.Timer1.Enabled = True
						formMessageBox.SendMessage.Enabled = True
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub
	End Class
End Namespace
