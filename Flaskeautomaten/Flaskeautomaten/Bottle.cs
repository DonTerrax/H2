using System;
using System.Collections.Generic;
using System.Text;

namespace Flaskeautomaten
{
    public class Bottle
    {
        protected string name;

        public string Name
        {
            get { return name; }
        }
        protected int productionNumber;

        public int ProductionNumber
        {
            get { return productionNumber; }
            
        }

        public Bottle()
        {

        }
    }
    
}
