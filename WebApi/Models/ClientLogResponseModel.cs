using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LogServer.Model.Dto;

namespace LogServer.WebApi.Models
{
    public class ClientLogResponseModel
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

        public ClientLogResponseModel()
        {

        }

        public ClientLogResponseModel(ClientLogDto dto)
        {
            LogTag = dto.LogTag;
            LogInfo = dto.LogInfo;
            LogSrcInfo = dto.LogSrcInfo;
            ClientInfo = dto.ClientInfo;
            State = dto.State;
            Remark = dto.Remark;
        }
    }
}