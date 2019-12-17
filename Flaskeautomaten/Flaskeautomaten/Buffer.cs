using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Flaskeautomaten
{
    class Buffer
    {
        //buffer between the producers and the splitter, contains both soda and beer
        #region Produced Buffer
        private static Queue<Bottle> producedBuffer = new Queue<Bottle>(10);
        public static Queue<Bottle> ProducedBuffer
        {
            get { return producedBuffer; }
        }
        public static object ProducedBufferLock = new object();
        public static void AddProducedBufferQueue(Bottle drink)
        {
            producedBuffer.Enqueue(drink);
        }
        #endregion

        //soda buffer, contains soda
        #region Soda Buffer
        private static Queue<Soda> sodaBuffer = new Queue<Soda>(10);
        public static Queue<Soda> SodaBuffer
        {
            get { return sodaBuffer; }
        }
        public static object SodaBufferLock = new object();
        public static void AddSodaBufferQueue(Soda drink)
        {
            sodaBuffer.Enqueue(drink);
        }
        #endregion

        //beer buffer, contains beer
        #region Beer Buffer
        private static Queue<Beer> beerBuffer = new Queue<Beer>(10);
        public static Queue<Beer> BeerBuffer
        {
            get { return beerBuffer; }
        }
        public static object BeerBufferLock = new object();
        public static void AddBeerBufferQueue(Beer drink)
        {
            beerBuffer.Enqueue(drink);
        }
        #endregion


        //explained in program.cs
        public static void BufferChecker()
        {
            do
            {
                Console.WriteLine("{0} | Soda:{1} | Beer:{2}", ProducedBuffer.Count, SodaBuffer.Count, BeerBuffer.Count);

                Thread.Sleep(5000);
            } while (true);
        }
    }
}
