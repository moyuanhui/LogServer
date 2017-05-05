using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Common.Validator
{
    public class EntityValidatorFactory
    {
        private static IEntityValidatorFactory _factory = null;

        static EntityValidatorFactory()
        {
            _factory= new DataAnnotationsEntityValidatorFactory();
        }

        /// <summary>
        /// 创建当前实体验证器实例
        /// </summary>
        /// <returns>IEntityValidator</returns>
        public static IEntityValidator CreateValidator()
        {
            return _factory?.Create();
        }
    }
}
