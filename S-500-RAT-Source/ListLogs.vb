Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server

Namespace S500RAT
	' Token: 0x02000064 RID: 100
	Public Class ListLogs
		' Token: 0x060011C6 RID: 4550 RVA: 0x0009EB6C File Offset: 0x0009CD6C
		Public Shared Sub AddArray(Mesg As String, Statue As Integer)
			Dim item As DataGridViewRow = New DataGridViewRow() With { .Height = 30 }
			item.Cells.Add(New DataGridViewImageCell() With { .Value = DataB.form1_0.ImageListLogs.Images(Conversions.ToString(Statue) + ".png"), .ImageLayout = DataGridViewImageCellLayout.Zoom })
			item.Cells.Add(New DataGridViewTextBoxCell() With { .Value = DateTime.Now.ToLongTimeString() })
			item.Cells.Add(New DataGridViewTextBoxCell() With { .Value = Mesg.ToString() })
			Dim dataGridViewCell As DataGridViewCell = item.Cells(2)
			Dim flag As Boolean = Statue = 0
			If flag Then
				dataGridViewCell.Style.ForeColor = Color.Orange
			Else
				Dim flag2 As Boolean = Statue = 2
				If flag2 Then
					dataGridViewCell.Style.ForeColor = Color.Cyan
				Else
					Dim flag3 As Boolean = Statue = 2
					If flag3 Then
						dataGridViewCell.Style.ForeColor = Color.LightGreen
					Else
						Dim flag4 As Boolean = Statue = 3
						If flag4 Then
							dataGridViewCell.Style.ForeColor = Color.LightGreen
						Else
							Dim flag5 As Boolean = Statue = 4
							If flag5 Then
								dataGridViewCell.Style.ForeColor = Color.LightGreen
							Else
								dataGridViewCell.Style.ForeColor = Color.Red
							End If
						End If
					End If
				End If
			End If
			item.Resizable = DataGridViewTriState.[False]
			DataB.form1_0.Invoke(New MethodInvoker(Sub()
				Dim lockDataGridVieLogs As Object = Setting.LockDataGridVieLogs
				ObjectFlowControl.CheckForSyncLockOnValueType(lockDataGridVieLogs)
				SyncLock lockDataGridVieLogs
					DataB.form1_0.DataGridViewLogs.Rows.Add(item)
				End SyncLock
			End Sub))
		End Sub
	End Class
End Namespace
