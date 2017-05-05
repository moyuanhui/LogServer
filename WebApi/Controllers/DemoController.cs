using LogServer.WebApi.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LogServer.WebApi.Controllers
{
    public class DemoController : ApiController
    {
        [HttpGet]
        public ResultMessage GetTest()
        {
            
            return new ResultMessage(StateCode.Success, "这是一个测试");
        }
    }
}
