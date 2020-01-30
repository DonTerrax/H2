using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeMachine
{
     class  Machine
    {
        public bool isPowerOn { get; private set; }

        public void PowerON()
        {
            isPowerOn = true;
        }

        public void PowerOff()
        {
            isPowerOn = false;
        }
    }
}
