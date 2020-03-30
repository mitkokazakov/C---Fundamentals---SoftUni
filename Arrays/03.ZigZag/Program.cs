using System;
using System.Linq;
namespace _03.ZigZag
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            int[] firstArray = new int[lines];
            int[] secondArray = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                int[] currentLine = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                   firstArray[i] = currentLine[0];
                    secondArray[i] = currentLine[1];
                }
                else if (i % 2 != 0)
                {
                    firstArray[i] = currentLine[1];
                    secondArray[i] = currentLine[0];
                }
            }

            foreach (int firstArrNum in firstArray)
            {
                Console.Write(firstArrNum + " ");
            }

            Console.WriteLine();

            foreach (int secondArrNum in secondArray)
            {
                Console.Write(secondArrNum + " ");
            }

            Console.WriteLine();
        }
    }
}
