using System;
using System.Linq;
using System.Collections.Generic;

namespace Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            SortedDictionary<string, int> numOfOccur = new SortedDictionary<string, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numOfOccur.ContainsKey(numbers[i]))
                {
                    numOfOccur[numbers[i]]++;
                }
                else
                {
                    numOfOccur[numbers[i]] = 1;
                }
            }

            foreach (var number in numOfOccur)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
