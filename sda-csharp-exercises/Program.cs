using System;
using System.Collections.Generic;

namespace sda_csharp_exercises
{
    class Program
    {
        static void PrintHello(Person person)
        {
            if (person.IsAdult())
                Console.WriteLine("Welcome to liquor store");
            else
                Console.WriteLine("Welcome to toy store");
        }
        static void Main(string[] args)
        {
            Person person = new Person("Jan", "Kowalski", 1981);
            Employee employee = new Employee("Adam", "Nowak", 2000, 5000);
            Person person2 = new Employee("Joanna", "Kowalska", 1982, 6000);
            //Employee employee2 = (Employee)person2;
            //Employee employee2 = person2 as Employee;
            Person person3 = new Person("Joanna", "Nowak", 2015);

            List<Person> people = new List<Person>();
            people.Add(person);
            people.Add(employee);
            people.Add(person2);
            people.Add(person3);

            foreach (Person p in people)
            {
                Console.WriteLine();
                if (p is Employee e)
                {
                    p.WhoAmI();
                    Console.WriteLine("Is Employee");
                    Console.WriteLine("Salary = " + e.Salary);
                }
                else if (p is Person)
                {
                    p.WhoAmI();
                    Console.WriteLine("Is Person");
                }
                else
                {
                    Console.WriteLine("No idea?!");
                }
                PrintHello(p);
            }
        }
    }
}
