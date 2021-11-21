using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Bank
    {
        private List<BasicAccount> accounts = new List<BasicAccount>();

        public void AddAccount(BasicAccount account)
        {
            accounts.Add(account);
        }

        public decimal GetValue()
        {
            decimal total = 0M;
            foreach (BasicAccount account in accounts)
            {
                total += account.GetValue();
            }
            return total;
        }
    }
}
