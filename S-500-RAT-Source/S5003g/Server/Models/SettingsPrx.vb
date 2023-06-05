Imports System
Imports System.IO
Imports System.Windows.Forms
Imports System.Xml
Imports System.Xml.XPath
Imports Microsoft.VisualBasic.CompilerServices

Namespace S500RAT.S5003g.Server.Models
	' Token: 0x02000076 RID: 118
	Public NotInheritable Module SettingsPrx
		' Token: 0x1700071B RID: 1819
		' (get) Token: 0x06001222 RID: 4642 RVA: 0x000A3AA0 File Offset: 0x000A1CA0
		' (set) Token: 0x06001223 RID: 4643 RVA: 0x000A3AC6 File Offset: 0x000A1CC6
		Public Property ListenPort As UShort
			Get
				Return UShort.Parse(SettingsPrx.ReadValueSafe("ListenPort", "4782"))
			End Get
			Set(value As UShort)
				SettingsPrx.WriteValue("ListenPort", value.ToString())
			End Set
		End Property

		' Token: 0x1700071C RID: 1820
		' (get) Token: 0x06001224 RID: 4644 RVA: 0x000A3ADC File Offset: 0x000A1CDC
		' (set) Token: 0x06001225 RID: 4645 RVA: 0x000A3B02 File Offset: 0x000A1D02
		Public Property IPv6Support As Boolean
			Get
				Return Boolean.Parse(SettingsPrx.ReadValueSafe("IPv6Support", "False"))
			End Get
			Set(value As Boolean)
				SettingsPrx.WriteValue("IPv6Support", value.ToString())
			End Set
		End Property

		' Token: 0x1700071D RID: 1821
		' (get) Token: 0x06001226 RID: 4646 RVA: 0x000A3B18 File Offset: 0x000A1D18
		' (set) Token: 0x06001227 RID: 4647 RVA: 0x000A3B3E File Offset: 0x000A1D3E
		Public Property AutoListen As Boolean
			Get
				Return Boolean.Parse(SettingsPrx.ReadValueSafe("AutoListen", "False"))
			End Get
			Set(value As Boolean)
				SettingsPrx.WriteValue("AutoListen", value.ToString())
			End Set
		End Property

		' Token: 0x1700071E RID: 1822
		' (get) Token: 0x06001228 RID: 4648 RVA: 0x000A3B54 File Offset: 0x000A1D54
		' (set) Token: 0x06001229 RID: 4649 RVA: 0x000A3B7A File Offset: 0x000A1D7A
		Public Property ShowPopup As Boolean
			Get
				Return Boolean.Parse(SettingsPrx.ReadValueSafe("ShowPopup", "False"))
			End Get
			Set(value As Boolean)
				SettingsPrx.WriteValue("ShowPopup", value.ToString())
			End Set
		End Property

		' Token: 0x1700071F RID: 1823
		' (get) Token: 0x0600122A RID: 4650 RVA: 0x000A3B90 File Offset: 0x000A1D90
		' (set) Token: 0x0600122B RID: 4651 RVA: 0x000A3BB6 File Offset: 0x000A1DB6
		Public Property UseUPnP As Boolean
			Get
				Return Boolean.Parse(SettingsPrx.ReadValueSafe("UseUPnP", "False"))
			End Get
			Set(value As Boolean)
				SettingsPrx.WriteValue("UseUPnP", value.ToString())
			End Set
		End Property

		' Token: 0x17000720 RID: 1824
		' (get) Token: 0x0600122C RID: 4652 RVA: 0x000A3BCC File Offset: 0x000A1DCC
		' (set) Token: 0x0600122D RID: 4653 RVA: 0x000A3BF2 File Offset: 0x000A1DF2
		Public Property ShowToolTip As Boolean
			Get
				Return Boolean.Parse(SettingsPrx.ReadValueSafe("ShowToolTip", "False"))
			End Get
			Set(value As Boolean)
				SettingsPrx.WriteValue("ShowToolTip", value.ToString())
			End Set
		End Property

		' Token: 0x17000721 RID: 1825
		' (get) Token: 0x0600122E RID: 4654 RVA: 0x000A3C08 File Offset: 0x000A1E08
		' (set) Token: 0x0600122F RID: 4655 RVA: 0x000A3C2E File Offset: 0x000A1E2E
		Public Property EnableNoIPUpdater As Boolean
			Get
				Return Boolean.Parse(SettingsPrx.ReadValueSafe("EnableNoIPUpdater", "False"))
			End Get
			Set(value As Boolean)
				SettingsPrx.WriteValue("EnableNoIPUpdater", value.ToString())
			End Set
		End Property

		' Token: 0x17000722 RID: 1826
		' (get) Token: 0x06001230 RID: 4656 RVA: 0x000A3C44 File Offset: 0x000A1E44
		' (set) Token: 0x06001231 RID: 4657 RVA: 0x000A3C65 File Offset: 0x000A1E65
		Public Property NoIPHost As String
			Get
				Return SettingsPrx.ReadValueSafe("NoIPHost", "")
			End Get
			Set(value As String)
				SettingsPrx.WriteValue("NoIPHost", value)
			End Set
		End Property

		' Token: 0x17000723 RID: 1827
		' (get) Token: 0x06001232 RID: 4658 RVA: 0x000A3C74 File Offset: 0x000A1E74
		' (set) Token: 0x06001233 RID: 4659 RVA: 0x000A3C95 File Offset: 0x000A1E95
		Public Property NoIPUsername As String
			Get
				Return SettingsPrx.ReadValueSafe("NoIPUsername", "")
			End Get
			Set(value As String)
				SettingsPrx.WriteValue("NoIPUsername", value)
			End Set
		End Property

		' Token: 0x17000724 RID: 1828
		' (get) Token: 0x06001234 RID: 4660 RVA: 0x000A3CA4 File Offset: 0x000A1EA4
		' (set) Token: 0x06001235 RID: 4661 RVA: 0x000A3CC5 File Offset: 0x000A1EC5
		Public Property NoIPPassword As String
			Get
				Return SettingsPrx.ReadValueSafe("NoIPPassword", "")
			End Get
			Set(value As String)
				SettingsPrx.WriteValue("NoIPPassword", value)
			End Set
		End Property

		' Token: 0x17000725 RID: 1829
		' (get) Token: 0x06001236 RID: 4662 RVA: 0x000A3CD4 File Offset: 0x000A1ED4
		' (set) Token: 0x06001237 RID: 4663 RVA: 0x000A3CF5 File Offset: 0x000A1EF5
		Public Property SaveFormat As String
			Get
				Return SettingsPrx.ReadValueSafe("SaveFormat", "APP - URL - USER:PASS")
			End Get
			Set(value As String)
				SettingsPrx.WriteValue("SaveFormat", value)
			End Set
		End Property

		' Token: 0x17000726 RID: 1830
		' (get) Token: 0x06001238 RID: 4664 RVA: 0x000A3D04 File Offset: 0x000A1F04
		' (set) Token: 0x06001239 RID: 4665 RVA: 0x000A3D2A File Offset: 0x000A1F2A
		Public Property ReverseProxyPort As UShort
			Get
				Return UShort.Parse(SettingsPrx.ReadValueSafe("ReverseProxyPort", "3128"))
			End Get
			Set(value As UShort)
				SettingsPrx.WriteValue("ReverseProxyPort", value.ToString())
			End Set
		End Property

		' Token: 0x0600123A RID: 4666 RVA: 0x000A3D40 File Offset: 0x000A1F40
		Private Function ReadValue(pstrValueToRead As String) As String
			Dim result As String
			Try
				Dim xpathDocument As XPathDocument = New XPathDocument(SettingsPrx.SettingsPath)
				Dim xpathNavigator As XPathNavigator = xpathDocument.CreateNavigator()
				Dim expr As XPathExpression = xpathNavigator.Compile("/settings/" + pstrValueToRead)
				Dim xpathNodeIterator As XPathNodeIterator = xpathNavigator.[Select](expr)
				If Not xpathNodeIterator.MoveNext() Then
					result = String.Empty
				Else
					result = xpathNodeIterator.Current.Value
				End If
			Catch ex As Exception
				result = String.Empty
			End Try
			Return result
		End Function

		' Token: 0x0600123B RID: 4667 RVA: 0x000A3DC8 File Offset: 0x000A1FC8
		Private Function ReadValueSafe(pstrValueToRead As String, Optional defaultValue As String = "") As String
			Dim text As String = SettingsPrx.ReadValue(pstrValueToRead)
			Return If((Not String.IsNullOrEmpty(text)), text, defaultValue)
		End Function

		' Token: 0x0600123C RID: 4668 RVA: 0x000A3DF0 File Offset: 0x000A1FF0
		Private Sub WriteValue(pstrValueToRead As String, pstrValueToWrite As String)
			Try
				Dim xmlDocument As XmlDocument = New XmlDocument()
				Dim flag As Boolean = File.Exists(SettingsPrx.SettingsPath)
				If flag Then
					Using xmlTextReader As XmlTextReader = New XmlTextReader(SettingsPrx.SettingsPath)
						xmlDocument.Load(xmlTextReader)
					End Using
				Else
					Dim directoryName As String = Path.GetDirectoryName(SettingsPrx.SettingsPath)
					Dim flag2 As Boolean = Not Directory.Exists(directoryName)
					If flag2 Then
						Directory.CreateDirectory(directoryName)
					End If
					xmlDocument.AppendChild(xmlDocument.CreateElement("settings"))
				End If
				Dim documentElement As XmlElement = xmlDocument.DocumentElement
				Dim xmlNode As XmlNode = documentElement.SelectSingleNode("/settings/" + pstrValueToRead)
				Dim flag3 As Boolean = xmlNode Is Nothing
				If flag3 Then
					xmlNode = xmlDocument.SelectSingleNode("settings")
					xmlNode.AppendChild(xmlDocument.CreateElement(pstrValueToRead)).InnerText = pstrValueToWrite
					xmlDocument.Save(SettingsPrx.SettingsPath)
				Else
					xmlNode.InnerText = pstrValueToWrite
					xmlDocument.Save(SettingsPrx.SettingsPath)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x040007F9 RID: 2041
		Private SettingsPath As String = Path.Combine(Application.StartupPath, "settings.xml")

		' Token: 0x040007FA RID: 2042
		Public CertificatePath As String = Path.Combine(Application.StartupPath, "quasar.p12")
	End Module
End Namespace
