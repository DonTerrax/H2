using System;
using System.Collections.Generic;

namespace Interface_fif
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Animal> animals = new List<Animal>();

            Animal a = new Pig("Pig");

            animals.Add(a);


            Animal bear = new Bear("Bear");
            bear.Consume();
            animals.Add(bear);

            Hunter h = new Hunter();

            h.Shoot(a);
            a.Kill();

            Bird kiwi = new Kiwi("Kiwi");
            Animal ff = new FlyFish("FlyFish");


            animals.Add(ff);
            Animal bb = new BlackBird("blackbird");
            animals.Add(bb);


            foreach (Animal item in animals)
            {
                if (item is Bird)
                {
                    ((Bird)item).LayEgg();
                    
                }

                if (item is IFlyable)
                {
                    ((IFlyable) item).GetCurrentVeleocity();
                }
                item.Consume();

            }

            Console.ReadKey();
        }
    }
}
