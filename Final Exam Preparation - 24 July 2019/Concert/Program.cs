using System;
using System.Linq;
using System.Collections.Generic;

namespace Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> bandInfo = new Dictionary<string, List<string>>();
            Dictionary<string, int> timeAmount = new Dictionary<string, int>();

            string commands = Console.ReadLine();

            while (commands != "start of concert")
            {
                string[] commandArgs = commands.Split("; ");
                string mainCommand = commandArgs[0];
                string bandName = commandArgs[1];

                if (mainCommand == "Add")
                {
                    string[] members = commandArgs[2].Split(", ");

                    AddMembers(bandInfo, bandName, members);
                }
                else if (mainCommand == "Play")
                {
                    AddTimeToTheBand(timeAmount, commandArgs, bandName);
                }

                commands = Console.ReadLine();
            }

            string filter = Console.ReadLine();

            Console.WriteLine($"Total time: {timeAmount.Values.Sum()}");

            PrintTimeOfEachBand(timeAmount);

            var filteredBands = bandInfo.Where(x => x.Key == filter);
            Console.WriteLine(filter);

            PrintMembersOfCertainBand(filteredBands);
        }

        private static void PrintMembersOfCertainBand(IEnumerable<KeyValuePair<string, List<string>>> filteredBands)
        {
            foreach (var band in filteredBands)
            {
                foreach (var member in band.Value)
                {
                    Console.WriteLine($"=> {member}");
                }

            }
        }

        private static void PrintTimeOfEachBand(Dictionary<string, int> timeAmount)
        {
            foreach (var band in timeAmount.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{band.Key} -> {band.Value}");
            }
        }

        private static void AddTimeToTheBand(Dictionary<string, int> timeAmount, string[] commandArgs, string bandName)
        {
            int time = int.Parse(commandArgs[2]);

            if (!timeAmount.ContainsKey(bandName))
            {
                timeAmount[bandName] = 0;
                timeAmount[bandName] += time;
            }
            else
            {
                timeAmount[bandName] += time;
            }
        }

        private static void AddMembers(Dictionary<string, List<string>> bandInfo, string bandName, string[] members)
        {
            if (!bandInfo.ContainsKey(bandName))
            {
                bandInfo[bandName] = new List<string>();
                for (int i = 0; i < members.Length; i++)
                {
                    if (!bandInfo[bandName].Contains(members[i]))
                    {
                        bandInfo[bandName].Add(members[i]);
                    }
                }
            }
            else if (bandInfo.ContainsKey(bandName))
            {
                for (int i = 0; i < members.Length; i++)
                {
                    if (!bandInfo[bandName].Contains(members[i]))
                    {
                        bandInfo[bandName].Add(members[i]);
                    }
                }
            }
        }
    }
}
