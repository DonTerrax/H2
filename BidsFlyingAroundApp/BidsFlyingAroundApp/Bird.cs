using System;
using System.Collections.Generic;
using System.Text;

namespace BidsFlyingAroundApp
{
    public abstract class Bird
    {
        public abstract void SetLocation(double longitude, double latitude);
        public abstract void SetAltitude(double altitude);
        public abstract void Draw();

    }
}
