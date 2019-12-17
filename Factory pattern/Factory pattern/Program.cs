using System;

namespace Factory_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(new EnemyFactory().CreateEnemyShip().ToString());
            }

        }
    }
}
