using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Treasure_Hunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chest = Console.ReadLine().Split("|").ToList();
            string input = Console.ReadLine();

            while (input != "Yohoho!")
            {
                string[] commandArg = input.Split(" ",2);
                string mainCommand = commandArg[0];

                if (mainCommand == "Loot")
                {
                    string loots = commandArg[1];
                    string[] lootArg = loots.Split();
                   
                    for (int i = 0; i < lootArg.Length; i++)
                    {
                        if (!chest.Contains(lootArg[i]))
                        {
                            chest.Insert(0, lootArg[i]);
                        }
                    }
                    
                }
                else if (mainCommand == "Drop")
                {
                    int index = int.Parse(commandArg[1]);
                    if (index >=0 && index <= chest.Count-1)
                    {
                        string currentDroppedLoot = chest[index];
                        chest.RemoveAt(index);
                        chest.Add(currentDroppedLoot);
                    }
                }
                else if (mainCommand == "Steal")
                {
                    int count = int.Parse(commandArg[1]);
                    int removeFrom = chest.Count - count;

                    if (count > chest.Count)
                    {
                        removeFrom = 0;
                        count = chest.Count;
                    }

                    List<string> stolenLoots = new List<string>();

                    for (int i = removeFrom; i <= chest.Count-1; i++)
                    {
                        stolenLoots.Add(chest[i]);
                        
                    }
                    Console.WriteLine(String.Join(", ", stolenLoots));
                    chest.RemoveRange(removeFrom,count);
                    
                }
 
                input = Console.ReadLine();
            }

            //Console.WriteLine(String.Join(" ", chest));
            if (chest.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                double sumLen = 0;

                for (int i = 0; i < chest.Count; i++)
                {
                    sumLen += chest[i].Length;
                }

                double averageGain = sumLen / chest.Count;
                Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");
            }
            
        }
    }
}
