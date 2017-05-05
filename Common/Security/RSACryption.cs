using System; 
using System.Text; 
using System.Security.Cryptography; 
namespace SXH.Infrastructure.Common.Security
{ 
	/// <summary> 
	/// RSA加密解密及RSA签名和验证
	/// </summary> 
	public class RSACryption 
	{ 		
		public RSACryption() 
		{ 			
		} 
		

		#region RSA 加密解密 

		#region RSA 的密钥产生 
	
		/// <summary>
		/// RSA 的密钥产生 产生私钥 和公钥 
		/// </summary>
		/// <param name="xmlKeys"></param>
		/// <param name="xmlPublicKey"></param>
		public void RSAKey(out string xmlKeys,out string xmlPublicKey) 
		{ 			
				System.Security.Cryptography.RSACryptoServiceProvider rsa=new RSACryptoServiceProvider(); 
				xmlKeys=rsa.ToXmlString(true); 
				xmlPublicKey = rsa.ToXmlString(false); 			
		} 
		#endregion 

		#region RSA的加密函数 
		//############################################################################## 
		//RSA 方式加密 
		//说明KEY必须是XML的行式,返回的是字符串 
		//在有一点需要说明！！该加密方式有 长度 限制的！！ 
		//############################################################################## 

		//RSA的加密函数  string
		public string RSAEncrypt(string xmlPublicKey,string mStrEncryptString ) 
		{
		    RSACryptoServiceProvider rsa=new RSACryptoServiceProvider(); 
			rsa.FromXmlString(xmlPublicKey); 
			var plainTextBArray = (new UnicodeEncoding()).GetBytes(mStrEncryptString); 
			var cypherTextBArray = rsa.Encrypt(plainTextBArray, false); 
			var result = Convert.ToBase64String(cypherTextBArray); 
			return result; 
			
		} 
		//RSA的加密函数 byte[]
		public string RSAEncrypt(string xmlPublicKey,byte[] encryptString ) 
		{
		    RSACryptoServiceProvider rsa=new RSACryptoServiceProvider(); 
			rsa.FromXmlString(xmlPublicKey); 
			var cypherTextBArray = rsa.Encrypt(encryptString, false); 
			var result = Convert.ToBase64String(cypherTextBArray); 
			return result; 
			
		} 
		#endregion 

		#region RSA的解密函数 
		//RSA的解密函数  string
		public string RSADecrypt(string xmlPrivateKey, string mStrDecryptString ) 
		{
		    System.Security.Cryptography.RSACryptoServiceProvider rsa=new RSACryptoServiceProvider(); 
			rsa.FromXmlString(xmlPrivateKey); 
			var plainTextBArray = Convert.FromBase64String(mStrDecryptString); 
			var dypherTextBArray = rsa.Decrypt(plainTextBArray, false); 
			var result = (new UnicodeEncoding()).GetString(dypherTextBArray); 
			return result; 
			
		} 

		//RSA的解密函数  byte
		public string RSADecrypt(string xmlPrivateKey, byte[] decryptString ) 
		{
		    System.Security.Cryptography.RSACryptoServiceProvider rsa=new RSACryptoServiceProvider(); 
			rsa.FromXmlString(xmlPrivateKey); 
			var dypherTextBArray = rsa.Decrypt(decryptString, false); 
			var result = (new UnicodeEncoding()).GetString(dypherTextBArray); 
			return result; 
			
		} 
		#endregion 

		#endregion 

		#region RSA数字签名 

		#region 获取Hash描述表 
		//获取Hash描述表 
		public bool GetHash(string mStrSource, ref byte[] hashData) 
		{ 			
			//从字符串中取得Hash描述 
		    System.Security.Cryptography.HashAlgorithm md5 = System.Security.Cryptography.HashAlgorithm.Create("MD5"); 
			var buffer = System.Text.Encoding.GetEncoding("GB2312").GetBytes(mStrSource); 
			hashData = md5.ComputeHash(buffer); 

			return true; 			
		} 

		//获取Hash描述表 
		public bool GetHash(string mStrSource, ref string strHashData) 
		{
		    if (strHashData == null) throw new ArgumentNullException(nameof(strHashData));

		    //从字符串中取得Hash描述 
		    System.Security.Cryptography.HashAlgorithm md5 = System.Security.Cryptography.HashAlgorithm.Create("MD5"); 
			var buffer = System.Text.Encoding.GetEncoding("GB2312").GetBytes(mStrSource); 
			var hashData = md5.ComputeHash(buffer); 

			strHashData = Convert.ToBase64String(hashData); 
			return true; 
			
		} 

