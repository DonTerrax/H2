using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_h2
{
    class Rectangle:Square
    {
        public double SideB { get;  }
        public double SideC { get;  }
        public Rectangle(double sideA,double sideB,double sideC) : base(sideA)
        {
            SideB = sideB;
            SideC = sideC;
        }

        public override double Area()
        {
            return SideA * SideB / 2;
        }

        public override double Perimeter()
        {
            return SideA * 2 + SideB *2;
        }
    }
}
