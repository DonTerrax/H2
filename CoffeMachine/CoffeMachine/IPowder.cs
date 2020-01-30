using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeMachine
{
    interface IPowder
    {
        IDrinkable MixingWithWater(Water water);
    }
}
