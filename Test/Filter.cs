using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Interfaces;
using GCLibrary;
using GCLibrary.Logger;
namespace Test
{
    public class Filter(int a, int b, string name) : IFilter
    {
        private readonly int A = a;
        private readonly int B = b;
        private  string _name = name.ToUpper();
        private readonly ILogger _logger= new ConsoleLogger();

        public FilterResponse Result { get; private set; } = new FilterResponse();

        public string Name { get { return _name; }  set { _name = value.ToUpper(); } }



        public FilterResponse RunFilter()
        {
            Console.WriteLine();
            Result = new FilterResponse();

            bool resp = A > B;

            return GenerateResult(resp);

        }

        private FilterResponse GenerateResult(bool resp)
        {

            if (resp)
            {
                _logger.Info($"{_name} is successfull ");
                Result.SetSuccessFull($"{_name} is successfull");
                return Result;
            }
            _logger.Error($"{_name} is Failed");

            Result.SetFail($"{_name} is Failed");
            return Result;

        }
    }




    
}
