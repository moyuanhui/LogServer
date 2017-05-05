using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Common.Logging
{
    /// <summary>
    /// A log4 Source base, log factory
    /// </summary>
    public class Log4NetLogFactory
    {
        /// <summary>
        /// Create the log4 source log
        /// </summary>
        /// <returns>New ILog based on Trace Source infrastructure</returns>
        public ILogger Create()
        {
            //TODO:Logger4Net path setting
            var configurePath = Path.Combine(AppDomain.CurrentDomain.GetBaseDirectory(), "log4net.config");
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new System.IO.FileInfo(configurePath));

            //_log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            var log = log4net.LogManager.GetLogger("logerror");
            //log.Info("Log4NetLogFactory创建logger成功hashcode:" + log.GetHashCode() + "配置文件路径:" + configurePath);

            return new Log4NetLog(log);
        }
    }
}
