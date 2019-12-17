using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri
{
    class Rektangle : Square
    {
        public Rektangle(double sideA, double sideB, int grader) : base(sideA, sideB, grader)
        {
        }

        public override double Area()
        {
            double area;
            area = SideA * SideB * Math.Sin(Grader);
            return area;
        }
    }
}
