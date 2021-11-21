using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class BasicAccount
    {
        public decimal Balance { get; private set; }
        public decimal Interest { get; private set; }
        public AccountType AccountType { get; private set; }

        public BasicAccount(AccountType accountType)
        {
            AccountType = accountType;
        }

        public void IncreaseBalance(decimal value)
        {
            Balance += value;
        }

        public void IncreaseInterest(decimal interest)
        {
            if (this.AccountType != AccountType.SavingAccount)
            {
                throw new ArgumentException("Operacja nieobsługiwana dla tego typu konta.", "Typ konta");
            }
            Interest += interest;
        }
        public decimal GetValue()
        {
            if (AccountType == AccountType.Account)
            {
                return Balance;
            }
            else if (AccountType == AccountType.SavingAccount)
            {
                return Balance + Interest;
            }
            else
            {
                throw new ArgumentException("Nie można pobrać salda dla tego typu konta.");
            }
        }
    }

    public enum AccountType { Account, SavingAccount };
}
