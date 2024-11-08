using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3300Assignment9PerrinOwens
{
    internal class BankAccount
    {
        public string OwnerName { get; set; }
        public decimal Balance { get; set; }
        public string MonthOpened { get; set; }
        public double InterestRate { get; set; }
        public string Type { get; set; }

        public BankAccount(string ownerName, decimal balance, string monthOpened, double interestRate, string type)
        {
            OwnerName = ownerName;
            Balance = balance;
            MonthOpened = monthOpened;
            InterestRate = interestRate;
            Type = type;
        }

        public virtual decimal CalculateMinimumFee()
        {
            if (Balance < 1200)
            {
                return Balance * 0.073m;
            }
            return 0;
        }

        public override string ToString()
        {
            return
                $"Name: {OwnerName}, Balance: {Balance}, Month Opened: {MonthOpened}, Monthly Interest Rate: {InterestRate}";
        }
    }
}