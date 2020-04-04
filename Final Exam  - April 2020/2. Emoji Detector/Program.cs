using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _2._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternForEmoji = @"([:]{2}|[**]{2})([A-Z]{1}[a-z]{2,})\1";
            string patternForDigits = @"\d";

            long coolTreshold = 1;

            string text = Console.ReadLine();

            var validEmojies = Regex.Matches(text,patternForEmoji);

            var allDigits = Regex.Matches(text,patternForDigits);

            foreach (Match digit in allDigits)
            {
                coolTreshold *= long.Parse(digit.Value);
            }

            Console.WriteLine($"Cool threshold: {coolTreshold}");
            Console.WriteLine($"{validEmojies.Count} emojis found in the text. The cool ones are: ");

            foreach (Match emoji in validEmojies)
            {
                string currentEmoji = emoji.Groups[2].Value;
                int coolness = 0;

                for (int i = 0; i < currentEmoji.Length; i++)
                {
                    coolness += currentEmoji[i];
                }

                if (coolness >= coolTreshold)
                {
                    Console.WriteLine($"{emoji.Groups[1]}{currentEmoji}{emoji.Groups[1]}");
                }
            }
        }
    }
}
