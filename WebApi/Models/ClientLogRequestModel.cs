using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LogServer.WebApi.Models
{
    public class ClientLogRequestModel
    {
        public bool IsDebug { set; get; }
        /// <summary>
        /// 日志标记
        /// </summary>
        [Required(ErrorMessage = @"日志标记不能为空")]
        [MaxLength(50, ErrorMessage = @"限50字符以内")]
        public string LogTag { set; get; }
        /// <summary>
        /// 日志信息
        /// </summary>
        [Required(ErrorMessage = @"日志信息不能为空")]
        public string LogInfo { set; get; }
        /// <summary>
        /// 来自来源信息 根据客户端自由定义
        /// </summary>
        [MaxLength(200, ErrorMessage = @"限200字符以内")]
        public string LogSrcInfo { set; get; }
        /// <summary>
        /// 客户端信息
        /// </summary>
        [MaxLength(200, ErrorMessage = @"限200字符以内")]
        public string ClientInfo { set; get; }
        /// <summary>
        /// 备注
        /// </summary>
        [MaxLength(200, ErrorMessage = @"限200字符以内")]
        public string Remark { get; set; }
    }
}