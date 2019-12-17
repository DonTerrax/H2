using System;
using System.Collections.Generic;
using System.Text;

namespace Flaskeautomaten
{
    class Soda:Bottle
    {
        public Soda(string name, int productionNumber)
        {
            this.name = name;
            this.productionNumber = productionNumber;
        }
    }
}
