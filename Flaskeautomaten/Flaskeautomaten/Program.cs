using System;
using System.Collections.Generic;
using System.Threading;

namespace Flaskeautomaten
{
    class Program
    {
        

        static void Main(string[] args)
        {
            List<Thread> threadList = new List<Thread>();
            //all the threads the program uses
            threadList.Add(new Thread(new ThreadStart(ProducerThread.SodaProducerThread)));
            threadList.Add(new Thread(new ThreadStart(ProducerThread.BeerProducerThread)));
            threadList.Add(new Thread(new ThreadStart(SplitterThread.SodaBeerSplitter)));
            threadList.Add(new Thread(new ThreadStart(ConsumerThread.BeerConsumer)));
            threadList.Add(new Thread(new ThreadStart(ConsumerThread.SodaConsumer)));

            //a thread that checks how many beers/sodas there is in the buffers
            //can be removed and program will still work
            threadList.Add(new Thread(new ThreadStart(Buffer.BufferChecker)));

            //starts the program
            foreach (Thread thread in threadList)
            {
                thread.Start();
            }
        }
    }
}

