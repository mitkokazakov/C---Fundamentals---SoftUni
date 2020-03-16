using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            WagonsUpdate(wagons, maxCapacity);

            Console.WriteLine(String.Join(" ", wagons));
        }

        private static void WagonsUpdate(List<int> wagons, int maxCapacity)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] currentInput = input.Split();

                if (currentInput[0] == "Add")
                {
                    wagons.Add(int.Parse(currentInput[1]));
                }
                else
                {
                    int currentPassanger = int.Parse(currentInput[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + currentPassanger <= maxCapacity)
                        {
                            wagons[i] += currentPassanger;
                            //i = -1;
                            break;
                        }
                    }
                }

                input = Console.ReadLine();

            }
        }
    }
}
