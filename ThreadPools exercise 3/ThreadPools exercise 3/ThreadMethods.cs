using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreadPools_exercise_3
{
    class ThreadMethods
    {
        public bool isAlive { get;}
        public bool isBackground { get; set; }
        public ThreadPriority Priority { get; set; }

        private Thread th;

        public void IsAlivePrint(object obj)
        {
            Console.WriteLine(isAlive);
        }

        public void IsBackgroundPrint(object obj)
        {
            Console.WriteLine(isBackground);
        }

        public void ThreadPriorityPrint(object obj)
        {
            Console.WriteLine(Priority);
        }

        public void ThreadStart()
        {
            th.Start();
            Console.WriteLine("Starting thread.....");
        }
        public void ThreadSleep()
        {
            Thread.Sleep(500);
        }
        public void ThreadSuspend()
        {
            th.Suspend();
            Console.WriteLine("Thread suspended!");
        }
        public void ThreadResume()
        {
            th.Resume();
            Console.WriteLine("Resuming thread");
        }
        public void ThreadAbort()
        {
            th.Abort();
            Console.WriteLine("Abort abort abort!!");
        }
        public void ThreadJoin()
        {
            th.Join();
            Console.WriteLine("Joining");
        }
    }
}
