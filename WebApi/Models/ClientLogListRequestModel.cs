using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogServer.WebApi.Models
{
    public class ClientLogListRequestModel:BaseListRequestModel
    {
        /// <summary>
        /// 应用编号
        /// </summary>
        public string AppkeyId { set; get; }
    }
}