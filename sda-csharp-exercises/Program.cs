using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Person senior = new Person("Jan", "Kowalski", "Ul. Ostra", 10, "Krzemowa Dolina", 1956, 5, 21, "Andrzej", 4);
            Person junior = new Person("Jaś", "Kowalski", "Ul. Ostra", 10, "Krzemowa Dolina", 2012, 3, 27);
            Person osoba = new Person("Anna", "Kowalska", "Ul. Ostra", 10, "Krzemowa Dolina", 1985, 9, 14, "Małgorzata");

            Console.WriteLine(Greetings(senior, IsFemale(senior)));
            Console.WriteLine(Greetings(junior, IsFemale(junior)));
            Console.WriteLine(Greetings(osoba, IsFemale(osoba)));
        }

        public static bool IsFemale(Person person)
        {
            if (person.FirstName.EndsWith('a'))
            {
                return true;
            }
            return false;
        }
        public static int GetAge(Person person)
        {
            int age = DateTime.UtcNow.Year - person.YearOfBirth; //tak na szybko, zrobić poprawnie później
            return age;
        }
        public static string Greetings(Person person, bool gender)
        {
            string str = "";
            /*
            [Imię Drugie_Imię Nazwisko]
            [ul. Nazwa_ulicy Numer / numer_mieszkaniaMiasto]
            [Szanowna Pani | Szanowny Panie | Droga Użytkowniczko | Drogi Użytkowniku]
            Zapraszamy [Pana | Panią | Cię] serdecznie na otwarcie naszego sklepu!
            Powitamy[Pana | Panią | Cię][kieliszkiem szampana | kubkiem gorącej czekolady].
            [I zapraszamy do gry w bingo]
            [do zobaczenia | czekamy na Pana | czekamy na Panią | z wyrazami szacunku]

            Założenia:
            - w zależności od płci i wieku wyświetlamy odpowiednie powitanie i później formy (Pan lub Pani, a
            dla niepełnoletnich Ty i Użytkowniku lub Użytkowniczko
            - dla niepełnoletnich czekolada, dla pełnoletnich szampan
            - gra w bingo tylko dla seniorów (powyżej 60 lat)
            - zakończenie – „z wyrazami szacunku” dla seniorów, pozostałe w zalezności od płci i wieku
            - płeć powinna być przekazana jako parametr funkcji, możesz np.użyć odpowiednio liter ‘m’ i ‘k’
            lub liczb i założyć, że np. 1 to kobieta, 2 to mężczyzna, lub jako zmienna logiczna, np.isFemale
            - pamiętaj, że nie każdy ma drugie imię i numer mieszkania.
            */
            str += $"{person.FirstName}{(person.SecondName == "" ? " " : $" {person.SecondName} ")}{person.LastName}\n";
            str += $"{person.StreetName} {person.StreetNumber}{(person.ApartmentNumber == -1 ? "" : "/" + person.ApartmentNumber)} {person.City}\n";
            bool underage = (GetAge(person) < 18);
            str += (underage == true ? (gender ? "Droga Użytkowniczko" : "Drogi Użytkowniku") : (gender ? "Szanowna Pani" : "Szanowny Panie"));
            str += $"\nZapraszamy ";
            str += (underage ? "Cię" : (gender ? "Panią" : "Pana"));
            str += " serdecznie na otwarcie naszego sklepu!\nPowitamy ";
            str += (underage ? "Cię" : (gender ? "Panią" : "Pana"));
            str += " ";
            str += (underage ? "kubkiem gorącej czekolady" : "kieliszkiem szampana");
            bool senior = (GetAge(person) > 60);
            str += $".\n{(senior ? "I zapraszamy do gry w bingo\n" : "")}";
            str += (underage == true ? "do zobaczenia" : (senior == true ? "z wyrazami szacunku" : (gender ? "czekamy na Panią" : "czekamy na Pana")));
            str += "\n";

            return str;
        }
        public class Person
        {
            private string firstName;
            private string secondName;
            private string lastName;

            private string streetName;
            private int streetNumber;
            private int apartmentNumber;
            private string city;

            private int yearOfBirth, monthOfBirth, dayOfBirth;

            public string FirstName
            {
                get { return firstName; }
            }
            public string SecondName
            {
                get { return secondName; }
            }
            public string LastName
            {
                get { return lastName; }
            }
            public string StreetName
            {
                get { return streetName; }
            }
            public int StreetNumber
            {
                get { return streetNumber; }
            }
            public int ApartmentNumber
            {
                get { return apartmentNumber; }
            }
            public string City
            {
                get { return city; }
            }
            public int YearOfBirth
            {
                get { return yearOfBirth; }
            }
            public int MonthOfBirth
            {
                get { return yearOfBirth; }
            }
            public int DayOfBirth
            {
                get { return yearOfBirth; }
            }

            public Person(string firstName, string lastName, string streetName, int streetNumber,
                string city, int yearOfBirth, int monthOfBirth, int dayOfBirth, string secondName = "", int apartmentNumber = -1)
            {
                this.firstName = firstName;
                this.secondName = (secondName != "" ? secondName : "");
                this.lastName = lastName;
                this.streetName = streetName;
                this.streetNumber = streetNumber;
                this.apartmentNumber = (apartmentNumber == -1 ? -1 : apartmentNumber);
                this.city = city;
                this.yearOfBirth = yearOfBirth;
                this.monthOfBirth = monthOfBirth;
                this.dayOfBirth = dayOfBirth;
            }


        }
    }
}
