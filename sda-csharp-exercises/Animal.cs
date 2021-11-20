using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Animal
    {
        public string Name { get; set; }
        public string Sound { get; set; }

        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} wydaje dźwięk {this.Sound}");
        }
    }
}
