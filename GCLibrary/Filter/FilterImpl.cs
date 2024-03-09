using GCLibrary.Logger;
using GCLibrary.Filter;

namespace GCLibrary.Filter
{

    public class FilterImpl(int a, int b, string name) : IFilter
    {
        private readonly int A = a;
        private readonly int B = b;
        /*private string _name = name.ToUpper();*/
        private IGCLogger _logger = new ConsoleLogger();



        public IGCLogger Logger { get { return _logger; } set { _logger = value; } }

        public Response RunFilter()
        {
            _logger.Log(A).Log(B).Log(name);
        
            Response response;
            bool resp = A > B;

            if (resp)
            {
                response = Response.ResponseBuilder.SetSuccess("Success");

            }
            response = Response.ResponseBuilder.SetError("Failed");
            return response;

        }


    }
}
