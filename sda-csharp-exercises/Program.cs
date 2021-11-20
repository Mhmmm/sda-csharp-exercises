using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //person.WhoAmI();
            //person.LastName = "Jan";
            //person.FirstName = "Kowalski";
            //person.YearOfBirth = 1981;
            //person.WhoAmI();
            //Console.WriteLine(person.IsAdult());

            //Person person = new Person()
            //{
            //    FirstName = "Jan",
            //    LastName = "Kowalski",
            //    YearOfBirth = 1981
            //};
            //person.WhoAmI();
            //Console.WriteLine(person.IsAdult());
            Employee employee = new Employee();
            employee.FirstName = "Jan";
            employee.LastName = "Kowalski";
            employee.YearOfBirth = 1981;
            employee.Salary = 5000;

            employee.WhoAmI();
        }
    }
}
