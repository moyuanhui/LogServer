using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogServer.WebApi.Extensions
{
    /// <summary>
    /// 结果状态
    /// </summary>
    public enum StateCode
    {
        /// <summary>
        /// 成功
        /// </summary>
        Success = 1,
        /// <summary>
        /// 失败
        /// </summary>
        Fail = -1,
        /// <summary>
        /// 没有数据
        /// </summary>
        NoData = 0,
    }
    /// <summary>
    /// 返回消息类
    /// </summary>
    public class ResultMessage
    {
        /// <summary>
        /// 返回状态码
        /// </summary>
        public StateCode StateCode { set; get; }
        /// <summary>
        /// 状态消息
        /// </summary>
        public string StateMessage { set; get; }
        /// <summary>
        /// 
        /// </summary>
        public ResultMessage()
            : this(StateCode.Fail, string.Empty)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stateCode"></param>
        /// <param name="stateMessage"></param>
        public ResultMessage(StateCode stateCode, string stateMessage)
        {
            this.StateCode = stateCode;
            this.StateMessage = stateMessage;
        }
    }
    /// <summary>
    /// 返回消息 泛型类
    /// </summary>
    /// <typeparam name="T">类型</typeparam>
    public class ResultMessage<T> : ResultMessage
    {
        /// <summary>
        /// 数据对象
        /// </summary>
        public T Data { set; get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        public ResultMessage(T data)
            : this(StateCode.Success, "OK", data)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stateCode"></param>
        /// <param name="stateMessage"></param>
        public ResultMessage(StateCode stateCode, string stateMessage)
        {
            this.StateCode = stateCode;
            this.StateMessage = stateMessage;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stateCode"></param>
        /// <param name="stateMessage"></param>
        /// <param name="data"></param>
        public ResultMessage(StateCode stateCode, string stateMessage, T data)
        {
            this.StateCode = stateCode;
            this.StateMessage = stateMessage;
            Data = data;
        }
    }
}