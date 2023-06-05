Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Guna.UI2.WinForms
Imports Guna.UI2.WinForms.Enums
Imports Microsoft.VisualBasic.CompilerServices
Imports Sunny.UI

Namespace S500RAT
	' Token: 0x0200003D RID: 61
	<DesignerGenerated()>
	Public Partial Class ReportWindows
		Inherits Form

		' Token: 0x06001122 RID: 4386 RVA: 0x000939E2 File Offset: 0x00091BE2
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.ReportWindows_Load
			AddHandler MyBase.Resize, AddressOf Me.ReportWindows_Resize
			Me.FormSize = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x170006FE RID: 1790
		' (get) Token: 0x06001125 RID: 4389 RVA: 0x00094BC5 File Offset: 0x00092DC5
		' (set) Token: 0x06001126 RID: 4390 RVA: 0x00094BCF File Offset: 0x00092DCF
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x170006FF RID: 1791
		' (get) Token: 0x06001127 RID: 4391 RVA: 0x00094BD8 File Offset: 0x00092DD8
		' (set) Token: 0x06001128 RID: 4392 RVA: 0x00094BE2 File Offset: 0x00092DE2
		Friend Overridable Property ImageList1 As ImageList

		' Token: 0x17000700 RID: 1792
		' (get) Token: 0x06001129 RID: 4393 RVA: 0x00094BEB File Offset: 0x00092DEB
		' (set) Token: 0x0600112A RID: 4394 RVA: 0x00094BF5 File Offset: 0x00092DF5
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x17000701 RID: 1793
		' (get) Token: 0x0600112B RID: 4395 RVA: 0x00094BFE File Offset: 0x00092DFE
		' (set) Token: 0x0600112C RID: 4396 RVA: 0x00094C08 File Offset: 0x00092E08
		Friend Overridable Property ElipseList As Guna2Elipse

		' Token: 0x17000702 RID: 1794
		' (get) Token: 0x0600112D RID: 4397 RVA: 0x00094C11 File Offset: 0x00092E11
		' (set) Token: 0x0600112E RID: 4398 RVA: 0x00094C1B File Offset: 0x00092E1B
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x17000703 RID: 1795
		' (get) Token: 0x0600112F RID: 4399 RVA: 0x00094C24 File Offset: 0x00092E24
		' (set) Token: 0x06001130 RID: 4400 RVA: 0x00094C2E File Offset: 0x00092E2E
		Friend Overridable Property MAX As ValleyMax

		' Token: 0x17000704 RID: 1796
		' (get) Token: 0x06001131 RID: 4401 RVA: 0x00094C37 File Offset: 0x00092E37
		' (set) Token: 0x06001132 RID: 4402 RVA: 0x00094C44 File Offset: 0x00092E44
		Friend Overridable Property ExitForm As ValleyClose
			<CompilerGenerated()>
			Get
				Return Me._ExitForm
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ValleyClose)
				Dim value2 As EventHandler = AddressOf Me.ExitForm_Click
				Dim exitForm As ValleyClose = Me._ExitForm
				If exitForm IsNot Nothing Then
					RemoveHandler exitForm.Click, value2
				End If
				Me._ExitForm = value
				exitForm = Me._ExitForm
				If exitForm IsNot Nothing Then
					AddHandler exitForm.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000705 RID: 1797
		' (get) Token: 0x06001133 RID: 4403 RVA: 0x00094C87 File Offset: 0x00092E87
		' (set) Token: 0x06001134 RID: 4404 RVA: 0x00094C91 File Offset: 0x00092E91
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x17000706 RID: 1798
		' (get) Token: 0x06001135 RID: 4405 RVA: 0x00094C9A File Offset: 0x00092E9A
		' (set) Token: 0x06001136 RID: 4406 RVA: 0x00094CA4 File Offset: 0x00092EA4
		Private Overridable Property ClientInfo As Label

		' Token: 0x17000707 RID: 1799
		' (get) Token: 0x06001137 RID: 4407 RVA: 0x00094CAD File Offset: 0x00092EAD
		' (set) Token: 0x06001138 RID: 4408 RVA: 0x00094CB7 File Offset: 0x00092EB7
		Friend Overridable Property ListAc As Guna2DataGridView

		' Token: 0x17000708 RID: 1800
		' (get) Token: 0x06001139 RID: 4409 RVA: 0x00094CC0 File Offset: 0x00092EC0
		' (set) Token: 0x0600113A RID: 4410 RVA: 0x00094CCA File Offset: 0x00092ECA
		Friend Overridable Property Column3 As DataGridViewImageColumn

		' Token: 0x17000709 RID: 1801
		' (get) Token: 0x0600113B RID: 4411 RVA: 0x00094CD3 File Offset: 0x00092ED3
		' (set) Token: 0x0600113C RID: 4412 RVA: 0x00094CDD File Offset: 0x00092EDD
		Friend Overridable Property Column4 As DataGridViewTextBoxColumn

		' Token: 0x1700070A RID: 1802
		' (get) Token: 0x0600113D RID: 4413 RVA: 0x00094CE6 File Offset: 0x00092EE6
		' (set) Token: 0x0600113E RID: 4414 RVA: 0x00094CF0 File Offset: 0x00092EF0
		Friend Overridable Property Save As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._Save
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.Save_Click
				Dim save As Guna2GradientButton = Me._Save
				If save IsNot Nothing Then
					RemoveHandler save.Click, value2
				End If
				Me._Save = value
				save = Me._Save
				If save IsNot Nothing Then
					AddHandler save.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700070B RID: 1803
		' (get) Token: 0x0600113F RID: 4415 RVA: 0x00094D33 File Offset: 0x00092F33
		' (set) Token: 0x06001140 RID: 4416 RVA: 0x00094D40 File Offset: 0x00092F40
		Friend Overridable Property TextBox1 As Guna2TextBox
			<CompilerGenerated()>
			Get
				Return Me._TextBox1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TextBox)
				Dim value2 As EventHandler = AddressOf Me.TextBox1_IconLeftClick
				Dim value3 As EventHandler = AddressOf Me.TextBox1_IconRightClick
				Dim textBox As Guna2TextBox = Me._TextBox1
				If textBox IsNot Nothing Then
					RemoveHandler textBox.IconLeftClick, value2
					RemoveHandler textBox.IconRightClick, value3
				End If
				Me._TextBox1 = value
				textBox = Me._TextBox1
				If textBox IsNot Nothing Then
					AddHandler textBox.IconLeftClick, value2
					AddHandler textBox.IconRightClick, value3
				End If
			End Set
		End Property

		' Token: 0x1700070C RID: 1804
		' (get) Token: 0x06001141 RID: 4417 RVA: 0x00094D9E File Offset: 0x00092F9E
		' (set) Token: 0x06001142 RID: 4418 RVA: 0x00094DA8 File Offset: 0x00092FA8
		Friend Overridable Property Guna2ResizeBox1 As Guna2ResizeBox

		' Token: 0x06001143 RID: 4419 RVA: 0x00094DB4 File Offset: 0x00092FB4
		Private Sub ReportWindows_Load(sender As Object, e As EventArgs)
			Me.ListAc.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 31, 55)
			Me.ListAc.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(26, 31, 55)
			Me.ListAc.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(26, 31, 55)
			Me.ListAc.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255)
			Me.ListAc.DefaultCellStyle.BackColor = Color.FromArgb(7, 11, 48)
			Me.ListAc.DefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255)
			Me.ListAc.DefaultCellStyle.SelectionBackColor = Color.FromArgb(47, 39, 134)
			Me.ListAc.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255)
			Me.ListAc.CellBorderStyle = DataGridViewCellBorderStyle.[Single]
			Me.FormSize = True
			Me.MinimumSize = MyBase.Size
			Me.ReadListAc()
		End Sub

		' Token: 0x06001144 RID: 4420 RVA: 0x00094EE8 File Offset: 0x000930E8
		Private Sub ReadListAc()
			Try
				Dim text As String = Conversions.ToString(Functions.RegistryGetValue("#ListAc", ""))
				Dim flag As Boolean = text <> Nothing
				If flag Then
					Dim array As String() = text.Split(New String() { "*" }, StringSplitOptions.None)
					For Each text2 As String In array
						Dim flag2 As Boolean = text2.Length > 0
						If flag2 Then
							Me.ListAc.Rows.Add(New Object() { Me.ImageList1.Images("B.png"), text2 })
						End If
					Next
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06001145 RID: 4421 RVA: 0x00094FB4 File Offset: 0x000931B4
		Public Sub SaveListAntiMalware()
			Try
				Dim text As String = String.Empty
				Try
					For Each obj As Object In CType(Me.ListAc.Rows, IEnumerable)
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Dim flag As Boolean = Not dataGridViewRow.IsNewRow
						If flag Then
							text = text + dataGridViewRow.Cells(1).Value.ToString() + "*"
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Functions.RegistrySetValue("#ListAc", Conversions.ToString(text))
			Catch ex As Exception
				Console.WriteLine(ex.Message)
			End Try
		End Sub

		' Token: 0x06001146 RID: 4422 RVA: 0x0009508C File Offset: 0x0009328C
		Private Sub ReportWindows_Resize(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not Me.FormSize
			If flag Then
				Dim width As Integer = Screen.PrimaryScreen.Bounds.Width
				Dim height As Integer = Screen.PrimaryScreen.Bounds.Height
				Dim width2 As Integer = MyBase.Width
				Dim height2 As Integer = MyBase.Height
				Dim x As Integer = CInt(Math.Round(CDbl((width - width2)) / 2.0))
				Dim y As Integer = CInt(Math.Round(CDbl((height - height2)) / 2.0))
				MyBase.Location = New Point(x, y)
			End If
		End Sub

		' Token: 0x06001147 RID: 4423 RVA: 0x00095120 File Offset: 0x00093320
		Private Sub Save_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.ListAc.Rows.Count > 0
				If flag Then
					Dim text As String = String.Empty
					Try
						For Each obj As Object In CType(Me.ListAc.Rows, IEnumerable)
							Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
							Dim flag2 As Boolean = Not dataGridViewRow.IsNewRow
							If flag2 Then
								text = text + "," + dataGridViewRow.Cells(1).Value.ToString()
							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					Me.Title = text
					Me.SaveListAntiMalware()
					MyBase.Close()
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06001148 RID: 4424 RVA: 0x00095208 File Offset: 0x00093408
		Private Sub TextBox1_IconLeftClick(sender As Object, e As EventArgs)
			Try
				Try
					For Each obj As Object In Me.ListAc.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Me.ListAc.Rows.Remove(dataGridViewRow)
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			Catch ex As Exception
				MessageBox.Show(ex.Message, "Motionr Watcher!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			End Try
		End Sub

		' Token: 0x06001149 RID: 4425 RVA: 0x000952B0 File Offset: 0x000934B0
		Private Sub TextBox1_IconRightClick(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Operators.CompareString(Me.TextBox1.Text, Nothing, False) = 0
				If Not flag Then
					Me.ListAc.Rows.Add(New Object() { Me.ImageList1.Images("B.png"), Me.TextBox1.Text })
					Me.TextBox1.Clear()
				End If
			Catch ex As Exception
				MessageBox.Show(ex.Message, "Motionr Watcher!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			End Try
		End Sub

		' Token: 0x0600114A RID: 4426 RVA: 0x0009535C File Offset: 0x0009355C
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			Me.Title = ""
			MyBase.Close()
		End Sub

		' Token: 0x040007BB RID: 1979
		Public Title As String

		' Token: 0x040007BC RID: 1980
		Private FormSize As Boolean
	End Class
End Namespace
