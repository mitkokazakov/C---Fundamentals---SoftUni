using System;
using System.Linq;

namespace _04.Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numOfRotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfRotations; i++)
            {
                int firstElement = Numbers[0];

                for (int j = 0; j < Numbers.Length - 1; j++)
                {
                    Numbers[j] = Numbers[j + 1];
                }

                Numbers[Numbers.Length-1] = firstElement;
            }

            Console.WriteLine(string.Join(" ", Numbers));
        }
    }
}
