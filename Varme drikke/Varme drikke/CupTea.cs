using System;
using System.Collections.Generic;
using System.Text;

namespace Varme_drikke
{
    public class CupTea:HotCup
    {
        protected override void Addcondiment()
        {
            Console.WriteLine("Lemon added");
        }
    }
}
