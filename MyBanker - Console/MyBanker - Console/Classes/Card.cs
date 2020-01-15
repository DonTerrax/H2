using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker___Console.Classes
{
    abstract class Card 

    {
        Random random = new Random();
        
        protected string accountNumber;
        protected string cardNumber;
        protected string cardOwner;
        protected string expireDate;
        protected string accountPrefix = "3520";

        #region Properties
        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public string CardOwner
        {
            get { return cardOwner; }
            set { cardOwner = value; }
        }

        public string ExpireDate
        {
            get { return expireDate; }
            set { expireDate = value; }
        }

        public string CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }
        #endregion

        #region Constructor
        public Card(string cardOwner)
        {
            this.cardOwner = cardOwner;
        }

        #endregion

        //Random Number Generator 
        public string RandomNumber(int digits)
        {
            string cardNumber = null;


            for (int i = 0; i < digits; i++)
            {
                cardNumber += random.Next(0, 9);
            }

            return cardNumber;
        }

        //Return a random prefix from list
        public string Prefix(List<string> list)
        {
            return list[random.Next(0, list.Count)];
        }
        //Finding out the Expire date and returning it 
        public string ExpiredDate(int year, int month)
        {
            string returnDate = null;
            DateTime date = DateTime.Now;
            int months = date.Month + month;

            if (months > 12)
            {
                returnDate = date.AddMonths(month).Month.ToString();
                returnDate += "/" + date.AddYears(year + 1).Year.ToString();
            }
            else
            {
                returnDate = date.AddMonths(month).Month.ToString();
                returnDate += "/" + date.AddYears(year).Year.ToString();
            }


            return returnDate;
        }

        public override string ToString()
        {
            return "Name : " + cardOwner + " \nCardnumber : " + cardNumber + "\nAccount Number :" + accountNumber + " Expire Date : " + expireDate;
        }
    }
}