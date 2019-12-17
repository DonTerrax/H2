using System;
using System.Threading;

namespace Dining_philosopthers
{
    class Philosopher
    {
        int n;
        int left, right;
        Fork fork;
        Random random = new Random();
        public Philosopher(int n,Fork fork)
        {
            this.n = n;
            this.fork = fork;
            left = n == 0 ? 4 : n - 1;
            right = (n + 1) % 5;
            new Thread(Run).Start();
        }
        public void Run()
        {
            while (true)
            {
                try
                {
                    Thread.Sleep(random.Next(2000,3000));
                    Console.WriteLine("Thread# ("+ Thread.CurrentThread.ManagedThreadId + ") Philosopher " + n + " is thinking...");
                    fork.Get(left, right);
                    Console.WriteLine("Thread# (" + Thread.CurrentThread.ManagedThreadId + ") Philosopher " + n + " is eating...");
                    Thread.Sleep(random.Next(2000,3000));
                    fork.Put(left,right);
                    Console.WriteLine("Thread# (" + Thread.CurrentThread.ManagedThreadId + ") Philosopher " + n + " is done eating...");
                }
                catch
                {
                    return;
                }
            }
            
        }
    }
}
