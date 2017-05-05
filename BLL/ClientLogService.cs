using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogServer.Common;
using LogServer.Common.Validator;
using LogServer.Model;
using LogServer.Model.Dto;
using LogServer.Model.Entity;

namespace LogServer.BLL
{
    public class ClientLogService: BasicService<ClientLog>
    {
        public ClientLogService()
        {
        
        }

        public void SubmitLog(string appKeyId,bool isDebug, string logTag,string logInfo,string logSrcInfo, string clientInfo,string remark)
        {
            var model = new ClientLog()
            {
                Id = NewId.NewSecuentialGuid(),
                AppKeyId = appKeyId,
                IsDebug = isDebug,
                ClientInfo = clientInfo,
                LogTag = logTag,
                LogInfo = logInfo,
                State = 0,
                Remark = remark,
                AddTime = DateTime.Now
            };
            var validator = EntityValidatorFactory.CreateValidator();
            if (!validator.IsValid(model))
                throw new NeedToShowFrontException("输入不合法");
            Add(model);
        }
        public IPagedList<ClientLogDto> GetAlLogs(int pageIndex, int pageSize,string appKeyId)
        {
            var query= GetList(pageIndex, pageSize,x=>x.AppKeyId== appKeyId, x => x.AddTime, true);
            var list = query.Select(x => new ClientLogDto(x)).ToList();
            return query.ConvertData(list);
        }
    }
}
