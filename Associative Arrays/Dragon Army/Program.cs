using System;
using System.Linq;
using System.Collections.Generic;

namespace Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, int[] >> dragons = new Dictionary<string, SortedDictionary<string, int[] >> ();

            int numDragons = int.Parse(Console.ReadLine());

            for (int i = 0; i < numDragons; i++)
            {
                string[] input = Console.ReadLine().Split();

                string type = input[0];
                string name = input[1];
                int damage = 0;
                int health = 0;
                int armor = 0;

                SetDefaultValues(input, out damage, out health, out armor);

                if (!dragons.ContainsKey(type))
                {
                    dragons[type] = new SortedDictionary<string, int[]>();
                }

                if (!dragons[type].ContainsKey(name))
                {
                    dragons[type][name] = new int[3];
                }

                dragons[type][name][0] = damage;
                dragons[type][name][1] = health;
                dragons[type][name][2] = armor;
            }

            foreach (var type in dragons)
            {
                Console.WriteLine($"{type.Key}::({type.Value.Select(x => x.Value[0]).Average():f2}/{type.Value.Select(x => x.Value[1]).Average():f2}/{type.Value.Select(x => x.Value[2]).Average():f2})");

                foreach (var name in type.Value)
                {
                    Console.WriteLine($"-{name.Key} -> damage: {name.Value[0]}, health: {name.Value[1]}, armor: {name.Value[2]}");
                }
            }

        }

        private static void SetDefaultValues(string[] input, out int damage, out int health, out int armor)
        {
            if (input[2] == "null")
            {
                damage = 45;
            }
            else
            {
                damage = int.Parse(input[2]);
            }

            if (input[3] == "null")
            {
                health = 250;
            }
            else
            {
                health = int.Parse(input[3]);
            }

            if (input[4] == "null")
            {
                armor = 10;
            }
            else
            {
                armor = int.Parse(input[4]);
            }
        }
    }
}
