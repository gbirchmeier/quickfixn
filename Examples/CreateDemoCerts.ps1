$rootCert = New-SelfSignedCertificate -Subject "CN=quickfixn-CA.demo" -Type Custom -KeyUsage CertSign, CRLSign, DigitalSignature -SuppressOid "2.5.29.37" -KeyLength 2048 -NotAfter (Get-Date).AddDays(3650)

$rootCertPath = "quickfixn-CA.demo.cer"
Export-Certificate -Cert $rootCert -FilePath $rootCertPath

$serverCert = New-SelfSignedCertificate -Subject "CN=qfn-server.demo" -DnsName localhost, 127.0.0.1 -Signer $rootCert -KeyUsage DigitalSignature, KeyEncipherment -TextExtension "2.5.29.37={text}1.3.6.1.5.5.7.3.1" -KeyLength 2048 -NotAfter (Get-Date).AddDays(3650)
$serverCertPath = "qfn-server.demo.pfx"
$password = ConvertTo-SecureString -String "qfnpass123" -Force -AsPlainText
Export-PfxCertificate -Cert $serverCert -FilePath $serverCertPath -Password $password

$clientCert = New-SelfSignedCertificate -Subject "CN=qfn-client.demo" -DnsName localhost, 127.0.0.1 -Signer $rootCert -KeyUsage DigitalSignature, KeyEncipherment -TextExtension "2.5.29.37={text}1.3.6.1.5.5.7.3.2" -KeyLength 2048 -NotAfter (Get-Date).AddDays(3650)
$clientCertPath = "qfn-client.demo.pfx"
$password = ConvertTo-SecureString -String "qfnpass123" -Force -AsPlainText
Export-PfxCertificate -Cert $clientCert -FilePath $clientCertPath -Password $password