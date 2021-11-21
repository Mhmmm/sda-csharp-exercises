using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    sealed class Manager : Employee
    {
        public Manager(string firstName, string lastName, int yearOfBirth, decimal salary)
            : base(firstName, lastName, yearOfBirth, salary)
        {
            Console.WriteLine("Called Manager constructor with parameters.");
        }

        public override decimal GetSalary()
        {
            return Salary * 1.10M;
        }
    }

    //class Director : Manager // nie można dziedziczyć po klasach "sealed"
    //{

    //}
}
