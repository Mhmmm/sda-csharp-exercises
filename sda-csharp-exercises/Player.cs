using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Player
    {
        public string Name { get; set; }
        protected PlayerStats Stats { get; set; } = new PlayerStats();
        public List<Item> Items { get; set; } = new List<Item>();

        public int Experience
        {
            get
            {
                return Stats.Experience;
            }
            set
            {
                Stats.Experience = value;
            }
        }

        public int Health
        {
            get
            {
                return Stats.Health;
            }
            set
            {
                Stats.Health = value;
            }
        }
    }
}
