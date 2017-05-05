using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Common.Cache
{
    public class CacheFactory
    {
        private static ICache _cache;
        /// <summary>
        /// 创建一个新的Logger
        /// </summary>
        /// <returns>创建后的 Logger</returns>
        public static ICache CreateCache()
        {
            return _cache ?? (_cache = new MemoryCache());
            //return (_loggerFactory != null) ? _loggerFactory.Create() : null;
        }
    }
}
