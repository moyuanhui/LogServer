using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Common.Validator
{
    /// <summary>
    /// 实体验证器
    /// </summary>
    public interface IEntityValidator
    {
        /// <summary>
        /// 验证实体对象是否有效
        /// </summary>
        /// <typeparam name="TEntity">需要验证的实体对象类型</typeparam>
        /// <param name="item">这个实体对象实例</param>
        /// <returns>如果实体对象验证有效返回true</returns>
        bool IsValid<TEntity>(TEntity item) where TEntity : class;

        /// <summary>
        /// 获取无效的实体对象验证消息
        /// </summary>
        /// <typeparam name="TEntity">实体对象类型</typeparam>
        /// <param name="item">这个实体对象实例</param>
        /// <returns>验证错误消息集合</returns>
        IEnumerable<string> GetInvalidMessage<TEntity>(TEntity item) where TEntity : class;
    }
}
