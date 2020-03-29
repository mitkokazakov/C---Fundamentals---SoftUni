using System;

namespace _02.Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();

            foreach (string firstArrElements in firstArray)
            {
                foreach (string secondArrElements in secondArray)
                {
                    if (firstArrElements == secondArrElements)
                    {
                        Console.Write(firstArrElements + " ");
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
