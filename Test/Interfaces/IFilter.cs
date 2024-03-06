﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Interfaces
{
    public interface IFilter
    {
        FilterResponse Result { get;  }
        FilterResponse RunFilter();
    }
}
