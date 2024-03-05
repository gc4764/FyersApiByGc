using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Models
{
    public class ExchangeSegmentModel
    {
        public bool? NseCash { get; set; }
        public bool? NseCurrncy { get; set; }
        public bool? NseFuture { get; set; }
        public bool? NseOption { get; set; }
        public bool? Bsecash { get; set; }
        public bool? BseFuture { get; set; }
        public bool? BseOption { get; set; }
        public bool? McxFuture { get; set; }
        public bool? McxOption { get; set; }

    }
}
