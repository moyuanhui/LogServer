using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogServer.Model.Entity;

namespace LogServer.Model.Dto
{
    public class ClientLogDto
    {
        /// <summary>
        /// 日志标记
        /// </summary>
        public string LogTag { set; get; }

        /// <summary>
        /// 日志信息
        /// </summary>
        public string LogInfo { set; get; }

        /// <summary>
        /// 日记来源信息
        /// </summary>
        public string LogSrcInfo { set; get; }
        /// <summary>
        /// 客户端信息
        /// </summary>
        public string ClientInfo { set; get; }
        /// <summary>
        /// 日志状态
        /// </summary>
        public int State { set; get; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        public ClientLogDto()
        {

        }

        public ClientLogDto(ClientLog entity)
        {
            LogTag = entity.LogTag;
            LogInfo = entity.LogInfo;
            LogSrcInfo = entity.LogSrcInfo;
            ClientInfo = entity.ClientInfo;
            State = entity.State;
            Remark = entity.Remark;
        }
    }
}
