using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Dining_philosophers_2
{
    class Philosopher
    {
        private int N;
        Random random = new Random();
        public Fork Fork;
        private int left;
        private int right;
        

        public Philosopher(int n,Fork fork)
        {
            N = n;
            Fork = fork;
            left = n == 0 ? 4 : n - 1;
            right = (n + 1) % 5;
            Thread thread = new Thread(new ThreadStart(Run));
            thread.Start();
        }

        public void Run()
        {
            try
            {
                while (true)
                {
                    Thread.Sleep(random.Next(1000, 2000));
                    Console.WriteLine("Philosopher " + N + " is thinking..");
                    Fork.Get(left, right);

                    Thread.Sleep(random.Next(1000, 2000));
                    Console.WriteLine("Philosopher " + N + " is eating...");
                    Fork.Put(left, right);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            
        }
    }
}
