using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeMachine
{
    class CoffeMachine : Machine
    {
        public Filter filter { get; private set; }
        public WaterContainer waterContainer { get; }
        public FluidContainer coffePot { get; private set; }

        public CoffeMachine(int maxWater)
        {
            waterContainer = new WaterContainer(maxWater);
        }
       

        public void Update()
        {
            if (isPowerOn && waterContainer.amount > 0 && coffePot != null && filter != null)
            {
             Water water = new Water();   
             coffePot.ChangeFluid(filter.container.powder.MixingWithWater(water));
             coffePot.PutObjectInContainer(waterContainer.TakeObjectFromWaterContainer(1));
            }
        }   

        public void PlaceFilter(Filter filter)
        {
            this.filter = filter;
        }

        public Filter RemoveFIlter()
        {
            Filter filter = this.filter;
            this.filter = null;
            return filter;
        }

        public FluidContainer RemoveCoffeePot()
        {
            FluidContainer fluid;
            fluid = coffePot;
            return coffePot;

        }

        public void PlaceCoffeePot(FluidContainer fluidContainer)
        {
            coffePot = fluidContainer;
        }
    }
}
