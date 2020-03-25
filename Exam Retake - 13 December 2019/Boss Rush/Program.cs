using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Boss_Rush
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOffLines = int.Parse(Console.ReadLine());
            string pattern = @"\|([A-Z]{4,})\|:#([A-Za-z]+ [A-Za-z]+)#";

            for (int i = 0; i < numOffLines; i++)
            {
                string input = Console.ReadLine();

                var validInput = Regex.Match(input, pattern);

                if (validInput.Success)
                {
                    string bossName = validInput.Groups[1].Value;
                    string title = validInput.Groups[2].Value;

                    Console.WriteLine($"{bossName}, The {title}");
                    Console.WriteLine($">> Strength: {bossName.Length}");
                    Console.WriteLine($">> Armour: {title.Length}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }

            }
        }
    }
}
