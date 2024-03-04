namespace RMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            LongTrade longTrade = new(100, 0, 120, 5, 15,10,30, "test");

            longTrade.Printdata();
 
        }
    }
}
