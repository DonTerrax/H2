using System;
using System.Collections.Generic;
using System.Text;

namespace BidsFlyingAroundApp
{
    public class Penguin : Bird
    {
        public override void Draw()
        {
            //Sæt en lokation
        }

        public override void SetAltitude(double altitude)
        {
            throw new NotImplementedException();
        }

        public override void SetLocation(double longitude, double latitude)
        {
            //Tegn fugl på skærmen
        }
    }
}
