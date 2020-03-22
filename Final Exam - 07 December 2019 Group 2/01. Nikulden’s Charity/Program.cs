using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace _01._Nikulden_s_Charity
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string commands = Console.ReadLine();

            while (commands != "Finish")
            {
                string[] commandArgs = commands.Split();
                string mainCommand = commandArgs[0];

                if (mainCommand == "Replace")
                {
                    input = ReplaceCurrentCharWithNew(input, commandArgs);
                }
                else if (mainCommand == "Cut")
                {
                    input = CutSubstringFromInput(input, commandArgs);
                    
                }
                else if (mainCommand == "Make")
                {
                    input = MakeInputLowerOrUpper(input, commandArgs);
                }
                else if (mainCommand == "Check")
                {
                    CheckIfCertainTextIsContained(input, commandArgs);
                }
                else if (mainCommand == "Sum")
                {
                    SumCharsFromSubstring(input, commandArgs);

                }
                commands = Console.ReadLine();
            }
        }

        private static void SumCharsFromSubstring(string input, string[] commandArgs)
        {
            int startIndex = int.Parse(commandArgs[1]);
            int endIndex = int.Parse(commandArgs[2]);

            if (startIndex < 0 || endIndex >= input.Length)
            {
                Console.WriteLine("Invalid indexes!");
            }
            else
            {
                string textToSum = input.Substring(startIndex, endIndex - startIndex + 1);
                int sum = 0;

                for (int i = 0; i < textToSum.Length; i++)
                {
                    sum += textToSum[i];
                }

                Console.WriteLine(sum);
            }
        }

        private static void CheckIfCertainTextIsContained(string input, string[] commandArgs)
        {
            string textToCheck = commandArgs[1];

            if (input.Contains(textToCheck))
            {
                Console.WriteLine($"Message contains {textToCheck}");
            }
            else
            {
                Console.WriteLine($"Message doesn't contain {textToCheck}");
            }
        }

        private static string MakeInputLowerOrUpper(string input, string[] commandArgs)
        {
            if (commandArgs[1] == "Upper")
            {
                input = input.ToUpper();
            }
            else if (commandArgs[1] == "Lower")
            {
                input = input.ToLower();
            }

            Console.WriteLine(input);
            return input;
        }

        private static string CutSubstringFromInput(string input, string[] commandArgs)
        {
            int startIndex = int.Parse(commandArgs[1]);
            int endIndex = int.Parse(commandArgs[2]);

            if (startIndex < 0 || endIndex >= input.Length || startIndex >= input.Length || endIndex <= 0)
            {
                Console.WriteLine("Invalid indexes!");
            }
            else
            {
                input = input.Remove(startIndex, endIndex - startIndex + 1);
                Console.WriteLine(input);
            }


            return input;
        }

        private static string ReplaceCurrentCharWithNew(string input, string[] commandArgs)
        {
            string cuurrentChar = commandArgs[1];
            string newChar = commandArgs[2];

            while (input.Contains(cuurrentChar))
            {
                input = input.Replace(cuurrentChar, newChar);
            }

            Console.WriteLine(input);
            return input;
        }
    }
}
