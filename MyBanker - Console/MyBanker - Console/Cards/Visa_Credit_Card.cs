using System;
using System.Collections.Generic;
using System.Text;
using MyBanker___Console.Classes;

namespace MyBanker___Console.Cards
{
    class Visa_Credit_Card : Card
    {
        public Visa_Credit_Card(string cardOwner) : base(cardOwner)
        {
            //Assign the card number
            cardNumber = "4" + RandomNumber(15);
            //Assign the account number 
            accountNumber = accountPrefix + RandomNumber(10);
            //Assign the Expire date MM/YY 
            expireDate = ExpiredDate(5, 0);
        }
    }
}
