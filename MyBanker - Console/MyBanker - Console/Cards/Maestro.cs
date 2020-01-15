using System;
using System.Collections.Generic;
using System.Text;
using MyBanker___Console.Classes;

namespace MyBanker___Console.Cards
{
    class Maestro : Card
    {
        List<string> maestroCardPrefix = new List<string> { "5018", "5020", "5038", "5893", "6304", "6759", "6761", "6762", "6763", };
        public Maestro(string cardOwner) : base(cardOwner)
        {
            //Assign the card number
            cardNumber = Prefix(maestroCardPrefix) + RandomNumber(15);
            //Assign the account number 
            accountNumber = accountPrefix + RandomNumber(10);
            //Assign the Expire date MM/YY 
            expireDate = ExpiredDate(5, 8);
        }
    }
}
