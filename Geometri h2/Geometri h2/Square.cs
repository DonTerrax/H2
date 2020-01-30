using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_h2
{
    public class Square
    {
        public double SideA { get; set ; }
        public Square(double sideA)
        {
            SideA = sideA;
        }

        public virtual double Perimeter()
        {
            return SideA * 4;
        }

        public virtual double Area()
        {
            return SideA * SideA;
        }
    }
}
