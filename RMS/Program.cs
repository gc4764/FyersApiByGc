namespace RMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            LongTrade longTrade = new(100, 80, 120, 5, 15, "test");

            longTrade.Printdata();
 
        }
    }
}
