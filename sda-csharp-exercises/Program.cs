using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Jan", "Kowalski", 1981, 5000);
            Console.WriteLine(employee.Salary);
            Person person = new Employee("Adam", "Nowak", 2000, 6000);
            //Console.WriteLine(person.Salary);
            Employee employee2 = (Employee)person;
            Console.WriteLine(employee2.Salary);
            Person person2 = new Person("Anna", "Kowalska", 1982);
            Employee employee3 = (Employee)person2;
        }
    }
}
