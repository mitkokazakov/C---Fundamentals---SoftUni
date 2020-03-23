using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Message_Encrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[\*@]{1}([A-Z]{1}[a-z]{2,})[\*@]{1}: \[([A-Za-z]+)\]\|\[([A-Za-z]+)\]\|\[([A-Za-z]+)\]\|$";

            int numOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfLines; i++)
            {
                string input = Console.ReadLine();

                var validMessage = Regex.Match(input,pattern);

                if (validMessage.Success)
                {
                    string tag = validMessage.Groups[1].Value;
                    string firstGroup = validMessage.Groups[2].Value;
                    string secondGroup = validMessage.Groups[3].Value;
                    string thirdGroup = validMessage.Groups[4].Value;

                    char one = Convert.ToChar(firstGroup);
                    char two = Convert.ToChar(secondGroup);
                    char third = Convert.ToChar(thirdGroup);

                    Console.Write($"{tag}: ");
                    Console.WriteLine($"{(int)one} {(int)two} {(int)third}");

                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
