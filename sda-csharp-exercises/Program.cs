using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                PriceList(i, 5);
            }
        }

        public static void PriceList(int amount, double price)
        {
            Console.WriteLine($"Liczba sztuk: {amount} łączna cena: {amount * price}zł");
        }
    }
}
