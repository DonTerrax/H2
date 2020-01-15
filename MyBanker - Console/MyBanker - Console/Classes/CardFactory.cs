using System;
using System.Collections.Generic;
using System.Text;
using MyBanker___Console.Cards;

namespace MyBanker___Console.Classes
{
    class CardFactory
    { 
        string[] name = { "Thomas", "Hank", "Mike", "Jakub", "John" };
        Random ran = new Random();
        public Card CreateCard(int chosenCard)
        {

            switch (chosenCard)
            {

                case 1: return new ATM_Card(NameGen()); 
                case 2: return new Maestro(NameGen());
                case 3: return new Visa_Electron(NameGen());
                case 4: return new Visa_Credit_Card(NameGen());
                case 5: return new MasterCard(NameGen()); 
                default:
                    Environment.Exit(0);
                    return null;
            }
        }

        public string NameGen()
        {
            return name[ran.Next(0, name.Length)];
        }
    }
}
