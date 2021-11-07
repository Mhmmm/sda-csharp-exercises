using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
            Console.WriteLine(FactorialRecursive(5));
        }
        public static int Factorial(int number)
        {
            int result = 1;
            for (int i = number; i > 1; i--)
            {
                result *= i;
            }

            return result;
        }

        public static int FactorialRecursive(int number)
        {
            int result = 1;
            result *= number;

            if (number > 1)
            {
                return result *= FactorialRecursive(number - 1);
            }

            return result;
        }

    }
}
