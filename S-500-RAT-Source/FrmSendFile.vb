Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x0200005D RID: 93
	Public Class FrmSendFile
		' Token: 0x060011B8 RID: 4536 RVA: 0x0009D870 File Offset: 0x0009BA70
		Public Sub AddArrary(client As Clients, unpack_msgpack As MsgPack)
			Try
				Dim formSendFile As FormSendFile = CType(Application.OpenForms("FormSendFile" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormSendFile)
				Dim flag As Boolean = formSendFile IsNot Nothing
				If flag Then
					Dim flag2 As Boolean = formSendFile.Client Is Nothing
					If flag2 Then
						formSendFile.Client = client
						formSendFile.Timer1.Enabled = True
					End If
					Dim flag3 As Boolean = Operators.CompareString(unpack_msgpack.ForcePathObject("State").AsString, "Started", False) = 0
					If flag3 Then
						formSendFile.State.ForeColor = Color.LightGreen
						formSendFile.State.Text = "Running"
						formSendFile.SendFile.Enabled = True
					Else
						formSendFile.State.ForeColor = Color.Red
						formSendFile.State.Text = unpack_msgpack.ForcePathObject("State").AsString
						formSendFile.SendFile.Enabled = True
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub
	End Class
End Namespace
