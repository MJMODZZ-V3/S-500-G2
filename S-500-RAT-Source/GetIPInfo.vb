﻿Imports System
Imports System.IO
Imports System.Net
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.My.Resources

Namespace S500RAT
	' Token: 0x0200006D RID: 109
	Public Class GetIPInfo
		' Token: 0x060011F7 RID: 4599 RVA: 0x000A0CEC File Offset: 0x0009EEEC
		Public Sub New()
			Me.CountryName = New String() { "N/A", "Asia/Pacific Region", "Europe", "Andorra", "United Arab Emirates", "Afghanistan", "Antigua and Barbuda", "Anguilla", "Albania", "Armenia", "Netherlands Antilles", "Angola", "Antarctica", "Argentina", "American Samoa", "Austria", "Australia", "Aruba", "Azerbaijan", "Bosnia and Herzegovina", "Barbados", "Bangladesh", "Belgium", "Burkina Faso", "Bulgaria", "Bahrain", "Burundi", "Benin", "Bermuda", "Brunei Darussalam", "Bolivia", "Brazil", "Bahamas", "Bhutan", "Bouvet Island", "Botswana", "Belarus", "Belize", "Canada", "Cocos (Keeling) Islands", "Congo, The Democratic Republic of the", "Central African Republic", "Congo", "Switzerland", "Cote D'Ivoire", "Cook Islands", "Chile", "Cameroon", "China", "Colombia", "Costa Rica", "Cuba", "Cape Verde", "Christmas Island", "Cyprus", "Czech Republic", "Germany", "Djibouti", "Denmark", "Dominica", "Dominican Republic", "Algeria", "Ecuador", "Estonia", "Egypt", "Western Sahara", "Eritrea", "Spain", "Ethiopia", "Finland", "Fiji", "Falkland Islands (Malvinas)", "Micronesia, Federated States of", "Faroe Islands", "France", "France, Metropolitan", "Gabon", "United Kingdom", "Grenada", "Georgia", "French Guiana", "Ghana", "Gibraltar", "Greenland", "Gambia", "Guinea", "Guadeloupe", "Equatorial Guinea", "Greece", "South Georgia and the South Sandwich Islands", "Guatemala", "Guam", "Guinea-Bissau", "Guyana", "Hong Kong", "Heard Island and McDonald Islands", "Honduras", "Croatia", "Haiti", "Hungary", "Indonesia", "Ireland", "Israel", "India", "British Indian Ocean Territory", "Iraq", "Iran, Islamic Republic of", "Iceland", "Italy", "Jamaica", "Jordan", "Japan", "Kenya", "Kyrgyzstan", "Cambodia", "Kiribati", "Comoros", "Saint Kitts and Nevis", "Korea, Democratic People's Republic of", "Korea, Republic of", "Kuwait", "Cayman Islands", "Kazakstan", "Lao People's Democratic Republic", "Lebanon", "Saint Lucia", "Liechtenstein", "Sri Lanka", "Liberia", "Lesotho", "Lithuania", "Luxembourg", "Latvia", "Libyan Arab Jamahiriya", "Morocco", "Monaco", "Moldova, Republic of", "Madagascar", "Marshall Islands", "Macedonia, the Former Yugoslav Republic of", "Mali", "Myanmar", "Mongolia", "Macao", "Northern Mariana Islands", "Martinique", "Mauritania", "Montserrat", "Malta", "Mauritius", "Maldives", "Malawi", "Mexico", "Malaysia", "Mozambique", "Namibia", "New Caledonia", "Niger", "Norfolk Island", "Nigeria", "Nicaragua", "Netherlands", "Norway", "Nepal", "Nauru", "Niue", "New Zealand", "Oman", "Panama", "Peru", "French Polynesia", "Papua New Guinea", "Philippines", "Pakistan", "Poland", "Saint Pierre and Miquelon", "Pitcairn", "Puerto Rico", "Palestinian Territory, Occupied", "Portugal", "Palau", "Paraguay", "Qatar", "Reunion", "Romania", "Russian Federation", "Rwanda", "Saudi Arabia", "Solomon Islands", "Seychelles", "Sudan", "Sweden", "Singapore", "Saint Helena", "Slovenia", "Svalbard and Jan Mayen", "Slovakia", "Sierra Leone", "San Marino", "Senegal", "Somalia", "Suriname", "Sao Tome and Principe", "El Salvador", "Syrian Arab Republic", "Swaziland", "Turks and Caicos Islands", "Chad", "French Southern Territories", "Togo", "Thailand", "Tajikistan", "Tokelau", "Turkmenistan", "Tunisia", "Tonga", "Timor-Leste", "Turkey", "Trinidad and Tobago", "Tuvalu", "Taiwan, Province of China", "Tanzania, United Republic of", "Ukraine", "Uganda", "United States Minor Outlying Islands", "United States", "Uruguay", "Uzbekistan", "Holy See (Vatican City State)", "Saint Vincent and the Grenadines", "Venezuela", "Virgin Islands, British", "Virgin Islands, U.S.", "Vietnam", "Vanuatu", "Wallis and Futuna", "Samoa", "Yemen", "Mayotte", "Yugoslavia", "South Africa", "Zambia", "Montenegro", "Zimbabwe", "Anonymous Proxy", "Satellite Provider", "Other", "Aland Islands", "Guernsey", "Isle of Man", "Jersey", "Saint Barthelemy", "Saint Martin" }
			Me.CountryCode = New String() { "--", "AP", "EU", "AD", "AE", "AF", "AG", "AI", "AL", "AM", "AN", "AO", "AQ", "AR", "AS", "AT", "AU", "AW", "AZ", "BA", "BB", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BM", "BN", "BO", "BR", "BS", "BT", "BV", "BW", "BY", "BZ", "CA", "CC", "CD", "CF", "CG", "CH", "CI", "CK", "CL", "CM", "CN", "CO", "CR", "CU", "CV", "CX", "CY", "CZ", "DE", "DJ", "DK", "DM", "DO", "DZ", "EC", "EE", "EG", "EH", "ER", "ES", "ET", "FI", "FJ", "FK", "FM", "FO", "FR", "FX", "GA", "GB", "GD", "GE", "GF", "GH", "GI", "GL", "GM", "GN", "GP", "GQ", "GR", "GS", "GT", "GU", "GW", "GY", "HK", "HM", "HN", "HR", "HT", "HU", "ID", "IE", "IL", "IN", "IO", "IQ", "IR", "IS", "IT", "JM", "JO", "JP", "KE", "KG", "KH", "KI", "KM", "KN", "KP", "KR", "KW", "KY", "KZ", "LA", "LB", "LC", "LI", "LK", "LR", "LS", "LT", "LU", "LV", "LY", "MA", "MC", "MD", "MG", "MH", "MK", "ML", "MM", "MN", "MO", "MP", "MQ", "MR", "MS", "MT", "MU", "MV", "MW", "MX", "MY", "MZ", "NA", "NC", "NE", "NF", "NG", "NI", "NL", "NO", "NP", "NR", "NU", "NZ", "OM", "PA", "PE", "PF", "PG", "PH", "PK", "PL", "PM", "PN", "PR", "PS", "PT", "PW", "PY", "QA", "RE", "RO", "RU", "RW", "SA", "SB", "SC", "SD", "SE", "SG", "SH", "SI", "SJ", "SK", "SL", "SM", "SN", "SO", "SR", "ST", "SV", "SY", "SZ", "TC", "TD", "TF", "TG", "TH", "TJ", "TK", "TM", "TN", "TO", "TL", "TR", "TT", "TV", "TW", "TZ", "UA", "UG", "UM", "US", "UY", "UZ", "VA", "VC", "VE", "VG", "VI", "VN", "VU", "WF", "WS", "YE", "YT", "SAU", "RS", "ZA", "ZM", "ME", "ZW", "A1", "A2", "O1", "AX", "GG", "IM", "JE", "BL", "MF" }
			Me.CountryNump = New String() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "211", "212", "213", "214", "215", "216", "217", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242", "243", "244", "245", "246", "247", "248", "249", "250", "251", "252", "253", "254" }
			Me.CountryBegin = 16776960L
			Me.Data_MS = New MemoryStream(Resources.GeoIP)
		End Sub

		' Token: 0x060011F8 RID: 4600 RVA: 0x000A2C6C File Offset: 0x000A0E6C
		Public Function Info(IP As String) As String
			Dim ipa As IPAddress
			Try
				ipa = IPAddress.Parse(IP)
			Catch ex As FormatException
				Return "N/A"
			End Try
			Return String.Concat(New String() { IP, ":", Me.CountryName(CInt(Me.SeekCountry(0L, Me.ConvertIPAddressToNumber(ipa), 31))), ":", Me.CountryCode(CInt(Me.SeekCountry(0L, Me.ConvertIPAddressToNumber(ipa), 31))) })
		End Function

		' Token: 0x060011F9 RID: 4601 RVA: 0x000A2D08 File Offset: 0x000A0F08
		Private Function ConvertIPAddressToNumber(IPA As IPAddress) As Long
			Dim array As String() = Strings.Split(IPA.ToString(), ".", -1, CompareMethod.Binary)
			Dim flag As Boolean = Information.UBound(array, 1) = 3
			Dim result As Long
			If flag Then
				' The following expression was wrapped in a checked-expression
				' The following expression was wrapped in a unchecked-expression
				result = CLng(Math.Round(16777216.0 * Conversions.ToDouble(array(0)) + 65536.0 * Conversions.ToDouble(array(1)) + 256.0 * Conversions.ToDouble(array(2)) + Conversions.ToDouble(array(3))))
			Else
				result = 0L
			End If
			Return result
		End Function

		' Token: 0x060011FA RID: 4602 RVA: 0x000A2D8C File Offset: 0x000A0F8C
		Private Function SeekCountry(StartOffset As Long, IPNumber As Long, SearchDepth As Integer) As Long
			Dim array As Byte() = New Byte(6) {}
			Dim array2 As Long() = New Long(2) {}
			Try
				Me.Data_MS.Seek(6L * StartOffset, SeekOrigin.Begin)
				Me.Data_MS.Read(array, 0, 6)
			Catch ex As IOException
			End Try
			Dim num As Integer = 0
			Do
				array2(num) = 0L
				Dim num2 As Integer = 0
				Do
					Dim num3 As Integer = CInt(array(num * 3 + num2))
					Dim flag As Boolean = num3 < 0
					If flag Then
						num3 += 256
					End If
					Dim array3 As Long() = array2
					Dim num4 As Integer = num
					Dim num5 As Long = array3(num4)
					array3(num4) = num5 + Me.Left(CLng(num3), num2 * 8)
					num2 += 1
				Loop While num2 <= 2
				num += 1
			Loop While num <= 1
			Dim flag2 As Boolean = (IPNumber And Me.Left(1L, SearchDepth)) > 0L
			Dim result As Long
			If flag2 Then
				Dim flag3 As Boolean = array2(1) >= Me.CountryBegin
				If flag3 Then
					result = array2(1) - Me.CountryBegin
				Else
					result = Me.SeekCountry(array2(1), IPNumber, SearchDepth - 1)
				End If
			Else
				Dim flag4 As Boolean = array2(0) >= Me.CountryBegin
				If flag4 Then
					result = array2(0) - Me.CountryBegin
				Else
					result = Me.SeekCountry(array2(0), IPNumber, SearchDepth - 1)
				End If
			End If
			Return result
		End Function

		' Token: 0x060011FB RID: 4603 RVA: 0x000A2EE8 File Offset: 0x000A10E8
		Private Function Left(Value As Long, Count As Integer) As Long
			Dim num As Long = Value
			For i As Integer = 1 To Count
				num *= 2L
			Next
			Return num
		End Function

		' Token: 0x040007E9 RID: 2025
		Private CountryName As String()

		' Token: 0x040007EA RID: 2026
		Private CountryCode As String()

		' Token: 0x040007EB RID: 2027
		Private CountryNump As String()

		' Token: 0x040007EC RID: 2028
		Private CountryBegin As Long

		' Token: 0x040007ED RID: 2029
		Private Data_MS As MemoryStream
	End Class
End Namespace
