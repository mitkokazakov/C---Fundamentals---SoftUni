using System;
using System.Linq;
using System.Collections.Generic;

namespace AnimalsInTowns
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> animalsBook = new Dictionary<string, Dictionary<string, List<string>>>();

            string input = Console.ReadLine();

            while (input != "Stop")
            {
                string[] inputInfo = input.Split(" - ");
                string town = inputInfo[0];
                string name = inputInfo[1];
                string[] animals = inputInfo[2].Split(",");

                if (!animalsBook.ContainsKey(town))
                {
                    animalsBook[town] = new Dictionary<string, List<string>>();
                    animalsBook[town][name] = new List<string>();

                    for (int i = 0; i < animals.Length; i++)
                    {
                        animalsBook[town][name].Add(animals[i]);
                    }
                    
                }
                else
                {
                    if (!animalsBook[town].ContainsKey(name))
                    {
                        animalsBook[town][name] = new List<string>();

                        for (int i = 0; i < animals.Length; i++)
                        {
                            animalsBook[town][name].Add(animals[i]);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < animals.Length; i++)
                        {
                            if (!animalsBook[town][name].Contains(animals[i]))
                            {
                                animalsBook[town][name].Add(animals[i]);
                            }
                        }
                        
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var town in animalsBook.OrderByDescending(x => x.Value.Values.Count))
            {
                Console.WriteLine($"{town.Key}:");

                foreach (var name in town.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"- {name.Key}");

                    foreach (var animal in name.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"  -- {animal}");
                    }
                }
            }
        }
    }
}
