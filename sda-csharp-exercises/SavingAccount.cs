using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class SavingAccount : Account
    {
        public decimal Interest { get; private set; }

        public SavingAccount(decimal balance = 0, decimal interest = 0) : base(balance)
        {
            Interest = interest;
        }

        public void IncreaseInterest(decimal interest)
        {
            Interest += interest;
        }

        public override decimal GetValue()
        {
            return Balance + Interest;
        }
    }
}
