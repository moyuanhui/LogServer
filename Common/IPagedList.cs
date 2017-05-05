using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Common
{
    public interface IPagedList<TEntity> : IList<TEntity>
    {
        //当前页数
        int PageIndex { get; }
        //当前页大小
        int PageSize { get; }
        //总记录数
        int TotalCount { get; }
        /// <summary>
        /// 总页数数
        /// </summary>
        int TotalPages { get; }
        /// <summary>
        /// 是否有上一页
        /// </summary>
        bool HasPreviousPage { get; }
        /// <summary>
        /// 是否有下一页
        /// </summary>
        bool HasNextPage { get; }
        IPagedList<T> ConvertData<T>(IEnumerable<T> enumerable);
    }
}
