using System;
using System.Collections.Generic;
using System.Text;

namespace Flaskeautomaten
{
    class Beer:Bottle
    {
        public Beer(string name, int productionNumb)
        {
            this.name = name;
            this.productionNumber = productionNumb;
        }
    }
}
