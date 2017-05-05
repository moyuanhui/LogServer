using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using LogServer.Common.Logging;

namespace LogServer.WebApi.Extensions
{
    /// <summary>
    /// 身份认证合法
    /// </summary>
    public class AuthenticationHandler : DelegatingHandler
    {
        protected override async System.Threading.Tasks.Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
        {
            var authorization = request.Headers.Authorization;
            if (authorization != null)
            {
                var value = authorization.Parameter;
                try
                {
                    var json= LogServer.Common.Security.DEncrypt.Base64Decrypt(value);
                    var dic= LogServer.Common.Serialized.JsonConvert.Deserialize<Dictionary<string, string>>(json);
                    var appKey = dic["appKey"];
                    var appSecret = dic["appSecret"];
                    var appKeyId = LogServer.Common.Security.DEncrypt.Base64Decrypt(appKey);
                    var secret = LogServer.Common.Security.DEncrypt.Decrypt(appSecret);
                    if (appKey == secret)
                    {
                        
                        request.Properties["AppKeyID"] = appKeyId;
                    }
                }
                catch (Exception ex)
                {
                    // ignored
                }
            }
            return await base.SendAsync(request, cancellationToken);
           
        }
    }
}