using System;
using System.Collections.Generic;
using System.Text;
using MyBanker___Console.Classes;

namespace MyBanker___Console.Cards
{
    class Visa_Electron : Card
    {
        List<string> visaElectronCardPrefix = new List<string> { "4026", "417500", "4508", "4844", "4913", "4917" };
        public Visa_Electron(string cardOwner) : base(cardOwner)
        {
            //Assign the card number && Check which prefix the card have
            string digit = Prefix(visaElectronCardPrefix);

            if (visaElectronCardPrefix[1] == digit)
            {
                cardNumber = digit + RandomNumber(10);
            }
            else
            {
                cardNumber = digit + RandomNumber(12);
            }
            //Assign the account number 
            accountNumber = accountPrefix + RandomNumber(10);
            //Assign the Expire date MM/YY 
            expireDate = ExpiredDate(5, 0);
        }
    }
}
