Imports System
Imports System.IO
Imports System.IO.Compression
Imports Microsoft.VisualBasic.CompilerServices

Namespace S500RAT.Server.Algorithm
	' Token: 0x0200000A RID: 10
	Public NotInheritable Module Zip
		' Token: 0x06000055 RID: 85 RVA: 0x00002DC0 File Offset: 0x00000FC0
		Public Function Decompress(input As Byte()) As Byte()
			Dim result As Byte()
			Using memoryStream As MemoryStream = New MemoryStream(input)
				Dim array As Byte() = New Byte(3) {}
				memoryStream.Read(array, 0, 4)
				Dim num As Integer = BitConverter.ToInt32(array, 0)
				Using gzipStream As GZipStream = New GZipStream(memoryStream, CompressionMode.Decompress)
					' The following expression was wrapped in a checked-expression
					Dim array2 As Byte() = New Byte(num - 1 + 1 - 1) {}
					gzipStream.Read(array2, 0, num)
					result = array2
				End Using
			End Using
			Return result
		End Function

		' Token: 0x06000056 RID: 86 RVA: 0x00002E50 File Offset: 0x00001050
		Public Function Compress(input As Byte()) As Byte()
			Dim result As Byte()
			Using memoryStream As MemoryStream = New MemoryStream()
				Dim bytes As Byte() = BitConverter.GetBytes(input.Length)
				memoryStream.Write(bytes, 0, 4)
				Using gzipStream As GZipStream = New GZipStream(memoryStream, CompressionMode.Compress)
					gzipStream.Write(input, 0, input.Length)
					gzipStream.Flush()
				End Using
				result = memoryStream.ToArray()
			End Using
			Return result
		End Function
	End Module
End Namespace
