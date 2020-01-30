using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeMachine
{
    class CoffePowder:IPowder
    {
        public IDrinkable MixingWithWater(Water water)
        {
            return new Coffe();
        }
    }
}
