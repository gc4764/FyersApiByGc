using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary.Logger
{
    public class ConsoleLogger : ILogger
    {
        public void AttachLogger(ILog ilog)
        {
            ilog.SetLogger(this);
        }

        public void Debug(string message)
        {
            ConsoleColor fc = Console.ForegroundColor;
            ConsoleColor bc = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Debug : {message}");
            Console.BackgroundColor = bc;
            Console.ForegroundColor = fc;
        }

        public void Error(string message)
        {
            ConsoleColor fc = Console.ForegroundColor;
            ConsoleColor bc = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Error : {message}");
            Console.BackgroundColor = bc;
            Console.ForegroundColor = fc;
        }

        public void Fatal(string message)
        {
            ConsoleColor fc = Console.ForegroundColor;
            ConsoleColor bc = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Fatal : {message}");
            Console.BackgroundColor = bc;
            Console.ForegroundColor = fc;
        }

        public void Fatal(string message, Exception exception)
        {
            ConsoleColor fc = Console.ForegroundColor;
            ConsoleColor bc = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Fatal : {message}");
            Console.BackgroundColor = bc;
            Console.ForegroundColor = fc;
        }

        public void Info(string message)
        {
            ConsoleColor fc = Console.ForegroundColor;
            ConsoleColor bc = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Info : {message}");
            Console.BackgroundColor = bc;
            Console.ForegroundColor = fc;
        }

        public void Log(string message)
        {
            ConsoleColor fc = Console.ForegroundColor;
            ConsoleColor bc = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Log : {message}");
            Console.BackgroundColor = bc;
            Console.ForegroundColor = fc;
        }

        public void SetLoggerName(string loggerName)
        {
            ConsoleColor fc = Console.ForegroundColor;
            ConsoleColor bc = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(loggerName);
            Console.BackgroundColor = bc;
            Console.ForegroundColor = fc;
        }

        public void TestLogger()
        {
            Log("Hello Guddu log");
            Info("Hello Guddu info");
            Debug("Hello Guddu debug");
            Error("Hello Guddu error");
            Fatal("Hello Guddu fatal");
            Warn("Hello Guddu warn");
        }

        public void Warn(string message)
        {
            ConsoleColor fc = Console.ForegroundColor;
            ConsoleColor bc = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Warn : {message}");
            Console.BackgroundColor = bc;
            Console.ForegroundColor = fc;
        }


    }

       


   
}
