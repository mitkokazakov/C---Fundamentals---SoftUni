using System;
using System.Linq;

namespace _07.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 1;
            int maxCount = 0;
            int lastNum = 0;
            //int firstNum = 0;
            //int firstMaxCount = 0;

            for (int i = 0; i < Numbers.Length-1; i++)
            {
                if (Numbers[i] == Numbers[i+1])
                {
                    counter++;
                    if (counter > maxCount)
                    {
                        maxCount = counter;
                        lastNum = Numbers[i];


                    }
                }
                else
                {
                    

                    if (counter > maxCount)
                    {
                        maxCount = counter;
                        lastNum = Numbers[i];
                        
                        
                    }
                    counter = 1;
                }
            }

            if ( maxCount == 0)
            {
                for (int y = 0; y < counter; y++)
                {
                    Console.Write(Numbers[0] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int j = 0; j < maxCount; j++)
                {
                    Console.Write(lastNum + " ");
                }
                Console.WriteLine();
            }

            
        }
    }
}
