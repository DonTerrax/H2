using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class MasterCard : Card
    {
        public MasterCard(string cardOwner) : base(cardOwner)
        {
            List<string> mastercardPrefix = new List<string> {"51","52","53","54","55" };
            cardNumber = ReturnPrefix(mastercardPrefix) + " " + RandomCardNumber(14);
            accountNumber = accountRegNumber + " " + RandomAccountNumber(10);
            expireDate = ExpiredDate(5, 0);
        }
    }
}
 