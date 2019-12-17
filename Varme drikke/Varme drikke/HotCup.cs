using System;
using System.Collections.Generic;
using System.Text;

namespace Varme_drikke
{
    public abstract class HotCup
    {
        protected void MakeCup()
        {
            Boilwater();
            Brew();
            Pour();
            Addcondiment();
        }
        private string Boilwater()
        {
            return "Water ready";
        }

        private string Brew()
        {
            return "Brewing done";
        }

        private string Pour()
        {
            return "Pouring";
        }

        protected abstract void Addcondiment();
    }
    
}
