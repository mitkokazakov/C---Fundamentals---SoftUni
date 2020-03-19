using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            List<char> specialSymbols = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (!Char.IsDigit(currentChar))
                {
                    if (!specialSymbols.Contains(currentChar))
                    {
                        specialSymbols.Add(currentChar);
                    }
                }
                
            }
            string pattern = @"([^0-9]+)([0-9]+)";

            Regex regex = new Regex(pattern);
            var matches = regex.Matches(input);
            string finalRes = String.Empty;

            StringBuilder sb = new StringBuilder();

            foreach (Match m in matches)
            {
                string textTorepeat = m.Groups[1].Value.ToUpper();
                int count = int.Parse(m.Groups[2].Value);

                

                for (int i = 0; i < count; i++)
                {
                    sb.Append(textTorepeat);
                }
                
                //Console.WriteLine($"{textTorepeat} --- {count}");
            }

            finalRes = sb.ToString();

            Console.WriteLine($"Unique symbols used: {specialSymbols.Count}");
            Console.WriteLine(finalRes);
        }
    }
}
