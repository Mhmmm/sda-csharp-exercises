using System;
using System.Collections.Generic;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Jan", "Kowalski", 1981);
            Employee employee = new Employee("Adam", "Nowak", 2000, 5000);
            Person person2 = new Employee("Joanna", "Kowalska", 1982, 6000);
            List<Person> people = new List<Person>();
            people.Add(person);
            people.Add(employee);
            people.Add(person2);

            foreach (Person p in people)
            {
                if (p.GetType() == typeof(Person))
                {
                    p.WhoAmI();
                    Console.WriteLine("Is Person");
                }
                else if (p.GetType() == typeof(Employee))
                {
                    p.WhoAmI();
                    Console.WriteLine("Is Employee");
                    Employee e = (Employee)p;
                    Console.WriteLine("Salary = " + e.Salary);
                }
                else
                {
                    Console.WriteLine("No idea?!");
                }
            }
        }
    }
}
