using System;
using System.Security.Cryptography;  
using System.Text;
namespace LogServer.Common.Security
{
    /// <summary>
    /// DES加密/解密类。
    /// Copyright (C) SXH
    /// </summary>
    public class DESEncrypt
    {
        private static readonly string sKey = "wangboyy";//长度为8位，要不报错：指定键的大小对于此算法无效
        public DESEncrypt()
        {
        }

        #region ========加密======== 

        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string Encrypt(string text)
        {
            return Encrypt(text, sKey);
        }
        /// <summary> 
        /// 加密数据 
        /// </summary> 
        /// <param name="text"></param> 
        /// <param name="key"></param> 
        /// <returns></returns> 
        public static string Encrypt(string text, string key)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            var inputByteArray = Encoding.Default.GetBytes(text);
            des.Key = Encoding.ASCII.GetBytes(key);
            des.IV = Encoding.ASCII.GetBytes(key);
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            StringBuilder ret = new StringBuilder();
            foreach (byte b in ms.ToArray())
            {
                ret.AppendFormat("{0:X2}", b);
            }
            return ret.ToString();
        }

        #endregion

        #region ========解密======== 


        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string Decrypt(string text)
        {
            return Decrypt(text, sKey);
        }
        /// <summary> 
        /// 解密数据 
        /// </summary> 
        /// <param name="text"></param> 
        /// <param name="key"></param> 
        /// <returns></returns> 
        public static string Decrypt(string text, string key)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            int len;
            len = text.Length / 2;
            byte[] inputByteArray = new byte[len];
            int x, i;
            for (x = 0; x < len; x++)
            {
                i = Convert.ToInt32(text.Substring(x * 2, 2), 16);
                inputByteArray[x] = (byte)i;
            }
            des.Key = Encoding.ASCII.GetBytes(key);
            des.IV = Encoding.ASCII.GetBytes(key);
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            return Encoding.Default.GetString(ms.ToArray());
        }

        #endregion


    }
}
