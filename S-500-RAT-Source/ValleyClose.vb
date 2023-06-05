Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace S500RAT
	' Token: 0x02000073 RID: 115
	Friend Class ValleyClose
		Inherits Control

		' Token: 0x06001207 RID: 4615 RVA: 0x000A34CF File Offset: 0x000A16CF
		Protected Overrides Sub OnMouseEnter(e As EventArgs)
			MyBase.OnMouseEnter(e)
			Me.State = MouseState.Over
			MyBase.Invalidate()
		End Sub

		' Token: 0x06001208 RID: 4616 RVA: 0x000A34E8 File Offset: 0x000A16E8
		Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
			MyBase.OnMouseDown(e)
			Me.State = MouseState.Down
			MyBase.Invalidate()
		End Sub

		' Token: 0x06001209 RID: 4617 RVA: 0x000A3501 File Offset: 0x000A1701
		Protected Overrides Sub OnMouseLeave(e As EventArgs)
			MyBase.OnMouseLeave(e)
			Me.State = MouseState.None
			MyBase.Invalidate()
		End Sub

		' Token: 0x0600120A RID: 4618 RVA: 0x000A351A File Offset: 0x000A171A
		Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
			MyBase.OnMouseUp(e)
			Me.State = MouseState.Over
			MyBase.Invalidate()
		End Sub

		' Token: 0x0600120B RID: 4619 RVA: 0x000A3533 File Offset: 0x000A1733
		Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
			MyBase.OnMouseMove(e)
			Me.x = e.X
			MyBase.Invalidate()
		End Sub

		' Token: 0x0600120C RID: 4620 RVA: 0x000A3551 File Offset: 0x000A1751
		Protected Overrides Sub OnResize(e As EventArgs)
			MyBase.OnResize(e)
			MyBase.Size = New Size(20, 20)
		End Sub

		' Token: 0x0600120D RID: 4621 RVA: 0x000A356C File Offset: 0x000A176C
		Public Sub New()
			Me.State = MouseState.None
			MyBase.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
			MyBase.SetStyle(ControlStyles.Opaque, True)
			Me.Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
		End Sub

		' Token: 0x0600120E RID: 4622 RVA: 0x000A359C File Offset: 0x000A179C
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Dim graphics As Graphics = e.Graphics
			graphics.Clear(Color.FromArgb(7, 11, 41))
			graphics.SmoothingMode = SmoothingMode.HighQuality
			graphics.FillEllipse(New SolidBrush(Color.FromArgb(7, 11, 41)), New Rectangle(0, 0, 18, 18))
			graphics.FillEllipse(New SolidBrush(Color.FromArgb(254, 97, 82)), New Rectangle(2, 2, 15, 15))
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

		' Token: 0x040007F3 RID: 2035
		Private State As MouseState

		' Token: 0x040007F4 RID: 2036
		Private x As Integer
	End Class
End Namespace
