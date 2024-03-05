using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Models
{
    public class WhiteListModel
    {
        public int Id { get; set; }
        public string? Exchange { get; set; }
        public string? ScripName { get; set; }
        public string? Series { get; set; }
    }
}
