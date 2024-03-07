using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary.Logger
{
    public interface ILog
    {
        void SetLogger(ILogger logger);
    }
}
