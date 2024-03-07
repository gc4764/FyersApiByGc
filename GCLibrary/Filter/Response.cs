using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary.Filter
{
    public class Response
    {
        private Response(bool success, string message, string error)
        {
            Success = success;
            Message = message;
            Error = error;
        }

        private Response() { }

        public class ResponseBuilder
        {
            public static Response SetSuccess(string message)
            {
                Response response = new(true, message, "");
                return response;
            }
            public static Response SetError(string error)
            {
                Response response= new(false, "",error);
                return response;
            }
        }

        public bool Success { get; private set; }
        public string Message { get; private set; } = string.Empty;
        public string Error { get; private set; } = string.Empty;


      
    }
}
