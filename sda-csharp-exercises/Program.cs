using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Name = "Conan";
            //player.Stats = new PlayerStats(); //inicializacja wewnątrz klasy
            //player.Stats.Experience = 60;
            player.Experience = 60;
            Item sword = new Item();
            sword.Name = "Excalibur";
            player.Items.Add(sword);
            Console.WriteLine($"HP:{player.Health}\nEXP:{player.Experience}");
            foreach (Item item in player.Items)
            {
                Console.WriteLine("-" + item.Name);
            }
        }
    }
}
