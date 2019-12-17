using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Basis_tråd_opgave_4
{
    class Output
    {
        
        public static void OutputRead()
        {
            bool run = true;
            while (run)
            {
                if (Input._input != null)
                {
                    Thread.Sleep(5);
                    Console.Write(Input._input);
                }
            }
            
        }
    }

}
