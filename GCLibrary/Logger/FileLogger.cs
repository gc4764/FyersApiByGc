using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary.Logger
{
    public class FileLogger : IGCLogger
    {
        public IGCLogger Logger { get { return this; }  set { _ = this; } }

        public void Debug(string message)
        {
            throw new NotImplementedException();
        }

        public void Error(string message)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string message)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string message, Exception exception)
        {
            throw new NotImplementedException();
        }



        public void Info(string message)
        {
            throw new NotImplementedException();
        }

        public void Log(string message)
        {
            throw new NotImplementedException();
        }

        public void SetLogger(string loggerName)
        {
            throw new NotImplementedException();
        }

        public void SetLoggerName(string loggerName)
        {
            throw new NotImplementedException();
        }

        public void TestLogger()
        {
            throw new NotImplementedException();
        }

        public void Warn(string message)
        {
            throw new NotImplementedException();
        }
    }
}
