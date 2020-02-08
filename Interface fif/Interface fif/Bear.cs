using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_fif
{
    class Bear: Animal
    {
        public Bear(string name) : base(name)
        {
        }

        public override void Consume()
        {
            Console.WriteLine("Is eating meat");
        }
    }
}
