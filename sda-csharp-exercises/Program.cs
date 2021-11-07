using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 5, 1, 2, 0, 5, 3, 1, 6, 8 };
            foreach (int num in PrintOnce(array))
            {
                if (num != -1)
                    Console.WriteLine(num);
            }
        }

        /*
        Dla podanej tablicy liczb naturalnych wypisz tylko niepowtarzające się liczby.
        Przykład:
        int[] numbers = {2,5,1,2,5};
        Wynik:
        2 5 1
        Podpowiedź:
        zauważ, że w tablicy będą tylko liczby naturalne, czyli >= 0. Duplikat możesz więc nadpisać
        dowolną liczbą ujemną
         */

        public static int[] PrintOnce(int[] numbers)
        {
            int[] finalNumbers = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (Array.IndexOf(finalNumbers, numbers[i]) == -1)
                {
                    finalNumbers[i] = numbers[i];
                }
                else
                {
                    finalNumbers[i] = -1;
                }
            }

            return finalNumbers;
        }
    }
}
