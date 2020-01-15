using System;
using System.Collections.Generic;
using System.Text;

namespace Mybanker
{
    class FactoryCard
    {
        private string[] VisaElectronPrefix = { "4026 ", "417500 ", "4508 ", "4912 ", "4917 " };
        private string[] MasterCardPreFix = { "51 ", "52 ", "53 ", "54 ", "55 " };
        private string[] MaestroPreFix = { "5018 ", "5020 ", "5038 ", "5893 ", "6304 ", "6759 ", "6761 ", "6762 ", "6763 " };
        private string Visa = "4";
        private string AtmCard = "2400";
        private string[] Name = { "Mike", "Jakub", "Benjamin", "Morten", "Mads" };
        private string[] LastName = { "Madsen", "Grubarski", "Mortensen", "Nielsen", "Borre" };

        Random rnd = new Random();
        public Card CreateCard(int choice)
        {

            switch (choice)
            {
                case 1: return new Card(PrefixGen(VisaElectronPrefix), NameGen(), LastNameGen(), 10000, ExpireDateGen(choice), 5, CardNumberGen(choice), AccountNumberGen());//VisaElectron

                case 2: return new Card(Visa, NameGen(), LastNameGen(), 10000, ExpireDateGen(choice), 123, CardNumberGen(choice), AccountNumberGen());//Visa

                case 3: return new Card(PrefixGen(MasterCardPreFix), NameGen(), LastNameGen(), 10000, ExpireDateGen(choice), 123, CardNumberGen(choice), AccountNumberGen());//MasterCard

                case 4: return new Card(PrefixGen(MaestroPreFix), NameGen(), LastNameGen(), 10000, ExpireDateGen(choice), 123, CardNumberGen(choice), AccountNumberGen());//Maestro

                case 5: return new Card(AtmCard, NameGen(), LastNameGen(), 10000, ExpireDateGen(choice), 123, CardNumberGen(choice), AccountNumberGen());//AtmCard

            }

            return null;
        }

        public string CardNumberGen(int choice)
        {
            string cardNumber = " ";
            int cardNumberLength = 16;
            if (choice == 3)
            {
                cardNumberLength += 3;
            }

            for (int i = 0; i < cardNumberLength; i++)
            {
                cardNumber += rnd.Next(0, 9).ToString();
            }

            return cardNumber;
        }

        public string ExpireDateGen(int choice)
        {
            DateTime time = DateTime.Now;
            if (choice == 4)
            {
                return time.AddYears(5).AddMonths(8).ToShortDateString();
            }

            return time.AddYears(5).ToShortDateString();
        }

        public string AccountNumberGen()
        {
            string accountNumber = "3520-";
            for (int i = 0; i <= 9; i++)
            {
                accountNumber += rnd.Next(0, 9).ToString();
            }

            return accountNumber;
        }

        public string PrefixGen(string[] prefix)
        {
            return prefix[rnd.Next(0, prefix.Length)];
        }

        public string NameGen()
        {
            return Name[rnd.Next(0, Name.Length)];
        }

        public string LastNameGen()
        {
            return LastName[rnd.Next(0, LastName.Length)];
        }

        
    }
}
