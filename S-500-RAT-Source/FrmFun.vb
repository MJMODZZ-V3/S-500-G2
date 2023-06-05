Imports System
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x02000049 RID: 73
	Public Class FrmFun
		' Token: 0x06001187 RID: 4487 RVA: 0x00097F60 File Offset: 0x00096160
		Public Sub AddArrary(client As Clients, unpack_msgpack As MsgPack)
			Try
				Dim formFun As FormFun = CType(Application.OpenForms("FormFun" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormFun)
				Dim flag As Boolean = formFun IsNot Nothing
				If flag Then
					Dim flag2 As Boolean = formFun.Client Is Nothing
					If flag2 Then
						formFun.Client = client
						formFun.Timer1.Enabled = True
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub
	End Class
End Namespace
