using GCLibrary.Logger;
using GCLibrary.Filter;
namespace Test
{
    public class Filter(int a, int b, string name) : FilterBase(name) ,IFilter, ILog
    {
        private readonly int A = a;
        private readonly int B = b;
        /*private string _name = name.ToUpper();*/
        private  ILogger _logger = new ConsoleLogger();


        public string Name { get { return _name; } set { _name = value.ToUpper(); } }

        public Response RunFilter()
        {
            Console.WriteLine();
            bool resp = A > B;

           
            Response response = GenerateResult(resp);
            return response;

        }

        public void SetLogger(ILogger logger)
        {
            _logger = logger;
        }
    }
}
