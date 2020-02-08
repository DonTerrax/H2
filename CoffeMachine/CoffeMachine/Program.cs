using System;



namespace CoffeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeMachine coffeeMachine = new CoffeMachine(10);
            coffeeMachine.waterContainer.PutObjectInContainer(10);
            IPowder coffeePowder = new CoffePowder();
            Filter filter = new Filter(coffeePowder, 10);
            filter.container.PutObjectInContainer(10);
            coffeeMachine.PlaceFilter(filter);
            IDrinkable coffe = new Coffe();
            FluidContainer fluidContainer = new FluidContainer(coffe,10);
            coffeeMachine.PlaceCoffeePot(fluidContainer);
            coffeeMachine.PowerON();
            for (int i = 0; i < 10; i++)
            {
                coffeeMachine.Update();
            }
            fluidContainer = coffeeMachine.RemoveCoffeePot();
            Console.WriteLine("Machine has" + fluidContainer.amount + " " + fluidContainer.fluidType);

            Console.ReadKey();

        }
    }
}
