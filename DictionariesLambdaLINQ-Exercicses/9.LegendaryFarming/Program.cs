using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            //adding name of key materials before input information. So if there are no "fragments" added in the end we will see "fragments: 0".
            keyMaterials.Add("shards", new int());
            keyMaterials.Add("fragments", new int());
            keyMaterials.Add("motes", new int());

            SortedDictionary<string, int> junkMaterials = new SortedDictionary<string, int>();

            bool isThere250 = false;
            string enoughtMaterial = "";

            while (isThere250 == false) //break "while" loop when there are 250
            {
                string[] inputLine = Console.ReadLine().Split(' ').ToArray();

                //add materials
                for (int i = 0; i < inputLine.Length; i +=2)
                {
                    int quantityOfMaterial = int.Parse(inputLine[i]);
                    string typeOfMaterial = inputLine[i + 1].ToLower();

                    //add to key materials
                    if (typeOfMaterial.Equals("shards") || 
                        typeOfMaterial.Equals("fragments") ||
                        typeOfMaterial.Equals("motes"))
                    {
                        keyMaterials[typeOfMaterial] += quantityOfMaterial;

                        // "With 1 bullet - 2 rabbits"               
                        if (keyMaterials[typeOfMaterial] >= 250)    // 1) Find 250 of some material
                        {
                            enoughtMaterial = typeOfMaterial;       // 2) Save which is the material
                            keyMaterials[typeOfMaterial] -= 250;    // 3) Remove 250 from this material
                            isThere250 = true;                      // 4) Break "While" Loop
                            break;                                  // 5) Break "Foreach" loop
                        }
                    }

                    //add to junk materials
                    else
                    {
                        if (!junkMaterials.ContainsKey(typeOfMaterial))
                        {
                            junkMaterials.Add(typeOfMaterial, new int());
                        }

                        junkMaterials[typeOfMaterial] += quantityOfMaterial;
                    }
                }
            }

            //find obtained item
            string obtainedItem = "";
            if (enoughtMaterial.Equals("shards"))
            {
                obtainedItem = "Shadowmourne";
            }
            else if (enoughtMaterial.Equals("fragments"))
            {
                obtainedItem = "Valanyr";
            }
            else if (enoughtMaterial.Equals("motes"))
            {
                obtainedItem = "Dragonwrath";
            }

            //printing
            Console.WriteLine($"{obtainedItem} obtained!");

            foreach (var pair in keyMaterials.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }

            foreach (var pair in junkMaterials)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
