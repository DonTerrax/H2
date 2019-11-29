using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class VisaCreditCard : Card
    {
        public VisaCreditCard(string cardOwner) : base(cardOwner)
        {
            List<string> prefix = new List<string>{"4026","417500","4508","4844","4913","4917"};
            cardNumber = ReturnPrefix(prefix) + " " + RandomCardNumber(12);
            accountNumber = accountRegNumber + " " + RandomAccountNumber(10);
            expireDate = ExpiredDate(5, 0);
        }
    }
}
