using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Basis_trådøvelser
{
    class PrintThread
    {

        public void ThreadStart()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Threading is easy");
                Thread.Sleep(1000);
            }
        }

        public void ThreadStart2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Also with more threads!");
                Thread.Sleep(1000);
            }
        }
    }
}
