using System.Security.Cryptography;

byte[] rsaprivatekey;
byte[] rsapublickey;

using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(2048))
{
  rsaprivatekey = RSA.ExportPkcs8PrivateKey();
  rsapublickey = RSA.ExportRSAPublicKey();
}

using (FileStream fileStream = new("privatekey.pem", FileMode.Create))
{
  fileStream.Write(rsaprivatekey, 0, rsaprivatekey.Length);
}

using (FileStream fileStream = new("publickey.pem", FileMode.Create))
{
	
	fileStream.Write(rsapublickey, 0, rsapublickey.Length);
}