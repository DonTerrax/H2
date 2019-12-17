using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Flaskeautomaten
{
    public class ProducerThread
    {
        //løbenummer
        private static int currentProducerNumb = 0;
        //lock for løbenummber
        private static object producerLock = new object();

        private static Random rnd = new Random();

        #region soda producer
        public static void SodaProducerThread()
        {
            Queue<Bottle> sodaQueue = new Queue<Bottle>();
            do
            {
                #region soda producer area
                if (Monitor.TryEnter(producerLock, 200))
                {
                    for (int sodaProducerLoop = 0; sodaProducerLoop < rnd.Next(1, 3); sodaProducerLoop++)
                    {
                        currentProducerNumb++;
                        Bottle soda = new Soda("soda", currentProducerNumb);
                        sodaQueue.Enqueue(soda);
                    }

                    Monitor.Exit(producerLock);
                }
                #endregion

                #region sodas put into producedbuffer
                if (Monitor.TryEnter(Buffer.ProducedBufferLock, 200))
                {
                    for (int insertIntoBufferLoop = 0; insertIntoBufferLoop < 10; insertIntoBufferLoop++)
                    {
                        if (Buffer.ProducedBuffer.Count != 10 && sodaQueue.Count != 0)
                        {
                            Buffer.AddProducedBufferQueue(sodaQueue.Peek());
                            sodaQueue.Dequeue();
                        }
                        else
                        {
                            Console.WriteLine("Sodas produced: {0}", insertIntoBufferLoop);
                            break;
                        }
                    }

                    Thread.Sleep(rnd.Next(200, 1001));
                    Monitor.Exit(Buffer.ProducedBufferLock);
                }
                #endregion

                Thread.Sleep(rnd.Next(2000, 10001));
            } while (true);
        }
        #endregion

        #region beer producer
        public static void BeerProducerThread()
        {
            Queue<Bottle> beerQueue = new Queue<Bottle>();
            do
            {
                #region beer producer area
                if (Monitor.TryEnter(producerLock, 200))
                {
                    for (int beerProducerLoop = 0; beerProducerLoop < rnd.Next(1, 3); beerProducerLoop++)
                    {
                        currentProducerNumb++;
                        Bottle beer = new Beer("beer", currentProducerNumb);
                        beerQueue.Enqueue(beer);
                    }

                    Monitor.Exit(producerLock);
                }
                #endregion

                #region beers put into producedbuffer
                if (Monitor.TryEnter(Buffer.ProducedBufferLock, 200))
                {
                    for (int insertIntoBufferLoop = 0; insertIntoBufferLoop < 10; insertIntoBufferLoop++)
                    {
                        if (Buffer.ProducedBuffer.Count != 10 && beerQueue.Count != 0)
                        {
                            Buffer.ProducedBuffer.Enqueue(beerQueue.Peek());
                            beerQueue.Dequeue();
                        }
                        else
                        {
                            Console.WriteLine("Beers produced: {0}", insertIntoBufferLoop);
                            break;
                        }
                    }

                    Thread.Sleep(rnd.Next(200, 1001));
                    Monitor.Exit(Buffer.ProducedBufferLock);
                }
                #endregion

                Thread.Sleep(rnd.Next(2000, 10001));
            } while (true);
        }
        #endregion
    }

}

