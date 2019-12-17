using System;
using System.Collections.Generic;
using System.Text;

namespace Vitos_pizza
{
    class Pizza
    {
        private bool cheese;
        
        private bool tomato;

        public bool Cheese { get=>cheese; set=>cheese=value; }
        
        public bool Tomato { get=>tomato; set=>tomato=value; }
        

        public Pizza(bool cheese,bool tomato)
        {
            Cheese = cheese;
            Tomato = tomato;
        }

    }
}
