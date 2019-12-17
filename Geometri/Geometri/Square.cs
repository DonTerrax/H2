using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Geometri
{
    public class Square
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double SideD { get; set; }
        public int Grader { get; set; }


        public Square(double sideA, double sideB, double sideC, double sideD)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            SideD = sideD;
        }

        public Square(double sideA, double sideB,int grader)
        {
            SideA = sideA;
            SideB = sideB;
            Grader = grader;
        }
        public Square(int sideA)
        {
            SideA = sideA;
        }

        public virtual double Area()
        {
            double area;
            area = SideA = SideA * 2;
            return area;
        }

        public double Omkreds()
        {
            double omkreds;
            omkreds = SideA * 4;
            return omkreds;
        }

        


    }
}
