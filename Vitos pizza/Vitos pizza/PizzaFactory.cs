using System;
using System.Collections.Generic;
using System.Text;

namespace Vitos_pizza
{
    class PizzaFactory
    {
        public Pizza CreatePizza(int choice)
        {
            
            switch (choice)
            {
                case 1: return new Anchovy(true,true);
                case 2: return new Margarita(true,true,true);
                case 3: return new Vesuvio(true,true,true,true);
                default:
                    return null;
                    
            }
        }
    }
}
