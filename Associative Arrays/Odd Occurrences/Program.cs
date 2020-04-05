using System;
using System.Linq;
using System.Collections.Generic;

namespace Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            Dictionary<string, int> oddOccur = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string lowerCaseWord = word.ToLower();
                if (oddOccur.ContainsKey(lowerCaseWord))
                {
                    oddOccur[lowerCaseWord]++;
                }
                else
                {
                    oddOccur[lowerCaseWord] = 1;
                }
            }

            foreach (var word in oddOccur)
            {
                if (word.Value % 2 !=0)
                {
                    Console.Write($"{word.Key} ");
                }
            }
            Console.WriteLine();
        }
    }
}
