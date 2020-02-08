using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Flaskeautomaten
{
    class ConsumerThread
    {
        #region soda consumer
        public static void SodaConsumer()
        {
            Random rnd = new Random();
            do
            {
                if (Monitor.TryEnter(Buffer.SodaBufferLock, 200))
                {
                    if (Buffer.SodaBuffer.Count != 0)
                    {
                        Console.WriteLine("Mike took a {0}, producer number: {1}", Buffer.SodaBuffer.Peek().Name, Buffer.SodaBuffer.Peek().ProductionNumber);
                        Buffer.SodaBuffer.Dequeue();
                    }

                    Monitor.Exit(Buffer.SodaBufferLock);
                }

                Thread.Sleep(rnd.Next(2000, 7001));

            } while (true);
        }
        #endregion

        #region beer consumer
        public static void BeerConsumer()
        {
            Random rnd = new Random();
            do
            {
                if (Monitor.TryEnter(Buffer.BeerBufferLock, 200))
                {
                    if (Buffer.BeerBuffer.Count != 0)
                    {
                        Console.WriteLine("Jakub took a {0}, producer number: {1}", Buffer.BeerBuffer.Peek().Name, Buffer.BeerBuffer.Peek().ProductionNumber);
                        Buffer.BeerBuffer.Dequeue();
                    }

                    Monitor.Exit(Buffer.BeerBufferLock);
                }

                Thread.Sleep(rnd.Next(2000, 7001));

            } while (true);
        }
        #endregion
    }
}
