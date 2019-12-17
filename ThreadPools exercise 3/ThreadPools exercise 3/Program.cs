using System;
using System.Threading;

namespace ThreadPools_exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadMethods methods = new ThreadMethods();
            methods.isBackground = true;
            methods.Priority = ThreadPriority.Highest;
            
            ThreadPool.QueueUserWorkItem(methods.IsAlivePrint);
            ThreadPool.QueueUserWorkItem(methods.IsBackgroundPrint);
            ThreadPool.QueueUserWorkItem(methods.ThreadPriorityPrint);
            Console.ReadKey();
        }
    }
}
