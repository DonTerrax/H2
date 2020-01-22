using System;
using System.Collections.Generic;
using System.Text;

namespace ChewPhew
{
    class Gum 
    {
        private string flavor;
        private string color;
        
        public string Flavor { get=>flavor; set=>flavor=value; }
        public string Color { get=>color; set=>color=value; }
        
        public Gum(string color,string flavor)
        {
            Flavor = flavor;
            Color = color;
            
        }

      
    }
}
