Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace S500RAT
	' Token: 0x02000074 RID: 116
	Friend Class ValleyMax
		Inherits Control

		' Token: 0x0600120F RID: 4623 RVA: 0x000A3679 File Offset: 0x000A1879
		Protected Overrides Sub OnMouseEnter(e As EventArgs)
			MyBase.OnMouseEnter(e)
			Me.State = MouseState.Over
			MyBase.Invalidate()
		End Sub

		' Token: 0x06001210 RID: 4624 RVA: 0x000A3692 File Offset: 0x000A1892
		Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
			MyBase.OnMouseDown(e)
			Me.State = MouseState.Down
			MyBase.Invalidate()
		End Sub

		' Token: 0x06001211 RID: 4625 RVA: 0x000A36AB File Offset: 0x000A18AB
		Protected Overrides Sub OnMouseLeave(e As EventArgs)
			MyBase.OnMouseLeave(e)
			Me.State = MouseState.None
			MyBase.Invalidate()
		End Sub

		' Token: 0x06001212 RID: 4626 RVA: 0x000A36C4 File Offset: 0x000A18C4
		Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
			MyBase.OnMouseUp(e)
			Me.State = MouseState.Over
			MyBase.Invalidate()
		End Sub

		' Token: 0x06001213 RID: 4627 RVA: 0x000A36DD File Offset: 0x000A18DD
		Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
			MyBase.OnMouseMove(e)
			Me.x = e.X
			MyBase.Invalidate()
		End Sub

		' Token: 0x06001214 RID: 4628 RVA: 0x000A36FC File Offset: 0x000A18FC
		Protected Overrides Sub OnClick(e As EventArgs)
			MyBase.OnClick(e)
			Dim windowState As FormWindowState = MyBase.FindForm().WindowState
			If windowState <> FormWindowState.Normal Then
				If windowState = FormWindowState.Maximized Then
					MyBase.FindForm().WindowState = FormWindowState.Normal
				End If
			Else
				MyBase.FindForm().WindowState = FormWindowState.Maximized
			End If
		End Sub

		' Token: 0x06001215 RID: 4629 RVA: 0x000A374B File Offset: 0x000A194B
		Protected Overrides Sub OnResize(e As EventArgs)
			MyBase.OnResize(e)
			MyBase.Size = New Size(20, 20)
		End Sub

		' Token: 0x06001216 RID: 4630 RVA: 0x000A3766 File Offset: 0x000A1966
		Public Sub New()
			Me.State = MouseState.None
			MyBase.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
			MyBase.SetStyle(ControlStyles.Opaque, True)
			Me.Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
		End Sub

		' Token: 0x06001217 RID: 4631 RVA: 0x000A3798 File Offset: 0x000A1998
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Dim graphics As Graphics = e.Graphics
			graphics.Clear(Color.FromArgb(7, 11, 41))
			graphics.SmoothingMode = SmoothingMode.HighQuality
			graphics.FillEllipse(New SolidBrush(Color.FromArgb(7, 11, 41)), New Rectangle(0, 0, 18, 18))
			graphics.FillEllipse(New SolidBrush(Color.FromArgb(254, 190, 4)), New Rectangle(2, 2, 15, 15))
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

		' Token: 0x040007F5 RID: 2037
		Private State As MouseState

		' Token: 0x040007F6 RID: 2038
		Private x As Integer
	End Class
End Namespace
