using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Timers;

namespace TOEC_Common
{
    /// <summary>
    /// 各种日志 O(∩_∩)O
    /// </summary>
    public class Log
    {
        /// <summary>
        /// 通用日志
        /// </summary>
        public static ILog logsys = LogManager.GetLogger("Log_Sys");

        /// <summary>
        /// 基础服务：串口日志
        /// </summary>
        public static ILog logcom = LogManager.GetLogger("Log_COM");
        /// <summary>
        /// 基础服务：出队列日志
        /// </summary>
        public static ILog logdequeue = LogManager.GetLogger("Log_Dequeue");
        /// <summary>
        /// 基础服务：第三方日志
        /// </summary>
        public static ILog log3rdParty = LogManager.GetLogger("Log_3rdParty");
        /// <summary>
        /// 导出服务日志
        /// </summary>
        public static ILog log_Export = LogManager.GetLogger("log_Export");
    }
}
