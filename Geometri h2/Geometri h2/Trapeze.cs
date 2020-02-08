using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_h2
{
    class Trapeze : Square
    {
        double s;
        public double height;
        public double SideB { get; }
        public double SideC { get; }
        public double SideD { get; }


        public Trapeze(double sideA, double sideB, double sideC, double sideD) : base(sideA)
        {
            SideB = sideB;
            SideC = sideC;
            SideD = sideD;
        }

        public override double Area()
        {

            s = (SideA + SideB - SideC + SideD) / 2;
            height = 2 / (SideA - SideC) * Math.Sqrt(s * (s - SideA + SideC) * (s - SideB) * (s - SideD));
            
            return height;
        }
    }
}
