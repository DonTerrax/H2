using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    abstract class Card
    {
        
        private Random rnd = new Random();   
        protected string cardOwner;
        protected string cardNumber;
        protected string accountNumber;
        protected string accountRegNumber = "3520";
        protected string expireDate;
        protected int balance;

        #region Properties

        
        public string ExpireDate
        {
            get
            {
                return expireDate;
            }
            set
            {
                expireDate = value;
            }
        }
        public int Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
        public string CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }
        public string AccountNumber
        {
            get
            {
                return accountNumber;
            }
            set
            {
                accountNumber = value;
            }
        }

        #endregion

      

        public Card(string cardOwner)
        {
            this.cardOwner = cardOwner;
        }

        public string RandomCardNumber(int digits)
        {
            string cardNumber = null;
            for (int i = 0; i < digits; i++)
            {
                cardNumber +=(rnd.Next(0,9));
            }

            return cardNumber;
        }

        public string RandomAccountNumber(int accountNumber)
        {
            string accNumber = null;
            for (int i = 0; i < 9; i++)
            {
                accNumber += (rnd.Next(0, 9));
            }

            return accNumber;
        }

        //public static string PrintOutCardInformation(string name,string cardNumber,string accNumber)
        //{
        //    return "Name: "+name +"Cardnumber: "+cardNumber + "AccountNumber: "+accNumber;
        //}

        public string ReturnPrefix(List<string>prefix)
        {
            return prefix[rnd.Next(0, prefix.Count)];
        }

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
    }

   

   

}
