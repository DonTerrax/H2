using System;
using MyBanker___Console.Cards;
using MyBanker___Console.Classes;

namespace MyBanker___Console
{
    class Program
    {
        static void Main(string[] args)
        {
      
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" ____________________  #####    ##    #####    ####\n" +
                                  "|1.ATM Card          | #       #  #   #    #   #   #\n" +
                                  "|2.Maestro           | #       #  #   #    #   #    #\n" +
                                  "|3.Visa Electron     | #      #    #  #####    #    #\n" +
                                  "|4.Visa / Credit Card| #      ######  #   #    #    #\n" +
                                  "|5.MasterCard        | #     #      # #    #   #   #\n" +
                                  "|____________________| ##### #      # #     #  ####\n" +
                                  "Choose a card! ");

                int chosenCard = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Cyan;
                CardFactory card = new CardFactory();
                Console.WriteLine(card.CreateCard(chosenCard).ToString());

                Console.ReadKey();
            
        }
    }
}
