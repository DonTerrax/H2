using System;
using System.Collections.Generic;
using System.Text;
using ChewPhew.GumTypes;

namespace ChewPhew
{
    class GumFactory
    {
        Gum[]gum = new Gum[55];
        private readonly int[] procent = new[] {25,12,20,19,14,10};
        
        public Gum[] CreateGum()
        {

            Gum blue = new Blue("blue", "Blueberry");
            Gum purple = new Purple("Purple", "Blackberry");
            Gum yellow = new Yellow("Yellow", "Tutti Frutti");
            Gum brown = new Brown("Brownie", "Brown");
            Gum red = new Red("Red", "Strawberry");
            Gum green = new Green("Green", "Apple");

            for (int i = 0; i < gum.Length; i++)
            {
                
            }

        }

        
    }
}
