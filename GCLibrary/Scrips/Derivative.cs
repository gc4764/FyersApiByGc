using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary.Scrips
{
    public class Derivative : Scrip
    {
        public Scrip UnderLyingScrip { get; set; } = new Scrip();

        public string Expiry { get; set; } = string.Empty;



    }
}
