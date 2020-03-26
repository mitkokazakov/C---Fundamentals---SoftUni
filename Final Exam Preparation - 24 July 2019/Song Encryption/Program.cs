using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Song_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"^([A-Z][a-z ']+):([A-Z ]+)$";
            
            while (input != "end")
            {
                var validInput = Regex.Match(input, pattern);
                StringBuilder decryptedInput = new StringBuilder();

                if (validInput.Success)
                {
                    string artist = validInput.Groups[1].Value;
                    int key = artist.Length;
                    input = input.Replace(':','@');

                    for (int i = 0; i < input.Length; i++)
                    {
                        char currentChar = input[i];
                        
                        int assumedChar = currentChar + key;

                        // Check wether currentChar is not whitespace, apostrophes or @.

                        if (currentChar != ' ' && currentChar != '\'' && currentChar != '@')
                        {
                            DecryptCharIfIsUpper(decryptedInput, currentChar, assumedChar);

                            DecryptCharIfIsLower(decryptedInput, currentChar, assumedChar);
                        }
                        else
                        {
                            decryptedInput.Append(currentChar);
                        }
                    }

                    Console.WriteLine($"Successful encryption: {decryptedInput.ToString()}");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                input = Console.ReadLine();
            }
        }

        private static void DecryptCharIfIsLower(StringBuilder decryptedInput, char currentChar, int assumedChar)
        {
            if (Char.IsLower(currentChar) && assumedChar > 122)
            {
                int remainder = assumedChar - 122;
                char newChar = Convert.ToChar(96 + remainder);
                decryptedInput.Append(newChar);
            }
            else if (Char.IsLower(currentChar) && assumedChar <= 122)
            {
                decryptedInput.Append(Convert.ToChar(assumedChar));
            }
        }

        private static void DecryptCharIfIsUpper(StringBuilder decryptedInput, char currentChar, int assumedChar)
        {
            if (Char.IsUpper(currentChar) && assumedChar > 90)
            {
                int remainder = assumedChar - 90;
                char newChar = Convert.ToChar(64 + remainder);
                decryptedInput.Append(newChar);
            }
            else if (Char.IsUpper(currentChar) && assumedChar <= 90)
            {
                decryptedInput.Append(Convert.ToChar(assumedChar));
            }
        }
    }
}
