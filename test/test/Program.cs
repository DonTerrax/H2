using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            try
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("What name should we put on the card?");
                string nameOnCard = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("What card do you want to create?\n" +
                                  " __________________\n"+
                                  "| 1: AtmCard       |\n" +
                                  "| 2: Meastro       |\n" +
                                  "| 3: MasterCard    |\n" +
                                  "| 4: Visa          |\n" +
                                  "| 5: VisaCreditCard|\n" + 
                                  "|__________________|\n" );
                int cardId = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Clear();
                switch (cardId)
                {
                    case 1:
                        {
                            Card card = new ATMCard(nameOnCard);
                            Console.WriteLine($"Navn: {nameOnCard}\n" +
                                          $"Kortnummer: {card.CardNumber}\n" +
                                          $"Accountnumber: {card.AccountNumber}");
                            break;
                        }
                    case 2:
                        {
                            Card card = new Maestro(nameOnCard);
                            Console.WriteLine($"Navn: {nameOnCard}\n" +
                                              $"Kortnummer: {card.CardNumber}\n" +
                                              $"AccountNumber: {card.AccountNumber}\n" +
                                              $"Expiredate: {card.ExpireDate}");
                            break;
                        }
                    case 3:
                        {
                            Card card = new MasterCard(nameOnCard);
                            Console.WriteLine($"Navn: {nameOnCard}\n" +
                                              $"Kortnummer: {card.CardNumber}\n" +
                                              $"AccountNumber: {card.AccountNumber}\n" +
                                              $"Expiredate: {card.ExpireDate}");
                            break;
                        }
                    case 4:
                        {
                            Card card = new Visa(nameOnCard);
                            Console.WriteLine($"Navn: {nameOnCard}\n" +
                                              $"Kortnummer: {card.CardNumber}\n" +
                                              $"AccountNumber: {card.AccountNumber}\n" +
                                              $"Expiredate: {card.ExpireDate}");
                            break;
                        }
                    case 5:
                        {
                            Card card = new VisaCreditCard(nameOnCard);
                            Console.WriteLine($"Navn: {nameOnCard}\n" +
                                              $"Kortnummer: {card.CardNumber}\n" +
                                              $"AccountNumber: {card.AccountNumber}\n" +
                                              $"Expiredate: {card.ExpireDate} ");
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }

                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Use a number between 1 and 5 bitch!");
                
            }
            
        }
    }
}
