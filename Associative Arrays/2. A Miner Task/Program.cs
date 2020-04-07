using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource = " ";
            Dictionary<string, int> numOfOccur = new Dictionary<string, int>();

            while (resource != "stop")
            {
                resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                

                if (!numOfOccur.ContainsKey(resource))
                {
                    numOfOccur[resource] = 0;
                }

                numOfOccur[resource] += quantity;
            }

            foreach (var item in numOfOccur)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
