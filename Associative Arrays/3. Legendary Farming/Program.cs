using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            keyMaterials["fragments"] = 0;
            keyMaterials["shards"] = 0;
            keyMaterials["motes"] = 0;

            SortedDictionary<string, int> junkMaterials = new SortedDictionary<string, int>();

            int fragmetsQuantity = 0;
            int motesQuantity = 0;
            int shardsQuantity = 0;
            bool reached = false;

            while (true)
            {
                if (reached)
                {
                    break;
                }
                string[] input = Console.ReadLine().Split();

                for (int i = 0; i <= input.Length-1; i= i+2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1].ToLower();

                    if (material == "fragments")
                    {
                        fragmetsQuantity += quantity;

                        if (fragmetsQuantity >= 250)
                        {
                            fragmetsQuantity = fragmetsQuantity - 250;
                            keyMaterials[material] = fragmetsQuantity;
                            Console.WriteLine("Valanyr obtained!");
                            reached = true;
                            break;
                        }
                        
                        keyMaterials[material] = fragmetsQuantity;
                    }
                    else if (material == "shards")
                    {
                        shardsQuantity += quantity;
                        if (shardsQuantity >= 250)
                        {
                            shardsQuantity = shardsQuantity - 250;
                            keyMaterials[material] = shardsQuantity;
                            Console.WriteLine("Shadowmourne obtained!");
                            reached = true;
                            break;
                        }
                        
                        keyMaterials[material] = shardsQuantity;
                    }
                    else if (material == "motes")
                    {
                        motesQuantity += quantity;
                        if (motesQuantity >= 250)
                        {
                            motesQuantity = motesQuantity - 250;
                            keyMaterials[material] = motesQuantity;
                            Console.WriteLine("Dragonwrath obtained!");
                            reached = true;
                            break;
                        }
                        
                        keyMaterials[material] = motesQuantity;
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials[material] = 0;
                        }

                        junkMaterials[material] += quantity;
                    }
                }
            }

            foreach (var materials in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{materials.Key}: {materials.Value}");
            }

            foreach (var junks in junkMaterials)
            {
                Console.WriteLine($"{junks.Key}: {junks.Value}");
            }
        }
    }
}
