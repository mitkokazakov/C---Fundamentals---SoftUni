using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int[]> pirates = new Dictionary<string, int[]>();

            string input = Console.ReadLine();

            while (input != "Sail")
            {
                string[] inputInfo = input.Split("||");
                string town = inputInfo[0];
                int population = int.Parse(inputInfo[1]);
                int gold = int.Parse(inputInfo[2]);

                if (!pirates.ContainsKey(town))
                {
                    pirates[town] = new int[2];
                    pirates[town][0] = population;
                    pirates[town][1] = gold;
                }
                else
                {
                    pirates[town][0] += population;
                    pirates[town][1] += gold;
                }


                input = Console.ReadLine();
            }

            string commands = Console.ReadLine();

            while (commands != "End")
            {
                string[] commandsArgs = commands.Split("=>");
                string mainCommand = commandsArgs[0];

                if (mainCommand == "Plunder")
                {
                    string town = commandsArgs[1];
                    int people = int.Parse(commandsArgs[2]);
                    int gold = int.Parse(commandsArgs[3]);

                    if (pirates.ContainsKey(town))
                    {
                        pirates[town][0] -= people;
                        pirates[town][1] -= gold;

                        Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                    }

                    if (pirates[town][0] <= 0 || pirates[town][1] <= 0)
                    {
                        pirates.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                 }
                else if (mainCommand == "Prosper")
                {
                    string town = commandsArgs[1];
                    int gold = int.Parse(commandsArgs[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        pirates[town][1] += gold;

                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {pirates[town][1]} gold.");
                    }
                }

                commands = Console.ReadLine();
            }

            if (pirates.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {pirates.Count} wealthy settlements to go to:");

                foreach (var town in pirates.OrderByDescending(x => x.Value[1]).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{town.Key} -> Population: {town.Value[0]} citizens, Gold: {town.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
