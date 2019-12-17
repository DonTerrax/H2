using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri
{
    class Trapez:Square
    {
        public Trapez(double sideA, double sideB, double sideC, double sideD) : base(sideA, sideB, sideC, sideD)
        {
        }

        public override double Area()
        {
            double s;
            double height;
            s = (SideA + SideB - SideC + SideD) / 2;
            height = 2 / (SideA - SideC) * Math.Sqrt(s * (s - SideA + SideC) * (s - SideB) * (s - SideD));
            //height = 1 * Math.Sqrt(80);
            return height;
        }
    }
}
