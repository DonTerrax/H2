using System;

namespace Vitos_pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What pizza do you want to order?\n 1: Anchovy\n 2: Margerita\n 3: Vesuvio");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine(new PizzaFactory().CreatePizza(choice).ToString());
            

        }
    }
}
