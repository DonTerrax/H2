using System;
using System.Collections.Generic;
using System.Text;
using ChewPhew;

namespace ChewPhew
{
    class GumFactory
    {
        private static object instance;
       

        public Gum[] gum =
        {
            new Gum("blue", "Blueberry"),
            new Gum("Purple", "Blackberry"), 
            new Gum("Yellow", "Tutti Frutti"),
            new Gum("Brown", "Brownie"),
            new Gum("Red", "Strawberry"),
            new Gum("Green", "Apple"),
        };

        
        public static GumFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GumFactory();
                }
                return (GumFactory) instance;
            }
        }

       
    }
}
