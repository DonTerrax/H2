using System;
using System.Diagnostics;
using System.Threading;

namespace ThreadpoolExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch mywatch = new Stopwatch();
            Console.WriteLine("Thread pool execution");
            mywatch.Start();
            Print.ProcessWithThreadMethod();
            mywatch.Stop();

            Console.WriteLine("Time consumed by ProcessWithThreadPoolMethod is : " + mywatch.ElapsedTicks.ToString());

            mywatch.Reset();
            Console.WriteLine("Thread Execution");

            mywatch.Start();
            Print.ProcessWithThreadMethod();
            mywatch.Stop();

            Console.WriteLine("Time consumed by ProcessWithThreadMethod is : " + mywatch.ElapsedTicks.ToString());
        }
    }
}
