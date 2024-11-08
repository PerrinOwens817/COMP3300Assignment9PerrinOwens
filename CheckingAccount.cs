using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3300Assignment9PerrinOwens
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(string ownerName, decimal balance, string monthOpened, double interestRate, string type)
            : base(ownerName, balance, monthOpened, interestRate, type)
        {
        }

        public override decimal CalculateMinimumBalanceFee()
        {
            if (Balance < 1000)
            {
                return Balance * 0.10m;
            }

            return 0;
        }

        public override string ToString()
        {
            return $"Account Type: {Type} - {base.ToString()}";
        }
    }
}
