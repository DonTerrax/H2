using System;

namespace Dining_philosophers_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fork fork = new Fork();
            new Philosopher(0,fork);
            new Philosopher(1,fork);
            new Philosopher(2,fork);
            new Philosopher(3,fork);
            new Philosopher(4,fork);
        }
    }
}
