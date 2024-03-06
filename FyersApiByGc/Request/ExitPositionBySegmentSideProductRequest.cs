using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FyersApiClient.Request
{
    
    public class ExitPositionBySegmentSideProductRequest
    {
        public List<int> segment { get; set; }
        public List<int> side { get; set; }
        public List<string> productType { get; set; }
    }

}
