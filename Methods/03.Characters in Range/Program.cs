using System;

namespace _03.Characters_in_Range
{
    class Program
    {

        static void PrintChars(int start, int end)
        {
            for (int i = start+1; i < end; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            int intStart = (int)start;
            int intEnd = (int)end;
            int first = 0;
            int second = 0;

            if (intStart < intEnd)
            {
                first = intStart;
                second = intEnd;
            }
            else if (start > end)
            {
                first = intEnd;
                second = intStart;
            }

            PrintChars(first,second);
        }
    }
}
