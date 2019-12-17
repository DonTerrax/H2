using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Basis_trådøvelser
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature();
            Thread thread = new Thread(temp.RandomTemp);
            thread.Start();

            bool run = true;

            while (run)
            {
                Thread.Sleep(5000);
                if (thread.IsAlive == false)
                {
                    Console.WriteLine("Thread stopped");
                    run = false;
                }
            }




            //PrintThread print = new PrintThread();
            //Thread thread1 = new Thread(print.ThreadStart);
            //thread1.Start();
            //Thread.Sleep(5000);
            

            //Thread thread2 = new Thread(print.ThreadStart2);
            //thread2.Start();
        }
    }
}
