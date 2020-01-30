using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_h2
{
    class Paralellogram:Square
    {
        public double Angle { get; }
        public double SideB { get;  }
        public Paralellogram(double sideA,double sideB,double angle) : base(sideA)
        {
            SideB = sideB;
            Angle = angle;
        }

        public override double Area()
        {
            return SideA * SideB * Math.Sin(Angle * Math.PI / 180);
        }
    }
}
