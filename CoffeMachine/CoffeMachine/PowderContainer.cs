using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeMachine
{
    class PowderContainer:Container
    {
        public IPowder powder { get; private set; }


        public PowderContainer(IPowder powder, int max) : base(max)
        {
            this.powder = powder;
        }
    }
}
