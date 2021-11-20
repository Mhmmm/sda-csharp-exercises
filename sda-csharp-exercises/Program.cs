using System;
using System.Collections.Generic;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog pies = new Dog("Kajtek");
            Cat kot = new Cat("Mruczek");

            List<Animal> animals = new List<Animal>();
            animals.Add(pies);
            animals.Add(kot);

            foreach (Animal animal in animals)
            {
                if (animal is Cat)
                {
                    animal.MakeSound();
                    Console.WriteLine("To jest kot.");
                }
                else if (animal is Dog)
                {
                    animal.MakeSound();
                    Console.WriteLine("To jest pies.");
                }
                else
                {
                    Console.WriteLine("To jest jakieś inne zwierzę.");
                }
            }

        }
    }
}
