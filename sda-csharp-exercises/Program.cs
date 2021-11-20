using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            CountWords("ala i ola mają koty");
        }
        public static void CountWords(string phrase)
        {
            string[] words = phrase.Split(' ');

            int maxLength = 0;

            foreach (string word in words)
            {
                maxLength = Math.Max(maxLength, word.Length); //sprawdzanie najdłuższego wyrazu
            }

            for (int i = 1; i <= maxLength; i++)
            {
                for (int j = 0; j <= words[i].Length; j++)
                {
                    if (words[i].Length != 0)
                    {
                        Console.WriteLine($"długość {i} - WYRAZ TUTAJ - liczba słów - ILOŚĆ SŁÓW TUTAJ");
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