		//获取Hash描述表 
		public bool GetHash(System.IO.FileStream objFile, ref byte[] hashData) 
		{ 
			
			//从文件中取得Hash描述 
			System.Security.Cryptography.HashAlgorithm md5 = System.Security.Cryptography.HashAlgorithm.Create("MD5"); 
			hashData = md5.ComputeHash(objFile); 
			objFile.Close(); 

			return true; 
			
		} 

		//获取Hash描述表 
		public bool GetHash(System.IO.FileStream objFile, ref string strHashData) 
		{ 
			
			//从文件中取得Hash描述 
		    System.Security.Cryptography.HashAlgorithm md5 = System.Security.Cryptography.HashAlgorithm.Create("MD5"); 
			var hashData = md5.ComputeHash(objFile); 
			objFile.Close(); 

			strHashData = Convert.ToBase64String(hashData); 

			return true; 
			
		} 
		#endregion 

		#region RSA签名 
		//RSA签名 
		public bool SignatureFormatter(string pStrKeyPrivate, byte[] hashbyteSignature, ref byte[] encryptedSignatureData) 
		{ 
			
				System.Security.Cryptography.RSACryptoServiceProvider rsa = new System.Security.Cryptography.RSACryptoServiceProvider(); 

				rsa.FromXmlString(pStrKeyPrivate); 
				System.Security.Cryptography.RSAPKCS1SignatureFormatter rsaFormatter = new System.Security.Cryptography.RSAPKCS1SignatureFormatter(rsa); 
				//设置签名的算法为MD5 
				rsaFormatter.SetHashAlgorithm("MD5"); 
				//执行签名 
				encryptedSignatureData = rsaFormatter.CreateSignature(hashbyteSignature); 

				return true; 
			
		} 

		//RSA签名 
		public bool SignatureFormatter(string pStrKeyPrivate, byte[] hashbyteSignature, ref string mStrEncryptedSignatureData) 
		{
		        System.Security.Cryptography.RSACryptoServiceProvider rsa = new System.Security.Cryptography.RSACryptoServiceProvider(); 

				rsa.FromXmlString(pStrKeyPrivate); 
				System.Security.Cryptography.RSAPKCS1SignatureFormatter rsaFormatter = new System.Security.Cryptography.RSAPKCS1SignatureFormatter(rsa); 
				//设置签名的算法为MD5 
				rsaFormatter.SetHashAlgorithm("MD5"); 
				//执行签名 
				var encryptedSignatureData = rsaFormatter.CreateSignature(hashbyteSignature); 

				mStrEncryptedSignatureData = Convert.ToBase64String(encryptedSignatureData); 

				return true; 
			
		} 

		//RSA签名 
		public bool SignatureFormatter(string pStrKeyPrivate, string mStrHashbyteSignature, ref byte[] encryptedSignatureData) 
		{
		        var hashbyteSignature = Convert.FromBase64String(mStrHashbyteSignature); 
				System.Security.Cryptography.RSACryptoServiceProvider rsa = new System.Security.Cryptography.RSACryptoServiceProvider(); 

				rsa.FromXmlString(pStrKeyPrivate); 
				System.Security.Cryptography.RSAPKCS1SignatureFormatter rsaFormatter = new System.Security.Cryptography.RSAPKCS1SignatureFormatter(rsa); 
				//设置签名的算法为MD5 
				rsaFormatter.SetHashAlgorithm("MD5"); 
				//执行签名 
				encryptedSignatureData = rsaFormatter.CreateSignature(hashbyteSignature); 

				return true; 
			
		} 

		//RSA签名 
		public bool SignatureFormatter(string pStrKeyPrivate, string mStrHashbyteSignature, ref string mStrEncryptedSignatureData) 
		{
		        var hashbyteSignature = Convert.FromBase64String(mStrHashbyteSignature); 
				System.Security.Cryptography.RSACryptoServiceProvider rsa = new System.Security.Cryptography.RSACryptoServiceProvider(); 

				rsa.FromXmlString(pStrKeyPrivate); 
				System.Security.Cryptography.RSAPKCS1SignatureFormatter rsaFormatter = new System.Security.Cryptography.RSAPKCS1SignatureFormatter(rsa); 
				//设置签名的算法为MD5 
				rsaFormatter.SetHashAlgorithm("MD5"); 
				//执行签名 
				var encryptedSignatureData = rsaFormatter.CreateSignature(hashbyteSignature); 

				mStrEncryptedSignatureData = Convert.ToBase64String(encryptedSignatureData); 

				return true; 
			
		} 
		#endregion 

