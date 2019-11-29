using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Visa : Card
    {
        public Visa(string cardOwner) :base(cardOwner)
        {
            
            cardNumber = "4" + RandomCardNumber(15);
            accountNumber = accountRegNumber + " " + RandomAccountNumber(10);
            expireDate = ExpiredDate(5, 0);

        }
    }
}
