using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace Username
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string commands = Console.ReadLine();

            while (commands != "Sign up")
            {
                string[] commandArgs = commands.Split();
                string mainCommnad = commandArgs[0];

                if (mainCommnad == "Case")
                {
                    if (commandArgs[1] == "upper")
                    {
                        text = text.ToUpper();
                    }
                    else if (commandArgs[1] == "lower")
                    {
                        text = text.ToLower();
                    }

                    Console.WriteLine(text);
                }
                else if (mainCommnad == "Reverse")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);

                    if (startIndex >= 0 && endIndex < text.Length)
                    {
                        string substring = text.Substring(startIndex, endIndex - startIndex + 1);
                        string reversedString = String.Empty;

                        for (int i = substring.Length - 1; i >= 0; i--)
                        {
                            reversedString += substring[i];
                        }
                        Console.WriteLine(reversedString);
                    }

                    
                }
                else if (mainCommnad == "Cut")
                {
                    string substring = commandArgs[1];

                    if (text.Contains(substring))
                    {
                        int start = text.IndexOf(substring);
                        text = text.Remove(start,substring.Length);
                        Console.WriteLine(text);
                    }
                    else
                    {
                        Console.WriteLine($"The word {text} doesn't contain {substring}.");
                    }
                }
                else if (mainCommnad == "Replace")
                {
                    char oldChar = Convert.ToChar(commandArgs[1]);

                    while (text.Contains(oldChar))
                    {
                        text = text.Replace(oldChar, '*');
                    }

                    Console.WriteLine(text);
                }
                else if (mainCommnad == "Check")
                {
                    string check = commandArgs[1];
                    if (text.Contains(check))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine($"Your username must contain {check}.");
                    }
                }
                commands = Console.ReadLine();
            }
        }
    }
}
