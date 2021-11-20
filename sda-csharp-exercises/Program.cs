using System;
using System.Collections.Generic;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person0 = new Person("Joanna", "Kowalska", 1982);
            person0.WhoAmI();
            Person person = new Employee("Adam", "Nowak", 2000, 6000);
            person.WhoAmI();
            Employee employee = new Employee("Jan", "Kowalski", 1981, 5000);
            employee.WhoAmI();
        }
    }
}
