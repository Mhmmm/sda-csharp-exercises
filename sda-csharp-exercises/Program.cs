using System;
using System.Collections.Generic;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Jan", "Kowalski", 1981, 5000));
            employees.Add(new Manager("Adam", "Nowak", 2000, 5000));

            foreach (Employee e in employees)
            {
                Console.WriteLine(e);
            }
        }
    }
}
