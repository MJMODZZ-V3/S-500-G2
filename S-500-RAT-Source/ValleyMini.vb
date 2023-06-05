Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace S500RAT
	' Token: 0x02000075 RID: 117
	Friend Class ValleyMini
		Inherits Control

		' Token: 0x06001218 RID: 4632 RVA: 0x000A3877 File Offset: 0x000A1A77
		Protected Overrides Sub OnMouseEnter(e As EventArgs)
			MyBase.OnMouseEnter(e)
			Me.State = MouseState.Over
			MyBase.Invalidate()
		End Sub

		' Token: 0x06001219 RID: 4633 RVA: 0x000A3890 File Offset: 0x000A1A90
		Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
			MyBase.OnMouseDown(e)
			Me.State = MouseState.Down
			MyBase.Invalidate()
		End Sub

		' Token: 0x0600121A RID: 4634 RVA: 0x000A38A9 File Offset: 0x000A1AA9
		Protected Overrides Sub OnMouseLeave(e As EventArgs)
			MyBase.OnMouseLeave(e)
			Me.State = MouseState.None
			MyBase.Invalidate()
		End Sub

		' Token: 0x0600121B RID: 4635 RVA: 0x000A38C2 File Offset: 0x000A1AC2
		Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
			MyBase.OnMouseUp(e)
			Me.State = MouseState.Over
			MyBase.Invalidate()
		End Sub

		' Token: 0x0600121C RID: 4636 RVA: 0x000A38DB File Offset: 0x000A1ADB
		Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
			MyBase.OnMouseMove(e)
			Me.x = e.X
			MyBase.Invalidate()
		End Sub

		' Token: 0x0600121D RID: 4637 RVA: 0x000A38FC File Offset: 0x000A1AFC
		Protected Overrides Sub OnClick(e As EventArgs)
			MyBase.OnClick(e)
			Dim windowState As FormWindowState = MyBase.FindForm().WindowState
			If windowState <> FormWindowState.Normal Then
				If windowState = FormWindowState.Maximized Then
					MyBase.FindForm().WindowState = FormWindowState.Minimized
				End If
			Else
				MyBase.FindForm().WindowState = FormWindowState.Minimized
			End If
		End Sub

		' Token: 0x0600121E RID: 4638 RVA: 0x000A394B File Offset: 0x000A1B4B
		Protected Overrides Sub OnResize(e As EventArgs)
			MyBase.OnResize(e)
			MyBase.Size = New Size(20, 20)
		End Sub

		' Token: 0x0600121F RID: 4639 RVA: 0x000A3966 File Offset: 0x000A1B66
		Public Sub New()
			Me.State = MouseState.None
			MyBase.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
			MyBase.SetStyle(ControlStyles.Opaque, True)
			Me.Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
		End Sub

		' Token: 0x06001220 RID: 4640 RVA: 0x000A3998 File Offset: 0x000A1B98
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Dim graphics As Graphics = e.Graphics
			graphics.Clear(Color.FromArgb(7, 11, 41))
			graphics.SmoothingMode = SmoothingMode.HighQuality
			graphics.FillEllipse(New SolidBrush(Color.FromArgb(7, 11, 41)), New Rectangle(0, 0, 18, 18))
			graphics.FillEllipse(New SolidBrush(Color.FromArgb(23, 205, 58)), New Rectangle(2, 2, 15, 15))
			Dim state As MouseState = Me.State
			If state <> MouseState.Over Then
				If state = MouseState.Down Then
					graphics.FillEllipse(New SolidBrush(Color.FromArgb(40, Color.Black)), New Rectangle(2, 2, 15, 15))
				End If
			Else
				graphics.FillEllipse(New SolidBrush(Color.FromArgb(40, Color.White)), New Rectangle(2, 2, 15, 15))
			End If
			MyBase.OnPaint(e)
		End Sub

		' Token: 0x040007F7 RID: 2039
		Private State As MouseState

		' Token: 0x040007F8 RID: 2040
		Private x As Integer
	End Class
End Namespace
