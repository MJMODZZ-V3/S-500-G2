Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Security

Namespace S500RAT
	' Token: 0x02000070 RID: 112
	Public Class IconN
		' Token: 0x06001203 RID: 4611 RVA: 0x000A32F4 File Offset: 0x000A14F4
		Public Shared Sub InjectIcon(exeFileName As String, iconFileName As String)
			IconN.InjectIcon(exeFileName, iconFileName, 1UI, 1UI)
		End Sub

		' Token: 0x06001204 RID: 4612 RVA: 0x000A3304 File Offset: 0x000A1504
		Public Shared Sub InjectIcon(exeFileName As String, iconFileName As String, iconGroupID As UInteger, iconBaseID As UInteger)
			Dim iconFile As IconN.IconFile = IconN.IconFile.FromFile(iconFileName)
			Dim hUpdate As IntPtr = IconN.NativeMethods.BeginUpdateResource(exeFileName, False)
			Dim array As Byte() = iconFile.CreateIconGroupData(iconBaseID)
			IconN.NativeMethods.UpdateResource(hUpdate, New IntPtr(14L), New IntPtr(CLng(CULng(iconGroupID))), 0S, array, array.Length)
			Dim num As Integer = iconFile.ImageCount - 1
			For i As Integer = 0 To num
				Dim array2 As Byte() = iconFile.get_ImageData(i)
				IconN.NativeMethods.UpdateResource(hUpdate, New IntPtr(3L), New IntPtr(CLng((CULng(iconBaseID) + CULng((CLng(i)))))), 0S, array2, array2.Length)
			Next
			IconN.NativeMethods.EndUpdateResource(hUpdate, False)
		End Sub

		' Token: 0x020000A9 RID: 169
		<SuppressUnmanagedCodeSecurity()>
		Private Class NativeMethods
			' Token: 0x06001378 RID: 4984
			Public Declare Function BeginUpdateResource Lib "kernel32" (fileName As String, <MarshalAs(UnmanagedType.Bool)> deleteExistingResources As Boolean) As IntPtr

			' Token: 0x06001379 RID: 4985
			Public Declare Function UpdateResource Lib "kernel32" (hUpdate As IntPtr, type As IntPtr, name As IntPtr, language As Short, <MarshalAs(UnmanagedType.LPArray, SizeParamIndex := 5S)> data As Byte(), dataSize As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean

			' Token: 0x0600137A RID: 4986
			Public Declare Function EndUpdateResource Lib "kernel32" (hUpdate As IntPtr, <MarshalAs(UnmanagedType.Bool)> discard As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean
		End Class

		' Token: 0x020000AA RID: 170
		Private Structure ICONDIR
			' Token: 0x0400091A RID: 2330
			Public Reserved As UShort

			' Token: 0x0400091B RID: 2331
			Public Type As UShort

			' Token: 0x0400091C RID: 2332
			Public Count As UShort
		End Structure

		' Token: 0x020000AB RID: 171
		Private Structure ICONDIRENTRY
			' Token: 0x0400091D RID: 2333
			Public Width As Byte

			' Token: 0x0400091E RID: 2334
			Public Height As Byte

			' Token: 0x0400091F RID: 2335
			Public ColorCount As Byte

			' Token: 0x04000920 RID: 2336
			Public Reserved As Byte

			' Token: 0x04000921 RID: 2337
			Public Planes As UShort

			' Token: 0x04000922 RID: 2338
			Public BitCount As UShort

			' Token: 0x04000923 RID: 2339
			Public BytesInRes As Integer

			' Token: 0x04000924 RID: 2340
			Public ImageOffset As Integer
		End Structure

		' Token: 0x020000AC RID: 172
		Private Structure BITMAPINFOHEADER
			' Token: 0x04000925 RID: 2341
			Public Size As UInteger

			' Token: 0x04000926 RID: 2342
			Public Width As Integer

			' Token: 0x04000927 RID: 2343
			Public Height As Integer

			' Token: 0x04000928 RID: 2344
			Public Planes As UShort

			' Token: 0x04000929 RID: 2345
			Public BitCount As UShort

			' Token: 0x0400092A RID: 2346
			Public Compression As UInteger

			' Token: 0x0400092B RID: 2347
			Public SizeImage As UInteger

			' Token: 0x0400092C RID: 2348
			Public XPelsPerMeter As Integer

			' Token: 0x0400092D RID: 2349
			Public YPelsPerMeter As Integer

			' Token: 0x0400092E RID: 2350
			Public ClrUsed As UInteger

			' Token: 0x0400092F RID: 2351
			Public ClrImportant As UInteger
		End Structure

		' Token: 0x020000AD RID: 173
		<StructLayout(LayoutKind.Sequential, Pack := 2)>
		Private Structure GRPICONDIRENTRY
			' Token: 0x04000930 RID: 2352
			Public Width As Byte

			' Token: 0x04000931 RID: 2353
			Public Height As Byte

			' Token: 0x04000932 RID: 2354
			Public ColorCount As Byte

			' Token: 0x04000933 RID: 2355
			Public Reserved As Byte

			' Token: 0x04000934 RID: 2356
			Public Planes As UShort

			' Token: 0x04000935 RID: 2357
			Public BitCount As UShort

			' Token: 0x04000936 RID: 2358
			Public BytesInRes As Integer

			' Token: 0x04000937 RID: 2359
			Public ID As UShort
		End Structure

		' Token: 0x020000AE RID: 174
		Private Class IconFile
			' Token: 0x17000770 RID: 1904
			' (get) Token: 0x0600137B RID: 4987 RVA: 0x000AE698 File Offset: 0x000AC898
			Public ReadOnly Property ImageCount As Integer
				Get
					Return CInt(Me.iconDir.Count)
				End Get
			End Property

			' Token: 0x17000771 RID: 1905
			' (get) Token: 0x0600137C RID: 4988 RVA: 0x000AE6B8 File Offset: 0x000AC8B8
			Public ReadOnly Property ImageData(index As Integer) As Byte()
				Get
					Return Me.iconImage(index)
				End Get
			End Property

			' Token: 0x0600137D RID: 4989 RVA: 0x000AE6D2 File Offset: 0x000AC8D2
			Private Sub New()
				Me.iconDir = Nothing
			End Sub

			' Token: 0x0600137E RID: 4990 RVA: 0x000AE6E8 File Offset: 0x000AC8E8
			Public Shared Function FromFile(filename As String) As IconN.IconFile
				Dim iconFile As IconN.IconFile = New IconN.IconFile()
				Dim array As Byte() = File.ReadAllBytes(filename)
				Dim gchandle As GCHandle = GCHandle.Alloc(array, GCHandleType.Pinned)
				iconFile.iconDir = CType(Marshal.PtrToStructure(gchandle.AddrOfPinnedObject(), GetType(IconN.ICONDIR)), IconN.ICONDIR)
				iconFile.iconEntry = New IconN.ICONDIRENTRY(CInt((iconFile.iconDir.Count - 1US + 1US)) - 1) {}
				iconFile.iconImage = New Byte(CInt((iconFile.iconDir.Count - 1US + 1US)) - 1)() {}
				Dim num As Integer = Marshal.SizeOf(Of IconN.ICONDIR)(iconFile.iconDir)
				Dim typeFromHandle As Type = GetType(IconN.ICONDIRENTRY)
				Dim num2 As Integer = Marshal.SizeOf(typeFromHandle)
				Dim num3 As Integer = CInt((iconFile.iconDir.Count - 1US))
				For i As Integer = 0 To num3
					' The following expression was wrapped in a unchecked-expression
					Dim icondirentry As IconN.ICONDIRENTRY = CType(Marshal.PtrToStructure(New IntPtr(gchandle.AddrOfPinnedObject().ToInt64() + CLng(num)), typeFromHandle), IconN.ICONDIRENTRY)
					iconFile.iconEntry(i) = icondirentry
					iconFile.iconImage(i) = New Byte(icondirentry.BytesInRes - 1 + 1 - 1) {}
					Buffer.BlockCopy(array, icondirentry.ImageOffset, iconFile.iconImage(i), 0, icondirentry.BytesInRes)
					num += num2
				Next
				gchandle.Free()
				Return iconFile
			End Function

			' Token: 0x0600137F RID: 4991 RVA: 0x000AE828 File Offset: 0x000ACA28
			Public Function CreateIconGroupData(iconBaseID As UInteger) As Byte()
				' The following expression was wrapped in a checked-statement
				Dim num As Integer = Marshal.SizeOf(GetType(IconN.ICONDIR)) + Marshal.SizeOf(GetType(IconN.GRPICONDIRENTRY)) * Me.ImageCount
				Dim array As Byte() = New Byte(num - 1 + 1 - 1) {}
				Dim gchandle As GCHandle = GCHandle.Alloc(array, GCHandleType.Pinned)
				Marshal.StructureToPtr(Of IconN.ICONDIR)(Me.iconDir, gchandle.AddrOfPinnedObject(), False)
				Dim num2 As Integer = Marshal.SizeOf(Of IconN.ICONDIR)(Me.iconDir)
				Dim num3 As Integer = Me.ImageCount - 1
				For i As Integer = 0 To num3
					Dim [structure] As IconN.GRPICONDIRENTRY = Nothing
					Dim bitmapinfoheader As IconN.BITMAPINFOHEADER = Nothing
					Dim gchandle2 As GCHandle = GCHandle.Alloc(bitmapinfoheader, GCHandleType.Pinned)
					Marshal.Copy(Me.get_ImageData(i), 0, gchandle2.AddrOfPinnedObject(), Marshal.SizeOf(GetType(IconN.BITMAPINFOHEADER)))
					gchandle2.Free()
					[structure].Width = Me.iconEntry(i).Width
					[structure].Height = Me.iconEntry(i).Height
					[structure].ColorCount = Me.iconEntry(i).ColorCount
					[structure].Reserved = Me.iconEntry(i).Reserved
					[structure].Planes = bitmapinfoheader.Planes
					[structure].BitCount = bitmapinfoheader.BitCount
					[structure].BytesInRes = Me.iconEntry(i).BytesInRes
					[structure].ID = CUShort((CULng(iconBaseID) + CULng((CLng(i)))))
					Marshal.StructureToPtr(Of IconN.GRPICONDIRENTRY)([structure], New IntPtr(gchandle.AddrOfPinnedObject().ToInt64() + CLng(num2)), False)
					num2 += Marshal.SizeOf(GetType(IconN.GRPICONDIRENTRY))
				Next
				gchandle.Free()
				Return array
			End Function

			' Token: 0x04000938 RID: 2360
			Private iconDir As IconN.ICONDIR

			' Token: 0x04000939 RID: 2361
			Private iconEntry As IconN.ICONDIRENTRY()

			' Token: 0x0400093A RID: 2362
			Private iconImage As Byte()()
		End Class
	End Class
End Namespace
