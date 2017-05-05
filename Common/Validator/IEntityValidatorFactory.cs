using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Common.Validator
{
    /// <summary>
    /// 实体验证器抽象工厂
    /// </summary>
    public interface IEntityValidatorFactory
    {
        /// <summary>
        /// 创建一个新的实体验证器实例
        /// </summary>
        /// <returns>IEntityValidator的实例</returns>
        IEntityValidator Create();
    }
}
