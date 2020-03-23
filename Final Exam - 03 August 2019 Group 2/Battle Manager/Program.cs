using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Battle_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int[]> battle = new Dictionary<string, int[]>();
            string commands = Console.ReadLine();

            while (commands != "Results")
            {
                string[] commandArgs = commands.Split(":");
                string mainCommand = commandArgs[0];

                if (mainCommand == "Add")
                {
                    string name = commandArgs[1];
                    int health = int.Parse(commandArgs[2]);
                    int energy = int.Parse(commandArgs[3]);

                    if (!battle.ContainsKey(name))
                    {
                        battle[name] = new int[2];
                        battle[name][0] = health;
                        battle[name][1] = energy;
                    }
                    else
                    {
                        battle[name][0] += health;
                    }

                }
                else if (mainCommand == "Attack")
                {
                    string attackerName = commandArgs[1];
                    string defenderName = commandArgs[2];
                    int damage = int.Parse(commandArgs[3]);

                    if (battle.ContainsKey(attackerName) && battle.ContainsKey(defenderName))
                    {
                        battle[defenderName][0] -= damage;

                        if (battle[defenderName][0] <= 0)
                        {
                            battle.Remove(defenderName);
                            Console.WriteLine($"{defenderName} was disqualified!");
                        }

                        battle[attackerName][1] -= 1;

                        if (battle[attackerName][1] <= 0)
                        {
                            battle.Remove(attackerName);
                            Console.WriteLine($"{attackerName} was disqualified!");
                        }
                    }

                }
                else if (mainCommand == "Delete")
                {
                    string username = commandArgs[1];

                    if (username == "All")
                    {
                        battle.Clear();
                    }

                    else if (battle.ContainsKey(username))
                    {
                        battle.Remove(username);
                    }
                }

                commands = Console.ReadLine();
            }

            Console.WriteLine($"People count: {battle.Keys.Count}");

            foreach (var user in battle.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key} - {user.Value[0]} - {user.Value[1]}");
            }
        }
    }
}
