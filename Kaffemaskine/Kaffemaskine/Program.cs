using System;
using Kaffemaskine.Classes;

namespace Kaffemaskine
{
    class Program
    {
        static void Main(string[] args)
        {
            Power power = new Power();
            WaterContainer water = new WaterContainer();
            Filter filter = new Filter();
            Powder powder = new Powder();
            TeaFlavor flavor = new TeaFlavor();

            while (true)
            {
                Console.WriteLine("Options:\n 1: Power option\n 2: Fill water\n 3: Insert filter\n 4: Remove filter\n 5: Choose drink");
                int choice = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case 1:

                        Console.WriteLine(" 1: Turn on\n 2: Turn off");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine(power.PowerOn(powder.containPowder,water.water));
                                break;
                            case 2:
                                Console.WriteLine(power.PowerOff());
                                break;
                        }
                        break;
                    case 2:

                        Console.WriteLine(" 1: Add water in ML: ");
                        choice = int.Parse(Console.ReadLine());
                        Console.WriteLine(water.AddWater(choice));
                        
                        break;
                    case 3:
                        Console.WriteLine(filter.AddFilter());
                        break;
                    case 4:
                        Console.WriteLine(filter.RemoveFilter(powder.containPowder));
                        break;
                    case 5:
                        Console.WriteLine(" 1: Coffe\n 2: The");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("How many scoops of powder?");
                                choice = int.Parse(Console.ReadLine());
                                Console.WriteLine(powder.AddPowder(choice, filter.filter));
                                break;
                            case 2:
                                Console.WriteLine("What flavor {0}",flavor.Flavor());
                                break;
                        }
                        break;
                    case 6:
                        
                        break;
                }
            }

        }
    }
}
