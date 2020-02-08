using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeMachine
{
    class Filter
    {
        public PowderContainer container { get; private set; }

        public Filter(IPowder powder,int max)
        {
            container = new PowderContainer(powder,max);
        }
    }
}
