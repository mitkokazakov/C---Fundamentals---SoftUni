using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parking = new Dictionary<string, string>();

            int numOfcommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfcommands; i++)
            {
                string[] commands = Console.ReadLine().Split();
                string mainCommand = commands[0];
                

                if (mainCommand == "register")
                {
                    string name = commands[1];
                    string regNumber = commands[2];

                    if (parking.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {regNumber}");
                    }
                    else
                    {
                        parking.Add(name, regNumber);
                        Console.WriteLine($"{name} registered {regNumber} successfully");
                    }
                }
                else if (mainCommand == "unregister")
                {
                    string name = commands[1];

                    if (!parking.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        parking.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                }
            }

            foreach (var user in parking)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
