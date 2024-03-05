using GCLibrary.Logger;

namespace ApiBridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            logger.Log("Hello Guddu log");
            logger.Info("Hello Guddu info");
            logger.Debug("Hello Guddu debug");
            logger.Error("Hello Guddu error");
            logger.Fatal("Hello Guddu fatal");
            logger.Warn("Hello Guddu warn");
        }
    }
}
