using System;
using System.Collections.Generic;
using System.Text;

namespace Vitos_pizza
{
    class Vesuvio:Pizza
    {
        
        private bool ham;
        private bool tomato;
        private bool oregano;

        
        public bool Ham { get=>ham; set=>ham=value; }
        
        public bool Oregano { get=>oregano; set=>oregano = value; }

        public Vesuvio(bool cheese, bool tomato,bool oregano,bool ham) : base(cheese, tomato)
        {
            Oregano = oregano;
            Ham = ham;
        }
    }
}
