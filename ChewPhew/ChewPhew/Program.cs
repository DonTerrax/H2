using System;

namespace ChewPhew
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Dispenser.Instance.FindAmount();
            Dispenser.Instance.AddToGumList();
            Dispenser.Instance.PullLever();
            

            //foreach (var gums in Dispenser.Instance.gumList)
            //{
            //    Console.WriteLine(gums.Flavor + " " + gums.Color + " " + i);
            //    i++;
            //}
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Pull the handle to get gums!");
            Console.ReadKey();
            foreach (var gum in Dispenser.Instance.gumoutput)
            {
                i++;
                Console.WriteLine(gum.Flavor + " " + gum.Color + " " +i);
            }
            
        }
    }
}
