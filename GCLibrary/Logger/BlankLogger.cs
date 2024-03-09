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

        public IGCLogger Debug(object message) { return this; }

        public IGCLogger Error(object message) { return this; }

        public IGCLogger Fatal(object message) { return this; }


        public IGCLogger Fatal(object message, Exception exception) { return this; }


        public IGCLogger Info(object message) { return this; }


        public IGCLogger Log(object message) { return this; }


        public IGCLogger SetLoggerName(string loggerName) { return this; }

        public IGCLogger TestLogger() 
        {
            Console.WriteLine("Blank logger is running");
            return this;
        }

        public IGCLogger Warn(object message) { return this; }
    
    }
}
