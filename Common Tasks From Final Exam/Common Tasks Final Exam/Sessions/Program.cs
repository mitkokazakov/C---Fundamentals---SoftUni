using System;
using System.Collections.Generic;
using System.Linq;

namespace Sessions
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> racersInfo = new Dictionary<string, List<string>>();

            string commands = Console.ReadLine();

            while (commands != "END")
            {
                string[] commandArgs = commands.Split("->");
                string mainCommand = commandArgs[0];

                if (mainCommand == "Add")
                {
                    string road = commandArgs[1];
                    string racer = commandArgs[2];

                    if (!racersInfo.ContainsKey(road))
                    {
                        racersInfo[road] = new List<string>();
                    }
                    racersInfo[road].Add(racer);
                }
                else if (mainCommand == "Move")
                {
                    string currentRoad = commandArgs[1];
                    string racer = commandArgs[2];
                    string nextRoad = commandArgs[3];

                    if (racersInfo[currentRoad].Contains(racer))
                    {
                        racersInfo[nextRoad].Add(racer);
                        racersInfo[currentRoad].Remove(racer);
                    }
                }
                else if (mainCommand == "Close")
                {
                    string road = commandArgs[1];
                    if (racersInfo.ContainsKey(road))
                    {
                        racersInfo.Remove(road);
                    }
                }

                commands = Console.ReadLine();
            }

            Console.WriteLine("Practice sessions:");
            foreach (var road in racersInfo.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{road.Key}");

                foreach (var racer in road.Value)
                {
                    Console.WriteLine($"++{racer}");
                }
            }
        }
    }
}
