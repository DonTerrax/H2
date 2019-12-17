using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Basis_tråd_opgave_4
{
    class Input
    {
        public static char _input = '*';
        
        public static void ReadInput()
        {
            bool run = true;
            while (run)
            {
                char input = char.Parse(Console.ReadLine());
                _input = input;
            }
            
        }
    }
}
