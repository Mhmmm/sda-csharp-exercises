using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Person
    {
        private string firstName;
        
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName { get; set; }

        public int YearOfBirth { get; set; }

        public Person() : this("", "", 1900)
        {
            Console.WriteLine("Called Person constructor without parameters.");
        }

        public Person(string firstName, string lastName, int yearOfBirth)
        {
            Console.WriteLine("Called Person constructor with parameters.");

            FirstName = firstName;
            LastName = lastName;
            YearOfBirth = yearOfBirth;
        }

        public void WhoAmI()
        {
            Console.WriteLine($"My name is {LastName}. {FirstName} {LastName}.");
        }

        public bool IsAdult() => DateTime.Today.Year - YearOfBirth >= 18;
        //{
        //    return DateTime.Today.Year - YearOfBirth >= 18;
        //}
    }
}
