using System;
using System.Linq;
using System.Collections.Generic;

namespace Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> dwarfs = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "Once upon a time")
            {
                string[] dwarfsInfo = input.Split(" <:> ");
                string dwarfName = dwarfsInfo[0];
                string dwarfHat = dwarfsInfo[1];
                int physics = int.Parse(dwarfsInfo[2]);

                if (!dwarfs.ContainsKey(dwarfHat))
                {
                    dwarfs[dwarfHat] = new Dictionary<string, int>();
                }

                if (!dwarfs[dwarfHat].ContainsKey(dwarfName))
                {
                    dwarfs[dwarfHat].Add(dwarfName, physics);
                }

                if (dwarfs[dwarfHat][dwarfName] < physics)
                {
                    dwarfs[dwarfHat][dwarfName] = physics;
                }


                input = Console.ReadLine();
            }

            foreach (var hat in dwarfs.OrderByDescending(x => x.Value.Values.Max()).ThenByDescending(x => x.Value.Count()))
            {
                foreach (var dwarf in hat.Value)
                {
                    Console.WriteLine($"({hat.Key}) {dwarf.Key} <-> {dwarf.Value}");
                }
            }
        }
    }
}
