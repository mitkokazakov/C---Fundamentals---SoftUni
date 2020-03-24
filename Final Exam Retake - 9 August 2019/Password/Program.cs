using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(.+)>(\d{3})\|([a-z]{3})\|([A-Z]{3})\|([^<>\s]{3})<\1$";

            int numOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfLines; i++)
            {
                string input = Console.ReadLine();

                var validPasswords = Regex.Match(input, pattern);

                if (validPasswords.Success)
                {
                    string firstGroup = validPasswords.Groups[2].Value;
                    string secondGroup = validPasswords.Groups[3].Value;
                    string thirdGroup = validPasswords.Groups[4].Value;
                    string fourthGroup = validPasswords.Groups[5].Value;
                    Console.WriteLine($"Password: {firstGroup}{secondGroup}{thirdGroup}{fourthGroup}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
                
            }
        }
    }
}