		#region RSA 签名验证 

		public bool SignatureDeformatter(string pStrKeyPublic, byte[] hashbyteDeformatter, byte[] deformatterData) 
		{ 
			
				System.Security.Cryptography.RSACryptoServiceProvider rsa = new System.Security.Cryptography.RSACryptoServiceProvider(); 

				rsa.FromXmlString(pStrKeyPublic); 
				System.Security.Cryptography.RSAPKCS1SignatureDeformatter rsaDeformatter = new System.Security.Cryptography.RSAPKCS1SignatureDeformatter(rsa); 
				//指定解密的时候HASH算法为MD5 
				rsaDeformatter.SetHashAlgorithm("MD5"); 

				if(rsaDeformatter.VerifySignature(hashbyteDeformatter,deformatterData)) 
				{ 
					return true; 
				} 
				else 
				{ 
					return false; 
				} 
			
		} 

		public bool SignatureDeformatter(string pStrKeyPublic, string pStrHashbyteDeformatter, byte[] deformatterData) 
		{ 
			
				byte[] HashbyteDeformatter; 

				HashbyteDeformatter = Convert.FromBase64String(pStrHashbyteDeformatter); 

				System.Security.Cryptography.RSACryptoServiceProvider rsa = new System.Security.Cryptography.RSACryptoServiceProvider(); 

				rsa.FromXmlString(pStrKeyPublic); 
				System.Security.Cryptography.RSAPKCS1SignatureDeformatter rsaDeformatter = new System.Security.Cryptography.RSAPKCS1SignatureDeformatter(rsa); 
				//指定解密的时候HASH算法为MD5 
				rsaDeformatter.SetHashAlgorithm("MD5"); 

				if(rsaDeformatter.VerifySignature(HashbyteDeformatter,deformatterData)) 
				{ 
					return true; 
				} 
				else 
				{ 
					return false; 
				} 
			
		} 

		public bool SignatureDeformatter(string pStrKeyPublic, byte[] hashbyteDeformatter, string pStrDeformatterData) 
		{
		        System.Security.Cryptography.RSACryptoServiceProvider rsa = new System.Security.Cryptography.RSACryptoServiceProvider(); 

				rsa.FromXmlString(pStrKeyPublic); 
				System.Security.Cryptography.RSAPKCS1SignatureDeformatter rsaDeformatter = new System.Security.Cryptography.RSAPKCS1SignatureDeformatter(rsa); 
				//指定解密的时候HASH算法为MD5 
				rsaDeformatter.SetHashAlgorithm("MD5"); 

				var deformatterData = Convert.FromBase64String(pStrDeformatterData); 

				if(rsaDeformatter.VerifySignature(hashbyteDeformatter,deformatterData)) 
				{ 
					return true; 
				} 
				else 
				{ 
					return false; 
				} 
			
		} 

		public bool SignatureDeformatter(string pStrKeyPublic, string pStrHashbyteDeformatter, string pStrDeformatterData) 
		{
		        var hashbyteDeformatter = Convert.FromBase64String(pStrHashbyteDeformatter); 
				System.Security.Cryptography.RSACryptoServiceProvider rsa = new System.Security.Cryptography.RSACryptoServiceProvider(); 

				rsa.FromXmlString(pStrKeyPublic); 
				System.Security.Cryptography.RSAPKCS1SignatureDeformatter rsaDeformatter = new System.Security.Cryptography.RSAPKCS1SignatureDeformatter(rsa); 
				//指定解密的时候HASH算法为MD5 
				rsaDeformatter.SetHashAlgorithm("MD5"); 

				var deformatterData = Convert.FromBase64String(pStrDeformatterData); 

				if(rsaDeformatter.VerifySignature(hashbyteDeformatter,deformatterData)) 
				{ 
					return true; 
				} 
				else 
				{ 
					return false; 
				} 
			
		} 


		#endregion 


		#endregion 

	} 
} 
