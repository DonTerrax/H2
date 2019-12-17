using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Tv
    {
        private int volume = 0;
        private bool on = false;
        private static Tv instance;

        public int Volume { get=>volume; set=>volume=value; }
        public bool On { get=>on; set=>on=value; }

        private Tv()
        {
            Volume = volume;
            On = on;
        }
        public static Tv Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Tv();
                }
                return instance;
            }
        }
        
    }
}
