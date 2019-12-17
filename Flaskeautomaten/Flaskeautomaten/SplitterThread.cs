using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Flaskeautomaten
{
    public class SplitterThread
    {
        public static void SodaBeerSplitter()
        {
            //temp soda nad beer queues until they are put into new buffers
            Queue<Soda> sodaQueue = new Queue<Soda>(5);
            Queue<Beer> beerQueue = new Queue<Beer>(5);
            Random rnd = new Random();

            do
            {
                if (Monitor.TryEnter(Buffer.ProducedBufferLock, 200))
                {
                    #region Splitter area
                    for (int producedBufferEmptierLoop = 0; producedBufferEmptierLoop < Buffer.ProducedBuffer.Count; producedBufferEmptierLoop++)
                    {
                        if (Buffer.ProducedBuffer.Peek() is Soda && sodaQueue.Count != 5)
                        {
                            sodaQueue.Enqueue((Soda)Buffer.ProducedBuffer.Peek());
                            Buffer.ProducedBuffer.Dequeue();
                        }
                        else if (Buffer.ProducedBuffer.Peek() is Beer && beerQueue.Count != 5)
                        {
                            beerQueue.Enqueue((Beer)Buffer.ProducedBuffer.Peek());
                            Buffer.ProducedBuffer.Dequeue();
                        }
                        else
                        {
                            break;
                        }
                    }
                    Monitor.Exit(Buffer.ProducedBufferLock);
                    #endregion
                }

                #region puts sodas and beers into buffers
                if (Monitor.TryEnter(Buffer.SodaBufferLock, 200))
                {
                    #region puts beers into beer buffer area
                    if (Monitor.TryEnter(Buffer.BeerBufferLock, 200))
                    {
                        for (int insertIntoBeerBufferLoop = 0; insertIntoBeerBufferLoop < 10; insertIntoBeerBufferLoop++)
                        {
                            if (Buffer.BeerBuffer.Count != 10 && beerQueue.Count != 0)
                            {
                                Buffer.AddBeerBufferQueue(beerQueue.Peek());
                                beerQueue.Dequeue();
                            }
                            else
                            {
                                Console.WriteLine("Beers added to Beer Buffer: {0}", insertIntoBeerBufferLoop);
                                break;
                            }
                        }

                        Monitor.Exit(Buffer.BeerBufferLock);
                    }
                    #endregion

                    #region puts sodas into soda buffer area
                    for (int insertIntoSodaBufferLoop = 0; insertIntoSodaBufferLoop < 10; insertIntoSodaBufferLoop++)
                    {
                        if (Buffer.SodaBuffer.Count != 10 && sodaQueue.Count != 0)
                        {
                            Buffer.AddSodaBufferQueue(sodaQueue.Peek());
                            sodaQueue.Dequeue();
                        }
                        else
                        {
                            Console.WriteLine("Sodas added to Soda Buffer: {0}", insertIntoSodaBufferLoop);
                            break;
                        }
                    }
                    #endregion

                    Monitor.Exit(Buffer.SodaBufferLock);
                }
                #endregion

                Thread.Sleep(rnd.Next(3000, 12001));
            } while (true);
        }
    }
}
