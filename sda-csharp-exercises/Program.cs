using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            //Account account1 = new Account(1000M);
            SavingAccount account2 = new SavingAccount(800M, 200M);
            ///Account account3 = new SavingAccount();
            //account3.IncreaseBalance(900M);
            //account3.IncreaseBalance(100M);
            //bank.AddAccount(account1);
            bank.AddAccount(account2);
            //bank.AddAccount(account3);



            //Console.WriteLine(account1.GetValue());
            Console.WriteLine(account2.GetValue());
            //Console.WriteLine(account3.GetValue());

            Console.WriteLine("Total: " + bank.GetValue());
        }
    }
}
