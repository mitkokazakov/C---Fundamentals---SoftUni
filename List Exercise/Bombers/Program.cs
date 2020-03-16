using System;
using System.Linq;
using System.Collections.Generic;

namespace Bombers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int[] bombInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int bomb = bombInfo[0];
            int power = bombInfo[1];

            

            while (numbers.Contains(bomb))
            {
                int indexOfBomb = numbers.IndexOf(bomb);
                int startIndex = indexOfBomb - power;
                int endIndex = indexOfBomb + power;

                CheckIfIndexesAreInBounds(numbers, ref startIndex, ref endIndex);

                Detonation(numbers, startIndex, endIndex);

            }

            Console.WriteLine(numbers.Sum());
            
        }

        private static void Detonation(List<int> numbers, int startIndex, int endIndex)
        {
            int rangeToRemove = endIndex - startIndex + 1;

            numbers.RemoveRange(startIndex, rangeToRemove);
        }

        private static void CheckIfIndexesAreInBounds(List<int> numbers, ref int startIndex, ref int endIndex)
        {
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            if (endIndex > numbers.Count - 1)
            {
                endIndex = numbers.Count - 1;
            }
        }
    }
}
