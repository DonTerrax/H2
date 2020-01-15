using System;
using System.Collections.Generic;
using System.Text;
using MyBanker___Console.Classes;

namespace MyBanker___Console.Cards
{
    class ATM_Card : Card
    {
        public ATM_Card(string cardOwner) : base(cardOwner)
        {
            //Assign the card number
            cardNumber = "2400" + RandomNumber(12);
            //Assign the account number 
            accountNumber = accountPrefix + RandomNumber(10);
        }
    }
}
