using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Man_O_War
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            List<int> warShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            int maxHealth = int.Parse(Console.ReadLine());
            bool sunken = false;
            double sectionToRepair = 1.0 * maxHealth * 0.2;
            string commands = Console.ReadLine();

            while (commands != "Retire")
            {
                string[] commandArg = commands.Split();
                string mainCommand = commandArg[0];

                if (mainCommand == "Fire")
                {
                    int index = int.Parse(commandArg[1]);
                    int damage = int.Parse(commandArg[2]);

                    if (index >= 0 && index < warShip.Count)
                    {
                        warShip[index] -= damage;

                        if (warShip[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            sunken = true;
                            return;
                        }
                    }
                    
                    
                }
                else if (mainCommand == "Defend")
                {
                    int startIndex = int.Parse(commandArg[1]);
                    int endIndex = int.Parse(commandArg[2]);
                    int damage = int.Parse(commandArg[3]);

                    if (startIndex >= 0 && endIndex < pirateShip.Count)
                    {
                        for (int i = startIndex; i <= endIndex ; i++)
                        {
                            pirateShip[i] -= damage;
                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                sunken = true;
                                return;
                            }
                        }
                    }
                   
                }
                else if (mainCommand == "Repair")
                {
                    int index = int.Parse(commandArg[1]);
                    int health = int.Parse(commandArg[2]);

                    if (index >= 0 && index < pirateShip.Count)
                    {
                        pirateShip[index] += health;
                        if (pirateShip[index] > maxHealth)
                        {
                            pirateShip[index] = maxHealth;
                        }
                    }
                    
                }
                else if (mainCommand == "Status")
                {
                    int counter = 0;

                    for (int i = 0; i < pirateShip.Count; i++)
                    {
                        if (pirateShip[i] < sectionToRepair)
                        {
                            counter++;
                        }
                    }

                    Console.WriteLine($"{counter} sections needs repair.");
                }
                commands = Console.ReadLine();
            }

            if (sunken == false)
            {
                Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
                Console.WriteLine($"Warship status: {warShip.Sum()}");
            }
        }
    }
}
