using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary.Logger
{
    public class LogBase
    {
        protected ILogger _logger = new ConsoleLogger();
        public void SetLogger(ILogger logger)
        {
            _logger = logger;
        }
    }
}
