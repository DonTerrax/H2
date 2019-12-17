using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Thread_syncronize_exercise_assignment_1
{
    class Program
    {
        public static char up = '*';
        public static char down = '#';
        public static int counter = 0;

        public static object padlock = new object();

        static void Main(string[] args)
        {
            while (true)
            {

                Thread threadup = new Thread(PrintStar.Star);
                Thread threaddown = new Thread(PrintHashtag.Hashtag);

                threadup.Start();
                threadup.Join();
                Thread.Sleep(500);
                threaddown.Start();
                threaddown.Join();
                Thread.Sleep(500);
            }

        }
    }
}
