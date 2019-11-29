using System;

namespace Kaffemaskine
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Make a choice:\n 1: Power option\n 2: Fill options\n");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:

                        Console.WriteLine(" 1: Turn on\n 2: Turn off");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                break;
                            case 2:
                                break;
                        }

                        break;
                    case 2:
                        Console.WriteLine(" 1: Water option\n 2: Filter option\n 3: Fill coffePowder");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("1: Fill water\n 2: Remove water");
                                choice = int.Parse(Console.ReadLine());
                                break;
                            case 2:
                                break;

                        }

                        break;
                    default:
                        break;
                }
            }

        }
    }
}
