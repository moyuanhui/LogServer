using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace LogServer.WebApi.Extensions
{
    public static class HttpExtensions
    {
        public static string GetAppKeyId(this HttpRequestMessage request)
        {
            if (request.Properties.ContainsKey("AppKeyID"))
            {
                var value = request.Properties["AppKeyID"];
                var s = value as string;
                return s ?? "";
            }
            return "";
        }
    }
}