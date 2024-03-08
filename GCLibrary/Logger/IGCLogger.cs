using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary.Logger
{
    public interface IGCLogger
    {
        void SetLoggerName(string loggerName);

        IGCLogger Logger { get; set; }
        
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
