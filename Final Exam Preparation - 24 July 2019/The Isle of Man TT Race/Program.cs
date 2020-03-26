using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace The_Isle_of_Man_TT_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([$#%*&]{1})([A-Za-z]+)\1=([0-9]+)!!(.+)$";

            while (true)
            {
                string input = Console.ReadLine();

                var validInput = Regex.Match(input,pattern);

                if (validInput.Success)
                {
                    string racerName = validInput.Groups[2].Value;
                    int lenOfGeoCode = int.Parse(validInput.Groups[3].Value);
                    string coordinates = validInput.Groups[4].Value;
                    StringBuilder decryptedCoordinates = new StringBuilder();

                    if (coordinates.Length != lenOfGeoCode)
                    {
                        Console.WriteLine("Nothing found!");
                    }
                    else
                    {
                        DecryptGeoCoordinates(racerName, lenOfGeoCode, coordinates, decryptedCoordinates);
                        break;

                    }
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }

            }
        }

        private static void DecryptGeoCoordinates(string racerName, int lenOfGeoCode, string coordinates, StringBuilder decryptedCoordinates)
        {
            for (int i = 0; i < coordinates.Length; i++)
            {
                int currentChar = coordinates[i];
                char newChar = Convert.ToChar(currentChar + lenOfGeoCode);
                decryptedCoordinates.Append(newChar);
            }

            Console.WriteLine($"Coordinates found! {racerName} -> {decryptedCoordinates.ToString()}");
        }
    }
}
