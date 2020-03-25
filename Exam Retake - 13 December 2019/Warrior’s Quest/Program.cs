using System;
using System.Linq;
using System.Text;

namespace Warrior_s_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string commands = Console.ReadLine();

            while (commands != "For Azeroth")
            {
                string[] commandArgs = commands.Split();
                string mainCommand = commandArgs[0];

                if (mainCommand == "GladiatorStance")
                {
                    text = MakeAllCharsUpperCase(text);
                    Console.WriteLine(text);
                }
                else if (mainCommand == "DefensiveStance")
                {
                    text = MakeAllCharsLowerCase(text);
                    Console.WriteLine(text);
                }
                else if (mainCommand == "Dispel")
                {
                    int index = int.Parse(commandArgs[1]);
                    string character = commandArgs[2];

                    text = ChangeLetterAtGivenIndex(text, index, character);
                }
                else if (mainCommand == "Target")
                {
                    string action = commandArgs[1];
                    
                    if (action == "Change")
                    {
                        string firstSubs = commandArgs[2];
                        string secondSubs = commandArgs[3];
                        if (text.Contains(firstSubs))
                        {
                            text = text.Replace(firstSubs, secondSubs);
                            Console.WriteLine(text);
                        }
                        
                    }
                    else if (action == "Remove")
                    {
                        string firstSubs = commandArgs[2]; ;
                        if (text.Contains(firstSubs))
                        {
                            int indexOfFirstOccur = text.IndexOf(firstSubs);
                            text = text.Remove(indexOfFirstOccur, firstSubs.Length);
                            Console.WriteLine(text);
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Command doesn't exist!");
                    }
                }
                else
                {
                    Console.WriteLine("Command doesn't exist!");
                }
            

                commands = Console.ReadLine();
            }
        }

        public static string MakeAllCharsUpperCase(string text)
        {
            text = text.ToUpper();
            return text;
        }

        public static string MakeAllCharsLowerCase(string text)
        {
            text = text.ToLower();
            return text;
        }
        public static string ChangeLetterAtGivenIndex(string text, int index, string ch)
        {
            string newText = String.Empty;

            if (index < 0 || index >= text.Length)
            {
                Console.WriteLine("Dispel too weak.");
                newText = text;
            }
            else
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (i == index)
                    {
                        newText += ch;
                    }
                    else
                    {
                        newText += text[i];
                    }
                }

                Console.WriteLine("Success!");
            }

            return newText;
        }
    }
}
