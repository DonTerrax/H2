using System;

namespace Mybanker
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine(new FactoryCard().CreateCard(rnd.Next(1,5)).ToString());
        }
    }
}
