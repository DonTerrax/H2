using System;
using System.Collections.Generic;
using System.Text;
using MyBanker___Console.Classes;

namespace MyBanker___Console.Cards
{
    class MasterCard : Card
    {
        List<string> masterCardPrefix = new List<string>{"51", "52", "53", "54", "55"};

        public MasterCard(string cardOwner) : base(cardOwner)
        {
            //Assign the card number
            cardNumber = Prefix(masterCardPrefix) + RandomNumber(14);
            //Assign the account number 
            accountNumber = accountPrefix + RandomNumber(10);
            //Assign the Expire date MM/YY 
            expireDate = ExpiredDate(5,0);
        }
    }
}
