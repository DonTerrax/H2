using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class ATMCard : Card
    {
        public ATMCard(string cardOwner) : base(cardOwner)
        {
            
            cardNumber = "2400"+" "+ RandomCardNumber(12);
            accountNumber = accountRegNumber + " " + RandomAccountNumber(10);

        }
    }
}
