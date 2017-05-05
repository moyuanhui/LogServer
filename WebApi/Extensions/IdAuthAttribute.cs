using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Filters;

namespace LogServer.WebApi.Extensions
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    public class IdAuthAttribute: FilterAttribute, IAuthorizationFilter
    {
        public Task<HttpResponseMessage> ExecuteAuthorizationFilterAsync(System.Web.Http.Controllers.HttpActionContext actionContext, System.Threading.CancellationToken cancellationToken, Func<Task<HttpResponseMessage>> continuation)
        {
            if (!string.IsNullOrEmpty(actionContext.Request.GetAppKeyId()))
                return continuation.Invoke();
            var msgobj = new ResultMessage(StateCode.Fail, "身份认证失败，未登录不允许访问");
            var msg = LogServer.Common.Serialized.JsonConvert.SerializeV2(msgobj, true);
            var response = new HttpResponseMessage()
            {

                Content = new StringContent(msg, System.Text.Encoding.UTF8, "application/json"),
                RequestMessage = actionContext.Request,
                StatusCode = HttpStatusCode.Forbidden
                //StatusCode= HttpStatusCode.OK
            };
            return Task.FromResult(response);
        }

        public override bool AllowMultiple => false;
    }
}