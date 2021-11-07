using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Example string";
            Console.WriteLine("Input: " + str);                     //Input: Example string
            str = Leetify(str);
            Console.WriteLine("Leetified: " + str);                 //Leetified: 3x4mpl3 $tr1ng
            Console.WriteLine("Unleetified: " + Unleetify(str));    //Unleetified: example string
        }

        static char[] leetLetters = { '4', '3', '1', '0', '$' };
        static char[] naturalLetters = { 'a', 'e', 'i', 'o', 's' };

        public static string Leetify(string str)
        {
            string result = str.ToLower();

            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < naturalLetters.Length; j++)
                {
                    if (result[i] == naturalLetters[j])
                    {
                        result = result.Replace(result[i], leetLetters[j]);
                    }
                }
            }

            return result;
        }

        public static string Unleetify(string str)
        {
            string result = str;

            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < leetLetters.Length; j++)
                {
                    if (result[i] == leetLetters[j])
                    {
                        result = result.Replace(result[i], naturalLetters[j]);
                    }
                }
            }
            return result;
        }
    }
}
