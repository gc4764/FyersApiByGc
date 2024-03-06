using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GCLibrary.Filter;

namespace GCLibrary.Interfaces
{
    public interface IFilter
    {
        FilterResponse Result { get; }
        FilterResponse RunFilter();
    }
}
