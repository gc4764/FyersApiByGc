using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary.Logger
{
    public interface ILogger
    {
        void SetLoggerName(string loggerName);

        void AttachLogger(ILog ilog);
        void AttachLogger(LogBase logBase);
        void Info(string message);
        void Warn(string message);
        void Error(string message);
        void Fatal(string message);
        void Debug(string message);
        void Fatal(string message, Exception exception);
        void Log(string message);

        void TestLogger();
    }
}
