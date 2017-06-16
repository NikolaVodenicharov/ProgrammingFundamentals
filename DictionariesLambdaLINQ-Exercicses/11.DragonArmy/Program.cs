using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputDragons = int.Parse(Console.ReadLine());

            var dragons = new Dictionary<string, SortedDictionary<string, decimal[]>>();

            for (int i = 0; i < numberOfInputDragons; i++)
            {
                // take the input information
                string[] inputDragon = Console.ReadLine().Split();

                string type = inputDragon[0];

                string name = inputDragon[1];

                decimal damage = 45;
                if (!inputDragon[2].Equals("null"))
                {
                    damage = decimal.Parse(inputDragon[2]);
                }

                decimal health = 250;
                if (!inputDragon[3].Equals("null"))
                {
                    health = decimal.Parse(inputDragon[3]);
                }

                decimal armor = 10;
                if (!inputDragon[4].Equals("null"))
                {
                    armor = decimal.Parse(inputDragon[4]);
                }

                // put the data in to the dictionary "dragons"
                if (!dragons.ContainsKey(type))
                {
                    dragons[type] = new SortedDictionary<string, decimal[]>();
                }

                dragons[type][name] = new decimal[] { damage, health, armor };
            }

            foreach (var pair in dragons)
            {
                string dragonType = pair.Key;
                var dragonValue = pair.Value;

                decimal avarageDamage = dragonValue.Values.Average(x => x[0]);
                decimal avarageHealt = dragonValue.Values.Average(x => x[1]);
                decimal avarageArmor = dragonValue.Values.Average(x => x[2]);

                Console.WriteLine($"{dragonType}::({avarageDamage:F2}/{avarageHealt:f2}/{avarageArmor:f2})");

                foreach (var dragon in dragonValue)
                {
                    string name = dragon.Key;
                    decimal damage = dragon.Value[0];
                    decimal health = dragon.Value[1];
                    decimal armor = dragon.Value[2];
                    Console.WriteLine($"-{name} -> damage: {damage}, health: {health}, armor: {armor}");
                }
            }
        }
    }
}
