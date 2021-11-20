using System;
using System.Collections.Generic;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Jan", "Kowalski", 1981, 5000);

            employee.WhoAmIWithSalary();
        }
    }
}
