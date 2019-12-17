using System;
using System.Threading;

namespace Basis_tråd_opgave_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread input = new Thread(new ThreadStart(Input.ReadInput));
            Thread output = new Thread(new ThreadStart(Output.OutputRead));
            input.Start();
            output.Start();
            
        }
    }
}
