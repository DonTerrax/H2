using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_fif
{
    public class BlackBird: Bird,IFlyable
    {
        public BlackBird(string name) : base(name)
        {
        }

        public int GetCurrentVeleocity()
        {
            return 1;
        }
    }
}
