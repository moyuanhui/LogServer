using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity
{
    public class ClientLog:Entity
    {
        /// <summary>
        /// APPKey
        /// </summary>
        public string AppKeyId { set; get; }
        /// <summary>
        /// 是否是测试状态
        /// </summary>
        public bool IsDebug { set; get; }

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

    }
}
