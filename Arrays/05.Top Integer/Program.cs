using System;
using System.Linq;

namespace _05.Top_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 0;
            string finalResult = "";

            for (int i = 0; i < Numbers.Length-1; i++)
            {
                for (int j = i+1; j < Numbers.Length; j++)
                {
                    if (Numbers[i] > Numbers[j])
                    {
                        counter++;
                    }
                }

                if (counter == Numbers.Length - (i+1) )
                {
                    finalResult += Numbers[i] + " ";
                }
                counter = 0;
            }

            finalResult += Numbers[Numbers.Length - 1];

            Console.WriteLine(finalResult);
        }
    }
}
