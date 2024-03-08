using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary.Logger
{
    public class BlankLogger : IGCLogger
    {
        public IGCLogger Logger { get { return this; } set { _ = this; } }

        public void Debug(string message) { }

        public void Error(string message) { }

        public void Fatal(string message) { }


        public void Fatal(string message, Exception exception) { }


        public void Info(string message) { }


        public void Log(string message) { }


        public void SetLoggerName(string loggerName) { }

        public void TestLogger() 
        {
            Console.WriteLine("Blank logger is running");
        }

        public void Warn(string message) { }
    
    }
}
