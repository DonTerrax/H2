using System;

namespace Geometri
{
    class Program
    {
        static void Main(string[] args)
        {

            Square square1 = new Square(10);
            Console.WriteLine("Areal: {0}",square1.Area());

            Square square2 = new Square(30);
            Console.WriteLine("Omkreds: {0}",square2.Omkreds());

            Rektangle r1 = new Rektangle(3,5,20);
            Console.WriteLine(r1.Area());

            Trapez trapez = new Trapez(10,9,8,9);
            Console.WriteLine(trapez.Area());
            
        }
    }
}
