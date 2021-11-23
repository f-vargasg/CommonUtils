using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CommonUtils.Log4NetTb
{
    public enum LogTypes
    {
        FatalLog, ErrorLog, WarnLog, InfoLog, DebugLog
    };

    public class Log4NetManager
    {
        private static readonly ILog _debugLogger;

        private static ILog GetLogger(string logName)
        {
            ILog log = LogManager.GetLogger(logName);
            return log;

        }

        static Log4NetManager()
        {
            //logger names are mentioned in <log4net> section of config file
            // _debugLogger = GetLogger("MyApplicationDebugLog");
            _debugLogger = GetLogger("MyAppLogg");
            
                
        }

        /// <summary>
        /// This method will write log in Log_USERNAME_date{yyyyMMdd}.log file
        /// </summary>
        /// <param name="message"></param>
        public static void WriteDebugLog(string message)
        {
            _debugLogger.DebugFormat(message);

        }


        public static void WriteLog(string message, LogTypes logType)
        {
            switch (logType)
            {
                case LogTypes.FatalLog:
                    _debugLogger.FatalFormat(message);
                    break;
                case LogTypes.ErrorLog:
                    _debugLogger.ErrorFormat(message);
                    break;
                case LogTypes.WarnLog:
                    _debugLogger.WarnFormat(message);
                    break;
                case LogTypes.InfoLog:
                    _debugLogger.InfoFormat(message);
                    break;
                case LogTypes.DebugLog:
                    _debugLogger.DebugFormat(message);
                    break;
                default:
                    break;
            }
        }
    }
}
