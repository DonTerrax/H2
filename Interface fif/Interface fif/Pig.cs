using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_fif
{
    public class Pig : Animal
    {
        public Pig(string name) : base(name)
        {

        }

        public override void Consume()
        {
            Console.WriteLine("Is eating carrots");
        }
    }
}
