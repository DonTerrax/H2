using System;
using System.Collections.Generic;

namespace Geometri_h2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Square>squares = new List<Square>();

            Square square = new Square(5);
            Square trapez = new Trapeze(10,9,8,9);
            Square parallelogram = new Paralellogram(3,5,20);
            Square rectangle = new Rectangle(3,4,5);

            squares.Add(square);
            squares.Add(trapez);
            squares.Add(parallelogram);
            squares.Add(rectangle);

            foreach (Square item in squares)
            {
                Console.WriteLine("Area: "+item.Area());
                Console.WriteLine("Perimeter: "+item.Perimeter());
            }
        }
    }
}
