using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Factorial(-5));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(FactorialRecursive(3));
        }
        public static int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Nie można wyliczyć silni dla liczby ujemnej!");
            }

            int result = 1;


            for (int i = number; i > 1; i--)
            {
                result *= i;
            }

            return result;
        }

        public static int FactorialRecursive(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            return number * FactorialRecursive(number - 1);
        }
    }
}
