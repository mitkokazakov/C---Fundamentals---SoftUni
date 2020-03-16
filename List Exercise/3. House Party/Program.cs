using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCommands = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();

            HouseParty(numOfCommands, names);

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        private static void HouseParty(int numOfCommands, List<string> names)
        {
            for (int i = 0; i < numOfCommands; i++)
            {
                string input = Console.ReadLine();
                string[] inputArr = input.Split();

                if (input.Contains("not"))
                {

                    if (!names.Contains(inputArr[0]))
                    {
                        Console.WriteLine($"{inputArr[0]} is not in the list!");
                    }
                    else
                    {
                        names.Remove(inputArr[0]);
                    }
                }
                else
                {
                    if (!names.Contains(inputArr[0]))
                    {
                        names.Add(inputArr[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{inputArr[0]} is already in the list!");
                    }
                }
                //input = Console.ReadLine();
            }
        }
    }
}
