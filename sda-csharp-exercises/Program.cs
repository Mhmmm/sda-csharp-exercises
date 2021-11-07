using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(checkPesel("55030101193")); //3
            Console.WriteLine(checkPesel("55030101230")); //0
            Console.WriteLine(checkPesel("12345678901")); //niepoprawny pesel

        }
        /*
        Dla numeru PESEL podanego jako tekst, sprawdź, czy ma on poprawną cyfrę kontrolną zgodnie z
        algorytmem podanym na stronie
        pl.wikipedia.org/wiki/PESEL#Cyfra_kontrolna_i_sprawdzanie_poprawności_numeru
        Liczby, przez które mnożymy poszczególne cyfry numeru PESEL nazywają się wagami.
        Utwórz tablicę, w której zapiszesz te wagi i wykorzystaj tę tablicę do sprawdzenia poprawności
        cyfry kontrolnej.
        */

        public static bool checkPesel(string peselNumber)
        {
            int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int[] sumNumbers = new int[10];
            int valueS = 0;

            for (int i = 0; i < weights.Length; i++)
            {
                sumNumbers[i] = Convert.ToInt32(peselNumber[i]) * weights[i];
                valueS += sumNumbers[i];
            }

            int valueM = valueS % 10;

            if (peselNumber[peselNumber.Length-1] == 0 && valueM == 0)
                return true;
            else if ((10-valueM) == peselNumber[peselNumber.Length-1])
                return true;

            return false;
        }

    }
}
