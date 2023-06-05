Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports S500RAT.My.Resources
Imports Svg

Namespace S500RAT
	' Token: 0x0200006C RID: 108
	Public Class Geomap
		' Token: 0x060011F5 RID: 4597 RVA: 0x000A0AFC File Offset: 0x0009ECFC
		Public Shared Function GetMAP(List As String) As Bitmap
			Dim result As Bitmap = New Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
			Try
				Dim path As String = Interaction.Environ("temp") + "\TMPGeoMap.svg"
				Dim contents As String = Resources.GeoMap.ToString().Replace("%Country%", List)
				File.WriteAllText(path, contents)
				Dim svgDocument As SvgDocument = SvgDocument.Open(path)
				Dim bitmap As Bitmap = svgDocument.Draw()
				Dim bitmap2 As Bitmap = bitmap
				Dim memoryStream As MemoryStream = New MemoryStream()
				bitmap2.Save(memoryStream, ImageFormat.Png)
				Dim image As Bitmap = CType(Image.FromStream(memoryStream), Bitmap)
				result = CType(Geomap.ResizeImage(image, New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height), True), Bitmap)
				memoryStream.Dispose()
				GC.Collect()
			Catch ex As Exception
				Console.WriteLine("Falid")
			End Try
			Return result
		End Function

		' Token: 0x060011F6 RID: 4598 RVA: 0x000A0C20 File Offset: 0x0009EE20
		Public Shared Function ResizeImage(image As Image, size As Size, Optional preserveAspectRatio As Boolean = True) As Image
			' The following expression was wrapped in a checked-statement
			Dim width2 As Integer
			Dim height2 As Integer
			If preserveAspectRatio Then
				Dim width As Integer = image.Width
				Dim height As Integer = image.Height
				Dim num As Single = CSng(size.Width) / CSng(width)
				Dim num2 As Single = CSng(size.Height) / CSng(height)
				Dim num3 As Single = If((num2 < num), num2, num)
				width2 = CInt(Math.Round(CDbl((CSng(width) * num3))))
				height2 = CInt(Math.Round(CDbl((CSng(height) * num3))))
			Else
				width2 = size.Width
				height2 = size.Height
			End If
			Dim image2 As Image = New Bitmap(width2, height2)
			Using graphics As Graphics = Graphics.FromImage(image2)
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
				graphics.DrawImage(image, 0, 0, width2, height2)
			End Using
			Return image2
		End Function

		' Token: 0x040007E8 RID: 2024
		Public Shared Map As Object = RuntimeHelpers.GetObjectValue(New Object())
	End Class
End Namespace
