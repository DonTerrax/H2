using System;
using System.Collections.Generic;
using System.Text;

namespace Vitos_pizza
{
    class Margarita:Pizza
    {
        
        private bool oregano;

        
        public bool Oregano { get=>oregano; set=>oregano=value; }


        public Margarita(bool cheese, bool tomato,bool oregano) : base(cheese, tomato)
        {
            Oregano = oregano;
        }
    }
}
