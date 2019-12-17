using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Basis_trådøvelser
{
    class Temperature
    {
        Random random = new Random();

        public void RandomTemp()
        {
            int randomTemp;
            int alarm = 0;
            bool run = true;
            while (run)
            {
                Thread.Sleep(1000);
                randomTemp = random.Next(-20, 120);
                if (alarm == 3)
                {
                    run = false;
                }
                else if (randomTemp < 0 || randomTemp > 100)
                {
                    Console.WriteLine("{0} Warning!", randomTemp);
                    alarm++;
                }
                else
                {
                    Console.WriteLine(randomTemp);
                }

            }
        }
    }
}
