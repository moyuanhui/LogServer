using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogServer.Common;
using LogServer.Common.Logging;
using LogServer.Model.Entity;

namespace LogServer.DAL
{
    public class Repository<TEntity> where TEntity : Entity
    {
        private readonly EfUnitOfWork _unitOfWork;
        public EfUnitOfWork UnitOfWork => _unitOfWork;
        public Repository(EfUnitOfWork unitOfWork)
        {
            if (unitOfWork == (EfUnitOfWork)null)
                throw new ArgumentNullException(nameof(unitOfWork));
            _unitOfWork = unitOfWork;
        }

        private IDbSet<TEntity> _iDSet;

        public IDbSet<TEntity> IDSet => _iDSet ??(_iDSet = _unitOfWork.CreateSet<TEntity>());

        /// <summary>
        /// 添加对象
        /// </summary>
        /// <param name="item"></param>
        public virtual void Add(TEntity item)
        {

            if (item == (TEntity)null)
                throw new NeedToShowFrontException("不能添加空的实体对象");
            IDSet.Add(item);
        }
        /// <summary>
        /// 移除对象
        /// </summary>
        /// <param name="item"></param>
        public virtual void Remove(TEntity item)
        {
            if (item == (TEntity)null)
                throw new NeedToShowFrontException("不能移除空的实体对象");
            //attach item if not exist
            _unitOfWork.Attach(item);

            //set as "removed"
            IDSet.Remove(item);
        }
        /// <summary>
        /// 不修改对象（锁定对象改变不会被提交到数据库）
        /// </summary>
        /// <param name="item"></param>
        public virtual void TrackItem(TEntity item)
        {
            if (item == (TEntity)null)
                throw new NeedToShowFrontException("实体对象为空");
            _unitOfWork.Attach(item);
            
        }
        /// <summary>
        /// 修改对象
        /// </summary>
        /// <param name="item"></param>
        public virtual void Modify(TEntity item)
        {
            if (item == (TEntity)null)
                throw new NeedToShowFrontException("实体对象为空");
            _unitOfWork.SetModified(item);
            
        }
        /// <summary>
        /// 将当前对象赋值到旧对象
        /// </summary>
        /// <param name="original"></param>
        /// <param name="current"></param>
        public virtual void Merge(TEntity original, TEntity current)
        {
            _unitOfWork.ApplyCurrentValues(original, current);
        }
        /// <summary>
        /// 获取对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual TEntity Get(Guid id)
        {
            if (id != Guid.Empty)
                return IDSet.Find(id);
            return null;
        }
        public virtual IEnumerable<TEntity> GetAll()
        {
            return IDSet;
        }
        public virtual IEnumerable<TEntity> Find(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter)
        {
            return IDSet.Where(filter);
        }
        public virtual IEnumerable<TEntity> GetPaged<TKProperty>(int pageIndex, int pageSize, System.Linq.Expressions.Expression<Func<TEntity, TKProperty>> orderByExpression, bool ascending)
        {
            var set = IDSet;

            if (ascending)
            {
                return set.OrderBy(orderByExpression)
                          .Skip(pageSize * pageIndex)
                          .Take(pageSize);
            }
            else
            {
                return set.OrderByDescending(orderByExpression)
                          .Skip(pageSize * pageIndex)
                          .Take(pageSize);
            }
        }
        public virtual PagedList<TEntity> GetPagedList<TKProperty>(int pageIndex, int pageSize, System.Linq.Expressions.Expression<Func<TEntity, TKProperty>> orderByExpression, bool ascending)
        {
            if (ascending)
            {
                var query = IDSet.OrderBy(orderByExpression);
                // 获取总数
                return new PagedList<TEntity>(query, pageIndex, pageSize);
            }
            else
            {
                var   query= IDSet.OrderByDescending(orderByExpression);
                // 获取总数
                return new PagedList<TEntity>(query, pageIndex, pageSize);
            }
        }
        public void Dispose()
        {
            _unitOfWork?.Dispose();
        }
    }
}
