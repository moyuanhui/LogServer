using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;

namespace LogServer.Common
{
    public static class CommonExtension
    {
        /// <summary>
        /// MD5
        /// </summary>
        /// <param name="text"></param>
        /// <returns>加密后的字符串</returns>
        public static string MD5Encryption(this string text)
        {
            return BitConverter.ToString(System.Security.Cryptography.MD5.Create().ComputeHash(Encoding.Default.GetBytes(text))).Replace("-", "");
        }
        /// <summary>
        /// 哈希算法 SHA1
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string SHA1(this string text)
        {
            byte[] cleanBytes = Encoding.Default.GetBytes(text);
            byte[] hashedBytes = System.Security.Cryptography.SHA1.Create().ComputeHash(cleanBytes);
            return BitConverter.ToString(hashedBytes).Replace("-", "");
        }
        /// <summary>
        /// 判断GUID值是否存在 存在返回true
        /// </summary>
        /// <param name="thiGuid"></param>
        /// <returns></returns>
        public static bool HasGuidValue(this Guid thiGuid)
        {
            return !string.IsNullOrEmpty(thiGuid.ToString()) && thiGuid != Guid.Empty;
        }
        /// <summary>
        /// 判断GUID值是否存在 存在返回true
        /// </summary>
        /// <param name="thiGuid"></param>
        /// <returns></returns>
        public static bool HasGuidValue(this Guid? thiGuid)
        {
            return !string.IsNullOrEmpty(thiGuid.ToString()) && thiGuid != Guid.Empty;
        }
        /// <summary>
        /// 获取 \bin 目录的物理路径
        /// </summary>
        /// <param name="appDomain">AppDomain</param>
        /// <returns>物理路径. "c:\inetpub\wwwroot\bin"</returns>
        public static string GetBinDirectory(this AppDomain appDomain)
        {
            if (HostingEnvironment.IsHosted)
            {
                //hosted
                return HttpRuntime.BinDirectory;
            }
            else
            {
                //not hosted. For example, run either in unit tests
                return AppDomain.CurrentDomain.BaseDirectory;
            }
        }
        /// <summary>
        ///DateTime时间格式转换为Unix时间戳格式 
        /// </summary>
        /// <param name="curTime"></param>
        /// <returns></returns>
        //public static int DateTimeToStamp(this DateTime curTime)
        //{
        //    DateTime defaultTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
        //    var expiration = (curTime - defaultTime).TotalSeconds;
        //    return (int)expiration;
        //}
        ///// <summary>
        ///// 时间戳转为C#格式时间
        ///// </summary>
        ///// <param name="timeStamp"></param>
        ///// <returns></returns>
        //public static DateTime StampToDateTime(this int timeStamp)
        //{
        //    DateTime defaultTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
        //    TimeSpan toNow = new TimeSpan(timeStamp * 10000000);
        //    return defaultTime.Add(toNow);
           
        //}

        /// <summary>
        /// 获取 \bin 的上级物理路径
        /// </summary>
        /// <param name="appDomain">AppDomain</param>
        /// <returns>物理路径. "c:\inetpub\wwwroot"</returns>
        public static string GetBaseDirectory(this AppDomain appDomain)
        {
            var path = AppDomain.CurrentDomain.GetBinDirectory();
            var index = path.IndexOf("\\bin", System.StringComparison.OrdinalIgnoreCase);
            if (index != -1)
            {
                return path.Substring(0, index);
            }
            return string.Empty;
        }
        public static string GetFirstChar(this string c)
        {
            byte[] array = new byte[2];
            array = System.Text.Encoding.Default.GetBytes(c);
            int i = (short)(array[0] - '\0') * 256 + ((short)(array[1] - '\0'));
            if (i < 0xB0A1) return "*";
            if (i < 0xB0C5) return "A";
            if (i < 0xB2C1) return "B";
            if (i < 0xB4EE) return "C";
            if (i < 0xB6EA) return "D";
            if (i < 0xB7A2) return "E";
            if (i < 0xB8C1) return "F";
            if (i < 0xB9FE) return "G";
            if (i < 0xBBF7) return "H";
            if (i < 0xBFA6) return "J";
            if (i < 0xC0AC) return "K";
            if (i < 0xC2E8) return "L";
            if (i < 0xC4C3) return "M";
            if (i < 0xC5B6) return "N";
            if (i < 0xC5BE) return "O";
            if (i < 0xC6DA) return "P";
            if (i < 0xC8BB) return "Q";
            if (i < 0xC8F6) return "R";
            if (i < 0xCBFA) return "S";
            if (i < 0xCDDA) return "T";
            if (i < 0xCEF4) return "W";
            if (i < 0xD1B9) return "X";
            if (i < 0xD4D1) return "Y";
            if (i < 0xD7FA) return "Z";
            return "*";
        }
        #region 生成N位随机数子
        /// <summary>
        /// 生成N位随机数例如N为6返回结果：632856
        /// </summary>
        /// <param name="N">长度N</param>
        /// <returns></returns>
        public static string RandomCode(int N)
        {
            char[] arrChar = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            StringBuilder num = new StringBuilder();
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < N; i++)
            {
                num.Append(arrChar[rnd.Next(0, arrChar.Length)].ToString());
            }
            return num.ToString();
        }
        #endregion
    }
}
