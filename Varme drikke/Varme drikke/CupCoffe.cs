using System;
using System.Collections.Generic;
using System.Text;

namespace Varme_drikke
{
    public class CupCoffe:HotCup
    {
        protected override void Addcondiment()
        {
            Console.WriteLine("Milk and sugar added");
        }
    }
}
