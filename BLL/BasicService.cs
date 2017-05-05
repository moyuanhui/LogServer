using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogServer.DAL;
using LogServer.Model.Entity;
using LogServer.Common;

namespace LogServer.BLL
{
    public class BasicService<TEntity> where TEntity : Entity
    {
        private readonly Repository<TEntity> _repository;
        public Repository<TEntity> Repository => _repository;
        public BasicService()
        {
            _repository = new Repository<TEntity>(new DAL.EfUnitOfWork());
        }
        public virtual bool Exists(Guid id)
        {
            return _repository.IDSet.Any(x => x.Id == id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public virtual void Add(TEntity model)
        {
            _repository.Add(model);
            _repository.UnitOfWork.Commit();
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public virtual void Update(TEntity model)
        {
            _repository.Modify(model);
            _repository.UnitOfWork.Commit();
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public virtual void Delete(Guid id)
        {
            var model = _repository.Get(id);
            if (model == null)
                return;
            _repository.Remove(model);
            _repository.UnitOfWork.Commit();
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public virtual TEntity GetModel(Guid id)
        {

            return _repository.Get(id);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public virtual List<TEntity> GetList(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            var query = _repository.IDSet.Where(predicate);
            return query.ToList();
        }
        public virtual IPagedList<TEntity> GetList<TOrderKey>(int pageIndex, int pageSize, System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate, System.Linq.Expressions.Expression<Func<TEntity, TOrderKey>> orderByExpression, bool ascending)
        {
            var query = _repository.IDSet.Where(predicate);
            if (ascending)
            {
                query = query.OrderBy(orderByExpression);
                // 获取总数
            }
            else
            {
                query = query.OrderByDescending(orderByExpression);
            }
            return new PagedList<TEntity>(query, pageIndex, pageSize);
        }
        public virtual IPagedList<TEntity> GetList<TOrderKey>(int pageIndex, int pageSize, System.Linq.Expressions.Expression<Func<TEntity, TOrderKey>> orderByExpression, bool ascending)
        {
            return _repository.GetPagedList(pageIndex, pageSize, orderByExpression, ascending);
        }
    }
}
