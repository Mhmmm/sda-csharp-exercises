using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var wynik = CalculatePaymentPlan(300000, 25, 4.7); //300k 25 lat 4.7%
            Console.WriteLine(wynik);
        }

        //A– wysokość kredytu
        //b– oprocentowanie w skali roku(stopy procentowe plus marża banku)
        //n– ilość rat do spłaty(okres kredytowania l (jak lata) pomnożony przez m, czyli 12, bo tyle jest miesięcy w roku)
        //R– to będzie wysokość naszej raty
        //C– całkowita kwota do spłaty

        

        //q = 1+(b/m)
        //m = liczba miesięcy

        //Dla podanych: kwoty kredytu, liczby miesięcy oraz oprocentowania wypisz wysokość
        //poszczególnych rat oraz całkowitą kwotę do spłaty(czyli sumę wszystkich rat)

        public static double CalculatePaymentPlan(double amount, int years, double percentage)
        {
            double A = amount;
            int m = 12;
            int n = years * 12; //ilość lat
            double R = 0; //wysokość raty
            double b = percentage; //wysokość oprocentowania

            double q = 1 + (b / m);
            //R=A*(q^n)*(q-1)/[(q^n)-1]

            R = A * Math.Pow(q, n) * (q-1) / ((Math.Pow(q, n)-1));

            return R;
        }
    }
}
