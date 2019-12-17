using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Tv.Instance.On = true;
            Tv.Instance.Volume = 3;

        }
    }
}
