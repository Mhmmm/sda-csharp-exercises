using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Account
    {

        public decimal Balance { get; private set; }

        public Account(decimal balance = 0M)
        {
            Balance = balance;
        }

        public void IncreaseBalance(decimal amount)
        {
            Balance += amount;
        }

        public virtual decimal GetValue()
        {
            return Balance;
        }
    }
}
