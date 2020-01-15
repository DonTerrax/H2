using System;
using System.Collections.Generic;
using System.Text;

namespace Mybanker
{
    class Card
    {

        public string Prefix { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int MaxAmount { get; set; }
        public string ExpireDate { get; set; }
        public int Age { get; set; }
        public string CardNumber { get; set; }
        public string AccountNumber { get; set; }
        

        public Card(string prefix, string name, string lastName, int maxAmount, string expireDate, int age, string cardNumber,string accountNumber )
        {
            Prefix = prefix;
            Name = name;
            LastName = lastName;
            MaxAmount = maxAmount;
            ExpireDate = expireDate;
            Age = age;
            CardNumber = cardNumber;
            AccountNumber = accountNumber;
        }

        public override string ToString()
        {
            return "Prefix : " + Prefix + "\n" +
                   "Name : " + Name + "\n" +
                   "Lastname : " + LastName + "\n" +
                   "Card Number : " + CardNumber + "\n" +
                   "Account Number : " + AccountNumber + "\n" +
                   "Age : " + Age.ToString() + "\n" +
                   "Max Amount : " + MaxAmount.ToString() + "\n" +
                   "Expire Date : " + ExpireDate + "\n";

        }
    }
}
