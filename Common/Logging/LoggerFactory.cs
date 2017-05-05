using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Common.Logging
{
    public class LoggerFactory
    {
        private static ILogger _logger;
        /// <summary>
        /// 创建一个新的Logger
        /// </summary>
        /// <returns>创建后的 Logger</returns>
        public static ILogger CreateLog()
        {
            if (_logger == null)
            {
                _logger = new Log4NetLogFactory().Create();
            }
            return _logger;

            //return (_loggerFactory != null) ? _loggerFactory.Create() : null;
        }
    }
}
