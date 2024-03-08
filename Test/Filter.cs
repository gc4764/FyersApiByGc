using GCLibrary.Logger;
using GCLibrary.Filter;
namespace Test
{
    public class Filter(int a, int b, string name) : FilterBase(name) ,IFilter, ILogConsumer
    {
        private readonly int A = a;
        private readonly int B = b;
        /*private string _name = name.ToUpper();*/
        private  IGCLogger _logger = new ConsoleLogger();


        public string Name { get { return _name; } set { _name = value.ToUpper(); } }

        public IGCLogger Logger { get { return _logger; } set { _logger = value; }  }

        public Response RunFilter()
        {
            bool resp = A > B;

           
            Response response = GenerateResult(resp);
            return response;

        }

      
    }
}
