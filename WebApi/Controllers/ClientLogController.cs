using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LogServer.BLL;
using LogServer.Common;
using LogServer.Model.Dto;
using LogServer.Model.Entity;
using LogServer.WebApi.Extensions;
using LogServer.WebApi.Models;

namespace LogServer.WebApi.Controllers
{
    public class ClientLogController : ApiController
    {
        private readonly ClientLogService _LogService;

        public ClientLogController()                                   
        {
            _LogService=new ClientLogService();
        }

        [HttpPost]
        [ModelValid]
        [IdAuth]
        public ResultMessage Submit(ClientLogRequestModel model)
        {
            try
            {
                var appKeyId= Request.GetAppKeyId();
                _LogService.SubmitLog(appKeyId,model.IsDebug,model.LogTag,model.LogInfo,model.LogSrcInfo, model.ClientInfo, model.Remark);
                return new ResultMessage(StateCode.Success, "提交成功");
            }
            catch (NeedToShowFrontException e)
            {
                return new ResultMessage(StateCode.Fail, e.Message);
            }
        }

        [HttpPost]
        [ModelValid]
        public ResultMessage<ListResponseModel<ClientLogResponseModel>> GetLogs(ClientLogListRequestModel model)
        {
            try
            {
                var dtos=_LogService.GetAlLogs(model.PageIndex,model.PageSize, model.AppkeyId);
                var list = dtos.Select(x => new ClientLogResponseModel(x)).ToList();
                var response = new ListResponseModel<ClientLogResponseModel>(list)
                {
                    PageIndex = dtos.PageIndex,
                    PageSize = dtos.PageSize,
                    TotalRecord = dtos.TotalCount,
                    TotalPages = dtos.TotalPages,
                    HasPreviousPage = dtos.HasPreviousPage,
                    HasNextPage = dtos.HasNextPage
                };
                return new ResultMessage<ListResponseModel<ClientLogResponseModel>>(response);
            }
            catch (NeedToShowFrontException e)
            {
                return new ResultMessage<ListResponseModel<ClientLogResponseModel>>(StateCode.Fail, e.Message);
            }
        }
    }
}
