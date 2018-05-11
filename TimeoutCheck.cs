using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TOEC_Common
{
    /// <summary>
    /// 工作流超时设置
    /// 朱恒
    /// 2018-03-16
    /// </summary>
    public class TimeoutCheck : IDisposable
    {
        public TimeoutCheck(TimeSpan ts)
        {
            total = ts.TotalSeconds;
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    if (total >= 0)
                    {
                        total -= 1;
                        Thread.Sleep(1000);
                    }
                    else { break; }
                }
            });
        }

        /// <summary>
        /// 总限时
        /// </summary>
        private double total { get; set; }

        /// <summary>
        /// 检测是否超时
        /// </summary>
        public void CheckTime()
        {
            if (total <= 0) { throw new TimeoutException("Time is out!"); }
        }

        public void Dispose() { }
    }
}
