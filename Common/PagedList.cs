using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Common
{
    public class PagedList<TEntity> : List<TEntity>, IPagedList<TEntity>
    {
        public PagedList(IQueryable<TEntity> queryable, int pageIndex, int pageSize)
        {
            int total = queryable.Count();
            this.TotalCount = total;
            this.TotalPages = total / pageSize;

            if (total % pageSize > 0)
                TotalPages++;

            this.PageSize = pageSize;
            this.PageIndex = pageIndex;
            this.AddRange(queryable.Skip(pageIndex * pageSize).Take(pageSize).ToList());
        }
        public PagedList(IEnumerable<TEntity> enumerable, int pageIndex, int pageSize, int totalCount)
        {
            TotalCount = totalCount;
            TotalPages = TotalCount / pageSize;

            if (TotalCount % pageSize > 0)
                TotalPages++;

            this.PageSize = pageSize;
            this.PageIndex = pageIndex;
            this.AddRange(enumerable);
        }
        public IPagedList<T> ConvertData<T>(IEnumerable<T> enumerable)
        {
            return new PagedList<T>(enumerable, this.PageIndex, this.PageSize, this.TotalCount);
        }
        public int PageIndex { set; get; }
        public int PageSize { set; get; }
        public int TotalCount { set; get; }
        public int TotalPages { set; get; }

        public bool HasPreviousPage => (PageIndex > 0);

        public bool HasNextPage => (PageIndex + 1 < TotalPages);
    }
}
