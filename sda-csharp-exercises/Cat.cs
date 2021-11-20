using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Cat : Animal
    {
        private static readonly string SOUND = "miau";
        public Cat(string name) : base(name, SOUND)
        {

        }
    }
}
