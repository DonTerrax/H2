using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Dining_philosophers_2
{
    class Fork
    {
        bool[] fork = new bool[5];

        public void Get(int left, int right)
        {
            lock (this)
            {
                while (fork[left] || fork[right]) Monitor.Wait(obj: this);
                {
                    fork[left] = false;
                    fork[right] = false;
                }
            }
        }

        public void Put(int left, int right)
        {
            lock (this)
            {
                fork[left] = true;
                fork[right] = true;
                Monitor.PulseAll(obj:this);
            }
        }
    }
}
