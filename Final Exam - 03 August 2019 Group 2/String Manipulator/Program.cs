using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace String_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string commands = Console.ReadLine();

            while (commands != "Done")
            {
                string[] commandArgs = commands.Split();
                string mainCommand = commandArgs[0];

                if (mainCommand == "Change")
                {
                    string oldChar = commandArgs[1];
                    string newChar = commandArgs[2];

                    while (text.Contains(oldChar))
                    {
                        text = text.Replace(oldChar, newChar);
                    }

                    Console.WriteLine(text);
                }
                else if (mainCommand == "Includes")
                {
                    string stringToContain = commandArgs[1];

                    if (text.Contains(stringToContain))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (mainCommand == "End")
                {
                    string endString = commandArgs[1];

                    bool result = text.EndsWith(endString);

                    Console.WriteLine(result.ToString());
                }
                else if (mainCommand == "Uppercase")
                {
                    text = text.ToUpper();
                    Console.WriteLine(text);
                }
                else if (mainCommand == "FindIndex")
                {
                    string wantedChar = commandArgs[1];
                    int index = text.IndexOf(wantedChar);
                    Console.WriteLine(index);
                }
                else if (mainCommand == "Cut")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);

                    string savedString = text.Substring(startIndex,endIndex);
                    text = savedString;
                    Console.WriteLine(text);
                }

                commands = Console.ReadLine();
            }
        }
    }
}
