using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Maestro : Card
    {
        

        public Maestro(string cardOwner) : base(cardOwner)
        {
            List<string> maestroCardPrefix = new List<string> { "5018", "5020", "5038", "5893", "6304", "6759", "6761", "6762", "6763"};
            cardNumber = ReturnPrefix(maestroCardPrefix) +" " + RandomCardNumber(15);
            accountNumber = accountRegNumber + " " + RandomAccountNumber(10);
            expireDate = ExpiredDate(5, 8);
        }
    }
}

