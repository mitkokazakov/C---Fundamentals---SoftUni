using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> numOfOccur = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    if (!numOfOccur.ContainsKey(input[i].ToString()))
                    {
                        numOfOccur[input[i].ToString()] = 0;
                    }
                    numOfOccur[input[i].ToString()]++;
                }
            }

            foreach (var letter in numOfOccur)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
