using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] {' ', ',' ,'\t', '\n' },StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, List<double>> demons = new Dictionary<string, List<double>>();

            //Console.WriteLine(String.Join(Environment.NewLine,input));

            string patternHealth = @"[^0-9.+\/*-]";
            //[+-]?[0-9]\.?[0-9]?
            string patternDamage = @"([-|+]?[0-9\.]*[0-9])";

            for (int i = 0; i < input.Length; i++)
            {
                string currentName = input[i];

                //if (currentName.Contains(' ') || currentName.Contains(','))
                //{
                //    continue;
                //}

                Regex health = new Regex(patternHealth);
                var symbolsForHealth = health.Matches(currentName);
                int sumHealth = 0;

                foreach (Match letter in symbolsForHealth)
                {
                    sumHealth += Convert.ToChar(letter.Value);
                }

                Regex damage = new Regex(patternDamage);
                var symbolsForDamage = damage.Matches(currentName);
                double sumDamage = 0;

                foreach (Match digit in symbolsForDamage)
                {
                    sumDamage += double.Parse(digit.Value);
                }

                for (int j = 0; j < currentName.Length; j++)
                {
                    if (currentName[j] == '*')
                    {
                        sumDamage *= 2.0;
                    }
                    else if (currentName[j] == '/')
                    {
                        sumDamage /= 2.0;
                    }
                }

                if (!demons.ContainsKey(currentName))
                {
                    demons[currentName] = new List<double>();
                }
                demons[currentName].Add(sumHealth);
                demons[currentName].Add(sumDamage);
                ///Console.WriteLine(sumHealth);
                //Console.WriteLine(sumDamage);
            }

            foreach (var demon in demons.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{demon.Key} - {demon.Value[0]} health, {demon.Value[1]:f2} damage");
            }
        }
    }
}
