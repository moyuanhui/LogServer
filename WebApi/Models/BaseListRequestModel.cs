using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogServer.WebApi.Models
{
    public class BaseListRequestModel
    {
        /// <summary>
        /// 当前页
        /// </summary>
        public int PageIndex { set; get; }
        /// <summary>
        /// 分页大小
        /// </summary>
        public int PageSize { set; get; }
    }
    /// <summary>
    /// 列表响应实例
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ListResponseModel<T>
    {
        /// <summary>
        /// 当前页号
        /// </summary>
        public int PageIndex { set; get; }
        /// <summary>
        /// 当前页大小
        /// </summary>
        public int PageSize { set; get; }
        /// <summary>
        /// 总记录数
        /// </summary>
        public int TotalRecord { set; get; }
        /// <summary>
        /// 总页数
        /// </summary>
        public int TotalPages { set; get; }
        /// <summary>
        /// 是否有上一页
        /// </summary>
        public bool HasPreviousPage { set; get; }
        /// <summary>
        /// 是否有下一页
        /// </summary>
        public bool HasNextPage { set; get; }
        /// <summary>
        /// 列表
        /// </summary>
        public List<T> List { set; get; }
        /// <summary>
        /// data构造函数
        /// </summary>
        /// <param name="data"></param>
        public ListResponseModel(List<T> data)
        {
            List = data;
        }
        /// <summary>
        /// 无参构造
        /// </summary>
        public ListResponseModel()
        {

        }
    }
}