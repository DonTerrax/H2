using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Thread_syncronize_exercise_assignment_1
{
    class PrintStar
    {
        public static void Star()
        {
            lock (Program.padlock)
            {
                for (int i = 0; i < 60; i++)
                {
                    Console.Write(Program.up);

                    Program.counter++;

                }

                Console.WriteLine(Program.counter + "\n");
            }
                
           
        }
    }
}
