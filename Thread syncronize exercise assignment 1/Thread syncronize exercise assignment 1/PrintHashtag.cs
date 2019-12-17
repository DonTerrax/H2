using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Thread_syncronize_exercise_assignment_1
{
    class PrintHashtag
    {
        public static void Hashtag()
        {

            lock (Program.padlock)
            {
                for (int i = 0; i < 60; i++)
                {

                    Console.Write(Program.down);
                    Program.counter++;
                }

                Console.WriteLine(Program.counter + "\n");
            }
                
        }
    }
}
