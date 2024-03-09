using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary.Logger
{
    public interface IGCLogger
    {
        IGCLogger SetLoggerName(string loggerName);

        IGCLogger Logger { get; set; }

        IGCLogger Info(object message);
        IGCLogger Warn(object message);
        IGCLogger Error(object message);
        IGCLogger Fatal(object message);
        IGCLogger Debug(object message);
        IGCLogger Fatal(object message, Exception exception);
        IGCLogger Log(object message);

        IGCLogger TestLogger();
    }
}
