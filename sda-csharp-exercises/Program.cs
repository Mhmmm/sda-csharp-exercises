using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static void CountWords(string phrase)
        {
            string[] words = phrase.Split(' ');
            //może string[][]?
            int maxLength = 0;

            foreach (string word in words)
            {
                maxLength = Math.Max(maxLength, word.Length); //sprawdzanie najdłuższego wyrazu
            }

            for (int i = 1; i <= maxLength; i++)
            {
                Console.WriteLine($"długość {i} - WYRAZY TUTAJ - liczba słów - ILOŚĆ SŁÓW TUTAJ");
            }

            Console.WriteLine();
        }
    }
}
