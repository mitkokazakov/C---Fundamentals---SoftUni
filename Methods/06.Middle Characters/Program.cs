using System;

namespace _06.Middle_Characters
{
    class Program
    {
        static void PrintMidChar(string someString)
        {
            int lenght = someString.Length;

            if (lenght % 2 == 0)
            {
                Console.WriteLine($"{someString[(lenght / 2) - 1]}{someString[lenght / 2]}");
            }
            else
            {
                Console.WriteLine(someString[lenght/2]);
            }
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintMidChar(input);
        }
    }
}
