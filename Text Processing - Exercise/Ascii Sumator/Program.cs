using System;

namespace Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string randomText = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < randomText.Length; i++)
            {
                if (randomText[i] > firstChar && randomText[i] < secondChar)
                {
                    sum += randomText[i];
                }
            }

            Console.WriteLine(sum);

        }
    }
}
