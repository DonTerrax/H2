using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_fif
{
    public class FlyFish:Fish,IFlyable
    {
        public FlyFish(string name) : base(name)
        {
        }

        public override void Consume()
        {
            Console.WriteLine("Im eating green stuff from the ocean");
        }

        public int GetCurrentVeleocity()
        {
            return 2;
        }
    }
}
