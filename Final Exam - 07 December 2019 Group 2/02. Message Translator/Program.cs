using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02._Message_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfLines = int.Parse(Console.ReadLine());
            string pattern = @"!([A-Z]{1}[a-z]{2,})!:\[([A-Za-z]{8,})\]";

            for (int i = 0; i < numOfLines; i++)
            {
                string message = Console.ReadLine();

                var validMessages = Regex.Match(message, pattern);

                if (!validMessages.Success)
                {
                    Console.WriteLine("The message is invalid");
                }
                else
                {
                    string currentMessage = validMessages.Groups[2].Value.ToString();
                    Console.Write($"{validMessages.Groups[1].Value}: ");
                    for (int j = 0; j < currentMessage.Length ; j++)
                    {
                        int currentASCII = currentMessage[j];
                        Console.Write(currentASCII + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
