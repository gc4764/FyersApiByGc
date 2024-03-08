using GCLibrary.Filter;
using GCLibrary.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GCLibrary.Filter
{
    public abstract class FilterBase
    {
        protected string _name;
        protected FilterBase(string name)
        {
            _name = name.ToUpper();
        }
        protected Response GenerateResult(bool resp)
        {

            IGCLogger _logger = new ConsoleLogger();
            Response response;

            if (resp)
            {
                
                _logger.Info($"{_name} is Success");
                response = Response.ResponseBuilder.SetSuccess($"{_name} is Success");
                return response;
            }
            _logger.Error($"{_name} is Failed");
            response = Response.ResponseBuilder.SetError($"{_name} is Failed ");
            return response;
        }
    }
}


