using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Dining_philosopthers
{
    class Fork
    {
        public static bool[] fork = new bool[5];
        public void Get(int left, int right)
        {
            lock (this)
            {
                while (fork[left] || fork[right]) Monitor.Wait(this);
                fork[left] = true; fork[right] = true;
            }
        }
        public void Put(int left, int right)
        {
            lock (this)
            {
                fork[left] = false; fork[right] = false;
                Monitor.PulseAll(this);
            }
        }
    }
}
