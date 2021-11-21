using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            BasicAccount account1 = new BasicAccount(AccountType.Account);
            account1.IncreaseBalance(1000M);
            //account1.IncreaseInterest(200M);
            BasicAccount account2 = new BasicAccount(AccountType.SavingAccount);
            account2.IncreaseBalance(1000M);
            account2.IncreaseInterest(200M);

            bank.AddAccount(account1);
            bank.AddAccount(account2);

            Console.WriteLine("Basic: " + account1.GetValue());
            Console.WriteLine("Saving: " + account2.GetValue());
            Console.WriteLine("TOTAL: " + bank.GetValue());
        }
    }
}
