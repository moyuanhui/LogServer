using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LogServer.Common.Unity
{
    public class CookieUtils
    {
        public static System.Web.HttpCookie AddCookie(string cookieName, string cookieValues)
        {
            return AddCookie(cookieName, cookieValues, "/", "", null, true);
        }

        public static System.Web.HttpCookie AddCookie(string cookieName, string cookieValues, string domain)
        {
            return AddCookie(cookieName, cookieValues, "/", domain, null, true);
        }
        public static System.Web.HttpCookie AddCookie(string cookieName, string cookieValues, string domain, int? expiresMinute)
        {
            return AddCookie(cookieName, cookieValues, "/", domain, expiresMinute, true);
        }
        /// <summary>
        /// 添加cookie
        /// </summary>
        /// <param name="cookieName">cookie name</param>
        /// <param name="cookieValues">cookie values</param>
        /// <param name="path">设置访问cookie的虚拟路径，如果""将设置为"/"</param>
        /// <param name="domain">可以访问此cookie的域名比如www.host.com, 或者.host.com所有二级域名都能访问</param>
        /// <param name="expiresMinute">过期分钟数，如果关闭浏览器就过期，设置null</param>
        /// <param name="httpOnly">设置客户端脚本是否可访问cookie</param>
        /// <returns>httpcookie</returns>
        public static System.Web.HttpCookie AddCookie(string cookieName, string cookieValues, string path, string domain, int? expiresMinute, bool httpOnly)
        {
            return Add(cookieName, cookieValues, path, domain, expiresMinute, httpOnly);
        }

        private static System.Web.HttpCookie Add(string cookieName, string cookieValues, string path, string domain, int? expiresMinute, bool httpOnly)
        {
            var values = Security.DEncrypt.Encrypt(cookieValues);
            //values = HttpUtility.HtmlEncode(values);
            var cookie = new System.Web.HttpCookie(cookieName);
            if (!string.IsNullOrEmpty(domain))
            {
                cookie.Domain = domain;
            }
            cookie.Path = string.IsNullOrEmpty(path) ? "/" : path;
            cookie.Value = values;
            cookie.HttpOnly = httpOnly;
            if (expiresMinute != null)
            {
                cookie.Expires = DateTime.UtcNow.AddMinutes(expiresMinute.Value);
            }
            return cookie;
        }

        public static System.Web.HttpCookie RemoveCookie(string cookieName)
        {
            return Add(cookieName, "", "/", "", -1, true);
        }
        public static System.Web.HttpCookie RemoveCookie(string cookieName, string domain)
        {
            return Add(cookieName, "", "/", domain, -1, true);
        }

        public static string GetCookie(HttpRequest currentRequest, string cookieName)
        {
            if (currentRequest != null)
            {
                var v = currentRequest.Cookies[cookieName];
                if (v != null && !string.IsNullOrEmpty(v.Value))
                {
                    return Security.DEncrypt.Decrypt(v.Value);
                }
                else
                {
                    return string.Empty;
                }
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
