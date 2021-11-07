using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Pow(2, 5);
            Pow(2, 0);
            Pow(2, -5);
        }

        public static void Pow(int number, int power)
        {
            int result = 1; //default result for power == 0

            if (power < 0)
            {
                Console.WriteLine("Power can't be lower than zero.");
                return;
            }

            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            Console.WriteLine(result);
        }
    }
}
