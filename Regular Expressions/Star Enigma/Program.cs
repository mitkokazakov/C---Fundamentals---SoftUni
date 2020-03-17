using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int countLines = int.Parse(Console.ReadLine());
            string patternLetters = @"[S,s,T,t,R,r,A,a]";
            string patternMessage = @"@([A-Za-z]+)[^@\-!:>]*:(\d+)[^@\-!:>]*!([A,D])![^@\-!:>]*->(\d+)";

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < countLines; i++)
            {
                string input = Console.ReadLine();

                Regex countLetters = new Regex(patternLetters);

                var matchedLetters = countLetters.Matches(input);
                int key = matchedLetters.Count;
                string decrytedMessage = String.Empty;

                decrytedMessage = DecryptingMessage(input, key, decrytedMessage);

                Regex planetsInfo = new Regex(patternMessage);

                var validLines = planetsInfo.Match(decrytedMessage);
                if (validLines.Length > 0)
                {
                    SortThePlanetsIfTheyAreValid(attackedPlanets, destroyedPlanets, validLines);
                }

            }

            PrintAllValidPlanets(attackedPlanets, destroyedPlanets);
        }

        private static void PrintAllValidPlanets(List<string> attackedPlanets, List<string> destroyedPlanets)
        {
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var planet in attackedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var planet in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }

        private static void SortThePlanetsIfTheyAreValid(List<string> attackedPlanets, List<string> destroyedPlanets, Match validLines)
        {
            string planetName = validLines.Groups[1].Value;
            string attackType = validLines.Groups[3].Value;

            if (attackType == "A")
            {
                attackedPlanets.Add(planetName);
            }
            else if (attackType == "D")
            {
                destroyedPlanets.Add(planetName);
            }
        }

        private static string DecryptingMessage(string input, int key, string decrytedMessage)
        {
            for (int j = 0; j < input.Length; j++)
            {
                decrytedMessage += (char)(input[j] - key);
            }

            return decrytedMessage;
        }
    }
}
