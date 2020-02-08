using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_fif
{
    public class Bird : Animal
    {
        public Bird(string name) : base(name)
        {
        }

        public override void Consume()
        {
            Console.WriteLine("Im eating worms");
        }


        public void LayEgg()
        {
            Console.WriteLine("Im pooping an egg");
        }

       
    }
}
