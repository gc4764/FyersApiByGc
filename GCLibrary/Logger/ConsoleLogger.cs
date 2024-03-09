using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary.Logger
{
    public class ConsoleLogger : IGCLogger
    {
 
        public  IGCLogger Logger { get { return this; } set { _ = this; } }

        public IGCLogger Debug(object message)
        {
            ConsoleColor fc = Console.ForegroundColor;
            ConsoleColor bc = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Debug : {message}");
            Console.BackgroundColor = bc;
            Console.ForegroundColor = fc;
            return this;    
        }

        public IGCLogger Error(object message)
        {
            ConsoleColor fc = Console.ForegroundColor;
            ConsoleColor bc = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Error : {message}");
            Console.BackgroundColor = bc;
            Console.ForegroundColor = fc;
            return this;
        }

        public IGCLogger Fatal(object message)
        {
            ConsoleColor fc = Console.ForegroundColor;
            ConsoleColor bc = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Fatal : {message}");
            Console.BackgroundColor = bc;
            Console.ForegroundColor = fc;
            return this;
        }

        public IGCLogger Fatal(object message, Exception exception)
        {
            ConsoleColor fc = Console.ForegroundColor;
            ConsoleColor bc = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Fatal : {message}");
            Console.BackgroundColor = bc;
            Console.ForegroundColor = fc;
            return this;
        }

        public IGCLogger Info(object message)
        {
            ConsoleColor fc = Console.ForegroundColor;
            ConsoleColor bc = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Info : {message}");
            Console.BackgroundColor = bc;
            Console.ForegroundColor = fc;
            return this ;
        }

        public IGCLogger Log(object message)
        {
            ConsoleColor fc = Console.ForegroundColor;
            ConsoleColor bc = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Log : {message}");
            Console.BackgroundColor = bc;
            Console.ForegroundColor = fc;
            return this ;
        }

        public IGCLogger SetLoggerName(string loggerName)
        {
            ConsoleColor fc = Console.ForegroundColor;
            ConsoleColor bc = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(loggerName);
            Console.BackgroundColor = bc;
            Console.ForegroundColor = fc;
            return this;    
        }

        public IGCLogger TestLogger()
        {
            Log("Hello Guddu log");
            Info("Hello Guddu info");
            Debug("Hello Guddu debug");
            Error("Hello Guddu error");
            Fatal("Hello Guddu fatal");
            Warn("Hello Guddu warn");
            return this;
        }

        public IGCLogger Warn(object message)
        {
            ConsoleColor fc = Console.ForegroundColor;
            ConsoleColor bc = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Warn : {message}");
            Console.BackgroundColor = bc;
            Console.ForegroundColor = fc;
                return this;
        }


    }

       


   
}
