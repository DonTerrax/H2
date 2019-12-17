using System;
using System.Collections.Generic;
using System.Text;

namespace Vitos_pizza
{
    class Anchovy:Pizza
    {
        private bool redOnion;
        private bool basilikum;
        private bool ansjoser;

        public bool RedOnion { get=>redOnion; set=>redOnion=value; }
        public bool Basilikum { get=>basilikum; set=>basilikum=value; }
        public bool Ansjoser { get=>ansjoser; set=>ansjoser=value; }
        public Anchovy(bool cheese, bool tomato) : base(cheese, tomato)
        {
            RedOnion = redOnion;
            Basilikum = basilikum;
            Ansjoser = ansjoser;
        }
    }
}
