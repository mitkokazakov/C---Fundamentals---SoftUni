using System;
using System.Linq;
using System.Text;

namespace Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string input = Console.ReadLine();
            StringBuilder decryptedText = new StringBuilder();


            while (input != "find")
            {
                int lenOfKey = key.Length;

                for (int i = 0; i < input.Length; i++)
                {
                    if (i == lenOfKey)
                    {
                        input = input.Remove(0,lenOfKey);
                        i = 0;
                    }
                    
                    decryptedText.Append(Convert.ToChar(input[i] - key[i]));
                }

                string result = decryptedText.ToString();
                int firstIndexOftreasure = result.IndexOf('&') + 1;
                int lastIndexOfTreasure = result.LastIndexOf('&') - firstIndexOftreasure;
                int firstIndexOfCoordinates = result.IndexOf('<') + 1;
                int lastIndeOfCoordinates = result.IndexOf('>') - firstIndexOfCoordinates;

                string treasure = result.Substring(firstIndexOftreasure,lastIndexOfTreasure);
                string coordinates = result.Substring(firstIndexOfCoordinates, lastIndeOfCoordinates);

                Console.WriteLine($"Found {treasure} at {coordinates}");

                decryptedText = new StringBuilder();
                input = Console.ReadLine();
            }

            
        }
    }
}
