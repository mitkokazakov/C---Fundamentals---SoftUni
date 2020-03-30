using System;
using System.Linq;
namespace _08.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < Numbers.Length; i++)
            {
                for (int j = i+1; j < Numbers.Length; j++)
                {
                    if (Numbers[i] + Numbers[j] == magicNumber)
                    {
                        Console.WriteLine(Numbers[i] + " " + Numbers[j]);
                    }
                }
            }
        }
    }
}
