using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeMachine
{
    public class FluidContainer:Container
    {
        public IDrinkable fluidType { get; private set; }
        private int amount;


        public FluidContainer(IDrinkable fluidType,int max) : base(max)
        {
            this.fluidType = fluidType;
        }

        public void ChangeFluid(IDrinkable type)
        {
            fluidType = type;
        }
    }
}
