using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var resourcesQuantity = new Dictionary<string, int>();

            while (true)
            {
                var inputKey = Console.ReadLine();
                if (inputKey.Equals("stop"))
                {
                    break;
                }
                var inputValue = int.Parse(Console.ReadLine());

                AddResourcesQuantity(resourcesQuantity, inputKey, inputValue);
            }

            PrintResourcesQuantity(resourcesQuantity);
        }


        private static void AddResourcesQuantity(Dictionary<string, int> resourcesQuantity, string inputKey, int inputValue)
        {
            if (resourcesQuantity.ContainsKey(inputKey))
            {
                resourcesQuantity[inputKey] += inputValue;
            }
            else
            {
                resourcesQuantity[inputKey] = inputValue;
            }
        }


        private static void PrintResourcesQuantity(Dictionary<string, int> resourceQuantity)
        {
            foreach (var pair in resourceQuantity)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }
    }
}
