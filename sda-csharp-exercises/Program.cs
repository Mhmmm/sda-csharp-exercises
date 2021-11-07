using System;
using System.Text.RegularExpressions;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(checkPasswordComplexity("SLABE*HASL0")); //brak malej litery
            Console.WriteLine(checkPasswordComplexity("slabe&hasl0")); //brak wielkiej litery
            Console.WriteLine(checkPasswordComplexity("slabe*HASLO")); //brak cyfry
            Console.WriteLine(checkPasswordComplexity("SLABEhasl0")); //brak znaku specjalnego
            Console.WriteLine(checkPasswordComplexity("$lAb3")); //zbyt krotkie haslo
            Console.WriteLine(checkPasswordComplexity("$ILNEhasl0")); //wszystkie warunki spełnione
        }

        /*
        • długość co najmniej 6 znaków
        • występują co najmniej jedna duża i jedna mała litera
        • występuje co najmniej jedna cyfra
        • występuje co najmniej jeden znak specjalny spośród następujących: &*$#
        */
        public static bool checkPasswordComplexity(string password)
        {
            Regex regexNum = new Regex(@"\d");
            Regex regexLower = new Regex(@"[a-z]");
            Regex regexUpper = new Regex(@"[A-Z]");
            Regex regexSign = new Regex(@"[&*$#]");

            if (!regexNum.IsMatch(password))
                return false;

            if (!regexLower.IsMatch(password))
                return false;

            if (!regexUpper.IsMatch(password))
                return false;

            if (!regexSign.IsMatch(password))
                return false;

            if (password.Length < 6)
                return false;

            return true;
        }
    }
}
