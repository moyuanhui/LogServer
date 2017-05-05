using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace LogServer.WebApi.Extensions
{
    public class ModelValidAttribute: ActionFilterAttribute
    {
        public override void OnActionExecuting(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            if (actionContext.ModelState.IsValid == false)
            {
                //actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest, actionContext.ModelState);
                var msg = "数据验证失败";
                if (actionContext.ModelState.Count > 0)
                {
                    var firstError = actionContext.ModelState.Values.FirstOrDefault();
                    if (firstError != null)
                    {
                        var errorMsg = firstError.Errors[0].ErrorMessage;
                        //不科学，错误信息太详情
                        errorMsg = string.IsNullOrEmpty(errorMsg) ? (actionContext.ModelState.Keys.FirstOrDefault() + "格式不对") : errorMsg;
                        msg = string.Format("{0},{1}", msg, errorMsg);
                    }
                }
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.OK,
                    new ResultMessage(StateCode.Fail, msg));
            }
            base.OnActionExecuting(actionContext);
        }
    }
}