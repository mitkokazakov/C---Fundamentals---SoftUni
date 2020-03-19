using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace Post_Office
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|");

            string firstPart = input[0];
            string secondPart = input[1];
            string thirdPart = input[2];

            string[] thirdPartArg = thirdPart.Split();

            string firstPattern = @"([#$%*&])([A-Z]+)\1";
            string secondPattern = @"([0-9]+[0-9]+):([0-9]+[0-9]+)";

            Regex regex1 = new Regex(firstPattern);

            var matches1 = regex1.Match(firstPart);
            string capitalLetters = matches1.Groups[2].Value;

            Regex regex2 = new Regex(secondPattern);

            var matches2 = regex2.Matches(secondPart);

            for (int i = 0; i < capitalLetters.Length; i++)
            {
                int currentLetter = capitalLetters[i];
                int lenOfWord = 0;

                foreach (Match digits in matches2)
                {
                    int currentDigit = int.Parse(digits.Groups[1].Value);

                    if (currentDigit == currentLetter)
                    {
                        lenOfWord = int.Parse(digits.Groups[2].Value);
                        break;
                    }
                }

                for (int j = 0; j < thirdPartArg.Length; j++)
                {
                    string currentWord = thirdPartArg[j];

                    if (currentWord.Length == lenOfWord+1 && currentWord[0] == capitalLetters[i])
                    {
                        Console.WriteLine(currentWord);
                        break;
                    }
                }
            }

            //Console.WriteLine(capitalLetters);
        }
    }
}
